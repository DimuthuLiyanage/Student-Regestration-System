Public Class PrintAdmmition
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles printSingleAdmition.CheckedChanged
        If printSingleAdmition.Checked Then
            lblEnter.Show()
            TextStudentNumber.Show()
        Else
            lblEnter.Hide()
            TextStudentNumber.Hide()

        End If
    End Sub
End Class