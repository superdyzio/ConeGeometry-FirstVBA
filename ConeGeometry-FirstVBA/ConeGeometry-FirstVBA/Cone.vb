Public Class Cone
    Private center As Point
    Private radius As Double
    Private height As Double

    Sub New(ByVal center As Point, ByVal radius As Double, ByVal height As Double)
        Me.center = center
        Me.radius = radius
        Me.height = height
    End Sub

    Public Function GetX() As Double
        Return center.GetX
    End Function

    Public Function GetY() As Double
        Return center.GetY
    End Function

    Public Function GetRadius() As Double
        Return radius
    End Function

    Public Function GetDiameter() As Double
        Return radius * 2
    End Function

    Public Function GetHeight() As Double
        Return height
    End Function

    Public Function GetVolume() As Double
        Return Math.PI * radius * radius * height / 3
    End Function
End Class
