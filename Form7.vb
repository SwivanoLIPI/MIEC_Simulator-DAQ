Public Class Form7
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Form5.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Form1.Button47.Enabled = True
            Form1.Button46.Enabled = True
            Form1.ComboBox9.Enabled = True
            Form1.ComboBox10.Enabled = True
            Form1.ComboBox11.Enabled = True
            Form1.ComboBox15.Enabled = True
            Form1.TextBox69.Text = "10"
            Form1.TextBox70.Text = "10"
            Form1.TextBox71.Text = "100"
            Form1.TextBox69.Enabled = True
            Form1.TextBox70.Enabled = True
            Form1.TextBox71.Enabled = True
            Form1.Label50.Enabled = True
            Form1.Label51.Enabled = True
            Form1.Label51.ForeColor = Color.Black
            Form1.Label52.Enabled = True
            Form1.Label13.Enabled = True
            Form1.Label50.Text = "Init Value"
            Form1.Label66.Text = "Database of Multi Curve Configuration"
            Form1.Label89.BackColor = Color.Transparent
            Form1.Label66.BackColor = Color.Transparent
            Me.Close()
            Form1.Show()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form7_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Form9.Hide()
            Form9.Close()
            If Form1.Button46.Enabled = False Then
                Form1.ComboBox8.Text = "Single Curve"
            End If
            If Application.OpenForms().OfType(Of Form5).Any Then
                If Form5.ListView3.Items(Form5.ListView3.Items.Count - 1).BackColor = Color.LightGreen Then
                    If Application.OpenForms().OfType(Of Form9).Any Then
                        Form9.Hide()
                    Else
                        Form9.Show()
                    End If
                    Exit Sub
                Else
                    Form1.ComboBox8.Text = "Multi Curve"
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Application.OpenForms().OfType(Of Form5).Any Then
            Form1.ComboBox8.Text = "Multi Curve"
            Exit Sub
        End If
        If Application.OpenForms().OfType(Of Form5).Any Then
            Me.Close()
        End If
    End Sub
End Class