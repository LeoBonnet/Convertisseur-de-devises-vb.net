Public Class Fenetre_mot_de_passe

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBox1.Text = "Linux1234" Then
            Menu_.Show()
            Me.Hide()
        Else
            Me.Label1.Visible = True
        End If
    End Sub

    Private Sub Fenetre_mot_de_passe_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.TextBox1.Text = ""
    End Sub
End Class
