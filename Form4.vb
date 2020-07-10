Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Font
Imports System.Drawing.FontFamily
Imports System.Drawing.FontConverter
Public Class Form4
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Button2.PerformClick()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TextBox1.Text = Form1.TextBox9.Text
            TextBox2.Text = Form1.Chart1.ChartAreas("ChartArea1").AxisX.Title
            TextBox3.Text = Form1.Chart1.ChartAreas("ChartArea1").AxisY.Title
            BindCombo()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Application.OpenForms().OfType(Of Form8).Any Then
                If Not Me.TextBox2.Text = "" Then
                    If ComboBox3.Text = "Bold" Then
                        Form8.Chart1.ChartAreas("ChartArea1").AxisX.TitleFont = New System.Drawing.Font(ComboBox2.Text, Convert.ToInt32(ComboBox4.SelectedItem), FontStyle.Bold)
                    ElseIf ComboBox3.Text = "Regular" Then
                        Form8.Chart1.ChartAreas("ChartArea1").AxisX.TitleFont = New System.Drawing.Font(ComboBox2.Text, Convert.ToInt32(ComboBox4.SelectedItem), FontStyle.Regular)
                    Else : ComboBox3.Text = "Italic"
                        Form8.Chart1.ChartAreas("ChartArea1").AxisX.TitleFont = New System.Drawing.Font(ComboBox2.Text, Convert.ToInt32(ComboBox4.SelectedItem), FontStyle.Italic)
                    End If
                    Form8.Chart1.ChartAreas("ChartArea1").AxisX.Title = TextBox2.Text
                End If
                If Not Me.TextBox3.Text = "" Then
                    If ComboBox8.Text = "Bold" Then
                        Form8.Chart1.ChartAreas("ChartArea1").AxisY.TitleFont = New System.Drawing.Font(ComboBox5.Text, Convert.ToInt32(ComboBox9.SelectedItem), FontStyle.Bold)
                    ElseIf ComboBox8.Text = "Regular" Then
                        Form8.Chart1.ChartAreas("ChartArea1").AxisY.TitleFont = New System.Drawing.Font(ComboBox5.Text, Convert.ToInt32(ComboBox9.SelectedItem), FontStyle.Regular)
                    Else : ComboBox8.Text = "Italic"
                        Form8.Chart1.ChartAreas("ChartArea1").AxisY.TitleFont = New System.Drawing.Font(ComboBox5.Text, Convert.ToInt32(ComboBox9.SelectedItem), FontStyle.Italic)
                    End If
                End If
                Form8.Chart1.Titles.Clear()
                If ComboBox6.Text = "Bold" Then
                    Form8.Chart1.Titles.Add(TextBox1.Text).Font = New System.Drawing.Font(ComboBox7.Text, Convert.ToInt32(ComboBox1.SelectedItem), System.Drawing.FontStyle.Bold)
                ElseIf ComboBox6.Text = "Regular" Then
                    Form8.Chart1.Titles.Add(TextBox1.Text).Font = New System.Drawing.Font(ComboBox7.Text, Convert.ToInt32(ComboBox1.SelectedItem), System.Drawing.FontStyle.Regular)
                Else : ComboBox6.Text = "Italic"
                    Form8.Chart1.Titles.Add(TextBox1.Text).Font = New System.Drawing.Font(ComboBox7.Text, Convert.ToInt32(ComboBox1.SelectedItem), System.Drawing.FontStyle.Italic)
                End If
            Else
                If Not Me.TextBox2.Text = "" Then
                    If ComboBox3.Text = "Bold" Then
                        Form1.Chart1.ChartAreas("ChartArea1").AxisX.TitleFont = New System.Drawing.Font(ComboBox2.Text, Convert.ToInt32(ComboBox4.SelectedItem), FontStyle.Bold)
                    ElseIf ComboBox3.Text = "Regular" Then
                        Form1.Chart1.ChartAreas("ChartArea1").AxisX.TitleFont = New System.Drawing.Font(ComboBox2.Text, Convert.ToInt32(ComboBox4.SelectedItem), FontStyle.Regular)
                    Else : ComboBox3.Text = "Italic"
                        Form1.Chart1.ChartAreas("ChartArea1").AxisX.TitleFont = New System.Drawing.Font(ComboBox2.Text, Convert.ToInt32(ComboBox4.SelectedItem), FontStyle.Italic)
                    End If
                    Form1.Chart1.ChartAreas("ChartArea1").AxisX.Title = TextBox2.Text
                End If
                If Not Me.TextBox3.Text = "" Then
                    If ComboBox8.Text = "Bold" Then
                        Form1.Chart1.ChartAreas("ChartArea1").AxisY.TitleFont = New System.Drawing.Font(ComboBox5.Text, Convert.ToInt32(ComboBox9.SelectedItem), FontStyle.Bold)
                    ElseIf ComboBox8.Text = "Regular" Then
                        Form1.Chart1.ChartAreas("ChartArea1").AxisY.TitleFont = New System.Drawing.Font(ComboBox5.Text, Convert.ToInt32(ComboBox9.SelectedItem), FontStyle.Regular)
                    Else : ComboBox8.Text = "Italic"
                        Form1.Chart1.ChartAreas("ChartArea1").AxisY.TitleFont = New System.Drawing.Font(ComboBox5.Text, Convert.ToInt32(ComboBox9.SelectedItem), FontStyle.Italic)
                    End If
                End If
                Form1.Chart1.Titles.Clear()
                If ComboBox6.Text = "Bold" Then
                    Form1.Chart1.Titles.Add(TextBox1.Text).Font = New System.Drawing.Font(ComboBox7.Text, Convert.ToInt32(ComboBox1.SelectedItem), System.Drawing.FontStyle.Bold)
                ElseIf ComboBox6.Text = "Regular" Then
                    Form1.Chart1.Titles.Add(TextBox1.Text).Font = New System.Drawing.Font(ComboBox7.Text, Convert.ToInt32(ComboBox1.SelectedItem), System.Drawing.FontStyle.Regular)
                Else : ComboBox6.Text = "Italic"
                    Form1.Chart1.Titles.Add(TextBox1.Text).Font = New System.Drawing.Font(ComboBox7.Text, Convert.ToInt32(ComboBox1.SelectedItem), System.Drawing.FontStyle.Italic)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BindCombo()
        Try
            ComboBox7.DrawMode = DrawMode.OwnerDrawFixed
            ComboBox7.Font = New System.Drawing.Font("Microsoft Sans Serif, 8pt", 8)
            ComboBox7.ItemHeight = 20
            Dim objFontFamily As FontFamily
            Dim objFontCollection As System.Drawing.Text.FontCollection
            objFontCollection = New System.Drawing.Text.InstalledFontCollection()
            For Each objFontFamily In objFontCollection.Families
                ComboBox7.Items.Add(objFontFamily.Name)
            Next
            ComboBox2.DrawMode = DrawMode.OwnerDrawFixed
            ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif, 8pt", 8)
            ComboBox2.ItemHeight = 20
            objFontCollection = New System.Drawing.Text.InstalledFontCollection()
            For Each objFontFamily In objFontCollection.Families
                ComboBox2.Items.Add(objFontFamily.Name)
            Next
            ComboBox5.DrawMode = DrawMode.OwnerDrawFixed
            ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif, 8pt", 8)
            ComboBox5.ItemHeight = 20
            objFontCollection = New System.Drawing.Text.InstalledFontCollection()
            For Each objFontFamily In objFontCollection.Families
                ComboBox5.Items.Add(objFontFamily.Name)
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub combobox7_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox7.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Focus) <> 0 Then
            e.DrawFocusRectangle()
        End If
        Dim objBrush As Brush = Nothing
        Try
            objBrush = New SolidBrush(e.ForeColor)
            Dim _FontName As String = ComboBox7.Items(e.Index)
            Dim _font As Font
            Dim _fontfamily = New System.Drawing.FontFamily(_FontName)
            If _fontfamily.IsStyleAvailable(FontStyle.Regular) Then
                _font = New System.Drawing.Font(_fontfamily, 14, FontStyle.Regular)
            ElseIf _fontfamily.IsStyleAvailable(FontStyle.Bold) Then
                _font = New System.Drawing.Font(_fontfamily, 14, FontStyle.Bold)
            ElseIf _fontfamily.IsStyleAvailable(FontStyle.Italic) Then
                _font = New System.Drawing.Font(_fontfamily, 14, FontStyle.Italic)
            End If
            e.Graphics.DrawString(_FontName, _font, objBrush, e.Bounds)
        Catch ex As Exception
        Finally
            If objBrush IsNot Nothing Then
                objBrush.Dispose()
            End If
            objBrush = Nothing
        End Try
    End Sub
    Private Sub ComboBox5_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox5.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Focus) <> 0 Then
            e.DrawFocusRectangle()
        End If
        Dim objBrush As Brush = Nothing
        Try
            objBrush = New SolidBrush(e.ForeColor)
            Dim _FontName As String = ComboBox5.Items(e.Index)
            Dim _font As Font
            Dim _fontfamily = New System.Drawing.FontFamily(_FontName)
            If _fontfamily.IsStyleAvailable(FontStyle.Regular) Then
                _font = New System.Drawing.Font(_fontfamily, 14, FontStyle.Regular)
            ElseIf _fontfamily.IsStyleAvailable(FontStyle.Bold) Then
                _font = New System.Drawing.Font(_fontfamily, 14, FontStyle.Bold)
            ElseIf _fontfamily.IsStyleAvailable(FontStyle.Italic) Then
                _font = New System.Drawing.Font(_fontfamily, 14, FontStyle.Italic)
            End If
            e.Graphics.DrawString(_FontName, _font, objBrush, e.Bounds)
        Catch ex As Exception
        Finally
            If objBrush IsNot Nothing Then
                objBrush.Dispose()
            End If
            objBrush = Nothing
        End Try
    End Sub
    Private Sub ComboBox2_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox2.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Focus) <> 0 Then
            e.DrawFocusRectangle()
        End If
        Dim objBrush As Brush = Nothing
        Try
            objBrush = New SolidBrush(e.ForeColor)
            Dim _FontName As String = ComboBox2.Items(e.Index)
            Dim _font As Font
            Dim _fontfamily = New System.Drawing.FontFamily(_FontName)
            If _fontfamily.IsStyleAvailable(FontStyle.Regular) Then
                _font = New System.Drawing.Font(_fontfamily, 14, FontStyle.Regular)
            ElseIf _fontfamily.IsStyleAvailable(FontStyle.Bold) Then
                _font = New System.Drawing.Font(_fontfamily, 14, FontStyle.Bold)
            ElseIf _fontfamily.IsStyleAvailable(FontStyle.Italic) Then
                _font = New System.Drawing.Font(_fontfamily, 14, FontStyle.Italic)
            End If
            e.Graphics.DrawString(_FontName, _font, objBrush, e.Bounds)
        Catch ex As Exception
        Finally
            If objBrush IsNot Nothing Then
                objBrush.Dispose()
            End If
            objBrush = Nothing
        End Try
    End Sub


End Class