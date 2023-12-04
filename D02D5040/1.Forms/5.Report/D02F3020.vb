Public Class D02F3020
	Dim report As D99C2003

    Dim stam As String
    Dim dtACodeID As DataTable

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub D02F3020_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
                Case Keys.NumPad4, Keys.D4
                    tdbcFromPeriodID.Focus()
            End Select
        End If
    End Sub

    Private Sub D02F3020_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	LoadInfoGeneral()
        txtReportTypeID.Text = "D02R3020"
        If gbUnicode Then
            txtReportTypeName.Text = ConvertVniToUnicode(rl3("A4_L_Danh_sach_tai_san_co_dinh"))
        Else
            txtReportTypeName.Text = rl3("A4_L_Danh_sach_tai_san_co_dinh")
        End If
        InputbyUnicode(Me, gbUnicode)
        Loadlanguage()
        SetBackColorObligatory()
        LoadTDBCombo()
        LoadDefaultValue()
        SetResolutionForm(Me)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LoadDefaultValue()
        tdbcGroupTypeID.SelectedValue = "%"
        tdbcACodeID.SelectedValue = "%"
        tdbcGroupType02ID.SelectedIndex = 0
        tdbcGroupType03ID.SelectedIndex = 0
        tdbcACode02ID.SelectedIndex = 0
        tdbcACode03ID.SelectedIndex = 0

        tdbcFromPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
        tdbcToPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
        tdbcFromAssetID.SelectedValue = "%"
        tdbcToAssetID.SelectedValue = "%"
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Bao_cao_danh_sach_TSCD_phat_sinh_-_D02F3020") & UnicodeCaption(gbUnicode) 'BÀo cÀo danh sÀch TSC˜ phÀt sinh - D02F3020
        '================================================================ 
        lblReportTypeID.Text = rl3("Mau_chuan") 'Mẫu chuẩn
        lblReportID.Text = rl3("Dac_thu") 'Đặc thù
        lblGroupTypeID.Text = rL3("Tieu_thuc") & " 1" 'Tiêu thức
        lblGroupType02ID.Text = rl3("Tieu_thuc") & " 2" 'Phân loại
        lblGroupType03ID.Text = rl3("Tieu_thuc") & " 3" 'Phân loại
        lblFromPeriodID.Text = rl3("Ky") 'Kỳ
        lblFromAssetID.Text = rl3("Tai_san") 'Tài sản
        lblDivisionID.Text = rl3("Don_vi")
        lblGrpDivisionID.Text = "1. " & rl3("Don_vi")
        lblReport.Text = "2. " & rl3("Dang_bao_cao") 'Dạng báo cáo
        lblFilter.Text = "3. " & rl3("Dieu_kien_loc") 'Điều kiện lọc
        lblTime.Text = "4. " & rl3("Thoi_gian")
        '================================================================ 
        chkIsDepreciation.Text = rl3("Hien_thi_cac_tai_san_con_khau_hao") 'Hiển thị các tài sản còn khấu hao
        chkIsStopDepreciation.Text = rl3("Hien_thi_cac_tai_san_ngung_khau_hao") 'Hiển thị các tài sản ngưng khấu hao
        chkIsNotLiquidated.Text = rl3("Hien_thi_cac_tai_san_chua_thanh_ly") 'Hiển thị các tài sản chưa thanh lý
        chkIsLiquidated.Text = rL3("Hien_thi_cac_tai_san_da_thanh_ly") 'Hiển thị các tài sản đã thanh lý
        chkIsPrintAsset.Text = rL3("In_tai_san_co_dinh") 'In tài sản cố định
        chkIsPrintTool.Text = rL3("In_cong_cu_dung_cu") 'In công cụ dụng cụ

        '================================================================ 
        btnPrint.Text = rl3("_In") '&In
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        btnFilter.Text = rl3("_Loc") '&Lọc
        '================================================================ 
        tdbcReportID.Columns("ReportID").Caption = rl3("Ma") 'Mã
        tdbcReportID.Columns("Title").Caption = rl3("Ten") 'Tên
        tdbcToAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcToAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcFromAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcFromAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên

        tdbcACodeID.Columns("ACodeID").Caption = rl3("Ma") 'Mã
        tdbcACodeID.Columns("Description").Caption = rl3("Ten") 'Tên\
        tdbcACode02ID.Columns("ACodeID").Caption = rl3("Ma") 'Mã
        tdbcACode02ID.Columns("Description").Caption = rl3("Ten") 'Tên
        tdbcACode03ID.Columns("ACodeID").Caption = rl3("Ma") 'Mã
        tdbcACode03ID.Columns("Description").Caption = rl3("Ten") 'Tên

        tdbcDivisionID.Columns(0).Caption = rl3("Ma") 'Mã
        tdbcDivisionID.Columns(1).Caption = rl3("Ten") 'Tên

        tdbcGroupTypeID.Columns("GroupTypeID").Caption = rl3("Ma") 'Mã
        tdbcGroupTypeID.Columns("GroupCaption").Caption = rl3("Ten") 'Tên
        tdbcGroupType02ID.Columns("GroupTypeID").Caption = rl3("Ma") 'Mã
        tdbcGroupType02ID.Columns("GroupCaption").Caption = rl3("Ten") 'Tên
        tdbcGroupType03ID.Columns("GroupTypeID").Caption = rl3("Ma") 'Mã
        tdbcGroupType03ID.Columns("GroupCaption").Caption = rl3("Ten") 'Tên
    End Sub

    Private Sub SetBackColorObligatory()
        tdbcGroupTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcACodeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY

        tdbcGroupType02ID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcACode02ID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY

        tdbcGroupType03ID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcACode03ID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY

        tdbcFromAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub

    Dim dtPeriod As DataTable

    Private Sub LoadTDBCombo()
        Dim sSQL As String = ""
        'Load tdbcFromPeriodID
        dtPeriod = LoadTablePeriodReport(D02)
        'LoadCboPeriodReport(tdbcFromPeriodID, tdbcToPeriodID, D02)
        LoadCboDivisionIDAll(tdbcDivisionID, D02, , gbUnicode)
        tdbcDivisionID.SelectedValue = gsDivisionID
        'Load tdbcReportID
        sSQL = "Select A.ReportID, A.Title" & UnicodeJoin(gbUnicode) & " as  Title, B.ModuleID, B.ReportTypeID, B.ReportTypeName" & UnicodeJoin(gbUnicode) & " as ReportTypeName " & vbCrLf
        sSQL &= "From D89T1000 A  WITH (NOLOCK) Inner Join D89T0010 B  WITH (NOLOCK) On  A.ReportTypeID = B.ReportTypeID " & vbCrLf
        sSQL &= "Where A.ModuleID = '02' And A.ReportTypeID = 'D02F3020'" & vbCrLf
        sSQL &= "And (DAGroupID= '' Or DAGroupID In (Select DAGroupID From Lemonsys.Dbo.D00V0080 " & vbCrLf
        sSQL &= "Where UserID = " & SQLString(gsUserID) & " Or UserID = 'LEMONADMIN')) " & vbCrLf
        sSQL &= "Order By	A.ReportTypeID" & vbCrLf
        LoadDataSource(tdbcReportID, sSQL, gbUnicode)

        'Load ACodeID
        Dim sSQl1 As String = ""
        sSQl1 = "	Select 	0 as DisplayOrder," & AllCode & " As ACodeID,  " & AllName & " as Description, '%' As TypeCodeID" & vbCrLf
        sSQl1 &= "Union All" & vbCrLf
        sSQl1 &= "Select 1 as DisplayOrder,ACodeID, Description" & UnicodeJoin(gbUnicode) & " as Description, TypeCodeID As GroupTypeID" & vbCrLf
        sSQl1 &= "From D02V4444  " & vbCrLf
        sSQl1 &= "Order By DisplayOrder,ACodeID"
        dtACodeID = ReturnDataTable(sSQl1)
        LoadDataSource(tdbcACodeID, dtACodeID, gbUnicode)
        LoadDataSource(tdbcACode02ID, dtACodeID.DefaultView.ToTable, gbUnicode)
        LoadDataSource(tdbcACode03ID, dtACodeID.DefaultView.ToTable, gbUnicode)
        'Load tdbcGroupTypeID
        sSQL = "Select GroupTypeID, " & IIf(geLanguage = EnumLanguage.English, "EngTypeCaption", "VieTypeCaption").ToString & UnicodeJoin(gbUnicode) & "  As GroupCaption,"
        sSQL &= "TableName, WhereClause, FieldName " & vbCrLf
        sSQL &= "From D02V3333 " & vbCrLf
        sSQL &= "Order By GroupTypeID "
        Dim dtGroupTypeID As DataTable = ReturnDataTable(sSQL)
        LoadDataSource(tdbcGroupTypeID, dtGroupTypeID, gbUnicode)
        LoadDataSource(tdbcGroupType02ID, dtGroupTypeID.DefaultView.ToTable, gbUnicode)
        LoadDataSource(tdbcGroupType03ID, dtGroupTypeID.DefaultView.ToTable, gbUnicode)
    End Sub


#Region "Events tdbcReportID with txtTitle"

    'Private Sub tdbcReportID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID.Close
    '    If tdbcReportID.FindStringExact(tdbcReportID.Text) = -1 Then
    '        tdbcReportID.Text = ""
    '        txtTitle.Text = ""
    '    End If
    'End Sub

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

    Private Sub tdbcGroupTypeID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.Close
        If tdbcGroupTypeID.FindStringExact(tdbcGroupTypeID.Text) = -1 Then tdbcGroupTypeID.Text = ""
    End Sub

    'Private Sub tdbcGroupTypeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcGroupTypeID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcGroupTypeID.Text = ""
    'End Sub

#End Region

    Private Sub LoadtdbcAssetID()
        Dim sSQL As String = ""
        sSQL &= "Select 0 as DisplayOrder," & AllCode & " As AssetID, " & AllName & " as AssetName " & vbCrLf
        sSQL &= "Union All  " & vbCrLf
        sSQL &= "Select 1 as DisplayOrder,AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName" & vbCrLf
        sSQL &= "From D02T0001  WITH (NOLOCK) " & vbCrLf
        sSQL &= "Where Disabled = 0  And IsCompleted = 1 And DivisionID LIKE " & SQLString(tdbcDivisionID.Text) & vbCrLf
        'sSQL &= " And TranMonth + TranYear*100 >= " & Number(tdbcFromPeriodID.Columns("TranMonth").Text) & "+" & Number(tdbcFromPeriodID.Columns("TranYear").Text) & "*100 " & vbCrLf
        'sSQL &= " And TranMonth + TranYear*100 <= " & Number(tdbcToPeriodID.Columns("TranMonth").Text) & "+" & Number(tdbcToPeriodID.Columns("TranYear").Text) & "*100  " & vbCrLf
        sSQL &= "Order By DisplayOrder,AssetID"
        Dim dt1 As DataTable = ReturnDataTable(sSQL)
        LoadDataSource(tdbcFromAssetID, dt1, gbUnicode)
        LoadDataSource(tdbcToAssetID, dt1.DefaultView.ToTable, gbUnicode)
        tdbcFromAssetID.SelectedIndex = 0
        tdbcToAssetID.SelectedIndex = 0
    End Sub

#Region "Events tdbcACodeID with txtDescription"

    Private Sub tdbcACodeID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcACodeID.Close
        If tdbcACodeID.FindStringExact(tdbcACodeID.Text) = -1 Then
            tdbcACodeID.Text = ""
            txtDescription.Text = ""
        End If
    End Sub

    Private Sub tdbcACodeID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcACodeID.SelectedValueChanged
        If tdbcACodeID.SelectedValue Is Nothing OrElse tdbcACodeID.Text = "" Then
            txtDescription.Text = ""
            Exit Sub
        End If
        txtDescription.Text = tdbcACodeID.Columns(1).Value.ToString
        'Dim sSQl As String = ""
        'Dim dt1 As DataTable
        'sSQl &= "Select 0 as DisplayOrder,'%' As AssetID,  " & vbCrLf
        ''If gsLanguage = "84" Then
        ''    sSQl &= "'<Taát caû>' As AssetName" & vbCrLf
        ''Else
        ''    sSQl &= "'<All>' As AssetName" & vbCrLf
        ''End If
        'sSQl &= AllCode & " as AssetName " & vbCrLf
        'sSQl &= "Union All  " & vbCrLf
        'sSQl &= "Select 1 as DisplayOrder,AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName" & vbCrLf
        'sSQl &= "From D02T0001 " & vbCrLf
        'sSQl &= "Where Disabled = 0  " & vbCrLf
        'sSQl &= "And IsCompleted = 1 " & vbCrLf
        'sSQl &= "And DivisionID = " & SQLString(tdbcDivisionID) & vbCrLf
        'If tdbcACodeID.Text <> "%" Then
        '    'If tdbcGroupTypeID.Text = "A01" Or tdbcGroupTypeID.Text = "A02" Or tdbcGroupTypeID.Text = "A03" Or tdbcGroupTypeID.Text = "A04" Or tdbcGroupTypeID.Text = "A05" Or tdbcGroupTypeID.Text = "A06" Or tdbcGroupTypeID.Text = "A07" Or tdbcGroupTypeID.Text = "A08" Or tdbcGroupTypeID.Text = "A09" Or tdbcGroupTypeID.Text = "A10" Then
        '    '    Dim s As String
        '    '    s = tdbcGroupTypeID.Text
        '    '    stam = s.Substring(1, 2)
        '    '    sSQl &= "And ACode" & stam & "ID like " & SQLString(tdbcACodeID.Text) & vbCrLf
        '    'Else
        '    '    If tdbcACodeID.Text = "" Then
        '    '        sSQl &= "And " & SQLString(tdbcGroupTypeID.Text) & "like '%' " & vbCrLf
        '    '    Else
        '    '        sSQl &= "And " & SQLString(tdbcGroupTypeID.Text) & "like " & SQLString(tdbcACodeID.Text) & vbCrLf
        '    '    End If
        '    'End If

        '    Dim sFieldName As String = tdbcGroupTypeID.Columns("FieldName").Text
        '    If sFieldName <> "" Then
        '        sSQl &= "And " & sFieldName & " like " & SQLString(tdbcACodeID.Text) & vbCrLf
        '    End If

        '    If tdbcGroupTypeID.Columns("FieldName").Text = "ObjectID" Then
        '        sSQl &= "And ObjectTypeID = " & SQLString(tdbcGroupTypeID.Text) & vbCrLf
        '    End If

        'End If
        'sSQl &= "And TranMonth + TranYear*100 >= " & Number(tdbcFromPeriodID.Columns("TranMonth").Text) & "+" & Number(tdbcFromPeriodID.Columns("TranYear").Text) & "*100 " & vbCrLf
        'sSQl &= "And TranMonth + TranYear*100 <= " & Number(tdbcToPeriodID.Columns("TranMonth").Text) & "+" & Number(tdbcToPeriodID.Columns("TranYear").Text) & "*100  " & vbCrLf
        'sSQl &= "Order By DisplayOrder,AssetID"
        'dt1 = ReturnDataTable(sSQl)
        'LoadDataSource(tdbcFromAssetID, dt1, gbUnicode)
        'LoadDataSource(tdbcToAssetID, dt1.Copy, gbUnicode)

    End Sub

    'Private Sub tdbcACodeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcACodeID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
    '        tdbcACodeID.Text = ""
    '        txtDescription.Text = ""
    '    End If
    'End Sub

#End Region

#Region "Events tdbcFromPeriodID"

    Private Sub tdbcFromPeriodID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFromPeriodID.Close
        If tdbcFromPeriodID.FindStringExact(tdbcFromPeriodID.Text) = -1 Then tdbcFromPeriodID.Text = ""
    End Sub

    'Private Sub tdbcFromPeriodID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFromPeriodID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFromPeriodID.Text = ""
    'End Sub

#End Region

#Region "Events tdbcToPeriodID"

    Private Sub tdbcToPeriodID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcToPeriodID.Close
        If tdbcToPeriodID.FindStringExact(tdbcToPeriodID.Text) = -1 Then tdbcToPeriodID.Text = ""
    End Sub

    'Private Sub tdbcToPeriodID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcToPeriodID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcToPeriodID.Text = ""
    'End Sub

#End Region

#Region "Events tdbcFromAssetID"
    Private Sub tdbcFromAssetID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.LostFocus
        If tdbcFromAssetID.FindStringExact(tdbcFromAssetID.Text) = -1 Then tdbcFromAssetID.Text = ""
        SetValueTo(tdbcFromAssetID, tdbcToAssetID)
    End Sub
    'Private Sub tdbcFromAssetID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.Close

    'End Sub

    'Private Sub tdbcFromAssetID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFromAssetID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFromAssetID.Text = ""
    'End Sub

#End Region

#Region "Events tdbcToAssetID"

    Private Sub tdbcToAssetID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcToAssetID.Close
        If tdbcToAssetID.FindStringExact(tdbcToAssetID.Text) = -1 Then tdbcToAssetID.Text = ""
    End Sub

    'Private Sub tdbcToAssetID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcToAssetID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcToAssetID.Text = ""
    'End Sub

#End Region


#Region "Events tdbcGroupTypeID"

    Private Sub tdbcGroupTypeID_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.LostFocus
        If tdbcGroupTypeID.FindStringExact(tdbcGroupTypeID.Text) = -1 Then tdbcGroupTypeID.Text = ""
    End Sub

#End Region

#Region "Events tdbcGroupType02ID load tdbcACode02ID with txtDescription02"

    Private Sub tdbcGroupType02ID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupType02ID.SelectedValueChanged
        If tdbcGroupType02ID Is Nothing OrElse tdbcGroupType02ID.Text = "" Then Exit Sub
        If tdbcGroupType02ID.Text = "%" Then
            LoadDataSource(tdbcACode02ID, dtACodeID, gbUnicode) '
        Else
            LoadDataSource(tdbcACode02ID, ReturnTableFilter(dtACodeID, "  TypeCodeID = " & SQLString(tdbcGroupType02ID.Text) & " Or TypeCodeID = '%'", True), gbUnicode) '
        End If
        tdbcACode02ID.SelectedIndex = 0
    End Sub

    Private Sub tdbcGroupType02ID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupType02ID.LostFocus
        If tdbcGroupType02ID.FindStringExact(tdbcGroupType02ID.Text) = -1 OrElse tdbcGroupType02ID.SelectedValue Is Nothing Then
            tdbcGroupType02ID.Text = ""
            tdbcACode02ID.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub tdbcACode02ID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcACode02ID.SelectedValueChanged
        If tdbcACode02ID.SelectedValue Is Nothing Then
            txtDescription02.Text = ""
        Else
            txtDescription02.Text = tdbcACode02ID.Columns(1).Value.ToString
        End If
    End Sub

    Private Sub tdbcACode02ID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcACode02ID.LostFocus
        If tdbcACode02ID.FindStringExact(tdbcACode02ID.Text) = -1 Then tdbcACode02ID.Text = ""
    End Sub

#End Region

#Region "Events tdbcGroupType03ID load tdbcACode03ID with txtDescription03"

    Private Sub tdbcGroupType03ID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupType03ID.SelectedValueChanged
        If tdbcGroupType03ID Is Nothing OrElse tdbcGroupType03ID.Text = "" Then Exit Sub
        If tdbcGroupType03ID.Text = "%" Then
            LoadDataSource(tdbcACode03ID, dtACodeID, gbUnicode) '
        Else
            LoadDataSource(tdbcACode03ID, ReturnTableFilter(dtACodeID, "  TypeCodeID = " & SQLString(tdbcGroupType03ID.Text) & " Or TypeCodeID = '%'", True), gbUnicode) '
        End If
        tdbcACode03ID.SelectedIndex = 0
    End Sub

    Private Sub tdbcGroupType03ID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupType03ID.LostFocus
        If tdbcGroupType03ID.FindStringExact(tdbcGroupType03ID.Text) = -1 OrElse tdbcGroupType03ID.SelectedValue Is Nothing Then
            tdbcGroupType03ID.Text = ""
            tdbcACode03ID.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub tdbcACode03ID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcACode03ID.SelectedValueChanged
        If tdbcACode03ID.SelectedValue Is Nothing Then
            txtDescription03.Text = ""
        Else
            txtDescription03.Text = tdbcACode03ID.Columns(1).Value.ToString
        End If
    End Sub

    Private Sub tdbcACode03ID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcACode03ID.LostFocus
        If tdbcACode03ID.FindStringExact(tdbcACode03ID.Text) = -1 Then tdbcACode03ID.Text = ""
    End Sub

#End Region



    Private Sub tdbcGroupTypeID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.SelectedValueChanged
        If tdbcGroupTypeID Is Nothing OrElse tdbcGroupTypeID.Text = "" Then Exit Sub
        If tdbcGroupTypeID.Text = "%" Then
            LoadDataSource(tdbcACodeID, dtACodeID, gbUnicode) '
        Else
            LoadDataSource(tdbcACodeID, ReturnTableFilter(dtACodeID, "  TypeCodeID = " & SQLString(tdbcGroupTypeID.Text) & " Or TypeCodeID = '%'", True), gbUnicode) '
        End If

        tdbcACodeID.SelectedIndex = 0
        'txtDescription.Text = ""
    End Sub

    Private Sub tdbcFromPeriodID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromPeriodID.SelectedValueChanged
        If tdbcFromPeriodID.SelectedValue Is Nothing OrElse tdbcFromPeriodID.Text = "" Then Exit Sub
    End Sub

    Private Sub tdbcToPeriodID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcToPeriodID.SelectedValueChanged
        If tdbcToPeriodID.SelectedValue Is Nothing OrElse tdbcToPeriodID.Text = "" Then Exit Sub
        'LoadtdbcAssetID()
    End Sub

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
        If tdbcGroupType02ID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Phan_loai"))
            tdbcGroupType02ID.Focus()
            Return False
        End If
        If tdbcACode02ID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Phan_loai"))
            tdbcACode02ID.Focus()
            Return False
        End If
        If tdbcGroupType03ID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Phan_loai"))
            tdbcGroupType03ID.Focus()
            Return False
        End If
        If tdbcACode03ID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Phan_loai"))
            tdbcACode03ID.Focus()
            Return False
        End If
        If tdbcFromAssetID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Tai_san"))
            tdbcFromAssetID.Focus()
            Return False
        End If
        If tdbcToAssetID.Enabled = True Then
            If tdbcToAssetID.Text.Trim = "" Then
                D99C0008.MsgNotYetChoose(rl3("Tai_san"))
                tdbcToAssetID.Focus()
                Return False
            End If
        End If
       
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
        If Not CheckValidPeriodFromTo(tdbcFromPeriodID, tdbcToPeriodID) Then Return False
        'If tdbcFromPeriodID.Text <> "" And tdbcToPeriodID.Text <> "" Then
        '    If CInt(tdbcFromPeriodID.Columns("TranYear").Text) > CInt(tdbcToPeriodID.Columns("TranYear").Text) Then
        '        D99C0008.MsgL3(rl3("Ban_phai_chon_tu_ky_nho_hon_den_ky"))
        '        tdbcFromPeriodID.Focus()
        '        Return False
        '    ElseIf CInt(tdbcFromPeriodID.Columns("TranYear").Text) = CInt(tdbcToPeriodID.Columns("TranYear").Text) Then
        '        If CInt(tdbcFromPeriodID.Columns("TranMonth").Text) > CInt(tdbcToPeriodID.Columns("TranMonth").Text) Then
        '            D99C0008.MsgL3(rl3("Ban_phai_chon_tu_ky_nho_hon_den_ky"))
        '            tdbcFromPeriodID.Focus()
        '            Return False
        '        End If
        '    End If

        'End If

        Return True
    End Function

 

    Private Sub tdbcFromAssetID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.SelectedValueChanged
        If tdbcFromAssetID.Text = "%" Then
            tdbcToAssetID.Enabled = False
        Else
            tdbcToAssetID.Enabled = True
        End If

    End Sub

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P3020
    '# Created User: Mỹ Vân
    '# Created Date: 13/02/2008 11:17:34
    '# Modified User: Nguyễn Thị Ánh
    '# Modified Date: 20/03/2012 10:41:00
    '# Description: In
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P3020(ByVal sReportName As String) As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P3020 "
        sSQL &= SQLString(gsUserID) & COMMA 'UserID, varchar[20], NOT NULL
        If tdbcGroupTypeID.Text = "" Then
            sSQL &= SQLString("%") & COMMA 'GroupTypeID, varchar[20], NOT NULL
        Else
            sSQL &= SQLString(tdbcGroupTypeID.Text) & COMMA 'GroupTypeID, varchar[20], NOT NULL
        End If
        If tdbcACodeID.Text = "" Then
            sSQL &= SQLString("%") & COMMA 'TypeCodeID, varchar[20], NOT NULL
        Else
            sSQL &= SQLString(tdbcACodeID.Text) & COMMA 'TypeCodeID, varchar[20], NOT NULL
        End If
        If tdbcFromAssetID.Text = "" Then
            sSQL &= SQLString("%") & COMMA 'FromAssetID, varchar[20], NOT NULL
        Else
            sSQL &= SQLString(tdbcFromAssetID.Text) & COMMA 'FromAssetID, varchar[20], NOT NULL
        End If
        If tdbcToAssetID.Text = "" Then
            sSQL &= SQLString("%") & COMMA 'ToAssetID, varchar[20], NOT NULL
        Else
            sSQL &= SQLString(tdbcToAssetID.Text) & COMMA 'ToAssetID, varchar[20], NOT NULL
        End If
        sSQL &= SQLMoney(tdbcFromPeriodID.Columns("TranMonth").Text) & COMMA 'FromMonth, money, NOT NULL
        sSQL &= SQLMoney(tdbcFromPeriodID.Columns("TranYear").Text) & COMMA 'FromYear, money, NOT NULL
        sSQL &= SQLMoney(tdbcToPeriodID.Columns("TranMonth").Text) & COMMA 'ToMonth, money, NOT NULL
        sSQL &= SQLMoney(tdbcToPeriodID.Columns("TranYear").Text) & COMMA 'ToYear, money, NOT NULL
        sSQL &= SQLString(tdbcDivisionID.Text) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLString("D02F3020") & COMMA 'ReportTypeID, varchar[20], NOT NULL
        sSQL &= SQLString(sReportName) & COMMA 'ReportID, varchar[20], NOT NULL
        ' Chua chuyen Unicode
        sSQL &= SQLNumber(gbUnicode) & COMMA 'CodeTable, tinyint, NOT NULL
        sSQL &= SQLNumber(chkIsDepreciation.Checked) & COMMA 'IsDepreciation, tinyint, NOT NULL
        sSQL &= SQLNumber(chkIsStopDepreciation.Checked) & COMMA 'IsStopDepreciation, tinyint, NOT NULL
        sSQL &= SQLNumber(chkIsNotLiquidated.Checked) & COMMA 'IsNotLiquidated, tinyint, NOT NULL
        sSQL &= SQLNumber(chkIsLiquidated.Checked) & COMMA 'IsLiquidated, tinyint, NOT NULL     
        sSQL &= SQLString(tdbcGroupType02ID.Text) & COMMA 'GroupType02ID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcGroupType03ID.Text) & COMMA 'GroupType03ID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcACode02ID.Text) & COMMA 'TypeCode02ID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcACode03ID.Text) & COMMA 'TypeCode03ID, varchar[20], NOT NULL
        '2014/09/15 Incident 68276 : Khanh - Bổ sung IsLiquidated, IsPrintAsset
        sSQL &= SQLString("") & COMMA 'strFindDivisionID, nvarchar[4000], NOT NULL
        sSQL &= SQLNumber(chkIsPrintAsset.Checked) & COMMA 'IsPrintAsset, tinyint, NOT NULL
        sSQL &= SQLNumber(chkIsPrintTool.Checked) 'IsPrintTool, tinyint, NOT NULL
        Return sSQL
    End Function





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
        Dim sReportName As String = ""
        Dim sSubReportName As String = "D02R0000"
        Dim sReportCaption As String = ""
        Dim sPathReport As String = ""
        Dim sSQL As String = ""
        Dim sSQLSub As String = ""

        sSQL = "Select * From D02V3020 Where UserID =   " & SQLString(gsUserID) & vbCrLf
        If sFind <> "" Then sSQL &= " and " & sFind & vbCrLf
        sSQL &= " Order By GroupID, AssetID" & vbCrLf
        sSQLSub = "SELECT * FROM D91V0016 WHERE DivisionID = " & SQLString(tdbcDivisionID.SelectedValue) ' "SELECT Top 1 * FROM D91T0025"

        If tdbcReportID.Text = "" Then
            sReportName = txtReportTypeID.Text
        Else
            sReportName = tdbcReportID.Text
        End If
        sReportCaption = rl3("Bao_cao_danh_sach_TSCD_phat_sinh") & " - " & sReportName

        'If D02Options.ReportLanguage = 0 Then
        '    sPathReport = Application.StartupPath & "\XReports\" & sReportName & ".rpt"
        'ElseIf D02Options.ReportLanguage = 1 Then
        '    sPathReport = Application.StartupPath & "\XReports\VE-XReports\" & sReportName & ".rpt"
        'ElseIf D02Options.ReportLanguage = 2 Then
        '    sPathReport = Application.StartupPath & "\XReports\E-XReports\" & sReportName & ".rpt"
        'End If
        sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, tdbcReportID.Text) & sReportName & ".rpt"
        UnicodeSubReport(sSubReportName, sSQLSub, tdbcDivisionID.Text, gbUnicode)
        ExecuteSQL(SQLStoreD02P3020(sReportName))
        With report
            .OpenConnection(conn)
            .AddSub(sSQLSub, sSubReportName & ".rpt")
            .AddMain(sSQL)
            .PrintReport(sPathReport, sReportCaption)
        End With
        'Else
        '    sReportName = tdbcReportID.Text
        '    sReportCaption = rl3("Bao_cao_danh_sach_TSCD_phat_sinh") & " - " & sReportName
        '    sPathReport = Application.StartupPath & "\Xcustom\" & sReportName & ".rpt"

        '    ExecuteSQL(SQLStoreD02P3020(sReportName))
        '    With report
        '        .OpenConnection(conn)
        '        .AddSub(sSQLSub, sSubReportName & ".rpt")
        '        .AddMain(sSQL)
        '        .PrintReport(sPathReport, sReportCaption)
        '    End With
        'End If
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
    End Sub

    'Private Sub PrintDataWS()
    '    btnPrint.Enabled = False
    '    Me.Cursor = Cursors.WaitCursor

    '    Dim reportWS As New D99C0009
    '    CallWebService.Url = gsAppServer & "D91W0000.asmx"
    '    CallWebService.Timeout = nWSTimeOut


    '    Dim sReportName As String = ""
    '    Dim sSubReportName As String = "D02R0000"
    '    Dim sReportCaption As String = ""
    '    Dim sPathReport As String = ""
    '    Dim sSQL As String = ""
    '    Dim sSQLSub As String = ""

    '    sSQL = "Select * From D02V3020 Where UserID =   " & SQLString(gsUserID) & vbCrLf
    '    If sFind <> "" Then sSQL &= " and " & sFind & vbCrLf
    '    sSQL &= " Order By GroupID, AssetID" & vbCrLf
    '    sSQLSub = "SELECT Top 1 * FROM D91T0025 WITH (NOLOCK) "

    '    If tdbcReportID.Text = "" Then
    '        sReportName = txtReportTypeID.Text
    '    Else
    '        sReportName = tdbcReportID.Text
    '    End If
    '    sReportCaption = rl3("Bao_cao_danh_sach_TSCD_phat_sinh") & " - " & sReportName
    '    ExecuteSQL(SQLStoreD02P3020(sReportName))
    '    With reportWS
    '        .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '        .AddSub(sSQLSub, sSubReportName & ".rpt")
    '        .AddMain(sSQL)
    '        .PrintReport(sReportName & ".rpt", sReportCaption)
    '    End With
    '    'sReportCaption = rl3("Bao_cao_danh_sach_TSCD_phat_sinh") & " - " & sReportName

    '    'ExecuteSQL(SQLStoreD02P3020(sReportName))
    '    'With reportWS
    '    '    .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '    '    .AddSub(sSQLSub, sSubReportName & ".rpt")
    '    '    .AddMain(sSQL)
    '    '    .PrintReport(sReportName & ".rpt", sReportCaption)
    '    'End With

    '    Me.Cursor = Cursors.Default
    '    btnPrint.Enabled = True
    'End Sub

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
        'If sFind <> "" Then
        '    sFind = sFind
        '    If giAppMode = 0 Then
        '        PrintData()
        '    Else
        '        PrintDataWS()
        '    End If
        'End If
        
    End Sub

    'Private Sub Finder_FindClick(ByVal ResultWhereClause As Object) Handles Finder.FindClick
    '    If ResultWhereClause Is Nothing Then Exit Sub
    '    sFind = ResultWhereClause.ToString()
    'End Sub

    
#End Region


#Region "Events tdbcDivisionID with txtDivisionName load tdbcFromPeriodID"

    Private Sub tdbcDivisionID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.SelectedValueChanged
        If tdbcDivisionID.SelectedValue Is Nothing OrElse tdbcDivisionID.Text = "" Then
            txtDivisionName.Text = ""
        Else
            txtDivisionName.Text = tdbcDivisionID.Columns(1).Value.ToString
            LoadCboPeriodReport(tdbcFromPeriodID, tdbcToPeriodID, dtPeriod, tdbcDivisionID.SelectedValue.ToString())
            LoadtdbcAssetID()
        End If
        tdbcFromPeriodID.SelectedIndex = 0
        tdbcToPeriodID.SelectedIndex = 0
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