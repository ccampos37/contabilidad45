Option Strict Off
Option Explicit On
Friend Class FrmContabCobrar
	Inherits System.Windows.Forms.Form
    Dim sqlcad As String
	Dim cnxtrans As ADODB.Connection
	Dim rstrans As ADODB.Recordset

	Private Sub FrmContabCobrar_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        DTPPeriodo.Value = VGParamSistem.FechaTrabajo
        DTPPeriodo.Format = DateTimePickerFormat.Custom
        DTPPeriodo.CustomFormat = "MMMM yyyy"
    End Sub
    Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
    Private Sub CmdProcesar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdProcesar.Click
        Dim Comando As Object
        Dim rsparimpo As ADODB.Recordset
        Dim BaseOrigen As String
        Dim paso1 As Short
        On Error GoTo Proceso
        'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        paso1 = 0

        rsparimpo = New ADODB.Recordset
        rsparimpo.Open("ct_importarcobrar", VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If rsparimpo.RecordCount = 0 Then Exit Sub
        Call DeleteDataPlanillaCobrar(rsparimpo.Fields("asientocodigo").Value, rsparimpo.Fields("subasientocodigo").Value, CShort(Format(Month(DTPPeriodo.Value), "00")), CStr(Year(DTPPeriodo.Value)))
        VGGeneral.BeginTrans()
        Comando = New ADODB.Command
        With Comando
            .CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            .CommandText = "cc_GeneraAsientoCobrarenLinea_pro"
            .ActiveConnection = VGGeneral.ConnectionString
            .Parameters.Refresh()
            .Parameters("@BaseConta") = VGParamSistem.BDEmpresa
            .Parameters("@BaseVenta") = VGParamSistem.BDEmpresa
            .Parameters("@empresa") = VGParametros.empresacodigo
            .Parameters("@Asiento") = rsparimpo.Fields("asientocodigo").Value
            .Parameters("@SubAsiento") = rsparimpo.Fields("subasientocodigo").Value
            .Parameters("@Libro") = rsparimpo.Fields("Librocodigo").Value
            .Parameters("@Mes") = Format(Month(DTPPeriodo.Value), "00")
            .Parameters("@Ano") = Year(DTPPeriodo.Value)
            .Parameters("@tipanal") = "002"
            .Parameters("@Compu") = VGcomputer
            .Parameters("@Usuario") = VGParamSistem.Usuario
            .Parameters("@ajustedebe") = VGParametros.sistemactaajustedeb
            .Parameters("@ajustehaber") = VGParametros.sistemactaajustehab
            .Execute()
        End With
        VGGeneral.CommitTrans()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
        MsgBox("La Operacion se Realizo Satisfactoriamente", MsgBoxStyle.Information, "Sistema de Ventas")
        Me.Close()
        Exit Sub
Proceso:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
        MsgBox(Err.Description)
        VGGeneral.RollbackTrans()
        Exit Sub
        Resume
    End Sub


    Sub DeleteDataPlanillaCobrar(ByRef Asiento As String, ByRef SubAsiento As String, ByRef mes As Short, ByRef anno As String)
        Dim SQL As String

        SQL = "DELETE FROM ct_cabcomprob" & anno & " where asientocodigo='" & Asiento & "' AND "
        SQL = SQL & "subasientocodigo='" & SubAsiento & "' AND "
        SQL = SQL & "cabcomprobmes=" & mes & " and empresacodigo='" & VGParametros.empresacodigo & "'"
        VGCNx.Execute(SQL)

    End Sub


    Private Sub DTPPerido_ValueChanged(sender As Object, e As EventArgs) Handles DTPPeriodo.ValueChanged

    End Sub
End Class