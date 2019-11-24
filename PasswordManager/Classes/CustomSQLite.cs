using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;

namespace PasswordManager.Classes
{
    public class CustomSQLite
    {

        /// <summary>
        /// Creates new DataBase
        /// </summary>
        /// <param name="dbPw">Database password</param>
        public static void CreateNewDB(string dbPw)
        {
            // Creates the DB
            SQLiteConnection.CreateFile("passwords.sqlite");

            SQLiteConnection conn = new SQLiteConnection("Data Source=passwords.sqlite;Version=3;");
            conn.SetPassword(dbPw);
            
            conn.Open();

            // Creates necessary tables
            string query =  "CREATE TABLE Users (id INTEGER PRIMARY KEY, site INTEGER, username VARCHAR(50), password VARCHAR(50));\n" +
                            "CREATE TABLE Sites (id INTEGER PRIMARY KEY, name VARCHAR(50));";

            // Excutes the query
            SQLiteCommand command = new SQLiteCommand(query, conn);
            command.ExecuteNonQuery();

            // Closes the connection for safety reasons
            conn.Close();
        }

        /// <summary>
        /// Connects to existent DataBase
        /// </summary>
        /// <param name="dbPw">Password of the databse</param>
        /// <returns>If the connection was succesfull, returns the connection object, otherwise returns null.</returns>
        public static SQLiteConnection ConnectToDB(string dbPw)
        {      
            // Tries to connect to the DB using the passed password.
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=passwords.sqlite;Version=3;Password=" + dbPw + ";");                
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand("PRAGMA encoding;", conn))
                {
                    var ret = command.ExecuteScalar();
                }
                conn.Close();

                // If the connection was successful, the password's stored
                Utils.AppPw = dbPw;

                return conn;
            }
            // If there's an exception the password was wrong.
            catch (SQLiteException)
            {
                System.Windows.Forms.MessageBox.Show("Incorrect password!");
                return null;
            }            
        }

    }
}
