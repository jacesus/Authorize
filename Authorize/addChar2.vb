Public Class addChar2
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gender.SelectedIndexChanged
        If gender.SelectedItem() = "Non-Binary" Then
            nbGender.Enabled = True
        Else
            nbGender.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addRace.Show()
    End Sub

    Private Sub race_SelectedIndexChanged(sender As Object, e As EventArgs) Handles race.SelectedIndexChanged

    End Sub
End Class