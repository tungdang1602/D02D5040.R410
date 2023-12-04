<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F3020
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F3020))
        Me.tdbcReportID = New C1.Win.C1List.C1Combo()
        Me.txtReportTypeName = New System.Windows.Forms.TextBox()
        Me.txtReportTypeID = New System.Windows.Forms.TextBox()
        Me.lblReportTypeID = New System.Windows.Forms.Label()
        Me.lblReportID = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.chkIsLiquidated = New System.Windows.Forms.CheckBox()
        Me.chkIsNotLiquidated = New System.Windows.Forms.CheckBox()
        Me.chkIsStopDepreciation = New System.Windows.Forms.CheckBox()
        Me.chkIsDepreciation = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.tdbcToAssetID = New C1.Win.C1List.C1Combo()
        Me.tdbcFromAssetID = New C1.Win.C1List.C1Combo()
        Me.tdbcToPeriodID = New C1.Win.C1List.C1Combo()
        Me.tdbcFromPeriodID = New C1.Win.C1List.C1Combo()
        Me.tdbcACodeID = New C1.Win.C1List.C1Combo()
        Me.tdbcGroupTypeID = New C1.Win.C1List.C1Combo()
        Me.lblGroupTypeID = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblFromPeriodID = New System.Windows.Forms.Label()
        Me.lblFromAssetID = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.tdbcDivisionID = New C1.Win.C1List.C1Combo()
        Me.lblDivisionID = New System.Windows.Forms.Label()
        Me.txtDivisionName = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.grpDivisionID = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblGrpDivisionID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tdbcACode02ID = New C1.Win.C1List.C1Combo()
        Me.tdbcGroupType02ID = New C1.Win.C1List.C1Combo()
        Me.lblGroupType02ID = New System.Windows.Forms.Label()
        Me.txtDescription02 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tdbcACode03ID = New C1.Win.C1List.C1Combo()
        Me.tdbcGroupType03ID = New C1.Win.C1List.C1Combo()
        Me.lblGroupType03ID = New System.Windows.Forms.Label()
        Me.txtDescription03 = New System.Windows.Forms.TextBox()
        Me.chkIsPrintAsset = New System.Windows.Forms.CheckBox()
        Me.chkIsPrintTool = New System.Windows.Forms.CheckBox()
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcToAssetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFromAssetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcToPeriodID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFromPeriodID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcACodeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcGroupTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcACode02ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcGroupType02ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcACode03ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcGroupType03ID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.tdbcReportID.Location = New System.Drawing.Point(127, 95)
        Me.tdbcReportID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcReportID.MaxDropDownItems = CType(8, Short)
        Me.tdbcReportID.MaxLength = 20
        Me.tdbcReportID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcReportID.Name = "tdbcReportID"
        Me.tdbcReportID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcReportID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcReportID.Size = New System.Drawing.Size(141, 23)
        Me.tdbcReportID.TabIndex = 12
        Me.tdbcReportID.ValueMember = "ReportID"
        Me.tdbcReportID.PropBag = resources.GetString("tdbcReportID.PropBag")
        '
        'txtReportTypeName
        '
        Me.txtReportTypeName.Enabled = False
        Me.txtReportTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtReportTypeName.Location = New System.Drawing.Point(273, 67)
        Me.txtReportTypeName.MaxLength = 250
        Me.txtReportTypeName.Name = "txtReportTypeName"
        Me.txtReportTypeName.Size = New System.Drawing.Size(473, 22)
        Me.txtReportTypeName.TabIndex = 9
        '
        'txtReportTypeID
        '
        Me.txtReportTypeID.Enabled = False
        Me.txtReportTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtReportTypeID.Location = New System.Drawing.Point(127, 67)
        Me.txtReportTypeID.MaxLength = 20
        Me.txtReportTypeID.Name = "txtReportTypeID"
        Me.txtReportTypeID.Size = New System.Drawing.Size(141, 22)
        Me.txtReportTypeID.TabIndex = 8
        '
        'lblReportTypeID
        '
        Me.lblReportTypeID.AutoSize = True
        Me.lblReportTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportTypeID.Location = New System.Drawing.Point(28, 72)
        Me.lblReportTypeID.Name = "lblReportTypeID"
        Me.lblReportTypeID.Size = New System.Drawing.Size(61, 13)
        Me.lblReportTypeID.TabIndex = 7
        Me.lblReportTypeID.Text = "Mẫu chuẩn"
        Me.lblReportTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReportID
        '
        Me.lblReportID.AutoSize = True
        Me.lblReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportID.Location = New System.Drawing.Point(28, 100)
        Me.lblReportID.Name = "lblReportID"
        Me.lblReportID.Size = New System.Drawing.Size(45, 13)
        Me.lblReportID.TabIndex = 11
        Me.lblReportID.Text = "Đặc thù"
        Me.lblReportID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTitle
        '
        Me.txtTitle.Enabled = False
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTitle.Location = New System.Drawing.Point(273, 95)
        Me.txtTitle.MaxLength = 250
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(473, 22)
        Me.txtTitle.TabIndex = 13
        Me.txtTitle.TabStop = False
        '
        'chkIsLiquidated
        '
        Me.chkIsLiquidated.AutoSize = True
        Me.chkIsLiquidated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsLiquidated.Location = New System.Drawing.Point(299, 284)
        Me.chkIsLiquidated.Name = "chkIsLiquidated"
        Me.chkIsLiquidated.Size = New System.Drawing.Size(173, 17)
        Me.chkIsLiquidated.TabIndex = 38
        Me.chkIsLiquidated.Text = "Hiển thị các tài sản đã thanh lý"
        Me.chkIsLiquidated.UseVisualStyleBackColor = True
        '
        'chkIsNotLiquidated
        '
        Me.chkIsNotLiquidated.AutoSize = True
        Me.chkIsNotLiquidated.Checked = True
        Me.chkIsNotLiquidated.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIsNotLiquidated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsNotLiquidated.Location = New System.Drawing.Point(299, 263)
        Me.chkIsNotLiquidated.Name = "chkIsNotLiquidated"
        Me.chkIsNotLiquidated.Size = New System.Drawing.Size(184, 17)
        Me.chkIsNotLiquidated.TabIndex = 37
        Me.chkIsNotLiquidated.Text = "Hiển thị các tài sản chưa thanh lý"
        Me.chkIsNotLiquidated.UseVisualStyleBackColor = True
        '
        'chkIsStopDepreciation
        '
        Me.chkIsStopDepreciation.AutoSize = True
        Me.chkIsStopDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsStopDepreciation.Location = New System.Drawing.Point(31, 284)
        Me.chkIsStopDepreciation.Name = "chkIsStopDepreciation"
        Me.chkIsStopDepreciation.Size = New System.Drawing.Size(198, 17)
        Me.chkIsStopDepreciation.TabIndex = 36
        Me.chkIsStopDepreciation.Text = "Hiển thị các tài sản ngưng khấu hao"
        Me.chkIsStopDepreciation.UseVisualStyleBackColor = True
        '
        'chkIsDepreciation
        '
        Me.chkIsDepreciation.AutoSize = True
        Me.chkIsDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsDepreciation.Location = New System.Drawing.Point(31, 263)
        Me.chkIsDepreciation.Name = "chkIsDepreciation"
        Me.chkIsDepreciation.Size = New System.Drawing.Size(186, 17)
        Me.chkIsDepreciation.TabIndex = 35
        Me.chkIsDepreciation.Text = "Hiển thị các tài sản còn khấu hao"
        Me.chkIsDepreciation.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(274, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "---"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(274, 237)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(16, 13)
        Me.lblLabel2.TabIndex = 33
        Me.lblLabel2.Text = "---"
        Me.lblLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(274, 339)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(16, 13)
        Me.lblLabel1.TabIndex = 43
        Me.lblLabel1.Text = "---"
        Me.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tdbcToAssetID.Location = New System.Drawing.Point(299, 232)
        Me.tdbcToAssetID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcToAssetID.MaxDropDownItems = CType(8, Short)
        Me.tdbcToAssetID.MaxLength = 20
        Me.tdbcToAssetID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcToAssetID.Name = "tdbcToAssetID"
        Me.tdbcToAssetID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcToAssetID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcToAssetID.Size = New System.Drawing.Size(137, 23)
        Me.tdbcToAssetID.TabIndex = 34
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
        Me.tdbcFromAssetID.Location = New System.Drawing.Point(127, 232)
        Me.tdbcFromAssetID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFromAssetID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFromAssetID.MaxLength = 20
        Me.tdbcFromAssetID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFromAssetID.Name = "tdbcFromAssetID"
        Me.tdbcFromAssetID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFromAssetID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFromAssetID.Size = New System.Drawing.Size(141, 23)
        Me.tdbcFromAssetID.TabIndex = 32
        Me.tdbcFromAssetID.ValueMember = "AssetID"
        Me.tdbcFromAssetID.PropBag = resources.GetString("tdbcFromAssetID.PropBag")
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
        Me.tdbcToPeriodID.ExtendRightColumn = True
        Me.tdbcToPeriodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToPeriodID.Images.Add(CType(resources.GetObject("tdbcToPeriodID.Images"), System.Drawing.Image))
        Me.tdbcToPeriodID.ItemHeight = 15
        Me.tdbcToPeriodID.Location = New System.Drawing.Point(299, 334)
        Me.tdbcToPeriodID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcToPeriodID.MaxDropDownItems = CType(8, Short)
        Me.tdbcToPeriodID.MaxLength = 20
        Me.tdbcToPeriodID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcToPeriodID.Name = "tdbcToPeriodID"
        Me.tdbcToPeriodID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcToPeriodID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcToPeriodID.Size = New System.Drawing.Size(137, 23)
        Me.tdbcToPeriodID.TabIndex = 44
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
        Me.tdbcFromPeriodID.ExtendRightColumn = True
        Me.tdbcFromPeriodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromPeriodID.Images.Add(CType(resources.GetObject("tdbcFromPeriodID.Images"), System.Drawing.Image))
        Me.tdbcFromPeriodID.ItemHeight = 15
        Me.tdbcFromPeriodID.Location = New System.Drawing.Point(127, 334)
        Me.tdbcFromPeriodID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFromPeriodID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFromPeriodID.MaxLength = 20
        Me.tdbcFromPeriodID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFromPeriodID.Name = "tdbcFromPeriodID"
        Me.tdbcFromPeriodID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFromPeriodID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFromPeriodID.Size = New System.Drawing.Size(141, 23)
        Me.tdbcFromPeriodID.TabIndex = 42
        Me.tdbcFromPeriodID.ValueMember = "Period"
        Me.tdbcFromPeriodID.PropBag = resources.GetString("tdbcFromPeriodID.PropBag")
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
        Me.tdbcACodeID.Location = New System.Drawing.Point(299, 145)
        Me.tdbcACodeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcACodeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcACodeID.MaxLength = 20
        Me.tdbcACodeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcACodeID.Name = "tdbcACodeID"
        Me.tdbcACodeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcACodeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcACodeID.Size = New System.Drawing.Size(137, 23)
        Me.tdbcACodeID.TabIndex = 19
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
        Me.tdbcGroupTypeID.Location = New System.Drawing.Point(127, 145)
        Me.tdbcGroupTypeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcGroupTypeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcGroupTypeID.MaxLength = 20
        Me.tdbcGroupTypeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcGroupTypeID.Name = "tdbcGroupTypeID"
        Me.tdbcGroupTypeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcGroupTypeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcGroupTypeID.Size = New System.Drawing.Size(141, 23)
        Me.tdbcGroupTypeID.TabIndex = 17
        Me.tdbcGroupTypeID.ValueMember = "GroupTypeID"
        Me.tdbcGroupTypeID.PropBag = resources.GetString("tdbcGroupTypeID.PropBag")
        '
        'lblGroupTypeID
        '
        Me.lblGroupTypeID.AutoSize = True
        Me.lblGroupTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupTypeID.Location = New System.Drawing.Point(28, 150)
        Me.lblGroupTypeID.Name = "lblGroupTypeID"
        Me.lblGroupTypeID.Size = New System.Drawing.Size(60, 13)
        Me.lblGroupTypeID.TabIndex = 16
        Me.lblGroupTypeID.Text = "Phân loại 1"
        Me.lblGroupTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDescription.Location = New System.Drawing.Point(439, 145)
        Me.txtDescription.MaxLength = 250
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(310, 22)
        Me.txtDescription.TabIndex = 20
        Me.txtDescription.TabStop = False
        '
        'lblFromPeriodID
        '
        Me.lblFromPeriodID.AutoSize = True
        Me.lblFromPeriodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromPeriodID.Location = New System.Drawing.Point(28, 339)
        Me.lblFromPeriodID.Name = "lblFromPeriodID"
        Me.lblFromPeriodID.Size = New System.Drawing.Size(19, 13)
        Me.lblFromPeriodID.TabIndex = 41
        Me.lblFromPeriodID.Text = "Kỳ"
        Me.lblFromPeriodID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFromAssetID
        '
        Me.lblFromAssetID.AutoSize = True
        Me.lblFromAssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromAssetID.Location = New System.Drawing.Point(28, 237)
        Me.lblFromAssetID.Name = "lblFromAssetID"
        Me.lblFromAssetID.Size = New System.Drawing.Size(42, 13)
        Me.lblFromAssetID.TabIndex = 31
        Me.lblFromAssetID.Text = "Tài sản"
        Me.lblFromAssetID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(592, 363)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(74, 22)
        Me.btnPrint.TabIndex = 45
        Me.btnPrint.Text = "&In"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(672, 363)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(74, 22)
        Me.btnClose.TabIndex = 46
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(6, 363)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(74, 22)
        Me.btnFilter.TabIndex = 47
        Me.btnFilter.Text = "&Lọc"
        Me.btnFilter.UseVisualStyleBackColor = True
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
        Me.tdbcDivisionID.Location = New System.Drawing.Point(127, 22)
        Me.tdbcDivisionID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDivisionID.MaxDropDownItems = CType(8, Short)
        Me.tdbcDivisionID.MaxLength = 32767
        Me.tdbcDivisionID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDivisionID.Name = "tdbcDivisionID"
        Me.tdbcDivisionID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDivisionID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDivisionID.Size = New System.Drawing.Size(141, 21)
        Me.tdbcDivisionID.TabIndex = 3
        Me.tdbcDivisionID.ValueMember = "DivisionID"
        Me.tdbcDivisionID.PropBag = resources.GetString("tdbcDivisionID.PropBag")
        '
        'lblDivisionID
        '
        Me.lblDivisionID.AutoSize = True
        Me.lblDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisionID.Location = New System.Drawing.Point(28, 26)
        Me.lblDivisionID.Name = "lblDivisionID"
        Me.lblDivisionID.Size = New System.Drawing.Size(38, 13)
        Me.lblDivisionID.TabIndex = 2
        Me.lblDivisionID.Text = "Đơn vị"
        Me.lblDivisionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDivisionName
        '
        Me.txtDivisionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivisionName.Location = New System.Drawing.Point(273, 22)
        Me.txtDivisionName.Name = "txtDivisionName"
        Me.txtDivisionName.ReadOnly = True
        Me.txtDivisionName.Size = New System.Drawing.Size(473, 22)
        Me.txtDivisionName.TabIndex = 4
        Me.txtDivisionName.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(13, 314)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(60, 13)
        Me.lblTime.TabIndex = 39
        Me.lblTime.Text = "Thời gian"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(106, 321)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 3)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilter.Location = New System.Drawing.Point(13, 123)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(82, 13)
        Me.lblFilter.TabIndex = 14
        Me.lblFilter.Text = "Điều kiện lọc"
        Me.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(106, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 3)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'lblReport
        '
        Me.lblReport.AutoSize = True
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(13, 49)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(81, 13)
        Me.lblReport.TabIndex = 5
        Me.lblReport.Text = "Mẫu báo cáo"
        Me.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpDivisionID
        '
        Me.grpDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDivisionID.Location = New System.Drawing.Point(106, 11)
        Me.grpDivisionID.Name = "grpDivisionID"
        Me.grpDivisionID.Size = New System.Drawing.Size(640, 3)
        Me.grpDivisionID.TabIndex = 1
        Me.grpDivisionID.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(106, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 3)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'lblGrpDivisionID
        '
        Me.lblGrpDivisionID.AutoSize = True
        Me.lblGrpDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrpDivisionID.Location = New System.Drawing.Point(13, 5)
        Me.lblGrpDivisionID.Name = "lblGrpDivisionID"
        Me.lblGrpDivisionID.Size = New System.Drawing.Size(44, 13)
        Me.lblGrpDivisionID.TabIndex = 0
        Me.lblGrpDivisionID.Text = "Đơn vị"
        Me.lblGrpDivisionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "---"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tdbcACode02ID
        '
        Me.tdbcACode02ID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcACode02ID.AllowColMove = False
        Me.tdbcACode02ID.AllowSort = False
        Me.tdbcACode02ID.AlternatingRows = True
        Me.tdbcACode02ID.AutoCompletion = True
        Me.tdbcACode02ID.AutoDropDown = True
        Me.tdbcACode02ID.Caption = ""
        Me.tdbcACode02ID.CaptionHeight = 17
        Me.tdbcACode02ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcACode02ID.ColumnCaptionHeight = 17
        Me.tdbcACode02ID.ColumnFooterHeight = 17
        Me.tdbcACode02ID.ColumnWidth = 100
        Me.tdbcACode02ID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcACode02ID.DisplayMember = "ACodeID"
        Me.tdbcACode02ID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcACode02ID.DropDownWidth = 300
        Me.tdbcACode02ID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcACode02ID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcACode02ID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcACode02ID.EmptyRows = True
        Me.tdbcACode02ID.ExtendRightColumn = True
        Me.tdbcACode02ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcACode02ID.Images.Add(CType(resources.GetObject("tdbcACode02ID.Images"), System.Drawing.Image))
        Me.tdbcACode02ID.ItemHeight = 15
        Me.tdbcACode02ID.Location = New System.Drawing.Point(299, 173)
        Me.tdbcACode02ID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcACode02ID.MaxDropDownItems = CType(8, Short)
        Me.tdbcACode02ID.MaxLength = 20
        Me.tdbcACode02ID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcACode02ID.Name = "tdbcACode02ID"
        Me.tdbcACode02ID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcACode02ID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcACode02ID.Size = New System.Drawing.Size(137, 23)
        Me.tdbcACode02ID.TabIndex = 24
        Me.tdbcACode02ID.ValueMember = "ACodeID"
        Me.tdbcACode02ID.PropBag = resources.GetString("tdbcACode02ID.PropBag")
        '
        'tdbcGroupType02ID
        '
        Me.tdbcGroupType02ID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcGroupType02ID.AllowColMove = False
        Me.tdbcGroupType02ID.AllowSort = False
        Me.tdbcGroupType02ID.AlternatingRows = True
        Me.tdbcGroupType02ID.AutoCompletion = True
        Me.tdbcGroupType02ID.AutoDropDown = True
        Me.tdbcGroupType02ID.Caption = ""
        Me.tdbcGroupType02ID.CaptionHeight = 17
        Me.tdbcGroupType02ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcGroupType02ID.ColumnCaptionHeight = 17
        Me.tdbcGroupType02ID.ColumnFooterHeight = 17
        Me.tdbcGroupType02ID.ColumnWidth = 100
        Me.tdbcGroupType02ID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcGroupType02ID.DisplayMember = "GroupTypeID"
        Me.tdbcGroupType02ID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcGroupType02ID.DropDownWidth = 300
        Me.tdbcGroupType02ID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcGroupType02ID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcGroupType02ID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcGroupType02ID.EmptyRows = True
        Me.tdbcGroupType02ID.ExtendRightColumn = True
        Me.tdbcGroupType02ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcGroupType02ID.Images.Add(CType(resources.GetObject("tdbcGroupType02ID.Images"), System.Drawing.Image))
        Me.tdbcGroupType02ID.ItemHeight = 15
        Me.tdbcGroupType02ID.Location = New System.Drawing.Point(127, 173)
        Me.tdbcGroupType02ID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcGroupType02ID.MaxDropDownItems = CType(8, Short)
        Me.tdbcGroupType02ID.MaxLength = 20
        Me.tdbcGroupType02ID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcGroupType02ID.Name = "tdbcGroupType02ID"
        Me.tdbcGroupType02ID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcGroupType02ID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcGroupType02ID.Size = New System.Drawing.Size(141, 23)
        Me.tdbcGroupType02ID.TabIndex = 22
        Me.tdbcGroupType02ID.ValueMember = "GroupTypeID"
        Me.tdbcGroupType02ID.PropBag = resources.GetString("tdbcGroupType02ID.PropBag")
        '
        'lblGroupType02ID
        '
        Me.lblGroupType02ID.AutoSize = True
        Me.lblGroupType02ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupType02ID.Location = New System.Drawing.Point(28, 178)
        Me.lblGroupType02ID.Name = "lblGroupType02ID"
        Me.lblGroupType02ID.Size = New System.Drawing.Size(60, 13)
        Me.lblGroupType02ID.TabIndex = 21
        Me.lblGroupType02ID.Text = "Phân loại 2"
        Me.lblGroupType02ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription02
        '
        Me.txtDescription02.Enabled = False
        Me.txtDescription02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDescription02.Location = New System.Drawing.Point(439, 173)
        Me.txtDescription02.MaxLength = 250
        Me.txtDescription02.Name = "txtDescription02"
        Me.txtDescription02.ReadOnly = True
        Me.txtDescription02.Size = New System.Drawing.Size(310, 22)
        Me.txtDescription02.TabIndex = 25
        Me.txtDescription02.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "---"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tdbcACode03ID
        '
        Me.tdbcACode03ID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcACode03ID.AllowColMove = False
        Me.tdbcACode03ID.AllowSort = False
        Me.tdbcACode03ID.AlternatingRows = True
        Me.tdbcACode03ID.AutoCompletion = True
        Me.tdbcACode03ID.AutoDropDown = True
        Me.tdbcACode03ID.Caption = ""
        Me.tdbcACode03ID.CaptionHeight = 17
        Me.tdbcACode03ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcACode03ID.ColumnCaptionHeight = 17
        Me.tdbcACode03ID.ColumnFooterHeight = 17
        Me.tdbcACode03ID.ColumnWidth = 100
        Me.tdbcACode03ID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcACode03ID.DisplayMember = "ACodeID"
        Me.tdbcACode03ID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcACode03ID.DropDownWidth = 300
        Me.tdbcACode03ID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcACode03ID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcACode03ID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcACode03ID.EmptyRows = True
        Me.tdbcACode03ID.ExtendRightColumn = True
        Me.tdbcACode03ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcACode03ID.Images.Add(CType(resources.GetObject("tdbcACode03ID.Images"), System.Drawing.Image))
        Me.tdbcACode03ID.ItemHeight = 15
        Me.tdbcACode03ID.Location = New System.Drawing.Point(299, 202)
        Me.tdbcACode03ID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcACode03ID.MaxDropDownItems = CType(8, Short)
        Me.tdbcACode03ID.MaxLength = 20
        Me.tdbcACode03ID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcACode03ID.Name = "tdbcACode03ID"
        Me.tdbcACode03ID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcACode03ID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcACode03ID.Size = New System.Drawing.Size(137, 23)
        Me.tdbcACode03ID.TabIndex = 29
        Me.tdbcACode03ID.ValueMember = "ACodeID"
        Me.tdbcACode03ID.PropBag = resources.GetString("tdbcACode03ID.PropBag")
        '
        'tdbcGroupType03ID
        '
        Me.tdbcGroupType03ID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcGroupType03ID.AllowColMove = False
        Me.tdbcGroupType03ID.AllowSort = False
        Me.tdbcGroupType03ID.AlternatingRows = True
        Me.tdbcGroupType03ID.AutoCompletion = True
        Me.tdbcGroupType03ID.AutoDropDown = True
        Me.tdbcGroupType03ID.Caption = ""
        Me.tdbcGroupType03ID.CaptionHeight = 17
        Me.tdbcGroupType03ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcGroupType03ID.ColumnCaptionHeight = 17
        Me.tdbcGroupType03ID.ColumnFooterHeight = 17
        Me.tdbcGroupType03ID.ColumnWidth = 100
        Me.tdbcGroupType03ID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcGroupType03ID.DisplayMember = "GroupTypeID"
        Me.tdbcGroupType03ID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcGroupType03ID.DropDownWidth = 300
        Me.tdbcGroupType03ID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcGroupType03ID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcGroupType03ID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcGroupType03ID.EmptyRows = True
        Me.tdbcGroupType03ID.ExtendRightColumn = True
        Me.tdbcGroupType03ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcGroupType03ID.Images.Add(CType(resources.GetObject("tdbcGroupType03ID.Images"), System.Drawing.Image))
        Me.tdbcGroupType03ID.ItemHeight = 15
        Me.tdbcGroupType03ID.Location = New System.Drawing.Point(127, 202)
        Me.tdbcGroupType03ID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcGroupType03ID.MaxDropDownItems = CType(8, Short)
        Me.tdbcGroupType03ID.MaxLength = 20
        Me.tdbcGroupType03ID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcGroupType03ID.Name = "tdbcGroupType03ID"
        Me.tdbcGroupType03ID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcGroupType03ID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcGroupType03ID.Size = New System.Drawing.Size(141, 23)
        Me.tdbcGroupType03ID.TabIndex = 27
        Me.tdbcGroupType03ID.ValueMember = "GroupTypeID"
        Me.tdbcGroupType03ID.PropBag = resources.GetString("tdbcGroupType03ID.PropBag")
        '
        'lblGroupType03ID
        '
        Me.lblGroupType03ID.AutoSize = True
        Me.lblGroupType03ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupType03ID.Location = New System.Drawing.Point(28, 207)
        Me.lblGroupType03ID.Name = "lblGroupType03ID"
        Me.lblGroupType03ID.Size = New System.Drawing.Size(60, 13)
        Me.lblGroupType03ID.TabIndex = 26
        Me.lblGroupType03ID.Text = "Phân loại 3"
        Me.lblGroupType03ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription03
        '
        Me.txtDescription03.Enabled = False
        Me.txtDescription03.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDescription03.Location = New System.Drawing.Point(439, 202)
        Me.txtDescription03.MaxLength = 250
        Me.txtDescription03.Name = "txtDescription03"
        Me.txtDescription03.ReadOnly = True
        Me.txtDescription03.Size = New System.Drawing.Size(310, 22)
        Me.txtDescription03.TabIndex = 30
        Me.txtDescription03.TabStop = False
        '
        'chkIsPrintAsset
        '
        Me.chkIsPrintAsset.AutoSize = True
        Me.chkIsPrintAsset.Checked = True
        Me.chkIsPrintAsset.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIsPrintAsset.Location = New System.Drawing.Point(514, 263)
        Me.chkIsPrintAsset.Name = "chkIsPrintAsset"
        Me.chkIsPrintAsset.Size = New System.Drawing.Size(108, 17)
        Me.chkIsPrintAsset.TabIndex = 48
        Me.chkIsPrintAsset.Text = "In tài sản cố định"
        Me.chkIsPrintAsset.UseVisualStyleBackColor = True
        '
        'chkIsPrintTool
        '
        Me.chkIsPrintTool.AutoSize = True
        Me.chkIsPrintTool.Location = New System.Drawing.Point(514, 284)
        Me.chkIsPrintTool.Name = "chkIsPrintTool"
        Me.chkIsPrintTool.Size = New System.Drawing.Size(119, 17)
        Me.chkIsPrintTool.TabIndex = 49
        Me.chkIsPrintTool.Text = "In công cụ dụng cụ"
        Me.chkIsPrintTool.UseVisualStyleBackColor = True
        '
        'D02F3020
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 391)
        Me.Controls.Add(Me.chkIsPrintTool)
        Me.Controls.Add(Me.chkIsPrintAsset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tdbcACode03ID)
        Me.Controls.Add(Me.tdbcGroupType03ID)
        Me.Controls.Add(Me.lblGroupType03ID)
        Me.Controls.Add(Me.txtDescription03)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tdbcACode02ID)
        Me.Controls.Add(Me.tdbcGroupType02ID)
        Me.Controls.Add(Me.lblGroupType02ID)
        Me.Controls.Add(Me.txtDescription02)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.grpDivisionID)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblGrpDivisionID)
        Me.Controls.Add(Me.chkIsLiquidated)
        Me.Controls.Add(Me.tdbcReportID)
        Me.Controls.Add(Me.chkIsNotLiquidated)
        Me.Controls.Add(Me.lblDivisionID)
        Me.Controls.Add(Me.chkIsStopDepreciation)
        Me.Controls.Add(Me.txtReportTypeName)
        Me.Controls.Add(Me.chkIsDepreciation)
        Me.Controls.Add(Me.tdbcDivisionID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReportTypeID)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblReportTypeID)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.tdbcToAssetID)
        Me.Controls.Add(Me.lblReportID)
        Me.Controls.Add(Me.tdbcFromAssetID)
        Me.Controls.Add(Me.txtDivisionName)
        Me.Controls.Add(Me.tdbcToPeriodID)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.tdbcFromPeriodID)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.tdbcACodeID)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tdbcGroupTypeID)
        Me.Controls.Add(Me.lblGroupTypeID)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblFromAssetID)
        Me.Controls.Add(Me.lblFromPeriodID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F3020"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BÀo cÀo danh sÀch TSC˜ phÀt sinh - D02F3020"
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcToAssetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFromAssetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcToPeriodID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFromPeriodID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcACodeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcGroupTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcACode02ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcGroupType02ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcACode03ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcGroupType03ID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtReportTypeName As System.Windows.Forms.TextBox
    Private WithEvents txtReportTypeID As System.Windows.Forms.TextBox
    Private WithEvents lblReportTypeID As System.Windows.Forms.Label
    Private WithEvents tdbcReportID As C1.Win.C1List.C1Combo
    Private WithEvents lblReportID As System.Windows.Forms.Label
    Private WithEvents txtTitle As System.Windows.Forms.TextBox
    Private WithEvents tdbcGroupTypeID As C1.Win.C1List.C1Combo
    Private WithEvents lblGroupTypeID As System.Windows.Forms.Label
    Private WithEvents tdbcToAssetID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcFromAssetID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcToPeriodID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcFromPeriodID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcACodeID As C1.Win.C1List.C1Combo
    Private WithEvents txtDescription As System.Windows.Forms.TextBox
    Private WithEvents lblFromPeriodID As System.Windows.Forms.Label
    Private WithEvents lblFromAssetID As System.Windows.Forms.Label
    Private WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnFilter As System.Windows.Forms.Button
    Private WithEvents lblLabel2 As System.Windows.Forms.Label
    Private WithEvents lblLabel1 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents chkIsNotLiquidated As System.Windows.Forms.CheckBox
    Private WithEvents chkIsStopDepreciation As System.Windows.Forms.CheckBox
    Private WithEvents chkIsDepreciation As System.Windows.Forms.CheckBox
    Private WithEvents chkIsLiquidated As System.Windows.Forms.CheckBox
    Private WithEvents tdbcDivisionID As C1.Win.C1List.C1Combo
    Private WithEvents lblDivisionID As System.Windows.Forms.Label
    Private WithEvents txtDivisionName As System.Windows.Forms.TextBox
    Private WithEvents lblTime As System.Windows.Forms.Label
    Private WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents lblFilter As System.Windows.Forms.Label
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lblReport As System.Windows.Forms.Label
    Private WithEvents grpDivisionID As System.Windows.Forms.GroupBox
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents lblGrpDivisionID As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents tdbcACode02ID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcGroupType02ID As C1.Win.C1List.C1Combo
    Private WithEvents lblGroupType02ID As System.Windows.Forms.Label
    Private WithEvents txtDescription02 As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents tdbcACode03ID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcGroupType03ID As C1.Win.C1List.C1Combo
    Private WithEvents lblGroupType03ID As System.Windows.Forms.Label
    Private WithEvents txtDescription03 As System.Windows.Forms.TextBox
    Private WithEvents chkIsPrintAsset As System.Windows.Forms.CheckBox
    Private WithEvents chkIsPrintTool As System.Windows.Forms.CheckBox
End Class