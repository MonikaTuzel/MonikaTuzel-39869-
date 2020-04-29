Public Class Rzut
    Private rzucaj As Random
    Private Sub Rzut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Witaj " & My.Settings.Imie & "!"

    End Sub

    Private Sub r(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        rzucaj = New Random
        Label3.Text = rzucaj.Next(1, 7)

    End Sub

    Private Sub Label3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Label3.MouseDoubleClick
        My.Computer.Clipboard.SetText(Label3.Text)
        MsgBox("Zapisałeś swój wynik do schowka!")

    End Sub

End Class