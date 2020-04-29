Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.TextLength > 0 Then
            My.Settings.Imie = TextBox1.Text
            My.Settings.Save()
            Rzut.Show()
            Me.Close()
        Else
            MsgBox("Przedstaw się!", MsgBoxStyle.OkOnly)

        End If

    End Sub
End Class
