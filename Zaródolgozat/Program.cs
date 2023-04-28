using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaródolgozat
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]


        public static string server = "localhost";
        public static string database = "patika";
        public static string uid = "root";
        public static string dbpassword = "";
        public static string connectionString = $"server={server};user id={uid};password={dbpassword};database={database}";
        public static MySqlConnection conn = new MySqlConnection(connectionString);


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }


    }
}
