<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsVacationTime
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
        Me.DateTimePickerStart = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateTimePickerStart
        '
        Me.DateTimePickerStart.Location = New System.Drawing.Point(39, 22)
        Me.DateTimePickerStart.Name = "DateTimePickerStart"
        Me.DateTimePickerStart.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerStart.TabIndex = 0
        '
        'DateTimePickerEnd
        '
        Me.DateTimePickerEnd.Location = New System.Drawing.Point(39, 54)
        Me.DateTimePickerEnd.Name = "DateTimePickerEnd"
        Me.DateTimePickerEnd.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerEnd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Od"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Do"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(164, 98)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Uložit"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'SettingsVacationTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 145)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePickerEnd)
        Me.Controls.Add(Me.DateTimePickerStart)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsVacationTime"
        Me.Text = "Nastavení doby dovolený"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePickerStart As Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerEnd As Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btnSave As Windows.Forms.Button
End Class
