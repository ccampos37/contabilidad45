Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FrmMntcentroCosto
	Inherits System.Windows.Forms.Form
	
	Dim resp As String
	Dim nTra As Short
	Dim rs As New ADODB.Recordset
	
	Dim datos As String
	
	Private Sub command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles command5.Click
		Dim cadena As String
		Dim cNomRepor As String
		
		cNomRepor = "unimedida.RPT"
		If Trim(cNomRepor) <> "" Then
			CrystalReport1.Reset()
			CrystalReport1.WindowTitle = "Reporte de Unidades de Medida"
			CrystalReport1.ReportFileName = VGParamSistem.RutaReport & "\" & cNomRepor
			CrystalReport1.Connect = VGCadenaReport2
			CrystalReport1.set_StoredProcParam(0, VGParamSistem.BDEmpresa)
			
			CrystalReport1.set_Formulas(0, "emp ='" & VGParametros.RucEmpresa & "'")
			
			CrystalReport1.Destination = Crystal.DestinationConstants.crptToWindow
			CrystalReport1.WindowShowPrintBtn = True
			CrystalReport1.WindowShowRefreshBtn = True
			CrystalReport1.WindowShowSearchBtn = True
			CrystalReport1.WindowShowPrintSetupBtn = True
			CrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
			If CrystalReport1.Status <> 2 Then
				CrystalReport1.Action = 1
			End If
		Else
			MsgBox("No existe el nombre del Reporte, verifique en Formatos", MsgBoxStyle.Information, "Información")
			Exit Sub
		End If
	End Sub
	
	Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command9.Click
		DbGrid1.Visible = True
		Frame5.Visible = True
		Frame2.Visible = True
		Frame1.Visible = False
		Frame3.Visible = False
		Call Listado("")
		DbGrid1.Focus()
	End Sub
	
	'UPGRADE_WARNING: El evento TxFiltro.TextChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TxFiltro_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxFiltro.TextChanged
		Dim ncondi As String
		'If RS.RecordCount > 0 Then
		If Trim(TxFiltro.Text) <> "" Then
			If CmbOrden.SelectedIndex = 0 Then
				ncondi = Trim(UCase(TxFiltro.Text)) & "%"
			ElseIf CmbOrden.SelectedIndex = 1 Then 
				ncondi = Trim(UCase(TxFiltro.Text)) & "%"
			End If
		Else
			ncondi = datos
		End If
		Call Listado(ncondi)
		'End If
	End Sub
	
	'UPGRADE_WARNING: El evento CmbOrden.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub CmbOrden_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmbOrden.SelectedIndexChanged ' Ordenar por
		Dim nCom As Short
		Dim nsql As String
		
		nCom = CmbOrden.SelectedIndex
		
		Select Case nCom
			Case 0
				'Data1.RecordSource = "Select * from TABUNIMED  order by UM_ABREV"
				nsql = datos & "' order by centrocostocodigo"
				Call Listado(nsql)
			Case 1
				'Data1.RecordSource = "Select * from TABUNIMED  order by UM_NOMBRE"
				nsql = datos & "' order by centrocostodescripcion"
				Call Listado(nsql)
		End Select
		TxFiltro.Text = ""
		'Data1.Refresh
		'If DbGrid1.Visible Then DbGrid1.SetFocus
		
	End Sub
	
	Private Sub DataGrid1_KeyPress(ByRef KeyAscii As Short)
		If KeyAscii = System.Windows.Forms.Keys.Back Then
			If Len(TxFiltro.Text) - 1 > 0 Then
				TxFiltro.Text = VB.Left(TxFiltro.Text, Len(TxFiltro.Text) - 1)
			Else
				TxFiltro.Text = ""
			End If
			KeyAscii = 0
		ElseIf KeyAscii <> 13 Then 
			TxFiltro.Text = TxFiltro.Text & Chr(KeyAscii)
		End If
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		resp = "S"
		Limpiar()
		txtcodigo.Enabled = True
		DbGrid1.Visible = False
		Frame2.Visible = False
		Frame5.Visible = False
		Frame3.Text = "Ingreso de Centro de costosS"
		
		Frame1.Visible = True
		Frame3.Visible = True
		txtcodigo.Focus()
	End Sub
	
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		If rs.RecordCount > 0 Then
			Limpiar()
			resp = "N"
			Frame3.Text = "Modificación de Centro de costosS"
			DbGrid1.Visible = False
			Frame2.Visible = False
			Frame5.Visible = False
			Frame1.Visible = True
			Frame3.Visible = True
			
			txtcodigo.Text = rs.Fields("centrocostocodigo").Value
			txtcodigo.Enabled = False
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtdescripcion.Text = ESNULO(rs.Fields("centrocostodescripcion"), "")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtnivel.Text = ESNULO(rs.Fields("CENTROCOSTOnivel"), 0)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtdescorta.Text = ESNULO(rs.Fields("centrocostodescrcorta"), "")
			Check1.CheckState = IIf(rs.Fields("estadoAnulado").Value = True, 1, 0)
			txtdescripcion.Focus()
		End If
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		On Error GoTo EliErr
		Dim cSql1 As String
		Dim CSQL2, cSql3 As String
		Dim cCodigo1 As String
		Dim cSel1 As ADODB.Recordset
		Dim cCodigo As String
		Dim cSqlA As String
		Dim cSelA As ADODB.Recordset
		If rs.RecordCount > 0 Then
			
			SQL = "Select * FROM v_Movimkardex WHERE EMPRESACODIGO='" & VGParametros.empresacodigo & "' AND decencos = '" & Trim(DbGrid1.Columns(0).Text) & "'"
			cSelA = New ADODB.Recordset
			cSelA = VGCNx.Execute(SQL)
			If Not cSelA.EOF Then
				MsgBox("Este CENTRO DE COSTOS Tiene Documentos no puede eliminarlo")
				cSelA.Close()
				Exit Sub
			End If
			cSelA.Close()
			
			SQL = "delete ct_centrocosto WHERE EMPRESACODIGO='" & VGParametros.empresacodigo & "' AND centrocostocodigo= '" & Trim(DbGrid1.Columns(0).Text) & "'"
			
			If MsgBox("Seguro de Eliminar", MsgBoxStyle.Question + MsgBoxStyle.OKCancel, mensaje1) = MsgBoxResult.OK Then
				nTra = 2
				'cCodigo1 = Pos_Dato1(RS, "UM_ABREV")
				nTra = 1
				VGCNx.BeginTrans()
				VGCNx.Execute(SQL)
				VGCNx.CommitTrans()
				nTra = 0
				Call Listado("")
			End If
			'UPGRADE_NOTE: Refresh se actualizó a CtlRefresh. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            DbGrid1.Refresh()

            If DbGrid1.Visible Then DbGrid1.Focus()
        Else
            MsgBox("No existe ningún registro para Eilminar", MsgBoxStyle.Information, mensaje1)
        End If
        Exit Sub
EliErr:
        MsgBox(Err.Description)
        If nTra = 1 Then VGCNx.RollbackTrans()
    End Sub

    Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
        Me.Close()
    End Sub

    Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
        Dim cUni As String

        If resp = "S" Then
            If txtcodigo.Text = "" Then
                MsgBox("Ingrese Código de Centro de costos", MsgBoxStyle.Information, "Mensaje")
                txtcodigo.Focus()
                Exit Sub
            Else
                If Existe(1, VGParametros.empresacodigo & Trim(txtcodigo.Text), "ct_centroCosto", "empresacodigo+centrocostocodigo", False) Then
                    MsgBox("El código de Centro de costos ya existe", MsgBoxStyle.Information, "Mensaje")
                    txtcodigo.Focus()
                    Exit Sub
                End If
            End If
        End If

        If txtdescripcion.Text = "" Then
            MsgBox("Ingrese Nombre de Centro de costos", MsgBoxStyle.Exclamation, "Aviso")
            txtdescripcion.Focus()
            Exit Sub
        End If

        If resp = "S" Then
            SQL = "INSERT INTO ct_centroCosto (empresacodigo,centrocostocodigo,centrocostodescripcion,"
            SQL = SQL & " centrocostodescrcorta,centrocostonivel,cuentacodigo,estadoanulado,usuariocodigo) "
            SQL = SQL & "VALUES ('" & VGParametros.empresacodigo & "' ,'" & txtcodigo.Text & "','" & txtdescripcion.Text & "',"
            SQL = SQL & " '" & txtdescorta.Text & "', " & txtnivel.Text & ",'" & txtclase9.Text & "',"
            SQL = SQL & "" & Check1.CheckState & ", '" & VGUsuario & "') "

        Else
            SQL = "UPDATE ct_centroCosto "
            SQL = SQL & " SET centrocostodescripcion ='" & Trim(txtdescripcion.Text) & "',"
            SQL = SQL & " centrocostodescrcorta ='" & Trim(txtdescorta.Text) & "',"
            SQL = SQL & " centrocostonivel =" & txtnivel.Text & ","
            SQL = SQL & " cuentacodigo ='" & txtclase9.Text & "', estadoanulado =" & Check1.CheckState & ""
            SQL = SQL & " WHERE empresacodigo='" & VGParametros.empresacodigo & "' AND centrocostocodigo ='" & txtcodigo.Text & "'"
        End If
        VGCNx.Execute(SQL)
        Limpiar()
        Call Command9_Click(Command9, New System.EventArgs())
        DbGrid1.Visible = True


    End Sub
    Sub Limpiar()
        txtcodigo.Text = ""
        txtdescripcion.Text = ""
        txtdescorta.Text = ""
        txtclase9.Text = ""
        txtnivel.Text = ""
        Check1.CheckState = System.Windows.Forms.CheckState.Unchecked
    End Sub

    Private Sub FrmMntcentroCosto_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        datos = "SELECT centrocostocodigo,centrocostodescripcion, centrocostodescrcorta,centrocostonivel,cuentacodigo, "
        datos = datos & " estadoanulado FROM ct_centrocosto WHERE empresacodigo='" & VGParametros.empresacodigo & "'"
        TxFiltro.Text = """"
        CmbOrden.SelectedIndex = 0
        If DbGrid1.Visible Then DbGrid1.Focus()
        rs = VGCNx.Execute(datos & " order by centrocostodescripcion")
        Call Listado("")
    End Sub


    Sub Listado(ByRef wcad As Object)
        'UPGRADE_NOTE: El objeto DbGrid1.DataSource no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        DbGrid1.DataSource = Nothing
        Dim nCursor As String
        '  Set rs = VGcnx.Execute(wcad)
        If Trim(TxFiltro.Text) <> "" And TxFiltro.Visible Then
            Select Case CmbOrden.SelectedIndex
                Case 0
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto wcad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    rs = VGCNx.Execute(datos & " AND centrocostocodigo LIKE '%" & wcad & "' ORDER BY centrocostocodigo")
                Case 1
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto wcad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    rs = VGCNx.Execute(datos & " AND centrocostodescripcion LIKE '%" & wcad & "' ORDER BY centrocostodescripcion ")
            End Select
            If rs.EOF Then rs = VGCNx.Execute(datos)
        Else
            Select Case CmbOrden.SelectedIndex
                Case 0
                    rs = VGCNx.Execute(datos & " ORDER BY centrocostocodigo")
                Case 1
                    rs = VGCNx.Execute(datos & " ORDER BY centrocostodescripcion")
            End Select
        End If
        DbGrid1.DataSource = rs
        With DbGrid1
            .Columns(0).Caption = "Codigo"
            .Columns(0).Width = VB6.TwipsToPixelsX(1000)
            .Columns(1).Caption = "Descripcion"
            .Columns(1).Width = VB6.TwipsToPixelsX(3800)
            .MarqueeStyle = MSDataGridLib.MarqueeStyleConstants.dbgHighlightRow
            'UPGRADE_NOTE: Refresh se actualizó a CtlRefresh. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Refresh()
        End With
    End Sub
	
	
	Private Sub TxtCodigo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtCodigo.Enter
		Enfoque(txtcodigo)
	End Sub
	
	Private Sub TxtCodigo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim cFam As String
		
		If KeyAscii = 13 Then
			If Trim(txtcodigo.Text) <> "" Then
				If Existe(1, Trim(txtcodigo.Text), "ct_centroCosto", "centrocostocodigo", False) Then
					MsgBox("El código de Centro de costos ya existe", MsgBoxStyle.Information, "Mensaje")
					txtcodigo.Text = "" : txtcodigo.Focus()
					GoTo EventExitSub
				End If
			Else
				MsgBox("Ingrese código de Centro de costos ", MsgBoxStyle.Information, "Mensaje")
				txtcodigo.Text = "" : txtcodigo.Focus()
			End If
			txtdescripcion.Focus()
		Else
			'If KeyAscii = 39 Or KeyAscii = 34 Then KeyAscii = 0
			KeyAscii = Asc(UCase(Chr(KeyAscii)))
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub TxtDescripcion_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtDescripcion.Enter
		Enfoque(txtdescripcion)
	End Sub
	
	Private Sub TxtDescripcion_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			If Trim(txtdescripcion.Text) = "" Then
				MsgBox("Ingrese descripcion del Centro de costos", MsgBoxStyle.Information, "Mensaje")
				txtdescripcion.Text = "" : txtdescripcion.Focus()
			End If
			Command8.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class