Public Class Point
    Private x As Double
    Private y As Double

    Sub New(ByVal x As Double, ByVal y As Double)
        Me.x = x
        Me.y = y
    End Sub

    Public Function GetX() As Double
        Return x
    End Function

    Public Function GetY() As Double
        Return y
    End Function
End Class
