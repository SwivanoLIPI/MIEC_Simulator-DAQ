Public Class Form3
    Dim legend As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Me.ComboBox1.Text = "All" Then
                For i = 1 To 10
                    Form1.Chart1.Series(i - 1).Points.Clear()
                    Form1.Chart1.Series(i - 1).Name = "Curve " & i
                Next i
                Form1.Chart1.Series(0).Points.AddXY(0, 0)
                Form1.Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Spline
                Form1.TextBox47.Text = ""
            Else
                Form1.Chart1.Series(CInt(Me.ComboBox1.Text) - 1).Points.Clear()
                Form1.TextBox47.Text = ""
                Form1.Chart1.Series(CInt(Me.ComboBox1.Text) - 1).Name = "Curve " & CInt(Me.ComboBox1.Text)
            End If
            legend = ""
            Form1.TextBox9.Text = ""
            Form1.Chart1.ChartAreas("ChartArea1").AxisX.Title = ""
            Form1.Chart1.ChartAreas("ChartArea1").AxisY.Title = ""
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.Close()
            Form1.TextBox47.Text = ""
            legend = ""
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Me.Close()
            Form1.Show()
        Catch ex As Exception
        End Try
    End Sub
End Class