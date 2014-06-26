Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMntSubAsiento
    Inherits System.Windows.Forms.Form

    Dim modoinsert As Boolean
    Dim modoedit As Boolean
    Dim rs As New ADODB.Recordset
    Dim rsAsiento As ADODB.Recordset

    Private Sub frmMantSubAsiento_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call ConfiguraForm()
        Call MuestraDatosAsiento()
        SSTab1.TabPages.Item(0).Enabled = True

    End Sub

    Private Sub frmMantSubAsiento_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        rs = Nothing
        rsAsiento = Nothing
    End Sub

    Sub ConfiguraForm()
        SSTab1.SelectedIndex = 0
        SSTab1.TabPages.Item(1).Enabled = False
        SSTab1.TabPages.Item(2).Enabled = False
        Ctr_Ayuda1.conexion(VGCNx)
        Ctr_Ayuda2.conexion(VGCNx)
        Ctr_Ayuda1.Filtro = "where asientocodigo<>'00'"
        cAcepta.Enabled = False
        lblNumReg.Text = CStr(Nothing)
        'Me.Width = VB6.TwipsToPixelsX(6825)
        'Me.Height = VB6.TwipsToPixelsY(7815)
    End Sub

    Sub MuestraDatosAsiento()
        Dim SQL As String
        rsAsiento = New ADODB.Recordset
        SQL = "SELECT asientocodigo as Codigo,asientodescripcion as Descripción FROM ct_asiento WHERE asientocodigo<>'00' ORDER BY 1"
        rsAsiento = VGCNx.Execute(SQL)
        TDBGrid1.DataSource = rsAsiento
        TDBGrid1.Columns(0).Width = 60
        TDBGrid1.Columns(1).Width = 220
        lblNumReg.Text = CStr(rsAsiento.RecordCount)
    End Sub

    Private Sub Ctr_Ayuda1_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_Ayuda1.AlDevolverDato
        Call MuestraDatosSubAsiento()
    End Sub
    Public Function MuestraDatosSubAsiento() As Object
        Dim SQL As String
        SQL = "SELECT ct_subasiento.subasientocodigo, ct_subasiento.subasientodescripcion,"
        SQL = SQL & "ct_subasiento.subasientoglosa,ct_subasiento.subasientorepitedoc,gr_moneda.monedadescripcion,"
        SQL = SQL & "ct_subasiento.subasientonumcorr01, ct_subasiento.subasientonumcorr02, ct_subasiento.subasientonumcorr03, ct_subasiento.subasientonumcorr04,"
        SQL = SQL & "ct_subasiento.subasientonumcorr05, ct_subasiento.subasientonumcorr06, ct_subasiento.subasientonumcorr07, ct_subasiento.subasientonumcorr08,"
        SQL = SQL & "ct_subasiento.subasientonumcorr09, ct_subasiento.subasientonumcorr10, ct_subasiento.subasientonumcorr11, ct_subasiento.subasientonumcorr12,ct_subasiento.monedacodigo "
        SQL = SQL & "FROM ct_subasiento INNER JOIN gr_moneda ON ct_subasiento.monedacodigo = gr_moneda.monedacodigo "
        SQL = SQL & "INNER JOIN ct_asiento ON ct_subasiento.asientocodigo = ct_asiento.asientocodigo "
        SQL = SQL & "WHERE ct_subasiento.subasientocodigo<>'00' AND "
        SQL = SQL & "ct_subasiento.asientocodigo='" & Trim(Ctr_Ayuda1.xclave) & "' "
        SQL = SQL & "ORDER BY 1,2"
        rs = VGCNx.Execute(SQL)
        TDBGrid3.DataSource = rs
        Call ConfiguraGridSubAsientos()
        If rs.RecordCount <= 0 Then Call LimpiarForm(Me, "ctr_ayuda1")

    End Function

    Private Sub cAcepta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cAcepta.Click
        Dim SQL As String = ""
        On Error GoTo X

        VGCNx.BeginTrans()

        If modoinsert = True Then
            SQL = "INSERT INTO CT_SUBASIENTO (subasientocodigo,asientocodigo,monedacodigo,subasientodescripcion,"
            SQL = SQL & "subasientoglosa,subasientorepitedoc,usuariocodigo,fechaact) "
            SQL = SQL & "VALUES ('" & txt0.CtlText & "','" & Ctr_Ayuda1.xclave & "','" & Ctr_Ayuda2.xclave & "','" & Trim(UCase(txt1.CtlText)) & "','"
            SQL = SQL & txt14.CtlText & " '," & chk.CheckState & ",'"
            SQL = SQL & VGUsuario & "','" & Today & "')"

        ElseIf modoedit = True Then
            SQL = "UPDATE CT_SUBASIENTO SET monedacodigo='" & Ctr_Ayuda2.xclave & "',"
            SQL = SQL & "subasientodescripcion='" & Trim(UCase(txt1.CtlText)) & "',"
            SQL = SQL & "subasientonumcorr01=" & ESNULO(txt(2).CtlText, 0) & ",subasientonumcorr02=" & ESNULO(txt(3).CtlText, 0) & ",subasientonumcorr03=" & ESNULO(txt(4).CtlText, 0) & ","
            SQL = SQL & "subasientonumcorr04=" & ESNULO(txt5.CtlText, 0) & ",subasientonumcorr05=" & ESNULO(txt6.CtlText, 0) & ",subasientonumcorr06=" & ESNULO(txt(7).CtlText, 0) & ","
            SQL = SQL & "subasientonumcorr07=" & ESNULO(txt8.CtlText, 0) & ",subasientonumcorr08=" & ESNULO(txt(9).CtlText, 0) & ",subasientonumcorr09=" & ESNULO(txt(10).CtlText, 0) & ","
            SQL = SQL & "subasientonumcorr10=" & ESNULO(txt11.CtlText, 0) & ",subasientonumcorr11=" & ESNULO(txt12.CtlText, 0) & ",subasientonumcorr12=" & ESNULO(txt(13).CtlText, 0) & ","
            SQL = SQL & "subasientoglosa='" & txt14.CtlText & "',subasientorepitedoc=" & chk.CheckState & ","
            SQL = SQL & "usuariocodigo='" & VGUsuario & "',fechaact='" & Today & "' "
            SQL = SQL & "WHERE subasientocodigo='" & txt0.CtlText & "' AND asientocodigo='" & Ctr_Ayuda1.xclave & "'"
        End If

        VGCNx.Execute(SQL)
        VGCNx.CommitTrans()
        frmbotones.Visible = True
        modoinsert = False : modoedit = False : lblMensaje.Text = CStr(Nothing)
        Call MuestraDatosSubAsiento()
        cAcepta.Enabled = False
        Call ModoEditable(False, Me, "")
        Exit Sub

X:
        If Err.Number = -2147217873 Then
            MsgBox("Esta intentando registrar Código de SubAsiento Existente ", MsgBoxStyle.Information, Text)
            txt0.Focus()
        Else
            MsgBox("Error inesperado: " & Err.Number & " " & Err.Description, MsgBoxStyle.Information, Text)
        End If
        VGCNx.RollbackTrans()

    End Sub

    Private Sub cCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cCancela.Click
        frmbotones.Visible = True
        modoinsert = False : modoedit = False : lblMensaje.Text = CStr(Nothing)
        cAcepta.Enabled = False
        SSTab1.SelectedIndex = 0
        SSTab1.TabPages.Item(0).Enabled = True
        SSTab1.TabPages.Item(1).Enabled = False
        SSTab1.TabPages.Item(2).Enabled = False
    End Sub

    Private Sub SSTab1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SSTab1.SelectedIndexChanged
        Static PreviousTab As Short = SSTab1.SelectedIndex()
        If PreviousTab = 0 Then SSTab1.TabPages.Item(PreviousTab).Enabled = False
        PreviousTab = SSTab1.SelectedIndex()
    End Sub

    Private Sub TDBGrid1_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_HeadClickEvent) Handles TDBGrid1.HeadClick
        On Error Resume Next
         If IsNothing(rs.Sort) Then
            rs.Sort = TDBGrid1.Columns.Item(eventArgs.ColIndex).DataField & " asc"
        ElseIf VB.Right(rs.Sort, 3) = "asc" Then
            rs.Sort = TDBGrid1.Columns.Item(eventArgs.ColIndex).DataField & " desc"
        ElseIf VB.Right(rs.Sort, 4) = "desc" Then
            rs.Sort = TDBGrid1.Columns.Item(eventArgs.ColIndex).DataField & " asc"
        End If
        TDBGrid1.Refresh()
    End Sub

    Private Sub TDBGrid1_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBGrid1.DblClick
        If rsAsiento.RecordCount > 0 Then
            SSTab1.TabPages.Item(1).Enabled = True
            SSTab1.TabPages.Item(2).Enabled = False
            SSTab1.SelectedIndex = 1
            Ctr_Ayuda1.xclave = TDBGrid1.Columns(0).Text : Ctr_Ayuda1.Ejecutar()
            Ctr_Ayuda1.CtlEnabled = False
            Call ModoEditable(False, gbDatos, "Ctr_Ayuda1")
            cAcepta.Enabled = False
        End If
    End Sub
    Private Sub TDBGrid2_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_RowColChangeEvent) Handles TDBGrid3.RowColChange
        Call EditarSubAsiento()
    End Sub

    Private Sub txt_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Change
        Dim Index As Short = txt.GetIndex(eventSender)
        If modoinsert = True Or modoedit = True Then
            cAcepta.Enabled = ValidaDataIngreso()
        End If
    End Sub
    Private Sub chk_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chk.CheckStateChanged
        If modoinsert = True Or modoedit = True Then cAcepta.Enabled = ValidaDataIngreso()
    End Sub

    Private Sub txt_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyPressEvent) Handles txt.KeyPressEvent
        Dim Index As Short = txt.GetIndex(eventSender)
        If eventArgs.KeyAscii = 13 And Index = 15 Then
            cAcepta.Focus()
            Call cAcepta_Click(cAcepta, New System.EventArgs())
        End If
    End Sub

    Private Sub txt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Leave
        Dim Index As Short = txt.GetIndex(eventSender)
        If Index = 0 Then
            If Not IsDBNull(txt0.CtlText) Then txt0.CtlText = VB6.Format(txt0.CtlText, "0000")
        Else
            txt(Index).CtlText = UCase(txt(Index).CtlText)
        End If
    End Sub

    Sub EditarSubAsiento()
        Dim i As Short

        If rs.RecordCount > 0 Then
            With TDBGrid3
                For i = 2 To 13
                    txt(i).CtlText = TDBGrid3.Columns(i + 3).Value
                Next
                txt0.CtlText = .Columns(0).Value
                txt1.CtlText = .Columns(1).Value
                txt14.CtlText = .Columns(2).Value
                chk.CheckState = IIf(.Columns(3).Value = 0, 0, 1)
                Ctr_Ayuda2.xclave = .Columns(17).Value : Ctr_Ayuda2.Ejecutar()
            End With

        End If
    End Sub

    Sub ConfiguraGridSubAsientos()
        Dim i As Short
        With TDBGrid3
            .Columns(0).Width = 60
            .Columns(1).Width = 220
            .Columns(2).Width = 80
            .Columns(3).Width = 100
            .Columns(4).Width = 90
            For i = 5 To 16
                .Columns(i).Width = 90
            Next
        End With

    End Sub

    Function ValidaDataIngreso() As Boolean
        Dim i As Short
        If IsNothing(Ctr_Ayuda1.xclave) Then
            ValidaDataIngreso = False
            Exit Function
        End If
        If IsNothing(Ctr_Ayuda2.xclave) Then
            ValidaDataIngreso = False
            Exit Function
        End If

        For i = 0 To 1
            If IsNothing(txt(i).CtlText) Then
                ValidaDataIngreso = False
                Exit Function
            End If

        Next
        If IsNothing(txt14.CtlText) Then
            ValidaDataIngreso = False
            Exit Function
        End If

        ValidaDataIngreso = True
    End Function

    Private Sub TDBGrid1_AfterColUpdate(ByVal sender As System.Object, ByVal e As AxTrueOleDBGrid70.TrueDBGridEvents_AfterColUpdateEvent) Handles TDBGrid1.AfterColUpdate

    End Sub

    Private Sub cmdBotones0_Click(sender As Object, e As EventArgs) Handles cmdBotones0.Click
        SSTab1.TabPages.Item(2).Enabled = True
        SSTab1.SelectedIndex = 1

        Call LimpiarForm(Me, "Ctr_Ayuda1")
        txt0.CtlText = GeneraCodigo(VGCNx, "Select max(subasientocodigo) from ct_subasiento where asientocodigo='" & Ctr_Ayuda1.xclave & "'", "0000")
        txt0.Focus()
        Call ModoEditable(True, gbDatos, "Ctr_Ayuda1")
        frmbotones.Visible = False
        modoinsert = True
        lblMensaje.Text = "Nuevo"
    End Sub

    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
        If TDBGrid1.Row < 0 Then
            Exit Sub
        End If
        SSTab1.TabPages.Item(2).Enabled = True
        SSTab1.SelectedIndex = 1
        modoedit = True
        frmbotones.Visible = False
        Call ModoEditable(True, gbDatos, "Ctr_Ayuda1")
        lblMensaje.Text = "Editar"
    End Sub

    Private Sub cmdBotones2_Click(sender As Object, e As EventArgs) Handles cmdBotones2.Click

        On Error GoTo X

        If MsgBox("Desea eliminar el registro de SubAsiento Nº " & TDBGrid3.Columns(0).Value & "?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "AVISO") = MsgBoxResult.Yes Then
            SQL = "DELETE FROM CT_SUBASIENTO WHERE subasientocodigo='" & Trim(TDBGrid3.Columns(0).Value) & "' AND "
            SQL = SQL & "asientocodigo='" & Trim(Ctr_Ayuda1.xclave) & "'"
            VGCNx.Execute(SQL)
            Call MuestraDatosSubAsiento()
        End If

        Exit Sub

X:
        MsgBox("Registro no podrá Eliminarse mientras exista Información en la Tablas Relacionadas", MsgBoxStyle.Information, Text)

    End Sub

    Private Sub cmdBotones3_Click(sender As Object, e As EventArgs) Handles cmdBotones3.Click
        Call Impresion("rptSubAsiento.rpt")
    End Sub

    Private Sub cmdBotones4_Click(sender As Object, e As EventArgs) Handles cmdBotones4.Click
        Me.Close()
    End Sub

End Class