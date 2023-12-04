
Public Class D02F3010
	Dim report As D99C2003

    Dim stam As String
    Dim dt As DataTable
    Dim dt4 As DataTable
    Dim oFilterCombo As Lemon3.Controls.FilterCombo

    Private Sub D02F3010_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
            Exit Sub
        End If
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.D1, Keys.NumPad1
                    tdbcReportTypeID.Focus()
                Case Keys.D2, Keys.NumPad2
                    tdbcGroupTypeID.Focus()
            End Select
        End If
    End Sub

    Private Sub D02F3010_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	LoadInfoGeneral()
        Loadlanguage()

        '18/10/2018, id 114008-Bổ sung filter lọc truy vấn TSCĐ - IN thẻ TSCĐ
        oFilterCombo = New Lemon3.Controls.FilterCombo
        oFilterCombo.CheckD91 = True
        oFilterCombo.UseFilterCombo(tdbcFromAssetID, tdbcToAssetID)

        SetBackColorObligatory()
        InputbyUnicode(Me, gbUnicode)
        LoadTDBCombo()
        LoadTDBCGroupTypeID()
        If tdbcReportID.Text = "" Then
            tdbcReportTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        Else
            tdbcReportTypeID.EditorBackColor = Color.White
        End If
        LoadDefault()
    SetResolutionForm(Me)
Me.Cursor = Cursors.Default
End Sub

    Private Sub LoadDefault()
        tdbcGroupTypeID.SelectedIndex = 0
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("In_the_TSCD_-_D02F3010") & UnicodeCaption(gbUnicode) 'In thÍ TSC˜ - D02F3010
        '================================================================ 
        lblReportTypeID.Text = rl3("Mau_chuan") 'Mẫu chuẩn
        lblReportID.Text = rl3("Dac_thu") 'Đặc thù
        lblGroupTypeID.Text = rL3("Phan_loai") 'Phân loại
        lblFromAssetID.Text = rl3("Tai_san") 'Tài sản
        '================================================================ 
        btnPrint.Text = rl3("_In") '&In
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        btnFilter.Text = rl3("_Loc") '&Lọc
        '================================================================ 
        chkOnlyCP.Text = rl3("In_but_doan_chi_phi") 'In bút đoán chi phí
        chkPrintAccessories.Text = rl3("In_thiet_bi_dinh_kem") 'In thiết bị đính kèm
        '================================================================ 
        grps.Text = "1. " & rl3("Dang_bao_cao")  '1. Dạng báo cáo
        GroupBox1.Text = "2. " & rl3("Dieu_kien_loc") '2. Điều kiện lọc
        '================================================================ 
        tdbcReportTypeID.Columns("ReportTypeID").Caption = rl3("Ma") 'Mã
        tdbcReportTypeID.Columns("ReportTypeName").Caption = rl3("Ten") 'Tên

        tdbcReportID.Columns("ReportID").Caption = rl3("Ma") 'Mã
        tdbcReportID.Columns("Title").Caption = rl3("Ten") 'Tên
        tdbcToAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcToAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcFromAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcFromAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcACodeID.Columns("ACodeID").Caption = rl3("Ma") 'Mã
        tdbcACodeID.Columns("Description").Caption = rl3("Ten") 'Tên
        tdbcGroupTypeID.Columns("GroupTypeID").Caption = rl3("Ma") 'Mã
        tdbcGroupTypeID.Columns("GroupCaption").Caption = rl3("Ten") 'Tên
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LoadTDBCombo()
        'Load tdbcReportTypeID
        Dim sSQL As String = ""

        sSQL = "Select ReportID As ReportTypeID,  " & vbCrLf
        If gsLanguage = "84" Then
            sSQL &= "Description" & UnicodeJoin(gbUnicode) & "   As 	ReportTypeName ," & vbCrLf
        Else
            sSQL &= "Description01" & UnicodeJoin(gbUnicode) & " As 	ReportTypeName , " & vbCrLf
        End If
        sSQL &= " StrSQL, ReportType " & vbCrLf
        sSQL &= "From D02V5555 " & vbCrLf
        sSQL &= "Where ReportType = 'D02F3010'" & vbCrLf
        sSQL &= "Order By ReportTypeID"
        LoadDataSource(tdbcReportTypeID, sSQL, gbUnicode)

        'Load(tdbcReportID)
        Dim sSQl1 As String = ""
        sSQl1 = "Select A.ReportID, A.Title, B.ModuleID, B.ReportTypeID, B.ReportTypeName" & UnicodeJoin(gbUnicode) & " as ReportTypeName " & vbCrLf
        sSQl1 &= "From D89T1000 A  WITH (NOLOCK) Inner Join D89T0010 B  WITH (NOLOCK) On  A.ReportTypeID = B.ReportTypeID " & vbCrLf
        sSQl1 &= "Where A.ModuleID = '02' And A.ReportTypeID = 'D02F3010'" & vbCrLf
        sSQl1 &= "And (DAGroupID= '' Or DAGroupID In (Select DAGroupID From Lemonsys.Dbo.D00V0080 " & vbCrLf
        sSQl1 &= "Where UserID = " & SQLString(gsUserID) & " Or UserID = 'LEMONADMIN')) " & vbCrLf
        sSQl1 &= "Order By	A.ReportTypeID"
        LoadDataSource(tdbcReportID, sSQl1, gbUnicode)



        'Load tdbcACodeID

        Dim sSQl4 As String = ""
        sSQl4 = "Select 	0 as DisplayOrder,'%' as ACodeID,  " & vbCrLf
        sSQl4 &= AllName & " as Description, " & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQl4 &= AllName & " as Description, " & vbCrLf
        'Else
        '    sSQl4 &= "'<All>' as Description, " & vbCrLf
        'End If
        sSQl4 &= "	'%' As GroupTypeID" & vbCrLf
        sSQl4 &= "Union All" & vbCrLf
        sSQl4 &= "Select 1 as DisplayOrder,ACodeID, Description" & UnicodeJoin(gbUnicode) & " as Description , TypeCodeID As  GroupTypeID" & vbCrLf
        sSQl4 &= "From D02V4444  " & vbCrLf
        sSQl4 &= "Order By DisplayOrder,ACodeID" & vbCrLf
        dt4 = ReturnDataTable(sSQl4)
        LoadDataSource(tdbcACodeID, dt4.Copy, gbUnicode)

    End Sub

    Private Sub LoadTDBCGroupTypeID()
        'Load tdbcGroupTypeID
        Dim sSQl2 As String = ""
        sSQl2 = "Select GroupTypeID,  " & vbCrLf
        If gsLanguage = "84" Then
            sSQl2 &= "VieTypeCaption" & UnicodeJoin(gbUnicode) & " As GroupCaption," & vbCrLf
        Else
            sSQl2 &= "EngTypeCaption" & UnicodeJoin(gbUnicode) & " As GroupCaption," & vbCrLf
        End If
        sSQl2 &= "TableName, WhereClause " & vbCrLf
        sSQl2 &= "From D02V3333 " & vbCrLf
        sSQl2 &= "Order By GroupTypeID "
        dt = ReturnDataTable(sSQl2)
        LoadDataSource(tdbcGroupTypeID, dt, gbUnicode)
    End Sub

    Private Sub LoadtdbcACodeID(ByVal ID As String)
        If ID = "%" Then
            LoadDataSource(tdbcACodeID, dt4.Copy, gbUnicode)
        Else
            LoadDataSource(tdbcACodeID, ReturnTableFilter(dt4, "GroupTypeID = '%' OR GroupTypeID = " & SQLString(tdbcGroupTypeID.Text), True), gbUnicode)
        End If
        tdbcACodeID.AutoSelect = True
    End Sub

    Private Sub LoadTDBCAssetID()
        'Load tdbcFromAssetID
        Dim sSQl3 As String = ""
        sSQl3 = "Select 0 as DisplayOrder,'%' As AssetID, " & AllName & " As AssetName " & vbCrLf
        sSQl3 &= "Union All  " & vbCrLf
        sSQl3 &= "Select 1 as DisplayOrder,AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName " & vbCrLf
        sSQl3 &= "From D02T0001  WITH (NOLOCK) " & vbCrLf
        sSQl3 &= "Where Disabled = 0  " & vbCrLf
        sSQl3 &= "And IsCompleted = 1 " & vbCrLf
        sSQl3 &= "And TranMonth + " & SQLString(giTranMonth) & "*100 <= " & SQLString(giTranMonth) & " + " & SQLString(giTranYear) & "*100 " & vbCrLf
        sSQl3 &= "And DivisionID = " & SQLString(gsDivisionID) & vbCrLf
        sSQl3 &= "Order By DisplayOrder,AssetID"
        LoadDataSource(tdbcFromAssetID, sSQl3, gbUnicode)
        'Load tdbcToAssetID
        LoadDataSource(tdbcToAssetID, sSQl3, gbUnicode)
    End Sub

#Region "Events tdbcReportTypeID with txtReportTypeName"

    Private Sub tdbcReportTypeID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportTypeID.Close
        If tdbcReportTypeID.FindStringExact(tdbcReportTypeID.Text) = -1 Then
            tdbcReportTypeID.Text = ""
            txtReportTypeName.Text = ""
        End If
    End Sub

    Private Sub tdbcReportTypeID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportTypeID.SelectedValueChanged
        txtReportTypeName.Text = tdbcReportTypeID.Columns(1).Value.ToString
    End Sub

    'Private Sub tdbcReportTypeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcReportTypeID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
    '        tdbcReportTypeID.Text = ""
    '        txtReportTypeName.Text = ""
    '    End If
    'End Sub

#End Region

#Region "Events tdbcReportID with txtTitle"

    Private Sub tdbcReportID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID.Close
        If tdbcReportID.FindStringExact(tdbcReportID.Text) = -1 Then
            tdbcReportID.Text = ""
            txtTitle.Text = ""
        End If
    End Sub

    Private Sub tdbcReportID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID.SelectedValueChanged
        txtTitle.Text = tdbcReportID.Columns(1).Value.ToString
       
    End Sub

    'Private Sub tdbcReportID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcReportID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
    '        tdbcReportID.Text = ""
    '        txtTitle.Text = ""
    '    End If
    'End Sub

#End Region

#Region "Events tdbcGroupTypeID"

    Private Sub tdbcGroupTypeID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.SelectedValueChanged
        LoadtdbcACodeID(tdbcGroupTypeID.Text)
    End Sub

    Private Sub tdbcGroupTypeID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.LostFocus
        If tdbcGroupTypeID.FindStringExact(tdbcGroupTypeID.Text) = -1 Then
            tdbcGroupTypeID.Text = ""
            LoadtdbcACodeID("-1")
            Exit Sub
        End If
    End Sub

    'Private Sub tdbcGroupTypeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcGroupTypeID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcGroupTypeID.Text = ""
    'End Sub

#End Region

#Region "Events tdbcACodeID with txtDescription"

    Private Sub tdbcACodeID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcACodeID.Close
        If tdbcACodeID.FindStringExact(tdbcACodeID.Text) = -1 Then
            tdbcACodeID.Text = ""
            txtDescription.Text = ""
        End If
    End Sub

    Private Sub tdbcACodeID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcACodeID.SelectedValueChanged
        txtDescription.Text = tdbcACodeID.Columns(1).Value.ToString
        Dim sSQl As String = ""
        Dim dt1 As DataTable
        sSQl &= "Select 0 as DisplayOrder,'%' As AssetID,  " & vbCrLf
        sSQl &= AllName & " As AssetName " & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQl &= "'<Taát caû>' As AssetName" & vbCrLf
        'Else
        '    sSQl &= "'<All>' As AssetName" & vbCrLf
        'End If
        sSQl &= "Union All  " & vbCrLf
        sSQl &= "Select 1 as DisplayOrder,AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName " & vbCrLf
        sSQl &= "From D02T0001  WITH (NOLOCK) " & vbCrLf
        sSQl &= "Where Disabled = 0  " & vbCrLf
        sSQl &= "And IsCompleted = 1 " & vbCrLf
        sSQl &= "And TranMonth + TranYear*100 <= " & SQLString(giTranMonth) & " + " & SQLString(giTranYear) & "*100 " & vbCrLf
        sSQl &= "And DivisionID = " & SQLString(gsDivisionID) & vbCrLf
        If tdbcACodeID.Text <> "%" Then
            If tdbcGroupTypeID.Text = "A01" Or tdbcGroupTypeID.Text = "A02" Or tdbcGroupTypeID.Text = "A03" Or tdbcGroupTypeID.Text = "A04" Or tdbcGroupTypeID.Text = "A05" Or tdbcGroupTypeID.Text = "A06" Or tdbcGroupTypeID.Text = "A07" Or tdbcGroupTypeID.Text = "A08" Or tdbcGroupTypeID.Text = "A09" Or tdbcGroupTypeID.Text = "A10" Then
                Dim s As String
                s = tdbcGroupTypeID.Text
                stam = s.Substring(1, 2)
                sSQl &= "And ACode" & stam & "ID = " & SQLString(tdbcACodeID.Text) & vbCrLf
            Else
                'sSQl &= "And GroupTypeID= " & SQLString(tdbcACodeID.Text) & vbCrLf
                sSQl &= "And " & SQLString(tdbcGroupTypeID.Text) & " = " & SQLString(tdbcACodeID.Text) & vbCrLf

            End If
        End If
        sSQl &= "Order By DisplayOrder, AssetID"
        dt1 = ReturnDataTable(sSQl)
        LoadDataSource(tdbcFromAssetID, dt1, gbUnicode)
        LoadDataSource(tdbcToAssetID, dt1.Copy, gbUnicode)

        'LoadTDBCAssetID()


    End Sub

    'Private Sub tdbcACodeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcACodeID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
    '        tdbcACodeID.Text = ""
    '        txtDescription.Text = ""
    '    End If
    'End Sub

#End Region

#Region "Events tdbcFromAssetID"
    Private Sub tdbcFromAssetID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.SelectedValueChanged
        If tdbcFromAssetID.Text = "%" Then
            tdbcToAssetID.Enabled = False
        Else
            tdbcToAssetID.Enabled = True
            tdbcToAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        End If
    End Sub

    Private Sub tdbcFromAssetID_Validated(sender As Object, e As EventArgs) Handles tdbcFromAssetID.Validated
        oFilterCombo.FilterCombo(tdbcFromAssetID, e) '18/10/2018, id 114008-Bổ sung filter lọc truy vấn TSCĐ - IN thẻ TSCĐ
        If tdbcFromAssetID.FindStringExact(tdbcFromAssetID.Text) = -1 Then tdbcFromAssetID.Text = ""
        If tdbcFromAssetID.Text = "%" Then
            tdbcToAssetID.Enabled = False
        Else
            SetValueTo(tdbcFromAssetID, tdbcToAssetID)
        End If
    End Sub

#End Region

#Region "Events tdbcToAssetID"

     Private Sub tdbcToAssetID_Validated(sender As Object, e As EventArgs) Handles tdbcToAssetID.Validated
        oFilterCombo.FilterCombo(tdbcToAssetID, e) '18/10/2018, id 114008-Bổ sung filter lọc truy vấn TSCĐ - IN thẻ TSCĐ
        If tdbcToAssetID.FindStringExact(tdbcToAssetID.Text) = -1 Then tdbcToAssetID.Text = ""
    End Sub

#End Region

#Region "Active Find - List All "
    Private WithEvents Finder As New D99C1001
	Dim gbEnabledUseFind As Boolean = False
    'Cần sửa Tìm kiếm như sau:
	'Bỏ sự kiện Finder_FindClick.
	'Sửa tham số Me.Name -> Me
	'Phải tạo biến properties có tên chính xác strNewFind và strNewServer
	'Sửa gdtCaptionExcel thành dtCaptionCols: biến toàn cục trong form
	'Nếu có F12 dùng D09U1111 thì Sửa dtCaptionCols thành ResetTableByGrid(usrOption, dtCaptionCols.DefaultView.ToTable)
    Private sFind As String = ""
	Public WriteOnly Property strNewFind() As String
		Set(ByVal Value As String)
			sFind = Value
            btnPrint_Click(Nothing, Nothing)
            sFind = ""
		End Set
	End Property

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        If Not AllowPrint() Then Exit Sub
        Dim sSQL As String = ""
        gbEnabledUseFind = True
        sSQL = "Select * From D02V1234 "
        sSQL &= "Where FormID = " & SQLString(Me.Name) & "And Language = " & SQLString(gsLanguage)
        ShowFindDialog(Finder, sSQL, Me, gbUnicode)
        'btnPrint_Click(Nothing, Nothing)
        'If sFind <> "" Then
        '    sFind = sFind
        '    If giAppMode = 0 Then
        '        PrintData()
        '    Else
        '        PrintDataWS()
        '    End If
        'End If
        'sFind = ""
    End Sub

    'Private Sub Finder_FindClick(ByVal ResultWhereClause As Object) Handles Finder.FindClick
    '    If ResultWhereClause Is Nothing Then Exit Sub
    '    sFind = ResultWhereClause.ToString() 
    'End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Not AllowPrint() Then Exit Sub
        PrintData()
        'If giAppMode = 0 Then
        '    PrintData()
        'Else
        '    PrintDataWS()
        'End If
    End Sub
#End Region

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P3010
    '# Created User: Mỹ Vân
    '# Created Date: 25/01/2008 04:05:42
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P3010() As String
        Dim sSQL As String = ""
        sSQL &= ("-- In the TSCD " & vbCrLf)
        sSQL &= "Exec D02P3010 "
        sSQL &= SQLString(gsUserID) & COMMA 'UserID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcGroupTypeID.Text) & COMMA 'GroupTypeID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcACodeID.Text) & COMMA 'TypeCodeID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcFromAssetID.Text) & COMMA 'FromAssetID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcToAssetID.Text) & COMMA 'ToAssetID, varchar[20], NOT NULL
        sSQL &= SQLNumber(giTranMonth) & COMMA 'TranMonth, money, NOT NULL
        sSQL &= SQLNumber(giTranYear) & COMMA 'TranYear, money, NOT NULL
        sSQL &= SQLString(gsDivisionID) & COMMA 'DivisionID, varchar[20], NOT NULL
        If chkOnlyCP.Checked = True Then
            sSQL &= SQLNumber(1) & COMMA  'OnlyCP, int, NOT NULL
        Else
            sSQL &= SQLNumber(0) & COMMA  'OnlyCP, int, NOT NULL
        End If
        sSQL &= SQLNumber(chkPrintAccessories.Checked) & COMMA   'PrintAccessories, int, NOT NULL
        sSQL &= SQLNumber(gbUnicode)   'PrintAccessories, int, NOT NULL
        Return sSQL
    End Function


    Private Function AllowPrint() As Boolean
        If tdbcReportID.Text = "" Then
            If tdbcReportTypeID.Text.Trim = "" Then
                D99C0008.MsgNotYetChoose(rl3("Mau_chuan"))
                tdbcReportTypeID.Focus()
                Return False
            End If
        End If

        If tdbcGroupTypeID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Phan_loai"))
            tdbcGroupTypeID.Focus()
            Return False
        End If
        If tdbcACodeID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Phan_loai"))
            tdbcACodeID.Focus()
            Return False
        End If
        If tdbcFromAssetID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Tai_san"))
            tdbcFromAssetID.Focus()
            Return False
        End If
        If tdbcFromAssetID.Text <> "%" Then
            If tdbcToAssetID.Text.Trim = "" Then
                D99C0008.MsgNotYetChoose(rl3("Tai_san"))
                tdbcToAssetID.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub PrintData()
        btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        'Dim report As New D99C1003
        'Đưa vể đầu tiên hàm In trước khi gọi AllowPrint()
		If Not AllowNewD99C2003(report, Me) Then Exit Sub
		'************************************
        Dim conn As New SqlConnection(gsConnectionString)
        Dim sSubReportName As String = "D02R0000"
        Dim sReportCaption As String = ""
        Dim sPathReport As String = ""
        Dim sSQL As String = ""
        Dim sSQLSub As String = ""
        Dim sReportName As String = ""
        Dim sSQLMain As String
        sSQLMain = SQLStoreD02P3010()
        ExecuteSQL(sSQLMain)
        sSQL = "Select * From D02V3010   Where UserID = " & SQLString(gsUserID) & vbCrLf
        If sFind <> "" Then sSQL &= " and " & sFind & vbCrLf
        sSQL &= " Order By AssetID ASC, Type" & vbCrLf
        sSQLSub = "SELECT Top 1 * FROM D91T0025 WITH (NOLOCK) "

        If tdbcReportID.Text = "" Then
            sReportName = tdbcReportTypeID.Text
            'If D02Options.ReportLanguage = 0 Then
            '    sPathReport = Application.StartupPath & "\XReports\" & sReportName & ".rpt"
            'ElseIf D02Options.ReportLanguage = 1 Then
            '    sPathReport = Application.StartupPath & "\XReports\VE-XReports\" & sReportName & ".rpt"
            'ElseIf D02Options.ReportLanguage = 2 Then
            '    sPathReport = Application.StartupPath & "\XReports\E-XReports\" & sReportName & ".rpt"
            'End If
            'With report
            '    .OpenConnection(conn)
            '    .AddSub(sSQLSub, sSubReportName & ".rpt")
            '    .AddMain(sSQL)
            '    .PrintReport(sPathReport, sReportCaption)
            'End With
        Else
            sReportName = tdbcReportID.Text
            '  sPathReport = Application.StartupPath & "\Xcustom\" & sReportName & ".rpt"
        End If
        sReportCaption = rl3("In_the_TSCD") & " - " & sReportName
        UnicodeSubReport(sSubReportName, sSQLSub, gsDivisionID, gbUnicode)
        sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, tdbcReportID.Text) & sReportName & ".rpt"
        With report
            .OpenConnection(conn)
            .AddSub(sSQLSub, sSubReportName & ".rpt")
            .AddMain(sSQL)
            .PrintReport(sPathReport, sReportCaption)
        End With
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
    End Sub

    'Private Sub PrintDataWS()
    '    btnPrint.Enabled = False
    '    Me.Cursor = Cursors.WaitCursor

    '    Dim reportWS As New D99C0009
    '    CallWebService.Url = gsAppServer & "D91W0000.asmx"
    '    CallWebService.Timeout = nWSTimeOut
    '    bPrintUnicode = gbUnicode And Not chkIsPrintVNI.Checked

    '    Dim sSubReportName As String = "D02R0000"
    '    Dim sReportCaption As String = ""
    '    Dim sPathReport As String = ""
    '    Dim sSQL As String = ""
    '    Dim sSQLSub As String = ""
    '    Dim sSQLMain As String
    '    Dim sReportName As String
    '    sSQLMain = SQLStoreD02P3010()
    '    ExecuteSQL(sSQLMain)
    '    sSQL = "Select * From D02V3010   Where UserID = " & SQLString(gsUserID) & vbCrLf
    '    If sFind <> "" Then sSQL &= " and " & sFind & vbCrLf
    '    sSQL &= " Order By AssetID ASC, Type" & vbCrLf
    '    sSQLSub = "SELECT Top 1 * FROM D91T0025 WITH (NOLOCK) "
    '    If tdbcReportID.Text = "" Then
    '        sReportName = tdbcReportTypeID.Text
    '        ' sReportCaption = rl3("In_the_TSCD") & " - " & sReportName
    '        'With reportWS
    '        '    .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '        '    .AddSub(sSQLSub, sSubReportName & ".rpt")
    '        '    .AddMain(sSQL)
    '        '    .PrintReport(sReportName & ".rpt", sReportCaption)
    '        'End With
    '    Else
    '        sReportName = tdbcReportID.Text
    '    End If
    '    sReportCaption = rL3("In_the_TSCD") & " - " & sReportName & UnicodeCaption(gbUnicode)
    '    UnicodeSubReport(sSubReportName, sSQLSub, gsDivisionID, bPrintUnicode)
    '    sPathReport = UnicodeGetReportPath(bPrintUnicode, D02Options.ReportLanguage, tdbcReportID.Text) & sReportName & ".rpt"
    '    With reportWS
    '        .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '        .AddSub(sSQLSub, sSubReportName & ".rpt")
    '        .AddMain(sSQL)
    '        .PrintReport(sReportName & ".rpt", sReportCaption)
    '    End With
    '    Me.Cursor = Cursors.Default
    '    btnPrint.Enabled = True
    'End Sub

   

    Private Sub SetBackColorObligatory()
        tdbcGroupTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcACodeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub
    
End Class