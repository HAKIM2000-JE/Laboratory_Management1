Imports System
Imports System.Data.OleDb
Imports IO





Public Class Form7
    Private strConnexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\moham\Desktop\Base_Patient.mdb"
    Private oConnection As New OleDbConnection(strConnexion)

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter


    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_Patient.Text = Form6.txt_Nom.Text + " " + Form6.txt_Prénom.Text
        txt_Analyse.Text = Form6.txt_Analyse.Text
        txt_ID.Text = Form6.txt_ID.Text
        txt_consult.Text = Form6.txt_consult.Text
        txt_ID.Visible = False
        txt_consult.Visible = False
        txt_Date.Text = Form6.DateTimePicker1.Value.ToShortDateString + " " + Form6.TextBox3.Text
        If txt_Analyse.Text = "Bilan hépatique" Then
            lbl_1.Text = "Albumine"
            lbl_2.Text = "INR"
            lbl_3.Text = "Bilirubine"
            lbl_4.Text = "Encéphalopathie"
            lbl_6.Visible = False
            lbl_5.Text = "Aciste"
            txt_6.Visible = False
            u_6.Visible = False





        ElseIf txt_Analyse.Text = "Glycémie" Then
            lbl_1.Text = "Triglycérides"
            lbl_2.Text = "INR"
            lbl_3.Text = "Choléstérol LDL"
            lbl_4.Text = "Choléstérol HDL"
            u_4.Text = "mmol/l"
            lbl_6.Visible = False
            lbl_5.Text = "Choléstérol Total"
            txt_6.Visible = False
            u_6.Visible = False
        ElseIf txt_Analyse.Text = "Hematologie" Then
            lbl_1.Text = "Hémaglobie"
            u_1.Text = "G/T"
            u_2.Text = "T/I"
            u_3.Text = "%"
            u_4.Text = "fl"
            u_5.Text = "pg"

            lbl_2.Text = "Hématie"
            lbl_3.Text = "Hématocrite"
            lbl_4.Text = "VGM"
            u_4.Text = "mmol/l"
            lbl_6.Visible = False
            lbl_5.Text = "TGMH"
            txt_6.Visible = False
            u_6.Visible = False


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim rep = MsgBox("Vous voulez vraiment quitte ", vbYesNo + vbInformation, "Confiramation")
        If rep = vbYes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form6.Show()
        Me.Close()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim ID, Age, Poids, Temp, Taille, Tension As Double
        ID = CDbl(txt_ID.Text)
        Age = CDbl(txt_Age.Text)
        Poids = CDbl(txt_Poids.Text)
        Taille = CDbl(txt_Taille.Text)
        Temp = CDbl(txt_Température.Text)
        Tension = CDbl(txt_Tension.Text)
        Dim Requette As String = "insert into Mesure_usuelles values(" & Age & ",'" & Poids & "','" & Temp & "','" & Taille & "',  '" & txt_Maladie.Text & "','" & Tension & "','" & ID & "')"
        Try
            oConnection.Open()
            Dim oCommand As New OleDbCommand(Requette, oConnection)
            oCommand.ExecuteNonQuery()
            oConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txt_Maladie.Text = " "
        txt_Poids.Text = " "
        txt_Température.Text = " "
        txt_Tension.Text = " "
        txt_Taille.Text = " "
        txt_Age.Text = " "
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txt_1.Text = " "
        txt_2.Text = " "
        txt_3.Text = " "
        txt_4.Text = " "
        txt_5.Text = " "
        txt_6.Text = " "

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If (txt_Analyse.Text = "Bilan sanguin") Then


            Dim Req_Sang As String = "insert into Sang values('" & txt_1.Text & "','" & txt_2.Text & "','" & txt_3.Text & "','" & txt_4.Text & "','" & txt_5.Text & "','" & txt_6.Text & "','" & txt_ID.Text & "', '" & txt_consult.Text & "')"
            Try
                oConnection.Open()
                Dim oCommand As New OleDbCommand(Req_Sang, oConnection)
                oCommand.ExecuteNonQuery()
                oConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf (txt_Analyse.Text = "Bilan hépatique") Then
            Dim Req_hepathie As String = "insert into Hypatique values('" & txt_1.Text & "','" & txt_2.Text & "','" & txt_3.Text & "','" & txt_4.Text & "','" & txt_5.Text & "','" & txt_ID.Text & "', '" & txt_consult.Text & "')"
            Try
                oConnection.Open()
                Dim oCommand As New OleDbCommand(Req_hepathie, oConnection)
                oCommand.ExecuteNonQuery()
                oConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf txt_Analyse.Text = "Glycémie" Then
            Dim Req_Gylcemie As String = "insert into Glycémie values('" & txt_1.Text & "','" & txt_2.Text & "','" & txt_3.Text & "','" & txt_4.Text & "','" & txt_5.Text & "','" & txt_ID.Text & "', '" & txt_consult.Text & "')"
            Try
                oConnection.Open()
                Dim oCommand As New OleDbCommand(Req_Gylcemie, oConnection)
                oCommand.ExecuteNonQuery()
                oConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf txt_Analyse.Text = "Hematologie" Then
            Dim Req_Hymat As String = "insert into Hematologie values( '" & txt_1.Text & "','" & txt_2.Text & "','" & txt_3.Text & "','" & txt_4.Text & "','" & txt_5.Text & "','" & txt_ID.Text & "', '" & txt_consult.Text & "')"
            Try
                oConnection.Open()
                Dim oCommand As New OleDbCommand(Req_Hymat, oConnection)
                oCommand.ExecuteNonQuery()
                oConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim p, q As String
        If RadioButton1.Checked = True Then
            p = "Oui"
        Else
            p = "Non"

        End If
        If RadioButton2.Checked = True Then
            txt_Montant.Text = 0
            q = "Absent"
        Else
            q = "Presnt"
        End If
        Dim Req As String = "insert into Reglement values('" & txt_ID.Text & "','" & txt_consult.Text & "','" & txt_Patient.Text & "' ,'" & txt_Analyse.Text & "', '" & q & "','" & txt_Montant.Text & "', '" & p & "')"
        Try

            oConnection.Open()
            Dim oCommand As New OleDbCommand(Req, oConnection)
            MsgBox(Req)
            oCommand.ExecuteNonQuery()

            oConnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Form8.Show()
        Me.Close()
    End Sub
End Class