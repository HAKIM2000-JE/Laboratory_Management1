Imports System
Imports System.Data.OleDb

Imports Io

Public Class Form9
    Private strconnexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\moham\Desktop\Base_Patient.mdb"
    Private oConnection As New OleDbConnection(strconnexion)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim rep = MsgBox("Vous voulez vraiment quitte ", vbYesNo + vbInformation, "Confiramation")
        If rep = vbYes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_nom.Text = Form6.txt_Nom.Text
        lbl_prenom.Text = Form6.txt_Prénom.Text

        lbl_date.Text = Form7.txt_Date.Text
        lbl_nume.Text = Form6.txt_consult.Text
        txt_id.Text = Form6.txt_ID.Text
        Label122.Text = Form8.TextBox2.Text
        lbl_analyse.Text = Form8.txt_Analyse.Text
        txt_id.Visible = False
        lbl_date.Text = Form6.DateTimePicker1.Value
        lbl_age.Text = Form8.txt_Age.Text


        lbl_maladie.Text = Form8.txt_Maladie.Text
        lbl_taille.Text = Form8.txt_Taille.Text
        lbl_tension.Text = Form8.txt_Tension.Text
        lbl_temperature.Text = Form8.txt_Température.Text
        lbl_poids.Text = Form8.txt_Poids.Text
        Label15.Text = Form8.Label13.Text

        Dim ID As Double
        ID = CDbl(txt_id.Text)

        If lbl_analyse.Text = "Bilan sanguin" Then



            Dim Requette As String = "select * from Sang where ID_Patient =  " & ID & " "
            Try
                oConnection.Open()
                Dim cmd1 As New OleDbCommand(Requette, oConnection)
                Dim oReader1 As OleDbDataReader = cmd1.ExecuteReader()

                While oReader1.Read()
                    l1.Text = oReader1.GetString(0)
                    l2.Text = oReader1.GetString(1)
                    l3.Text = oReader1.GetString(2)
                    l4.Text = oReader1.GetString(3)
                    l5.Text = oReader1.GetString(4)
                    L6.Text = oReader1.GetString(5)


                End While
                MsgBox(L6.Text)







            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End If






        If lbl_analyse.Text = "Bilan hépatique" Then
            Dim Requette As String = "select * from Hypatique where ID_Patient = " & ID & "  "

            lbl_1.Text = "Albumine"
            lbl_2.Text = "INR"
            lbl_3.Text = "Bilirubine"
            lbl_4.Text = "Encéphalopathie"
            lbl_6.Visible = False
            lbl_5.Text = "Aciste"
            lbl_6.Visible = False

            l11.Text = "[3.4,5.4]"
            l22.Text = "[0.8,2]"
            l33.Text = "[10,12]"
            l44.Text = "[10,50]"
            l55.Text = "[5,11]"
            Try
                oConnection.Open()
                Dim cmd1 As New OleDbCommand(Requette, oConnection)
                Dim oReader1 As OleDbDataReader = cmd1.ExecuteReader()

                While oReader1.Read()
                    l1.Text = oReader1.GetString(0)
                    l2.Text = oReader1.GetString(1)
                    l3.Text = oReader1.GetString(2)
                    l4.Text = oReader1.GetString(3)
                    l5.Text = oReader1.GetString(4)



                End While
                oConnection.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try






        ElseIf lbl_analyse.Text = "Glycémie" Then
            Dim Requette As String = "select * from Glycémie where ID_Patient = " & ID & "  "

            lbl_1.Text = "Triglycérides"
            lbl_2.Text = "INR"
            lbl_3.Text = "Choléstérol LDL"
            lbl_4.Text = "Choléstérol HDL"
            u_4.Text = "mmol/l"
            lbl_6.Visible = False
            lbl_5.Text = "Choléstérol Total"
            lbl_6.Visible = False
            u_6.Visible = False
            l11.Text = "< 1.5"
            l22.Text = "[0.8,2]"
            l33.Text = "< 1.6"
            l66.Text = "> 0.4"
            l55.Text = "[5,11]"
            l44.Visible = False
            l4.Visible = False

            Try
                oConnection.Open()
                Dim cmd1 As New OleDbCommand(Requette, oConnection)
                Dim oReader1 As OleDbDataReader = cmd1.ExecuteReader()

                While oReader1.Read()
                    l1.Text = oReader1.GetString(0)
                    l2.Text = oReader1.GetString(1)
                    l3.Text = oReader1.GetString(2)
                    L6.Text = oReader1.GetString(3)
                    l5.Text = oReader1.GetString(4)



                End While
                oConnection.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf lbl_analyse.Text = "Hematologie" Then
            Dim Requette As String = "select * from  Hematologie where ID_Patient = " & ID & "  "
            lbl_1.Text = "Hémaglobie"
            lbl_2.Text = "Hémathie"
            lbl_3.Text = "Hématocrite"
            lbl_4.Text = "VGM"
            u_4.Text = "fl"
            u_1.Text = "G/I"
            u_3.Text = "%"
            u_5.Text = "pg"
            u_2.Text = "T/I"
            lbl_6.Visible = False
            lbl_5.Text = "TGHM"
            lbl_6.Visible = False
            u_6.Visible = False
            l11.Text = "[4,10]"
            l22.Text = "[3,5]"
            l33.Text = "[30,40]"
            l66.Text = "[80,100]"
            l55.Text = "[27,32]"
            l44.Visible = False
            l4.Visible = False

            Try
                oConnection.Open()
                Dim cmd1 As New OleDbCommand(Requette, oConnection)
                Dim oReader1 As OleDbDataReader = cmd1.ExecuteReader()

                While oReader1.Read()
                    l1.Text = oReader1.GetString(0)
                    l2.Text = oReader1.GetString(1)
                    l3.Text = oReader1.GetString(2)
                    L6.Text = oReader1.GetString(3)
                    l5.Text = oReader1.GetString(4)



                End While
                oConnection.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class