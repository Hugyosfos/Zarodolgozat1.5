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
    public partial class UC_PatikusGyógyszerValiditása : UserControl
    {
        public static string server = "localhost";
        public static string database = "patika";
        public static string uid = "root";
        public static string dbpassword = "";
        public static string connectionString = $"server={server};user id={uid};password={dbpassword};database={database}";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlCommand comm = new MySqlCommand();
        String query;
        public UC_PatikusGyógyszerValiditása()
        {
            InitializeComponent();
        }

        private void ValidaloTXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ValidaloTXT.SelectedIndex == 0)
            {
                query = "select * from gyogyszer where gyogyszerLejarat >= CURDATE()";
                setDataGridView(query, "Valid gyógyszerek:", Color.Black);
            }
            else if(ValidaloTXT.SelectedIndex == 1)
            {
                query = "select * from gyogyszer where gyogyszerLejarat < CURDATE()";
                setDataGridView(query, "Lejárt gyógyszerek:", Color.Red);

            }
            else if(ValidaloTXT.SelectedIndex == 2)
            {
                query = "select * from gyogyszer";
                setDataGridView(query, "", Color.Black);
            }
        }

        private void setDataGridView(String query,String labelName,Color col)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "gyogyszer");
            guna2DataGridView1.DataSource = dataset.Tables[0];
            elerhetolabel.Text = labelName;
            elerhetolabel.ForeColor = col;

        }
        private void UC_PatikusGyógyszerValiditása_Load(object sender, EventArgs e)
        {

        }
    }
}
