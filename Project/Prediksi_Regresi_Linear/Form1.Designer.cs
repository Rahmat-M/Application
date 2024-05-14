namespace Prediksi_Regresi_Linear
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.navAbout = new FontAwesome.Sharp.IconButton();
            this.navGrafik = new FontAwesome.Sharp.IconButton();
            this.navProses3 = new FontAwesome.Sharp.IconButton();
            this.navProses2 = new FontAwesome.Sharp.IconButton();
            this.navProses1 = new FontAwesome.Sharp.IconButton();
            this.navUpload = new FontAwesome.Sharp.IconButton();
            this.navHome = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shutdownButton = new System.Windows.Forms.PictureBox();
            this.mainBackground = new System.Windows.Forms.PictureBox();
            this.panelProses1 = new Prediksi_Regresi_Linear.Proses_1();
            this.panelGrafik = new Prediksi_Regresi_Linear.Grafik();
            this.panelProses3 = new Prediksi_Regresi_Linear.proses_3();
            this.panelProses2 = new Prediksi_Regresi_Linear.Proses_2();
            this.panelHome = new Prediksi_Regresi_Linear.Home_1();
            this.panelAbout = new Prediksi_Regresi_Linear.About_1();
            this.panelHelp = new Prediksi_Regresi_Linear.panelHelp_1();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shutdownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.navAbout);
            this.panelMenu.Controls.Add(this.navGrafik);
            this.panelMenu.Controls.Add(this.navProses3);
            this.panelMenu.Controls.Add(this.navProses2);
            this.panelMenu.Controls.Add(this.navProses1);
            this.panelMenu.Controls.Add(this.navUpload);
            this.panelMenu.Controls.Add(this.navHome);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 780);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 141);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 742);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 15);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(682, 591);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(140, 37);
            this.btnUpload.TabIndex = 10;
            this.btnUpload.Text = "Upload file";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click_1);
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.mainDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.ColumnHeadersVisible = false;
            this.mainDataGridView.Location = new System.Drawing.Point(347, 141);
            this.mainDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.RowHeadersWidth = 51;
            this.mainDataGridView.RowTemplate.Height = 24;
            this.mainDataGridView.Size = new System.Drawing.Size(800, 411);
            this.mainDataGridView.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Upload file *.csv ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 590);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Data pada kolom 2 baris 2";
            // 
            // navAbout
            // 
            this.navAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.navAbout.FlatAppearance.BorderSize = 0;
            this.navAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navAbout.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navAbout.ForeColor = System.Drawing.Color.White;
            this.navAbout.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.navAbout.IconColor = System.Drawing.Color.White;
            this.navAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navAbout.IconSize = 32;
            this.navAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navAbout.Location = new System.Drawing.Point(0, 501);
            this.navAbout.Name = "navAbout";
            this.navAbout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.navAbout.Size = new System.Drawing.Size(200, 60);
            this.navAbout.TabIndex = 30;
            this.navAbout.Text = "About";
            this.navAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navAbout.UseVisualStyleBackColor = true;
            this.navAbout.Click += new System.EventHandler(this.navAbout_Click);
            // 
            // navGrafik
            // 
            this.navGrafik.Dock = System.Windows.Forms.DockStyle.Top;
            this.navGrafik.FlatAppearance.BorderSize = 0;
            this.navGrafik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navGrafik.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navGrafik.ForeColor = System.Drawing.Color.White;
            this.navGrafik.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.navGrafik.IconColor = System.Drawing.Color.White;
            this.navGrafik.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navGrafik.IconSize = 32;
            this.navGrafik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navGrafik.Location = new System.Drawing.Point(0, 441);
            this.navGrafik.Name = "navGrafik";
            this.navGrafik.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.navGrafik.Size = new System.Drawing.Size(200, 60);
            this.navGrafik.TabIndex = 29;
            this.navGrafik.Text = "Grafik";
            this.navGrafik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navGrafik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navGrafik.UseVisualStyleBackColor = true;
            this.navGrafik.Click += new System.EventHandler(this.navGrafik_Click);
            // 
            // navProses3
            // 
            this.navProses3.Dock = System.Windows.Forms.DockStyle.Top;
            this.navProses3.FlatAppearance.BorderSize = 0;
            this.navProses3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navProses3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navProses3.ForeColor = System.Drawing.Color.White;
            this.navProses3.IconChar = FontAwesome.Sharp.IconChar.Th;
            this.navProses3.IconColor = System.Drawing.Color.White;
            this.navProses3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navProses3.IconSize = 32;
            this.navProses3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navProses3.Location = new System.Drawing.Point(0, 381);
            this.navProses3.Name = "navProses3";
            this.navProses3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.navProses3.Size = new System.Drawing.Size(200, 60);
            this.navProses3.TabIndex = 28;
            this.navProses3.Text = "Prediksi (2020-2025)";
            this.navProses3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navProses3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navProses3.UseVisualStyleBackColor = true;
            this.navProses3.Click += new System.EventHandler(this.navProses3_Click);
            // 
            // navProses2
            // 
            this.navProses2.Dock = System.Windows.Forms.DockStyle.Top;
            this.navProses2.FlatAppearance.BorderSize = 0;
            this.navProses2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navProses2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navProses2.ForeColor = System.Drawing.Color.White;
            this.navProses2.IconChar = FontAwesome.Sharp.IconChar.Th;
            this.navProses2.IconColor = System.Drawing.Color.White;
            this.navProses2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navProses2.IconSize = 32;
            this.navProses2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navProses2.Location = new System.Drawing.Point(0, 321);
            this.navProses2.Name = "navProses2";
            this.navProses2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.navProses2.Size = new System.Drawing.Size(200, 60);
            this.navProses2.TabIndex = 27;
            this.navProses2.Text = "Prediksi (2025)";
            this.navProses2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navProses2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navProses2.UseVisualStyleBackColor = true;
            this.navProses2.Click += new System.EventHandler(this.navProses2_Click);
            // 
            // navProses1
            // 
            this.navProses1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navProses1.FlatAppearance.BorderSize = 0;
            this.navProses1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navProses1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navProses1.ForeColor = System.Drawing.Color.White;
            this.navProses1.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.navProses1.IconColor = System.Drawing.Color.White;
            this.navProses1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navProses1.IconSize = 32;
            this.navProses1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navProses1.Location = new System.Drawing.Point(0, 261);
            this.navProses1.Name = "navProses1";
            this.navProses1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.navProses1.Size = new System.Drawing.Size(200, 60);
            this.navProses1.TabIndex = 26;
            this.navProses1.Text = "Nilai a dan b";
            this.navProses1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navProses1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navProses1.UseVisualStyleBackColor = true;
            this.navProses1.Click += new System.EventHandler(this.navProses1_Click);
            // 
            // navUpload
            // 
            this.navUpload.Dock = System.Windows.Forms.DockStyle.Top;
            this.navUpload.FlatAppearance.BorderSize = 0;
            this.navUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navUpload.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navUpload.ForeColor = System.Drawing.Color.White;
            this.navUpload.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.navUpload.IconColor = System.Drawing.Color.White;
            this.navUpload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navUpload.IconSize = 32;
            this.navUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navUpload.Location = new System.Drawing.Point(0, 201);
            this.navUpload.Name = "navUpload";
            this.navUpload.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.navUpload.Size = new System.Drawing.Size(200, 60);
            this.navUpload.TabIndex = 25;
            this.navUpload.Text = "Input data";
            this.navUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navUpload.UseVisualStyleBackColor = true;
            this.navUpload.Click += new System.EventHandler(this.navUpload_Click);
            // 
            // navHome
            // 
            this.navHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.navHome.FlatAppearance.BorderSize = 0;
            this.navHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navHome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navHome.ForeColor = System.Drawing.Color.White;
            this.navHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.navHome.IconColor = System.Drawing.Color.White;
            this.navHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navHome.IconSize = 32;
            this.navHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navHome.Location = new System.Drawing.Point(0, 141);
            this.navHome.Name = "navHome";
            this.navHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.navHome.Size = new System.Drawing.Size(200, 60);
            this.navHome.TabIndex = 24;
            this.navHome.Text = "Home";
            this.navHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navHome.UseVisualStyleBackColor = true;
            this.navHome.Click += new System.EventHandler(this.navHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prediksi_Regresi_Linear.Properties.Resources.Screenshot_2024_05_06_183556_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(19, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // shutdownButton
            // 
            this.shutdownButton.Image = ((System.Drawing.Image)(resources.GetObject("shutdownButton.Image")));
            this.shutdownButton.Location = new System.Drawing.Point(1217, 21);
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.Size = new System.Drawing.Size(32, 34);
            this.shutdownButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shutdownButton.TabIndex = 3;
            this.shutdownButton.TabStop = false;
            this.shutdownButton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // mainBackground
            // 
            this.mainBackground.BackColor = System.Drawing.SystemColors.Control;
            this.mainBackground.Image = global::Prediksi_Regresi_Linear.Properties.Resources.border;
            this.mainBackground.Location = new System.Drawing.Point(200, 62);
            this.mainBackground.Name = "mainBackground";
            this.mainBackground.Size = new System.Drawing.Size(1080, 720);
            this.mainBackground.TabIndex = 12;
            this.mainBackground.TabStop = false;
            // 
            // panelProses1
            // 
            this.panelProses1.BackColor = System.Drawing.SystemColors.Control;
            this.panelProses1.Location = new System.Drawing.Point(200, 62);
            this.panelProses1.Name = "panelProses1";
            this.panelProses1.Size = new System.Drawing.Size(1080, 720);
            this.panelProses1.TabIndex = 13;
            // 
            // panelGrafik
            // 
            this.panelGrafik.AutoScroll = true;
            this.panelGrafik.AutoScrollMargin = new System.Drawing.Size(0, 100);
            this.panelGrafik.BackColor = System.Drawing.SystemColors.Control;
            this.panelGrafik.Location = new System.Drawing.Point(200, 62);
            this.panelGrafik.Name = "panelGrafik";
            this.panelGrafik.Size = new System.Drawing.Size(1280, 720);
            this.panelGrafik.TabIndex = 16;
            // 
            // panelProses3
            // 
            this.panelProses3.BackColor = System.Drawing.SystemColors.Control;
            this.panelProses3.Location = new System.Drawing.Point(200, 62);
            this.panelProses3.Name = "panelProses3";
            this.panelProses3.Size = new System.Drawing.Size(1280, 720);
            this.panelProses3.TabIndex = 15;
            // 
            // panelProses2
            // 
            this.panelProses2.BackColor = System.Drawing.SystemColors.Control;
            this.panelProses2.Location = new System.Drawing.Point(200, 62);
            this.panelProses2.Name = "panelProses2";
            this.panelProses2.Size = new System.Drawing.Size(1280, 720);
            this.panelProses2.TabIndex = 14;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.SystemColors.Control;
            this.panelHome.Location = new System.Drawing.Point(200, 62);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1280, 720);
            this.panelHome.TabIndex = 0;
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelAbout.Location = new System.Drawing.Point(200, 62);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(1280, 720);
            this.panelAbout.TabIndex = 0;
            // 
            //panelHelp
            //
            this.panelHelp.BackColor = System.Drawing.SystemColors.Control;
            this.panelHelp.Location = new System.Drawing.Point(200, 62);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(1280, 720);
            this.panelHelp.TabIndex = 0;
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.shutdownButton);
            this.Controls.Add(this.mainBackground);
            this.Controls.Add(this.panelProses1);
            this.Controls.Add(this.panelGrafik);
            this.Controls.Add(this.panelProses3);
            this.Controls.Add(this.panelProses2);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.panelHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shutdownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox shutdownButton;
        private System.Windows.Forms.Button btnUpload;
        public System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox mainBackground;
        private Proses_1 panelProses1;
        private Proses_2 panelProses2;
        private proses_3 panelProses3;
        private Home_1 panelHome;
        private About_1 panelAbout;
        private Grafik panelGrafik;
        private panelHelp_1 panelHelp;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton navProses2;
        private FontAwesome.Sharp.IconButton navProses1;
        private FontAwesome.Sharp.IconButton navUpload;
        private FontAwesome.Sharp.IconButton navHome;
        private FontAwesome.Sharp.IconButton navAbout;
        private FontAwesome.Sharp.IconButton navGrafik;
        private FontAwesome.Sharp.IconButton navProses3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

