<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_homme = New System.Windows.Forms.TextBox()
        Me.txt_femme = New System.Windows.Forms.TextBox()
        Me.txt_patient = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_vitesse = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_hepatique = New System.Windows.Forms.TextBox()
        Me.txt_urines = New System.Windows.Forms.TextBox()
        Me.txt_echographie = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_sang = New System.Windows.Forms.TextBox()
        Me.txt_Glycemie = New System.Windows.Forms.TextBox()
        Me.txt_nbrvisite = New System.Windows.Forms.TextBox()
        Me.Rendez_Vous = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_absent = New System.Windows.Forms.TextBox()
        Me.txt_rdv = New System.Windows.Forms.TextBox()
        Me.txt_present = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_npaye = New System.Windows.Forms.TextBox()
        Me.txt_paye = New System.Windows.Forms.TextBox()
        Me.txt_revenue = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Rendez_Vous.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1125, 80)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gestion_Laboratoir.My.Resources.Resources.green_arrow_showing_growth_vector
        Me.PictureBox1.Location = New System.Drawing.Point(340, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(411, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Statistique  2020"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.Gestion_Laboratoir.My.Resources.Resources.ver
        Me.Button1.Location = New System.Drawing.Point(1065, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 44)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_homme)
        Me.GroupBox1.Controls.Add(Me.txt_femme)
        Me.GroupBox1.Controls.Add(Me.txt_patient)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 140)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(569, 238)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patients"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre de patient Homme"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre de patinet femme"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre de Patient"
        '
        'txt_homme
        '
        Me.txt_homme.Location = New System.Drawing.Point(441, 110)
        Me.txt_homme.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_homme.Name = "txt_homme"
        Me.txt_homme.Size = New System.Drawing.Size(73, 22)
        Me.txt_homme.TabIndex = 3
        '
        'txt_femme
        '
        Me.txt_femme.Location = New System.Drawing.Point(441, 162)
        Me.txt_femme.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_femme.Name = "txt_femme"
        Me.txt_femme.Size = New System.Drawing.Size(73, 22)
        Me.txt_femme.TabIndex = 2
        '
        'txt_patient
        '
        Me.txt_patient.Location = New System.Drawing.Point(441, 60)
        Me.txt_patient.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_patient.Name = "txt_patient"
        Me.txt_patient.Size = New System.Drawing.Size(73, 22)
        Me.txt_patient.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Gestion_Laboratoir.My.Resources.Resources.images
        Me.PictureBox2.Location = New System.Drawing.Point(28, 36)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(171, 151)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_vitesse)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_hepatique)
        Me.GroupBox2.Controls.Add(Me.txt_urines)
        Me.GroupBox2.Controls.Add(Me.txt_echographie)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_sang)
        Me.GroupBox2.Controls.Add(Me.txt_Glycemie)
        Me.GroupBox2.Controls.Add(Me.txt_nbrvisite)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 424)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(569, 276)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Analyse"
        '
        'txt_vitesse
        '
        Me.txt_vitesse.Location = New System.Drawing.Point(489, 219)
        Me.txt_vitesse.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_vitesse.Name = "txt_vitesse"
        Me.txt_vitesse.Size = New System.Drawing.Size(65, 22)
        Me.txt_vitesse.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(311, 162)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Analyses urinaires"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(311, 223)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 17)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Vitesse de sédimentation"
        '
        'txt_hepatique
        '
        Me.txt_hepatique.Location = New System.Drawing.Point(489, 91)
        Me.txt_hepatique.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_hepatique.Name = "txt_hepatique"
        Me.txt_hepatique.Size = New System.Drawing.Size(63, 22)
        Me.txt_hepatique.TabIndex = 14
        '
        'txt_urines
        '
        Me.txt_urines.Location = New System.Drawing.Point(489, 154)
        Me.txt_urines.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_urines.Name = "txt_urines"
        Me.txt_urines.Size = New System.Drawing.Size(63, 22)
        Me.txt_urines.TabIndex = 13
        '
        'txt_echographie
        '
        Me.txt_echographie.Location = New System.Drawing.Point(207, 214)
        Me.txt_echographie.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_echographie.Name = "txt_echographie"
        Me.txt_echographie.Size = New System.Drawing.Size(65, 22)
        Me.txt_echographie.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 91)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Bilan sanguin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 158)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Glycémie"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 223)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Échographie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(311, 95)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Bilan hépatique"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nombre d'analyse effectuées "
        '
        'txt_sang
        '
        Me.txt_sang.Location = New System.Drawing.Point(209, 91)
        Me.txt_sang.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_sang.Name = "txt_sang"
        Me.txt_sang.Size = New System.Drawing.Size(63, 22)
        Me.txt_sang.TabIndex = 4
        '
        'txt_Glycemie
        '
        Me.txt_Glycemie.Location = New System.Drawing.Point(211, 149)
        Me.txt_Glycemie.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Glycemie.Name = "txt_Glycemie"
        Me.txt_Glycemie.Size = New System.Drawing.Size(61, 22)
        Me.txt_Glycemie.TabIndex = 3
        '
        'txt_nbrvisite
        '
        Me.txt_nbrvisite.Location = New System.Drawing.Point(235, 28)
        Me.txt_nbrvisite.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nbrvisite.Name = "txt_nbrvisite"
        Me.txt_nbrvisite.Size = New System.Drawing.Size(123, 22)
        Me.txt_nbrvisite.TabIndex = 2
        '
        'Rendez_Vous
        '
        Me.Rendez_Vous.Controls.Add(Me.Label14)
        Me.Rendez_Vous.Controls.Add(Me.Label12)
        Me.Rendez_Vous.Controls.Add(Me.Label13)
        Me.Rendez_Vous.Controls.Add(Me.txt_absent)
        Me.Rendez_Vous.Controls.Add(Me.txt_rdv)
        Me.Rendez_Vous.Controls.Add(Me.txt_present)
        Me.Rendez_Vous.Controls.Add(Me.PictureBox3)
        Me.Rendez_Vous.Location = New System.Drawing.Point(645, 140)
        Me.Rendez_Vous.Margin = New System.Windows.Forms.Padding(4)
        Me.Rendez_Vous.Name = "Rendez_Vous"
        Me.Rendez_Vous.Padding = New System.Windows.Forms.Padding(4)
        Me.Rendez_Vous.Size = New System.Drawing.Size(443, 238)
        Me.Rendez_Vous.TabIndex = 11
        Me.Rendez_Vous.TabStop = False
        Me.Rendez_Vous.Text = "Rendez_Vous"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(209, 171)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 17)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Absents"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(209, 110)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 17)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Présents"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(209, 36)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(159, 17)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Rendez_vous Réservés"
        '
        'txt_absent
        '
        Me.txt_absent.Location = New System.Drawing.Point(213, 194)
        Me.txt_absent.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_absent.Name = "txt_absent"
        Me.txt_absent.Size = New System.Drawing.Size(123, 22)
        Me.txt_absent.TabIndex = 5
        '
        'txt_rdv
        '
        Me.txt_rdv.Location = New System.Drawing.Point(213, 60)
        Me.txt_rdv.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rdv.Name = "txt_rdv"
        Me.txt_rdv.Size = New System.Drawing.Size(123, 22)
        Me.txt_rdv.TabIndex = 4
        '
        'txt_present
        '
        Me.txt_present.Location = New System.Drawing.Point(213, 132)
        Me.txt_present.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_present.Name = "txt_present"
        Me.txt_present.Size = New System.Drawing.Size(123, 22)
        Me.txt_present.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Gestion_Laboratoir.My.Resources.Resources.time
        Me.PictureBox3.Location = New System.Drawing.Point(31, 60)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(155, 132)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txt_npaye)
        Me.GroupBox4.Controls.Add(Me.txt_paye)
        Me.GroupBox4.Controls.Add(Me.txt_revenue)
        Me.GroupBox4.Controls.Add(Me.PictureBox4)
        Me.GroupBox4.Location = New System.Drawing.Point(645, 422)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(443, 278)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Réglement"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(129, 242)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(175, 28)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Bilan des paiements"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(209, 186)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 17)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Non-payé"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(209, 129)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 17)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Payé"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(209, 41)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 17)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Totale Revenues "
        '
        'txt_npaye
        '
        Me.txt_npaye.Location = New System.Drawing.Point(213, 209)
        Me.txt_npaye.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_npaye.Name = "txt_npaye"
        Me.txt_npaye.Size = New System.Drawing.Size(123, 22)
        Me.txt_npaye.TabIndex = 21
        '
        'txt_paye
        '
        Me.txt_paye.Location = New System.Drawing.Point(213, 149)
        Me.txt_paye.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_paye.Name = "txt_paye"
        Me.txt_paye.Size = New System.Drawing.Size(123, 22)
        Me.txt_paye.TabIndex = 22
        '
        'txt_revenue
        '
        Me.txt_revenue.Location = New System.Drawing.Point(213, 74)
        Me.txt_revenue.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_revenue.Name = "txt_revenue"
        Me.txt_revenue.Size = New System.Drawing.Size(123, 22)
        Me.txt_revenue.TabIndex = 23
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Gestion_Laboratoir.My.Resources.Resources.flos
        Me.PictureBox4.Location = New System.Drawing.Point(31, 81)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(133, 121)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(548, 725)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 28)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Retour"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(300, 111)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(53, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(180, 19)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Veuillez Choisir une date"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button4.Location = New System.Drawing.Point(548, 102)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(175, 28)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Afficher"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(1121, 793)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Rendez_Vous)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Rendez_Vous.ResumeLayout(False)
        Me.Rendez_Vous.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_homme As TextBox
    Friend WithEvents txt_femme As TextBox
    Friend WithEvents txt_patient As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_vitesse As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_hepatique As TextBox
    Friend WithEvents txt_urines As TextBox
    Friend WithEvents txt_echographie As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_sang As TextBox
    Friend WithEvents txt_Glycemie As TextBox
    Friend WithEvents txt_nbrvisite As TextBox
    Friend WithEvents Rendez_Vous As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_absent As TextBox
    Friend WithEvents txt_rdv As TextBox
    Friend WithEvents txt_present As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_npaye As TextBox
    Friend WithEvents txt_paye As TextBox
    Friend WithEvents txt_revenue As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Button4 As Button
End Class
