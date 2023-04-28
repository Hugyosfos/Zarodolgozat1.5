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
using System.Xml.Linq;

namespace Zaródolgozat.AdminUC
{
    public partial class FelhasznaloAddUC : UserControl
    {

        MySqlConnection connection;
        string server = "localhost";
        string database = "patika";
        string uid = "root";
        string dbpassword = "";
        public FelhasznaloAddUC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FelhasznaloAddUC_Load(object sender, EventArgs e)
        {
            
        }
        private void FelhasznaloRegUC_Click(object sender, EventArgs e)
        {
            string authenticationLevel = FelhasznaloRoleUC.SelectedItem.ToString();
            string name = FelhasznaloNevUC.Text;
            string dateOfBirth = FelhasznaloSzulUC.Value.ToString("yyyy-MM-dd");
            string mobileNumber = FelhasznaloTeleUC.Text;
            string email = FelhasznaloEmailUC.Text;
            string username = FelhasznaloUnevUC.Text;
            string password = FelhasznaloPassUC.Text;

            string connectionString = $"Server={server};Database={database};Uid={uid};Pwd={dbpassword};";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = $"INSERT INTO felhasz(FelhasznaloRole, FelhasznaloNev, FelhasznaloSzul, FelhasznaloTele, FelhasznaloEmail, FelhasznaloUnev, FelhasznaloPass) VALUES ('{authenticationLevel}', '{name}', '{dateOfBirth}', '{mobileNumber}', '{email}', '{username}', '{password}')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Felhasználó regisztrálás sikeres");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }

        private void FelhasznaloRoleUC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
