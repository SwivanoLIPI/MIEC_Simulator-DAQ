Public Class Form5
    Dim baris As Integer
    Dim l As ListViewItem
    Dim k As Integer
    Private Sub Form5_FormClosing_5(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Form1.TextBox72.Text = 0
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Public Sub wait(ByVal Dt As Double)
        Dim IDay As Double = Date.Now.DayOfYear
        Dim CDay As Double
        Dim ITime As Double = Date.Now.TimeOfDay.TotalSeconds
        Dim CTime As Double
        Dim DiffDay As Double
        Try
            Do
                Application.DoEvents()
                CDay = Date.Now.DayOfYear
                CTime = Date.Now.TimeOfDay.TotalSeconds
                DiffDay = CDay - IDay
                CTime = CTime + 86400 * DiffDay
                If CTime >= ITime + Dt Then Exit Do
            Loop
        Catch e As Exception
        End Try
    End Sub
    Private Sub ComboBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ComboBox9.Items.Clear()
    End Sub
    Private Sub Form5_FormClosing_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If Form1.ComboBox8.Text = "Single Curve" Then
                Form9.Hide()
                Form7.Hide()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Label50.Text = "Value"
            ListView3.Columns.Clear()
            ListView3.Columns.Add("No.", 30, HorizontalAlignment.Center)
            ListView3.Columns.Add("Curve", 60, HorizontalAlignment.Center)
            ListView3.Columns.Add("Parameter", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("Effective Area", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("% N2 in Effluent", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("% O2 in Effluent", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("P_O2 Feed Surface Membrane", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("Membrane Characteristic Thickness", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("Temperature", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("Ionic Conductivity", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("Thickness", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("Total O2 Chem Potential Diff", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("Electronic Conductivity", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("Oxygen Debit", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("Farad Contant", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("Gas constant", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("P_O2 PSM", 120, HorizontalAlignment.Center)
            ListView3.Columns.Add("CTE efc", 120, HorizontalAlignment.Center)
            If ComboBox9.Text = "Effective Area" Then
                Label5.Text = 3
            End If
            If ListView7.Items.Count < 1 Then
                For i = 1 To CInt((Form1.ListView4.Items.Count))
                    ListView7.Columns.Add(Form1.ColumnHeader5.Text & " (" & i & ")", 125, HorizontalAlignment.Center)
                    ListView7.Columns.Add(Form1.ColumnHeader6.Text & " (" & i & ")", 120, HorizontalAlignment.Center)
                    ListView7.Columns.Add(Form1.ColumnHeader10.Text & " (" & i & ")", 120, HorizontalAlignment.Center)
                Next
                For Me.baris = CInt(1) To CInt(Form1.ListView7.Items.Count)
                    l = Me.ListView7.Items.Add(Form1.ListView7.Items(baris - 1).SubItems(0).Text)
                    For j As Integer = CInt(2) To CInt(Form1.ListView7.Columns.Count)
                        l.SubItems.Add(Form1.ListView7.Items(baris - 1).SubItems(j - 1).Text)
                    Next
                Next
                For Me.baris = CInt(1) To CInt(Form1.ListView4.Items.Count)
                    l = Me.ListView1.Items.Add(Form1.ListView4.Items(baris - 1).SubItems(0).Text)
                    For j As Integer = CInt(2) To CInt(Form1.ListView4.Columns.Count)
                        l.SubItems.Add(Form1.ListView4.Items(baris - 1).SubItems(j - 1).Text)
                    Next
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button46_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        Try
            If ListView7.Items.Count > 1 Then
                Form9.Show()
                Form9.Label1.Text = "Program is not ready to run simulation!" & vbCrLf & "You must delete previous database and graphic! " & vbCrLf & " Do you want to save it first?"
                Exit Sub
            End If
            Button2.PerformClick()
            ListView7.Items.Clear()
            ListView7.Columns.Clear()
            ListView7.Columns.Add("No.")
            If ListView3.Items.Count > 1 Then
                Form1.ComboBox8.Text = "Multi Curve"
                Form7.Close()
            End If
            For i = 1 To ListView3.Columns.Count
                For j = 1 To ListView3.Items.Count
                    If ListView3.Items(j - 1).SubItems(i - 1).Text = "" Then
                        ListView3.Items(j - 1).SubItems(i - 1).Text = "Set to Default"
                    End If
                    wait(0.01)
                    If ListView3.Items(j - 1).SubItems(0).Text = "Set to Default" Then
                        ListView3.Items(j - 1).SubItems(0).Text = ComboBox11.Text
                        ListView3.Items(j - 1).SubItems(1).Text = ComboBox10.Text
                        ListView3.Items(j - 1).SubItems(2).Text = ComboBox33.Text
                    End If
                Next
            Next
            wait(1)
            Form1.Show()
            Me.Hide()
            Form1.TabControl1.SelectedIndex = 1
            For i = 1 To ListView3.Items.Count
                If Not ListView3.Items(i - 1).BackColor = Color.LightGreen And Not ListView3.Items(i - 1).BackColor = Color.Yellow Then
                    If Not ListView3.Items(i - 1).SubItems(3).Text = "Set to Default" Then
                        Form1.TextBox14.Text = CDec(ListView3.Items(i - 1).SubItems(3).Text)
                    Else
                        Form1.TextBox14.Text = Form1.TextBox14.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(4).Text = "Set to Default" Then
                        Form1.TextBox3.Text = ListView3.Items(i - 1).SubItems(4).Text
                    Else
                        Form1.TextBox3.Text = Form1.TextBox3.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(5).Text = "Set to Default" Then
                        Form1.TextBox17.Text = ListView3.Items(i - 1).SubItems(5).Text
                    Else
                        Form1.TextBox17.Text = Form1.TextBox17.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(6).Text = "Set to Default" Then
                        Form1.TextBox10.Text = ListView3.Items(i - 1).SubItems(6).Text
                    Else
                        Form1.TextBox10.Text = Form1.TextBox10.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(7).Text = "Set to Default" Then
                        Form1.TextBox40.Text = ListView3.Items(i - 1).SubItems(7).Text
                    Else
                        Form1.TextBox40.Text = Form1.TextBox40.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(8).Text = "Set to Default" Then
                        Form1.TextBox12.Text = ListView3.Items(i - 1).SubItems(8).Text
                    Else
                        Form1.TextBox12.Text = Form1.TextBox12.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(9).Text = "Set to Default" Then
                        Form1.TextBox93.Text = ListView3.Items(i - 1).SubItems(9).Text
                    Else
                        Form1.TextBox93.Text = Form1.TextBox93.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(10).Text = "Set to Default" Then
                        Form1.TextBox24.Text = ListView3.Items(i - 1).SubItems(10).Text
                    Else
                        Form1.TextBox24.Text = Form1.TextBox24.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(11).Text = "Set to Default" Then
                        Form1.TextBox39.Text = ListView3.Items(i - 1).SubItems(11).Text
                    Else
                        Form1.TextBox39.Text = Form1.TextBox39.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(12).Text = "Set to Default" Then
                        Form1.TextBox33.Text = ListView3.Items(i - 1).SubItems(12).Text
                    Else
                        Form1.TextBox33.Text = Form1.TextBox33.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(13).Text = "Set to Default" Then
                        Form1.TextBox95.Text = ListView3.Items(i - 1).SubItems(13).Text
                    Else
                        Form1.TextBox95.Text = Form1.TextBox95.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(14).Text = "Set to Default" Then
                        Form1.TextBox2.Text = ListView3.Items(i - 1).SubItems(14).Text
                    Else
                        Form1.TextBox2.Text = Form1.TextBox2.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(15).Text = "Set to Default" Then
                        Form1.TextBox1.Text = ListView3.Items(i - 1).SubItems(15).Text
                    Else
                        Form1.TextBox1.Text = Form1.TextBox1.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(16).Text = "Set to Default" Then
                        Form1.TextBox23.Text = ListView3.Items(i - 1).SubItems(16).Text
                    Else
                        Form1.TextBox23.Text = Form1.TextBox23.Text
                    End If
                    If Not ListView3.Items(i - 1).SubItems(17).Text = "Set to Default" Then
                        Form1.TextBox44.Text = ListView3.Items(i - 1).SubItems(17).Text
                    Else
                        Form1.TextBox44.Text = Form1.TextBox44.Text
                    End If
                    Form1.ComboBox1.Text = Me.ListView3.Items(i - 1).SubItems(1).Text
                    Form1.Button62.PerformClick()
                    Form1.Button29.PerformClick()
                Else
                    Me.Show()
                    ListView3.Items(i - 1).BackColor = Color.Yellow
                    If ListView3.Items(ListView3.Items.Count - 1).BackColor = Color.Yellow Then
                        MsgBox("Run for " & ListView3.Items(i - 1).SubItems(1).Text & " failed! You have run this row of configuration.")
                    Else
                        MsgBox("Run for " & ListView3.Items(i - 1).SubItems(1).Text & " failed! You have run this row of configuration.  Program will continiue to the next run.")
                    End If
                End If
            Next
            MsgBox("Finish!")
            Me.Show()
            For i = 1 To ListView3.Items.Count
                Me.ListView3.Items(i - 1).BackColor = Color.LightGreen
            Next
        Catch ex As Exception
            MsgBox("Error to produce data output! Make sure all your configuration is correct! ")
            Exit Sub
        End Try
    End Sub
    Private Sub ComboBox9_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox9.SelectedIndexChanged
        Try
            If ComboBox9.Text = "Effective Area" Then
                Label5.Text = 3
            ElseIf ComboBox9.Text = "% N2 in Effluent" Then
                Label5.Text = 4
            ElseIf ComboBox9.Text = "% O2 in Effluent" Then
                Label5.Text = 5
            ElseIf ComboBox9.Text = "P_O2 Feed Surface Membrane" Then
                Label5.Text = 6
            ElseIf ComboBox9.Text = "Membrane Characteristic Thickness" Then
                Label5.Text = 7
            ElseIf ComboBox9.Text = "Temperature" Then
                Label5.Text = 8
            ElseIf ComboBox9.Text = "Ionic Conductivity" Then
                Label5.Text = 9
            ElseIf ComboBox9.Text = "Thickness" Then
                Label5.Text = 10
            ElseIf ComboBox9.Text = "Total O2 Chem Potential Delseiff" Then
                Label5.Text = 11
            ElseIf ComboBox9.Text = "Electronic Conductivity" Then
                Label5.Text = 12
            ElseIf ComboBox9.Text = "Oxygen Debit" Then
                Label5.Text = 13
            ElseIf ComboBox9.Text = "Farad Contant" Then
                Label5.Text = 14
            ElseIf ComboBox9.Text = "Gas constant" Then
                Label5.Text = 15
            ElseIf ComboBox9.Text = "P_O2 PSM" Then
                Label5.Text = 16
            ElseIf ComboBox9.Text = "CTE efc" Then
                Label5.Text = 17
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If TextBox69.Text = "" Then
                TextBox69.BackColor = Color.Red
                MsgBox("value can not be blank!")
                Exit Sub
            End If
            If ListView3.Items.Count > 1 Then
                Form1.ComboBox8.Text = "Multi Curve"
                Form7.Close()
            End If
            If ListView3.Items.Count = 0 Then
                l = Me.ListView3.Items.Add("")
                For i = 1 To 17
                    l.SubItems.Add("")
                Next
            Else
                ListView3.Items(CInt(ComboBox11.Text) - 1).SubItems(0).Text = ComboBox11.Text
                ListView3.Items(CInt(ComboBox11.Text) - 1).SubItems(1).Text = ComboBox10.Text
                ListView3.Items(CInt(ComboBox11.Text) - 1).SubItems(2).Text = ComboBox33.Text
                ListView3.Items(CInt(ComboBox11.Text) - 1).SubItems(CInt(Label5.Text)).Text = TextBox69.Text
                ListView3.Items(CInt(ComboBox11.Text) - 1).BackColor = Color.LightGray
            End If
        Catch ex As Exception
        End Try
    End Sub
 Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        Try
            Label50.Text = "Value"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        Try
            ListView3.Items.Clear()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ComboBox11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox11.SelectedIndexChanged
        Try
            Dim del As String
            del = Val(ComboBox11.Text) - Val(ListView3.Items.Count)
            If Val(ListView3.Items.Count) < Val(ComboBox11.Text) Then
                For j As Integer = 1 To CInt(del)
                    l = Me.ListView3.Items.Add("")
                    For i = 1 To 17
                        l.SubItems.Add("")
                    Next
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        Try
            ListView3.FullRowSelect = True
            For Each item As ListViewItem In ListView3.SelectedItems
                item.Remove()
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        Try
            Dim SaveFile As New SaveFileDialog
            SaveFile.FileName = ""
            SaveFile.Filter = "Text Files (*.txt)|*.txt"
            SaveFile.Title = "Save"
            SaveFile.ShowDialog()
            Dim Write As New System.IO.StreamWriter(SaveFile.FileName)
            Dim col As ColumnHeader
            Dim columnnames As String = ""
            For Each col In ListView3.Columns
                If String.IsNullOrEmpty(columnnames) Then
                    columnnames = col.Text
                Else
                    columnnames &= "|" & col.Text
                End If
            Next
            For Me.baris = 1 To ListView3.Items.Count
                Write.Write(ListView3.Items(baris - 1).SubItems(0).Text & "|" & ListView3.Items(baris - 1).SubItems(1).Text & "|" & ListView3.Items(baris - 1).SubItems(2).Text & "|" & ListView3.Items(baris - 1).SubItems(3).Text & "|" & ListView3.Items(baris - 1).SubItems(4).Text & "|" & ListView3.Items(baris - 1).SubItems(5).Text & "|" & ListView3.Items(baris - 1).SubItems(6).Text & "|" & ListView3.Items(baris - 1).SubItems(7).Text & "|" & ListView3.Items(baris - 1).SubItems(8).Text & "|" & ListView3.Items(baris - 1).SubItems(9).Text & "|" & ListView3.Items(baris - 1).SubItems(10).Text & "|" & ListView3.Items(baris - 1).SubItems(11).Text & "|" & ListView3.Items(baris - 1).SubItems(12).Text & "|" & ListView3.Items(baris - 1).SubItems(13).Text & "|" & ListView3.Items(baris - 1).SubItems(14).Text & "|" & ListView3.Items(baris - 1).SubItems(15).Text & "|" & ListView3.Items(baris - 1).SubItems(16).Text & "|" & ListView3.Items(baris - 1).SubItems(17).Text & "|" & ListView3.Items(baris - 1).SubItems(17).Text & vbCrLf)
            Next baris
            Write.Close()
        Catch p As Exception
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListView1.Items.Clear()
        ListView7.Items.Clear()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim OpenFile As New OpenFileDialog
            OpenFile.ShowDialog()
            OpenFile.Filter = "Text Files (*.txt)|*.txt"
            OpenFile.Title = "Open"
            Dim filepath As String = OpenFile.FileName
            Dim inputstream As New IO.StreamReader(filepath)
            Dim newstr(0) As String
            For i = 1 To ListView3.Items.Count
                ListView3.Items(i - 1).Remove()
            Next
            Do While inputstream.Peek <> 0
                newstr = inputstream.ReadLine().Split("|")
                l = ListView3.Items.Add(CStr(newstr(0)))
                For i = 2 To ListView3.Columns.Count
                    l.SubItems.Add(CStr(newstr(i - 1)))
                Next
            Loop
            inputstream.Close()
            For i = 1 To ListView3.Items.Count
                ListView3.Items(i - 1).BackColor = Color.LightGray
            Next
        Catch es As Exception
            ' ListView3.Items.Clear()
            'MsgBox("Failed to re-input database of configuration!")
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim SaveFile As New SaveFileDialog
            SaveFile.FileName = ""
            SaveFile.Filter = "Text Files (*.txt)|*.txt"
            SaveFile.Title = "Save"
            SaveFile.ShowDialog()
            Dim Write As New System.IO.StreamWriter(SaveFile.FileName)
            Dim col As ColumnHeader
            Dim columnnames As String = ""
            Dim columnnames1 As String = ""
            For Each col In ListView7.Columns
                If String.IsNullOrEmpty(columnnames) Then
                    columnnames = col.Text
                Else
                    columnnames &= "|" & col.Text
                End If
            Next
            Write.Write(columnnames & vbCrLf)
            For Me.baris = 1 To ListView7.Items.Count
                For j = 1 To ListView7.Columns.Count
                    Write.Write(ListView7.Items(baris - 1).SubItems(j - 1).Text & "|")
                Next j
                Write.Write(vbCrLf)
                Write.Write(vbCrLf)
            Next baris
            For Each col In ListView1.Columns
                If String.IsNullOrEmpty(columnnames1) Then
                    columnnames1 = col.Text
                Else
                    columnnames1 &= "|" & col.Text
                End If
            Next
            Write.Write(columnnames1 & vbCrLf)
            For Me.baris = 1 To ListView1.Items.Count
                For j = 1 To ListView1.Columns.Count
                    Write.Write(ListView1.Items(baris - 1).SubItems(j - 1).Text & "|")
                Next j
                Write.Write(vbCrLf)
            Next baris
            Write.Close()
        Catch p As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListView1.FullRowSelect = True
        For Each item As ListViewItem In ListView1.SelectedItems
            item.Remove()
        Next
        ListView7.FullRowSelect = True
        For Each item As ListViewItem In ListView7.SelectedItems
            item.Remove()
        Next
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ListView3.Items.Count > 1 And Form1.ComboBox8.Text = "Multi Curve" Then
            Form1.Button65.PerformClick()
        ElseIf ListView7.Items.Count > 1 And Form1.ComboBox8.Text = "Single Curve" Then
            Form1.Button65.PerformClick()
        ElseIf Form1.ComboBox8.Text = "Multi Curve" And ListView3.Items.Count < 2 Then
            Form1.ComboBox8.Text = "Single Curve"
            Form1.Button65.PerformClick()
        End If
    End Sub
End Class