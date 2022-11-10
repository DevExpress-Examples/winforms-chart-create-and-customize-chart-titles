Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

' ...
Namespace WindowsApplication25

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Create chart titles.
            Dim chartTitle1 As ChartTitle = New ChartTitle()
            Dim chartTitle2 As ChartTitle = New ChartTitle()
            ' Define the text for the titles.
            chartTitle1.Text = "<i>Basic</i> <b>HTML</b> <u>is</u> <color=blue>supported</color>."
            chartTitle2.Text = "The capability to word-wrap is available for chart titles."
            chartTitle2.WordWrap = True
            chartTitle2.MaxLineCount = 2
            ' Define the alignment of the titles.
            chartTitle1.Alignment = StringAlignment.Center
            chartTitle2.Alignment = StringAlignment.Near
            ' Place the titles where it's required.
            chartTitle1.Dock = ChartTitleDockStyle.Top
            chartTitle2.Dock = ChartTitleDockStyle.Bottom
            ' Customize a title's appearance.
            chartTitle1.Antialiasing = True
            chartTitle1.Font = New Font(Font.FontFamily.Name, 14, FontStyle.Bold)
            chartTitle1.TextColor = Color.Red
            chartTitle1.Indent = 10
            ' Add the titles to the chart.
            chartControl1.Titles.AddRange(New ChartTitle() {chartTitle1, chartTitle2})
        End Sub
    End Class
End Namespace
