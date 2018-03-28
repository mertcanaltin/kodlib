Public Class Form1
    Private Sub ButtonSonuc_Click(sender As Object, e As EventArgs) Handles ButtonSonuc.Click
        Dim sayi As Integer
        sayi = TextBoxSayi.Text
        If sayi < 100 And sayi > -100 Then
            TextBoxSonuc.Text = "Girdiğiniz sayı 2 hanelidir."
        Else
            TextBoxSonuc.Text = "Girdiğiniz sayı 2 haneli değildir."
        End If
    End Sub
End Class
