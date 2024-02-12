using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace PasswordManager.Classes
{
    public static class Utils
    {
        public enum Action { Insert, Update, Select, Delete }

        /// <summary>
        /// Verifies the password's format
        /// </summary>
        /// <param name="password">Password to be checked</param>
        /// <param name="verifyLengthOnly">Should the function verify the length only?</param>
        /// <returns>True if the password fulfill the requeriments, false otherwise</returns>
        public static bool VerifyPassword(string password, bool verifyLengthOnly = true)
        {
            string specialChars = @"([<>/\*-+_@&$#%])+";
            // Creates Regex for special chars.
            System.Text.RegularExpressions.Regex rg = new System.Text.RegularExpressions.Regex(specialChars);

            if (verifyLengthOnly)
                return !(password.Length < 8);
            else
            {
                return (password.Length < 8 ||             // Checks length
                !password.Any(char.IsLetter) ||    // Checks if has at least one letter
                !password.Any(char.IsDigit) ||     // Checks if has at least one digit
                !password.Any(char.IsUpper) ||     // Checks if has at least one upper letter
                !rg.IsMatch(password))             // Checks if has at least one special char
                ? (false) : true;
            }            
        }

        /// <summary>
        /// Fills the passed object with the sites
        /// </summary>
        /// <param name="listObj">Windows Forms object to be filled</param>
        public static void SitesFillList(Control listObj, bool addUsers)
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


        public static string GetMimeType(string filePath)
        {
            string mimeType = "application/unknown";
            string ext = Path.GetExtension(filePath).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null)
                mimeType = regKey.GetValue("Content Type").ToString();
            System.Diagnostics.Debug.WriteLine(mimeType);
            return mimeType;
        }

        // Deprecated
        public static FileStream WaitForFile(string filePath)
        {
            // If the file can be opened for exclusive access it means that the file
            // is no longer locked by another process.
            bool isFree = false;
            do
            {
                try
                {
                    using (FileStream inputStream = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                        isFree = true;
                }
                catch (Exception)
                {
                    isFree = false;
                }
            }
            while (!isFree);

            return File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write);

        }
    }
}
