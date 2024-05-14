namespace Prediksi_Regresi_Linear
{
    partial class Proses_1
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
            this.dataGridViewCoefficients = new System.Windows.Forms.DataGridView();
            this.btnHitung = new System.Windows.Forms.Button();
            this.bgProces1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoefficients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgProces1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCoefficients
            // 
            this.dataGridViewCoefficients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCoefficients.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewCoefficients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCoefficients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoefficients.Location = new System.Drawing.Point(146, 80);
            this.dataGridViewCoefficients.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCoefficients.Name = "dataGridViewCoefficients";
            this.dataGridViewCoefficients.RowHeadersWidth = 51;
            this.dataGridViewCoefficients.RowTemplate.Height = 24;
            this.dataGridViewCoefficients.Size = new System.Drawing.Size(800, 411);
            this.dataGridViewCoefficients.TabIndex = 11;
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
            this.btnHitung.TabIndex = 12;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = false;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click_1);
            // 
            // bgProces1
            // 
            this.bgProces1.Image = global::Prediksi_Regresi_Linear.Properties.Resources.border;
            this.bgProces1.Location = new System.Drawing.Point(0, 0);
            this.bgProces1.Name = "bgProces1";
            this.bgProces1.Size = new System.Drawing.Size(1080, 720);
            this.bgProces1.TabIndex = 13;
            this.bgProces1.TabStop = false;
            // 
            // Proses_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.dataGridViewCoefficients);
            this.Controls.Add(this.bgProces1);
            this.Name = "Proses_1";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoefficients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgProces1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCoefficients;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.PictureBox bgProces1;
    }
}
