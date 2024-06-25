Partial Class VacationRibbon
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Vyžadované pro podporu Návrháře kompozice třídy Windows.Forms
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'Toto volání je vyžadované Návrhářem komponent.
        InitializeComponent()

    End Sub

    'Komponenta přepisuje metodu Dispose, aby vyčistila seznam součástí.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Vyžadováno Návrhářem komponent
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující proceduru vyžaduje Návrhář komponent
    'Dá se upravit pomocí Návrháře komponent.
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Vacation = Me.Factory.CreateRibbonTab
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.CheckBox1 = Me.Factory.CreateRibbonCheckBox
        Me.Vacation.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Vacation
        '
        Me.Vacation.Groups.Add(Me.Group1)
        Me.Vacation.Label = "Dovolená"
        Me.Vacation.Name = "Vacation"
        '
        'Group1
        '
        Me.Group1.Items.Add(Me.CheckBox1)
        Me.Group1.Name = "Group1"
        '
        'CheckBox1
        '
        Me.CheckBox1.Label = "Aktivovat režim dovolené"
        Me.CheckBox1.Name = "CheckBox1"
        '
        'VacationRibbon
        '
        Me.Name = "VacationRibbon"
        Me.RibbonType = "Microsoft.Outlook.Explorer"
        Me.Tabs.Add(Me.Vacation)
        Me.Vacation.ResumeLayout(False)
        Me.Vacation.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Vacation As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents CheckBox1 As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property VacationRibbon() As VacationRibbon
        Get
            Return Me.GetRibbon(Of VacationRibbon)()
        End Get
    End Property
End Class
