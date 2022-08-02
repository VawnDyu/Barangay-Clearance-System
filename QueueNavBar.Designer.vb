<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueueNavBar
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
        Dim resources As $safeprojectname$.ComponentModel.ComponentResourceManager = New $safeprojectname$.ComponentModel.ComponentResourceManager(GetType(QueueNavBar))
        Me.Panel15 = New $safeprojectname$.Windows.Forms.Panel()
        Me.btnQueueDashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnSignOut = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnQueueWindow = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnQueueController = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel15.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.btnQueueDashboard)
        Me.Panel15.Controls.Add(Me.BtnSignOut)
        Me.Panel15.Controls.Add(Me.btnQueueWindow)
        Me.Panel15.Controls.Add(Me.btnQueueController)
        Me.Panel15.Dock = $safeprojectname$.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New $safeprojectname$.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New $safeprojectname$.Drawing.Size(227, 264)
        Me.Panel15.TabIndex = 16
        '
        'btnQueueDashboard
        '
        Me.btnQueueDashboard.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnQueueDashboard.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnQueueDashboard.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.btnQueueDashboard.BorderRadius = 0
        Me.btnQueueDashboard.ButtonText = "Dashboard"
        Me.btnQueueDashboard.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.btnQueueDashboard.DisabledColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnQueueDashboard.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.btnQueueDashboard.Iconimage = CType(resources.GetObject("btnQueueDashboard.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.btnQueueDashboard.Iconimage_right = Nothing
        Me.btnQueueDashboard.Iconimage_right_Selected = Nothing
        Me.btnQueueDashboard.Iconimage_Selected = Nothing
        Me.btnQueueDashboard.IconMarginLeft = 20
        Me.btnQueueDashboard.IconMarginRight = 0
        Me.btnQueueDashboard.IconRightVisible = True
        Me.btnQueueDashboard.IconRightZoom = 0.0R
        Me.btnQueueDashboard.IconVisible = True
        Me.btnQueueDashboard.IconZoom = 40.0R
        Me.btnQueueDashboard.IsTab = False
        Me.btnQueueDashboard.Location = New $safeprojectname$.Drawing.Point(0, 0)
        Me.btnQueueDashboard.Name = "btnQueueDashboard"
        Me.btnQueueDashboard.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnQueueDashboard.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnQueueDashboard.OnHoverTextColor = $safeprojectname$.Drawing.Color.White
        Me.btnQueueDashboard.selected = False
        Me.btnQueueDashboard.Size = New $safeprojectname$.Drawing.Size(228, 53)
        Me.btnQueueDashboard.TabIndex = 14
        Me.btnQueueDashboard.Text = "Dashboard"
        Me.btnQueueDashboard.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        Me.btnQueueDashboard.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.btnQueueDashboard.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'btnQueueWindow
        '
        Me.btnQueueWindow.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnQueueWindow.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnQueueWindow.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.btnQueueWindow.BorderRadius = 0
        Me.btnQueueWindow.ButtonText = "Queue Window"
        Me.btnQueueWindow.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.btnQueueWindow.DisabledColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnQueueWindow.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.btnQueueWindow.Iconimage = CType(resources.GetObject("btnQueueWindow.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.btnQueueWindow.Iconimage_right = Nothing
        Me.btnQueueWindow.Iconimage_right_Selected = Nothing
        Me.btnQueueWindow.Iconimage_Selected = Nothing
        Me.btnQueueWindow.IconMarginLeft = 20
        Me.btnQueueWindow.IconMarginRight = 0
        Me.btnQueueWindow.IconRightVisible = True
        Me.btnQueueWindow.IconRightZoom = 0.0R
        Me.btnQueueWindow.IconVisible = True
        Me.btnQueueWindow.IconZoom = 40.0R
        Me.btnQueueWindow.IsTab = False
        Me.btnQueueWindow.Location = New $safeprojectname$.Drawing.Point(0, 50)
        Me.btnQueueWindow.Name = "btnQueueWindow"
        Me.btnQueueWindow.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnQueueWindow.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnQueueWindow.OnHoverTextColor = $safeprojectname$.Drawing.Color.White
        Me.btnQueueWindow.selected = False
        Me.btnQueueWindow.Size = New $safeprojectname$.Drawing.Size(228, 53)
        Me.btnQueueWindow.TabIndex = 13
        Me.btnQueueWindow.Text = "Queue Window"
        Me.btnQueueWindow.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        Me.btnQueueWindow.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.btnQueueWindow.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnQueueController
        '
        Me.btnQueueController.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnQueueController.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnQueueController.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.btnQueueController.BorderRadius = 0
        Me.btnQueueController.ButtonText = "Queue Controller"
        Me.btnQueueController.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.btnQueueController.DisabledColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnQueueController.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.btnQueueController.Iconimage = CType(resources.GetObject("btnQueueController.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.btnQueueController.Iconimage_right = Nothing
        Me.btnQueueController.Iconimage_right_Selected = Nothing
        Me.btnQueueController.Iconimage_Selected = Nothing
        Me.btnQueueController.IconMarginLeft = 20
        Me.btnQueueController.IconMarginRight = 0
        Me.btnQueueController.IconRightVisible = True
        Me.btnQueueController.IconRightZoom = 0.0R
        Me.btnQueueController.IconVisible = True
        Me.btnQueueController.IconZoom = 40.0R
        Me.btnQueueController.IsTab = False
        Me.btnQueueController.Location = New $safeprojectname$.Drawing.Point(0, 101)
        Me.btnQueueController.Name = "btnQueueController"
        Me.btnQueueController.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnQueueController.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnQueueController.OnHoverTextColor = $safeprojectname$.Drawing.Color.White
        Me.btnQueueController.selected = False
        Me.btnQueueController.Size = New $safeprojectname$.Drawing.Size(228, 53)
        Me.btnQueueController.TabIndex = 1
        Me.btnQueueController.Text = "Queue Controller"
        Me.btnQueueController.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        Me.btnQueueController.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.btnQueueController.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'QueueNavBar
        '
        Me.AutoScaleDimensions = New $safeprojectname$.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = $safeprojectname$.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New $safeprojectname$.Drawing.Size(227, 264)
        Me.Controls.Add(Me.Panel15)
        Me.FormBorderStyle = $safeprojectname$.Windows.Forms.FormBorderStyle.None
        Me.Name = "QueueNavBar"
        Me.Text = "QueueNavBar"
        Me.Panel15.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel15 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents btnQueueController As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnSignOut As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnQueueWindow As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnQueueDashboard As Bunifu.Framework.UI.BunifuFlatButton
End Class
