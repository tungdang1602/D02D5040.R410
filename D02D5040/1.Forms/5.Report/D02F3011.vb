Public Class D02F3011
	Dim report As D99C2003

    Dim stam As String
    Dim dt4 As DataTable
    Dim dt As DataTable

    Private Sub D02F3011_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
            Exit Sub
        End If
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.NumPad1, Keys.D1
                    tdbcDivisionID.Focus()
                Case Keys.NumPad2, Keys.D2
                    txtReportTypeID.Focus()
                Case Keys.NumPad3, Keys.D3
                    tdbcGroupTypeID.Focus()
            End Select
        End If
    End Sub

    Private Sub D02F3011_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
	LoadInfoGeneral()
        SetBackColorObligatory()
        InputbyUnicode(Me, gbUnicode)
        Loadlanguage()
        LoadTDBCGroupTypeID()
        LoadTDBCombo()
        tdbcReportID.AutoCompletion = False
        tdbcACodeID.AutoCompletion = False
        tdbcGroupTypeID.AutoCompletion = False
        tdbcFromAssetID.AutoCompletion = False
        tdbcToAssetID.AutoCompletion = False
        LoadTDBCPeriodID()
        LoadDefault()
    SetResolutionForm(Me)
Me.Cursor = Cursors.Default
End Sub

    Private Sub LoadDefault()
        txtReportTypeID.Text = "D02R3011"
        If (gbUnicode) Then
            txtReportTypeName.Text = rl3("A4_P_Phieu_nhap_tai_san_co_dinhU")
        Else
            txtReportTypeName.Text = rl3("A4_P_Phieu_nhap_tai_san_co_dinh")
        End If
        tdbcGroupTypeID.SelectedIndex = 0
        tdbcFromPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
        tdbcToPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
    End Sub

    Private Sub SetBackColorObligatory()
        tdbcGroupTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcACodeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Phieu_nhap_TSCD_-_D02F3011") & UnicodeCaption(gbUnicode) 'PhiÕu nhËp TSC˜ - D02F3011
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
        chkPeriodID.Text = rl3("Ky") 'Kỳ
        '================================================================ 
        grpDivisionID.Text = "1. " & rl3("Don_vi")
        GroupBox1.Text = "2. " & rl3("Dang_bao_cao") '1. Dạng báo cáo
        GroupBox2.Text = "3." & rl3("Dieu_kien_loc") '2. Điều kiện lọc
        '================================================================ 
        tdbcReportID.Columns("ReportID").Caption = rl3("Ma") 'Mã
        tdbcReportID.Columns("Title").Caption = rl3("Ten") 'Tên
        tdbcDivisionID.Columns(0).Caption = rl3("Ma") 'Mã
        tdbcDivisionID.Columns(1).Caption = rl3("Ten") 'Tên
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

    Dim dtPeriod As DataTable

    Private Sub LoadTDBCombo()
        'Load(tdbcReportID)
        'Load tdbcFromPeriodID
        dtPeriod = LoadTablePeriodReport(D02)
        'LoadCboPeriodReport(tdbcFromPeriodID, tdbcToPeriodID, D02)
        LoadCboDivisionIDAll(tdbcDivisionID, D02, , gbUnicode)
        tdbcDivisionID.SelectedValue = gsDivisionID

        Dim sSQl1 As String = ""
        sSQl1 = "Select A.ReportID, " & IIf(gsLanguage = "84", "A.Title", "A.Title01").ToString & UnicodeJoin(gbUnicode) & " as Title, B.ModuleID, B.ReportTypeID," & IIf(gsLanguage = "84", "B.ReportTypeName", "B.ReportTypeName01").ToString & UnicodeJoin(gbUnicode) & " as ReportTypeName" & vbCrLf
        sSQl1 &= "From D89T1000 A  WITH (NOLOCK) Inner Join D89T0010 B WITH (NOLOCK)  On  A.ReportTypeID = B.ReportTypeID " & vbCrLf
        sSQl1 &= "Where A.ModuleID = '02' And A.ReportTypeID = 'D02F3011'" & vbCrLf
        sSQl1 &= "And (DAGroupID= '' Or DAGroupID In (Select DAGroupID From Lemonsys.Dbo.D00V0080 " & vbCrLf
        sSQl1 &= "Where UserID = " & SQLString(gsUserID) & " Or UserID = 'LEMONADMIN')) " & vbCrLf
        sSQl1 &= "Order By	A.ReportTypeID"
        LoadDataSource(tdbcReportID, sSQl1, gbUnicode)

        'Load tdbcACodeID
        Dim sSQl4 As String = ""
        sSQl4 = "Select 	0 as DisplayOrder,'%' as ACodeID,  " & AllName & " as Description," & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQl4 &= "'<Taát caû>' as Description, " & vbCrLf
        'Else
        '    sSQl4 &= "'<All>' as Description, " & vbCrLf
        'End If
        sSQl4 &= "	'%' as TypeCodeID" & vbCrLf
        sSQl4 &= "Union All" & vbCrLf
        sSQl4 &= "Select 1 as DisplayOrder,ACodeID, Description" & UnicodeJoin(gbUnicode) & " as Description, TypeCodeID As GroupTypeID " & vbCrLf
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
            LoadDataSource(tdbcACodeID, ReturnTableFilter(dt4, "TypeCodeID = '%' OR TypeCodeID = " & SQLString(tdbcGroupTypeID.Text), True), gbUnicode)
        End If
        tdbcACodeID.AutoSelect = True
    End Sub

    Private Sub LoadTDBCAssetID()
        'Load tdbcFromAssetID

        Dim sSQl3 As String = ""
        Dim dt3 As DataTable
        sSQl3 = "Select 0 as DisplayOrder,'%' As AssetID," & AllName & "  As AssetName " & vbCrLf
        sSQl3 &= "Union All  " & vbCrLf
        sSQl3 &= "Select 1 as DisplayOrder,AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName" & vbCrLf
        sSQl3 &= "From D02T0001  WITH (NOLOCK) " & vbCrLf
        sSQl3 &= "Where Disabled = 0  " & vbCrLf
        sSQl3 &= "And IsCompleted = 1 " & vbCrLf
        'Cap nhat ngay 26/9/2012 theo incident 51525 của BAOCHI boi VANVINH thay " & SQLString(giTranMonth) & " = TranYear
        sSQl3 &= "And TranMonth + TranYear *100 <= " & SQLString(giTranMonth) & " + " & SQLString(giTranYear) & "*100 " & vbCrLf
        If tdbcDivisionID.Text <> "%" Then
            sSQl3 &= "And DivisionID = " & SQLString(tdbcDivisionID.Text) & vbCrLf
        End If
        If tdbcACodeID.Text <> "%" And tdbcACodeID.Text <> "" Then
            If tdbcGroupTypeID.Text = "A01" Or tdbcGroupTypeID.Text = "A02" Or tdbcGroupTypeID.Text = "A03" Or tdbcGroupTypeID.Text = "A04" Or tdbcGroupTypeID.Text = "A05" Or tdbcGroupTypeID.Text = "A06" Or tdbcGroupTypeID.Text = "A07" Or tdbcGroupTypeID.Text = "A08" Or tdbcGroupTypeID.Text = "A09" Or tdbcGroupTypeID.Text = "A10" Then
                Dim s As String
                s = tdbcGroupTypeID.Text
                stam = s.Substring(1, 2)
                sSQl3 &= "And ACode" & stam & "ID like" & SQLString(tdbcACodeID.Text) & vbCrLf
            Else
                sSQl3 &= "And " & SQLString(tdbcGroupTypeID.Text) & "like " & SQLString(tdbcACodeID.Text) & vbCrLf
            End If
        End If
        sSQl3 &= "Order By DisplayOrder,AssetID"

        dt3 = ReturnDataTable(sSQl3)
        LoadDataSource(tdbcFromAssetID, dt3, gbUnicode)
        'Load tdbcToAssetID
        LoadDataSource(tdbcToAssetID, dt3.DefaultView.ToTable, gbUnicode)
    End Sub

    Private Sub LoadTDBCPeriodID()
        LoadCboPeriodReport(tdbcFromPeriodID, tdbcToPeriodID, D02)
    End Sub

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

    Private Sub tdbcReportID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcReportID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
            tdbcReportID.Text = ""
            txtTitle.Text = ""
        End If
    End Sub

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
        'LoadTDBCAssetID()
        Dim sSQl As String = ""

        sSQl &= "Select 0 as DisplayOrder,'%' As AssetID,  " & AllName & " as AssetName" & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQl &= "'<Taát caû>' As AssetName" & vbCrLf
        'Else
        '    sSQl &= "'<All>' As AssetName" & vbCrLf
        'End If
        sSQl &= "Union All  " & vbCrLf
        sSQl &= "Select 1 as DisplayOrder,AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName" & vbCrLf
        sSQl &= "From D02T0001  WITH (NOLOCK) " & vbCrLf
        sSQl &= "Where Disabled = 0  " & vbCrLf
        sSQl &= "And IsCompleted = 1 " & vbCrLf
        sSQl &= "And TranMonth + TranYear*100 <= " & SQLString(giTranMonth) & " + " & SQLString(giTranYear) & "*100 " & vbCrLf
        If tdbcDivisionID.Text <> "%" Then
            sSQl &= "And DivisionID = " & SQLString(tdbcDivisionID.Text) & vbCrLf 'Them ngay 26/9/2012 theo incident 51525 cua BAOCHI bởi VĂNVINH
        End If

        If tdbcACodeID.Text <> "%" Then
            If tdbcGroupTypeID.Text = "A01" Or tdbcGroupTypeID.Text = "A02" Or tdbcGroupTypeID.Text = "A03" Or tdbcGroupTypeID.Text = "A04" Or tdbcGroupTypeID.Text = "A05" Or tdbcGroupTypeID.Text = "A06" Or tdbcGroupTypeID.Text = "A07" Or tdbcGroupTypeID.Text = "A08" Or tdbcGroupTypeID.Text = "A09" Or tdbcGroupTypeID.Text = "A10" Then
                Dim s As String
                s = tdbcGroupTypeID.Text
                stam = s.Substring(1, 2)
                sSQl &= "And ACode" & stam & "ID like" & SQLString(tdbcACodeID.Text) & vbCrLf
            Else
                sSQl &= "And " & SQLString(tdbcGroupTypeID.Text) & "like " & SQLString(tdbcACodeID.Text) & vbCrLf
            End If
        End If
        sSQl &= "Order By DisplayOrder,AssetID"
        Dim dt5 As DataTable = ReturnDataTable(sSQl)
        LoadDataSource(tdbcFromAssetID, dt5, gbUnicode)
        LoadDataSource(tdbcToAssetID, dt5.DefaultView.ToTable, gbUnicode)
    End Sub

    Private Sub tdbcACodeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcACodeID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
            tdbcACodeID.Text = ""
            txtDescription.Text = ""
        End If
    End Sub

#End Region

#Region "Events tdbcFromAssetID"

    'Private Sub tdbcFromAssetID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.Close
    '    If tdbcFromAssetID.FindStringExact(tdbcFromAssetID.Text) = -1 Then tdbcFromAssetID.Text = ""
    'End Sub

    Private Sub tdbcFromAssetID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFromAssetID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFromAssetID.Text = ""
    End Sub

#End Region

#Region "Events tdbcToAssetID"

    Private Sub tdbcToAssetID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcToAssetID.Close
        If tdbcToAssetID.FindStringExact(tdbcToAssetID.Text) = -1 Then tdbcToAssetID.Text = ""
    End Sub

    Private Sub tdbcToAssetID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcToAssetID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcToAssetID.Text = ""
    End Sub

#End Region

#Region "Events tdbcFromPeriodID"

    Private Sub tdbcFromPeriodID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFromPeriodID.Close
        If tdbcFromPeriodID.FindStringExact(tdbcFromPeriodID.Text) = -1 Then tdbcFromPeriodID.Text = ""
    End Sub

    Private Sub tdbcFromPeriodID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFromPeriodID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFromPeriodID.Text = ""
    End Sub

#End Region

#Region "Events tdbcToPeriodID"

    Private Sub tdbcToPeriodID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcToPeriodID.Close
        If tdbcToPeriodID.FindStringExact(tdbcToPeriodID.Text) = -1 Then tdbcToPeriodID.Text = ""
    End Sub

    Private Sub tdbcToPeriodID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcToPeriodID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcToPeriodID.Text = ""
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
        '  sSQL = "Select No,FormID,Mode,Language,FieldName,Description" & UnicodeJoin(gbUnicode) & " as Description,DataType,Length,ModuleID From D02V1234 "
        sSQL = "Select * From D02V1234 "
        sSQL &= "Where FormID = " & SQLString(Me.Name) & "And Language = " & SQLString(gsLanguage)
        ShowFindDialog(Finder, sSQL, Me, gbUnicode)
        'If sFind <> "" Then
        '    sFind = sFind
        '    If giAppMode = 0 Then
        '        PrintData()
        '    Else
        '        PrintDataWS()
        '    End If
        'End If
        'btnPrint_Click(Nothing, Nothing)
        'sFind = ""
    End Sub

    'Private Sub Finder_FindClick(ByVal ResultWhereClause As Object) Handles Finder.FindClick
    '    If ResultWhereClause Is Nothing Then Exit Sub
    '    sFind = ResultWhereClause.ToString()

    'End Sub

#End Region

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Not AllowPrint() Then Exit Sub
        PrintData()
        'If giAppMode = 0 Then
        '    PrintData()
        'Else
        '    PrintDataWS()
        'End If
       
    End Sub

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
        Dim sReportName As String = "D02R3011"
        sReportCaption = rl3("Phieu_nhap_TSCDF")
        If tdbcReportID.Text <> "" Then
            sReportName = tdbcReportID.Text
        End If
        sReportCaption = sReportCaption & " - " & sReportName
        sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, tdbcReportID.Text) & sReportName & ".rpt"
        ' If tdbcReportID.Text = "" Then
        '    sReportName = "D02R3011"
        '    sReportCaption = sReportCaption & " - " & sReportName

        '    If D02Options.ReportLanguage = 0 Then
        '        sPathReport = Application.StartupPath & "\XReports\" & sReportName & ".rpt"
        '    ElseIf D02Options.ReportLanguage = 1 Then
        '        sPathReport = Application.StartupPath & "\XReports\VE-XReports\" & sReportName & ".rpt"
        '    ElseIf D02Options.ReportLanguage = 2 Then
        '        sPathReport = Application.StartupPath & "\XReports\E-XReports\" & sReportName & ".rpt"
        '    End If
        ' Else
        ' sReportName = tdbcReportID.Text
        ' sReportCaption = sReportCaption & " - " & sReportName
        '' sPathReport = Application.StartupPath & "\Xcustom\" & sReportName & ".rpt"
        ' End If
        sSQL = SQLStoreD02P3015.ToString
        'sSQL = "SELECT * FROM D02V1111 WHERE DivisionID = " & SQLString(gsDivisionID) & vbCrLf
        'sSQL &= "And (TranMonth + TranYear * 100) <= " & giTranMonth & "+" & giTranYear & " * 100" & vbCrLf
        'If tdbcFromAssetID.Text <> "%" Then
        '    sSQL &= "AND AssetID >= '" & tdbcFromAssetID.Text & "' AND AssetID <= '" & tdbcToAssetID.Text & "'"
        'End If
        'If chkPeriodID.Checked = True Then
        '    sSQL &= "And (SetupMonth + SetupYear * 100) > = " & CInt(tdbcFromPeriodID.Columns("TranMonth").Text) & "+" & CInt(tdbcFromPeriodID.Columns("TranYear").Text) & " * 100" & vbCrLf
        '    sSQL &= "And (SetupMonth + SetupYear * 100) < = " & CInt(tdbcToPeriodID.Columns("TranMonth").Text) & "+" & CInt(tdbcToPeriodID.Columns("TranYear").Text) & " * 100" & vbCrLf
        'End If
        'If sFind <> "" Then sSQL &= " and " & sFind
        'sSQL &= "	ORDER BY SupplierName ASC"
        If (gbUnicode) Then
            'Sua ngay 28/9/2012 theo Bảo Chi bởi Văn Vinh
            'UnicodeSubReport(sSubReportName, sSQLSub, IIf(gsDivisionID = "", "%", gsDivisionID).ToString, gbUnicode)
            UnicodeSubReport(sSubReportName, sSQLSub, tdbcDivisionID.Text, gbUnicode)
        Else
            'sSQLSub = "Select Top 1 * from D91T0025"
            'Sua ngay 28/9/2012 theo Bảo Chi bởi Văn Vinh
            sSQLSub = "SELECT * FROM D91V0016 WHERE DivisionID = " & SQLString(tdbcDivisionID.Text)
        End If
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

    '    Dim sSubReportName As String = "D02R0000"
    '    Dim sReportCaption As String = ""
    '    Dim sPathReport As String = ""
    '    Dim sReportName As String
    '    Dim sSQL As String = ""
    '    Dim sSQLSub As String = ""
    '    sSQL = SQLStoreD02P3015.ToString

    '    ' sSQLSub = "Select Top 1 * from D91T0025"
    '    If (bPrintUnicode) Then
    '        'UnicodeSubReport(sSubReportName, sSQLSub, IIf(gsDivisionID = "", "%", gsDivisionID).ToString, gbUnicode)
    '        UnicodeSubReport(sSubReportName, sSQLSub, tdbcDivisionID.Text, bPrintUnicode)
    '    Else
    '        ' sSQLSub = "Select Top 1 * from D91T0025"
    '        'Sua ngay 28/9/2012 theo Bảo Chi bởi Văn Vinh
    '        sSQLSub = "SELECT * FROM D91V0016 WHERE DivisionID = " & SQLString(tdbcDivisionID.Text)
    '    End If
    '    If tdbcReportID.Text = "" Then
    '        sReportName = "D02R3011"
    '    Else
    '        sReportName = tdbcReportID.Text
    '    End If
    '    sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, tdbcReportID.Text) & sReportName & ".rpt"
    '    sReportCaption = rl3("Phieu_nhap_TSCDF") & " - " & sReportName & UnicodeCaption(gbUnicode)
    '    With reportWS
    '        .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '        .AddSub(sSQLSub, sSubReportName & ".rpt")
    '        .AddMain(sSQL)
    '        .PrintReport(sReportName & ".rpt", sReportCaption)
    '    End With
    '    Me.Cursor = Cursors.Default
    '    btnPrint.Enabled = True
    'End Sub

    Private Function AllowPrint() As Boolean

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

        If chkPeriodID.Checked = True Then
            If tdbcFromPeriodID.Text.Trim = "" Then
                D99C0008.MsgNotYetChoose(rl3("Ky"))
                tdbcFromPeriodID.Focus()
                Return False
            End If
            If tdbcToPeriodID.Text.Trim = "" Then
                D99C0008.MsgNotYetChoose(rl3("Ky"))
                tdbcToPeriodID.Focus()
                Return False
            End If

            'If tdbcFromPeriodID.Columns("TranYear").Text > tdbcToPeriodID.Columns("TranYear").Text Then
            '     D99C0008.MsgL3(rl3("Ban_phai_chon_tu_ky_nho_hon_den_ky"))
            '     tdbcFromPeriodID.Focus()
            '     Return False
            ' ElseIf tdbcFromPeriodID.Columns("TranYear").Text = tdbcToPeriodID.Columns("TranYear").Text Then
            '     If tdbcFromPeriodID.Columns("TranMonth").Text > tdbcToPeriodID.Columns("TranMonth").Text Then
            '         D99C0008.MsgL3(rl3("Ban_phai_chon_tu_ky_nho_hon_den_ky"))
            '         tdbcFromPeriodID.Focus()
            '         Return False
            '     End If
            ' End If
            CheckValidPeriodFromTo(tdbcFromPeriodID, tdbcToPeriodID)
        End If

        Return True
    End Function

    Private Sub tdbcFromAssetID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.LostFocus
        If tdbcFromAssetID.FindStringExact(tdbcFromAssetID.Text) = -1 Then tdbcFromAssetID.Text = ""
        SetValueTo(tdbcFromAssetID, tdbcToAssetID)
    End Sub

    Private Sub tdbcFromAssetID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.SelectedValueChanged
        If tdbcFromAssetID.Text = "%" Then
            tdbcToAssetID.Enabled = False

        Else
            tdbcToAssetID.Enabled = True
            tdbcToAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY

        End If
    End Sub

    Private Sub chkPeriodID_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPeriodID.Click
        If chkPeriodID.Checked = True Then
            tdbcToPeriodID.Enabled = True
            tdbcFromPeriodID.Enabled = True
            tdbcToPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
            tdbcFromPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        Else
            tdbcToPeriodID.Enabled = False
            tdbcFromPeriodID.Enabled = False
        End If
    End Sub

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P3015
    '# Created User: Mỹ Vân
    '# Created Date: 29/02/2008 03:15:25
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P3015() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P3015 "
        sSQL &= SQLString(tdbcDivisionID.Text) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcGroupTypeID.Text) & COMMA 'GroupTypeID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcACodeID.Text) & COMMA 'ACodeID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcFromAssetID.Text) & COMMA 'FromAssetID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcToAssetID.Text) & COMMA 'ToAssetID, varchar[20], NOT NULL
        If chkPeriodID.Checked = True Then
            sSQL &= SQLNumber("1") & COMMA 'Mode, tinyint, NOT NULL
        Else
            sSQL &= SQLNumber("0") & COMMA 'Mode, tinyint, NOT NULL

        End If

        sSQL &= SQLNumber(tdbcFromPeriodID.Columns("TranMonth").Text) & COMMA 'FromTranMonth, smallint, NOT NULL
        sSQL &= SQLNumber(tdbcFromPeriodID.Columns("TranYear").Text) & COMMA 'FromTranYear, smallint, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns("TranMonth").Text) & COMMA 'ToTranMonth, int, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns("TranYear").Text) & COMMA 'ToTranYear, int, NOT NULL
        sSQL &= SQLString(sFind) & COMMA 'sFind, varchar[8000],  NULL
        sSQL &= SQLNumber(gbUnicode) '@CodeTable, Number,  NULL
        Return sSQL
    End Function

    Private Sub tdbcGroupTypeID_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.Validated, tdbcACodeID.Validated, tdbcFromAssetID.Validated, tdbcToAssetID.Validated
        Dim tdbc As C1.Win.C1List.C1Combo = CType(sender, C1.Win.C1List.C1Combo)
        tdbc.Text = tdbc.WillChangeToText
    End Sub

#Region "Events tdbcDivisionID with txtDivisionName load tdbcFromPeriodID"

    Private Sub tdbcDivisionID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.SelectedValueChanged
        If tdbcDivisionID.SelectedValue Is Nothing OrElse tdbcDivisionID.Text = "" Then
            txtDivisionName.Text = ""
        Else
            txtDivisionName.Text = tdbcDivisionID.Columns(1).Value.ToString
            LoadCboPeriodReport(tdbcFromPeriodID, tdbcToPeriodID, dtPeriod, tdbcDivisionID.SelectedValue.ToString())
            LoadTDBCAssetID()
        End If
        tdbcFromPeriodID.SelectedIndex = 0
        tdbcToPeriodID.SelectedIndex = 0
        tdbcFromAssetID.SelectedIndex = 0
        tdbcToAssetID.SelectedIndex = 0
    End Sub

    Private Sub tdbcDivisionID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.LostFocus
        If tdbcDivisionID.FindStringExact(tdbcDivisionID.Text) = -1 OrElse tdbcDivisionID.SelectedValue Is Nothing Then
            tdbcDivisionID.Text = ""
            'LoadtdbcFromPeriodID("-1")
            tdbcFromPeriodID.Text = ""
            tdbcToPeriodID.Text = ""
            Exit Sub
        End If
    End Sub

#End Region

End Class