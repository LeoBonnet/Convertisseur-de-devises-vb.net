Public Class Convertisseur_de_distances

    Private Sub Convertisseur_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Fenetre_mot_de_passe.Close()
    End Sub

    Private Sub Convertisseur_de_distances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Menu_.Hide()
        ComboBox1.SelectedIndex = 0
        TextBox1.Text = "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim entre, resultat As Double
        Dim unite As String
        entre = CDbl(Me.TextBox1.Text)
        Select Case Me.ComboBox1.SelectedIndex
            Case 0
                resultat = entre / 0.62137
                unite = " km"
            Case 1
                resultat = entre * 0.62137
                unite = " milles"
        End Select
        Label2.Text = resultat & unite
        Label2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_.Show()
        Me.Hide()
    End Sub

    Private Sub Convertisseur_de_distances_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Menu_.Hide()
    End Sub
End Class