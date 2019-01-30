Public Class Form1


    'Mario déclaré en global

    Dim MonMario As Mario


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Se met en écoute des touches

        Me.KeyPreview = True

        'Un nouveau Mario

        MonMario = New Mario(Me.PAN_MARIO.Location, Me.PAN_MARIO.Size)

    End Sub

    Private Function PAN_MARIO() As Object
        Throw New NotImplementedException()
    End Function

    Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Z

                MonMario.Monte()

            Case Keys.S

                MonMario.Descend()

            Case Keys.Q

                MonMario.Recule()

            Case Keys.D

                MonMario.Avance()

        End Select

        Me.PAN_MARIO.Location = MonMario.Position

    End Sub



#Region "Boutons de l'interface"


    Private Sub BT_AVANCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_AVANCE.Click

        'On le fait avancer

        MonMario.Avance()

        'On recupère la nouvelle position

        Me.PAN_MARIO.Location = MonMario.Position

    End Sub


    Private Sub BT_RECULE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_RECULE.Click

        'On le fait reculer

        MonMario.Recule()

        'On recupère la nouvelle position

        Me.PAN_MARIO.Location = MonMario.Position

    End Sub


    Private Sub BT_DESCEND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_DESCEND.Click

        'On le fait descendre

        MonMario.Descend()

        'On recupère la nouvelle position

        Me.PAN_MARIO.Location = MonMario.Position

    End Sub


    Private Sub BT_MONTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MONTE.Click

        'On le fait monter

        MonMario.Monte()

        'On recupère la nouvelle position

        Me.PAN_MARIO.Location = MonMario.Position

    End Sub


#End Region


End Class