<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.LabelCenterX = New System.Windows.Forms.Label()
        Me.LabelCenterY = New System.Windows.Forms.Label()
        Me.LabelRadius = New System.Windows.Forms.Label()
        Me.LabelHeight = New System.Windows.Forms.Label()
        Me.LabelVolume = New System.Windows.Forms.Label()
        Me.TextBoxCenterX = New System.Windows.Forms.TextBox()
        Me.TextBoxRadius = New System.Windows.Forms.TextBox()
        Me.TextBoxHeight = New System.Windows.Forms.TextBox()
        Me.TextBoxCenterY = New System.Windows.Forms.TextBox()
        Me.TextBoxVolume = New System.Windows.Forms.TextBox()
        Me.ButtonDraw = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(26, 82)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(115, 23)
        Me.ButtonCalculate.TabIndex = 5
        Me.ButtonCalculate.Text = "Calculate volume"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'LabelCenterX
        '
        Me.LabelCenterX.AutoSize = True
        Me.LabelCenterX.Location = New System.Drawing.Point(13, 13)
        Me.LabelCenterX.Name = "LabelCenterX"
        Me.LabelCenterX.Size = New System.Drawing.Size(51, 13)
        Me.LabelCenterX.TabIndex = 1
        Me.LabelCenterX.Text = "Center X:"
        '
        'LabelCenterY
        '
        Me.LabelCenterY.AutoSize = True
        Me.LabelCenterY.Location = New System.Drawing.Point(184, 13)
        Me.LabelCenterY.Name = "LabelCenterY"
        Me.LabelCenterY.Size = New System.Drawing.Size(51, 13)
        Me.LabelCenterY.TabIndex = 2
        Me.LabelCenterY.Text = "Center Y:"
        '
        'LabelRadius
        '
        Me.LabelRadius.AutoSize = True
        Me.LabelRadius.Location = New System.Drawing.Point(13, 39)
        Me.LabelRadius.Name = "LabelRadius"
        Me.LabelRadius.Size = New System.Drawing.Size(43, 13)
        Me.LabelRadius.TabIndex = 3
        Me.LabelRadius.Text = "Radius:"
        '
        'LabelHeight
        '
        Me.LabelHeight.AutoSize = True
        Me.LabelHeight.Location = New System.Drawing.Point(184, 39)
        Me.LabelHeight.Name = "LabelHeight"
        Me.LabelHeight.Size = New System.Drawing.Size(41, 13)
        Me.LabelHeight.TabIndex = 4
        Me.LabelHeight.Text = "Height:"
        '
        'LabelVolume
        '
        Me.LabelVolume.AutoSize = True
        Me.LabelVolume.Location = New System.Drawing.Point(12, 140)
        Me.LabelVolume.Name = "LabelVolume"
        Me.LabelVolume.Size = New System.Drawing.Size(45, 13)
        Me.LabelVolume.TabIndex = 5
        Me.LabelVolume.Text = "Volume:"
        '
        'TextBoxCenterX
        '
        Me.TextBoxCenterX.Location = New System.Drawing.Point(73, 10)
        Me.TextBoxCenterX.Name = "TextBoxCenterX"
        Me.TextBoxCenterX.Size = New System.Drawing.Size(68, 20)
        Me.TextBoxCenterX.TabIndex = 1
        '
        'TextBoxRadius
        '
        Me.TextBoxRadius.Location = New System.Drawing.Point(73, 39)
        Me.TextBoxRadius.Name = "TextBoxRadius"
        Me.TextBoxRadius.Size = New System.Drawing.Size(68, 20)
        Me.TextBoxRadius.TabIndex = 3
        '
        'TextBoxHeight
        '
        Me.TextBoxHeight.Location = New System.Drawing.Point(258, 39)
        Me.TextBoxHeight.Name = "TextBoxHeight"
        Me.TextBoxHeight.Size = New System.Drawing.Size(68, 20)
        Me.TextBoxHeight.TabIndex = 4
        '
        'TextBoxCenterY
        '
        Me.TextBoxCenterY.Location = New System.Drawing.Point(258, 10)
        Me.TextBoxCenterY.Name = "TextBoxCenterY"
        Me.TextBoxCenterY.Size = New System.Drawing.Size(68, 20)
        Me.TextBoxCenterY.TabIndex = 2
        '
        'TextBoxVolume
        '
        Me.TextBoxVolume.Location = New System.Drawing.Point(73, 137)
        Me.TextBoxVolume.Name = "TextBoxVolume"
        Me.TextBoxVolume.ReadOnly = True
        Me.TextBoxVolume.Size = New System.Drawing.Size(253, 20)
        Me.TextBoxVolume.TabIndex = 10
        Me.TextBoxVolume.TabStop = False
        Me.TextBoxVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonDraw
        '
        Me.ButtonDraw.Location = New System.Drawing.Point(216, 82)
        Me.ButtonDraw.Name = "ButtonDraw"
        Me.ButtonDraw.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDraw.TabIndex = 6
        Me.ButtonDraw.Text = "Draw"
        Me.ButtonDraw.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 180)
        Me.Controls.Add(Me.ButtonDraw)
        Me.Controls.Add(Me.TextBoxVolume)
        Me.Controls.Add(Me.TextBoxCenterY)
        Me.Controls.Add(Me.TextBoxHeight)
        Me.Controls.Add(Me.TextBoxRadius)
        Me.Controls.Add(Me.TextBoxCenterX)
        Me.Controls.Add(Me.LabelVolume)
        Me.Controls.Add(Me.LabelHeight)
        Me.Controls.Add(Me.LabelRadius)
        Me.Controls.Add(Me.LabelCenterY)
        Me.Controls.Add(Me.LabelCenterX)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents LabelCenterX As Label
    Friend WithEvents LabelCenterY As Label
    Friend WithEvents LabelRadius As Label
    Friend WithEvents LabelHeight As Label
    Friend WithEvents LabelVolume As Label
    Friend WithEvents TextBoxCenterX As TextBox
    Friend WithEvents TextBoxRadius As TextBox
    Friend WithEvents TextBoxHeight As TextBox
    Friend WithEvents TextBoxCenterY As TextBox
    Friend WithEvents TextBoxVolume As TextBox
    Friend WithEvents ButtonDraw As Button
End Class
