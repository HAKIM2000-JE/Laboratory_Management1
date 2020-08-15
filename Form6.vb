Imports System
Imports System.Data.OleDb
Imports IO
Public Class Form6
    Private strconnexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\moham\Desktop\Base_Patient.mdb"
    Private oConnection As New OleDbConnection(strconnexion)
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Visible = False
        DateTimePicker1.Value = Now.Date
        TextBox1.Visible = False


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rep = MsgBox("Vous voulez vraiment quitte ", vbYesNo + vbInformation, "Confiramation")
        If rep = vbYes Then
            Application.Exit()
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectedRow As DataGridViewRow
        SelectedRow = DataGridView1.Rows(index)
        txt_Nom.Text = SelectedRow.Cells(1).Value.ToString
        txt_ID.Text = SelectedRow.Cells(0).Value.ToString
        txt_Prénom.Text = SelectedRow.Cells(2).Value.ToString
        txt_Analyse.Text = SelectedRow.Cells(3).Value.ToString
        txt_consult.Text = SelectedRow.Cells(6).Value.ToString
        TextBox3.Text = SelectedRow.Cells(5).Value.ToString




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form7.Show()
        Me.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = DateTimePicker1.Value.ToShortDateString
        Dim Requette As String = "SELECT Consultation.ID_Patient, Patient.Nom, Patient.Prénom, Consultation.[Type d'analyse], Consultation.Datecon, Consultation.heure, Consultation.[Code_Consultation] 
FROM Consultation INNER JOIN Patient ON Consultation.ID_Patient = Patient.ID_Patient WHERE (((Consultation.Datecon)='" & TextBox1.Text & "'));"

        MsgBox(Requette)
        Try
            oConnection.Open()

            Dim Commande As New OleDbCommand(Requette, oConnection)
            Dim Adaptateur As New OleDbDataAdapter(Commande)
            Dim MonDataSet As New DataSet
            Adaptateur.Fill(MonDataSet, "Consultation")
            DataGridView1.DataSource = MonDataSet
            DataGridView1.DataMember = "Consultation"
            oConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txt_consult_TextChanged(sender As Object, e As EventArgs) Handles txt_consult.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class