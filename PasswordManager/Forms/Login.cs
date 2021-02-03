using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data.SQLite;
using PasswordManager.Classes;
using GoogleAPI = PasswordManager.Classes.CustomGoogleDriveAPI;

namespace PasswordManager.Forms
{
    public partial class Login : Form
    {
        public static bool firstStart = true;
        public static bool loggedIn = false;

        public Login()
        {
            InitializeComponent();

            // Verifies if the DB exists
            if (File.Exists(Environment.CurrentDirectory + "\\passwords.sqlite"))
            {
                firstStart = false;
                // Proceeds as normal.
                start_Label.Visible = false;
                login_Button.Text = "Login";
                loginPw_Textbox.Visible = true;

                downloadCloud_Button.Enabled = false; downloadCloud_Button.Visible = false;
            }
            else
            {
                // Creates the DB
                start_Label.Visible = true;
                login_Button.Text = "Create new database";
                loginPw_Textbox.Visible = false;

                downloadCloud_Button.Enabled = true; downloadCloud_Button.Visible = true;
            }
        }

        //// ESTO DEBE SER CAMBIADO. CUANDO CIERRO LA PANTALLA DE LOGIN SE CIERRA TODO EL PROGRAMA.
        protected override void OnClosing(CancelEventArgs e)
        {
            if (!loggedIn)
                Environment.Exit(1);
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            // Shows SetPassword form to create de DB or to log into the program            
            SQLiteConnection conn = null;

            if (firstStart)
            {
                // Must create the DB

                // Opens Set Password to set a new password to the DB
                SetPassword setPwForm = new SetPassword();

                // Once the password was chosen and the form closed
                setPwForm.FormClosed += delegate
                {
                    if (setPwForm.Password != null)
                    {
                        CustomSQLite.CreateNewDB(setPwForm.Password);

                        if ((conn = CustomSQLite.ConnectToDB(setPwForm.Password)) != null)        
                            // Stores the chosen password
                            Program.AppPw = setPwForm.Password;                        
                    }
                };

                setPwForm.ShowDialog();
                //Hide();

                //new Login().ShowDialog();

                Application.Restart();
            }
            else
            {
                // The DB is already created, so we try to connect to it
                if (loginPw_Textbox.Text != null)
                {
                    if ((conn = CustomSQLite.ConnectToDB(loginPw_Textbox.Text)) != null)
                    {
                        loggedIn = true;
                        Program.AppPw = loginPw_Textbox.Text;
                        // The user has logged into the program
                        Program.SqlConn = conn;
                        Main mainForm = new Main();

                        mainForm.FormClosing += delegate
                        {
                            Environment.Exit(0);
                        };
                        mainForm.Show();
                        Hide();
                    }
                        
                    
                }
            }            
        }

        private void DownloadCloud_Button_Click(object sender, EventArgs e)
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
