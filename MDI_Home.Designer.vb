<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI_Home))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.CheckinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubscribersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELFCHECKINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lab_loggeduser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lab_subs_num = New System.Windows.Forms.Label()
        Me.lab_subearnings = New System.Windows.Forms.Label()
        Me.Lab_resnumber = New System.Windows.Forms.Label()
        Me.Lab_researnings = New System.Windows.Forms.Label()
        Me.Lab_totalcheckin = New System.Windows.Forms.Label()
        Me.Lab_totalearnings = New System.Windows.Forms.Label()
        Me.EmployersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckinToolStripMenuItem, Me.CheckoutToolStripMenuItem, Me.ReservationToolStripMenuItem, Me.SubscribersToolStripMenuItem, Me.SELFCHECKINToolStripMenuItem, Me.EmployersToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1014, 24)
        Me.MenuStrip.TabIndex = 9
        Me.MenuStrip.Text = "MenuStrip"
        '
        'CheckinToolStripMenuItem
        '
        Me.CheckinToolStripMenuItem.Name = "CheckinToolStripMenuItem"
        Me.CheckinToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.CheckinToolStripMenuItem.Text = "&Check-in"
        '
        'CheckoutToolStripMenuItem
        '
        Me.CheckoutToolStripMenuItem.Name = "CheckoutToolStripMenuItem"
        Me.CheckoutToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.CheckoutToolStripMenuItem.Text = "&Check-out"
        '
        'ReservationToolStripMenuItem
        '
        Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
        Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ReservationToolStripMenuItem.Text = "&Reservations"
        '
        'SubscribersToolStripMenuItem
        '
        Me.SubscribersToolStripMenuItem.Name = "SubscribersToolStripMenuItem"
        Me.SubscribersToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.SubscribersToolStripMenuItem.Text = "&Subscriptions"
        '
        'SELFCHECKINToolStripMenuItem
        '
        Me.SELFCHECKINToolStripMenuItem.Name = "SELFCHECKINToolStripMenuItem"
        Me.SELFCHECKINToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.SELFCHECKINToolStripMenuItem.Text = "&SELF CHECK-IN"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.QuitterToolStripMenuItem.Text = "&Quitter"
        '
        'Lab_loggeduser
        '
        Me.Lab_loggeduser.Name = "Lab_loggeduser"
        Me.Lab_loggeduser.Size = New System.Drawing.Size(27, 17)
        Me.Lab_loggeduser.Text = "État"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Lab_loggeduser})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 480)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1014, 22)
        Me.StatusStrip.TabIndex = 10
        Me.StatusStrip.Text = "StatusStrip"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Numbers of subscribers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(415, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Numbers of reservations"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Open Sans Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 28)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Earnings of subscriptions"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Open Sans Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(416, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 28)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Earnings of reservations"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkGray
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Open Sans Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(770, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 28)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total checked in"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkGray
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Open Sans Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(783, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 28)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Total earnings"
        '
        'lab_subs_num
        '
        Me.lab_subs_num.AutoSize = True
        Me.lab_subs_num.BackColor = System.Drawing.Color.DarkGray
        Me.lab_subs_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lab_subs_num.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_subs_num.Location = New System.Drawing.Point(130, 210)
        Me.lab_subs_num.Name = "lab_subs_num"
        Me.lab_subs_num.Size = New System.Drawing.Size(79, 28)
        Me.lab_subs_num.TabIndex = 18
        Me.lab_subs_num.Text = "Label7"
        '
        'lab_subearnings
        '
        Me.lab_subearnings.AutoSize = True
        Me.lab_subearnings.BackColor = System.Drawing.Color.DarkGray
        Me.lab_subearnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lab_subearnings.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_subearnings.Location = New System.Drawing.Point(130, 421)
        Me.lab_subearnings.Name = "lab_subearnings"
        Me.lab_subearnings.Size = New System.Drawing.Size(79, 28)
        Me.lab_subearnings.TabIndex = 19
        Me.lab_subearnings.Text = "Label8"
        '
        'Lab_resnumber
        '
        Me.Lab_resnumber.AutoSize = True
        Me.Lab_resnumber.BackColor = System.Drawing.Color.DarkGray
        Me.Lab_resnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_resnumber.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_resnumber.Location = New System.Drawing.Point(507, 210)
        Me.Lab_resnumber.Name = "Lab_resnumber"
        Me.Lab_resnumber.Size = New System.Drawing.Size(79, 28)
        Me.Lab_resnumber.TabIndex = 20
        Me.Lab_resnumber.Text = "Label9"
        '
        'Lab_researnings
        '
        Me.Lab_researnings.AutoSize = True
        Me.Lab_researnings.BackColor = System.Drawing.Color.DarkGray
        Me.Lab_researnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_researnings.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_researnings.Location = New System.Drawing.Point(501, 421)
        Me.Lab_researnings.Name = "Lab_researnings"
        Me.Lab_researnings.Size = New System.Drawing.Size(91, 28)
        Me.Lab_researnings.TabIndex = 21
        Me.Lab_researnings.Text = "Label10"
        '
        'Lab_totalcheckin
        '
        Me.Lab_totalcheckin.AutoSize = True
        Me.Lab_totalcheckin.BackColor = System.Drawing.Color.DarkGray
        Me.Lab_totalcheckin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_totalcheckin.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_totalcheckin.Location = New System.Drawing.Point(826, 210)
        Me.Lab_totalcheckin.Name = "Lab_totalcheckin"
        Me.Lab_totalcheckin.Size = New System.Drawing.Size(91, 28)
        Me.Lab_totalcheckin.TabIndex = 22
        Me.Lab_totalcheckin.Text = "Label11"
        '
        'Lab_totalearnings
        '
        Me.Lab_totalearnings.AutoSize = True
        Me.Lab_totalearnings.BackColor = System.Drawing.Color.DarkGray
        Me.Lab_totalearnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_totalearnings.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_totalearnings.Location = New System.Drawing.Point(826, 421)
        Me.Lab_totalearnings.Name = "Lab_totalearnings"
        Me.Lab_totalearnings.Size = New System.Drawing.Size(91, 28)
        Me.Lab_totalearnings.TabIndex = 23
        Me.Lab_totalearnings.Text = "Label12"
        '
        'EmployersToolStripMenuItem
        '
        Me.EmployersToolStripMenuItem.Name = "EmployersToolStripMenuItem"
        Me.EmployersToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.EmployersToolStripMenuItem.Text = "&Employers"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gray
        Me.PictureBox2.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.unnamed
        Me.PictureBox2.Location = New System.Drawing.Point(478, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(130, 101)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.sdgfdgvc
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1014, 502)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'MDI_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1014, 502)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Lab_totalearnings)
        Me.Controls.Add(Me.Lab_totalcheckin)
        Me.Controls.Add(Me.Lab_researnings)
        Me.Controls.Add(Me.Lab_resnumber)
        Me.Controls.Add(Me.lab_subearnings)
        Me.Controls.Add(Me.lab_subs_num)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MDI_Home"
        Me.Text = "Smart Park - Parking Made Easy - DashBoard"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents CheckinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubscribersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SELFCHECKINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Lab_loggeduser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lab_subs_num As System.Windows.Forms.Label
    Friend WithEvents lab_subearnings As System.Windows.Forms.Label
    Friend WithEvents Lab_resnumber As System.Windows.Forms.Label
    Friend WithEvents Lab_researnings As System.Windows.Forms.Label
    Friend WithEvents Lab_totalcheckin As System.Windows.Forms.Label
    Friend WithEvents Lab_totalearnings As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents EmployersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
