<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F3200
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F3200))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tdbcReportTypeID = New C1.Win.C1List.C1Combo()
        Me.optDetail = New System.Windows.Forms.RadioButton()
        Me.optSum = New System.Windows.Forms.RadioButton()
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
        Me.tdbcToAssetID = New C1.Win.C1List.C1Combo()
        Me.tdbcFromAssetID = New C1.Win.C1List.C1Combo()
        Me.tdbcAccountID = New C1.Win.C1List.C1Combo()
        Me.tdbcDivisionID = New C1.Win.C1List.C1Combo()
        Me.lblDivisionID = New System.Windows.Forms.Label()
        Me.txtDivisionName = New System.Windows.Forms.TextBox()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.lblFromAssetID = New System.Windows.Forms.Label()
        Me.lblFromPeriodID = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tdbcReportTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tdbcToPeriodID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFromPeriodID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcToAssetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFromAssetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcAccountID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tdbcReportTypeID)
        Me.GroupBox1.Controls.Add(Me.optDetail)
        Me.GroupBox1.Controls.Add(Me.optSum)
        Me.GroupBox1.Controls.Add(Me.tdbcReportID)
        Me.GroupBox1.Controls.Add(Me.lblReportTypeID)
        Me.GroupBox1.Controls.Add(Me.txtReportTypeName)
        Me.GroupBox1.Controls.Add(Me.lblReportID)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 99)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1. Dạng báo cáo"
        '
        'tdbcReportTypeID
        '
        Me.tdbcReportTypeID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcReportTypeID.AllowColMove = False
        Me.tdbcReportTypeID.AllowColSelect = True
        Me.tdbcReportTypeID.AllowSort = False
        Me.tdbcReportTypeID.AlternatingRows = True
        Me.tdbcReportTypeID.AutoCompletion = True
        Me.tdbcReportTypeID.AutoDropDown = True
        Me.tdbcReportTypeID.Caption = ""
        Me.tdbcReportTypeID.CaptionHeight = 17
        Me.tdbcReportTypeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcReportTypeID.ColumnCaptionHeight = 17
        Me.tdbcReportTypeID.ColumnFooterHeight = 17
        Me.tdbcReportTypeID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcReportTypeID.DisplayMember = "ReportID"
        Me.tdbcReportTypeID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcReportTypeID.DropDownWidth = 500
        Me.tdbcReportTypeID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcReportTypeID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportTypeID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcReportTypeID.EmptyRows = True
        Me.tdbcReportTypeID.ExtendRightColumn = True
        Me.tdbcReportTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportTypeID.Images.Add(CType(resources.GetObject("tdbcReportTypeID.Images"), System.Drawing.Image))
        Me.tdbcReportTypeID.ItemHeight = 15
        Me.tdbcReportTypeID.Location = New System.Drawing.Point(81, 39)
        Me.tdbcReportTypeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcReportTypeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcReportTypeID.MaxLength = 20
        Me.tdbcReportTypeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcReportTypeID.Name = "tdbcReportTypeID"
        Me.tdbcReportTypeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcReportTypeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcReportTypeID.Size = New System.Drawing.Size(128, 22)
        Me.tdbcReportTypeID.TabIndex = 3
        Me.tdbcReportTypeID.ValueMember = "ReportID"
        Me.tdbcReportTypeID.PropBag = resources.GetString("tdbcReportTypeID.PropBag")
        '
        'optDetail
        '
        Me.optDetail.AutoSize = True
        Me.optDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDetail.Location = New System.Drawing.Point(214, 18)
        Me.optDetail.Name = "optDetail"
        Me.optDetail.Size = New System.Drawing.Size(65, 20)
        Me.optDetail.TabIndex = 1
        Me.optDetail.Text = "Chi tiết"
        Me.optDetail.UseVisualStyleBackColor = True
        '
        'optSum
        '
        Me.optSum.AutoSize = True
        Me.optSum.Checked = True
        Me.optSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSum.Location = New System.Drawing.Point(80, 18)
        Me.optSum.Name = "optSum"
        Me.optSum.Size = New System.Drawing.Size(84, 20)
        Me.optSum.TabIndex = 0
        Me.optSum.TabStop = True
        Me.optSum.Text = "Tổng hợp"
        Me.optSum.UseVisualStyleBackColor = True
        '
        'tdbcReportID
        '
        Me.tdbcReportID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcReportID.AllowColMove = False
        Me.tdbcReportID.AllowColSelect = True
        Me.tdbcReportID.AllowSort = False
        Me.tdbcReportID.AlternatingRows = True
        Me.tdbcReportID.AutoCompletion = True
        Me.tdbcReportID.AutoDropDown = True
        Me.tdbcReportID.Caption = ""
        Me.tdbcReportID.CaptionHeight = 17
        Me.tdbcReportID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcReportID.ColumnCaptionHeight = 17
        Me.tdbcReportID.ColumnFooterHeight = 17
        Me.tdbcReportID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcReportID.DisplayMember = "ReportID"
        Me.tdbcReportID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcReportID.DropDownWidth = 500
        Me.tdbcReportID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcReportID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcReportID.EmptyRows = True
        Me.tdbcReportID.ExtendRightColumn = True
        Me.tdbcReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportID.Images.Add(CType(resources.GetObject("tdbcReportID.Images"), System.Drawing.Image))
        Me.tdbcReportID.ItemHeight = 15
        Me.tdbcReportID.Location = New System.Drawing.Point(81, 68)
        Me.tdbcReportID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcReportID.MaxDropDownItems = CType(8, Short)
        Me.tdbcReportID.MaxLength = 20
        Me.tdbcReportID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcReportID.Name = "tdbcReportID"
        Me.tdbcReportID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcReportID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcReportID.Size = New System.Drawing.Size(128, 22)
        Me.tdbcReportID.TabIndex = 6
        Me.tdbcReportID.ValueMember = "ReportID"
        Me.tdbcReportID.PropBag = resources.GetString("tdbcReportID.PropBag")
        '
        'lblReportTypeID
        '
        Me.lblReportTypeID.AutoSize = True
        Me.lblReportTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportTypeID.Location = New System.Drawing.Point(7, 44)
        Me.lblReportTypeID.Name = "lblReportTypeID"
        Me.lblReportTypeID.Size = New System.Drawing.Size(73, 16)
        Me.lblReportTypeID.TabIndex = 2
        Me.lblReportTypeID.Text = "Mẫu chuẩn"
        Me.lblReportTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReportTypeName
        '
        Me.txtReportTypeName.Enabled = False
        Me.txtReportTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtReportTypeName.Location = New System.Drawing.Point(214, 39)
        Me.txtReportTypeName.MaxLength = 250
        Me.txtReportTypeName.Name = "txtReportTypeName"
        Me.txtReportTypeName.ReadOnly = True
        Me.txtReportTypeName.Size = New System.Drawing.Size(318, 21)
        Me.txtReportTypeName.TabIndex = 4
        Me.txtReportTypeName.TabStop = False
        '
        'lblReportID
        '
        Me.lblReportID.AutoSize = True
        Me.lblReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportID.Location = New System.Drawing.Point(7, 71)
        Me.lblReportID.Name = "lblReportID"
        Me.lblReportID.Size = New System.Drawing.Size(52, 16)
        Me.lblReportID.TabIndex = 5
        Me.lblReportID.Text = "Đặc thù"
        Me.lblReportID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTitle.Location = New System.Drawing.Point(214, 68)
        Me.txtTitle.MaxLength = 250
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(318, 21)
        Me.txtTitle.TabIndex = 7
        Me.txtTitle.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLine1)
        Me.GroupBox2.Controls.Add(Me.lblLine)
        Me.GroupBox2.Controls.Add(Me.tdbcToPeriodID)
        Me.GroupBox2.Controls.Add(Me.tdbcFromPeriodID)
        Me.GroupBox2.Controls.Add(Me.tdbcToAssetID)
        Me.GroupBox2.Controls.Add(Me.tdbcFromAssetID)
        Me.GroupBox2.Controls.Add(Me.tdbcAccountID)
        Me.GroupBox2.Controls.Add(Me.tdbcDivisionID)
        Me.GroupBox2.Controls.Add(Me.lblDivisionID)
        Me.GroupBox2.Controls.Add(Me.txtDivisionName)
        Me.GroupBox2.Controls.Add(Me.lblAccountID)
        Me.GroupBox2.Controls.Add(Me.txtAccountName)
        Me.GroupBox2.Controls.Add(Me.lblFromAssetID)
        Me.GroupBox2.Controls.Add(Me.lblFromPeriodID)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(538, 141)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2. Điếu kiện lọc"
        '
        'lblLine1
        '
        Me.lblLine1.AutoSize = True
        Me.lblLine1.Location = New System.Drawing.Point(233, 111)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(23, 16)
        Me.lblLine1.TabIndex = 12
        Me.lblLine1.Text = "---"
        Me.lblLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(233, 82)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(23, 16)
        Me.lblLine.TabIndex = 8
        Me.lblLine.Text = "---"
        Me.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tdbcToPeriodID
        '
        Me.tdbcToPeriodID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcToPeriodID.AllowColMove = False
        Me.tdbcToPeriodID.AllowColSelect = True
        Me.tdbcToPeriodID.AllowSort = False
        Me.tdbcToPeriodID.AlternatingRows = True
        Me.tdbcToPeriodID.AutoCompletion = True
        Me.tdbcToPeriodID.AutoDropDown = True
        Me.tdbcToPeriodID.AutoSelect = True
        Me.tdbcToPeriodID.Caption = ""
        Me.tdbcToPeriodID.CaptionHeight = 17
        Me.tdbcToPeriodID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcToPeriodID.ColumnCaptionHeight = 17
        Me.tdbcToPeriodID.ColumnFooterHeight = 17
        Me.tdbcToPeriodID.ColumnHeaders = False
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
        Me.tdbcToPeriodID.Location = New System.Drawing.Point(267, 106)
        Me.tdbcToPeriodID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcToPeriodID.MaxDropDownItems = CType(8, Short)
        Me.tdbcToPeriodID.MaxLength = 20
        Me.tdbcToPeriodID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcToPeriodID.Name = "tdbcToPeriodID"
        Me.tdbcToPeriodID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcToPeriodID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcToPeriodID.Size = New System.Drawing.Size(128, 22)
        Me.tdbcToPeriodID.TabIndex = 13
        Me.tdbcToPeriodID.ValueMember = "Period"
        Me.tdbcToPeriodID.PropBag = resources.GetString("tdbcToPeriodID.PropBag")
        '
        'tdbcFromPeriodID
        '
        Me.tdbcFromPeriodID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcFromPeriodID.AllowColMove = False
        Me.tdbcFromPeriodID.AllowColSelect = True
        Me.tdbcFromPeriodID.AllowSort = False
        Me.tdbcFromPeriodID.AlternatingRows = True
        Me.tdbcFromPeriodID.AutoCompletion = True
        Me.tdbcFromPeriodID.AutoDropDown = True
        Me.tdbcFromPeriodID.AutoSelect = True
        Me.tdbcFromPeriodID.Caption = ""
        Me.tdbcFromPeriodID.CaptionHeight = 17
        Me.tdbcFromPeriodID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcFromPeriodID.ColumnCaptionHeight = 17
        Me.tdbcFromPeriodID.ColumnFooterHeight = 17
        Me.tdbcFromPeriodID.ColumnHeaders = False
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
        Me.tdbcFromPeriodID.Location = New System.Drawing.Point(81, 106)
        Me.tdbcFromPeriodID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFromPeriodID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFromPeriodID.MaxLength = 20
        Me.tdbcFromPeriodID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFromPeriodID.Name = "tdbcFromPeriodID"
        Me.tdbcFromPeriodID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFromPeriodID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFromPeriodID.Size = New System.Drawing.Size(128, 22)
        Me.tdbcFromPeriodID.TabIndex = 11
        Me.tdbcFromPeriodID.ValueMember = "Period"
        Me.tdbcFromPeriodID.PropBag = resources.GetString("tdbcFromPeriodID.PropBag")
        '
        'tdbcToAssetID
        '
        Me.tdbcToAssetID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcToAssetID.AllowColMove = False
        Me.tdbcToAssetID.AllowColSelect = True
        Me.tdbcToAssetID.AllowSort = False
        Me.tdbcToAssetID.AlternatingRows = True
        Me.tdbcToAssetID.AutoCompletion = True
        Me.tdbcToAssetID.AutoDropDown = True
        Me.tdbcToAssetID.Caption = ""
        Me.tdbcToAssetID.CaptionHeight = 17
        Me.tdbcToAssetID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcToAssetID.ColumnCaptionHeight = 17
        Me.tdbcToAssetID.ColumnFooterHeight = 17
        Me.tdbcToAssetID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcToAssetID.DisplayMember = "AssetID"
        Me.tdbcToAssetID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcToAssetID.DropDownWidth = 500
        Me.tdbcToAssetID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcToAssetID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToAssetID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcToAssetID.EmptyRows = True
        Me.tdbcToAssetID.ExtendRightColumn = True
        Me.tdbcToAssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToAssetID.Images.Add(CType(resources.GetObject("tdbcToAssetID.Images"), System.Drawing.Image))
        Me.tdbcToAssetID.ItemHeight = 15
        Me.tdbcToAssetID.Location = New System.Drawing.Point(267, 77)
        Me.tdbcToAssetID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcToAssetID.MaxDropDownItems = CType(8, Short)
        Me.tdbcToAssetID.MaxLength = 20
        Me.tdbcToAssetID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcToAssetID.Name = "tdbcToAssetID"
        Me.tdbcToAssetID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcToAssetID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcToAssetID.Size = New System.Drawing.Size(128, 22)
        Me.tdbcToAssetID.TabIndex = 9
        Me.tdbcToAssetID.ValueMember = "AssetID"
        Me.tdbcToAssetID.PropBag = resources.GetString("tdbcToAssetID.PropBag")
        '
        'tdbcFromAssetID
        '
        Me.tdbcFromAssetID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcFromAssetID.AllowColMove = False
        Me.tdbcFromAssetID.AllowColSelect = True
        Me.tdbcFromAssetID.AllowSort = False
        Me.tdbcFromAssetID.AlternatingRows = True
        Me.tdbcFromAssetID.AutoCompletion = True
        Me.tdbcFromAssetID.AutoDropDown = True
        Me.tdbcFromAssetID.Caption = ""
        Me.tdbcFromAssetID.CaptionHeight = 17
        Me.tdbcFromAssetID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcFromAssetID.ColumnCaptionHeight = 17
        Me.tdbcFromAssetID.ColumnFooterHeight = 17
        Me.tdbcFromAssetID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcFromAssetID.DisplayMember = "AssetID"
        Me.tdbcFromAssetID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcFromAssetID.DropDownWidth = 500
        Me.tdbcFromAssetID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcFromAssetID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromAssetID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcFromAssetID.EmptyRows = True
        Me.tdbcFromAssetID.ExtendRightColumn = True
        Me.tdbcFromAssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromAssetID.Images.Add(CType(resources.GetObject("tdbcFromAssetID.Images"), System.Drawing.Image))
        Me.tdbcFromAssetID.ItemHeight = 15
        Me.tdbcFromAssetID.Location = New System.Drawing.Point(81, 77)
        Me.tdbcFromAssetID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFromAssetID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFromAssetID.MaxLength = 20
        Me.tdbcFromAssetID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFromAssetID.Name = "tdbcFromAssetID"
        Me.tdbcFromAssetID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFromAssetID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFromAssetID.Size = New System.Drawing.Size(128, 22)
        Me.tdbcFromAssetID.TabIndex = 7
        Me.tdbcFromAssetID.ValueMember = "AssetID"
        Me.tdbcFromAssetID.PropBag = resources.GetString("tdbcFromAssetID.PropBag")
        '
        'tdbcAccountID
        '
        Me.tdbcAccountID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcAccountID.AllowColMove = False
        Me.tdbcAccountID.AllowColSelect = True
        Me.tdbcAccountID.AllowSort = False
        Me.tdbcAccountID.AlternatingRows = True
        Me.tdbcAccountID.AutoCompletion = True
        Me.tdbcAccountID.AutoDropDown = True
        Me.tdbcAccountID.Caption = ""
        Me.tdbcAccountID.CaptionHeight = 17
        Me.tdbcAccountID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcAccountID.ColumnCaptionHeight = 17
        Me.tdbcAccountID.ColumnFooterHeight = 17
        Me.tdbcAccountID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcAccountID.DisplayMember = "AccountID"
        Me.tdbcAccountID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcAccountID.DropDownWidth = 500
        Me.tdbcAccountID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcAccountID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAccountID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcAccountID.EmptyRows = True
        Me.tdbcAccountID.ExtendRightColumn = True
        Me.tdbcAccountID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAccountID.Images.Add(CType(resources.GetObject("tdbcAccountID.Images"), System.Drawing.Image))
        Me.tdbcAccountID.ItemHeight = 15
        Me.tdbcAccountID.Location = New System.Drawing.Point(81, 48)
        Me.tdbcAccountID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcAccountID.MaxDropDownItems = CType(8, Short)
        Me.tdbcAccountID.MaxLength = 20
        Me.tdbcAccountID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcAccountID.Name = "tdbcAccountID"
        Me.tdbcAccountID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcAccountID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcAccountID.Size = New System.Drawing.Size(128, 22)
        Me.tdbcAccountID.TabIndex = 4
        Me.tdbcAccountID.ValueMember = "AccountID"
        Me.tdbcAccountID.PropBag = resources.GetString("tdbcAccountID.PropBag")
        '
        'tdbcDivisionID
        '
        Me.tdbcDivisionID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcDivisionID.AllowColMove = False
        Me.tdbcDivisionID.AllowColSelect = True
        Me.tdbcDivisionID.AllowSort = False
        Me.tdbcDivisionID.AlternatingRows = True
        Me.tdbcDivisionID.AutoCompletion = True
        Me.tdbcDivisionID.AutoDropDown = True
        Me.tdbcDivisionID.Caption = ""
        Me.tdbcDivisionID.CaptionHeight = 17
        Me.tdbcDivisionID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcDivisionID.ColumnCaptionHeight = 17
        Me.tdbcDivisionID.ColumnFooterHeight = 17
        Me.tdbcDivisionID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcDivisionID.DisplayMember = "DivisionID"
        Me.tdbcDivisionID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcDivisionID.DropDownWidth = 500
        Me.tdbcDivisionID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcDivisionID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDivisionID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcDivisionID.EmptyRows = True
        Me.tdbcDivisionID.ExtendRightColumn = True
        Me.tdbcDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDivisionID.Images.Add(CType(resources.GetObject("tdbcDivisionID.Images"), System.Drawing.Image))
        Me.tdbcDivisionID.ItemHeight = 15
        Me.tdbcDivisionID.Location = New System.Drawing.Point(81, 19)
        Me.tdbcDivisionID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDivisionID.MaxDropDownItems = CType(8, Short)
        Me.tdbcDivisionID.MaxLength = 20
        Me.tdbcDivisionID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDivisionID.Name = "tdbcDivisionID"
        Me.tdbcDivisionID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDivisionID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDivisionID.Size = New System.Drawing.Size(128, 22)
        Me.tdbcDivisionID.TabIndex = 1
        Me.tdbcDivisionID.ValueMember = "DivisionID"
        Me.tdbcDivisionID.PropBag = resources.GetString("tdbcDivisionID.PropBag")
        '
        'lblDivisionID
        '
        Me.lblDivisionID.AutoSize = True
        Me.lblDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisionID.Location = New System.Drawing.Point(7, 24)
        Me.lblDivisionID.Name = "lblDivisionID"
        Me.lblDivisionID.Size = New System.Drawing.Size(45, 16)
        Me.lblDivisionID.TabIndex = 0
        Me.lblDivisionID.Text = "Đơn vị"
        Me.lblDivisionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDivisionName
        '
        Me.txtDivisionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDivisionName.Location = New System.Drawing.Point(214, 19)
        Me.txtDivisionName.MaxLength = 250
        Me.txtDivisionName.Name = "txtDivisionName"
        Me.txtDivisionName.ReadOnly = True
        Me.txtDivisionName.Size = New System.Drawing.Size(318, 21)
        Me.txtDivisionName.TabIndex = 2
        Me.txtDivisionName.TabStop = False
        '
        'lblAccountID
        '
        Me.lblAccountID.AutoSize = True
        Me.lblAccountID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountID.Location = New System.Drawing.Point(7, 53)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(68, 16)
        Me.lblAccountID.TabIndex = 3
        Me.lblAccountID.Text = "Tài khoản"
        Me.lblAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAccountName
        '
        Me.txtAccountName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtAccountName.Location = New System.Drawing.Point(214, 48)
        Me.txtAccountName.MaxLength = 250
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.ReadOnly = True
        Me.txtAccountName.Size = New System.Drawing.Size(318, 21)
        Me.txtAccountName.TabIndex = 5
        Me.txtAccountName.TabStop = False
        '
        'lblFromAssetID
        '
        Me.lblFromAssetID.AutoSize = True
        Me.lblFromAssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromAssetID.Location = New System.Drawing.Point(7, 82)
        Me.lblFromAssetID.Name = "lblFromAssetID"
        Me.lblFromAssetID.Size = New System.Drawing.Size(53, 16)
        Me.lblFromAssetID.TabIndex = 6
        Me.lblFromAssetID.Text = "Tài sản"
        Me.lblFromAssetID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFromPeriodID
        '
        Me.lblFromPeriodID.AutoSize = True
        Me.lblFromPeriodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromPeriodID.Location = New System.Drawing.Point(7, 111)
        Me.lblFromPeriodID.Name = "lblFromPeriodID"
        Me.lblFromPeriodID.Size = New System.Drawing.Size(23, 16)
        Me.lblFromPeriodID.TabIndex = 10
        Me.lblFromPeriodID.Text = "Kỳ"
        Me.lblFromPeriodID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(395, 253)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(74, 22)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "&In"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(473, 253)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(74, 22)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'D02F3200
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 283)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F3200"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In så chi tiÕt TSC˜ phÀt sinh - D02F3200"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tdbcReportTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tdbcToPeriodID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFromPeriodID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcToAssetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFromAssetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcAccountID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents tdbcReportID As C1.Win.C1List.C1Combo
    Private WithEvents lblReportTypeID As System.Windows.Forms.Label
    Private WithEvents txtReportTypeName As System.Windows.Forms.TextBox
    Private WithEvents lblReportID As System.Windows.Forms.Label
    Private WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents tdbcDivisionID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcFromPeriodID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcToAssetID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcFromAssetID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcAccountID As C1.Win.C1List.C1Combo
    Private WithEvents lblDivisionID As System.Windows.Forms.Label
    Private WithEvents txtDivisionName As System.Windows.Forms.TextBox
    Private WithEvents lblAccountID As System.Windows.Forms.Label
    Private WithEvents txtAccountName As System.Windows.Forms.TextBox
    Private WithEvents lblFromAssetID As System.Windows.Forms.Label
    Private WithEvents lblFromPeriodID As System.Windows.Forms.Label
    Private WithEvents tdbcToPeriodID As C1.Win.C1List.C1Combo
    Private WithEvents lblLine1 As System.Windows.Forms.Label
    Private WithEvents lblLine As System.Windows.Forms.Label
    Private WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents optDetail As System.Windows.Forms.RadioButton
    Private WithEvents optSum As System.Windows.Forms.RadioButton
    Private WithEvents tdbcReportTypeID As C1.Win.C1List.C1Combo
End Class