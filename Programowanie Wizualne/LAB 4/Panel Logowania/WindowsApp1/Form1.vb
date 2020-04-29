Public Class Form1
    Private Sub RejestracjaButton2_Click(sender As Object, e As EventArgs) Handles RejestracjaButton2.Click
        Me.Hide()
        Rejestracja.Show()

    End Sub

    Private Sub ZalogujButton1_Click(sender As Object, e As EventArgs) Handles ZalogujButton1.Click
        If My.Settings.Login = TextBox1.Text And My.Settings.Hasło = TextBox2.Text Then
            Me.Hide()
            Zalogowano.Show()
            Me.Close()

        Else
            MsgBox("Niepoprawne hasło lub login!", MsgBoxStyle.Critical)
        End If

    End Sub
End Class
