Imports SFTSTORE.ftn
Imports SFTSTORE.data
Imports SFTSTORE.reportpdf

Public Class orderdetailfrm
   Private Sub orderdetailfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      lblProduct.Text = Txt(660) + ":"
      lblStatus.Text = Txt(625) + ":"
      lblQuantity.Text = Txt(611) + ":"
      'lblShipTracking.Text = Txt(661) + ":"
      lblNotes.Text = Txt(384) + ":"
      lblremain.Text = Txt(698) + ":"

      btnSave.Text = Txt(382)
      btnClose.Text = Txt(390)

      'SetCboItems(cmbStatus, 36, 2)
      cmbStatus.Items.Add(New ComboClass(1, Txt(36)))
      'cmbStatus.Items.Add(New ComboClass(5, Txt(645)))
      cmbStatus.Items.Add(New ComboClass(2, Txt(697)))
      cmbStatus.Items.Add(New ComboClass(3, Txt(695)))
      cmbStatus.Items.Add(New ComboClass(4, Txt(696)))

      If dr.FRMSWT = 2 Then
         If dr.od_iStatus = 2 Or dr.od_iStatus = 4 Then
            btnProduct.Enabled = False
            txtQuantity.Enabled = False
         End If
      End If
      Inits()
   End Sub
   Private Sub Inits()
      If dr.FRMSWT = 1 Then
         InitOrderDetail(dr)
      End If
      Display()
   End Sub
   Private Sub Display()
      If dr.od_PRO_PRODUCT > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT pp_szProductName FROM PRO_PRODUCT WHERE pp_iid = " + CStr(dr.od_PRO_PRODUCT)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            txtProduct.Text = dr.oread("pp_szProductName")
         Else
            txtProduct.Text = ""
         End If
         dr.oread.Close()

         dr.ocmd.CommandText = "SELECT Top 1 pn_iRemaining FROM PRO_TRANSACTION WHERE pn_PRO_PRODUCT = " + CStr(dr.od_PRO_PRODUCT) + " ORDER BY pn_dDate Desc"
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            txtRemain.Text = dr.oread("pn_iRemaining")
         Else
            txtRemain.Text = ""
         End If
         dr.oread.Close()
      Else
         txtProduct.Text = ""
         txtRemain.Text = ""
      End If
      txtQuantity.Text = dr.od_iQuantity
      'txtShipTracking.Text = dr.od_szShipTracking
      txtNotes.Text = dr.od_szNotes
      SetCboIndex(cmbStatus, dr.od_iStatus)
   End Sub
   Private Sub ScreenToRecord()
      dr.od_iStatus = CType(cmbStatus.SelectedItem, ComboClass).Value
      dr.od_iQuantity = CLng(GetFloat(txtQuantity.Text))
      'dr.od_szShipTracking = Trim(txtShipTracking.Text)
      dr.od_szNotes = Trim(txtNotes.Text)
   End Sub
   Private Function Validation()
      Validation = 0
      If dr.od_PRO_PRODUCT = 0 Then
         btnProduct.Focus()
         MsgDsp(Txt(549))
         Exit Function
      End If
      If dr.oo_iid = 0 Then
         MsgDsp(Txt(642))
         Exit Function
      End If
      If dr.od_iQuantity <= 0 Then
         txtQuantity.Focus()
         MsgDsp(Txt(608))
         Exit Function
      End If
      Validation = 1
   End Function
#Region "Click events"
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1& = 0, oldQuant& = 0, oldStatus& = 0, quantDiff& = 0
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      tl1 = dr.od_iid
      If tl1 = 0 Then
         If dr.od_iStatus = 1 Or dr.od_iStatus = 2 Then
            InitProductTransaction(dr)
            dr.pn_iType = 3
            dr.pn_iKey = dr.od_iid
            dr.pn_iChanged = dr.od_iQuantity
            dr.pn_PRO_PRODUCT = dr.od_PRO_PRODUCT
            dr.pn_szDescription = Txt(41)

            TestConnection()
            dr.ocmd.CommandText = "SELECT TOP 1 pn_iRemaining FROM PRO_TRANSACTION WHERE pn_PRO_PRODUCT = " + CStr(dr.od_PRO_PRODUCT) + " ORDER BY pn_dDate Desc"
            dr.oread = dr.ocmd.ExecuteReader()
            If dr.oread.HasRows = True Then
               dr.oread.Read()
               dr.pn_iRemaining = dr.oread("pn_iRemaining")
            Else
               dr.pn_iRemaining = 0
            End If
            dr.oread.Close()

            dr.pn_iRemaining -= dr.pn_iChanged
            If dr.pn_iRemaining < 0 Then
               MsgDsp(Txt(691))
               Exit Sub
            End If
            UpdateProductTransactionRecord(dr)
         End If
      Else
         InitProductTransaction(dr)
         dr.pn_iType = 4
         dr.pn_iKey = dr.od_iid
         dr.pn_PRO_PRODUCT = dr.od_PRO_PRODUCT

         TestConnection()
         dr.ocmd.CommandText = "SELECT od_iQuantity, od_iStatus FROM ORD_DETAIL WHERE od_iid = " + CStr(dr.od_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            oldQuant = dr.oread("od_iQuantity")
            oldStatus = dr.oread("od_iStatus")
         End If
         dr.oread.Close()

         If (oldStatus = 1 Or oldStatus = 2) And (dr.od_iStatus = 3 Or dr.od_iStatus = 4) Then
            dr.pn_iChanged = oldQuant
            dr.od_iQuantity = oldQuant
            TestConnection()
            dr.ocmd.CommandText = "SELECT TOP 1 pn_iRemaining FROM PRO_TRANSACTION WHERE pn_PRO_PRODUCT = " + CStr(dr.od_PRO_PRODUCT) + " ORDER BY pn_dDate Desc"
            dr.oread = dr.ocmd.ExecuteReader()
            If dr.oread.HasRows = True Then
               dr.oread.Read()
               dr.pn_iRemaining = dr.oread("pn_iRemaining")
            End If
            dr.oread.Close()
            dr.pn_iRemaining += oldQuant
            dr.pn_szDescription = Txt(699)
            UpdateProductTransactionRecord(dr)
         ElseIf (oldStatus = 1 Or oldStatus = 2) And (dr.od_iStatus = 1 Or dr.od_iStatus = 2) Then
            If oldQuant <> dr.od_iQuantity Then
               'check if quantity is adding or subtracting for type
               If (oldQuant - dr.od_iQuantity) < 0 Then
                  quantDiff = (oldQuant - dr.od_iQuantity) * -1
                  dr.pn_iChanged = quantDiff
                  dr.pn_iType = 3
                  dr.pn_szDescription = Txt(694)

                  TestConnection()
                  dr.ocmd.CommandText = "SELECT TOP 1 pn_iRemaining FROM PRO_TRANSACTION WHERE pn_PRO_PRODUCT = " + CStr(dr.od_PRO_PRODUCT) + " ORDER BY pn_dDate Desc"
                  dr.oread = dr.ocmd.ExecuteReader()
                  If dr.oread.HasRows = True Then
                     dr.oread.Read()
                     dr.pn_iRemaining = dr.oread("pn_iRemaining")
                  Else
                     dr.pn_iRemaining = 0
                  End If
                  dr.oread.Close()

                  dr.pn_iRemaining -= dr.pn_iChanged
                  If dr.pn_iRemaining < 0 Then
                     MsgDsp(Txt(691))
                     Exit Sub
                  End If
                  UpdateProductTransactionRecord(dr)
               Else
                  quantDiff = (oldQuant - dr.od_iQuantity)
                  dr.pn_iChanged = quantDiff
                  dr.pn_iType = 4
                  dr.pn_szDescription = Txt(694)

                  TestConnection()
                  dr.ocmd.CommandText = "SELECT TOP 1 pn_iRemaining FROM PRO_TRANSACTION WHERE pn_PRO_PRODUCT = " + CStr(dr.od_PRO_PRODUCT) + " ORDER BY pn_dDate Desc"
                  dr.oread = dr.ocmd.ExecuteReader()
                  If dr.oread.HasRows = True Then
                     dr.oread.Read()
                     dr.pn_iRemaining = dr.oread("pn_iRemaining")
                  Else
                     dr.pn_iRemaining = 0
                  End If
                  dr.oread.Close()

                  dr.pn_iRemaining += dr.pn_iChanged
                  UpdateProductTransactionRecord(dr)
               End If
            End If
         ElseIf (oldStatus = 3 Or oldStatus = 4) And (dr.od_iStatus = 3 Or dr.od_iStatus = 4) Then
            dr.od_iQuantity = oldQuant
         ElseIf (oldStatus = 3 Or oldStatus = 4) And (dr.od_iStatus = 1 Or dr.od_iStatus = 2) Then
            InitProductTransaction(dr)
            dr.pn_iType = 3
            dr.pn_iKey = dr.od_iid
            dr.pn_iChanged = dr.od_iQuantity
            dr.pn_PRO_PRODUCT = dr.od_PRO_PRODUCT
            dr.pn_szDescription = Txt(41)

            TestConnection()
            dr.ocmd.CommandText = "SELECT TOP 1 pn_iRemaining FROM PRO_TRANSACTION WHERE pn_PRO_PRODUCT = " + CStr(dr.od_PRO_PRODUCT) + " ORDER BY pn_dDate Desc"
            dr.oread = dr.ocmd.ExecuteReader()
            If dr.oread.HasRows = True Then
               dr.oread.Read()
               dr.pn_iRemaining = dr.oread("pn_iRemaining")
            Else
               dr.pn_iRemaining = 0
            End If
            dr.oread.Close()

            dr.pn_iRemaining -= dr.pn_iChanged
            If dr.pn_iRemaining < 0 Then
               MsgDsp(Txt(691))
               Exit Sub
            End If
            UpdateProductTransactionRecord(dr)
         End If
      End If

      UpdateOrderDetailRecord(dr)
      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
      Me.Close()
   End Sub
   Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
      Dim tDec1@ = 0
      dr.LIST_CTRL = 16
      ScreenToRecord()
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         GetProductRecord(dr.od_PRO_PRODUCT, dr)
         dr.productPrice = 0
         Dim frm1 As productpriceselectfrm
         frm1 = New productpriceselectfrm
         frm1.ShowDialog()
         If dr.productPrice <> 0 Then
            GetProductTypeRecord(dr.pp_PRO_TYPE, dr)
            dr.od_rTypeDiscount = 0
            If dr.pt_iSpecial = 2 Then
               If Now.Date >= dr.pt_dSpecialStart And Now.Date <= dr.pt_dSpecialEnd Then
                  If MsgBox(Txt(829), vbYesNo, Txt(575)) = MsgBoxResult.Yes Then
                     'tDec1 = (dr.pt_rSpecialPercent / 100) * dr.productPrice
                     'dr.productPrice = dr.productPrice - tDec1
                     dr.od_rTypeDiscount = dr.pt_rSpecialPercent
                  End If
               End If
            End If
            dr.od_rWeight = dr.pp_rWeight
            dr.od_rLength = dr.pp_rLength
            dr.od_rWidth = dr.pp_rWidth
            dr.od_rHeight = dr.pp_rHeight
            dr.od_iPackMaterial = dr.pp_iPackMaterials
            dr.od_rPiecePrice = dr.productPrice
            'dr.od_iPackaged = dr.pp
            Display()
         Else
            dr.od_PRO_PRODUCT = 0
            dr.od_rTypeDiscount = 0
            MsgDsp(Txt(824))
            Display()
         End If
      End If
   End Sub
#End Region
#Region "Got Focus"
   Private Sub txtQuantity_GotFocus(sender As Object, e As EventArgs) Handles txtQuantity.GotFocus
      SetText(txtQuantity)
   End Sub
#End Region
End Class