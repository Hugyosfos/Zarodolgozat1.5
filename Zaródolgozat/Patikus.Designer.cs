namespace Zaródolgozat
{
    partial class Patikus
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
            this.KijelentkezesGB = new Guna.UI2.WinForms.Guna2Button();
            this.GyogyszerEladasGB = new Guna.UI2.WinForms.Guna2Button();
            this.gyogyValGB = new Guna.UI2.WinForms.Guna2Button();
            this.GyógyszerModGB = new Guna.UI2.WinForms.Guna2Button();
            this.GyogyszerMegTGB = new Guna.UI2.WinForms.Guna2Button();
            this.GyogyszeraddGB = new Guna.UI2.WinForms.Guna2Button();
            this.MűszerfalGB = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fopanel = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_PatikusGyógyszerValiditása1 = new Zaródolgozat.PatikusUC.UC_PatikusGyógyszerValiditása();
            this.uC_Patikus_GyogyszerUpdate1 = new Zaródolgozat.PatikusUC.UC_Patikus_GyogyszerUpdate();
            this.uC_Patikus_Gyogyszermegtekintes1 = new Zaródolgozat.PatikusUC.UC_Patikus_Gyogyszermegtekintes();
            this.uC_Patikus_Gyógyszeradd1 = new Zaródolgozat.PatikusUC.UC_Patikus_Gyógyszeradd();
            this.uC_Patikus_Műszerfal1 = new Zaródolgozat.PatikusUC.UC_Patikus_Műszerfal();
            this.uC_Patikus_GyogyszerEladas1 = new Zaródolgozat.PatikusUC.UC_Patikus_GyogyszerEladas();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.fopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.KijelentkezesGB);
            this.panel1.Controls.Add(this.GyogyszerEladasGB);
            this.panel1.Controls.Add(this.gyogyValGB);
            this.panel1.Controls.Add(this.GyógyszerModGB);
            this.panel1.Controls.Add(this.GyogyszerMegTGB);
            this.panel1.Controls.Add(this.GyogyszeraddGB);
            this.panel1.Controls.Add(this.MűszerfalGB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 785);
            this.panel1.TabIndex = 0;
            // 
            // KijelentkezesGB
            // 
            this.KijelentkezesGB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.KijelentkezesGB.CheckedState.FillColor = System.Drawing.Color.White;
            this.KijelentkezesGB.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.KijelentkezesGB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.KijelentkezesGB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.KijelentkezesGB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.KijelentkezesGB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.KijelentkezesGB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.KijelentkezesGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KijelentkezesGB.ForeColor = System.Drawing.Color.White;
            this.KijelentkezesGB.Image = global::Zaródolgozat.Properties.Resources.logout;
            this.KijelentkezesGB.ImageSize = new System.Drawing.Size(30, 30);
            this.KijelentkezesGB.Location = new System.Drawing.Point(0, 636);
            this.KijelentkezesGB.Name = "KijelentkezesGB";
            this.KijelentkezesGB.Size = new System.Drawing.Size(270, 45);
            this.KijelentkezesGB.TabIndex = 10;
            this.KijelentkezesGB.Text = "Kijelentkezés";
            this.KijelentkezesGB.Click += new System.EventHandler(this.KijelentkezesGB_Click);
            // 
            // GyogyszerEladasGB
            // 
            this.GyogyszerEladasGB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GyogyszerEladasGB.CheckedState.FillColor = System.Drawing.Color.White;
            this.GyogyszerEladasGB.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.GyogyszerEladasGB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GyogyszerEladasGB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GyogyszerEladasGB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GyogyszerEladasGB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GyogyszerEladasGB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.GyogyszerEladasGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GyogyszerEladasGB.ForeColor = System.Drawing.Color.White;
            this.GyogyszerEladasGB.Image = global::Zaródolgozat.Properties.Resources.sellMedicine_64px;
            this.GyogyszerEladasGB.ImageSize = new System.Drawing.Size(30, 30);
            this.GyogyszerEladasGB.Location = new System.Drawing.Point(0, 574);
            this.GyogyszerEladasGB.Name = "GyogyszerEladasGB";
            this.GyogyszerEladasGB.Size = new System.Drawing.Size(270, 45);
            this.GyogyszerEladasGB.TabIndex = 9;
            this.GyogyszerEladasGB.Text = "Gyógyszer eleadása";
            this.GyogyszerEladasGB.Click += new System.EventHandler(this.GyogyszerEladasGB_Click);
            // 
            // gyogyValGB
            // 
            this.gyogyValGB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gyogyValGB.CheckedState.FillColor = System.Drawing.Color.White;
            this.gyogyValGB.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.gyogyValGB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gyogyValGB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gyogyValGB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gyogyValGB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gyogyValGB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.gyogyValGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gyogyValGB.ForeColor = System.Drawing.Color.White;
            this.gyogyValGB.Image = global::Zaródolgozat.Properties.Resources.MedicineValidation_40px;
            this.gyogyValGB.ImageSize = new System.Drawing.Size(30, 30);
            this.gyogyValGB.Location = new System.Drawing.Point(0, 514);
            this.gyogyValGB.Name = "gyogyValGB";
            this.gyogyValGB.Size = new System.Drawing.Size(270, 45);
            this.gyogyValGB.TabIndex = 8;
            this.gyogyValGB.Text = "Gyógyszer Validitása";
            this.gyogyValGB.Click += new System.EventHandler(this.gyogyValGB_Click);
            // 
            // GyógyszerModGB
            // 
            this.GyógyszerModGB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GyógyszerModGB.CheckedState.FillColor = System.Drawing.Color.White;
            this.GyógyszerModGB.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.GyógyszerModGB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GyógyszerModGB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GyógyszerModGB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GyógyszerModGB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GyógyszerModGB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.GyógyszerModGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GyógyszerModGB.ForeColor = System.Drawing.Color.White;
            this.GyógyszerModGB.Image = global::Zaródolgozat.Properties.Resources.modifyMedicine_32px;
            this.GyógyszerModGB.ImageSize = new System.Drawing.Size(30, 30);
            this.GyógyszerModGB.Location = new System.Drawing.Point(0, 454);
            this.GyógyszerModGB.Name = "GyógyszerModGB";
            this.GyógyszerModGB.Size = new System.Drawing.Size(270, 45);
            this.GyógyszerModGB.TabIndex = 7;
            this.GyógyszerModGB.Text = "Gyógyszer Módosítása";
            this.GyógyszerModGB.Click += new System.EventHandler(this.GyógyszerModGB_Click);
            // 
            // GyogyszerMegTGB
            // 
            this.GyogyszerMegTGB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GyogyszerMegTGB.CheckedState.FillColor = System.Drawing.Color.White;
            this.GyogyszerMegTGB.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.GyogyszerMegTGB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GyogyszerMegTGB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GyogyszerMegTGB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GyogyszerMegTGB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GyogyszerMegTGB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.GyogyszerMegTGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GyogyszerMegTGB.ForeColor = System.Drawing.Color.White;
            this.GyogyszerMegTGB.Image = global::Zaródolgozat.Properties.Resources.view_64px1;
            this.GyogyszerMegTGB.ImageSize = new System.Drawing.Size(30, 30);
            this.GyogyszerMegTGB.Location = new System.Drawing.Point(0, 394);
            this.GyogyszerMegTGB.Name = "GyogyszerMegTGB";
            this.GyogyszerMegTGB.Size = new System.Drawing.Size(270, 45);
            this.GyogyszerMegTGB.TabIndex = 6;
            this.GyogyszerMegTGB.Text = "Gyógyszer megtekíntése";
            this.GyogyszerMegTGB.Click += new System.EventHandler(this.GyogyszerMegTGB_Click);
            // 
            // GyogyszeraddGB
            // 
            this.GyogyszeraddGB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GyogyszeraddGB.CheckedState.FillColor = System.Drawing.Color.White;
            this.GyogyszeraddGB.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.GyogyszeraddGB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GyogyszeraddGB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GyogyszeraddGB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GyogyszeraddGB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GyogyszeraddGB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.GyogyszeraddGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GyogyszeraddGB.ForeColor = System.Drawing.Color.White;
            this.GyogyszeraddGB.Image = global::Zaródolgozat.Properties.Resources.addMedic_48px;
            this.GyogyszeraddGB.ImageSize = new System.Drawing.Size(30, 30);
            this.GyogyszeraddGB.Location = new System.Drawing.Point(-3, 334);
            this.GyogyszeraddGB.Name = "GyogyszeraddGB";
            this.GyogyszeraddGB.Size = new System.Drawing.Size(270, 45);
            this.GyogyszeraddGB.TabIndex = 5;
            this.GyogyszeraddGB.Text = "Gyógyszer hozzáadása";
            this.GyogyszeraddGB.Click += new System.EventHandler(this.GyogyszeraddGB_Click);
            // 
            // MűszerfalGB
            // 
            this.MűszerfalGB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MűszerfalGB.CheckedState.FillColor = System.Drawing.Color.White;
            this.MűszerfalGB.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.MűszerfalGB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MűszerfalGB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MűszerfalGB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MűszerfalGB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MűszerfalGB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.MűszerfalGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MűszerfalGB.ForeColor = System.Drawing.Color.White;
            this.MűszerfalGB.Image = global::Zaródolgozat.Properties.Resources.dashbord;
            this.MűszerfalGB.ImageSize = new System.Drawing.Size(30, 30);
            this.MűszerfalGB.Location = new System.Drawing.Point(0, 271);
            this.MűszerfalGB.Name = "MűszerfalGB";
            this.MűszerfalGB.Size = new System.Drawing.Size(270, 45);
            this.MűszerfalGB.TabIndex = 4;
            this.MűszerfalGB.Text = "Műszerfal";
            this.MűszerfalGB.Click += new System.EventHandler(this.MűszerfalGB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patikus";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zaródolgozat.Properties.Resources.pharmacy_100px;
            this.pictureBox1.Location = new System.Drawing.Point(46, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(267, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 833);
            this.panel2.TabIndex = 1;
            // 
            // fopanel
            // 
            this.fopanel.BackColor = System.Drawing.Color.White;
            this.fopanel.Controls.Add(this.uC_Patikus_GyogyszerEladas1);
            this.fopanel.Controls.Add(this.uC_PatikusGyógyszerValiditása1);
            this.fopanel.Controls.Add(this.uC_Patikus_GyogyszerUpdate1);
            this.fopanel.Controls.Add(this.uC_Patikus_Gyogyszermegtekintes1);
            this.fopanel.Controls.Add(this.uC_Patikus_Gyógyszeradd1);
            this.fopanel.Controls.Add(this.uC_Patikus_Műszerfal1);
            this.fopanel.Location = new System.Drawing.Point(270, 0);
            this.fopanel.Name = "fopanel";
            this.fopanel.Size = new System.Drawing.Size(1102, 782);
            this.fopanel.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.fopanel;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.fopanel;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.fopanel;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.fopanel;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.fopanel;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.fopanel;
            // 
            // uC_PatikusGyógyszerValiditása1
            // 
            this.uC_PatikusGyógyszerValiditása1.BackColor = System.Drawing.Color.White;
            this.uC_PatikusGyógyszerValiditása1.Location = new System.Drawing.Point(1, 4);
            this.uC_PatikusGyógyszerValiditása1.Name = "uC_PatikusGyógyszerValiditása1";
            this.uC_PatikusGyógyszerValiditása1.Size = new System.Drawing.Size(1104, 770);
            this.uC_PatikusGyógyszerValiditása1.TabIndex = 4;
            // 
            // uC_Patikus_GyogyszerUpdate1
            // 
            this.uC_Patikus_GyogyszerUpdate1.BackColor = System.Drawing.Color.White;
            this.uC_Patikus_GyogyszerUpdate1.ForeColor = System.Drawing.Color.Black;
            this.uC_Patikus_GyogyszerUpdate1.Location = new System.Drawing.Point(7, 4);
            this.uC_Patikus_GyogyszerUpdate1.Name = "uC_Patikus_GyogyszerUpdate1";
            this.uC_Patikus_GyogyszerUpdate1.Size = new System.Drawing.Size(1104, 770);
            this.uC_Patikus_GyogyszerUpdate1.TabIndex = 3;
            // 
            // uC_Patikus_Gyogyszermegtekintes1
            // 
            this.uC_Patikus_Gyogyszermegtekintes1.BackColor = System.Drawing.Color.White;
            this.uC_Patikus_Gyogyszermegtekintes1.Location = new System.Drawing.Point(7, 4);
            this.uC_Patikus_Gyogyszermegtekintes1.Name = "uC_Patikus_Gyogyszermegtekintes1";
            this.uC_Patikus_Gyogyszermegtekintes1.Size = new System.Drawing.Size(1104, 770);
            this.uC_Patikus_Gyogyszermegtekintes1.TabIndex = 2;
            // 
            // uC_Patikus_Gyógyszeradd1
            // 
            this.uC_Patikus_Gyógyszeradd1.BackColor = System.Drawing.Color.White;
            this.uC_Patikus_Gyógyszeradd1.Location = new System.Drawing.Point(0, 0);
            this.uC_Patikus_Gyógyszeradd1.Name = "uC_Patikus_Gyógyszeradd1";
            this.uC_Patikus_Gyógyszeradd1.Size = new System.Drawing.Size(1104, 770);
            this.uC_Patikus_Gyógyszeradd1.TabIndex = 1;
            // 
            // uC_Patikus_Műszerfal1
            // 
            this.uC_Patikus_Műszerfal1.BackColor = System.Drawing.Color.White;
            this.uC_Patikus_Műszerfal1.Location = new System.Drawing.Point(7, 4);
            this.uC_Patikus_Műszerfal1.Name = "uC_Patikus_Műszerfal1";
            this.uC_Patikus_Műszerfal1.Size = new System.Drawing.Size(1092, 775);
            this.uC_Patikus_Műszerfal1.TabIndex = 0;
            this.uC_Patikus_Műszerfal1.Load += new System.EventHandler(this.uC_Patikus_Műszerfal1_Load);
            // 
            // uC_Patikus_GyogyszerEladas1
            // 
            this.uC_Patikus_GyogyszerEladas1.BackColor = System.Drawing.Color.White;
            this.uC_Patikus_GyogyszerEladas1.Location = new System.Drawing.Point(0, 0);
            this.uC_Patikus_GyogyszerEladas1.Name = "uC_Patikus_GyogyszerEladas1";
            this.uC_Patikus_GyogyszerEladas1.Size = new System.Drawing.Size(1104, 770);
            this.uC_Patikus_GyogyszerEladas1.TabIndex = 5;
            // 
            // Patikus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 780);
            this.Controls.Add(this.fopanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patikus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patikus";
            this.Load += new System.EventHandler(this.Patikus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.fopanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel fopanel;
        private Guna.UI2.WinForms.Guna2Button KijelentkezesGB;
        private Guna.UI2.WinForms.Guna2Button GyogyszerEladasGB;
        private Guna.UI2.WinForms.Guna2Button gyogyValGB;
        private Guna.UI2.WinForms.Guna2Button GyógyszerModGB;
        private Guna.UI2.WinForms.Guna2Button GyogyszerMegTGB;
        private Guna.UI2.WinForms.Guna2Button GyogyszeraddGB;
        private Guna.UI2.WinForms.Guna2Button MűszerfalGB;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PatikusUC.UC_Patikus_Műszerfal uC_Patikus_Műszerfal1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PatikusUC.UC_Patikus_Gyógyszeradd uC_Patikus_Gyógyszeradd1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PatikusUC.UC_Patikus_Gyogyszermegtekintes uC_Patikus_Gyogyszermegtekintes1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PatikusUC.UC_Patikus_GyogyszerUpdate uC_Patikus_GyogyszerUpdate1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PatikusUC.UC_PatikusGyógyszerValiditása uC_PatikusGyógyszerValiditása1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private PatikusUC.UC_Patikus_GyogyszerEladas uC_Patikus_GyogyszerEladas1;
    }
}