using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace PasswordManager.Classes
{
    public class User
    {
        #region PARAMETERS
        private int id;
        private int siteid;
        private string username;
        private string password;

        public int ID { get => id; set => id = value; }
        public int SITEID { get => siteid; set => siteid = value; }
        public string USERNAME { get => username; set => username = value; }
        public string PASSWORD { get => password; set => password = value; }
        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datarow">DataRow from where the data'll be extracted</param>
        public User(DataRow datarow)
        {
            id = int.Parse(datarow["id"].ToString());
            siteid = int.Parse(datarow["site"].ToString());
            username = datarow["username"].ToString();
            password = datarow["password"].ToString();
        }
        #endregion

        #region GETS

        /// <summary>
        /// Gets a single user by it's ID
        /// </summary>
        /// <param name="sqlConn">SQLiteConnection</param>
        /// <param name="userId">User ID</param>
        /// <returns>Returns a User object filled with it's data</returns>
        public static User Get_ById(int userId)
        {
            string command = "SELECT * FROM Users WHERE id = " + userId;

            SQLiteDataAdapter db = new SQLiteDataAdapter(command, Utils.SqlConn);
            DataSet ds = new DataSet();
            db.Fill(ds);            

            return (ds != null && ds.Tables[0].Rows.Count > 0) ? (new User(ds.Tables[0].Rows[0])) : (null);
        }

        /// <summary>
        /// Searchs for each user associated with a certain site
        /// </summary>
        /// <param name="connection">SQLite connection</param>
        /// <param name="siteId">Site id</param>
        /// <returns>Returns a user list filled with users that are associated with passed site</returns>
        public static List<User> Get_BySite(int siteId)
        {
            string command = "SELECT * FROM Users WHERE site = " + siteId;

            List<User> list = new List<User>();

            SQLiteDataAdapter db = new SQLiteDataAdapter(command, Utils.SqlConn);
            DataSet ds = new DataSet();
            db.Fill(ds);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow datarow in ds.Tables[0].Rows)
                    list.Add(new User(datarow));
            }           
            return list;
        }

        #endregion

        #region UPDATES

        /// <summary>
        /// Modifies the password of an user
        /// </summary>
        /// <param name="sqlConn">SQLite Connection</param>
        /// <param name="userId">User id</param>
        /// <param name="newPw">New password to be stored</param>
        /// <returns>Returns the number of rows modified</returns>
        public static int UpdatePw(
            int userId,
            string newPw)
        {
            string command = "UPDATE Users SET password = '" + newPw + "' WHERE id = " + userId;

            Utils.SqlConn.Open();

            SQLiteCommand sqlCommand = Utils.SqlConn.CreateCommand();
            sqlCommand.CommandText = command;
            int result = sqlCommand.ExecuteNonQuery();
            Utils.SqlConn.Close();

            return result;
        }

        #endregion

        #region DELETES

        /// <summary>
        /// Deletes an user from the DB
        /// </summary>        
        /// <param name="userId">User id</param>
        /// <returns>Returns true if the user has been deleted</returns>
        public static bool Delete_ById(int userId)
        {
            string command = "DELETE FROM Users WHERE id = " + userId;

            Utils.SqlConn.Open();

            SQLiteCommand sqlCommand = Utils.SqlConn.CreateCommand();
            sqlCommand.CommandText = command;
            int result = sqlCommand.ExecuteNonQuery();

            Utils.SqlConn.Close();

            return result == 1 ? true : false;
        }

        public bool Delete()
        {
            return Delete_ById(id);
        }

        #endregion

        #region INSERTS

        /// <summary>
        /// Inserts a new user into the DB
        /// </summary>
        /// <param name="siteId">Site where the user is registered</param>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>Returns true if the user was created, false otherwise</returns>
        public static bool Insert(
            int siteId,
            string username,
            string password)
        {
            string command = "INSERT INTO Users (site, username, password) values (" + siteId + ", '" + username + "', '" + password + "');";
            int result;

            Utils.SqlConn.Open();

            SQLiteCommand sqlCommand = Utils.SqlConn.CreateCommand();
            sqlCommand.CommandText = command;
            result = sqlCommand.ExecuteNonQuery();
            Utils.SqlConn.Close();

            return result == 1 ? true : false;
        }

        #endregion

    }
}
