Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing
Imports System.Globalization
Imports System.Windows
Imports System.Data.OleDb
Imports System.Linq
Public Class Form8
    Dim p As Integer
    Private Sub Form8_FormClosing_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If Form1.ListView4.Items.Count > 1 Then
                Form1.ComboBox8.Text = "Multi Curve"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Form9.Close()
            For baris As Integer = 1 To (Form1.ListView7.Items.Count)
                If Form1.ComboBox8.Text = "Single Curve" Then
                    p = 1
                Else
                    If Form1.ListView5.Enabled = True And Form1.ListView5.Items.Count > 1 Then
                        p = Form1.ListView5.Items.Count
                    Else
                        p = Form1.ListView4.Items.Count
                    End If
                End If
                For i As Integer = 1 To p
                    If Form1.ComboBox17.Text = "Point" Then
                        Chart1.Series(CInt(i - 1)).ChartType = DataVisualization.Charting.SeriesChartType.Point
                    ElseIf Form1.ComboBox17.Text = "Area" Then
                        Chart1.Series(CInt(i - 1)).ChartType = DataVisualization.Charting.SeriesChartType.Area
                    ElseIf Form1.ComboBox17.Text = "Fast Line" Then
                        Chart1.Series(CInt(i - 1)).ChartType = DataVisualization.Charting.SeriesChartType.FastLine
                    Else
                        Chart1.Series(CInt(i - 1)).ChartType = DataVisualization.Charting.SeriesChartType.Spline
                    End If
                    Chart1.Series(CInt(i - 1)).Points.AddXY(CDec(Form1.ListView7.Items(baris - 1).SubItems(CInt((i - 1) * 3) + 1).Text.ToString), CDec(Form1.ListView7.Items(baris - 1).SubItems(CInt((i - 1) * 3) + 2).Text))
                    If Val(Form1.ListView7.Items(baris - 1).SubItems(1).Text) = Val(Form1.ListView4.Items(i - 1).SubItems(3).Text) Then
                        Chart1.Series(CInt(i - 1)).Points(baris - 1).MarkerStyle = MarkerStyle.Circle
                        Chart1.Series(CInt(i - 1)).Points(baris - 1).MarkerSize = 15
                        Chart1.Series(CInt(i - 1)).Points(baris - 1).Label = "max (" & i & ") = " + Form1.ListView4.Items(i - 1).SubItems(2).Text
                        Chart1.Series(CInt(i - 1)).Points(baris - 1).MarkerColor = Color.Blue
                        Chart1.Series(CInt(i - 1)).Points(baris - 1).MarkerStyle = MarkerStyle.Circle
                        If Not Application.OpenForms().OfType(Of Form5).Any Then
                            Chart1.Series(CInt(i - 1)).Points(CInt(baris - 1) / 2).Label = Form1.ComboBox33.Text & " (" & i & ")"
                        ElseIf Not Form1.ComboBox8.Text = "Single Curve" Then
                            Chart1.Series(CInt(i - 1)).Points(CInt(baris - 1) / 2).Label = Form1.ListView4.Items(CInt(i - 1)).SubItems(1).Text & " (" & i & ")"
                        Else
                            Chart1.Series(CInt(i - 1)).Points(CInt(baris - 1) / 2).Label = Form5.ListView3.Items(CInt(i - 1)).SubItems(2).Text & " (" & i & ")"
                        End If
                        Chart1.Series(CInt(i - 1)).Points(CInt(baris - 1) / 2).Font = New System.Drawing.Font("Consolas", 10.0F)
                        Chart1.Series(CInt(i - 1)).Points(CInt(baris - 1) / 2).LabelForeColor = Color.Green
                    End If
                    If Val(Form1.ListView7.Items(baris - 1).SubItems(1).Text) = Val(Form1.ListView4.Items(i - 1).SubItems(5).Text) Then
                        Chart1.Series(CInt(i - 1)).Points(baris - 1).MarkerSize = 15
                        Chart1.Series(CInt(i - 1)).Points(baris - 1).Label = "min (" & i & ") = " + Form1.ListView4.Items(i - 1).SubItems(4).Text
                        Chart1.Series(CInt(i - 1)).Points(baris - 1).MarkerColor = Color.Yellow
                        Chart1.Series(CInt(i - 1)).Points(baris - 1).MarkerStyle = MarkerStyle.Circle
                    End If
                    Chart1.Series(i - 1).Name = Form1.ListView4.Items(i - 1).SubItems(1).Text & "(" & i & ")"
                Next
            Next
            Chart1.ChartAreas("ChartArea1").AxisX.Title = Form1.Chart1.ChartAreas("ChartArea1").AxisX.Title
            Chart1.ChartAreas("ChartArea1").AxisY.Title = Form1.Chart1.ChartAreas("ChartArea1").AxisY.Title
            Chart1.Titles.Add(Form1.TextBox9.Text)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub Button64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button64.Click
        Try
            Chart1.ChartAreas("ChartArea1").Area3DStyle.PointDepth = CInt(Chart1.ChartAreas("ChartArea1").Area3DStyle.PointDepth) * 2
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button63.Click
        Try
            Chart1.ChartAreas("ChartArea1").Area3DStyle.PointDepth = CInt(Chart1.ChartAreas("ChartArea1").Area3DStyle.PointDepth) / 2
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button61.Click
        Try
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button62.Click
        Try
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button60.Click
        Try
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Rotation = Chart1.ChartAreas("ChartArea1").Area3DStyle.Rotation + 10
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click
        Try
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Rotation = Chart1.ChartAreas("ChartArea1").Area3DStyle.Rotation - 10
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        Try
            Chart1.ChartAreas("ChartArea1").AxisX.Maximum = Chart1.ChartAreas("ChartArea1").AxisX.Maximum - (CDec(Chart1.ChartAreas("ChartArea1").AxisX.Maximum) - CDec(Chart1.ChartAreas("ChartArea1").AxisX.Minimum)) / 10
            Form1.TextBox66.Text = Chart1.ChartAreas("ChartArea1").AxisX.Maximum
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        Try
            Chart1.ChartAreas("ChartArea1").AxisX.Maximum = Chart1.ChartAreas("ChartArea1").AxisX.Maximum + (CDec(Chart1.ChartAreas("ChartArea1").AxisX.Maximum) - CDec(Chart1.ChartAreas("ChartArea1").AxisX.Minimum)) / 10
            Form1.TextBox66.Text = Chart1.ChartAreas("ChartArea1").AxisX.Maximum
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        Try
            Chart1.ChartAreas("ChartArea1").AxisX.Minimum = Chart1.ChartAreas("ChartArea1").AxisX.Minimum + (CDec(Chart1.ChartAreas("ChartArea1").AxisX.Maximum) - CDec(Chart1.ChartAreas("ChartArea1").AxisX.Minimum)) / 10
            Form1.TextBox65.Text = Chart1.ChartAreas("ChartArea1").AxisX.Minimum
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Try
            Chart1.ChartAreas("ChartArea1").AxisX.Minimum = Chart1.ChartAreas("ChartArea1").AxisX.Minimum - (CDec(Chart1.ChartAreas("ChartArea1").AxisX.Maximum) - CDec(Chart1.ChartAreas("ChartArea1").AxisX.Minimum)) / 10
            Form1.TextBox65.Text = Chart1.ChartAreas("ChartArea1").AxisX.Minimum
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Try
            Chart1.ChartAreas("ChartArea1").AxisY.Maximum = Chart1.ChartAreas("ChartArea1").AxisY.Maximum + (CDec(Chart1.ChartAreas("ChartArea1").AxisY.Maximum) - CDec(Chart1.ChartAreas("ChartArea1").AxisY.Minimum)) / 10
            Form1.TextBox67.Text = Chart1.ChartAreas("ChartArea1").AxisY.Maximum
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Try
            Chart1.ChartAreas("ChartArea1").AxisY.Maximum = Chart1.ChartAreas("ChartArea1").AxisY.Maximum - (CDec(Chart1.ChartAreas("ChartArea1").AxisY.Maximum) - CDec(Chart1.ChartAreas("ChartArea1").AxisY.Minimum)) / 10
            Form1.TextBox67.Text = Chart1.ChartAreas("ChartArea1").AxisY.Maximum
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Try
            Chart1.ChartAreas("ChartArea1").AxisY.Minimum = Chart1.ChartAreas("ChartArea1").AxisY.Minimum + (CDec(Chart1.ChartAreas("ChartArea1").AxisY.Maximum) - CDec(Chart1.ChartAreas("ChartArea1").AxisY.Minimum)) / 10
            Form1.TextBox68.Text = Chart1.ChartAreas("ChartArea1").AxisY.Minimum
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Try
            Chart1.ChartAreas("ChartArea1").AxisY.Minimum = Chart1.ChartAreas("ChartArea1").AxisY.Minimum - (CDec(Chart1.ChartAreas("ChartArea1").AxisY.Maximum) - CDec(Chart1.ChartAreas("ChartArea1").AxisY.Minimum)) / 10
            Form1.TextBox68.Text = Chart1.ChartAreas("ChartArea1").AxisY.Minimum
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Try
            saveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|EMF (*.emf)|*.emf|PNG (*.png)|*.png|SVG (*.svg)|*.svg|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim format As ChartImageFormat = ChartImageFormat.Bmp
                If saveFileDialog1.FileName.EndsWith("bmp") Then
                    format = ChartImageFormat.Bmp
                Else
                    If saveFileDialog1.FileName.EndsWith("jpg") Then
                        format = ChartImageFormat.Jpeg
                    Else
                        If saveFileDialog1.FileName.EndsWith("emf") Then
                            format = ChartImageFormat.Emf
                        Else
                            If saveFileDialog1.FileName.EndsWith("gif") Then
                                format = ChartImageFormat.Gif
                            Else
                                If saveFileDialog1.FileName.EndsWith("png") Then
                                    format = ChartImageFormat.Png
                                Else
                                    If saveFileDialog1.FileName.EndsWith("tif") Then
                                        format = ChartImageFormat.Tiff
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                Chart1.SaveImage(saveFileDialog1.FileName, format)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form4.Show()
    End Sub
    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        Form6.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Form1.ComboBox8.Text = "Multi Curve" Then
                For i = 1 To Form1.ListView4.Items.Count
                    For g = 1 To Form1.ListView2.Items.Count
                        Chart1.Series(CInt(i - 1)).Points(g - 1).Label = ""
                        Chart1.Series(CInt(i - 1)).Points(g - 1).MarkerSize = 0
                    Next g
                Next
            Else
                For g = 1 To Form1.ListView2.Items.Count
                    Chart1.Series(0).Points(g - 1).Label = ""
                    Chart1.Series(0).Points(g - 1).MarkerSize = 0
                Next g
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class