Imports System

Public Class ResponderSettings

    Public Property IsActive As Boolean
        Get
            Return My.Settings.isActive
        End Get

        Set(value As Boolean)
            My.Settings.isActive = value
            My.Settings.Save()
        End Set
    End Property

    Public Property VacationMessage As String
        Get
            Return My.Settings.VacationMessage
        End Get
        Set(value As String)
            My.Settings.VacationMessage = value
            My.Settings.Save()
        End Set
    End Property

    Public Property VacationStartDate As Date
        Get
            Return My.Settings.VacationStartDate
        End Get
        Set(value As Date)
            My.Settings.VacationStartDate = value
            My.Settings.Save()
        End Set
    End Property

    Public Property VacationEndDate As Date
        Get
            Return My.Settings.VacationEndDate
        End Get
        Set(value As Date)
            My.Settings.VacationEndDate = value
            My.Settings.Save()
        End Set
    End Property

End Class
