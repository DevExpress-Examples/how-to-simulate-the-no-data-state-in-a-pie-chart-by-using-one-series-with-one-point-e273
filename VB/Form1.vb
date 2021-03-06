﻿Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace ChartEmptyPie
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            ' Remove all Series from chart 
            chartControl1.Series.Clear()

            ' Simulate "No data" state
            Dim series As New Series("Empty Series", ViewType.Pie)

            series.Label.TextPattern = "{A}"
            CType(series.Label, PieSeriesLabel).Position = PieSeriesLabelPosition.Inside
            CType(series.Label, PieSeriesLabel).Font = New Font("Arial", 40)
            series.Points.Add(New SeriesPoint("No data", New Object() { 0.2 }))

            chartControl1.Series.Add(series)
            CType(chartControl1.Diagram, SimpleDiagram).EqualPieSize = True
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
        End Sub
    End Class
End Namespace