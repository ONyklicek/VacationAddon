Imports System
Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Tools.Ribbon
Imports System.Windows.Forms

Public Class ThisAddIn
    Private WithEvents InboxItems As Outlook.Items

    Private _settings As ResponderSettings
    Private _responder As Respounder


    Private Sub ThisAddIn_Startup() Handles Me.Startup
        'Boot
        _settings = New ResponderSettings
        _responder = New Respounder(_settings)

        Dim outlookApp As Outlook.Application = Me.Application
        Dim inbox As Outlook.MAPIFolder = DirectCast(outlookApp.ActiveExplorer().Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox), Outlook.MAPIFolder)
        InboxItems = inbox.Items

        'Dim RibbornUI = Microsoft.Office.Tools.Ribbon.

    End Sub

    'Active vacation
    Public Sub ToggleVacationResponder(ByVal isOn As Boolean)
        _settings.IsActive = isOn
        Dim status As String = If(_settings.IsActive, "aktivní", "vypnuté")
        MessageBox.Show($"Automatické odpovědi jsou nyní {status}.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class
