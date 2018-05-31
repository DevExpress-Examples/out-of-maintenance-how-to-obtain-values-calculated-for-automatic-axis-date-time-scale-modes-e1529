Namespace DateTimeScales
    Partial Public Class MainForm
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
            Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim lineSeriesView3 As New DevExpress.XtraCharts.LineSeriesView()
            Dim lineSeriesView4 As New DevExpress.XtraCharts.LineSeriesView()
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            Me.ordersTableAdapter = New DateTimeScales.nwindDataSetTableAdapters.OrdersTableAdapter()
            Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New DateTimeScales.nwindDataSet()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(lineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(lineSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl
            ' 
            Me.chartControl.DataAdapter = Me.ordersTableAdapter
            Me.chartControl.DataSource = Me.ordersBindingSource
            xyDiagram2.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic
            xyDiagram2.AxisX.Label.TextPattern = "{A:m}"
            xyDiagram2.AxisX.Title.Text = ""
            xyDiagram2.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram2.AxisX.WholeRange.SideMarginsValue = 0R
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram2.EnableAxisXScrolling = True
            xyDiagram2.EnableAxisXZooming = True
            Me.chartControl.Diagram = xyDiagram2
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Legend.Name = "Default Legend"
            Me.chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl.Location = New System.Drawing.Point(0, 0)
            Me.chartControl.Name = "chartControl"
            series2.ArgumentDataMember = "OrderDate"
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series2.Name = "Series 1"
            series2.ValueDataMembersSerializable = "Freight"
            series2.View = lineSeriesView3
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() { series2}
            Me.chartControl.SeriesTemplate.View = lineSeriesView4
            Me.chartControl.Size = New System.Drawing.Size(718, 373)
            Me.chartControl.TabIndex = 0
            ' 
            ' ordersTableAdapter
            ' 
            Me.ordersTableAdapter.ClearBeforeFill = True
            ' 
            ' ordersBindingSource
            ' 
            Me.ordersBindingSource.DataMember = "Orders"
            Me.ordersBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(718, 373)
            Me.Controls.Add(Me.chartControl)
            Me.Name = "MainForm"
            Me.Text = "Zoom the Chart or Resize the Window to See Changes"
            CType(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(lineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(lineSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents chartControl As DevExpress.XtraCharts.ChartControl
        Private ordersTableAdapter As nwindDataSetTableAdapters.OrdersTableAdapter
        Private nwindDataSet As nwindDataSet
        Private ordersBindingSource As System.Windows.Forms.BindingSource
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

