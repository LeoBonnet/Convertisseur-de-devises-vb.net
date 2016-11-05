Public Class Convertisseur_de_devises
    Dim monnaieDepart, monnaieArrive As Integer

    Function conversion(ByVal valeurMonnaie As Double, ByVal paramConversion As Integer, ByVal paramConversion2 As Integer) As Double
        Dim valeurFinale As Double = 0
        Const TAUX12 As Double = 1.1087
        Const TAUX21 As Double = 0.9019
        Const TAUX13 As Double = 0.9016
        Const TAUX31 As Double = 1.109
        Const TAUX23 As Double = 0.8133
        Const TAUX32 As Double = 1.2296

        Select Case paramConversion
            Case 1 'Euros
                Select Case paramConversion2
                    Case 1 'Euros
                        valeurFinale = valeurMonnaie
                    Case 2 'Dollars
                        valeurFinale = valeurMonnaie / TAUX21
                    Case 3 'Livres
                        valeurFinale = valeurMonnaie / TAUX31
                End Select
            Case 2 'Dollars
                Select Case paramConversion2
                    Case 1 'Euros
                        valeurFinale = valeurMonnaie / TAUX12
                    Case 2 'Dollars
                        valeurFinale = valeurMonnaie
                    Case 3 'Livres
                        valeurFinale = valeurMonnaie / TAUX32
                End Select
            Case 3 'Livres
                Select Case paramConversion2
                    Case 1 'Euros
                        valeurFinale = valeurMonnaie / TAUX13
                    Case 2 'Dollars
                        valeurFinale = valeurMonnaie / TAUX23
                    Case 3 'Livres
                        valeurFinale = valeurMonnaie
                End Select
        End Select
        Return valeurFinale
    End Function



    Private Sub BT_CALC_Click(sender As Object, e As EventArgs) Handles BT_CALC.Click
        Select Case Me.CB_DEPART.SelectedIndex
            Case 0
                monnaieDepart = 1
                'Me.TB_DEPART.Text = monnaieDepart
                'Me.TB_DEPART.Text = Me.CB_DEPART.SelectedIndex
            Case 1
                monnaieDepart = 2
                'Me.TB_DEPART.Text = monnaieDepart
                'Me.TB_DEPART.Text = Me.CB_DEPART.SelectedIndex
            Case 2
                monnaieDepart = 3
                'Me.TB_DEPART.Text = monnaieDepart
                'Me.TB_DEPART.Text = Me.CB_DEPART.SelectedIndex
        End Select

        Select Case Me.CB_ARRIVE.SelectedIndex
            Case 0
                monnaieArrive = 1
            Case 1
                monnaieArrive = 2
            Case 2
                monnaieArrive = 3
        End Select

        Dim valeurConvertie As Double
        valeurConvertie = conversion(CDbl(Me.TB_DEPART.Text), monnaieDepart, monnaieArrive)
        Me.TB_ARRIVE.Text = valeurConvertie
    End Sub

    Private Sub Convertisseur_de_devises_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Fenetre_mot_de_passe.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CB_DEPART.SelectedIndex = 0
        Me.CB_ARRIVE.SelectedIndex = 0
        Me.TB_DEPART.Text = 0
        Menu_.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menu_.Show()
        Me.Hide()
    End Sub

    Private Sub Convertisseur_de_devises_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Menu_.Hide()
    End Sub
End Class