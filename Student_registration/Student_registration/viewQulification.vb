Public Class viewQulification
    Private Sub RadioHNDA_CheckedChanged(sender As Object, e As EventArgs) Handles RadioHNDA.CheckedChanged
        If RadioHNDA.Checked Then
            sub1.Text = "Accountancy"
            sub2.Text = "Economics"
            sub3.Text = "Bussiness Studies"
            Commerce.Text = "Commerce"
            Combocommerce.Show()
            Zscorce.Show()
            TextZscorce.Show()
        Else
            sub1.Text = "Subject 01"
            sub2.Text = "Subject 02"
            sub3.Text = "Subject 03"
            Commerce.Text = ""
            Combocommerce.Hide()
            Zscorce.Hide()
            TextZscorce.Hide()
        End If
    End Sub
End Class