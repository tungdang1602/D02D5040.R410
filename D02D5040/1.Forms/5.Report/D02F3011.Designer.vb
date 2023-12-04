<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F3011
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F3011))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtReportTypeID = New System.Windows.Forms.TextBox()
        Me.tdbcReportID = New C1.Win.C1List.C1Combo()
        Me.lblReportTypeID = New System.Windows.Forms.Label()
        Me.txtReportTypeName = New System.Windows.Forms.TextBox()
        Me.lblReportID = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLine1 = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.tdbcToPeriodID = New C1.Win.C1List.C1Combo()
        Me.tdbcFromPeriodID = New C1.Win.C1List.C1Combo()
        Me.chkPeriodID = New System.Windows.Forms.CheckBox()
        Me.tdbcToAssetID = New C1.Win.C1List.C1Combo()
        Me.tdbcFromAssetID = New C1.Win.C1List.C1Combo()
        Me.tdbcACodeID = New C1.Win.C1List.C1Combo()
        Me.tdbcGroupTypeID = New C1.Win.C1List.C1Combo()
        Me.lblGroupTypeID = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblFromAssetID = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.grpDivisionID = New System.Windows.Forms.GroupBox()
        Me.lblDivisionID = New System.Windows.Forms.Label()
        Me.tdbcDivisionID = New C1.Win.C1List.C1Combo()
        Me.txtDivisionName = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tdbcToPeriodID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFromPeriodID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcToAssetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFromAssetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcACodeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcGroupTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDivisionID.SuspendLayout()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtReportTypeID)
        Me.GroupBox1.Controls.Add(Me.tdbcReportID)
        Me.GroupBox1.Controls.Add(Me.lblReportTypeID)
        Me.GroupBox1.Controls.Add(Me.txtReportTypeName)
        Me.GroupBox1.Controls.Add(Me.lblReportID)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 91)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1. Dạng báo cáo"
        '
        'txtReportTypeID
        '
        Me.txtReportTypeID.Enabled = False
        Me.txtReportTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtReportTypeID.Location = New System.Drawing.Point(82, 24)
        Me.txtReportTypeID.Name = "txtReportTypeID"
        Me.txtReportTypeID.Size = New System.Drawing.Size(128, 22)
        Me.txtReportTypeID.TabIndex = 1
        '
        'tdbcReportID
        '
        Me.tdbcReportID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcReportID.AllowColMove = False
        Me.tdbcReportID.AllowSort = False
        Me.tdbcReportID.AlternatingRows = True
        Me.tdbcReportID.AutoCompletion = True
        Me.tdbcReportID.AutoDropDown = True
        Me.tdbcReportID.Caption = ""
        Me.tdbcReportID.CaptionHeight = 17
        Me.tdbcReportID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcReportID.ColumnCaptionHeight = 17
        Me.tdbcReportID.ColumnFooterHeight = 17
        Me.tdbcReportID.ColumnWidth = 100
        Me.tdbcReportID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcReportID.DisplayMember = "ReportID"
        Me.tdbcReportID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcReportID.DropDownWidth = 300
        Me.tdbcReportID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcReportID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcReportID.EmptyRows = True
        Me.tdbcReportID.ExtendRightColumn = True
        Me.tdbcReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportID.Images.Add(CType(resources.GetObject("tdbcReportID.Images"), System.Drawing.Image))
        Me.tdbcReportID.ItemHeight = 15
        Me.tdbcReportID.Location = New System.Drawing.Point(82, 53)
        Me.tdbcReportID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcReportID.MaxDropDownItems = CType(8, Short)
        Me.tdbcReportID.MaxLength = 20
        Me.tdbcReportID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcReportID.Name = "tdbcReportID"
        Me.tdbcReportID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcReportID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcReportID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcReportID.TabIndex = 5
        Me.tdbcReportID.ValueMember = "ReportID"
        Me.tdbcReportID.PropBag = resources.GetString("tdbcReportID.PropBag")
        '
        'lblReportTypeID
        '
        Me.lblReportTypeID.AutoSize = True
        Me.lblReportTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportTypeID.Location = New System.Drawing.Point(5, 29)
        Me.lblReportTypeID.Name = "lblReportTypeID"
        Me.lblReportTypeID.Size = New System.Drawing.Size(61, 13)
        Me.lblReportTypeID.TabIndex = 0
        Me.lblReportTypeID.Text = "Mẫu chuẩn"
        Me.lblReportTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReportTypeName
        '
        Me.txtReportTypeName.Enabled = False
        Me.txtReportTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtReportTypeName.Location = New System.Drawing.Point(215, 24)
        Me.txtReportTypeName.MaxLength = 250
        Me.txtReportTypeName.Name = "txtReportTypeName"
        Me.txtReportTypeName.ReadOnly = True
        Me.txtReportTypeName.Size = New System.Drawing.Size(321, 22)
        Me.txtReportTypeName.TabIndex = 2
        Me.txtReportTypeName.TabStop = False
        '
        'lblReportID
        '
        Me.lblReportID.AutoSize = True
        Me.lblReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportID.Location = New System.Drawing.Point(5, 58)
        Me.lblReportID.Name = "lblReportID"
        Me.lblReportID.Size = New System.Drawing.Size(45, 13)
        Me.lblReportID.TabIndex = 4
        Me.lblReportID.Text = "Đặc thù"
        Me.lblReportID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTitle.Location = New System.Drawing.Point(215, 53)
        Me.txtTitle.MaxLength = 250
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(322, 22)
        Me.txtTitle.TabIndex = 6
        Me.txtTitle.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLine1)
        Me.GroupBox2.Controls.Add(Me.lblLine)
        Me.GroupBox2.Controls.Add(Me.tdbcToPeriodID)
        Me.GroupBox2.Controls.Add(Me.tdbcFromPeriodID)
        Me.GroupBox2.Controls.Add(Me.chkPeriodID)
        Me.GroupBox2.Controls.Add(Me.tdbcToAssetID)
        Me.GroupBox2.Controls.Add(Me.tdbcFromAssetID)
        Me.GroupBox2.Controls.Add(Me.tdbcACodeID)
        Me.GroupBox2.Controls.Add(Me.tdbcGroupTypeID)
        Me.GroupBox2.Controls.Add(Me.lblGroupTypeID)
        Me.GroupBox2.Controls.Add(Me.txtDescription)
        Me.GroupBox2.Controls.Add(Me.lblFromAssetID)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(551, 118)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2. Điều kiện lọc"
        '
        'lblLine1
        '
        Me.lblLine1.AutoSize = True
        Me.lblLine1.Location = New System.Drawing.Point(230, 88)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(19, 13)
        Me.lblLine1.TabIndex = 10
        Me.lblLine1.Text = "---"
        Me.lblLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(230, 56)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(19, 13)
        Me.lblLine.TabIndex = 6
        Me.lblLine.Text = "---"
        Me.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tdbcToPeriodID
        '
        Me.tdbcToPeriodID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcToPeriodID.AllowColMove = False
        Me.tdbcToPeriodID.AllowSort = False
        Me.tdbcToPeriodID.AlternatingRows = True
        Me.tdbcToPeriodID.AutoCompletion = True
        Me.tdbcToPeriodID.AutoDropDown = True
        Me.tdbcToPeriodID.Caption = ""
        Me.tdbcToPeriodID.CaptionHeight = 17
        Me.tdbcToPeriodID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcToPeriodID.ColumnCaptionHeight = 17
        Me.tdbcToPeriodID.ColumnFooterHeight = 17
        Me.tdbcToPeriodID.ColumnHeaders = False
        Me.tdbcToPeriodID.ColumnWidth = 100
        Me.tdbcToPeriodID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcToPeriodID.DisplayMember = "Period"
        Me.tdbcToPeriodID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcToPeriodID.DropDownWidth = 128
        Me.tdbcToPeriodID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcToPeriodID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToPeriodID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcToPeriodID.EmptyRows = True
        Me.tdbcToPeriodID.Enabled = False
        Me.tdbcToPeriodID.ExtendRightColumn = True
        Me.tdbcToPeriodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToPeriodID.Images.Add(CType(resources.GetObject("tdbcToPeriodID.Images"), System.Drawing.Image))
        Me.tdbcToPeriodID.ItemHeight = 15
        Me.tdbcToPeriodID.Location = New System.Drawing.Point(270, 80)
        Me.tdbcToPeriodID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcToPeriodID.MaxDropDownItems = CType(8, Short)
        Me.tdbcToPeriodID.MaxLength = 20
        Me.tdbcToPeriodID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcToPeriodID.Name = "tdbcToPeriodID"
        Me.tdbcToPeriodID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcToPeriodID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcToPeriodID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcToPeriodID.TabIndex = 11
        Me.tdbcToPeriodID.ValueMember = "Period"
        Me.tdbcToPeriodID.PropBag = resources.GetString("tdbcToPeriodID.PropBag")
        '
        'tdbcFromPeriodID
        '
        Me.tdbcFromPeriodID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcFromPeriodID.AllowColMove = False
        Me.tdbcFromPeriodID.AllowSort = False
        Me.tdbcFromPeriodID.AlternatingRows = True
        Me.tdbcFromPeriodID.AutoCompletion = True
        Me.tdbcFromPeriodID.AutoDropDown = True
        Me.tdbcFromPeriodID.Caption = ""
        Me.tdbcFromPeriodID.CaptionHeight = 17
        Me.tdbcFromPeriodID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcFromPeriodID.ColumnCaptionHeight = 17
        Me.tdbcFromPeriodID.ColumnFooterHeight = 17
        Me.tdbcFromPeriodID.ColumnHeaders = False
        Me.tdbcFromPeriodID.ColumnWidth = 100
        Me.tdbcFromPeriodID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcFromPeriodID.DisplayMember = "Period"
        Me.tdbcFromPeriodID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcFromPeriodID.DropDownWidth = 128
        Me.tdbcFromPeriodID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcFromPeriodID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromPeriodID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcFromPeriodID.EmptyRows = True
        Me.tdbcFromPeriodID.Enabled = False
        Me.tdbcFromPeriodID.ExtendRightColumn = True
        Me.tdbcFromPeriodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromPeriodID.Images.Add(CType(resources.GetObject("tdbcFromPeriodID.Images"), System.Drawing.Image))
        Me.tdbcFromPeriodID.ItemHeight = 15
        Me.tdbcFromPeriodID.Location = New System.Drawing.Point(81, 80)
        Me.tdbcFromPeriodID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFromPeriodID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFromPeriodID.MaxLength = 20
        Me.tdbcFromPeriodID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFromPeriodID.Name = "tdbcFromPeriodID"
        Me.tdbcFromPeriodID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFromPeriodID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFromPeriodID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcFromPeriodID.TabIndex = 9
        Me.tdbcFromPeriodID.ValueMember = "Period"
        Me.tdbcFromPeriodID.PropBag = resources.GetString("tdbcFromPeriodID.PropBag")
        '
        'chkPeriodID
        '
        Me.chkPeriodID.AutoSize = True
        Me.chkPeriodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPeriodID.Location = New System.Drawing.Point(7, 87)
        Me.chkPeriodID.Name = "chkPeriodID"
        Me.chkPeriodID.Size = New System.Drawing.Size(38, 17)
        Me.chkPeriodID.TabIndex = 8
        Me.chkPeriodID.Text = "Kỳ"
        Me.chkPeriodID.UseVisualStyleBackColor = True
        '
        'tdbcToAssetID
        '
        Me.tdbcToAssetID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcToAssetID.AllowColMove = False
        Me.tdbcToAssetID.AllowSort = False
        Me.tdbcToAssetID.AlternatingRows = True
        Me.tdbcToAssetID.AutoCompletion = True
        Me.tdbcToAssetID.AutoDropDown = True
        Me.tdbcToAssetID.Caption = ""
        Me.tdbcToAssetID.CaptionHeight = 17
        Me.tdbcToAssetID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcToAssetID.ColumnCaptionHeight = 17
        Me.tdbcToAssetID.ColumnFooterHeight = 17
        Me.tdbcToAssetID.ColumnWidth = 100
        Me.tdbcToAssetID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcToAssetID.DisplayMember = "AssetID"
        Me.tdbcToAssetID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcToAssetID.DropDownWidth = 300
        Me.tdbcToAssetID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcToAssetID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToAssetID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcToAssetID.EmptyRows = True
        Me.tdbcToAssetID.ExtendRightColumn = True
        Me.tdbcToAssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToAssetID.Images.Add(CType(resources.GetObject("tdbcToAssetID.Images"), System.Drawing.Image))
        Me.tdbcToAssetID.ItemHeight = 15
        Me.tdbcToAssetID.Location = New System.Drawing.Point(270, 51)
        Me.tdbcToAssetID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcToAssetID.MaxDropDownItems = CType(8, Short)
        Me.tdbcToAssetID.MaxLength = 20
        Me.tdbcToAssetID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcToAssetID.Name = "tdbcToAssetID"
        Me.tdbcToAssetID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcToAssetID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcToAssetID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcToAssetID.TabIndex = 7
        Me.tdbcToAssetID.ValueMember = "AssetID"
        Me.tdbcToAssetID.PropBag = resources.GetString("tdbcToAssetID.PropBag")
        '
        'tdbcFromAssetID
        '
        Me.tdbcFromAssetID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcFromAssetID.AllowColMove = False
        Me.tdbcFromAssetID.AllowSort = False
        Me.tdbcFromAssetID.AlternatingRows = True
        Me.tdbcFromAssetID.AutoCompletion = True
        Me.tdbcFromAssetID.AutoDropDown = True
        Me.tdbcFromAssetID.AutoSelect = True
        Me.tdbcFromAssetID.Caption = ""
        Me.tdbcFromAssetID.CaptionHeight = 17
        Me.tdbcFromAssetID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcFromAssetID.ColumnCaptionHeight = 17
        Me.tdbcFromAssetID.ColumnFooterHeight = 17
        Me.tdbcFromAssetID.ColumnWidth = 100
        Me.tdbcFromAssetID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcFromAssetID.DisplayMember = "AssetID"
        Me.tdbcFromAssetID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcFromAssetID.DropDownWidth = 300
        Me.tdbcFromAssetID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcFromAssetID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromAssetID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcFromAssetID.EmptyRows = True
        Me.tdbcFromAssetID.ExtendRightColumn = True
        Me.tdbcFromAssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromAssetID.Images.Add(CType(resources.GetObject("tdbcFromAssetID.Images"), System.Drawing.Image))
        Me.tdbcFromAssetID.ItemHeight = 15
        Me.tdbcFromAssetID.Location = New System.Drawing.Point(81, 51)
        Me.tdbcFromAssetID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFromAssetID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFromAssetID.MaxLength = 20
        Me.tdbcFromAssetID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFromAssetID.Name = "tdbcFromAssetID"
        Me.tdbcFromAssetID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFromAssetID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFromAssetID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcFromAssetID.TabIndex = 5
        Me.tdbcFromAssetID.ValueMember = "AssetID"
        Me.tdbcFromAssetID.PropBag = resources.GetString("tdbcFromAssetID.PropBag")
        '
        'tdbcACodeID
        '
        Me.tdbcACodeID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcACodeID.AllowColMove = False
        Me.tdbcACodeID.AllowSort = False
        Me.tdbcACodeID.AlternatingRows = True
        Me.tdbcACodeID.AutoCompletion = True
        Me.tdbcACodeID.AutoDropDown = True
        Me.tdbcACodeID.Caption = ""
        Me.tdbcACodeID.CaptionHeight = 17
        Me.tdbcACodeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcACodeID.ColumnCaptionHeight = 17
        Me.tdbcACodeID.ColumnFooterHeight = 17
        Me.tdbcACodeID.ColumnWidth = 100
        Me.tdbcACodeID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcACodeID.DisplayMember = "ACodeID"
        Me.tdbcACodeID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcACodeID.DropDownWidth = 300
        Me.tdbcACodeID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcACodeID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcACodeID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcACodeID.EmptyRows = True
        Me.tdbcACodeID.ExtendRightColumn = True
        Me.tdbcACodeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcACodeID.Images.Add(CType(resources.GetObject("tdbcACodeID.Images"), System.Drawing.Image))
        Me.tdbcACodeID.ItemHeight = 15
        Me.tdbcACodeID.Location = New System.Drawing.Point(215, 19)
        Me.tdbcACodeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcACodeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcACodeID.MaxLength = 20
        Me.tdbcACodeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcACodeID.Name = "tdbcACodeID"
        Me.tdbcACodeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcACodeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcACodeID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcACodeID.TabIndex = 2
        Me.tdbcACodeID.ValueMember = "ACodeID"
        Me.tdbcACodeID.PropBag = resources.GetString("tdbcACodeID.PropBag")
        '
        'tdbcGroupTypeID
        '
        Me.tdbcGroupTypeID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcGroupTypeID.AllowColMove = False
        Me.tdbcGroupTypeID.AllowSort = False
        Me.tdbcGroupTypeID.AlternatingRows = True
        Me.tdbcGroupTypeID.AutoCompletion = True
        Me.tdbcGroupTypeID.AutoDropDown = True
        Me.tdbcGroupTypeID.Caption = ""
        Me.tdbcGroupTypeID.CaptionHeight = 17
        Me.tdbcGroupTypeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcGroupTypeID.ColumnCaptionHeight = 17
        Me.tdbcGroupTypeID.ColumnFooterHeight = 17
        Me.tdbcGroupTypeID.ColumnWidth = 100
        Me.tdbcGroupTypeID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcGroupTypeID.DisplayMember = "GroupTypeID"
        Me.tdbcGroupTypeID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcGroupTypeID.DropDownWidth = 300
        Me.tdbcGroupTypeID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcGroupTypeID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcGroupTypeID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcGroupTypeID.EmptyRows = True
        Me.tdbcGroupTypeID.ExtendRightColumn = True
        Me.tdbcGroupTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcGroupTypeID.Images.Add(CType(resources.GetObject("tdbcGroupTypeID.Images"), System.Drawing.Image))
        Me.tdbcGroupTypeID.ItemHeight = 15
        Me.tdbcGroupTypeID.Location = New System.Drawing.Point(81, 19)
        Me.tdbcGroupTypeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcGroupTypeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcGroupTypeID.MaxLength = 20
        Me.tdbcGroupTypeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcGroupTypeID.Name = "tdbcGroupTypeID"
        Me.tdbcGroupTypeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcGroupTypeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcGroupTypeID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcGroupTypeID.TabIndex = 1
        Me.tdbcGroupTypeID.ValueMember = "GroupTypeID"
        Me.tdbcGroupTypeID.PropBag = resources.GetString("tdbcGroupTypeID.PropBag")
        '
        'lblGroupTypeID
        '
        Me.lblGroupTypeID.AutoSize = True
        Me.lblGroupTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupTypeID.Location = New System.Drawing.Point(5, 24)
        Me.lblGroupTypeID.Name = "lblGroupTypeID"
        Me.lblGroupTypeID.Size = New System.Drawing.Size(51, 13)
        Me.lblGroupTypeID.TabIndex = 0
        Me.lblGroupTypeID.Text = "Phân loại"
        Me.lblGroupTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDescription.Location = New System.Drawing.Point(348, 20)
        Me.txtDescription.MaxLength = 250
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(188, 22)
        Me.txtDescription.TabIndex = 3
        Me.txtDescription.TabStop = False
        '
        'lblFromAssetID
        '
        Me.lblFromAssetID.AutoSize = True
        Me.lblFromAssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromAssetID.Location = New System.Drawing.Point(5, 56)
        Me.lblFromAssetID.Name = "lblFromAssetID"
        Me.lblFromAssetID.Size = New System.Drawing.Size(42, 13)
        Me.lblFromAssetID.TabIndex = 4
        Me.lblFromAssetID.Text = "Tài sản"
        Me.lblFromAssetID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(410, 282)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(74, 22)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "&In"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(488, 282)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(74, 22)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(10, 282)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(74, 22)
        Me.btnFilter.TabIndex = 3
        Me.btnFilter.Text = "&Lọc"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'grpDivisionID
        '
        Me.grpDivisionID.Controls.Add(Me.lblDivisionID)
        Me.grpDivisionID.Controls.Add(Me.tdbcDivisionID)
        Me.grpDivisionID.Controls.Add(Me.txtDivisionName)
        Me.grpDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDivisionID.Location = New System.Drawing.Point(10, 2)
        Me.grpDivisionID.Name = "grpDivisionID"
        Me.grpDivisionID.Size = New System.Drawing.Size(553, 52)
        Me.grpDivisionID.TabIndex = 0
        Me.grpDivisionID.TabStop = False
        Me.grpDivisionID.Text = "Đơn vị"
        '
        'lblDivisionID
        '
        Me.lblDivisionID.AutoSize = True
        Me.lblDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisionID.Location = New System.Drawing.Point(5, 21)
        Me.lblDivisionID.Name = "lblDivisionID"
        Me.lblDivisionID.Size = New System.Drawing.Size(38, 13)
        Me.lblDivisionID.TabIndex = 0
        Me.lblDivisionID.Text = "Đơn vị"
        Me.lblDivisionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tdbcDivisionID
        '
        Me.tdbcDivisionID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcDivisionID.AllowColMove = False
        Me.tdbcDivisionID.AllowSort = False
        Me.tdbcDivisionID.AlternatingRows = True
        Me.tdbcDivisionID.AutoCompletion = True
        Me.tdbcDivisionID.AutoDropDown = True
        Me.tdbcDivisionID.Caption = ""
        Me.tdbcDivisionID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcDivisionID.ColumnWidth = 100
        Me.tdbcDivisionID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcDivisionID.DisplayMember = "DivisionID"
        Me.tdbcDivisionID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcDivisionID.DropDownWidth = 350
        Me.tdbcDivisionID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcDivisionID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbcDivisionID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcDivisionID.EmptyRows = True
        Me.tdbcDivisionID.ExtendRightColumn = True
        Me.tdbcDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbcDivisionID.Images.Add(CType(resources.GetObject("tdbcDivisionID.Images"), System.Drawing.Image))
        Me.tdbcDivisionID.Location = New System.Drawing.Point(82, 17)
        Me.tdbcDivisionID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDivisionID.MaxDropDownItems = CType(8, Short)
        Me.tdbcDivisionID.MaxLength = 32767
        Me.tdbcDivisionID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDivisionID.Name = "tdbcDivisionID"
        Me.tdbcDivisionID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDivisionID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDivisionID.Size = New System.Drawing.Size(129, 21)
        Me.tdbcDivisionID.TabIndex = 1
        Me.tdbcDivisionID.ValueMember = "DivisionID"
        Me.tdbcDivisionID.PropBag = resources.GetString("tdbcDivisionID.PropBag")
        '
        'txtDivisionName
        '
        Me.txtDivisionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivisionName.Location = New System.Drawing.Point(216, 17)
        Me.txtDivisionName.Name = "txtDivisionName"
        Me.txtDivisionName.ReadOnly = True
        Me.txtDivisionName.Size = New System.Drawing.Size(322, 22)
        Me.txtDivisionName.TabIndex = 2
        Me.txtDivisionName.TabStop = False
        '
        'D02F3011
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 312)
        Me.Controls.Add(Me.grpDivisionID)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F3011"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PhiÕu nhËp TSC˜ - D02F3011"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tdbcToPeriodID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFromPeriodID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcToAssetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFromAssetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcACodeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcGroupTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDivisionID.ResumeLayout(False)
        Me.grpDivisionID.PerformLayout()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lblReportTypeID As System.Windows.Forms.Label
    Private WithEvents txtReportTypeName As System.Windows.Forms.TextBox
    Private WithEvents tdbcReportID As C1.Win.C1List.C1Combo
    Private WithEvents lblReportID As System.Windows.Forms.Label
    Private WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents tdbcGroupTypeID As C1.Win.C1List.C1Combo
    Private WithEvents lblGroupTypeID As System.Windows.Forms.Label
    Private WithEvents tdbcACodeID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcFromPeriodID As C1.Win.C1List.C1Combo
    Private WithEvents chkPeriodID As System.Windows.Forms.CheckBox
    Private WithEvents tdbcToAssetID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcFromAssetID As C1.Win.C1List.C1Combo
    Private WithEvents txtDescription As System.Windows.Forms.TextBox
    Private WithEvents lblFromAssetID As System.Windows.Forms.Label
    Private WithEvents tdbcToPeriodID As C1.Win.C1List.C1Combo
    Private WithEvents lblLine1 As System.Windows.Forms.Label
    Private WithEvents lblLine As System.Windows.Forms.Label
    Private WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnFilter As System.Windows.Forms.Button
    Private WithEvents txtReportTypeID As System.Windows.Forms.TextBox
    Private WithEvents grpDivisionID As System.Windows.Forms.GroupBox
    Private WithEvents lblDivisionID As System.Windows.Forms.Label
    Private WithEvents tdbcDivisionID As C1.Win.C1List.C1Combo
    Private WithEvents txtDivisionName As System.Windows.Forms.TextBox
End Class