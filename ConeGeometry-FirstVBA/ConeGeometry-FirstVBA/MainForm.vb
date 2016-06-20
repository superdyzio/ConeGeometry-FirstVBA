Public Class MainForm
    Private cone As Cone

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        For Each tb As TextBox In Controls.OfType(Of TextBox)
            If (tb.Text.IndexOf(",").Equals(tb.TextLength - 1)) Then
                tb.Text = tb.Text + "0"
            End If
        Next
        Dim x, y, r, h As Double
        x = Double.Parse(TextBoxCenterX.Text)
        y = Double.Parse(TextBoxCenterY.Text)
        r = Double.Parse(TextBoxRadius.Text)
        h = Double.Parse(TextBoxHeight.Text)
        cone = New Cone(New Point(x, y), r, h)
        TextBoxVolume.Text = FormatNumber(cone.GetVolume, 4)
        ButtonDraw.Enabled = True
    End Sub

    Private Sub ButtonDraw_Click(sender As Object, e As EventArgs) Handles ButtonDraw.Click
        Dim form As New DrawingForm(cone, DrawingForm.ProjectionType.Top)     ' first window, for projection from the top
        Dim form2 As New DrawingForm(cone, DrawingForm.ProjectionType.Side)   ' second window, for side projection
        If (projectionFits(form.getXAxisLength, form.getYAxisLength)) Then
            If (cone.GetVolume > 0) Then
                form.Show()
                form2.Show()
            Else
                MessageBox.Show("Volume must be greater than zero.", "Not a cone!")
            End If
        Else
                MessageBox.Show("Specified cone will not fit into drawing form.", "Cone too big!")
        End If
    End Sub

    Private Function projectionFits(ByVal xLength As Integer, ByVal yLength As Integer) As Boolean
        Dim correction As Integer = 2
        If ((cone.GetX + cone.GetRadius > xLength - correction) Or (cone.GetX - cone.GetRadius < -xLength + correction) Or
            (cone.GetY + cone.GetRadius > yLength - correction) Or (cone.GetY - cone.GetRadius < -yLength + correction) Or
            (cone.GetY + cone.GetHeight > yLength - correction)) Then
            Return False
        End If
        Return True
    End Function

    Private Sub TextBoxValueChanged(sender As Object, e As EventArgs) Handles TextBoxRadius.TextChanged, TextBoxHeight.TextChanged, TextBoxCenterY.TextChanged, TextBoxCenterX.TextChanged
        EnableCalculating()
        Dim tb As TextBox = CType(sender, TextBox)
        Dim length = tb.TextLength
        If (length > 0) Then
            Dim lastChar As String = tb.Text.Substring(length - 1)
            Select Case (lastChar)
                Case "-"
                    If ((tb.Equals(TextBoxCenterX)) Or (tb.Equals(TextBoxCenterY))) Then
                        If Not (length.Equals(1)) Then
                            tb.Text = tb.Text.Substring(0, length - 1)
                        End If
                    Else
                        tb.Text = tb.Text.Substring(0, length - 1)
                    End If
                Case 0 To 9
                    Dim dotIndex = tb.Text.IndexOf(",")
                    If (dotIndex > 0 And dotIndex < length - 2) Then  ' index of "," is never equal 0, because of text formatting in textbox
                        tb.Text = tb.Text.Substring(0, length - 1)
                    End If
                    If (tb.Text.IndexOf("0").Equals(0) And dotIndex < 0 And length > 1) Then
                        tb.Text = tb.Text.Substring(1, tb.TextLength - 1)
                    End If
                Case ","
                    If (length.Equals(1)) Then
                        tb.Text = "0,"
                    ElseIf (tb.Text.Substring(0, length - 1).Contains(",") Or length.Equals(10)) Then
                        tb.Text = tb.Text.Substring(0, length - 1)
                    End If
                Case Else
                    tb.Text = tb.Text.Substring(0, length - 1)
            End Select
            tb.SelectionStart = tb.TextLength
        End If
    End Sub

    Private Sub EnableCalculating()
        If (TextBoxCenterX.TextLength > 0 And TextBoxCenterY.TextLength > 0 And TextBoxRadius.TextLength > 0 And TextBoxHeight.TextLength > 0) Then
            ButtonCalculate.Enabled = True
        Else
            ButtonCalculate.Enabled = False
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonDraw.Enabled = False
        ButtonCalculate.Enabled = False
    End Sub

    Private Sub TextBoxEnter(sender As Object, e As EventArgs) Handles TextBoxRadius.Enter, TextBoxHeight.Enter, TextBoxCenterY.Enter, TextBoxCenterX.Enter
        Dim tb = CType(sender, TextBox)
        tb.SelectionStart = 0
        tb.SelectionLength = tb.TextLength
    End Sub

    Private Sub TextBoxKeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxRadius.KeyDown, TextBoxHeight.KeyDown, TextBoxCenterY.KeyDown, TextBoxCenterX.KeyDown
        Dim tb = CType(sender, TextBox)
        Select Case (e.KeyCode)
            Case Keys.Back
                If (tb.SelectionLength.Equals(tb.TextLength)) Then
                    tb.Text = ""
                End If
            Case Keys.Left, Keys.Right
                e.SuppressKeyPress = True
            Case Else
        End Select
    End Sub

    Private Sub TextBoxClick(sender As Object, e As EventArgs) Handles TextBoxRadius.Click, TextBoxHeight.Click, TextBoxCenterY.Click, TextBoxCenterX.Click
        Dim tb = CType(sender, TextBox)
        tb.SelectionStart = tb.TextLength
    End Sub
End Class
