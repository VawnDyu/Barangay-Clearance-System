<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Dim resources As $safeprojectname$.ComponentModel.ComponentResourceManager = New $safeprojectname$.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Panel4 = New $safeprojectname$.Windows.Forms.Panel()
        Me.FormClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New $safeprojectname$.Windows.Forms.PictureBox()
        Me.Panel29 = New $safeprojectname$.Windows.Forms.Panel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.FormClose, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), $safeprojectname$.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel4)
        Me.BunifuGradientPanel1.Controls.Add(Me.FormClose)
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
        Me.BunifuGradientPanel1.Size = New $safeprojectname$.Drawing.Size(1161, 56)
        Me.BunifuGradientPanel1.TabIndex = 42
        '
        'Panel4
        '
        Me.Panel4.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Panel4.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New $safeprojectname$.Drawing.Point(0, 54)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New $safeprojectname$.Drawing.Size(1161, 1)
        Me.Panel4.TabIndex = 46
        '
        'FormClose
        '
        Me.FormClose.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FormClose.Image = CType(resources.GetObject("FormClose.Image"), $safeprojectname$.Drawing.Image)
        Me.FormClose.ImageActive = Nothing
        Me.FormClose.Location = New $safeprojectname$.Drawing.Point(1121, 10)
        Me.FormClose.Name = "FormClose"
        Me.FormClose.Size = New $safeprojectname$.Drawing.Size(32, 32)
        Me.FormClose.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FormClose.TabIndex = 44
        Me.FormClose.TabStop = False
        Me.FormClose.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), $safeprojectname$.Drawing.Image)
        Me.PictureBox1.Location = New $safeprojectname$.Drawing.Point(12, 16)
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
        Me.Panel29.Location = New $safeprojectname$.Drawing.Point(0, 55)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New $safeprojectname$.Drawing.Size(1161, 1)
        Me.Panel29.TabIndex = 2
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 15.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel2.Location = New $safeprojectname$.Drawing.Point(44, 16)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New $safeprojectname$.Drawing.Size(121, 24)
        Me.BunifuCustomLabel2.TabIndex = 0
        Me.BunifuCustomLabel2.Text = "Clearance"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = $safeprojectname$.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = $safeprojectname$.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New $safeprojectname$.Drawing.Point(0, 56)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New $safeprojectname$.Drawing.Size(1161, 651)
        Me.CrystalReportViewer1.TabIndex = 43
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Form
        '
        Me.AutoScaleDimensions = New $safeprojectname$.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = $safeprojectname$.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New $safeprojectname$.Drawing.Size(1161, 707)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = $safeprojectname$.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form"
        Me.StartPosition = $safeprojectname$.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.FormClose, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox1 As $safeprojectname$.Windows.Forms.PictureBox
    Friend WithEvents Panel29 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents FormClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel4 As $safeprojectname$.Windows.Forms.Panel
End Class
