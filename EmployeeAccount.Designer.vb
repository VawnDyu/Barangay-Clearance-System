<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeAccount
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
        Dim resources As $safeprojectname$.ComponentModel.ComponentResourceManager = New $safeprojectname$.ComponentModel.ComponentResourceManager(GetType(EmployeeAccount))
        Dim DataGridViewCellStyle1 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Me.ImgAdminStaff = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImgInfoDesk = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImgAll = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TextAll = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextAdminStaff = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextInfoDesk = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ImgDelete = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImgUpdate = New Bunifu.Framework.UI.BunifuImageButton()
        Me.EmployeeAccountList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.SearchBar = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox1 = New $safeprojectname$.Windows.Forms.PictureBox()
        Me.Panel29 = New $safeprojectname$.Windows.Forms.Panel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SearchRemoveAll = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.ImgAdminStaff, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgInfoDesk, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgAll, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgDelete, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgUpdate, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeAccountList, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchRemoveAll, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImgAdminStaff
        '
        Me.ImgAdminStaff.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ImgAdminStaff.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.ImgAdminStaff.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.ImgAdminStaff.Image = CType(resources.GetObject("ImgAdminStaff.Image"), $safeprojectname$.Drawing.Image)
        Me.ImgAdminStaff.ImageActive = Nothing
        Me.ImgAdminStaff.Location = New $safeprojectname$.Drawing.Point(840, 125)
        Me.ImgAdminStaff.Name = "ImgAdminStaff"
        Me.ImgAdminStaff.Size = New $safeprojectname$.Drawing.Size(64, 64)
        Me.ImgAdminStaff.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgAdminStaff.TabIndex = 6
        Me.ImgAdminStaff.TabStop = False
        Me.ImgAdminStaff.Zoom = 10
        '
        'ImgInfoDesk
        '
        Me.ImgInfoDesk.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ImgInfoDesk.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.ImgInfoDesk.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.ImgInfoDesk.Image = CType(resources.GetObject("ImgInfoDesk.Image"), $safeprojectname$.Drawing.Image)
        Me.ImgInfoDesk.ImageActive = Nothing
        Me.ImgInfoDesk.Location = New $safeprojectname$.Drawing.Point(927, 125)
        Me.ImgInfoDesk.Name = "ImgInfoDesk"
        Me.ImgInfoDesk.Size = New $safeprojectname$.Drawing.Size(64, 64)
        Me.ImgInfoDesk.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgInfoDesk.TabIndex = 7
        Me.ImgInfoDesk.TabStop = False
        Me.ImgInfoDesk.Zoom = 10
        '
        'ImgAll
        '
        Me.ImgAll.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ImgAll.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.ImgAll.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.ImgAll.Image = CType(resources.GetObject("ImgAll.Image"), $safeprojectname$.Drawing.Image)
        Me.ImgAll.ImageActive = Nothing
        Me.ImgAll.Location = New $safeprojectname$.Drawing.Point(754, 125)
        Me.ImgAll.Name = "ImgAll"
        Me.ImgAll.Size = New $safeprojectname$.Drawing.Size(64, 64)
        Me.ImgAll.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgAll.TabIndex = 8
        Me.ImgAll.TabStop = False
        Me.ImgAll.Zoom = 10
        '
        'TextAll
        '
        Me.TextAll.AutoSize = True
        Me.TextAll.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAll.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.TextAll.Location = New $safeprojectname$.Drawing.Point(774, 206)
        Me.TextAll.Name = "TextAll"
        Me.TextAll.Size = New $safeprojectname$.Drawing.Size(23, 17)
        Me.TextAll.TabIndex = 9
        Me.TextAll.Text = "All"
        '
        'TextAdminStaff
        '
        Me.TextAdminStaff.AutoSize = True
        Me.TextAdminStaff.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAdminStaff.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.TextAdminStaff.Location = New $safeprojectname$.Drawing.Point(847, 196)
        Me.TextAdminStaff.Name = "TextAdminStaff"
        Me.TextAdminStaff.Size = New $safeprojectname$.Drawing.Size(50, 34)
        Me.TextAdminStaff.TabIndex = 10
        Me.TextAdminStaff.Text = "Admin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Staff"
        Me.TextAdminStaff.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        '
        'TextInfoDesk
        '
        Me.TextInfoDesk.AutoSize = True
        Me.TextInfoDesk.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextInfoDesk.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.TextInfoDesk.Location = New $safeprojectname$.Drawing.Point(930, 206)
        Me.TextInfoDesk.Name = "TextInfoDesk"
        Me.TextInfoDesk.Size = New $safeprojectname$.Drawing.Size(62, 17)
        Me.TextInfoDesk.TabIndex = 11
        Me.TextInfoDesk.Text = "InfoDesk"
        Me.TextInfoDesk.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 20.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New $safeprojectname$.Drawing.Point(824, 70)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New $safeprojectname$.Drawing.Size(102, 33)
        Me.BunifuCustomLabel5.TabIndex = 12
        Me.BunifuCustomLabel5.Text = "Sort By"
        '
        'ImgDelete
        '
        Me.ImgDelete.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ImgDelete.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.ImgDelete.Image = CType(resources.GetObject("ImgDelete.Image"), $safeprojectname$.Drawing.Image)
        Me.ImgDelete.ImageActive = Nothing
        Me.ImgDelete.Location = New $safeprojectname$.Drawing.Point(457, 180)
        Me.ImgDelete.Name = "ImgDelete"
        Me.ImgDelete.Size = New $safeprojectname$.Drawing.Size(55, 64)
        Me.ImgDelete.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgDelete.TabIndex = 19
        Me.ImgDelete.TabStop = False
        Me.ImgDelete.Zoom = 10
        '
        'ImgUpdate
        '
        Me.ImgUpdate.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ImgUpdate.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.ImgUpdate.Image = CType(resources.GetObject("ImgUpdate.Image"), $safeprojectname$.Drawing.Image)
        Me.ImgUpdate.ImageActive = Nothing
        Me.ImgUpdate.Location = New $safeprojectname$.Drawing.Point(374, 180)
        Me.ImgUpdate.Name = "ImgUpdate"
        Me.ImgUpdate.Size = New $safeprojectname$.Drawing.Size(64, 64)
        Me.ImgUpdate.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgUpdate.TabIndex = 18
        Me.ImgUpdate.TabStop = False
        Me.ImgUpdate.Zoom = 10
        '
        'EmployeeAccountList
        '
        Me.EmployeeAccountList.AllowUserToAddRows = False
        Me.EmployeeAccountList.AllowUserToDeleteRows = False
        Me.EmployeeAccountList.AllowUserToResizeColumns = False
        Me.EmployeeAccountList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.EmployeeAccountList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeAccountList.AutoSizeColumnsMode = $safeprojectname$.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.EmployeeAccountList.AutoSizeRowsMode = $safeprojectname$.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.EmployeeAccountList.BackgroundColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.EmployeeAccountList.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.None
        Me.EmployeeAccountList.ColumnHeadersBorderStyle = $safeprojectname$.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle2.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = $safeprojectname$.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = $safeprojectname$.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = $safeprojectname$.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeAccountList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.EmployeeAccountList.ColumnHeadersHeight = 30
        Me.EmployeeAccountList.ColumnHeadersHeightSizeMode = $safeprojectname$.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle3.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        DataGridViewCellStyle3.Padding = New $safeprojectname$.Windows.Forms.Padding(7)
        DataGridViewCellStyle3.SelectionBackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = $safeprojectname$.Drawing.Color.LightGray
        DataGridViewCellStyle3.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeAccountList.DefaultCellStyle = DataGridViewCellStyle3
        Me.EmployeeAccountList.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.EmployeeAccountList.DoubleBuffered = True
        Me.EmployeeAccountList.EnableHeadersVisualStyles = False
        Me.EmployeeAccountList.GridColor = $safeprojectname$.Drawing.Color.DimGray
        Me.EmployeeAccountList.HeaderBgColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.EmployeeAccountList.HeaderForeColor = $safeprojectname$.Drawing.Color.Black
        Me.EmployeeAccountList.Location = New $safeprojectname$.Drawing.Point(0, 292)
        Me.EmployeeAccountList.MultiSelect = False
        Me.EmployeeAccountList.Name = "EmployeeAccountList"
        Me.EmployeeAccountList.ReadOnly = True
        Me.EmployeeAccountList.RowHeadersBorderStyle = $safeprojectname$.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = $safeprojectname$.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 8.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = $safeprojectname$.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = $safeprojectname$.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = $safeprojectname$.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeAccountList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.EmployeeAccountList.RowHeadersVisible = False
        Me.EmployeeAccountList.SelectionMode = $safeprojectname$.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeAccountList.Size = New $safeprojectname$.Drawing.Size(1162, 327)
        Me.EmployeeAccountList.TabIndex = 20
        '
        'SearchBar
        '
        Me.SearchBar.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SearchBar.BackgroundImage = CType(resources.GetObject("SearchBar.BackgroundImage"), $safeprojectname$.Drawing.Image)
        Me.SearchBar.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.SearchBar.ForeColor = $safeprojectname$.Drawing.Color.Gray
        Me.SearchBar.Icon = CType(resources.GetObject("SearchBar.Icon"), $safeprojectname$.Drawing.Image)
        Me.SearchBar.Location = New $safeprojectname$.Drawing.Point(23, 186)
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New $safeprojectname$.Drawing.Size(329, 49)
        Me.SearchBar.TabIndex = 21
        Me.SearchBar.text = "Search"
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
        Me.BunifuGradientPanel1.Size = New $safeprojectname$.Drawing.Size(1162, 46)
        Me.BunifuGradientPanel1.TabIndex = 22
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
        Me.Panel29.Size = New $safeprojectname$.Drawing.Size(1162, 1)
        Me.Panel29.TabIndex = 2
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 14.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel2.Location = New $safeprojectname$.Drawing.Point(50, 14)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New $safeprojectname$.Drawing.Size(187, 22)
        Me.BunifuCustomLabel2.TabIndex = 0
        Me.BunifuCustomLabel2.Text = "Employee Account"
        '
        'SearchRemoveAll
        '
        Me.SearchRemoveAll.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SearchRemoveAll.Image = CType(resources.GetObject("SearchRemoveAll.Image"), $safeprojectname$.Drawing.Image)
        Me.SearchRemoveAll.ImageActive = Nothing
        Me.SearchRemoveAll.Location = New $safeprojectname$.Drawing.Point(311, 194)
        Me.SearchRemoveAll.Name = "SearchRemoveAll"
        Me.SearchRemoveAll.Size = New $safeprojectname$.Drawing.Size(32, 32)
        Me.SearchRemoveAll.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SearchRemoveAll.TabIndex = 23
        Me.SearchRemoveAll.TabStop = False
        Me.SearchRemoveAll.Zoom = 10
        '
        'EmployeeAccount
        '
        Me.AutoScaleDimensions = New $safeprojectname$.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = $safeprojectname$.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New $safeprojectname$.Drawing.Size(1162, 619)
        Me.Controls.Add(Me.SearchRemoveAll)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.SearchBar)
        Me.Controls.Add(Me.EmployeeAccountList)
        Me.Controls.Add(Me.ImgDelete)
        Me.Controls.Add(Me.ImgUpdate)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.TextInfoDesk)
        Me.Controls.Add(Me.TextAdminStaff)
        Me.Controls.Add(Me.TextAll)
        Me.Controls.Add(Me.ImgAll)
        Me.Controls.Add(Me.ImgInfoDesk)
        Me.Controls.Add(Me.ImgAdminStaff)
        Me.FormBorderStyle = $safeprojectname$.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmployeeAccount"
        Me.StartPosition = $safeprojectname$.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeAccount"
        Me.WindowState = $safeprojectname$.Windows.Forms.FormWindowState.Maximized
        CType(Me.ImgAdminStaff, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgInfoDesk, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgAll, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgDelete, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgUpdate, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeAccountList, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox1, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchRemoveAll, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImgInfoDesk As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImgAdminStaff As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TextInfoDesk As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextAdminStaff As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextAll As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ImgAll As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ImgDelete As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImgUpdate As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents EmployeeAccountList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents SearchBar As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox1 As $safeprojectname$.Windows.Forms.PictureBox
    Friend WithEvents Panel29 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SearchRemoveAll As Bunifu.Framework.UI.BunifuImageButton
End Class
