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
        private string password;
        public string Password { get => password; set => password = value; }        

        public SetPassword()
        {            
            InitializeComponent();

            generateRndPw_Button.Visible = !Login.firstStart;
            generateRndPw_Button.Enabled = !Login.firstStart;            
        }

        private void SetPw_Button_Click(object sender, EventArgs e)
        {            
            string newPass = newPw_Textbox.Text;
            string newPassRepeated = newPwRep_Textbox.Text;

            bool error = false;

            // Verifies password format
            if (!Utils.VerifyPassword(newPass, Login.firstStart) ||
                !Utils.VerifyPassword(newPassRepeated, Login.firstStart))
            {
                error = true;
                MessageBox.Show("The password doesn't fulfill the requeriments.", "Password error", MessageBoxButtons.OK);
            }                
            // Verifies matching
            if (newPass != newPassRepeated)
            {
                error = true;
                MessageBox.Show("The passwords don't match.", "Password error", MessageBoxButtons.OK);
            }

            // There was no errors in passwords
            if (!error)
            {
                if (Login.firstStart)
                {
                    ConfirmAppPassword confirmPwForm = new ConfirmAppPassword(newPass);
                    confirmPwForm.FormClosed += delegate
                    {
                        if (confirmPwForm.isCorrect)
                        {
                            Password = newPass;
                            Close();
                        }

                    };

                    confirmPwForm.ShowDialog();
                }
                else
                {
                    ConfirmAppPassword confirmPwForm = new ConfirmAppPassword(null);

                    confirmPwForm.FormClosed += delegate
                    {
                        if (confirmPwForm.isCorrect)
                        {
                            Password = newPass;
                            Close();
                        }
                    };

                    confirmPwForm.ShowDialog();
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

            if (Login.firstStart)            
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
