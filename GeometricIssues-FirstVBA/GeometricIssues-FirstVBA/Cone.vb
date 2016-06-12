Public Class Cone
    Public srodek As Point
    Public r, h As Double
    Sub New(ByVal srodek As Point, ByVal r As Double, ByVal h As Double)
        Me.srodek = srodek
        Me.r = r
        Me.h = h
    End Sub
    Public Function objetosc() As Double
        Return Math.PI * r * r * h / 3
    End Function
End Class
