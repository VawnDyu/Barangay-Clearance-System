<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceRecord
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
        Dim DataGridViewCellStyle1 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim resources As $safeprojectname$.ComponentModel.ComponentResourceManager = New $safeprojectname$.ComponentModel.ComponentResourceManager(GetType(AttendanceRecord))
        Me.AttendanceList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox1 = New $safeprojectname$.Windows.Forms.PictureBox()
        Me.Panel29 = New $safeprojectname$.Windows.Forms.Panel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnAll = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.DatePicker = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel3 = New $safeprojectname$.Windows.Forms.Panel()
        Me.SearchRemoveAll = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SearchBar = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New $safeprojectname$.Windows.Forms.Panel()
        Me.btnInfoDesk = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnAdminStaff = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.Panel2 = New $safeprojectname$.Windows.Forms.Panel()
        Me.PictureBox2 = New $safeprojectname$.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.AttendanceList, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.SearchRemoveAll, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AttendanceList
        '
        Me.AttendanceList.AllowUserToAddRows = False
        Me.AttendanceList.AllowUserToDeleteRows = False
        Me.AttendanceList.AllowUserToResizeColumns = False
        Me.AttendanceList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.AttendanceList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AttendanceList.AutoSizeColumnsMode = $safeprojectname$.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AttendanceList.AutoSizeRowsMode = $safeprojectname$.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AttendanceList.BackgroundColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.AttendanceList.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.None
        Me.AttendanceList.ColumnHeadersBorderStyle = $safeprojectname$.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle2.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = $safeprojectname$.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = $safeprojectname$.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = $safeprojectname$.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[True]
        Me.AttendanceList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AttendanceList.ColumnHeadersHeight = 30
        Me.AttendanceList.ColumnHeadersHeightSizeMode = $safeprojectname$.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle3.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        DataGridViewCellStyle3.NullValue = "Still Online"
        DataGridViewCellStyle3.Padding = New $safeprojectname$.Windows.Forms.Padding(7)
        DataGridViewCellStyle3.SelectionBackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = $safeprojectname$.Drawing.Color.LightGray
        DataGridViewCellStyle3.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[False]
        Me.AttendanceList.DefaultCellStyle = DataGridViewCellStyle3
        Me.AttendanceList.DoubleBuffered = True
        Me.AttendanceList.EnableHeadersVisualStyles = False
        Me.AttendanceList.GridColor = $safeprojectname$.Drawing.Color.DimGray
        Me.AttendanceList.HeaderBgColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.AttendanceList.HeaderForeColor = $safeprojectname$.Drawing.Color.Black
        Me.AttendanceList.Location = New $safeprojectname$.Drawing.Point(0, 52)
        Me.AttendanceList.MultiSelect = False
        Me.AttendanceList.Name = "AttendanceList"
        Me.AttendanceList.ReadOnly = True
        Me.AttendanceList.RowHeadersBorderStyle = $safeprojectname$.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = $safeprojectname$.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 8.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = $safeprojectname$.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = $safeprojectname$.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = $safeprojectname$.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[True]
        Me.AttendanceList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.AttendanceList.RowHeadersVisible = False
        Me.AttendanceList.SelectionMode = $safeprojectname$.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AttendanceList.Size = New $safeprojectname$.Drawing.Size(575, 255)
        Me.AttendanceList.TabIndex = 2
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), $safeprojectname$.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel29)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuGradientPanel1.Dock = $safeprojectname$.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New $safeprojectname$.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New $safeprojectname$.Drawing.Size(1031, 46)
        Me.BunifuGradientPanel1.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), $safeprojectname$.Drawing.Image)
        Me.PictureBox1.Location = New $safeprojectname$.Drawing.Point(15, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New $safeprojectname$.Drawing.Size(26, 26)
        Me.PictureBox1.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel29
        '
        Me.Panel29.BackColor = $safeprojectname$.Drawing.Color.Gray
        Me.Panel29.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.Panel29.Location = New $safeprojectname$.Drawing.Point(0, 45)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New $safeprojectname$.Drawing.Size(1031, 1)
        Me.Panel29.TabIndex = 2
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 14.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel2.Location = New $safeprojectname$.Drawing.Point(50, 14)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New $safeprojectname$.Drawing.Size(197, 22)
        Me.BunifuCustomLabel2.TabIndex = 0
        Me.BunifuCustomLabel2.Text = "Attendance Record"
        '
        'btnAll
        '
        Me.btnAll.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAll.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.btnAll.color = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAll.colorActive = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnAll.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.btnAll.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.btnAll.Image = CType(resources.GetObject("btnAll.Image"), $safeprojectname$.Drawing.Image)
        Me.btnAll.ImagePosition = 0
        Me.btnAll.ImageZoom = 100
        Me.btnAll.LabelPosition = 26
        Me.btnAll.LabelText = ""
        Me.btnAll.Location = New $safeprojectname$.Drawing.Point(385, 78)
        Me.btnAll.Margin = New $safeprojectname$.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New $safeprojectname$.Drawing.Size(72, 73)
        Me.btnAll.TabIndex = 17
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.DatePicker)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel5)
        Me.BunifuCards1.Controls.Add(Me.Panel3)
        Me.BunifuCards1.Controls.Add(Me.SearchRemoveAll)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel4)
        Me.BunifuCards1.Controls.Add(Me.SearchBar)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuCards1.Controls.Add(Me.Panel1)
        Me.BunifuCards1.Controls.Add(Me.btnInfoDesk)
        Me.BunifuCards1.Controls.Add(Me.btnAdminStaff)
        Me.BunifuCards1.Controls.Add(Me.btnAll)
        Me.BunifuCards1.ForeColor = $safeprojectname$.Drawing.Color.Black
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New $safeprojectname$.Drawing.Point(15, 71)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New $safeprojectname$.Drawing.Size(983, 174)
        Me.BunifuCards1.TabIndex = 18
        '
        'DatePicker
        '
        Me.DatePicker.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DatePicker.BorderRadius = 0
        Me.DatePicker.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.DatePicker.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.DatePicker.Format = $safeprojectname$.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePicker.FormatCustom = " MMM dd, yyyy"
        Me.DatePicker.Location = New $safeprojectname$.Drawing.Point(718, 93)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New $safeprojectname$.Drawing.Size(237, 36)
        Me.DatePicker.TabIndex = 28
        Me.DatePicker.Value = New Date(2019, 11, 29, 0, 0, 0, 0)
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 18.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New $safeprojectname$.Drawing.Point(805, 31)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New $safeprojectname$.Drawing.Size(71, 30)
        Me.BunifuCustomLabel5.TabIndex = 27
        Me.BunifuCustomLabel5.Text = "Date"
        '
        'Panel3
        '
        Me.Panel3.BackColor = $safeprojectname$.Drawing.Color.DimGray
        Me.Panel3.Location = New $safeprojectname$.Drawing.Point(690, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New $safeprojectname$.Drawing.Size(2, 140)
        Me.Panel3.TabIndex = 26
        '
        'SearchRemoveAll
        '
        Me.SearchRemoveAll.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SearchRemoveAll.Image = CType(resources.GetObject("SearchRemoveAll.Image"), $safeprojectname$.Drawing.Image)
        Me.SearchRemoveAll.ImageActive = Nothing
        Me.SearchRemoveAll.Location = New $safeprojectname$.Drawing.Point(250, 105)
        Me.SearchRemoveAll.Name = "SearchRemoveAll"
        Me.SearchRemoveAll.Size = New $safeprojectname$.Drawing.Size(24, 24)
        Me.SearchRemoveAll.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SearchRemoveAll.TabIndex = 25
        Me.SearchRemoveAll.TabStop = False
        Me.SearchRemoveAll.Zoom = 10
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 18.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New $safeprojectname$.Drawing.Point(117, 31)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New $safeprojectname$.Drawing.Size(95, 30)
        Me.BunifuCustomLabel4.TabIndex = 25
        Me.BunifuCustomLabel4.Text = "Search"
        '
        'SearchBar
        '
        Me.SearchBar.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SearchBar.BackgroundImage = CType(resources.GetObject("SearchBar.BackgroundImage"), $safeprojectname$.Drawing.Image)
        Me.SearchBar.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.SearchBar.ForeColor = $safeprojectname$.Drawing.Color.Gray
        Me.SearchBar.Icon = CType(resources.GetObject("SearchBar.Icon"), $safeprojectname$.Drawing.Image)
        Me.SearchBar.Location = New $safeprojectname$.Drawing.Point(57, 93)
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New $safeprojectname$.Drawing.Size(226, 49)
        Me.SearchBar.TabIndex = 24
        Me.SearchBar.text = "Search Username"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 18.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New $safeprojectname$.Drawing.Point(473, 31)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New $safeprojectname$.Drawing.Size(92, 30)
        Me.BunifuCustomLabel1.TabIndex = 21
        Me.BunifuCustomLabel1.Text = "Sort by"
        '
        'Panel1
        '
        Me.Panel1.BackColor = $safeprojectname$.Drawing.Color.DimGray
        Me.Panel1.Location = New $safeprojectname$.Drawing.Point(335, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New $safeprojectname$.Drawing.Size(2, 140)
        Me.Panel1.TabIndex = 20
        '
        'btnInfoDesk
        '
        Me.btnInfoDesk.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnInfoDesk.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.btnInfoDesk.color = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnInfoDesk.colorActive = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnInfoDesk.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.btnInfoDesk.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfoDesk.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.btnInfoDesk.Image = CType(resources.GetObject("btnInfoDesk.Image"), $safeprojectname$.Drawing.Image)
        Me.btnInfoDesk.ImagePosition = 0
        Me.btnInfoDesk.ImageZoom = 70
        Me.btnInfoDesk.LabelPosition = 21
        Me.btnInfoDesk.LabelText = "Info Desk"
        Me.btnInfoDesk.Location = New $safeprojectname$.Drawing.Point(570, 78)
        Me.btnInfoDesk.Margin = New $safeprojectname$.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInfoDesk.Name = "btnInfoDesk"
        Me.btnInfoDesk.Size = New $safeprojectname$.Drawing.Size(72, 73)
        Me.btnInfoDesk.TabIndex = 19
        '
        'btnAdminStaff
        '
        Me.btnAdminStaff.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAdminStaff.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.btnAdminStaff.color = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAdminStaff.colorActive = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnAdminStaff.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.btnAdminStaff.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminStaff.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.btnAdminStaff.Image = CType(resources.GetObject("btnAdminStaff.Image"), $safeprojectname$.Drawing.Image)
        Me.btnAdminStaff.ImagePosition = 0
        Me.btnAdminStaff.ImageZoom = 70
        Me.btnAdminStaff.LabelPosition = 26
        Me.btnAdminStaff.LabelText = "Admin"
        Me.btnAdminStaff.Location = New $safeprojectname$.Drawing.Point(478, 78)
        Me.btnAdminStaff.Margin = New $safeprojectname$.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnAdminStaff.Name = "btnAdminStaff"
        Me.btnAdminStaff.Size = New $safeprojectname$.Drawing.Size(72, 73)
        Me.btnAdminStaff.TabIndex = 18
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.AttendanceList)
        Me.BunifuCards2.Controls.Add(Me.Panel2)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New $safeprojectname$.Drawing.Point(227, 256)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New $safeprojectname$.Drawing.Size(575, 310)
        Me.BunifuCards2.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel2.Location = New $safeprojectname$.Drawing.Point(0, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New $safeprojectname$.Drawing.Size(575, 46)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), $safeprojectname$.Drawing.Image)
        Me.PictureBox2.Location = New $safeprojectname$.Drawing.Point(170, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New $safeprojectname$.Drawing.Size(26, 26)
        Me.PictureBox2.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 14.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel3.Location = New $safeprojectname$.Drawing.Point(205, 13)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New $safeprojectname$.Drawing.Size(197, 22)
        Me.BunifuCustomLabel3.TabIndex = 4
        Me.BunifuCustomLabel3.Text = "Attendance Record"
        '
        'AttendanceRecord
        '
        Me.AutoScaleDimensions = New $safeprojectname$.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = $safeprojectname$.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New $safeprojectname$.Drawing.Size(1031, 604)
        Me.Controls.Add(Me.BunifuCards2)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = $safeprojectname$.Windows.Forms.FormBorderStyle.None
        Me.Name = "AttendanceRecord"
        Me.StartPosition = $safeprojectname$.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AttendanceRecord"
        Me.WindowState = $safeprojectname$.Windows.Forms.FormWindowState.Maximized
        CType(Me.AttendanceList, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox1, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.SearchRemoveAll, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AttendanceList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox1 As $safeprojectname$.Windows.Forms.PictureBox
    Friend WithEvents Panel29 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnAll As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents btnInfoDesk As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnAdminStaff As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Panel2 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As $safeprojectname$.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SearchRemoveAll As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SearchBar As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents DatePicker As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel3 As $safeprojectname$.Windows.Forms.Panel
End Class
