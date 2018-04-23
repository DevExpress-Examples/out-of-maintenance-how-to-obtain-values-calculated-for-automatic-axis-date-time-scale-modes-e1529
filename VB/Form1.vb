Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace DateTimeScales
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.OrdersTableAdapter.Fill(Me.NwindDataSet.Orders)
            Me.OrdersTableAdapter.Fill(Me.NwindDataSet.Orders)
		End Sub

        Private Sub OnDateTimeMeasurementUnitsCalculated(ByVal sender As Object, ByVal e As DateTimeMeasurementUnitsCalculatedEventArgs) _
        Handles chartControl1.DateTimeMeasurementUnitsCalculated
            ' In this event, you can access the properties of the corresponding axis, and
            ' obtain the automatically calculated value for the axis date-time grid alignment and measure unit.
            CType(e.Axis, AxisX).Title.Visible = True
            CType(e.Axis, AxisX).Title.Text = "The Axis Grid Alignment Unit is " & e.GridAlignment.ToString() & _
                Constants.vbCrLf & "The Axis Measure Unit is " & e.MeasureUnit.ToString()
        End Sub
	End Class
End Namespace
