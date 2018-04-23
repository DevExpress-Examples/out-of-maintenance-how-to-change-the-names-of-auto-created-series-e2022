using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace ChangeNames4AutoSeries {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'gspDataSet.GSP' table. You can move, or remove it, as needed.
            this.gSPTableAdapter.Fill(this.gspDataSet.GSP);
        }

        private void chartControl1_CustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {
            e.LegendText = e.LegendText.Remove(0, 3);
        }

    }
}