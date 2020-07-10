Public Class Form10

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Hide()
            Form1.Button29.Visible = True
            Form1.Button3.Visible = True
            If Form1.ListView5.Items.Count < 1 Then
                MsgBox("Please configure variables and click add button on the left")
                Exit Sub
            End If
            Form1.ComboBox8.Text = "Multi Curve"
            For i As Integer = 1 To Form1.ComboBox11.Text
                Form1.Chart1.Series(i - 1).Points.Clear()
            Next
            For i = 0 To Form1.ListView5.Items.Count - 1
                Form1.ComboBox1.Text = Form1.ListView5.Items(i).SubItems(0).Text
                Form1.ListView5.Items(i).BackColor = Color.Yellow
                If Form1.ListView5.Items(i).SubItems(1).Text = "P_O2 Feed Surface Membrane" Then
                    Form1.TextBox10.Text = Form1.ListView5.Items(i).SubItems(3).Text
                ElseIf Form1.ListView5.Items(i).SubItems(1).Text = "Membrane Characteristic Thickness" Then
                    Form1.TextBox24.Text = Form1.ListView5.Items(i).SubItems(3).Text
                ElseIf Form1.ListView5.Items(i).SubItems(1).Text = "Effective Area" Then
                    Form1.TextBox14.Text = Form1.ListView5.Items(i).SubItems(3).Text
                ElseIf Form1.ListView5.Items(i).SubItems(1).Text = "% O2 in Effluent" Then
                    Form1.TextBox18.Text = Form1.ListView5.Items(i).SubItems(3).Text
                ElseIf Form1.ListView5.Items(i).SubItems(1).Text = "% N2 in Effluent" Then
                    Form1.TextBox3.Text = Form1.ListView5.Items(i).SubItems(3).Text
                ElseIf Form1.ListView5.Items(i).SubItems(1).Text = "Temperature" Then
                    Form1.TextBox12.Text = Form1.ListView5.Items(i).SubItems(3).Text
                ElseIf Form1.ListView5.Items(i).SubItems(1).Text = "Ionic Conductivity" Then
                    Form1.TextBox93.Text = Form1.ListView5.Items(i).SubItems(3).Text
                ElseIf Form1.ListView5.Items(i).SubItems(1).Text = "Thickness" Then
                    Form1.TextBox24.Text = Form1.ListView5.Items(i).SubItems(3).Text
                ElseIf Form1.ListView5.Items(i).SubItems(1).Text = "Total O2 Chem Potential Diff" Then
                    Form1.TextBox39.Text = Form1.ListView5.Items(i).SubItems(3).Text
                ElseIf Form1.ListView5.Items(i).SubItems(1).Text = "Electronic Conductivity" Then
                    Form1.TextBox33.Text = Form1.ListView5.Items(i).SubItems(3).Text
                ElseIf Form1.ListView5.Items(i).SubItems(1).Text = "Oxygen Debit(mol/s)" Then
                    Form1.TextBox95.Text = Form1.ListView5.Items(i).SubItems(3).Text
                ElseIf Form1.ListView5.Items(i).SubItems(1).Text = "P_O2 PSM" Then
                    Form1.TextBox23.Text = Form1.ListView5.Items(i).SubItems(3).Text
                ElseIf Form1.ListView5.Items(i).SubItems(1).Text = "CTE efc" Then
                    Form1.TextBox44.Text = Form1.ListView5.Items(i).SubItems(3).Text
                End If
                Form1.Button29.PerformClick()
                Form1.ListView5.Items(i).BackColor = Color.LightBlue
                Form1.ListView5.Items(i).EnsureVisible()
                If Form1.ListView4.Items.Count > 1 Then
                    Form1.ListView4.Items(i - 1).BackColor = Color.White
                    Form1.ListView4.Items(i).BackColor = Color.Yellow
                Else
                    Form1.ListView4.Items(i).BackColor = Color.Yellow
                End If
                Form1.ListView4.Items(i).EnsureVisible()
                If Form1.ListView5.Items.Count = 0 Then
                    MsgBox("Press add first")
                    Exit Sub
                Else
                    If i < Form1.ListView5.Items.Count - 1 Then
                        Form1.ComboBox1.Text = Form1.ListView5.Items(i + 1).SubItems(0).Text
                    Else
                        Form1.ComboBox1.Text = Form1.ListView5.Items(i).SubItems(0).Text
                    End If
                End If
            Next
            MsgBox("finish")
            Form1.ComboBox1.Text = Form1.ComboBox10.Text
            Form1.Button51.BackColor = Color.LightGray
            Form1.Button29.Visible = True
            Form1.Button3.Visible = True
            Form1.Button29.BackColor = Color.LightGray
            Form1.Button3.BackColor = Color.LightGray
        Catch ex As Exception
            MsgBox("Error in running")
            Exit Sub
        End Try
        Form1.Button29.ForeColor = Color.Black
        Form1.Button3.ForeColor = Color.Black
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class