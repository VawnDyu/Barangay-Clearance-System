<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountNavBar
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
        Dim resources As $safeprojectname$.ComponentModel.ComponentResourceManager = New $safeprojectname$.ComponentModel.ComponentResourceManager(GetType(AccountNavBar))
        Me.PanelNavBar = New $safeprojectname$.Windows.Forms.Panel()
        Me.BtnDashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnAttendanceRecord = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnAddEmployee = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnEmployeeAccount = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnSignOut = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelNavBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelNavBar
        '
        Me.PanelNavBar.Controls.Add(Me.BtnDashboard)
        Me.PanelNavBar.Controls.Add(Me.BtnAttendanceRecord)
        Me.PanelNavBar.Controls.Add(Me.BtnAddEmployee)
        Me.PanelNavBar.Controls.Add(Me.BtnEmployeeAccount)
        Me.PanelNavBar.Controls.Add(Me.BtnSignOut)
        Me.PanelNavBar.Dock = $safeprojectname$.Windows.Forms.DockStyle.Top
        Me.PanelNavBar.Location = New $safeprojectname$.Drawing.Point(0, 0)
        Me.PanelNavBar.Name = "PanelNavBar"
        Me.PanelNavBar.Size = New $safeprojectname$.Drawing.Size(227, 264)
        Me.PanelNavBar.TabIndex = 16
        '
        'BtnDashboard
        '
        Me.BtnDashboard.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnDashboard.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnDashboard.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.BtnDashboard.BorderRadius = 0
        Me.BtnDashboard.ButtonText = "Dashboard"
        Me.BtnDashboard.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.BtnDashboard.DisabledColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnDashboard.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.BtnDashboard.Iconimage = CType(resources.GetObject("BtnDashboard.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.BtnDashboard.Iconimage_right = Nothing
        Me.BtnDashboard.Iconimage_right_Selected = Nothing
        Me.BtnDashboard.Iconimage_Selected = Nothing
        Me.BtnDashboard.IconMarginLeft = 20
        Me.BtnDashboard.IconMarginRight = 0
        Me.BtnDashboard.IconRightVisible = True
        Me.BtnDashboard.IconRightZoom = 0.0R
        Me.BtnDashboard.IconVisible = True
        Me.BtnDashboard.IconZoom = 40.0R
        Me.BtnDashboard.IsTab = False
        Me.BtnDashboard.Location = New $safeprojectname$.Drawing.Point(0, -1)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnDashboard.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnDashboard.OnHoverTextColor = $safeprojectname$.Drawing.Color.White
        Me.BtnDashboard.selected = False
        Me.BtnDashboard.Size = New $safeprojectname$.Drawing.Size(228, 53)
        Me.BtnDashboard.TabIndex = 12
        Me.BtnDashboard.Text = "Dashboard"
        Me.BtnDashboard.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        Me.BtnDashboard.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.BtnDashboard.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnAttendanceRecord
        '
        Me.BtnAttendanceRecord.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnAttendanceRecord.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnAttendanceRecord.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.BtnAttendanceRecord.BorderRadius = 0
        Me.BtnAttendanceRecord.ButtonText = "Attendance Record"
        Me.BtnAttendanceRecord.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.BtnAttendanceRecord.DisabledColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnAttendanceRecord.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.BtnAttendanceRecord.Iconimage = CType(resources.GetObject("BtnAttendanceRecord.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.BtnAttendanceRecord.Iconimage_right = Nothing
        Me.BtnAttendanceRecord.Iconimage_right_Selected = Nothing
        Me.BtnAttendanceRecord.Iconimage_Selected = Nothing
        Me.BtnAttendanceRecord.IconMarginLeft = 18
        Me.BtnAttendanceRecord.IconMarginRight = 0
        Me.BtnAttendanceRecord.IconRightVisible = True
        Me.BtnAttendanceRecord.IconRightZoom = 0.0R
        Me.BtnAttendanceRecord.IconVisible = True
        Me.BtnAttendanceRecord.IconZoom = 45.0R
        Me.BtnAttendanceRecord.IsTab = False
        Me.BtnAttendanceRecord.Location = New $safeprojectname$.Drawing.Point(0, 154)
        Me.BtnAttendanceRecord.Name = "BtnAttendanceRecord"
        Me.BtnAttendanceRecord.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnAttendanceRecord.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnAttendanceRecord.OnHoverTextColor = $safeprojectname$.Drawing.Color.White
        Me.BtnAttendanceRecord.selected = False
        Me.BtnAttendanceRecord.Size = New $safeprojectname$.Drawing.Size(228, 53)
        Me.BtnAttendanceRecord.TabIndex = 11
        Me.BtnAttendanceRecord.Text = "Attendance Record"
        Me.BtnAttendanceRecord.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleRight
        Me.BtnAttendanceRecord.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.BtnAttendanceRecord.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnAddEmployee
        '
        Me.BtnAddEmployee.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnAddEmployee.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnAddEmployee.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddEmployee.BorderRadius = 0
        Me.BtnAddEmployee.ButtonText = "   Add Employee"
        Me.BtnAddEmployee.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.BtnAddEmployee.DisabledColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnAddEmployee.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.BtnAddEmployee.Iconimage = CType(resources.GetObject("BtnAddEmployee.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.BtnAddEmployee.Iconimage_right = Nothing
        Me.BtnAddEmployee.Iconimage_right_Selected = Nothing
        Me.BtnAddEmployee.Iconimage_Selected = Nothing
        Me.BtnAddEmployee.IconMarginLeft = 20
        Me.BtnAddEmployee.IconMarginRight = 0
        Me.BtnAddEmployee.IconRightVisible = True
        Me.BtnAddEmployee.IconRightZoom = 0.0R
        Me.BtnAddEmployee.IconVisible = True
        Me.BtnAddEmployee.IconZoom = 40.0R
        Me.BtnAddEmployee.IsTab = False
        Me.BtnAddEmployee.Location = New $safeprojectname$.Drawing.Point(0, 102)
        Me.BtnAddEmployee.Name = "BtnAddEmployee"
        Me.BtnAddEmployee.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnAddEmployee.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnAddEmployee.OnHoverTextColor = $safeprojectname$.Drawing.Color.White
        Me.BtnAddEmployee.selected = False
        Me.BtnAddEmployee.Size = New $safeprojectname$.Drawing.Size(228, 53)
        Me.BtnAddEmployee.TabIndex = 2
        Me.BtnAddEmployee.Text = "   Add Employee"
        Me.BtnAddEmployee.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAddEmployee.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.BtnAddEmployee.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnEmployeeAccount
        '
        Me.BtnEmployeeAccount.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnEmployeeAccount.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnEmployeeAccount.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.BtnEmployeeAccount.BorderRadius = 0
        Me.BtnEmployeeAccount.ButtonText = "   Employee Account"
        Me.BtnEmployeeAccount.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.BtnEmployeeAccount.DisabledColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnEmployeeAccount.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.BtnEmployeeAccount.Iconimage = CType(resources.GetObject("BtnEmployeeAccount.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.BtnEmployeeAccount.Iconimage_right = Nothing
        Me.BtnEmployeeAccount.Iconimage_right_Selected = Nothing
        Me.BtnEmployeeAccount.Iconimage_Selected = Nothing
        Me.BtnEmployeeAccount.IconMarginLeft = 20
        Me.BtnEmployeeAccount.IconMarginRight = 0
        Me.BtnEmployeeAccount.IconRightVisible = True
        Me.BtnEmployeeAccount.IconRightZoom = 0.0R
        Me.BtnEmployeeAccount.IconVisible = True
        Me.BtnEmployeeAccount.IconZoom = 40.0R
        Me.BtnEmployeeAccount.IsTab = False
        Me.BtnEmployeeAccount.Location = New $safeprojectname$.Drawing.Point(0, 51)
        Me.BtnEmployeeAccount.Name = "BtnEmployeeAccount"
        Me.BtnEmployeeAccount.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnEmployeeAccount.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnEmployeeAccount.OnHoverTextColor = $safeprojectname$.Drawing.Color.White
        Me.BtnEmployeeAccount.selected = False
        Me.BtnEmployeeAccount.Size = New $safeprojectname$.Drawing.Size(228, 53)
        Me.BtnEmployeeAccount.TabIndex = 1
        Me.BtnEmployeeAccount.Text = "   Employee Account"
        Me.BtnEmployeeAccount.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        Me.BtnEmployeeAccount.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.BtnEmployeeAccount.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnSignOut
        '
        Me.BtnSignOut.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnSignOut.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnSignOut.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.BtnSignOut.BorderRadius = 0
        Me.BtnSignOut.ButtonText = "Sign Out"
        Me.BtnSignOut.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.BtnSignOut.DisabledColor = $safeprojectname$.Drawing.Color.Gray
        Me.BtnSignOut.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.BtnSignOut.Iconimage = CType(resources.GetObject("BtnSignOut.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.BtnSignOut.Iconimage_right = Nothing
        Me.BtnSignOut.Iconimage_right_Selected = Nothing
        Me.BtnSignOut.Iconimage_Selected = Nothing
        Me.BtnSignOut.IconMarginLeft = 21
        Me.BtnSignOut.IconMarginRight = 0
        Me.BtnSignOut.IconRightVisible = True
        Me.BtnSignOut.IconRightZoom = 0.0R
        Me.BtnSignOut.IconVisible = True
        Me.BtnSignOut.IconZoom = 45.0R
        Me.BtnSignOut.IsTab = False
        Me.BtnSignOut.Location = New $safeprojectname$.Drawing.Point(0, 206)
        Me.BtnSignOut.Name = "BtnSignOut"
        Me.BtnSignOut.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnSignOut.OnHovercolor = $safeprojectname$.Drawing.Color.LightCoral
        Me.BtnSignOut.OnHoverTextColor = $safeprojectname$.Drawing.Color.White
        Me.BtnSignOut.selected = False
        Me.BtnSignOut.Size = New $safeprojectname$.Drawing.Size(228, 53)
        Me.BtnSignOut.TabIndex = 10
        Me.BtnSignOut.Text = "Sign Out"
        Me.BtnSignOut.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSignOut.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.BtnSignOut.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'AccountNavBar
        '
        Me.AutoScaleDimensions = New $safeprojectname$.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = $safeprojectname$.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New $safeprojectname$.Drawing.Size(227, 264)
        Me.Controls.Add(Me.PanelNavBar)
        Me.FormBorderStyle = $safeprojectname$.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountNavBar"
        Me.Text = "AccountNavBar"
        Me.PanelNavBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelNavBar As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents BtnDashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnAttendanceRecord As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnAddEmployee As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnEmployeeAccount As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnSignOut As Bunifu.Framework.UI.BunifuFlatButton
End Class
