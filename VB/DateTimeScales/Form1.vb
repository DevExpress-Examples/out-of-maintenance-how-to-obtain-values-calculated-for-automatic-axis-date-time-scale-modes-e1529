Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace DateTimeScales
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
			Me.ordersTableAdapter.Fill(Me.nwindDataSet.Orders)

		End Sub

		Private Sub chartControl1_DateTimeMeasurementUnitsCalculated(ByVal sender As Object, _ 
                                    ByVal e As DateTimeMeasurementUnitsCalculatedEventArgs) _ 
                                    Handles chartControl1.DateTimeMeasurementUnitsCalculated
			' In this event, you can access the properties of the corresponding axis, and
			' obtain the automatically calculated value for the axis date-time grid alignment and measure unit.
			CType(e.Axis, AxisX).Title.Visible = True
			CType(e.Axis, AxisX).Title.Text = "The Axis Grid Alignment Unit is " & e.GridAlignment.ToString() & _ 
                                                    Constants.vbCrLf & "The Axis Measure Unit is " & e.MeasureUnit.ToString()
		End Sub

	End Class
End Namespace