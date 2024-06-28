Imports Microsoft.Office.Interop.Outlook

Public Class Respounder
    Private _settings As ResponderSettings

    Public Sub New(settings As ResponderSettings)
        _settings = settings
    End Sub
    Public Sub ProcessNewMail(mail As MailItem)
        If ShouldSendVacationReply(mail) Then
            SendVacationReply(mail)
        End If
    End Sub

    Private Function ShouldSendVacationReply(mail As MailItem) As Boolean
        Dim currentDate As Date = Date.Today
        Return _settings.IsActive Or _settings.isVacationPlanActive AndAlso
            currentDate >= _settings.VacationStartDate.Date AndAlso
            currentDate <= _settings.VacationEndDate.Date
    End Function

    Private Sub SendVacationReply(mail As MailItem)
        Dim reply As MailItem = mail.Reply()
        reply.Body = replaceKeyTags(_settings.VacationMessage)
        reply.Send()
    End Sub
End Class
