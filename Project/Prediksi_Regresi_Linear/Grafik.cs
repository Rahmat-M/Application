using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Prediksi_Regresi_Linear
{
    public partial class Grafik : UserControl
    {
        public Grafik()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            // Ambil Referensi dari Script Lain
            Form1 uploaded = (Form1)Application.OpenForms["Form1"];

            // Data
            (double[] x, List<double[]> yValues) = uploaded.GetXYFromDataGridView(uploaded.mainDataGridView);
            // Ambil sel dari kolom pertama dan baris kedua
            


            // Hitung regresi linear untuk fungsi pertama
            double[] y1 = yValues[0];
            double sumX1 = x.Sum();
            double sumY1 = y1.Sum();
            double sumXY1 = x.Zip(y1, (xi, yi) => xi * yi).Sum();
            double sumXSquare1 = x.Sum(xi => xi * xi);
            double n1 = x.Length;
            double b1 = (n1 * sumXY1 - sumX1 * sumY1) / ((n1 * sumXSquare1) - (sumX1 * sumX1));
            double a1 = (sumY1 - b1 * sumX1) / n1;

            // Hitung nilai y prediksi untuk x dari 1 sampai 6
            double[] predictedY1 = new double[6];
            for (int i = 0; i < 6; i++)
            {
                predictedY1[i] = a1 + b1 * (i + 1);
            }

            // Tampilkan hasil untuk fungsi pertama pada DataGridViewResult

            // Membuat chart untuk fungsi pertama
            chart1.Series.Clear(); // Bersihkan chart sebelum menambahkan yang baru


            // Tambahkan data asli dari fungsi pertama
            Series series1 = new Series();
            series1.Name = "Data Asli"; // Set label series
            series1.ChartType = SeriesChartType.Line;
            for (int i = 0; i < x.Length; i++)
            {
                series1.Points.AddXY(x[i], y1[i]);
            }
            chart1.Series.Add(series1);

            // Tambahkan data prediksi dari fungsi pertama
            Series series2 = new Series();
            series2.Name = "Data Prediksi"; // Set label series
            series2.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 6; i++)
            {
                series2.Points.AddXY(i + 1, predictedY1[i]);
            }
            chart1.Series.Add(series2);




            // Hitung regresi linear untuk fungsi kedua
            double[] y2 = yValues[1];
            double sumX2 = x.Sum();
            double sumY2 = y2.Sum();
            double sumXY2 = x.Zip(y2, (xi, yi) => xi * yi).Sum();
            double sumXSquare2 = x.Sum(xi => xi * xi);
            double n2 = x.Length;
            double b2 = (n2 * sumXY2 - sumX2 * sumY2) / ((n2 * sumXSquare2) - (sumX2 * sumX2));
            double a2 = (sumY2 - b2 * sumX2) / n2;

            // Hitung nilai y prediksi untuk x dari 1 sampai 6
            double[] predictedY2 = new double[6];
            for (int i = 0; i < 6; i++)
            {
                predictedY2[i] = a2 + b2 * (i + 1);
            }

            // Membuat chart untuk fungsi kedua
            chart2.Series.Clear(); // Bersihkan chart sebelum menambahkan yang baru

            // Tambahkan data asli dari fungsi kedua
            Series series3 = new Series();
            series3.Name = "Data Asli"; // Set label series
            series3.ChartType = SeriesChartType.Line;
            for (int i = 0; i < x.Length; i++)
            {
                series3.Points.AddXY(x[i], y2[i]);
            }
            chart2.Series.Add(series3);

            // Tambahkan data prediksi dari fungsi kedua
            Series series4 = new Series();
            series4.Name = "Data Prediksi"; // Set label series
            series4.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 6; i++)
            {
                series4.Points.AddXY(i + 1, predictedY2[i]);
            }
            chart2.Series.Add(series4);

            // Mengatur range angka pada sumbu y dari 0 sampai 100
            chart2.ChartAreas[0].AxisY.Minimum = 100000;
            chart2.ChartAreas[0].AxisY.Maximum = 150000;




            // Hitung regresi linear untuk fungsi ketiga
            double[] y3 = yValues[2];
            double sumX3 = x.Sum();
            double sumY3 = y3.Sum();
            double sumXY3 = x.Zip(y3, (xi, yi) => xi * yi).Sum();
            double sumXSquare3 = x.Sum(xi => xi * xi);
            double n3 = x.Length;
            double b3 = (n3 * sumXY3 - sumX3 * sumY3) / ((n3 * sumXSquare3) - (sumX3 * sumX3));
            double a3 = (sumY3 - b3 * sumX3) / n3;

            // Hitung nilai y prediksi untuk x dari 1 sampai 6
            double[] predictedY3 = new double[6];
            for (int i = 0; i < 6; i++)
            {
                predictedY3[i] = a3 + b3 * (i + 1);
            }

            // Tampilkan hasil untuk fungsi ketiga pada DataGridViewResult

            // Membuat chart untuk fungsi ketiga
            chart3.Series.Clear(); // Bersihkan chart sebelum menambahkan yang baru

            // Tambahkan data asli dari fungsi ketiga
            Series series5 = new Series();
            series5.Name = "Data Asli"; // Set label series
            series5.ChartType = SeriesChartType.Line;
            for (int i = 0; i < x.Length; i++)
            {
                series5.Points.AddXY(x[i], y3[i]);
            }
            chart3.Series.Add(series5);

            // Tambahkan data prediksi dari fungsi ketiga
            Series series6 = new Series();
            series6.Name = "Data Prediksi"; // Set label series
            series6.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 6; i++)
            {
                series6.Points.AddXY(i + 1, predictedY3[i]);
            }
            chart3.Series.Add(series6);



            // Hitung regresi linear untuk fungsi keempat
            double[] y4 = yValues[3];
            double sumX4 = x.Sum();
            double sumY4 = y4.Sum();
            double sumXY4 = x.Zip(y4, (xi, yi) => xi * yi).Sum();
            double sumXSquare4 = x.Sum(xi => xi * xi);
            double n4 = x.Length;
            double b4 = (n4 * sumXY4 - sumX4 * sumY4) / ((n4 * sumXSquare4) - (sumX4 * sumX4));
            double a4 = (sumY4 - b4 * sumX4) / n4;

            // Hitung nilai y prediksi untuk x dari 1 sampai 6
            double[] predictedY4 = new double[6];
            for (int i = 0; i < 6; i++)
            {
                predictedY4[i] = a4 + b4 * (i + 1);
            }

            // Tampilkan hasil untuk fungsi ketiga pada DataGridViewResult

            // Membuat chart untuk fungsi ketiga
            chart4.Series.Clear(); // Bersihkan chart sebelum menambahkan yang baru

            // Tambahkan data asli dari fungsi ketiga
            Series series7 = new Series();
            series7.Name = "Data Asli"; // Set label series
            series7.ChartType = SeriesChartType.Line;
            for (int i = 0; i < x.Length; i++)
            {
                series7.Points.AddXY(x[i], y4[i]);
            }
            chart4.Series.Add(series7);

            // Tambahkan data prediksi dari fungsi ketiga
            Series series8 = new Series();
            series8.Name = "Data Prediksi"; // Set label series
            series8.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 6; i++)
            {
                series8.Points.AddXY(i + 1, predictedY4[i]);
            }
            chart4.Series.Add(series8);


            // Hitung regresi linear untuk fungsi kelima
            double[] y5 = yValues[4];
            double sumX5 = x.Sum();
            double sumY5 = y5.Sum();
            double sumXY5 = x.Zip(y5, (xi, yi) => xi * yi).Sum();
            double sumXSquare5 = x.Sum(xi => xi * xi);
            double n5 = x.Length;
            double b5 = (n5 * sumXY5 - sumX5 * sumY5) / ((n5 * sumXSquare5) - (sumX5 * sumX5));
            double a5 = (sumY5 - b5 * sumX5) / n5;

            // Hitung nilai y prediksi untuk x dari 1 sampai 6
            double[] predictedY5 = new double[6];
            for (int i = 0; i < 6; i++)
            {
                predictedY5[i] = a5 + b5 * (i + 1);
            }

            // Tampilkan hasil untuk fungsi kelima pada DataGridViewResult

            // Membuat chart untuk fungsi kelima
            chart5.Series.Clear(); // Bersihkan chart sebelum menambahkan yang baru

            // Tambahkan data asli dari fungsi kelima
            Series series9 = new Series();
            series9.Name = "Data Asli"; // Set label series
            series9.ChartType = SeriesChartType.Line;
            for (int i = 0; i < x.Length; i++)
            {
                series9.Points.AddXY(x[i], y5[i]);
            }
            chart5.Series.Add(series9);

            // Tambahkan data prediksi dari fungsi kelima
            Series series10 = new Series();
            series10.Name = "Data Prediksi"; // Set label series
            series10.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 6; i++)
            {
                series10.Points.AddXY(i + 1, predictedY5[i]);
            }
            chart5.Series.Add(series10);


            // Hitung regresi linear untuk fungsi keenam
            double[] y6 = yValues[5];
            double sumX6 = x.Sum();
            double sumY6 = y6.Sum();
            double sumXY6 = x.Zip(y6, (xi, yi) => xi * yi).Sum();
            double sumXSquare6 = x.Sum(xi => xi * xi);
            double n6 = x.Length;
            double b6 = (n6 * sumXY6 - sumX6 * sumY6) / ((n6 * sumXSquare6) - (sumX6 * sumX6));
            double a6 = (sumY6 - b6 * sumX6) / n6;

            // Hitung nilai y prediksi untuk x dari 1 sampai 6
            double[] predictedY6 = new double[6];
            for (int i = 0; i < 6; i++)
            {
                predictedY6[i] = a6 + b6 * (i + 1);
            }

            // Tampilkan hasil untuk fungsi keenam pada DataGridViewResult

            // Membuat chart untuk fungsi keenam
            chart6.Series.Clear(); // Bersihkan chart sebelum menambahkan yang baru

            // Tambahkan data asli dari fungsi keenam
            Series series11 = new Series();
            series11.Name = "Data Asli"; // Set label series
            series11.ChartType = SeriesChartType.Line;
            for (int i = 0; i < x.Length; i++)
            {
                series11.Points.AddXY(x[i], y6[i]);
            }
            chart6.Series.Add(series11);

            // Tambahkan data prediksi dari fungsi keenam
            Series series12 = new Series();
            series12.Name = "Data Prediksi"; // Set label series
            series12.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 6; i++)
            {
                series12.Points.AddXY(i + 1, predictedY6[i]);
            }
            chart6.Series.Add(series12);


            // Hitung regresi linear untuk fungsi ketujuh
            double[] y7 = yValues[6];
            double sumX7 = x.Sum();
            double sumY7 = y7.Sum();
            double sumXY7 = x.Zip(y7, (xi, yi) => xi * yi).Sum();
            double sumXSquare7 = x.Sum(xi => xi * xi);
            double n7 = x.Length;
            double b7 = (n7 * sumXY7 - sumX7 * sumY7) / ((n7 * sumXSquare7) - (sumX7 * sumX7));
            double a7 = (sumY7 - b7 * sumX7) / n7;

            // Hitung nilai y prediksi untuk x dari 1 sampai 6
            double[] predictedY7 = new double[6];
            for (int i = 0; i < 6; i++)
            {
                predictedY7[i] = a7 + b7 * (i + 1);
            }

            // Tampilkan hasil untuk fungsi ketujuh pada DataGridViewResult

            // Membuat chart untuk fungsi ketujuh
            chart7.Series.Clear(); // Bersihkan chart sebelum menambahkan yang baru

            // Tambahkan data asli dari fungsi ketujuh
            Series series13 = new Series();
            series13.Name = "Data Asli"; // Set label series
            series13.ChartType = SeriesChartType.Line;
            for (int i = 0; i < x.Length; i++)
            {
                series13.Points.AddXY(x[i], y7[i]);
            }
            chart7.Series.Add(series13);

            // Tambahkan data prediksi dari fungsi ketujuh
            Series series14 = new Series();
            series14.Name = "Data Prediksi"; // Set label series
            series14.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 6; i++)
            {
                series14.Points.AddXY(i + 1, predictedY7[i]);
            }
            chart7.Series.Add(series14);

            
            // Hitung regresi linear untuk fungsi kedelapan
            double[] y8 = yValues[7];
            double sumX8 = x.Sum();
            double sumY8 = y8.Sum();
            double sumXY8 = x.Zip(y8, (xi, yi) => xi * yi).Sum();
            double sumXSquare8 = x.Sum(xi => xi * xi);
            double n8 = x.Length;
            double b8 = (n8 * sumXY8 - sumX8 * sumY8) / ((n8 * sumXSquare8) - (sumX8 * sumX8));
            double a8 = (sumY8 - b8 * sumX8) / n8;

            // Hitung nilai y prediksi untuk x dari 1 sampai 6
            double[] predictedY8 = new double[6];
            for (int i = 0; i < 6; i++)
            {
                predictedY8[i] = a8 + b8 * (i + 1);
            }

            // Tampilkan hasil untuk fungsi kedelapan pada DataGridViewResult

            // Membuat chart untuk fungsi kedelapan
            chart8.Series.Clear(); // Bersihkan chart sebelum menambahkan yang baru

            // Tambahkan data asli dari fungsi kedelapan
            Series series15 = new Series();
            series15.Name = "Data Asli"; // Set label series
            series15.ChartType = SeriesChartType.Line;
            for (int i = 0; i < x.Length; i++)
            {
                series15.Points.AddXY(x[i], y8[i]);
            }
            chart8.Series.Add(series15);

            // Tambahkan data prediksi dari fungsi kedelapan
            Series series16 = new Series();
            series16.Name = "Data Prediksi"; // Set label series
            series16.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 6; i++)
            {
                series16.Points.AddXY(i + 1, predictedY8[i]);
            }
            chart8.Series.Add(series16);


            // Hitung regresi linear untuk fungsi kesembilan
            double[] y9 = yValues[8];
            double sumX9 = x.Sum();
            double sumY9 = y9.Sum();
            double sumXY9 = x.Zip(y9, (xi, yi) => xi * yi).Sum();
            double sumXSquare9 = x.Sum(xi => xi * xi);
            double n9 = x.Length;
            double b9 = (n9 * sumXY9 - sumX9 * sumY9) / ((n9 * sumXSquare9) - (sumX9 * sumX9));
            double a9 = (sumY9 - b9 * sumX9) / n9;

            // Hitung nilai y prediksi untuk x dari 1 sampai 6
            double[] predictedY9 = new double[6];
            for (int i = 0; i < 6; i++)
            {
                predictedY9[i] = a9 + b9 * (i + 1);
            }

            // Tampilkan hasil untuk fungsi kesembilan pada DataGridViewResult

            // Membuat chart untuk fungsi kesembilan
            chart9.Series.Clear(); // Bersihkan chart sebelum menambahkan yang baru

            // Tambahkan data asli dari fungsi kesembilan
            Series series17 = new Series();
            series17.Name = "Data Asli"; // Set label series
            series17.ChartType = SeriesChartType.Line;
            for (int i = 0; i < x.Length; i++)
            {
                series17.Points.AddXY(x[i], y9[i]);
            }
            chart9.Series.Add(series17);

            // Tambahkan data prediksi dari fungsi kesembilan
            Series series18 = new Series();
            series18.Name = "Data Prediksi"; // Set label series
            series18.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 6; i++)
            {
                series18.Points.AddXY(i + 1, predictedY9[i]);
            }
            chart9.Series.Add(series18);

            // Mengatur range angka pada sumbu y dari 0 sampai 100
            chart9.ChartAreas[0].AxisY.Minimum = 6000;
            chart9.ChartAreas[0].AxisY.Maximum = 15000;


            // Hitung regresi linear untuk fungsi kesepuluh
            double[] y10 = yValues[9];
            double sumX10 = x.Sum();
            double sumY10 = y10.Sum();
            double sumXY10 = x.Zip(y10, (xi, yi) => xi * yi).Sum();
            double sumXSquare10 = x.Sum(xi => xi * xi);
            double n10 = x.Length;
            double b10 = (n10 * sumXY10 - sumX10 * sumY10) / ((n10 * sumXSquare10) - (sumX10 * sumX10));
            double a10 = (sumY10 - b10 * sumX10) / n10;

            // Hitung nilai y prediksi untuk x dari 1 sampai 6
            double[] predictedY10 = new double[6];
            for (int i = 0; i < 6; i++)
            {
                predictedY10[i] = a10 + b10 * (i + 1);
            }

            // Tampilkan hasil untuk fungsi kesepuluh pada DataGridViewResult

            // Membuat chart untuk fungsi kesepuluh
            chart10.Series.Clear(); // Bersihkan chart sebelum menambahkan yang baru

            // Tambahkan data asli dari fungsi kesepuluh
            Series series19 = new Series();
            series19.Name = "Data Asli"; // Set label series
            series19.ChartType = SeriesChartType.Line;
            for (int i = 0; i < x.Length; i++)
            {
                series19.Points.AddXY(x[i], y10[i]);
            }
            chart10.Series.Add(series19);

            // Tambahkan data prediksi dari fungsi kesepuluh
            Series series20 = new Series();
            series20.Name = "Data Prediksi"; // Set label series
            series20.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 6; i++)
            {
                series20.Points.AddXY(i + 1, predictedY10[i]);
            }
            chart10.Series.Add(series20);


            // Hitung regresi linear untuk fungsi kesebelas
            double[] y11 = yValues[10];
            double sumX11 = x.Sum();
            double sumY11 = y11.Sum();
            double sumXY11 = x.Zip(y11, (xi, yi) => xi * yi).Sum();
            double sumXSquare11 = x.Sum(xi => xi * xi);
            double n11 = x.Length;
            double b11 = (n11 * sumXY11 - sumX11 * sumY11) / ((n11 * sumXSquare11) - (sumX11 * sumX11));
            double a11 = (sumY11 - b11 * sumX11) / n11;

            // Hitung nilai y prediksi untuk x dari 1 sampai 6
            double[] predictedY11 = new double[6];
            for (int i = 0; i < 6; i++)
            {
                predictedY11[i] = a11 + b11 * (i + 1);
            }

            // Tampilkan hasil untuk fungsi kesebelas pada DataGridViewResult

            // Membuat chart untuk fungsi kesebelas
            chart11.Series.Clear(); // Bersihkan chart sebelum menambahkan yang baru

            // Tambahkan data asli dari fungsi kesebelas
            Series series21 = new Series();
            series21.Name = "Data Asli"; // Set label series
            series21.ChartType = SeriesChartType.Line;
            for (int i = 0; i < x.Length; i++)
            {
                series21.Points.AddXY(x[i], y11[i]);
            }
            chart11.Series.Add(series21);

            // Tambahkan data prediksi dari fungsi kesebelas
            Series series22 = new Series();
            series22.Name = "Data Prediksi"; // Set label series
            series22.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 6; i++)
            {
                series22.Points.AddXY(i + 1, predictedY11[i]);
            }
            chart11.Series.Add(series22);

            // Mengatur range angka pada sumbu y dari 0 sampai 100
            chart11.ChartAreas[0].AxisY.Minimum = 150000;
            chart11.ChartAreas[0].AxisY.Maximum = 300000;


            // Memberi judul pada chart pertama
            chart1.Titles.Add("Pelayanan umum");

            // Memberi judul pada chart kedua
            chart2.Titles.Add("Pertahanan");

            // Memberi judul pada chart ketiga
            chart3.Titles.Add("Ketertiban dan keamanan");

            // Memberi judul pada chart keempat
            chart4.Titles.Add("Ekonomi");

            // Memberi judul pada chart kelima
            chart5.Titles.Add("Lingkungan hidup");

            // Memberi judul pada chart keenam
            chart6.Titles.Add("Perumahan dan fasilitas umum");

            // Memberi judul pada chart ketujuh
            chart7.Titles.Add("Kesehatan");

            // Memberi judul pada chart kedelapan
            chart8.Titles.Add("Pariwisata dan budaya");

            // Memberi judul pada chart kesembilan
            chart9.Titles.Add("Agama");

            // Memberi judul pada chart kesepuluh
            chart10.Titles.Add("Pendidikan");

            // Memberi judul pada chart kesebelas
            chart11.Titles.Add("Perlindungan sosial");



        }
    }
}
