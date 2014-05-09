Option Strict Off
Option Explicit On
Friend Class FrmAjusDiferxDoc
	Inherits System.Windows.Forms.Form
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If Not ValidaIngreso() Then Exit Sub
        Call GenAjuste()
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmAjusDiferxDoc_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call Ctr_AyudaCCosto.ConectarBD() : Ctr_AyudaCCosto.Filtro = "empresacodigo ='" & VGParametros.empresacodigo & "'"
        DateTimePicker1.Value = Fecha(2, VGParamSistem.FechaTrabajo)
    End Sub
    Private Function ValidaIngreso() As Boolean
        Dim tipocambio_Renamed As Short
        tipocambio_Renamed = 0
        ValidaIngreso = False
        If Ctr_AyudaCCosto.Codigo = "" Then
            MsgBox("Debe Ingresar un Centro de Costo", MsgBoxStyle.Exclamation)
            Ctr_AyudaCCosto.Focus()
            Exit Function
        End If
        tipocambio_Renamed = XRecuperaTipoCambio(DateTimePicker1.Value, tipocambio.Compra, VGCnxCT)
        If tipocambio_Renamed = 0 Then
            MsgBox("Fecha de Ajuste no tiene tipo de cambio", MsgBoxStyle.Exclamation)
            DateTimePicker1.Focus()
            Exit Function
        End If
        ValidaIngreso = True
    End Function
    Private Sub GenAjuste()
        On Error GoTo Ajuste
        VGGeneral.BeginTrans()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        EliminaAjustes()
        '  Mayoriza

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        VGCommandoSP = New ADODB.Command
        VGCommandoSP.let_ActiveConnection(VGGeneral)
        VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        VGCommandoSP.CommandText = "Ct_AjusDifCambxDoc_pro"
        VGCommandoSP.Parameters.Refresh()
        With VGCommandoSP
            .Parameters("@base").Value = VGParamSistem.BDEmpresa
            .Parameters("@empresa").Value = VGParametros.empresacodigo
            .Parameters("@Ano").Value = Year(DateTimePicker1.Value)
            .Parameters("@Mes").Value = Month(DateTimePicker1.Value)
            .Parameters("@Asiento").Value = "055"
            .Parameters("@SubAsiento").Value = "0099"
            .Parameters("@AjusteDebe").Value = Trim(VGParametros.sistemactaajustedeb)
            .Parameters("@AjusteHaber").Value = Trim(VGParametros.sistemactaajustehab)
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DTPicker1.Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .Parameters("@Fecha").Value = DateTimePicker1.Value
            .Parameters("@Usuario").Value = VGParamSistem.Usuario
            .Parameters("@NombrePC").Value = VGcomputer
            .Parameters("@TipoCambio1").Value = XRecuperaTipoCambio((DateTimePicker1.Value), 1, VGCnxCT)
            .Parameters("@TipoCambio2").Value = XRecuperaTipoCambio((DateTimePicker1.Value), 2, VGCnxCT)
            .Parameters("@CCosto").Value = Ctr_AyudaCCosto.Codigo
            rs = .Execute
        End With

        Mayoriza()

        VGGeneral.CommitTrans()
        If rs.State = 0 Then
            MsgBox("El Ajuste de Diferencia de Cambio de Documentos " & Chr(13) & "Cancelados se Realizo Satisfactoriamente ", MsgBoxStyle.Information)
        Else
            MsgBox("El Ajuste de Diferencia de Cambio de Documentos " & Chr(13) & "Cancelados No se Realizará porque no Encontro " & Chr(13) & "Ni un Documento a Ajustar ", MsgBoxStyle.Exclamation)

        End If
         System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
        Exit Sub

Ajuste:
        VGGeneral.RollbackTrans()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
        MsgBox("No se genero el Ajuste " & Chr(13) & Err.Description, MsgBoxStyle.Exclamation)
    End Sub
    Private Sub EliminaAjustes()
        Dim rs1 As ADODB.Recordset
        Dim SQL As String
        rs1 = New ADODB.Recordset

        'Eliminando asientos de ajuste
        'Ajuste Ganancia
        SQL = "Delete From ct_cabcomprob" & Year(DateTimePicker1.Value) & " Where empresacodigo='" & VGParametros.empresacodigo & "' " & "And cabcomprobmes=" & Month(DateTimePicker1.Value) & " AND cabcomprobnumero='" & Format(Month(DateTimePicker1.Value), "00") & "05500001' " & " AND subasientocodigo='0099' AND asientocodigo='055'"
        rs1 = VGCNx.Execute(SQL)
        rs1 = Nothing
        'Ajuste Perdida
        SQL = "Delete From ct_cabcomprob" & Year(DateTimePicker1.Value) & " Where empresacodigo='" & VGParametros.empresacodigo & "' " & "And cabcomprobmes=" & Month(DateTimePicker1.Value) & " AND cabcomprobnumero='" & Format(Month(DateTimePicker1.Value), "00") & "05500002' " & " AND subasientocodigo='0099' AND asientocodigo='055'"
        rs1 = VGCNx.Execute(SQL)
        rs1 = Nothing
    End Sub
    Private Sub Mayoriza()
        VGCommandoSP = New ADODB.Command
        VGCommandoSP.let_ActiveConnection(VGGeneral)
        VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        VGCommandoSP.CommandText = "ct_mayoriza_pro"
        VGCommandoSP.Parameters.Refresh()
        With VGCommandoSP
            .Parameters("@base").Value = VGParamSistem.BDEmpresa
            .Parameters("@empresa").Value = VGParametros.empresacodigo
            .Parameters("@anno").Value = Year(DateTimePicker1.Value)
            .Parameters("@mespro").Value = Month(DateTimePicker1.Value)
            .Parameters("@user").Value = VGParamSistem.Usuario
            .Execute()
        End With
    End Sub
End Class