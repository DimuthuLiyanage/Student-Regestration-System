Public Class addQlification
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub RadioHNDA_CheckedChanged(sender As Object, e As EventArgs) Handles RadioHNDA.CheckedChanged
        If RadioFullTime.Checked And RadioHNDA.Checked Then


            sub1.Text = "Accountancy"
            sub2.Text = "Economics"
            sub3.Text = "Bussiness Studies"
            Commerce.Text = "Commerce"
            CombCommerce.Show()
            Zscroce.Show()
            TextZscroce.Show()


        Else
            sub1.Text = "Subject 01"
            sub2.Text = "Subject 02"
            sub3.Text = "Subject 03"
            Commerce.Text = ""
            CombCommerce.Hide()
            Zscroce.Hide()
            TextZscroce.Hide()
        End If

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioFullTime_CheckedChanged(sender As Object, e As EventArgs) Handles RadioFullTime.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Submit.Click

    End Sub

    Private Sub GrpCourse_Enter(sender As Object, e As EventArgs) Handles GrpCourse.Enter

    End Sub
End Class