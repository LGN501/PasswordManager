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
    public partial class ConfirmAppPassword : Form
    {
        public bool isCorrect = false;
        private string passedPw;        

        public ConfirmAppPassword(string password = null)
        {
            InitializeComponent();
            
            passedPw = password;

            if (Login.firstStart)            
                operation_Label.Text = "Please confirm this is the password you want to use for the database.\nIt cannot be changed!";            
            else
                operation_Label.Text = "Please verify your identity. Enter the app password";

            //ok_Button.DialogResult = DialogResult.OK;
            //cancel_Button.DialogResult = DialogResult.Cancel;
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            if (Login.firstStart)
            {
                if (password_Textbox.Text.Length > 0 && password_Textbox.Text == passedPw)
                {
                    isCorrect = true;
                    Close();
                }
                else
                    MessageBox.Show("The passwords aren't the same!");
            }
            else
            {
                if (password_Textbox.Text.Length > 0 && password_Textbox.Text == Program.AppPw)
                {
                    isCorrect = true;
                    Close();
                }
                else
                    MessageBox.Show("Incorrect password! Try again");
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();            
        }
    }
}
