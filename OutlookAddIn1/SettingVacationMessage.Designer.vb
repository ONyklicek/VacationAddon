<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingVacationMessage
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(27, 111)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(743, 247)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'SettingVacationMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "SettingVacationMessage"
        Me.Text = "tex"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As Windows.Forms.RichTextBox
End Class
