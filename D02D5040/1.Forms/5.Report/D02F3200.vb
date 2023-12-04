Public Class D02F3200
    Dim report As D99C2003

    Dim dt4 As DataTable
    Dim dtPeriod As DataTable
    Dim oFilterCombo As Lemon3.Controls.FilterCombo

    Private Sub D02F3200_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
            Exit Sub
        End If
    End Sub

    Private Sub D02F3200_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadInfoGeneral()
        Loadlanguage()

        '18/10/2018, id 114010-Bổ sung filter lọc truy vấn TSCĐ - In Sổ CT TSCĐ
        oFilterCombo = New Lemon3.Controls.FilterCombo
        oFilterCombo.CheckD91 = True
        oFilterCombo.UseFilterCombo(tdbcFromAssetID, tdbcToAssetID)

        SetBackColorObligatory()
        InputbyUnicode(Me, gbUnicode)
        LoadTDBCombo()
        LoadDefault()
        optSum_Click(Nothing, Nothing)
        SetResolutionForm(Me)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LoadDefault()
        tdbcDivisionID.Text = gsDivisionID
        tdbcAccountID.SelectedIndex = 0
        tdbcFromPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
        tdbcToPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
    End Sub

    Private Sub SetBackColorObligatory()
        tdbcDivisionID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcAccountID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("In_so_chi_tiet_TSCD_phat_sinh_-_D02F3200") & UnicodeCaption(gbUnicode) 'In så chi tiÕt TSC˜ phÀt sinh - D02F3200
        '================================================================ 
        lblReportTypeID.Text = rl3("Mau_chuan") 'Mẫu chuẩn
        lblReportID.Text = rl3("Dac_thu") 'Đặc thù
        lblDivisionID.Text = rL3("Don_vi") 'Đơn vị
        lblAccountID.Text = rl3("Tai_khoan") 'Tài khoản
        lblFromAssetID.Text = rl3("Tai_san") 'Tài sản
        lblFromPeriodID.Text = rl3("Ky") 'Kỳ
        '================================================================ 
        btnPrint.Text = rl3("_In") '&In
        btnClose.Text = rl3("Do_ng") 'Đó&ng

        optSum.Text = rl3("Tong_hop")
        optDetail.Text = rl3("Chi_tiet")
        '================================================================ 
        GroupBox1.Text = rl3("1_Dang_bao_cao") '1. Dạng báo cáo
        GroupBox2.Text = rl3("2_Dieu_kien_loc") '2. Điếu kiện lọc
        '================================================================ 
        tdbcReportID.Columns("ReportID").Caption = rl3("Ma") 'Mã
        tdbcReportID.Columns("Title").Caption = rl3("Ten") 'Tên
        tdbcToPeriodID.Columns("Period").Caption = rl3("Ky") 'Kỳ

        tdbcFromPeriodID.Columns("Period").Caption = rl3("Ky") 'Kỳ

        tdbcToAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcToAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên

        tdbcFromAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcFromAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcReportTypeID.Columns("ReportID").Caption = rl3("Ma") 'Mã
        tdbcReportTypeID.Columns("ReportName").Caption = rl3("Ten") 'Tên
        tdbcAccountID.Columns("AccountID").Caption = rl3("Ma") 'Mã
        tdbcAccountID.Columns("AccountName").Caption = rl3("Ten") 'Tên
        tdbcDivisionID.Columns("DivisionID").Caption = rl3("Ma") 'Mã
        tdbcDivisionID.Columns("DivisionName").Caption = rl3("Ten") 'Tên
    End Sub

#Region "Events tdbcReportTypeID with txtReportTypeName"

    Private Sub tdbcReportTypeID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportTypeID.SelectedValueChanged
        If tdbcReportTypeID.SelectedValue Is Nothing Then
            txtReportTypeName.Text = ""
        Else
            txtReportTypeName.Text = tdbcReportTypeID.Columns(1).Value.ToString
        End If
    End Sub

    Private Sub tdbcReportTypeID_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportTypeID.LostFocus
        If tdbcReportTypeID.FindStringExact(tdbcReportTypeID.Text) = -1 Then
            tdbcReportTypeID.Text = ""
        End If
    End Sub

#End Region



    Private Sub LoadComboReprotSum()
        Dim sSQl1 As String = ""
        sSQl1 = "SELECT 		ReportID,  Description" & IIf(geLanguage = EnumLanguage.English, "01", "").ToString & UnicodeJoin(gbUnicode) & " AS  ReportName,	StrSQL,  ReportType  "
        sSQl1 &= " FROM 		D02V5555  WHERE 		ReportType = 'D02F3200A' ORDER BY 	ReportType"
        LoadDataSource(tdbcReportTypeID, sSQl1, gbUnicode)
        tdbcReportTypeID.AutoSelect = True
        sSQl1 = "Select A.ReportID, A.Title" & IIf(geLanguage = EnumLanguage.English, "01", "").ToString & UnicodeJoin(gbUnicode) & " as Title, B.ModuleID, B.ReportTypeID, B.ReportTypeName" & UnicodeJoin(gbUnicode) & " as ReportTypeName " & vbCrLf
        sSQl1 &= "From D89T1000 A  WITH (NOLOCK) Inner Join D89T0010 B  WITH (NOLOCK) On  A.ReportTypeID = B.ReportTypeID " & vbCrLf
        sSQl1 &= "Where A.ModuleID = '02' And A.ReportTypeID = 'D02F3200A'" & vbCrLf
        sSQl1 &= "And (DAGroupID= '' Or DAGroupID In (Select DAGroupID From Lemonsys.Dbo.D00V0080 " & vbCrLf
        sSQl1 &= "Where UserID = " & SQLString(gsUserID) & " Or UserID = 'LEMONADMIN')) " & vbCrLf
        sSQl1 &= "Order By	A.ReportTypeID"
        LoadDataSource(tdbcReportID, sSQl1, gbUnicode)
        txtTitle.Text = ""
    End Sub

    Private Sub LoadComboReprotDetail()
        Dim sSQl1 As String = ""
        sSQl1 = "SELECT 		ReportID,  Description" & IIf(geLanguage = EnumLanguage.English, "01", "").ToString & UnicodeJoin(gbUnicode) & " AS  ReportName,	StrSQL,  ReportType  "
        sSQl1 &= " FROM 		D02V5555  WHERE 		ReportType = 'D02F3200B' ORDER BY 	ReportType"
        LoadDataSource(tdbcReportTypeID, sSQl1, gbUnicode)
        tdbcReportTypeID.AutoSelect = True
        sSQl1 = "Select A.ReportID, A.Title" & IIf(geLanguage = EnumLanguage.English, "01", "").ToString & UnicodeJoin(gbUnicode) & " AS Title, B.ModuleID, B.ReportTypeID, B.ReportTypeName" & UnicodeJoin(gbUnicode) & " as ReportTypeName " & vbCrLf
        sSQl1 &= "From D89T1000 A  WITH (NOLOCK) Inner Join D89T0010 B  WITH (NOLOCK) On  A.ReportTypeID = B.ReportTypeID " & vbCrLf
        sSQl1 &= "Where A.ModuleID = '02' And A.ReportTypeID = 'D02F3200B'" & vbCrLf
        sSQl1 &= "And (DAGroupID= '' Or DAGroupID In (Select DAGroupID From Lemonsys.Dbo.D00V0080 " & vbCrLf
        sSQl1 &= "Where UserID = " & SQLString(gsUserID) & " Or UserID = 'LEMONADMIN')) " & vbCrLf
        sSQl1 &= "Order By	A.ReportTypeID"
        LoadDataSource(tdbcReportID, sSQl1, gbUnicode)
        txtTitle.Text = ""
    End Sub



    Private Sub LoadTDBCombo()
        'Load(tdbcReportID)


        'Load DivisionID
        LoadCboDivisionIDReport(tdbcDivisionID, D02, , gbUnicode)

        'Load AccountID
        Dim sSQl3 As String = ""
        sSQl3 = "Select 0 as DisplayOrder,'%' As AccountID, " & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQl3 &= "'Taát caû'  As AccountName " & vbCrLf
        'Else
        '    sSQl3 &= "'All'  As AccountName " & vbCrLf
        'End If
        sSQl3 &= AllName & " as AccountName "
        sSQl3 &= "Union All " & vbCrLf
        sSQl3 &= "Select 1 as DisplayOrder,AccountID,  " & vbCrLf
        If gsLanguage = "84" Then
            sSQl3 &= "AccountName" & UnicodeJoin(gbUnicode) & " As AccountName   " & vbCrLf
        Else
            sSQl3 &= "AccountName01" & UnicodeJoin(gbUnicode) & " As AccountName " & vbCrLf
        End If
        sSQl3 &= "From D90T0001  WITH (NOLOCK) " & vbCrLf
        sSQl3 &= "Where GroupID = '7' And OffAccount= 0  " & vbCrLf
        sSQl3 &= "Order By DisplayOrder,AccountID  " & vbCrLf
        LoadDataSource(tdbcAccountID, sSQl3, gbUnicode)

        'Load AssetID
        ' loadComboAssetID()
        'Load PeriodID
        dtPeriod = LoadTablePeriodReport(D02)

    End Sub

    Private Sub loadComboAssetID()
        Dim sSQL4 As String = ""
        'Thay doi ngay 5/11/2012 theo incident 51409 của Thị Hiệp bởi Văn Vinh
        'sSQL4 = "Select 0 as DisplayOrder,'%' As AssetID,  " & AllName & " As AssetName, '%' As AssetAccountID  " & vbCrLf
        'sSQL4 &= "Union All " & vbCrLf
        'sSQL4 &= "Select 1 as DisplayOrder,AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName , AssetAccountID" & vbCrLf
        'sSQL4 &= "From D02T0001  " & vbCrLf
        'sSQL4 &= " WHERE 1=1 AND CASE WHEN " & SQLString(ReturnValueC1Combo(tdbcDivisionID)) & " = '%' THEN '%' ELSE DivisionID END = " & SQLString(ReturnValueC1Combo(tdbcDivisionID)) & " AND CASE WHEN " & SQLString(ReturnValueC1Combo(tdbcAccountID)) & " = '%' THEN '%' ELSE AssetAccountID END = " & SQLString(ReturnValueC1Combo(tdbcAccountID))
        'sSQL4 &= "Order By DisplayOrder,AssetID  " & vbCrLf
        sSQL4 = "SELECT 0 AS DisplayOrder, '%' AS AssetID,  " & AllName & " AS AssetName, '%' As AssetAccountID " & vbCrLf
        sSQL4 &= "UNION ALL SELECT 1 AS DisplayOrder, AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName , AssetAccountID " & vbCrLf
        sSQL4 &= "FROM D02T0001  WITH (NOLOCK) WHERE DivisionID LIKE " & SQLString(ReturnValueC1Combo(tdbcDivisionID)) & " AND AssetAccountID LIKE " & SQLString(ReturnValueC1Combo(tdbcAccountID)) & vbCrLf
        sSQL4 &= "ORDER BY 	DisplayOrder,AssetID" & vbCrLf
        dt4 = ReturnDataTable(sSQL4)
        LoadDataSource(tdbcFromAssetID, dt4, gbUnicode)
        LoadDataSource(tdbcToAssetID, dt4.Copy, gbUnicode)
    End Sub

#Region "Events tdbcReportID with txtTitle"

    Private Sub tdbcReportID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID.Close
        'If tdbcReportID.FindStringExact(tdbcReportID.Text) = -1 Then
        '    tdbcReportID.Text = ""
        '    txtTitle.Text = ""
        'End If
        If tdbcReportID.SelectedValue Is Nothing OrElse tdbcReportID.Text = "" Then
            txtTitle.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub tdbcReportID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID.SelectedValueChanged
        If tdbcReportID.SelectedValue Is Nothing OrElse tdbcReportID.Text = "" Then
            txtTitle.Text = ""
            Exit Sub
        End If
        txtTitle.Text = tdbcReportID.Columns(1).Value.ToString
    End Sub

    Private Sub tdbcReportID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcReportID.KeyDown
        'If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
        '    tdbcReportID.Text = ""
        '    txtTitle.Text = ""
        'End If
    End Sub

#End Region

#Region "Events tdbcDivisionID with txtDivisionName"

    Private Sub tdbcDivisionID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.Close
        If tdbcDivisionID.FindStringExact(tdbcDivisionID.Text) = -1 Then
            tdbcDivisionID.Text = ""
            txtDivisionName.Text = ""
        End If
    End Sub

    Private Sub tdbcDivisionID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.SelectedValueChanged
        txtDivisionName.Text = tdbcDivisionID.Columns(1).Value.ToString
        LoadCboPeriodReport(tdbcFromPeriodID, tdbcToPeriodID, dtPeriod.Copy, tdbcDivisionID.Text)
        loadComboAssetID()
    End Sub

    'Private Sub tdbcDivisionID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcDivisionID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
    '        tdbcDivisionID.Text = ""
    '        txtDivisionName.Text = ""
    '    End If
    'End Sub

#End Region

#Region "Events tdbcAccountID with txtAccountName"

    Private Sub tdbcAccountID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcAccountID.Close
        If tdbcAccountID.FindStringExact(tdbcAccountID.Text) = -1 Then
            tdbcAccountID.Text = ""
            txtAccountName.Text = ""
        End If
    End Sub

    Private Sub tdbcAccountID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcAccountID.SelectedValueChanged
        txtAccountName.Text = tdbcAccountID.Columns(1).Value.ToString
        LoadDataSource(tdbcFromAssetID, ReturnTableFilter(dt4, "AssetAccountID Like " & SQLString(tdbcAccountID.Text)), gbUnicode)
        LoadDataSource(tdbcToAssetID, ReturnTableFilter(dt4, "AssetAccountID Like " & SQLString(tdbcAccountID.Text)), gbUnicode)
        loadComboAssetID()
        tdbcFromAssetID.AutoSelect = True
        tdbcToAssetID.AutoSelect = True

    End Sub


    Private Sub tdbcAccountID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcAccountID.KeyDown
        'If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
        '    tdbcAccountID.Text = ""
        '    txtAccountName.Text = ""
        'End If
    End Sub

#End Region

#Region "Events tdbcFromAssetID"

    Private Sub tdbcFromAssetID_Validated(sender As Object, e As EventArgs) Handles tdbcFromAssetID.Validated
        oFilterCombo.FilterCombo(tdbcFromAssetID, e) '18/10/2018, id 114010-Bổ sung filter lọc truy vấn TSCĐ - In Sổ CT TSCĐ
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
#End Region

#Region "Events tdbcToAssetID"

    Private Sub tdbcToAssetID_Validated(sender As Object, e As EventArgs) Handles tdbcToAssetID.Validated
        oFilterCombo.FilterCombo(tdbcToAssetID, e) '18/10/2018, id 114010-Bổ sung filter lọc truy vấn TSCĐ - In Sổ CT TSCĐ
        If tdbcToAssetID.FindStringExact(tdbcToAssetID.Text) = -1 Then tdbcToAssetID.Text = ""
    End Sub
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

    Private Function AllowPrint() As Boolean

        If tdbcDivisionID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Don_vi"))
            tdbcDivisionID.Focus()
            Return False
        End If
        If tdbcAccountID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Tai_khoan"))
            tdbcAccountID.Focus()
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

        Dim iFromTranYear As Integer
        Dim iToTranYear As Integer
        Dim iFromPeriod As Integer
        Dim iToPeriod As Integer

        If tdbcFromPeriodID.Columns("TranYear").Text <> "" Then iFromTranYear = Convert.ToInt32(tdbcFromPeriodID.Columns("TranYear").Text)
        If tdbcToPeriodID.Columns("TranYear").Text <> "" Then iToTranYear = Convert.ToInt32(tdbcToPeriodID.Columns("TranYear").Text)

        If tdbcFromPeriodID.Columns("TranMonth").Text <> "" Then iFromPeriod = Convert.ToInt32(tdbcFromPeriodID.Columns("TranMonth").Text)
        If tdbcToPeriodID.Columns("TranMonth").Text <> "" Then iToPeriod = Convert.ToInt32(tdbcToPeriodID.Columns("TranMonth").Text)

        If iFromTranYear > iToTranYear Then
            D99C0008.MsgL3(rl3("Ban_phai_chon_tu_ky_nho_hon_den_ky"))
            tdbcFromPeriodID.Focus()
            Return False
        ElseIf iFromTranYear = iToTranYear Then
            If iFromPeriod > iToPeriod Then
                D99C0008.MsgL3(rl3("Ban_phai_chon_tu_ky_nho_hon_den_ky"))
                tdbcFromPeriodID.Focus()
                Return False
            End If
        End If
        Return True
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
        Dim sReportName As String
        Dim sSubReportName As String = "D02R0000"
        Dim sReportCaption As String = ""
        Dim sPathReport As String = ""
        Dim sSQL As String = ""
        Dim sSQLSub As String = ""
        If tdbcReportID.Text <> "" Then
            sReportName = tdbcReportID.Text
        Else
            sReportName = tdbcReportTypeID.Text
        End If
        sSQLSub &= "SELECT  CompanyName, CompanyFax, CompanyPhone," & vbCrLf
        sSQLSub &= "        AddressLine1, AddressLine2, AddressLine3, AddressLine4, AddressLine5" & vbCrLf
        sSQLSub &= "FROM    D91V0016" & vbCrLf
        sSQLSub &= "WHERE   DivisionID = " & SQLString(tdbcDivisionID.Text) & vbCrLf
        sReportCaption = rl3("In_so_chi_tiet_TSCD_phat_sinh_") & " - " & sReportName
        'If D02Options.ReportLanguage = 0 Then
        '    sPathReport = Application.StartupPath & "\XReports\" & sReportName & ".rpt"
        'ElseIf D02Options.ReportLanguage = 1 Then
        '    sPathReport = Application.StartupPath & "\XReports\VE-XReports\" & sReportName & ".rpt"
        'ElseIf D02Options.ReportLanguage = 2 Then
        '    sPathReport = Application.StartupPath & "\XReports\E-XReports\" & sReportName & ".rpt"
        'End If
        sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, tdbcReportID.Text) & sReportName & ".rpt"
        UnicodeSubReport(sSubReportName, sSQLSub, tdbcDivisionID.Text, gbUnicode)
        If optSum.Checked Then
            sSQL = SQLStoreD02P3200()
        Else
            sSubReportName = "D91R0000"
            sSQLSub = "Select *" & vbCrLf
            sSQLSub &= " FROM D91V0016 " & vbCrLf
            sSQLSub &= " WHERE   DivisionID = " & SQLString(tdbcDivisionID.Text)
            sSQL = SQLStoreD02P3201()
        End If
        ' ExecuteSQL(sSQL) ' Rem ngay 23/8/2012 boi VANVINH theo HOANGNAM
        'sSQLSub = "Select Top 1* from D91T0025"
        With report
            .OpenConnection(conn)
            .AddSub(sSQLSub, sSubReportName & ".rpt")
            .AddMain(sSQL)
            .PrintReport(sPathReport, sReportCaption)
        End With
        'Else
        '    Dim sReportName As String = tdbcReportID.Text
        '    Dim sSubReportName As String = "D02R0000"
        '    Dim sReportCaption As String = ""
        '    Dim sPathReport As String = ""
        '    Dim sSQL As String = ""
        '    Dim sSQLSub As String = ""


        '    sReportCaption = rl3("In_so_chi_tiet_TSCD_phat_sinh_") & " - " & sReportName
        '    sPathReport = Application.StartupPath & "\Xcustom\" & sReportName & ".rpt"
        '    sSQL = SQLStoreD02P3200()
        '    ExecuteSQL(sSQL)
        '    'sSQLSub = "Select Top 1* from D91T0025"
        '    sSQLSub &= "SELECT  CompanyName, CompanyFax, CompanyPhone," & vbCrLf
        '    sSQLSub &= "        AddressLine1, AddressLine2, AddressLine3, AddressLine4, AddressLine5" & vbCrLf
        '    sSQLSub &= "FROM    D91V0016" & vbCrLf
        '    sSQLSub &= "WHERE   DivisionID = " & SQLString(tdbcDivisionID.Text) & vbCrLf
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

    '    If tdbcReportID.Text = "" Then

    '        Dim sReportName As String = "D02R3200"
    '        Dim sSubReportName As String = "D02R0000"
    '        Dim sReportCaption As String = ""
    '        Dim sPathReport As String = ""
    '        Dim sSQL As String = ""
    '        Dim sSQLSub As String = ""


    '        sReportCaption = rl3("In_so_chi_tiet_TSCD_phat_sinh_") & " - " & sReportName
    '        sSQLSub = "Select Top 1* from D91T0025 WITH (NOLOCK) "
    '        sSQL = SQLStoreD02P3200()
    '        UnicodeSubReport(sSubReportName, sSQLSub, tdbcDivisionID.Text, gbUnicode)
    '        ExecuteSQL(sSQL)

    '        With reportWS
    '            .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '            .AddSub(sSQLSub, sSubReportName & ".rpt")
    '            .AddMain(sSQL)
    '            .PrintReport(sReportName & ".rpt", sReportCaption)
    '        End With
    '    Else
    '        Dim sReportName As String = tdbcReportID.Text
    '        Dim sSubReportName As String = "D02R0000"
    '        Dim sReportCaption As String = ""
    '        Dim sPathReport As String = ""
    '        Dim sSQL As String = ""
    '        Dim sSQLSub As String = ""
    '        sReportCaption = rl3("In_so_chi_tiet_TSCD_phat_sinh_") & " - " & sReportName
    '        sSQL = SQLStoreD02P3200()
    '        ExecuteSQL(sSQL)
    '        sSQLSub = "Select Top 1* from D91T0025 WITH (NOLOCK) "
    '        With reportWS
    '            .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '            .AddSub(sSQLSub, sSubReportName & ".rpt")
    '            .AddMain(sSQL)
    '            .PrintReport(sReportName & ".rpt", sReportCaption)
    '        End With
    '    End If
    '    Me.Cursor = Cursors.Default
    '    btnPrint.Enabled = True
    'End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P3200
    '# Created User: Mỹ Vân
    '# Created Date: 28/01/2008 04:10:56
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P3200() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P3200 "
        sSQL &= SQLString(tdbcDivisionID.Text) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLNumber(tdbcFromPeriodID.Columns("TranMonth").Text) & COMMA 'FromMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcFromPeriodID.Columns("TranYear").Text) & COMMA 'FromYear, int, NOT NULL
        sSQL &= SQLString(tdbcAccountID.Text) & COMMA 'AssetType, varchar[20], NOT NULL
        sSQL &= SQLString(txtAccountName.Text) & COMMA 'AssetTypeName, varchar[250], NOT NULL
        sSQL &= SQLString(tdbcFromAssetID.Text) & COMMA 'FromAssetID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcToAssetID.Text) & COMMA 'ToAssetID, varchar[20], NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns("TranMonth").Text) & COMMA 'ToMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns("TranYear").Text) & COMMA 'ToYear, int, NOT NULL
        sSQL &= SQLString(gsLanguage) & COMMA ''Language, varchar[20], NOT NULL
        sSQL &= SQLNumber(gbUnicode) & COMMA 'Language, varchar[20], NOT NULL
        'Them ngay 13/11/2012 theo incident 51409 của Thị Hiệp bởi Văn Vinh
        sSQL &= SQLString(gsUserID)  ''UserID, varchar[50], NOT NULL
        Return sSQL
    End Function


    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P3201
    '# Created User: Lê Đình Thái
    '# Created Date: 27/02/2012 01:26:30
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P3201() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P3201 "
        sSQL &= SQLString(tdbcDivisionID.Text) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLString(gsLanguage) & COMMA 'Language, varchar[20], NOT NULL
        sSQL &= SQLNumber(tdbcFromPeriodID.Columns("TranMonth").Text) & COMMA 'FromMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcFromPeriodID.Columns("TranYear").Text) & COMMA 'FromYear, int, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns("TranMonth").Text) & COMMA 'ToMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns("TranYear").Text) & COMMA 'ToYear, int, NOT NULL
        sSQL &= SQLString(tdbcFromAssetID.Text) & COMMA 'FromAssetID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcToAssetID.Text) & COMMA 'ToAssetID, varchar[20], NOT NULL
        sSQL &= SQLNumber(gbUnicode) & COMMA 'CodeTable, tinyint, NOT NULL
        'Them ngay 13/11/2012 theo incident 51409 của Thị Hiệp bởi Văn Vinh
        sSQL &= SQLString(gsUserID)  ''UserID, varchar[50], NOT NULL
        Return sSQL
    End Function



    Private Sub optSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSum.Click
        LoadComboReprotSum()
    End Sub

    Private Sub optDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDetail.Click
        LoadComboReprotDetail()
    End Sub



End Class