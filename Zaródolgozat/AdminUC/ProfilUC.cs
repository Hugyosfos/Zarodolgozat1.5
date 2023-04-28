using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace Zaródolgozat.AdminUC
{
    public partial class ProfilUC : UserControl
    {
        public static string server = "localhost";
        public static string database = "patika";
        public static string uid = "root";
        public static string dbpassword = "";
        public static string connectionString = $"server={server};user id={uid};password={dbpassword};database={database}";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlCommand comm = new MySqlCommand();
        string query;
        public ProfilUC()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { FelhaszNevLB.Text = value; }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String ID = FelhaszIDTB.Text;
            String szint = FelhaszSzintTB.Text;
            String nev = FelhaszNevLB.Text;
            String szul = FelhaszSzulTB.Text;
            Int64 tel = Int64.Parse(FelhaszTeleTB.Text);
            String email = FelhaszEmailTB.Text;
            String felhasznev = FelhaszNevTB.Text;
            String pass = FelhaszJelTB.Text;

            MessageBox.Show(nev.ToString());

            query = "UPDATE felhasz SET FelhasznaloRole = '" + szint + "', FelhasznaloUnev = '" + nev + "', FelhasznaloSzul = '" + szul + "', FelhasznaloTele = '" + tel + "', FelhasznaloEmail = '" + email + "', FelhasznaloPass = '" + pass + "' WHERE id = '" + FelhaszIDTB.Text + "'";

            comm.CommandText = query;
            comm.Connection = conn;
            int fasztudja = comm.ExecuteNonQuery();
            MessageBox.Show(fasztudja.ToString());

            conn.Close();
           

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfilUC_Load(object sender, EventArgs e)
        {

        }

        private void ProfilUC_Enter(object sender, EventArgs e)
        {
            query = "SELECT * FROM felhasz WHERE FelhasznaloNev = '" + FelhaszNevLB.Text + "'";
            comm.CommandText = query;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comm;
            adapter.SelectCommand.Connection = conn;
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            FelhaszIDTB.Text = dataset.Tables[0].Rows[0][0].ToString();
            FelhaszSzintTB.Text = dataset.Tables[0].Rows[0][1].ToString();
            FelhaszNevTB.Text = dataset.Tables[0].Rows[0][2].ToString();
            FelhaszSzulTB.Text = dataset.Tables[0].Rows[0][3].ToString();
            FelhaszTeleTB.Text = dataset.Tables[0].Rows[0][4].ToString();
            FelhaszEmailTB.Text = dataset.Tables[0].Rows[0][5].ToString();
            FelhaszJelTB.Text = dataset.Tables[0].Rows[0][7].ToString();
        }

        private void ResetGomb_Click(object sender, EventArgs e)
        {
            ProfilUC_Enter(this, null);
        }

        private void FelhaszIDTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
