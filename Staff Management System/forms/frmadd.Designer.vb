<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmadd))
        Me.Gender = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.photoadd = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Dateemp = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuDate = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.tcn = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.salary = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.toe = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.name1 = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.dept = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.id = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.age = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.addrs = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.phon = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.qua = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.nat = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.photoadd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ofd
        '
        Me.ofd.FileName = "ofd"
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
        Me.GunaGroupBox1.Controls.Add(Me.Label4)
        Me.GunaGroupBox1.Controls.Add(Me.GunaButton1)
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
        Me.GunaGroupBox1.Controls.Add(Me.id)
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
        Me.GunaGroupBox1.Size = New System.Drawing.Size(781, 585)
        Me.GunaGroupBox1.TabIndex = 74
        Me.GunaGroupBox1.Text = "بيانات الموظف"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(410, 8)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(400, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "صورة الموظف"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.SeaGreen
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Save_as_100px
        Me.GunaButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton1.Location = New System.Drawing.Point(404, 500)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.SeaGreen
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 1
        Me.GunaButton1.Size = New System.Drawing.Size(363, 43)
        Me.GunaButton1.TabIndex = 85
        Me.GunaButton1.Text = "حفظ الموظف"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(400, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 84
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
        Me.GunaButton3.Location = New System.Drawing.Point(707, 137)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.SeaGreen
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Radius = 1
        Me.GunaButton3.Size = New System.Drawing.Size(59, 34)
        Me.GunaButton3.TabIndex = 83
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'photoadd
        '
        Me.photoadd.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Xlarge_Icons_96px
        Me.photoadd.Location = New System.Drawing.Point(404, 51)
        Me.photoadd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.photoadd.Name = "photoadd"
        Me.photoadd.Size = New System.Drawing.Size(298, 212)
        Me.photoadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.photoadd.TabIndex = 82
        Me.photoadd.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(404, 288)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(363, 192)
        Me.TextBox1.TabIndex = 81
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
        Me.Dateemp.Location = New System.Drawing.Point(106, 545)
        Me.Dateemp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dateemp.MinimumSize = New System.Drawing.Size(267, 32)
        Me.Dateemp.Name = "Dateemp"
        Me.Dateemp.Size = New System.Drawing.Size(267, 32)
        Me.Dateemp.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 552)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "تاريخ التوظيف"
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
        Me.BunifuDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
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
        Me.tcn.Location = New System.Drawing.Point(15, 353)
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
        Me.salary.Location = New System.Drawing.Point(15, 500)
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
        Me.toe.Location = New System.Drawing.Point(15, 448)
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
        Me.dept.Location = New System.Drawing.Point(15, 401)
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
        'id
        '
        Me.id.AcceptsReturn = False
        Me.id.AcceptsTab = False
        Me.id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.id.BackColor = System.Drawing.Color.White
        Me.id.BackgroundImage = CType(resources.GetObject("id.BackgroundImage"), System.Drawing.Image)
        Me.id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.id.BorderColorActive = System.Drawing.Color.SeaGreen
        Me.id.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.id.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.id.BorderColorIdle = System.Drawing.Color.SeaGreen
        Me.id.BorderRadius = 1
        Me.id.BorderThickness = 2
        Me.id.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.id.DefaultFont = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.DefaultText = ""
        Me.id.FillColor = System.Drawing.Color.White
        Me.id.ForeColor = System.Drawing.Color.Black
        Me.id.HideSelection = True
        Me.id.IconLeft = Nothing
        Me.id.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.id.IconPadding = 8
        Me.id.IconRight = Nothing
        Me.id.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.id.Location = New System.Drawing.Point(13, 79)
        Me.id.MaxLength = 10
        Me.id.MinimumSize = New System.Drawing.Size(100, 35)
        Me.id.Modified = False
        Me.id.Name = "id"
        Me.id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.id.ReadOnly = False
        Me.id.SelectedText = ""
        Me.id.SelectionLength = 0
        Me.id.SelectionStart = 0
        Me.id.ShortcutsEnabled = True
        Me.id.Size = New System.Drawing.Size(148, 35)
        Me.id.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.id.TabIndex = 54
        Me.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.id.TextMarginLeft = 5
        Me.id.TextPlaceholder = "الرقم الوظيفي"
        Me.id.UseSystemPasswordChar = False
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
        Me.phon.Location = New System.Drawing.Point(15, 301)
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
        'frmadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 585)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.SvgImage = CType(resources.GetObject("frmadd.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmadd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة موظف"
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.photoadd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcn As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents salary As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents Gender As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents dept As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents name1 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents id As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents age As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents addrs As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents toe As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents phon As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents qua As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents nat As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BunifuDate As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents Dateemp As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents photoadd As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
