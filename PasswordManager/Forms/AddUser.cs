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
    public partial class AddUser : Form
    {        
        int siteId;

        public AddUser(int _siteId)
        {
            InitializeComponent();

            siteId = _siteId;            
        }

        private void AddUser_Button_Click(object sender, EventArgs e)
        {
            string username = username_TextBox.Text;
            string password = password_TextBox.Text;            

            if (siteId < 0)
                MessageBox.Show("A site must be selected before proceeding", "Site error", MessageBoxButtons.OK);
            else if (username.Length == 0 || password.Length == 0)
                MessageBox.Show("Password and username must be at least 1 character long.",
                               "Password and username format", MessageBoxButtons.OK);
            else if (username == "Username")
                MessageBox.Show("Username not allowed, please enter another username.", "Username not allowed", MessageBoxButtons.OK);
            else if (password == "Password")
                MessageBox.Show("Password not allowed, please enter another password.", "Password not allowed", MessageBoxButtons.OK);
            else
            {
                Classes.User.Insert(siteId, username, password);
                Close();
            }
        }

        #region Textbox focus

        private void username_TextBox_GotFocus(Object sender, EventArgs e)
        {
            if (username_TextBox.Text == "Username")
                username_TextBox.Text = "";
        }
        private void username_TextBox_LostFocus(Object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username_TextBox.Text))
                username_TextBox.Text = "Username";
        }

        private void password_TextBox_GotFocus(Object sender, EventArgs e)
        {
            if (password_TextBox.Text == "Password")
                password_TextBox.Text = "";
        }
        private void password_TextBox_LostFocus(Object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password_TextBox.Text))
                password_TextBox.Text = "Password";
        }

        #endregion

        private void GenerateRndPw_Button_Click(object sender, EventArgs e)
        {
            password_TextBox.Text = Classes.Utils.GenerateRandomPassword();
        }

        private void password_Textbox_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();

            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 100;

            toolTip.SetToolTip(password_TextBox, "The password must have:\nAt least 8 characters.\nAt least 1 up case character.\n" +
                                                "At least 1 number.\nAt least 1 special character\n(<>/*-+_@&$#%).\n");
        }
    }
}
