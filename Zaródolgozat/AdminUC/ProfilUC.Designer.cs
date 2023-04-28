namespace Zaródolgozat.AdminUC
{
    partial class ProfilUC
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
            this.FelhaszNevLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FelhaszSzintTB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FelhaszNevTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FelhaszSzulTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.FelhaszTeleTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.FelhaszEmailTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.FelhaszJelTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ResetGomb = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateGomb = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FelhaszIDTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profil";
            // 
            // FelhaszNevLB
            // 
            this.FelhaszNevLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhaszNevLB.Location = new System.Drawing.Point(52, 426);
            this.FelhaszNevLB.Name = "FelhaszNevLB";
            this.FelhaszNevLB.Size = new System.Drawing.Size(186, 30);
            this.FelhaszNevLB.TabIndex = 4;
            this.FelhaszNevLB.Text = "Felhasználó Név";
            this.FelhaszNevLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(640, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Felhasználó Szint";
            // 
            // FelhaszSzintTB
            // 
            this.FelhaszSzintTB.BackColor = System.Drawing.Color.Transparent;
            this.FelhaszSzintTB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FelhaszSzintTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FelhaszSzintTB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszSzintTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszSzintTB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FelhaszSzintTB.ForeColor = System.Drawing.Color.Black;
            this.FelhaszSzintTB.ItemHeight = 30;
            this.FelhaszSzintTB.Items.AddRange(new object[] {
            "Adminisztrátor",
            "Patikus"});
            this.FelhaszSzintTB.Location = new System.Drawing.Point(652, 95);
            this.FelhaszSzintTB.Name = "FelhaszSzintTB";
            this.FelhaszSzintTB.Size = new System.Drawing.Size(256, 36);
            this.FelhaszSzintTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(648, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Név";
            // 
            // FelhaszNevTB
            // 
            this.FelhaszNevTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FelhaszNevTB.DefaultText = "";
            this.FelhaszNevTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FelhaszNevTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FelhaszNevTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhaszNevTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhaszNevTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszNevTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhaszNevTB.ForeColor = System.Drawing.Color.Black;
            this.FelhaszNevTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszNevTB.Location = new System.Drawing.Point(652, 196);
            this.FelhaszNevTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FelhaszNevTB.Name = "FelhaszNevTB";
            this.FelhaszNevTB.PasswordChar = '\0';
            this.FelhaszNevTB.PlaceholderText = "";
            this.FelhaszNevTB.SelectedText = "";
            this.FelhaszNevTB.Size = new System.Drawing.Size(340, 36);
            this.FelhaszNevTB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(648, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Születési Dátum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(648, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Teelfonszám";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(648, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "E-mail cím";
            // 
            // FelhaszSzulTB
            // 
            this.FelhaszSzulTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FelhaszSzulTB.DefaultText = "";
            this.FelhaszSzulTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FelhaszSzulTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FelhaszSzulTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhaszSzulTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhaszSzulTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszSzulTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhaszSzulTB.ForeColor = System.Drawing.Color.Black;
            this.FelhaszSzulTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszSzulTB.Location = new System.Drawing.Point(652, 300);
            this.FelhaszSzulTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FelhaszSzulTB.Name = "FelhaszSzulTB";
            this.FelhaszSzulTB.PasswordChar = '\0';
            this.FelhaszSzulTB.PlaceholderText = "";
            this.FelhaszSzulTB.SelectedText = "";
            this.FelhaszSzulTB.Size = new System.Drawing.Size(340, 36);
            this.FelhaszSzulTB.TabIndex = 12;
            // 
            // FelhaszTeleTB
            // 
            this.FelhaszTeleTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FelhaszTeleTB.DefaultText = "";
            this.FelhaszTeleTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FelhaszTeleTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FelhaszTeleTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhaszTeleTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhaszTeleTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszTeleTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhaszTeleTB.ForeColor = System.Drawing.Color.Black;
            this.FelhaszTeleTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszTeleTB.Location = new System.Drawing.Point(652, 380);
            this.FelhaszTeleTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FelhaszTeleTB.Name = "FelhaszTeleTB";
            this.FelhaszTeleTB.PasswordChar = '\0';
            this.FelhaszTeleTB.PlaceholderText = "";
            this.FelhaszTeleTB.SelectedText = "";
            this.FelhaszTeleTB.Size = new System.Drawing.Size(340, 36);
            this.FelhaszTeleTB.TabIndex = 13;
            this.FelhaszTeleTB.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // FelhaszEmailTB
            // 
            this.FelhaszEmailTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FelhaszEmailTB.DefaultText = "";
            this.FelhaszEmailTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FelhaszEmailTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FelhaszEmailTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhaszEmailTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhaszEmailTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszEmailTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhaszEmailTB.ForeColor = System.Drawing.Color.Black;
            this.FelhaszEmailTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszEmailTB.Location = new System.Drawing.Point(652, 460);
            this.FelhaszEmailTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FelhaszEmailTB.Name = "FelhaszEmailTB";
            this.FelhaszEmailTB.PasswordChar = '\0';
            this.FelhaszEmailTB.PlaceholderText = "";
            this.FelhaszEmailTB.SelectedText = "";
            this.FelhaszEmailTB.Size = new System.Drawing.Size(340, 36);
            this.FelhaszEmailTB.TabIndex = 14;
            this.FelhaszEmailTB.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // FelhaszJelTB
            // 
            this.FelhaszJelTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FelhaszJelTB.DefaultText = "";
            this.FelhaszJelTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FelhaszJelTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FelhaszJelTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhaszJelTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhaszJelTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszJelTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhaszJelTB.ForeColor = System.Drawing.Color.Black;
            this.FelhaszJelTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszJelTB.Location = new System.Drawing.Point(652, 542);
            this.FelhaszJelTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FelhaszJelTB.Name = "FelhaszJelTB";
            this.FelhaszJelTB.PasswordChar = '\0';
            this.FelhaszJelTB.PlaceholderText = "";
            this.FelhaszJelTB.SelectedText = "";
            this.FelhaszJelTB.Size = new System.Drawing.Size(340, 36);
            this.FelhaszJelTB.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(648, 518);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Jelszó";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // ResetGomb
            // 
            this.ResetGomb.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ResetGomb.BorderRadius = 21;
            this.ResetGomb.BorderThickness = 1;
            this.ResetGomb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetGomb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResetGomb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetGomb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResetGomb.FillColor = System.Drawing.SystemColors.HotTrack;
            this.ResetGomb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResetGomb.ForeColor = System.Drawing.Color.White;
            this.ResetGomb.HoverState.BorderColor = System.Drawing.Color.Black;
            this.ResetGomb.HoverState.FillColor = System.Drawing.Color.White;
            this.ResetGomb.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ResetGomb.Image = global::Zaródolgozat.Properties.Resources.reset_25px;
            this.ResetGomb.ImageSize = new System.Drawing.Size(28, 28);
            this.ResetGomb.Location = new System.Drawing.Point(852, 605);
            this.ResetGomb.Name = "ResetGomb";
            this.ResetGomb.Size = new System.Drawing.Size(122, 45);
            this.ResetGomb.TabIndex = 18;
            this.ResetGomb.Text = "Reset";
            this.ResetGomb.Click += new System.EventHandler(this.ResetGomb_Click);
            // 
            // UpdateGomb
            // 
            this.UpdateGomb.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UpdateGomb.BorderRadius = 21;
            this.UpdateGomb.BorderThickness = 1;
            this.UpdateGomb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateGomb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateGomb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateGomb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateGomb.FillColor = System.Drawing.SystemColors.HotTrack;
            this.UpdateGomb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateGomb.ForeColor = System.Drawing.Color.White;
            this.UpdateGomb.HoverState.BorderColor = System.Drawing.Color.Black;
            this.UpdateGomb.HoverState.FillColor = System.Drawing.Color.White;
            this.UpdateGomb.HoverState.ForeColor = System.Drawing.Color.Black;
            this.UpdateGomb.Image = global::Zaródolgozat.Properties.Resources.update_64px;
            this.UpdateGomb.ImageSize = new System.Drawing.Size(24, 24);
            this.UpdateGomb.Location = new System.Drawing.Point(674, 605);
            this.UpdateGomb.Name = "UpdateGomb";
            this.UpdateGomb.Size = new System.Drawing.Size(122, 45);
            this.UpdateGomb.TabIndex = 17;
            this.UpdateGomb.Text = "Update";
            this.UpdateGomb.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zaródolgozat.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(56, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FelhaszIDTB
            // 
            this.FelhaszIDTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FelhaszIDTB.DefaultText = "";
            this.FelhaszIDTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FelhaszIDTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FelhaszIDTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhaszIDTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhaszIDTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszIDTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FelhaszIDTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhaszIDTB.Location = new System.Drawing.Point(447, 95);
            this.FelhaszIDTB.Name = "FelhaszIDTB";
            this.FelhaszIDTB.PasswordChar = '\0';
            this.FelhaszIDTB.PlaceholderText = "";
            this.FelhaszIDTB.SelectedText = "";
            this.FelhaszIDTB.Size = new System.Drawing.Size(57, 36);
            this.FelhaszIDTB.TabIndex = 19;
            this.FelhaszIDTB.TextChanged += new System.EventHandler(this.FelhaszIDTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(419, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Felhasználó ID:\r\n";
            // 
            // ProfilUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FelhaszIDTB);
            this.Controls.Add(this.ResetGomb);
            this.Controls.Add(this.UpdateGomb);
            this.Controls.Add(this.FelhaszJelTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FelhaszEmailTB);
            this.Controls.Add(this.FelhaszTeleTB);
            this.Controls.Add(this.FelhaszSzulTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FelhaszNevTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FelhaszSzintTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FelhaszNevLB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ProfilUC";
            this.Size = new System.Drawing.Size(1104, 770);
            this.Load += new System.EventHandler(this.ProfilUC_Load);
            this.Enter += new System.EventHandler(this.ProfilUC_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FelhaszNevLB;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox FelhaszSzintTB;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox FelhaszNevTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox FelhaszSzulTB;
        private Guna.UI2.WinForms.Guna2TextBox FelhaszTeleTB;
        private Guna.UI2.WinForms.Guna2TextBox FelhaszEmailTB;
        private Guna.UI2.WinForms.Guna2TextBox FelhaszJelTB;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button UpdateGomb;
        private Guna.UI2.WinForms.Guna2Button ResetGomb;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox FelhaszIDTB;
    }
}
