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
    public partial class UC_Patikus_Gyógyszeradd : UserControl
    {
        public static string server = "localhost";
        public static string database = "patika";
        public static string uid = "root";
        public static string dbpassword = "";
        public static string connectionString = $"server={server};user id={uid};password={dbpassword};database={database}";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlCommand comm = new MySqlCommand();
        String query;
        public UC_Patikus_Gyógyszeradd()
        {
            InitializeComponent();
        }

        private void gyogyszerAddGB_Click(object sender, EventArgs e)
        {
            if (gyogyszerIDTB.Text != "" && gyogyszerNevTB.Text != "" && gyogyszerSzamTB.Text != "" && gyogyszerMennyTB.Text != "" && gyogyszerarperTB.Text != "")
            {
                String gyogyid = gyogyszerIDTB.Text;
                String gyogynev = gyogyszerNevTB.Text;
                String gyogyszam = gyogyszerSzamTB.Text;
                String gyogykesz = gyogyszerGyartTB.Value.ToString("yyyy-MM-dd");
                String gyogyle = gyogyszerExpTB.Value.ToString("yyyy-MM-dd");
                Int64 gyogymenny = Int64.Parse(gyogyszerMennyTB.Text);
                Int64 gyogyper = Int64.Parse(gyogyszerarperTB.Text);

                query = "INSERT INTO gyogyszer (gyogyszerID, gyogyszerNev, gyogyszerSzam, gyogyszerKesz, gyogyszerLejarat, gyogyszerMenny, gyogyszerArperDB) VALUES ('"+gyogyid+"','"+gyogynev+"','"+gyogyszam+"','"+gyogykesz+"','"+gyogyle+"','"+gyogymenny+"','"+gyogyper+"')";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Az adatok mentése sikeres volt", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Az adatok mentése sikertelen volt: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Írjon be minden adatot","Információ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            
        }

        private void adatresetGB_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        { 
            gyogyszerIDTB.Clear();
            gyogyszerNevTB.Clear();
            gyogyszerSzamTB.Clear();
            gyogyszerGyartTB.ResetText();
            gyogyszerExpTB.ResetText();
            gyogyszerMennyTB.Clear();
            gyogyszerarperTB.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            adminisztrator form1 = new adminisztrator();
            form1.Hide();
        }

        private void gyogyszerGyartTB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_Patikus_Gyógyszeradd_Load(object sender, EventArgs e)
        {

        }
    }
}
