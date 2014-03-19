Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMantPlanCuentas
	Inherits System.Windows.Forms.Form
	
	Dim modoinsert As Boolean
	Dim modoedit As Boolean
	Dim i_filaorigen As Short
	Dim rs As New ADODB.Recordset
	Dim rsDist As New ADODB.Recordset
	Dim cCta As String
	Dim dCta As String
    Dim xCuenta As String
    Dim xdllgen As New dllgeneral.dll_general
    Dim FLAGMOVIMIENTODISTRI As Boolean
    Dim FLAGDISTRIBUCION As Boolean
    Dim l_error As String



    Private Sub frmMantPlanCuentas_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        l_error = CStr(Nothing)
        Call ConfiguraForm()
        Call MuestraDatos(CStr(Nothing))
        Call Arbol((txtBuscar.CtlText))
        xdllgen = New dllgeneral.dll_general
        If Len(l_error) > 0 Then
            frmError.RichError.Text = l_error
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
            frmError.ShowDialog()
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
        TDBGrid1.FetchRowStyle = True
        xCuenta = "%"
        SSTab1.Enabled = True





    End Sub

    Sub ConfiguraForm()
        SSTab1.SelectedIndex = 0



        Ctr_Ayuda1.CadenaCone = VGCNxSql
        Ctr_Ayuda2.CadenaCone = VGCNxSql
        Ctr_Ayuda3.CadenaCone = VGCNxSql
        Ctr_Ayuda2.Filtro = "where empresacodigo='" & VGParametros.empresacodigo & "' and cuentanivel=" & VGnumnivelescuenta
        Ctr_Ayuda3.Filtro = "where empresacodigo='" & VGParametros.empresacodigo & "' and  cuentanivel=" & VGnumnivelescuenta
        Ctr_Ayuda4.CadenaCone = VGCNxSql
        cAcepta.Enabled = False
        lblNumReg.Text = CStr(Nothing)
        Me.Width = VB6.TwipsToPixelsX(11310)
        Me.Height = VB6.TwipsToPixelsY(8250)
        FLAGMOVIMIENTODISTRI = False
        FLAGDISTRIBUCION = False
        Call IniciaGridDist()
    End Sub

    Public Sub MuestraDatos(ByRef xCta As String)
        Dim SQL As String
        SQL = "SELECT a.cuentacodigo, cuentadescripcion, cuentalineaactivo, cuentalineapasivo,cuentanatu,"
        SQL = SQL & "cuentalineaegp,cuentanategp, cuentaestadoanalitico,a.tipoanaliticocodigo, cuentaestadoccostos,"
        SQL = SQL & "cuentadocumento,cuentanivel,b.tipoanaliticodescripcion,cuentaestadodistribucion,cuentaestado,tipocuentacodigo,tipoajuste,cuentaadicionacargo "
        SQL = SQL & "FROM ct_cuenta a INNER JOIN  ct_tipoanalitico b ON a.tipoanaliticocodigo =b.tipoanaliticocodigo "
        SQL = SQL & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo<>'00'"
        If Not IsNothing(xCta) Then
            SQL = SQL & " AND a.cuentacodigo like '" & Trim(xCta) & "%' "
        End If
        SQL = SQL & " ORDER BY 1"
        rs = VGCNx.Execute(SQL)
        TDBGrid1.DataSource = rs
        Call ConfiguraTdbgrid()
        lblNumReg.Text = CStr(rs.RecordCount)
        SSTab1.SelectedIndex = 0
    End Sub

    Private Sub txtBuscar_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyDownEvent) Handles txtBuscar.KeyDownEvent
        If eventArgs.keyCode = 13 Then
            Call cmdBuscar_Click(cmdBuscar, New System.EventArgs())
        End If
    End Sub

    Private Sub cmdBuscar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBuscar.Click
        VGvardllgen = New dllgeneral.dll_general
        txtBuscar.CtlText = VGvardllgen.ESNULO((txtBuscar.CtlText), "%")
        Call MuestraDatos((txtBuscar.CtlText))
        Call Arbol((txtBuscar.CtlText))
    End Sub

    Sub EditarValores()
        With TDBGrid1

            Text0.ValorTxt = Trim(xdllgen.ESNULO((.Columns(0).Text), Nothing))
            Text1.ValorTxt = Trim(xdllgen.ESNULO((.Columns(1).Text), Nothing))
            Text2.ValorTxt = Trim(xdllgen.ESNULO((.Columns(2).Text), Nothing))
            Text3.ValorTxt = Trim(xdllgen.ESNULO((.Columns(3).Text), Nothing))
            Text4.ValorTxt = Trim(xdllgen.ESNULO((.Columns(4).Text), Nothing))
            Text5.ValorTxt = Trim(xdllgen.ESNULO((.Columns(5).Text), Nothing))
            Text6.ValorTxt = Trim(xdllgen.ESNULO((.Columns(6).Text), Nothing))


            chk(0).CheckState = IIf(CDbl(Trim(.Columns(7).Text)) = -1, 1, 0)
            Ctr_Ayuda1.Codigo = Trim(xdllgen.ESNULO((.Columns(8).Text), Nothing)) : Ctr_Ayuda1.LlenayDevuelve()
            chk(1).CheckState = IIf(CDbl(Trim(.Columns(9).Text)) = -1, 1, 0)
            chk(2).CheckState = IIf(CDbl(Trim(.Columns(10).Text)) = -1, 1, 0)
            chk(3).CheckState = IIf(CDbl(Trim(.Columns(13).Text)) = -1, 1, 0)
            chk(4).CheckState = IIf(CDbl(Trim(.Columns(14).Text)) = -1, 1, 0)
            chk(5).CheckState = IIf(CDbl(Trim(.Columns(17).Text)) = 1, 1, 0)
            lblNivel.Text = Trim(xdllgen.ESNULO((.Columns(11).Text), Nothing))
            Ctr_Ayuda4.Codigo = xdllgen.ESNULO((.Columns(15).Text), Nothing) : Ctr_Ayuda4.LlenayDevuelve()

            cboTipoAjuste.SelectedIndex = CShort(.Columns(16).Text)

        End With
        Call ConfiguraModoEdicion()
    End Sub

    Sub ConfiguraModoEdicion()
        If IsNothing(lblNivel.Text) Or lblNivel.Text = "" Then

            MsgBox("Debe registrar el Código de Cuenta Contable", MsgBoxStyle.Information, Text)
            Call ModoNormal() 'Deshabilitar todos los objetos de ingreso

        Else
            If CDbl(lblNivel.Text) = 1 Then 'Preguntar por 1º Nivel
                Ctr_Ayuda4.Enabled = True
            Else
                Ctr_Ayuda4.Enabled = False
            End If

            If CDbl(lblNivel.Text) = VGnumnivelescuenta Then
                Call ModoEdicion(True)
            Else
                Call ModoEdicion(False)
            End If
        End If
    End Sub

    Public Sub LimpiarValores()
        Dim i As Short
        Ctr_Ayuda1.Codigo = CStr(Nothing)
        Ctr_Ayuda1.Descripcion = CStr(Nothing)
        Ctr_Ayuda4.Codigo = CStr(Nothing)
        Ctr_Ayuda4.Descripcion = CStr(Nothing)


        Text0.ValorTxt = Nothing
        Text1.ValorTxt = Nothing
        Text2.ValorTxt = Nothing
        Text3.ValorTxt = Nothing
        Text4.ValorTxt = Nothing
        Text5.ValorTxt = Nothing
        Text6.ValorTxt = Nothing


        For i = 0 To 3
            chk(i).CheckState = System.Windows.Forms.CheckState.Unchecked
        Next
        chk(4).CheckState = System.Windows.Forms.CheckState.Checked
        lblNivel.Text = CStr(Nothing)
        'cboTipoAjuste.SelText = Empty

    End Sub

    Private Sub cAcepta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cAcepta.Click
        If ValidarData() = True Then
            Call GrabarData()
        End If
    End Sub

    Private Sub cCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cCancela.Click
        SSTab1.TabPages.Item(0).Enabled = True
        SSTab1.SelectedIndex = 0
        SSTab1.Focus()
        Toolbar1.Visible = True
        TreeView1.Enabled = True
        modoinsert = False
        modoedit = False
        i_filaorigen = -1
        FLAGDISTRIBUCION = False



    End Sub

    Sub GrabarData()
        Dim SQL As String
        'On Error GoTo X

        SSTab1.TabPages.Item(0).Enabled = True
        If cboTipoAjuste.SelectedIndex < 0 Then cboTipoAjuste.SelectedIndex = 0

        If modoinsert = True Then
            VGCNx.BeginTrans()
            SQL = GrabarPlanCuenta(0, Text0.ValorTxt, Text1.ValorTxt, Val(Text2.ValorTxt), Val(Text3.ValorTxt), Val(Text5.ValorTxt), Text4.ValorTxt, Text6.ValorTxt, chk(1).CheckState, chk(0).CheckState, chk(2).CheckState, CShort(lblNivel.Text), (Ctr_Ayuda1.Codigo), chk(3).CheckState, (Ctr_Ayuda4.Codigo), VB.Left(VB6.GetItemString(cboTipoAjuste, cboTipoAjuste.SelectedIndex), 2), CStr(chk(5).CheckState))
            VGCNx.Execute(SQL)

            If CShort(lblNivel.Text) = VGnumnivelescuenta And FLAGDISTRIBUCION = True Then
                Call GrabarCuentaDistribucion()
                Call GrabarTablaSaldos()
            End If

            VGCNx.CommitTrans()
            Call Arbol((txtBuscar.CtlText))

        ElseIf modoedit = True Then
            VGCNx.BeginTrans()
            SQL = GrabarPlanCuenta(1, Text0.ValorTxt, Text1.ValorTxt, Val(Text2.ValorTxt), Val(Text3.ValorTxt), Val(Text5.ValorTxt), Text4.ValorTxt, Text6.ValorTxt, chk(1).CheckState, chk(0).CheckState, chk(2).CheckState, CShort(lblNivel.Text), (Ctr_Ayuda1.Codigo), chk(3).CheckState, (Ctr_Ayuda4.Codigo), VB.Left(VB6.GetItemString(cboTipoAjuste, cboTipoAjuste.SelectedIndex), 2), CStr(chk(5).CheckState))
            VGCNx.Execute(SQL)

            If CShort(lblNivel.Text) = VGnumnivelescuenta And FLAGDISTRIBUCION = True Then
                Call GrabarCuentaDistribucion()
            End If
            If CDbl(lblNivel.Text) = 1 Then
                Call GrabaTipoCuenta(Text0.ValorTxt, (Ctr_Ayuda4.Codigo), CShort(lblNivel.Text))
            End If

            VGCNx.CommitTrans()
        End If

        Call MuestraDatos(VB.Right(Trim(cCta), CInt(Len(Trim(cCta))) - 1))
        Toolbar1.Visible = True : TreeView1.Enabled = True
        Text0.Enabled = True
        modoinsert = False : modoedit = False
        i_filaorigen = -1
        Ctr_Ayuda1.Enabled = False
        FLAGDISTRIBUCION = False
        FLAGMOVIMIENTODISTRI = False
        rsDist = Nothing
        Exit Sub

X:
        If Err.Number = -2147217873 Then
            MsgBox("Esta intentando registrar uno Existente " & Err.Description, MsgBoxStyle.Information, Text)
        Else
            MsgBox("Error inesperado: " & Err.Number & " " & Err.Description, CDbl(Text))
        End If
        VGCNx.RollbackTrans()

    End Sub

    Function ValidarData() As Boolean
        Dim i As Short
        Dim SQL As String
        If IsNothing(lblNivel.Text) Then
            MsgBox("No se ha podido registrar el Número de Nivel de la Cuenta Contable", MsgBoxStyle.Information, Text)
            ValidarData = False
            Text0.Focus()
            Exit Function
        End If
        If CDbl(lblNivel.Text) - 2 < 0 Then
            If VG_aNIVELES(CDbl(lblNivel.Text) - 1) < CInt(Len(Text0.ValorTxt)) Then
                MsgBox("La Cuenta a registrar no corresponde con el Nivel de Cuenta", MsgBoxStyle.Information, Text)
                ValidarData = False
                Text0.Focus()
                '    Exit Function
            End If
        Else
            If VG_aNIVELES(CDbl(lblNivel.Text) - 1) < CInt(Len(Text0.ValorTxt)) Or VG_aNIVELES(CDbl(lblNivel.Text) - 2) >= CInt(Len(Text0.ValorTxt)) Then
                MsgBox("La Cuenta a registrar no corresponde con el Nivel de Cuenta", MsgBoxStyle.Information, Text)
                ValidarData = False
                Text0.Focus()
                '    Exit Function
            End If
        End If

        If CInt(lblNivel.Text) > 1 Then
            SQL = "SELECT cuentacodigo FROM CT_CUENTA WHERE cuentacodigo='" & VB.Left(Text0.ValorTxt, VG_aNIVELES(CDbl(lblNivel.Text) - 2)) & "'"
            If xdllgen.VerificaDatoExistente(VGCNx, SQL) <= 0 Then
                MsgBox("La Cuenta a registrar no tiene la Cuenta Superior Correspondiente ", MsgBoxStyle.Information, Text)
                ValidarData = False
                Text0.Focus()
                Exit Function
            End If
        End If

        SQL = "SELECT cuentacodigo FROM CT_CUENTA WHERE cuentacodigo='" & Text0.ValorTxt & "' and empresacodigo='" & VGParametros.empresacodigo & "'"
        If modoinsert = True And xdllgen.VerificaDatoExistente(VGCNx, SQL) > 0 Then
            MsgBox("La Cuenta se encuentra registrada en la Base Datos, Debe registrar otra", MsgBoxStyle.Information, Text)
            ValidarData = False
            Text0.Focus()
            Exit Function
        End If

        If IsNothing(Ctr_Ayuda4.Codigo) Then
            MsgBox("No existe Código de Tipo de Cuenta en el registro editado", MsgBoxStyle.Information, Text)
            If CDbl(lblNivel.Text) = 1 Then
                Ctr_Ayuda4.Focus()
            Else
                Text0.Focus()
            End If
            ValidarData = False
            Exit Function
        End If

        If CInt(lblNivel.Text) > 1 Then
            If chk(0).CheckState = 1 And IsNothing(Ctr_Ayuda1.Codigo) Then
                MsgBox("Falta indicar el Tipo de Analítico", MsgBoxStyle.Information, Text)
                ValidarData = False
                Ctr_Ayuda1.Focus()
                Exit Function
            End If
        End If

        If chk(3).CheckState = 1 And FLAGDISTRIBUCION = False Then
            MsgBox("No Existe Porcentaje de Distribución para esta cuenta, Deshabilitar el check", MsgBoxStyle.Information, Text)
            ValidarData = False
            chk(3).Focus()
            Exit Function
        End If

        ValidarData = True
    End Function

    Private Sub chk_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chk.CheckStateChanged
        Dim Index As Short = chk.GetIndex(eventSender)
        Select Case Index
            Case 0
                Ctr_Ayuda1.Enabled = IIf(chk(0).CheckState = 0, False, True)
                If chk(0).CheckState = 0 Then Ctr_Ayuda1.Codigo = CStr(Nothing) : Ctr_Ayuda1.Codigo = CStr(Nothing)

            Case 3
                If chk(3).CheckState = 1 Then
                    If FLAGMOVIMIENTODISTRI = False Then
                        cmdDistribucion.Visible = True
                        SSTab1.TabPages.Item(2).Enabled = True
                        SSTab1.SelectedIndex = 2
                        FLAGMOVIMIENTODISTRI = False
                        Call LlenarPorcentajes()
                    End If
                Else
                    cmdDistribucion.Visible = False
                    SSTab1.TabPages.Item(2).Enabled = False
                End If
        End Select

        If modoedit = True Then
            cAcepta.Enabled = True
        End If

    End Sub

    Private Sub frmMantPlanCuentas_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        rs = Nothing
        rsDist = Nothing
    End Sub

    Private Sub SSTab1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SSTab1.SelectedIndexChanged
        Static PreviousTab As Short = SSTab1.SelectedIndex()
        'SSTab1.TabPages.Item(PreviousTab).Enabled = False
        PreviousTab = SSTab1.SelectedIndex()
    End Sub

    Private Sub TDBGrid1_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBGrid1.DblClick
        If rs.RecordCount > 0 And (modoedit = False And modoinsert = False) Then
            Call Mantenimiento(1)
        End If

    End Sub

    Private Sub TDBGrid1_FetchRowStyle(ByVal Split_Renamed As Short, ByRef Bookmark As Object, ByVal RowStyle As TrueOleDBGrid70.StyleDisp)
        Dim rsX As ADODB.Recordset
        rsX = rs.Clone(ADODB.LockTypeEnum.adLockReadOnly)
        rsX.Bookmark = Bookmark
        If rsX.Fields("cuentanivel").Value = 1 Then
            RowStyle.BackColor = System.Convert.ToUInt32(&H80000018)
        End If

    End Sub

    Private Sub TDBGrid1_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_HeadClickEvent) Handles TDBGrid1.HeadClick
        On Error Resume Next
        If IsNothing(rs.Sort) Then
            rs.Sort = TDBGrid1.Columns.Item(eventArgs.colIndex).DataField & " asc"
        ElseIf VB.Right(rs.Sort, 3) = "asc" Then
            rs.Sort = TDBGrid1.Columns.Item(eventArgs.colIndex).DataField & " desc"
        ElseIf VB.Right(rs.Sort, 4) = "desc" Then
            rs.Sort = TDBGrid1.Columns.Item(eventArgs.colIndex).DataField & " asc"
        End If
        Call ConfiguraTdbgrid()
        TDBGrid1.Refresh()
    End Sub

    Private Sub ConfiguraTdbgrid()
        With TDBGrid1
            .Columns(0).Width = 70
            .Columns(1).Width = 310
            .Columns(2).Width = 80
            .Columns(3).Width = 80
            .Columns(4).Width = 80
            .Columns(5).Width = 80
            .Columns(6).Width = 80
        End With

    End Sub

    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button1.Click, _Toolbar1_Button2.Click, _Toolbar1_Button3.Click, _Toolbar1_Button4.Click, _Toolbar1_Button5.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Call Mantenimiento(Button.Owner.Items.IndexOf(Button))
    End Sub

    Sub Mantenimiento(ByRef indice As Short)
        Dim J As Short
        Dim spos As Short
        Dim SQL As String

        On Error GoTo X
        SSTab1.TabPages.Item(1).Enabled = True

        Dim rs As ADODB.Recordset
        Select Case indice
            Case 0 'nuevo
                modoinsert = True
                SSTab1.SelectedIndex = 1
                SSTab1.TabPages.Item(2).Enabled = False
                Call LimpiarValores()
                Call ModoNormal()
                Toolbar1.Visible = False
                TreeView1.Enabled = False

                FLAGDISTRIBUCION = False

            Case 1 'modificar
                modoedit = True
                If TDBGrid1.Row < 0 Then
                    Exit Sub
                End If
                Call EditarValores()
                SSTab1.SelectedIndex = 1
                Toolbar1.Visible = False
                TreeView1.Enabled = False
                i_filaorigen = TDBGrid1.Row
                Text0.Enabled = False
                cAcepta.Enabled = False
                FLAGDISTRIBUCION = False

            Case 2 'eliminar
                If MsgBox("Desea eliminar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "AVISO") = MsgBoxResult.Yes Then
                    rs = New ADODB.Recordset
                    SQL = "Select isnull(count(*),0) from ct_cuenta where empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo like '" & Trim(TDBGrid1.Columns(0).Value) & "%'"
                    rs = VGCNx.Execute(SQL)
                    If rs.Fields(0).Value > 1 Then
                        MsgBox("La Cuenta a Eliminar tiene Cuentas Dependientes al Nivel Inferior" & Chr(10) & Chr(13) & "Deben Eliminarse primero las Cuentas de Nivel Inferior", MsgBoxStyle.Information, Text)
                        Exit Sub
                    End If
                    SQL = "DELETE FROM CT_CUENTA WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo = '" & Trim(TDBGrid1.Columns(0).Value) & "'"
                    VGCNx.Execute(SQL)
                    Call MuestraDatos(Trim(TDBGrid1.Columns(0).Value))
                End If

            Case 3 'Imprimir
                With MDIPrincipal
                    .cryRpt.Destination = Crystal.DestinationConstants.crptToWindow
                    .cryRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
                    .cryRpt.set_StoredProcParam(0, VGParamSistem.BDEmpresa)
                    .cryRpt.set_StoredProcParam(1, Trim(xCuenta) & "%")
                    .cryRpt.set_Formulas(0, "@Emp='" & VGParametros.NomEmpresa & "'")
                    .cryRpt.ReportFileName = VGParamSistem.RutaReport & "rptPlanCuentas.rpt"
                    .cryRpt.Connect = vgCADENAREPORT
                    .cryRpt.DiscardSavedData = True
                    .cryRpt.Action = 1
                End With

            Case 4 ' salir
                Me.Close()
        End Select
        Exit Sub

X:
        If indice = 2 And Err.Number = -2147217873 Then
            MsgBox("Registro no podrá Eliminarse mientras exista Información en las Tablas Relacionadas", MsgBoxStyle.Information, Text)
        Else
            MsgBox("Error inesperado: " & Err.Description & "  " & Err.Number, MsgBoxStyle.Information, Text)
        End If
    End Sub


    Private Sub text0_eChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text0.eChange
        cAcepta.Enabled = IIf(xdllgen.ESNULO((lblNivel.Text), 0) = VGnumnivelescuenta, ValidarCuentaUltimoNivel(), ValidarCuentaNivel())
    End Sub
    Private Sub text1_eChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text1.eChange
        cAcepta.Enabled = IIf(xdllgen.ESNULO((lblNivel.Text), 0) = VGnumnivelescuenta, ValidarCuentaUltimoNivel(), ValidarCuentaNivel())
    End Sub
    Private Sub text2_eChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text2.eChange
        cAcepta.Enabled = IIf(xdllgen.ESNULO((lblNivel.Text), 0) = VGnumnivelescuenta, ValidarCuentaUltimoNivel(), ValidarCuentaNivel())
    End Sub
    Private Sub text3_eChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text3.eChange
        cAcepta.Enabled = IIf(xdllgen.ESNULO((lblNivel.Text), 0) = VGnumnivelescuenta, ValidarCuentaUltimoNivel(), ValidarCuentaNivel())
    End Sub
    Private Sub text4_eChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text4.eChange
        cAcepta.Enabled = IIf(xdllgen.ESNULO((lblNivel.Text), 0) = VGnumnivelescuenta, ValidarCuentaUltimoNivel(), ValidarCuentaNivel())
    End Sub
    Private Sub text5_eChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text5.eChange
        cAcepta.Enabled = IIf(xdllgen.ESNULO((lblNivel.Text), 0) = VGnumnivelescuenta, ValidarCuentaUltimoNivel(), ValidarCuentaNivel())
    End Sub
    Private Sub text6_eChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text6.eChange
        cAcepta.Enabled = IIf(xdllgen.ESNULO((lblNivel.Text), 0) = VGnumnivelescuenta, ValidarCuentaUltimoNivel(), ValidarCuentaNivel())
    End Sub





    Private Sub Ctr_Ayuda4_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent)
        cAcepta.Enabled = IIf(xdllgen.ESNULO((lblNivel.Text), 0) = VGnumnivelescuenta, ValidarCuentaUltimoNivel(), ValidarCuentaNivel())
    End Sub

    Private Sub cboTipoAjuste_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTipoAjuste.SelectedIndexChanged
        cAcepta.Enabled = IIf(xdllgen.ESNULO((lblNivel.Text), 0) = VGnumnivelescuenta, ValidarCuentaUltimoNivel(), ValidarCuentaNivel())
    End Sub

    Function ValidarCuentaUltimoNivel() As Boolean

        If IsNothing(Text0.ValorTxt) Then
            ValidarCuentaUltimoNivel = False
            Exit Function
        End If
        If IsNothing(Text1.ValorTxt) Then
            ValidarCuentaUltimoNivel = False
            Exit Function
        End If



        ValidarCuentaUltimoNivel = True
    End Function

    Function ValidarCuentaNivel() As Boolean
        If IsNothing(Text0.ValorTxt) Then
            ValidarCuentaNivel = False
            Exit Function
        End If

        If IsNothing(Text1.ValorTxt) Then
            ValidarCuentaNivel = False
            Exit Function
        End If

        If IsNothing(Text2.ValorTxt) Then
            ValidarCuentaNivel = False
            Exit Function
        End If

        If IsNothing(Text3.ValorTxt) Then
            ValidarCuentaNivel = False
            Exit Function
        End If

        If IsNothing(Text4.ValorTxt) Then
            ValidarCuentaNivel = False
            Exit Function
        End If

        If IsNothing(Text5.ValorTxt) Then
            ValidarCuentaNivel = False
            Exit Function
        End If

        If IsNothing(Text6.ValorTxt) Then
            ValidarCuentaNivel = False
            Exit Function
        End If

        ValidarCuentaNivel = True
    End Function

    Sub ModoEdicion(ByRef flagULTIMONIVEL As Boolean) 'True: Ultimo Nivel  False:Otros Niveles
        Dim i As Short

        Text0.Enabled = True
        Text1.Enabled = True



        Text2.ColorFondo = System.Drawing.ColorTranslator.FromOle(IIf(flagULTIMONIVEL = True, ColorHabilitado, ColorDesHabilitado))
        Text2.Enabled = Not flagULTIMONIVEL
        Text2.ValorTxt = 0
        Text3.ColorFondo = System.Drawing.ColorTranslator.FromOle(IIf(flagULTIMONIVEL = True, ColorHabilitado, ColorDesHabilitado))
        Text3.Enabled = Not flagULTIMONIVEL
        Text3.ValorTxt = 0
        Text4.ColorFondo = System.Drawing.ColorTranslator.FromOle(IIf(flagULTIMONIVEL = True, ColorHabilitado, ColorDesHabilitado))
        Text4.Enabled = Not flagULTIMONIVEL
        Text4.ValorTxt = 0
        Text5.ColorFondo = System.Drawing.ColorTranslator.FromOle(IIf(flagULTIMONIVEL = True, ColorHabilitado, ColorDesHabilitado))
        Text5.Enabled = Not flagULTIMONIVEL
        Text5.ValorTxt = 0
        Text6.ColorFondo = System.Drawing.ColorTranslator.FromOle(IIf(flagULTIMONIVEL = True, ColorHabilitado, ColorDesHabilitado))
        Text6.Enabled = Not flagULTIMONIVEL
        Text6.ValorTxt = 0



        For i = 0 To 3
            chk(i).Enabled = flagULTIMONIVEL
        Next
        cmdDistribucion.Visible = flagULTIMONIVEL
        Ctr_Ayuda1.Enabled = flagULTIMONIVEL
        cboTipoAjuste.Enabled = flagULTIMONIVEL

    End Sub

    Sub ModoNormal()
        Dim i As Short


        Text0.Enabled = True
        Text1.Enabled = True
        Text2.Enabled = True
        Text3.Enabled = True
        Text4.Enabled = True
        Text5.Enabled = True
        Text6.Enabled = True

        For i = 0 To 4
            chk(i).Enabled = True
        Next
        Ctr_Ayuda1.Enabled = True
        Ctr_Ayuda4.Enabled = True
        cboTipoAjuste.Enabled = True

    End Sub

    Function GrabarPlanCuenta(ByRef tipooperacion As Short, ByRef xCod As String, ByRef xDes As String, ByRef xLinAct As Double, ByRef xLinPas As Double, ByRef xLinEgp As Double, ByRef xNatu As String, ByRef xNatuegp As String, ByRef xCtaCostos As Short, ByRef xCtaAnalitico As Short, ByRef xCtaDoc As Short, ByRef xCtaNivel As Short, ByRef xTipoAnalitico As String, ByRef xCtaDist As Short, ByRef xTipoCuenta As String, ByRef xTipoAJuste As String, ByRef xAdicionaCargo As String) As String
        Dim strSQL As String

        xTipoAnalitico = IIf(IsDBNull(xTipoAnalitico) Or IsNothing(xTipoAnalitico), "00", xTipoAnalitico)
        Select Case tipooperacion
            Case 0
                strSQL = "INSERT INTO ct_cuenta (empresacodigo,cuentacodigo, cuentadescripcion, cuentalineaactivo,cuentalineapasivo, cuentalineaegp, cuentanatu, cuentanategp,"
                strSQL = strSQL & "cuentaestadoccostos, cuentaestadoanalitico,cuentadocumento, cuentanivel, tipoanaliticocodigo,cuentaestadodistribucion,tipocuentacodigo,usuariocodigo, fechaact, CUENTAGRUPO,tipoajuste,cuentaestado,cuentaadicionacargo) "
                strSQL = strSQL & " VALUES ('" & VGParametros.empresacodigo & "','" & xCod & "','" & xDes & "'," & xLinAct & "," & xLinPas & "," & xLinEgp & ",'" & xNatu & "','" & xNatuegp & "'," & xCtaCostos & "," & xCtaAnalitico & "," & xCtaDoc & "," & xCtaNivel & ",'" & xTipoAnalitico & "'," & xCtaDist & ",'" & xTipoCuenta & "','" & VGusuario & "','" & VB6.Format(Now, "dd/mm/yyyy") & "','01','" & xTipoAJuste & "','1','" & xAdicionaCargo & "')"

            Case 1
                strSQL = "UPDATE CT_CUENTA SET "
                strSQL = strSQL & "cuentadescripcion='" & xDes & "',"
                strSQL = strSQL & "cuentalineaactivo=" & xdllgen.ESNULO(xLinAct, 0) & ","
                strSQL = strSQL & "cuentalineapasivo=" & xdllgen.ESNULO(xLinPas, 0) & ","
                strSQL = strSQL & "cuentalineaegp=" & xdllgen.ESNULO(xLinEgp, 0) & ","
                strSQL = strSQL & "cuentanatu='" & xdllgen.ESNULO(xNatu, "") & "',"
                strSQL = strSQL & "cuentanategp='" & xdllgen.ESNULO(xNatuegp, "") & "',"
                strSQL = strSQL & "cuentaestadoccostos=" & xdllgen.ESNULO(xCtaCostos, 0) & ","
                strSQL = strSQL & "cuentaestadoanalitico=" & xdllgen.ESNULO(xCtaAnalitico, 0) & ","
                strSQL = strSQL & "cuentadocumento=" & xdllgen.ESNULO(xCtaDoc, 0) & ","
                strSQL = strSQL & "cuentanivel=" & xdllgen.ESNULO(xCtaNivel, 0) & ","
                strSQL = strSQL & "tipoanaliticocodigo='" & xTipoAnalitico & "',"
                strSQL = strSQL & "cuentaestadodistribucion=" & xdllgen.ESNULO(xCtaDist, 0) & ","
                strSQL = strSQL & "tipocuentacodigo='" & xTipoCuenta & "',"
                strSQL = strSQL & "usuariocodigo='" & VGusuario & "',"
                strSQL = strSQL & "fechaact='" & VB6.Format(Now, "dd/mm/yyyy") & "',"
                strSQL = strSQL & "cuentagrupo='01',"
                strSQL = strSQL & "tipoajuste='" & xTipoAJuste & "', "
                strSQL = strSQL & "cuentaadicionacargo='" & xAdicionaCargo & "' "
                strSQL = strSQL & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo='" & xCod & "'"

        End Select
        GrabarPlanCuenta = strSQL

    End Function

    Sub GrabarCuentaDistribucion()
        Dim i As Integer
        Dim SQL As String

        If rsDist.RecordCount > 0 Then
            SQL = "DELETE FROM ct_distribucion WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo='" & Text0.ValorTxt & "'"
            VGCNx.Execute(SQL)
            rsDist.MoveFirst()
            For i = 0 To rsDist.RecordCount - 1
                SQL = "INSERT ct_distribucion (empresacodigo,cuentacodigo,distribucioncargo,distribucionabono,distribucionporcen,usuariocodigo,fechaact) VALUES "
                SQL = SQL & "('" & VGParametros.empresacodigo & "','" & rsDist.Fields(0).Value & "','" & rsDist.Fields(1).Value & "','" & rsDist.Fields(2).Value & "'," & rsDist.Fields(3).Value & ",'" & VGusuario & "','" & Today & "')"
                VGCNx.Execute(SQL)
                rsDist.MoveNext()
            Next
        End If

    End Sub

    Sub GrabarTablaSaldos()
        Dim SQL As String
        Dim NombreTabla As String
        NombreTabla = "CT_SALDOS" & VGParamSistem.Anoproceso
        SQL = "INSERT " & NombreTabla & "(empresacodigo,cuentacodigo,usuariocodigo,fechaact)"
        SQL = SQL & "VALUES ('" & VGParametros.empresacodigo & "','" & Text0.ValorTxt & "','" & VGusuario & "','" & Today & "')"
        VGCNx.Execute(SQL)

    End Sub

    Private Sub cmdSigue_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSigue.Click
        If rsDist.RecordCount > 0 And CDbl(lblPorcen.Text) <> 100 Then
            MsgBox("El Total de % Distribución no se ha completado al 100%", MsgBoxStyle.Information, Text)
        Else
            cAcepta.Enabled = IIf(rsDist.RecordCount > 0 And FLAGMOVIMIENTODISTRI = True, True, False)
            chk(3).CheckState = IIf(rsDist.RecordCount > 0, 1, 0)
            SSTab1.SelectedIndex = 1
            SSTab1.TabPages.Item(1).Enabled = True
        End If

    End Sub

    Private Sub cmdDistribucion_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDistribucion.Click
        SSTab1.TabPages.Item(2).Enabled = True
        SSTab1.SelectedIndex = 2
        FLAGMOVIMIENTODISTRI = False
        Call LlenarPorcentajes()
    End Sub

    Sub LlenarPorcentajes()
        rsDist = Nothing
        rsDist = New ADODB.Recordset
        Call IniciaGridDist()
        Call CargaGridDist()
        Call ConfigGridDist()
        FLAGDISTRIBUCION = True
    End Sub

    Private Sub IniciaGridDist()
        rsDist = New ADODB.Recordset
        Call rsDist.Fields.Append("Cuenta", ADODB.DataTypeEnum.adVarChar, 20)
        Call rsDist.Fields.Append("Cuenta Cargo", ADODB.DataTypeEnum.adVarChar, 20)
        Call rsDist.Fields.Append("Cuenta Abono", ADODB.DataTypeEnum.adVarChar, 20)
        Call rsDist.Fields.Append("Porcentaje", ADODB.DataTypeEnum.adDouble)
        Call rsDist.Fields.Append("Item", ADODB.DataTypeEnum.adInteger)
        rsDist.Open()
    End Sub

    Private Sub CargaGridDist()
        Dim xRs As ADODB.Recordset
        Dim nConta As Integer
        Dim SQL As String
        xRs = New ADODB.Recordset
        SQL = "SELECT cuentacodigo,distribucioncargo,distribucionabono,distribucionporcen "
        SQL = SQL & "FROM ct_distribucion WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo='" & Text0.ValorTxt & "'"
        xRs = VGCNx.Execute(SQL)
        nConta = 1
        If xRs.RecordCount > 0 Then
            xRs.MoveFirst()
            Do While Not xRs.EOF
                rsDist.AddNew()
                rsDist.Fields(0).Value = xRs.Fields(0).Value
                rsDist.Fields(1).Value = xRs.Fields(1).Value
                rsDist.Fields(2).Value = xRs.Fields(2).Value
                rsDist.Fields(3).Value = xRs.Fields(3).Value
                rsDist.Fields(4).Value = nConta
                nConta = nConta + 1
                rsDist.Update()
                xRs.MoveNext()
            Loop
        End If
        xRs = Nothing
        xRs = New ADODB.Recordset
    End Sub

    Private Sub ConfigGridDist()
        Dim i As Short
        TDBGrid2.DataSource = rsDist
        With TDBGrid2
            For i = 0 To 4
                .Columns(i).AllowSizing = False
            Next
            .Columns(0).Visible = False
            .Columns(0).Caption = "Cuenta"
            .Columns(1).Width = 70
            .Columns(1).Caption = "Cuenta Cargo"
            .Columns(2).Width = 170
            .Columns(2).Caption = "Cuenta Abono"
            .Columns(3).Width = 190
            .Columns(3).Caption = "Distribución(%)"
            .Columns(4).Width = 80
            .Columns(4).Caption = "Item"
        End With
        lblPorcen.Text = CStr(DevuelveTotPor())
        TDBGrid2.Refresh()
    End Sub

    Private Sub ActualizaGridDist()
        Dim nReg As Integer
        nReg = DevuelveNumReg() + 1
        With rsDist
            .AddNew()
            .Fields(0).Value = Text0.ValorTxt
            .Fields(1).Value = Ctr_Ayuda2.Codigo
            .Fields(2).Value = Ctr_Ayuda3.Codigo
            .Fields(3).Value = CDbl(txtPorcen.ValorTxt)
            .Fields(4).Value = CInt(nReg)
            .Update()
        End With
    End Sub

    Private Sub txtbuscarcuenta_KeyPress(ByRef KeyAscii As Short)
        If KeyAscii = 13 Then
            Call cmdBuscar_Click(cmdBuscar, New System.EventArgs())
        End If
    End Sub


    Private Sub txtPorcen_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If Not IsNothing(Ctr_Ayuda2.Codigo) And Not IsNothing(Ctr_Ayuda3.Codigo) Then
            If Not IsNothing(txtPorcen.ValorTxt) Then
                cmdAceptar.Enabled = True
                Exit Sub
            End If
        End If
        cmdAceptar.Enabled = False
    End Sub

    Function ValidarGridDist() As Boolean

        If DevuelveTotPor() + Val(txtPorcen.ValorTxt) > 100 Then
            MsgBox("La Sumatoria de Porcentaje excede al 100%", MsgBoxStyle.Information, Text)
            txtPorcen.Focus()
            System.Windows.Forms.SendKeys.Send("{HOME}+{END}")
            ValidarGridDist = False
            Exit Function
        End If

        If Val(txtPorcen.ValorTxt) = 0 Then
            MsgBox("Valor de Porcentaje  no permitido", MsgBoxStyle.Information, Text)
            txtPorcen.Focus()
            System.Windows.Forms.SendKeys.Send("{HOME}+{END}")
            ValidarGridDist = False
            Exit Function
        End If

        ValidarGridDist = True
    End Function

    Function DevuelveTotPor() As Double
        Dim i As Short
        Dim nSum As Double
        nSum = 0
        If rsDist.RecordCount > 0 Then
            rsDist.MoveFirst()
            Do While Not rsDist.EOF
                nSum = nSum + rsDist.Fields(3).Value
                rsDist.MoveNext()
            Loop
        End If
        DevuelveTotPor = CDbl(VB6.Format(nSum, "###0.#0"))
    End Function

    Private Sub TDBGrid2_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBGrid2.ClickEvent
        TDBGrid2.Focus()
    End Sub

    Private Sub TDBGrid2_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_KeyDownEvent) Handles TDBGrid2.KeyDownEvent
        Dim nvalor As String
        If rsDist.RecordCount > 0 Then
            If eventArgs.keyCode = 46 Then
                nvalor = TDBGrid2.Columns(4).Text
                If rsDist.RecordCount > 0 Then
                    rsDist.MoveFirst()
                    Do Until rsDist.EOF
                        If rsDist.Fields(4).Value = nvalor Then
                            rsDist.Delete(ADODB.AffectEnum.adAffectCurrent)
                            rsDist.Update()
                            Exit Do
                        End If
                        rsDist.MoveNext()
                    Loop
                    ConfigGridDist()
                    lblPorcen.Text = CStr(DevuelveTotPor())
                End If
            End If
        End If
    End Sub

    Function DevuelveNumReg() As Integer
        Dim nUlt As Integer
        If rsDist.RecordCount > 0 Then
            rsDist.MoveFirst()
            Do While Not rsDist.EOF
                nUlt = rsDist.Fields(4).Value
                rsDist.MoveNext()
            Loop
            DevuelveNumReg = nUlt
        Else
            DevuelveNumReg = 0
        End If
    End Function

    Private Sub Arbol(ByRef xCta As String)
        On Error GoTo xx
        Dim rs As ADODB.Recordset
        Dim SQL As String
        Dim CodCan As String
        Dim i As Integer
        Dim K As Short
        Dim nodX As System.Windows.Forms.TreeNode

        VGvardllgen = New dllgeneral.dll_general
        xCta = VGvardllgen.ESNULO(xCta, "%")

        SQL = "SELECT A.cuentacodigo,A.cuentadescripcion, A.cuentanivel FROM CT_CUENTA A "
        SQL = SQL & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo<>'00' and A.cuentacodigo like '" & xCta & "%' "
        SQL = SQL & "ORDER BY 1"
        rs = New ADODB.Recordset
        rs = VGCNx.Execute(SQL)

        If (rs.EOF Or rs.BOF) Then
            Exit Sub
        End If
        TreeView1.Nodes.Clear()
        nodX = TreeView1.Nodes.Add("P", "Plan de Cuentas", 1)
        nodX.EnsureVisible()

        For i = 1 To rs.RecordCount
            cCta = "P" & Trim(rs.Fields(0).Value)
            If rs.Fields(2).Value > 1 Then
                nodX = TreeView1.Nodes.Find("P" & Trim(Mid(cCta, 2, VG_aNIVELES(rs.Fields(2).Value - 2))), True)(0).Nodes.Add(cCta, rs.Fields(0).Value, 1)
            Else
                nodX = TreeView1.Nodes.Find("P", True)(0).Nodes.Add(cCta, rs.Fields(0).Value, 1)
                nodX.EnsureVisible()
            End If
            rs.MoveNext()
        Next i
        rs.MoveFirst()
        Exit Sub
xx:
        'MsgBox "Error de Inconsistencia en Base de Datos: " & "No existe Plan de Cuentas superior para la Cuenta " & rs(0) & " - " & rs(1), vbInformation, Caption
        l_error = l_error & "No existe Cuenta superior para la Cuenta " & rs.Fields(0).Value & " - " & rs.Fields(1).Value & Chr(13)
        Resume Next
    End Sub

    Private Sub TREEVIEW1_AfterExpand(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterExpand
        Dim NODE As System.Windows.Forms.TreeNode = eventArgs.Node
        NODE.ImageIndex = 2
    End Sub

    Private Sub TREEVIEW1_AfterCollapse(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCollapse
        Dim NODE As System.Windows.Forms.TreeNode = eventArgs.Node
        NODE.ImageIndex = 1
    End Sub

    Private Sub TreeView1_NodeClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        Dim NODE As System.Windows.Forms.TreeNode = eventArgs.Node
        If Not IsNothing(NODE.Name) Then
            xCuenta = VB.Right(Trim(NODE.Name), Len(Trim(NODE.Name)) - 1)
            MuestraDatos(VB.Right(Trim(NODE.Name), Len(Trim(NODE.Name)) - 1))
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
        If ValidarGridDist() = True Then
            Call ActualizaGridDist()
            Call ConfigGridDist()
            Ctr_Ayuda2.Codigo = CStr(Nothing)
            Ctr_Ayuda3.Codigo = CStr(Nothing)
            Ctr_Ayuda2.Descripcion = CStr(Nothing)
            Ctr_Ayuda3.Descripcion = CStr(Nothing)
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            txtPorcen.ValorTxt = Nothing
            FLAGMOVIMIENTODISTRI = True
        End If
    End Sub

    Function DevuelveTipoCuenta() As Object
        Dim rsX As New ADODB.Recordset
        Dim SQL As String

        rsX = New ADODB.Recordset
        SQL = "Select tipocuentacodigo from ct_cuenta where empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo=left('" & Trim(Text0.ValorTxt) & "',2)"
        rsX = VGCNx.Execute(SQL)
        If rsX.RecordCount > 0 Then
            DevuelveTipoCuenta = rsX.Fields(0).Value
        Else
            DevuelveTipoCuenta = 0
        End If
        rsX = Nothing
        rsX = New ADODB.Recordset

    End Function

    Sub GrabaTipoCuenta(ByRef xCta As String, ByRef xValor As String, ByRef xNivel As Short)
        Dim SQL As String
        SQL = "UPDATE ct_cuenta SET tipocuentacodigo='" & xValor & "' "
        SQL = SQL & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and left(cuentacodigo,2)='" & xCta & "' AND cuentanivel>" & xNivel
        VGCNx.Execute(SQL)
    End Sub

    Private Sub SSTab1_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles SSTab1.Selecting

        Select Case e.TabPageIndex
            Case 0
                Call cCancela_Click(cCancela, New System.EventArgs())
            Case 1
                If modoinsert = False And modoedit = False Then
                    Call TDBGrid1_DblClick(TDBGrid1, New System.EventArgs())
                End If

            Case 2
                If cmdDistribucion.Visible = False Or chk(3).Enabled = False Then
                    SSTab1.SelectedIndex = 1
                Else
                    SSTab1.SelectedIndex = 2

                End If

        End Select


    End Sub

    Private Sub Text6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cAcepta.Focus()
            Call cAcepta_Click(cAcepta, New System.EventArgs())
        End If
    End Sub

    Private Sub Text0_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        Dim i As Short
        Dim sw As Boolean
        'txt(Index).CtlText = UCase(txt(Index).CtlText)

        If modoinsert = True Then
            For i = 0 To VGnumnivelescuenta
                If i > 1 Then
                    sw = VG_aNIVELES(i) >= Len(Trim(Text0.ValorTxt)) And VG_aNIVELES(i - 1) < Len(Trim(Text0.ValorTxt))
                Else
                    sw = VG_aNIVELES(i) = Len(Trim(Text0.ValorTxt))
                End If
                If sw Then
                    lblNivel.Text = CStr(i + 1)
                    Call ConfiguraModoEdicion()
                    cboTipoAjuste.SelectedIndex = 0

                    If i = 0 And UBound(VG_aNIVELES) > 1 Then
                        Ctr_Ayuda4.Enabled = True
                    Else
                        Ctr_Ayuda4.Enabled = False
                        Ctr_Ayuda4.Codigo = DevuelveTipoCuenta() : Ctr_Ayuda4.LlenayDevuelve()
                        Ctr_Ayuda1.Enabled = False
                        Ctr_Ayuda1.Codigo = "00" : Ctr_Ayuda1.LlenayDevuelve()
                    End If

                    Exit For
                Else
                    lblNivel.Text = CStr(Nothing)
                    Ctr_Ayuda4.Codigo = CStr(Nothing)
                    Ctr_Ayuda4.Descripcion = CStr(Nothing)
                End If
            Next
        End If


    End Sub


    Private Sub Text0_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Text1_Leave(ByVal sender As Object, ByVal e As System.EventArgs)

        Call ConfiguraModoEdicion()
    End Sub



End Class