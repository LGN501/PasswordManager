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
    public partial class SetPassword : Form
    {        
        private bool firstStart = true;
        private string password;

        public string Password { get => password; set => password = value; }

        /// <summary>
        /// Used to set the form if it's the first time the app is launched.
        /// </summary>
        /// <param name="firstStart">Is this the first time the app is launched?</param>
        public SetPassword(bool _firstStart)
        {            
            InitializeComponent();            
            firstStart = _firstStart;
            
            if (firstStart)
            {               
                generateRndPw_Button.Visible = false;
                generateRndPw_Button.Enabled = false;
            }
            else
            {
                generateRndPw_Button.Visible = true;
                generateRndPw_Button.Enabled = true;                
            }
            
        }

        private void SetPw_Button_Click(object sender, EventArgs e)
        {            
            string newPw = newPw_Textbox.Text;
            string newPwRep = newPwRep_Textbox.Text;

            bool error = false;

            // Just verifies length
            if (firstStart)
            {
                if (newPw.Length < 8 || newPwRep.Length < 8)
                {
                    error = true;
                    MessageBox.Show("The password doesn't fulfill the requeriments.", "Password error", MessageBoxButtons.OK);
                }
            }                
            // Full mode verification
            else
            {
                if (!Utils.VerifyPassword(newPw) || !Utils.VerifyPassword(newPwRep))
                {
                    error = true;
                    MessageBox.Show("The password doesn't fulfill the requeriments.", "Password error", MessageBoxButtons.OK);
                }
            }
                
            // Verifies matching
            if (newPw != newPwRep)
            {
                error = true;
                MessageBox.Show("The passwords don't match.", "Password error", MessageBoxButtons.OK);
            }

            // There was no errors in passwords
            if (!error)
            {
                if (!firstStart)
                {
                    ConfirmPassword confirmPwForm = new ConfirmPassword(false, null);

                    confirmPwForm.FormClosed += delegate
                    {
                        if (confirmPwForm.correctPw && confirmPwForm.DialogResult == DialogResult.OK)
                        {
                            Password = newPw;
                            Close();
                        }

                    };

                    confirmPwForm.ShowDialog();
                } 
                else
                {
                    ConfirmPassword confirmPwForm = new ConfirmPassword(true, newPw);

                    confirmPwForm.FormClosed += delegate
                    {
                        if (confirmPwForm.correctPw && confirmPwForm.DialogResult == DialogResult.OK)
                        {
                            Password = newPw;
                            Close();
                        }

                    };

                    confirmPwForm.Show();
                }
            }
        }

        private void GenerateRndPw_Button_Click(object sender, EventArgs e)
        {
            string pw = Utils.GenerateRandomPassword();

            newPwRep_Textbox.Text = pw;
            newPw_Textbox.Text = pw;
        }

        private void Password_Textbox_MouseHover(object sender, EventArgs e)
        {
            string helpStr;

            if (firstStart)            
                helpStr = "The password must have:\nAt least 8 characters.";
            
            else
            {
                helpStr = "The password must have:\nAt least 8 characters.\nAt least 1 up case character.\n" +
                             "At least 1 number.\nAt least 1 special character\n(<>/*-+_@&$#%).\n";
            }           

            ToolTip toolTip = new ToolTip();

            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 100;

            toolTip.SetToolTip(newPw_Textbox, helpStr);
            toolTip.SetToolTip(newPwRep_Textbox, helpStr);
        }
    }
}
