
Public Class Form1
        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            If txt_Nom.Text = "Admin" And txt_pswrd.Text = "App123" Then
                Form2.Show()
                Me.Visible = False
            Else
                MsgBox("le Nom d'utilisateur ou le Mot de passe sont incorrecte ", MsgBoxStyle.Critical)
            End If

        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim rep = MsgBox("Vous voulez vraiment quitte ", vbYesNo + vbInformation, "Confiramation")
            If rep = vbYes Then
                Application.Exit()
            End If

        End Sub
    End Class
