Option Strict Off
Option Explicit On
Imports Func = Contabilidad.ModFuncionesGen
Friend Class frmMntPlantillaAsiento
    Inherits System.Windows.Forms.Form

    Dim modoinsert As Boolean
    Dim modoedit As Boolean
    Dim mododelete As Boolean
    Dim i_filaorigen As Short
    Dim rs As New ADODB.Recordset
    Dim rs1 As New ADODB.Recordset
    Dim rsPlantilla As ADODB.Recordset
    '  Dim dllgen As dllgeneral.dll_general

    'UPGRADE_WARNING: El evento ChkAjuste.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub ChkAjuste_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ChkAjuste.CheckStateChanged
        If modoinsert = True Or modoedit = True Then cAcepta.Enabled = ValidaDataIngreso()
    End Sub

    Private Sub frmMantPlantillaAsiento_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call ConfiguraForm()
        Call MuestraDatos1()
    End Sub

    Private Sub frmMantPlantillaAsiento_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rs = Nothing
    End Sub

    Sub ConfiguraForm()
        SSTab1.SelectedIndex = 0
        Ctr_Ayuda1.conexion(VGCNx)
        Ctr_Ayuda2.conexion(VGCNx)
        Ctr_Ayuda3.conexion(VGCNx)
        Ctr_Ayucuenta.conexion(VGCNx)
        Ctr_Ayucuenta.Filtro = "where empresacodigo='" & VGParametros.empresacodigo & "' and (cuentanivel=" & VGnumnivelescuenta & " or cuentacodigo='00')"
        Ctr_Ayuda5.conexion(VGCNx)
        Ctr_Ayuda5.Filtro = "where empresacodigo='" & VGParametros.empresacodigo & "' and (cuentanivel=" & VGnumnivelescuenta & " or cuentacodigo='00')"
        cAcepta.Enabled = False
        lblNumRegAsientos.Text = CStr(Nothing)
        lblNumRegSubAs.Text = CStr(Nothing)

    End Sub

    Sub MuestraDatos1()
        Dim SQL As String
        SQL = "SELECT ct_asiento.asientocodigo, ct_asiento.asientodescripcion "
        SQL = SQL & "FROM ct_asiento "
        SQL = SQL & "WHERE ct_asiento.asientocodigo<>'00' "
        SQL = SQL & "ORDER BY 1,2"

        rs = VGCNx.Execute(SQL)
        If rs.RecordCount <= 0 Then
            MsgBox("No se han Registrado los Asientos, Ingresar por opción de Asientos", MsgBoxStyle.Information, Text)
            Exit Sub
        Else
            TDBGrid3.DataSource = rs
            Call ConfiguraTdbgrid()
            lblNumRegAsientos.Text = CStr(rs.RecordCount)
            SSTab1.SelectedIndex = 0
            With TDBGrid3
                .Columns(0).Width = 1500
                .Columns(1).Width = 4500
            End With
        End If
    End Sub

    Sub MuestraDatos2()
        Dim SQL As String
        SQL = "SELECT ct_subasiento.subasientocodigo, ct_subasiento.subasientodescripcion "
        SQL = SQL & "FROM ct_subasiento "
        SQL = SQL & "WHERE ct_subasiento.asientocodigo='" & TDBGrid3.Columns(0).Text & "' AND ct_subasiento.subasientocodigo<>'00' "
        SQL = SQL & "ORDER BY 1,2"

        rs1 = VGCNx.Execute(SQL)
        TDBGrid1.DataSource = rs1
        lblNumRegSubAs.Text = CStr(rs1.RecordCount)
        SSTab1.SelectedIndex = 0

        With TDBGrid1
            .Columns(0).Width = 1500
            .Columns(1).Width = 4600
        End With

    End Sub

    Private Sub cCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cCancela.Click
        frmbotones.Visible = True
        modoinsert = False : modoedit = False : mododelete = False : lblMensaje.Text = CStr(Nothing)
        SSTab1.SelectedIndex = 0
        i_filaorigen = -1
    End Sub
    Sub EditarValores()

        With TDBGrid2
            txt0.Text = Trim(.Columns(2).Text)
            Ctr_Ayuda3.xclave = Trim(.Columns(3).Text) : Ctr_Ayuda3.Ejecutar()
            Ctr_Ayucuenta.xclave = Trim(.Columns(4).Text) : Ctr_Ayucuenta.Ejecutar()
            Ctr_Ayuda5.xclave = Trim(.Columns(7).Text) : Ctr_Ayuda5.Ejecutar()
            txt1.Text = Trim(.Columns(5).Text)
            chk.CheckState = IIf(CDbl(.Columns(6).Text) = 0, 0, 1)
            ChkAjuste.CheckState = IIf(CDbl(.Columns(10).Text) = 0, 0, 1)
            txt2.Text = .Columns(8).Text
            txt3.Text = .Columns(9).Text
        End With
        If modoinsert = True Then Call LimpiarValores()

    End Sub
    Public Sub LimpiarValores()
        Dim i As Short
        Ctr_Ayuda3.xclave = CStr(Nothing) : Ctr_Ayuda3.Ejecutar()
        Ctr_Ayucuenta.xclave = CStr(Nothing) : Ctr_Ayucuenta.Ejecutar()
        Ctr_Ayuda5.xclave = CStr(Nothing) : Ctr_Ayuda5.Ejecutar()
        For i = 0 To 3
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            txt(i).Text = Nothing
        Next
        chk.CheckState = System.Windows.Forms.CheckState.Unchecked

    End Sub

    Private Sub txt_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Change
        Dim Index As Short = txt.GetIndex(eventSender)
        If modoinsert = True Or modoedit = True Then cAcepta.Enabled = ValidaDataIngreso()
    End Sub

    Private Sub Ctr_Ayuda3_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_Ayuda3.AlDevolverDato
        If modoinsert = True Or modoedit = True Then cAcepta.Enabled = ValidaDataIngreso()
    End Sub

    Private Sub ctr_ayucuenta_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_Ayucuenta.AlDevolverDato
        If modoinsert = True Or modoedit = True Then
            cAcepta.Enabled = ValidaDataIngreso()
            If Ctr_Ayucuenta.xclave = "00" Then
                'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt3.CtlEnabled = True
                txt3.Focus()
            Else
                'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt3.CtlEnabled = False
            End If
        End If

    End Sub

    Private Sub ctr_ayucuenta_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Ctr_Ayucuenta.Leave
        If modoinsert = True Or modoedit = True Then
            If Ctr_Ayucuenta.xclave = "00" Then
                'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt3.CtlEnabled = True
                txt3.Focus()
            Else
                'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt3.CtlEnabled = False
            End If
        End If
    End Sub

    Private Sub ctr_ayucuenta_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_KeyPressEvent) Handles Ctr_Ayucuenta.KeyPressEvent
        If modoinsert = True Or modoedit = True Then
            If eventArgs.keyAscii = 13 Then
                If Ctr_Ayucuenta.xclave = "00" Then
                    txt3.Focus()
                End If
            End If
        End If
    End Sub

    'UPGRADE_WARNING: El evento chk.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chk_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chk.CheckStateChanged
        If modoinsert = True Or modoedit = True Then cAcepta.Enabled = ValidaDataIngreso()
        Select Case chk.CheckState
            Case 0
                'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                Ctr_Ayuda5.CtlEnabled = True
                'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt2.CtlEnabled = True
                'UPGRADE_NOTE: BackColor se actualizó a CtlBackColor. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt2.CtlBackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
            Case 1
                'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                Ctr_Ayuda5.CtlEnabled = False
                'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt2.CtlEnabled = False
                'UPGRADE_NOTE: BackColor se actualizó a CtlBackColor. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt2.CtlBackColor = System.Drawing.ColorTranslator.FromOle(ColorDesHabilitado)
        End Select
    End Sub

    Private Sub txt_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyPressEvent) Handles txt.KeyPressEvent
        Dim Index As Short = txt.GetIndex(eventSender)
        If eventArgs.keyAscii = 13 And Index = 1 Then
            chk.Focus()
        End If
    End Sub

    Private Sub cAcepta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cAcepta.Click
        If ValidaData() = True Then
            Call GrabarData()
            Call MuestraGrid2()
            Call LimpiarValores()
            frmbotones.Visible = True
            cAcepta.Enabled = False
            modoinsert = False : modoedit = False : mododelete = False : lblMensaje.Text = CStr(Nothing)
            Call LimpiarValores()
            Call ModoPlantilla(False)
        End If
    End Sub

    Private Sub Ctr_Ayuda2_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_Ayuda2.AlDevolverDato
        Call MuestraGrid2()
    End Sub

    Sub MuestraGrid2()
        Dim SQL As String
        SQL = "SELECT asientocodigo,subasientocodigo,plantillaasientocorrela,operacioncodigo,cuentacodigo,iddebeohaber,plantillaasientoinafecto,plantillaasientocuentaigv,plantillaasientovalorigv,plantillaasientocomodin,plantillaasientoctaajuste "
        SQL = SQL & "FROM ct_plantillaasiento WHERE asientocodigo='" & Ctr_Ayuda1.xclave & "' AND subasientocodigo='" & Ctr_Ayuda2.xclave & "' "
        SQL = SQL & "ORDER BY 3"
        rsPlantilla = New ADODB.Recordset
        rsPlantilla = VGCNx.Execute(SQL)
        TDBGrid2.DataSource = rsPlantilla
        Call ConfigGrid2()
    End Sub

    Sub ModoPlantilla(ByRef Flag_Normal As Boolean)
        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        txt0.CtlEnabled = Flag_Normal
        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Ctr_Ayuda3.CtlEnabled = Flag_Normal
        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Ctr_Ayucuenta.CtlEnabled = Flag_Normal
        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Ctr_Ayuda5.CtlEnabled = Flag_Normal
        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        txt1.CtlEnabled = Flag_Normal
        chk.Enabled = Flag_Normal
        ChkAjuste.Enabled = Flag_Normal
        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        txt2.CtlEnabled = Flag_Normal
        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        txt3.CtlEnabled = Flag_Normal

    End Sub

    Sub ConfigGrid2()
        With TDBGrid2
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).Width = 1000
            .Columns(3).Width = 1100
            .Columns(4).Width = 1000
            .Columns(5).Width = 1100
            .Columns(6).Width = 820
            .Columns(7).Width = 1100
            .Columns(8).Visible = False
        End With
    End Sub

    Private Sub SSTab1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SSTab1.SelectedIndexChanged
        Static PreviousTab As Short = SSTab1.SelectedIndex()
        '  VGvardllgen = New dllgeneral.dll_general
        Ctr_Ayuda1.xclave = TDBGrid3.Columns(0).Value : Ctr_Ayuda1.Ejecutar()
        Ctr_Ayuda2.Filtro = "where asientocodigo='" & Ctr_Ayuda1.xclave & "'"
        Ctr_Ayuda2.xclave = ESNULO((TDBGrid1.Columns(0).Value), "") : Ctr_Ayuda2.Ejecutar()
        Call LimpiarValores()
        Call ModoPlantilla(False)
        PreviousTab = SSTab1.SelectedIndex()
    End Sub

    Private Sub TDBGrid1_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_HeadClickEvent) Handles TDBGrid1.HeadClick
        On Error Resume Next

        If IsNothing(rs.Sort) Then
            rs.Sort = TDBGrid1.Columns.Item(eventArgs.colIndex).DataField & " asc"
        ElseIf Func.Right(rs.Sort, 3) = "asc" Then
            rs.Sort = TDBGrid1.Columns.Item(eventArgs.colIndex).DataField & " desc"
        ElseIf Func.Right(rs.Sort, 4) = "desc" Then
            rs.Sort = TDBGrid1.Columns.Item(eventArgs.colIndex).DataField & " asc"
        End If
        Call ConfiguraTdbgrid()
        TDBGrid1.Refresh()
    End Sub

    Private Sub TDBGrid1_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBGrid1.DblClick
        If ValidaSubAsientos((TDBGrid3.Columns(0).Text)) = True Then
            Call SSTab1_SelectedIndexChanged(SSTab1, New System.EventArgs())
            SSTab1.SelectedIndex = 1
        End If
    End Sub

    Private Sub ConfiguraTdbgrid()
        With TDBGrid3
            .Columns(0).Width = 1100
            .Columns(1).Width = 3500
        End With

    End Sub

    Function ValidaDataIngreso() As Boolean

        If IsNothing(Ctr_Ayuda1.xclave) Then
            ValidaDataIngreso = False
            Exit Function
        End If
        If IsNothing(Ctr_Ayuda2.xclave) Then
            ValidaDataIngreso = False
            Exit Function
        End If
        If IsNothing(Ctr_Ayuda3.xclave) Then
            ValidaDataIngreso = False
            Exit Function
        End If
        If IsNothing(Ctr_Ayucuenta.xclave) Then
            ValidaDataIngreso = False
            Exit Function
        End If
        ValidaDataIngreso = True
    End Function
    Private Sub TDBGrid2_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_RowColChangeEvent) Handles TDBGrid2.RowColChange
        If rsPlantilla.RecordCount = 0 Then Exit Sub
        If modoinsert = False Or modoedit = False Then Call EditarValores()
    End Sub

    Private Sub TDBGrid3_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_RowColChangeEvent) Handles TDBGrid3.RowColChange
        If rs.RecordCount > 0 Then
            Call MuestraDatos2()
            SSTab1.TabPages.Item(1).Enabled = (rs1.RecordCount > 0)
        End If
    End Sub

    Function ValidaData() As Boolean
        Dim SQL As String
        SQL = "SELECT cuentacodigo FROM ct_plantillaasiento WHERE asientocodigo='" & Trim(Ctr_Ayuda1.xclave) & "' AND "
        SQL = SQL & "subasientocodigo='" & Trim(Ctr_Ayuda2.xclave) & "' AND cuentacodigo='" & Trim(Ctr_Ayucuenta.xclave) & "'"

        If modoinsert = True And VerificaDatoExistente(VGCNx, SQL) > 0 Then
            MsgBox("La cuenta se va a duplicar en la Plantilla Actual")
            ValidaData = True
            'Deja pasar esta validación
        End If

        SQL = "SELECT cuentacodigo FROM ct_plantillaasiento WHERE asientocodigo='" & Trim(Ctr_Ayuda1.xclave) & "' AND "
        SQL = SQL & "subasientocodigo='" & Trim(Ctr_Ayuda2.xclave) & "' AND "
        SQL = SQL & "plantillaasientocorrela=" & txt0.Text
        If modoinsert = True And VerificaDatoExistente(VGCNx, SQL) > 0 Then
            MsgBox("El Correlativo Nº " & txt0.Text & " existe en la Plantilla actual", MsgBoxStyle.Information, Text)
            txt0.Focus()
            ValidaData = False
            Exit Function
        End If

        '  VGvardllgen = New dllgeneral.dll_general
        If Not IsNothing(Ctr_Ayuda5.xclave) And (CInt(ESNULO(txt2.Text, 0)) <= 0) = True Then
            MsgBox("Falta la Cuenta con IGV  ó Valor de IGV(%)", MsgBoxStyle.Information, Text)
            Ctr_Ayuda5.Focus()
            ValidaData = False
            Exit Function
        End If
        If Not IsNothing(txt3.Text) Then
            If Func.Right(txt3.Text, 1) <> "%" Then
                MsgBox("La Cuenta Comodín debe terminar con un Caracter (%)", MsgBoxStyle.Information, Text)
                ValidaData = False
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt3.Text = txt3.Text & "%"
                Exit Function
            End If
            If VerificaCriterioComodin(txt3.Text) = False Then
                ValidaData = False
                txt3.Focus()
                Exit Function
            End If
        End If

        ValidaData = True
    End Function

    Sub GrabarData()
        On Error GoTo X

        If modoinsert = True Then
            SQL = "INSERT INTO ct_plantillaasiento (subasientocodigo,asientocodigo,plantillaasientocorrela,operacioncodigo,"
            SQL = SQL & "cuentacodigo,iddebeohaber,plantillaasientoinafecto,plantillaasientocuentaigv,plantillaasientovalorigv,plantillaasientocomodin,plantillaasientoctaajuste,usuariocodigo,fechaact) "
            SQL = SQL & "VALUES ('" & Ctr_Ayuda2.xclave & "','" & Ctr_Ayuda1.xclave & "','" & txt0.Text & "','"
            SQL = SQL & Ctr_Ayuda3.xclave & "','" & Ctr_Ayucuenta.xclave & "','" & UCase(txt1.Text) & "'," & chk.CheckState & ",'" & Ctr_Ayuda5.xclave & "',"
            SQL = SQL & ESNULO(txt2.Text, 0) & ",'" & txt3.Text & "'," & ChkAjuste.CheckState & ",'" & VGUsuario & "','" & Format(Today, "dd/mm/yyyy") & "')"

        ElseIf modoedit = True Then
            SQL = "UPDATE ct_plantillaasiento SET operacioncodigo='" & Ctr_Ayuda3.xclave & "',cuentacodigo='" & Ctr_Ayucuenta.xclave & "',"
            SQL = SQL & "iddebeohaber='" & txt1.Text & "',plantillaasientoinafecto=" & chk.CheckState & ",plantillaasientocuentaigv='" & Ctr_Ayuda5.xclave & "',"
            SQL = SQL & "plantillaasientovalorigv=" & ESNULO(txt2.Text, 0) & ",plantillaasientocomodin='" & txt3.Text & "',plantillaasientoctaajuste=" & ChkAjuste.CheckState & ",usuariocodigo='" & VGUsuario & "',fechaact='" & Format(Today, "dd/mm/yyyy") & "'"
            SQL = SQL & "WHERE subasientocodigo='" & Trim(Ctr_Ayuda2.xclave) & "' AND asientocodigo = '" & Trim(Ctr_Ayuda1.xclave) & "' AND plantillaasientocorrela =" & UCase(txt0.Text)
        End If

        VGCNx.BeginTrans()
        VGCNx.Execute(SQL)
        VGCNx.CommitTrans()

        Exit Sub

X:
        If Err.Number = -2147217873 Then
            MsgBox("Esta intentando registrar uno Existente " & Err.Description, MsgBoxStyle.Information, Text)
        Else
            MsgBox("Error inesperado: " & Err.Number & " " & Err.Description)
        End If
        VGCNx.RollbackTrans()

    End Sub

    Private Sub txt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Leave
        Dim Index As Short = txt.GetIndex(eventSender)
        txt(Index).Text = UCase(txt(Index).Text)
    End Sub

    Private Sub Ctr_Ayuda5_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_Ayuda5.AlDevolverDato
        cAcepta.Enabled = ValidaDataIngreso()
    End Sub

    Private Sub Ctr_Ayuda5_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_KeyPressEvent) Handles Ctr_Ayuda5.KeyPressEvent
        If eventArgs.keyAscii = 13 Then
            cAcepta.Focus()
        End If
    End Sub

    Private Function VerificaCriterioComodin(ByRef cad As String) As Boolean
        Dim pos As Short
        Dim SQL As String
        Dim valor As String
        Dim flag As Boolean
        pos = 1
        flag = True
        '  VGvardllgen = New dllgeneral.dll_general
        Do While pos <> 0
            pos = InStr(1, cad, "%", CompareMethod.Text)
            If pos > 0 Then
                valor = Func.Left(cad, pos - 1)
                SQL = "SELECT cuentacodigo FROM ct_cuenta WHERE cuentacodigo='" & valor & "'"
                If VerificaDatoExistente(VGCNx, SQL) <= 0 Then
                    MsgBox("La Cuenta Contable Nº " & valor & " no Existe en el Plan de Cuentas", MsgBoxStyle.Information, Text)
                    flag = False
                    Exit Do
                End If
                cad = Func.Right(cad, Len(cad) - pos)
            End If
        Loop
        VerificaCriterioComodin = flag

    End Function

    Sub Impresion()
        'FIXIT: Declare 'arrparm' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
        Dim arrparm(4) As Object
        'FIXIT: Declare 'arrform' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
        Dim arrform(2) As Object
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(0) = VGParamSistem.BDEmpresa
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(1) = VGParamSistem.Anoproceso
        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(2) = IIf(IsNothing(Ctr_Ayuda1.xclave), "%%", Ctr_Ayuda1.xclave)
        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(3) = IIf(IsNothing(Ctr_Ayuda2.xclave), "%%", Ctr_Ayuda2.xclave)
        '  VGvardllgen = New dllgeneral.dll_general
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrform(0) = "@TituloReporte='" & "Plantilla de SubAsientos - Asiento: " & Ctr_Ayuda1.xclave & " " & Ctr_Ayuda1.xnombre & "'"
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrform(1) = "@Mes='" & DesMes(VGParamSistem.Mesproceso) & "'"
        Call ImpresionRptProc("rptPlantillaSubAsiento.rpt", arrform, arrparm)

    End Sub

    Private Sub cmdBotones0_Click(sender As Object, e As EventArgs) Handles cmdBotones0.Click
        frmbotones.Visible = False
        modoinsert = True
        lblMensaje.Text = "Nuevo"
        Call ModoPlantilla(True)
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto TDBGrid3.Columns().Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Ctr_Ayuda1.xclave = TDBGrid3.Columns(0).Value : Ctr_Ayuda1.Ejecutar()
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto TDBGrid1.Columns().Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Ctr_Ayuda2.xclave = TDBGrid1.Columns(0).Value : Ctr_Ayuda2.Ejecutar()
        txt0.Focus()
        Call LimpiarValores()
        SSTab1.TabPages.Item(1).Enabled = True
    End Sub

    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
        If TDBGrid1.Row < 0 Then
            Exit Sub
        End If
        frmbotones.Visible = False
        modoedit = True
        lblMensaje.Text = "Editar"
        Call ModoPlantilla(True)
        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        txt0.CtlEnabled = False
        SSTab1.TabPages.Item(1).Enabled = True
    End Sub

    Private Sub cmdBotones2_Click(sender As Object, e As EventArgs) Handles cmdBotones2.Click
        If MsgBox("Desea eliminar el registro con Correlativo Nº " & CShort(TDBGrid2.Columns(2).Text) & " ?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "AVISO") = MsgBoxResult.Yes Then
            SQL = "DELETE FROM CT_PLANTILLAASIENTO WHERE subasientocodigo = '" & Trim(Ctr_Ayuda2.xclave) & "' AND asientocodigo = '" & Trim(Ctr_Ayuda1.xclave) & "' AND plantillaasientocorrela =" & CShort(TDBGrid2.Columns(2).Text)
            VGCNx.Execute(SQL)
            Call MuestraGrid2()
        End If
        SSTab1.TabPages.Item(1).Enabled = True
    End Sub

    Private Sub cmdBotones3_Click(sender As Object, e As EventArgs) Handles cmdBotones3.Click
        Call Impresion()
        SSTab1.TabPages.Item(1).Enabled = True
    End Sub

    Private Sub cmdBotones4_Click(sender As Object, e As EventArgs) Handles cmdBotones4.Click
        Me.Close()
        SSTab1.TabPages.Item(1).Enabled = True
    End Sub
End Class