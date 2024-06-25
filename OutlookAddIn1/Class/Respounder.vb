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
        Dim currentDate As Date = Date.Now
        Return _settings.IsActive AndAlso
               currentDate >= _settings.VacationStartDate AndAlso
               currentDate <= _settings.VacationEndDate
    End Function

    Private Sub SendVacationReply(mail As MailItem)
        Dim reply As MailItem = mail.Reply()
        reply.Body = _settings.VacationMessage
        reply.Send()
    End Sub

End Class
