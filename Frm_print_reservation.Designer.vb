<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_print_reservation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_print_reservation))
        Me.Lab_nres = New System.Windows.Forms.Label()
        Me.Lab_matricule = New System.Windows.Forms.Label()
        Me.Lab_classtype = New System.Windows.Forms.Label()
        Me.Lab_cartype = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Lab_name = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lab_resenddate = New System.Windows.Forms.Label()
        Me.Lab_resstartdate = New System.Windows.Forms.Label()
        Me.Lab_ticket_time = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.but_print_ticket = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lab_nres
        '
        Me.Lab_nres.AutoSize = True
        Me.Lab_nres.BackColor = System.Drawing.Color.DarkGray
        Me.Lab_nres.Location = New System.Drawing.Point(171, 229)
        Me.Lab_nres.Name = "Lab_nres"
        Me.Lab_nres.Size = New System.Drawing.Size(45, 13)
        Me.Lab_nres.TabIndex = 43
        Me.Lab_nres.Text = "Label14"
        '
        'Lab_matricule
        '
        Me.Lab_matricule.AutoSize = True
        Me.Lab_matricule.BackColor = System.Drawing.Color.DarkGray
        Me.Lab_matricule.Location = New System.Drawing.Point(171, 190)
        Me.Lab_matricule.Name = "Lab_matricule"
        Me.Lab_matricule.Size = New System.Drawing.Size(45, 13)
        Me.Lab_matricule.TabIndex = 42
        Me.Lab_matricule.Text = "Label13"
        '
        'Lab_classtype
        '
        Me.Lab_classtype.AutoSize = True
        Me.Lab_classtype.BackColor = System.Drawing.Color.DarkGray
        Me.Lab_classtype.Location = New System.Drawing.Point(171, 150)
        Me.Lab_classtype.Name = "Lab_classtype"
        Me.Lab_classtype.Size = New System.Drawing.Size(45, 13)
        Me.Lab_classtype.TabIndex = 41
        Me.Lab_classtype.Text = "Label12"
        '
        'Lab_cartype
        '
        Me.Lab_cartype.AutoSize = True
        Me.Lab_cartype.BackColor = System.Drawing.Color.DarkGray
        Me.Lab_cartype.Location = New System.Drawing.Point(171, 110)
        Me.Lab_cartype.Name = "Lab_cartype"
        Me.Lab_cartype.Size = New System.Drawing.Size(45, 13)
        Me.Lab_cartype.TabIndex = 40
        Me.Lab_cartype.Text = "Label11"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DarkGray
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 18)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "N° Reservation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DarkGray
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Matricule"
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
        Me.PrintPreviewDialog1.Text = ""
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Lab_name
        '
        Me.Lab_name.AutoSize = True
        Me.Lab_name.BackColor = System.Drawing.Color.DarkGray
        Me.Lab_name.Location = New System.Drawing.Point(171, 72)
        Me.Lab_name.Name = "Lab_name"
        Me.Lab_name.Size = New System.Drawing.Size(33, 13)
        Me.Lab_name.TabIndex = 39
        Me.Lab_name.Text = "name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkGray
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Class type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkGray
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Car type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkGray
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 18)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Name"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "End Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Start Date"
        '
        'Lab_resenddate
        '
        Me.Lab_resenddate.AutoSize = True
        Me.Lab_resenddate.BackColor = System.Drawing.Color.DarkGray
        Me.Lab_resenddate.Location = New System.Drawing.Point(171, 302)
        Me.Lab_resenddate.Name = "Lab_resenddate"
        Me.Lab_resenddate.Size = New System.Drawing.Size(39, 13)
        Me.Lab_resenddate.TabIndex = 31
        Me.Lab_resenddate.Text = "Label2"
        '
        'Lab_resstartdate
        '
        Me.Lab_resstartdate.AutoSize = True
        Me.Lab_resstartdate.BackColor = System.Drawing.Color.DarkGray
        Me.Lab_resstartdate.Location = New System.Drawing.Point(171, 265)
        Me.Lab_resstartdate.Name = "Lab_resstartdate"
        Me.Lab_resstartdate.Size = New System.Drawing.Size(39, 13)
        Me.Lab_resstartdate.TabIndex = 30
        Me.Lab_resstartdate.Text = "Label1"
        '
        'Lab_ticket_time
        '
        Me.Lab_ticket_time.AutoSize = True
        Me.Lab_ticket_time.BackColor = System.Drawing.Color.DarkGray
        Me.Lab_ticket_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_ticket_time.Location = New System.Drawing.Point(88, 30)
        Me.Lab_ticket_time.Name = "Lab_ticket_time"
        Me.Lab_ticket_time.Size = New System.Drawing.Size(65, 20)
        Me.Lab_ticket_time.TabIndex = 28
        Me.Lab_ticket_time.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PFE2023_Gestionparking.My.Resources.Resources.sdgfdgvc
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lab_nres)
        Me.Panel1.Controls.Add(Me.Lab_matricule)
        Me.Panel1.Controls.Add(Me.Lab_classtype)
        Me.Panel1.Controls.Add(Me.Lab_cartype)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Lab_name)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Lab_resenddate)
        Me.Panel1.Controls.Add(Me.Lab_resstartdate)
        Me.Panel1.Controls.Add(Me.Lab_ticket_time)
        Me.Panel1.Location = New System.Drawing.Point(4, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 348)
        Me.Panel1.TabIndex = 44
        '
        'but_print_ticket
        '
        Me.but_print_ticket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.but_print_ticket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.but_print_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.but_print_ticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_print_ticket.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.rsz_print_svgrepo_com
        Me.but_print_ticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.but_print_ticket.Location = New System.Drawing.Point(96, 365)
        Me.but_print_ticket.Name = "but_print_ticket"
        Me.but_print_ticket.Size = New System.Drawing.Size(165, 59)
        Me.but_print_ticket.TabIndex = 29
        Me.but_print_ticket.Text = "Print ticket"
        Me.but_print_ticket.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.but_print_ticket.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(264, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'Frm_print_reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PFE2023_Gestionparking.My.Resources.Resources.color
        Me.ClientSize = New System.Drawing.Size(359, 429)
        Me.Controls.Add(Me.but_print_ticket)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_print_reservation"
        Me.Text = "Frm_print_reservation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lab_nres As System.Windows.Forms.Label
    Friend WithEvents Lab_matricule As System.Windows.Forms.Label
    Friend WithEvents Lab_classtype As System.Windows.Forms.Label
    Friend WithEvents Lab_cartype As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Lab_name As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lab_resenddate As System.Windows.Forms.Label
    Friend WithEvents Lab_resstartdate As System.Windows.Forms.Label
    Friend WithEvents but_print_ticket As System.Windows.Forms.Button
    Friend WithEvents Lab_ticket_time As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
