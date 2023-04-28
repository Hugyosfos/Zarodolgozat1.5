using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaródolgozat.AdminUC
{
    public partial class FelhasznaloMegtekintesUC : UserControl
    {
        string query;
        string JelenFel = "";
        public static string server = "localhost";
        public static string database = "patika";
        public static string uid = "root";
        public static string dbpassword = "";
        public static string connectionString = $"server={server};user id={uid};password={dbpassword};database={database}";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlCommand comm = new MySqlCommand();
        
 
        public FelhasznaloMegtekintesUC()
        {
           
            InitializeComponent();
        }

        String felhasznev;

        public string ID
        {
            set { JelenFel = value; }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Biztos törölni kívája ezt a felhasználót?", "Error",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error)== DialogResult.Yes)
            {

                if (JelenFel != felhasznev)
                {
                    conn.Open();
                    query = "delete from felhasz where FelhasznaloUnev='" + felhasznev + "'";
                    comm.CommandText = query;
                    comm.ExecuteNonQuery();
                    FelhasznaloMegtekintesUC_Load(this, null);
                    MessageBox.Show("Törölte a felhasználót.");
                    conn.Close();

                }
                else
                {

                    MessageBox.Show("A jelenleg bejelentkeztetet felhasználót próbálja törölni.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FelhasznaloMegtekintesUC_Load(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            MySqlCommand localcomm = conn.CreateCommand();
            query = "select * from felhasz";
            localcomm.CommandText = query;
            MySqlDataReader dr = localcomm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("FelhasznaloRole", typeof(string));
            dt.Columns.Add("FelhasznaloNev", typeof(string));
            dt.Columns.Add("FelhasznaloSzul", typeof(string));
            dt.Columns.Add("FelhasznaloTele", typeof(string));
            dt.Columns.Add("FelhasznaloEmail", typeof(string));
            dt.Columns.Add("FelhasznaloUnev", typeof(string));
            dt.Columns.Add("FelhasznaloPass", typeof(string));
            while (dr.Read())
            {
                DataRow drow = dt.NewRow();
                drow["id"] = dr.GetInt32("id");
                drow["FelhasznaloRole"] = dr.GetString("FelhasznaloRole");
                drow["FelhasznaloNev"] = dr.GetString("FelhasznaloNev");
                drow["FelhasznaloSzul"] = dr.GetString("FelhasznaloSzul");
                drow["FelhasznaloTele"] = dr.GetString("FelhasznaloTele");
                drow["FelhasznaloEmail"] = dr.GetString("FelhasznaloEmail");
                drow["FelhasznaloUnev"] = dr.GetString("FelhasznaloUnev");
                drow["FelhasznaloPass"] = dr.GetString("FelhasznaloPass");
            }

            guna2DataGridView1.DataSource = dt;
            conn.Close();
        }

        private void FelNevKeres_TextChanged(object sender, EventArgs e)
        {
            query = "select * from felhasz where FelhasznaloNev like '" + FelNevKeres.Text + "%'";
            comm.CommandText = query;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comm;
            adapter.SelectCommand.Connection = conn;
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            

            guna2DataGridView1.DataSource = dataset.Tables[0];
        }

        
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                felhasznev = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

              
            }
        }

        private void Sync_Click(object sender, EventArgs e)
        {
            FelhasznaloMegtekintesUC_Load(this, null);
        }
    }

}
