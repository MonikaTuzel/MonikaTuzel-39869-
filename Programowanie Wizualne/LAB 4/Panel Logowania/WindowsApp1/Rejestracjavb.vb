Public Class Rejestracja
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.Login = LoginTextBox1.Text
        My.Settings.Hasło = HasloTextBox2.Text
        My.Settings.Save()
        MsgBox("rejestracja przebiegła pomyślnie!", MsgBoxStyle.Information)
        Me.Hide()
        Form1.Show()
        Me.Close()

    End Sub


End Class