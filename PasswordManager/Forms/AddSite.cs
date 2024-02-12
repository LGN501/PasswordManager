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

namespace PasswordManager.Forms
{
    public partial class AddSite : Form
    {


        public AddSite()
        {
            InitializeComponent();
        }
       
        private void AddSite_Label_Click(object sender, EventArgs e)
        {
            if (siteName_Textbox.Text.Length > 0)
            {
                Classes.Site.Insert(siteName_Textbox.Text);
                Close();
            }                          
            else            
                MessageBox.Show("Error: Site's name must be at least 1 character long.");
            
        }
    }
}
