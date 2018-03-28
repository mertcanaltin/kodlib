Public Class Form1
    Private Sub ButtonGoster_Click(sender As Object, e As EventArgs) Handles ButtonGoster.Click
        Dim gunler As String
        gunler = TextBoxGunler.Text
        TextBoxGunler.Text = ""
        If gunler = "pazartesi" Then
            TextBoxSonuc.Text = "Mesai Günü"
        ElseIf gunler = "salı" Then
            TextBoxSonuc.Text = "Mesai Günü"
        ElseIf gunler = "çarşamba" Then
            TextBoxSonuc.Text = "Mesai Günü"
        ElseIf gunler = "perşembe" Then
            TextBoxSonuc.Text = "Mesai Günü"
        ElseIf gunler = "cuma" Then
            TextBoxSonuc.Text = "Mesai Günü"
        ElseIf gunler = "cumartesi" Then
            TextBoxSonuc.Text = "Hafta sonu tatili"
        ElseIf gunler = "pazar" Then
            TextBoxSonuc.Text = "Hafta sonu tatili"
        Else
            MsgBox("Günleri küçük harflerle ve türkçe karakterlerle yazınız.")
        End If
    End Sub
End Class
