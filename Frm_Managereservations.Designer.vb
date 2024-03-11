<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Managereservations
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.But_edit = New System.Windows.Forms.Button()
        Me.But_print_reservation = New System.Windows.Forms.Button()
        Me.But_reset = New System.Windows.Forms.Button()
        Me.datetime_resenddate = New System.Windows.Forms.DateTimePicker()
        Me.datetime_resstartdate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cmb_classtype = New System.Windows.Forms.ComboBox()
        Me.Cmb_cartype = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_fullname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_nmatricule = New System.Windows.Forms.TextBox()
        Me.Txt_nres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Lab_Date_time = New System.Windows.Forms.Label()
        Me.Lab_Loggeduser = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NReservationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPlateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicletypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClasstypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPayerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBReservationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_gestion_parkingDataSet1 = New PFE2023_Gestionparking.BD_gestion_parkingDataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TB_ReservationsTableAdapter = New PFE2023_Gestionparking.BD_gestion_parkingDataSet1TableAdapters.TB_ReservationsTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.But_managereservations = New System.Windows.Forms.Button()
        Me.But_Logout = New System.Windows.Forms.Button()
        Me.But_logs = New System.Windows.Forms.Button()
        Me.But_managesubs = New System.Windows.Forms.Button()
        Me.But_checkout = New System.Windows.Forms.Button()
        Me.But_checkin = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBReservationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_gestion_parkingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(128, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Date Début"
        '
        'But_edit
        '
        Me.But_edit.Location = New System.Drawing.Point(33, 408)
        Me.But_edit.Name = "But_edit"
        Me.But_edit.Size = New System.Drawing.Size(142, 44)
        Me.But_edit.TabIndex = 32
        Me.But_edit.Text = "Edit"
        Me.But_edit.UseVisualStyleBackColor = True
        '
        'But_print_reservation
        '
        Me.But_print_reservation.Location = New System.Drawing.Point(445, 408)
        Me.But_print_reservation.Name = "But_print_reservation"
        Me.But_print_reservation.Size = New System.Drawing.Size(142, 44)
        Me.But_print_reservation.TabIndex = 31
        Me.But_print_reservation.Text = "Print Reservation Bill"
        Me.But_print_reservation.UseVisualStyleBackColor = True
        '
        'But_reset
        '
        Me.But_reset.Location = New System.Drawing.Point(239, 408)
        Me.But_reset.Name = "But_reset"
        Me.But_reset.Size = New System.Drawing.Size(142, 44)
        Me.But_reset.TabIndex = 30
        Me.But_reset.Text = "Reset"
        Me.But_reset.UseVisualStyleBackColor = True
        '
        'datetime_resenddate
        '
        Me.datetime_resenddate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetime_resenddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetime_resenddate.Location = New System.Drawing.Point(306, 343)
        Me.datetime_resenddate.Name = "datetime_resenddate"
        Me.datetime_resenddate.Size = New System.Drawing.Size(172, 20)
        Me.datetime_resenddate.TabIndex = 36
        '
        'datetime_resstartdate
        '
        Me.datetime_resstartdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetime_resstartdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetime_resstartdate.Location = New System.Drawing.Point(306, 305)
        Me.datetime_resstartdate.Name = "datetime_resstartdate"
        Me.datetime_resstartdate.Size = New System.Drawing.Size(172, 20)
        Me.datetime_resstartdate.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(128, 349)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Date Fin"
        '
        'Cmb_classtype
        '
        Me.Cmb_classtype.FormattingEnabled = True
        Me.Cmb_classtype.Items.AddRange(New Object() {"First Class", "Second Class", "Special Needs"})
        Me.Cmb_classtype.Location = New System.Drawing.Point(306, 272)
        Me.Cmb_classtype.Name = "Cmb_classtype"
        Me.Cmb_classtype.Size = New System.Drawing.Size(172, 21)
        Me.Cmb_classtype.TabIndex = 29
        '
        'Cmb_cartype
        '
        Me.Cmb_cartype.FormattingEnabled = True
        Me.Cmb_cartype.Items.AddRange(New Object() {"automobile", "moto", "van" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.Cmb_cartype.Location = New System.Drawing.Point(306, 234)
        Me.Cmb_cartype.Name = "Cmb_cartype"
        Me.Cmb_cartype.Size = New System.Drawing.Size(172, 21)
        Me.Cmb_cartype.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Class type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(128, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Vehicle type"
        '
        'Txt_fullname
        '
        Me.Txt_fullname.Location = New System.Drawing.Point(306, 197)
        Me.Txt_fullname.Name = "Txt_fullname"
        Me.Txt_fullname.Size = New System.Drawing.Size(172, 20)
        Me.Txt_fullname.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Nom-prenom"
        '
        'Txt_nmatricule
        '
        Me.Txt_nmatricule.Location = New System.Drawing.Point(306, 164)
        Me.Txt_nmatricule.Name = "Txt_nmatricule"
        Me.Txt_nmatricule.Size = New System.Drawing.Size(172, 20)
        Me.Txt_nmatricule.TabIndex = 23
        '
        'Txt_nres
        '
        Me.Txt_nres.Location = New System.Drawing.Point(306, 123)
        Me.Txt_nres.Name = "Txt_nres"
        Me.Txt_nres.Size = New System.Drawing.Size(172, 20)
        Me.Txt_nres.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "N° Plate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "N° Reservation"
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
        'Lab_Date_time
        '
        Me.Lab_Date_time.AutoSize = True
        Me.Lab_Date_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Date_time.Location = New System.Drawing.Point(603, 473)
        Me.Lab_Date_time.Name = "Lab_Date_time"
        Me.Lab_Date_time.Size = New System.Drawing.Size(67, 18)
        Me.Lab_Date_time.TabIndex = 19
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
        Me.Lab_Loggeduser.TabIndex = 18
        Me.Lab_Loggeduser.Text = "Logged_user"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.datetime_resenddate)
        Me.Panel2.Controls.Add(Me.datetime_resstartdate)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.But_edit)
        Me.Panel2.Controls.Add(Me.But_print_reservation)
        Me.Panel2.Controls.Add(Me.But_reset)
        Me.Panel2.Controls.Add(Me.Cmb_classtype)
        Me.Panel2.Controls.Add(Me.Cmb_cartype)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Txt_fullname)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Txt_nmatricule)
        Me.Panel2.Controls.Add(Me.Txt_nres)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(329, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(988, 471)
        Me.Panel2.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(267, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NReservationDataGridViewTextBoxColumn, Me.NPlateDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.VehicletypeDataGridViewTextBoxColumn, Me.ClasstypeDataGridViewTextBoxColumn, Me.StartDateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn, Me.TotalPayerDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TBReservationsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(604, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(384, 464)
        Me.DataGridView1.TabIndex = 37
        '
        'NReservationDataGridViewTextBoxColumn
        '
        Me.NReservationDataGridViewTextBoxColumn.DataPropertyName = "N_Reservation"
        Me.NReservationDataGridViewTextBoxColumn.HeaderText = "N_Reservation"
        Me.NReservationDataGridViewTextBoxColumn.Name = "NReservationDataGridViewTextBoxColumn"
        '
        'NPlateDataGridViewTextBoxColumn
        '
        Me.NPlateDataGridViewTextBoxColumn.DataPropertyName = "N_Plate"
        Me.NPlateDataGridViewTextBoxColumn.HeaderText = "N_Plate"
        Me.NPlateDataGridViewTextBoxColumn.Name = "NPlateDataGridViewTextBoxColumn"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Full_Name"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'VehicletypeDataGridViewTextBoxColumn
        '
        Me.VehicletypeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_type"
        Me.VehicletypeDataGridViewTextBoxColumn.HeaderText = "Vehicle_type"
        Me.VehicletypeDataGridViewTextBoxColumn.Name = "VehicletypeDataGridViewTextBoxColumn"
        '
        'ClasstypeDataGridViewTextBoxColumn
        '
        Me.ClasstypeDataGridViewTextBoxColumn.DataPropertyName = "Class_type"
        Me.ClasstypeDataGridViewTextBoxColumn.HeaderText = "Class_type"
        Me.ClasstypeDataGridViewTextBoxColumn.Name = "ClasstypeDataGridViewTextBoxColumn"
        '
        'StartDateDataGridViewTextBoxColumn
        '
        Me.StartDateDataGridViewTextBoxColumn.DataPropertyName = "Start_Date"
        Me.StartDateDataGridViewTextBoxColumn.HeaderText = "Start_Date"
        Me.StartDateDataGridViewTextBoxColumn.Name = "StartDateDataGridViewTextBoxColumn"
        '
        'EndDateDataGridViewTextBoxColumn
        '
        Me.EndDateDataGridViewTextBoxColumn.DataPropertyName = "End_Date"
        Me.EndDateDataGridViewTextBoxColumn.HeaderText = "End_Date"
        Me.EndDateDataGridViewTextBoxColumn.Name = "EndDateDataGridViewTextBoxColumn"
        '
        'TotalPayerDataGridViewTextBoxColumn
        '
        Me.TotalPayerDataGridViewTextBoxColumn.DataPropertyName = "Total_Payer"
        Me.TotalPayerDataGridViewTextBoxColumn.HeaderText = "Total_Payer"
        Me.TotalPayerDataGridViewTextBoxColumn.Name = "TotalPayerDataGridViewTextBoxColumn"
        '
        'TBReservationsBindingSource
        '
        Me.TBReservationsBindingSource.DataMember = "TB_Reservations"
        Me.TBReservationsBindingSource.DataSource = Me.BD_gestion_parkingDataSet1
        '
        'BD_gestion_parkingDataSet1
        '
        Me.BD_gestion_parkingDataSet1.DataSetName = "BD_gestion_parkingDataSet1"
        Me.BD_gestion_parkingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 476)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Logged_user"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(603, 472)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Date&time"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TB_ReservationsTableAdapter
        '
        Me.TB_ReservationsTableAdapter.ClearBeforeFill = True
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
        Me.But_managereservations.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.But_managereservations.Font = New System.Drawing.Font("Calibri", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_managereservations.Location = New System.Drawing.Point(6, 238)
        Me.But_managereservations.Name = "But_managereservations"
        Me.But_managereservations.Size = New System.Drawing.Size(309, 70)
        Me.But_managereservations.TabIndex = 4
        Me.But_managereservations.Text = "Manage &Reservations"
        Me.But_managereservations.UseVisualStyleBackColor = False
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
        Me.But_logs.Text = "Self_checkin"
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
        Me.But_checkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.But_checkin.Font = New System.Drawing.Font("Calibri", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_checkin.Location = New System.Drawing.Point(6, 9)
        Me.But_checkin.Name = "But_checkin"
        Me.But_checkin.Size = New System.Drawing.Size(309, 69)
        Me.But_checkin.TabIndex = 0
        Me.But_checkin.Text = "Check-in"
        Me.But_checkin.UseVisualStyleBackColor = False
        '
        'Frm_Managereservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 498)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Lab_Date_time)
        Me.Controls.Add(Me.Lab_Loggeduser)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_Managereservations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart park - Parking Made Easy"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBReservationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_gestion_parkingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents But_edit As System.Windows.Forms.Button
    Friend WithEvents But_print_reservation As System.Windows.Forms.Button
    Friend WithEvents But_reset As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents But_managereservations As System.Windows.Forms.Button
    Friend WithEvents But_Logout As System.Windows.Forms.Button
    Friend WithEvents But_logs As System.Windows.Forms.Button
    Friend WithEvents But_managesubs As System.Windows.Forms.Button
    Friend WithEvents But_checkout As System.Windows.Forms.Button
    Friend WithEvents But_checkin As System.Windows.Forms.Button
    Friend WithEvents datetime_resenddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents datetime_resstartdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cmb_classtype As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_cartype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_fullname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_nmatricule As System.Windows.Forms.TextBox
    Friend WithEvents Txt_nres As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Lab_Date_time As System.Windows.Forms.Label
    Friend WithEvents Lab_Loggeduser As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BD_gestion_parkingDataSet1 As PFE2023_Gestionparking.BD_gestion_parkingDataSet1
    Friend WithEvents TBReservationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_ReservationsTableAdapter As PFE2023_Gestionparking.BD_gestion_parkingDataSet1TableAdapters.TB_ReservationsTableAdapter
    Friend WithEvents NReservationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPlateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicletypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClasstypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPayerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
