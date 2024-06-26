Public Class SettingVacationMessage
    Private message As String

    Private Sub SettingVacationMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = Globals.ThisAddIn.GetMessage
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        message = RichTextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Globals.ThisAddIn.MessageVacationResponder(message)
    End Sub


End Class