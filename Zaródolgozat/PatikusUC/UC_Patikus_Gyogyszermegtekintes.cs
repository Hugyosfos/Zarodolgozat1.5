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
    public partial class UC_Patikus_Gyogyszermegtekintes : UserControl
    {
        String query;
        public static string server = "localhost";
        public static string database = "patika";
        public static string uid = "root";
        public static string dbpassword = "";
        public static string connectionString = $"server={server};user id={uid};password={dbpassword};database={database}";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlCommand comm = new MySqlCommand();
        public UC_Patikus_Gyogyszermegtekintes()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void UC_Patikus_Gyogyszermegtekintes_Load(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            MySqlCommand localcomm = conn.CreateCommand();
            query = "select * from gyogyszer";
            localcomm.CommandText = query;
            MySqlDataReader dr = localcomm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("gyogyszerID", typeof(string));
            dt.Columns.Add("gyogyszerNev", typeof(string));
            dt.Columns.Add("gyogyszerSzam", typeof(string));
            dt.Columns.Add("gyogyszerKesz", typeof(string));
            dt.Columns.Add("gyogyszerLejarat", typeof(string));
            dt.Columns.Add("gyogyszerMenny", typeof(int));
            dt.Columns.Add("gyogyszerArperDB", typeof(int));
            while (dr.Read())
            {
                DataRow drow = dt.NewRow();
                drow["id"] = dr.GetInt32("id");
                drow["gyogyszerID"] = dr.GetString("gyogyszerID");
                drow["gyogyszerNev"] = dr.GetString("gyogyszerNev");
                drow["gyogyszerSzam"] = dr.GetString("gyogyszerSzam");
                drow["gyogyszerKesz"] = dr.GetString("gyogyszerKesz");
                drow["gyogyszerLejarat"] = dr.GetString("gyogyszerLejarat");
                drow["gyogyszerMenny"] = dr.GetInt32("gyogyszerMenny");
                drow["gyogyszerArperDB"] = dr.GetInt32("gyogyszerArperDB");

            }

            guna2DataGridView1.DataSource = dt;
   
            conn.Close();

        }

        private void KeresesTB_TextChanged(object sender, EventArgs e)
        {
            query = "select * from gyogyszer where gyogyszerNev like '"+KeresesTB.Text+"%'";
            comm.CommandText = query;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comm;
            adapter.SelectCommand.Connection = conn;
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);


            guna2DataGridView1.DataSource = dataset.Tables[0];
        }

        String gyogyszerid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                gyogyszerid = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void TörlésGB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztos a törlésben?","Várakozás a törlés megerősítésére",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)                                               
            {
                conn.Open();
                query = "delete from gyogyszer where id = '" + gyogyszerid + "'";
                comm.CommandText = query;
                comm.ExecuteNonQuery();
                UC_Patikus_Gyogyszermegtekintes_Load(this, null);
                MessageBox.Show("Törölte a gyógyszert.");
                conn.Close();

            }
            else
            {

                MessageBox.Show("Ezt a gyógyszert nem tudja törölni.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Sync_Click(object sender, EventArgs e)
        {
            UC_Patikus_Gyogyszermegtekintes_Load(this,null);
        }
    }
}
