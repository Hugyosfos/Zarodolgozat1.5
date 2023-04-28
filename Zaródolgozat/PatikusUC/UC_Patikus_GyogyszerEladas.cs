using DGVPrinterHelper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaródolgozat.PatikusUC
{
    public partial class UC_Patikus_GyogyszerEladas : UserControl
    {
        public static string server = "localhost";
        public static string database = "patika";
        public static string uid = "root";
        public static string dbpassword = "";
        public static string connectionString = $"server={server};user id={uid};password={dbpassword};database={database}";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlCommand comm = new MySqlCommand();
        String query;
        public UC_Patikus_GyogyszerEladas()
        {
            InitializeComponent();
        }

        private void UC_Patikus_GyogyszerEladas_Load(object sender, EventArgs e)
        {
            GyogyszerListB.Items.Clear();
            query = "select gyogyszerNev from gyogyszer where gyogyszerLejarat >= CURDATE() and gyogyszerMenny >'0'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataSet dataset = new DataSet();
            DataSet ds = new DataSet();
            adapter.Fill(dataset, "gyogyszer");

            for (int i = 0; i < dataset.Tables[0].Rows.Count;i++)
            {
                GyogyszerListB.Items.Add(dataset.Tables[0].Rows[i][0].ToString());
            }
        }

        private void SyncGB_Click(object sender, EventArgs e)
        {
            UC_Patikus_GyogyszerEladas_Load(this, null);
        }

        private void TXTkereses_TextChanged(object sender, EventArgs e)
        {
            GyogyszerListB.Items.Clear();
            query = "select * from gyogyszer where gyogyszerNev like '%" +TXTkereses+ "%' and gyogyszerLejarat >= CURDATE() and gyogyszerMenny >'0'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataSet dataset = new DataSet();
            DataSet ds = new DataSet();
            adapter.Fill(dataset, "gyogyszer");

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                GyogyszerListB.Items.Add(dataset.Tables[0].Rows[i][0].ToString());
                MessageBox.Show(dataset.Tables[0].Rows[i][0].ToString());
            }
        }

        private void GyogyszerListB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GyogyszerListB.SelectedIndex == -1)
            {
                return;
            }
            gyogyszermennyisegtxt.Clear();

            String nev = GyogyszerListB.GetItemText(GyogyszerListB.SelectedItem);

            gyogyszerNevtxt.Text = nev;
            query = "select gyogyszerID, gyogyszerLejarat, gyogyszerMenny, gyogyszerArperDB from gyogyszer where gyogyszerNev LIKE'%" + nev + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataSet dataset = new DataSet();
            DataSet ds = new DataSet();
            adapter.Fill(dataset, "gyogyszer");

            gyogyszerIDtxt.Text = dataset.Tables[0].Rows[0][0].ToString();
            gyogyszerardbtxt.Text = dataset.Tables[0].Rows[0][3].ToString();
        }

        private void gyogyszermennyisegtxt_TextChanged(object sender, EventArgs e)
        {
            if (gyogyszermennyisegtxt.Text != "")
            {
                Int64 gyogyszerunit = Convert.ToInt64(gyogyszerardbtxt.Text);
                Int64 unit = Convert.ToInt64(gyogyszermennyisegtxt.Text);
                Int64 teljesm = gyogyszerunit * unit;
                gyogyszerteljesosszeg.Text = teljesm.ToString();
            }
            else
            {
                gyogyszerteljesosszeg.Clear();
            }
        }

        protected int n, teljesmeny = 0;
        protected Int64 mennyiseg, ujmenny;


        private void KosarGB_Click(object sender, EventArgs e)
        {
            if (gyogyszerIDtxt.Text != "")
            {
                query = "select gyogyszerMenny from gyogyszer where gyogyszerID ='" + gyogyszerIDtxt.Text + "' ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "gyogyszer");


                mennyiseg = Convert.ToInt64(dataset.Tables[0].Rows[0][0].ToString());
                ujmenny = mennyiseg - Convert.ToInt64(gyogyszermennyisegtxt.Text);

                if (ujmenny >= 0)
                {
                    guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = gyogyszerIDtxt.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = gyogyszerNevtxt.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = gyogyszerlejaratdtp.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = gyogyszerardbtxt.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = gyogyszermennyisegtxt.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = gyogyszerteljesosszeg.Text;
                    n++;

                    teljesmeny = teljesmeny + int.Parse(gyogyszerteljesosszeg.Text);
                    totalprice.Text = "Ft." + teljesmeny.ToString();

                    query = "update gyogyszer set gyogyszerMenny = '" + ujmenny + "' where gyogyszerID = '" + gyogyszerIDtxt + "'";
                    MySqlDataAdapter adapt = new MySqlDataAdapter(query, conn);
                    DataSet datas = new DataSet();
                    adapter.Fill(dataset, "gyogyszer");
                    DataSet dts = new DataSet();
                    MessageBox.Show("Gyógyszer hozzáadva.");
                }
                else
                {
                    MessageBox.Show("Nincs raktáron. \n Csak " + mennyiseg + " van.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ClearAll();
                UC_Patikus_GyogyszerEladas_Load(this, null);
            }
            else
            {
                MessageBox.Show("Válasszon ki egy gyógyszert előszőr!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int valMenny;
        String valID;
        protected Int64 NOU;


        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.RowIndex == 0)
            {
                return;
            }
            try
            {
                valMenny = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valID = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                NOU = Convert.ToInt64(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

            }
            catch (Exception)
            {
            }
  

        }


        private void TorlesGB_Click(object sender, EventArgs e)
        {
            
            if (NOU != null)
            {
                try
                {
                    query = "select gyogyszerMenny from gyogyszer where gyogyszerID ='" + NOU + "'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset, "gyogyszer");
                    mennyiseg = Convert.ToInt64(dataset.Tables[0].Rows[0][0].ToString());

                    ujmenny = mennyiseg + teljesmeny;

                    query = "update gyogyszer set gyogyszerMenny = '" + ujmenny + "' where gyogyszerID = '" + valID + "'";
                    MySqlDataAdapter adapt = new MySqlDataAdapter(query, conn);
                    DataSet datas = new DataSet();
                    adapter.Fill(dataset, "gyogyszer");
                    DataSet das = new DataSet();
                    MessageBox.Show("Gyógyszer Eltávolítva a kosárból.");
                    teljesmeny = teljesmeny - valMenny;
                    totalprice.Text = "Ft." + teljesmeny.ToString();
                }
                catch (Exception)
                {

                   
                }
                finally
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.CurrentCell.RowIndex);
                }
                UC_Patikus_GyogyszerEladas_Load(this, null);
            }
        }

        private void gyogyszerardbtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void VasperNyomGB_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Gyógyszer számla";
            print.SubTitle = String.Format("Date:- {0}",DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Teljes fizetendő összeg :" + totalprice.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            teljesmeny = 0;
            totalprice.Text = "Ft. 00";
            guna2DataGridView1.DataSource = 0;

        }

        private void ClearAll()
        {
            gyogyszerIDtxt.Clear();
            gyogyszerNevtxt.Clear();
            gyogyszerlejaratdtp.ResetText();
            gyogyszerardbtxt.Clear();
            gyogyszermennyisegtxt.Clear();
        }
    }
}
