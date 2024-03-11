<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_selfcheckin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_selfcheckin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Lab_datentime = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Radbut_van = New System.Windows.Forms.RadioButton()
        Me.Radbut_bike = New System.Windows.Forms.RadioButton()
        Me.Radbut_car = New System.Windows.Forms.RadioButton()
        Me.Radbut_1stclass = New System.Windows.Forms.RadioButton()
        Me.Radbut_2ndclass = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Radbut_specialneeds = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.But_valider = New System.Windows.Forms.Button()
        Me.But_annuler = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose your vehicle's type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(207, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Choose which class you want :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "4 DH/1h"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(382, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "2 DH/1h"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(691, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "7 DH/1hr"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "X 1.2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(399, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "X 1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(700, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "X 0.5"
        '
        'Lab_datentime
        '
        Me.Lab_datentime.AutoSize = True
        Me.Lab_datentime.Location = New System.Drawing.Point(555, 563)
        Me.Lab_datentime.Name = "Lab_datentime"
        Me.Lab_datentime.Size = New System.Drawing.Size(28, 13)
        Me.Lab_datentime.TabIndex = 17
        Me.Lab_datentime.Text = "-------"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Radbut_van)
        Me.GroupBox1.Controls.Add(Me.Radbut_bike)
        Me.GroupBox1.Controls.Add(Me.Radbut_car)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(211, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(823, 108)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'Radbut_van
        '
        Me.Radbut_van.AutoSize = True
        Me.Radbut_van.Font = New System.Drawing.Font("Calibri", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radbut_van.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.rsz_van_svgrepo_com
        Me.Radbut_van.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Radbut_van.Location = New System.Drawing.Point(674, 7)
        Me.Radbut_van.Name = "Radbut_van"
        Me.Radbut_van.Size = New System.Drawing.Size(78, 64)
        Me.Radbut_van.TabIndex = 20
        Me.Radbut_van.TabStop = True
        Me.Radbut_van.UseVisualStyleBackColor = True
        '
        'Radbut_bike
        '
        Me.Radbut_bike.AutoSize = True
        Me.Radbut_bike.Font = New System.Drawing.Font("Calibri", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radbut_bike.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.rsz_motorcycle_1_svgrepo_com
        Me.Radbut_bike.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Radbut_bike.Location = New System.Drawing.Point(364, 7)
        Me.Radbut_bike.Name = "Radbut_bike"
        Me.Radbut_bike.Size = New System.Drawing.Size(78, 64)
        Me.Radbut_bike.TabIndex = 19
        Me.Radbut_bike.TabStop = True
        Me.Radbut_bike.UseVisualStyleBackColor = True
        '
        'Radbut_car
        '
        Me.Radbut_car.AutoSize = True
        Me.Radbut_car.Font = New System.Drawing.Font("Calibri", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radbut_car.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.rsz_car_3_svgrepo_com
        Me.Radbut_car.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Radbut_car.Location = New System.Drawing.Point(45, 7)
        Me.Radbut_car.Name = "Radbut_car"
        Me.Radbut_car.Size = New System.Drawing.Size(78, 64)
        Me.Radbut_car.TabIndex = 18
        Me.Radbut_car.TabStop = True
        Me.Radbut_car.UseVisualStyleBackColor = True
        '
        'Radbut_1stclass
        '
        Me.Radbut_1stclass.AutoSize = True
        Me.Radbut_1stclass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radbut_1stclass.Location = New System.Drawing.Point(45, 13)
        Me.Radbut_1stclass.Name = "Radbut_1stclass"
        Me.Radbut_1stclass.Size = New System.Drawing.Size(106, 24)
        Me.Radbut_1stclass.TabIndex = 22
        Me.Radbut_1stclass.TabStop = True
        Me.Radbut_1stclass.Text = "First class"
        Me.Radbut_1stclass.UseVisualStyleBackColor = True
        '
        'Radbut_2ndclass
        '
        Me.Radbut_2ndclass.AutoSize = True
        Me.Radbut_2ndclass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radbut_2ndclass.Location = New System.Drawing.Point(347, 13)
        Me.Radbut_2ndclass.Name = "Radbut_2ndclass"
        Me.Radbut_2ndclass.Size = New System.Drawing.Size(128, 24)
        Me.Radbut_2ndclass.TabIndex = 23
        Me.Radbut_2ndclass.TabStop = True
        Me.Radbut_2ndclass.Text = "Second class"
        Me.Radbut_2ndclass.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Radbut_specialneeds)
        Me.GroupBox2.Controls.Add(Me.Radbut_2ndclass)
        Me.GroupBox2.Controls.Add(Me.Radbut_1stclass)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(211, 342)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(823, 82)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'Radbut_specialneeds
        '
        Me.Radbut_specialneeds.AutoSize = True
        Me.Radbut_specialneeds.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radbut_specialneeds.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.rsz_wheelchair_svgrepo_com
        Me.Radbut_specialneeds.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Radbut_specialneeds.Location = New System.Drawing.Point(674, 13)
        Me.Radbut_specialneeds.Name = "Radbut_specialneeds"
        Me.Radbut_specialneeds.Size = New System.Drawing.Size(78, 64)
        Me.Radbut_specialneeds.TabIndex = 24
        Me.Radbut_specialneeds.TabStop = True
        Me.Radbut_specialneeds.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(555, 597)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Copyright 2023.  V1.0"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.color
        Me.PictureBox3.Location = New System.Drawing.Point(1058, -2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(196, 622)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.color
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(186, 622)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.PARKING_MADE_EASY
        Me.PictureBox1.Location = New System.Drawing.Point(530, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'But_valider
        '
        Me.But_valider.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_valider.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.rsz_validate_svgrepo_com
        Me.But_valider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.But_valider.Location = New System.Drawing.Point(662, 466)
        Me.But_valider.Name = "But_valider"
        Me.But_valider.Size = New System.Drawing.Size(256, 72)
        Me.But_valider.TabIndex = 9
        Me.But_valider.Text = "Get My ticket !"
        Me.But_valider.UseVisualStyleBackColor = True
        '
        'But_annuler
        '
        Me.But_annuler.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_annuler.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.rsz_cancel_svgrepo_com
        Me.But_annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.But_annuler.Location = New System.Drawing.Point(316, 466)
        Me.But_annuler.Name = "But_annuler"
        Me.But_annuler.Size = New System.Drawing.Size(250, 72)
        Me.But_annuler.TabIndex = 8
        Me.But_annuler.Text = "Cancel"
        Me.But_annuler.UseVisualStyleBackColor = True
        '
        'Frm_selfcheckin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1253, 619)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lab_datentime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.But_valider)
        Me.Controls.Add(Me.But_annuler)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_selfcheckin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart park - Parking Made Easy"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents But_annuler As System.Windows.Forms.Button
    Friend WithEvents But_valider As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Lab_datentime As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Radbut_car As System.Windows.Forms.RadioButton
    Friend WithEvents Radbut_bike As System.Windows.Forms.RadioButton
    Friend WithEvents Radbut_van As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Radbut_1stclass As System.Windows.Forms.RadioButton
    Friend WithEvents Radbut_2ndclass As System.Windows.Forms.RadioButton
    Friend WithEvents Radbut_specialneeds As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
