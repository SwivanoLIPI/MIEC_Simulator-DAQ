Public Class Form9
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.Button31.PerformClick()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Button8.PerformClick()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Button66.PerformClick()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Button67.PerformClick()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form1.Button43.PerformClick()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Form1.Button6.PerformClick()
        MsgBox("This Program ready to run simulation now!" & (vbCrLf) & (vbCrLf) & "You can directly press button related with run again!" & (vbCrLf) & (vbCrLf) & "Note: " & (vbCrLf) & (vbCrLf) & "1. If you changes to ""Multi Curve"" mode please manage the configuration first" & (vbCrLf) & (vbCrLf) & "2. If you already used ""Multi Curve"" mode, make sure all your configuration row color in configuration table is not ""Green"" or ""Blue!""" & (vbCrLf) & (vbCrLf) & "3. If all row of configuration color is ""Green"" or ""Blue"", database of configuration need to be added or changes.")
        If Form1.ComboBox8.Text = "Multi Curve" And Not Application.OpenForms().OfType(Of Form5).Any Then
            Form7.Show()
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form1.ComboBox8.Text = Form1.ComboBox8.Text
        Me.Close()
    End Sub
    Private Sub Form9_FormClosing_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If Application.OpenForms().OfType(Of Form5).Any Then
                Form1.ComboBox8.Text = "Multi Curve"
                Exit Sub
            End If
            If Form1.ComboBox8.Text = "Multi Curve" Then
                Form7.Show()
            Else
                Form7.Close()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Application.OpenForms().OfType(Of Form5).Any Then
            Form1.ComboBox8.Text = "Multi Curve"
            Exit Sub
        End If
    End Sub
End Class