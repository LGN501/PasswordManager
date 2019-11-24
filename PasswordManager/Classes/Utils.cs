using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PasswordManager.Classes
{
    public static class Utils
    {

        private static SQLiteConnection sqlconn;
        private static string appPw;

        public static SQLiteConnection SqlConn { get => sqlconn; set => sqlconn = value; }
        public static string AppPw { get => appPw; set => appPw = value; }

        public enum Action { Insert, Update, Select, Delete }

        /// <summary>
        /// Verifies the password's format
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool VerifyPassword(string password)
        {
            string specialChars = @"([<>/\*-+_@&$#%])+";
            // Creates Regex for special chars.
            System.Text.RegularExpressions.Regex rg = new System.Text.RegularExpressions.Regex(specialChars);

            return (password.Length < 8 ||             // Checks length
                !password.Any(char.IsLetter) ||    // Checks if has at least one letter
                !password.Any(char.IsDigit) ||     // Checks if has at least one digit
                !password.Any(char.IsUpper) ||     // Checks if has at least one upper letter
                !rg.IsMatch(password))             // Checks if has at least one special char
                ? (false) : true;
        }

        /// <summary>
        /// Fills the passed object with the sites
        /// </summary>
        /// <param name="listObj">Windows Forms object to be filled</param>
        public static void SitesFillList(object listObj, bool addUsers)
        {
            List<Site> sitesList = Site.GetAll();

            if (listObj.GetType() == typeof(TreeView))
            {
                TreeView treeView = listObj as TreeView;

                treeView.BeginUpdate();

                // Cleans the treeview
                treeView.Nodes.Clear();                

                int i = 0;
                foreach (Site site in sitesList)
                {
                    
                    treeView.Nodes.Add(site.NAME);
                    treeView.Nodes[i].Tag = site.ID;

                    if (addUsers)
                    {
                        int j = 0;
                        foreach (User user in site.USERS)
                        {
                            treeView.Nodes[i].Nodes.Add(user.USERNAME);
                            treeView.Nodes[i].Nodes[j].Tag = user.ID;

                            j++;
                        }
                    }
                    
                    i++;
                }

                treeView.EndUpdate();
            }

        }

        /// <summary>
        /// Generates a random password (15 chars)
        /// </summary>
        /// <returns>String of the password</returns>
        public static string GenerateRandomPassword()
        {
            Guid guid = Guid.NewGuid();
            string pw = guid.ToString().Substring(0, 13);
            string specialChars = "<>/*-+_@&$#%";            
           
            Random rnd = new Random(); 
            
            pw = pw.Insert(3, "A");
            pw = pw.Insert(9, "b");

            for (int i = 0; i < pw.Length; i++)
            {
                if (pw[i] == '-')
                {
                    pw = pw.Remove(i, 1);                    
                    pw = pw.Insert(i, specialChars[rnd.Next(0, specialChars.Length)].ToString());
                }
            }            

            return pw;
        }
    }
}
