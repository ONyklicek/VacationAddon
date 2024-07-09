Imports System
Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Tools.Ribbon
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Core
Imports System.Diagnostics

Public Class ThisAddIn
    Dim outlookNameSpace As Outlook.NameSpace
    Dim inbox As Outlook.MAPIFolder
    Dim accounts As Outlook.Accounts
    Dim defaultAccount As Outlook.Account
    Dim WithEvents items As Outlook.Items

    Private _settings As ResponderSettings
    Private _responder As ResponderMail

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        'Boot
        _settings = New ResponderSettings
        _responder = New ResponderMail(_settings)


        outlookNameSpace = Me.Application.GetNamespace("MAPI")
        defaultAccount = outlookNameSpace.Accounts.Item(1)
        accounts = outlookNameSpace.Accounts
        inbox = defaultAccount.DeliveryStore.GetDefaultFolder(OlDefaultFolders.olFolderInbox)
        'inbox = outlookNameSpace.Folders(defaultAccount.DeliveryStore.DisplayName).Folders(olFolderInbox)
        'inbox = outlookNameSpace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox)
        items = inbox.Items

        If GetIsActive() Then
            MessageBox.Show($"Režim dovolené je aktivní.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Items_ItemAdd(ByVal item As Object) Handles items.ItemAdd
        If TypeOf (item) Is Outlook.MailItem Then
            Dim mail As Outlook.MailItem = item

            _responder.ProcessNewMail(mail)
        End If
    End Sub

    'Active vacation
    Public Sub ToggleVacationResponder(ByVal isOn As Boolean)
        _settings.IsActive = isOn
        Message.HasActive(_settings.IsActive)
    End Sub

    Public Sub ToggleVacationPlanResonder(ByVal isOnPlan As Boolean)
        _settings.isVacationPlanActive = isOnPlan
        'Message.HasActiveByPlan(_settings.isVacationPlanActive)
    End Sub

    Public Sub TimeVacationResponder(ByVal startDate As Date, ByVal endDate As Date)
        _settings.VacationStartDate = startDate
        _settings.VacationEndDate = endDate
        'Message.HasSetDate(startDate, endDate)
    End Sub

    Public Sub MessageVacationResponder(ByVal message As String)
        _settings.VacationMessage = message
        HasSetMessage()
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown
        '
    End Sub

    Public Function GetIsActive() As Boolean
        Return _settings.IsActive
    End Function

    Public Function GetIsVacationPlanActive() As Boolean
        Return _settings.isVacationPlanActive
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
        Return _settings.VacationMessage
    End Function

    Public Function GetMessageReplaceKeyTags() As String
        Return replaceKeyTags(_settings.VacationMessage)
    End Function
End Class
