﻿Imports Microsoft.Office.Tools.Ribbon

Public Class VacationRibbon
    Private Sub VacationRibbon_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load
        CheckBox1.Checked = Globals.ThisAddIn.GetIsActive
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As RibbonControlEventArgs) Handles CheckBox1.Click
        Dim isOn As Boolean = CheckBox1.Checked
        Globals.ThisAddIn.ToggleVacationResponder(isOn)
    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles btnOenSettingsVacationTime.Click
        Dim SettingsVacationTimeBox As New SettingsVacationTime
        SettingsVacationTimeBox.ShowDialog()
    End Sub

    Private Sub btnSettingsReply_Click(sender As Object, e As RibbonControlEventArgs) Handles btnSettingsReply.Click
        Dim SettingsVacationMessageBox As New SettingVacationMessage
        SettingsVacationMessageBox.ShowDialog()
    End Sub
End Class
