
Imports System
Imports System.Data.OleDb
Imports IO
Public Class Form5
    Private strconnexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\moham\Desktop\Base_Patient.mdb"
    Private oConnection As New OleDbConnection(strconnexion)


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Now.Date
        TextBox1.Text = DateTimePicker1.Value.ToShortDateString
        TextBox1.Visible = False

        Dim Requette As String = " SELECT Consultation.[Code_Consultation], Consultation.[Type d'analyse], Consultation.ID_Patient, Consultation.Datecon, Consultation.heure FROM Consultation WHERE (((Consultation.Datecon)='" & TextBox1.Text & "'))"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rep = MsgBox("Vous voulez vraiment quitte ", vbYesNo + vbInformation, "Confiramation")
        If rep = vbYes Then
            Application.Exit()
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Requette1 As String = " SELECT Consultation.[Code_Consultation], Consultation.[Type d'analyse], Consultation.ID_Patient, Consultation.Datecon, Consultation.heure FROM Consultation WHERE (((Consultation.Datecon)='" & TextBox1.Text & "'))"
        TextBox1.Text = DateTimePicker1.Value.ToShortDateString
        Try
            oConnection.Open()

            Dim Commande As New OleDbCommand(Requette1, oConnection)
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
End Class
