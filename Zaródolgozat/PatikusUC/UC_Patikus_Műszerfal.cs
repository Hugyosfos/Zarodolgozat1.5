using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaródolgozat.PatikusUC
{
    public partial class UC_Patikus_Műszerfal : UserControl
    {
        public static string server = "localhost";
        public static string database = "patika";
        public static string uid = "root";
        public static string dbpassword = "";
        public static string connectionString = $"server={server};user id={uid};password={dbpassword};database={database}";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlCommand comm = new MySqlCommand();
        String query;
        DataSet ds;
        Int64 count;
        public UC_Patikus_Műszerfal()
        {
            InitializeComponent();
        }

        private void UC_Patikus_Műszerfal_Load(object sender, EventArgs e)
        {
            diagram();
        }

        public void diagram()
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            diagram();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
