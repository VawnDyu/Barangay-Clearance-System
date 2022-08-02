<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClearanceNavBar
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
        Dim resources As $safeprojectname$.ComponentModel.ComponentResourceManager = New $safeprojectname$.ComponentModel.ComponentResourceManager(GetType(ClearanceNavBar))
        Me.Panel15 = New $safeprojectname$.Windows.Forms.Panel()
        Me.btnClearance = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnClearanceDashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnSignOut = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAddResident = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel15.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel15
        '
        Me.Panel15.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel15.Controls.Add(Me.btnClearance)
        Me.Panel15.Controls.Add(Me.btnClearanceDashboard)
        Me.Panel15.Controls.Add(Me.BtnSignOut)
        Me.Panel15.Controls.Add(Me.btnAddResident)
        Me.Panel15.Dock = $safeprojectname$.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New $safeprojectname$.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New $safeprojectname$.Drawing.Size(227, 264)
        Me.Panel15.TabIndex = 17
        '
        'btnClearance
        '
        Me.btnClearance.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnClearance.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnClearance.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.btnClearance.BorderRadius = 0
        Me.btnClearance.ButtonText = "Clearance"
        Me.btnClearance.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.btnClearance.DisabledColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnClearance.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.btnClearance.Iconimage = CType(resources.GetObject("btnClearance.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.btnClearance.Iconimage_right = Nothing
        Me.btnClearance.Iconimage_right_Selected = Nothing
        Me.btnClearance.Iconimage_Selected = Nothing
        Me.btnClearance.IconMarginLeft = 20
        Me.btnClearance.IconMarginRight = 0
        Me.btnClearance.IconRightVisible = True
        Me.btnClearance.IconRightZoom = 0.0R
        Me.btnClearance.IconVisible = True
        Me.btnClearance.IconZoom = 40.0R
        Me.btnClearance.IsTab = False
        Me.btnClearance.Location = New $safeprojectname$.Drawing.Point(0, 52)
        Me.btnClearance.Name = "btnClearance"
        Me.btnClearance.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnClearance.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnClearance.OnHoverTextColor = $safeprojectname$.Drawing.Color.White
        Me.btnClearance.selected = False
        Me.btnClearance.Size = New $safeprojectname$.Drawing.Size(228, 53)
        Me.btnClearance.TabIndex = 15
        Me.btnClearance.Text = "Clearance"
        Me.btnClearance.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        Me.btnClearance.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.btnClearance.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnClearanceDashboard
        '
        Me.btnClearanceDashboard.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnClearanceDashboard.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnClearanceDashboard.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.btnClearanceDashboard.BorderRadius = 0
        Me.btnClearanceDashboard.ButtonText = "Dashboard"
        Me.btnClearanceDashboard.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.btnClearanceDashboard.DisabledColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnClearanceDashboard.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.btnClearanceDashboard.Iconimage = CType(resources.GetObject("btnClearanceDashboard.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.btnClearanceDashboard.Iconimage_right = Nothing
        Me.btnClearanceDashboard.Iconimage_right_Selected = Nothing
        Me.btnClearanceDashboard.Iconimage_Selected = Nothing
        Me.btnClearanceDashboard.IconMarginLeft = 20
        Me.btnClearanceDashboard.IconMarginRight = 0
        Me.btnClearanceDashboard.IconRightVisible = True
        Me.btnClearanceDashboard.IconRightZoom = 0.0R
        Me.btnClearanceDashboard.IconVisible = True
        Me.btnClearanceDashboard.IconZoom = 40.0R
        Me.btnClearanceDashboard.IsTab = False
        Me.btnClearanceDashboard.Location = New $safeprojectname$.Drawing.Point(0, 0)
        Me.btnClearanceDashboard.Name = "btnClearanceDashboard"
        Me.btnClearanceDashboard.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnClearanceDashboard.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnClearanceDashboard.OnHoverTextColor = $safeprojectname$.Drawing.Color.White
        Me.btnClearanceDashboard.selected = False
        Me.btnClearanceDashboard.Size = New $safeprojectname$.Drawing.Size(228, 53)
        Me.btnClearanceDashboard.TabIndex = 14
        Me.btnClearanceDashboard.Text = "Dashboard"
        Me.btnClearanceDashboard.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        Me.btnClearanceDashboard.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.btnClearanceDashboard.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'btnAddResident
        '
        Me.btnAddResident.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAddResident.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAddResident.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.btnAddResident.BorderRadius = 0
        Me.btnAddResident.ButtonText = "Add Resident"
        Me.btnAddResident.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.btnAddResident.DisabledColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnAddResident.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.btnAddResident.Iconimage = CType(resources.GetObject("btnAddResident.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.btnAddResident.Iconimage_right = Nothing
        Me.btnAddResident.Iconimage_right_Selected = Nothing
        Me.btnAddResident.Iconimage_Selected = Nothing
        Me.btnAddResident.IconMarginLeft = 20
        Me.btnAddResident.IconMarginRight = 0
        Me.btnAddResident.IconRightVisible = True
        Me.btnAddResident.IconRightZoom = 0.0R
        Me.btnAddResident.IconVisible = True
        Me.btnAddResident.IconZoom = 40.0R
        Me.btnAddResident.IsTab = False
        Me.btnAddResident.Location = New $safeprojectname$.Drawing.Point(0, 101)
        Me.btnAddResident.Name = "btnAddResident"
        Me.btnAddResident.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAddResident.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnAddResident.OnHoverTextColor = $safeprojectname$.Drawing.Color.White
        Me.btnAddResident.selected = False
        Me.btnAddResident.Size = New $safeprojectname$.Drawing.Size(228, 53)
        Me.btnAddResident.TabIndex = 1
        Me.btnAddResident.Text = "Add Resident"
        Me.btnAddResident.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        Me.btnAddResident.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.btnAddResident.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ClearanceNavBar
        '
        Me.AutoScaleDimensions = New $safeprojectname$.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = $safeprojectname$.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New $safeprojectname$.Drawing.Size(227, 264)
        Me.Controls.Add(Me.Panel15)
        Me.FormBorderStyle = $safeprojectname$.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClearanceNavBar"
        Me.Text = "ClearanceNavBar"
        Me.Panel15.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel15 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents btnClearanceDashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnSignOut As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAddResident As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnClearance As Bunifu.Framework.UI.BunifuFlatButton
End Class
