<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueueController2
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
        Dim resources As $safeprojectname$.ComponentModel.ComponentResourceManager = New $safeprojectname$.ComponentModel.ComponentResourceManager(GetType(QueueController2))
        Dim DataGridViewCellStyle1 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel4 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Panel6 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Panel3 = New $safeprojectname$.Windows.Forms.Panel()
        Me.qEnqueue = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.qCall = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.qDequeue = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.qVoid = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Panel1 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Panel11 = New $safeprojectname$.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel5 = New $safeprojectname$.Windows.Forms.Panel()
        Me.PictureBox1 = New $safeprojectname$.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Window2Queue = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.BunifuImageButton1, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.Window2Queue, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 20.25!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel2.Location = New $safeprojectname$.Drawing.Point(86, 12)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New $safeprojectname$.Drawing.Size(99, 32)
        Me.BunifuCustomLabel2.TabIndex = 5
        Me.BunifuCustomLabel2.Text = "Action"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel4.Dock = $safeprojectname$.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New $safeprojectname$.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New $safeprojectname$.Drawing.Size(276, 47)
        Me.Panel4.TabIndex = 17
        '
        'Panel6
        '
        Me.Panel6.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel6.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New $safeprojectname$.Drawing.Point(0, 45)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New $safeprojectname$.Drawing.Size(276, 2)
        Me.Panel6.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.qEnqueue)
        Me.Panel3.Controls.Add(Me.qCall)
        Me.Panel3.Controls.Add(Me.qDequeue)
        Me.Panel3.Controls.Add(Me.qVoid)
        Me.Panel3.Location = New $safeprojectname$.Drawing.Point(234, 66)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New $safeprojectname$.Drawing.Size(276, 190)
        Me.Panel3.TabIndex = 23
        '
        'qEnqueue
        '
        Me.qEnqueue.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.qEnqueue.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.qEnqueue.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.qEnqueue.BorderRadius = 0
        Me.qEnqueue.ButtonText = "Queue"
        Me.qEnqueue.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.qEnqueue.DisabledColor = $safeprojectname$.Drawing.Color.LightCoral
        Me.qEnqueue.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 8.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qEnqueue.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.qEnqueue.Iconimage = CType(resources.GetObject("qEnqueue.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.qEnqueue.Iconimage_right = Nothing
        Me.qEnqueue.Iconimage_right_Selected = Nothing
        Me.qEnqueue.Iconimage_Selected = Nothing
        Me.qEnqueue.IconMarginLeft = 0
        Me.qEnqueue.IconMarginRight = 0
        Me.qEnqueue.IconRightVisible = True
        Me.qEnqueue.IconRightZoom = 0.0R
        Me.qEnqueue.IconVisible = True
        Me.qEnqueue.IconZoom = 40.0R
        Me.qEnqueue.IsTab = False
        Me.qEnqueue.Location = New $safeprojectname$.Drawing.Point(22, 74)
        Me.qEnqueue.Margin = New $safeprojectname$.Windows.Forms.Padding(3, 4, 3, 4)
        Me.qEnqueue.Name = "qEnqueue"
        Me.qEnqueue.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.qEnqueue.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.qEnqueue.OnHoverTextColor = $safeprojectname$.Drawing.Color.LightGray
        Me.qEnqueue.selected = False
        Me.qEnqueue.Size = New $safeprojectname$.Drawing.Size(110, 39)
        Me.qEnqueue.TabIndex = 9
        Me.qEnqueue.Text = "Queue"
        Me.qEnqueue.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        Me.qEnqueue.Textcolor = $safeprojectname$.Drawing.Color.White
        Me.qEnqueue.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'qCall
        '
        Me.qCall.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.qCall.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.qCall.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.qCall.BorderRadius = 0
        Me.qCall.ButtonText = "Call"
        Me.qCall.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.qCall.DisabledColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.qCall.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 8.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qCall.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.qCall.Iconimage = CType(resources.GetObject("qCall.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.qCall.Iconimage_right = Nothing
        Me.qCall.Iconimage_right_Selected = Nothing
        Me.qCall.Iconimage_Selected = Nothing
        Me.qCall.IconMarginLeft = 0
        Me.qCall.IconMarginRight = 0
        Me.qCall.IconRightVisible = True
        Me.qCall.IconRightZoom = 0.0R
        Me.qCall.IconVisible = True
        Me.qCall.IconZoom = 90.0R
        Me.qCall.IsTab = False
        Me.qCall.Location = New $safeprojectname$.Drawing.Point(22, 133)
        Me.qCall.Margin = New $safeprojectname$.Windows.Forms.Padding(3, 4, 3, 4)
        Me.qCall.Name = "qCall"
        Me.qCall.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.qCall.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.qCall.OnHoverTextColor = $safeprojectname$.Drawing.Color.LightGray
        Me.qCall.selected = False
        Me.qCall.Size = New $safeprojectname$.Drawing.Size(110, 39)
        Me.qCall.TabIndex = 16
        Me.qCall.Text = "Call"
        Me.qCall.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleLeft
        Me.qCall.Textcolor = $safeprojectname$.Drawing.Color.White
        Me.qCall.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'qDequeue
        '
        Me.qDequeue.Activecolor = $safeprojectname$.Drawing.Color.SeaGreen
        Me.qDequeue.BackColor = $safeprojectname$.Drawing.Color.SeaGreen
        Me.qDequeue.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.qDequeue.BorderRadius = 0
        Me.qDequeue.ButtonText = "Dequeue"
        Me.qDequeue.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.qDequeue.DisabledColor = $safeprojectname$.Drawing.Color.IndianRed
        Me.qDequeue.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qDequeue.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.qDequeue.Iconimage = CType(resources.GetObject("qDequeue.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.qDequeue.Iconimage_right = Nothing
        Me.qDequeue.Iconimage_right_Selected = Nothing
        Me.qDequeue.Iconimage_Selected = Nothing
        Me.qDequeue.IconMarginLeft = 0
        Me.qDequeue.IconMarginRight = 0
        Me.qDequeue.IconRightVisible = True
        Me.qDequeue.IconRightZoom = 0.0R
        Me.qDequeue.IconVisible = True
        Me.qDequeue.IconZoom = 80.0R
        Me.qDequeue.IsTab = False
        Me.qDequeue.Location = New $safeprojectname$.Drawing.Point(149, 74)
        Me.qDequeue.Margin = New $safeprojectname$.Windows.Forms.Padding(3, 4, 3, 4)
        Me.qDequeue.Name = "qDequeue"
        Me.qDequeue.Normalcolor = $safeprojectname$.Drawing.Color.SeaGreen
        Me.qDequeue.OnHovercolor = $safeprojectname$.Drawing.Color.SeaGreen
        Me.qDequeue.OnHoverTextColor = $safeprojectname$.Drawing.Color.LightGray
        Me.qDequeue.selected = False
        Me.qDequeue.Size = New $safeprojectname$.Drawing.Size(110, 39)
        Me.qDequeue.TabIndex = 8
        Me.qDequeue.Text = "Dequeue"
        Me.qDequeue.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleLeft
        Me.qDequeue.Textcolor = $safeprojectname$.Drawing.Color.White
        Me.qDequeue.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 9.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'qVoid
        '
        Me.qVoid.Activecolor = $safeprojectname$.Drawing.Color.IndianRed
        Me.qVoid.BackColor = $safeprojectname$.Drawing.Color.IndianRed
        Me.qVoid.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.qVoid.BorderRadius = 0
        Me.qVoid.ButtonText = "Void"
        Me.qVoid.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.qVoid.DisabledColor = $safeprojectname$.Drawing.Color.IndianRed
        Me.qVoid.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 8.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qVoid.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.qVoid.Iconimage = CType(resources.GetObject("qVoid.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.qVoid.Iconimage_right = Nothing
        Me.qVoid.Iconimage_right_Selected = Nothing
        Me.qVoid.Iconimage_Selected = Nothing
        Me.qVoid.IconMarginLeft = 0
        Me.qVoid.IconMarginRight = 0
        Me.qVoid.IconRightVisible = True
        Me.qVoid.IconRightZoom = 0.0R
        Me.qVoid.IconVisible = True
        Me.qVoid.IconZoom = 40.0R
        Me.qVoid.IsTab = False
        Me.qVoid.Location = New $safeprojectname$.Drawing.Point(149, 133)
        Me.qVoid.Margin = New $safeprojectname$.Windows.Forms.Padding(3, 4, 3, 4)
        Me.qVoid.Name = "qVoid"
        Me.qVoid.Normalcolor = $safeprojectname$.Drawing.Color.IndianRed
        Me.qVoid.OnHovercolor = $safeprojectname$.Drawing.Color.IndianRed
        Me.qVoid.OnHoverTextColor = $safeprojectname$.Drawing.Color.LightGray
        Me.qVoid.selected = False
        Me.qVoid.Size = New $safeprojectname$.Drawing.Size(110, 39)
        Me.qVoid.TabIndex = 15
        Me.qVoid.Text = "Void"
        Me.qVoid.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        Me.qVoid.Textcolor = $safeprojectname$.Drawing.Color.White
        Me.qVoid.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel2.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New $safeprojectname$.Drawing.Point(1, 277)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New $safeprojectname$.Drawing.Size(552, 1)
        Me.Panel2.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel1.Dock = $safeprojectname$.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New $safeprojectname$.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New $safeprojectname$.Drawing.Size(1, 235)
        Me.Panel1.TabIndex = 21
        '
        'Panel11
        '
        Me.Panel11.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel11.Dock = $safeprojectname$.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New $safeprojectname$.Drawing.Point(553, 43)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New $safeprojectname$.Drawing.Size(1, 235)
        Me.Panel11.TabIndex = 20
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuImageButton1.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), $safeprojectname$.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New $safeprojectname$.Drawing.Point(514, 5)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New $safeprojectname$.Drawing.Size(32, 32)
        Me.BunifuImageButton1.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 17
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Panel5
        '
        Me.Panel5.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel5.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New $safeprojectname$.Drawing.Point(0, 41)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New $safeprojectname$.Drawing.Size(554, 2)
        Me.Panel5.TabIndex = 6
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
        Me.BunifuCustomLabel1.Size = New $safeprojectname$.Drawing.Size(233, 21)
        Me.BunifuCustomLabel1.TabIndex = 4
        Me.BunifuCustomLabel1.Text = "Window 2 - Queue Controller"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), $safeprojectname$.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel5)
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
        Me.BunifuGradientPanel1.Size = New $safeprojectname$.Drawing.Size(554, 43)
        Me.BunifuGradientPanel1.TabIndex = 19
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.BunifuGradientPanel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Window2Queue
        '
        Me.Window2Queue.AllowUserToAddRows = False
        Me.Window2Queue.AllowUserToDeleteRows = False
        Me.Window2Queue.AllowUserToResizeColumns = False
        Me.Window2Queue.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window2Queue.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Window2Queue.AutoSizeColumnsMode = $safeprojectname$.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Window2Queue.AutoSizeRowsMode = $safeprojectname$.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Window2Queue.BackgroundColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window2Queue.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.None
        Me.Window2Queue.ColumnHeadersBorderStyle = $safeprojectname$.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle2.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = $safeprojectname$.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = $safeprojectname$.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = $safeprojectname$.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[True]
        Me.Window2Queue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Window2Queue.ColumnHeadersHeight = 30
        Me.Window2Queue.ColumnHeadersHeightSizeMode = $safeprojectname$.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle3.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 14.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        DataGridViewCellStyle3.NullValue = "Empty"
        DataGridViewCellStyle3.Padding = New $safeprojectname$.Windows.Forms.Padding(7)
        DataGridViewCellStyle3.SelectionBackColor = $safeprojectname$.Drawing.Color.IndianRed
        DataGridViewCellStyle3.SelectionForeColor = $safeprojectname$.Drawing.Color.LightGray
        DataGridViewCellStyle3.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[False]
        Me.Window2Queue.DefaultCellStyle = DataGridViewCellStyle3
        Me.Window2Queue.DoubleBuffered = True
        Me.Window2Queue.EnableHeadersVisualStyles = False
        Me.Window2Queue.GridColor = $safeprojectname$.Drawing.Color.DimGray
        Me.Window2Queue.HeaderBgColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Window2Queue.HeaderForeColor = $safeprojectname$.Drawing.Color.Black
        Me.Window2Queue.Location = New $safeprojectname$.Drawing.Point(50, 66)
        Me.Window2Queue.MultiSelect = False
        Me.Window2Queue.Name = "Window2Queue"
        Me.Window2Queue.ReadOnly = True
        Me.Window2Queue.RowHeadersBorderStyle = $safeprojectname$.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = $safeprojectname$.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 8.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = $safeprojectname$.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = $safeprojectname$.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = $safeprojectname$.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[True]
        Me.Window2Queue.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Window2Queue.RowHeadersVisible = False
        Me.Window2Queue.SelectionMode = $safeprojectname$.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Window2Queue.Size = New $safeprojectname$.Drawing.Size(127, 190)
        Me.Window2Queue.TabIndex = 18
        '
        'QueueController2
        '
        Me.AutoScaleDimensions = New $safeprojectname$.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = $safeprojectname$.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New $safeprojectname$.Drawing.Size(554, 278)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.Window2Queue)
        Me.FormBorderStyle = $safeprojectname$.Windows.Forms.FormBorderStyle.None
        Me.Name = "QueueController2"
        Me.StartPosition = $safeprojectname$.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QueueController2"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.BunifuImageButton1, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.Window2Queue, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel4 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel6 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel3 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents qEnqueue As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents qCall As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents qDequeue As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents qVoid As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel1 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel11 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel5 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As $safeprojectname$.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Window2Queue As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class
