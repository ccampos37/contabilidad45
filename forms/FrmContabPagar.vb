Option Strict Off
Option Explicit On
Friend Class FrmContabPagar
	Inherits System.Windows.Forms.Form
    Dim sqlcad As String
	Dim cnxtrans As ADODB.Connection
	Dim rstrans As ADODB.Recordset
	Dim NombreArchivo As String

	Private Sub CmdArchivo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdArchivo.Click
		cmdg_archivoOpen.Filter = "Archivos de Exportacion|EXPO*.EX"
		cmdg_archivoOpen.ShowDialog()
		NombreArchivo = cmdg_archivoOpen.FileName
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
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		
		paso1 = 0
		
        Call DeleteDataPlanillaCobrar(rsparimpo.Fields("asientocodigo").Value, rsparimpo.Fields("subasientocodigo").Value, CShort(Format(Month(DTPPerido.Value), "00")), CStr(Year(DTPPerido.Value)))

        '  MsgBox (" Contabilizando Aplicaciones ")

        VGGeneral.BeginTrans()
        Comando = New ADODB.Command
        With Comando
            .CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            .CommandText = "cp_GeneraAsientoPagarenLinea_pro"
            .ActiveConnection = VGGeneral.ConnectionString
            .Parameters.Refresh()
            .Parameters("@BaseConta") = VGParamSistem.BDEmpresa
            .Parameters("@BaseVenta") = VGParamSistem.BDEmpresa
            .Parameters("@empresa") = VGParametros.empresacodigo
            .Parameters("@Asiento") = rsparimpo.Fields("asientocodigo").Value
            .Parameters("@SubAsiento") = rsparimpo.Fields("subasientocodigo").Value
            .Parameters("@Libro") = rsparimpo.Fields("Librocodigo").Value
            .Parameters("@Mes") = Format(Month(DTPPerido.Value), "00")
            .Parameters("@Ano") = Year(DTPPerido.Value)
            .Parameters("@tipanal") = "001"
            .Parameters("@Compu") = VGcomputer
            .Parameters("@Usuario") = VGParamSistem.Usuario
            .Parameters("@ajustedebe") = VGParametros.sistemactaajustedeb
            .Parameters("@ajustehaber") = VGParametros.sistemactaajustehab
            .Execute()
        End With
        VGGeneral.CommitTrans()

        ' MsgBox (" Contabilizando Canjes  ")

        VGGeneral.BeginTrans()
        Comando = New ADODB.Command
        With Comando
            .CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            .CommandText = "cp_GeneraAsientoPagarenLinea1_pro"
            .ActiveConnection = VGGeneral.ConnectionString
            .Parameters.Refresh()
            .Parameters("@BaseConta") = VGParamSistem.BDEmpresa
            .Parameters("@BaseVenta") = VGParamSistem.BDEmpresa
            .Parameters("@empresa") = VGParametros.empresacodigo
            .Parameters("@Asiento") = rsparimpo.Fields("asientocodigo").Value
            .Parameters("@SubAsiento") = rsparimpo.Fields("subasientocodigo").Value
            .Parameters("@Libro") = rsparimpo.Fields("Librocodigo").Value
            .Parameters("@Mes") = Format(Month(DTPPerido.Value), "00")
            .Parameters("@Ano") = Year(DTPPerido.Value)
            .Parameters("@tipanal") = "001"
            .Parameters("@Compu") = VGcomputer
            .Parameters("@Usuario") = VGParamSistem.Usuario
            .Parameters("@ajustedebe") = VGParametros.sistemactaajustedeb
            .Parameters("@ajustehaber") = VGParametros.sistemactaajustehab
            .Execute()
        End With
        VGGeneral.CommitTrans()

        ' MsgBox (" Contabilizando Compensaciones ")

        VGGeneral.BeginTrans()
        Comando = New ADODB.Command
        With Comando
            .CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            .CommandText = "cp_GeneraAsientoPagarenLinea2_pro"
            .ActiveConnection = VGGeneral.ConnectionString
            .Parameters.Refresh()
            .Parameters("@BaseConta") = VGParamSistem.BDEmpresa
            .Parameters("@BaseVenta") = VGParamSistem.BDEmpresa
            .Parameters("@empresa") = VGParametros.empresacodigo
            .Parameters("@Asiento") = rsparimpo.Fields("asientocodigo").Value
            .Parameters("@SubAsiento") = rsparimpo.Fields("subasientocodigo").Value
            .Parameters("@Libro") = rsparimpo.Fields("Librocodigo").Value
            .Parameters("@Mes") = Format(Month(DTPPerido.Value), "00")
            .Parameters("@Ano") = Year(DTPPerido.Value)
            .Parameters("@tipanal") = "001"
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
	
	Private Function Restaurar() As Boolean
		Dim Data(1) As String
		Dim Log(1) As String
		Dim i As Short
		Restaurar = False
		On Error GoTo restarurar
		cnxtrans = New ADODB.Connection
		With cnxtrans
			.CursorLocation = ADODB.CursorLocationEnum.adUseClient
			.CommandTimeout = 0
			.ConnectionTimeout = 0
			.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=" & VGParamSistem.Usuario & ";Password=" & VGParamSistem.Pwd & ";Initial Catalog=TRANSFER;Data Source=" & VGParamSistem.Servidor
			.Open()
		End With
		rstrans = New ADODB.Recordset
		rstrans.Open("Select name,filename From SysFiles ", cnxtrans, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		rstrans.MoveFirst()
		Data(0) = rstrans.Fields("Name").Value : Data(1) = rstrans.Fields("FileName").Value
		rstrans.MoveNext()
		Log(0) = rstrans.Fields("Name").Value : Log(1) = rstrans.Fields("FileName").Value
Reintento: 
		MsgBox("Se procede a Restaurar", MsgBoxStyle.Information)
		cnxtrans = Nothing
		rstrans = Nothing
		MsgBox("Se procede a Restaurar", MsgBoxStyle.Information)
		sqlcad = " RESTORE DATABASE TRANSFER " & " FROM DISK='" & NombreArchivo & "'" & " WITH RECOVERY,  " & " Move '" & Trim(Data(0)) & "' TO '" & Trim(Data(1)) & "', " & " Move '" & Trim(Log(0)) & "' TO  '" & Trim(Log(1)) & "' "
		VGGeneral.Execute(sqlcad)
		Restaurar = True
		MsgBox("Se Restauro Satisfactoriamente", MsgBoxStyle.Information)
		Exit Function
restarurar: 
		If MsgBox("Desea Reintentar la Restauracion", MsgBoxStyle.Question + MsgBoxStyle.RetryCancel) = MsgBoxResult.Retry Then
			GoTo Reintento
		End If
		Restaurar = False
		MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Error al restauar")
	End Function
	

	Sub DeleteDataPlanillaCobrar(ByRef Asiento As String, ByRef SubAsiento As String, ByRef mes As Short, ByRef anno As String)
		Dim SQL As String
		
		SQL = "DELETE FROM ct_cabcomprob" & anno & " where asientocodigo='" & Asiento & "' AND "
		SQL = SQL & "subasientocodigo='" & SubAsiento & "' AND "
		SQL = SQL & "cabcomprobmes=" & mes & " and empresacodigo='" & VGParametros.empresacodigo & "'"
		VGCNx.Execute(SQL)
		
	End Sub

    Private Sub FrmContabPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class