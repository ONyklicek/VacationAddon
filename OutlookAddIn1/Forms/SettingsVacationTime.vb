Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SettingsVacationTime
    Private Property startDate As Date
    Private Property endDate As Date
    Private Property isOnVacationPlan As Boolean



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
        If Not SaveData() Then
            Exit Sub
        End If

        Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerStart.ValueChanged
        startDate = DateTimePickerStart.Value
    End Sub

    Private Sub DateTimePickerEnd_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerEnd.ValueChanged
        endDate = DateTimePickerEnd.Value
    End Sub

    Private Function SaveData() As Boolean

        'Validate data
        If Not Validate() Then
            Return False
        End If

        Globals.ThisAddIn.ToggleVacationPlanResonder(True)
        Globals.ThisAddIn.TimeVacationResponder(startDate, endDate)
        Globals.ThisAddIn.ToggleVacationPlanResonder(VacationPlanCheck.Checked)

        Return True

    End Function

    Private Sub VacationPlanCheck_CheckedChanged(sender As Object, e As EventArgs) Handles VacationPlanCheck.CheckedChanged
        isOnVacationPlan = VacationPlanCheck.Checked
    End Sub

    Private Overloads Function Validate() As Boolean
        'Validate start date
        If startDate < Date.MinValue Or
            startDate < Date.Today Then
            MessageBox.Show($"Nelze nastavit datum začátku v minulosti.", "Naplatné datum", MessageBoxButtons.OK, MessageBoxIcon.Error)

            DateTimePickerStart.Value = Date.Today
            Return False

        End If

        'Validate end date
        If endDate < Date.Today Then
            MessageBox.Show($"Nelze nastavit datum v minulosti. do", "Naplatné datum", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePickerEnd.Value = Date.Today.AddDays(7)
        ElseIf DateTimePickerEnd.Value < DateTimePickerStart.Value Then
            MessageBox.Show($"Nelze nastavit datum před začátkem dovolené.", "Naplatné datum", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePickerEnd.Value = Date.Today.AddDays(7)

            Return False
        End If

        Return True
    End Function
End Class