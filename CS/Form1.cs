using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace ChangeNames4AutoSeries {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.gSPTableAdapter.Fill(this.gspDataSet.GSP);
        }

        private void chartControl1_CustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {
            e.LegendText = e.LegendText.Remove(0, 3);
        }
    }
}
