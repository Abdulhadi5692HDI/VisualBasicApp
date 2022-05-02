Public Class LoginForm1

    ' Sets Username and Password '

        Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "hadi" Then
            Form2.Show()
            Me.Close()
        End If
        If UsernameTextBox.Text = "*" Then
            ErrorDialog1.Show()
            Me.Close()
        End If
    End Sub

        Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
            Form1.Show()
            Me.Close()
        End Sub

    End Class
