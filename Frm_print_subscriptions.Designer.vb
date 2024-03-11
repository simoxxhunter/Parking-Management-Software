<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_print_subscriptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_print_subscriptions))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lab_nsub = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lab_enddate = New System.Windows.Forms.Label()
        Me.Lab_startdate = New System.Windows.Forms.Label()
        Me.Lab_veh_type = New System.Windows.Forms.Label()
        Me.Lab_matricule = New System.Windows.Forms.Label()
        Me.Lab_class = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lab_name = New System.Windows.Forms.Label()
        Me.but_print_card = New System.Windows.Forms.Button()
        Me.Lab_subduration = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PFE2023_Gestionparking.My.Resources.Resources._Downloader_la__6482710b2e392
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Lab_subduration)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Lab_nsub)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Lab_veh_type)
        Me.Panel1.Controls.Add(Me.Lab_matricule)
        Me.Panel1.Controls.Add(Me.Lab_class)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lab_name)
        Me.Panel1.Location = New System.Drawing.Point(39, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(638, 346)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 29)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Subscribtion Card"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(436, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Plate No° :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(237, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Class :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(22, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Vehicule type :"
        '
        'Lab_nsub
        '
        Me.Lab_nsub.AutoSize = True
        Me.Lab_nsub.BackColor = System.Drawing.Color.Transparent
        Me.Lab_nsub.Font = New System.Drawing.Font("Cooper Black", 14.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_nsub.Location = New System.Drawing.Point(435, 129)
        Me.Lab_nsub.Name = "Lab_nsub"
        Me.Lab_nsub.Size = New System.Drawing.Size(134, 21)
        Me.Lab_nsub.TabIndex = 20
        Me.Lab_nsub.Text = "FIRST  LAST"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Lab_enddate)
        Me.GroupBox1.Controls.Add(Me.Lab_startdate)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 285)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 59)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Lab_enddate
        '
        Me.Lab_enddate.AutoSize = True
        Me.Lab_enddate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_enddate.Location = New System.Drawing.Point(38, 33)
        Me.Lab_enddate.Name = "Lab_enddate"
        Me.Lab_enddate.Size = New System.Drawing.Size(75, 17)
        Me.Lab_enddate.TabIndex = 17
        Me.Lab_enddate.Text = "End Date"
        '
        'Lab_startdate
        '
        Me.Lab_startdate.AutoSize = True
        Me.Lab_startdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_startdate.Location = New System.Drawing.Point(37, 16)
        Me.Lab_startdate.Name = "Lab_startdate"
        Me.Lab_startdate.Size = New System.Drawing.Size(80, 17)
        Me.Lab_startdate.TabIndex = 16
        Me.Lab_startdate.Text = "Start date"
        '
        'Lab_veh_type
        '
        Me.Lab_veh_type.AutoSize = True
        Me.Lab_veh_type.BackColor = System.Drawing.Color.Transparent
        Me.Lab_veh_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_veh_type.Location = New System.Drawing.Point(105, 170)
        Me.Lab_veh_type.Name = "Lab_veh_type"
        Me.Lab_veh_type.Size = New System.Drawing.Size(72, 17)
        Me.Lab_veh_type.TabIndex = 18
        Me.Lab_veh_type.Text = "Veh type"
        '
        'Lab_matricule
        '
        Me.Lab_matricule.AutoSize = True
        Me.Lab_matricule.BackColor = System.Drawing.Color.Transparent
        Me.Lab_matricule.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_matricule.Location = New System.Drawing.Point(495, 170)
        Me.Lab_matricule.Name = "Lab_matricule"
        Me.Lab_matricule.Size = New System.Drawing.Size(74, 17)
        Me.Lab_matricule.TabIndex = 15
        Me.Lab_matricule.Text = "Matricule"
        '
        'Lab_class
        '
        Me.Lab_class.AutoSize = True
        Me.Lab_class.BackColor = System.Drawing.Color.Transparent
        Me.Lab_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_class.Location = New System.Drawing.Point(292, 170)
        Me.Lab_class.Name = "Lab_class"
        Me.Lab_class.Size = New System.Drawing.Size(47, 17)
        Me.Lab_class.TabIndex = 14
        Me.Lab_class.Text = "Class"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(288, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Lab_name
        '
        Me.Lab_name.AutoSize = True
        Me.Lab_name.BackColor = System.Drawing.Color.Transparent
        Me.Lab_name.Font = New System.Drawing.Font("Cooper Black", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_name.Location = New System.Drawing.Point(21, 129)
        Me.Lab_name.Name = "Lab_name"
        Me.Lab_name.Size = New System.Drawing.Size(134, 21)
        Me.Lab_name.TabIndex = 12
        Me.Lab_name.Text = "FIRST  LAST"
        '
        'but_print_card
        '
        Me.but_print_card.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.but_print_card.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.but_print_card.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.but_print_card.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_print_card.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.rsz_print_svgrepo_com
        Me.but_print_card.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.but_print_card.Location = New System.Drawing.Point(278, 364)
        Me.but_print_card.Name = "but_print_card"
        Me.but_print_card.Size = New System.Drawing.Size(165, 60)
        Me.but_print_card.TabIndex = 6
        Me.but_print_card.Text = "Print Card"
        Me.but_print_card.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.but_print_card.UseVisualStyleBackColor = True
        '
        'Lab_subduration
        '
        Me.Lab_subduration.AutoSize = True
        Me.Lab_subduration.BackColor = System.Drawing.Color.Transparent
        Me.Lab_subduration.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_subduration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lab_subduration.Location = New System.Drawing.Point(277, 260)
        Me.Lab_subduration.Name = "Lab_subduration"
        Me.Lab_subduration.Size = New System.Drawing.Size(70, 22)
        Me.Lab_subduration.TabIndex = 25
        Me.Lab_subduration.Text = "Label5"
        '
        'Frm_print_subscriptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 429)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.but_print_card)
        Me.Name = "Frm_print_subscriptions"
        Me.Text = "Frm_print_subscriptions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lab_enddate As System.Windows.Forms.Label
    Friend WithEvents Lab_startdate As System.Windows.Forms.Label
    Friend WithEvents Lab_veh_type As System.Windows.Forms.Label
    Friend WithEvents Lab_matricule As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lab_class As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lab_name As System.Windows.Forms.Label
    Friend WithEvents but_print_card As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lab_nsub As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lab_subduration As System.Windows.Forms.Label
End Class
