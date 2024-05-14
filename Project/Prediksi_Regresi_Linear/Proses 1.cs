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
    public partial class Proses_1 : UserControl
    {
        public Proses_1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click_1(object sender, EventArgs e)
        {
            // Ambil Referensi dari Script Lain
            Form1 uploaded = (Form1)Application.OpenForms["Form1"];

            // Data
            (double[] x, List<double[]> yValues) = uploaded.GetXYFromDataGridView(uploaded.mainDataGridView);

            // Display results
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Fungsi", typeof(int));
            dataTable.Columns.Add("a", typeof(double));
            dataTable.Columns.Add("b", typeof(double));

            for (int i = 0; i < yValues.Count; i++)
            {
                double[] y = yValues[i];

                // Calculations
                double sumX = x.Sum();
                double sumY = y.Sum();
                double sumXY = x.Zip(y, (xi, yi) => xi * yi).Sum();
                double sumXSquare = x.Sum(xi => xi * xi);

                double n = x.Length;
                double a = ((sumY * sumXSquare) - (sumX * sumXY)) / ((n * sumXSquare) - (sumX * sumX));
                double b = (n * sumXY - sumX * sumY) / ((n * sumXSquare) - (sumX * sumX));

                // Add to DataTable
                dataTable.Rows.Add(i + 1, a, b);
            }

            // Display results
            dataGridViewCoefficients.DataSource = dataTable;
        }
    }
}
