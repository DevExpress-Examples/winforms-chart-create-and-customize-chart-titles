Namespace WindowsApplication25
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
            Dim simpleDiagram1 As New DevExpress.XtraCharts.SimpleDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim pieSeriesLabel1 As New DevExpress.XtraCharts.PieSeriesLabel()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("1", New Object() { (DirectCast(2R, Object))}, 0)
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("2", New Object() { (DirectCast(3R, Object))}, 1)
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("4", New Object() { (DirectCast(4R, Object))}, 2)
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("5", New Object() { (DirectCast(3R, Object))}, 3)
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("6", New Object() { (DirectCast(8R, Object))}, 4)
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("7", New Object() { (DirectCast(5R, Object))}, 5)
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("8", New Object() { (DirectCast(6R, Object))}, 6)
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("9", New Object() { (DirectCast(4R, Object))}, 7)
            Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("10", New Object() { (DirectCast(3R, Object))}, 8)
            Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("11", New Object() { (DirectCast(2R, Object))}, 9)
            Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("12", New Object() { (DirectCast(3R, Object))}, 10)
            Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("13", New Object() { (DirectCast(2R, Object))}, 11)
            Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("14", New Object() { (DirectCast(4R, Object))}, 12)
            Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("15", New Object() { (DirectCast(5R, Object))}, 13)
            Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("16", New Object() { (DirectCast(6R, Object))}, 14)
            Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("17", New Object() { (DirectCast(3R, Object))}, 15)
            Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint("18", New Object() { (DirectCast(1R, Object))}, 16)
            Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint("19", New Object() { (DirectCast(3R, Object))}, 17)
            Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint("20", New Object() { (DirectCast(5R, Object))}, 18)
            Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint("21", New Object() { (DirectCast(1R, Object))}, 19)
            Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint("22", New Object() { (DirectCast(4R, Object))}, 20)
            Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
            Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(simpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            simpleDiagram1.EqualPieSize = False
            Me.chartControl1.Diagram = simpleDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PaletteName = "Opulent"
            pieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.Label = pieSeriesLabel1
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            series1.LegendTextPattern = "{A}: {VP:P0}"
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21})
            series1.SynchronizePointOptions = False
            series1.TopNOptions.Enabled = True
            series1.TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.ThresholdPercent
            series1.TopNOptions.ShowOthers = False
            series1.TopNOptions.ThresholdPercent = 7R
            series1.TopNOptions.ThresholdValue = 5R
            pieSeriesView1.RuntimeExploding = False
            pieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise
            series1.View = pieSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chartControl1.SeriesTemplate.SynchronizePointOptions = False
            Me.chartControl1.Size = New System.Drawing.Size(520, 295)
            Me.chartControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(520, 295)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(simpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace

