Option Strict Off
Option Explicit On
Public Class frmlogin
    Inherits System.Windows.Forms.Form


    Private Sub CargarParametros()
        Dim rssql As New ADODB.Recordset
        VGParamSistem.Anoproceso = Format(Year(DTPfecha.Value), "0000")
        VGParamSistem.Mesproceso = Format(Month(DTPfecha.Value), "00")
        VGParamSistem.TablaCabcomprob = "ct_cabcomprob" & Year(DTPfecha.Value)
        VGParamSistem.TablaDetcomprob = "ct_detcomprob" & Year(DTPfecha.Value)
        VGParamSistem.FechaTrabajo = DTPfecha.Value
        rssql = VGCNx.Execute("select * from co_multiempresas where empresacodigo='" & VGParametros.empresacodigo & "'")
        If rssql.RecordCount > 0 Then VGParametros.RucEmpresa = ESNULO(rssql.Fields("empresaruc"), "")
    End Sub
    Private Function Validaraño() As Boolean
        Validaraño = True
        Dim rsaux As ADODB.Recordset
        rsaux = New ADODB.Recordset
        'Verificar que existan cabecera de comprobante
        rsaux.Open("select name from sysobjects where name in ('" & VGParamSistem.TablaCabcomprob & "','" & VGParamSistem.TablaDetcomprob & "')", VGCNx)
        If rsaux.RecordCount <= 1 Then
            MsgBox("No estan aperturadas la tablas para este año", MsgBoxStyle.Exclamation)
            Validaraño = False
        End If
    End Function


    Private Sub cmdGenerar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGenerar.Click
        frmannos.Visible = False
        frmannos.DTPanno.Value = DTPfecha.Value
        frmannos.cmdGenerar_Click(Nothing, New System.EventArgs())
        framaño.Visible = False
        frmannos.Close()
    End Sub
    Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo1.SelectedIndexChanged
        Dim RSQL As String
        Dim rs As ADODB.Recordset
        On Error GoTo ERRAR
        If Combo1.Items.Count > 0 Then
            rs = New ADODB.Recordset
            SQL = "Select * from EMPRESA WHERE  EMP_RAZON_NOMBRE = '" & Trim(Combo1.Text) & "' "
            SQL = SQL & " and empresaflagcontabilidad= 1"
            rs = VGConfig.Execute(SQL)
            Lbgrupo.Text = ""
            If Not rs.EOF Then
                VGParametros.NomEmpresa = rs.Fields("EMP_RAZON_NOMBRE").Value
                VGParametros.RucEmpresa = ESNULO(rs.Fields("EMP_RUC_DOCUMENTO"), "")
                If ESNULO(rs.Fields("MultiEmpresas"), False) = True Then Lbgrupo.Text = "Grupo"
                VGParametros.MultiEmpresas = ESNULO(rs.Fields("MultiEmpresas"), False)
                VGtipolicencia = rs.Fields("tipodelicencias").Value
                VGfechalicencia = rs.Fields("fechalimitelicencias").Value
                VGCodEmpresa = rs.Fields("EMP_CODIGO").Value
                If Trim(rs.Fields("empresabasecontabilidad").Value) <> "" Then
                    VGParamSistem.BDEmpresa = rs.Fields("empresabasecontabilidad").Value
                    VGCNx = New ADODB.Connection
                    VGCNx.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                    VGCNx.CommandTimeout = 0
                    VGCNx.ConnectionTimeout = 0
                    VGCNx.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=" & VGParamSistem.Usuario & ";Password=" & VGParamSistem.Pwd & ";Initial Catalog=" & VGParamSistem.BDEmpresa & ";Data Source=" & VGParamSistem.Servidor
                    VGCNxSql = "Data Source=" & VGParamSistem.Servidor & ";Initial Catalog=" & VGParamSistem.BDEmpresa & ";User ID=" & VGParamSistem.Usuario & ";Password=" & VGParamSistem.Pwd
                    VGCNx.Open()
                End If
            End If
            If Lbgrupo.Text = "Grupo" Then
                Lbempresa.Visible = True
                Combo2.Visible = True
            Else
                Lbgrupo.Text = "Empresa"
                Lbempresa.Visible = False
                Combo2.Visible = False
            End If
            Call LlenarListaempresas()
            rs.Close()

            Call CargarParametrosContabilidad()
        End If
        Exit Sub

ERRAR:
        MsgBox("Ocurrio un Error," & ErrorToString() & " debe Actualizar su Base de Datos e Ingrese Nuevamente al Sistema", MsgBoxStyle.Information, "Aviso..")
        Resume Next
    End Sub

    Private Sub Combo1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Combo1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then System.Windows.Forms.SendKeys.Send("{tab}")
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        VGParametros.NomEmpresa = Mid(Combo2.Text, 1, Len(Combo2.Text) - 2)
        MDIPrincipal.Text = "Sistema de Contabilidad - " & VGParametros.NomEmpresa
    End Sub

    Private Sub Combo2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Combo2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then System.Windows.Forms.SendKeys.Send("{tab}")
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub



    Private Sub frmlogin_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        DTPfecha.Value = Today
        Call LlenarListBox()
    End Sub
    Private Function VERIFICAUSUARIO() As Boolean
        Dim RSPASS As New ADODB.Recordset
        Dim Pwd As String
        Dim CLMENU As ClassMenu
        CLMENU = New ClassMenu
        CLMENU.TablaUsu = "SI_USUARIO"

        'cuando no existe usuarios
        VERIFICAUSUARIO = False
        RSPASS = New ADODB.Recordset
        RSPASS.Open("SELECT * FROM " & UCase(CLMENU.TablaUsu), VGConfig, ADODB.CursorTypeEnum.adOpenKeyset)
        If RSPASS.RecordCount = 0 Then
            VERIFICAUSUARIO = True
            Exit Function
        End If
        'VALIDANDO SI EXISTE EL USUARIO
        RSPASS = New ADODB.Recordset
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        RSPASS.Open("SELECT * FROM " & UCase(CLMENU.TablaUsu) & " WHERE USUARIOCODIGO='" & TxUser.CtlText & "'", VGConfig, ADODB.CursorTypeEnum.adOpenKeyset)
        If RSPASS.RecordCount = 0 Then
            MsgBox("NO SE ENCUENTRA EL USUARIO ", MsgBoxStyle.Exclamation)
            TxUser.Focus()
            Exit Function
        End If

        'VALIDANDO SI EXISTE EL PWD
        If CDbl(VGTipoCod) = 1 Then
            Pwd = CODIFICASQL((TxPwd.CtlText))
        Else
            Pwd = CODIFICA((TxPwd.CtlText), NUMMAGICO)
        End If
        RSPASS = Nothing
        SQL = "SELECT * FROM " & UCase(CLMENU.TablaUsu) & " WHERE USUARIOCODIGO='" & TxUser.CtlText & "'"
        SQL = SQL & " AND USUarioPASSWORD='" & Pwd & "'"
        RSPASS = VGConfig.Execute(SQL)
        If RSPASS.RecordCount = 0 Then
            MsgBox("LA CONTRASEÑA ES INCORRECTA", MsgBoxStyle.Exclamation)
            TxPwd.Focus()
            Exit Function
        End If
        VERIFICAUSUARIO = True
    End Function

    Private Sub frmlogin_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'End
    End Sub

    Public Sub LlenarListBox()
        Dim REG1 As New ADODB.Recordset
        REG1 = VGConfig.Execute("Select * from EMPRESA where empresaflagcontabilidad= 1 order by EMP_CODIGO ")
        If REG1.BOF Then Exit Sub
        Do While Not REG1.EOF
             If Not IsDBNull(REG1.Fields("EMP_RAZON_NOMBRE").Value) Then
                Combo1.Items.Add(REG1.Fields("EMP_RAZON_NOMBRE").Value)
            End If
            REG1.MoveNext()
        Loop
        If Combo1.Items.Count > 0 Then Combo1.SelectedIndex = 0
    End Sub

    Public Sub LlenarListaempresas()
        Dim REG1 As New ADODB.Recordset
        REG1 = New ADODB.Recordset
        REG1 = VGCNx.Execute("Select * from co_multiempresas where empresacodigo<>'00'  ")
        Combo2.Items.Clear()
        If REG1.EOF Then Exit Sub
        If REG1.BOF Then Exit Sub
        Do While Not REG1.EOF
            Combo2.Items.Add(REG1.Fields("empresacodigo").Value + " " + REG1.Fields("empresadescripcion").Value)
            REG1.MoveNext()
        Loop

        REG1.MoveFirst()
        Combo2.SelectedIndex = 0


    End Sub
    Private Sub TxPwd_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyPressEvent) Handles TxPwd.KeyPressEvent
        If eventArgs.keyAscii = 13 Then System.Windows.Forms.SendKeys.Send("{tab}")
    End Sub
    Private Sub TxUser_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyPressEvent) Handles TxUser.KeyPressEvent
        If eventArgs.keyAscii = 13 Then
            TxUser.CtlText = UCase(TxUser.CtlText)
            System.Windows.Forms.SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click
        VGSalir = True

        Me.Hide()
    End Sub

    Private Sub CmdAceptar_Click_1(sender As Object, e As EventArgs) Handles CmdAceptar.Click
        Dim tccambio As Double
        Call CargarParametros()
        If Not Validaraño() Then
            framaño.Visible = True

            Exit Sub
        Else
            framaño.Visible = False

        End If
        If Not VERIFICAUSUARIO() Then Exit Sub
        tccambio = XRecuperaTipoCambio(CDate(VB6.Format(DTPfecha.Value, "dd/mm/yyyy")), tipocambio.Venta, VGCNx)
        If tccambio = 0 Then
            MsgBox("No existe tipo de cambio para esta fecha", MsgBoxStyle.Information)
        End If
        MDIPrincipal.StatusBar1.Items.Item(1).Text = "Mes Proceso : " & DesMes(VGParamSistem.Mesproceso)
        MDIPrincipal.StatusBar1.Items.Item(2).Text = "Año Proceso :" & VGParamSistem.Anoproceso
        MDIPrincipal.StatusBar1.Items.Item(3).Text = "Fecha de Trabajo (" & VGParamSistem.FechaTrabajo & ")"
        MDIPrincipal.StatusBar1.Items.Item(4).Text = "Tipo Cambio  (" & VB6.Format(tccambio, "#.000") & ")"
        VGUsuario = UCase(TxUser.CtlText)
        Dim Clsmenu As New ClassMenu
        Clsmenu.Conexion = VGConfig
        MainContab.VGtipo = TIPOSISTEMA.contab
        Clsmenu.TablaMenu = "si_menu"
        Clsmenu.CrearTablaMenu()
        Clsmenu.TabaMenuDet = "si_menuusuarios"
        Clsmenu.TablaMenu = "si_menu"
        Call Clsmenu.HabilitarMenuNom(VGUsuario)
        Call adicionarcamposCT()
        Call CargarParametrosContabilidad()
        If TxUser.CtlText <> "" Then
            VGParamSistem.Usuario = TxUser.CtlText
            VGParamSistem.Pwd = ""
            MDIPrincipal.Text = MDIPrincipal.Text & " Usuario : " & TxUser.CtlText
        Else
            MDIPrincipal.Text = MDIPrincipal.Text & " Usuario : Sin Usuario "
        End If
        Me.Close()
    End Sub

End Class