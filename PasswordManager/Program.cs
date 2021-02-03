using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Data.SQLite;


namespace PasswordManager
{
    static class Program
    {
        private static SQLiteConnection sqlconn;
        private static string appPw;

        public static SQLiteConnection SqlConn { get => sqlconn; set => sqlconn = value; }
        public static string AppPw { get => appPw; set => appPw = value; }
        

        private static UserCredential credential = null;
        private static DriveService service = null;
        static bool driveEnabled = false;

        public static UserCredential Credential { get => credential; set => credential = value; }
        public static DriveService Service { get => service; set => service = value; }
        public static bool DriveEnabled { get => driveEnabled; set => driveEnabled = value; }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Login());
        }
    }
}
