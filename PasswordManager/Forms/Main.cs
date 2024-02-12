using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using PasswordManager.Classes;
using GoogleAPI = PasswordManager.Classes.CustomGoogleDriveAPI;

namespace PasswordManager.Forms
{
    public partial class Main : Form
    {        
        private SQLiteConnection sqlConn;
        private User user;

        public User User { get => user; set => user = value; }
        public SQLiteConnection SqlConn { get => sqlConn; set => sqlConn = value; }

        public Main()
        {            
            InitializeComponent();            

            // Fills the treeview with actual sites and users
            Utils.SitesFillList(site_TreeView, true);                       
        }

        private void AddSite_Button_Click(object sender, EventArgs e)
        {
            AddSite addSiteForm = new AddSite();
          
            addSiteForm.FormClosed += delegate
            {
                Utils.SitesFillList(site_TreeView, true);
            };

            addSiteForm.ShowDialog();            
        }

        void OptionGroupBoxUpdate(bool userSelected)
        {
            deleteSite_Button.Enabled = !userSelected; deleteSite_Button.Visible = !userSelected;
            addUser_Button.Enabled = !userSelected; addUser_Button.Visible = !userSelected;

            changePw_Button.Enabled = userSelected; changePw_Button.Visible = userSelected;
            changeUsr_Button.Enabled = userSelected; changeUsr_Button.Visible = userSelected;
            copyPw_Button.Enabled = userSelected; copyPw_Button.Visible = userSelected;
            showPw_Button.Enabled = userSelected; showPw_Button.Visible = userSelected;
            deleteUsr_Button.Enabled = userSelected; deleteUsr_Button.Visible = userSelected;
        }

        private void Site_TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            options_GroupBox.Tag = e.Node.Tag;

            // When a user's being selected, updates the user section on the right
            if (e.Node.Level == 1)
            {
                // User selected
                options_GroupBox.Text = "Selected user: " + e.Node.Text;

                OptionGroupBoxUpdate(true);
            }            
            else
            {
                // Site selected
                options_GroupBox.Text = "Selected site: " + e.Node.Text;

                OptionGroupBoxUpdate(false);
            }
        }

        private void ChangePw_Button_Click(object sender, EventArgs e)
        {
            SetPassword setPw = new SetPassword();

            setPw.FormClosed += delegate
            {
                if (setPw.Password != null)
                {
                    User.UpdatePw(int.Parse(options_GroupBox.Tag.ToString()), setPw.Password);
                    Utils.SitesFillList(site_TreeView, true);
                    site_TreeView.SelectedNode = site_TreeView.Nodes[0];
                }                
            };

            setPw.ShowDialog();
        }

        private void AddUser_Button_Click(object sender, EventArgs e)
        {
            if (site_TreeView.Nodes.Count == 0)
                MessageBox.Show("There aren't any sites added yet, please add one before adding new users.", "There are no sites", MessageBoxButtons.OK);

            else
            {
                AddUser addUserForm = new AddUser(int.Parse(options_GroupBox.Tag.ToString()));

                addUserForm.FormClosed += delegate
                {
                    Utils.SitesFillList(site_TreeView, true);
                };

                addUserForm.ShowDialog();
            }
        }

        private void ShowPw_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(User.Get_ById(int.Parse(options_GroupBox.Tag.ToString())).PASSWORD, "Showing password", MessageBoxButtons.OK);
        }

        private void CopyPw_Button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(User.Get_ById(int.Parse(options_GroupBox.Tag.ToString())).PASSWORD);
            MessageBox.Show("Password copied to clipboard!", "Password copied", MessageBoxButtons.OK);
        }        

        private void GeneratePw_Button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Utils.GenerateRandomPassword());
            MessageBox.Show("Password copied to clipboard!", "Password copied", MessageBoxButtons.OK);
        }

        #region Delete

        private void DeleteSite_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "You are going to delete \"" + options_GroupBox.Text.Substring("Selected site: ".Length, options_GroupBox.Text.Length - "Selected site: ".Length) + "\" and all of its users associated.\nAre you sure?",
                "Delete site",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConfirmAppPassword confirmPwForm = new ConfirmAppPassword();

                confirmPwForm.FormClosed += delegate
                {
                    if (confirmPwForm.isCorrect)
                    {                        
                        Classes.Site.Delete_ById(int.Parse(options_GroupBox.Tag.ToString()));
                        deleteSite_Button.Enabled = false;
                        addUser_Button.Enabled = false;
                        Utils.SitesFillList(site_TreeView, true);
                    }

                };

                confirmPwForm.ShowDialog();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "You are going to delete \"" + options_GroupBox.Text.Substring("Selected user: ".Length) + "\" and all of its data.\nAre you sure?",
                "Delete user",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConfirmAppPassword confirmPwForm = new ConfirmAppPassword();

                confirmPwForm.FormClosed += delegate
                {
                    if (confirmPwForm.isCorrect)
                    {
                        User.Delete_ById(int.Parse(options_GroupBox.Tag.ToString()));
                        Utils.SitesFillList(site_TreeView, true);
                    }

                };

                confirmPwForm.ShowDialog();
            }
        }


        #endregion

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Utils.SitesFillList(site_TreeView, true);
            Utils.SitesFillList(Application.OpenForms["Main"].Controls.Find("site_TreeView", true)[0], true);
        }        

        private void AutoUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.Credential == null || Program.Service == null)
            {
                Program.Credential = GoogleAPI.GetCredential();
                Program.Service = GoogleAPI.GetDriveService(Program.Credential);
            }

            GoogleAPI.AutoUpdate(Program.Service, "./passwords.sqlite");
        }

        private void UploadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Program.Credential == null || Program.Service == null)
            {
                Program.Credential = GoogleAPI.GetCredential();
                Program.Service = GoogleAPI.GetDriveService(Program.Credential);
            }
            GoogleAPI.UploadFile(Program.Service, "./passwords.sqlite");
        }

        private void DownloadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Program.Credential == null || Program.Service == null)
            {
                Program.Credential = GoogleAPI.GetCredential();
                Program.Service = GoogleAPI.GetDriveService(Program.Credential);
            }
            GoogleAPI.DownloadFile(Program.Service, "./passwords.sqlite");
        }

    }
}