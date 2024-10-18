Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Example: Check against hardcoded credentials
        If username = "admin" And password = "password123" Then
            Dim storeForm As New StorePage()
            storeForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid credentials, please try again.")
        End If
    End Sub
End Class
