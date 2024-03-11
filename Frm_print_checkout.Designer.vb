<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_print_checkout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_print_checkout))
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.but_print_ticket = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lab_todaysdate = New System.Windows.Forms.Label()
        Me.Lab_checkouttime = New System.Windows.Forms.Label()
        Me.Lab_checkindate = New System.Windows.Forms.Label()
        Me.Lab_total = New System.Windows.Forms.Label()
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
        'but_print_ticket
        '
        Me.but_print_ticket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.but_print_ticket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.but_print_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.but_print_ticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_print_ticket.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.rsz_print_svgrepo_com
        Me.but_print_ticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.but_print_ticket.Location = New System.Drawing.Point(81, 462)
        Me.but_print_ticket.Name = "but_print_ticket"
        Me.but_print_ticket.Size = New System.Drawing.Size(165, 62)
        Me.but_print_ticket.TabIndex = 12
        Me.but_print_ticket.Text = "Print ticket"
        Me.but_print_ticket.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.but_print_ticket.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PFE2023_Gestionparking.My.Resources.Resources.ticketcheckout
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lab_todaysdate)
        Me.Panel1.Controls.Add(Me.Lab_checkouttime)
        Me.Panel1.Controls.Add(Me.Lab_checkindate)
        Me.Panel1.Controls.Add(Me.Lab_total)
        Me.Panel1.Location = New System.Drawing.Point(3, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 426)
        Me.Panel1.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(158, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 83)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Smart park parking made easy"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(18, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Lab_todaysdate
        '
        Me.Lab_todaysdate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lab_todaysdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lab_todaysdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_todaysdate.Location = New System.Drawing.Point(82, 175)
        Me.Lab_todaysdate.Name = "Lab_todaysdate"
        Me.Lab_todaysdate.Size = New System.Drawing.Size(168, 20)
        Me.Lab_todaysdate.TabIndex = 4
        Me.Lab_todaysdate.Text = "Todays date "
        Me.Lab_todaysdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_checkouttime
        '
        Me.Lab_checkouttime.AutoSize = True
        Me.Lab_checkouttime.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lab_checkouttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_checkouttime.Location = New System.Drawing.Point(126, 245)
        Me.Lab_checkouttime.Name = "Lab_checkouttime"
        Me.Lab_checkouttime.Size = New System.Drawing.Size(90, 20)
        Me.Lab_checkouttime.TabIndex = 3
        Me.Lab_checkouttime.Text = "checkout "
        '
        'Lab_checkindate
        '
        Me.Lab_checkindate.AutoSize = True
        Me.Lab_checkindate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lab_checkindate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_checkindate.Location = New System.Drawing.Point(126, 220)
        Me.Lab_checkindate.Name = "Lab_checkindate"
        Me.Lab_checkindate.Size = New System.Drawing.Size(125, 20)
        Me.Lab_checkindate.TabIndex = 2
        Me.Lab_checkindate.Text = "checkin d&time"
        '
        'Lab_total
        '
        Me.Lab_total.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lab_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_total.Location = New System.Drawing.Point(173, 293)
        Me.Lab_total.Name = "Lab_total"
        Me.Lab_total.Size = New System.Drawing.Size(92, 24)
        Me.Lab_total.TabIndex = 0
        Me.Lab_total.Text = "Label1"
        '
        'Frm_print_checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PFE2023_Gestionparking.My.Resources.Resources.color
        Me.ClientSize = New System.Drawing.Size(324, 536)
        Me.Controls.Add(Me.but_print_ticket)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_print_checkout"
        Me.Text = "Frm_print_checkout"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents but_print_ticket As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lab_todaysdate As System.Windows.Forms.Label
    Friend WithEvents Lab_checkouttime As System.Windows.Forms.Label
    Friend WithEvents Lab_checkindate As System.Windows.Forms.Label
    Friend WithEvents Lab_total As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
