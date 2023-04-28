namespace Zaródolgozat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FelhasznaloNev = new Guna.UI2.WinForms.Guna2TextBox();
            this.FelhasznaloJel = new Guna.UI2.WinForms.Guna2TextBox();
            this.Reset = new Guna.UI2.WinForms.Guna2Button();
            this.Bejelentkezes = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Kilep = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 770);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zaródolgozat.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(89, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(56, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 177);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gyógyszertári\r\nMenedzsment\r\nRendszer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(886, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bejelentkezés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(795, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Felhasználónév";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(795, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jelszó";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FelhasznaloNev
            // 
            this.FelhasznaloNev.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FelhasznaloNev.DefaultText = "";
            this.FelhasznaloNev.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FelhasznaloNev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FelhasznaloNev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloNev.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloNev.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloNev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhasznaloNev.ForeColor = System.Drawing.Color.Black;
            this.FelhasznaloNev.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloNev.Location = new System.Drawing.Point(798, 253);
            this.FelhasznaloNev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FelhasznaloNev.Name = "FelhasznaloNev";
            this.FelhasznaloNev.PasswordChar = '\0';
            this.FelhasznaloNev.PlaceholderText = "";
            this.FelhasznaloNev.SelectedText = "";
            this.FelhasznaloNev.Size = new System.Drawing.Size(257, 50);
            this.FelhasznaloNev.TabIndex = 6;
            this.FelhasznaloNev.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // FelhasznaloJel
            // 
            this.FelhasznaloJel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FelhasznaloJel.DefaultText = "";
            this.FelhasznaloJel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FelhasznaloJel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FelhasznaloJel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloJel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FelhasznaloJel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloJel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhasznaloJel.ForeColor = System.Drawing.Color.Black;
            this.FelhasznaloJel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FelhasznaloJel.Location = new System.Drawing.Point(798, 329);
            this.FelhasznaloJel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FelhasznaloJel.Name = "FelhasznaloJel";
            this.FelhasznaloJel.PasswordChar = '*';
            this.FelhasznaloJel.PlaceholderText = "";
            this.FelhasznaloJel.SelectedText = "";
            this.FelhasznaloJel.Size = new System.Drawing.Size(257, 50);
            this.FelhasznaloJel.TabIndex = 7;
            this.FelhasznaloJel.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // Reset
            // 
            this.Reset.BorderRadius = 16;
            this.Reset.BorderThickness = 1;
            this.Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.HoverState.BorderColor = System.Drawing.Color.Black;
            this.Reset.HoverState.FillColor = System.Drawing.Color.White;
            this.Reset.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.Reset.Image = global::Zaródolgozat.Properties.Resources.reset_25px;
            this.Reset.ImageSize = new System.Drawing.Size(28, 28);
            this.Reset.Location = new System.Drawing.Point(915, 408);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(180, 45);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Bejelentkezes
            // 
            this.Bejelentkezes.BorderRadius = 16;
            this.Bejelentkezes.BorderThickness = 1;
            this.Bejelentkezes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Bejelentkezes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Bejelentkezes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Bejelentkezes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Bejelentkezes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.Bejelentkezes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bejelentkezes.ForeColor = System.Drawing.Color.White;
            this.Bejelentkezes.HoverState.BorderColor = System.Drawing.Color.Black;
            this.Bejelentkezes.HoverState.FillColor = System.Drawing.Color.White;
            this.Bejelentkezes.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.Bejelentkezes.Image = ((System.Drawing.Image)(resources.GetObject("Bejelentkezes.Image")));
            this.Bejelentkezes.Location = new System.Drawing.Point(729, 408);
            this.Bejelentkezes.Name = "Bejelentkezes";
            this.Bejelentkezes.Size = new System.Drawing.Size(180, 45);
            this.Bejelentkezes.TabIndex = 8;
            this.Bejelentkezes.Text = "Bejelentkezés";
            this.Bejelentkezes.Click += new System.EventHandler(this.Bejelentkezes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Zaródolgozat.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(862, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Kilep
            // 
            this.Kilep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Kilep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Kilep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Kilep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Kilep.FillColor = System.Drawing.Color.White;
            this.Kilep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Kilep.ForeColor = System.Drawing.Color.White;
            this.Kilep.Image = global::Zaródolgozat.Properties.Resources.zaro;
            this.Kilep.Location = new System.Drawing.Point(1332, 0);
            this.Kilep.Name = "Kilep";
            this.Kilep.Size = new System.Drawing.Size(34, 34);
            this.Kilep.TabIndex = 1;
            this.Kilep.Click += new System.EventHandler(this.Kilep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1364, 729);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Bejelentkezes);
            this.Controls.Add(this.FelhasznaloJel);
            this.Controls.Add(this.FelhasznaloNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Kilep);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Kilep;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox FelhasznaloNev;
        private Guna.UI2.WinForms.Guna2TextBox FelhasznaloJel;
        private Guna.UI2.WinForms.Guna2Button Bejelentkezes;
        private Guna.UI2.WinForms.Guna2Button Reset;
    }
}

