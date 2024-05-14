using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prediksi_Regresi_Linear
{
    public partial class proses_3 : UserControl
    {
        public proses_3()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            // Ambil Referensi dari Script Lain
            Form1 uploaded = (Form1)Application.OpenForms["Form1"];

            // Data
            (double[] x, List<double[]> yValues) = uploaded.GetXYFromDataGridView(uploaded.mainDataGridView);

            // Data untuk DataGridView baru
            DataTable newDataGrid = new DataTable();
            newDataGrid.Columns.Add("Fungsi", typeof(int));
            newDataGrid.Columns.Add("a", typeof(double));
            newDataGrid.Columns.Add("b", typeof(double));
            newDataGrid.Columns.Add("2020", typeof(double));
            newDataGrid.Columns.Add("2021", typeof(double));
            newDataGrid.Columns.Add("2022", typeof(double));
            newDataGrid.Columns.Add("2023", typeof(double));
            newDataGrid.Columns.Add("2024", typeof(double));
            newDataGrid.Columns.Add("2025", typeof(double));

            // Hitung dan tambahkan hasil ke DataGridView baru
            for (int i = 0; i < yValues.Count; i++)
            {
                double[] y = yValues[i];

                // Lakukan perhitungan regresi linear menggunakan nilai x dan y yang diperoleh
                double sumX = x.Sum();
                double sumY = y.Sum();
                double sumXY = x.Zip(y, (xi, yi) => xi * yi).Sum();
                double sumXSquare = x.Sum(xi => xi * xi);

                double n = x.Length;
                double b = (n * sumXY - sumX * sumY) / ((n * sumXSquare) - (sumX * sumX));
                double a = (sumY - b * sumX) / n;

                // Hitung nilai y pada x=1 sampai x=6
                double[] yAtX = new double[6];
                for (int j = 0; j < 6; j++)
                {
                    yAtX[j] = a + b * (j + 1);
                }

                // Tambahkan hasil ke DataGridView baru
                newDataGrid.Rows.Add(i + 1, a, b, yAtX[0], yAtX[1], yAtX[2], yAtX[3], yAtX[4], yAtX[5]);
            }

            // Tampilkan hasil pada DataGridView baru
            dataGridViewResult2.DataSource = newDataGrid;
        }
    }
}
