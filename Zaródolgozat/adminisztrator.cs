using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zaródolgozat.AdminUC;

namespace Zaródolgozat
{
    public partial class adminisztrator : Form
    {
        String user = "";
        public adminisztrator()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return user.ToString(); }
        }

        public adminisztrator(String username)
        {
            InitializeComponent();
            FelhasznaloNevLB.Text = username;
            user = username;
            felhasznaloMegtekintesUC1.ID = ID;
            profilUC1.ID = ID;
        }


        private void AdminKijelentkezes_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();

        }

        private void adminMT1_Load(object sender, EventArgs e)
        {

        }

        private void iranyitopult_Click(object sender, EventArgs e)
        {
            adminMT1.BringToFront();
            profilUC1.SendToBack();
            felhasznaloAddUC1.SendToBack();
            felhasznaloMegtekintesUC1.SendToBack();


        }

        private void adminisztrator_Load(object sender, EventArgs e)
        {
            
            

        }

        private void Felhaszadd_Click(object sender, EventArgs e)
        {
           
            adminMT1.SendToBack();
            profilUC1.SendToBack();
            felhasznaloMegtekintesUC1.SendToBack();
            felhasznaloAddUC1.BringToFront();

        }

        private void felhasznaloAddUC1_Load(object sender, EventArgs e)
        {
            
        }

        private void felhasznaloAddUC1_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FelhasznaloMegB_Click(object sender, EventArgs e)
        {
            felhasznaloAddUC1.SendToBack();
            adminMT1.SendToBack();
            profilUC1.SendToBack();
            felhasznaloMegtekintesUC1.BringToFront();

        }

        private void felhasznaloMegtekintesUC1_Load(object sender, EventArgs e)
        {

        }

        private void Profil_Click(object sender, EventArgs e)
        {
            profilUC1.BringToFront();
            felhasznaloAddUC1.SendToBack();
            adminMT1.SendToBack();
            felhasznaloMegtekintesUC1.SendToBack();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
