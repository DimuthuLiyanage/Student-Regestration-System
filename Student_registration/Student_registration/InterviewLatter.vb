Public Class InterviewLatter
    Private Sub RadioSingleLatter_CheckedChanged(sender As Object, e As EventArgs) Handles RadioSingleLatter.CheckedChanged
        If RadioSingleLatter.Checked Then
            GroupStudent.Show()
        Else
            GroupStudent.Hide()
        End If
    End Sub
End Class