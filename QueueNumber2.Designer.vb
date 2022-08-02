<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueueNumber2
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
        Dim resources As $safeprojectname$.ComponentModel.ComponentResourceManager = New $safeprojectname$.ComponentModel.ComponentResourceManager(GetType(QueueNumber2))
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel4 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Panel3 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Panel2 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Panel1 = New $safeprojectname$.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.qEnqueue = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.BunifuImageButton1, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel2.Location = New $safeprojectname$.Drawing.Point(154, 15)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New $safeprojectname$.Drawing.Size(124, 19)
        Me.BunifuCustomLabel2.TabIndex = 25
        Me.BunifuCustomLabel2.Text = "Queueing Stub"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuImageButton1.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), $safeprojectname$.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New $safeprojectname$.Drawing.Point(401, 15)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New $safeprojectname$.Drawing.Size(32, 32)
        Me.BunifuImageButton1.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 24
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel4.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New $safeprojectname$.Drawing.Point(2, 232)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New $safeprojectname$.Drawing.Size(439, 2)
        Me.Panel4.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel3.Dock = $safeprojectname$.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New $safeprojectname$.Drawing.Point(0, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New $safeprojectname$.Drawing.Size(2, 232)
        Me.Panel3.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel2.Dock = $safeprojectname$.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New $safeprojectname$.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New $safeprojectname$.Drawing.Size(441, 2)
        Me.Panel2.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel1.Dock = $safeprojectname$.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New $safeprojectname$.Drawing.Point(441, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New $safeprojectname$.Drawing.Size(2, 234)
        Me.Panel1.TabIndex = 20
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 72.0!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel1.Location = New $safeprojectname$.Drawing.Point(0, 48)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New $safeprojectname$.Drawing.Size(441, 112)
        Me.BunifuCustomLabel1.TabIndex = 19
        Me.BunifuCustomLabel1.Text = "B001"
        Me.BunifuCustomLabel1.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        '
        'qEnqueue
        '
        Me.qEnqueue.Activecolor = $safeprojectname$.Drawing.Color.Empty
        Me.qEnqueue.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.qEnqueue.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.qEnqueue.BorderRadius = 0
        Me.qEnqueue.ButtonText = "Queue"
        Me.qEnqueue.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.qEnqueue.DisabledColor = $safeprojectname$.Drawing.Color.LightCoral
        Me.qEnqueue.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 8.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qEnqueue.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.qEnqueue.Iconimage = Nothing
        Me.qEnqueue.Iconimage_right = Nothing
        Me.qEnqueue.Iconimage_right_Selected = Nothing
        Me.qEnqueue.Iconimage_Selected = Nothing
        Me.qEnqueue.IconMarginLeft = 0
        Me.qEnqueue.IconMarginRight = 0
        Me.qEnqueue.IconRightVisible = True
        Me.qEnqueue.IconRightZoom = 0.0R
        Me.qEnqueue.IconVisible = True
        Me.qEnqueue.IconZoom = 90.0R
        Me.qEnqueue.IsTab = False
        Me.qEnqueue.Location = New $safeprojectname$.Drawing.Point(158, 172)
        Me.qEnqueue.Margin = New $safeprojectname$.Windows.Forms.Padding(3, 4, 3, 4)
        Me.qEnqueue.Name = "qEnqueue"
        Me.qEnqueue.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.qEnqueue.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.qEnqueue.OnHoverTextColor = $safeprojectname$.Drawing.Color.LightGray
        Me.qEnqueue.selected = False
        Me.qEnqueue.Size = New $safeprojectname$.Drawing.Size(109, 39)
        Me.qEnqueue.TabIndex = 18
        Me.qEnqueue.Text = "Queue"
        Me.qEnqueue.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        Me.qEnqueue.Textcolor = $safeprojectname$.Drawing.Color.White
        Me.qEnqueue.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'QueueNumber2
        '
        Me.AutoScaleDimensions = New $safeprojectname$.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = $safeprojectname$.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New $safeprojectname$.Drawing.Size(443, 234)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.qEnqueue)
        Me.FormBorderStyle = $safeprojectname$.Windows.Forms.FormBorderStyle.None
        Me.Name = "QueueNumber2"
        Me.StartPosition = $safeprojectname$.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QueueNumber2"
        CType(Me.BunifuImageButton1, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel4 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel3 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel2 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel1 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents qEnqueue As Bunifu.Framework.UI.BunifuFlatButton
End Class
