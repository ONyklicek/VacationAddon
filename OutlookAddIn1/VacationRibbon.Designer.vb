Partial Class VacationRibbon
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Vyžadované pro podporu Návrháře kompozice třídy Windows.Forms
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'Toto volání je vyžadované Návrhářem komponent.
        InitializeComponent()

    End Sub

    'Komponenta přepisuje metodu Dispose, aby vyčistila seznam součástí.
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

    'Vyžadováno Návrhářem komponent
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující proceduru vyžaduje Návrhář komponent
    'Dá se upravit pomocí Návrháře komponent.
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim RibbonDialogLauncherImpl1 As Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher = Me.Factory.CreateRibbonDialogLauncher
        Me.Vacation = Me.Factory.CreateRibbonTab
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.btnToggle = Me.Factory.CreateRibbonToggleButton
        Me.Vacation.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Vacation
        '
        Me.Vacation.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Vacation.Groups.Add(Me.Group1)
        Me.Vacation.Label = "Dovolená"
        Me.Vacation.Name = "Vacation"
        '
        'Group1
        '
        Me.Group1.DialogLauncher = RibbonDialogLauncherImpl1
        Me.Group1.Items.Add(Me.btnToggle)
        Me.Group1.Name = "Group1"
        '
        'btnToggle
        '
        Me.btnToggle.Label = "ToggleButton1"
        Me.btnToggle.Name = "btnToggle"
        '
        'VacationRibbon
        '
        Me.Name = "VacationRibbon"
        Me.RibbonType = "Microsoft.Outlook.Mail.Read"
        Me.Tabs.Add(Me.Vacation)
        Me.Vacation.ResumeLayout(False)
        Me.Vacation.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Vacation As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnToggle As Microsoft.Office.Tools.Ribbon.RibbonToggleButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property VacationRibbon() As VacationRibbon
        Get
            Return Me.GetRibbon(Of VacationRibbon)()
        End Get
    End Property
End Class
