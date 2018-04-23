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
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.NwindDataSet = New nwindDataSet()
            Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.OrdersTableAdapter = New nwindDataSetTableAdapters.OrdersTableAdapter()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.DataAdapter = Me.OrdersTableAdapter
            Me.chartControl1.DataSource = Me.OrdersBindingSource
            XyDiagram1.AxisX.DateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.MonthAndDay
            XyDiagram1.AxisX.DateTimeScaleMode = DevExpress.XtraCharts.DateTimeScaleMode.AutomaticIntegral
            XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
            XyDiagram1.AxisX.Range.SideMarginsEnabled = True
            XyDiagram1.AxisX.Title.Text = "Sales Average"
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
            XyDiagram1.AxisY.Range.SideMarginsEnabled = True
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = XyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Series1.ArgumentDataMember = "OrderDate"
            Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            SideBySideBarSeriesLabel1.LineVisible = True
            Series1.Label = SideBySideBarSeriesLabel1
            Series1.Name = "Series 1"
            Series1.ValueDataMembersSerializable = "Freight"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
            SideBySideBarSeriesLabel2.LineVisible = True
            Me.chartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel2
            Me.chartControl1.Size = New System.Drawing.Size(578, 358)
            Me.chartControl1.TabIndex = 0
            '
            'NwindDataSet
            '
            Me.NwindDataSet.DataSetName = "nwindDataSet"
            Me.NwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'OrdersBindingSource
            '
            Me.OrdersBindingSource.DataMember = "Orders"
            Me.OrdersBindingSource.DataSource = Me.NwindDataSet
            '
            'OrdersTableAdapter
            '
            Me.OrdersTableAdapter.ClearBeforeFill = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(578, 358)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

        Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
        Friend WithEvents OrdersTableAdapter As nwindDataSetTableAdapters.OrdersTableAdapter
        Friend WithEvents NwindDataSet As nwindDataSet
        Friend WithEvents OrdersBindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace

