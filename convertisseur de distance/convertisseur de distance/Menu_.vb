Public Class Menu_

    Private Sub Menu__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Timer1.Enabled = False
        Fenetre_mot_de_passe.Close()
    End Sub

    Private Sub Menu__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim random As New Random(), nmbrRnd As Integer
        nmbrRnd = random.Next(0, 10)
        Select Case nmbrRnd
            Case 0
                RichTextBox1.ForeColor = Color.Black
            Case 1
                RichTextBox1.ForeColor = Color.Blue
            Case 2
                RichTextBox1.ForeColor = Color.Green
            Case 3
                RichTextBox1.ForeColor = Color.Red
            Case 4
                RichTextBox1.ForeColor = Color.Yellow
            Case 5
                RichTextBox1.ForeColor = Color.Gray
            Case 6
                RichTextBox1.ForeColor = Color.Brown
            Case 7
                RichTextBox1.ForeColor = Color.Cyan
            Case 8
                RichTextBox1.ForeColor = Color.Magenta
            Case 9
                RichTextBox1.ForeColor = Color.Gold
            Case 10
                RichTextBox1.ForeColor = Color.Orange
            Case Else
                Me.Close()
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Convertisseur_de_devises.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Convertisseur_de_distances.Show()
    End Sub
End Class