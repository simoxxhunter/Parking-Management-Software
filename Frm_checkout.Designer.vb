<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_checkout
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
        Me.But_lostticket = New System.Windows.Forms.Button()
        Me.But_reset = New System.Windows.Forms.Button()
        Me.txt_class_type = New System.Windows.Forms.TextBox()
        Me.txt_vehtype = New System.Windows.Forms.TextBox()
        Me.But_printcheckout = New System.Windows.Forms.Button()
        Me.txt_plateno = New System.Windows.Forms.TextBox()
        Me.txt_ticketno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBcheckinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_gestion_parkingDataSet1 = New PFE2023_Gestionparking.BD_gestion_parkingDataSet1()
        Me.Lab_Loggeduser = New System.Windows.Forms.Label()
        Me.Lab_Date_time = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_checkindatetime = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_checkinTableAdapter1 = New PFE2023_Gestionparking.BD_gestion_parkingDataSet1TableAdapters.TB_checkinTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.But_managereservations = New System.Windows.Forms.Button()
        Me.But_Logout = New System.Windows.Forms.Button()
        Me.But_logs = New System.Windows.Forms.Button()
        Me.But_managesubs = New System.Windows.Forms.Button()
        Me.But_checkout = New System.Windows.Forms.Button()
        Me.But_checkin = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBcheckinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_gestion_parkingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'But_lostticket
        '
        Me.But_lostticket.Location = New System.Drawing.Point(12, 407)
        Me.But_lostticket.Name = "But_lostticket"
        Me.But_lostticket.Size = New System.Drawing.Size(52, 44)
        Me.But_lostticket.TabIndex = 16
        Me.But_lostticket.Text = "Lost Ticket"
        Me.But_lostticket.UseVisualStyleBackColor = True
        '
        'But_reset
        '
        Me.But_reset.Location = New System.Drawing.Point(126, 407)
        Me.But_reset.Name = "But_reset"
        Me.But_reset.Size = New System.Drawing.Size(142, 44)
        Me.But_reset.TabIndex = 12
        Me.But_reset.Text = "Reset"
        Me.But_reset.UseVisualStyleBackColor = True
        '
        'txt_class_type
        '
        Me.txt_class_type.Location = New System.Drawing.Point(301, 218)
        Me.txt_class_type.Name = "txt_class_type"
        Me.txt_class_type.Size = New System.Drawing.Size(172, 20)
        Me.txt_class_type.TabIndex = 10
        '
        'txt_vehtype
        '
        Me.txt_vehtype.Location = New System.Drawing.Point(301, 163)
        Me.txt_vehtype.Name = "txt_vehtype"
        Me.txt_vehtype.Size = New System.Drawing.Size(172, 20)
        Me.txt_vehtype.TabIndex = 9
        '
        'But_printcheckout
        '
        Me.But_printcheckout.Location = New System.Drawing.Point(331, 407)
        Me.But_printcheckout.Name = "But_printcheckout"
        Me.But_printcheckout.Size = New System.Drawing.Size(142, 44)
        Me.But_printcheckout.TabIndex = 13
        Me.But_printcheckout.Text = "Print bill"
        Me.But_printcheckout.UseVisualStyleBackColor = True
        '
        'txt_plateno
        '
        Me.txt_plateno.Location = New System.Drawing.Point(301, 280)
        Me.txt_plateno.Name = "txt_plateno"
        Me.txt_plateno.Size = New System.Drawing.Size(172, 20)
        Me.txt_plateno.TabIndex = 11
        '
        'txt_ticketno
        '
        Me.txt_ticketno.Location = New System.Drawing.Point(301, 106)
        Me.txt_ticketno.Name = "txt_ticketno"
        Me.txt_ticketno.Size = New System.Drawing.Size(172, 20)
        Me.txt_ticketno.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Plate N°"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Class type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Vahicle type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ticket  N° "
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DataGridView1.DataSource = Me.TBcheckinBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(593, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(395, 464)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ticket_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ticket_ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "vehicle_type"
        Me.DataGridViewTextBoxColumn6.HeaderText = "vehicle_type"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Class_type"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Class_type"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Plate_number"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Plate_number"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Checkin_date_and_time"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Checkin_date_and_time"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'TBcheckinBindingSource
        '
        Me.TBcheckinBindingSource.DataMember = "TB_checkin"
        Me.TBcheckinBindingSource.DataSource = Me.BD_gestion_parkingDataSet1
        '
        'BD_gestion_parkingDataSet1
        '
        Me.BD_gestion_parkingDataSet1.DataSetName = "BD_gestion_parkingDataSet1"
        Me.BD_gestion_parkingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lab_Loggeduser
        '
        Me.Lab_Loggeduser.AutoSize = True
        Me.Lab_Loggeduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Loggeduser.Location = New System.Drawing.Point(3, 475)
        Me.Lab_Loggeduser.Name = "Lab_Loggeduser"
        Me.Lab_Loggeduser.Size = New System.Drawing.Size(105, 18)
        Me.Lab_Loggeduser.TabIndex = 18
        Me.Lab_Loggeduser.Text = "Logged_user"
        '
        'Lab_Date_time
        '
        Me.Lab_Date_time.AutoSize = True
        Me.Lab_Date_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Date_time.Location = New System.Drawing.Point(603, 475)
        Me.Lab_Date_time.Name = "Lab_Date_time"
        Me.Lab_Date_time.Size = New System.Drawing.Size(67, 18)
        Me.Lab_Date_time.TabIndex = 19
        Me.Lab_Date_time.Text = "Date&time"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 476)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1317, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.txt_checkindatetime)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.But_lostticket)
        Me.Panel2.Controls.Add(Me.But_printcheckout)
        Me.Panel2.Controls.Add(Me.But_reset)
        Me.Panel2.Controls.Add(Me.txt_plateno)
        Me.Panel2.Controls.Add(Me.txt_class_type)
        Me.Panel2.Controls.Add(Me.txt_vehtype)
        Me.Panel2.Controls.Add(Me.txt_ticketno)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(329, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(988, 471)
        Me.Panel2.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(255, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'txt_checkindatetime
        '
        Me.txt_checkindatetime.Location = New System.Drawing.Point(301, 336)
        Me.txt_checkindatetime.Name = "txt_checkindatetime"
        Me.txt_checkindatetime.Size = New System.Drawing.Size(172, 20)
        Me.txt_checkindatetime.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(123, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Check-in date and time"
        '
        'TB_checkinTableAdapter1
        '
        Me.TB_checkinTableAdapter1.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PFE2023_Gestionparking.My.Resources.Resources.color
        Me.Panel1.Controls.Add(Me.But_managereservations)
        Me.Panel1.Controls.Add(Me.But_Logout)
        Me.Panel1.Controls.Add(Me.But_logs)
        Me.Panel1.Controls.Add(Me.But_managesubs)
        Me.Panel1.Controls.Add(Me.But_checkout)
        Me.Panel1.Controls.Add(Me.But_checkin)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 477)
        Me.Panel1.TabIndex = 20
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
        Me.But_Logout.Size = New System.Drawing.Size(309, 79)
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
        Me.But_logs.Text = "self checkin"
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
        Me.But_checkout.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.But_checkout.Font = New System.Drawing.Font("Calibri", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_checkout.Location = New System.Drawing.Point(6, 84)
        Me.But_checkout.Name = "But_checkout"
        Me.But_checkout.Size = New System.Drawing.Size(309, 70)
        Me.But_checkout.TabIndex = 1
        Me.But_checkout.Text = "Check-out"
        Me.But_checkout.UseVisualStyleBackColor = False
        '
        'But_checkin
        '
        Me.But_checkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.But_checkin.Font = New System.Drawing.Font("Calibri", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_checkin.Location = New System.Drawing.Point(6, 9)
        Me.But_checkin.Name = "But_checkin"
        Me.But_checkin.Size = New System.Drawing.Size(309, 69)
        Me.But_checkin.TabIndex = 0
        Me.But_checkin.Text = "Check-in"
        Me.But_checkin.UseVisualStyleBackColor = False
        '
        'Frm_checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 498)
        Me.Controls.Add(Me.Lab_Loggeduser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lab_Date_time)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_checkout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart park - Parking Made Easy"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBcheckinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_gestion_parkingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents But_lostticket As System.Windows.Forms.Button
    Friend WithEvents But_reset As System.Windows.Forms.Button
    Friend WithEvents txt_class_type As System.Windows.Forms.TextBox
    Friend WithEvents txt_vehtype As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents But_managereservations As System.Windows.Forms.Button
    Friend WithEvents But_Logout As System.Windows.Forms.Button
    Friend WithEvents But_logs As System.Windows.Forms.Button
    Friend WithEvents But_managesubs As System.Windows.Forms.Button
    Friend WithEvents But_checkout As System.Windows.Forms.Button
    Friend WithEvents But_checkin As System.Windows.Forms.Button
    Friend WithEvents But_printcheckout As System.Windows.Forms.Button
    Friend WithEvents txt_plateno As System.Windows.Forms.TextBox
    Friend WithEvents txt_ticketno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Lab_Loggeduser As System.Windows.Forms.Label
    Friend WithEvents Lab_Date_time As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

    Friend WithEvents TicketIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClasstypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlatenumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckindateandtimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicletypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BD_gestion_parkingDataSet1 As PFE2023_Gestionparking.BD_gestion_parkingDataSet1
    Friend WithEvents TBcheckinBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_checkinTableAdapter1 As PFE2023_Gestionparking.BD_gestion_parkingDataSet1TableAdapters.TB_checkinTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_checkindatetime As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
