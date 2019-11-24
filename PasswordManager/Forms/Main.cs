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

        private void Site_TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // When a user's being selected, updates the user section on the right
            if (e.Node.Level == 1)
            {
                user_GroupBox.Enabled = true;
                user_GroupBox.Text = e.Node.Text;
                user_GroupBox.Tag = e.Node.Tag;

                selectedSite_Label.Text = "Select a site to start";
                selectedSite_Label.Tag = -1;
                deleteSite_Button.Enabled = false;
            }            
            else
            {
                selectedSite_Label.Text = "Selected site: " + e.Node.Text;
                selectedSite_Label.Tag = e.Node.Tag;
                deleteSite_Button.Enabled = true;

                user_GroupBox.Enabled = false;
                user_GroupBox.Text = "Select an user to start";
                user_GroupBox.Tag = -1;

            }
        }

        private void ChangePw_Button_Click(object sender, EventArgs e)
        {
            SetPassword setPw = new SetPassword(false);

            setPw.FormClosed += delegate
            {
                if (setPw.Password != null)
                {
                    User.UpdatePw(int.Parse(user_GroupBox.Tag.ToString()), setPw.Password);
                    Utils.SitesFillList(site_TreeView, true);
                    site_TreeView.SelectedNode = site_TreeView.Nodes[0];
                }                
            };

            setPw.ShowDialog();
        }

        private void ShowPw_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(User.Get_ById(int.Parse(user_GroupBox.Tag.ToString())).PASSWORD, "Showing password", MessageBoxButtons.OK);
        }

        private void CopyPw_Button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(User.Get_ById(int.Parse(user_GroupBox.Tag.ToString())).PASSWORD);
            MessageBox.Show("Password copied to clipboard!", "Password copied", MessageBoxButtons.OK);
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {           
            if (MessageBox.Show(
                "You are going to delete " + user_GroupBox.Text + " and all of its data.\nAre you sure?",
                "Delete user",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Microsoft.VisualBasic.Interaction.InputBox("Please enter app password", "Deleting user", "****") == Utils.AppPw)
                {
                    User.Delete_ById(int.Parse(user_GroupBox.Tag.ToString()));
                    Utils.SitesFillList(site_TreeView, true);
                    user_GroupBox.Enabled = false;
                }
                else
                    MessageBox.Show("Incorrec password!", "Password error", MessageBoxButtons.OK);
            }                       
        }

        private void AddUser_Button_Click(object sender, EventArgs e)
        {
            if (site_TreeView.Nodes.Count == 0)            
                MessageBox.Show("There aren't any sites added yet, please add one before adding new users.", "There are no sites", MessageBoxButtons.OK);
            
            else
            {
                AddUser addUserForm = new AddUser();

                addUserForm.FormClosed += delegate
                {
                    Utils.SitesFillList(site_TreeView, true);
                };

                addUserForm.ShowDialog();
            }            
        }

        private void GeneratePw_Button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Utils.GenerateRandomPassword());
            MessageBox.Show("Password copied to clipboard!", "Password copied", MessageBoxButtons.OK);
        }

        private void DeleteSite_Button_Click(object sender, EventArgs e)
        {
            if (site_TreeView.Nodes.Count == 0)
                MessageBox.Show("There are no sites to be deleted! Pleasde add one before trying to delete one.", "There are no sites", MessageBoxButtons.OK);

            else
            {
                if (MessageBox.Show(
                "You are going to delete " + selectedSite_Label.Text.Substring("Selected site: ".Length, selectedSite_Label.Text.Length - "Selected site: ".Length) + " and all of its users associated.\nAre you sure?",
                "Delete site",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Microsoft.VisualBasic.Interaction.InputBox("Please enter app password", "Deleting site", "****") == Utils.AppPw)
                    {
                        Classes.Site.Delete_ById(int.Parse(selectedSite_Label.Tag.ToString()));
                        Utils.SitesFillList(site_TreeView, true);
                        user_GroupBox.Enabled = false;
                    }
                    else
                        MessageBox.Show("Incorrect password!", "Password error", MessageBoxButtons.OK);
                }
            }
            
        }

    }
}
