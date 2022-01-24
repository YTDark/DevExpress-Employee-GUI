<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsalary
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsalary))
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
        Me.DBETTableAdapter = New Staff_Management_System.EMPDataSetTableAdapters.DBETTableAdapter()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Search = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.GunaButton8 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton10 = New Guna.UI.WinForms.GunaButton()
        Me.salary = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 118)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(891, 382)
        Me.DataGridView1.TabIndex = 155
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
        '
        'EnameDataGridViewTextBoxColumn
        '
        Me.EnameDataGridViewTextBoxColumn.DataPropertyName = "ename"
        Me.EnameDataGridViewTextBoxColumn.FillWeight = 130.6843!
        Me.EnameDataGridViewTextBoxColumn.HeaderText = "اسم الموظف"
        Me.EnameDataGridViewTextBoxColumn.Name = "EnameDataGridViewTextBoxColumn"
        Me.EnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EidDataGridViewTextBoxColumn
        '
        Me.EidDataGridViewTextBoxColumn.DataPropertyName = "eid"
        Me.EidDataGridViewTextBoxColumn.FillWeight = 137.1076!
        Me.EidDataGridViewTextBoxColumn.HeaderText = "الرقم الوظيفي"
        Me.EidDataGridViewTextBoxColumn.Name = "EidDataGridViewTextBoxColumn"
        Me.EidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EageDataGridViewTextBoxColumn
        '
        Me.EageDataGridViewTextBoxColumn.DataPropertyName = "eage"
        Me.EageDataGridViewTextBoxColumn.FillWeight = 80.52364!
        Me.EageDataGridViewTextBoxColumn.HeaderText = "السن"
        Me.EageDataGridViewTextBoxColumn.Name = "EageDataGridViewTextBoxColumn"
        Me.EageDataGridViewTextBoxColumn.ReadOnly = True
        Me.EageDataGridViewTextBoxColumn.Visible = False
        '
        'DateBirthDataGridViewTextBoxColumn
        '
        Me.DateBirthDataGridViewTextBoxColumn.DataPropertyName = "DateBirth"
        Me.DateBirthDataGridViewTextBoxColumn.FillWeight = 114.9409!
        Me.DateBirthDataGridViewTextBoxColumn.HeaderText = "تاريخ الميلاد"
        Me.DateBirthDataGridViewTextBoxColumn.Name = "DateBirthDataGridViewTextBoxColumn"
        Me.DateBirthDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateBirthDataGridViewTextBoxColumn.Visible = False
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.FillWeight = 73.57681!
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "النوع"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Visible = False
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.FillWeight = 99.12268!
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "الجنسية"
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        Me.NationalityDataGridViewTextBoxColumn.ReadOnly = True
        Me.NationalityDataGridViewTextBoxColumn.Visible = False
        '
        'QualificationDataGridViewTextBoxColumn
        '
        Me.QualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification"
        Me.QualificationDataGridViewTextBoxColumn.FillWeight = 133.6362!
        Me.QualificationDataGridViewTextBoxColumn.HeaderText = "المؤهل العلمي"
        Me.QualificationDataGridViewTextBoxColumn.Name = "QualificationDataGridViewTextBoxColumn"
        Me.QualificationDataGridViewTextBoxColumn.ReadOnly = True
        Me.QualificationDataGridViewTextBoxColumn.Visible = False
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.FillWeight = 84.30206!
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "العنوان"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Visible = False
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.FillWeight = 101.932!
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "رقم الهاتف"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhoneDataGridViewTextBoxColumn.Visible = False
        '
        'NCompanyDataGridViewTextBoxColumn
        '
        Me.NCompanyDataGridViewTextBoxColumn.DataPropertyName = "nCompany"
        Me.NCompanyDataGridViewTextBoxColumn.FillWeight = 87.25305!
        Me.NCompanyDataGridViewTextBoxColumn.HeaderText = "الشركة"
        Me.NCompanyDataGridViewTextBoxColumn.Name = "NCompanyDataGridViewTextBoxColumn"
        Me.NCompanyDataGridViewTextBoxColumn.ReadOnly = True
        Me.NCompanyDataGridViewTextBoxColumn.Visible = False
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.FillWeight = 80.87164!
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "القسم"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentDataGridViewTextBoxColumn.Visible = False
        '
        'TypeEmpDataGridViewTextBoxColumn
        '
        Me.TypeEmpDataGridViewTextBoxColumn.DataPropertyName = "TypeEmp"
        Me.TypeEmpDataGridViewTextBoxColumn.FillWeight = 94.35268!
        Me.TypeEmpDataGridViewTextBoxColumn.HeaderText = "نوع العمل"
        Me.TypeEmpDataGridViewTextBoxColumn.Name = "TypeEmpDataGridViewTextBoxColumn"
        Me.TypeEmpDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeEmpDataGridViewTextBoxColumn.Visible = False
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.FillWeight = 76.31501!
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "الراتب"
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        Me.SalaryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateempDataGridViewTextBoxColumn
        '
        Me.DateempDataGridViewTextBoxColumn.DataPropertyName = "Dateemp"
        Me.DateempDataGridViewTextBoxColumn.FillWeight = 117.6182!
        Me.DateempDataGridViewTextBoxColumn.HeaderText = "تاريخ التوظيف"
        Me.DateempDataGridViewTextBoxColumn.Name = "DateempDataGridViewTextBoxColumn"
        Me.DateempDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateempDataGridViewTextBoxColumn.Visible = False
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.FillWeight = 94.77281!
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "ملاحظات"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        Me.NotesDataGridViewTextBoxColumn.Visible = False
        '
        'PhotoDataGridViewImageColumn
        '
        Me.PhotoDataGridViewImageColumn.DataPropertyName = "Photo"
        Me.PhotoDataGridViewImageColumn.FillWeight = 92.99046!
        Me.PhotoDataGridViewImageColumn.HeaderText = "صورة الموظف"
        Me.PhotoDataGridViewImageColumn.Name = "PhotoDataGridViewImageColumn"
        Me.PhotoDataGridViewImageColumn.ReadOnly = True
        Me.PhotoDataGridViewImageColumn.Visible = False
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
        'DBETTableAdapter
        '
        Me.DBETTableAdapter.ClearBeforeFill = True
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
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(57, 53)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Radius = 1
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(204, 35)
        Me.GunaAdvenceButton3.TabIndex = 162
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
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 30)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(267, 11)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Radius = 1
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(114, 35)
        Me.GunaAdvenceButton2.TabIndex = 161
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
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 250)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(267, 53)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 1
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(114, 35)
        Me.GunaAdvenceButton1.TabIndex = 160
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
        Me.Search.Location = New System.Drawing.Point(57, 11)
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
        Me.Search.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material
        Me.Search.TabIndex = 159
        Me.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Search.TextMarginLeft = 5
        Me.Search.TextPlaceholder = "بحث عن موظف"
        Me.Search.UseSystemPasswordChar = False
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
        Me.GunaButton8.Location = New System.Drawing.Point(457, 52)
        Me.GunaButton8.Name = "GunaButton8"
        Me.GunaButton8.OnHoverBaseColor = System.Drawing.Color.Green
        Me.GunaButton8.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton8.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton8.OnHoverImage = Nothing
        Me.GunaButton8.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton8.Radius = 3
        Me.GunaButton8.Size = New System.Drawing.Size(193, 40)
        Me.GunaButton8.TabIndex = 158
        Me.GunaButton8.Text = "حفظ التعديل"
        Me.GunaButton8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaButton10.Location = New System.Drawing.Point(655, 52)
        Me.GunaButton10.Name = "GunaButton10"
        Me.GunaButton10.OnHoverBaseColor = System.Drawing.Color.Green
        Me.GunaButton10.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton10.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton10.OnHoverImage = Nothing
        Me.GunaButton10.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton10.Radius = 3
        Me.GunaButton10.Size = New System.Drawing.Size(193, 40)
        Me.GunaButton10.TabIndex = 157
        Me.GunaButton10.Text = "تعديل"
        Me.GunaButton10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.salary.Location = New System.Drawing.Point(457, 11)
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
        Me.salary.Size = New System.Drawing.Size(391, 35)
        Me.salary.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material
        Me.salary.TabIndex = 156
        Me.salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.salary.TextMarginLeft = 5
        Me.salary.TextPlaceholder = "الراتب"
        Me.salary.UseSystemPasswordChar = False
        '
        'frmsalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 500)
        Me.Controls.Add(Me.GunaAdvenceButton3)
        Me.Controls.Add(Me.GunaAdvenceButton2)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.GunaButton8)
        Me.Controls.Add(Me.GunaButton10)
        Me.Controls.Add(Me.salary)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.SvgImage = CType(resources.GetObject("frmsalary.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmsalary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "رواتب الموظفين"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents DBETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPDataSet As Staff_Management_System.EMPDataSet
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
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Search As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents GunaButton8 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton10 As Guna.UI.WinForms.GunaButton
    Friend WithEvents salary As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
End Class
