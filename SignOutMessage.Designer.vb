<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignOutMessage
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
        Dim resources As $safeprojectname$.ComponentModel.ComponentResourceManager = New $safeprojectname$.ComponentModel.ComponentResourceManager(GetType(SignOutMessage))
        Me.Panel1 = New $safeprojectname$.Windows.Forms.Panel()
        Me.BtnNo = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnYes = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblTime = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel4 = New $safeprojectname$.Windows.Forms.Panel()
        Me.PictureBox1 = New $safeprojectname$.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Panel3 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Timer1 = New $safeprojectname$.Windows.Forms.Timer(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New $safeprojectname$.Drawing.Point(0, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New $safeprojectname$.Drawing.Size(365, 2)
        Me.Panel1.TabIndex = 13
        '
        'BtnNo
        '
        Me.BtnNo.ActiveBorderThickness = 1
        Me.BtnNo.ActiveCornerRadius = 20
        Me.BtnNo.ActiveFillColor = $safeprojectname$.Drawing.Color.IndianRed
        Me.BtnNo.ActiveForecolor = $safeprojectname$.Drawing.Color.White
        Me.BtnNo.ActiveLineColor = $safeprojectname$.Drawing.Color.IndianRed
        Me.BtnNo.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnNo.BackgroundImage = CType(resources.GetObject("BtnNo.BackgroundImage"), $safeprojectname$.Drawing.Image)
        Me.BtnNo.ButtonText = "No"
        Me.BtnNo.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.BtnNo.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNo.ForeColor = $safeprojectname$.Drawing.Color.White
        Me.BtnNo.IdleBorderThickness = 1
        Me.BtnNo.IdleCornerRadius = 20
        Me.BtnNo.IdleFillColor = $safeprojectname$.Drawing.Color.LightCoral
        Me.BtnNo.IdleForecolor = $safeprojectname$.Drawing.Color.White
        Me.BtnNo.IdleLineColor = $safeprojectname$.Drawing.Color.LightCoral
        Me.BtnNo.Location = New $safeprojectname$.Drawing.Point(192, 116)
        Me.BtnNo.Margin = New $safeprojectname$.Windows.Forms.Padding(5)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New $safeprojectname$.Drawing.Size(127, 41)
        Me.BtnNo.TabIndex = 10
        Me.BtnNo.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnYes
        '
        Me.BtnYes.ActiveBorderThickness = 1
        Me.BtnYes.ActiveCornerRadius = 20
        Me.BtnYes.ActiveFillColor = $safeprojectname$.Drawing.Color.SeaGreen
        Me.BtnYes.ActiveForecolor = $safeprojectname$.Drawing.Color.White
        Me.BtnYes.ActiveLineColor = $safeprojectname$.Drawing.Color.SeaGreen
        Me.BtnYes.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnYes.BackgroundImage = CType(resources.GetObject("BtnYes.BackgroundImage"), $safeprojectname$.Drawing.Image)
        Me.BtnYes.ButtonText = "Yes"
        Me.BtnYes.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.BtnYes.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnYes.ForeColor = $safeprojectname$.Drawing.Color.White
        Me.BtnYes.IdleBorderThickness = 1
        Me.BtnYes.IdleCornerRadius = 20
        Me.BtnYes.IdleFillColor = $safeprojectname$.Drawing.Color.MediumSeaGreen
        Me.BtnYes.IdleForecolor = $safeprojectname$.Drawing.Color.White
        Me.BtnYes.IdleLineColor = $safeprojectname$.Drawing.Color.MediumSeaGreen
        Me.BtnYes.Location = New $safeprojectname$.Drawing.Point(40, 116)
        Me.BtnYes.Margin = New $safeprojectname$.Windows.Forms.Padding(5)
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.Size = New $safeprojectname$.Drawing.Size(127, 43)
        Me.BtnYes.TabIndex = 9
        Me.BtnYes.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel2.Location = New $safeprojectname$.Drawing.Point(40, 75)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New $safeprojectname$.Drawing.Size(284, 21)
        Me.BunifuCustomLabel2.TabIndex = 12
        Me.BunifuCustomLabel2.Text = "Are you sure you want to Sign Out?"
        Me.BunifuCustomLabel2.TextAlign = $safeprojectname$.Drawing.ContentAlignment.TopCenter
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), $safeprojectname$.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.lblTime)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel4)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel1.Dock = $safeprojectname$.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New $safeprojectname$.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New $safeprojectname$.Drawing.Size(365, 43)
        Me.BunifuGradientPanel1.TabIndex = 11
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.lblTime.Location = New $safeprojectname$.Drawing.Point(258, 13)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New $safeprojectname$.Drawing.Size(95, 20)
        Me.lblTime.TabIndex = 7
        Me.lblTime.Text = "00:00:00 AM"
        Me.lblTime.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Panel4.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New $safeprojectname$.Drawing.Point(0, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New $safeprojectname$.Drawing.Size(365, 1)
        Me.Panel4.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), $safeprojectname$.Drawing.Image)
        Me.PictureBox1.Location = New $safeprojectname$.Drawing.Point(11, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New $safeprojectname$.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel1.Location = New $safeprojectname$.Drawing.Point(46, 12)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New $safeprojectname$.Drawing.Size(77, 21)
        Me.BunifuCustomLabel1.TabIndex = 4
        Me.BunifuCustomLabel1.Text = "Sign Out"
        '
        'Panel2
        '
        Me.Panel2.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel2.Dock = $safeprojectname$.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New $safeprojectname$.Drawing.Point(363, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New $safeprojectname$.Drawing.Size(2, 135)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel3.Dock = $safeprojectname$.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New $safeprojectname$.Drawing.Point(0, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New $safeprojectname$.Drawing.Size(2, 135)
        Me.Panel3.TabIndex = 15
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
        'SignOutMessage
        '
        Me.AutoScaleDimensions = New $safeprojectname$.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = $safeprojectname$.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New $safeprojectname$.Drawing.Size(365, 180)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnNo)
        Me.Controls.Add(Me.BtnYes)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = $safeprojectname$.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignOutMessage"
        Me.StartPosition = $safeprojectname$.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignOutMessage"
        Me.BunifuGradientPanel1.ResumeLayout(false)
        Me.BunifuGradientPanel1.PerformLayout
        CType(Me.PictureBox1,$safeprojectname$.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Panel1 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents BtnNo As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnYes As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panel4 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As $safeprojectname$.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel3 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents lblTime As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Timer1 As $safeprojectname$.Windows.Forms.Timer
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
