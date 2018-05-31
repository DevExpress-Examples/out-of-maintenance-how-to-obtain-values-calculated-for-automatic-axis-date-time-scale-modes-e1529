Imports System
Imports DevExpress.XtraCharts

Namespace DateTimeScales
    Partial Public Class MainForm
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#OnAxisScaleChangedExample"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Me.ordersTableAdapter.Fill(Me.nwindDataSet.Orders)
            AddHandler Me.chartControl.AxisScaleChanged, AddressOf OnAxisScaleChanged
        End Sub

        Private Sub OnAxisScaleChanged(ByVal sender As Object, ByVal e As AxisScaleChangedEventArgs) Handles chartControl.AxisScaleChanged
            Dim axis As AxisX = TryCast(e.Axis, AxisX)
            Dim args As DateTimeScaleChangedEventArgs = TryCast(e, DateTimeScaleChangedEventArgs)
            If (args Is Nothing) OrElse (args Is Nothing) Then
                Return
            End If
            axis.Title.Text = String.Format("The Axis Grid Alignment Unit is {0}" & ControlChars.CrLf & "The Axis Measure Unit is {1}", args.GridAlignmentChange.NewValue, args.MeasureUnitChange.NewValue)
        End Sub
        #End Region ' #OnAxisScaleChangedExample
    End Class
End Namespace
