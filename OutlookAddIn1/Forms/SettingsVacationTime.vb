Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SettingsVacationTime
    Public Property StartDate As Date
    Public Property EndDate As Date

    Private Sub SettingsVacationTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Globals.ThisAddIn.GetStartDate <> Date.MinValue Or Not Globals.ThisAddIn.GetStartDate < Date.Today Then
            DateTimePickerStart.Value = Globals.ThisAddIn.GetStartDate
        Else
            DateTimePickerStart.Value = Date.Today
        End If

        If Globals.ThisAddIn.GetEndDate <> Date.MinValue Or Not Globals.ThisAddIn.GetEndDate < Date.Today Then
            DateTimePickerEnd.Value = Globals.ThisAddIn.GetEndDate
        Else
            DateTimePickerEnd.Value = Date.Today.AddDays(7)
        End If

        VacationPlanCheck.Checked = Globals.ThisAddIn.GetisVacationPlanActive

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveData()
        Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerStart.ValueChanged
        If DateTimePickerStart.Value < Date.Today Then
            MessageBox.Show($"Nelze nastavit datum v minulosti. od", "Naplatné datum", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePickerStart.Value = Date.Today
        Else
            StartDate = DateTimePickerStart.Value
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerEnd.ValueChanged
        If DateTimePickerEnd.Value < Date.Today Then
            MessageBox.Show($"Nelze nastavit datum v minulosti. do", "Naplatné datum", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePickerEnd.Value = Date.Today.AddDays(7)
        ElseIf DateTimePickerEnd.Value < DateTimePickerStart.Value Then
            MessageBox.Show($"Nelze nastavit datum před začátkem dovolené.", "Naplatné datum", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            EndDate = DateTimePickerEnd.Value
        End If
    End Sub

    Private Sub SaveData()
        Globals.ThisAddIn.TimeVacationResponder(StartDate, EndDate)
    End Sub

    Private Sub VacationPlanCheck_CheckedChanged(sender As Object, e As EventArgs) Handles VacationPlanCheck.CheckedChanged
        Globals.ThisAddIn.ToogleVacationPlanResonder(VacationPlanCheck.Checked)
    End Sub
End Class