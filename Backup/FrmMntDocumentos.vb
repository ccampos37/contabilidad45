Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FrmMntDocumentos
	Inherits System.Windows.Forms.Form
	Dim resp As String
	Dim nTra As Short
	Dim rs As New ADODB.Recordset
	Dim datos As String
	Private Sub command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles command5.Click
		Dim cadena As String
		Dim cNomRepor As String
		cNomRepor = "unimedida.RPT"
		
	End Sub
	Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command9.Click
		DbGrid1.Visible = True
		Frame5.Visible = True
		Frame2.Visible = True
		Frame1.Visible = False
		Frame3.Visible = False
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
				nsql = datos & "' order by documentocodigo"
				Call Listado(nsql)
			Case 1
				'Data1.RecordSource = "Select * from TABUNIMED  order by UM_NOMBRE"
				nsql = datos & "' order by documentodescripcion"
				Call Listado(nsql)
		End Select
		TxFiltro.Text = ""
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
		Frame3.Text = "Ingreso de Tipo de documento"
		Frame1.Visible = True
		Frame3.Visible = True
		txtcodigo.Focus()
	End Sub
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		If rs.RecordCount > 0 Then
			Limpiar()
			resp = "N"
			Frame3.Text = "Modificación de tipo de Documento"
			DbGrid1.Visible = False
			Frame2.Visible = False
			Frame5.Visible = False
			Frame1.Visible = True
			Frame3.Visible = True
			txtcodigo.Text = rs.Fields("documentocodigo").Value
			txtcodigo.Enabled = False
			txtdescripcion.Text = rs.Fields("documentodescripcion").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TxtRefSunat.Text = ESNULO(rs.Fields("formadepagocodigo"), "")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CheckcOMPRAS.CheckState = ESNULO(IIf(rs.Fields("documentoregcompras").Value = True, 1, 0), 0)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CheckVTAS.CheckState = ESNULO(IIf(rs.Fields("documentoregventas").Value = True, 1, 0), 0)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CheckNota.CheckState = ESNULO(IIf(rs.Fields("documentonotacredito").Value = True, 1, 0), 0)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Checkref.CheckState = ESNULO(IIf(rs.Fields("documentoref").Value = True, 1, 0), 0)
			
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
			cSqlA = "Select * FROM ct_detComprob" & VGParamSistem.Anoproceso & " WHERE documentocodigo = '" & Trim(DbGrid1.Columns(0).Text) & "'"
			cSelA = New ADODB.Recordset
			cSelA = VGCNx.Execute(cSqlA)
			If Not cSelA.EOF Then
				MsgBox("Existen documentos de referencia en asientos contables, no puede eliminarlo")
				cSelA.Close()
				Exit Sub
			End If
			cSelA.Close()
			cSql1 = "delete gr_documento where documentocodigo='" & Trim(DbGrid1.Columns(0).Text) & "'"
			If MsgBox("Seguro de Eliminar", MsgBoxStyle.Question + MsgBoxStyle.OKCancel, mensaje1) = MsgBoxResult.OK Then
				nTra = 2
				'cCodigo1 = Pos_Dato1(RS, "UM_ABREV")
				nTra = 1
				VGCNx.BeginTrans()
				VGCNx.Execute(cSql1)
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
                MsgBox("Ingrese Código de Documento", MsgBoxStyle.Information, "Mensaje")
                txtcodigo.Focus()
                Exit Sub
            Else
                If Existe(1, Trim(txtcodigo.Text), "gr_documento", "documentocodigo", False) Then
                    MsgBox("El código del docuemnto ya existe", MsgBoxStyle.Information, "Mensaje")
                    txtcodigo.Focus()
                    Exit Sub
                End If
            End If
        End If
        If txtdescripcion.Text = "" Then
            MsgBox("Ingrese Nombre del documento", MsgBoxStyle.Exclamation, "Aviso")
            txtdescripcion.Focus()
            Exit Sub
        End If
        If resp = "S" Then
            SQL = "INSERT INTO gr_documento (documentocodigo, documentodescripcion, documentoregcompras, "
            SQL = SQL & "documentoregventas,documentonotacredito, documentoregletrasxcobrar, documentoregletrasxpagar,"
            SQL = SQL & "documentoref,formadepagocodigo)"
            SQL = SQL & " VALUES ('" & txtcodigo.Text & "','" & txtdescripcion.Text & "',"
            SQL = SQL & CheckcOMPRAS.CheckState & "," & CheckVTAS.CheckState & ","
            SQL = SQL & CheckNota.CheckState & ",0,0," & Checkref.CheckState & ",'" & TxtRefSunat.Text & "')"
        Else
            SQL = "UPDATE gr_documento "
            SQL = SQL & " SET documentodescripcion='" & RTrim(txtdescripcion.Text) & "',"
            SQL = SQL & "documentoregcompras=" & CheckcOMPRAS.CheckState & ",documentoregventas=" & CheckVTAS.CheckState & ","
            SQL = SQL & "documentonotacredito=" & CheckNota.CheckState & ", documentoref=" & Checkref.CheckState & ","
            SQL = SQL & "formadepagocodigo ='" & TxtRefSunat.Text & "'"
            SQL = SQL & " WHERE documentocodigo ='" & txtcodigo.Text & "'"
        End If
        VGCNx.Execute(SQL)
        Limpiar()
        Call Command9_Click(Command9, New System.EventArgs())
        Listado((""))
        DbGrid1.Visible = True
    End Sub
    Sub Limpiar()
        txtcodigo.Text = ""
        txtdescripcion.Text = ""
    End Sub

    Private Sub FrmMntDocumentos_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        datos = "SELECT documentocodigo, documentodescripcion, documentoregcompras, documentoregventas, documentoregletrasxcobrar, "
        datos = datos & " documentoregletrasxpagar, documentonotacredito, documentoref, formadepagocodigo FROM Gr_Documento"
        TxFiltro.Text = """"
        CmbOrden.SelectedIndex = 0
        If DbGrid1.Visible Then DbGrid1.Focus()
        Listado((""))
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
                    rs = VGCNx.Execute(datos & " AND documentocodigo LIKE '%" & wcad & "' ORDER BY documentocodigo")
                Case 1
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto wcad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    rs = VGCNx.Execute(datos & " AND documentodescripcion LIKE '%" & wcad & "' ORDER BY documentodescripcion ")
            End Select
            If rs.EOF Then rs = VGCNx.Execute(datos)
        Else
            Select Case CmbOrden.SelectedIndex
                Case 0
                    rs = VGCNx.Execute(datos & " ORDER BY documentocodigo")
                Case 1
                    rs = VGCNx.Execute(datos & " ORDER BY documentodescripcion")
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
				If Existe(1, Trim(txtcodigo.Text), "gr_documento", "documentocodigo", False) Then
					MsgBox("El código de docuemnto ya existe", MsgBoxStyle.Information, "Mensaje")
					txtcodigo.Text = "" : txtcodigo.Focus()
					GoTo EventExitSub
				End If
			Else
				MsgBox("Ingrese código de documento ", MsgBoxStyle.Information, "Mensaje")
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
				MsgBox("Ingrese descripcion del documento ", MsgBoxStyle.Information, "Mensaje")
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