using System;
using DevExpress.XtraCharts;

namespace DateTimeScales {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        #region #OnAxisScaleChangedExample
        private void Form1_Load(object sender, EventArgs e) {
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);
            this.chartControl.AxisScaleChanged += OnAxisScaleChanged;
        }

        private void OnAxisScaleChanged(object sender, AxisScaleChangedEventArgs e) {
            AxisX axis = e.Axis as AxisX;
            DateTimeScaleChangedEventArgs args = e as DateTimeScaleChangedEventArgs;
            if ((args == null) || (args == null)) return;
            axis.Title.Text = String.Format(
                "The Axis Grid Alignment Unit is {0}\r\nThe Axis Measure Unit is {1}", 
                args.GridAlignmentChange.NewValue,
                args.MeasureUnitChange.NewValue);
        }
        #endregion #OnAxisScaleChangedExample
    }
}
