Option Strict Off
Option Explicit On
Friend Class FrmMntEstructuraBalance
	Inherits System.Windows.Forms.Form
	
	Dim resp As String
	Dim nTra As Short
	Dim rs As New ADODB.Recordset
	Dim datos As String
	Private Sub cmdImprimir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImprimir.Click
        Dim aparam(1) As Object
		Dim aform(1) As Object
		Dim cNomRepor As String
		cNomRepor = "unimedida.RPT"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aform(0) = "emp ='" & VGParametros.RucEmpresa & "'"
		Call ImpresionRptProc(cNomRepor, aform, aparam,  , "Centro de costos")
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		DbGrid1.Visible = True
		frame5.Visible = True
		Frame2.Visible = True
		Frame1.Visible = False
		Frame3.Visible = False
		
	End Sub
	Private Sub CmdSalir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdSalir.Click
		Me.Close()
	End Sub
	
	Private Sub DataGrid1_KeyPress(ByRef KeyAscii As Short)
		
	End Sub
	
	Private Sub CmdNuevo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdNuevo.Click
		resp = "S"
		Limpiar()
		txtlinea.Enabled = True
		DbGrid1.Visible = False
		Frame2.Visible = False
		frame5.Visible = False
		Frame3.Text = "Ingreso de Centro de costosS"
		
		Frame1.Visible = True
		Frame3.Visible = True
		txtlinea.Focus()
	End Sub
	Private Sub CmdModificar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdModificar.Click
		If rs.RecordCount > 0 Then
			Limpiar()
			resp = "N"
			Frame3.Text = "Modificación de Centro de costosS"
			DbGrid1.Visible = False
			Frame2.Visible = False
			frame5.Visible = False
			Frame1.Visible = True
			Frame3.Visible = True
			txtlinea.Text = rs.Fields("strucbalancelinea").Value
			txtlinea.Enabled = False
			
			ChKDual.CheckState = IIf(rs.Fields("strucbalancedual").Value, 1, 0)
			
			txttipolinea1.Text = rs.Fields("strucbalancedato1").Value
			ChkN1.CheckState = IIf(rs.Fields("strucbalanceinvval1").Value, 1, 0)
			txtCtas1.Text = rs.Fields("strucbalancenivel1").Value
			Txtdesc1.Text = rs.Fields("strucbalancedescrip1").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Txtsigno1.Text = ESNULO(rs.Fields("strucbalancesigno1"), "")
			
			Txttipolinea2.Text = rs.Fields("strucbalancedato2").Value
			ChkN2.CheckState = IIf(rs.Fields("strucbalanceinvval2").Value, 1, 0)
			Txtctas2.Text = rs.Fields("strucbalancenivel2").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Txtdesc2.Text = ESNULO(rs.Fields("strucbalancedescrip2"), "")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Txtsigno2.Text = ESNULO(rs.Fields("strucbalancesigno2"), "")
			
		End If
	End Sub
	
	Private Sub CmdEliminar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdEliminar.Click
		On Error GoTo EliErr
		Dim cSql1 As String
		Dim CSQL2, cSql3 As String
		Dim cCodigo1 As String
		Dim cSel1 As ADODB.Recordset
		Dim cCodigo As String
		Dim cSqlA As String
		Dim cSelA As ADODB.Recordset
		If rs.RecordCount > 0 Then
			cSql1 = "delete ct_strucbalance where  strucbalancelinea='" & Trim(DbGrid1.Columns(0).Text) & "'"
			If MsgBox("Seguro de Eliminar", MsgBoxStyle.Question + MsgBoxStyle.OKCancel, mensaje1) = MsgBoxResult.OK Then
				nTra = 2
				'cCodigo1 = Pos_Dato1(RS, "UM_ABREV")
				nTra = 1
				VGCNx.BeginTrans()
				VGCNx.Execute(cSql1)
				VGCNx.CommitTrans()
				nTra = 0
			End If
		Else
			MsgBox("No existe ningún registro para Eilminar", MsgBoxStyle.Information, mensaje1)
		End If
		Limpiar()
		DbGrid1.Visible = True
		cmdCancelar_Click(cmdCancelar, New System.EventArgs())
		Exit Sub
EliErr: 
		MsgBox(Err.Description)
		If nTra = 1 Then VGCNx.RollbackTrans()
	End Sub
	Private Sub cmdgrabar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdgrabar.Click
        If resp = "S" Then
            If txtlinea.Text = "" Then
                MsgBox("Ingrese Numero de linea", MsgBoxStyle.Information, "Mensaje")
                txtlinea.Focus()
                Exit Sub
            Else
                If Existe(1, Trim(txtlinea.Text), "ct_strucbalance", "strucbalancelinea", False) Then
                    MsgBox("El código de Linea ya existe", MsgBoxStyle.Information, "Mensaje")
                    txtlinea.Focus()
                    Exit Sub
                End If
            End If
            If Not IsNumeric(txtlinea.Text) Then
                MsgBox("LINEA es numerico ", MsgBoxStyle.Information, "Mensaje")
                txtlinea.Focus()
                Exit Sub

            End If
        End If
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_EstructuraBalance_pro"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@condicion").Value = ""
			If resp = "S" Then
				.Parameters("@tipo").Value = 1
			Else
				.Parameters("@tipo").Value = 2
			End If
			.Parameters("@strucbalancelinea").Value = txtlinea.Text
			.Parameters("@strucbalancedato1").Value = txttipolinea1.Text
			.Parameters("@strucbalanceinvval1").Value = ChkN1.CheckState
			.Parameters("@strucbalancenivel1").Value = txtCtas1.Text
			.Parameters("@strucbalancedescrip1").Value = Txtdesc1.Text
			.Parameters("@strucbalancesigno1").Value = Txtsigno1.Text
			
			.Parameters("@strucbalancenivel2").Value = Txtctas2.Text
			.Parameters("@strucbalancedato2").Value = Txttipolinea2.Text
			.Parameters("@strucbalancedescrip2").Value = Txtdesc2.Text
			.Parameters("@strucbalancesigno2").Value = Txtsigno2.Text
			.Parameters("@strucbalanceinvval2").Value = ChkN2.CheckState
			.Parameters("@strucbalancedual").Value = ChKDual.CheckState
			.Parameters("@usuariocodigo").Value = VGUsuario
			.Parameters("@fechaact").Value = Now
			.Execute()
		End With
		Limpiar()
		DbGrid1.Visible = True
		cmdCancelar_Click(cmdCancelar, New System.EventArgs())
		Listado((""))
	End Sub
	Sub Limpiar()
		txtlinea.Text = ""
		txttipolinea1.Text = ""
		ChkN1.CheckState = System.Windows.Forms.CheckState.Unchecked
		txtCtas1.Text = ""
		Txtdesc1.Text = ""
		Txtsigno1.Text = ""
		Txtctas2.Text = ""
		Txttipolinea2.Text = ""
		Txtdesc2.Text = ""
		Txtsigno2.Text = ""
		ChkN2.CheckState = System.Windows.Forms.CheckState.Unchecked
		ChKDual.CheckState = System.Windows.Forms.CheckState.Unchecked
	End Sub
	Private Sub FrmMntEstructuraBalance_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		datos = "SELECT strucbalancelinea,strucbalancedato1,strucbalanceinvval1,strucbalancenivel1,"
		datos = datos & " strucbalancedescrip1,strucbalancesigno1,strucbalancedato2,strucbalancenivel2,"
		datos = datos & " strucbalancedescrip2,strucbalancesigno2,strucbalanceinvval2,strucbalancedual"
		datos = datos & " FROM ct_strucbalance "
		If DbGrid1.Visible Then DbGrid1.Focus()
		Call cmdCancelar_Click(cmdCancelar, New System.EventArgs())
		Call Listado("")
	End Sub
	Sub Listado(ByRef wcad As Object)
		'UPGRADE_NOTE: El objeto DbGrid1.DataSource no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		DbGrid1.DataSource = Nothing

		rs = VGCNx.Execute(datos)
		DbGrid1.DataSource = rs
		With DbGrid1
			.Columns(0).Caption = "Lin"

            .Columns(1).Caption = "Tip"

            .Columns(2).Caption = "Neg"

            .Columns(3).Caption = "Cuentas"

            .Columns(4).Caption = "descripcion Linea"

            .Columns(5).Caption = "Signo Rep"

			.MarqueeStyle = MSDataGridLib.MarqueeStyleConstants.dbgHighlightRow
            .Refresh()
		End With
	End Sub
End Class