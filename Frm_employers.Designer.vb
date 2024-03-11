<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_employers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_employers))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDemployerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmptelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpCINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpadresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBemployerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_gestion_parkingDataSet1 = New PFE2023_Gestionparking.BD_gestion_parkingDataSet1()
        Me.Butt_edit = New System.Windows.Forms.Button()
        Me.Txt_idemployer = New System.Windows.Forms.TextBox()
        Me.txt_empname = New System.Windows.Forms.TextBox()
        Me.txt_emptel = New System.Windows.Forms.TextBox()
        Me.txt_empcin = New System.Windows.Forms.TextBox()
        Me.txt_empadress = New System.Windows.Forms.TextBox()
        Me.TB_employerTableAdapter = New PFE2023_Gestionparking.BD_gestion_parkingDataSet1TableAdapters.TB_employerTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.But_delete = New System.Windows.Forms.Button()
        Me.but_add = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBemployerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_gestion_parkingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDemployerDataGridViewTextBoxColumn, Me.EmpnameDataGridViewTextBoxColumn, Me.EmptelDataGridViewTextBoxColumn, Me.EmpCINDataGridViewTextBoxColumn, Me.EmpadresseDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TBemployerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 475)
        Me.DataGridView1.TabIndex = 0
        '
        'IDemployerDataGridViewTextBoxColumn
        '
        Me.IDemployerDataGridViewTextBoxColumn.DataPropertyName = "ID_employer"
        Me.IDemployerDataGridViewTextBoxColumn.HeaderText = "ID_employer"
        Me.IDemployerDataGridViewTextBoxColumn.Name = "IDemployerDataGridViewTextBoxColumn"
        '
        'EmpnameDataGridViewTextBoxColumn
        '
        Me.EmpnameDataGridViewTextBoxColumn.DataPropertyName = "emp_name"
        Me.EmpnameDataGridViewTextBoxColumn.HeaderText = "emp_name"
        Me.EmpnameDataGridViewTextBoxColumn.Name = "EmpnameDataGridViewTextBoxColumn"
        '
        'EmptelDataGridViewTextBoxColumn
        '
        Me.EmptelDataGridViewTextBoxColumn.DataPropertyName = "emp_tel"
        Me.EmptelDataGridViewTextBoxColumn.HeaderText = "emp_tel"
        Me.EmptelDataGridViewTextBoxColumn.Name = "EmptelDataGridViewTextBoxColumn"
        '
        'EmpCINDataGridViewTextBoxColumn
        '
        Me.EmpCINDataGridViewTextBoxColumn.DataPropertyName = "emp_CIN"
        Me.EmpCINDataGridViewTextBoxColumn.HeaderText = "emp_CIN"
        Me.EmpCINDataGridViewTextBoxColumn.Name = "EmpCINDataGridViewTextBoxColumn"
        '
        'EmpadresseDataGridViewTextBoxColumn
        '
        Me.EmpadresseDataGridViewTextBoxColumn.DataPropertyName = "emp_adresse"
        Me.EmpadresseDataGridViewTextBoxColumn.HeaderText = "emp_adresse"
        Me.EmpadresseDataGridViewTextBoxColumn.Name = "EmpadresseDataGridViewTextBoxColumn"
        '
        'TBemployerBindingSource
        '
        Me.TBemployerBindingSource.DataMember = "TB_employer"
        Me.TBemployerBindingSource.DataSource = Me.BD_gestion_parkingDataSet1
        '
        'BD_gestion_parkingDataSet1
        '
        Me.BD_gestion_parkingDataSet1.DataSetName = "BD_gestion_parkingDataSet1"
        Me.BD_gestion_parkingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Butt_edit
        '
        Me.Butt_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butt_edit.Location = New System.Drawing.Point(928, 193)
        Me.Butt_edit.Name = "Butt_edit"
        Me.Butt_edit.Size = New System.Drawing.Size(219, 64)
        Me.Butt_edit.TabIndex = 2
        Me.Butt_edit.Text = "Edit an employer"
        Me.Butt_edit.UseVisualStyleBackColor = True
        '
        'Txt_idemployer
        '
        Me.Txt_idemployer.Location = New System.Drawing.Point(748, 95)
        Me.Txt_idemployer.Name = "Txt_idemployer"
        Me.Txt_idemployer.Size = New System.Drawing.Size(158, 20)
        Me.Txt_idemployer.TabIndex = 4
        '
        'txt_empname
        '
        Me.txt_empname.Location = New System.Drawing.Point(748, 158)
        Me.txt_empname.Name = "txt_empname"
        Me.txt_empname.Size = New System.Drawing.Size(158, 20)
        Me.txt_empname.TabIndex = 5
        '
        'txt_emptel
        '
        Me.txt_emptel.Location = New System.Drawing.Point(748, 219)
        Me.txt_emptel.Name = "txt_emptel"
        Me.txt_emptel.Size = New System.Drawing.Size(158, 20)
        Me.txt_emptel.TabIndex = 6
        '
        'txt_empcin
        '
        Me.txt_empcin.Location = New System.Drawing.Point(748, 281)
        Me.txt_empcin.Name = "txt_empcin"
        Me.txt_empcin.Size = New System.Drawing.Size(158, 20)
        Me.txt_empcin.TabIndex = 7
        '
        'txt_empadress
        '
        Me.txt_empadress.Location = New System.Drawing.Point(748, 340)
        Me.txt_empadress.Name = "txt_empadress"
        Me.txt_empadress.Size = New System.Drawing.Size(158, 20)
        Me.txt_empadress.TabIndex = 8
        '
        'TB_employerTableAdapter
        '
        Me.TB_employerTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(572, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(572, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Employee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(572, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Employee CIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(572, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Employee Phone N"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(572, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Employee Adress"
        '
        'But_delete
        '
        Me.But_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_delete.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.rsz_cancel_svgrepo_com
        Me.But_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.But_delete.Location = New System.Drawing.Point(928, 296)
        Me.But_delete.Name = "But_delete"
        Me.But_delete.Size = New System.Drawing.Size(219, 64)
        Me.But_delete.TabIndex = 3
        Me.But_delete.Text = "Delete an employer"
        Me.But_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.But_delete.UseVisualStyleBackColor = True
        '
        'but_add
        '
        Me.but_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_add.Image = Global.PFE2023_Gestionparking.My.Resources.Resources.Ampeross_Qetto_2_Add_contact_256
        Me.but_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.but_add.Location = New System.Drawing.Point(928, 95)
        Me.but_add.Name = "but_add"
        Me.but_add.Size = New System.Drawing.Size(219, 64)
        Me.but_add.TabIndex = 1
        Me.but_add.Text = "Add an employer"
        Me.but_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.but_add.UseVisualStyleBackColor = True
        '
        'Frm_employers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 501)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_empadress)
        Me.Controls.Add(Me.txt_empcin)
        Me.Controls.Add(Me.txt_emptel)
        Me.Controls.Add(Me.txt_empname)
        Me.Controls.Add(Me.Txt_idemployer)
        Me.Controls.Add(Me.But_delete)
        Me.Controls.Add(Me.Butt_edit)
        Me.Controls.Add(Me.but_add)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_employers"
        Me.Text = "Employers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBemployerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_gestion_parkingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BD_gestion_parkingDataSet1 As PFE2023_Gestionparking.BD_gestion_parkingDataSet1
    Friend WithEvents TBemployerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_employerTableAdapter As PFE2023_Gestionparking.BD_gestion_parkingDataSet1TableAdapters.TB_employerTableAdapter
    Friend WithEvents IDemployerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmptelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpCINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpadresseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents but_add As System.Windows.Forms.Button
    Friend WithEvents Butt_edit As System.Windows.Forms.Button
    Friend WithEvents But_delete As System.Windows.Forms.Button
    Friend WithEvents Txt_idemployer As System.Windows.Forms.TextBox
    Friend WithEvents txt_empname As System.Windows.Forms.TextBox
    Friend WithEvents txt_emptel As System.Windows.Forms.TextBox
    Friend WithEvents txt_empcin As System.Windows.Forms.TextBox
    Friend WithEvents txt_empadress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
