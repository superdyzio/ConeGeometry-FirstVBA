Public Class DrawingForm
    Public Enum ProjectionType As Integer
        Side = 0
        Top = 1
    End Enum

    Private cone As Cone
    Private projection As Integer 'true - projection from the top, false - side projection
    Private drawingScale = 10  ' number of pixels corresponding to coordinate value equal to 1

    Function getXAxisLength() As Integer
        Return Convert.ToSingle((Me.Width / 2) / drawingScale)
    End Function

    Function getYAxisLength() As Integer
        Return Convert.ToSingle((Me.Height / 2) / drawingScale)
    End Function

    Sub New(ByVal cone As Cone, ByVal projection As Integer)
        Me.cone = cone
        Me.projection = projection
        If (projection.Equals(ProjectionType.Top)) Then
            Me.Text = "Projection from the top"
        Else
            Me.Text = "Side projection"
        End If
        InitializeComponent()
    End Sub

    Private Sub DrawingForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim pen = Pens.Black
        Dim halfFormHeight As Integer = (Me.Height / 2) - 20
        Dim halfFormWidth As Integer = (Me.Width / 2) - 10
        e.Graphics.DrawLine(pen, 0, halfFormHeight, Me.Width, halfFormHeight)  ' X and Y axes
        e.Graphics.DrawLine(pen, halfFormWidth, 0, halfFormWidth, Me.Height)
        Dim xAxisScale = Convert.ToSingle(Me.Width / drawingScale)
        Dim yAxisScale = Convert.ToSingle(Me.Height / drawingScale)
        For i = 1 To xAxisScale
            e.Graphics.DrawLine(pen, i * drawingScale, halfFormHeight - 5, i * drawingScale, halfFormHeight + 5)
        Next i
        For i = 1 To yAxisScale
            e.Graphics.DrawLine(pen, halfFormWidth - 5, i * drawingScale, halfFormWidth + 5, i * drawingScale)
        Next i
        ' values conversion
        Dim centerX = Convert.ToSingle(cone.GetX() * drawingScale + halfFormWidth)
        Dim centerY = Convert.ToSingle(cone.GetY() * (-drawingScale) + halfFormHeight)
        Dim radius = Convert.ToSingle(cone.GetRadius * drawingScale)
        Dim height = Convert.ToSingle(cone.GetHeight * (-drawingScale))
        Dim diameter = Convert.ToSingle(cone.GetDiameter * drawingScale)
        If (projection.Equals(ProjectionType.Top)) Then  ' drawing the appropriate projection, depending on variable
            e.Graphics.DrawEllipse(pen, centerX - radius, centerY - radius, diameter, diameter)
        Else
            e.Graphics.DrawLine(pen, centerX - radius, centerY, centerX + radius, centerY)
            e.Graphics.DrawLine(pen, centerX - radius, centerY, centerX, centerY + height)
            e.Graphics.DrawLine(pen, centerX + radius, centerY, centerX, centerY + height)
        End If
    End Sub
End Class