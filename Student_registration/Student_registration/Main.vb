Public Class Main
    Public Property FrmLogUserName As Object

    Private Sub ApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginAsAdmin.Click
        FrmAdminLogin.Show()
    End Sub

    Private Sub ApplcationPrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplcationPrintToolStripMenuItem.Click
        Application.Show()
    End Sub

    Private Sub LblTime_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserChange.Click

    End Sub

    Private Function View() As ToolStripMenuItem
        Throw New NotImplementedException()
    End Function

    Private Sub AddQulificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddQulificationToolStripMenuItem.Click
        addQlification.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ViewQulificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewQulificationToolStripMenuItem.Click
        viewQulification.Show()
    End Sub

    Private Sub PrintAdmitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintAdmitionToolStripMenuItem.Click
        PrintAdmmition.Show()
    End Sub

    Private Sub EnterExamResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterExamResultsToolStripMenuItem.Click
        EnterExamResults.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub ViewResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewResultsToolStripMenuItem.Click
        viewResults.Show()
    End Sub

    Private Sub PrintInterviewLatterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintInterviewLatterToolStripMenuItem.Click
        InterviewLatter.Show()
    End Sub
End Class