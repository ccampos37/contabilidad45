Option Strict Off
Option Explicit On
Friend Class FrmSunat682
	Inherits System.Windows.Forms.Form
	Dim RSAUX As New ADODB.Recordset
	Dim lforma As Short
	
	Private Sub cmdCancelar_Click()
		Me.Close()
	End Sub
	
	
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		Call generar()
	End Sub
	
	Private Sub FrmSunat682_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call CargaNivel()
		DTPicker1.Value = DateSerial(CShort(VGParamSistem.Anoproceso), CShort(VGParamSistem.Mesproceso), 1)
	End Sub
	Private Sub CargaNivel()
		Dim i As Short
		For i = 1 To VGnumnivelescuenta
			cmbNivel.Items.Add(VB6.Format(i, "0"))
		Next 
		cmbNivel.SelectedIndex = 0
	End Sub
	Private Sub Exportar(ByRef rs As ADODB.Recordset)
		Dim xsumactas As Object
        Dim li_aRC As Short

        Dim xmonto As Object

		Dim xregistro1 As String
		Dim sumas As String
		sumas = "0"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xmonto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xmonto = 0
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xsumactas. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xsumactas = 0
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		li_aRC = FreeFile
		
		FileOpen(li_aRC, "C:\temp\" & RTrim(Text1.Text) & ".txt", OpenMode.Output)
		rs.MoveFirst()
		Do While Not rs.EOF
			With rs
				xregistro1 = rs.Fields("cuentacodigo").Value & "|" & rs.Fields("saldoinidebe").Value & "|" & rs.Fields("saldoinihaber").Value & "|"
				xregistro1 = xregistro1 & "" & rs.Fields("Movacumdebe").Value & "|" & rs.Fields("movacumhaber").Value & "|"
				xregistro1 = xregistro1 & "" & sumas & "|" & sumas & "|"
			End With
			PrintLine(li_aRC, xregistro1)
			rs.MoveNext()
		Loop 
		rs.Close()
		FileClose(li_aRC)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
		MsgBox("Se ha generado el archivo c:\temp\" & Text1.Text & ".txt  satisfactoriamente ", MsgBoxStyle.Information, "Mensaje")
		Exit Sub
Error_PDT: 
	End Sub
	
	Private Sub Transf_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Transf.Click
		If Text1.Text = "" Then
			MsgBox("Ingrese nombre del Archivo a transferir ")
			Text1.Focus()
			Exit Sub
		End If
		Call Exportar(RSAUX)
	End Sub
	Private Sub generar()
		VGCommandoSP = New ADODB.Command
        'Elimar los Detalle antes de grabar
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_pro_GeneraSunat682"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@anno").Value = CShort(VGParamSistem.Anoproceso)
			.Parameters("@nivel").Value = cmbNivel.SelectedIndex + 1
			RSAUX = .Execute
		End With
		If RSAUX.RecordCount > 0 Then
			DataGrid1.DataSource = RSAUX
			'UPGRADE_NOTE: Refresh se actualizó a CtlRefresh. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            DataGrid1.Refresh()
		End If
	End Sub
End Class