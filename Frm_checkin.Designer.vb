<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_checkin
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBcheckinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_gestion_parkingDataSet11 = New PFE2023_Gestionparking.BD_gestion_parkingDataSet1()
        Me.Txt_plateNO = New System.Windows.Forms.TextBox()
        Me.Cmb_vehtype = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Cmb_classtype = New System.Windows.Forms.ComboBox()
        Me.But_print_ticket = New System.Windows.Forms.Button()
        Me.But_reset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lab_Date_time = New System.Windows.Forms.Label()
        Me.Lab_Loggeduser = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TB_checkinTableAdapter2 = New PFE2023_Gestionparking.BD_gestion_parkingDataSet1TableAdapters.TB_checkinTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.But_managereservations = New System.Windows.Forms.Button()
        Me.But_Logout = New System.Windows.Forms.Button()
        Me.But_logs = New System.Windows.Forms.Button()
        Me.But_managesubs = New System.Windows.Forms.Button()
        Me.But_checkout = New System.Windows.Forms.Button()
        Me.But_checkin = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBcheckinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_gestion_parkingDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Plate Number"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.DataGridView1.DataSource = Me.TBcheckinBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(541, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(442, 465)
        Me.DataGridView1.TabIndex = 26
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Ticket_ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ticket_ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "vehicle_type"
        Me.DataGridViewTextBoxColumn7.HeaderText = "vehicle_type"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Class_type"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Class_type"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Plate_number"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Plate_number"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Checkin_date_and_time"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Checkin_date_and_time"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'TBcheckinBindingSource
        '
        Me.TBcheckinBindingSource.DataMember = "TB_checkin"
        Me.TBcheckinBindingSource.DataSource = Me.BD_gestion_parkingDataSet11
        '
        'BD_gestion_parkingDataSet11
        '
        Me.BD_gestion_parkingDataSet11.DataSetName = "BD_gestion_parkingDataSet1"
        Me.BD_gestion_parkingDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Txt_plateNO
        '
        Me.Txt_plateNO.Location = New System.Drawing.Point(316, 233)
        Me.Txt_plateNO.Name = "Txt_plateNO"
        Me.Txt_plateNO.Size = New System.Drawing.Size(172, 20)
        Me.Txt_plateNO.TabIndex = 28
        Me.Txt_plateNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cmb_vehtype
        '
        Me.Cmb_vehtype.FormattingEnabled = True
        Me.Cmb_vehtype.Items.AddRange(New Object() {"Car", "Bike", "Van"})
        Me.Cmb_vehtype.Location = New System.Drawing.Point(316, 79)
        Me.Cmb_vehtype.Name = "Cmb_vehtype"
        Me.Cmb_vehtype.Size = New System.Drawing.Size(172, 21)
        Me.Cmb_vehtype.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Txt_plateNO)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Cmb_classtype)
        Me.Panel2.Controls.Add(Me.Cmb_vehtype)
        Me.Panel2.Controls.Add(Me.But_print_ticket)
        Me.Panel2.Controls.Add(Me.But_reset)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(329, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(986, 471)
        Me.Panel2.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(246, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Cmb_classtype
        '
        Me.Cmb_classtype.FormattingEnabled = True
        Me.Cmb_classtype.Items.AddRange(New Object() {"1 ére class", "2 éme class", "Speciale"})
        Me.Cmb_classtype.Location = New System.Drawing.Point(316, 155)
        Me.Cmb_classtype.Name = "Cmb_classtype"
        Me.Cmb_classtype.Size = New System.Drawing.Size(172, 21)
        Me.Cmb_classtype.TabIndex = 25
        '
        'But_print_ticket
        '
        Me.But_print_ticket.Location = New System.Drawing.Point(316, 327)
        Me.But_print_ticket.Name = "But_print_ticket"
        Me.But_print_ticket.Size = New System.Drawing.Size(172, 44)
        Me.But_print_ticket.TabIndex = 23
        Me.But_print_ticket.Text = "Print Ticket" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.But_print_ticket.UseVisualStyleBackColor = True
        '
        'But_reset
        '
        Me.But_reset.Location = New System.Drawing.Point(100, 327)
        Me.But_reset.Name = "But_reset"
        Me.But_reset.Size = New System.Drawing.Size(160, 44)
        Me.But_reset.TabIndex = 22
        Me.But_reset.Text = "Reset"
        Me.But_reset.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Class type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Vehicle type"
        '
        'Lab_Date_time
        '
        Me.Lab_Date_time.AutoSize = True
        Me.Lab_Date_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Date_time.Location = New System.Drawing.Point(583, 473)
        Me.Lab_Date_time.Name = "Lab_Date_time"
        Me.Lab_Date_time.Size = New System.Drawing.Size(67, 18)
        Me.Lab_Date_time.TabIndex = 14
        Me.Lab_Date_time.Text = "Date&time"
        '
        'Lab_Loggeduser
        '
        Me.Lab_Loggeduser.AutoSize = True
        Me.Lab_Loggeduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Loggeduser.Location = New System.Drawing.Point(3, 473)
        Me.Lab_Loggeduser.Name = "Lab_Loggeduser"
        Me.Lab_Loggeduser.Size = New System.Drawing.Size(105, 18)
        Me.Lab_Loggeduser.TabIndex = 13
        Me.Lab_Loggeduser.Text = "Logged_user"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 476)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1317, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TB_checkinTableAdapter2
        '
        Me.TB_checkinTableAdapter2.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel1.BackgroundImage = Global.PFE2023_Gestionparking.My.Resources.Resources.color
        Me.Panel1.Controls.Add(Me.But_managereservations)
        Me.Panel1.Controls.Add(Me.But_Logout)
        Me.Panel1.Controls.Add(Me.But_logs)
        Me.Panel1.Controls.Add(Me.But_managesubs)
        Me.Panel1.Controls.Add(Me.But_checkout)
        Me.Panel1.Controls.Add(Me.But_checkin)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 473)
        Me.Panel1.TabIndex = 15
        '
        'But_managereservations
        '
        Me.But_managereservations.Font = New System.Drawing.Font("Calibri", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_managereservations.Location = New System.Drawing.Point(6, 238)
        Me.But_managereservations.Name = "But_managereservations"
        Me.But_managereservations.Size = New System.Drawing.Size(309, 70)
        Me.But_managereservations.TabIndex = 4
        Me.But_managereservations.Text = "Manage &Reservations"
        Me.But_managereservations.UseVisualStyleBackColor = True
        '
        'But_Logout
        '
        Me.But_Logout.Font = New System.Drawing.Font("Calibri", 15.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Logout.Location = New System.Drawing.Point(6, 391)
        Me.But_Logout.Name = "But_Logout"
        Me.But_Logout.Size = New System.Drawing.Size(309, 70)
        Me.But_Logout.TabIndex = 6
        Me.But_Logout.Text = "Logout"
        Me.But_Logout.UseVisualStyleBackColor = True
        '
        'But_logs
        '
        Me.But_logs.Font = New System.Drawing.Font("Calibri", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_logs.Location = New System.Drawing.Point(6, 314)
        Me.But_logs.Name = "But_logs"
        Me.But_logs.Size = New System.Drawing.Size(309, 71)
        Me.But_logs.TabIndex = 5
        Me.But_logs.Text = "Self checkin"
        Me.But_logs.UseVisualStyleBackColor = True
        '
        'But_managesubs
        '
        Me.But_managesubs.Font = New System.Drawing.Font("Calibri", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_managesubs.Location = New System.Drawing.Point(6, 160)
        Me.But_managesubs.Name = "But_managesubs"
        Me.But_managesubs.Size = New System.Drawing.Size(309, 72)
        Me.But_managesubs.TabIndex = 3
        Me.But_managesubs.Text = "Manage &Subscriptions"
        Me.But_managesubs.UseVisualStyleBackColor = True
        '
        'But_checkout
        '
        Me.But_checkout.Font = New System.Drawing.Font("Calibri", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_checkout.Location = New System.Drawing.Point(6, 84)
        Me.But_checkout.Name = "But_checkout"
        Me.But_checkout.Size = New System.Drawing.Size(309, 70)
        Me.But_checkout.TabIndex = 1
        Me.But_checkout.Text = "Check-out"
        Me.But_checkout.UseVisualStyleBackColor = True
        '
        'But_checkin
        '
        Me.But_checkin.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.But_checkin.Font = New System.Drawing.Font("Calibri", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_checkin.Location = New System.Drawing.Point(6, 9)
        Me.But_checkin.Name = "But_checkin"
        Me.But_checkin.Size = New System.Drawing.Size(309, 69)
        Me.But_checkin.TabIndex = 0
        Me.But_checkin.Text = "Check-in"
        Me.But_checkin.UseVisualStyleBackColor = False
        '
        'Frm_checkin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 498)
        Me.Controls.Add(Me.Lab_Date_time)
        Me.Controls.Add(Me.Lab_Loggeduser)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Frm_checkin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check-in Smart park - Parking Made Easy"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBcheckinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_gestion_parkingDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents But_checkin As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_plateNO As System.Windows.Forms.TextBox
    Friend WithEvents But_managereservations As System.Windows.Forms.Button
    Friend WithEvents Cmb_vehtype As System.Windows.Forms.ComboBox
    Friend WithEvents But_Logout As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Cmb_classtype As System.Windows.Forms.ComboBox
    Friend WithEvents But_print_ticket As System.Windows.Forms.Button
    Friend WithEvents But_reset As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents But_logs As System.Windows.Forms.Button
    Friend WithEvents But_managesubs As System.Windows.Forms.Button
    Friend WithEvents But_checkout As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lab_Date_time As System.Windows.Forms.Label
    Friend WithEvents Lab_Loggeduser As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    
    Friend WithEvents TicketIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicletypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClasstypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlatenumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckindateandtimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
   
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BD_gestion_parkingDataSet11 As PFE2023_Gestionparking.BD_gestion_parkingDataSet1
    Friend WithEvents TBcheckinBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_checkinTableAdapter2 As PFE2023_Gestionparking.BD_gestion_parkingDataSet1TableAdapters.TB_checkinTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
