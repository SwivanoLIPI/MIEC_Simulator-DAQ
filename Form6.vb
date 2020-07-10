Public Class Form6
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Form4.Show()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        Try
            Form3.Show()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Try
            If Application.OpenForms().OfType(Of Form8).Any Then
                With Form8.Chart1.ChartAreas(0)
                    .AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Solid
                    .AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Solid
                End With
            Else
                With Form1.Chart1.ChartAreas(0)
                    .AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Solid
                    .AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Solid
                End With
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        Try
            If Application.OpenForms().OfType(Of Form8).Any Then
                With Form8.Chart1.ChartAreas(0)
                    .AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
                End With
            Else
                With Form1.Chart1.ChartAreas(0)
                    .AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
                End With
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Try
            If Application.OpenForms().OfType(Of Form8).Any Then
                With Form8.Chart1.ChartAreas(0)
                    .AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
                End With
            Else
                With Form1.Chart1.ChartAreas(0)
                    .AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
                End With
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Try
            If Application.OpenForms().OfType(Of Form8).Any Then
                With Form8.Chart1.ChartAreas(0)
                    .AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
                    .AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
                End With
            Else
                With Form1.Chart1.ChartAreas(0)
                    .AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
                    .AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
                End With
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Try
            If Application.OpenForms().OfType(Of Form8).Any Then
                Form8.Chart1.ChartAreas(0).AxisX.ScaleView.Size = Math.Abs(CDec(Form1.TextBox45.Text) - CDec(Form1.TextBox30.Text)) * 2
                Form8.Chart1.ChartAreas(0).AxisY.ScaleView.Size = Math.Abs(CDec(Form1.TextBox35.Text) - CDec(Form1.TextBox34.Text)) * 2
                Form8.Chart1.ChartAreas(0).AxisX.ScrollBar.Enabled = True
                Form8.Chart1.ChartAreas(0).AxisY.ScrollBar.Enabled = True
                Form8.Chart1.ChartAreas(0).CursorX.IsUserEnabled = True
                Form8.Chart1.ChartAreas(0).CursorY.IsUserEnabled = True
            Else
                Form1.Chart1.ChartAreas(0).AxisX.ScaleView.Size = Math.Abs(CDec(Form1.TextBox45.Text) - CDec(Form1.TextBox30.Text)) * 2
                Form1.Chart1.ChartAreas(0).AxisY.ScaleView.Size = Math.Abs(CDec(Form1.TextBox35.Text) - CDec(Form1.TextBox34.Text)) * 2
                Form1.Chart1.ChartAreas(0).AxisX.ScrollBar.Enabled = True
                Form1.Chart1.ChartAreas(0).AxisY.ScrollBar.Enabled = True
                Form1.Chart1.ChartAreas(0).CursorX.IsUserEnabled = True
                Form1.Chart1.ChartAreas(0).CursorY.IsUserEnabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Try
            If Application.OpenForms().OfType(Of Form8).Any Then
                Form8.Chart1.ChartAreas(0).AxisX.ScaleView.Size = Form1.Chart1.ChartAreas(0).AxisX.ScaleView.Size / 2
                Form8.Chart1.ChartAreas(0).AxisY.ScaleView.Size = Form1.Chart1.ChartAreas(0).AxisY.ScaleView.Size / 2
                Form8.Chart1.ChartAreas(0).AxisX.ScrollBar.Enabled = True
                Form8.Chart1.ChartAreas(0).AxisY.ScrollBar.Enabled = True
                Form8.Chart1.ChartAreas(0).CursorX.IsUserEnabled = True
                Form8.Chart1.ChartAreas(0).CursorY.IsUserEnabled = True
            Else
                Form1.Chart1.ChartAreas(0).AxisX.ScaleView.Size = Form1.Chart1.ChartAreas(0).AxisX.ScaleView.Size / 2
                Form1.Chart1.ChartAreas(0).AxisY.ScaleView.Size = Form1.Chart1.ChartAreas(0).AxisY.ScaleView.Size / 2
                Form1.Chart1.ChartAreas(0).AxisX.ScrollBar.Enabled = True
                Form1.Chart1.ChartAreas(0).AxisY.ScrollBar.Enabled = True
                Form1.Chart1.ChartAreas(0).CursorX.IsUserEnabled = True
                Form1.Chart1.ChartAreas(0).CursorY.IsUserEnabled = True
            End If      
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Try
            If Application.OpenForms().OfType(Of Form8).Any Then
                With Form8.Chart1.ChartAreas(0)
                    .AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Dash
                    .AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Dash
                End With
            Else
                With Form1.Chart1.ChartAreas(0)
                    .AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Dash
                    .AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Dash
                End With
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class