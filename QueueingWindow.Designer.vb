<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueueingWindow
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
        Dim DataGridViewCellStyle1 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As $safeprojectname$.Windows.Forms.DataGridViewCellStyle = New $safeprojectname$.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New $safeprojectname$.Windows.Forms.Panel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel5 = New $safeprojectname$.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Panel6 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Window1Queue = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel3 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Window2Queue = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel4 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Window3Queue = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel7 = New $safeprojectname$.Windows.Forms.Panel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Timer1 = New $safeprojectname$.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Window1Queue, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Window2Queue, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Window3Queue, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = $safeprojectname$.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New $safeprojectname$.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New $safeprojectname$.Drawing.Size(1386, 101)
        Me.Panel1.TabIndex = 0
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 48.0!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel3.Location = New $safeprojectname$.Drawing.Point(985, 12)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New $safeprojectname$.Drawing.Size(332, 77)
        Me.BunifuCustomLabel3.TabIndex = 9
        Me.BunifuCustomLabel3.Text = "Window 3"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 48.0!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel2.Location = New $safeprojectname$.Drawing.Point(512, 12)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New $safeprojectname$.Drawing.Size(332, 77)
        Me.BunifuCustomLabel2.TabIndex = 8
        Me.BunifuCustomLabel2.Text = "Window 2"
        '
        'Panel5
        '
        Me.Panel5.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Panel5.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New $safeprojectname$.Drawing.Point(0, 99)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New $safeprojectname$.Drawing.Size(1386, 2)
        Me.Panel5.TabIndex = 7
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 48.0!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel1.Location = New $safeprojectname$.Drawing.Point(50, 21)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New $safeprojectname$.Drawing.Size(332, 77)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "Window 1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Window1Queue)
        Me.Panel2.Dock = $safeprojectname$.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New $safeprojectname$.Drawing.Point(0, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New $safeprojectname$.Drawing.Size(440, 648)
        Me.Panel2.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Panel6.Dock = $safeprojectname$.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New $safeprojectname$.Drawing.Point(438, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New $safeprojectname$.Drawing.Size(2, 648)
        Me.Panel6.TabIndex = 9
        '
        'Window1Queue
        '
        Me.Window1Queue.AllowUserToAddRows = False
        Me.Window1Queue.AllowUserToDeleteRows = False
        Me.Window1Queue.AllowUserToResizeColumns = False
        Me.Window1Queue.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window1Queue.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Window1Queue.AutoSizeColumnsMode = $safeprojectname$.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Window1Queue.AutoSizeRowsMode = $safeprojectname$.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Window1Queue.BackgroundColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window1Queue.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.None
        Me.Window1Queue.ColumnHeadersBorderStyle = $safeprojectname$.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle2.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = $safeprojectname$.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = $safeprojectname$.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[True]
        Me.Window1Queue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Window1Queue.ColumnHeadersHeight = 30
        Me.Window1Queue.ColumnHeadersHeightSizeMode = $safeprojectname$.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Window1Queue.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle3.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 72.0!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = $safeprojectname$.Drawing.Color.LightCoral
        DataGridViewCellStyle3.Padding = New $safeprojectname$.Windows.Forms.Padding(7)
        DataGridViewCellStyle3.SelectionBackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = $safeprojectname$.Drawing.Color.LimeGreen
        DataGridViewCellStyle3.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[False]
        Me.Window1Queue.DefaultCellStyle = DataGridViewCellStyle3
        Me.Window1Queue.DoubleBuffered = True
        Me.Window1Queue.Enabled = False
        Me.Window1Queue.EnableHeadersVisualStyles = False
        Me.Window1Queue.GridColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window1Queue.HeaderBgColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Window1Queue.HeaderForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window1Queue.Location = New $safeprojectname$.Drawing.Point(63, 9)
        Me.Window1Queue.MultiSelect = False
        Me.Window1Queue.Name = "Window1Queue"
        Me.Window1Queue.ReadOnly = True
        Me.Window1Queue.RowHeadersBorderStyle = $safeprojectname$.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = $safeprojectname$.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 8.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = $safeprojectname$.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = $safeprojectname$.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = $safeprojectname$.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[True]
        Me.Window1Queue.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Window1Queue.RowHeadersVisible = False
        Me.Window1Queue.ScrollBars = $safeprojectname$.Windows.Forms.ScrollBars.None
        Me.Window1Queue.SelectionMode = $safeprojectname$.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Window1Queue.ShowCellErrors = False
        Me.Window1Queue.ShowCellToolTips = False
        Me.Window1Queue.ShowEditingIcon = False
        Me.Window1Queue.ShowRowErrors = False
        Me.Window1Queue.Size = New $safeprojectname$.Drawing.Size(330, 624)
        Me.Window1Queue.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Window2Queue)
        Me.Panel3.Dock = $safeprojectname$.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New $safeprojectname$.Drawing.Point(440, 101)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New $safeprojectname$.Drawing.Size(946, 648)
        Me.Panel3.TabIndex = 2
        '
        'Window2Queue
        '
        Me.Window2Queue.AllowUserToAddRows = False
        Me.Window2Queue.AllowUserToDeleteRows = False
        Me.Window2Queue.AllowUserToResizeColumns = False
        Me.Window2Queue.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window2Queue.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Window2Queue.AutoSizeColumnsMode = $safeprojectname$.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Window2Queue.AutoSizeRowsMode = $safeprojectname$.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Window2Queue.BackgroundColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window2Queue.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.None
        Me.Window2Queue.ColumnHeadersBorderStyle = $safeprojectname$.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle6.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = $safeprojectname$.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = $safeprojectname$.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[True]
        Me.Window2Queue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Window2Queue.ColumnHeadersHeight = 30
        Me.Window2Queue.ColumnHeadersHeightSizeMode = $safeprojectname$.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Window2Queue.ColumnHeadersVisible = False
        DataGridViewCellStyle7.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle7.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 72.0!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = $safeprojectname$.Drawing.Color.LightCoral
        DataGridViewCellStyle7.Padding = New $safeprojectname$.Windows.Forms.Padding(7)
        DataGridViewCellStyle7.SelectionBackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = $safeprojectname$.Drawing.Color.LimeGreen
        DataGridViewCellStyle7.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[False]
        Me.Window2Queue.DefaultCellStyle = DataGridViewCellStyle7
        Me.Window2Queue.DoubleBuffered = True
        Me.Window2Queue.Enabled = False
        Me.Window2Queue.EnableHeadersVisualStyles = False
        Me.Window2Queue.GridColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window2Queue.HeaderBgColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Window2Queue.HeaderForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window2Queue.Location = New $safeprojectname$.Drawing.Point(85, 9)
        Me.Window2Queue.MultiSelect = False
        Me.Window2Queue.Name = "Window2Queue"
        Me.Window2Queue.ReadOnly = True
        Me.Window2Queue.RowHeadersBorderStyle = $safeprojectname$.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = $safeprojectname$.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 8.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = $safeprojectname$.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = $safeprojectname$.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = $safeprojectname$.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[True]
        Me.Window2Queue.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Window2Queue.RowHeadersVisible = False
        Me.Window2Queue.ScrollBars = $safeprojectname$.Windows.Forms.ScrollBars.None
        Me.Window2Queue.SelectionMode = $safeprojectname$.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Window2Queue.ShowCellErrors = False
        Me.Window2Queue.ShowCellToolTips = False
        Me.Window2Queue.ShowEditingIcon = False
        Me.Window2Queue.ShowRowErrors = False
        Me.Window2Queue.Size = New $safeprojectname$.Drawing.Size(330, 624)
        Me.Window2Queue.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Window3Queue)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Dock = $safeprojectname$.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New $safeprojectname$.Drawing.Point(929, 101)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New $safeprojectname$.Drawing.Size(457, 648)
        Me.Panel4.TabIndex = 3
        '
        'Window3Queue
        '
        Me.Window3Queue.AllowUserToAddRows = False
        Me.Window3Queue.AllowUserToDeleteRows = False
        Me.Window3Queue.AllowUserToResizeColumns = False
        Me.Window3Queue.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window3Queue.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Window3Queue.AutoSizeColumnsMode = $safeprojectname$.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Window3Queue.AutoSizeRowsMode = $safeprojectname$.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Window3Queue.BackgroundColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window3Queue.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.None
        Me.Window3Queue.ColumnHeadersBorderStyle = $safeprojectname$.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle10.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle10.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = $safeprojectname$.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = $safeprojectname$.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[True]
        Me.Window3Queue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.Window3Queue.ColumnHeadersHeight = 30
        Me.Window3Queue.ColumnHeadersHeightSizeMode = $safeprojectname$.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Window3Queue.ColumnHeadersVisible = False
        DataGridViewCellStyle11.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle11.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 72.0!, $safeprojectname$.Drawing.FontStyle.Bold, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = $safeprojectname$.Drawing.Color.LightCoral
        DataGridViewCellStyle11.Padding = New $safeprojectname$.Windows.Forms.Padding(7)
        DataGridViewCellStyle11.SelectionBackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = $safeprojectname$.Drawing.Color.LimeGreen
        DataGridViewCellStyle11.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[False]
        Me.Window3Queue.DefaultCellStyle = DataGridViewCellStyle11
        Me.Window3Queue.DoubleBuffered = True
        Me.Window3Queue.Enabled = False
        Me.Window3Queue.EnableHeadersVisualStyles = False
        Me.Window3Queue.GridColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window3Queue.HeaderBgColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Window3Queue.HeaderForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Window3Queue.Location = New $safeprojectname$.Drawing.Point(78, 9)
        Me.Window3Queue.MultiSelect = False
        Me.Window3Queue.Name = "Window3Queue"
        Me.Window3Queue.ReadOnly = True
        Me.Window3Queue.RowHeadersBorderStyle = $safeprojectname$.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = $safeprojectname$.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = $safeprojectname$.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 8.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = $safeprojectname$.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = $safeprojectname$.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = $safeprojectname$.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = $safeprojectname$.Windows.Forms.DataGridViewTriState.[True]
        Me.Window3Queue.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.Window3Queue.RowHeadersVisible = False
        Me.Window3Queue.ScrollBars = $safeprojectname$.Windows.Forms.ScrollBars.None
        Me.Window3Queue.SelectionMode = $safeprojectname$.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Window3Queue.ShowCellErrors = False
        Me.Window3Queue.ShowCellToolTips = False
        Me.Window3Queue.ShowEditingIcon = False
        Me.Window3Queue.ShowRowErrors = False
        Me.Window3Queue.Size = New $safeprojectname$.Drawing.Size(330, 624)
        Me.Window3Queue.TabIndex = 10
        '
        'Panel7
        '
        Me.Panel7.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Panel7.Dock = $safeprojectname$.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New $safeprojectname$.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New $safeprojectname$.Drawing.Size(2, 648)
        Me.Panel7.TabIndex = 9
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Timer1
        '
        '
        'QueueingWindow
        '
        Me.AutoScaleDimensions = New $safeprojectname$.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = $safeprojectname$.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New $safeprojectname$.Drawing.Size(1386, 749)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = $safeprojectname$.Windows.Forms.FormBorderStyle.None
        Me.Name = "QueueingWindow"
        Me.StartPosition = $safeprojectname$.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QueueingWindow"
        Me.WindowState = $safeprojectname$.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Window1Queue, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.Window2Queue, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Window3Queue, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel2 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel3 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel4 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Window1Queue As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel5 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel6 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel7 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Window2Queue As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Window3Queue As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Timer1 As $safeprojectname$.Windows.Forms.Timer
End Class
