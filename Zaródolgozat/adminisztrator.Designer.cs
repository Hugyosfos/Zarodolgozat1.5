namespace Zaródolgozat
{
    partial class adminisztrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Felhaszadd = new Guna.UI2.WinForms.Guna2Button();
            this.FelhasznaloNevLB = new System.Windows.Forms.Label();
            this.AdminKijelentkezes = new Guna.UI2.WinForms.Guna2Button();
            this.Profil = new Guna.UI2.WinForms.Guna2Button();
            this.FelhasznaloMegB = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.profilUC1 = new Zaródolgozat.AdminUC.ProfilUC();
            this.felhasznaloMegtekintesUC1 = new Zaródolgozat.AdminUC.FelhasznaloMegtekintesUC();
            this.felhasznaloAddUC1 = new Zaródolgozat.AdminUC.FelhasznaloAddUC();
            this.adminMT1 = new Zaródolgozat.AdminUC.AdminMT();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.Felhaszadd);
            this.panel1.Controls.Add(this.FelhasznaloNevLB);
            this.panel1.Controls.Add(this.AdminKijelentkezes);
            this.panel1.Controls.Add(this.Profil);
            this.panel1.Controls.Add(this.FelhasznaloMegB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 768);
            this.panel1.TabIndex = 0;
            // 
            // Felhaszadd
            // 
            this.Felhaszadd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Felhaszadd.CheckedState.FillColor = System.Drawing.Color.White;
            this.Felhaszadd.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.Felhaszadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Felhaszadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Felhaszadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Felhaszadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Felhaszadd.FillColor = System.Drawing.Color.DimGray;
            this.Felhaszadd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Felhaszadd.ForeColor = System.Drawing.Color.White;
            this.Felhaszadd.Image = global::Zaródolgozat.Properties.Resources.addUser;
            this.Felhaszadd.Location = new System.Drawing.Point(0, 426);
            this.Felhaszadd.Name = "Felhaszadd";
            this.Felhaszadd.Size = new System.Drawing.Size(275, 47);
            this.Felhaszadd.TabIndex = 3;
            this.Felhaszadd.Text = "Felhasználó hozzáadása";
            this.Felhaszadd.Click += new System.EventHandler(this.Felhaszadd_Click);
            // 
            // FelhasznaloNevLB
            // 
            this.FelhasznaloNevLB.AutoSize = true;
            this.FelhasznaloNevLB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhasznaloNevLB.ForeColor = System.Drawing.Color.White;
            this.FelhasznaloNevLB.Location = new System.Drawing.Point(108, 702);
            this.FelhasznaloNevLB.Name = "FelhasznaloNevLB";
            this.FelhasznaloNevLB.Size = new System.Drawing.Size(0, 23);
            this.FelhasznaloNevLB.TabIndex = 7;
            this.FelhasznaloNevLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // AdminKijelentkezes
            // 
            this.AdminKijelentkezes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AdminKijelentkezes.CheckedState.FillColor = System.Drawing.Color.White;
            this.AdminKijelentkezes.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.AdminKijelentkezes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AdminKijelentkezes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AdminKijelentkezes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AdminKijelentkezes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AdminKijelentkezes.FillColor = System.Drawing.Color.DimGray;
            this.AdminKijelentkezes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdminKijelentkezes.ForeColor = System.Drawing.Color.White;
            this.AdminKijelentkezes.Image = global::Zaródolgozat.Properties.Resources.logout;
            this.AdminKijelentkezes.Location = new System.Drawing.Point(0, 624);
            this.AdminKijelentkezes.Name = "AdminKijelentkezes";
            this.AdminKijelentkezes.Size = new System.Drawing.Size(275, 54);
            this.AdminKijelentkezes.TabIndex = 6;
            this.AdminKijelentkezes.Text = "Kijelentkezés";
            this.AdminKijelentkezes.Click += new System.EventHandler(this.AdminKijelentkezes_Click);
            // 
            // Profil
            // 
            this.Profil.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Profil.CheckedState.FillColor = System.Drawing.Color.White;
            this.Profil.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.Profil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Profil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Profil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Profil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Profil.FillColor = System.Drawing.Color.DimGray;
            this.Profil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Profil.ForeColor = System.Drawing.Color.White;
            this.Profil.Image = global::Zaródolgozat.Properties.Resources.customer_25px;
            this.Profil.Location = new System.Drawing.Point(0, 558);
            this.Profil.Name = "Profil";
            this.Profil.Size = new System.Drawing.Size(275, 51);
            this.Profil.TabIndex = 5;
            this.Profil.Text = "Profilom";
            this.Profil.Click += new System.EventHandler(this.Profil_Click);
            // 
            // FelhasznaloMegB
            // 
            this.FelhasznaloMegB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.FelhasznaloMegB.CheckedState.FillColor = System.Drawing.Color.White;
            this.FelhasznaloMegB.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.FelhasznaloMegB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FelhasznaloMegB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FelhasznaloMegB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FelhasznaloMegB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FelhasznaloMegB.FillColor = System.Drawing.Color.DimGray;
            this.FelhasznaloMegB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhasznaloMegB.ForeColor = System.Drawing.Color.White;
            this.FelhasznaloMegB.Image = global::Zaródolgozat.Properties.Resources.view_64px;
            this.FelhasznaloMegB.ImageOffset = new System.Drawing.Point(4, 0);
            this.FelhasznaloMegB.Location = new System.Drawing.Point(0, 492);
            this.FelhasznaloMegB.Name = "FelhasznaloMegB";
            this.FelhasznaloMegB.Size = new System.Drawing.Size(275, 49);
            this.FelhasznaloMegB.TabIndex = 4;
            this.FelhasznaloMegB.Text = "Felhasználó megtekíntése";
            this.FelhasznaloMegB.Click += new System.EventHandler(this.FelhasznaloMegB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zaródolgozat.Properties.Resources.admin3;
            this.pictureBox1.Location = new System.Drawing.Point(3, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.profilUC1);
            this.flowLayoutPanel1.Controls.Add(this.felhasznaloMegtekintesUC1);
            this.flowLayoutPanel1.Controls.Add(this.felhasznaloAddUC1);
            this.flowLayoutPanel1.Controls.Add(this.adminMT1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(281, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1089, 767);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // profilUC1
            // 
            this.profilUC1.BackColor = System.Drawing.Color.White;
            this.profilUC1.Location = new System.Drawing.Point(3, 3);
            this.profilUC1.Name = "profilUC1";
            this.profilUC1.Size = new System.Drawing.Size(1104, 770);
            this.profilUC1.TabIndex = 3;
            // 
            // felhasznaloMegtekintesUC1
            // 
            this.felhasznaloMegtekintesUC1.Location = new System.Drawing.Point(3, 779);
            this.felhasznaloMegtekintesUC1.Name = "felhasznaloMegtekintesUC1";
            this.felhasznaloMegtekintesUC1.Size = new System.Drawing.Size(1104, 770);
            this.felhasznaloMegtekintesUC1.TabIndex = 2;
            this.felhasznaloMegtekintesUC1.Load += new System.EventHandler(this.felhasznaloMegtekintesUC1_Load);
            // 
            // felhasznaloAddUC1
            // 
            this.felhasznaloAddUC1.BackColor = System.Drawing.Color.White;
            this.felhasznaloAddUC1.Location = new System.Drawing.Point(3, 1555);
            this.felhasznaloAddUC1.Name = "felhasznaloAddUC1";
            this.felhasznaloAddUC1.Size = new System.Drawing.Size(1104, 770);
            this.felhasznaloAddUC1.TabIndex = 1;
            this.felhasznaloAddUC1.Load += new System.EventHandler(this.felhasznaloAddUC1_Load_1);
            // 
            // adminMT1
            // 
            this.adminMT1.BackColor = System.Drawing.Color.White;
            this.adminMT1.Location = new System.Drawing.Point(3, 2331);
            this.adminMT1.Name = "adminMT1";
            this.adminMT1.Size = new System.Drawing.Size(1111, 770);
            this.adminMT1.TabIndex = 0;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.Felhaszadd;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.Profil;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.felhasznaloMegtekintesUC1;
            // 
            // adminisztrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminisztrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminisztrator";
            this.Load += new System.EventHandler(this.adminisztrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button AdminKijelentkezes;
        private Guna.UI2.WinForms.Guna2Button Profil;
        private Guna.UI2.WinForms.Guna2Button FelhasznaloMegB;
        private Guna.UI2.WinForms.Guna2Button Felhaszadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FelhasznaloNevLB;
        private AdminUC.AdminMT adminMT1;
        private AdminUC.FelhasznaloAddUC felhasznaloAddUC1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AdminUC.FelhasznaloMegtekintesUC felhasznaloMegtekintesUC1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AdminUC.ProfilUC profilUC1;
    }
}