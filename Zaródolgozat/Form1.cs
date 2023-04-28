using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Zaródolgozat.AdminUC;
using System.Threading;

namespace Zaródolgozat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Kilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            FelhasznaloNev.Clear();
            FelhasznaloJel.Clear();
        }

        private void Bejelentkezes_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Program.conn;
            try
            {
                conn.Open();
                string query = "SELECT * FROM felhasz WHERE FelhasznaloUnev=@username AND FelhasznaloPass=@password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", FelhasznaloNev.Text);
                cmd.Parameters.AddWithValue("@password", FelhasznaloJel.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string authenticationLevel = reader.GetString("FelhasznaloRole");
                        if (authenticationLevel == "Adminisztrátor")
                        {
                            this.Hide();
                            adminisztrator form1 = new adminisztrator(FelhasznaloNev.Text);
                            form1.Show();
                        }
                        else if (authenticationLevel == "Patikus")
                        {
                            this.Hide();
                            Patikus form2 = new Patikus();
                            form2.Show();

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a bejelentkezés során: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
