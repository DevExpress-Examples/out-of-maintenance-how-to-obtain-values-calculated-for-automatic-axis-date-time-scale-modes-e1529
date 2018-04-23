using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace DateTimeScales {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);

        }

        private void chartControl1_DateTimeMeasurementUnitsCalculated(object sender, 
            DateTimeMeasurementUnitsCalculatedEventArgs e) {
            // In this event, you can access the properties of the corresponding axis, and
            // obtain the automatically calculated value for the axis date-time grid alignment and measure unit.
            ((AxisX)e.Axis).Title.Visible = true;
            ((AxisX)e.Axis).Title.Text = "The Axis Grid Alignment Unit is " + e.GridAlignment.ToString() +
                "\r\nThe Axis Measure Unit is " + e.MeasureUnit.ToString();
        }

    }
}