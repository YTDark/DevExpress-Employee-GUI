<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmedit
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmedit))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Gender = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.DataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateempDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DBETBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPDataSet = New Staff_Management_System.EMPDataSet()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Search = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.GunaButton7 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton8 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton9 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton10 = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.photoadd = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Dateemp = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.BunifuDate = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.tcn = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.salary = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.toe = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.name1 = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.dept = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.id2 = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.age = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.addrs = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.phon = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.qua = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.nat = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.DBETTableAdapter = New Staff_Management_System.EMPDataSetTableAdapters.DBETTableAdapter()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photoadd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(408, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "تاريخ التوظيف"
        '
        'Gender
        '
        Me.Gender.BackColor = System.Drawing.Color.Transparent
        Me.Gender.BaseColor = System.Drawing.Color.White
        Me.Gender.BorderColor = System.Drawing.Color.SeaGreen
        Me.Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Gender.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Gender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Gender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Gender.ForeColor = System.Drawing.Color.Black
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.Gender.Location = New System.Drawing.Point(88, 162)
        Me.Gender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Gender.Name = "Gender"
        Me.Gender.OnHoverItemBaseColor = System.Drawing.Color.SeaGreen
        Me.Gender.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Gender.Size = New System.Drawing.Size(290, 26)
        Me.Gender.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(9, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "تاريخ الميلاد"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(9, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "النوع"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.DataGridView1)
        Me.GunaGroupBox1.Controls.Add(Me.GunaAdvenceButton3)
        Me.GunaGroupBox1.Controls.Add(Me.GunaAdvenceButton2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaAdvenceButton1)
        Me.GunaGroupBox1.Controls.Add(Me.Search)
        Me.GunaGroupBox1.Controls.Add(Me.GunaButton7)
        Me.GunaGroupBox1.Controls.Add(Me.GunaButton8)
        Me.GunaGroupBox1.Controls.Add(Me.GunaButton9)
        Me.GunaGroupBox1.Controls.Add(Me.GunaButton10)
        Me.GunaGroupBox1.Controls.Add(Me.Label3)
        Me.GunaGroupBox1.Controls.Add(Me.GunaButton3)
        Me.GunaGroupBox1.Controls.Add(Me.photoadd)
        Me.GunaGroupBox1.Controls.Add(Me.TextBox1)
        Me.GunaGroupBox1.Controls.Add(Me.Dateemp)
        Me.GunaGroupBox1.Controls.Add(Me.Label2)
        Me.GunaGroupBox1.Controls.Add(Me.BunifuDate)
        Me.GunaGroupBox1.Controls.Add(Me.tcn)
        Me.GunaGroupBox1.Controls.Add(Me.salary)
        Me.GunaGroupBox1.Controls.Add(Me.Gender)
        Me.GunaGroupBox1.Controls.Add(Me.toe)
        Me.GunaGroupBox1.Controls.Add(Me.name1)
        Me.GunaGroupBox1.Controls.Add(Me.dept)
        Me.GunaGroupBox1.Controls.Add(Me.Label1)
        Me.GunaGroupBox1.Controls.Add(Me.id2)
        Me.GunaGroupBox1.Controls.Add(Me.age)
        Me.GunaGroupBox1.Controls.Add(Me.addrs)
        Me.GunaGroupBox1.Controls.Add(Me.phon)
        Me.GunaGroupBox1.Controls.Add(Me.Label6)
        Me.GunaGroupBox1.Controls.Add(Me.qua)
        Me.GunaGroupBox1.Controls.Add(Me.nat)
        Me.GunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.SeaGreen
        Me.GunaGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(1157, 697)
        Me.GunaGroupBox1.TabIndex = 75
        Me.GunaGroupBox1.Text = "تعديل بيانات الموظف"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(650, 8)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EnameDataGridViewTextBoxColumn, Me.EidDataGridViewTextBoxColumn, Me.EageDataGridViewTextBoxColumn, Me.DateBirthDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.NationalityDataGridViewTextBoxColumn, Me.QualificationDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.NCompanyDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.TypeEmpDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn, Me.DateempDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.PhotoDataGridViewImageColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1.DataSource = Me.DBETBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(138, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 368)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1157, 329)
        Me.DataGridView1.TabIndex = 147
        Me.DataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Green
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 40
        Me.DataGridView1.ThemeStyle.ReadOnly = True
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 40
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        Me.IdDataGridViewTextBoxColumn.Width = 49
        '
        'EnameDataGridViewTextBoxColumn
        '
        Me.EnameDataGridViewTextBoxColumn.DataPropertyName = "ename"
        Me.EnameDataGridViewTextBoxColumn.FillWeight = 130.6843!
        Me.EnameDataGridViewTextBoxColumn.HeaderText = "اسم الموظف"
        Me.EnameDataGridViewTextBoxColumn.Name = "EnameDataGridViewTextBoxColumn"
        Me.EnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EnameDataGridViewTextBoxColumn.Width = 119
        '
        'EidDataGridViewTextBoxColumn
        '
        Me.EidDataGridViewTextBoxColumn.DataPropertyName = "eid"
        Me.EidDataGridViewTextBoxColumn.FillWeight = 137.1076!
        Me.EidDataGridViewTextBoxColumn.HeaderText = "الرقم الوظيفي"
        Me.EidDataGridViewTextBoxColumn.Name = "EidDataGridViewTextBoxColumn"
        Me.EidDataGridViewTextBoxColumn.ReadOnly = True
        Me.EidDataGridViewTextBoxColumn.Width = 126
        '
        'EageDataGridViewTextBoxColumn
        '
        Me.EageDataGridViewTextBoxColumn.DataPropertyName = "eage"
        Me.EageDataGridViewTextBoxColumn.FillWeight = 80.52364!
        Me.EageDataGridViewTextBoxColumn.HeaderText = "السن"
        Me.EageDataGridViewTextBoxColumn.Name = "EageDataGridViewTextBoxColumn"
        Me.EageDataGridViewTextBoxColumn.ReadOnly = True
        Me.EageDataGridViewTextBoxColumn.Width = 67
        '
        'DateBirthDataGridViewTextBoxColumn
        '
        Me.DateBirthDataGridViewTextBoxColumn.DataPropertyName = "DateBirth"
        Me.DateBirthDataGridViewTextBoxColumn.FillWeight = 114.9409!
        Me.DateBirthDataGridViewTextBoxColumn.HeaderText = "تاريخ الميلاد"
        Me.DateBirthDataGridViewTextBoxColumn.Name = "DateBirthDataGridViewTextBoxColumn"
        Me.DateBirthDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateBirthDataGridViewTextBoxColumn.Width = 109
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.FillWeight = 73.57681!
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "النوع"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Width = 65
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.FillWeight = 99.12268!
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "الجنسية"
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        Me.NationalityDataGridViewTextBoxColumn.ReadOnly = True
        Me.NationalityDataGridViewTextBoxColumn.Width = 83
        '
        'QualificationDataGridViewTextBoxColumn
        '
        Me.QualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification"
        Me.QualificationDataGridViewTextBoxColumn.FillWeight = 133.6362!
        Me.QualificationDataGridViewTextBoxColumn.HeaderText = "المؤهل العلمي"
        Me.QualificationDataGridViewTextBoxColumn.Name = "QualificationDataGridViewTextBoxColumn"
        Me.QualificationDataGridViewTextBoxColumn.ReadOnly = True
        Me.QualificationDataGridViewTextBoxColumn.Width = 131
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.FillWeight = 84.30206!
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "العنوان"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Width = 80
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.FillWeight = 101.932!
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "رقم الهاتف"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhoneDataGridViewTextBoxColumn.Width = 103
        '
        'NCompanyDataGridViewTextBoxColumn
        '
        Me.NCompanyDataGridViewTextBoxColumn.DataPropertyName = "nCompany"
        Me.NCompanyDataGridViewTextBoxColumn.FillWeight = 87.25305!
        Me.NCompanyDataGridViewTextBoxColumn.HeaderText = "الشركة"
        Me.NCompanyDataGridViewTextBoxColumn.Name = "NCompanyDataGridViewTextBoxColumn"
        Me.NCompanyDataGridViewTextBoxColumn.ReadOnly = True
        Me.NCompanyDataGridViewTextBoxColumn.Width = 77
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.FillWeight = 80.87164!
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "القسم"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentDataGridViewTextBoxColumn.Width = 73
        '
        'TypeEmpDataGridViewTextBoxColumn
        '
        Me.TypeEmpDataGridViewTextBoxColumn.DataPropertyName = "TypeEmp"
        Me.TypeEmpDataGridViewTextBoxColumn.FillWeight = 94.35268!
        Me.TypeEmpDataGridViewTextBoxColumn.HeaderText = "نوع العمل"
        Me.TypeEmpDataGridViewTextBoxColumn.Name = "TypeEmpDataGridViewTextBoxColumn"
        Me.TypeEmpDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeEmpDataGridViewTextBoxColumn.Width = 98
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.FillWeight = 76.31501!
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "الراتب"
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        Me.SalaryDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalaryDataGridViewTextBoxColumn.Width = 73
        '
        'DateempDataGridViewTextBoxColumn
        '
        Me.DateempDataGridViewTextBoxColumn.DataPropertyName = "Dateemp"
        Me.DateempDataGridViewTextBoxColumn.FillWeight = 117.6182!
        Me.DateempDataGridViewTextBoxColumn.HeaderText = "تاريخ التوظيف"
        Me.DateempDataGridViewTextBoxColumn.Name = "DateempDataGridViewTextBoxColumn"
        Me.DateempDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateempDataGridViewTextBoxColumn.Width = 125
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.FillWeight = 94.77281!
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "ملاحظات"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        Me.NotesDataGridViewTextBoxColumn.Width = 93
        '
        'PhotoDataGridViewImageColumn
        '
        Me.PhotoDataGridViewImageColumn.DataPropertyName = "Photo"
        Me.PhotoDataGridViewImageColumn.FillWeight = 92.99046!
        Me.PhotoDataGridViewImageColumn.HeaderText = "صورة الموظف"
        Me.PhotoDataGridViewImageColumn.Name = "PhotoDataGridViewImageColumn"
        Me.PhotoDataGridViewImageColumn.ReadOnly = True
        Me.PhotoDataGridViewImageColumn.Width = 112
        '
        'DBETBindingSource
        '
        Me.DBETBindingSource.DataMember = "DBET"
        Me.DBETBindingSource.DataSource = Me.EMPDataSet
        '
        'EMPDataSet
        '
        Me.EMPDataSet.DataSetName = "EMPDataSet"
        Me.EMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = Nothing
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.2!)
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.Image = Nothing
        Me.GunaAdvenceButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(15, 329)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Radius = 1
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(204, 28)
        Me.GunaAdvenceButton3.TabIndex = 146
        Me.GunaAdvenceButton3.Text = "عرض جميع البيانات"
        Me.GunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = Nothing
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.2!)
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = Nothing
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(225, 294)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Radius = 1
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(114, 28)
        Me.GunaAdvenceButton2.TabIndex = 145
        Me.GunaAdvenceButton2.Text = "بحث باسم الموظف"
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = Nothing
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.2!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(225, 327)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 1
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(114, 28)
        Me.GunaAdvenceButton1.TabIndex = 144
        Me.GunaAdvenceButton1.Text = "بحث برقم الموظف"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Search
        '
        Me.Search.AcceptsReturn = False
        Me.Search.AcceptsTab = False
        Me.Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Search.BackColor = System.Drawing.Color.White
        Me.Search.BackgroundImage = CType(resources.GetObject("Search.BackgroundImage"), System.Drawing.Image)
        Me.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Search.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Search.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Search.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Search.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Search.BorderRadius = 1
        Me.Search.BorderThickness = 2
        Me.Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Search.DefaultFont = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.DefaultText = ""
        Me.Search.FillColor = System.Drawing.Color.White
        Me.Search.ForeColor = System.Drawing.Color.Black
        Me.Search.HideSelection = True
        Me.Search.IconLeft = Nothing
        Me.Search.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Search.IconPadding = 8
        Me.Search.IconRight = Nothing
        Me.Search.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Search.Location = New System.Drawing.Point(15, 294)
        Me.Search.MaxLength = 10
        Me.Search.MinimumSize = New System.Drawing.Size(100, 35)
        Me.Search.Modified = False
        Me.Search.Name = "Search"
        Me.Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Search.ReadOnly = False
        Me.Search.SelectedText = ""
        Me.Search.SelectionLength = 0
        Me.Search.SelectionStart = 0
        Me.Search.ShortcutsEnabled = True
        Me.Search.Size = New System.Drawing.Size(204, 35)
        Me.Search.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.Search.TabIndex = 143
        Me.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Search.TextMarginLeft = 5
        Me.Search.TextPlaceholder = "بحث عن موظف"
        Me.Search.UseSystemPasswordChar = False
        '
        'GunaButton7
        '
        Me.GunaButton7.AnimationHoverSpeed = 0.07!
        Me.GunaButton7.AnimationSpeed = 0.03!
        Me.GunaButton7.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton7.BaseColor = System.Drawing.Color.Red
        Me.GunaButton7.BorderColor = System.Drawing.Color.Black
        Me.GunaButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton7.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton7.ForeColor = System.Drawing.Color.White
        Me.GunaButton7.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Delete_Table_100px
        Me.GunaButton7.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton7.Location = New System.Drawing.Point(344, 314)
        Me.GunaButton7.Name = "GunaButton7"
        Me.GunaButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton7.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton7.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton7.OnHoverImage = Nothing
        Me.GunaButton7.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton7.Radius = 3
        Me.GunaButton7.Size = New System.Drawing.Size(205, 40)
        Me.GunaButton7.TabIndex = 142
        Me.GunaButton7.Text = "مسح جميع الموظفين"
        '
        'GunaButton8
        '
        Me.GunaButton8.AnimationHoverSpeed = 0.07!
        Me.GunaButton8.AnimationSpeed = 0.03!
        Me.GunaButton8.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton8.BaseColor = System.Drawing.Color.SeaGreen
        Me.GunaButton8.BorderColor = System.Drawing.Color.Black
        Me.GunaButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton8.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton8.ForeColor = System.Drawing.Color.White
        Me.GunaButton8.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Save_as_100px1
        Me.GunaButton8.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton8.Location = New System.Drawing.Point(752, 314)
        Me.GunaButton8.Name = "GunaButton8"
        Me.GunaButton8.OnHoverBaseColor = System.Drawing.Color.Green
        Me.GunaButton8.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton8.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton8.OnHoverImage = Nothing
        Me.GunaButton8.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton8.Radius = 3
        Me.GunaButton8.Size = New System.Drawing.Size(193, 40)
        Me.GunaButton8.TabIndex = 141
        Me.GunaButton8.Text = "حفظ التعديل"
        Me.GunaButton8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton9
        '
        Me.GunaButton9.AnimationHoverSpeed = 0.07!
        Me.GunaButton9.AnimationSpeed = 0.03!
        Me.GunaButton9.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton9.BaseColor = System.Drawing.Color.Red
        Me.GunaButton9.BorderColor = System.Drawing.Color.Black
        Me.GunaButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton9.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton9.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton9.ForeColor = System.Drawing.Color.White
        Me.GunaButton9.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Delete_User_Male_100px
        Me.GunaButton9.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton9.Location = New System.Drawing.Point(554, 314)
        Me.GunaButton9.Name = "GunaButton9"
        Me.GunaButton9.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton9.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton9.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton9.OnHoverImage = Nothing
        Me.GunaButton9.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton9.Radius = 3
        Me.GunaButton9.Size = New System.Drawing.Size(193, 40)
        Me.GunaButton9.TabIndex = 140
        Me.GunaButton9.Text = "مسح موظف"
        Me.GunaButton9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton10
        '
        Me.GunaButton10.AnimationHoverSpeed = 0.07!
        Me.GunaButton10.AnimationSpeed = 0.03!
        Me.GunaButton10.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton10.BaseColor = System.Drawing.Color.SeaGreen
        Me.GunaButton10.BorderColor = System.Drawing.Color.Black
        Me.GunaButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton10.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton10.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton10.ForeColor = System.Drawing.Color.White
        Me.GunaButton10.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Edit_Property_100px1
        Me.GunaButton10.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton10.Location = New System.Drawing.Point(950, 314)
        Me.GunaButton10.Name = "GunaButton10"
        Me.GunaButton10.OnHoverBaseColor = System.Drawing.Color.Green
        Me.GunaButton10.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton10.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton10.OnHoverImage = Nothing
        Me.GunaButton10.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton10.Radius = 3
        Me.GunaButton10.Size = New System.Drawing.Size(193, 40)
        Me.GunaButton10.TabIndex = 139
        Me.GunaButton10.Text = "تعديل"
        Me.GunaButton10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(780, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "ملاحظات"
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.SeaGreen
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = CType(resources.GetObject("GunaButton3.Image"), System.Drawing.Image)
        Me.GunaButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(1087, 69)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.SeaGreen
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Radius = 1
        Me.GunaButton3.Size = New System.Drawing.Size(59, 34)
        Me.GunaButton3.TabIndex = 87
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'photoadd
        '
        Me.photoadd.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Xlarge_Icons_96px
        Me.photoadd.Location = New System.Drawing.Point(783, 30)
        Me.photoadd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.photoadd.Name = "photoadd"
        Me.photoadd.Size = New System.Drawing.Size(298, 119)
        Me.photoadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.photoadd.TabIndex = 86
        Me.photoadd.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(783, 167)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(363, 116)
        Me.TextBox1.TabIndex = 85
        '
        'Dateemp
        '
        Me.Dateemp.BorderRadius = 1
        Me.Dateemp.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick
        Me.Dateemp.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.Dateemp.DisabledColor = System.Drawing.Color.Gray
        Me.Dateemp.DisplayWeekNumbers = False
        Me.Dateemp.DPHeight = 0
        Me.Dateemp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.Dateemp.FillDatePicker = False
        Me.Dateemp.ForeColor = System.Drawing.Color.Purple
        Me.Dateemp.Icon = CType(resources.GetObject("Dateemp.Icon"), System.Drawing.Image)
        Me.Dateemp.IconColor = System.Drawing.Color.Purple
        Me.Dateemp.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.Dateemp.Location = New System.Drawing.Point(498, 257)
        Me.Dateemp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dateemp.MinimumSize = New System.Drawing.Size(267, 32)
        Me.Dateemp.Name = "Dateemp"
        Me.Dateemp.Size = New System.Drawing.Size(267, 32)
        Me.Dateemp.TabIndex = 76
        '
        'BunifuDate
        '
        Me.BunifuDate.BorderRadius = 1
        Me.BunifuDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick
        Me.BunifuDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.BunifuDate.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDate.DisplayWeekNumbers = False
        Me.BunifuDate.DPHeight = 0
        Me.BunifuDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.BunifuDate.FillDatePicker = False
        Me.BunifuDate.ForeColor = System.Drawing.Color.Purple
        Me.BunifuDate.Icon = CType(resources.GetObject("BunifuDate.Icon"), System.Drawing.Image)
        Me.BunifuDate.IconColor = System.Drawing.Color.Purple
        Me.BunifuDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.BunifuDate.Location = New System.Drawing.Point(88, 124)
        Me.BunifuDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuDate.MinimumSize = New System.Drawing.Size(290, 32)
        Me.BunifuDate.Name = "BunifuDate"
        Me.BunifuDate.Size = New System.Drawing.Size(290, 32)
        Me.BunifuDate.TabIndex = 74
        '
        'tcn
        '
        Me.tcn.AcceptsReturn = False
        Me.tcn.AcceptsTab = False
        Me.tcn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tcn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tcn.BackColor = System.Drawing.Color.White
        Me.tcn.BackgroundImage = CType(resources.GetObject("tcn.BackgroundImage"), System.Drawing.Image)
        Me.tcn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tcn.BorderColorActive = System.Drawing.Color.SeaGreen
        Me.tcn.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.tcn.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.tcn.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.tcn.BorderRadius = 1
        Me.tcn.BorderThickness = 2
        Me.tcn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tcn.DefaultFont = New System.Drawing.Font("Tahoma", 10.8!)
        Me.tcn.DefaultText = ""
        Me.tcn.FillColor = System.Drawing.Color.White
        Me.tcn.ForeColor = System.Drawing.Color.Black
        Me.tcn.HideSelection = True
        Me.tcn.IconLeft = Nothing
        Me.tcn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.tcn.IconPadding = 8
        Me.tcn.IconRight = Nothing
        Me.tcn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.tcn.Location = New System.Drawing.Point(403, 79)
        Me.tcn.MaxLength = 100
        Me.tcn.MinimumSize = New System.Drawing.Size(100, 35)
        Me.tcn.Modified = False
        Me.tcn.Name = "tcn"
        Me.tcn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tcn.ReadOnly = False
        Me.tcn.SelectedText = ""
        Me.tcn.SelectionLength = 0
        Me.tcn.SelectionStart = 0
        Me.tcn.ShortcutsEnabled = True
        Me.tcn.Size = New System.Drawing.Size(362, 35)
        Me.tcn.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.tcn.TabIndex = 58
        Me.tcn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tcn.TextMarginLeft = 5
        Me.tcn.TextPlaceholder = "اسم الشركة"
        Me.tcn.UseSystemPasswordChar = False
        '
        'salary
        '
        Me.salary.AcceptsReturn = False
        Me.salary.AcceptsTab = False
        Me.salary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.salary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.salary.BackColor = System.Drawing.Color.White
        Me.salary.BackgroundImage = CType(resources.GetObject("salary.BackgroundImage"), System.Drawing.Image)
        Me.salary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.salary.BorderColorActive = System.Drawing.Color.SeaGreen
        Me.salary.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.salary.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.salary.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.salary.BorderRadius = 1
        Me.salary.BorderThickness = 2
        Me.salary.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.salary.DefaultFont = New System.Drawing.Font("Tahoma", 10.8!)
        Me.salary.DefaultText = ""
        Me.salary.FillColor = System.Drawing.Color.White
        Me.salary.ForeColor = System.Drawing.Color.Black
        Me.salary.HideSelection = True
        Me.salary.IconLeft = Nothing
        Me.salary.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.salary.IconPadding = 8
        Me.salary.IconRight = Nothing
        Me.salary.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.salary.Location = New System.Drawing.Point(403, 211)
        Me.salary.MaxLength = 32767
        Me.salary.MinimumSize = New System.Drawing.Size(100, 35)
        Me.salary.Modified = False
        Me.salary.Name = "salary"
        Me.salary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.salary.ReadOnly = False
        Me.salary.SelectedText = ""
        Me.salary.SelectionLength = 0
        Me.salary.SelectionStart = 0
        Me.salary.ShortcutsEnabled = True
        Me.salary.Size = New System.Drawing.Size(362, 35)
        Me.salary.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.salary.TabIndex = 57
        Me.salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.salary.TextMarginLeft = 5
        Me.salary.TextPlaceholder = "الراتب"
        Me.salary.UseSystemPasswordChar = False
        '
        'toe
        '
        Me.toe.AcceptsReturn = False
        Me.toe.AcceptsTab = False
        Me.toe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.toe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.toe.BackColor = System.Drawing.Color.White
        Me.toe.BackgroundImage = CType(resources.GetObject("toe.BackgroundImage"), System.Drawing.Image)
        Me.toe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.toe.BorderColorActive = System.Drawing.Color.SeaGreen
        Me.toe.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.toe.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.toe.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.toe.BorderRadius = 1
        Me.toe.BorderThickness = 2
        Me.toe.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.toe.DefaultFont = New System.Drawing.Font("Tahoma", 10.8!)
        Me.toe.DefaultText = ""
        Me.toe.FillColor = System.Drawing.Color.White
        Me.toe.ForeColor = System.Drawing.Color.Black
        Me.toe.HideSelection = True
        Me.toe.IconLeft = Nothing
        Me.toe.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.toe.IconPadding = 8
        Me.toe.IconRight = Nothing
        Me.toe.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.toe.Location = New System.Drawing.Point(404, 167)
        Me.toe.MaxLength = 50
        Me.toe.MinimumSize = New System.Drawing.Size(100, 35)
        Me.toe.Modified = False
        Me.toe.Name = "toe"
        Me.toe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.toe.ReadOnly = False
        Me.toe.SelectedText = ""
        Me.toe.SelectionLength = 0
        Me.toe.SelectionStart = 0
        Me.toe.ShortcutsEnabled = True
        Me.toe.Size = New System.Drawing.Size(362, 35)
        Me.toe.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.toe.TabIndex = 56
        Me.toe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.toe.TextMarginLeft = 5
        Me.toe.TextPlaceholder = "نوع العمل"
        Me.toe.UseSystemPasswordChar = False
        '
        'name1
        '
        Me.name1.AcceptsReturn = False
        Me.name1.AcceptsTab = False
        Me.name1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.name1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.name1.BackColor = System.Drawing.Color.White
        Me.name1.BackgroundImage = CType(resources.GetObject("name1.BackgroundImage"), System.Drawing.Image)
        Me.name1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.name1.BorderColorActive = System.Drawing.Color.SeaGreen
        Me.name1.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.name1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.name1.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.name1.BorderRadius = 1
        Me.name1.BorderThickness = 2
        Me.name1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.name1.DefaultFont = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name1.DefaultText = ""
        Me.name1.FillColor = System.Drawing.Color.White
        Me.name1.ForeColor = System.Drawing.Color.Black
        Me.name1.HideSelection = True
        Me.name1.IconLeft = Nothing
        Me.name1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.name1.IconPadding = 8
        Me.name1.IconRight = Nothing
        Me.name1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.name1.Location = New System.Drawing.Point(10, 30)
        Me.name1.MaxLength = 255
        Me.name1.MinimumSize = New System.Drawing.Size(100, 35)
        Me.name1.Modified = False
        Me.name1.Name = "name1"
        Me.name1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.name1.ReadOnly = False
        Me.name1.SelectedText = ""
        Me.name1.SelectionLength = 0
        Me.name1.SelectionStart = 0
        Me.name1.ShortcutsEnabled = True
        Me.name1.Size = New System.Drawing.Size(363, 35)
        Me.name1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.name1.TabIndex = 55
        Me.name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.name1.TextMarginLeft = 5
        Me.name1.TextPlaceholder = "اسم الموظف"
        Me.name1.UseSystemPasswordChar = False
        '
        'dept
        '
        Me.dept.AcceptsReturn = False
        Me.dept.AcceptsTab = False
        Me.dept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.dept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.dept.BackColor = System.Drawing.Color.White
        Me.dept.BackgroundImage = CType(resources.GetObject("dept.BackgroundImage"), System.Drawing.Image)
        Me.dept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dept.BorderColorActive = System.Drawing.Color.SeaGreen
        Me.dept.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.dept.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dept.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.dept.BorderRadius = 1
        Me.dept.BorderThickness = 2
        Me.dept.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dept.DefaultFont = New System.Drawing.Font("Tahoma", 10.8!)
        Me.dept.DefaultText = ""
        Me.dept.FillColor = System.Drawing.Color.White
        Me.dept.ForeColor = System.Drawing.Color.Black
        Me.dept.HideSelection = True
        Me.dept.IconLeft = Nothing
        Me.dept.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.dept.IconPadding = 8
        Me.dept.IconRight = Nothing
        Me.dept.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.dept.Location = New System.Drawing.Point(403, 124)
        Me.dept.MaxLength = 100
        Me.dept.MinimumSize = New System.Drawing.Size(100, 35)
        Me.dept.Modified = False
        Me.dept.Name = "dept"
        Me.dept.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dept.ReadOnly = False
        Me.dept.SelectedText = ""
        Me.dept.SelectionLength = 0
        Me.dept.SelectionStart = 0
        Me.dept.ShortcutsEnabled = True
        Me.dept.Size = New System.Drawing.Size(362, 35)
        Me.dept.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.dept.TabIndex = 55
        Me.dept.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.dept.TextMarginLeft = 5
        Me.dept.TextPlaceholder = "القسم"
        Me.dept.UseSystemPasswordChar = False
        '
        'id2
        '
        Me.id2.AcceptsReturn = False
        Me.id2.AcceptsTab = False
        Me.id2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.id2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.id2.BackColor = System.Drawing.Color.White
        Me.id2.BackgroundImage = CType(resources.GetObject("id2.BackgroundImage"), System.Drawing.Image)
        Me.id2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.id2.BorderColorActive = System.Drawing.Color.SeaGreen
        Me.id2.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.id2.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.id2.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.id2.BorderRadius = 1
        Me.id2.BorderThickness = 2
        Me.id2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.id2.DefaultFont = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id2.DefaultText = ""
        Me.id2.FillColor = System.Drawing.Color.White
        Me.id2.ForeColor = System.Drawing.Color.Black
        Me.id2.HideSelection = True
        Me.id2.IconLeft = Nothing
        Me.id2.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.id2.IconPadding = 8
        Me.id2.IconRight = Nothing
        Me.id2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.id2.Location = New System.Drawing.Point(13, 79)
        Me.id2.MaxLength = 10
        Me.id2.MinimumSize = New System.Drawing.Size(100, 35)
        Me.id2.Modified = False
        Me.id2.Name = "id2"
        Me.id2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.id2.ReadOnly = False
        Me.id2.SelectedText = ""
        Me.id2.SelectionLength = 0
        Me.id2.SelectionStart = 0
        Me.id2.ShortcutsEnabled = True
        Me.id2.Size = New System.Drawing.Size(148, 35)
        Me.id2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.id2.TabIndex = 54
        Me.id2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.id2.TextMarginLeft = 5
        Me.id2.TextPlaceholder = "الرقم الوظيفي"
        Me.id2.UseSystemPasswordChar = False
        '
        'age
        '
        Me.age.AcceptsReturn = False
        Me.age.AcceptsTab = False
        Me.age.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.age.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.age.BackColor = System.Drawing.Color.White
        Me.age.BackgroundImage = CType(resources.GetObject("age.BackgroundImage"), System.Drawing.Image)
        Me.age.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.age.BorderColorActive = System.Drawing.Color.SeaGreen
        Me.age.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.age.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.age.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.age.BorderRadius = 1
        Me.age.BorderThickness = 2
        Me.age.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.age.DefaultFont = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.DefaultText = ""
        Me.age.FillColor = System.Drawing.Color.White
        Me.age.ForeColor = System.Drawing.Color.Black
        Me.age.HideSelection = True
        Me.age.IconLeft = Nothing
        Me.age.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.age.IconPadding = 8
        Me.age.IconRight = Nothing
        Me.age.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.age.Location = New System.Drawing.Point(187, 79)
        Me.age.MaxLength = 5
        Me.age.MinimumSize = New System.Drawing.Size(100, 35)
        Me.age.Modified = False
        Me.age.Name = "age"
        Me.age.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.age.ReadOnly = False
        Me.age.SelectedText = ""
        Me.age.SelectionLength = 0
        Me.age.SelectionStart = 0
        Me.age.ShortcutsEnabled = True
        Me.age.Size = New System.Drawing.Size(186, 35)
        Me.age.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.age.TabIndex = 56
        Me.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.age.TextMarginLeft = 5
        Me.age.TextPlaceholder = "السن"
        Me.age.UseSystemPasswordChar = False
        '
        'addrs
        '
        Me.addrs.AcceptsReturn = False
        Me.addrs.AcceptsTab = False
        Me.addrs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.addrs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.addrs.BackColor = System.Drawing.Color.White
        Me.addrs.BackgroundImage = CType(resources.GetObject("addrs.BackgroundImage"), System.Drawing.Image)
        Me.addrs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.addrs.BorderColorActive = System.Drawing.Color.SeaGreen
        Me.addrs.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.addrs.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.addrs.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.addrs.BorderRadius = 1
        Me.addrs.BorderThickness = 2
        Me.addrs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.addrs.DefaultFont = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addrs.DefaultText = ""
        Me.addrs.FillColor = System.Drawing.Color.White
        Me.addrs.ForeColor = System.Drawing.Color.Black
        Me.addrs.HideSelection = True
        Me.addrs.IconLeft = Nothing
        Me.addrs.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.addrs.IconPadding = 8
        Me.addrs.IconRight = Nothing
        Me.addrs.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.addrs.Location = New System.Drawing.Point(15, 248)
        Me.addrs.MaxLength = 255
        Me.addrs.MinimumSize = New System.Drawing.Size(100, 35)
        Me.addrs.Modified = False
        Me.addrs.Name = "addrs"
        Me.addrs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.addrs.ReadOnly = False
        Me.addrs.SelectedText = ""
        Me.addrs.SelectionLength = 0
        Me.addrs.SelectionStart = 0
        Me.addrs.ShortcutsEnabled = True
        Me.addrs.Size = New System.Drawing.Size(363, 35)
        Me.addrs.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.addrs.TabIndex = 58
        Me.addrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.addrs.TextMarginLeft = 5
        Me.addrs.TextPlaceholder = "العنوان"
        Me.addrs.UseSystemPasswordChar = False
        '
        'phon
        '
        Me.phon.AcceptsReturn = False
        Me.phon.AcceptsTab = False
        Me.phon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.phon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.phon.BackColor = System.Drawing.Color.White
        Me.phon.BackgroundImage = CType(resources.GetObject("phon.BackgroundImage"), System.Drawing.Image)
        Me.phon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.phon.BorderColorActive = System.Drawing.Color.SeaGreen
        Me.phon.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.phon.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.phon.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.phon.BorderRadius = 1
        Me.phon.BorderThickness = 2
        Me.phon.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.phon.DefaultFont = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phon.DefaultText = ""
        Me.phon.FillColor = System.Drawing.Color.White
        Me.phon.ForeColor = System.Drawing.Color.Black
        Me.phon.HideSelection = True
        Me.phon.IconLeft = Nothing
        Me.phon.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.phon.IconPadding = 8
        Me.phon.IconRight = Nothing
        Me.phon.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.phon.Location = New System.Drawing.Point(403, 30)
        Me.phon.MaxLength = 20
        Me.phon.MinimumSize = New System.Drawing.Size(100, 35)
        Me.phon.Modified = False
        Me.phon.Name = "phon"
        Me.phon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.phon.ReadOnly = False
        Me.phon.SelectedText = ""
        Me.phon.SelectionLength = 0
        Me.phon.SelectionStart = 0
        Me.phon.ShortcutsEnabled = True
        Me.phon.Size = New System.Drawing.Size(363, 35)
        Me.phon.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.phon.TabIndex = 59
        Me.phon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.phon.TextMarginLeft = 5
        Me.phon.TextPlaceholder = "رقم الهاتف"
        Me.phon.UseSystemPasswordChar = False
        '
        'qua
        '
        Me.qua.AcceptsReturn = False
        Me.qua.AcceptsTab = False
        Me.qua.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.qua.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.qua.BackColor = System.Drawing.Color.White
        Me.qua.BackgroundImage = CType(resources.GetObject("qua.BackgroundImage"), System.Drawing.Image)
        Me.qua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.qua.BorderColorActive = System.Drawing.Color.SeaGreen
        Me.qua.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.qua.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.qua.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.qua.BorderRadius = 1
        Me.qua.BorderThickness = 2
        Me.qua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.qua.DefaultFont = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qua.DefaultText = ""
        Me.qua.FillColor = System.Drawing.Color.White
        Me.qua.ForeColor = System.Drawing.Color.Black
        Me.qua.HideSelection = True
        Me.qua.IconLeft = Nothing
        Me.qua.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.qua.IconPadding = 8
        Me.qua.IconRight = Nothing
        Me.qua.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.qua.Location = New System.Drawing.Point(159, 199)
        Me.qua.MaxLength = 150
        Me.qua.MinimumSize = New System.Drawing.Size(100, 35)
        Me.qua.Modified = False
        Me.qua.Name = "qua"
        Me.qua.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.qua.ReadOnly = False
        Me.qua.SelectedText = ""
        Me.qua.SelectionLength = 0
        Me.qua.SelectionStart = 0
        Me.qua.ShortcutsEnabled = True
        Me.qua.Size = New System.Drawing.Size(219, 35)
        Me.qua.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.qua.TabIndex = 60
        Me.qua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.qua.TextMarginLeft = 5
        Me.qua.TextPlaceholder = "المؤهل العلمي"
        Me.qua.UseSystemPasswordChar = False
        '
        'nat
        '
        Me.nat.AcceptsReturn = False
        Me.nat.AcceptsTab = False
        Me.nat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.nat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.nat.BackColor = System.Drawing.Color.White
        Me.nat.BackgroundImage = CType(resources.GetObject("nat.BackgroundImage"), System.Drawing.Image)
        Me.nat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.nat.BorderColorActive = System.Drawing.Color.SeaGreen
        Me.nat.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.nat.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.nat.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.nat.BorderRadius = 1
        Me.nat.BorderThickness = 2
        Me.nat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.nat.DefaultFont = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nat.DefaultText = ""
        Me.nat.FillColor = System.Drawing.Color.White
        Me.nat.ForeColor = System.Drawing.Color.Black
        Me.nat.HideSelection = True
        Me.nat.IconLeft = Nothing
        Me.nat.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.nat.IconPadding = 8
        Me.nat.IconRight = Nothing
        Me.nat.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.nat.Location = New System.Drawing.Point(15, 199)
        Me.nat.MaxLength = 50
        Me.nat.MinimumSize = New System.Drawing.Size(100, 35)
        Me.nat.Modified = False
        Me.nat.Name = "nat"
        Me.nat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nat.ReadOnly = False
        Me.nat.SelectedText = ""
        Me.nat.SelectionLength = 0
        Me.nat.SelectionStart = 0
        Me.nat.ShortcutsEnabled = True
        Me.nat.Size = New System.Drawing.Size(122, 35)
        Me.nat.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.nat.TabIndex = 61
        Me.nat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.nat.TextMarginLeft = 5
        Me.nat.TextPlaceholder = "الجنسية"
        Me.nat.UseSystemPasswordChar = False
        '
        'ofd
        '
        Me.ofd.FileName = "ofd"
        '
        'DBETTableAdapter
        '
        Me.DBETTableAdapter.ClearBeforeFill = True
        '
        'frmedit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 697)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.SvgImage = CType(resources.GetObject("frmedit.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmedit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تعديل بيانات الموظف"
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photoadd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dateemp As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BunifuDate As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents tcn As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents salary As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents Gender As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents toe As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents name1 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents dept As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id2 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents age As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents addrs As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents phon As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents qua As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents nat As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents photoadd As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Search As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents GunaButton7 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton8 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton9 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton10 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents DataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents EMPDataSet As Staff_Management_System.EMPDataSet
    Friend WithEvents DBETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DBETTableAdapter As Staff_Management_System.EMPDataSetTableAdapters.DBETTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QualificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCompanyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeEmpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateempDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
End Class
