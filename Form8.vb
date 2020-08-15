Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Age.Text = Form7.txt_Age.Text
        txt_Analyse.Text = Form7.txt_Analyse.Text
        txt_Poids.Text = Form7.txt_Poids.Text
        txt_Taille.Text = Form7.txt_Taille.Text
        txt_Température.Text = Form7.txt_Température.Text
        txt_Tension.Text = Form7.txt_Tension.Text
        txt_Maladie.Text = Form7.txt_Maladie.Text
        labelM.Text = Form7.txt_Montant.Text
        If Form7.RadioButton1.Checked = True Then
            labelp.Text = "payé"
        Else
            labelp.Text = " Non payé"
        End If
        TextBox1.Text = Form6.TextBox2.Text
        Label13.Visible = False
        TextBox1.Text = Form6.TextBox2.Text
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Form9.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rep = MsgBox("Vous voulez vraiment quitte ", vbYesNo + vbInformation, "Confiramation")
        If rep = vbYes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form11.Show()


    End Sub
End Class