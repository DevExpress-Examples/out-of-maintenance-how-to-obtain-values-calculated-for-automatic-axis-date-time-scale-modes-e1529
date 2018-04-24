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
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.ordersTableAdapter = New DateTimeScales.nwindDataSetTableAdapters.OrdersTableAdapter()
            Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New DateTimeScales.nwindDataSet()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.DataAdapter = Me.ordersTableAdapter
            Me.chartControl1.DataSource = Me.ordersBindingSource
            xyDiagram1.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic
            xyDiagram1.AxisX.Label.DateTimeOptions.AutoFormat = False
            xyDiagram1.AxisX.Label.DateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.MonthAndDay
            xyDiagram1.AxisX.Title.Text = "Sales Average"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.ArgumentDataMember = "OrderDate"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.Name = "Series 1"
            series1.ValueDataMembersSerializable = "Freight"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chartControl1.Size = New System.Drawing.Size(578, 358)
            Me.chartControl1.TabIndex = 0
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
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(578, 358)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
        Private ordersTableAdapter As nwindDataSetTableAdapters.OrdersTableAdapter
        Private nwindDataSet As nwindDataSet
        Private ordersBindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace

