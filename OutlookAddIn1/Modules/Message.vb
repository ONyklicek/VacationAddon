Imports System.Windows.Forms

Module Message
    Public Sub HasActive(status As Boolean)
        Dim StatusInfo As String = If(status, "aktivní", "neaktivní")
        MessageBox.Show($"Režim dovolené je nyní {StatusInfo}.",
                        "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub HasActiveByPlan(status As Boolean)
        Dim StatusInfo As String = If(status, "aktivní", "neaktivní")
        MessageBox.Show($"Režim dovolené dle plánu je nyní {StatusInfo}.",
                        "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub HasSetDate(ByVal startDate As Date, ByVal endDate As Date)
        MessageBox.Show($"Automatické odpovědi jsou nyní aktivní budou odesílány v období od {startDate.ToShortDateString} do {endDate.ToShortDateString}.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub HasSetMessage()
        MessageBox.Show(replaceKeyTags(My.Settings.VacationMessage), "Zpráva automatické odpovědi", MessageBoxButtons.OK)

    End Sub
End Module
