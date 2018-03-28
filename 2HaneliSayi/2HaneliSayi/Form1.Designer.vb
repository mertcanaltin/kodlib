<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSayi = New System.Windows.Forms.TextBox()
        Me.ButtonSonuc = New System.Windows.Forms.Button()
        Me.TextBoxSonuc = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sayı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sonuç:"
        '
        'TextBoxSayi
        '
        Me.TextBoxSayi.Location = New System.Drawing.Point(69, 17)
        Me.TextBoxSayi.Name = "TextBoxSayi"
        Me.TextBoxSayi.Size = New System.Drawing.Size(218, 22)
        Me.TextBoxSayi.TabIndex = 2
        '
        'ButtonSonuc
        '
        Me.ButtonSonuc.Location = New System.Drawing.Point(69, 45)
        Me.ButtonSonuc.Name = "ButtonSonuc"
        Me.ButtonSonuc.Size = New System.Drawing.Size(218, 35)
        Me.ButtonSonuc.TabIndex = 3
        Me.ButtonSonuc.Text = "Sonuç"
        Me.ButtonSonuc.UseVisualStyleBackColor = True
        '
        'TextBoxSonuc
        '
        Me.TextBoxSonuc.Location = New System.Drawing.Point(70, 86)
        Me.TextBoxSonuc.Name = "TextBoxSonuc"
        Me.TextBoxSonuc.Size = New System.Drawing.Size(217, 22)
        Me.TextBoxSonuc.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 138)
        Me.Controls.Add(Me.TextBoxSonuc)
        Me.Controls.Add(Me.ButtonSonuc)
        Me.Controls.Add(Me.TextBoxSayi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxSayi As TextBox
    Friend WithEvents ButtonSonuc As Button
    Friend WithEvents TextBoxSonuc As TextBox
End Class
