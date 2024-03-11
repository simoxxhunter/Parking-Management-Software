<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_print_selfcheckticket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_print_selfcheckticket))
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Lab_ticket_time = New System.Windows.Forms.Label()
        Me.Lab_class_type = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lab_vehicule_type = New System.Windows.Forms.Label()
        Me.but_print_ticket = New System.Windows.Forms.Button()
        Me.Pict_vehicule = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lab_selfcheckticketno = New System.Windows.Forms.Label()
        CType(Me.Pict_vehicule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'PrintDocument1
        '
        '
        'Lab_ticket_time
        '
        Me.Lab_ticket_time.AutoSize = True
        Me.Lab_ticket_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_ticket_time.Location = New System.Drawing.Point(5, 13)
        Me.Lab_ticket_time.Name = "Lab_ticket_time"
        Me.Lab_ticket_time.Size = New System.Drawing.Size(65, 20)
        Me.Lab_ticket_time.TabIndex = 6
        Me.Lab_ticket_time.Text = "Label1"
        '
        'Lab_class_type
        '
        Me.Lab_class_type.AutoSize = True
        Me.Lab_class_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lab_class_type.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_class_type.Location = New System.Drawing.Point(12, 213)
        Me.Lab_class_type.Name = "Lab_class_type"
        Me.Lab_class_type.Size = New System.Drawing.Size(90, 30)
        Me.Lab_class_type.TabIndex = 10
        Me.Lab_class_type.Text = "Label3"
        Me.Lab_class_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Lab_vehicule_type
        '
        Me.Lab_vehicule_type.AutoSize = True
        Me.Lab_vehicule_type.Location = New System.Drawing.Point(125, 121)
        Me.Lab_vehicule_type.Name = "Lab_vehicule_type"
        Me.Lab_vehicule_type.Size = New System.Drawing.Size(39, 13)
        Me.Lab_vehicule_type.TabIndex = 9
        Me.Lab_vehicule_type.Text = "Label2"
        '
        'but_print_ticket
        '
        Me.but_print_ticket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.but_print_ticket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.but_print_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.but_print_ticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_print_ticket.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.rsz_print_svgrepo_com
        Me.but_print_ticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.but_print_ticket.Location = New System.Drawing.Point(21, 317)
        Me.but_print_ticket.Name = "but_print_ticket"
        Me.but_print_ticket.Size = New System.Drawing.Size(165, 62)
        Me.but_print_ticket.TabIndex = 8
        Me.but_print_ticket.Text = "Print ticket"
        Me.but_print_ticket.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.but_print_ticket.UseVisualStyleBackColor = True
        '
        'Pict_vehicule
        '
        Me.Pict_vehicule.Location = New System.Drawing.Point(17, 97)
        Me.Pict_vehicule.Name = "Pict_vehicule"
        Me.Pict_vehicule.Size = New System.Drawing.Size(102, 85)
        Me.Pict_vehicule.TabIndex = 7
        Me.Pict_vehicule.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Lab_selfcheckticketno)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lab_ticket_time)
        Me.Panel1.Controls.Add(Me.Lab_class_type)
        Me.Panel1.Controls.Add(Me.Lab_vehicule_type)
        Me.Panel1.Controls.Add(Me.Pict_vehicule)
        Me.Panel1.Location = New System.Drawing.Point(4, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 282)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(61, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Lab_selfcheckticketno
        '
        Me.Lab_selfcheckticketno.AutoSize = True
        Me.Lab_selfcheckticketno.Location = New System.Drawing.Point(80, 269)
        Me.Lab_selfcheckticketno.Name = "Lab_selfcheckticketno"
        Me.Lab_selfcheckticketno.Size = New System.Drawing.Size(39, 13)
        Me.Lab_selfcheckticketno.TabIndex = 31
        Me.Lab_selfcheckticketno.Text = "Label1"
        '
        'Frm_print_selfcheckticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PFE2023_Gestionparking.My.Resources.Resources.color
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(207, 391)
        Me.Controls.Add(Me.but_print_ticket)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_print_selfcheckticket"
        Me.Text = "Self check-in ticket"
        CType(Me.Pict_vehicule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents but_print_ticket As System.Windows.Forms.Button
    Friend WithEvents Lab_ticket_time As System.Windows.Forms.Label
    Friend WithEvents Lab_class_type As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lab_vehicule_type As System.Windows.Forms.Label
    Friend WithEvents Pict_vehicule As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lab_selfcheckticketno As System.Windows.Forms.Label
End Class
