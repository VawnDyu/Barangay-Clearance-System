<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateResidentData
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
        Dim resources As $safeprojectname$.ComponentModel.ComponentResourceManager = New $safeprojectname$.ComponentModel.ComponentResourceManager(GetType(UpdateResidentData))
        Me.ContactNumber = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.ErrorContactNumber = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LabelNotRegistered = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LabelRegistered = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnNo = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnYes = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ErrorVoterStatus = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.StreetNo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Submit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblMarried = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblSingle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.StatusMarried = New Bunifu.Framework.UI.BunifuImageButton()
        Me.StatusSingle = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ErrorCivilStatus = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New $safeprojectname$.Windows.Forms.Panel()
        Me.ErrorGender = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Age = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.FormClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.LabelMale = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GenderFemale = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New $safeprojectname$.Windows.Forms.PictureBox()
        Me.LabelFemale = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GenderMale = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel4 = New $safeprojectname$.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Birthdate = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Street = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.ErrorAddress = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LastName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MiddleName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.FirstName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ErrorFullName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel3 = New $safeprojectname$.Windows.Forms.Panel()
        Me.Panel1 = New $safeprojectname$.Windows.Forms.Panel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        CType(Me.btnNo, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnYes, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusMarried, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusSingle, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormClose, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenderFemale, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenderMale, $safeprojectname$.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContactNumber
        '
        Me.ContactNumber.AutoCompleteCustomSource.AddRange(New String() {"Araceli Street", "Asuncion Street", "Baltazar Street", "Bayabasan Street", "Bayes Street", "Belen Street", "Berting Street", "Bigasan Street", "Bulaklak Street", "Carnation Street", "Consuelo Street", "Continental Street", "Commissioner Street", "Dahlia Street", "Diamond Street", "Don Crispulo Street", "Dr. Villareal Avenue", "Exeter Street", "Florentina Street", "Forest Hill Drive", "Genoveva Street", "Glora Street", "Governor Street", "Granada Street", "Hilltop Street", "Illuminada Street", "Int. Nenita Street", "Interior Masaya Street", "Jewel Streeet", "Joan of Arc Street", "Kabaitan Street", "Kabilugan Street", "Kabuhayan Street", "Kadalagahan Street", "KabagongTauhan Street", "Kalayaan Street", "Kalinisan Street", "Culasisi Street", "Lily Street", "Lolita Street", "Luisito Street", "Luz Street", "Luzviminda Street", "Maligaya Street", "Maganda Street", "Magdalena Street", "Maligaya Street", "Maninging Street", "Marcusin Street", "Mariposa Street", "Margarita Street", "Marianito Street", "Martirez Street", "Masaya Street", "Midway Street", "Minister Street", "Nazario Street", "Nellie Street", "Nenita Street", "Neninta Extension", "Nitang Avenue", "Paquita Street", "Payapa Street", "Pilaring Street", "Placida Street", "Pearl Street", "Ponciana Street", "Premiere Street", "President Street", "PulangBituin Street", "Queens Street", "Quirino Highway", "San Agustin Street", "San Ignacio Street", "San Juan Street", "San Lazaro Street", "San Luis Street", "San Martin Street", "San Miguel Street", "San Nicolas Street", "San Pablo Street", "San Pedro Street", "Sapphire Street", "Senading Street", "Senator Street", "Severina Street", "St. Anthony Street", "Sta. Barbara Street", "Sta. Engracia Street", "Sta. Eleuteria Street", "Sta. Isabel Street", "Sta. Maxima Street", "Sta. Monica Street", "Sta. Rita Street", "Sta. Trinidad Street", "Sta. Veronica Street", "Sumilang Street", "Sun Flower Street", "Susana Street", "T. Gonzalez Drive", "Tagumpay Street", "Tatlong Hari Street", "Temple Street", "Tutubi Street", "Venus Street", "Victoria Street", "Villareal Street", "Virginia Street"})
        Me.ContactNumber.AutoCompleteMode = $safeprojectname$.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ContactNumber.AutoCompleteSource = $safeprojectname$.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ContactNumber.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ContactNumber.BorderColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ContactNumber.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.None
        Me.ContactNumber.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNumber.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.ContactNumber.Location = New $safeprojectname$.Drawing.Point(608, 357)
        Me.ContactNumber.MaxLength = 11
        Me.ContactNumber.Name = "ContactNumber"
        Me.ContactNumber.Size = New $safeprojectname$.Drawing.Size(236, 19)
        Me.ContactNumber.TabIndex = 110
        Me.ContactNumber.Text = "Contact Number"
        '
        'ErrorContactNumber
        '
        Me.ErrorContactNumber.AutoSize = True
        Me.ErrorContactNumber.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorContactNumber.ForeColor = $safeprojectname$.Drawing.Color.LightCoral
        Me.ErrorContactNumber.Location = New $safeprojectname$.Drawing.Point(730, 304)
        Me.ErrorContactNumber.Name = "ErrorContactNumber"
        Me.ErrorContactNumber.Size = New $safeprojectname$.Drawing.Size(36, 17)
        Me.ErrorContactNumber.TabIndex = 109
        Me.ErrorContactNumber.Text = "Error"
        Me.ErrorContactNumber.Visible = False
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel12.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BunifuCustomLabel12.Location = New $safeprojectname$.Drawing.Point(579, 300)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New $safeprojectname$.Drawing.Size(145, 21)
        Me.BunifuCustomLabel12.TabIndex = 108
        Me.BunifuCustomLabel12.Text = "Contact Number"
        '
        'LabelNotRegistered
        '
        Me.LabelNotRegistered.AutoSize = True
        Me.LabelNotRegistered.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNotRegistered.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.LabelNotRegistered.Location = New $safeprojectname$.Drawing.Point(670, 239)
        Me.LabelNotRegistered.Name = "LabelNotRegistered"
        Me.LabelNotRegistered.Size = New $safeprojectname$.Drawing.Size(126, 21)
        Me.LabelNotRegistered.TabIndex = 107
        Me.LabelNotRegistered.Text = "Not Registered"
        '
        'LabelRegistered
        '
        Me.LabelRegistered.AutoSize = True
        Me.LabelRegistered.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegistered.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.LabelRegistered.Location = New $safeprojectname$.Drawing.Point(670, 181)
        Me.LabelRegistered.Name = "LabelRegistered"
        Me.LabelRegistered.Size = New $safeprojectname$.Drawing.Size(93, 21)
        Me.LabelRegistered.TabIndex = 106
        Me.LabelRegistered.Text = "Registered"
        '
        'btnNo
        '
        Me.btnNo.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnNo.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.btnNo.Image = CType(resources.GetObject("btnNo.Image"), $safeprojectname$.Drawing.Image)
        Me.btnNo.ImageActive = Nothing
        Me.btnNo.Location = New $safeprojectname$.Drawing.Point(608, 224)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New $safeprojectname$.Drawing.Size(50, 50)
        Me.btnNo.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnNo.TabIndex = 105
        Me.btnNo.TabStop = False
        Me.btnNo.Zoom = 10
        '
        'btnYes
        '
        Me.btnYes.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnYes.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.btnYes.Image = CType(resources.GetObject("btnYes.Image"), $safeprojectname$.Drawing.Image)
        Me.btnYes.ImageActive = Nothing
        Me.btnYes.Location = New $safeprojectname$.Drawing.Point(608, 164)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New $safeprojectname$.Drawing.Size(50, 50)
        Me.btnYes.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnYes.TabIndex = 104
        Me.btnYes.TabStop = False
        Me.btnYes.Zoom = 10
        '
        'ErrorVoterStatus
        '
        Me.ErrorVoterStatus.AutoSize = True
        Me.ErrorVoterStatus.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorVoterStatus.ForeColor = $safeprojectname$.Drawing.Color.LightCoral
        Me.ErrorVoterStatus.Location = New $safeprojectname$.Drawing.Point(691, 124)
        Me.ErrorVoterStatus.Name = "ErrorVoterStatus"
        Me.ErrorVoterStatus.Size = New $safeprojectname$.Drawing.Size(36, 17)
        Me.ErrorVoterStatus.TabIndex = 103
        Me.ErrorVoterStatus.Text = "Error"
        Me.ErrorVoterStatus.Visible = False
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BunifuCustomLabel11.Location = New $safeprojectname$.Drawing.Point(579, 120)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New $safeprojectname$.Drawing.Size(106, 21)
        Me.BunifuCustomLabel11.TabIndex = 102
        Me.BunifuCustomLabel11.Text = "Voter Status"
        '
        'StreetNo
        '
        Me.StreetNo.Cursor = $safeprojectname$.Windows.Forms.Cursors.IBeam
        Me.StreetNo.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!)
        Me.StreetNo.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.StreetNo.HintForeColor = $safeprojectname$.Drawing.Color.Empty
        Me.StreetNo.HintText = ""
        Me.StreetNo.isPassword = False
        Me.StreetNo.LineFocusedColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.StreetNo.LineIdleColor = $safeprojectname$.Drawing.Color.Gray
        Me.StreetNo.LineMouseHoverColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.StreetNo.LineThickness = 3
        Me.StreetNo.Location = New $safeprojectname$.Drawing.Point(58, 248)
        Me.StreetNo.Margin = New $safeprojectname$.Windows.Forms.Padding(4)
        Me.StreetNo.Name = "StreetNo"
        Me.StreetNo.Size = New $safeprojectname$.Drawing.Size(127, 44)
        Me.StreetNo.TabIndex = 101
        Me.StreetNo.Text = "Street No."
        Me.StreetNo.TextAlign = $safeprojectname$.Windows.Forms.HorizontalAlignment.Left
        '
        'Submit
        '
        Me.Submit.Activecolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Submit.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Submit.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.Submit.BorderRadius = 0
        Me.Submit.ButtonText = "Submit"
        Me.Submit.Cursor = $safeprojectname$.Windows.Forms.Cursors.Hand
        Me.Submit.DisabledColor = $safeprojectname$.Drawing.Color.Gray
        Me.Submit.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 6.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Iconcolor = $safeprojectname$.Drawing.Color.Transparent
        Me.Submit.Iconimage = CType(resources.GetObject("Submit.Iconimage"), $safeprojectname$.Drawing.Image)
        Me.Submit.Iconimage_right = Nothing
        Me.Submit.Iconimage_right_Selected = Nothing
        Me.Submit.Iconimage_Selected = Nothing
        Me.Submit.IconMarginLeft = 0
        Me.Submit.IconMarginRight = 0
        Me.Submit.IconRightVisible = True
        Me.Submit.IconRightZoom = 0.0R
        Me.Submit.IconVisible = True
        Me.Submit.IconZoom = 90.0R
        Me.Submit.IsTab = False
        Me.Submit.Location = New $safeprojectname$.Drawing.Point(570, 450)
        Me.Submit.Name = "Submit"
        Me.Submit.Normalcolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Submit.OnHovercolor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Submit.OnHoverTextColor = $safeprojectname$.Drawing.Color.LightGray
        Me.Submit.selected = False
        Me.Submit.Size = New $safeprojectname$.Drawing.Size(255, 48)
        Me.Submit.TabIndex = 100
        Me.Submit.Text = "Submit"
        Me.Submit.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleLeft
        Me.Submit.Textcolor = $safeprojectname$.Drawing.Color.LightGray
        Me.Submit.TextFont = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblMarried
        '
        Me.lblMarried.AutoSize = True
        Me.lblMarried.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarried.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.lblMarried.Location = New $safeprojectname$.Drawing.Point(299, 611)
        Me.lblMarried.Name = "lblMarried"
        Me.lblMarried.Size = New $safeprojectname$.Drawing.Size(70, 21)
        Me.lblMarried.TabIndex = 99
        Me.lblMarried.Text = "Married"
        '
        'lblSingle
        '
        Me.lblSingle.AutoSize = True
        Me.lblSingle.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSingle.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.lblSingle.Location = New $safeprojectname$.Drawing.Point(153, 611)
        Me.lblSingle.Name = "lblSingle"
        Me.lblSingle.Size = New $safeprojectname$.Drawing.Size(55, 21)
        Me.lblSingle.TabIndex = 98
        Me.lblSingle.Text = "Single"
        '
        'StatusMarried
        '
        Me.StatusMarried.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.StatusMarried.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.StatusMarried.Image = CType(resources.GetObject("StatusMarried.Image"), $safeprojectname$.Drawing.Image)
        Me.StatusMarried.ImageActive = Nothing
        Me.StatusMarried.Location = New $safeprojectname$.Drawing.Point(243, 596)
        Me.StatusMarried.Name = "StatusMarried"
        Me.StatusMarried.Size = New $safeprojectname$.Drawing.Size(50, 50)
        Me.StatusMarried.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StatusMarried.TabIndex = 97
        Me.StatusMarried.TabStop = False
        Me.StatusMarried.Zoom = 10
        '
        'StatusSingle
        '
        Me.StatusSingle.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.StatusSingle.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.StatusSingle.Image = CType(resources.GetObject("StatusSingle.Image"), $safeprojectname$.Drawing.Image)
        Me.StatusSingle.ImageActive = Nothing
        Me.StatusSingle.Location = New $safeprojectname$.Drawing.Point(97, 596)
        Me.StatusSingle.Name = "StatusSingle"
        Me.StatusSingle.Size = New $safeprojectname$.Drawing.Size(50, 50)
        Me.StatusSingle.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StatusSingle.TabIndex = 96
        Me.StatusSingle.TabStop = False
        Me.StatusSingle.Zoom = 10
        '
        'ErrorCivilStatus
        '
        Me.ErrorCivilStatus.AutoSize = True
        Me.ErrorCivilStatus.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorCivilStatus.ForeColor = $safeprojectname$.Drawing.Color.LightCoral
        Me.ErrorCivilStatus.Location = New $safeprojectname$.Drawing.Point(134, 556)
        Me.ErrorCivilStatus.Name = "ErrorCivilStatus"
        Me.ErrorCivilStatus.Size = New $safeprojectname$.Drawing.Size(36, 17)
        Me.ErrorCivilStatus.TabIndex = 95
        Me.ErrorCivilStatus.Text = "Error"
        Me.ErrorCivilStatus.Visible = False
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New $safeprojectname$.Drawing.Point(33, 552)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New $safeprojectname$.Drawing.Size(95, 21)
        Me.BunifuCustomLabel7.TabIndex = 94
        Me.BunifuCustomLabel7.Text = "Civil Status"
        '
        'Panel2
        '
        Me.Panel2.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Panel2.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New $safeprojectname$.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New $safeprojectname$.Drawing.Size(919, 1)
        Me.Panel2.TabIndex = 2
        '
        'ErrorGender
        '
        Me.ErrorGender.AutoSize = True
        Me.ErrorGender.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorGender.ForeColor = $safeprojectname$.Drawing.Color.LightCoral
        Me.ErrorGender.Location = New $safeprojectname$.Drawing.Point(107, 309)
        Me.ErrorGender.Name = "ErrorGender"
        Me.ErrorGender.Size = New $safeprojectname$.Drawing.Size(36, 17)
        Me.ErrorGender.TabIndex = 93
        Me.ErrorGender.Text = "Error"
        Me.ErrorGender.Visible = False
        '
        'Age
        '
        Me.Age.AutoSize = True
        Me.Age.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.Age.Location = New $safeprojectname$.Drawing.Point(153, 502)
        Me.Age.Name = "Age"
        Me.Age.Size = New $safeprojectname$.Drawing.Size(145, 21)
        Me.Age.TabIndex = 92
        Me.Age.Text = "0 Years, 0 Months"
        Me.Age.TextAlign = $safeprojectname$.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New $safeprojectname$.Drawing.Point(33, 410)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New $safeprojectname$.Drawing.Size(83, 21)
        Me.BunifuCustomLabel6.TabIndex = 91
        Me.BunifuCustomLabel6.Text = "Birthdate"
        '
        'FormClose
        '
        Me.FormClose.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FormClose.Image = CType(resources.GetObject("FormClose.Image"), $safeprojectname$.Drawing.Image)
        Me.FormClose.ImageActive = Nothing
        Me.FormClose.Location = New $safeprojectname$.Drawing.Point(879, 9)
        Me.FormClose.Name = "FormClose"
        Me.FormClose.Size = New $safeprojectname$.Drawing.Size(32, 32)
        Me.FormClose.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FormClose.TabIndex = 19
        Me.FormClose.TabStop = False
        Me.FormClose.Zoom = 10
        '
        'LabelMale
        '
        Me.LabelMale.AutoSize = True
        Me.LabelMale.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMale.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.LabelMale.Location = New $safeprojectname$.Drawing.Point(153, 357)
        Me.LabelMale.Name = "LabelMale"
        Me.LabelMale.Size = New $safeprojectname$.Drawing.Size(49, 21)
        Me.LabelMale.TabIndex = 89
        Me.LabelMale.Text = "Male"
        '
        'GenderFemale
        '
        Me.GenderFemale.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GenderFemale.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.GenderFemale.Image = CType(resources.GetObject("GenderFemale.Image"), $safeprojectname$.Drawing.Image)
        Me.GenderFemale.ImageActive = Nothing
        Me.GenderFemale.Location = New $safeprojectname$.Drawing.Point(243, 342)
        Me.GenderFemale.Name = "GenderFemale"
        Me.GenderFemale.Size = New $safeprojectname$.Drawing.Size(50, 50)
        Me.GenderFemale.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GenderFemale.TabIndex = 88
        Me.GenderFemale.TabStop = False
        Me.GenderFemale.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), $safeprojectname$.Drawing.Image)
        Me.PictureBox1.Location = New $safeprojectname$.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New $safeprojectname$.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LabelFemale
        '
        Me.LabelFemale.AutoSize = True
        Me.LabelFemale.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFemale.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.LabelFemale.Location = New $safeprojectname$.Drawing.Point(299, 357)
        Me.LabelFemale.Name = "LabelFemale"
        Me.LabelFemale.Size = New $safeprojectname$.Drawing.Size(67, 21)
        Me.LabelFemale.TabIndex = 90
        Me.LabelFemale.Text = "Female"
        '
        'GenderMale
        '
        Me.GenderMale.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GenderMale.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.FixedSingle
        Me.GenderMale.Image = CType(resources.GetObject("GenderMale.Image"), $safeprojectname$.Drawing.Image)
        Me.GenderMale.ImageActive = Nothing
        Me.GenderMale.Location = New $safeprojectname$.Drawing.Point(97, 342)
        Me.GenderMale.Name = "GenderMale"
        Me.GenderMale.Size = New $safeprojectname$.Drawing.Size(50, 50)
        Me.GenderMale.SizeMode = $safeprojectname$.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GenderMale.TabIndex = 87
        Me.GenderMale.TabStop = False
        Me.GenderMale.Zoom = 10
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New $safeprojectname$.Drawing.Point(33, 305)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New $safeprojectname$.Drawing.Size(70, 21)
        Me.BunifuCustomLabel5.TabIndex = 86
        Me.BunifuCustomLabel5.Text = "Gender"
        '
        'Panel4
        '
        Me.Panel4.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel4.Dock = $safeprojectname$.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New $safeprojectname$.Drawing.Point(2, 681)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New $safeprojectname$.Drawing.Size(915, 2)
        Me.Panel4.TabIndex = 73
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 14.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.BunifuCustomLabel1.Location = New $safeprojectname$.Drawing.Point(54, 17)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New $safeprojectname$.Drawing.Size(163, 22)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Update Resident"
        '
        'Birthdate
        '
        Me.Birthdate.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Birthdate.BorderRadius = 0
        Me.Birthdate.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.Fixed3D
        Me.Birthdate.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 8.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Birthdate.ForeColor = $safeprojectname$.Drawing.Color.Gray
        Me.Birthdate.Format = $safeprojectname$.Windows.Forms.DateTimePickerFormat.Custom
        Me.Birthdate.FormatCustom = " MMMM dd, yyyy"
        Me.Birthdate.Location = New $safeprojectname$.Drawing.Point(97, 451)
        Me.Birthdate.Margin = New $safeprojectname$.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Birthdate.Name = "Birthdate"
        Me.Birthdate.Size = New $safeprojectname$.Drawing.Size(261, 43)
        Me.Birthdate.TabIndex = 85
        Me.Birthdate.Value = New Date(2000, 12, 25, 0, 0, 0, 0)
        '
        'Street
        '
        Me.Street.AutoCompleteCustomSource.AddRange(New String() {"Araceli Street", "Asuncion Street", "Baltazar Street", "Bayabasan Street", "Bayes Street", "Belen Street", "Berting Street", "Bigasan Street", "Bulaklak Street", "Carnation Street", "Consuelo Street", "Continental Street", "Commissioner Street", "Dahlia Street", "Diamond Street", "Don Crispulo Street", "Dr. Villareal Avenue", "Exeter Street", "Florentina Street", "Forest Hill Drive", "Genoveva Street", "Glora Street", "Governor Street", "Granada Street", "Hilltop Street", "Illuminada Street", "Int. Nenita Street", "Interior Masaya Street", "Jewel Streeet", "Joan of Arc Street", "Kabaitan Street", "Kabilugan Street", "Kabuhayan Street", "Kadalagahan Street", "KabagongTauhan Street", "Kalayaan Street", "Kalinisan Street", "Culasisi Street", "Lily Street", "Lolita Street", "Luisito Street", "Luz Street", "Luzviminda Street", "Maligaya Street", "Maganda Street", "Magdalena Street", "Maligaya Street", "Maninging Street", "Marcusin Street", "Mariposa Street", "Margarita Street", "Marianito Street", "Martirez Street", "Masaya Street", "Midway Street", "Minister Street", "Nazario Street", "Nellie Street", "Nenita Street", "Neninta Extension", "Nitang Avenue", "Paquita Street", "Payapa Street", "Pilaring Street", "Placida Street", "Pearl Street", "Ponciana Street", "Premiere Street", "President Street", "PulangBituin Street", "Queens Street", "Quirino Highway", "San Agustin Street", "San Ignacio Street", "San Juan Street", "San Lazaro Street", "San Luis Street", "San Martin Street", "San Miguel Street", "San Nicolas Street", "San Pablo Street", "San Pedro Street", "Sapphire Street", "Senading Street", "Senator Street", "Severina Street", "St. Anthony Street", "Sta. Barbara Street", "Sta. Engracia Street", "Sta. Eleuteria Street", "Sta. Isabel Street", "Sta. Maxima Street", "Sta. Monica Street", "Sta. Rita Street", "Sta. Trinidad Street", "Sta. Veronica Street", "Sumilang Street", "Sun Flower Street", "Susana Street", "T. Gonzalez Drive", "Tagumpay Street", "Tatlong Hari Street", "Temple Street", "Tutubi Street", "Venus Street", "Victoria Street", "Villareal Street", "Virginia Street"})
        Me.Street.AutoCompleteMode = $safeprojectname$.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Street.AutoCompleteSource = $safeprojectname$.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Street.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Street.BorderColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Street.BorderStyle = $safeprojectname$.Windows.Forms.BorderStyle.None
        Me.Street.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 11.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Street.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.Street.Location = New $safeprojectname$.Drawing.Point(262, 262)
        Me.Street.Name = "Street"
        Me.Street.Size = New $safeprojectname$.Drawing.Size(236, 19)
        Me.Street.TabIndex = 84
        Me.Street.Text = "Street"
        '
        'ErrorAddress
        '
        Me.ErrorAddress.AutoSize = True
        Me.ErrorAddress.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorAddress.ForeColor = $safeprojectname$.Drawing.Color.LightCoral
        Me.ErrorAddress.Location = New $safeprojectname$.Drawing.Point(111, 224)
        Me.ErrorAddress.Name = "ErrorAddress"
        Me.ErrorAddress.Size = New $safeprojectname$.Drawing.Size(36, 17)
        Me.ErrorAddress.TabIndex = 83
        Me.ErrorAddress.Text = "Error"
        Me.ErrorAddress.Visible = False
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New $safeprojectname$.Drawing.Point(33, 220)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New $safeprojectname$.Drawing.Size(72, 21)
        Me.BunifuCustomLabel3.TabIndex = 82
        Me.BunifuCustomLabel3.Text = "Address"
        '
        'LastName
        '
        Me.LastName.Cursor = $safeprojectname$.Windows.Forms.Cursors.IBeam
        Me.LastName.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!)
        Me.LastName.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.LastName.HintForeColor = $safeprojectname$.Drawing.Color.Empty
        Me.LastName.HintText = ""
        Me.LastName.isPassword = False
        Me.LastName.LineFocusedColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.LastName.LineIdleColor = $safeprojectname$.Drawing.Color.Gray
        Me.LastName.LineMouseHoverColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.LastName.LineThickness = 3
        Me.LastName.Location = New $safeprojectname$.Drawing.Point(369, 149)
        Me.LastName.Margin = New $safeprojectname$.Windows.Forms.Padding(4)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New $safeprojectname$.Drawing.Size(127, 44)
        Me.LastName.TabIndex = 81
        Me.LastName.Text = "Last Name"
        Me.LastName.TextAlign = $safeprojectname$.Windows.Forms.HorizontalAlignment.Left
        '
        'MiddleName
        '
        Me.MiddleName.Cursor = $safeprojectname$.Windows.Forms.Cursors.IBeam
        Me.MiddleName.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!)
        Me.MiddleName.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.MiddleName.HintForeColor = $safeprojectname$.Drawing.Color.Empty
        Me.MiddleName.HintText = ""
        Me.MiddleName.isPassword = False
        Me.MiddleName.LineFocusedColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.MiddleName.LineIdleColor = $safeprojectname$.Drawing.Color.Gray
        Me.MiddleName.LineMouseHoverColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.MiddleName.LineThickness = 3
        Me.MiddleName.Location = New $safeprojectname$.Drawing.Point(213, 149)
        Me.MiddleName.Margin = New $safeprojectname$.Windows.Forms.Padding(4)
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Size = New $safeprojectname$.Drawing.Size(127, 44)
        Me.MiddleName.TabIndex = 80
        Me.MiddleName.Text = "Middle Name"
        Me.MiddleName.TextAlign = $safeprojectname$.Windows.Forms.HorizontalAlignment.Left
        '
        'FirstName
        '
        Me.FirstName.Cursor = $safeprojectname$.Windows.Forms.Cursors.IBeam
        Me.FirstName.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!)
        Me.FirstName.ForeColor = $safeprojectname$.Drawing.Color.LightGray
        Me.FirstName.HintForeColor = $safeprojectname$.Drawing.Color.Empty
        Me.FirstName.HintText = ""
        Me.FirstName.isPassword = False
        Me.FirstName.LineFocusedColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.FirstName.LineIdleColor = $safeprojectname$.Drawing.Color.Gray
        Me.FirstName.LineMouseHoverColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.FirstName.LineThickness = 3
        Me.FirstName.Location = New $safeprojectname$.Drawing.Point(58, 149)
        Me.FirstName.Margin = New $safeprojectname$.Windows.Forms.Padding(4)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New $safeprojectname$.Drawing.Size(127, 44)
        Me.FirstName.TabIndex = 79
        Me.FirstName.Text = "First Name"
        Me.FirstName.TextAlign = $safeprojectname$.Windows.Forms.HorizontalAlignment.Left
        '
        'ErrorFullName
        '
        Me.ErrorFullName.AutoSize = True
        Me.ErrorFullName.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 9.75!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorFullName.ForeColor = $safeprojectname$.Drawing.Color.LightCoral
        Me.ErrorFullName.Location = New $safeprojectname$.Drawing.Point(124, 124)
        Me.ErrorFullName.Name = "ErrorFullName"
        Me.ErrorFullName.Size = New $safeprojectname$.Drawing.Size(36, 17)
        Me.ErrorFullName.TabIndex = 78
        Me.ErrorFullName.Text = "Error"
        Me.ErrorFullName.Visible = False
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 12.0!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New $safeprojectname$.Drawing.Point(33, 120)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New $safeprojectname$.Drawing.Size(86, 21)
        Me.BunifuCustomLabel4.TabIndex = 77
        Me.BunifuCustomLabel4.Text = "Full Name"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New $safeprojectname$.Drawing.Font("Century Gothic", 20.25!, $safeprojectname$.Drawing.FontStyle.Regular, $safeprojectname$.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New $safeprojectname$.Drawing.Point(12, 67)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New $safeprojectname$.Drawing.Size(282, 33)
        Me.BunifuCustomLabel2.TabIndex = 76
        Me.BunifuCustomLabel2.Text = "Personal Information"
        '
        'Panel3
        '
        Me.Panel3.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel3.Dock = $safeprojectname$.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New $safeprojectname$.Drawing.Point(0, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New $safeprojectname$.Drawing.Size(2, 632)
        Me.Panel3.TabIndex = 75
        '
        'Panel1
        '
        Me.Panel1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Dock = $safeprojectname$.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New $safeprojectname$.Drawing.Point(917, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New $safeprojectname$.Drawing.Size(2, 632)
        Me.Panel1.TabIndex = 74
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), $safeprojectname$.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = $safeprojectname$.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.FormClose)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel2)
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
        Me.BunifuGradientPanel1.Size = New $safeprojectname$.Drawing.Size(919, 51)
        Me.BunifuGradientPanel1.TabIndex = 72
        '
        'UpdateResidentData
        '
        Me.AutoScaleDimensions = New $safeprojectname$.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = $safeprojectname$.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = $safeprojectname$.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New $safeprojectname$.Drawing.Size(919, 683)
        Me.Controls.Add(Me.ContactNumber)
        Me.Controls.Add(Me.ErrorContactNumber)
        Me.Controls.Add(Me.BunifuCustomLabel12)
        Me.Controls.Add(Me.LabelNotRegistered)
        Me.Controls.Add(Me.LabelRegistered)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.ErrorVoterStatus)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.StreetNo)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.lblMarried)
        Me.Controls.Add(Me.lblSingle)
        Me.Controls.Add(Me.StatusMarried)
        Me.Controls.Add(Me.StatusSingle)
        Me.Controls.Add(Me.ErrorCivilStatus)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.ErrorGender)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.LabelMale)
        Me.Controls.Add(Me.GenderFemale)
        Me.Controls.Add(Me.LabelFemale)
        Me.Controls.Add(Me.GenderMale)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Birthdate)
        Me.Controls.Add(Me.Street)
        Me.Controls.Add(Me.ErrorAddress)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.MiddleName)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.ErrorFullName)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = $safeprojectname$.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateResidentData"
        Me.StartPosition = $safeprojectname$.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateResidentData"
        CType(Me.btnNo, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnYes, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusMarried, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusSingle, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormClose, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenderFemale, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenderMale, $safeprojectname$.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContactNumber As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents ErrorContactNumber As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LabelNotRegistered As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LabelRegistered As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnNo As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnYes As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ErrorVoterStatus As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents StreetNo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Submit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblMarried As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblSingle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents StatusMarried As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents StatusSingle As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ErrorCivilStatus As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents ErrorGender As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Age As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents FormClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents LabelMale As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GenderFemale As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As $safeprojectname$.Windows.Forms.PictureBox
    Friend WithEvents LabelFemale As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GenderMale As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel4 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Birthdate As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Street As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents ErrorAddress As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LastName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MiddleName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents FirstName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ErrorFullName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel3 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents Panel1 As $safeprojectname$.Windows.Forms.Panel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
End Class
