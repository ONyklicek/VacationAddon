Imports System
Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Tools.Ribbon
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Core

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

    End Sub

    'Active vacation
    Public Sub ToggleVacationResponder(ByVal isOn As Boolean)
        _settings.IsActive = isOn
        Dim status As String = If(_settings.IsActive, "aktivní", "vypnuté")
        MessageBox.Show($"Automatické odpovědi jsou nyní {status}.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub TimeVacationResponder(ByVal startDate As Date, ByVal endDate As Date)
        _settings.VacationStartDate = startDate
        _settings.VacationEndDate = endDate

        MessageBox.Show($"Automatické odpovědi budou odesílány dle rozvrhu. {vbCrLf}Od {startDate.ToShortDateString} do {endDate.ToShortDateString}.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub MessageVacationResponder(ByVal message As String)
        _settings.VacationMessage = message
        MessageBox.Show(GetMessage)
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown
        '
    End Sub

    Public Function GetIsActive() As Boolean
        Return _settings.IsActive
    End Function

    Public Function GetStartDate() As Date
        Return _settings.VacationStartDate
    End Function

    Public Function GetEndDate() As Date
        Return _settings.VacationEndDate
    End Function

    Public Function GetStartDateShortDateString() As String
        Return _settings.VacationStartDate.ToShortDateString
    End Function

    Public Function GetEndDateShortDateString() As String
        Return _settings.VacationEndDate.ToShortDateString
    End Function

    Public Function GetMessage() As String
        Return replaceKeyTags(_settings.VacationMessage)
    End Function
End Class
