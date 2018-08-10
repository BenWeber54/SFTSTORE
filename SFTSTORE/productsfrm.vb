Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class productsfrm
   Private Sub companyfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(387)
      btnNew.Text = Txt(379)
      btnOpen.Text = Txt(380)
      btnRecent.Text = Txt(370)
      btnSave.Text = Txt(382)
      btnDelete.Text = Txt(383)
      btnImage.Text = Txt(550)
      btnAudit.Text = Txt(389)
      btnClose.Text = Txt(390)
      btnEditProduct.Text = Txt(565)
      btnNewPrice.Text = Txt(379)
      btnEditPrice.Text = Txt(566)
      btnDeletePrice.Text = Txt(383)
      btnClose.Text = Txt(390)
      btnFeedback.Text = Txt(669)
      btnConvert.Text = Txt(763)

      lblProdNum.Text = Txt(546) + ":"
      lblEntry.Text = Txt(567) + ":"
      lblProdType.Text = Txt(548) + ":"
      lblProdName.Text = Txt(547) + ":"
      lblProdStatus.Text = Txt(540) + ":"
      lblSpecStatus.Text = Txt(568) + ":"
      lblSpecDesc.Text = Txt(569) + ":"
      lblProdDesc.Text = Txt(570) + ":"
      lblProdDesc2.Text = Txt(571) + ":"
      lblProdDetail.Text = Txt(572) + ":"
      lblRemain.Text = Txt(698) + ":"
      lblWeight.Text = Txt(702) + ":"
      lblMaterial.Text = Txt(770) + ":"
      lblSolo.Text = Txt(778) + ":"
      lblTaxFree.Text = Txt(836) + ":"
      lblSubTypes.Text = Txt(886) + ":"

      lblLength.Text = Txt(727) + ":"
      lblWidth.Text = Txt(728) + ":"
      lblHeight.Text = Txt(729) + ":"
      lblLength3.Text = Txt(730)
      lblWidth3.Text = Txt(731)
      lblHeight3.Text = Txt(732)
      lblAddress.Text = Txt(726) + ":"

      tb.TabPages(0).Text = Txt(857)
      tb.TabPages(1).Text = Txt(858)
      tb.TabPages(2).Text = Txt(794)

      tb1.TabPages(0).Text = Txt(859)
      tb1.TabPages(1).Text = Txt(860)

      cmbPackaged.Items.Add(New ComboClass(1, Txt(744)))
      cmbPackaged.Items.Add(New ComboClass(2, Txt(745)))

      cmbSolo.Items.Add(New ComboClass(1, Txt(354)))
      cmbSolo.Items.Add(New ComboClass(2, Txt(353)))

      SetCboItems(cmbProdStatus, 36, 2)
      SetCboItems(cmbSpecStatus, 36, 2)
      inits()
   End Sub
   Private Sub inits()
      If dr.FRMSWT <> 2 Then
         InitProduct(dr)
      Else
         btnNew.Visible = False
         btnOpen.Visible = False
         btnRecent.Visible = False
         btnSave.Visible = False
         btnDelete.Visible = False
         btnImage.Visible = False
         btnAudit.Visible = False
         btnNewPrice.Visible = False
         btnEditPrice.Visible = False
         btnEditProduct.Visible = False
         btnDeletePrice.Visible = False
      End If
      Display()
   End Sub
   Private Sub Display()
      Dim tIMAGE$ = "", tAUDIT$ = "", tFEEDBACK$ = ""
      SetCboIndex(cmbSolo, dr.pp_iPackedSolo)
      txtProdNumber.Text = dr.pp_szProductNumber
      dpEntry.Value = dr.pp_dEntry

      If dr.pp_iTaxFree = 0 Then
         chkTaxFree.Checked = False
      Else
         chkTaxFree.Checked = True
      End If
      txtProdName.Text = dr.pp_szProductName
      txtSpecDesc.Text = dr.pp_szSpecialDesc
      txtProdDesc.Text = dr.pp_szProductDesc
      txtProDesc2.Text = dr.pp_szProductDesc2
      txtSKU.Text = dr.pp_szSKU
      txtProdDetail.Text = dr.pp_szDetails
      txtMaterial.Text = CStr(dr.pp_iPackMaterials)
      SetCboIndex(cmbPackaged, dr.pp_iPackaged)
      txtWeight.Text = dr.pp_rWeight
      loadShipBoxes()
      cmbType.Items.Clear()
      cmbType.Items.Add(New ComboClass(0, "NOT DEFINED"))
      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM PRO_TYPE WHERE pt_COM_COMPANY = " + CStr(dr.sr_iCompany)
      dr.ocmd.CommandText += " ORDER BY pt_szTypeName"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows() = True Then
         Do While dr.oread.Read()
            cmbType.Items.Add(New ComboClass(dr.oread("pt_iid"), dr.oread("pt_szTypeName")))
         Loop
      End If
      dr.oread.Close()

      SetCboIndex(cmbType, dr.pp_PRO_TYPE)
      SetCboIndex(cmbProdStatus, dr.pp_iActive)
      SetCboIndex(cmbSpecStatus, dr.pp_iSpecial)
      If dr.pp_iid > 0 Then
         LoadPriceChanges()
         loadPrices()
      Else
         lstPrices.Items.Clear()
         txtPriceChanges.Text = ""
      End If

      If dr.pp_iid > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT Top 1 pn_iRemaining FROM PRO_TRANSACTION WHERE pn_PRO_PRODUCT = " + CStr(dr.pp_iid) + " ORDER BY pn_dDate Desc"
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            txtRemain.Text = dr.oread("pn_iRemaining")
         Else
            txtRemain.Text = "0"
         End If
         dr.oread.Close()
      Else
         txtRemain.Text = ""
      End If
      loadSubTypes()
      'If dr.pp_iid > 0 Then
      '   TestConnection()
      '   dr.ocmd.CommandText = "SELECT ch_szTitle FROM COM_ADDRESS WHERE ch_iid = " + CStr(dr.pp_COM_ADDRESS)
      '   dr.oread = dr.ocmd.ExecuteReader()
      '   If dr.oread.HasRows = True Then
      '      dr.oread.Read()
      '      txtAddress.Text = dr.oread("ch_szTitle")
      '   Else
      '      txtAddress.Text = ""
      '   End If
      '   dr.oread.Close()
      'Else
      '   txtAddress.Text = ""
      'End If

      txtLength.Text = StringFormatEnglish(23, dr.pp_rLength)
      txtWidth.Text = StringFormatEnglish(23, dr.pp_rWidth)
      txtHeight.Text = StringFormatEnglish(23, dr.pp_rHeight)

      tIMAGE = Txt(550)
      tAUDIT = Txt(389)
      tFEEDBACK = Txt(669)

      If dr.co_iid > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "PRODUCT_GET_INFO " + CStr(dr.pp_iid) + ""
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If dr.oread(1) <> 0 Then
               tIMAGE += " (" + CStr(dr.oread(1)) + ")"
            End If
            If dr.oread(2) <> 0 Then
               tAUDIT += " (" + CStr(dr.oread(2)) + ")"
            End If
            If dr.oread(3) <> 0 Then
               tFEEDBACK += " (" + CStr(dr.oread(3)) + ")"
            End If
         End If
         dr.oread.Close()
      End If

      If btnImage.Text <> tIMAGE Then btnImage.Text = tIMAGE
      If btnAudit.Text <> tAUDIT Then btnAudit.Text = tAUDIT
      If btnFeedback.Text <> tFEEDBACK Then btnFeedback.Text = tFEEDBACK
   End Sub
   Private Sub loadShipBoxes()
      If dr.pp_iPackedSolo = 2 Then
         If dr.pp_COM_BOXES > 0 Then
            GetCompanyBoxesRecord(dr.pp_COM_BOXES, dr)
            txtShipBox.Text = CStr(dr.cx_rLength) + " X " + CStr(dr.cx_rWidth) + " X " + CStr(dr.cx_rHeight)
         Else
            txtShipBox.Text = ""
         End If
      Else
         txtShipBox.Text = ""
      End If
   End Sub
   Private Sub LoadPriceChanges()
      txtPriceChanges.Text = ""
      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM PRO_PRICE_CHANGES JOIN USR_USER ON pc_USR_USER = uu_iid WHERE pc_PRO_PRODUCT = " + CStr(dr.pp_iid) + " ORDER BY pc_dDate DESC"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         Do While dr.oread.Read()
            txtPriceChanges.Text += Txt(541) + ": " + CStr(dr.oread("uu_szFirst")) + " " + CStr(dr.oread("uu_szLast")) + vbCrLf
            txtPriceChanges.Text += Txt(542) + ": " + Format(dr.oread("pc_dDate"), "dd/MMMM/yyyy") + vbCrLf
            txtPriceChanges.Text += Txt(543) + ": " + StringFormatCurrency(2, dr.oread("pc_rOldPrice")) + vbCrLf
            txtPriceChanges.Text += Txt(544) + ": " + StringFormatCurrency(2, dr.oread("pc_rNewPrice")) + vbCrLf
            txtPriceChanges.Text += Txt(545) + ": " + dr.oread("pc_szReason") + vbCrLf + vbCrLf
         Loop
      End If
      dr.oread.Close()
   End Sub
   Private Sub loadSubTypes()
      If dr.pp_iid > 0 Then
         TestConnection()
         lstSubTypes.Items.Clear()
         dr.ocmd.CommandText = "SELECT * FROM PRO_PRODUCT_TYPES "
         dr.ocmd.CommandText += " JOIN PRO_PRODUCT ON py_PRO_PRODUCT = pp_iid"
         dr.ocmd.CommandText += " JOIN PRO_SUB_TYPE ON ps_iid = py_PRO_SUB_TYPE"
         dr.ocmd.CommandText += " WHERE pp_iid > 0 AND pp_iid = " + CStr(dr.pp_iid)
         dr.ocmd.CommandText += " order by ps_szName"
         dr.oread = dr.ocmd.ExecuteReader
         If dr.oread.HasRows = True Then
            lstSubTypes.View = View.Details
            lstSubTypes.Columns.Add(Txt(573), lstSubTypes.Width - 155, HorizontalAlignment.Left)
            lstSubTypes.Columns.Add(Txt(378), 150, HorizontalAlignment.Left)
            Do While dr.oread.Read()
               Dim ListItem1 As New ListViewItem(CStr(dr.oread("ps_szName")))
               ListItem1.Tag = CStr(dr.oread("py_iid"))
               ListItem1.SubItems.Add(Format(dr.oread("py_dDate"), "dd-MMM-yyyy hh:mm:ss"))
               lstSubTypes.Items.Add(ListItem1)
            Loop
         End If
         dr.oread.Close()
      Else
         lstSubTypes.Items.Clear()
      End If
   End Sub
   Private Sub loadPrices()
      TestConnection()
      lstPrices.Items.Clear()
      dr.ocmd.CommandText = "select * FROM PRO_PRICE where pr_iid > 0 AND pr_PRO_PRODUCT = " + CStr(dr.pp_iid)
      dr.ocmd.CommandText += " order by pr_dDate"
      dr.oread = dr.ocmd.ExecuteReader
      If dr.oread.HasRows = True Then
         lstPrices.View = View.Details
         lstPrices.Columns.Add(Txt(539), 150, HorizontalAlignment.Left)
         lstPrices.Columns.Add(Txt(540), 150, HorizontalAlignment.Left)
         lstPrices.Columns.Add(Txt(363), lstPrices.Width - 605, HorizontalAlignment.Left)
         lstPrices.Columns.Add(Txt(826), 150, HorizontalAlignment.Left)
         lstPrices.Columns.Add(Txt(827), 150, HorizontalAlignment.Left)
         Do While dr.oread.Read()
            Dim ListItem1 As New ListViewItem(StringFormatCurrency(2, dr.oread("pr_rPrice")))
            ListItem1.Tag = CStr(dr.oread("pr_iid"))
            If dr.oread("pr_iStatus") = 1 Then
               ListItem1.SubItems.Add(Txt(36))
            ElseIf dr.oread("pr_iStatus") = 2 Then
               ListItem1.SubItems.Add(Txt(37))
            Else
               ListItem1.SubItems.Add(Txt(559))
            End If
            ListItem1.SubItems.Add(Format(dr.oread("pr_dDate"), "dd/MMMM/yyyy"))
            If dr.oread("pr_iStatus") = 3 Then
               ListItem1.SubItems.Add(Format(CDate(dr.oread("pr_dSpecialStart")), "dd/MMM/yyyy"))
               ListItem1.SubItems.Add(Format(CDate(dr.oread("pr_dSpecialEnd")), "dd/MMM/yyyy"))
            Else
               ListItem1.SubItems.Add("")
               ListItem1.SubItems.Add("")
            End If
            lstPrices.Items.Add(ListItem1)
         Loop
      End If
      dr.oread.Close()
   End Sub
   Private Sub ScreenToRecord()
      dr.pp_szSKU = Trim(txtSKU.Text)
      dr.pp_szProductNumber = Trim(txtProdNumber.Text)
      dr.pp_dEntry = dpEntry.Value
      Try
         dr.pp_PRO_TYPE = CType(cmbType.SelectedItem, ComboClass).Value
      Catch ex As Exception
         dr.pp_PRO_TYPE = 0
      End Try
      Try
         dr.pp_iActive = CType(cmbProdStatus.SelectedItem, ComboClass).Value
      Catch ex As Exception
         dr.pp_iActive = 0
      End Try
      Try
         dr.pp_iSpecial = CType(cmbSpecStatus.SelectedItem, ComboClass).Value
      Catch ex As Exception
         dr.pp_iSpecial = 1
      End Try
      Try
         dr.pp_iPackaged = CType(cmbPackaged.SelectedItem, ComboClass).Value
      Catch ex As Exception
         dr.pp_iPackaged = 0
      End Try
      Try
         dr.pp_iPackedSolo = CType(cmbSolo.SelectedItem, ComboClass).Value
      Catch ex As Exception
         dr.pp_iPackedSolo = 0
      End Try
      dr.pp_szProductName = Trim(txtProdName.Text)
      dr.pp_szSpecialDesc = Trim(txtSpecDesc.Text)
      dr.pp_szProductDesc = Trim(txtProdDesc.Text)
      dr.pp_szProductDesc2 = Trim(txtProDesc2.Text)
      dr.pp_szDetails = Trim(txtProdDetail.Text)
      dr.pp_rWeight = GetFloat(txtWeight.Text)
      dr.pp_rLength = GetFloat(txtLength.Text)
      dr.pp_rWidth = GetFloat(txtWidth.Text)
      dr.pp_rHeight = GetFloat(txtHeight.Text)
      dr.pp_iPackMaterials = CLng(GetFloat(txtMaterial.Text))
      If chkTaxFree.Checked = True Then
         dr.pp_iTaxFree = 1
      Else
         dr.pp_iTaxFree = 0
      End If
   End Sub
   Private Function Validation()
      Validation = 0
      If dr.pp_szSKU = "" Then
         txtSKU.Focus()
         MsgDsp(Txt(535))
         Exit Function
      End If
      If dr.pp_PRO_TYPE = 0 Then
         cmbType.Focus()
         MsgDsp(Txt(536))
         Exit Function
      End If
      If dr.pp_szProductName = "" Then
         txtProdName.Focus()
         MsgDsp(Txt(537))
         Exit Function
      End If
      If dr.pp_iPackMaterials < 0 Then
         txtMaterial.Focus()
         MsgDsp(Txt(772))
         Exit Function
      End If
      If dr.pp_rWeight <= 0 Then
         txtWeight.Focus()
         MsgDsp(Txt(738))
         Exit Function
      ElseIf dr.pp_rWeight > 30 Then
         txtWeight.Focus()
         MsgDsp(Txt(903))
         Exit Function
      End If
      If dr.pp_rLength <= 0 Then
         txtLength.Focus()
         MsgDsp(Txt(739))
         Exit Function
      End If
      If dr.pp_rWidth <= 0 Then
         txtWidth.Focus()
         MsgDsp(Txt(740))
         Exit Function
      End If
      If dr.pp_rHeight <= 0 Then
         txtHeight.Focus()
         MsgDsp(Txt(741))
         Exit Function
      End If
      If dr.pp_rHeight > 200 Or dr.pp_rWidth > 200 Or dr.pp_rLength > 200 Then
         txtLength.Focus()
         MsgDsp(Txt(904))
         Exit Function
      End If
      If dr.pp_rLength < 10 Then
         txtLength.Focus()
         MsgDsp(Txt(905))
         Exit Function
      End If
      If dr.pp_rWidth < 2.3 Then
         txtWidth.Focus()
         MsgDsp(Txt(906))
         Exit Function
      End If
      If dr.pp_rHeight < 2.3 Then
         txtHeight.Focus()
         MsgDsp(Txt(907))
         Exit Function
      End If
      If dr.pp_iPackMaterials < 0 Or dr.pp_iPackMaterials >= 100 Then
         txtMaterial.Focus()
         MsgDsp(Txt(776))
         Exit Function
      End If
      If dr.pp_iPackedSolo = 2 Then
         If dr.pp_COM_BOXES = 0 Then
            btnShipBox.Focus()
            MsgDsp(Txt(780))
            Exit Function
         End If
      End If
      TestConnection()
      dr.ocmd.CommandText = "SELECT pp_szSKU, pp_iid, pp_COM_COMPANY FROM PRO_PRODUCT WHERE pp_szSKU = '" + AStr(dr.pp_szSKU) + "'"
      dr.ocmd.CommandText += " AND pp_COM_COMPANY = " + CStr(dr.pp_COM_COMPANY)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         If dr.oread("pp_iid") <> dr.pp_iid Then
            MsgDsp(Txt(538))
            txtSKU.Focus()
            Exit Function
         End If
      End If
      dr.oread.Close()
      Validation = 1
   End Function
#Region "Click events"
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      inits()
   End Sub
   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tstr1$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         ExecuteScalar(dr.szConnection, "DELETE FROM PRO_PRODUCT WHERE pp_iid = " + CStr(dr.pp_iid), tstr1)
         ExecuteScalar(dr.szConnection, "DELETE FROM PRO_FEEDBACK WHERE pf_PRO_PRODUCT = " + CStr(dr.pp_iid), tstr1)
         btnNew_Click(sender, e)
         MsgDsp(Txt(355))
      End If
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1& = 0
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      tl1 = dr.pp_iid
      UpdateProductRecord(dr)
      AddMostrecent(MR_PRODUCT, dr)
      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
      Display()
   End Sub
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      dr.LIST_CTRL = 8
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
         txtProdName.Focus()
         AddMostrecent(MR_PRODUCT, dr)
      End If
   End Sub
   Private Sub btnRecent_Click(sender As Object, e As EventArgs) Handles btnRecent.Click
MostRecentRestart:
      dr.mr_iType = MR_PRODUCT
      dr.LIST_CTRL = 2
      OpenMostRecent(dr)
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         GetProductRecord(dr.LIST_KEY, dr)
         If dr.LIST_KEY = dr.pp_iid Then
            Display()
            txtProdName.Focus()
            AddMostrecent(MR_PRODUCT, dr)
         Else
            RemoveMostRecent(MR_PRODUCT, dr.LIST_KEY, dr)
            MsgDsp(Txt(366))
            GoTo MostRecentRestart
         End If
      End If
   End Sub
   Private Sub btnAudit_Click(sender As Object, e As EventArgs) Handles btnAudit.Click
      If InStr(btnAudit.Text, "(") > 0 Then
         GenerateAudit(AUDIT_PRODUCT, dr.pp_iid)
      Else
         MsgDsp(Txt(361))
      End If
   End Sub
   Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
      If dr.pp_iid > 0 Then
         dr.pi_PRO_PRODUCT = dr.pp_iid
         ScreenToRecord()
         Dim frm As productimagesfrm
         frm = New productimagesfrm
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(549))
      End If
   End Sub
   Private Sub btnEditPart_Click(sender As Object, e As EventArgs) Handles btnEditProduct.Click
      If dr.pp_iid > 0 Then
         ScreenToRecord()
         Dim frm As editproductnumberfrm
         frm = New editproductnumberfrm
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(549))
      End If
   End Sub
   Private Sub btnNewPrice_Click(sender As Object, e As EventArgs) Handles btnNewPrice.Click
      dr.FRMSWT = 2
      Dim frm As productpricefrm
      frm = New productpricefrm
      frm.ShowDialog()
      loadPrices()
   End Sub
   Private Sub btnEditPrice_Click(sender As Object, e As EventArgs) Handles btnEditPrice.Click
      dr.FRMSWT = 1
      Dim tl1& = 0, tl2& = 0
      For Each itm As ListViewItem In lstPrices.SelectedItems
         If itm.Selected Then
            tl2 = 1
            tl1 = GetFloat(itm.Tag)
            dr.pr_iid = tl1
            GetProductPriceRecord(tl1, dr)
            Dim frm As productpricefrm
            frm = New productpricefrm
            frm.ShowDialog()
            loadPrices()
            LoadPriceChanges()
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      End If
   End Sub
   Private Sub btnDeletePrice_Click(sender As Object, e As EventArgs) Handles btnDeletePrice.Click
      Dim tl1& = 0, tl2& = 0
      For Each itm As ListViewItem In lstPrices.SelectedItems
         If itm.Selected Then
            tl2 = 1
            tl1 = GetFloat(itm.Tag)
            dr.pr_iid = tl1
            Dim tstr1$ = ""
            If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
               ExecuteScalar(dr.szConnection, "DELETE FROM PRO_PRICE WHERE pr_iid = " + CStr(dr.pr_iid), tstr1)
               loadPrices()
               MsgDsp(Txt(355))
            End If
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      End If
   End Sub
   Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
      If dr.pp_iid > 0 Then
         dr.FRMSWT = 1
         ScreenToRecord()
         Dim frm As productfeedbackfrm
         frm = New productfeedbackfrm
         frm.ShowDialog()
         Display()
      End If
   End Sub
   Private Sub btnQuantity_Click(sender As Object, e As EventArgs) Handles btnQuantity.Click
      If dr.pp_iid > 0 Then
         Dim frm As producttransactionfrm
         frm = New producttransactionfrm
         frm.ShowDialog()
      Else
         MsgDsp(Txt(549))
      End If
   End Sub
   Private Sub btnAddress_Click(sender As Object, e As EventArgs) Handles btnAddress.Click
      dr.LIST_CTRL = 23
      ScreenToRecord()
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
      End If
   End Sub
   Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
      btnConvert.Enabled = False
      Dim tl1@ = 0

      tl1 = GetFloat(txtWeight.Text)
      tl1 = tl1 / 2.20462
      txtWeight.Text = StringFormatEnglish(24, tl1)
      btnConvert.Enabled = True
   End Sub
   Private Sub btnShipBox_Click(sender As Object, e As EventArgs) Handles btnShipBox.Click
      ScreenToRecord()
      If dr.pp_iPackedSolo = 2 Then
         dr.FRMSWT = 1
         dr.LIST_CTRL = 27
         Dim frm As listfrm
         frm = New listfrm
         frm.ShowDialog()
         If dr.LIST_RET = 1 Then
            Display()
         End If
      Else
         MsgDsp(Txt(779))
      End If
   End Sub
   Private Sub btnAddType_Click(sender As Object, e As EventArgs) Handles btnAddType.Click
      If dr.pp_iid > 0 Then
         ScreenToRecord()
         InitProductSubTypes(dr)
         dr.LIST_CTRL = 31
         Dim frm As listfrm
         frm = New listfrm
         frm.ShowDialog()
         If dr.LIST_RET = 1 Then
            dr.py_PRO_PRODUCT = dr.pp_iid
            UpdateProductSubTypesRecord(dr)
            Display()
         End If
      Else
         MsgDsp(Txt(549))
      End If
   End Sub
   Private Sub btnRemoveType_Click(sender As Object, e As EventArgs) Handles btnRemoveType.Click
      Dim tl1& = 0, tl2& = 0, tstr1$ = ""
      For Each itm As ListViewItem In lstSubTypes.SelectedItems
         If itm.Selected = True Then
            tl2 = 1
            tl1 = CLng(GetFloat(itm.Tag))
            If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
               ExecuteScalar(dr.szConnection, "DELETE FROM PRO_PRODUCT_TYPES WHERE py_iid = " + CStr(tl1), tstr1)
               MsgDsp(Txt(355))
               Display()
            End If
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      End If
   End Sub
#End Region
#Region "Got Focus"
   'Private Sub txtCompanyName_GotFocus(sender As Object, e As EventArgs) Handles txtCompanyName.GotFocus
   '   SetText(txtCompanyName)
   'End Sub
#End Region
#Region "Draw Items"
   Private Sub tb_DrawItem(sender As Object, e As DrawItemEventArgs) Handles tb.DrawItem
      Dim g As Graphics = e.Graphics
      If e.Index = tb.SelectedIndex Then
         Dim b As New SolidBrush(Color.LightBlue)
         Dim f As Font = New Font(e.Font, FontStyle.Bold)
         g.FillRectangle(b, e.Bounds)
         b.Color = Color.Black
         g.DrawString(Me.tb.TabPages(e.Index).Text, f, b, e.Bounds.X + 2, e.Bounds.Y + 2)
      Else
         Dim b As New SolidBrush(Me.tb.BackColor)
         Dim f As Font = New Font(e.Font, FontStyle.Regular)
         g.FillRectangle(b, e.Bounds)
         b.Color = Color.Black
         g.DrawString(Me.tb.TabPages(e.Index).Text, f, b, e.Bounds.X + 2, e.Bounds.Y + 2)
      End If
   End Sub

   Private Sub tb1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles tb1.DrawItem
      Dim g As Graphics = e.Graphics
      If e.Index = tb1.SelectedIndex Then
         Dim b As New SolidBrush(Color.LightBlue)
         Dim f As Font = New Font(e.Font, FontStyle.Bold)
         g.FillRectangle(b, e.Bounds)
         b.Color = Color.Black
         g.DrawString(Me.tb1.TabPages(e.Index).Text, f, b, e.Bounds.X + 2, e.Bounds.Y + 2)
      Else
         Dim b As New SolidBrush(Me.tb1.BackColor)
         Dim f As Font = New Font(e.Font, FontStyle.Regular)
         g.FillRectangle(b, e.Bounds)
         b.Color = Color.Black
         g.DrawString(Me.tb1.TabPages(e.Index).Text, f, b, e.Bounds.X + 2, e.Bounds.Y + 2)
      End If
   End Sub
#End Region
   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim bv As Boolean
      Dim bv1 As Boolean
      If dr.pp_iid = 0 Then
         bv = False
      Else
         bv = True
      End If
      If dr.pp_iid = 0 Then
         bv1 = True
      Else
         bv1 = False
      End If
      If btnDelete.Enabled <> bv Then btnDelete.Enabled = bv
      If btnImage.Enabled <> bv Then btnImage.Enabled = bv
      If btnAudit.Enabled <> bv Then btnAudit.Enabled = bv
      If txtSKU.Enabled <> bv1 Then txtSKU.Enabled = bv1
      If dpEntry.Enabled <> bv1 Then dpEntry.Enabled = bv1
      If btnNewPrice.Enabled <> bv Then btnNewPrice.Enabled = bv
      If btnEditPrice.Enabled <> bv Then btnEditPrice.Enabled = bv
      If btnDeletePrice.Enabled <> bv Then btnDeletePrice.Enabled = bv
      If btnEditProduct.Enabled <> bv Then btnEditProduct.Enabled = bv
      If btnFeedback.Enabled <> bv Then btnFeedback.Enabled = bv
      If btnQuantity.Enabled <> bv Then btnQuantity.Enabled = bv
      If btnAddType.Enabled <> bv Then btnAddType.Enabled = bv
      If btnRemoveType.Enabled <> bv Then btnRemoveType.Enabled = bv
   End Sub

   Private Sub cmbSolo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSolo.SelectedIndexChanged
      If CType(cmbSolo.SelectedItem, ComboClass).Value = 1 Then
         lblShipBox.Visible = False
         txtShipBox.Visible = False
         btnShipBox.Visible = False
      Else
         lblShipBox.Visible = True
         txtShipBox.Visible = True
         btnShipBox.Visible = True
      End If
   End Sub
End Class