Imports System.IO
Imports System.Data
Imports System.Data.OleDb
#If SFTSTORE Then
Imports Excel = Microsoft.Office.Interop.Excel
Imports SFTSTORE.ftn
#ElseIf SFTSTOREWEB Then
Imports SFTSTOREWEB.ftn
#End If


Public Class data

#If Not ONLINE Then
   Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
ByVal lpKeyName As String, ByVal lpDefault As String, _
ByVal lpReturnedString As String, ByVal nSize As Int32, _
ByVal lpFileName As String) As Int32

   Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFileName As String) As Int32
#End If

   Public Const DEF_SERVER = ""
   Public Const SSQ_CASE = 2015000019
   Public Const DEF_DATABASE = ""
   Public Const DEF_USERID = ""
   Public Const DEF_PASSWORD = ""
   Public Const DEF_VERSION = "1" 'Dont forget to change the assembly info in project properties 
   Public Const DEF_COPYRIGHT = "© Copyright 2015"
   Public Const DEF_TITLE = "Software Developers Store."
   Public Const COMPANY = 1

   Public Const ENGLISH = 1
   Public Const FRENCH = 2

   Public Const CANADA = 1
   Public Const USA = 2

   Public Const VISA = 1
   Public Const MASTERCARD = 2
   Public Const AMEX = 3

   Public Const chPDF = 3

   Public Const ACC_TOTAL = 50

   Public Const AUDIT_COMPANY = 1
   Public Const AUDIT_CUSTOMER = 2
   Public Const AUDIT_INVOICE = 3
   Public Const AUDIT_ORDERS = 4
   Public Const AUDIT_PRODUCT = 5
   Public Const AUDIT_USER = 6

   Public Const NOTE_COMPANY = "1"
   Public Const NOTE_USER = "2"
   Public Const NOTE_CUSTOMER = "3"

   Public Const ATTACHMENT_COMPANY = "1"
   Public Const ATTACHMENT_USER = "2"
   Public Const ATTACHMENT_CUSTOMER = "3"

   Public Const PASSWORD_NORMAL = 1
   Public Const PASSWORD_RESET = 2

   Public Const MR_COMPANY = 1
   Public Const MR_USER = 2
   Public Const MR_ORDERS = 3
   Public Const MR_PRODUCT = 4
   Public Const MR_CUSTOMER = 5

   Public Structure DATA_RECORD
      Dim ocn As System.Data.OleDb.OleDbConnection
      Dim ocmd As OleDb.OleDbCommand
      Dim oread As OleDb.OleDbDataReader
#If SFTSTORE Then
      Dim frm As mfrm
#End If

      Dim MFRM_CNT As Long
      Dim MFRM_REFRESH As Long
      Dim MFRM_INTERVAL As Long
      Dim sbarleft As String

      Dim productPrice As Decimal

      Dim filteredText$()
      Dim shipNumber As Long

      Dim MAILUSER As String
      Dim MAILPASSWORD As String
      Dim MAILCUSNUMBER As String

      Dim SHIPPING_ARRAY$()
      Dim shipNum As Long

      Dim FRMSWT As Long

      Dim WEB_RESULT As String
      Dim WEB_ERRORS As String

      Dim USER_CTRL As Long

      Dim ATTACHMENT_TYPE As Long
      Dim ATTACHMENT_KEY As Long
      Dim IMAGE_KEY As Long
      Dim NOTES_TYPE As Long
      Dim NOTES_KEY As Long

      Dim LIST_CTRL As Long
      Dim LIST_RET As Long
      Dim LIST_KEY As Long
      Dim LIST_DATA As String

      Dim full_filename As String

      Dim mr_szData As String
      Dim mr_iType As Long

      Dim bytes() As Byte

      Dim au_szAccess As String

      Dim cr_szServer As String
      Dim cr_szDevelopment As String
      Dim cr_szDatabase As String
      Dim cr_szUser As String
      Dim cr_szPassword As String
      Dim cr_szVersion As String
      Dim cr_szCopyright As String
      Dim cr_test As Long

      Dim dLastpassword As Date
      Dim iid As Long
      Dim szPassword As String
      Dim szNewpassword As String
      Dim szConfirmpassword As String
      Dim szLogin As String
      Dim szHostname As String
      Dim szConnection As String
      Dim szRstr As String

      Dim sr_iid As Long
      Dim sr_szDisplay As String
      Dim sr_szFirst As String
      Dim sr_szLast As String
      Dim sr_szNotes As String
      Dim sr_szSettings As String
      Dim sr_iLanguage As Long
      Dim sr_iRlanguage As Long
      Dim sr_iProvince As Long
      Dim sr_iCountry As Long
      Dim sr_szAccess As String
      Dim sr_iCompany As Long
      Dim sr_iComMaterials As Long

      Dim ss_iid As Long
      Dim ss_iTax1 As Long
      Dim ss_szTax1 As String
      Dim ss_rTax1 As Decimal
      Dim ss_iTax2 As Long
      Dim ss_szTax2 As String
      Dim ss_rTax2 As Decimal

      Dim SCR As Long
      Dim TAB As Long
      Dim CMD As Long
      Dim PCMD As Long
      Dim MCMD As Long
      Dim LANG As Long
      Dim RADIO As Long
      Dim MSG As Long
      Dim MSG_TYPE As Long
      Dim MSG_STR As String
      Dim MSG_TITLE As String
      Dim MSG_CMD As Long
      Dim MSG_CNT As Long
      Dim MSG_KIND As Long

      Dim tx_txt() As String

      Dim at_iid As Long
      Dim at_dDate As Date
      Dim at_USR_USER As Long
      Dim at_dUpdate As Date
      Dim at_uUSR_USER As Long
      Dim at_iType As Long
      Dim at_iAttachment As Long
      Dim at_iKey As Long
      Dim at_szSubject As String
      Dim at_szFilename As String

      Dim au_iid As Long
      Dim au_dDate As Date
      Dim au_USR_USER As Long
      Dim au_iType As Long
      Dim au_iKey As Long
      Dim au_iCount As Long
      Dim au_szEngstr As String
      Dim au_szFrnstr As String

      Dim ci_iid As Long
      Dim ci_dDate As Date
      Dim ci_USR_USER As Long
      Dim ci_dUpdate As Date
      Dim ci_uUSR_USER As Long
      Dim ci_iType As Long
      Dim ci_COM_COMPANY As Long
      Dim ci_szFilename As String

      Dim co_iid As Long
      Dim co_USR_USER As Long
      Dim co_dDate As Date
      Dim co_uUSR_USER As Long
      Dim co_dUpdate As Date
      Dim co_szCompanyName As String
      Dim co_szEmail As String
      Dim co_szPhone As String
      Dim co_szFax As String
      Dim co_szAddr1 As String
      Dim co_szAddr2 As String
      Dim co_szCity As String
      Dim co_szPostal As String
      Dim co_iCountry As Long
      Dim co_iProvince As Long
      Dim co_szMarket As String
      Dim co_iDefaultMaterial As Long
      Dim co_szWebsite As String
      Dim co_szNoReplyEmail As String
      Dim co_szReplyPass As String

      Dim cn_iid As Long
      Dim cn_dDate As Date
      Dim cn_uUSR_USER As Long
      Dim cn_dUpdated As Date
      Dim cn_COM_COMPANY As Long
      Dim cn_szName As String
      Dim cn_szEmail As String
      Dim cn_szMessage As String
      Dim cn_iFlag As Long

      Dim ca_iid As Long
      Dim ca_dDate As Date
      Dim ca_dUpdate As Date
      Dim ca_CUS_CUSTOMER As Long
      Dim ca_szName As String
      Dim ca_iMain As Long
      Dim ca_szAddr1 As String
      Dim ca_szAddr2 As String
      Dim ca_iCountry As Long
      Dim ca_iProvince As Long
      Dim ca_szCity As String
      Dim ca_szPostal As String
      Dim ca_szTitle As String

      Dim cx_iid As Long
      Dim cx_USR_USER As Long
      Dim cx_dDate As Date
      Dim cx_uUSR_USER As Long
      Dim cx_dUpdate As Date
      Dim cx_COM_COMPANY As Long
      Dim cx_rMaxWeight As Decimal
      Dim cx_rLength As Decimal
      Dim cx_rWidth As Decimal
      Dim cx_rHeight As Decimal

      Dim ch_iid As Long
      Dim ch_USR_USER As Long
      Dim ch_dDate As Date
      Dim ch_dUpdate As Date
      Dim ch_COM_COMPANY As Long
      Dim ch_szAddr1 As String
      Dim ch_szAddr2 As String
      Dim ch_szCity As String
      Dim ch_iCountry As Long
      Dim ch_iProvince As Long
      Dim ch_szPostal As String
      Dim ch_szTitle As String
      Dim ch_szName As String
      Dim ch_iShipping As Long
      Dim ch_szHours As String
      Dim ch_szTelephone As String

      Dim cb_iid As Long
      Dim cb_dDate As Date
      Dim cb_dUpdate As Date
      Dim cb_CUS_CUSTOMER As Long
      Dim cb_szTitle As String
      Dim cb_szCardHolder As String
      Dim cb_szAddr1 As String
      Dim cb_szAddr2 As String
      Dim cb_szCity As String
      Dim cb_iCountry As Long
      Dim cb_iProvince As Long
      Dim cb_szPostal As String
      Dim cb_iCardType As Long
      Dim cb_szCardNumber As String
      Dim cb_szExpiry As String
      Dim cb_szPhone As String

      Dim cu_iid As Long
      Dim cu_dDate As Date
      Dim cu_dUpdate As Date
      Dim cu_COM_COMPANY As Long
      Dim cu_szFirst As String
      Dim cu_szLast As String
      Dim cu_szEmail As String
      Dim cu_iVerified As Long
      Dim cu_iActive As Long
      Dim cu_iPasswordFlag As Long
      Dim cu_szId As String
      Dim cu_iLanguage As Long
      Dim cu_szNotes As String
      Dim cu_szDisplay As String
      Dim cu_szActivationCode As String

      Dim cp_iid As Long
      Dim cp_CUS_CUSTOMER As Long
      Dim cp_dDate As Date
      Dim cp_bPassword As Byte

      Dim cw_iid As Long
      Dim cw_dDate As Date
      Dim cw_CUS_CUSTOMER As Long
      Dim cw_PRO_PRODUCT As Long
      Dim cw_iOrdered As Long
      Dim cw_iQuantity As Long

      Dim er_iid As Long
      Dim er_szEnglish As String
      Dim er_szFrench As String
      Dim er_szEngReal As String
      Dim er_szFrnReal As String

      Dim is_iid As Long
      Dim is_INV_INVOICE As Long
      Dim is_ORD_TRACKING As Long

      Dim iv_iid As Long
      Dim iv_dDate As Date
      Dim iv_USR_USER As Long
      Dim iv_dUpdate As Date
      Dim iv_uUSR_USER As Long
      Dim iv_ORD_ORDERS As Long
      Dim iv_dInvoiceDate As Date
      Dim iv_szInvoiceNotes As String
      Dim iv_iInvnum As Long
      Dim iv_iInvoiced As Long
      Dim iv_rInvoiceTotal As Decimal
      Dim iv_rTaxAmount As Decimal
      Dim iv_iTaxFree As Long
      Dim iv_rShipping As Decimal
      Dim iv_PRM_CODES As Long

      Dim id_iid As Long
      Dim id_dDate As Date
      Dim id_USR_USER As Long
      Dim id_ORD_TRACKING_DETAIL As Long
      Dim id_INV_INVOICE As Long
      Dim id_iQuantity As Long
      Dim id_rPrice As Decimal
      Dim id_rInvAmount As Decimal
      Dim id_iTaxFree As Long

      Dim lf_iid As Long
      Dim lf_USR_USER As Long
      Dim lf_dDate As Date
      Dim lf_uUSR_USER As Long
      Dim lf_dUpdate As Date
      Dim lf_szFilter As String

      Dim no_iid As Long
      Dim no_dDate As Date
      Dim no_USR_USER As Long
      Dim no_dUpdate As Date
      Dim no_uUSR_USER As Long
      Dim no_iType As Long
      Dim no_iKey As Long
      Dim no_szSubject As String
      Dim no_szDetail As String

      Dim od_iid As Long
      Dim od_dDate As Date
      Dim od_dUpdate As Date
      Dim od_ORD_ORDERS As Long
      Dim od_PRO_PRODUCT As Long
      Dim od_vUSR_USER As Long
      Dim od_szNotes As String
      Dim od_iStatus As Long
      Dim od_iQuantity As Long
      Dim od_iLineNumber As Long
      Dim od_rPiecePrice As Decimal
      Dim od_rWeight As Decimal
      Dim od_rLength As Decimal
      Dim od_rWidth As Decimal
      Dim od_rHeight As Decimal
      Dim od_iPackMaterial As Long
      Dim od_iPackaged As Long
      Dim od_rTypeDiscount As Decimal

      Dim oo_iid As Long
      Dim oo_dDate As Date
      Dim oo_dUpdate As Date
      Dim oo_uUSR_USER As Long
      Dim oo_CUS_CUSTOMER As Long
      Dim oo_szNotes As String
      Dim oo_iStatus As Long
      Dim oo_dCompleted As Date
      Dim oo_dShipped As Date
      Dim oo_dOrderDate As Date
      Dim oo_CUS_ADDRESS As Long
      Dim oo_COM_COMPANY As Long
      Dim oo_PRM_CODES As Long

      Dim ot_iid As Long
      Dim ot_dDate As Date
      Dim ot_COM_BOXES As Long
      Dim ot_iShipNum As Long
      Dim ot_szTracking As String
      Dim ot_szShipCode As String
      Dim ot_rShipCost As Decimal
      Dim ot_szArtifact As String
      Dim ot_szShipId As String
      Dim ot_iReturned As Long
      Dim ot_iReturnRequested As Long
      Dim ot_uUSR_USER As Long
      Dim ot_dReturned As Date
      Dim ot_szTicketId As String
      Dim ot_dTicketDate As Date
      Dim ot_szTicketEmail As String
      Dim ot_szRefundReason As String
      Dim ot_iInvoiced As Long

      Dim oa_iid As Long
      Dim oa_ORD_DETAIL As Long
      Dim oa_ORD_TRACKING As Long
      Dim oa_rPrice As Decimal
      Dim oa_rTypeDiscount As Decimal

      Dim pf_iid As Long
      Dim pf_dDate As Date
      Dim pf_CUS_CUSTOMER As Long
      Dim pf_PRO_PRODUCT As Long
      Dim pf_iRating As Long
      Dim pf_szFeedback As String

      Dim pi_iid As Long
      Dim pi_USR_USER As Long
      Dim pi_dDate As Date
      Dim pi_uUSR_USER As Long
      Dim pi_dUpdate As Date
      Dim pi_PRO_PRODUCT As Long
      Dim pi_szImage As String
      Dim pi_bBinary() As Byte
      Dim pi_iActive As Long
      Dim pi_iOrder As Long
      Dim pi_szTooltip As String

      Dim pc_iid As Long
      Dim pc_dDate As Date
      Dim pc_USR_USER As Long
      Dim pc_PRO_PRODUCT As Long
      Dim pc_szReason As String
      Dim pc_rNewPrice As Decimal
      Dim pc_rOldPrice As Decimal

      Dim pr_iid As Long
      Dim pr_USR_USER As Long
      Dim pr_dDate As Date
      Dim pr_uUSR_USER As Long
      Dim pr_dUpdate As Date
      Dim pr_PRO_PRODUCT As Long
      Dim pr_rPrice As Decimal
      Dim pr_iStatus As Long
      Dim pr_dSpecialStart As Date
      Dim pr_dSpecialEnd As Date

      Dim pn_iid As Long
      Dim pn_dDate As Date
      Dim pn_PRO_PRODUCT As Long
      Dim pn_iType As Long
      Dim pn_iKey As Long
      Dim pn_iChanged As Long
      Dim pn_iRemaining As Long
      Dim pn_szDescription As String

      Dim po_iid As Long
      Dim po_dDate As Date
      Dim po_USR_USER As Long
      Dim po_iType As Long
      Dim po_iDiscountType As Long
      Dim po_rDiscount As Decimal
      Dim po_szDiscount As String
      Dim po_dStart As Date
      Dim po_dEnd As Date
      Dim po_COM_COMPANY As Long
      Dim po_iMinNeeded As Long
      Dim po_rTotalNeeded As Decimal
      Dim po_szCode As String

      Dim pp_iid As Long
      Dim pp_USR_USER As Long
      Dim pp_dDate As Date
      Dim pp_uUSR_USER As Long
      Dim pp_dUpdate As Date
      Dim pp_COM_COMPANY As Long
      Dim pp_PRO_TYPE As Long
      Dim pp_szProductNumber As String
      Dim pp_iActive As Long
      Dim pp_szProductName As String
      Dim pp_szProductDesc As String
      Dim pp_szProductDesc2 As String
      Dim pp_iSpecial As Long
      Dim pp_szSpecialDesc As String
      Dim pp_szDetails As String
      Dim pp_dEntry As Date
      Dim pp_rWeight As Decimal
      Dim pp_rLength As Decimal
      Dim pp_rWidth As Decimal
      Dim pp_rHeight As Decimal
      Dim pp_COM_ADDRESS As Decimal
      Dim pp_iPackaged As Long
      Dim pp_iPackMaterials As Long
      Dim pp_iPackedSolo As Long
      Dim pp_COM_BOXES As Long
      Dim pp_szSKU As String
      Dim pp_iTaxFree As Long

      Dim ps_iid As Long
      Dim ps_USR_USER As Long
      Dim ps_dDate As Date
      Dim ps_uUSR_USER As Long
      Dim ps_dUpdate As Date
      Dim ps_PRO_TYPE As Long
      Dim ps_szName As String

      Dim pt_iid As Long
      Dim pt_USR_USER As Long
      Dim pt_dDate As Date
      Dim pt_uUSR_USER As Long
      Dim pt_dUpdate As Date
      Dim pt_COM_COMPANY As Long
      Dim pt_iType As Long
      Dim pt_szTypeName As String
      Dim pt_iSpecial As Long
      Dim pt_szSpecialDesc As String
      Dim pt_rSpecialPercent As Decimal
      Dim pt_dSpecialStart As Date
      Dim pt_dSpecialEnd As Date

      Dim py_iid As Long
      Dim py_USR_USER As Long
      Dim py_dDate As Date
      Dim py_PRO_PRODUCT As Long
      Dim py_PRO_SUB_TYPE As Long

      Dim um_USR_USER As Long
      Dim um_iType As Long
      Dim um_szMostrecent As String

      Dim up_iid As Long
      Dim up_USR_USER As Long
      Dim up_dDate As Date
      Dim up_bPassword As String

      Dim uu_iid As Long
      Dim uu_USR_USER As Long
      Dim uu_dDate As Date
      Dim uu_uUSR_USER As Long
      Dim uu_dUpdate As Date
      Dim uu_COM_COMPANY As Long
      Dim uu_szCompany As String
      Dim uu_szFirst As String
      Dim uu_szLast As String
      Dim uu_szEmail As String
      Dim uu_szPhone As String
      Dim uu_szCell As String
      Dim uu_szAddr1 As String
      Dim uu_szAddr2 As String
      Dim uu_szCity As String
      Dim uu_iProvince As Long
      Dim uu_iCountry As Long
      Dim uu_szPostal As String
      Dim uu_iPasswordFlag As Long
      Dim uu_szId As String
      Dim uu_iActive As Long
      Dim uu_iLanguage As Long
      Dim uu_iRlanguage As Long

      Dim testConnectionSWT As Long
   End Structure

   Public Shared dr As DATA_RECORD
   Public Shared hdr As DATA_RECORD

   Public Shared Function ReadIni(ByVal iSection As String, ByVal iItem As String) As String
      Dim tstr1$
      Dim ParamVal$, tl1&

      Dim tFILE$ = AppDomain.CurrentDomain.BaseDirectory + "SFTSTORE.INI"

      ParamVal = Space$(1024)
      tl1 = GetPrivateProfileString(iSection, iItem, "", ParamVal, Len(ParamVal), tFILE)

      tstr1 = ""
      If tl1 > 0 Then
         tstr1 = Trim(Mid(ParamVal, 1, tl1))
      End If

      ReadIni = tstr1
   End Function
#If SFTSTOREWEB Then
   Public Shared Sub GetControlRecord(ByRef dr As DATA_RECORD)
      dr.cr_szDevelopment = ConfigurationManager.AppSettings("development")
      dr.cr_szServer = DEF_SERVER
      dr.cr_szDatabase = DEF_DATABASE
      dr.cr_szUser = DEF_USERID
      dr.cr_szPassword = DEF_PASSWORD
      dr.cr_szVersion = DEF_VERSION
      dr.cr_szCopyright = DEF_COPYRIGHT

      dr.szConnection = "Provider=SQLOLEDB;User ID=" + dr.cr_szUser + ";Password=" + dr.cr_szPassword + ";Data Source=" + dr.cr_szServer + ";Initial Catalog=" + dr.cr_szDatabase
   End Sub
   Public Shared Sub SaveSession(ByRef dr As DATA_RECORD, Optional ctrl% = 0)
      dr.szConnection = "Provider=SQLOLEDB;User ID=" + dr.cr_szUser + ";Password=" + dr.cr_szPassword + ";Data Source=" + dr.cr_szServer + ";Initial Catalog=" + dr.cr_szDatabase
      'SV("PASSWORD", dr.szPassword)
      'SV("CONFIRMPASSWORD", dr.szConfirmpassword)
      'SV("NEWPASSWORD", dr.szNewpassword)
      'SV("LOGIN", dr.szLogin)
      'SV("OPEN_CERTIFICATE", dr.open_szCertificate)
      'SV("OPEN_IID", dr.open_szIid)
      'SV("OPEN_LAST", dr.open_szLast)
      'SV("OPEN_RANGER", dr.open_szRanger)
      'SV("OPEN_FIRST", dr.open_szFirst)
      'SV("OPEN_DESC", dr.open_szDesc)
      'SV("OPEN_ID", dr.open_szId)
      'SV("DATE_REMIT_FROM", Format(dr.DATE_REMIT_FROM, "dd/MMM/yyyy"))
      'SV("DATE_REMIT_TO", Format(dr.DATE_REMIT_TO, "dd/MMM/yyyy"))

      'SV(CStr(ctrl) + "_" + "ap_iid", CStr(dr.ap_iid))
      'SV(CStr(ctrl) + "_" + "ap_dDate", Format(dr.ap_dDate, "dd/MMM/yyyy HH:mm:ss"))
   End Sub
   Public Shared Sub GetSession(ByRef dr As DATA_RECORD, Optional ctrl% = 0)
      GetControlRecord(dr)
      GV("sr_iid", 0)
   End Sub
#End If
   Public Shared Sub ConnectDatabase()
      Err.Clear()
      dr.ocn = New OleDb.OleDbConnection

      dr.ocn.ConnectionString = dr.szConnection

      dr.ocn.Open()
      dr.ocmd = New OleDb.OleDbCommand
      dr.ocmd.Connection = dr.ocn
      'dr.oread = Nothing

      If Err.Number > 0 Then
#If SFTSTORE Then
         MsgBox("Database connection not found.")
         End
#End If
      End If
   End Sub
   Public Shared Sub TestConnection()
      Try
         If dr.testConnectionSWT = 0 Then
            dr.testConnectionSWT = 1
            dr.ocmd.CommandText = "SELECT TOP 1 uu_iid FROM USR_USER"
            dr.oread = dr.ocmd.ExecuteReader()
            If dr.oread.HasRows = False Then
#If SFTSTORE Then
               MsgDsp("Connection Lost. Re-Establishing Connection.")
#End If
               ConnectDatabase()
            End If
         Else
            If dr.oread.IsClosed = False Then
               dr.oread.Close()
            End If
            dr.ocmd.CommandText = "SELECT TOP 1 uu_iid FROM USR_USER"
            dr.oread = dr.ocmd.ExecuteReader()
            If dr.oread.HasRows = False Then
#If SFTSTORE Then
               MsgDsp("Connection Lost. Re-Establishing Connection.")
#End If
               ConnectDatabase()
            End If
         End If
      Catch ex As Exception
      Finally
         If dr.oread.IsClosed = False Then
            dr.oread.Close()
         End If
      End Try
   End Sub
   Public Shared Sub CloseDatabase()
      If dr.oread Is Nothing Then
      Else
         dr.oread.Close()
      End If

      dr.ocn.Close()
   End Sub

   Public Shared Sub Inits()
#If SFTSTOREWEB Then
      SV("sr_iCompany", "1")
#End If
      Dim tFILE$ = AppDomain.CurrentDomain.BaseDirectory + "SFTSTORE.DAT"
      dr.sr_iLanguage = ENGLISH
      dr.sr_szSettings = ""
      If System.IO.File.Exists(tFILE) = True Then
         Dim obj As New System.IO.StreamReader(tFILE, True)
         dr.sr_szSettings = obj.ReadToEnd()
         obj.Close()
      End If

      dr.cr_szServer = DEF_SERVER
      dr.cr_szDatabase = DEF_DATABASE
      dr.cr_szUser = DEF_USERID
      dr.cr_szPassword = DEF_PASSWORD
      dr.cr_szVersion = DEF_VERSION
      dr.cr_szCopyright = DEF_COPYRIGHT

      If GetKeyValue(dr.sr_szSettings, "BETA") = "1" Then
         dr.cr_szDatabase = "SFTSTORE"
         dr.cr_test = 1
      End If
      If GetKeyValue(dr.sr_szSettings, "LOCAL") = "1" Then
         dr.cr_szServer = "(local)"
         dr.cr_szDatabase = "SFTSTORE"
         dr.cr_test = 2
      End If
      If GetKeyValue(dr.sr_szSettings, "ALPHA") = "1" Then
         dr.cr_szDatabase = "SFTSTORE"
         dr.cr_test = 3
      End If

      dr.szConnection = "Provider=SQLOLEDB;User ID=" + dr.cr_szUser + ";Password=" + dr.cr_szPassword + ";Data Source=" + dr.cr_szServer + ";Initial Catalog=" + dr.cr_szDatabase
      ConnectDatabase()
   End Sub
   Public Shared Sub getFilteredText()
      Dim tstr1$ = ""
      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM LAN_FILTER WHERE lf_szFilter <> ''"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         Do While dr.oread.Read()
            tstr1 += dr.oread("lf_szFilter") + "|"
         Loop
      End If
      dr.oread.Close()
      dr.filteredText = Split(tstr1, "|")
   End Sub
   Public Shared Sub AuditAdd(ByVal iType&, ByVal iKey&, ByVal eStr$, ByVal fStr$, ByRef dr As DATA_RECORD)
      Dim strSQL$, rstr$, tstr1$, tSW%, tI%, tE%, tF%, tCNT%, tLEN%
      Dim edta$(), fdta$()
      Dim engstr$, frnstr$
      tLEN = 90
      If Len(eStr) > Len(fStr) Then
         tstr1 = eStr
      Else
         tstr1 = fStr
      End If
      tCNT = 0
      tSW = 0
      tI = 1
      tE = 0
      tF = 0
      edta = Split(eStr + " ", " ")
      fdta = Split(fStr + " ", " ")
      Do While tSW = 0
         engstr = ""
         frnstr = ""
         tSW = 0
         If tE >= UBound(edta) Then tSW = 1
         If tSW = 0 Then
            Do While tSW = 0
               If engstr <> "" Then engstr += " "
               engstr += edta(tE)
               If UBound(edta) = tE Then
                  tSW = 1
               Else
                  tE += 1
                  If Len(engstr + " " + edta(tE)) > tLEN Then
                     tSW = 1
                  End If
               End If
            Loop
         End If
         tSW = 0
         If tF >= UBound(fdta) Then tSW = 1
         If tSW = 0 Then
            Do While tSW = 0
               If frnstr <> "" Then frnstr += " "
               frnstr += fdta(tF)
               If UBound(fdta) = tF Then
                  tSW = 1
               Else
                  tF += 1
                  If Len(frnstr + " " + fdta(tF)) > tLEN Then
                     tSW = 1
                  End If
               End If
            Loop
         End If
         'engstr = Mid(eStr, tI)
         'frnstr = Mid(fStr, tI)
         'If Len(engstr) > 60 Then engstr = Mid(eStr, tI, 60)
         'If Len(frnstr) > 60 Then frnstr = Mid(fStr, tI, 60)
         engstr = Trim(engstr)
         frnstr = Trim(frnstr)
         tSW = 0
         If engstr + frnstr = "" Then
            tSW = 1
         Else
            strSQL = "AUDIT_UPDATE "
            strSQL += "'" + Format(Now, "dd/MMM/yyyy HH:mm:ss") + "', "
            strSQL += CStr(dr.sr_iid) + ", "
            strSQL += CStr(iType) + ", "
            strSQL += CStr(iKey) + ", "
            strSQL += CStr(tCNT) + ", "
            strSQL += "'" + AStr(engstr) + "', "
            strSQL += "'" + AStr(frnstr) + "'"
            rstr = ""
            ExecuteScalar(dr.szConnection, strSQL, rstr)
         End If
         tCNT += 1
         'tI += 60
      Loop
   End Sub
   Public Shared Sub AttachmentsInits(ByRef dr As DATA_RECORD)
      dr.at_iid = 0
      dr.at_dDate = Now
      dr.at_USR_USER = dr.sr_iid
      dr.at_dUpdate = Now
      dr.at_uUSR_USER = dr.sr_iid
      dr.at_iType = dr.ATTACHMENT_TYPE
      dr.at_iKey = dr.ATTACHMENT_KEY
      dr.at_iAttachment = 1
      dr.at_szSubject = ""
      dr.at_szFilename = ""
   End Sub
   Public Shared Sub UpdateAttachmentRecord(ByRef dr As DATA_RECORD)
      Dim oP1 As New OleDb.OleDbParameter
      Dim retVal As String, tstr1$
      Dim tl1&

      Dim rdr As FileStream = File.OpenRead(dr.at_szFilename)
      Dim tI&
      ReDim dr.bytes(rdr.Length)
      tI = rdr.Read(dr.bytes, 0, rdr.Length)
      rdr.Close()

      tstr1 = ""
      For tl1 = Len(dr.at_szFilename) To 1 Step -1
         If Mid(dr.at_szFilename, tl1, 1) = "\" Or Mid(dr.at_szFilename, tl1, 1) = "/" Or Mid(dr.at_szFilename, tl1, 1) = ":" Then
            Exit For
         Else
            tstr1 = Mid(dr.at_szFilename, tl1, 1) + tstr1
         End If
      Next

      dr.at_szFilename = tstr1
      TestConnection()

      dr.at_uUSR_USER = dr.sr_iid
      dr.at_dUpdate = Now

      dr.ocmd.CommandType = CommandType.StoredProcedure
      dr.ocmd.CommandText = "ATTACHMENTS_UPDATE"
      dr.ocmd.Parameters.Add("iID", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("dDate", OleDbType.Date)
      dr.ocmd.Parameters.Add("USR_USER", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("dUpdate", OleDbType.Date)
      dr.ocmd.Parameters.Add("uUSR_USER", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("iType", OleDbType.Integer)
      dr.ocmd.Parameters.Add("iKey", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("iAttachment", OleDbType.Integer)
      dr.ocmd.Parameters.Add("szSubject", OleDbType.VarChar)
      dr.ocmd.Parameters.Add("szFilename", OleDbType.VarChar)
      dr.ocmd.Parameters.Add("bBinary", OleDbType.Binary)
      dr.ocmd.Parameters(0).Direction = ParameterDirection.InputOutput
      dr.ocmd.Parameters(1).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(2).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(3).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(4).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(5).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(6).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(7).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(8).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(9).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(10).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(0).Value = dr.at_iid
      dr.ocmd.Parameters(1).Value = dr.at_dDate
      dr.ocmd.Parameters(2).Value = dr.at_USR_USER
      dr.ocmd.Parameters(3).Value = dr.at_dUpdate
      dr.ocmd.Parameters(4).Value = dr.at_uUSR_USER
      dr.ocmd.Parameters(5).Value = dr.at_iType
      dr.ocmd.Parameters(6).Value = dr.at_iKey
      dr.ocmd.Parameters(7).Value = dr.at_iAttachment
      dr.ocmd.Parameters(8).Value = dr.at_szSubject
      dr.ocmd.Parameters(9).Value = dr.at_szFilename
      dr.ocmd.Parameters(10).Value = dr.bytes
      retVal = dr.ocmd.ExecuteNonQuery()
      dr.at_iid = dr.ocmd.Parameters(0).Value

      ConnectDatabase()
   End Sub
   Public Shared Sub GetAttachmentsBinary(ByVal iid As Long, ByRef dr As DATA_RECORD)

      Dim rspString As String = ""
      Dim strSQL As String = "SELECT * FROM ATT_ATTACHMENTS where at_iid = " + CStr(iid)
      TestConnection()
      Try
         dr.ocmd.CommandText = strSQL
         dr.oread = dr.ocmd.ExecuteReader
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            dr.bytes = dr.oread("at_bBinary")
         End If
      Catch ex As Exception
         rspString = ex.Message
      Finally
         dr.oread.Close()
      End Try
   End Sub
   Public Shared Sub GetAttachmentsRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)

      Dim rspString As String = ""
      Dim strSQL As String = "SELECT at_iid, at_ddate, at_USR_USER, at_dUpdate, at_uUSR_USER, at_iKey, at_iType, at_szFilename, at_szSubject, at_iAttachment FROM ATT_ATTACHMENTS where at_iid = " + CStr(iid)
      TestConnection()
      Try
         dr.ocmd.CommandText = strSQL
         dr.oread = dr.ocmd.ExecuteReader
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            dr.at_iid = dr.oread("at_iid")
            dr.at_dDate = dr.oread("at_dDate")
            dr.at_USR_USER = dr.oread("at_USR_USER")
            dr.at_dUpdate = dr.oread("at_dUpdate")
            dr.at_uUSR_USER = dr.oread("at_uUSR_USER")
            dr.at_iType = dr.oread("at_iType")
            dr.at_iKey = dr.oread("at_iKey")
            dr.at_iAttachment = dr.oread("at_iAttachment")
            dr.at_szFilename = dr.oread("at_szFilename")
            dr.at_szSubject = dr.oread("at_szSubject")
         End If
      Catch ex As Exception
         rspString = ex.Message
      Finally
         dr.oread.Close()
      End Try
   End Sub
   Public Shared Function OpenAttachments(ByRef dr As DATA_RECORD) As String
      Dim tstr1$
      Dim rspString As String = ""
      Dim strsql$ = "select at_iid, at_szSubject, at_dDate from ATT_ATTACHMENTS where at_iType = " + CStr(dr.ATTACHMENT_TYPE) + " And at_iKey = " + CStr(dr.ATTACHMENT_KEY)

      Err.Clear()
      tstr1 = ""
      dr.ocmd.CommandText = strsql
      dr.oread = dr.ocmd.ExecuteReader()
      While dr.oread.Read()
         If Err.Number > 0 Then Exit While
         tstr1 += CStr(dr.oread("at_iid")) + "^"
         tstr1 += dr.oread("at_szSubject") + "^"
         tstr1 += DateFormat(dr.oread("at_dDate"), dr.LANG, 1) + "^"
      End While
      dr.oread.Close()
      OpenAttachments = RStr(tstr1)
   End Function
   Public Shared Sub CompanyImagesInits(ByRef dr As DATA_RECORD)
      dr.ci_iid = 0
      dr.ci_dDate = Now
      dr.ci_USR_USER = dr.sr_iid
      dr.ci_dUpdate = Now
      dr.ci_uUSR_USER = dr.sr_iid
      dr.ci_iType = 1
      dr.ci_COM_COMPANY = dr.IMAGE_KEY
      dr.ci_szFilename = ""
   End Sub
   Public Shared Sub UpdateCompanyImagesRecord(ByRef dr As DATA_RECORD)
      Dim oP1 As New OleDb.OleDbParameter
      Dim retVal As String, tstr1$
      Dim tl1&

      Dim rdr As FileStream = File.OpenRead(dr.ci_szFilename)
      Dim tI&
      ReDim dr.bytes(rdr.Length)
      tI = rdr.Read(dr.bytes, 0, rdr.Length)
      rdr.Close()

      tstr1 = ""
      For tl1 = Len(dr.ci_szFilename) To 1 Step -1
         If Mid(dr.ci_szFilename, tl1, 1) = "\" Or Mid(dr.ci_szFilename, tl1, 1) = "/" Or Mid(dr.ci_szFilename, tl1, 1) = ":" Then
            Exit For
         Else
            tstr1 = Mid(dr.ci_szFilename, tl1, 1) + tstr1
         End If
      Next

      dr.ci_szFilename = tstr1
      TestConnection()

      dr.ci_uUSR_USER = dr.sr_iid
      dr.ci_dUpdate = Now

      dr.ocmd.CommandType = CommandType.StoredProcedure
      dr.ocmd.CommandText = "COMPANY_IMAGES_UPDATE"
      dr.ocmd.Parameters.Add("iID", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("dDate", OleDbType.Date)
      dr.ocmd.Parameters.Add("USR_USER", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("dUpdate", OleDbType.Date)
      dr.ocmd.Parameters.Add("uUSR_USER", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("iType", OleDbType.Integer)
      dr.ocmd.Parameters.Add("iKey", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("szFilename", OleDbType.VarChar)
      dr.ocmd.Parameters.Add("bBinary", OleDbType.Binary)
      dr.ocmd.Parameters(0).Direction = ParameterDirection.InputOutput
      dr.ocmd.Parameters(1).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(2).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(3).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(4).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(5).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(6).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(7).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(8).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(0).Value = dr.ci_iid
      dr.ocmd.Parameters(1).Value = dr.ci_dDate
      dr.ocmd.Parameters(2).Value = dr.ci_USR_USER
      dr.ocmd.Parameters(3).Value = dr.ci_dUpdate
      dr.ocmd.Parameters(4).Value = dr.ci_uUSR_USER
      dr.ocmd.Parameters(5).Value = dr.ci_iType
      dr.ocmd.Parameters(6).Value = dr.ci_COM_COMPANY
      dr.ocmd.Parameters(7).Value = dr.ci_szFilename
      dr.ocmd.Parameters(8).Value = dr.bytes
      retVal = dr.ocmd.ExecuteNonQuery()
      dr.ci_iid = dr.ocmd.Parameters(0).Value

      ConnectDatabase()
   End Sub
   Public Shared Sub GetCompanyImagesBinary(ByVal iid As Long, ByRef dr As DATA_RECORD)

      Dim rspString As String = ""
      Dim strSQL As String = "SELECT ci_bBinary FROM COM_IMAGES where ci_iid = " + CStr(iid)
      TestConnection()
      Try
         dr.ocmd.CommandText = strSQL
         dr.oread = dr.ocmd.ExecuteReader
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            dr.bytes = dr.oread("ci_bBinary")
         End If
      Catch ex As Exception
         rspString = ex.Message
      Finally
         dr.oread.Close()
      End Try
   End Sub
   Public Shared Sub GetCompanyImagesRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)

      Dim rspString As String = ""
      Dim strSQL As String = "SELECT * FROM COM_IMAGES where ci_iid = " + CStr(iid)
      TestConnection()
      Try
         dr.ocmd.CommandText = strSQL
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            dr.ci_iid = dr.oread("ci_iid")
            dr.ci_dDate = dr.oread("ci_dDate")
            dr.ci_USR_USER = dr.oread("ci_USR_USER")
            dr.ci_dUpdate = dr.oread("ci_dUpdate")
            dr.ci_uUSR_USER = dr.oread("ci_uUSR_USER")
            dr.ci_iType = dr.oread("ci_iType")
            dr.ci_COM_COMPANY = dr.oread("ci_COM_COMPANY")
            dr.ci_szFilename = dr.oread("ci_szFilename")
         End If
      Catch ex As Exception
         rspString = ex.Message
      Finally
         dr.oread.Close()
      End Try
   End Sub
   Public Shared Function OpenCompanyImages(ByRef dr As DATA_RECORD) As String
      Dim tstr1$
      Dim rspString As String = ""
      Dim strsql$ = "SELECT ci_iid, ci_szSubject, ci_dDate FROM COM_IMAGES WHERE ci_COM_COMPANY = " + CStr(dr.IMAGE_KEY)

      Err.Clear()
      tstr1 = ""
      dr.ocmd.CommandText = strsql
      dr.oread = dr.ocmd.ExecuteReader()
      While dr.oread.Read()
         If Err.Number > 0 Then Exit While
         tstr1 += CStr(dr.oread("ci_iid")) + "^"
         tstr1 += dr.oread("ci_szSubject") + "^"
         tstr1 += DateFormat(dr.oread("ci_dDate"), dr.LANG, 1) + "^"
      End While
      dr.oread.Close()
      OpenCompanyImages = RStr(tstr1)
   End Function
   Public Shared Sub InitCompany(ByRef dr As DATA_RECORD)
      dr.co_iid = 0
      dr.co_USR_USER = dr.sr_iid
      dr.co_dDate = Now
      dr.co_uUSR_USER = dr.sr_iid
      dr.co_dUpdate = Now
      dr.co_szCompanyName = ""
      dr.co_szEmail = ""
      dr.co_szPhone = ""
      dr.co_szFax = ""
      dr.co_szAddr1 = ""
      dr.co_szAddr2 = ""
      dr.co_szCity = ""
      dr.co_szPostal = ""
      dr.co_iCountry = 1
      dr.co_iProvince = 1
      dr.co_szMarket = ""
      dr.co_iDefaultMaterial = 0
      dr.co_szWebsite = ""
      dr.co_szNoReplyEmail = ""
      dr.co_szReplyPass = ""
   End Sub
   Public Shared Sub UpdateCompanyRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""
      Dim tl1& = 0, tl2& = 0
      If dr.co_iid > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM COM_COMPANY WHERE co_iid = " + CStr(dr.co_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If dr.oread("co_szCompanyname") <> dr.co_szCompanyName Then AuditAdd(AUDIT_COMPANY, dr.co_iid, EngTxt(2) + " " + dr.oread("co_szCompanyname") + " " + EngTxt(1) + " " + dr.co_szCompanyName, FrnTxt(2) + " " + dr.oread("co_szCompanyname") + " " + FrnTxt(1) + " " + dr.co_szCompanyName, dr)
            If dr.oread("co_szEmail") <> dr.co_szEmail Then AuditAdd(AUDIT_COMPANY, dr.co_iid, EngTxt(3) + " " + dr.oread("co_szEmail") + " " + EngTxt(1) + " " + dr.co_szEmail, FrnTxt(3) + " " + dr.oread("co_szEmail") + " " + FrnTxt(1) + " " + dr.co_szEmail, dr)
            If dr.oread("co_szPhone") <> dr.co_szPhone Then AuditAdd(AUDIT_COMPANY, dr.co_iid, EngTxt(4) + " " + dr.oread("co_szPhone") + " " + EngTxt(1) + " " + dr.co_szPhone, FrnTxt(4) + " " + dr.oread("co_szPhone") + " " + FrnTxt(1) + " " + dr.co_szPhone, dr)
            If dr.oread("co_szAddr1") <> dr.co_szAddr1 Then AuditAdd(AUDIT_COMPANY, dr.co_iid, EngTxt(5) + " " + dr.oread("co_szAddr1") + " " + EngTxt(1) + " " + dr.co_szAddr1, FrnTxt(5) + " " + dr.oread("co_szAddr1") + " " + FrnTxt(1) + " " + dr.co_szAddr1, dr)
            If dr.oread("co_szAddr2") <> dr.co_szAddr2 Then AuditAdd(AUDIT_COMPANY, dr.co_iid, EngTxt(6) + " " + dr.oread("co_szAddr2") + " " + EngTxt(1) + " " + dr.co_szAddr2, FrnTxt(6) + " " + dr.oread("co_szAddr2") + " " + FrnTxt(1) + " " + dr.co_szAddr2, dr)
            If dr.oread("co_szCity") <> dr.co_szCity Then AuditAdd(AUDIT_COMPANY, dr.co_iid, EngTxt(7) + " " + dr.oread("co_szCity") + " " + EngTxt(1) + " " + dr.co_szCity, FrnTxt(7) + " " + dr.oread("co_szCity") + " " + FrnTxt(1) + " " + dr.co_szCity, dr)
            If dr.oread("co_szPostal") <> dr.co_szPostal Then AuditAdd(AUDIT_COMPANY, dr.co_iid, EngTxt(8) + " " + dr.oread("co_szPostal") + " " + EngTxt(1) + " " + dr.co_szPostal, FrnTxt(8) + " " + dr.oread("co_szPostal") + " " + FrnTxt(1) + " " + dr.co_szPostal, dr)
            If dr.oread("co_iCountry") <> dr.co_iCountry Then AuditAdd(AUDIT_COMPANY, dr.co_iid, EngTxt(9) + " " + EngTxt(299 + dr.oread("co_iCountry")) + " " + EngTxt(1) + " " + EngTxt(299 + dr.co_iCountry), FrnTxt(9) + " " + FrnTxt(299 + dr.oread("co_iCountry")) + " " + FrnTxt(1) + " " + FrnTxt(299 + dr.co_iCountry), dr)
            If dr.oread("co_iCountry") = CANADA Then
               tl1 = 99
            Else
               tl1 = 149
            End If
            If dr.oread("co_iProvince") <> dr.co_iProvince Then AuditAdd(AUDIT_COMPANY, dr.co_iProvince, EngTxt(10) + " " + EngTxt(tl1 + dr.oread("co_iProvince")) + " " + EngTxt(1) + " " + EngTxt(tl1 + dr.co_iProvince), FrnTxt(10) + " " + EngTxt(tl1 + dr.oread("co_iProvince")) + " " + FrnTxt(1) + " " + FrnTxt(tl1 + dr.co_iProvince), dr)
            If dr.oread("co_szFax") <> dr.co_szFax Then AuditAdd(AUDIT_COMPANY, dr.co_iid, EngTxt(351) + " " + dr.oread("co_szFax") + " " + EngTxt(1) + " " + dr.co_szFax, EngTxt(351) + " " + dr.oread("co_szFax") + " " + FrnTxt(1) + " " + dr.co_szFax, dr)
            If dr.oread("co_szMarket") <> dr.co_szMarket Then AuditAdd(AUDIT_COMPANY, dr.co_iid, EngTxt(350) + " " + dr.oread("co_szMarket") + " " + EngTxt(1) + " " + dr.co_szMarket, FrnTxt(350) + " " + dr.oread("co_szMarket") + " " + FrnTxt(1) + " " + dr.co_szMarket, dr)
         End If
         dr.oread.Close()
      Else
         tl2 = 1
      End If

      dr.co_uUSR_USER = dr.sr_iid
      dr.co_dUpdate = Now

      strSQL = "COMPANY_UPDATE "
      strSQL += CStr(dr.co_iid) + ","
      strSQL += CStr(dr.co_USR_USER) + ","
      strSQL += "'" + Format(dr.co_dDate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.co_uUSR_USER) + ", "
      strSQL += "'" + Format(dr.co_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += "'" + AStr(dr.co_szCompanyName) + "',"
      strSQL += "'" + AStr(dr.co_szEmail) + "',"
      strSQL += "'" + AStr(dr.co_szPhone) + "',"
      strSQL += "'" + AStr(dr.co_szFax) + "',"
      strSQL += "'" + AStr(dr.co_szAddr1) + "',"
      strSQL += "'" + AStr(dr.co_szAddr2) + "',"
      strSQL += "'" + AStr(dr.co_szCity) + "',"
      strSQL += "'" + AStr(dr.co_szPostal) + "',"
      strSQL += CStr(dr.co_iCountry) + ","
      strSQL += CStr(dr.co_iProvince) + ","
      strSQL += "'" + AStr(dr.co_szMarket) + "',"
      strSQL += CStr(dr.co_iDefaultMaterial) + ","
      strSQL += "'" + AStr(dr.co_szWebsite) + "',"
      strSQL += "'" + AStr(dr.co_szNoReplyEmail) + "',"
      strSQL += "'" + AStr(dr.co_szReplyPass) + "'"

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.co_iid = 0 Then
         dr.co_iid = CLng(GetFloat(rstr))
      End If
      If tl2 = 1 Then
         AuditAdd(AUDIT_COMPANY, dr.co_iid, EngTxt(33) + " " + Format(dr.co_dDate, "dd-MMM-yyyy"), FrnTxt(33) + " " + Format(dr.co_dDate, "dd-MMM-yyyy"), dr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetCompanyRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      TestConnection()
      Dim strSql$ = "SELECT * FROM COM_COMPANY WHERE co_iid = " + CStr(iid)
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.co_iid = dr.oread("co_iid")
         dr.co_USR_USER = dr.oread("co_USR_USER")
         dr.co_dDate = dr.oread("co_dDate")
         dr.co_uUSR_USER = dr.oread("co_uUSR_USER")
         dr.co_dUpdate = dr.oread("co_dUpdate")
         dr.co_szCompanyName = dr.oread("co_szCompanyName")
         dr.co_szEmail = dr.oread("co_szEmail")
         dr.co_szPhone = dr.oread("co_szPhone")
         dr.co_szFax = dr.oread("co_szFax")
         dr.co_szAddr1 = dr.oread("co_szAddr1")
         dr.co_szAddr2 = dr.oread("co_szAddr2")
         dr.co_szCity = dr.oread("co_szCity")
         dr.co_szPostal = dr.oread("co_szPostal")
         dr.co_iCountry = dr.oread("co_iCountry")
         dr.co_iProvince = dr.oread("co_iProvince")
         dr.co_szMarket = dr.oread("co_szMarket")
         dr.co_iDefaultMaterial = dr.oread("co_iDefaultMaterial")
         dr.co_szWebsite = dr.oread("co_szWebsite")
         dr.co_szNoReplyEmail = dr.oread("co_szNoReplyEmail")
         dr.co_szReplyPass = dr.oread("co_szReplyPass")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitCustomerAddress(ByRef dr As DATA_RECORD)
      dr.ca_iid = 0
      dr.ca_dDate = Now
      dr.ca_dUpdate = Now
      dr.ca_CUS_CUSTOMER = dr.cu_iid
      dr.ca_szName = ""
      dr.ca_iMain = 1
      dr.ca_szAddr1 = ""
      dr.ca_szAddr2 = ""
      dr.ca_iCountry = 1
      dr.ca_iProvince = 1
      dr.ca_szCity = ""
      dr.ca_szPostal = ""
      dr.ca_szTitle = ""
   End Sub
   Public Shared Sub UpdateCustomerAddressRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""
      dr.ca_dUpdate = Now

      strSQL = "CUSTOMER_ADDRESS_UPDATE "
      strSQL += CStr(dr.ca_iid) + ", "
      strSQL += "'" + Format(dr.ca_dDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += "'" + Format(dr.ca_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.ca_CUS_CUSTOMER) + ", "
      strSQL += "'" + AStr(dr.ca_szName) + "',"
      strSQL += CStr(dr.ca_iMain) + ", "
      strSQL += "'" + AStr(dr.ca_szAddr1) + "',"
      strSQL += "'" + AStr(dr.ca_szAddr2) + "',"
      strSQL += CStr(dr.ca_iCountry) + ","
      strSQL += CStr(dr.ca_iProvince) + ","
      strSQL += "'" + AStr(dr.ca_szCity) + "',"
      strSQL += "'" + AStr(dr.ca_szPostal) + "',"
      strSQL += "'" + AStr(dr.ca_szTitle) + "'"

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.ca_iid = 0 Then
         dr.ca_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetCustomerAddressRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM CUS_ADDRESS where ca_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.ca_iid = dr.oread("ca_iid")
         dr.ca_dDate = dr.oread("ca_dDate")
         dr.ca_dUpdate = dr.oread("ca_dUpdate")
         dr.ca_CUS_CUSTOMER = dr.oread("ca_CUS_CUSTOMER")
         dr.ca_szName = dr.oread("ca_szName")
         dr.ca_iMain = dr.oread("ca_iMain")
         dr.ca_szAddr1 = dr.oread("ca_szAddr1")
         dr.ca_szAddr2 = dr.oread("ca_szAddr2")
         dr.ca_iCountry = dr.oread("ca_iCountry")
         dr.ca_iProvince = dr.oread("ca_iProvince")
         dr.ca_szCity = dr.oread("ca_szCity")
         dr.ca_szPostal = dr.oread("ca_szPostal")
         dr.ca_szTitle = dr.oread("ca_szTitle")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitCompanyBoxes(ByRef dr As DATA_RECORD)
      dr.cx_iid = 0
      dr.cx_USR_USER = dr.sr_iid
      dr.cx_dDate = Now
      dr.cx_uUSR_USER = dr.sr_iid
      dr.cx_dUpdate = Now
      If dr.FRMSWT = 1 Then
         dr.cx_COM_COMPANY = dr.sr_iCompany
      Else
         dr.cx_COM_COMPANY = dr.co_iid
      End If
      dr.cx_rMaxWeight = 0
      dr.cx_rLength = 0
      dr.cx_rWidth = 0
      dr.cx_rHeight = 0
   End Sub
   Public Shared Sub UpdateCompanyBoxesRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      dr.cx_dUpdate = Now

      strSQL = "COMPANY_BOXES_UPDATE "
      strSQL += CStr(dr.cx_iid) + ", "
      strSQL += CStr(dr.cx_USR_USER) + ", "
      strSQL += "'" + Format(dr.cx_dDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.cx_uUSR_USER) + ", "
      strSQL += "'" + Format(dr.cx_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.cx_COM_COMPANY) + ", "
      strSQL += StringFormatEnglish(24, dr.cx_rMaxWeight) + ","
      strSQL += StringFormatEnglish(23, dr.cx_rLength) + ","
      strSQL += StringFormatEnglish(23, dr.cx_rWidth) + ","
      strSQL += StringFormatEnglish(23, dr.cx_rHeight) + ""

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.cx_iid = 0 Then
         dr.cx_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetCompanyBoxesRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM COM_BOXES where cx_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.cx_iid = dr.oread("cx_iid")
         dr.cx_USR_USER = dr.oread("cx_USR_USER")
         dr.cx_dDate = dr.oread("cx_dDate")
         dr.cx_uUSR_USER = dr.oread("cx_uUSR_USER")
         dr.cx_dUpdate = dr.oread("cx_dUpdate")
         dr.cx_COM_COMPANY = dr.oread("cx_COM_COMPANY")
         dr.cx_rMaxWeight = dr.oread("cx_rMaxWeight")
         dr.cx_rLength = dr.oread("cx_rLength")
         dr.cx_rWidth = dr.oread("cx_rWidth")
         dr.cx_rHeight = dr.oread("cx_rHeight")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitCompanyAddress(ByRef dr As DATA_RECORD)
      dr.ch_iid = 0
      dr.ch_USR_USER = dr.sr_iid
      dr.ch_dDate = Now
      dr.ch_dUpdate = Now
      dr.ch_COM_COMPANY = dr.co_iid
      dr.ch_szName = ""
      dr.ch_szAddr1 = ""
      dr.ch_szAddr2 = ""
      dr.ch_iCountry = 1
      dr.ch_iProvince = 1
      dr.ch_szCity = ""
      dr.ch_szPostal = ""
      dr.ch_szTitle = ""
      dr.ch_iShipping = 1
      dr.ch_szHours = ""
      dr.ch_szTelephone = ""
   End Sub
   Public Shared Sub UpdateCompanyAddressRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      dr.ch_dUpdate = Now

      strSQL = "COMPANY_ADDRESS_UPDATE "
      strSQL += CStr(dr.ch_iid) + ","
      strSQL += CStr(dr.ch_USR_USER) + ","
      strSQL += "'" + Format(dr.ch_dDate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += "'" + Format(dr.ch_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.ch_COM_COMPANY) + ","
      strSQL += "'" + AStr(dr.ch_szAddr1) + "',"
      strSQL += "'" + AStr(dr.ch_szAddr2) + "',"
      strSQL += "'" + AStr(dr.ch_szCity) + "',"
      strSQL += CStr(dr.ch_iCountry) + ","
      strSQL += CStr(dr.ch_iProvince) + ","
      strSQL += "'" + AStr(dr.ch_szPostal) + "',"
      strSQL += "'" + AStr(dr.ch_szTitle) + "',"
      strSQL += "'" + AStr(dr.ch_szName) + "',"
      strSQL += CStr(dr.ch_iShipping) + ","
      strSQL += "'" + AStr(dr.ch_szHours) + "',"
      strSQL += "'" + AStr(dr.ch_szTelephone) + "'"

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.ch_iid = 0 Then
         dr.ch_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetCompanyAddressRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM COM_ADDRESS where ch_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.ch_iid = dr.oread("ch_iid")
         dr.ch_USR_USER = dr.oread("ch_USR_USER")
         dr.ch_dDate = dr.oread("ch_dDate")
         dr.ch_dUpdate = dr.oread("ch_dUpdate")
         dr.ch_COM_COMPANY = dr.oread("ch_COM_COMPANY")
         dr.ch_szName = dr.oread("ch_szName")
         dr.ch_szAddr1 = dr.oread("ch_szAddr1")
         dr.ch_szAddr2 = dr.oread("ch_szAddr2")
         dr.ch_iCountry = dr.oread("ch_iCountry")
         dr.ch_iProvince = dr.oread("ch_iProvince")
         dr.ch_szCity = dr.oread("ch_szCity")
         dr.ch_szPostal = dr.oread("ch_szPostal")
         dr.ch_szTitle = dr.oread("ch_szTitle")
         dr.ch_iShipping = dr.oread("ch_iShipping")
         dr.ch_szHours = dr.oread("ch_szHours")
         dr.ch_szTelephone = dr.oread("ch_szTelephone")

      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitCustomerBilling(ByRef dr As DATA_RECORD)
      Dim currentyear As Date
      currentyear = Now.Date

#If SFTSTORE Then
      dr.cb_iid = 0
#ElseIf SFTSTOREWEB Then
      SV("cb_iid", 0)
#End If
      dr.cb_dDate = Now
      dr.cb_dUpdate = Now
      dr.cb_CUS_CUSTOMER = dr.cu_iid
      dr.cb_szTitle = ""
      dr.cb_szCardHolder = ""
      dr.cb_szAddr1 = ""
      dr.cb_szAddr2 = ""
      dr.cb_szCity = ""
      dr.cb_iCountry = CANADA
      dr.cb_iProvince = 1
      dr.cb_szPostal = ""
      dr.cb_iCardType = 1
      dr.cb_szCardNumber = ""
      dr.cb_szExpiry = "1|" + Format(currentyear, "yyyy")
      dr.cb_szPhone = ""
   End Sub
   Public Shared Sub UpdateCustomerBillingRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      dr.cb_dUpdate = Now

      strSQL = "CUSTOMER_BILLING_UPDATE "
#If SFTSTORE Then
      strSQL += CStr(dr.cb_iid) + ", "
#ElseIf SFTSTOREWEB Then
      strSQL += CStr(GV("cb_iid", 0)) + ", "
#End If
      strSQL += "'" + Format(dr.cb_dDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += "'" + Format(dr.cb_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.cb_CUS_CUSTOMER) + ", "
      strSQL += "'" + AStr(dr.cb_szTitle) + "',"
      strSQL += "'" + AStr(dr.cb_szCardHolder) + "',"
      strSQL += "'" + AStr(dr.cb_szAddr1) + "',"
      strSQL += "'" + AStr(dr.cb_szAddr2) + "',"
      strSQL += "'" + AStr(dr.cb_szCity) + "',"
      strSQL += CStr(dr.cb_iCountry) + ","
      strSQL += CStr(dr.cb_iProvince) + ","
      strSQL += "'" + AStr(dr.cb_szPostal) + "',"
      strSQL += CStr(dr.cb_iCardType) + ","
      strSQL += "'" + AStr(dr.cb_szCardNumber) + "',"
      strSQL += "'" + AStr(dr.cb_szExpiry) + "',"
      strSQL += "'" + AStr(dr.cb_szPhone) + "'"

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.cb_iid = 0 Then
         dr.cb_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetCustomerBillingRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM CUS_BILLING where cb_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
#If SFTSTOREWEB Then
SV("cb_iid", dr.oread("cb_iid"))
#End If

         dr.cb_iid = dr.oread("cb_iid")
         dr.cb_dDate = dr.oread("cb_dDate")
         dr.cb_dUpdate = dr.oread("cb_dUpdate")
         dr.cb_CUS_CUSTOMER = dr.oread("cb_CUS_CUSTOMER")
         dr.cb_szTitle = dr.oread("cb_szTitle")
         dr.cb_szCardHolder = dr.oread("cb_szCardHolder")
         dr.cb_szAddr1 = dr.oread("cb_szAddr1")
         dr.cb_szAddr2 = dr.oread("cb_szAddr2")
         dr.cb_szCity = dr.oread("cb_szCity")
         dr.cb_iCountry = dr.oread("cb_iCountry")
         dr.cb_iProvince = dr.oread("cb_iProvince")
         dr.cb_szPostal = dr.oread("cb_szPostal")
         dr.cb_iCardType = dr.oread("cb_iCardType")
         dr.cb_szCardNumber = dr.oread("cb_szCardNumber")
         dr.cb_szExpiry = dr.oread("cb_szExpiry")
         dr.cb_szPhone = dr.oread("cb_szPhone")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitCustomer(ByRef dr As DATA_RECORD)
      dr.cu_iid = 0
      dr.cu_dDate = Now
      dr.cu_dUpdate = Now
      dr.cu_COM_COMPANY = dr.sr_iCompany
      dr.cu_szFirst = ""
      dr.cu_szLast = ""
      dr.cu_szEmail = ""
      dr.cu_iVerified = 1
      dr.cu_iActive = 2
      dr.cu_iPasswordFlag = 2
      dr.cu_szId = ""
      dr.cu_iLanguage = ENGLISH
      dr.cu_szNotes = ""
      dr.cu_szDisplay = ""
      dr.cu_szActivationCode = ""
   End Sub
   Public Shared Sub UpdateCustomerRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      Inits()
      Dim tl1& = 0, tl2& = 0
      If dr.cu_iid > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM CUS_CUSTOMER WHERE cu_iid = " + CStr(dr.cu_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If dr.oread("cu_szFirst") <> dr.cu_szFirst Then AuditAdd(AUDIT_CUSTOMER, dr.cu_iid, EngTxt(11) + " " + dr.oread("cu_szFirst") + " " + EngTxt(1) + " " + dr.cu_szFirst, FrnTxt(11) + " " + dr.oread("cu_szFirst") + " " + FrnTxt(1) + " " + dr.cu_szFirst, dr)
            If dr.oread("cu_szLast") <> dr.cu_szLast Then AuditAdd(AUDIT_CUSTOMER, dr.cu_iid, EngTxt(12) + " " + dr.oread("cu_szLast") + " " + EngTxt(1) + " " + dr.cu_szLast, FrnTxt(12) + " " + dr.oread("cu_szLast") + " " + FrnTxt(1) + " " + dr.cu_szLast, dr)
            If dr.oread("cu_iVerified") <> dr.cu_iVerified Then AuditAdd(AUDIT_CUSTOMER, dr.cu_iid, EngTxt(13) + " " + EngTxt(33 + dr.oread("cu_iVerified")) + " " + EngTxt(1) + " " + EngTxt(33 + dr.cu_iVerified), FrnTxt(13) + " " + FrnTxt(33 + dr.oread("cu_iVerified")) + " " + FrnTxt(1) + " " + FrnTxt(33 + dr.cu_iVerified), dr)
            If dr.oread("cu_iActive") <> dr.cu_iActive Then AuditAdd(AUDIT_CUSTOMER, dr.cu_iid, EngTxt(14) + " " + EngTxt(35 + dr.oread("cu_iActive")) + " " + EngTxt(1) + " " + EngTxt(35 + dr.cu_iActive), FrnTxt(14) + " " + FrnTxt(35 + dr.oread("cu_iActive")) + " " + FrnTxt(1) + " " + FrnTxt(35 + dr.cu_iActive), dr)
            If dr.oread("cu_iPasswordFlag") <> dr.cu_iPasswordFlag Then AuditAdd(AUDIT_CUSTOMER, dr.cu_iid, EngTxt(15) + " " + EngTxt(37 + dr.oread("cu_iPasswordFlag")) + " " + EngTxt(1) + " " + EngTxt(37 + dr.cu_iPasswordFlag), FrnTxt(15) + " " + FrnTxt(37 + dr.oread("cu_iPasswordFlag")) + " " + FrnTxt(1) + " " + FrnTxt(37 + dr.cu_iPasswordFlag), dr)
            If dr.oread("cu_szId") <> dr.cu_szId Then AuditAdd(AUDIT_CUSTOMER, dr.cu_iid, EngTxt(16) + " " + dr.oread("cu_szId") + " " + EngTxt(1) + " " + dr.cu_szId, FrnTxt(16) + " " + dr.oread("cu_szId") + " " + FrnTxt(1) + " " + dr.cu_szId, dr)
            If dr.oread("cu_iLanguage") <> dr.cu_iLanguage Then AuditAdd(AUDIT_CUSTOMER, dr.cu_iid, EngTxt(32) + " " + EngTxt(49 + dr.oread("cu_iLanguage")) + " " + EngTxt(1) + " " + EngTxt(49 + dr.cu_iLanguage), FrnTxt(32) + " " + FrnTxt(49 + dr.oread("cu_iLanguage")) + " " + FrnTxt(1) + " " + FrnTxt(49 + dr.cu_iLanguage), dr)
            If dr.oread("cu_szNotes") <> dr.cu_szNotes Then AuditAdd(AUDIT_CUSTOMER, dr.cu_iid, EngTxt(640) + " " + dr.oread("cu_szNotes") + " " + EngTxt(1) + " " + dr.cu_szNotes, FrnTxt(640) + " " + dr.oread("cu_szNotes") + " " + FrnTxt(1) + " " + dr.cu_szNotes, dr)
            If dr.oread("cu_szDisplay") <> dr.cu_szDisplay Then AuditAdd(AUDIT_CUSTOMER, dr.cu_iid, EngTxt(662) + " " + dr.oread("cu_szDisplay") + " " + EngTxt(1) + " " + dr.cu_szDisplay, FrnTxt(662) + " " + dr.oread("cu_szDisplay") + " " + FrnTxt(1) + " " + dr.cu_szDisplay, dr)
         End If
         dr.oread.Close()
      Else
         tl2 = 1
      End If

      dr.cu_dUpdate = Now

      strSQL = "CUSTOMER_UPDATE "
      strSQL += CStr(dr.cu_iid) + ", "
      strSQL += "'" + Format(dr.cu_dDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += "'" + Format(dr.cu_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.cu_COM_COMPANY) + ", "
      strSQL += "'" + AStr(dr.cu_szFirst) + "',"
      strSQL += "'" + AStr(dr.cu_szLast) + "',"
      strSQL += "'" + AStr(dr.cu_szEmail) + "',"
      strSQL += CStr(dr.cu_iVerified) + ","
      strSQL += CStr(dr.cu_iActive) + ","
      strSQL += CStr(dr.cu_iPasswordFlag) + ","
      strSQL += "'" + AStr(dr.cu_szId) + "',"
      strSQL += CStr(dr.cu_iLanguage) + ","
      strSQL += "'" + AStr(dr.cu_szNotes) + "',"
      strSQL += "'" + AStr(dr.cu_szDisplay) + "',"
      strSQL += "'" + AStr(dr.cu_szActivationCode) + "'"

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.cu_iid = 0 Then
         dr.cu_iid = CLng(rstr)
      End If
      If tl2 = 1 Then
         AuditAdd(AUDIT_CUSTOMER, dr.cu_iid, EngTxt(33) + " " + Format(dr.cu_dDate, "dd-MMM-yyyy"), FrnTxt(33) + " " + Format(dr.cu_dDate, "dd-MMM-yyyy"), dr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetCustomerRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM CUS_CUSTOMER where cu_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.cu_iid = dr.oread("cu_iid")
         dr.cu_dDate = dr.oread("cu_dDate")
         dr.cu_dUpdate = dr.oread("cu_dUpdate")
         dr.cu_COM_COMPANY = dr.oread("cu_COM_COMPANY")
         dr.cu_szFirst = dr.oread("cu_szFirst")
         dr.cu_szLast = dr.oread("cu_szLast")
         dr.cu_szEmail = dr.oread("cu_szEmail")
         dr.cu_iVerified = dr.oread("cu_iVerified")
         dr.cu_iActive = dr.oread("cu_iActive")
         dr.cu_iPasswordFlag = dr.oread("cu_iPasswordFlag")
         dr.cu_szId = dr.oread("cu_szId")
         dr.cu_iLanguage = dr.oread("cu_iLanguage")
         dr.cu_szNotes = dr.oread("cu_szNotes")
         dr.cu_szDisplay = dr.oread("cu_szDisplay")
         dr.cu_szActivationCode = dr.oread("cu_szActivationCode")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitCustomerWishlist(ByRef dr As DATA_RECORD)
      dr.cw_iid = 0
      dr.cw_dDate = Now
      dr.cw_CUS_CUSTOMER = dr.cu_iid
      dr.cw_PRO_PRODUCT = 0
      dr.cw_iOrdered = 1
      dr.cw_iQuantity = 1
   End Sub
   Public Shared Sub UpdateCustomerWishlistRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      strSQL = "CUSTOMER_WISHLIST_UPDATE "
      strSQL += CStr(dr.cw_iid) + ", "
      strSQL += "'" + Format(dr.cw_dDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.cw_CUS_CUSTOMER) + ", "
      strSQL += CStr(dr.cw_PRO_PRODUCT) + ", "
      strSQL += CStr(dr.cw_iOrdered) + ","
      strSQL += CStr(dr.cw_iQuantity) + ""

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.cw_iid = 0 Then
         dr.cw_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetCustomerWishlistRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM CUS_WISHLIST where cw_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.cw_iid = dr.oread("cw_iid")
         dr.cw_dDate = dr.oread("cw_dDate")
         dr.cw_CUS_CUSTOMER = dr.oread("cw_CUS_CUSTOMER")
         dr.cw_PRO_PRODUCT = dr.oread("cw_PRO_PRODUCT")
         dr.cw_iOrdered = dr.oread("cw_iOrdered")
         dr.cw_iQuantity = dr.oread("cw_iQuantity")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitErrorMessages(ByRef dr As DATA_RECORD)
      dr.er_iid = 0
      dr.er_szEnglish = ""
      dr.er_szFrench = ""
      dr.er_szEngReal = ""
      dr.er_szFrnReal = ""
   End Sub
   Public Shared Sub UpdateErrorMessagesRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      strSQL = "ERROR_MESSAGES_UPDATE "
      strSQL += CStr(dr.er_iid) + ", "
      strSQL += "'" + AStr("er_szEnglish") + "', "
      strSQL += "'" + AStr("er_szFrench") + "', "
      strSQL += "'" + AStr("er_szEngReal") + "', "
      strSQL += "'" + AStr("er_szFrnReal") + "'"

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.er_iid = 0 Then
         dr.er_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetErrorMessagesRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM ERR_MESSAGES where er_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.er_iid = dr.oread("er_iid")
         dr.er_szEnglish = dr.oread("er_szEnglish")
         dr.er_szFrench = dr.oread("er_szFrench")
         dr.er_szEngReal = dr.oread("er_szEngReal")
         dr.er_szFrnReal = dr.oread("er_szFrnReal")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitInvoice(ByRef dr As DATA_RECORD)
      dr.iv_iid = 0
      dr.iv_dDate = Now
      dr.iv_USR_USER = dr.sr_iid
      dr.iv_dUpdate = Now
      dr.iv_uUSR_USER = dr.sr_iid
      dr.iv_ORD_ORDERS = 0
      dr.iv_dInvoiceDate = Now
      dr.iv_szInvoiceNotes = ""
      dr.iv_iInvnum = 0
      dr.iv_iInvoiced = 0
      dr.iv_rInvoiceTotal = 0.0
      dr.iv_rTaxAmount = 0.0
      dr.iv_iTaxFree = 0
      dr.iv_rShipping = 0
      dr.iv_PRM_CODES = 0
   End Sub
   Public Shared Sub UpdateInvoiceRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      If dr.iv_iid = 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT TOP 1 iv_iInvNum FROM INV_INVOICE WHERE iv_ORD_ORDERS = " + CStr(dr.oo_iid) + " ORDER BY iv_iInvNum Desc"
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            dr.iv_iInvnum = dr.oread("iv_iInvNum") + 1
         Else
            dr.iv_iInvnum = 1
         End If
         dr.oread.Close()
      End If

      dr.iv_dUpdate = Now
      dr.iv_uUSR_USER = dr.sr_iid

      strSQL = "INVOICE_UPDATE "
      strSQL += CStr(dr.iv_iid) + ", "
      strSQL += "'" + Format(dr.iv_dDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.iv_USR_USER) + ","
      strSQL += "'" + Format(dr.iv_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.iv_uUSR_USER) + ","
      strSQL += CStr(dr.iv_ORD_ORDERS) + ","
      strSQL += "'" + Format(dr.iv_dInvoiceDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += "'" + AStr(dr.iv_szInvoiceNotes) + "',"
      strSQL += CStr(dr.iv_iInvnum) + ","
      strSQL += CStr(dr.iv_iInvoiced) + ","
      strSQL += StringFormatEnglish(14, dr.iv_rInvoiceTotal) + ","
      strSQL += StringFormatEnglish(14, dr.iv_rTaxAmount) + ","
      strSQL += CStr(dr.iv_iTaxFree) + ","
      strSQL += StringFormatEnglish(14, dr.iv_rShipping) + ","
      strSQL += CStr(dr.iv_PRM_CODES) + ""

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.iv_iid = 0 Then
         dr.iv_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetInvoiceRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM INV_INVOICE where iv_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.iv_iid = dr.oread("iv_iid")
         dr.iv_dDate = dr.oread("iv_dDate")
         dr.iv_USR_USER = dr.oread("iv_USR_USER")
         dr.iv_dUpdate = dr.oread("iv_dUpdate")
         dr.iv_uUSR_USER = dr.oread("iv_uUSR_USER")
         dr.iv_ORD_ORDERS = dr.oread("iv_ORD_ORDERS")
         dr.iv_dInvoiceDate = dr.oread("iv_dInvoiceDate")
         dr.iv_szInvoiceNotes = dr.oread("iv_szInvoiceNotes")
         dr.iv_iInvnum = dr.oread("iv_iInvnum")
         dr.iv_iInvoiced = dr.oread("iv_iInvoiced")
         dr.iv_rInvoiceTotal = dr.oread("iv_rInvoiceTotal")
         dr.iv_rTaxAmount = dr.oread("iv_rTaxAmount")
         dr.iv_iTaxFree = dr.oread("iv_iTaxFree")
         dr.iv_rShipping = dr.oread("iv_rShipping")
         dr.iv_PRM_CODES = dr.oread("iv_PRM_CODES")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitInvoiceDetail(ByRef dr As DATA_RECORD)
      dr.id_iid = 0
      dr.id_dDate = Now
      dr.id_USR_USER = dr.sr_iid
      dr.id_ORD_TRACKING_DETAIL = 0
      dr.id_INV_INVOICE = 0
      dr.id_iQuantity = 0
      dr.id_rPrice = 0
      dr.id_rInvAmount = 0
      dr.id_iTaxFree = 0
   End Sub
   Public Shared Sub UpdateInvoiceDetailRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      strSQL = "INVOICE_DETAIL_UPDATE "
      strSQL += CStr(dr.id_iid) + ", "
      strSQL += "'" + Format(dr.id_dDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.id_USR_USER) + ","
      strSQL += CStr(dr.id_ORD_TRACKING_DETAIL) + ","
      strSQL += CStr(dr.id_INV_INVOICE) + ","
      strSQL += CStr(dr.id_iQuantity) + ","
      strSQL += StringFormatEnglish(14, dr.id_rPrice) + ","
      strSQL += StringFormatEnglish(14, dr.id_rInvAmount) + ","
      strSQL += CStr(dr.id_iTaxFree) + ""

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.id_iid = 0 Then
         dr.id_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetInvoiceDetailRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM INV_DETAIL where id_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.id_iid = dr.oread("id_iid")
         dr.id_dDate = dr.oread("id_dDate")
         dr.id_USR_USER = dr.oread("id_USR_USER")
         dr.id_ORD_TRACKING_DETAIL = dr.oread("id_ORD_TRACKING_DETAIL")
         dr.id_INV_INVOICE = dr.oread("id_INV_INVOICE")
         dr.id_iQuantity = dr.oread("id_iQuantity")
         dr.id_rPrice = dr.oread("id_rPrice")
         dr.id_rInvAmount = dr.oread("id_rInvAmount")
         dr.id_iTaxFree = dr.oread("id_iTaxFree")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub NotesInits(ByRef dr As DATA_RECORD)
      dr.no_iid = 0
      dr.no_dDate = Now
      dr.no_USR_USER = dr.sr_iid
      dr.no_dUpdate = Now
      dr.no_uUSR_USER = dr.sr_iid
      dr.no_szSubject = ""
      dr.no_szDetail = ""
      dr.no_iType = dr.NOTES_TYPE
      dr.no_iKey = dr.NOTES_KEY
   End Sub
   Public Shared Sub UpdateNotesRecord(ByRef dr As DATA_RECORD)
      Dim strSQL$, rstr$

      dr.no_dUpdate = Now
      dr.no_uUSR_USER = dr.sr_iid

      strSQL = "NOTES_UPDATE "
      strSQL += CStr(dr.no_iid) + ", "
      strSQL += "'" + Format(dr.no_dDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.no_USR_USER) + ", "
      strSQL += "'" + Format(dr.no_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.no_uUSR_USER) + ", "
      strSQL += CStr(dr.no_iType) + ", "
      strSQL += CStr(dr.no_iKey) + ", "
      strSQL += "'" + AStr(dr.no_szSubject) + "', "
      strSQL += "'" + AStr(dr.no_szDetail) + "' "

      rstr = ""
      ExecuteScalar(dr.szConnection, strSQL, rstr)
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetNotesRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim rspString As String = ""
      Dim strSQL As String = "SELECT * FROM NOT_NOTES where no_iid = " + CStr(iid)
      TestConnection()
      Try
         dr.ocmd.CommandText = strSQL
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            dr.no_iid = dr.oread("no_iid")
            dr.no_dDate = dr.oread("no_dDate")
            dr.no_USR_USER = dr.oread("no_USR_USER")
            dr.no_dUpdate = dr.oread("no_dUpdate")
            dr.no_uUSR_USER = dr.oread("no_uUSR_USER")
            dr.no_iType = dr.oread("no_iType")
            dr.no_iKey = dr.oread("no_iKey")
            dr.no_szDetail = dr.oread("no_szDetail")
            dr.no_szSubject = dr.oread("no_szSubject")
         End If
      Catch ex As Exception
         rspString = ex.Message
      Finally
         dr.oread.Close()
      End Try
   End Sub
   Public Shared Sub LanguageFilterInits(ByRef dr As DATA_RECORD)
      dr.lf_iid = 0
      dr.lf_dDate = Now
      dr.lf_USR_USER = dr.sr_iid
      dr.lf_dUpdate = Now
      dr.lf_uUSR_USER = dr.sr_iid
      dr.lf_szFilter = ""
   End Sub
   Public Shared Sub UpdateLanguageFilterRecord(ByRef dr As DATA_RECORD)
      Dim strSQL$, rstr$

      dr.lf_dUpdate = Now
      dr.lf_uUSR_USER = dr.sr_iid

      strSQL = "LANGUAGE_FILTER_UPDATE "
      strSQL += CStr(dr.lf_iid) + ", "
      strSQL += CStr(dr.lf_USR_USER) + ", "
      strSQL += "'" + Format(dr.lf_dDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.lf_uUSR_USER) + ", "
      strSQL += "'" + Format(dr.lf_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += "'" + AStr(dr.lf_szFilter) + "'"

      rstr = ""
      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.lf_iid = 0 Then
         dr.lf_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetLanguageFilterRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim rspString As String = ""
      Dim strSQL As String = "SELECT * FROM LAN_FILTER where lf_iid = " + CStr(iid)
      TestConnection()
      Try
         dr.ocmd.CommandText = strSQL
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            dr.lf_iid = dr.oread("lf_iid")
            dr.lf_dDate = dr.oread("lf_dDate")
            dr.lf_USR_USER = dr.oread("lf_USR_USER")
            dr.lf_dUpdate = dr.oread("lf_dUpdate")
            dr.lf_uUSR_USER = dr.oread("lf_uUSR_USER")
            dr.lf_szFilter = dr.oread("lf_szFilter")
         End If
      Catch ex As Exception
         rspString = ex.Message
      Finally
         dr.oread.Close()
      End Try
   End Sub
   Public Shared Function OpenNotes(ByRef dr As DATA_RECORD) As String
      Dim tstr1$
      Dim rspString As String = ""
      Dim strsql$ = "select * from NOT_NOTES where no_iType = " + CStr(dr.NOTES_TYPE) + " And no_iKey = " + CStr(dr.NOTES_KEY)
      TestConnection()

      Err.Clear()
      tstr1 = ""
      dr.ocmd.CommandText = strsql
      dr.oread = dr.ocmd.ExecuteReader()
      While dr.oread.Read()
         If Err.Number > 0 Then Exit While
         tstr1 += CStr(dr.oread("no_iid")) + "^"
         tstr1 += dr.oread("no_szSubject") + "^"
         tstr1 += dr.oread("no_szDetail") + "^"
         tstr1 += DateFormat(dr.oread("no_dDate"), dr.LANG, 1) + "^"
      End While
      dr.oread.Close()
      OpenNotes = RStr(tstr1)
   End Function
   Public Shared Sub InitOrderDetail(ByRef dr As DATA_RECORD)
      dr.od_iid = 0
      dr.od_dDate = Now
      dr.od_dUpdate = Now
      dr.od_ORD_ORDERS = dr.oo_iid
      dr.od_PRO_PRODUCT = 0
      dr.od_vUSR_USER = dr.sr_iid
      dr.od_szNotes = ""
      dr.od_iStatus = 1
      dr.od_iQuantity = 1
      dr.od_iLineNumber = 0
      dr.od_rPiecePrice = 0.0
      dr.od_rWeight = 0
      dr.od_rLength = 0
      dr.od_rWidth = 0
      dr.od_rHeight = 0
      dr.od_iPackMaterial = dr.sr_iComMaterials
      dr.od_iPackaged = 0
      dr.od_rTypeDiscount = 0
   End Sub
   Public Shared Sub UpdateOrderDetailRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""
      Dim tl2& = 0
      If dr.od_iid > 0 Then
         GetProductRecord(dr.od_PRO_PRODUCT, dr)
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM ORD_DETAIL JOIN PRO_PRODUCT ON pp_iid = od_PRO_PRODUCT WHERE od_iid = " + CStr(dr.od_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If dr.oread("od_szNotes") <> dr.od_szNotes Then AuditAdd(AUDIT_ORDERS, dr.od_ORD_ORDERS, EngTxt(18) + " " + dr.oread("od_szNotes") + " " + EngTxt(1) + " " + dr.od_szNotes, FrnTxt(18) + " " + dr.oread("od_szNotes") + " " + FrnTxt(1) + " " + dr.od_szNotes, dr)
            If dr.oread("od_PRO_PRODUCT") <> dr.od_PRO_PRODUCT Then AuditAdd(AUDIT_ORDERS, dr.od_ORD_ORDERS, EngTxt(17) + " " + dr.oread("pp_szProductName") + " " + EngTxt(1) + " " + dr.pp_szProductName, FrnTxt(17) + " " + dr.oread("pp_szProductName") + " " + FrnTxt(1) + " " + dr.pp_szProductName, dr)
            'If dr.oread("od_iReturnRequested") = 1 Then
            '   If dr.oread("od_iReturnRequested") <> dr.od_iReturnRequested Then AuditAdd(AUDIT_ORDERS, dr.od_ORD_ORDERS, EngTxt(17) + " " + dr.oread("od_iReturnRequested") + " " + EngTxt(1) + " " + dr.od_iReturnRequested, FrnTxt(17) + " " + dr.oread("od_iReturnRequested") + " " + FrnTxt(1) + " " + dr.od_iReturnRequested, dr)
            'Else
            '   If dr.oread("od_iReturnRequested") <> dr.od_iReturnRequested Then AuditAdd(AUDIT_ORDERS, dr.od_ORD_ORDERS, EngTxt(17) + " " + dr.oread("od_iReturnRequested") + " " + EngTxt(1) + " " + dr.od_iReturnRequested, FrnTxt(17) + " " + dr.oread("od_iReturnRequested") + " " + FrnTxt(1) + " " + dr.od_iReturnRequested, dr)
            'End If
            'If dr.oread("od_szShipTracking") <> dr.od_szShipTracking Then AuditAdd(AUDIT_ORDERS, dr.od_ORD_ORDERS, EngTxt(641) + " " + dr.oread("od_szShipTracking") + " " + EngTxt(1) + " " + dr.od_szShipTracking, FrnTxt(641) + " " + dr.oread("od_szShipTracking") + " " + FrnTxt(1) + " " + dr.od_szShipTracking, dr)
         End If
         dr.oread.Close()
      Else
         TestConnection()
         dr.ocmd.CommandText = "SELECT od_iLineNumber FROM ORD_DETAIL JOIN ORD_ORDERS ON od_ORD_ORDERS = oo_iid WHERE oo_iid = " + CStr(dr.oo_iid)
         dr.ocmd.CommandText += " ORDER BY od_iLineNumber Desc"
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            dr.od_iLineNumber = dr.oread("od_iLineNumber") + 1
         Else
            dr.od_iLineNumber = 1
         End If
         tl2 = 1
         dr.oread.Close()
      End If

      dr.od_dUpdate = Now

      strSQL = "ORDER_DETAIL_UPDATE "
      strSQL += CStr(dr.od_iid) + ", "
      strSQL += "'" + Format(dr.od_dDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += "'" + Format(dr.od_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.od_ORD_ORDERS) + ","
      strSQL += CStr(dr.od_PRO_PRODUCT) + ","
      strSQL += CStr(dr.od_vUSR_USER) + ","
      strSQL += "'" + AStr(dr.od_szNotes) + "',"
      strSQL += CStr(dr.od_iStatus) + ","
      strSQL += CStr(dr.od_iQuantity) + ","
      strSQL += CStr(dr.od_iLineNumber) + ","
      strSQL += StringFormatEnglish(14, dr.od_rPiecePrice) + ","
      strSQL += StringFormatEnglish(24, dr.od_rWeight) + ","
      strSQL += StringFormatEnglish(23, dr.od_rLength) + ","
      strSQL += StringFormatEnglish(23, dr.od_rWidth) + ","
      strSQL += StringFormatEnglish(23, dr.od_rHeight) + ","
      strSQL += CStr(dr.od_iPackMaterial) + ","
      strSQL += CStr(dr.od_iPackaged) + ","
      strSQL += StringFormatEnglish(14, dr.od_rTypeDiscount) + ""

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.od_iid = 0 Then
         dr.od_iid = CLng(rstr)
      End If
      If tl2 = 1 Then
         AuditAdd(AUDIT_ORDERS, dr.oo_iid, EngTxt(41) + " " + Format(dr.od_dDate, "dd-MMM-yyyy"), FrnTxt(41) + " " + Format(dr.od_dDate, "dd-MMM-yyyy"), dr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub UpdateOrderDetailLineNumber(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM ORD_DETAIL WHERE od_ORD_ORDERS = " + CStr(dr.oo_iid) + " AND od_iLineNumber > " + CStr(dr.od_iLineNumber) + " ORDER BY od_iLineNumber"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         Do While dr.oread.Read()
            strSQL = "ORDER_DETAIL_UPDATE "
            strSQL += CStr(dr.oread("od_iid")) + ", "
            strSQL += "'" + Format(dr.oread("od_dDate"), "dd/MMM/yyyy HH:mm:ss") + "', "
            strSQL += "'" + Format(dr.oread("od_dUpdate"), "dd/MMM/yyyy HH:mm:ss") + "', "
            strSQL += CStr(dr.oread("od_ORD_ORDERS")) + ","
            strSQL += CStr(dr.oread("od_PRO_PRODUCT")) + ","
            strSQL += CStr(dr.oread("od_vUSR_USER")) + ","
            strSQL += "'" + AStr(dr.oread("od_szNotes")) + "',"
            strSQL += CStr(dr.oread("od_iStatus")) + ","
            strSQL += CStr(dr.oread("od_iQuantity")) + ","
            strSQL += CStr(dr.oread("od_iLineNumber") - 1) + ","
            strSQL += StringFormatEnglish(14, dr.oread("od_rPiecePrice")) + ","
            strSQL += StringFormatEnglish(24, dr.oread("od_rWeight")) + ","
            strSQL += StringFormatEnglish(23, dr.oread("od_rLength")) + ","
            strSQL += StringFormatEnglish(23, dr.oread("od_rWidth")) + ","
            strSQL += StringFormatEnglish(23, dr.oread("od_rHeight")) + ","
            strSQL += CStr(dr.oread("od_iPackMaterial")) + ","
            strSQL += CStr(dr.oread("od_iPackaged")) + ","
            strSQL += StringFormatEnglish(14, dr.oread("od_rTypeDiscount")) + ""

            dr.szRstr = ""
            ExecuteScalar(dr.szConnection, strSQL, rstr)
         Loop
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub GetOrderDetailRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM ORD_DETAIL where od_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.od_iid = dr.oread("od_iid")
         dr.od_dDate = dr.oread("od_dDate")
         dr.od_dUpdate = dr.oread("od_dUpdate")
         dr.od_ORD_ORDERS = dr.oread("od_ORD_ORDERS")
         dr.od_PRO_PRODUCT = dr.oread("od_PRO_PRODUCT")
         dr.od_vUSR_USER = dr.oread("od_vUSR_USER")
         dr.od_szNotes = dr.oread("od_szNotes")
         dr.od_iStatus = dr.oread("od_iStatus")
         dr.od_iQuantity = dr.oread("od_iQuantity")
         dr.od_iLineNumber = dr.oread("od_iLineNumber")
         dr.od_rPiecePrice = dr.oread("od_rPiecePrice")
         dr.od_rWeight = dr.oread("od_rWeight")
         dr.od_rLength = dr.oread("od_rLength")
         dr.od_rWidth = dr.oread("od_rWidth")
         dr.od_rHeight = dr.oread("od_rHeight")
         dr.od_iPackMaterial = dr.oread("od_iPackMaterial")
         dr.od_iPackaged = dr.oread("od_iPackaged")
         dr.od_rTypeDiscount = dr.oread("od_rTypeDiscount")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitOrder(ByRef dr As DATA_RECORD)
      dr.oo_iid = 0
      dr.oo_dDate = Now
      dr.oo_dUpdate = Now
      dr.oo_uUSR_USER = 0
      dr.oo_CUS_CUSTOMER = 0
      dr.oo_szNotes = ""
      dr.oo_iStatus = 1
      dr.oo_dCompleted = Now
      dr.oo_dShipped = Now
      dr.oo_dOrderDate = Now
      dr.oo_CUS_ADDRESS = 0
      dr.oo_COM_COMPANY = dr.sr_iCompany
      dr.oo_PRM_CODES = 0
   End Sub
   Public Shared Sub UpdateOrderRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""
      Dim tl2& = 0
      If dr.oo_iid > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM ORD_ORDERS WHERE oo_iid = " + CStr(dr.oo_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If dr.oread("oo_szNotes") <> dr.oo_szNotes Then AuditAdd(AUDIT_ORDERS, dr.oo_iid, EngTxt(19) + " " + dr.oread("oo_szNotes") + " " + EngTxt(1) + " " + dr.oo_szNotes, FrnTxt(19) + " " + dr.oread("oo_szNotes") + " " + FrnTxt(1) + " " + dr.oo_szNotes, dr)
         End If
         dr.oread.Close()
      Else
         tl2 = 1
      End If

      dr.oo_dUpdate = Now

      strSQL = "ORDER_UPDATE "
      strSQL += CStr(dr.oo_iid) + ", "
      strSQL += "'" + Format(dr.oo_dDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += "'" + Format(dr.oo_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.oo_uUSR_USER) + ","
      strSQL += CStr(dr.oo_CUS_CUSTOMER) + ","
      strSQL += "'" + AStr(dr.oo_szNotes) + "',"
      strSQL += CStr(dr.oo_iStatus) + ","
      strSQL += "'" + Format(dr.oo_dCompleted, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += "'" + Format(dr.oo_dShipped, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += "'" + Format(dr.oo_dOrderDate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.oo_CUS_ADDRESS) + ","
      strSQL += CStr(dr.oo_COM_COMPANY) + ","
      strSQL += CStr(dr.oo_PRM_CODES) + ""

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.oo_iid = 0 Then
         dr.oo_iid = CLng(rstr)
      End If
      If tl2 = 1 Then
         AuditAdd(AUDIT_ORDERS, dr.od_ORD_ORDERS, EngTxt(33) + " " + Format(dr.oo_dDate, "dd-MMM-yyyy"), FrnTxt(33) + " " + Format(dr.oo_dDate, "dd-MMM-yyyy"), dr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetOrderRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM ORD_ORDERS where oo_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.oo_iid = dr.oread("oo_iid")
         dr.oo_dDate = dr.oread("oo_dDate")
         dr.oo_dUpdate = dr.oread("oo_dUpdate")
         dr.oo_uUSR_USER = dr.oread("oo_uUSR_USER")
         dr.oo_CUS_CUSTOMER = dr.oread("oo_CUS_CUSTOMER")
         dr.oo_szNotes = dr.oread("oo_szNotes")
         dr.oo_iStatus = dr.oread("oo_iStatus")
         dr.oo_dCompleted = dr.oread("oo_dCompleted")
         dr.oo_dShipped = dr.oread("oo_dShipped")
         dr.oo_dOrderDate = dr.oread("oo_dOrderDate")
         dr.oo_CUS_ADDRESS = dr.oread("oo_CUS_ADDRESS")
         dr.oo_COM_COMPANY = dr.oread("oo_COM_COMPANY")
         dr.oo_PRM_CODES = dr.oread("oo_PRM_CODES")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitOrderTracking(ByRef dr As DATA_RECORD)
      dr.ot_iid = 0
      dr.ot_dDate = Now
      dr.ot_COM_BOXES = 0
      dr.ot_iShipNum = 0
      dr.ot_szTracking = ""
      dr.ot_szShipCode = ""
      dr.ot_rShipCost = 0
      dr.ot_szArtifact = ""
      dr.ot_szShipId = ""
      dr.ot_iReturned = 0
      dr.ot_iReturnRequested = 0
      dr.ot_uUSR_USER = dr.sr_iid
      dr.ot_dReturned = Now
      dr.ot_dTicketDate = Now
      dr.ot_szTicketId = ""
      dr.ot_szTicketEmail = ""
      dr.ot_szRefundReason = ""
      dr.ot_iInvoiced = 0
   End Sub
   Public Shared Sub UpdateOrderTrackingRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""


      strSQL = "ORDER_TRACKING_UPDATE "
      strSQL += CStr(dr.ot_iid) + ", "
      strSQL += "'" + Format(dr.ot_dDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.ot_COM_BOXES) + ", "
      strSQL += CStr(dr.ot_iShipNum) + ", "
      strSQL += "'" + AStr(dr.ot_szTracking) + "',"
      strSQL += "'" + AStr(dr.ot_szShipCode) + "',"
      strSQL += StringFormatEnglish(14, dr.ot_rShipCost) + ","
      strSQL += "'" + AStr(dr.ot_szArtifact) + "',"
      strSQL += "'" + AStr(dr.ot_szShipId) + "',"
      strSQL += CStr(dr.ot_iReturned) + ","
      strSQL += CStr(dr.ot_iReturnRequested) + ","
      strSQL += CStr(dr.ot_uUSR_USER) + ","
      strSQL += "'" + Format(dr.ot_dReturned, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += "'" + AStr(dr.ot_szTicketId) + "',"
      strSQL += "'" + Format(dr.ot_dTicketDate, "dd/MMM/yyyy") + "',"
      strSQL += "'" + AStr(dr.ot_szTicketEmail) + "',"
      strSQL += "'" + AStr(dr.ot_szRefundReason) + "',"
      strSQL += CStr(dr.ot_iInvoiced) + ""

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.ot_iid = 0 Then
         dr.ot_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetOrderTrackingRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM ORD_TRACKING where ot_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.ot_iid = dr.oread("ot_iid")
         dr.ot_dDate = dr.oread("ot_dDate")
         dr.ot_COM_BOXES = dr.oread("ot_COM_BOXES")
         dr.ot_iShipNum = dr.oread("ot_iShipNum")
         dr.ot_szTracking = dr.oread("ot_szTracking")
         dr.ot_szShipCode = dr.oread("ot_szShipCode")
         dr.ot_rShipCost = dr.oread("ot_rShipCost")
         dr.ot_szArtifact = dr.oread("ot_szArtifact")
         dr.ot_szShipId = dr.oread("ot_szShipId")
         dr.ot_iReturned = dr.oread("ot_iReturned")
         dr.ot_iReturnRequested = dr.oread("ot_iReturnRequested")
         dr.ot_uUSR_USER = dr.oread("ot_uUSR_USER")
         dr.ot_dReturned = dr.oread("ot_dReturned")
         dr.ot_dTicketDate = dr.oread("ot_dTicketDate")
         dr.ot_szTicketEmail = dr.oread("ot_szTicketEmail")
         dr.ot_szRefundReason = dr.oread("ot_szRefundReason")
         dr.ot_iInvoiced = dr.oread("ot_iInvoiced")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitOrderTrackingDetail(ByRef dr As DATA_RECORD)
      dr.oa_iid = 0
      dr.oa_ORD_DETAIL = 0
      dr.oa_ORD_TRACKING = 0
      dr.oa_rPrice = 0
      dr.oa_rTypeDiscount = 0
   End Sub
   Public Shared Sub UpdateOrderTrackingDetailRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      strSQL = "ORDER_TRACKING_DETAIL_UPDATE "
      strSQL += CStr(dr.oa_iid) + ", "
      strSQL += CStr(dr.oa_ORD_DETAIL) + ", "
      strSQL += CStr(dr.oa_ORD_TRACKING) + ","
      strSQL += StringFormatEnglish(14, dr.oa_rPrice) + ","
      strSQL += StringFormatEnglish(14, dr.oa_rTypeDiscount) + ""

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.oa_iid = 0 Then
         dr.oa_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetOrderTrackingDetailRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM ORD_TRACKING_DETAIL where oa_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.oa_iid = dr.oread("oa_iid")
         dr.oa_ORD_DETAIL = dr.oread("oa_ORD_DETAIL")
         dr.oa_ORD_TRACKING = dr.oread("oa_ORD_TRACKING")
         dr.oa_rPrice = dr.oread("oa_rPrice")
         dr.oa_rTypeDiscount = dr.oread("oa_rTypeDiscount")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitInvoiceShipping(ByRef dr As DATA_RECORD)
      dr.is_iid = 0
      dr.is_INV_INVOICE = 0
      dr.is_ORD_TRACKING = 0
   End Sub
   Public Shared Sub UpdateInvoiceShippingRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      strSQL = "INVOICE_SHIPPING_UPDATE "
      strSQL += CStr(dr.is_iid) + ", "
      strSQL += CStr(dr.is_INV_INVOICE) + ", "
      strSQL += CStr(dr.is_ORD_TRACKING) + ""

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.is_iid = 0 Then
         dr.is_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetInvoiceShippingRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM INV_SHIPPING where is_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.is_iid = dr.oread("is_iid")
         dr.is_INV_INVOICE = dr.oread("is_INV_INVOICE")
         dr.is_ORD_TRACKING = dr.oread("is_ORD_TRACKING")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitProductFeedback(ByRef dr As DATA_RECORD)
      dr.pf_iid = 0
      dr.pf_dDate = Now
      dr.pf_CUS_CUSTOMER = 0
      dr.pf_PRO_PRODUCT = 0
      dr.pf_iRating = 1
      dr.pf_szFeedback = ""
   End Sub
   Public Shared Sub UpdateProductFeedbackRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""
      Dim tl2& = 0

      strSQL = "PRODUCT_FEEDBACK_UPDATE "
      strSQL += CStr(dr.pf_iid) + ", "
      strSQL += "'" + Format(dr.pf_dDate, "dd/MMM/yyyy HH:mm:ss") + "', "
      strSQL += CStr(dr.pf_CUS_CUSTOMER) + ","
      strSQL += CStr(dr.pf_PRO_PRODUCT) + ","
      strSQL += CStr(dr.pf_iRating) + ","
      strSQL += "'" + AStr(dr.pf_szFeedback) + "'"

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.pf_iid = 0 Then
         dr.pf_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetProductFeedback(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM PRO_FEEDBACK where pf_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.pf_iid = dr.oread("pf_iid")
         dr.pf_dDate = dr.oread("pf_dDate")
         dr.pf_CUS_CUSTOMER = dr.oread("pf_CUS_CUSTOMER")
         dr.pf_PRO_PRODUCT = dr.oread("pf_PRO_PRODUCT")
         dr.pf_iRating = dr.oread("pf_iRating")
         dr.pf_szFeedback = dr.oread("pf_szFeedback")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitProductImage(ByRef dr As DATA_RECORD)
      dr.pi_iid = 0
      dr.pi_USR_USER = dr.sr_iid
      dr.pi_dDate = Now
      dr.pi_uUSR_USER = dr.sr_iid
      dr.pi_dUpdate = Now
      dr.pi_PRO_PRODUCT = 0
      dr.pi_szImage = ""
      dr.pi_iActive = 1
      dr.pi_iOrder = 1
      dr.pi_szTooltip = ""
   End Sub
   Public Shared Function UpdateProductImageRecord(ByRef dr As DATA_RECORD) As Boolean
      Dim oP1 As New OleDb.OleDbParameter
      Dim retVal As String, tstr1$
      Dim tl1&

      Try
         Dim rdr As FileStream = File.OpenRead(dr.pi_szImage)
         Dim tI&
         ReDim dr.bytes(rdr.Length)
         tI = rdr.Read(dr.bytes, 0, rdr.Length)
         rdr.Close()

         tstr1 = ""
         For tl1 = Len(dr.pi_szImage) To 1 Step -1
            If Mid(dr.pi_szImage, tl1, 1) = "\" Or Mid(dr.pi_szImage, tl1, 1) = "/" Or Mid(dr.pi_szImage, tl1, 1) = ":" Then
               Exit For
            Else
               tstr1 = Mid(dr.pi_szImage, tl1, 1) + tstr1
            End If
         Next

         If UBound(dr.bytes) < 10 Then
#If SFTSTORE Then
            MsgDsp(Txt(502))
#End If
            Return False
            Exit Function
         End If
         If Not Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Files") Then
            MkDir(AppDomain.CurrentDomain.BaseDirectory + "Files")
         End If
         dr.full_filename = AppDomain.CurrentDomain.BaseDirectory + "Files\" + CStr(tstr1)
         If File.Exists(dr.full_filename) Then
            Kill(dr.full_filename)
         End If

         Dim wrt As FileStream = File.OpenWrite(dr.full_filename)
         wrt.Write(dr.bytes, 0, UBound(dr.bytes) + 1)
         wrt.Close()

         If IsValidImage(dr.full_filename) = False Then
#If SFTSTORE Then
            MsgDsp(Txt(554))
#End If

            If File.Exists(dr.full_filename) Then
               Kill(dr.full_filename)
            End If
            Return False
            Exit Function
         End If
      Catch ex As Exception
#If SFTSTORE Then
         MsgDsp(Txt(502))
#End If

         Return False
         Exit Function
      End Try


      dr.pi_szImage = tstr1
      TestConnection()

      dr.pi_dUpdate = Now
      dr.pi_uUSR_USER = dr.sr_iid

      dr.ocmd.CommandType = CommandType.StoredProcedure
      dr.ocmd.CommandText = "PRODUCT_IMAGE_UPDATE"
      dr.ocmd.Parameters.Add("iID", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("USR_USER", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("dDate", OleDbType.Date)
      dr.ocmd.Parameters.Add("uUSR_USER", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("dUpdate", OleDbType.Date)
      dr.ocmd.Parameters.Add("PRO_PRODUCT", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("szImage", OleDbType.VarChar)
      dr.ocmd.Parameters.Add("bBinary", OleDbType.Binary)
      dr.ocmd.Parameters.Add("iActive", OleDbType.TinyInt)
      dr.ocmd.Parameters.Add("iOrder", OleDbType.Integer)
      dr.ocmd.Parameters.Add("szTooltip", OleDbType.VarChar)
      dr.ocmd.Parameters(0).Direction = ParameterDirection.InputOutput
      dr.ocmd.Parameters(1).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(2).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(3).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(4).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(5).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(6).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(7).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(8).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(9).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(10).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(0).Value = dr.pi_iid
      dr.ocmd.Parameters(1).Value = dr.pi_USR_USER
      dr.ocmd.Parameters(2).Value = dr.pi_dDate
      dr.ocmd.Parameters(3).Value = dr.pi_uUSR_USER
      dr.ocmd.Parameters(4).Value = dr.pi_dUpdate
      dr.ocmd.Parameters(5).Value = dr.pi_PRO_PRODUCT
      dr.ocmd.Parameters(6).Value = dr.pi_szImage
      dr.ocmd.Parameters(7).Value = dr.bytes
      dr.ocmd.Parameters(8).Value = dr.pi_iActive
      dr.ocmd.Parameters(9).Value = dr.pi_iOrder
      dr.ocmd.Parameters(10).Value = dr.pi_szTooltip
      retVal = dr.ocmd.ExecuteNonQuery()
      dr.pi_iid = dr.ocmd.Parameters(0).Value

      ConnectDatabase()
      Return True
   End Function
   Public Shared Sub UpdateProductImageOrder(ByRef dr As DATA_RECORD)
      Dim oP1 As New OleDb.OleDbParameter
      Dim retVal As String
      Dim ids$ = "", idsArray$()
      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM PRO_IMAGE WHERE pi_iOrder > " + CStr(dr.pi_iOrder) + " AND pi_PRO_PRODUCT = " + CStr(dr.pp_iid)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         Do While dr.oread.Read()
            ids += CStr(dr.oread("pi_iid")) + "|"
         Loop
      End If
      dr.oread.Close()

      idsArray = Split(ids, "|")

      For tl1 = 0 To UBound(idsArray) - 1
         GetProductImageRecord(CLng(idsArray(tl1)), dr)
         dr.pi_iOrder -= 1
         If dr.pi_iid > 0 Then
            dr.pi_dUpdate = Now
            dr.pi_uUSR_USER = dr.sr_iid

            dr.ocmd.CommandType = CommandType.StoredProcedure
            dr.ocmd.CommandText = "PRODUCT_IMAGE_UPDATE"
            dr.ocmd.Parameters.Add("iID", OleDbType.BigInt)
            dr.ocmd.Parameters.Add("USR_USER", OleDbType.BigInt)
            dr.ocmd.Parameters.Add("dDate", OleDbType.Date)
            dr.ocmd.Parameters.Add("uUSR_USER", OleDbType.BigInt)
            dr.ocmd.Parameters.Add("dUpdate", OleDbType.Date)
            dr.ocmd.Parameters.Add("PRO_PRODUCT", OleDbType.BigInt)
            dr.ocmd.Parameters.Add("szImage", OleDbType.VarChar)
            dr.ocmd.Parameters.Add("bBinary", OleDbType.Binary)
            dr.ocmd.Parameters.Add("iActive", OleDbType.TinyInt)
            dr.ocmd.Parameters.Add("iOrder", OleDbType.Integer)
            dr.ocmd.Parameters.Add("szTooltip", OleDbType.VarChar)
            dr.ocmd.Parameters(0).Direction = ParameterDirection.InputOutput
            dr.ocmd.Parameters(1).Direction = ParameterDirection.Input
            dr.ocmd.Parameters(2).Direction = ParameterDirection.Input
            dr.ocmd.Parameters(3).Direction = ParameterDirection.Input
            dr.ocmd.Parameters(4).Direction = ParameterDirection.Input
            dr.ocmd.Parameters(5).Direction = ParameterDirection.Input
            dr.ocmd.Parameters(6).Direction = ParameterDirection.Input
            dr.ocmd.Parameters(7).Direction = ParameterDirection.Input
            dr.ocmd.Parameters(8).Direction = ParameterDirection.Input
            dr.ocmd.Parameters(9).Direction = ParameterDirection.Input
            dr.ocmd.Parameters(10).Direction = ParameterDirection.Input
            dr.ocmd.Parameters(0).Value = dr.pi_iid
            dr.ocmd.Parameters(1).Value = dr.pi_USR_USER
            dr.ocmd.Parameters(2).Value = dr.pi_dDate
            dr.ocmd.Parameters(3).Value = dr.pi_uUSR_USER
            dr.ocmd.Parameters(4).Value = dr.pi_dUpdate
            dr.ocmd.Parameters(5).Value = dr.pi_PRO_PRODUCT
            dr.ocmd.Parameters(6).Value = dr.pi_szImage
            dr.ocmd.Parameters(7).Value = dr.pi_bBinary
            dr.ocmd.Parameters(8).Value = dr.pi_iActive
            dr.ocmd.Parameters(9).Value = dr.pi_iOrder
            dr.ocmd.Parameters(10).Value = dr.pi_szTooltip
            retVal = dr.ocmd.ExecuteNonQuery()
            dr.pi_iid = dr.ocmd.Parameters(0).Value
            ConnectDatabase()
         End If
      Next
   End Sub
   Public Shared Function UpdateProductImageShiftRecord(ByRef dr As DATA_RECORD) As Boolean
      Dim oP1 As New OleDb.OleDbParameter
      Dim retVal As String
      TestConnection()

      dr.pi_dUpdate = Now
      dr.pi_uUSR_USER = dr.sr_iid

      dr.ocmd.CommandType = CommandType.StoredProcedure
      dr.ocmd.CommandText = "PRODUCT_IMAGE_UPDATE"
      dr.ocmd.Parameters.Add("iID", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("USR_USER", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("dDate", OleDbType.Date)
      dr.ocmd.Parameters.Add("uUSR_USER", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("dUpdate", OleDbType.Date)
      dr.ocmd.Parameters.Add("PRO_PRODUCT", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("szImage", OleDbType.VarChar)
      dr.ocmd.Parameters.Add("bBinary", OleDbType.Binary)
      dr.ocmd.Parameters.Add("iActive", OleDbType.TinyInt)
      dr.ocmd.Parameters.Add("iOrder", OleDbType.Integer)
      dr.ocmd.Parameters.Add("szTooltip", OleDbType.VarChar)
      dr.ocmd.Parameters(0).Direction = ParameterDirection.InputOutput
      dr.ocmd.Parameters(1).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(2).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(3).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(4).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(5).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(6).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(7).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(8).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(9).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(10).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(0).Value = dr.pi_iid
      dr.ocmd.Parameters(1).Value = dr.pi_USR_USER
      dr.ocmd.Parameters(2).Value = dr.pi_dDate
      dr.ocmd.Parameters(3).Value = dr.pi_uUSR_USER
      dr.ocmd.Parameters(4).Value = dr.pi_dUpdate
      dr.ocmd.Parameters(5).Value = dr.pi_PRO_PRODUCT
      dr.ocmd.Parameters(6).Value = dr.pi_szImage
      dr.ocmd.Parameters(7).Value = dr.pi_bBinary
      dr.ocmd.Parameters(8).Value = dr.pi_iActive
      dr.ocmd.Parameters(9).Value = dr.pi_iOrder
      dr.ocmd.Parameters(10).Value = dr.pi_szTooltip
      retVal = dr.ocmd.ExecuteNonQuery()
      dr.pi_iid = dr.ocmd.Parameters(0).Value

      ConnectDatabase()
      Return True
   End Function
   Public Shared Sub GetProductImageBinary(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim rspString As String = ""
      Dim strSQL As String = "SELECT * FROM PRO_IMAGE where pi_iid = " + CStr(iid)

      TestConnection()
      Try
         dr.ocmd.CommandText = strSQL
         dr.oread = dr.ocmd.ExecuteReader
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            dr.bytes = dr.oread("pi_bBinary")
         End If
      Catch ex As Exception
         rspString = ex.Message
      Finally
         dr.oread.Close()
      End Try
   End Sub
   Public Shared Sub GetProductImageRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM PRO_IMAGE where pi_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.pi_iid = dr.oread("pi_iid")
         dr.pi_USR_USER = dr.oread("pi_USR_USER")
         dr.pi_dDate = dr.oread("pi_dDate")
         dr.pi_uUSR_USER = dr.oread("pi_uUSR_USER")
         dr.pi_dUpdate = dr.oread("pi_dUpdate")
         dr.pi_PRO_PRODUCT = dr.oread("pi_PRO_PRODUCT")
         dr.pi_szImage = dr.oread("pi_szImage")
         dr.pi_bBinary = dr.oread("pi_bBinary")
         dr.pi_iActive = dr.oread("pi_iActive")
         dr.pi_iOrder = dr.oread("pi_iOrder")
         dr.pi_szTooltip = dr.oread("pi_szTooltip")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitProductTransaction(ByRef dr As DATA_RECORD)
      dr.pn_iid = 0
      dr.pn_dDate = Now
      'dr.pn_PRO_PRODUCT = 0
      'dr.pn_iType = 1
      'dr.pn_iKey = 0
      dr.pn_iChanged = 0
      dr.pn_iRemaining = 0
      dr.pn_szDescription = ""
   End Sub
   Public Shared Sub UpdateProductTransactionRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      strSQL = "PRODUCT_TRANSACTION_UPDATE "
      strSQL += CStr(dr.pn_iid) + ", "
      strSQL += "'" + Format(dr.pn_dDate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.pn_PRO_PRODUCT) + ","
      strSQL += CStr(dr.pn_iType) + ","
      strSQL += CStr(dr.pn_iKey) + ","
      strSQL += CStr(dr.pn_iChanged) + ","
      strSQL += CStr(dr.pn_iRemaining) + ","
      strSQL += "'" + AStr(dr.pn_szDescription) + "'"

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.pn_iid = 0 Then
         dr.pn_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetProductTransactionRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM PRO_TRANSACTION where pn_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.pn_iid = dr.oread("pn_iid")
         dr.pn_dDate = dr.oread("pn_dDate")
         dr.pn_PRO_PRODUCT = dr.oread("pn_PRO_PRODUCT")
         dr.pn_iType = dr.oread("pn_iType")
         dr.pn_iKey = dr.oread("pn_iKey")
         dr.pn_iChanged = dr.oread("pn_iChanged")
         dr.pn_iRemaining = dr.oread("pn_iRemaining")
         dr.pn_szDescription = dr.oread("pn_szDescription")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitPromoCodes(ByRef dr As DATA_RECORD)
      dr.po_iid = 0
      dr.po_dDate = Now
      dr.po_USR_USER = dr.sr_iid
      dr.po_iType = 0
      dr.po_iDiscountType = 0
      dr.po_rDiscount = 0
      dr.po_szDiscount = ""
      dr.po_dStart = Now.Date
      dr.po_dEnd = Now.Date
      dr.po_COM_COMPANY = dr.sr_iCompany
      dr.po_iMinNeeded = 0
      dr.po_rTotalNeeded = 0
      dr.po_szCode = ""
   End Sub
   Public Shared Sub UpdatePromoCodesRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      strSQL = "PROMO_CODES_UPDATE "
      strSQL += CStr(dr.po_iid) + ", "
      strSQL += "'" + Format(dr.po_dDate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.po_USR_USER) + ","
      strSQL += CStr(dr.po_iType) + ","
      strSQL += CStr(dr.po_iDiscountType) + ","
      strSQL += StringFormatEnglish(14, dr.po_rDiscount) + ","
      strSQL += "'" + AStr(dr.po_szDiscount) + "',"
      strSQL += "'" + Format(dr.po_dStart, "dd/MMM/yyyy") + "',"
      strSQL += "'" + Format(dr.po_dEnd, "dd/MMM/yyyy") + "',"
      strSQL += CStr(dr.po_COM_COMPANY) + ","
      strSQL += CStr(dr.po_iMinNeeded) + ","
      strSQL += StringFormatEnglish(14, dr.po_rTotalNeeded) + ","
      strSQL += "'" + AStr(dr.po_szCode) + "'"

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.po_iid = 0 Then
         dr.po_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetPromoCodesRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM PRM_CODES where po_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.po_iid = dr.oread("po_iid")
         dr.po_dDate = dr.oread("po_dDate")
         dr.po_USR_USER = dr.oread("po_USR_USER")
         dr.po_iType = dr.oread("po_iType")
         dr.po_iDiscountType = dr.oread("po_iDiscountType")
         dr.po_rDiscount = dr.oread("po_rDiscount")
         dr.po_szDiscount = dr.oread("po_szDiscount")
         dr.po_dStart = dr.oread("po_dStart")
         dr.po_dEnd = dr.oread("po_dEnd")
         dr.po_COM_COMPANY = dr.oread("po_COM_COMPANY")
         dr.po_iMinNeeded = dr.oread("po_iMinNeeded")
         dr.po_rTotalNeeded = dr.oread("po_rTotalNeeded")
         dr.po_szCode = dr.oread("po_szCode")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitProductPrice(ByRef dr As DATA_RECORD)
      dr.pr_iid = 0
      dr.pr_USR_USER = dr.sr_iid
      dr.pr_dDate = Now
      dr.pr_uUSR_USER = dr.sr_iid
      dr.pr_dUpdate = Now
      dr.pr_PRO_PRODUCT = 0
      dr.pr_rPrice = 0.0
      dr.pr_iStatus = 2
      dr.pr_dSpecialStart = Now
      dr.pr_dSpecialEnd = Now
   End Sub
   Public Shared Sub UpdateProductPriceRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      dr.pr_dUpdate = Now
      dr.pr_uUSR_USER = dr.sr_iid

      strSQL = "PRODUCT_PRICE_UPDATE "
      strSQL += CStr(dr.pr_iid) + ", "
      strSQL += CStr(dr.pr_USR_USER) + ","
      strSQL += "'" + Format(dr.pr_dDate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.pr_uUSR_USER) + ","
      strSQL += "'" + Format(dr.pr_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.pr_PRO_PRODUCT) + ","
      strSQL += StringFormatEnglish(14, dr.pr_rPrice) + ","
      strSQL += CStr(dr.pr_iStatus) + ","
      strSQL += "'" + Format(dr.pr_dSpecialStart, "dd/MMM/yyyy") + "',"
      strSQL += "'" + Format(dr.pr_dSpecialEnd, "dd/MMM/yyyy") + "'"

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.pr_iid = 0 Then
         dr.pr_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetProductPriceRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM PRO_PRICE where pr_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.pr_iid = dr.oread("pr_iid")
         dr.pr_USR_USER = dr.oread("pr_USR_USER")
         dr.pr_dDate = dr.oread("pr_dDate")
         dr.pr_uUSR_USER = dr.oread("pr_uUSR_USER")
         dr.pr_dUpdate = dr.oread("pr_dUpdate")
         dr.pr_PRO_PRODUCT = dr.oread("pr_PRO_PRODUCT")
         dr.pr_rPrice = dr.oread("pr_rPrice")
         dr.pr_iStatus = dr.oread("pr_iStatus")
         dr.pr_dSpecialStart = dr.oread("pr_dSpecialStart")
         dr.pr_dSpecialEnd = dr.oread("pr_dSpecialEnd")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitProductPriceChanges(ByRef dr As DATA_RECORD)
      dr.pc_iid = 0
      dr.pc_USR_USER = dr.sr_iid
      dr.pc_dDate = Now
      dr.pc_PRO_PRODUCT = 0
      dr.pc_szReason = ""
      dr.pc_rNewPrice = 0.0
      dr.pc_rOldPrice = 0.0
   End Sub
   Public Shared Sub UpdateProductPriceChangesRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      strSQL = "PRODUCT_PRICE_CHANGES_UPDATE "
      strSQL += CStr(dr.pc_iid) + ", "
      strSQL += "'" + Format(dr.pc_dDate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.pc_USR_USER) + ","
      strSQL += CStr(dr.pc_PRO_PRODUCT) + ","
      strSQL += "'" + AStr(dr.pc_szReason) + "',"
      strSQL += StringFormatEnglish(14, dr.pc_rNewPrice) + ","
      strSQL += StringFormatEnglish(14, dr.pc_rOldPrice) + ""

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      'If dr.pc_iid = 0 Then
      '   dr.pc_iid = CLng(rstr)
      'End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetProductPriceChangesRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM PRO_PRICE_CHANGES where pc_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.pc_iid = dr.oread("pc_iid")
         dr.pc_USR_USER = dr.oread("pc_USR_USER")
         dr.pc_dDate = dr.oread("pc_dDate")
         dr.pc_PRO_PRODUCT = dr.oread("pc_PRO_PRODUCT")
         dr.pc_szReason = dr.oread("pc_szReason")
         dr.pc_rNewPrice = dr.oread("pc_rNewPrice")
         dr.pc_rOldPrice = dr.oread("pc_rOldPrice")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitProduct(ByRef dr As DATA_RECORD)
      dr.pp_iid = 0
      dr.pp_USR_USER = dr.sr_iid
      dr.pp_dDate = Now
      dr.pp_uUSR_USER = dr.sr_iid
      dr.pp_dUpdate = Now
      dr.pp_COM_COMPANY = dr.sr_iCompany
      dr.pp_PRO_TYPE = 0
      dr.pp_szProductNumber = ""
      dr.pp_iActive = 1
      dr.pp_szProductName = ""
      dr.pp_szProductDesc = ""
      dr.pp_szProductDesc2 = ""
      dr.pp_iSpecial = 2
      dr.pp_szSpecialDesc = ""
      dr.pp_szDetails = ""
      dr.pp_dEntry = Now
      dr.pp_rWeight = 0
      dr.pp_rLength = 0
      dr.pp_rWidth = 0
      dr.pp_rHeight = 0
      dr.pp_COM_ADDRESS = 0
      dr.pp_iPackaged = 1
      dr.pp_iPackMaterials = dr.sr_iComMaterials
      dr.pp_iPackedSolo = 1
      dr.pp_COM_BOXES = 0
      dr.pp_szSKU = ""
      dr.pp_iTaxFree = 0
   End Sub
   Public Shared Sub UpdateProductRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""
      Dim tl2& = 0
      If dr.pp_iid > 0 Then
         GetProductTypeRecord(dr.pp_PRO_TYPE, dr)
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM PRO_PRODUCT JOIN PRO_TYPE ON pt_iid = pp_PRO_TYPE WHERE pp_iid = " + CStr(dr.pp_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If dr.oread("pp_PRO_TYPE") <> dr.pp_PRO_TYPE Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(23) + " " + dr.oread("pt_szTypeName") + " " + EngTxt(1) + " " + dr.pt_szTypeName, FrnTxt(23) + " " + dr.oread("pt_szTypeName") + " " + FrnTxt(1) + " " + dr.pt_szTypeName, dr)
            If dr.oread("pp_iActive") <> dr.pp_iActive Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(23) + " " + EngTxt(35 + dr.oread("pp_iActive")) + " " + EngTxt(1) + " " + EngTxt(35 + dr.pp_iActive), FrnTxt(23) + " " + FrnTxt(35 + dr.oread("pp_iActive")) + " " + FrnTxt(1) + " " + FrnTxt(35 + dr.pp_iActive), dr)
            If dr.oread("pp_szProductName") <> dr.pp_szProductName Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(24) + " " + dr.oread("pp_szProductName") + " " + EngTxt(1) + " " + dr.pp_szProductName, FrnTxt(24) + " " + dr.oread("pp_szProductName") + " " + FrnTxt(1) + " " + dr.pp_szProductName, dr)
            If dr.oread("pp_szProductDesc") <> dr.pp_szProductDesc Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(25) + " " + dr.oread("pp_szProductDesc") + " " + EngTxt(1) + " " + dr.pp_szProductDesc, FrnTxt(25) + " " + dr.oread("pp_szProductDesc") + " " + FrnTxt(1) + " " + dr.pp_szProductDesc, dr)
            If dr.oread("pp_szProductDesc2") <> dr.pp_szProductDesc2 Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(26) + " " + dr.oread("pp_szProductDesc2") + " " + EngTxt(1) + " " + dr.pp_szProductDesc2, FrnTxt(26) + " " + dr.oread("pp_szProductDesc2") + " " + FrnTxt(1) + " " + dr.pp_szProductDesc2, dr)
            If dr.oread("pp_iSpecial") <> dr.pp_iSpecial Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(27) + " " + EngTxt(35 + dr.oread("pp_iSpecial")) + " " + EngTxt(1) + " " + EngTxt(35 + dr.pp_iSpecial), FrnTxt(27) + " " + FrnTxt(35 + dr.oread("pp_iSpecial")) + " " + FrnTxt(1) + " " + FrnTxt(35 + dr.pp_iSpecial), dr)
            If dr.oread("pp_szSpecialDesc") <> dr.pp_szSpecialDesc Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(28) + " " + dr.oread("pp_szSpecialDesc") + " " + EngTxt(1) + " " + dr.pp_szSpecialDesc, FrnTxt(28) + " " + dr.oread("pp_szSpecialDesc") + " " + FrnTxt(1) + " " + dr.pp_szSpecialDesc, dr)
            If dr.oread("pp_szDetails") <> dr.pp_szDetails Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(29) + " " + dr.oread("pp_szDetails") + " " + EngTxt(1) + " " + dr.pp_szDetails, FrnTxt(29) + " " + dr.oread("pp_szDetails") + " " + FrnTxt(1) + " " + dr.pp_szDetails, dr)
            If dr.oread("pp_szProductNumber") <> dr.pp_szProductNumber Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(534) + " " + dr.oread("pp_szProductNumber") + " " + EngTxt(1) + " " + dr.pp_szProductNumber, FrnTxt(534) + " " + dr.oread("pp_szProductNumber") + " " + FrnTxt(1) + " " + dr.pp_szProductNumber, dr)
            If dr.oread("pp_rWeight") <> dr.pp_rWeight Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(534) + " " + StringFormatEnglish(8, dr.oread("pp_rWeight")) + " " + EngTxt(1) + " " + StringFormatEnglish(8, dr.pp_rWeight), FrnTxt(534) + " " + StringFormatEnglish(8, dr.oread("pp_rWeight")) + " " + FrnTxt(1) + " " + StringFormatEnglish(8, dr.pp_rWeight), dr)
            If dr.oread("pp_rLength") <> dr.pp_rLength Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(733) + " " + StringFormatEnglish(23, dr.oread("pp_rLength")) + " " + EngTxt(1) + " " + StringFormatEnglish(23, dr.pp_rLength), FrnTxt(733) + " " + StringFormatEnglish(23, dr.oread("pp_rLength")) + " " + FrnTxt(1) + " " + StringFormatEnglish(23, dr.pp_rLength), dr)
            If dr.oread("pp_rWidth") <> dr.pp_rWidth Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(734) + " " + StringFormatEnglish(23, dr.oread("pp_rWidth")) + " " + EngTxt(1) + " " + StringFormatEnglish(23, dr.pp_rWidth), FrnTxt(734) + " " + StringFormatEnglish(23, dr.oread("pp_rWidth")) + " " + FrnTxt(1) + " " + StringFormatEnglish(23, dr.pp_rWidth), dr)
            If dr.oread("pp_rHeight") <> dr.pp_rHeight Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(735) + " " + StringFormatEnglish(23, dr.oread("pp_rHeight")) + " " + EngTxt(1) + " " + StringFormatEnglish(23, dr.pp_rHeight), FrnTxt(735) + " " + StringFormatEnglish(23, dr.oread("pp_rHeight")) + " " + FrnTxt(1) + " " + StringFormatEnglish(23, dr.pp_rHeight), dr)
            If dr.oread("pp_iPackMaterials") <> dr.pp_iPackMaterials Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(771) + " " + CStr(dr.oread("pp_iPackMaterials")) + "% " + EngTxt(1) + " " + CStr(dr.pp_iPackMaterials) + "%", FrnTxt(771) + " " + CStr(dr.oread("pp_iPackMaterials")) + "% " + FrnTxt(1) + " " + CStr(dr.pp_iPackMaterials) + "%", dr)
            If dr.oread("pp_szSKU") <> dr.pp_szSKU Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(797) + " " + dr.oread("pp_szSKU") + " " + EngTxt(1) + " " + dr.pp_szSKU, FrnTxt(797) + " " + dr.oread("pp_szSKU") + " " + FrnTxt(1) + " " + dr.pp_szSKU, dr)
            If dr.pp_iTaxFree = 0 Then
               If dr.oread("pp_iTaxFree") <> dr.pp_iTaxFree Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(835) + " " + EngTxt(36) + " " + EngTxt(1) + " " + EngTxt(37), FrnTxt(835) + " " + FrnTxt(36) + " " + FrnTxt(1) + " " + FrnTxt(37), dr)
            Else
               If dr.oread("pp_iTaxFree") <> dr.pp_iTaxFree Then AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(835) + " " + EngTxt(37) + " " + EngTxt(1) + " " + EngTxt(36), FrnTxt(835) + " " + FrnTxt(37) + " " + FrnTxt(1) + " " + FrnTxt(36), dr)
            End If
         End If
         dr.oread.Close()
      Else
         tl2 = 1
      End If

      dr.pp_dUpdate = Now
      dr.pp_uUSR_USER = dr.sr_iid

      strSQL = "PRODUCT_UPDATE "
      strSQL += CStr(dr.pp_iid) + ", "
      strSQL += CStr(dr.pp_USR_USER) + ","
      strSQL += "'" + Format(dr.pp_dDate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.pp_uUSR_USER) + ","
      strSQL += "'" + Format(dr.pp_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.pp_COM_COMPANY) + ","
      strSQL += CStr(dr.pp_PRO_TYPE) + ","
      strSQL += "'" + AStr(dr.pp_szProductNumber) + "',"
      strSQL += CStr(dr.pp_iActive) + ","
      strSQL += "'" + AStr(dr.pp_szProductName) + "',"
      strSQL += "'" + AStr(dr.pp_szProductDesc) + "',"
      strSQL += "'" + AStr(dr.pp_szProductDesc2) + "',"
      strSQL += CStr(dr.pp_iSpecial) + ","
      strSQL += "'" + AStr(dr.pp_szSpecialDesc) + "',"
      strSQL += "'" + AStr(dr.pp_szDetails) + "',"
      strSQL += "'" + Format(dr.pp_dEntry, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += StringFormatEnglish(24, dr.pp_rWeight) + ","
      strSQL += StringFormatEnglish(23, dr.pp_rLength) + ","
      strSQL += StringFormatEnglish(23, dr.pp_rWidth) + ","
      strSQL += StringFormatEnglish(23, dr.pp_rHeight) + ","
      strSQL += CStr(dr.pp_COM_ADDRESS) + ","
      strSQL += CStr(dr.pp_iPackaged) + ","
      strSQL += CStr(dr.pp_iPackMaterials) + ","
      strSQL += CStr(dr.pp_iPackedSolo) + ","
      strSQL += CStr(dr.pp_COM_BOXES) + ","
      strSQL += "'" + AStr(dr.pp_szSKU) + "',"
      strSQL += CStr(dr.pp_iTaxFree) + ""

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.pp_iid = 0 Then
         dr.pp_iid = CLng(rstr)
      End If
      If tl2 = 1 Then
         AuditAdd(AUDIT_PRODUCT, dr.pp_iid, EngTxt(33) + " " + Format(dr.pp_dDate, "dd-MMM-yyyy"), FrnTxt(33) + " " + Format(dr.pp_dDate, "dd-MMM-yyyy"), dr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetProductRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM PRO_PRODUCT where pp_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.pp_iid = dr.oread("pp_iid")
         dr.pp_USR_USER = dr.oread("pp_USR_USER")
         dr.pp_dDate = dr.oread("pp_dDate")
         dr.pp_uUSR_USER = dr.oread("pp_uUSR_USER")
         dr.pp_dUpdate = dr.oread("pp_dUpdate")
         dr.pp_COM_COMPANY = dr.oread("pp_COM_COMPANY")
         dr.pp_PRO_TYPE = dr.oread("pp_PRO_TYPE")
         dr.pp_szProductNumber = dr.oread("pp_szProductNumber")
         dr.pp_iActive = dr.oread("pp_iActive")
         dr.pp_szProductName = dr.oread("pp_szProductName")
         dr.pp_szProductDesc = dr.oread("pp_szProductDesc")
         dr.pp_szProductDesc2 = dr.oread("pp_szProductDesc2")
         dr.pp_iSpecial = dr.oread("pp_iSpecial")
         dr.pp_szSpecialDesc = dr.oread("pp_szSpecialDesc")
         dr.pp_szDetails = dr.oread("pp_szDetails")
         dr.pp_dEntry = dr.oread("pp_dEntry")
         dr.pp_rWeight = dr.oread("pp_rWeight")
         dr.pp_rLength = dr.oread("pp_rLength")
         dr.pp_rWidth = dr.oread("pp_rWidth")
         dr.pp_rHeight = dr.oread("pp_rHeight")
         dr.pp_COM_ADDRESS = dr.oread("pp_COM_ADDRESS")
         dr.pp_iPackaged = dr.oread("pp_iPackaged")
         dr.pp_iPackMaterials = dr.oread("pp_iPackMaterials")
         dr.pp_iPackedSolo = dr.oread("pp_iPackedSolo")
         dr.pp_COM_BOXES = dr.oread("pp_COM_BOXES")
         dr.pp_szSKU = dr.oread("pp_szSKU")
         dr.pp_iTaxFree = dr.oread("pp_iTaxFree")
      Else
         InitProduct(dr)
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitProductSubType(ByRef dr As DATA_RECORD)
      dr.ps_iid = 0
      dr.ps_USR_USER = dr.sr_iid
      dr.ps_dDate = Now
      dr.ps_uUSR_USER = dr.sr_iid
      dr.ps_dUpdate = Now
      dr.ps_PRO_TYPE = 0
      dr.ps_szName = ""
   End Sub
   Public Shared Sub UpdateProductSubTypeRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      dr.ps_uUSR_USER = dr.sr_iid
      dr.ps_dUpdate = Now

      strSQL = "PRODUCT_SUB_TYPE_UPDATE "
      strSQL += CStr(dr.ps_iid) + ", "
      strSQL += CStr(dr.ps_USR_USER) + ","
      strSQL += "'" + Format(dr.ps_dDate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.ps_uUSR_USER) + ","
      strSQL += "'" + Format(dr.ps_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.ps_PRO_TYPE) + ","
      strSQL += "'" + AStr(dr.ps_szName) + "'"

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.ps_iid = 0 Then
         dr.ps_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetProductSubTypeRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM PRO_SUB_TYPE where ps_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.ps_iid = dr.oread("ps_iid")
         dr.ps_USR_USER = dr.oread("ps_USR_USER")
         dr.ps_dDate = dr.oread("ps_dDate")
         dr.ps_uUSR_USER = dr.oread("ps_uUSR_USER")
         dr.ps_dUpdate = dr.oread("ps_dUpdate")
         dr.ps_PRO_TYPE = dr.oread("ps_PRO_TYPE")
         dr.ps_szName = dr.oread("ps_szName")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitProductType(ByRef dr As DATA_RECORD)
      dr.pt_iid = 0
      dr.pt_USR_USER = dr.sr_iid
      dr.pt_dDate = Now
      dr.pt_uUSR_USER = dr.sr_iid
      dr.pt_dUpdate = Now
      dr.pt_COM_COMPANY = dr.sr_iCompany
      dr.pt_iType = 0
      dr.pt_szTypeName = ""
      dr.pt_iSpecial = 1
      dr.pt_szSpecialDesc = ""
      dr.pt_rSpecialPercent = 0.0
      dr.pt_dSpecialStart = Now
      dr.pt_dSpecialEnd = Now
   End Sub
   Public Shared Sub UpdateProductTypeRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""


      TestConnection()
      dr.ocmd.CommandText = "SELECT top 1 pt_iType FROM PRO_TYPE WHERE pt_COM_COMPANY = " + CStr(dr.sr_iCompany) + " ORDER BY pt_iType Desc"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         If dr.pt_iid = 0 Then
            dr.pt_iType = dr.oread("pt_iType") + 1
         End If
      Else
         dr.pt_iType = 1
      End If
      dr.oread.Close()

      dr.pt_uUSR_USER = dr.sr_iid
      dr.pt_dUpdate = Now

      strSQL = "PRODUCT_TYPE_UPDATE "
      strSQL += CStr(dr.pt_iid) + ", "
      strSQL += CStr(dr.pt_USR_USER) + ","
      strSQL += "'" + Format(dr.pt_dDate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.pt_uUSR_USER) + ","
      strSQL += "'" + Format(dr.pt_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.pt_COM_COMPANY) + ","
      strSQL += CStr(dr.pt_iType) + ","
      strSQL += "'" + AStr(dr.pt_szTypeName) + "',"
      strSQL += CStr(dr.pt_iSpecial) + ","
      strSQL += "'" + AStr(dr.pt_szSpecialDesc) + "',"
      strSQL += StringFormatEnglish(14, dr.pt_rSpecialPercent) + ","
      strSQL += "'" + Format(dr.pt_dSpecialStart, "dd/MMM/yyyy") + "',"
      strSQL += "'" + Format(dr.pt_dSpecialEnd, "dd/MMM/yyyy") + "'"

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.pt_iid = 0 Then
         dr.pt_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetProductTypeRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM PRO_TYPE where pt_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.pt_iid = dr.oread("pt_iid")
         dr.pt_USR_USER = dr.oread("pt_USR_USER")
         dr.pt_dDate = dr.oread("pt_dDate")
         dr.pt_uUSR_USER = dr.oread("pt_uUSR_USER")
         dr.pt_dUpdate = dr.oread("pt_dUpdate")
         dr.pt_COM_COMPANY = dr.oread("pt_COM_COMPANY")
         dr.pt_iType = dr.oread("pt_iType")
         dr.pt_szTypeName = dr.oread("pt_szTypeName")
         dr.pt_iSpecial = dr.oread("pt_iSpecial")
         dr.pt_szSpecialDesc = dr.oread("pt_szSpecialDesc")
         dr.pt_rSpecialPercent = dr.oread("pt_rSpecialPercent")
         dr.pt_dSpecialStart = dr.oread("pt_dSpecialStart")
         dr.pt_dSpecialEnd = dr.oread("pt_dSpecialEnd")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitProductSubTypes(ByRef dr As DATA_RECORD)
      dr.py_iid = 0
      dr.py_USR_USER = dr.sr_iid
      dr.py_dDate = Now
      dr.py_PRO_PRODUCT = 0
      dr.py_PRO_SUB_TYPE = 0
   End Sub
   Public Shared Sub UpdateProductSubTypesRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      strSQL = "PRODUCT_TYPES_UPDATE "
      strSQL += CStr(dr.py_iid) + ", "
      strSQL += CStr(dr.py_USR_USER) + ","
      strSQL += "'" + Format(dr.py_dDate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.py_PRO_PRODUCT) + ","
      strSQL += CStr(dr.py_PRO_SUB_TYPE) + ""

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.py_iid = 0 Then
         dr.py_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetProductSubTypesRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM PRO_PRODUCT_TYPES where py_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.py_iid = dr.oread("py_iid")
         dr.py_USR_USER = dr.oread("py_USR_USER")
         dr.py_dDate = dr.oread("py_dDate")
         dr.py_PRO_PRODUCT = dr.oread("py_PRO_PRODUCT")
         dr.py_PRO_SUB_TYPE = dr.oread("py_PRO_SUB_TYPE")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitSystem(ByRef dr As DATA_RECORD)
      dr.ss_iid = 0
      dr.ss_iTax1 = 0
      dr.ss_szTax1 = ""
      dr.ss_rTax1 = 0
      dr.ss_iTax2 = 0
      dr.ss_szTax2 = ""
      dr.ss_rTax2 = 0
   End Sub
   Public Shared Sub UpdateSystemRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""

      strSQL = "SYSTEM_UPDATE "
      strSQL += CStr(dr.ss_iid) + ", "
      strSQL += CStr(dr.ss_iTax1) + ","
      strSQL += "'" + AStr(dr.ss_szTax1) + "',"
      strSQL += StringFormatEnglish(14, dr.ss_rTax1) + ","
      strSQL += CStr(dr.ss_iTax2) + ","
      strSQL += "'" + AStr(dr.ss_szTax2) + "',"
      strSQL += StringFormatEnglish(14, dr.ss_rTax2) + ""


      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.ss_iid = 0 Then
         dr.ss_iid = CLng(rstr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetSystemRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM SYS_SYSTEM where ss_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.ss_iid = dr.oread("ss_iid")
         dr.ss_iTax1 = dr.oread("ss_iTax1")
         dr.ss_szTax1 = dr.oread("ss_szTax1")
         dr.ss_rTax1 = dr.oread("ss_rTax1")
         dr.ss_iTax2 = dr.oread("ss_iTax2")
         dr.ss_szTax2 = dr.oread("ss_szTax2")
         dr.ss_rTax2 = dr.oread("ss_rTax2")
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub InitUser(ByRef dr As DATA_RECORD)
      dr.uu_iid = 0
      dr.uu_USR_USER = dr.sr_iid
      dr.uu_dDate = Now
      dr.uu_uUSR_USER = dr.sr_iid
      dr.uu_dUpdate = Now
      dr.uu_COM_COMPANY = dr.sr_iCompany
      dr.uu_szCompany = ""
      dr.uu_szFirst = ""
      dr.uu_szLast = ""
      dr.uu_szEmail = ""
      dr.uu_szPhone = ""
      dr.uu_szCell = ""
      dr.uu_szAddr1 = ""
      dr.uu_szAddr2 = ""
      dr.uu_szCity = ""
      dr.uu_iProvince = 1
      dr.uu_iCountry = 1
      dr.uu_szPostal = ""
      dr.uu_iPasswordFlag = 1
      dr.uu_szId = ""
      dr.uu_iLanguage = ENGLISH
      dr.uu_iRlanguage = ENGLISH
      dr.uu_iActive = 1
   End Sub
   Public Shared Sub UpdateUserRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String
      Dim rstr$
      strSQL = ""
      rstr = ""
      Dim tl2& = 0
      If dr.uu_iid > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM USR_USER WHERE uu_iid = " + CStr(dr.uu_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If dr.oread("uu_szEmail") <> dr.uu_szEmail Then AuditAdd(AUDIT_USER, dr.uu_iid, EngTxt(3) + " " + dr.oread("uu_szEmail") + " " + EngTxt(1) + " " + dr.uu_szEmail, FrnTxt(3) + " " + dr.oread("uu_szEmail") + " " + FrnTxt(1) + " " + dr.uu_szEmail, dr)
            If dr.oread("uu_szPhone") <> dr.uu_szPhone Then AuditAdd(AUDIT_USER, dr.uu_iid, EngTxt(4) + " " + dr.oread("uu_szPhone") + " " + EngTxt(1) + " " + dr.uu_szPhone, FrnTxt(4) + " " + dr.oread("uu_szPhone") + " " + FrnTxt(1) + " " + dr.uu_szPhone, dr)
            If dr.oread("uu_szCell") <> dr.uu_szCell Then AuditAdd(AUDIT_USER, dr.uu_iid, EngTxt(30) + " " + dr.oread("uu_szCell") + " " + EngTxt(1) + " " + dr.uu_szCell, FrnTxt(30) + " " + dr.oread("uu_szCell") + " " + FrnTxt(1) + " " + dr.uu_szCell, dr)
            If dr.oread("uu_iPasswordFlag") <> dr.uu_iPasswordFlag Then AuditAdd(AUDIT_USER, dr.uu_iid, EngTxt(15) + " " + EngTxt(37 + dr.oread("uu_iPasswordFlag")) + " " + EngTxt(1) + " " + EngTxt(37 + dr.uu_iPasswordFlag), FrnTxt(3) + " " + FrnTxt(37 + dr.oread("uu_iPasswordFlag")) + " " + FrnTxt(1) + " " + FrnTxt(37 + dr.uu_iPasswordFlag), dr)
            If dr.oread("uu_szId") <> dr.uu_szId Then AuditAdd(AUDIT_USER, dr.uu_iid, EngTxt(16) + " " + dr.oread("uu_szId") + " " + EngTxt(1) + " " + dr.uu_szId, FrnTxt(16) + " " + dr.oread("uu_szId") + " " + FrnTxt(1) + " " + dr.uu_szId, dr)
            If dr.oread("uu_iActive") <> dr.uu_iActive Then AuditAdd(AUDIT_USER, dr.uu_iid, EngTxt(14) + " " + EngTxt(35 + dr.oread("uu_iActive")) + " " + EngTxt(1) + " " + EngTxt(35 + dr.uu_iActive), FrnTxt(14) + " " + FrnTxt(35 + dr.oread("uu_iActive")) + " " + FrnTxt(1) + " " + FrnTxt(35 + dr.uu_iActive), dr)
            If dr.oread("uu_iLanguage") <> dr.uu_iLanguage Then AuditAdd(AUDIT_USER, dr.uu_iid, EngTxt(32) + " " + EngTxt(49 + dr.oread("uu_iLanguage")) + " " + EngTxt(1) + " " + EngTxt(49 + dr.uu_iLanguage), FrnTxt(32) + " " + FrnTxt(49 + dr.oread("uu_iLanguage")) + " " + FrnTxt(1) + " " + FrnTxt(49 + dr.uu_iLanguage), dr)
            If dr.oread("uu_szAddr1") <> dr.uu_szAddr1 Then AuditAdd(AUDIT_USER, dr.uu_iid, EngTxt(5) + " " + dr.oread("uu_szAddr1") + " " + EngTxt(1) + " " + dr.uu_szAddr1, FrnTxt(5) + " " + dr.oread("uu_szAddr1") + " " + FrnTxt(1) + " " + dr.uu_szAddr1, dr)
            If dr.oread("uu_szAddr2") <> dr.uu_szAddr2 Then AuditAdd(AUDIT_USER, dr.uu_iid, EngTxt(6) + " " + dr.oread("uu_szAddr2") + " " + EngTxt(1) + " " + dr.uu_szAddr2, FrnTxt(6) + " " + dr.oread("uu_szAddr2") + " " + FrnTxt(1) + " " + dr.uu_szAddr2, dr)
            If dr.oread("uu_szCity") <> dr.uu_szCity Then AuditAdd(AUDIT_USER, dr.uu_iid, EngTxt(7) + " " + dr.oread("uu_szCity") + " " + EngTxt(1) + " " + dr.uu_szCity, FrnTxt(7) + " " + dr.oread("uu_szCity") + " " + FrnTxt(1) + " " + dr.uu_szCity, dr)
            If dr.oread("uu_szPostal") <> dr.uu_szPostal Then AuditAdd(AUDIT_USER, dr.uu_iid, EngTxt(8) + " " + dr.oread("uu_szPostal") + " " + EngTxt(1) + " " + dr.uu_szPostal, FrnTxt(8) + " " + dr.oread("uu_szPostal") + " " + FrnTxt(1) + " " + dr.uu_szPostal, dr)
            If dr.oread("uu_szCompany") <> dr.uu_szCompany Then AuditAdd(AUDIT_USER, dr.uu_iid, EngTxt(2) + " " + dr.oread("uu_szCompany") + " " + EngTxt(1) + " " + dr.uu_szCompany, FrnTxt(2) + " " + dr.oread("uu_szCompany") + " " + FrnTxt(1) + " " + dr.uu_szCompany, dr)
         End If
         dr.oread.Close()
      Else
         tl2 = 1
      End If

      dr.uu_dUpdate = Now
      dr.uu_uUSR_USER = dr.sr_iid

      strSQL = "USER_UPDATE "
      strSQL += CStr(dr.uu_iid) + ", "
      strSQL += CStr(dr.uu_USR_USER) + ","
      strSQL += "'" + Format(dr.uu_dDate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.uu_uUSR_USER) + ","
      strSQL += "'" + Format(dr.uu_dUpdate, "dd/MMM/yyyy HH:mm:ss") + "',"
      strSQL += CStr(dr.uu_COM_COMPANY) + ","
      strSQL += "'" + AStr(dr.uu_szCompany) + "',"
      strSQL += "'" + AStr(dr.uu_szFirst) + "',"
      strSQL += "'" + AStr(dr.uu_szLast) + "',"
      strSQL += "'" + AStr(dr.uu_szEmail) + "',"
      strSQL += "'" + AStr(dr.uu_szPhone) + "',"
      strSQL += "'" + AStr(dr.uu_szCell) + "',"
      strSQL += "'" + AStr(dr.uu_szAddr1) + "',"
      strSQL += "'" + AStr(dr.uu_szAddr2) + "',"
      strSQL += "'" + AStr(dr.uu_szCity) + "',"
      strSQL += CStr(dr.uu_iProvince) + ","
      strSQL += CStr(dr.uu_iCountry) + ","
      strSQL += "'" + AStr(dr.uu_szPostal) + "',"
      strSQL += CStr(dr.uu_iPasswordFlag) + ","
      strSQL += "'" + AStr(dr.uu_szId) + "',"
      strSQL += CStr(dr.uu_iActive) + ","
      strSQL += CStr(dr.uu_iLanguage) + ","
      strSQL += CStr(dr.uu_iRlanguage) + ""

      ExecuteScalar(dr.szConnection, strSQL, rstr)
      If dr.uu_iid = 0 Then
         dr.uu_iid = CLng(rstr)
      End If
      If tl2 = 1 Then
         AuditAdd(AUDIT_USER, dr.uu_iid, EngTxt(33) + " " + Format(dr.uu_dDate, "dd-MMM-yyyy"), FrnTxt(33) + " " + Format(dr.uu_dDate, "dd-MMM-yyyy"), dr)
      End If
      dr.szRstr = rstr
   End Sub
   Public Shared Sub GetUserRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      Dim strSql As String = "SELECT * FROM USR_USER where uu_iid = " + CStr(iid)
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.uu_iid = dr.oread("uu_iid")
         dr.uu_USR_USER = dr.oread("uu_USR_USER")
         dr.uu_dDate = dr.oread("uu_dDate")
         dr.uu_uUSR_USER = dr.oread("uu_uUSR_USER")
         dr.uu_dUpdate = dr.oread("uu_dUpdate")
         dr.uu_COM_COMPANY = dr.oread("uu_COM_COMPANY")
         dr.uu_szCompany = dr.oread("uu_szCompany")
         dr.uu_szFirst = dr.oread("uu_szFirst")
         dr.uu_szLast = dr.oread("uu_szLast")
         dr.uu_szEmail = dr.oread("uu_szEmail")
         dr.uu_szPhone = dr.oread("uu_szPhone")
         dr.uu_szCell = dr.oread("uu_szCell")
         dr.uu_szAddr1 = dr.oread("uu_szAddr1")
         dr.uu_szAddr2 = dr.oread("uu_szAddr2")
         dr.uu_szCity = dr.oread("uu_szCity")
         dr.uu_iProvince = dr.oread("uu_iProvince")
         dr.uu_iCountry = dr.oread("uu_iCountry")
         dr.uu_szPostal = dr.oread("uu_szPostal")
         dr.uu_iPasswordFlag = dr.oread("uu_iPasswordFlag")
         dr.uu_szId = dr.oread("uu_szId")
         dr.uu_iActive = dr.oread("uu_iActive")
         dr.uu_iLanguage = dr.oread("uu_iLanguage")
         dr.uu_iRlanguage = dr.oread("uu_iRlanguage")
      End If
      dr.oread.Close()

#If SFTSTOREWEB Then
      SaveSession(dr)
#End If
   End Sub
   Public Shared Function UserCheckPassword(ByRef dr As DATA_RECORD) As Long
      'On Error Resume Next
      Dim strSQL$, rt&

      UserCheckPassword = 0
      strSQL = ""
      Dim oConn As New OleDb.OleDbConnection(dr.szConnection)
      Dim oCommand As New OleDb.OleDbCommand(strSQL, oConn)
      Dim oP1 As New OleDb.OleDbParameter
      Dim retVal As String
      oConn.Open()
      oCommand.CommandType = CommandType.StoredProcedure
      oCommand.CommandText = "USER_CHECK_PASSWORD"
      oCommand.Parameters.Add("@RETURN_VALUE", OleDbType.Integer)
      oCommand.Parameters.Add("USR_USER", OleDbType.BigInt)
      oCommand.Parameters.Add("szPassword", OleDbType.VarChar)
      oCommand.Parameters.Add("iReturn", OleDbType.Integer)
      oCommand.Parameters("@RETURN_VALUE").Direction = ParameterDirection.ReturnValue
      oCommand.Parameters("USR_USER").Direction = ParameterDirection.Input
      oCommand.Parameters("szPassword").Direction = ParameterDirection.Input
      oCommand.Parameters("iReturn").Direction = ParameterDirection.Output
      oCommand.Parameters("USR_USER").Value = dr.sr_iid
      oCommand.Parameters("szPassword").Value = dr.szPassword
      oCommand.Parameters("iReturn").Value = 0
      retVal = oCommand.ExecuteNonQuery()
      rt = oCommand.Parameters("iReturn").Value
      UserCheckPassword = rt

      'If dr.uu_iExpires > 0 Then
      '   oCommand.CommandType = CommandType.Text
      '   strSQL = "SELECT up_sdDate FROM USR_PASSWORD where up_USR_USER = " + CStr(dr.sr_iid) + " order by up_iid desc"
      '   oCommand.CommandText = strSQL
      '   Dim oread As OleDb.OleDbDataReader
      '   oread = oCommand.ExecuteReader()
      '   If oread.HasRows = True Then
      '      oread.Read()
      '      dr.dLastpassword = oread("up_sdDate")
      '   Else
      '      dr.dLastpassword = Now
      '   End If
      '   oread.Close()
      'End If
      oConn.Close()
   End Function
   Public Shared Function UserSetPassword(ByRef dr As DATA_RECORD) As Long
      Dim strSQL$, tCNT1&

      strSQL = "delete from USR_PASSWORD where up_USR_USER = " + CStr(dr.uu_iid)
      ExecuteScalar(dr.szConnection, strSQL, dr.szRstr)

      strSQL = "USER_SET_PASSWORD " + CStr(dr.uu_iid) + ", '" + Format(Now, "dd/MMM/yyyy HH:mm:ss") + "', '" + dr.szPassword + "'"
      ExecuteScalar(dr.szConnection, strSQL, dr.szRstr)

      strSQL = "USER_GET_PASSWORD_COUNT 0, " + CStr(dr.uu_iid)
      ExecuteScalar(dr.szConnection, strSQL, dr.szRstr)
      tCNT1 = CLng(GetFloat(dr.szRstr))

      If tCNT1 > 0 Then
         UserSetPassword = 1
         strSQL = "update USR_USER set uu_iPasswordflag = 1 where uu_iid = " + CStr(dr.uu_iid)
         ExecuteScalar(dr.szConnection, strSQL, dr.szRstr)
      Else
         UserSetPassword = 0
      End If
   End Function
   Public Shared Function CustomerCheckPassword(ByRef dr As DATA_RECORD) As Long
      Dim strSQL$, rt&

      CustomerCheckPassword = 0
      strSQL = ""
      TestConnection()
      Try
         Dim retVal As String
         dr.ocmd.CommandType = CommandType.StoredProcedure
         dr.ocmd.CommandText = "CUSTOMER_CHECK_PASSWORD"
         dr.ocmd.Parameters.Add("@RETURN_VALUE", OleDbType.Integer)
         dr.ocmd.Parameters.Add("CUS_CUSTOMER", OleDbType.BigInt)
         dr.ocmd.Parameters.Add("szPassword", OleDbType.VarChar)
         dr.ocmd.Parameters.Add("iReturn", OleDbType.Integer)
         dr.ocmd.Parameters("@RETURN_VALUE").Direction = ParameterDirection.ReturnValue
         dr.ocmd.Parameters("CUS_CUSTOMER").Direction = ParameterDirection.Input
         dr.ocmd.Parameters("szPassword").Direction = ParameterDirection.Input
         dr.ocmd.Parameters("iReturn").Direction = ParameterDirection.Output
         dr.ocmd.Parameters("CUS_CUSTOMER").Value = dr.cu_iid
         dr.ocmd.Parameters("szPassword").Value = dr.szPassword
         dr.ocmd.Parameters("iReturn").Value = 0
         retVal = dr.ocmd.ExecuteNonQuery()
         rt = dr.ocmd.Parameters("iReturn").Value
         ConnectDatabase()
         CustomerCheckPassword = rt
      Catch ex As Exception
         ConnectDatabase()
         CustomerCheckPassword = 0
      End Try


      'dr.ocmd.CommandType = CommandType.Text
      'strSQL = "SELECT cp_sdDate FROM CUS_PASSWORD where cp_CUS_CUSTOMER = " + CStr(dr.sr_iid) + " order by cp_iid desc"
      'dr.ocmd.CommandText = strSQL
      'dr.oread = dr.ocmd.ExecuteReader()
      'If dr.oread.HasRows = True Then
      '   dr.oread.Read()
      '   dr.dLastpassword = dr.oread("cp_sdDate")
      'Else
      '   dr.dLastpassword = Now
      'End If
      'dr.oread.Close()
   End Function
   Public Shared Function CustomerSetPassword(ByRef dr As DATA_RECORD) As Long
      Dim strSQL$, tCNT1&

      strSQL = "delete from CUS_PASSWORD where cp_CUS_CUSTOMER = " + CStr(dr.cu_iid)
      ExecuteScalar(dr.szConnection, strSQL, dr.szRstr)

      strSQL = "CUSTOMER_SET_PASSWORD " + CStr(dr.cu_iid) + ", '" + Format(Now, "dd/MMM/yyyy HH:mm:ss") + "', '" + dr.szPassword + "'"
      ExecuteScalar(dr.szConnection, strSQL, dr.szRstr)

      strSQL = "CUSTOMER_GET_PASSWORD_COUNT 0, " + CStr(dr.cu_iid)
      ExecuteScalar(dr.szConnection, strSQL, dr.szRstr)
      tCNT1 = CLng(GetFloat(dr.szRstr))

      If tCNT1 > 0 Then
         CustomerSetPassword = 1
         strSQL = "update CUS_CUSTOMER set cu_iPasswordflag = 1 where cu_iid = " + CStr(dr.cu_iid)
         ExecuteScalar(dr.szConnection, strSQL, dr.szRstr)
      Else
         CustomerSetPassword = 0
      End If
   End Function
   Public Shared Function UserCheckId(ByRef dr As DATA_RECORD) As Long
      '0 - Not found
      '1 - uu_szId is blank
      '2 - uu_szId is found
      '3 - uu_szId is found and not matching current
      TestConnection()
      Dim strSQL$
      Dim tRT&
      tRT = 0
      If dr.uu_szId = "" Then
         UserCheckId = 1
         Exit Function
      End If
      strSQL = "SELECT * FROM USR_USER where uu_szId = '" + CStr(dr.uu_szId) + "'"
      dr.ocmd.CommandText = strSQL
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.iid = dr.oread("uu_iid")
         tRT = 2
         If dr.oread("uu_iid") <> dr.uu_iid Then
            tRT = 3
         End If
      Else
         tRT = 0
      End If
      dr.oread.Close()
      UserCheckId = tRT
   End Function
   Public Shared Function CustomerCheckId(ByRef dr As DATA_RECORD) As Long
      '0 - Not found
      '1 - cu_szEmail is blank
      '2 - cu_szEmail is found
      '3 - cu_szEmail is found and not matching current
      TestConnection()
      Dim strSQL$
      Dim tRT&
      tRT = 0
      If dr.cu_szEmail = "" Then
         CustomerCheckId = 0
         Exit Function
      End If
#If SFTSTORE Then
      strSQL = "SELECT * FROM CUS_CUSTOMER where cu_szEmail = '" + CStr(dr.cu_szEmail) + "' AND cu_COM_COMPANY = " + CStr(dr.sr_iCompany)
#ElseIf SFTSTOREWEB Then
      strSQL = "SELECT * FROM CUS_CUSTOMER where cu_szEmail = '" + CStr(dr.cu_szEmail) + "' AND cu_COM_COMPANY = " + CStr(GV("sr_iCompany", 0))
#End If

      dr.ocmd.CommandText = strSQL
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.iid = dr.oread("cu_iid")
         tRT = 2
         If dr.oread("cu_iid") <> dr.cu_iid Then
            tRT = 3
         End If
      Else
         tRT = 0
      End If
      dr.oread.Close()
      CustomerCheckId = tRT
   End Function
   Public Shared Sub WriteIni(ByVal iSection As String, ByVal iItem As String, ByVal iVal As String)
      Dim tl1&

      Dim tFILE$ = AppDomain.CurrentDomain.BaseDirectory + "SFTSTORE.INI"

      tl1 = WritePrivateProfileString(iSection, iItem, iVal, tFILE)
   End Sub
   Public Shared Function UserToSystem(ByRef dr As DATA_RECORD) As Long
      UserToSystem = 0
      GetCompanyRecord(dr.uu_COM_COMPANY, dr)
      dr.sr_iLanguage = dr.uu_iLanguage
      dr.sr_iRlanguage = dr.uu_iRlanguage
      dr.sr_iProvince = dr.co_iProvince
      dr.sr_iCountry = dr.co_iCountry
      dr.sr_szDisplay = dr.uu_szFirst + " " + dr.uu_szLast
      dr.sr_szFirst = dr.uu_szFirst
      dr.sr_szLast = dr.uu_szLast
      dr.sr_iid = dr.uu_iid
      dr.LANG = dr.uu_iLanguage
      dr.sr_iCompany = dr.uu_COM_COMPANY
      dr.sr_iComMaterials = dr.co_iDefaultMaterial
      '#If SFTSTOREWEB Then
      '      SV("sr_iLanguage", CStr(dr.sr_iLanguage))
      '      SV("sr_iRlanguage", CStr(dr.sr_iRlanguage))
      '      SV("sr_iProvince", CStr(dr.sr_iProvince))
      '      SV("sr_iCountry", CStr(dr.sr_iCountry))
      '      SV("sr_szDisplay", CStr(dr.sr_szDisplay))
      '      SV("sr_szFirst", CStr(dr.sr_szFirst))
      '      SV("sr_szLast", CStr(dr.sr_szLast))
      '      SV("sr_iid", CStr(dr.sr_iid))
      '      SV("LANG", CStr(dr.LANG))
      '      SV("sr_iCompany", CStr(dr.sr_iCompany))
      '      SV("sr_iComMaterials", CStr(dr.sr_iComMaterials))
      '#End If
   End Function
   Public Shared Function CustomerToSystem(ByRef dr As DATA_RECORD) As Long
      CustomerToSystem = 0
      GetCompanyRecord(dr.cu_COM_COMPANY, dr)
      dr.sr_iLanguage = dr.cu_iLanguage
      dr.sr_iProvince = dr.co_iProvince
      dr.sr_iCountry = dr.co_iCountry
      dr.sr_szDisplay = dr.cu_szFirst + " " + dr.cu_szLast
      dr.sr_szFirst = dr.cu_szFirst
      dr.sr_szLast = dr.cu_szLast
      dr.sr_iid = dr.cu_iid
      dr.LANG = dr.cu_iLanguage
      'dr.sr_iCompany = dr.cu_COM_COMPANY
      dr.sr_iComMaterials = dr.co_iDefaultMaterial
#If SFTSTOREWEB Then
      SV("sr_iLanguage", CStr(dr.sr_iLanguage))
      SV("sr_iRlanguage", CStr(dr.sr_iRlanguage))
      SV("sr_iProvince", CStr(dr.sr_iProvince))
      SV("sr_iCountry", CStr(dr.sr_iCountry))
      SV("sr_szDisplay", CStr(dr.sr_szDisplay))
      SV("sr_szFirst", CStr(dr.sr_szFirst))
      SV("sr_szLast", CStr(dr.sr_szLast))
      SV("sr_iid", CStr(dr.sr_iid))
      SV("LANG", CStr(dr.LANG))
      'SV("sr_iCompany", CStr(dr.sr_iCompany))
      SV("sr_iComMaterials", CStr(dr.sr_iComMaterials))
#End If
   End Function
   Public Shared Sub AddMostrecent(ByVal ctrl%, ByRef dr As DATA_RECORD)
      Dim tstr1$, tdta$(), tl1&, tstr2$, tl2&, tstr3$, tstr4$
      Dim rspString As String = ""
      Dim strSQL As String = "SELECT um_szMostRecent FROM USR_MOSTRECENT where um_USR_USER = " + CStr(dr.sr_iid) + " and um_iType = " + CStr(ctrl)

      Dim rstr$
      tstr1 = ""
      tstr2 = ""
      tstr3 = ""
      tl2 = 0
      tdta = Nothing
      rstr = ""
      TestConnection()
      Try
         dr.ocmd.CommandText = strSQL
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            tstr1 = dr.oread("um_szMostRecent")
         Else
            tstr1 = ""
         End If
      Catch ex As Exception
         rspString = ex.Message
      Finally
         dr.oread.Close()
      End Try

      If ctrl = MR_COMPANY Then
         tstr3 = ""
         If dr.co_szEmail <> "" Then
            tstr3 += CStr(dr.co_szEmail)
         End If
         If tstr3 = "" Then tstr3 = "NOT DEFINED"
         tstr4 = dr.co_szCompanyName
         If tstr4 = "" Then
            tstr4 += CStr(dr.co_iid)
         Else
            tstr4 += " (" + CStr(dr.co_iid) + ")"
         End If
         tstr2 = CStr(dr.co_iid) + "|" + tstr4 + "|" + tstr3 + "|" + Format(Now, "dd/MMM/yyyy HH:mm:ss tt") + "|"
         tl2 = 1
         If InStr(1, tstr1, "|") Then
            tdta = Split(tstr1, "|")
            For tl1 = 0 To UBound(tdta) - 1 Step 4
               If tl1 + 3 <= UBound(tdta) - 1 Then
                  If CLng(dr.co_iid) <> CLng(tdta(tl1)) Then
                     tl2 += 1
                     If tl2 <= 20 Then
                        tstr2 += tdta(tl1) + "|" + tdta(tl1 + 1) + "|" + tdta(tl1 + 2) + "|" + tdta(tl1 + 3) + "|"
                     End If
                  End If
               End If
            Next
         End If
      End If
      If ctrl = MR_USER Then
         tstr3 = ""
         If dr.uu_szLast <> "" Then
            tstr3 += dr.uu_szLast
         End If
         If dr.uu_szFirst <> "" Then
            If tstr3 <> "" Then tstr3 += ", "
            tstr3 += dr.uu_szFirst
         End If
         tstr2 = CStr(dr.uu_iid) + "|" + dr.uu_szId + "|" + tstr3 + "|" + Format(Now, "dd/MMM/yyyy HH:mm:ss tt") + "|"
         tl2 = 1
         If InStr(1, tstr1, "|") Then
            tdta = Split(tstr1, "|")
            For tl1 = 0 To UBound(tdta) - 1 Step 4
               If tl1 + 3 <= UBound(tdta) - 1 Then
                  If CLng(dr.uu_iid) <> CLng(tdta(tl1)) Then
                     tl2 += 1
                     If tl2 <= 20 Then
                        tstr2 += tdta(tl1) + "|" + tdta(tl1 + 1) + "|" + tdta(tl1 + 2) + "|" + tdta(tl1 + 3) + "|"
                     End If
                  End If
               End If
            Next
         End If
      End If
      If ctrl = MR_PRODUCT Then
         tstr3 = ""
         If dr.pp_szProductName <> "" Then
            tstr3 += dr.uu_szLast
         End If
         tstr2 = CStr(dr.pp_iid) + "|" + dr.pp_szProductNumber + "|" + tstr3 + "|" + Format(Now, "dd/MMM/yyyy HH:mm:ss tt") + "|"
         tl2 = 1
         If InStr(1, tstr1, "|") Then
            tdta = Split(tstr1, "|")
            For tl1 = 0 To UBound(tdta) - 1 Step 4
               If tl1 + 3 <= UBound(tdta) - 1 Then
                  If CLng(dr.pp_iid) <> CLng(tdta(tl1)) Then
                     tl2 += 1
                     If tl2 <= 20 Then
                        tstr2 += tdta(tl1) + "|" + tdta(tl1 + 1) + "|" + tdta(tl1 + 2) + "|" + tdta(tl1 + 3) + "|"
                     End If
                  End If
               End If
            Next
         End If
      End If
      If ctrl = MR_CUSTOMER Then
         tstr3 = ""
         If dr.cu_szLast <> "" Then
            tstr3 += dr.cu_szLast
         End If
         If dr.cu_szFirst <> "" Then
            If tstr3 <> "" Then tstr3 += ", "
            tstr3 += dr.cu_szFirst
         End If
         tstr2 = CStr(dr.cu_iid) + "|" + dr.cu_szId + "|" + tstr3 + "|" + Format(Now, "dd/MMM/yyyy HH:mm:ss tt") + "|"
         tl2 = 1
         If InStr(1, tstr1, "|") Then
            tdta = Split(tstr1, "|")
            For tl1 = 0 To UBound(tdta) - 1 Step 4
               If tl1 + 3 <= UBound(tdta) - 1 Then
                  If CLng(dr.cu_iid) <> CLng(tdta(tl1)) Then
                     tl2 += 1
                     If tl2 <= 20 Then
                        tstr2 += tdta(tl1) + "|" + tdta(tl1 + 1) + "|" + tdta(tl1 + 2) + "|" + tdta(tl1 + 3) + "|"
                     End If
                  End If
               End If
            Next
         End If
      End If
      If ctrl = MR_ORDERS Then
         Dim tFirst$ = "", tLast$ = ""
         TestConnection()
         dr.ocmd.CommandText = "SELECT cu_szFirst, cu_szLast FROM CUS_CUSTOMER WHERE cu_iid = " + CStr(dr.oo_CUS_CUSTOMER)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            tFirst = dr.oread("cu_szFirst")
            tLast = dr.oread("cu_szLast")
         End If
         dr.oread.Close()

         tstr3 = ""
         If tLast <> "" Then
            tstr3 += tLast
         End If
         If tFirst <> "" Then
            If tstr3 <> "" Then tstr3 += ", "
            tstr3 += tFirst
         End If
         tstr2 = CStr(dr.oo_iid) + "|" + CStr(dr.oo_iid) + "|" + tstr3 + "|" + Format(Now, "dd/MMM/yyyy HH:mm:ss tt") + "|"
         tl2 = 1
         If InStr(1, tstr1, "|") Then
            tdta = Split(tstr1, "|")
            For tl1 = 0 To UBound(tdta) - 1 Step 4
               If tl1 + 3 <= UBound(tdta) - 1 Then
                  If CLng(dr.oo_iid) <> CLng(tdta(tl1)) Then
                     tl2 += 1
                     If tl2 <= 20 Then
                        tstr2 += tdta(tl1) + "|" + tdta(tl1 + 1) + "|" + tdta(tl1 + 2) + "|" + tdta(tl1 + 3) + "|"
                     End If
                  End If
               End If
            Next
         End If
      End If

      strSQL = "USER_MOSTRECENT_UPDATE "
      strSQL += CStr(dr.sr_iid) + ", "
      strSQL += CStr(ctrl) + ", "
      strSQL += "'" + AStr(tstr2) + "' "
      rstr = ""
      ExecuteScalar(dr.szConnection, strSQL, rstr)
   End Sub
   Public Shared Sub OpenMostRecent(ByRef dr As DATA_RECORD)
      Dim tstr1$
      Dim rspString As String = ""
      TestConnection()
      Dim strsql$ = "select * from USR_MOSTRECENT where um_iType = " + CStr(dr.mr_iType) + "  and um_USR_USER = " + CStr(dr.sr_iid)
      dr.mr_szData = ""
      Err.Clear()
      tstr1 = ""
      dr.ocmd.CommandText = strsql
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.Read() Then
         tstr1 += CStr(dr.oread("um_szMostrecent"))
      End If
      dr.oread.Close()
      dr.mr_szData = tstr1
   End Sub
   Public Shared Sub RemoveMostRecent(ByVal ctrl%, ByVal RemoveKey&, ByRef dr As DATA_RECORD)
      Dim tstr1$, tdta$(), tl1&, tstr2$, tl2&, tstr3$
      Dim rspString As String = ""
      Dim strSQL As String = "SELECT um_szMostRecent FROM USR_MOSTRECENT where um_USR_USER = " + CStr(dr.sr_iid) + " and um_iType = " + CStr(ctrl)
      Dim rstr$
      tstr1 = ""
      tstr2 = ""
      tstr3 = ""
      tl2 = 0
      tdta = Nothing
      rstr = ""
      TestConnection()
      Try
         dr.ocmd.CommandText = strSQL
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            tstr1 = dr.oread("um_szMostrecent")
         Else
            tstr1 = ""
         End If
      Catch ex As Exception
         rspString = ex.Message
      Finally
         dr.oread.Close()
      End Try
      tstr2 = ""
      tl2 = 1
      If InStr(1, tstr1, "|") Then
         tdta = Split(tstr1, "|")
         For tl1 = 0 To UBound(tdta) - 1 Step 4
            If CLng(tdta(tl1)) <> RemoveKey Then
               tl2 += 1
               If tl2 <= 20 Then
                  tstr2 += tdta(tl1) + "|" + tdta(tl1 + 1) + "|" + tdta(tl1 + 2) + "|" + tdta(tl1 + 3) + "|"
               End If
            End If
         Next
      End If
      strSQL = "USER_MOSTRECENT_UPDATE "
      strSQL += CStr(dr.sr_iid) + ", "
      strSQL += CStr(ctrl) + ", "
      strSQL += "'" + AStr(tstr2) + "' "
      rstr = ""
      ExecuteScalar(dr.szConnection, strSQL, rstr)
   End Sub
   Public Shared Sub UpdateUserAccessRecord(ByRef dr As DATA_RECORD)
      Dim strSQL As String, tI%, RStr$
      strSQL = ""
      TestConnection()
      strSQL = "USER_ACCESS_UPDATE "
      strSQL += CStr(0) + ", "
      strSQL += CStr(dr.uu_iid) + ", "
      For tI = 1 To ACC_TOTAL
         strSQL += "'" + Mid(dr.au_szAccess, tI, 1) + "'"
         If tI <> ACC_TOTAL Then
            strSQL += ","
         End If
      Next
      RStr = ""
      ExecuteScalar(dr.szConnection, strSQL, RStr)
   End Sub
   Public Shared Sub GetAccessSystemRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      TestConnection()
      dr.ocmd.CommandText = "select * from USR_ACCESS where ua_USR_USER = " + CStr(iid)
      dr.oread = dr.ocmd.ExecuteReader()
      dr.sr_szAccess = ""
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         For tI = 2 To ACC_TOTAL + 1
            dr.sr_szAccess += CStr(dr.oread(tI))
         Next
      Else
         For tI = 2 To ACC_TOTAL + 1
            dr.sr_szAccess += "0"
         Next
      End If
      dr.oread.Close()
   End Sub
   Public Shared Sub GetAccessRecord(ByVal iid As Long, ByRef dr As DATA_RECORD)
      TestConnection()
      dr.ocmd.CommandText = "select * from USR_ACCESS where ua_USR_USER = " + CStr(iid)
      dr.oread = dr.ocmd.ExecuteReader()
      dr.au_szAccess = ""
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         For tI = 2 To ACC_TOTAL + 1
            dr.au_szAccess += CStr(dr.oread(tI))
         Next
      Else
         For tI = 2 To ACC_TOTAL + 1
            dr.au_szAccess += "0"
         Next
      End If
      dr.oread.Close()
   End Sub
   Public Shared Function IsValidImage(filename As String) As Boolean
      Dim img As System.Drawing.Image
      Try
         img = System.Drawing.Image.FromFile(filename)
         img.Dispose()
      Catch generatedExceptionName As OutOfMemoryException
         Return False
      End Try
      Return True
   End Function

   Public Shared Sub UpdateCompanyContact(ByRef dr As DATA_RECORD)

      Dim oP1 As New OleDb.OleDbParameter
      Dim retVal As String

      TestConnection()

      dr.ocmd.CommandType = CommandType.StoredProcedure
      dr.ocmd.CommandText = "COMPANY_CONTACT_UPDATE"
      dr.ocmd.Parameters.Add("iID", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("dDate", OleDbType.Date)
      dr.ocmd.Parameters.Add("uUSR_USER", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("dUpdated", OleDbType.Date)
      dr.ocmd.Parameters.Add("COM_COMPANY", OleDbType.BigInt)
      dr.ocmd.Parameters.Add("szName", OleDbType.VarChar)
      dr.ocmd.Parameters.Add("szEmail", OleDbType.VarChar)
      dr.ocmd.Parameters.Add("szMessage", OleDbType.VarChar)
      dr.ocmd.Parameters.Add("iFlag", OleDbType.Integer)
      dr.ocmd.Parameters(0).Direction = ParameterDirection.InputOutput
      dr.ocmd.Parameters(1).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(2).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(3).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(4).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(5).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(6).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(7).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(8).Direction = ParameterDirection.Input
      dr.ocmd.Parameters(0).Value = dr.cn_iid
      dr.ocmd.Parameters(1).Value = dr.cn_dDate
      dr.ocmd.Parameters(2).Value = dr.cn_uUSR_USER
      dr.ocmd.Parameters(3).Value = dr.cn_dUpdated
      dr.ocmd.Parameters(4).Value = dr.cn_COM_COMPANY
      dr.ocmd.Parameters(5).Value = dr.cn_szName
      dr.ocmd.Parameters(6).Value = dr.cn_szEmail
      dr.ocmd.Parameters(7).Value = dr.cn_szMessage
      dr.ocmd.Parameters(8).Value = dr.cn_iFlag
      retVal = dr.ocmd.ExecuteNonQuery()
      dr.cn_iid = dr.ocmd.Parameters(0).Value

      ConnectDatabase()
   End Sub

   Public Shared Function GetStoreInformation() As ArrayList
      Dim information As ArrayList = New ArrayList
      Dim strSql As String = "SELECT * FROM COM_ADDRESS where ch_COM_COMPANY = " + CStr(1) + " AND ch_iShipping = 1 ORDER BY ch_szCity;"
      TestConnection()
      dr.ocmd.CommandText = strSql
      dr.oread = dr.ocmd.ExecuteReader()
      While dr.oread.Read()
         Dim temparray(7) As String
         temparray(0) = dr.oread("ch_szAddr1")
         temparray(1) = dr.oread("ch_szCity")
         temparray(2) = dr.oread("ch_iCountry")
         temparray(3) = dr.oread("ch_iProvince")
         temparray(4) = dr.oread("ch_szPostal")
         temparray(5) = dr.oread("ch_szTitle")
         temparray(6) = dr.oread("ch_szHours")
         temparray(7) = dr.oread("ch_szTelephone")
         information.Add(temparray)
      End While
      dr.oread.Close()

      Return information
   End Function

   Public Shared Function GetCompanyContact(ByVal iid As Long, ByRef dr As DATA_RECORD) As String()
      Dim contact(8) As String
      Dim rspString As String = ""
      Dim strSQL As String = "SELECT * FROM COM_COMPANY where co_iid = " + CStr(iid)
      TestConnection()
      Try
         dr.ocmd.CommandText = strSQL
         dr.oread = dr.ocmd.ExecuteReader
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            contact(0) = dr.oread("co_szCompanyName")
            contact(1) = dr.oread("co_szAddr1")
            contact(2) = dr.oread("co_szCity")
            contact(3) = dr.oread("co_iProvince")
            contact(4) = dr.oread("co_iCountry")
            contact(5) = dr.oread("co_szPostal")
            contact(6) = dr.oread("co_szPhone")
            contact(7) = dr.oread("co_szEmail")
         End If
      Catch ex As Exception
         rspString = ex.Message
      Finally
         dr.oread.Close()
      End Try
      Return contact



   End Function
End Class

