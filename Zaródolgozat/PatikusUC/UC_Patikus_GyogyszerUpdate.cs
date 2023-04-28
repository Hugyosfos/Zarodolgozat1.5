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
    public partial class UC_Patikus_GyogyszerUpdate : UserControl
    {
        public static string server = "localhost";
        public static string database = "patika";
        public static string uid = "root";
        public static string dbpassword = "";
        public static string connectionString = $"server={server};user id={uid};password={dbpassword};database={database}";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlCommand comm = new MySqlCommand();
        String query;
        public UC_Patikus_GyogyszerUpdate()
        {
            InitializeComponent();
        }

        private void UC_Patikus_GyogyszerUpdate_Load(object sender, EventArgs e)
        {

        }

        private void KeresesGB_Click(object sender, EventArgs e)
        {
            if (GyogyszerID.Text != "")
            {
                query ="select * from gyogyszer where gyogyszerID ='" + GyogyszerID.Text + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "gyogyszer");
                if(dataset.Tables[0].Rows.Count != 0) 
                {
                    GyogyszerNev.Text = dataset.Tables[0].Rows[0][2].ToString();
                    GyogyszerSzama.Text = dataset.Tables[0].Rows[0][3].ToString();
                    GyogyszerDatum.Text = dataset.Tables[0].Rows[0][4].ToString();
                    GyogyszerExpire.Text = dataset.Tables[0].Rows[0][5].ToString();
                    GyogyszerMennyi.Text = dataset.Tables[0].Rows[0][6].ToString();
                    gyogyszerardb.Text = dataset.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("Nincs ilyen gyógyszer ezzek az ID-vel : '" + GyogyszerID.Text + "'","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            else
            {
                ClearAll();
            }
        }

        private void ClearAll()
        {
            GyogyszerID.Clear();
            GyogyszerNev.Clear();
            GyogyszerSzama.Clear();
            GyogyszerDatum.ResetText();
            GyogyszerExpire.ResetText();
            GyogyszerMennyi.Clear();
            gyogyszerardb.Clear();
            if(GyogyszerHozzaad.Text != "0")
            {
                GyogyszerHozzaad.Text = "0";
            }
            else
            {
                GyogyszerHozzaad.Text = "0";
            }


        }

        private void ResetGB_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        Int64 FullMenny;
        private void FrissitGB_Click(object sender, EventArgs e)
        {
            String gyogynev = GyogyszerNev.Text;
            String gyogyszam = GyogyszerSzama.Text;
            String gyogykesz = GyogyszerDatum.Text;
            String gyogyle = GyogyszerExpire.Text;
            Int64 gyogymenny = Int64.Parse(GyogyszerMennyi.Text);
            var gyogyhozzaadas = Int64.Parse(GyogyszerHozzaad.Text);
            Int64 gyogyper = Int64.Parse(gyogyszerardb.Text);

            FullMenny = gyogymenny + gyogyhozzaadas;

            query = "UPDATE gyogyszer SET gyogyszerNev = '" +gyogynev + "', gyogyszerSzam ='" + gyogyszam + "', gyogyszerKesz = '" + gyogykesz + "',gyogyszerLejarat = '" + gyogyle + "',gyogyszerMenny = '" + FullMenny + "',gyogyszerArperDB = '" + gyogyper + "' WHERE gyogyszerID ='" + GyogyszerID.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "gyogyszer");
            MessageBox.Show("Gyógyszer adatai frissítve.");
            GyogyszerHozzaad.Text = "";
            KeresesGB.PerformClick();
        }

        private void GyogyszerHozzaad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
