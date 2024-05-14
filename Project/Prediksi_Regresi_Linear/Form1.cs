using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Prediksi_Regresi_Linear
{
    public partial class Form1 : Form
    {
        Proses_1 proses1 = new Proses_1();
        //field
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        //constructor
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //menghilangkan control box form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private struct RGBcolors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(120, 207, 227);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(120, 207, 227);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(120, 207, 227);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(120, 207, 227);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(120, 207, 227);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(120, 207, 227);
        }
        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon current child form
                
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                leftBorderBtn.Visible = false;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(41, 39, 40);
                currentBtn.ForeColor = System.Drawing.Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";
            openFileDialog.Title = "Select a CSV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    DataTable dataTable = new DataTable();
                    string[] lines = File.ReadAllLines(filePath);

                    // header
                    string[] headers = lines[0].Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    // ambil data dari file
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] data = lines[i].Split(',');
                        dataTable.Rows.Add(data);
                    }

                    mainDataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        public (double[] x, List<double[]> yValues) GetXYFromDataGridView(DataGridView dataGridView)
        {
            List<double[]> yValues = new List<double[]>();

            // Ambil nilai x yang sudah ditentukan
            double[] xValues = { 1, 2, 3, 4, 5 };

            // Ambil nilai y dari setiap baris di DataGridView, dimulai dari kolom kedua
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Skip baris pertama karena itu adalah label kolom
                if (row.Index != 0)
                {
                    List<double> yRowValues = new List<double>();

                    // Start iterating from the second column
                    for (int i = 1; i < row.Cells.Count; i++)
                    {
                        DataGridViewCell cell = row.Cells[i];

                        double y;
                        if (cell.Value != null && double.TryParse(cell.Value.ToString(), out y))
                        {
                            yRowValues.Add(y);
                        }
                    }

                    yValues.Add(yRowValues.ToArray());
                }
            }

            return (xValues, yValues);
        }

        private void navHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color1);
            panelHome.BringToFront();
        }

        private void navUpload_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color2);
            mainBackground.BringToFront();
            btnUpload.BringToFront();
            mainDataGridView.BringToFront();
            label1.BringToFront();
            label2.BringToFront();
        }

        private void navProses1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color3);
            panelProses1.BringToFront();


        }

        private void navProses2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color4);
            panelProses2.BringToFront();
            
        }

        private void navProses3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color5);
            panelProses3.BringToFront();
        }

        private void navGrafik_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color6);
            panelGrafik.BringToFront();
        }

        private void navAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color1);
            panelAbout.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panelHelp.BringToFront();
            DisableButton();
        }
    }
}
