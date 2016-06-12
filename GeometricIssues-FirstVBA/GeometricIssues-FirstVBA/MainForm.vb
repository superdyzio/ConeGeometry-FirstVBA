Public Class MainForm
    Dim cone As Cone
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim x, y, r, h As Double    ' zmienne dla wartości odczytanych z textboxów
        x = Double.Parse(TextBoxCenterX.Text)   ' rzutowanie wartości tekstowych na liczby typu double
        y = Double.Parse(TextBoxCenterY.Text)
        r = Double.Parse(TextBoxRadius.Text)
        h = Double.Parse(TextBoxHeight.Text)
        cone = New Cone(New Point(x, y), r, h)  ' stworzenie obiektu stozka
        TextBoxVolume.Text = cone.objetosc      ' wypełnienie odpowiedniego textboxa wartoscia objetosci stożka (zwracane przez metodę volume)
    End Sub

    ' obsługa kliknięcia przycisku
    Private Sub ButtonDraw_Click(sender As Object, e As EventArgs) Handles ButtonDraw.Click
        Dim form As New DrawingForm(cone, True)
        form.Show() ' uruchomienie pierwszego okienka, dla jednego rzutu
        Dim form2 As New DrawingForm(cone, False)
        form2.Show()    ' uruchomienie drugiego okienka, dla drugiego rzutu
    End Sub
End Class
