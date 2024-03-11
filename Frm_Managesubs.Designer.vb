<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Managesubs
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
        Me.But_deletesub = New System.Windows.Forms.Button()
        Me.datetime_resenddate = New System.Windows.Forms.DateTimePicker()
        Me.datetime_resstartdate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cmb_classtype = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Cmb_cartype = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_fullname = New System.Windows.Forms.TextBox()
        Me.Txt_sub = New System.Windows.Forms.TextBox()
        Me.Lab_Loggeduser = New System.Windows.Forms.Label()
        Me.But_reset = New System.Windows.Forms.Button()
        Me.But_edit = New System.Windows.Forms.Button()
        Me.But_print_subscription = New System.Windows.Forms.Button()
        Me.Lab_Date_time = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_nmatricule = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.But_managereservations = New System.Windows.Forms.Button()
        Me.But_Logout = New System.Windows.Forms.Button()
        Me.But_logs = New System.Windows.Forms.Button()
        Me.But_managesubs = New System.Windows.Forms.Button()
        Me.But_checkout = New System.Windows.Forms.Button()
        Me.But_checkin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBsubscriptionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_gestion_parkingDataSet1 = New PFE2023_Gestionparking.BD_gestion_parkingDataSet1()
        Me.TB_subscriptionsTableAdapter = New PFE2023_Gestionparking.BD_gestion_parkingDataSet1TableAdapters.TB_subscriptionsTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBsubscriptionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_gestion_parkingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'But_deletesub
        '
        Me.But_deletesub.Location = New System.Drawing.Point(479, 411)
        Me.But_deletesub.Name = "But_deletesub"
        Me.But_deletesub.Size = New System.Drawing.Size(142, 44)
        Me.But_deletesub.TabIndex = 74
        Me.But_deletesub.Text = "Delete"
        Me.But_deletesub.UseVisualStyleBackColor = True
        '
        'datetime_resenddate
        '
        Me.datetime_resenddate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetime_resenddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetime_resenddate.Location = New System.Drawing.Point(189, 198)
        Me.datetime_resenddate.Name = "datetime_resenddate"
        Me.datetime_resenddate.Size = New System.Drawing.Size(172, 20)
        Me.datetime_resenddate.TabIndex = 73
        '
        'datetime_resstartdate
        '
        Me.datetime_resstartdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetime_resstartdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetime_resstartdate.Location = New System.Drawing.Point(189, 160)
        Me.datetime_resstartdate.Name = "datetime_resstartdate"
        Me.datetime_resstartdate.Size = New System.Drawing.Size(172, 20)
        Me.datetime_resstartdate.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "End Date "
        '
        'Cmb_classtype
        '
        Me.Cmb_classtype.FormattingEnabled = True
        Me.Cmb_classtype.Items.AddRange(New Object() {"First Class", "Second Class", "Special Needs"})
        Me.Cmb_classtype.Location = New System.Drawing.Point(189, 127)
        Me.Cmb_classtype.Name = "Cmb_classtype"
        Me.Cmb_classtype.Size = New System.Drawing.Size(172, 21)
        Me.Cmb_classtype.TabIndex = 69
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Start Date"
        '
        'Cmb_cartype
        '
        Me.Cmb_cartype.FormattingEnabled = True
        Me.Cmb_cartype.Items.AddRange(New Object() {"Car", "bike", "Van" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.Cmb_cartype.Location = New System.Drawing.Point(189, 89)
        Me.Cmb_cartype.Name = "Cmb_cartype"
        Me.Cmb_cartype.Size = New System.Drawing.Size(172, 21)
        Me.Cmb_cartype.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Class type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Vehicle type"
        '
        'Txt_fullname
        '
        Me.Txt_fullname.Location = New System.Drawing.Point(189, 52)
        Me.Txt_fullname.Name = "Txt_fullname"
        Me.Txt_fullname.Size = New System.Drawing.Size(172, 20)
        Me.Txt_fullname.TabIndex = 65
        '
        'Txt_sub
        '
        Me.Txt_sub.Location = New System.Drawing.Point(189, 12)
        Me.Txt_sub.Name = "Txt_sub"
        Me.Txt_sub.Size = New System.Drawing.Size(172, 20)
        Me.Txt_sub.TabIndex = 62
        '
        'Lab_Loggeduser
        '
        Me.Lab_Loggeduser.AutoSize = True
        Me.Lab_Loggeduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Loggeduser.Location = New System.Drawing.Point(3, 473)
        Me.Lab_Loggeduser.Name = "Lab_Loggeduser"
        Me.Lab_Loggeduser.Size = New System.Drawing.Size(105, 18)
        Me.Lab_Loggeduser.TabIndex = 18
        Me.Lab_Loggeduser.Text = "Logged_user"
        '
        'But_reset
        '
        Me.But_reset.Location = New System.Drawing.Point(151, 411)
        Me.But_reset.Name = "But_reset"
        Me.But_reset.Size = New System.Drawing.Size(142, 44)
        Me.But_reset.TabIndex = 52
        Me.But_reset.Text = "Reset"
        Me.But_reset.UseVisualStyleBackColor = True
        '
        'But_edit
        '
        Me.But_edit.Location = New System.Drawing.Point(3, 411)
        Me.But_edit.Name = "But_edit"
        Me.But_edit.Size = New System.Drawing.Size(142, 44)
        Me.But_edit.TabIndex = 54
        Me.But_edit.Text = "Modifier"
        Me.But_edit.UseVisualStyleBackColor = True
        '
        'But_print_subscription
        '
        Me.But_print_subscription.Location = New System.Drawing.Point(331, 411)
        Me.But_print_subscription.Name = "But_print_subscription"
        Me.But_print_subscription.Size = New System.Drawing.Size(142, 44)
        Me.But_print_subscription.TabIndex = 53
        Me.But_print_subscription.Text = "Print Subscription card"
        Me.But_print_subscription.UseVisualStyleBackColor = True
        '
        'Lab_Date_time
        '
        Me.Lab_Date_time.AutoSize = True
        Me.Lab_Date_time.BackColor = System.Drawing.Color.Transparent
        Me.Lab_Date_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Date_time.Location = New System.Drawing.Point(603, 473)
        Me.Lab_Date_time.Name = "Lab_Date_time"
        Me.Lab_Date_time.Size = New System.Drawing.Size(67, 18)
        Me.Lab_Date_time.TabIndex = 19
        Me.Lab_Date_time.Text = "Date&time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Full Name"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.But_deletesub)
        Me.Panel2.Controls.Add(Me.But_edit)
        Me.Panel2.Controls.Add(Me.But_print_subscription)
        Me.Panel2.Controls.Add(Me.But_reset)
        Me.Panel2.Location = New System.Drawing.Point(331, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(986, 471)
        Me.Panel2.TabIndex = 21
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.datetime_resenddate)
        Me.GroupBox2.Controls.Add(Me.datetime_resstartdate)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Cmb_classtype)
        Me.GroupBox2.Controls.Add(Me.Cmb_cartype)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Txt_fullname)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Txt_nmatricule)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(127, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 225)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        '
        'Txt_nmatricule
        '
        Me.Txt_nmatricule.Location = New System.Drawing.Point(189, 15)
        Me.Txt_nmatricule.Name = "Txt_nmatricule"
        Me.Txt_nmatricule.Size = New System.Drawing.Size(172, 20)
        Me.Txt_nmatricule.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Plate N°"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_sub)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(127, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 43)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Subscription N to edit"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView1.DataSource = Me.TBsubscriptionsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(627, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(356, 464)
        Me.DataGridView1.TabIndex = 59
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
        'Timer1
        '
        Me.Timer1.Enabled = True
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
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 473)
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
        Me.But_logs.Text = "Logs"
        Me.But_logs.UseVisualStyleBackColor = True
        '
        'But_managesubs
        '
        Me.But_managesubs.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.But_managesubs.Font = New System.Drawing.Font("Calibri", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_managesubs.Location = New System.Drawing.Point(6, 160)
        Me.But_managesubs.Name = "But_managesubs"
        Me.But_managesubs.Size = New System.Drawing.Size(309, 72)
        Me.But_managesubs.TabIndex = 3
        Me.But_managesubs.Text = "Manage &Subscriptions"
        Me.But_managesubs.UseVisualStyleBackColor = False
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
        Me.But_checkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.But_checkin.Font = New System.Drawing.Font("Calibri", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_checkin.Location = New System.Drawing.Point(6, 9)
        Me.But_checkin.Name = "But_checkin"
        Me.But_checkin.Size = New System.Drawing.Size(309, 69)
        Me.But_checkin.TabIndex = 0
        Me.But_checkin.Text = "Check-in"
        Me.But_checkin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(257, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "N_Subscription"
        Me.DataGridViewTextBoxColumn1.HeaderText = "N_Subscription"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "N_Plate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "N_Plate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Full_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Full_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Vehicle_type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Vehicle_type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Class_type"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Class_type"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Start_Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Start_Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "End_Date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "End_Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'TBsubscriptionsBindingSource
        '
        Me.TBsubscriptionsBindingSource.DataMember = "TB_subscriptions"
        Me.TBsubscriptionsBindingSource.DataSource = Me.BD_gestion_parkingDataSet1
        '
        'BD_gestion_parkingDataSet1
        '
        Me.BD_gestion_parkingDataSet1.DataSetName = "BD_gestion_parkingDataSet1"
        Me.BD_gestion_parkingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TB_subscriptionsTableAdapter
        '
        Me.TB_subscriptionsTableAdapter.ClearBeforeFill = True
        '
        'Frm_Managesubs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 498)
        Me.Controls.Add(Me.Lab_Loggeduser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lab_Date_time)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_Managesubs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart park - Parking Made Easy"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBsubscriptionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_gestion_parkingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents But_managereservations As System.Windows.Forms.Button
    Friend WithEvents But_Logout As System.Windows.Forms.Button
    Friend WithEvents But_logs As System.Windows.Forms.Button
    Friend WithEvents But_managesubs As System.Windows.Forms.Button
    Friend WithEvents But_checkout As System.Windows.Forms.Button
    Friend WithEvents But_checkin As System.Windows.Forms.Button
    Friend WithEvents But_deletesub As System.Windows.Forms.Button
    Friend WithEvents datetime_resenddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents datetime_resstartdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cmb_classtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Cmb_cartype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_fullname As System.Windows.Forms.TextBox
    Friend WithEvents Txt_sub As System.Windows.Forms.TextBox
    Friend WithEvents Lab_Loggeduser As System.Windows.Forms.Label
    Friend WithEvents But_reset As System.Windows.Forms.Button
    Friend WithEvents But_edit As System.Windows.Forms.Button
    Friend WithEvents But_print_subscription As System.Windows.Forms.Button
    Friend WithEvents Lab_Date_time As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents NSubscriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPlateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BD_gestion_parkingDataSet1 As PFE2023_Gestionparking.BD_gestion_parkingDataSet1
    Friend WithEvents TBsubscriptionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_subscriptionsTableAdapter As PFE2023_Gestionparking.BD_gestion_parkingDataSet1TableAdapters.TB_subscriptionsTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Txt_nmatricule As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
