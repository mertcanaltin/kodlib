Public Class Form1
    Private Sub ButtonGoster_Click(sender As Object, e As EventArgs) Handles ButtonGoster.Click
        Dim gunler As String
        gunler = TextBoxGun.Text
        TextBoxGun.Text = ""
        Select Case gunler
            Case "pazartesi"
                TextBoxSonuc.Text = "Mesai Günü"
            Case "salı"
                TextBoxSonuc.Text = "Mesai Günü"
            Case "çarşamba"
                TextBoxSonuc.Text = "Mesai Günü"
            Case "perşembe"
                TextBoxSonuc.Text = "Mesai Günü"
            Case "cuma"
                TextBoxSonuc.Text = "Mesai Günü"
            Case "cumartesi"
                TextBoxSonuc.Text = "Hafta sonu tatili"
            Case "pazar"
                TextBoxSonuc.Text = "Hafta sonu tatili"
        End Select
    End Sub
End Class
