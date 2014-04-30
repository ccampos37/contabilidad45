Option Strict Off
Option Explicit On
Imports Func = Contabilidad.ModFuncionesGen
Friend Class frmParametros
    Inherits System.Windows.Forms.Form


    Dim rs As New ADODB.Recordset
    Dim FlagNUEVO As Boolean

    Private Sub Ctr_AyudaCuentaAjuste_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_AyudaCuentaAjuste.AlDevolverDato
        Dim Index As Short = Ctr_AyudaCuentaAjuste.GetIndex(eventSender)
        cmdBotones0.Enabled = ValidaBoton()
    End Sub

    Private Sub Ctr_Codigo_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_Codigo.AlDevolverDato
        Dim Index As Short = Ctr_Codigo.GetIndex(eventSender)
        Ctr_Codigo1.Filtro = "asientocodigo='" & eventArgs.colecCampos(0).Value & "'"
    End Sub

    Private Sub frmParametros_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        rs = New ADODB.Recordset
        Ctr_moneda.CtlEnabled = True
        Ctr_moneda.conexion(VGCNx)
        Ctr_AyudaCuentaAjuste0.conexion(VGCNx)
        Ctr_AyudaCuentaAjuste1.conexion(VGCNx)
        Ctr_AyudaCuentaAjuste0.Filtro = "cuentanivel=" & VGnumnivelescuenta
        Ctr_AyudaCuentaAjuste1.Filtro = "cuentanivel=" & VGnumnivelescuenta
        Ctr_Codigo0.conexion(VGCNx)
        Ctr_Codigo1.conexion(VGCNx)
        Call CargarData()
        cmdBotones0.Enabled = False
    End Sub

    Sub CargarData()
        Dim SQL As String
        'SQL = "SELECT sistemadescripcionempresa,sistemadescrcortaempresa,sistemaesttipodescrempresa,sistemadireccionempresa,sistemaempresaruc,sistemaestcuadreasiento,sistemaestimpresionasiento,sistemaconfiguracuenta,monedacodigo,sistemavalorigv,sistemaajustelinea,isnull(sistemactaajustedeb,''),isnull(sistemactaajustehab,''),sistemaasientocodigo,sistemasubasientocodigo,sistemamonista FROM ct_sistema"
        SQL = "SELECT * FROM ct_sistema"
        rs = VGCNx.Execute(SQL)
        If rs.RecordCount = 0 Then
            FlagNUEVO = True
            Call LlenarLista()
            Exit Sub
        End If

        Call MuestraData()
        Call LlenarLista()
        Call MarcarLista()

    End Sub

    Sub MuestraData()
        Dim I As Short
        For I = 0 To 3
            txt(I).Text = Trim(IIf(I > 1, rs.Fields("sistemadescrcortaempresa").Value, rs.Fields("sistemadescripcionempresa").Value))
        Next
        chk0.CheckState = IIf(rs.Fields("sistemaesttipodescrempresa").Value = 0, 0, 1)
        chk1.CheckState = IIf(rs.Fields("sistemaestcuadreasiento").Value = 0, 0, 1)
        chk2.CheckState = IIf(rs.Fields("sistemaestimpresionasiento").Value = 0, 0, 1)
        chk4.CheckState = IIf(rs.Fields("sistemamonista").Value = 0, 0, 1)
        chk5.CheckState = IIf(rs.Fields("ingresoformatorapido").Value = 0, 0, 1)

        'SQL = 1,2,3,sistemadireccionempresa,sistemaempresaruc,5,6,
        'sistemaconfiguracuenta,8 ,9,10,11,12  ,13 ,14 , FROM ct_sistema"


        Ctr_moneda.xclave = Trim(rs.Fields("monedacodigo").Value) : Ctr_moneda.Ejecutar()
        txt4.Text = rs.Fields("sistemavalorigv").Value
        chk3.CheckState = IIf(rs.Fields("sistemaajustelinea").Value = 0, 0, 1)

        Ctr_AyudaCuentaAjuste0.xclave = rs.Fields("sistemactaajustedeb").Value : Ctr_AyudaCuentaAjuste0.Ejecutar()
        Ctr_AyudaCuentaAjuste1.xclave = rs.Fields("sistemactaajustehab").Value : Ctr_AyudaCuentaAjuste1.Ejecutar()

        Ctr_Codigo0.xclave = rs.Fields("sistemaasientocodigo").Value : Ctr_Codigo0.Ejecutar()
        Ctr_Codigo1.xclave = rs.Fields("sistemasubasientocodigo").Value : Ctr_Codigo1.Ejecutar()

    End Sub

    Sub LlenarLista()
        Dim I As Short
        Dim itmX As System.Windows.Forms.ListViewItem

        ListView1.Columns.Clear()
        ListView1.Items.Clear()
        ListView1.Columns.Add("", "Número Dígitos", CInt(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(ListView1.Width) / 1)))
        ListView1.View = System.Windows.Forms.View.Details

        ListView2.Columns.Clear()
        ListView2.Items.Clear()
        ListView2.Columns.Add("", "Número Dígitos", CInt(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(ListView2.Width) / 1)))
        ListView2.View = System.Windows.Forms.View.Details
        For I = 1 To 9
            itmX = ListView1.Items.Add(CStr(I))
            itmX = ListView2.Items.Add(CStr(I))
        Next

    End Sub

    Sub MarcarLista()
        Dim I As Short
        Dim J As Short

        Call ParametroCuenta(0)
        For I = 1 To VGnumnivelescuenta
            For J = 1 To 9
                If CDbl(ListView1.Items.Item(J).Text) = VG_aNIVELES(I - 1) Then
                    ListView1.Items.Item(J).Checked = True
                End If
            Next
        Next

        ''**
        If VGnumnivelescentrocosto > 0 Then
            For I = 1 To VGnumnivelescentrocosto
                For J = 1 To 9
                    'UPGRADE_WARNING: El límite inferior de la colección ListView2.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    If CDbl(ListView2.Items.Item(J).Text) = VG_cNIVELES(I - 1) Then
                        ListView2.Items.Item(J).Checked = True
                    End If
                Next
            Next
        End If

    End Sub

    Function ValidarData() As Boolean
        Dim I As Short

        Dim nC As Short

        Dim rsX As ADODB.Recordset
        For I = 1 To 9
            If ListView1.Items.Item(I).Checked = True Then
                ValidarData = True
                Exit For
            Else
                ValidarData = False
                If I = 9 Then
                    MsgBox("Falta Seleccionar los Niveles para el Plan de Cuentas", MsgBoxStyle.Information, Text)
                    Exit Function
                End If
            End If
        Next

        For I = 1 To 9
            If ListView1.Items.Item(I).Checked = True Then
                nC = nC + 1
            End If
        Next
        If nC < 3 Then
            MsgBox("Debe Seleccionar al menos 3 Niveles para el Plan de Cuentas", MsgBoxStyle.Information, Text)
            ValidarData = False
            Exit Function
        End If
        nC = 0
        Dim J As Short
        For J = 1 To 9
            If ListView1.Items.Item(J).Checked = True Then
                For I = 1 To VGnumnivelescuenta
                    If CDbl(ListView1.Items.Item(J).Text) = VG_aNIVELES(I - 1) Then
                        nC = nC + 1
                    End If
                Next
            End If
        Next

        rsX = New ADODB.Recordset
        If ESNULO(txt4.Text, 0) = 0 Then
            MsgBox("Debe registrar Valor(%) para el IGV", MsgBoxStyle.Information, Text)
            ValidarData = False
            txt4.Focus()
            Exit Function
        End If

        If chk3.CheckState = 0 And (IsNothing(Ctr_AyudaCuentaAjuste0.xclave) Or IsNothing(Ctr_AyudaCuentaAjuste1.xclave)) Then
            MsgBox("El Check de Ajuste en Linea esta inactivo y Cuentas de Ajuste estan sin Datos", MsgBoxStyle.Information, Text)
            ValidarData = False
            Ctr_AyudaCuentaAjuste0.Focus()
            Exit Function
        End If

        ValidarData = True
    End Function

    Sub GrabarData()
        On Error GoTo x
        Dim SQL As String

        Dim ValorMoneda As String
        ValorMoneda = Ctr_moneda.xclave
        '  VGvardllgen = New dllgeneral.dll_general

        strvalor = NivelCuenta(0)
        strvalor1 = NivelCuenta(1)
        Call ParametroCuenta(1)

        If FlagNUEVO = True Then
            SQL = "INSERT INTO ct_sistema (sistemadescripcionempresa, sistemadescrcortaempresa,"
            SQL = SQL & "sistemaesttipodescrempresa, sistemadireccionempresa,sistemaempresaruc,"
            SQL = SQL & "sistemaestcuadreasiento,sistemaestimpresionasiento, sistemaconfiguracuenta,"
            SQL = SQL & "monedacodigo,sistemaultimonivel,sistemavalorigv,sistemaajustelinea,"
            SQL = SQL & "sistemactaajustedeb,sistemactaajustehab,usuariocodigo,fechaact,sistemaasientocodigo,"
            SQL = SQL & "sistemasubasientocodigo,sistemamonista,sistemaconfiguracentrocostos,sistemaultimonivelcostos,"
            SQL = SQL & " ingresoformatorapido) "
            SQL = SQL & "VALUES ('" & Trim(txt0.Text) & "','" & Trim(txt1.Text) & "'," & chk0.CheckState & ""
            SQL = SQL & ",'" & Trim(txt2.Text) & "','" & Trim(txt3.Text) & "'," & chk1.CheckState & "," & chk2.CheckState
            SQL = SQL & ",'" & strvalor & "','" & ValorMoneda & "'," & VGnumnivelescuenta & "," & txt(4).Text
            SQL = SQL & "," & chk4.CheckState & ",'" & Ctr_AyudaCuentaAjuste0.xclave & "'"
            SQL = SQL & ",'" & Ctr_AyudaCuentaAjuste1.xclave & "','" & VGUsuario & "','" & Today & "'"
            SQL = SQL & ",'" & Trim(Ctr_Codigo0.xclave) & "','" & Trim(Ctr_Codigo1.xclave) & "'"
            SQL = SQL & "," & chk4.CheckState & ",'" & strvalor1 & "'," & VGnumnivelescentrocosto & ""
            SQL = SQL & "," & chk5.CheckState & " "
        Else
            SQL = "Update ct_sistema "
            SQL = SQL & "SET sistemadescripcionempresa='" & Trim(txt0.Text) & "'"
            SQL = SQL & ",sistemadescrcortaempresa='" & Trim(txt1.Text) & "'"
            SQL = SQL & ",sistemaesttipodescrempresa='" & chk0.CheckState & "'"
            SQL = SQL & ",sistemadireccionempresa='" & Trim(txt2.Text) & "',sistemaempresaruc='" & txt3.Text & "'"
            SQL = SQL & ",sistemaestcuadreasiento=" & chk1.CheckState & ",sistemaestimpresionasiento=" & chk2.CheckState
            SQL = SQL & ",sistemaconfiguracuenta='" & strvalor & "'"
            SQL = SQL & ",monedacodigo='" & ValorMoneda & "',sistemaultimonivel=" & VGnumnivelescuenta
            SQL = SQL & ",sistemavalorigv=" & ESNULO(txt4.Text, 0)
            SQL = SQL & ",sistemaajustelinea=" & chk3.CheckState & ",sistemactaajustedeb='" & Ctr_AyudaCuentaAjuste0.xclave & "',sistemactaajustehab='" & Ctr_AyudaCuentaAjuste(1).xclave & "'"
            SQL = SQL & ",usuariocodigo='" & VGUsuario & "',fechaact='" & Today & "',"
            SQL = SQL & "sistemaasientocodigo='" & Ctr_Codigo(0).xclave & "',"
            SQL = SQL & "sistemasubasientocodigo='" & Ctr_Codigo(1).xclave & "',"
            SQL = SQL & "sistemamonista=" & chk4.CheckState & ""
            SQL = SQL & ",sistemaconfiguracentrocostos='" & strvalor1 & "'"
            SQL = SQL & ",sistemaultimonivelcostos=" & VGnumnivelescentrocosto & ","
            SQL = SQL & "ingresoformatorapido=" & chk5.CheckState & ""


        End If
        VGCNx.Execute(SQL)
        cmdBotones0.Enabled = False

        Exit Sub

x:
        MsgBox("Error inesperado: " & Err.Description & "  " & Err.Number)
    End Sub

    Function NivelCuenta(ByRef Index As Short) As String
        Dim I As Short
        Dim valor As String
        valor = CStr(Nothing)
        Select Case Index
            Case 0
                For I = 1 To 9
                    If ListView1.Items.Item(I).Checked = True Then
                        valor = valor & ListView1.Items.Item(I).Text & "*"
                    End If
                Next
            Case 1
                For I = 1 To 9
                    If ListView2.Items.Item(I).Checked = True Then
                        valor = valor & ListView2.Items.Item(I).Text & "*"
                    End If
                Next
        End Select
        NivelCuenta = Func.Left(valor, Len(valor) - 1)
    End Function

    Private Sub ListView1_ItemCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ItemCheckEventArgs) Handles ListView1.ItemCheck
        Dim Item As System.Windows.Forms.ListViewItem = ListView1.Items(eventArgs.Index)
        cmdBotones0.Enabled = ValidaBoton()
    End Sub

    Private Sub txt_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Change
        Dim Index As Short = txt.GetIndex(eventSender)
        cmdBotones0.Enabled = ValidaBoton()
    End Sub

    'UPGRADE_WARNING: El evento chk.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chk_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        cmdBotones0.Enabled = ValidaBoton()
    End Sub

    Function ValidaBoton() As Boolean
        Dim I As Short
        For I = 0 To 3
            If IsNothing(txt(I).Text) Then
                ValidaBoton = False
                Exit Function
            End If
        Next
        ValidaBoton = True

    End Function

    Private Sub txt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Leave
        Dim Index As Short = txt.GetIndex(eventSender)
    End Sub

    Private Function cmdBotones(p1 As Integer) As Object
        Throw New NotImplementedException
    End Function
    Private Sub cmdBotones0_Click(sender As Object, e As EventArgs) Handles cmdBotones0.Click
        If ValidarData() = True Then
            Call GrabarData()
            Call CargarParametrosContabilidad()
        End If

    End Sub

    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
        Me.Close()
    End Sub
End Class