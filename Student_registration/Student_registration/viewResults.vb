Public Class viewResults
    Private Sub RadioHNDA_CheckedChanged(sender As Object, e As EventArgs) Handles RadioHNDA.CheckedChanged
    End Sub

    Private Sub BtnViewExamResults_Click(sender As Object, e As EventArgs) Handles BtnViewExamResults.Click

    End Sub

    Private Sub RadioPass_CheckedChanged(sender As Object, e As EventArgs) Handles RadioSingle.CheckedChanged
        If RadioSingle.Checked Then
            GroupStudent.Show()
        Else
            GroupStudent.Hide()
        End If
    End Sub
End Class