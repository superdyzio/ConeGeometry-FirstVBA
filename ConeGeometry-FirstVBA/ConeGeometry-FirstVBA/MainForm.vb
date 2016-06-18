Public Class MainForm
    Private cone As Cone

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
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
        Dim form As New DrawingForm(cone, True)
        form.Show()     ' first window, for projection from the top
        Dim form2 As New DrawingForm(cone, False)
        form2.Show()    ' second window, for side projection
    End Sub

    Private Sub TextBoxValueChanged(sender As Object, e As EventArgs) Handles TextBoxRadius.TextChanged, TextBoxHeight.TextChanged, TextBoxCenterY.TextChanged, TextBoxCenterX.TextChanged
        EnableCalculating()
        Dim tb As TextBox = CType(sender, TextBox)
        Dim length = tb.TextLength
        If (length > 0) Then
            Dim lastChar As String = tb.Text.Substring(length - 1)
            Select Case (lastChar)
                Case 0 To 9
                    Dim dotIndex = tb.Text.IndexOf(".")
                    If (dotIndex > 0 And dotIndex < length - 2) Then  ' index of "." is never equal 0, because of text formatting in textbox
                        tb.Text = tb.Text.Substring(0, length - 1)
                    End If
                Case "."
                    If (length.Equals(1)) Then
                        tb.Text = "0."
                    ElseIf (tb.Text.Substring(0, length - 1).Contains(".")) Then
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
End Class
