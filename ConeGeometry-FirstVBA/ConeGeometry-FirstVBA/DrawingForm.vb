Public Class DrawingForm
    Public Enum ProjectionType As Integer
        Side = 0
        Top = 1
    End Enum

    Private cone As Cone
    Private projection As Integer 'true - projection from the top, false - side projection
    Private drawingScale As Integer = 10  ' number of pixels corresponding to coordinate value equal to 1

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
        Dim penNormal = Pens.Black
        Dim penDashed As Pen = New Pen(New SolidBrush(Color.Red))
        penDashed.DashCap = Drawing2D.LineCap.Round
        penDashed.DashStyle = Drawing2D.DashStyle.Dash
        Dim halfFormHeight As Integer = (Me.Height / 2) - 20
        Dim halfFormWidth As Integer = (Me.Width / 2) - 10
        e.Graphics.DrawLine(penNormal, 0, halfFormHeight, Me.Width, halfFormHeight)  ' X and Y axes
        e.Graphics.DrawLine(penNormal, halfFormWidth, 0, halfFormWidth, Me.Height)
        Dim xAxisScale = Convert.ToSingle(Me.Width / drawingScale)
        Dim yAxisScale = Convert.ToSingle(Me.Height / drawingScale)
        For i = 1 To xAxisScale
            If (((i * drawingScale - halfFormWidth) Mod 50).Equals(0)) Then
                e.Graphics.DrawLine(penNormal, i * drawingScale, halfFormHeight - 5, i * drawingScale, halfFormHeight + 5)
            Else
                e.Graphics.DrawLine(penNormal, i * drawingScale, halfFormHeight - 2, i * drawingScale, halfFormHeight + 2)
            End If
        Next i
        For i = 1 To yAxisScale
            If (((i * drawingScale - halfFormHeight) Mod 50).Equals(0)) Then
                e.Graphics.DrawLine(penNormal, halfFormWidth - 5, i * drawingScale, halfFormWidth + 5, i * drawingScale)
            Else
                e.Graphics.DrawLine(penNormal, halfFormWidth - 2, i * drawingScale, halfFormWidth + 2, i * drawingScale)
            End If
        Next i
        ' values conversion
        Dim centerX = Convert.ToSingle(cone.GetX() * drawingScale + halfFormWidth)
        Dim centerY = Convert.ToSingle(cone.GetY() * (-drawingScale) + halfFormHeight)
        Dim radius = Convert.ToSingle(cone.GetRadius * drawingScale)
        Dim height = Convert.ToSingle(cone.GetHeight * (-drawingScale))
        Dim diameter = Convert.ToSingle(cone.GetDiameter * drawingScale)
        If (projection.Equals(ProjectionType.Top)) Then  ' drawing the appropriate projection, depending on variable
            e.Graphics.DrawEllipse(penNormal, centerX - radius, centerY - radius, diameter, diameter)
            e.Graphics.DrawLine(penNormal, centerX, centerY, centerX, centerY)
            e.Graphics.DrawLine(penDashed, centerX, halfFormHeight, centerX, centerY)
            e.Graphics.DrawLine(penDashed, halfFormWidth, centerY, centerX, centerY)
            Dim cornerSquareDiagonal = Convert.ToSingle((Math.Sqrt(2) - 1) * radius / Math.Sqrt(2))
            e.Graphics.DrawLine(penDashed, centerX, centerY, centerX + radius - cornerSquareDiagonal, centerY - radius + cornerSquareDiagonal)
        Else
            e.Graphics.DrawLine(penNormal, centerX - radius, centerY, centerX + radius, centerY)
            e.Graphics.DrawLine(penNormal, centerX - radius, centerY, centerX, centerY + height)
            e.Graphics.DrawLine(penNormal, centerX + radius, centerY, centerX, centerY + height)
            If (centerX > halfFormWidth) Then
                e.Graphics.DrawLine(penDashed, halfFormWidth, centerY, centerX - radius, centerY)
            ElseIf (centerX < halfFormWidth) Then
                e.Graphics.DrawLine(penDashed, halfFormWidth, centerY, centerX + radius, centerY)
            End If
            If (centerY < halfFormHeight) Then
                e.Graphics.DrawLine(penDashed, centerX, halfFormHeight, centerX, centerY)
            ElseIf (centerY > halfFormHeight) Then
                e.Graphics.DrawLine(penDashed, centerX, halfFormHeight, centerX, centerY + height)
            End If
            e.Graphics.DrawLine(penDashed, centerX, centerY, centerX, centerY + height)
        End If
    End Sub
End Class