using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace DateTimeScales {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);
        }

        private void OnDateTimeMeasurementUnitsCalculated(object sender, DateTimeMeasurementUnitsCalculatedEventArgs e) {
            // In this event, you can access the properties of the corresponding axis, and
            // obtain the automatically calculated value for the axis date-time grid alignment and measure unit.
            ((AxisX)e.Axis).Title.Visible = true;
            ((AxisX)e.Axis).Title.Text = "The Axis Grid Alignment Unit is " + e.GridAlignment.ToString() +
                "\r\nThe Axis Measure Unit is " + e.MeasureUnit.ToString();
        }
    }
}
