Imports SFTSTORE.ftn
Imports SFTSTORE.data
Imports SFTSTORE.reportpdf

Public Class maintenancefrm
   Private Sub maintenancefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      lblSelect.Text = Txt(612) + ":"
      Me.Text = Txt(803)

      btnNew.Text = Txt(379)
      btnOpen.Text = Txt(380)
      btnSave.Text = Txt(382)
      btnDelete.Text = Txt(383)
      btnClose.Text = Txt(390)

      cmbSelect.Items.Add(New ComboClass(1, Txt(800)))
      cmbSelect.SelectedIndex = 0
      Inits()
   End Sub
   Private Sub Inits()
      Dim tl1& = 0
      tl1 = CType(cmbSelect.SelectedItem, ComboClass).Value
      If tl1 = 1 Then
         LanguageFilterInits(dr)
      End If
      Display()
   End Sub
   Private Sub Display()
      Dim tl1& = 0
      tl1 = CType(cmbSelect.SelectedItem, ComboClass).Value
      If tl1 = 1 Then
         txt1.Text = dr.lf_szFilter
         lbl1.Text = Txt(798) + ":"
      End If
   End Sub
   Private Function Validation()
      Validation = 0
      Dim tl1& = 0
      tl1 = CType(cmbSelect.SelectedItem, ComboClass).Value
      If tl1 = 1 Then
         If dr.lf_szFilter = "" Then
            txt1.Focus()
            MsgDsp(Txt(799))
            Exit Function
         End If
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM LAN_FILTER WHERE lf_szFilter = '" + dr.lf_szFilter + "' AND lf_iid <> " + CStr(dr.lf_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            txt1.Focus()
            MsgDsp(Txt(802))
            Exit Function
         End If
         dr.oread.Close()
      End If
      Validation = 1
   End Function
   Private Sub ScreenToRecord()
      Dim tl1& = 0
      tl1 = CType(cmbSelect.SelectedItem, ComboClass).Value
      If tl1 = 1 Then
         dr.lf_szFilter = Trim(txt1.Text)
      End If
   End Sub
#Region "Click events"
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      Inits()
   End Sub

   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      Dim tl1& = 0
      tl1 = CType(cmbSelect.SelectedItem, ComboClass).Value
      If tl1 = 1 Then
         dr.LIST_CTRL = 28
         Dim frm As listfrm
         frm = New listfrm
         frm.ShowDialog()
         If dr.LIST_RET = 1 Then
            Display()
            txt1.Focus()
         End If
      End If
   End Sub

   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1& = 0, tl2& = 0
      tl1 = CType(cmbSelect.SelectedItem, ComboClass).Value
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      If tl1 = 1 Then
         tl2 = dr.lf_iid
         UpdateLanguageFilterRecord(dr)
      End If
      If tl2 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
   End Sub

   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tl1& = 0, tstr1$ = ""
      tl1 = CType(cmbSelect.SelectedItem, ComboClass).Value
      If tl1 = 1 Then
         If dr.lf_iid > 0 Then
            If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
               ExecuteScalar(dr.szConnection, "DELETE FROM LAN_FILTER WHERE lf_iid = " + CStr(dr.lf_iid), tstr1)
               btnNew_Click(sender, e)
               MsgDsp(Txt(355))
            End If
         End If
      End If
   End Sub
#End Region
#Region "Got Focus"

#End Region

   Private Sub cmbSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelect.SelectedIndexChanged
      Dim tl1& = 0
      tl1 = CType(cmbSelect.SelectedItem, ComboClass).Value
      If tl1 = 1 Then
         txt1.Visible = True
         lbl1.Visible = True
      ElseIf tl1 = 2 Then

      End If
   End Sub

   Private Sub btnhey_Click(sender As Object, e As EventArgs) Handles btnhey.Click
      'Dim array$()
      'Dim tstr1$ = "", tl2& = 0

      'tstr1 = "4r5e| 5h1t| 5hit| a55| anal| anus| ar5e| arrse| arse| ass| ass-fucker| asses| assfucker| assfukka| asshole| assholes| asswhole| a_s_s| b!tch| b00bs| b17ch| b1tch| ballbag| balls| ballsack| bastard| beastial| beastiality| bellend| bestial| bestiality| bi+ch| biatch| bitch| bitcher| bitchers| bitches| bitchin| bitching| bloody| blow job| blowjob| blowjobs| boiolas| bollock| bollok| boner| boob| boobs| booobs| boooobs| booooobs| booooooobs| breasts| buceta| bugger| bum| bunny fucker| butt| butthole| buttmuch| buttplug| c0ck| c0cksucker| carpet muncher| cawk| chink| cipa| cl1t| clit| clitoris| clits| cnut| cock| cock-sucker| cockface| cockhead| cockmunch| cockmuncher| cocks| cocksuck | cocksucked | cocksucker| cocksucking| cocksucks | cocksuka| cocksukka| cok| cokmuncher| coksucka| coon| cox| crap| cum| cummer| cumming| cums| cumshot| cunilingus| cunillingus| cunnilingus| cunt| cuntlick | cuntlicker | cuntlicking | cunts| cyalis| cyberfuc| cyberfuck | cyberfucked | cyberfucker| cyberfuckers| cyberfucking | d1ck| damn| dick| dickhead| dildo| dildos| dink| dinks| dirsa| dlck| dog-fucker| doggin| dogging| donkeyribber| doosh| duche| dyke| ejaculate| ejaculated| ejaculates | ejaculating | ejaculatings| ejaculation| ejakulate| f u c k| f u c k e r| f4nny| fag| fagging| faggitt| faggot| faggs| fagot| fagots| fags| fanny| fannyflaps| fannyfucker| fanyy| fatass| fcuk| fcuker| fcuking| feck| fecker| felching| fellate| fellatio| fingerfuck | fingerfucked | fingerfucker | fingerfuckers| fingerfucking | fingerfucks | fistfuck| fistfucked | fistfucker | fistfuckers | fistfucking | fistfuckings | fistfucks | flange| fook| fooker| fuck| fucka| fucked| fucker| fuckers| fuckhead| fuckheads| fuckin| fucking| fuckings| fuckingshitmotherfucker| fuckme | fucks| fuckwhit| fuckwit| fudge packer| fudgepacker| fuk| fuker| fukker| fukkin| fuks| fukwhit| fukwit| fux| fux0r| f_u_c_k| gangbang| gangbanged | gangbangs | gaylord| gaysex| goatse| God| god-dam| god-damned| goddamn| goddamned| hardcoresex | hell| heshe| hoar| hoare| hoer| homo| hore| horniest| horny| hotsex| jack-off | jackoff| jap| jerk-off | jism| jiz | jizm | jizz| kawk| knob| knobead| knobed| knobend| knobhead| knobjocky| knobjokey| kock| kondum| kondums| kum| kummer| kumming| kums| kunilingus| l3i+ch| l3itch| labia| lmfao| lust| lusting| m0f0| m0fo| m45terbate| ma5terb8| ma5terbate| masochist| master-bate| masterb8| masterbat*| masterbat3| masterbate| masterbation| masterbations| masturbate| mo-fo| mof0| mofo| mothafuck| mothafucka| mothafuckas| mothafuckaz| mothafucked | mothafucker| mothafuckers| mothafuckin| mothafucking | mothafuckings| mothafucks| mother fucker| motherfuck| motherfucked| motherfucker| motherfuckers| motherfuckin| motherfucking| motherfuckings| motherfuckka| motherfucks| muff| mutha| muthafecker| muthafuckker| muther| mutherfucker| n1gga| n1gger| nazi| nigg3r| nigg4h| nigga| niggah| niggas| niggaz| nigger| niggers | nob| nob jokey| nobhead| nobjocky| nobjokey| numbnuts| nutsack| orgasim | orgasims | orgasm| orgasms | p0rn| pawn| pecker| penis| penisfucker| phonesex| phuck| phuk| phuked| phuking| phukked| phukking| phuks| phuq| pigfucker| pimpis| piss| pissed| pisser| pissers| pisses | pissflaps| pissin | pissing| pissoff | poop| porn| porno| pornography| pornos| prick| pricks | pron| pube| pusse| pussi| pussies| pussy| pussys | rectum| retard| rimjaw| rimming| s hit| s.o.b.| sadist| schlong| screwing| scroat| scrote| scrotum| semen| sex| sh!+| sh!t| sh1t| shag| shagger| shaggin| shagging| shemale| shi+| shit| shitdick| shite| shited| shitey| shitfuck| shitfull| shithead| shiting| shitings| shits| shitted| shitter| shitters | shitting| shittings| shitty | skank| slut| sluts| smegma| smut| snatch| son-of-a-bitch| spac| spunk| s_h_i_t| t1tt1e5| t1tties| teets| teez| testical| testicle| tit| titfuck| tits| titt| tittie5| tittiefucker| titties| tittyfuck| tittywank| titwank| tosser| turd| tw4t| twat| twathead| twatty| twunt| twunter| v14gra| v1gra| vagina| viagra| vulva| w00se| wang| wank| wanker| wanky| whoar| whore| willies| willy| xrated| xxx"
      'array = Split(tstr1, "| ")
      'For tl1 = 0 To UBound(array) - 1
      '   tl2 = 0
      '   LanguageFilterInits(dr)
      '   dr.lf_szFilter = array(tl1)
      '   TestConnection()
      '   dr.ocmd.CommandText = "SELECT * FROM LAN_FILTER WHERE lf_szFilter = '" + dr.lf_szFilter + "'"
      '   dr.oread = dr.ocmd.ExecuteReader()
      '   If dr.oread.HasRows = False Then
      '      tl2 = 1
      '   End If
      '   dr.oread.Close()
      '   If tl2 = 1 Then
      '      UpdateLanguageFilterRecord(dr)
      '   End If
      'Next
      'tl2 = 0
   End Sub
End Class