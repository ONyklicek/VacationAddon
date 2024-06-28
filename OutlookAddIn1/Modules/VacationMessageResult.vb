Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Reflection

Module VacationMessageResult
    Public Function replaceKeyTags(ByVal message As String) As String
        Dim resultMessage As String = message

        Dim keyTags As New Dictionary(Of String, String) From {
            {"@startDate", "GetStartDateShortDateString"},
            {"@endDate", "GetEndDateShortDateString"}
        }

        For Each kvp As KeyValuePair(Of String, String) In keyTags
            ' Získání hodnoty z ThisAddIn dynamicky
            Dim value As String = GetSettingsValue(Globals.ThisAddIn, kvp.Value)
            resultMessage = resultMessage.Replace(kvp.Key, value)
        Next

        Return resultMessage
    End Function

    Private Function LoadReplacements(ByVal filePath As String) As Dictionary(Of String, String)
        Dim json As String = File.ReadAllText(filePath)
        Dim serializer As New JavaScriptSerializer()
        Return serializer.Deserialize(Of Dictionary(Of String, String))(json)
    End Function

    Private Function GetSettingsValue(settingsManager As Object, methodName As String) As String
        Dim method As MethodInfo = settingsManager.GetType().GetMethod(methodName)
        If method IsNot Nothing Then
            Dim result As Object = method.Invoke(settingsManager, Nothing)
            Return result.ToString()
        Else
            Throw New Exception("Method not found")
        End If
    End Function
End Module
