Imports Microsoft.VisualBasic
Imports System
Namespace DateTimeScales
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.nwindDataSet = New DateTimeScales.nwindDataSet()
			Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.ordersTableAdapter = New DateTimeScales.nwindDataSetTableAdapters.OrdersTableAdapter()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.DataAdapter = Me.ordersTableAdapter
			Me.chartControl1.DataSource = Me.ordersBindingSource
			xyDiagram1.AxisX.DateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.Custom
			xyDiagram1.AxisX.DateTimeOptions.FormatString = "yyyy"
			xyDiagram1.AxisX.DateTimeScaleMode = DevExpress.XtraCharts.DateTimeScaleMode.AutomaticIntegral
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.Title.Text = "Sales Average"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Visible = False
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			series1.ArgumentDataMember = "OrderDate"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			sideBySideBarSeriesLabel1.LineVisible = True
			sideBySideBarSeriesLabel1.Visible = False
			series1.Label = sideBySideBarSeriesLabel1
			series1.Name = "Series 1"
			series1.ValueDataMembersSerializable = "Freight"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			sideBySideBarSeriesLabel2.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel2
			Me.chartControl1.Size = New System.Drawing.Size(426, 250)
			Me.chartControl1.TabIndex = 0
'			Me.chartControl1.DateTimeMeasurementUnitsCalculated += New DevExpress.XtraCharts.DateTimeMeasurementUnitsCalculatedEventHandler(Me.chartControl1_DateTimeMeasurementUnitsCalculated);
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.nwindDataSet
			Me.ordersBindingSource.Position = 0
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(426, 250)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
		Private ordersTableAdapter As DateTimeScales.nwindDataSetTableAdapters.OrdersTableAdapter
		Private nwindDataSet As nwindDataSet
		Private ordersBindingSource As System.Windows.Forms.BindingSource
	End Class
End Namespace

