<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.Remember = New Guna.UI.WinForms.GunaCheckBox()
        Me.loginbtn = New Guna.UI.WinForms.GunaButton()
        Me.pass = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.user = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaProgressBar1 = New Guna.UI.WinForms.GunaProgressBar()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Remember
        '
        Me.Remember.BaseColor = System.Drawing.Color.White
        Me.Remember.CheckedOffColor = System.Drawing.Color.Gray
        Me.Remember.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Remember.FillColor = System.Drawing.Color.White
        Me.Remember.ForeColor = System.Drawing.Color.White
        Me.Remember.Location = New System.Drawing.Point(248, 368)
        Me.Remember.Name = "Remember"
        Me.Remember.Size = New System.Drawing.Size(111, 20)
        Me.Remember.TabIndex = 42
        Me.Remember.Text = "حفظ التسجيل"
        '
        'loginbtn
        '
        Me.loginbtn.Animated = True
        Me.loginbtn.AnimationHoverSpeed = 0.07!
        Me.loginbtn.AnimationSpeed = 0.03!
        Me.loginbtn.BackColor = System.Drawing.Color.Transparent
        Me.loginbtn.BaseColor = System.Drawing.Color.SeaGreen
        Me.loginbtn.BorderColor = System.Drawing.Color.SeaGreen
        Me.loginbtn.BorderSize = 2
        Me.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.loginbtn.FocusedColor = System.Drawing.Color.Empty
        Me.loginbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Image = Nothing
        Me.loginbtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.loginbtn.Location = New System.Drawing.Point(67, 402)
        Me.loginbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.OnHoverBaseColor = System.Drawing.Color.Green
        Me.loginbtn.OnHoverBorderColor = System.Drawing.Color.Green
        Me.loginbtn.OnHoverForeColor = System.Drawing.Color.White
        Me.loginbtn.OnHoverImage = Nothing
        Me.loginbtn.OnPressedColor = System.Drawing.Color.Black
        Me.loginbtn.Radius = 5
        Me.loginbtn.Size = New System.Drawing.Size(289, 59)
        Me.loginbtn.TabIndex = 41
        Me.loginbtn.Text = "تسجيل دخول"
        Me.loginbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.Transparent
        Me.pass.BaseColor = System.Drawing.Color.White
        Me.pass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.pass.BorderSize = 3
        Me.pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pass.FocusedBaseColor = System.Drawing.Color.White
        Me.pass.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pass.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.pass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pass.ForeColor = System.Drawing.Color.Black
        Me.pass.Location = New System.Drawing.Point(67, 315)
        Me.pass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Radius = 5
        Me.pass.Size = New System.Drawing.Size(289, 46)
        Me.pass.TabIndex = 38
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(277, 288)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(79, 23)
        Me.GunaLabel4.TabIndex = 37
        Me.GunaLabel4.Text = "كلمة السر"
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.Transparent
        Me.user.BaseColor = System.Drawing.Color.White
        Me.user.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.user.BorderSize = 3
        Me.user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.user.FocusedBaseColor = System.Drawing.Color.White
        Me.user.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.user.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.user.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.Black
        Me.user.Location = New System.Drawing.Point(67, 223)
        Me.user.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.user.Name = "user"
        Me.user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.user.Radius = 5
        Me.user.Size = New System.Drawing.Size(289, 46)
        Me.user.TabIndex = 36
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(244, 196)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(112, 23)
        Me.GunaLabel3.TabIndex = 35
        Me.GunaLabel3.Text = "اسم المستخدم"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'GunaProgressBar1
        '
        Me.GunaProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.GunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.GunaProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaProgressBar1.Location = New System.Drawing.Point(67, 402)
        Me.GunaProgressBar1.Name = "GunaProgressBar1"
        Me.GunaProgressBar1.ProgressMaxColor = System.Drawing.Color.Green
        Me.GunaProgressBar1.ProgressMinColor = System.Drawing.Color.Green
        Me.GunaProgressBar1.Size = New System.Drawing.Size(289, 59)
        Me.GunaProgressBar1.TabIndex = 44
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 100
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        Me.ErrorProvider1.RightToLeft = True
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.BlinkRate = 100
        Me.ErrorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider2.ContainerControl = Me
        Me.ErrorProvider2.Icon = CType(resources.GetObject("ErrorProvider2.Icon"), System.Drawing.Icon)
        Me.ErrorProvider2.RightToLeft = True
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "تسجيل الخروج"
        Me.BarButtonItem17.Hint = "تسجيل الخروج"
        Me.BarButtonItem17.Id = 59
        Me.BarButtonItem17.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem17.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaButton1.BorderSize = 2
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton1.ImageSize = New System.Drawing.Size(50, 50)
        Me.GunaButton1.Location = New System.Drawing.Point(190, 476)
        Me.GunaButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 5
        Me.GunaButton1.Size = New System.Drawing.Size(49, 46)
        Me.GunaButton1.TabIndex = 45
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Lock
        Me.PictureBox2.Location = New System.Drawing.Point(362, 325)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Contacts
        Me.PictureBox3.Location = New System.Drawing.Point(362, 233)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Staff_Management_System.My.Resources.Resources._2222222222
        Me.PictureBox1.Location = New System.Drawing.Point(-18, -104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(482, 411)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'frmlogin
        '
        Me.AcceptButton = Me.loginbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.Remember)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.SvgImage = CType(resources.GetObject("frmlogin.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.MaximizeBox = False
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تسجيل الدخول"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Remember As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents loginbtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents pass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents user As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GunaProgressBar1 As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
End Class
