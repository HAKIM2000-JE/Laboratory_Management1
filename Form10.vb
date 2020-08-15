Imports System
Imports System.Data.OleDb

Imports Io



Public Class Form10
    Private strconnexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\moham\Desktop\Base_Patient.mdb"
    Private oConnection As New OleDbConnection(strconnexion)



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rep = MsgBox("Vous voulez vraiment quitte ", vbYesNo + vbInformation, "Confiramation")
        If rep = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Rendez_Vous_Enter(sender As Object, e As EventArgs) Handles Rendez_Vous.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form12.Show()
        Me.Close()
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim n, m, l, K As Integer
        Dim h, f, BS, BH, G, VIT, URN, GR, O1, O2 As String
        BS = "Bilan sanguin"
        BH = "Bilan hépatique"
        G = "Glycémie"
        VIT = "Vitesse de sédimentation"
        URN = "Analyses urinaires"
        GR = "Échographie"
        h = "Homme"
        f = "Femme"
        O1 = "Oui"
        O2 = "Non"
        Dim Requette1 As String = "SELECT Count(ID_Patient) AS NumberPatient FROM Patient "
        Dim Requette2 As String = "SELECT Count(ID_Patient) AS NumberPatientH FROM Patient where Sexe= '" & h & "'"
        Dim Requette3 As String = "SELECT Count(ID_Patient) AS NumberPatientF FROM Patient where Sexe='" & f & "'"
        Dim Requette4 As String = "SELECT COUNT( *) AS NumberConst FROM Consultation"
        Dim Requette5 As String = "SELECT COUNT(*) AS NumberConstB FROM Consultation WHERE (((Consultation.[Type d'analyse])='" & BS & "')); "
        Dim Requette6 As String = "SELECT COUNT(*) AS NumberConstB FROM Consultation WHERE (((Consultation.[Type d'analyse])='" & BH & "')); "
        Dim Requette7 As String = "SELECT COUNT(*) AS NumberConstB FROM Consultation WHERE (((Consultation.[Type d'analyse])='" & G & "')); "
        Dim Requette8 As String = "SELECT COUNT(*) AS NumberConstB FROM Consultation WHERE (((Consultation.[Type d'analyse])='" & VIT & "')); "
        Dim Requette9 As String = "SELECT COUNT(*) AS NumberConstB FROM Consultation WHERE (((Consultation.[Type d'analyse])='" & URN & "')); "
        Dim Requette10 As String = "SELECT COUNT(*) AS NumberConstB FROM Consultation WHERE (((Consultation.[Type d'analyse])='" & GR & "')); "
        Dim Requette11 As String = "SELECT SUM(Montant) FROM Reglement"
        Dim Requette12 As String = "SELECT SUM(Montant) FROM Reglement WHERE payé= '" & O1 & "' "
        Dim Requette13 As String = "SELECT SUM(Montant) FROM Reglement WHERE payé= '" & O2 & "' "
        Dim Requette14 As String = "SELECT COUNT(*) FROM Reglement"
        Try

            oConnection.Open()
            Dim cmd1 As New OleDbCommand(Requette1, oConnection)
            Dim oReader1 As OleDbDataReader = cmd1.ExecuteReader()

            While oReader1.Read()
                n = oReader1.GetValue(0)
            End While
            txt_patient.Text = n
            oConnection.Close()
            oConnection.Open()
            Dim cmd2 As New OleDbCommand(Requette2, oConnection)
            Dim oReader2 As OleDbDataReader = cmd2.ExecuteReader()

            While oReader2.Read()
                m = oReader2.GetValue(0)
            End While
            txt_homme.Text = m
            oConnection.Close()

            oConnection.Open()
            Dim cmd3 As New OleDbCommand(Requette3, oConnection)
            Dim oReader3 As OleDbDataReader = cmd3.ExecuteReader()

            While oReader3.Read()
                l = oReader3.GetValue(0)
            End While
            txt_femme.Text = l
            oConnection.Close()

            oConnection.Open()
            Dim cmd4 As New OleDbCommand(Requette4, oConnection)
            Dim oReader4 As OleDbDataReader = cmd4.ExecuteReader()

            While oReader4.Read()
                l = oReader4.GetValue(0)
            End While
            txt_nbrvisite.Text = l
            txt_present.Text = txt_nbrvisite.Text
            txt_present.Text = n
            oConnection.Close()

            oConnection.Open()
            Dim cmd5 As New OleDbCommand(Requette5, oConnection)
            Dim oReader5 As OleDbDataReader = cmd5.ExecuteReader()

            While oReader5.Read()
                l = oReader5.GetValue(0)
            End While
            txt_sang.Text = l
            oConnection.Close()

            oConnection.Open()
            Dim cmd6 As New OleDbCommand(Requette6, oConnection)
            Dim oReader6 As OleDbDataReader = cmd6.ExecuteReader()

            While oReader6.Read()
                l = oReader6.GetValue(0)
            End While
            txt_hepatique.Text = l
            oConnection.Close()

            oConnection.Open()
            Dim cmd7 As New OleDbCommand(Requette7, oConnection)
            Dim oReader7 As OleDbDataReader = cmd7.ExecuteReader()

            While oReader7.Read()
                l = oReader7.GetValue(0)
            End While
            txt_Glycemie.Text = l
            oConnection.Close()

            oConnection.Open()
            Dim cmd8 As New OleDbCommand(Requette8, oConnection)
            Dim oReader8 As OleDbDataReader = cmd8.ExecuteReader()

            While oReader8.Read()
                l = oReader8.GetValue(0)
            End While
            txt_vitesse.Text = l
            oConnection.Close()

            oConnection.Open()
            Dim cmd9 As New OleDbCommand(Requette9, oConnection)
            Dim oReader9 As OleDbDataReader = cmd9.ExecuteReader()

            While oReader9.Read()
                l = oReader9.GetValue(0)
            End While
            txt_urines.Text = l
            oConnection.Close()

            oConnection.Open()
            Dim cmd10 As New OleDbCommand(Requette10, oConnection)
            Dim oReader10 As OleDbDataReader = cmd10.ExecuteReader()

            While oReader10.Read()
                l = oReader10.GetValue(0)
            End While
            txt_echographie.Text = l
            oConnection.Close()

            oConnection.Open()
            Dim cmd11 As New OleDbCommand(Requette11, oConnection)
            Dim oReader11 As OleDbDataReader = cmd11.ExecuteReader()

            While oReader11.Read()
                l = oReader11.GetValue(0)
            End While
            txt_revenue.Text = l
            oConnection.Close()

            oConnection.Open()
            Dim cmd12 As New OleDbCommand(Requette12, oConnection)
            Dim oReader12 As OleDbDataReader = cmd12.ExecuteReader()

            While oReader12.Read()
                l = oReader12.GetValue(0)
            End While
            txt_paye.Text = l
            oConnection.Close()

            oConnection.Open()
            Dim cmd13 As New OleDbCommand(Requette13, oConnection)
            Dim oReader13 As OleDbDataReader = cmd13.ExecuteReader()

            While oReader13.Read()
                l = oReader13.GetValue(0)
            End While
            txt_npaye.Text = l
            oConnection.Close()

            oConnection.Open()
            Dim cmd14 As New OleDbCommand(Requette14, oConnection)
            Dim oReader14 As OleDbDataReader = cmd14.ExecuteReader()

            While oReader14.Read()
                l = oReader14.GetValue(0)
            End While

            txt_rdv.Text = l
            txt_absent.Text = l - n

            oConnection.Close()











        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


End Class