Public Class Fenetre_mot_de_passe
    Dim nmbr As Integer 'nombre de fois où l'on appui sur entrer
    Dim troll As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nmbr += 1
        If nmbr < 15 Then
            If Me.TextBox1.Text = "Linux1234" Then
                Menu_.Show()
                Me.Hide()
            Else
                Me.Label1.Visible = True
            End If
        Else
            troll = True
        End If
        
    End Sub

    Private Sub Fenetre_mot_de_passe_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.TextBox1.Text = ""
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        If troll = True Then
            Dim random As New Random(), hauteur, largeur As Integer
            hauteur = random.Next(0, Me.Size.Height)
            random = New Random()
            largeur = random.Next(0, Me.Size.Width)
            Me.Button1.Location = New System.Drawing.Point(largeur, hauteur)
        End If
    End Sub
End Class
