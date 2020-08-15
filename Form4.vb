Imports System
Imports System.Data.OleDb
Imports IO





Public Class Form4
    Private strconnexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\moham\Desktop\Base_Patient.mdb"
    Private oConnection As New OleDbConnection(strconnexion)
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If Radio_Nom.Checked = True Then
            Dim req_ID As String = "select ID_Patient , Nom , Prénom from Patient where Nom ='" & txt_Rechere.Text & "'"
            Try

                oConnection.Open()

                Dim Commande As New OleDbCommand(req_ID, oConnection)
                Dim Adaptateur As New OleDbDataAdapter(Commande)
                Dim MonDataSet As New DataSet
                Adaptateur.Fill(MonDataSet, "Patient")
                DataGridView1.DataSource = MonDataSet
                DataGridView1.DataMember = "Patient"
                oConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
        If Radio_CIN.Checked = True Then
            Dim req_ID As String = "select ID_Patient , Nom , Prénom from Patient where CIN ='" & txt_Rechere.Text & "'"
            Try

                oConnection.Open()

                Dim Commande As New OleDbCommand(req_ID, oConnection)
                Dim Adaptateur As New OleDbDataAdapter(Commande)
                Dim MonDataSet As New DataSet
                Adaptateur.Fill(MonDataSet, "Patient")
                DataGridView1.DataSource = MonDataSet
                DataGridView1.DataMember = "Patient"
                oConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
        If Radio_ID.Checked = True Then
            Dim ID As Double
            ID = CDbl(txt_Rechere.Text)
            Dim req_ID As String = "select ID_Patient , Nom , Prénom from Patient where ID_Patient = " & ID & " "
            Try

                oConnection.Open()

                Dim Commande As New OleDbCommand(req_ID, oConnection)
                Dim Adaptateur As New OleDbDataAdapter(Commande)
                Dim MonDataSet As New DataSet
                Adaptateur.Fill(MonDataSet, "Patient")
                DataGridView1.DataSource = MonDataSet
                DataGridView1.DataMember = "Patient"
                oConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Radio_Nom.Checked = True Then
            Dim req_ID As String = "SELECT Consultation.[Code_Consultation], Consultation.[Type d'analyse], Consultation.ID_Patient, Consultation.[Datecon]
                                    FROM Consultation INNER JOIN Patient ON Consultation.ID_Patient = Patient.ID_Patient WHERE Patient.Nom='" & txt_Rechere.Text & "'"

            Try

                oConnection.Open()

                Dim Commande As New OleDbCommand(req_ID, oConnection)
                Dim Adaptateur As New OleDbDataAdapter(Commande)
                Dim MonDataSet As New DataSet
                Adaptateur.Fill(MonDataSet, "Patient")
                DataGridView2.DataSource = MonDataSet
                DataGridView2.DataMember = "Patient"
                oConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
        If Radio_CIN.Checked = True Then
            Dim req_ID As String = "SELECT Consultation.[Code _Consultaion], Consultation.[Type d'analyse], Consultation.ID_Patient, Consultation.[Datecon]
                                    FROM Consultation INNER JOIN Patient ON Consultation.ID_Patient = Patient.ID_Patient WHERE Patient.CIN='" & txt_Rechere.Text & "'"
            Try

                oConnection.Open()

                Dim Commande As New OleDbCommand(req_ID, oConnection)
                Dim Adaptateur As New OleDbDataAdapter(Commande)
                Dim MonDataSet As New DataSet
                Adaptateur.Fill(MonDataSet, "Consultation")
                DataGridView2.DataSource = MonDataSet
                DataGridView2.DataMember = "Consultation"
                oConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
        If Radio_ID.Checked = True Then
            Dim ID As Double
            ID = CDbl(txt_Rechere.Text)
            Dim req_ID As String = "select * from  Consultation where ID_Patient = " & ID & " "
            Try

                oConnection.Open()

                Dim Commande As New OleDbCommand(req_ID, oConnection)
                Dim Adaptateur As New OleDbDataAdapter(Commande)
                Dim MonDataSet As New DataSet
                Adaptateur.Fill(MonDataSet, "Consultation")
                DataGridView2.DataSource = MonDataSet
                DataGridView2.DataMember = "Consultation"
                oConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim C, P As Double
        Dim D As Date
        D = DateTimePicker1.Value
        C = CDbl(txt_Consultation.Text)
        P = CDbl(txt_ID.Text)
        Dim Reqt As String = "insert into Consultation values(" & C & ", '" & cb_Analyse.SelectedItem.ToString & "' , '" & P & "' , '" & DateTimePicker1.Value.ToShortDateString & "', '" & DateTimePicker2.Value.ToShortTimeString & "') "
        Try
            oConnection.Open()
            Dim oCommand As New OleDbCommand(Reqt, oConnection)
            oCommand.ExecuteNonQuery()
            oConnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form5.Show()



    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim rep = MsgBox("Vous voulez vraiment quitte ", vbYesNo + vbInformation, "Confiramation")
        If rep = vbYes Then
            Application.Exit()
        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        Dim rdm As New Random()
        Dim ID As Integer = rdm.Next(1000, 10000)

        index = e.RowIndex
        Dim SelectedRow As DataGridViewRow
        SelectedRow = DataGridView1.Rows(index)
        txt_ID.Text = SelectedRow.Cells(0).Value.ToString
        txt_Consultation.Text = ID

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Process.Start("https://www.facebook.com/")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Process.Start("https://twitter.com/explore")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Process.Start("https://www.instagram.com/accounts/login/")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form10.Show()
        Me.Close()
    End Sub
End Class
