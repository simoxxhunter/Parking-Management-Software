<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Lostticket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Lostticket))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Lab_ticket_time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lab_class_type = New System.Windows.Forms.Label()
        Me.but_print_ticket = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Lost Ticket Fee : 50 MAD"
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
        'Lab_ticket_time
        '
        Me.Lab_ticket_time.AutoSize = True
        Me.Lab_ticket_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_ticket_time.Location = New System.Drawing.Point(50, 12)
        Me.Lab_ticket_time.Name = "Lab_ticket_time"
        Me.Lab_ticket_time.Size = New System.Drawing.Size(65, 20)
        Me.Lab_ticket_time.TabIndex = 12
        Me.Lab_ticket_time.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Lab_class_type
        '
        Me.Lab_class_type.AutoSize = True
        Me.Lab_class_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lab_class_type.Font = New System.Drawing.Font("Candara", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_class_type.ForeColor = System.Drawing.Color.Red
        Me.Lab_class_type.Location = New System.Drawing.Point(36, 152)
        Me.Lab_class_type.Name = "Lab_class_type"
        Me.Lab_class_type.Size = New System.Drawing.Size(207, 42)
        Me.Lab_class_type.TabIndex = 14
        Me.Lab_class_type.Text = "LOST TICKET"
        Me.Lab_class_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_print_ticket
        '
        Me.but_print_ticket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.but_print_ticket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.but_print_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.but_print_ticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_print_ticket.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.rsz_print_svgrepo_com
        Me.but_print_ticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.but_print_ticket.Location = New System.Drawing.Point(59, 342)
        Me.but_print_ticket.Name = "but_print_ticket"
        Me.but_print_ticket.Size = New System.Drawing.Size(165, 59)
        Me.but_print_ticket.TabIndex = 13
        Me.but_print_ticket.Text = "Print ticket"
        Me.but_print_ticket.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.but_print_ticket.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Lab_ticket_time)
        Me.Panel1.Controls.Add(Me.Lab_class_type)
        Me.Panel1.Location = New System.Drawing.Point(5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 318)
        Me.Panel1.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.PARKING_MADE_EASY
        Me.PictureBox1.Location = New System.Drawing.Point(71, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'frm_Lostticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 417)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.but_print_ticket)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Lostticket"
        Me.Text = "Lost ticket"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Lab_ticket_time As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents but_print_ticket As System.Windows.Forms.Button
    Friend WithEvents Lab_class_type As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
