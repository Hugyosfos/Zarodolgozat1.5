using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaródolgozat
{
    public partial class Patikus : Form
    {
        public Patikus()
        {
            InitializeComponent();
        }


        private void KijelentkezesGB_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void MűszerfalGB_Click(object sender, EventArgs e)
        {
            uC_Patikus_Műszerfal1.Visible = true;
            uC_Patikus_Műszerfal1.BringToFront();
        }

        private void Patikus_Load(object sender, EventArgs e)
        {
            uC_Patikus_Műszerfal1.Visible = false;
            MűszerfalGB.PerformClick();

        }

        private void GyogyszeraddGB_Click(object sender, EventArgs e)
        {
            uC_Patikus_Gyógyszeradd1.Visible = true;
            uC_Patikus_Gyógyszeradd1.BringToFront();

        }

        private void uC_Patikus_Műszerfal1_Load(object sender, EventArgs e)
        {

        }

        private void GyogyszerMegTGB_Click(object sender, EventArgs e)
        {
            uC_Patikus_Gyogyszermegtekintes1.Visible = true;
            uC_Patikus_Gyogyszermegtekintes1.BringToFront();
        }

        private void GyógyszerModGB_Click(object sender, EventArgs e)
        {
            uC_Patikus_GyogyszerUpdate1.Visible = true;
            uC_Patikus_GyogyszerUpdate1.BringToFront();

        }

        private void gyogyValGB_Click(object sender, EventArgs e)
        {
            uC_PatikusGyógyszerValiditása1.Visible = true;
            uC_PatikusGyógyszerValiditása1.BringToFront();
        }

        private void GyogyszerEladasGB_Click(object sender, EventArgs e)
        {
            uC_Patikus_GyogyszerEladas1.Visible = true;
            uC_Patikus_GyogyszerEladas1.BringToFront();
        }
    }
}
