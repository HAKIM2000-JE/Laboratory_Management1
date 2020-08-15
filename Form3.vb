Imports System.Data.OleDb
Imports System.Diagnostics
Imports Io




Public Class Form3
    Dim imageName As String
    Dim daImage As OleDbDataAdapter
    Dim dsImage As DataSet

    Private strconnexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\moham\Desktop\Base_Patient.mdb"
    Private oConnection As New OleDbConnection(strconnexion)
    Private Sub image()
        Process.Start("explorer.exe", "‪C:\Users\moham\Desktop\Gestion_Laboratoir\img")
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Dim rdm As New Random()
            Dim ID As Integer = rdm.Next(0, 1000000)





            Dim Requette As String = "Insert into Patient values  ('" & ID & "', '" & txt_nom.Text & "', '" & txt_prenom.Text & "', '" & txt_CIN.Text & "', '" & DateTimePicker1.Value.ToShortDateString & "' , '" & cb_Sexe.SelectedItem & "' ,'" & DateTimePicker2.Value.ToShortDateString & "' , '" & txt_Telephone.Text & "','" & txt_Adresse.Text & "','" & TextBox1.Text & "')"
            oConnection.Open()
            Dim oCommand As New OleDbCommand(Requette, oConnection)
            MsgBox(Requette)
            oCommand.ExecuteNonQuery()

            oConnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim rep = MsgBox("Vous voulez vraiment quitte ", vbYesNo + vbInformation, "Confiramation")
        If rep = vbYes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DataGridView1.Visible = False
        Try
            oConnection.Open()
            Dim Requete As String = "SELECT * from Patient"
            Dim Commande As New OleDbCommand(Requete, oConnection)
            Dim Adaptateur As New OleDbDataAdapter(Commande)
            Dim MonDataSet As New DataSet
            Adaptateur.Fill(MonDataSet, "Patient")
            DataGridView2.DataSource = MonDataSet
            DataGridView2.DataMember = "Patient"
            oConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txt_nom.Text = " "
        txt_prenom.Text = " "
        TextBox1.Text = " "
        PictureBox2.Image = Nothing


        txt_CIN.Text = " "
        txt_Telephone.Text = " "
        txt_Adresse.Text = " "
        cb_Sexe.SelectedIndex = -1

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form10.Show()
        Me.Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("https://www.facebook.com/")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Process.Start("https://www.instagram.com/accounts/login/")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Process.Start("https://twitter.com/explore")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            Dim dlImage As FileDialog = New OpenFileDialog()

            dlImage.Filter = "Image file (* .jpg ;* .bmp ;*.gif) | * .jpg;*.bmp ;*.gif"

            If dlImage.ShowDialog() = DialogResult.OK Then
                imageName = dlImage.FileName
                Dim newimg As New Bitmap(imageName)
                PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox2.Image = DirectCast(newimg, Image)
                Me.PictureBox2.Tag = dlImage.FileName

            End If

            dlImage = Nothing
            TextBox1.Text = Me.PictureBox2.Tag.ToString

        Catch ae As System.ArgumentException
            imageName = " "
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub
End Class