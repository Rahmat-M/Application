namespace Prediksi_Regresi_Linear
{
    partial class proses_3
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
            this.dataGridViewResult2 = new System.Windows.Forms.DataGridView();
            this.btnHitung = new System.Windows.Forms.Button();
            this.bgProces3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgProces3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResult2
            // 
            this.dataGridViewResult2.AccessibleName = "";
            this.dataGridViewResult2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult2.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewResult2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResult2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult2.Location = new System.Drawing.Point(60, 88);
            this.dataGridViewResult2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewResult2.Name = "dataGridViewResult2";
            this.dataGridViewResult2.RowHeadersWidth = 51;
            this.dataGridViewResult2.RowTemplate.Height = 24;
            this.dataGridViewResult2.Size = new System.Drawing.Size(967, 411);
            this.dataGridViewResult2.TabIndex = 14;
            // 
            // btnHitung
            // 
            this.btnHitung.BackColor = System.Drawing.Color.DarkCyan;
            this.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHitung.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHitung.ForeColor = System.Drawing.Color.White;
            this.btnHitung.Location = new System.Drawing.Point(482, 529);
            this.btnHitung.Margin = new System.Windows.Forms.Padding(2);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(140, 37);
            this.btnHitung.TabIndex = 16;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = false;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // bgProces3
            // 
            this.bgProces3.Image = global::Prediksi_Regresi_Linear.Properties.Resources.border;
            this.bgProces3.Location = new System.Drawing.Point(0, 0);
            this.bgProces3.Name = "bgProces3";
            this.bgProces3.Size = new System.Drawing.Size(1080, 720);
            this.bgProces3.TabIndex = 17;
            this.bgProces3.TabStop = false;
            // 
            // proses_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.dataGridViewResult2);
            this.Controls.Add(this.bgProces3);
            this.Name = "proses_3";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgProces3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewResult2;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.PictureBox bgProces3;
    }
}
