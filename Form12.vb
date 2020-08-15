Imports System
Imports System.Data.OleDb
Imports IO


Public Class Form12
    Private strConnexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\moham\Desktop\Base_Patient.mdb"
    Private oConnection As New OleDbConnection(strConnexion)
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            oConnection.Open()
            Dim Requete As String = "SELECT * from Reglement"
            Dim Commande As New OleDbCommand(Requete, oConnection)
            Dim Adaptateur As New OleDbDataAdapter(Commande)
            Dim MonDataSet As New DataSet
            Adaptateur.Fill(MonDataSet, "Patient")
            DataGridView1.DataSource = MonDataSet
            DataGridView1.DataMember = "Patient"
            oConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rep = MsgBox("Vous voulez vraiment quitte ", vbYesNo + vbInformation, "Confiramation")
        If rep = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form10.Show()
        Me.Close()
    End Sub
End Class