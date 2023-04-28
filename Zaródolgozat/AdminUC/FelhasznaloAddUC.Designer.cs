namespace Zaródolgozat.AdminUC
{
    partial class FelhasznaloAddUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FelhasznaloRoleUC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FelhasznaloNevUC = new Guna.UI2.WinForms.Guna2TextBox();
            this.FelhasznaloTeleUC = new Guna.UI2.WinForms.Guna2TextBox();
            this.FelhasznaloEmailUC = new Guna.UI2.WinForms.Guna2TextBox();
            this.FelhasznaloUnevUC = new Guna.UI2.WinForms.Guna2TextBox();
            this.FelhasznaloPassUC = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FelhasznaloSzulUC = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FelhasznaloResetUC = new Guna.UI2.WinForms.Guna2Button();
            this.FelhasznaloRegUC = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználó Hozzáadása";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(82, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Felhasználói Szint";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(82, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Név";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(82, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Születési Dátum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(82, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telelfonszám";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(677, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(677, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Felhasználónév";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(677, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Jelszó";
            // 
            // FelhasznaloRoleUC
            // 
            this.FelhasznaloRoleUC.BackColor = System.Drawing.Color.Transparent;
            this.FelhasznaloRoleUC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FelhasznaloRoleUC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FelhasznaloRoleUC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloRoleUC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloRoleUC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FelhasznaloRoleUC.ForeColor = System.Drawing.Color.Black;
            this.FelhasznaloRoleUC.ItemHeight = 30;
            this.FelhasznaloRoleUC.Items.AddRange(new object[] {
            "Adminisztrátor",
            "Patikus"});
            this.FelhasznaloRoleUC.Location = new System.Drawing.Point(85, 154);
            this.FelhasznaloRoleUC.Name = "FelhasznaloRoleUC";
            this.FelhasznaloRoleUC.Size = new System.Drawing.Size(340, 36);
            this.FelhasznaloRoleUC.TabIndex = 8;
            this.FelhasznaloRoleUC.SelectedIndexChanged += new System.EventHandler(this.FelhasznaloRoleUC_SelectedIndexChanged);
            // 
            // FelhasznaloNevUC
            // 
            this.FelhasznaloNevUC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FelhasznaloNevUC.DefaultText = "";
            this.FelhasznaloNevUC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FelhasznaloNevUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FelhasznaloNevUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloNevUC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloNevUC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloNevUC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhasznaloNevUC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloNevUC.Location = new System.Drawing.Point(85, 247);
            this.FelhasznaloNevUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FelhasznaloNevUC.Name = "FelhasznaloNevUC";
            this.FelhasznaloNevUC.PasswordChar = '\0';
            this.FelhasznaloNevUC.PlaceholderText = "";
            this.FelhasznaloNevUC.SelectedText = "";
            this.FelhasznaloNevUC.Size = new System.Drawing.Size(340, 36);
            this.FelhasznaloNevUC.TabIndex = 9;
            // 
            // FelhasznaloTeleUC
            // 
            this.FelhasznaloTeleUC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FelhasznaloTeleUC.DefaultText = "";
            this.FelhasznaloTeleUC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FelhasznaloTeleUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FelhasznaloTeleUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloTeleUC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloTeleUC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloTeleUC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhasznaloTeleUC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloTeleUC.Location = new System.Drawing.Point(86, 454);
            this.FelhasznaloTeleUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FelhasznaloTeleUC.Name = "FelhasznaloTeleUC";
            this.FelhasznaloTeleUC.PasswordChar = '\0';
            this.FelhasznaloTeleUC.PlaceholderText = "";
            this.FelhasznaloTeleUC.SelectedText = "";
            this.FelhasznaloTeleUC.Size = new System.Drawing.Size(340, 36);
            this.FelhasznaloTeleUC.TabIndex = 10;
            // 
            // FelhasznaloEmailUC
            // 
            this.FelhasznaloEmailUC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FelhasznaloEmailUC.DefaultText = "";
            this.FelhasznaloEmailUC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FelhasznaloEmailUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FelhasznaloEmailUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloEmailUC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloEmailUC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloEmailUC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhasznaloEmailUC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloEmailUC.Location = new System.Drawing.Point(681, 154);
            this.FelhasznaloEmailUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FelhasznaloEmailUC.Name = "FelhasznaloEmailUC";
            this.FelhasznaloEmailUC.PasswordChar = '\0';
            this.FelhasznaloEmailUC.PlaceholderText = "";
            this.FelhasznaloEmailUC.SelectedText = "";
            this.FelhasznaloEmailUC.Size = new System.Drawing.Size(340, 36);
            this.FelhasznaloEmailUC.TabIndex = 11;
            // 
            // FelhasznaloUnevUC
            // 
            this.FelhasznaloUnevUC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FelhasznaloUnevUC.DefaultText = "";
            this.FelhasznaloUnevUC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FelhasznaloUnevUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FelhasznaloUnevUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloUnevUC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloUnevUC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloUnevUC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhasznaloUnevUC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloUnevUC.Location = new System.Drawing.Point(681, 247);
            this.FelhasznaloUnevUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FelhasznaloUnevUC.Name = "FelhasznaloUnevUC";
            this.FelhasznaloUnevUC.PasswordChar = '\0';
            this.FelhasznaloUnevUC.PlaceholderText = "";
            this.FelhasznaloUnevUC.SelectedText = "";
            this.FelhasznaloUnevUC.Size = new System.Drawing.Size(340, 36);
            this.FelhasznaloUnevUC.TabIndex = 12;
            // 
            // FelhasznaloPassUC
            // 
            this.FelhasznaloPassUC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FelhasznaloPassUC.DefaultText = "";
            this.FelhasznaloPassUC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FelhasznaloPassUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FelhasznaloPassUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloPassUC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloPassUC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloPassUC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhasznaloPassUC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloPassUC.Location = new System.Drawing.Point(681, 361);
            this.FelhasznaloPassUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FelhasznaloPassUC.Name = "FelhasznaloPassUC";
            this.FelhasznaloPassUC.PasswordChar = '\0';
            this.FelhasznaloPassUC.PlaceholderText = "";
            this.FelhasznaloPassUC.SelectedText = "";
            this.FelhasznaloPassUC.Size = new System.Drawing.Size(340, 36);
            this.FelhasznaloPassUC.TabIndex = 13;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(85, 361);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(0, 0);
            this.guna2DateTimePicker1.TabIndex = 14;
            this.guna2DateTimePicker1.Value = new System.DateTime(2023, 2, 27, 8, 42, 18, 629);
            // 
            // FelhasznaloSzulUC
            // 
            this.FelhasznaloSzulUC.Checked = true;
            this.FelhasznaloSzulUC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FelhasznaloSzulUC.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FelhasznaloSzulUC.Location = new System.Drawing.Point(86, 361);
            this.FelhasznaloSzulUC.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FelhasznaloSzulUC.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FelhasznaloSzulUC.Name = "FelhasznaloSzulUC";
            this.FelhasznaloSzulUC.Size = new System.Drawing.Size(340, 36);
            this.FelhasznaloSzulUC.TabIndex = 15;
            this.FelhasznaloSzulUC.Value = new System.DateTime(2023, 2, 27, 8, 42, 45, 815);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(537, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 523);
            this.panel1.TabIndex = 16;
            // 
            // FelhasznaloResetUC
            // 
            this.FelhasznaloResetUC.BorderRadius = 19;
            this.FelhasznaloResetUC.BorderThickness = 1;
            this.FelhasznaloResetUC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FelhasznaloResetUC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FelhasznaloResetUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FelhasznaloResetUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FelhasznaloResetUC.FillColor = System.Drawing.SystemColors.HotTrack;
            this.FelhasznaloResetUC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhasznaloResetUC.ForeColor = System.Drawing.Color.White;
            this.FelhasznaloResetUC.HoverState.FillColor = System.Drawing.Color.White;
            this.FelhasznaloResetUC.HoverState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FelhasznaloResetUC.Image = global::Zaródolgozat.Properties.Resources.reset_25px;
            this.FelhasznaloResetUC.Location = new System.Drawing.Point(876, 445);
            this.FelhasznaloResetUC.Name = "FelhasznaloResetUC";
            this.FelhasznaloResetUC.Size = new System.Drawing.Size(180, 45);
            this.FelhasznaloResetUC.TabIndex = 18;
            this.FelhasznaloResetUC.Text = "Törlés";
            // 
            // FelhasznaloRegUC
            // 
            this.FelhasznaloRegUC.BorderRadius = 19;
            this.FelhasznaloRegUC.BorderThickness = 1;
            this.FelhasznaloRegUC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FelhasznaloRegUC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FelhasznaloRegUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FelhasznaloRegUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FelhasznaloRegUC.FillColor = System.Drawing.SystemColors.HotTrack;
            this.FelhasznaloRegUC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhasznaloRegUC.ForeColor = System.Drawing.Color.White;
            this.FelhasznaloRegUC.HoverState.FillColor = System.Drawing.Color.White;
            this.FelhasznaloRegUC.HoverState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FelhasznaloRegUC.Image = global::Zaródolgozat.Properties.Resources.signup_64px;
            this.FelhasznaloRegUC.Location = new System.Drawing.Point(681, 445);
            this.FelhasznaloRegUC.Name = "FelhasznaloRegUC";
            this.FelhasznaloRegUC.Size = new System.Drawing.Size(180, 45);
            this.FelhasznaloRegUC.TabIndex = 17;
            this.FelhasznaloRegUC.Text = "Regisztrálás";
            this.FelhasznaloRegUC.Click += new System.EventHandler(this.FelhasznaloRegUC_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // FelhasznaloAddUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FelhasznaloResetUC);
            this.Controls.Add(this.FelhasznaloRegUC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FelhasznaloSzulUC);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.FelhasznaloPassUC);
            this.Controls.Add(this.FelhasznaloUnevUC);
            this.Controls.Add(this.FelhasznaloEmailUC);
            this.Controls.Add(this.FelhasznaloTeleUC);
            this.Controls.Add(this.FelhasznaloNevUC);
            this.Controls.Add(this.FelhasznaloRoleUC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FelhasznaloAddUC";
            this.Size = new System.Drawing.Size(1104, 770);
            this.Load += new System.EventHandler(this.FelhasznaloAddUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox FelhasznaloRoleUC;
        private Guna.UI2.WinForms.Guna2TextBox FelhasznaloNevUC;
        private Guna.UI2.WinForms.Guna2TextBox FelhasznaloTeleUC;
        private Guna.UI2.WinForms.Guna2TextBox FelhasznaloEmailUC;
        private Guna.UI2.WinForms.Guna2TextBox FelhasznaloUnevUC;
        private Guna.UI2.WinForms.Guna2TextBox FelhasznaloPassUC;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker FelhasznaloSzulUC;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button FelhasznaloRegUC;
        private Guna.UI2.WinForms.Guna2Button FelhasznaloResetUC;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
