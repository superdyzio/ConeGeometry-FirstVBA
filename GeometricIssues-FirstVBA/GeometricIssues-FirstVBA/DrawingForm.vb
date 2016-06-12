Public Class DrawingForm
    Dim stozek As Cone
    Dim rzut As Boolean 'true - rzut z góry, rysujemy kolko, false - rzut z boku, rysujemy trojkacik
    Sub New(ByVal stozek As Cone, ByVal rzut As Boolean)
        Me.stozek = stozek
        Me.rzut = rzut
        InitializeComponent()
    End Sub

    Private Sub DrawingForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim zeroX = 400     ' wyliczony w gowie środek obszaru rysowania
        Dim zeroY = 300
        Dim pisak = Pens.Black
        Dim polWysokosciOkna As Integer = 300   ' w sumie nadmiarowe zmienne, ale zostawiłem hehe
        Dim polSzerokosciOkna As Integer = 400
        e.Graphics.DrawLine(pisak, 0, polWysokosciOkna, 800, polWysokosciOkna)  ' te dwie linie to rysowanie osi układu współrzędnych
        e.Graphics.DrawLine(pisak, polSzerokosciOkna, 0, polSzerokosciOkna, 650)
        For i = 1 To 80 ' rysowanie kreseczek na osi X
            e.Graphics.DrawLine(pisak, i * 10, polWysokosciOkna - 5, i * 10, polWysokosciOkna + 5)
        Next i
        For i = 1 To 60 ' rysowanie kreseczek na osi Y
            e.Graphics.DrawLine(pisak, polSzerokosciOkna - 5, i * 10, polSzerokosciOkna + 5, i * 10)
        Next i

        Dim srodekX = Convert.ToSingle(stozek.srodek.x * 10 + zeroX)    ' rzutowanie wszystkich wartosci na single - metoda rysująca takie chce
        Dim srodekY = Convert.ToSingle(stozek.srodek.y * (-10) + zeroY)
        Dim promien = Convert.ToSingle(stozek.r * 10)
        Dim wysokosc = Convert.ToSingle(stozek.h * (-10))
        If (rzut) Then  ' zależnie od rzutu rysowanie okręgu lub trójkąta
            e.Graphics.DrawEllipse(pisak, srodekX - promien, srodekY - promien, promien * 2, promien * 2)
        Else
            e.Graphics.DrawLine(pisak, srodekX - promien, srodekY, srodekX + promien, srodekY)
            e.Graphics.DrawLine(pisak, srodekX - promien, srodekY, srodekX, srodekY + wysokosc)
            e.Graphics.DrawLine(pisak, srodekX + promien, srodekY, srodekX, srodekY + wysokosc)
        End If
    End Sub
End Class