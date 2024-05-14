namespace Prediksi_Regresi_Linear
{
    partial class About_1
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
            this.bgAbout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bgAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // bgAbout
            // 
            this.bgAbout.Image = global::Prediksi_Regresi_Linear.Properties.Resources.about;
            this.bgAbout.Location = new System.Drawing.Point(0, 0);
            this.bgAbout.Name = "bgAbout";
            this.bgAbout.Size = new System.Drawing.Size(1080, 720);
            this.bgAbout.TabIndex = 0;
            this.bgAbout.TabStop = false;
            // 
            // About_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.bgAbout);
            this.Name = "About_1";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.bgAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bgAbout;
    }
}
