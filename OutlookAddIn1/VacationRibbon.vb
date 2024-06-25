Imports Microsoft.Office.Tools.Ribbon

Public Class VacationRibbon

    Private Sub VacationRibbon_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToggleButton1_Click(sender As Object, e As RibbonControlEventArgs) Handles btnToggle.Click
        Dim isOn As Boolean = btnToggle.Checked

    End Sub
End Class
