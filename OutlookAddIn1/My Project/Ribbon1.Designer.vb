﻿Partial Class Ribbon1
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
        Me.Dovolená = Me.Factory.CreateRibbonTab
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.Dovolená.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dovolená
        '
        Me.Dovolená.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Dovolená.ControlId.OfficeId = "Vacation"
        Me.Dovolená.Groups.Add(Me.Group1)
        Me.Dovolená.Label = "Dovolená"
        Me.Dovolená.Name = "Dovolená"
        '
        'Group1
        '
        Me.Group1.DialogLauncher = RibbonDialogLauncherImpl1
        Me.Group1.Label = "Group1"
        Me.Group1.Name = "Group1"
        '
        'VacationResponderRibbon
        '
        Me.Name = "VacationResponderRibbon"
        Me.RibbonType = "Microsoft.Outlook.Mail.Read"
        Me.Tabs.Add(Me.Dovolená)
        Me.Dovolená.ResumeLayout(False)
        Me.Dovolená.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Dovolená As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As Ribbon1
        Get
            Return Me.GetRibbon(Of Ribbon1)()
        End Get
    End Property
End Class
