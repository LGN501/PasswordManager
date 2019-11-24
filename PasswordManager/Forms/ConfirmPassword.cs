using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class ConfirmPassword : Form
    {
        public bool correctPw = false;
        private string passedPw;
        private bool firstStart;

        public ConfirmPassword(bool firststart, string password)
        {
            InitializeComponent();

            firstStart = firststart;
            passedPw = password;

            if (firstStart)            
                operation_Label.Text = "Please confirm this is the password you want to use for the database.\nIt cannot be changed!";            
            else
                operation_Label.Text = "Please verify your identity. Enter the app password";

            ok_Button.DialogResult = DialogResult.OK;
            cancel_Button.DialogResult = DialogResult.Cancel;
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            if (!firstStart)
            {
                if (password_Textbox.Text.Length > 0 && password_Textbox.Text == Classes.Utils.AppPw)
                {
                    correctPw = true;
                    Close();
                }
                else
                    MessageBox.Show("Incorrect password! Try again");
            }
            else
            {
                if (password_Textbox.Text.Length > 0 && password_Textbox.Text == passedPw)
                {
                    correctPw = true;
                    Close();
                }
                else
                    MessageBox.Show("The passwords aren't the same!");

            }
                            
            
            
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
