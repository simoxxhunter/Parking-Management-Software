<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_print_checkin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_print_checkin))
        Me.lab_ticket_no = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lab_class_type = New System.Windows.Forms.Label()
        Me.Lab_ticket_time = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pict_vehicule = New System.Windows.Forms.PictureBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.but_print_ticket = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TicketidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClasstypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicletypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckindateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBticketscheckinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_gestion_parkingDataSet1 = New PFE2023_Gestionparking.BD_gestion_parkingDataSet1()
        Me.TB_ticketscheckinTableAdapter = New PFE2023_Gestionparking.BD_gestion_parkingDataSet1TableAdapters.TB_ticketscheckinTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.Pict_vehicule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBticketscheckinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_gestion_parkingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lab_ticket_no
        '
        Me.lab_ticket_no.AutoSize = True
        Me.lab_ticket_no.Location = New System.Drawing.Point(151, 79)
        Me.lab_ticket_no.Name = "lab_ticket_no"
        Me.lab_ticket_no.Size = New System.Drawing.Size(45, 13)
        Me.lab_ticket_no.TabIndex = 19
        Me.lab_ticket_no.Text = "ticketno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Ticket Number :"
        '
        'Lab_class_type
        '
        Me.Lab_class_type.AutoSize = True
        Me.Lab_class_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lab_class_type.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_class_type.Location = New System.Drawing.Point(26, 233)
        Me.Lab_class_type.Name = "Lab_class_type"
        Me.Lab_class_type.Size = New System.Drawing.Size(90, 30)
        Me.Lab_class_type.TabIndex = 17
        Me.Lab_class_type.Text = "Label3"
        Me.Lab_class_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_ticket_time
        '
        Me.Lab_ticket_time.AutoSize = True
        Me.Lab_ticket_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_ticket_time.Location = New System.Drawing.Point(27, 15)
        Me.Lab_ticket_time.Name = "Lab_ticket_time"
        Me.Lab_ticket_time.Size = New System.Drawing.Size(65, 20)
        Me.Lab_ticket_time.TabIndex = 13
        Me.Lab_ticket_time.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lab_ticket_no)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Lab_class_type)
        Me.Panel1.Controls.Add(Me.Pict_vehicule)
        Me.Panel1.Controls.Add(Me.Lab_ticket_time)
        Me.Panel1.Location = New System.Drawing.Point(6, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 310)
        Me.Panel1.TabIndex = 20
        '
        'Pict_vehicule
        '
        Me.Pict_vehicule.Location = New System.Drawing.Point(72, 123)
        Me.Pict_vehicule.Name = "Pict_vehicule"
        Me.Pict_vehicule.Size = New System.Drawing.Size(102, 85)
        Me.Pict_vehicule.TabIndex = 14
        Me.Pict_vehicule.TabStop = False
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
        Me.but_print_ticket.Location = New System.Drawing.Point(61, 350)
        Me.but_print_ticket.Name = "but_print_ticket"
        Me.but_print_ticket.Size = New System.Drawing.Size(165, 62)
        Me.but_print_ticket.TabIndex = 15
        Me.but_print_ticket.Text = "Print ticket"
        Me.but_print_ticket.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.but_print_ticket.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TicketidDataGridViewTextBoxColumn, Me.ClasstypeDataGridViewTextBoxColumn, Me.VehicletypeDataGridViewTextBoxColumn, Me.CheckindateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TBticketscheckinBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(537, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(442, 239)
        Me.DataGridView1.TabIndex = 21
        '
        'TicketidDataGridViewTextBoxColumn
        '
        Me.TicketidDataGridViewTextBoxColumn.DataPropertyName = "Ticket_id"
        Me.TicketidDataGridViewTextBoxColumn.HeaderText = "Ticket_id"
        Me.TicketidDataGridViewTextBoxColumn.Name = "TicketidDataGridViewTextBoxColumn"
        '
        'ClasstypeDataGridViewTextBoxColumn
        '
        Me.ClasstypeDataGridViewTextBoxColumn.DataPropertyName = "Class_type"
        Me.ClasstypeDataGridViewTextBoxColumn.HeaderText = "Class_type"
        Me.ClasstypeDataGridViewTextBoxColumn.Name = "ClasstypeDataGridViewTextBoxColumn"
        '
        'VehicletypeDataGridViewTextBoxColumn
        '
        Me.VehicletypeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_type"
        Me.VehicletypeDataGridViewTextBoxColumn.HeaderText = "Vehicle_type"
        Me.VehicletypeDataGridViewTextBoxColumn.Name = "VehicletypeDataGridViewTextBoxColumn"
        '
        'CheckindateDataGridViewTextBoxColumn
        '
        Me.CheckindateDataGridViewTextBoxColumn.DataPropertyName = "checkin_date"
        Me.CheckindateDataGridViewTextBoxColumn.HeaderText = "checkin_date"
        Me.CheckindateDataGridViewTextBoxColumn.Name = "CheckindateDataGridViewTextBoxColumn"
        '
        'TBticketscheckinBindingSource
        '
        Me.TBticketscheckinBindingSource.DataMember = "TB_ticketscheckin"
        Me.TBticketscheckinBindingSource.DataSource = Me.BD_gestion_parkingDataSet1
        '
        'BD_gestion_parkingDataSet1
        '
        Me.BD_gestion_parkingDataSet1.DataSetName = "BD_gestion_parkingDataSet1"
        Me.BD_gestion_parkingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TB_ticketscheckinTableAdapter
        '
        Me.TB_ticketscheckinTableAdapter.ClearBeforeFill = True
        '
        'Frm_print_checkin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PFE2023_Gestionparking.My.Resources.Resources.color
        Me.ClientSize = New System.Drawing.Size(275, 438)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.but_print_ticket)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_print_checkin"
        Me.Text = "Frm_print_checkin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Pict_vehicule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBticketscheckinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_gestion_parkingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lab_ticket_no As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lab_class_type As System.Windows.Forms.Label
    Friend WithEvents but_print_ticket As System.Windows.Forms.Button
    Friend WithEvents Pict_vehicule As System.Windows.Forms.PictureBox
    Friend WithEvents Lab_ticket_time As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BD_gestion_parkingDataSet1 As PFE2023_Gestionparking.BD_gestion_parkingDataSet1
    Friend WithEvents TBticketscheckinBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_ticketscheckinTableAdapter As PFE2023_Gestionparking.BD_gestion_parkingDataSet1TableAdapters.TB_ticketscheckinTableAdapter
    Friend WithEvents TicketidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClasstypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicletypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckindateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
