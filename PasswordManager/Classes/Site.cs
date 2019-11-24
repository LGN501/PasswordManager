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
    public class Site
    {
        #region PARAMETERS
        private int id;
        private string name;
        private List<User> users;


        public string NAME { get => name; set => name = value; }
        public List<User> USERS { get => users; set => users = value; }
        public int ID { get => id; set => id = value; }
        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn">SQLConnection of the DB</param>
        /// <param name="datarow">DataRow from where the data'll be extracted</param>
        public Site(DataRow datarow)
        {
            id = int.Parse(datarow["id"].ToString());
            name = datarow["name"].ToString();
            users = User.Get_BySite(id);
        }

        #endregion

        #region GETS

        /// <summary>
        /// Gets all the sites in the DB
        /// </summary>
        /// <param name="connection">SQLConnection of the DB</param>
        /// <returns>A DataTable filled with sites</returns>
        public static List<Site> GetAll()
        {
            string command = "SELECT * FROM Sites;";

            Utils.SqlConn.Open();

            List<Site> list = new List<Site>();

            SQLiteDataAdapter db = new SQLiteDataAdapter(command, Utils.SqlConn);
            DataSet ds = new DataSet();
            db.Fill(ds);

            if (ds != null ||ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow datarow in ds.Tables[0].Rows)
                    list.Add(new Site(datarow));
            }

            Utils.SqlConn.Close();
            return list;
        }

        /// <summary>
        /// Gets a site from the DB by its id
        /// </summary>
        /// <param name="siteId">Site id</param>
        /// <returns>Returns a Site object</returns>
        public static Site Get_ById(int siteId)
        {
            string command = "SELECT * FROM Sites WHERE id = " + siteId;

            Utils.SqlConn.Open();            

            SQLiteDataAdapter db = new SQLiteDataAdapter(command, Utils.SqlConn);
            DataSet ds = new DataSet();
            db.Fill(ds);

            Utils.SqlConn.Close();
            return (ds != null && ds.Tables[0].Rows.Count > 0) ? (new Site(ds.Tables[0].Rows[0])) : (null);
        }

        #endregion       

        #region INSERTS

        /// <summary>
        /// Inserts a site into the DB
        /// </summary>
        /// <param name="siteName">Name of the site</param>
        /// <returns>Returns true if the user has been inserte, false otherwise</returns>
        public static bool Insert(string siteName)
        {
            string command = "INSERT INTO Sites (name) values ('" + siteName + "');";
            int result;

            Utils.SqlConn.Open();

            SQLiteCommand sqlCommand = Utils.SqlConn.CreateCommand();
            sqlCommand.CommandText = command;
            result = sqlCommand.ExecuteNonQuery();
            Utils.SqlConn.Close();

            return result == 1 ? true : false;
        }

        #endregion

        #region DELETES

        /// <summary>
        /// Deletes a site by its id. Therefore, the users associated with the site are removed
        /// </summary>
        /// <param name="siteId">Site id</param>
        /// <returns>Returns true if the site was removed, false otherwise</returns>
        public static bool Delete_ById(int siteId)
        {
            Site site = Get_ById(siteId);

            string command = "DELETE FROM Sites WHERE id = " + siteId;
                       
            Utils.SqlConn.Open();

            SQLiteCommand sqlCommand = Utils.SqlConn.CreateCommand();
            sqlCommand.CommandText = command;
            int result = sqlCommand.ExecuteNonQuery();
            
            Utils.SqlConn.Close();

            if (site != null && site.USERS.Count > 0)
            {
                foreach (User usr in site.USERS)
                    usr.Delete();
            }

            return result == 1 ? true : false;
        }

        #endregion

    }
}
