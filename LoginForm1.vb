Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Sub loginForm1_FormClosing_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try

            If Application.OpenForms().OfType(Of Form2).Any Then
                Form2.Close()
            ElseIf Application.OpenForms().OfType(Of Form3).Any Then
                Form3.Close()
            ElseIf Application.OpenForms().OfType(Of Form4).Any Then
                Form4.Close()
            ElseIf Application.OpenForms().OfType(Of Form5).Any Then
                Form5.Close()
            ElseIf Application.OpenForms().OfType(Of Form6).Any Then
                Form6.Close()
            ElseIf Application.OpenForms().OfType(Of Form7).Any Then
                Form7.Close()
            ElseIf Application.OpenForms().OfType(Of Form8).Any Then
                Form8.Close()
            ElseIf Application.OpenForms().OfType(Of Form5).Any Then
                Form9.Close()
            ElseIf Application.OpenForms().OfType(Of Form9).Any Then
                Form9.Close()
                Form7.Close()
            Else
                Form10.Close()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "trial" And PasswordTextBox.Text = "trial" Then
            If My.Computer.Clock.LocalTime.Year = 2020 And My.Computer.Clock.LocalTime.Month = 3 And My.Computer.Clock.LocalTime.Day = 30 Then

                Me.Hide()
                Dialog1.Show()
            Else
                Me.Visible = False
                Me.Hide()
                Dialog2.Show()
            End If


        ElseIf UsernameTextBox.Text = "trial" And Not PasswordTextBox.Text = "trial" Then
            MsgBox("Wrong Password")
            PasswordLabel.ForeColor = Color.Red
        ElseIf UsernameTextBox.Text = "trial" And Not PasswordTextBox.Text = "trial" Then
            UsernameLabel.ForeColor = Color.Red
            MsgBox("Username is not recognized")
        Else
            PasswordLabel.ForeColor = Color.Red
            UsernameLabel.ForeColor = Color.Red
            MsgBox("You input wrong password and incorrect Username")
        End If
        'Me.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
