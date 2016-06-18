Public Class Point
    Private x, y As Double

    Public Function GetX() As Double
        Return x
    End Function

    Public Function GetY() As Double
        Return y
    End Function

    Sub New(ByVal x As Double, ByVal y As Double)
        Me.x = x
        Me.y = y
    End Sub
End Class
