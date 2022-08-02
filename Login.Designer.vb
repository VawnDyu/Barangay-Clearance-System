<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits $safeprojectname$.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <$safeprojectname$.Diagnostics.DebuggerNonUserCode()> _
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
    Private components As $safeprojectname$.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <$safeprojectname$.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New $safeprojectname$.ComponentModel.Container()
        Dim resources As $safeprojectname$.ComponentModel.ComponentResourceManager = New $safeprojectname$.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Panel6 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Panel2 = New $safeprojectname$.Windows.Forms.Panel()
        Me.FormClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblDate = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New $safeprojectname$.Windows.Forms.PictureBox()
        Me.lblTime = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox2 = New $safeprojectname$.Windows.Forms.PictureBox()
        Me.BtnLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnCancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label3 = New $safeprojectname$.Windows.Forms.Label()
        Me.Label2 = New $safeprojectname$.Windows.Forms.Label()
        Me.Label1 = New $safeprojectname$.Windows.Forms.Label()
        Me.lblError = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Panel4 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Panel5 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Timer1 = New $safeprojectname$.Windows.Forms.Timer(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.FormClose, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), $safeprojectname$.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel6)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel2)
        Me.BunifuGradientPanel1.Controls.Add(Me.FormClose)
        Me.BunifuGradientPanel1.Controls.Add(Me.lblDate)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.lblTime)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel1.Dock = $safeprojectname$.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New $safeprojectname$.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New $safeprojectname$.Drawing.Size(370, 51)
        Me.BunifuGradientPanel1.TabIndex = 12
        '
        'Panel6
        '
        Me.Panel6.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Panel6.Location = New $safeprojectname$.Drawing.Point(237, 19)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New $safeprojectname$.Drawing.Size(1, 20)
        Me.Panel6.TabIndex = 90
        '
        'Panel2
        '
        Me.Panel2.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Panel2.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New $safeprojectname$.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New $safeprojectname$.Drawing.Size(370, 1)
        Me.Panel2.TabIndex = 15
        '
        'FormClose
        '
        Me.FormClose.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FormClose.Image = CType(resources.GetObject("FormClose.Image"), $safeprojectname$.Drawing.Image)
        Me.FormClose.ImageActive = Nothing
        Me.FormClose.Location = New $safeprojectname$.Drawing.Point(325, 11)
        Me.FormClose.Name = "FormClose"
        Me.FormClose.Size = New $safeprojectname$.Drawing.Size(32, 32)
        Me.FormClose.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FormClose.TabIndex = 20
        Me.FormClose.TabStop = False
        Me.FormClose.Zoom = 10
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.lblDate.Location = New $safeprojectname$.Drawing.Point(150, 22)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New $safeprojectname$.Drawing.Size(84, 17)
        Me.lblDate.TabIndex = 89
        Me.lblDate.Text = "Dec 30, 2999"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), $safeprojectname$.Drawing.Image)
        Me.PictureBox1.Location = New $safeprojectname$.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New $safeprojectname$.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.lblTime.Location = New $safeprojectname$.Drawing.Point(243, 22)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New $safeprojectname$.Drawing.Size(79, 17)
        Me.lblTime.TabIndex = 88
        Me.lblTime.Text = "00:00:00 AM"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 14.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel1.Location = New $safeprojectname$.Drawing.Point(56, 17)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New $safeprojectname$.Drawing.Size(59, 22)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Login"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), $safeprojectname$.Drawing.Image)
        Me.PictureBox2.Location = New $safeprojectname$.Drawing.Point(124, 96)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New $safeprojectname$.Drawing.Size(128, 128)
        Me.PictureBox2.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'BtnLogin
        '
        Me.BtnLogin.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BtnLogin.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BtnLogin.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogin.BorderRadius = 0
        Me.BtnLogin.ButtonText = "Login"
        Me.BtnLogin.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.BtnLogin.DisabledColor = $safeprojectname$.Drawing.Color.Gray
        Me.BtnLogin.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 6.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.BtnLogin.Iconimage = CType(resources.GetObject("BtnLogin.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.BtnLogin.Iconimage_right = Nothing
        Me.BtnLogin.Iconimage_right_Selected = Nothing
        Me.BtnLogin.Iconimage_Selected = Nothing
        Me.BtnLogin.IconMarginLeft = 70
        Me.BtnLogin.IconMarginRight = 0
        Me.BtnLogin.IconRightVisible = True
        Me.BtnLogin.IconRightZoom = 0.0R
        Me.BtnLogin.IconVisible = True
        Me.BtnLogin.IconZoom = 90.0R
        Me.BtnLogin.IsTab = False
        Me.BtnLogin.Location = New $safeprojectname$.Drawing.Point(49, 462)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BtnLogin.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BtnLogin.OnHoverTextColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BtnLogin.selected = False
        Me.BtnLogin.Size = New $safeprojectname$.Drawing.Size(270, 40)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.TabStop = False
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogin.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.BtnLogin.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 14.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnCancel
        '
        Me.BtnCancel.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BtnCancel.BackColor = $safeprojectname$.Drawing.Color.LightCoral
        Me.BtnCancel.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.BorderRadius = 0
        Me.BtnCancel.ButtonText = "Cancel"
        Me.BtnCancel.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.BtnCancel.DisabledColor = $safeprojectname$.Drawing.Color.Gray
        Me.BtnCancel.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 6.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.BtnCancel.Iconimage = Nothing
        Me.BtnCancel.Iconimage_right = Nothing
        Me.BtnCancel.Iconimage_right_Selected = Nothing
        Me.BtnCancel.Iconimage_Selected = Nothing
        Me.BtnCancel.IconMarginLeft = 100
        Me.BtnCancel.IconMarginRight = 0
        Me.BtnCancel.IconRightVisible = True
        Me.BtnCancel.IconRightZoom = 0.0R
        Me.BtnCancel.IconVisible = True
        Me.BtnCancel.IconZoom = 90.0R
        Me.BtnCancel.IsTab = False
        Me.BtnCancel.Location = New $safeprojectname$.Drawing.Point(49, 508)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Normalcolor = $safeprojectname$.Drawing.Color.LightCoral
        Me.BtnCancel.OnHovercolor = $safeprojectname$.Drawing.Color.IndianRed
        Me.BtnCancel.OnHoverTextColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BtnCancel.selected = False
        Me.BtnCancel.Size = New $safeprojectname$.Drawing.Size(270, 40)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.TabStop = False
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.BtnCancel.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 14.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.Label3.Location = New $safeprojectname$.Drawing.Point(95, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New $safeprojectname$.Drawing.Size(169, 20)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "District V, Quezon City"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 18.0!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = $safeprojectname$.Drawing.Color.LightCoral
        Me.Label2.Location = New $safeprojectname$.Drawing.Point(65, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New $safeprojectname$.Drawing.Size(237, 28)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "BARANGAY GULOD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.Label1.Location = New $safeprojectname$.Drawing.Point(43, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New $safeprojectname$.Drawing.Size(284, 19)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "OFFICE OF THE BARANGAY COUNCIL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = $safeprojectname$.Drawing.Color.LightCoral
        Me.lblError.Location = New $safeprojectname$.Drawing.Point(58, 328)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New $safeprojectname$.Drawing.Size(36, 17)
        Me.lblError.TabIndex = 82
        Me.lblError.Text = "Error"
        Me.lblError.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Dock = $safeprojectname$.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New $safeprojectname$.Drawing.Point(368, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New $safeprojectname$.Drawing.Size(2, 529)
        Me.Panel1.TabIndex = 83
        '
        'Panel4
        '
        Me.Panel4.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel4.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New $safeprojectname$.Drawing.Point(0, 578)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New $safeprojectname$.Drawing.Size(368, 2)
        Me.Panel4.TabIndex = 84
        '
        'Panel5
        '
        Me.Panel5.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel5.Dock = $safeprojectname$.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New $safeprojectname$.Drawing.Point(0, 51)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New $safeprojectname$.Drawing.Size(2, 527)
        Me.Panel5.TabIndex = 85
        '
        'Username
        '
        Me.Username.Cursor = $safeprojectname$.Windows.Forms.Cursors.IBeam
        Me.Username.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.Username.HintForeColor = $safeprojectname$.Drawing.Color.Empty
        Me.Username.HintText = ""
        Me.Username.isPassword = False
        Me.Username.LineFocusedColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Username.LineIdleColor = $safeprojectname$.Drawing.Color.LightGray
        Me.Username.LineMouseHoverColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Username.LineThickness = 3
        Me.Username.Location = New $safeprojectname$.Drawing.Point(49, 342)
        Me.Username.Margin = New $safeprojectname$.Windows.Forms.Padding(4)
        Me.Username.Name = "Username"
        Me.Username.Size = New $safeprojectname$.Drawing.Size(270, 44)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username"
        Me.Username.TextAlign = $safeprojectname$.Windows.Forms.HorizontalAlignment.Left
        '
        'Password
        '
        Me.Password.Cursor = $safeprojectname$.Windows.Forms.Cursors.IBeam
        Me.Password.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.Password.HintForeColor = $safeprojectname$.Drawing.Color.Empty
        Me.Password.HintText = ""
        Me.Password.isPassword = False
        Me.Password.LineFocusedColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Password.LineIdleColor = $safeprojectname$.Drawing.Color.LightGray
        Me.Password.LineMouseHoverColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Password.LineThickness = 3
        Me.Password.Location = New $safeprojectname$.Drawing.Point(49, 394)
        Me.Password.Margin = New $safeprojectname$.Windows.Forms.Padding(4)
        Me.Password.Name = "Password"
        Me.Password.Size = New $safeprojectname$.Drawing.Size(270, 44)
        Me.Password.TabIndex = 2
        Me.Password.Text = "Password"
        Me.Password.TextAlign = $safeprojectname$.Windows.Forms.HorizontalAlignment.Left
        '
        'Timer1
        '
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.BunifuGradientPanel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New $safeprojectname$.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = $safeprojectname$.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New $safeprojectname$.Drawing.Size(370, 580)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = $safeprojectname$.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = $safeprojectname$.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.FormClose, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panel2 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents FormClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As $safeprojectname$.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox2 As $safeprojectname$.Windows.Forms.PictureBox
    Friend WithEvents BtnLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnCancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As $safeprojectname$.Windows.Forms.Label
    Friend WithEvents Label2 As $safeprojectname$.Windows.Forms.Label
    Friend WithEvents Label1 As $safeprojectname$.Windows.Forms.Label
    Friend WithEvents lblError As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel4 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel5 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel6 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents lblDate As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblTime As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Timer1 As $safeprojectname$.Windows.Forms.Timer
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
