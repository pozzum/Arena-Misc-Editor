<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button_Misc = New System.Windows.Forms.Button()
        Me.Button_Show = New System.Windows.Forms.Button()
        Me.Button_Color = New System.Windows.Forms.Button()
        Me.Button_Objects = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "2K17 Misc"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button_Misc
        '
        Me.Button_Misc.Location = New System.Drawing.Point(93, 12)
        Me.Button_Misc.Name = "Button_Misc"
        Me.Button_Misc.Size = New System.Drawing.Size(75, 23)
        Me.Button_Misc.TabIndex = 1
        Me.Button_Misc.Text = "2K18 Misc"
        Me.Button_Misc.UseVisualStyleBackColor = True
        '
        'Button_Show
        '
        Me.Button_Show.Location = New System.Drawing.Point(174, 12)
        Me.Button_Show.Name = "Button_Show"
        Me.Button_Show.Size = New System.Drawing.Size(75, 23)
        Me.Button_Show.TabIndex = 2
        Me.Button_Show.Text = "Show Edit"
        Me.Button_Show.UseVisualStyleBackColor = True
        '
        'Button_Color
        '
        Me.Button_Color.Location = New System.Drawing.Point(255, 12)
        Me.Button_Color.Name = "Button_Color"
        Me.Button_Color.Size = New System.Drawing.Size(75, 23)
        Me.Button_Color.TabIndex = 3
        Me.Button_Color.Text = "Color Edit"
        Me.Button_Color.UseVisualStyleBackColor = True
        '
        'Button_Objects
        '
        Me.Button_Objects.Location = New System.Drawing.Point(336, 12)
        Me.Button_Objects.Name = "Button_Objects"
        Me.Button_Objects.Size = New System.Drawing.Size(75, 23)
        Me.Button_Objects.TabIndex = 4
        Me.Button_Objects.Text = "Objects Edit"
        Me.Button_Objects.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 47)
        Me.Controls.Add(Me.Button_Objects)
        Me.Controls.Add(Me.Button_Color)
        Me.Controls.Add(Me.Button_Show)
        Me.Controls.Add(Me.Button_Misc)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button_Misc As Button
    Friend WithEvents Button_Show As Button
    Friend WithEvents Button_Color As Button
    Friend WithEvents Button_Objects As Button
End Class
