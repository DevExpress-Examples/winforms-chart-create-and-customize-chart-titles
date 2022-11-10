Namespace WindowsApplication25

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
            Dim piePointOptions1 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(1R, New Object() {(CObj((2R)))}, 0)
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2R, New Object() {(CObj((3R)))}, 1)
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(4R, New Object() {(CObj((4R)))}, 2)
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(5R, New Object() {(CObj((3R)))}, 3)
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(6R, New Object() {(CObj((8R)))}, 4)
            Dim seriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(7R, New Object() {(CObj((5R)))}, 5)
            Dim seriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(8R, New Object() {(CObj((6R)))}, 6)
            Dim seriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(9R, New Object() {(CObj((4R)))}, 7)
            Dim seriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(10R, New Object() {(CObj((3R)))}, 8)
            Dim seriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(11R, New Object() {(CObj((2R)))}, 9)
            Dim seriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(12R, New Object() {(CObj((3R)))}, 10)
            Dim seriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(13R, New Object() {(CObj((2R)))}, 11)
            Dim seriesPoint13 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(14R, New Object() {(CObj((4R)))}, 12)
            Dim seriesPoint14 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(15R, New Object() {(CObj((5R)))}, 13)
            Dim seriesPoint15 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(16R, New Object() {(CObj((6R)))}, 14)
            Dim seriesPoint16 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(17R, New Object() {(CObj((3R)))}, 15)
            Dim seriesPoint17 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(18R, New Object() {(CObj((1R)))}, 16)
            Dim seriesPoint18 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(19R, New Object() {(CObj((3R)))}, 17)
            Dim seriesPoint19 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(20R, New Object() {(CObj((5R)))}, 18)
            Dim seriesPoint20 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(21R, New Object() {(CObj((1R)))}, 19)
            Dim seriesPoint21 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(22R, New Object() {(CObj((4R)))}, 20)
            Dim pieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PaletteName = "Opulent"
            pieSeriesLabel1.LineVisible = True
            series1.Label = pieSeriesLabel1
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            piePointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
            piePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent
            piePointOptions1.ValueNumericOptions.Precision = 0
            series1.LegendPointOptions = piePointOptions1
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21})
            series1.SynchronizePointOptions = False
            series1.TopNOptions.Enabled = True
            series1.TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.ThresholdPercent
            series1.TopNOptions.ShowOthers = False
            series1.TopNOptions.ThresholdPercent = 7R
            series1.TopNOptions.ThresholdValue = 5R
            pieSeriesView1.RuntimeExploding = False
            series1.View = pieSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            sideBySideBarSeriesLabel1.LineVisible = True
            Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chartControl1.Size = New System.Drawing.Size(522, 297)
            Me.chartControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(522, 297)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((pieSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private chartControl1 As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
