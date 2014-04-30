Option Strict Off
Option Explicit On
Imports Contabilidad.ModFuncionesGen
Module ModLibroselectronicos
	Public Sub Generadiario(ByRef dato As String)
		Dim RSQL As New ADODB.Recordset
		Dim Archivo As String
		Dim li_aRC As Short
		Dim ruta As String
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto NombreArchivoTxt(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Archivo = NombreArchivoTxt(dato)
		ruta = "C:\libroselectronicos\" & VGParametros.empresacodigo & "\"
		ruta = ruta & VGParamSistem.Anoproceso & "\" & RTrim(DesMes(VGParamSistem.Mesproceso)) & "\"
		li_aRC = FreeFile
		FileOpen(li_aRC, ruta & Archivo, OpenMode.Output)
		If Mid(Archivo, 30, 1) = "2" Then
			FileClose(li_aRC)
			Exit Sub
		End If
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_libroDiario_rpt"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@anno").Value = VGParamSistem.Anoproceso
			.Parameters("@cabcomprobmes").Value = VGParamSistem.Mesproceso
			RSQL = .Execute
		End With
		If RSQL.RecordCount > 0 Then Call GeneraArchivoDiario(RSQL, Archivo, li_aRC)
	End Sub
	
	Public Sub GeneraArchivoDiario(ByRef rs As ADODB.Recordset, ByRef Archivo As String, ByRef li_arc1 As Short)
		Dim registro As Object
		Dim reg As String
		Dim fecha As String
		Dim n As Double
		rs.MoveFirst()
		n = 0
		Do While Not rs.EOF
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto registro. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			registro = ""
			If rs.Fields("detcomprobdebe").Value + rs.Fields("detcomprobhaber").Value > 0 Then
				With rs
					'campo 1
					fecha = rs.Fields("cabcomprobfeccontable").Value
					reg = Mid(Archivo, 14, 8) & "|"
					reg = reg + rs.Fields("cabcomprobnumero").Value + "." + rs.Fields("detcomprobitem").Value + "|"
					reg = reg & "01|"
					'Campos 4
					
					reg = reg + rs.Fields("cuentacodigo").Value + "|" + fecha + "|" + IIf(RTrim(rs.Fields("detcomprobglosa").Value) = "", rs.Fields("cabcomprobglosa").Value, rs.Fields("detcomprobglosa").Value) + "|"
					'Campo 7
					reg = reg & VB6.Format(rs.Fields("detcomprobdebe").Value, "00000000.00") & "|"
					reg = reg & VB6.Format(rs.Fields("detcomprobhaber").Value, "00000000.00") & "|1|"
				End With
				PrintLine(li_arc1, reg)
				n = n + 1
			Else
				'      MsgBox ("Hola")
			End If
			rs.MoveNext()
		Loop 
		rs.Close()
		FileClose(li_arc1)
		'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		Exit Sub
Error_PDT: 
	End Sub
	Public Sub GeneradiarioSimplificado(ByRef dato As String)
		Dim li_aRC As Object
		Dim RSQL As New ADODB.Recordset
		Dim Archivo As String
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto NombreArchivoTxt(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Archivo = NombreArchivoTxt(dato)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto li_aRC. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		li_aRC = FreeFile
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto li_aRC. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(li_aRC, "C:\libroselectronicos\" & Archivo, OpenMode.Output)
		If Mid(Archivo, 30, 1) = "2" Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto li_aRC. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileClose(li_aRC)
			Exit Sub
		End If
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_libroDiario_rpt"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@anno").Value = VGParamSistem.Anoproceso
			.Parameters("@cabcomprobmes").Value = VGParamSistem.Mesproceso
			RSQL = .Execute
		End With
		Call GeneraArchivoDiarioSimplificado(RSQL, Archivo)
	End Sub
	Public Sub GeneraArchivoDiarioSimplificado(ByRef rs As ADODB.Recordset, ByRef Archivo As String)
        Dim LBLNUMERO As String = ""
		Dim registro As Object
		Dim li_aRC As Short
		Dim reg As String
		Dim fecha As String
		li_aRC = FreeFile
		rs.MoveFirst()
		Do While Not rs.EOF
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto registro. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			registro = ""
			With rs
				fecha = rs.Fields("cabcomprobfeccontable").Value
				reg = Mid(Archivo, 14, 8) & "|" + rs.Fields("cabcomprobnumero").Value + "|01|" + rs.Fields("cuentacodigo").Value + "|"
				reg = reg & fecha & "|" + rs.Fields("detcomprobglosa").Value + "|"
				reg = reg & LTrim(Str(System.Math.Round(rs.Fields("detcomprobdebe").Value, 2))) & "|"
				reg = reg & LTrim(Str(System.Math.Round(rs.Fields("detcomprobhaber").Value, 2))) & "|1|"
			End With
			PrintLine(li_aRC, reg)
			rs.MoveNext()
		Loop 
		rs.Close()
		FileClose(li_aRC)
		'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto LBLNUMERO. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MsgBox("Se ha generado el archivo c:\telecredito\" & "0600" & LBLNUMERO & ".txt  satisfactoriamente ", MsgBoxStyle.Information, "Mensaje")
		Exit Sub
Error_PDT: 
	End Sub
	Public Sub GeneraCompras(ByRef dato As String)
		Dim RSparCompras As Object
		Dim Rrsql As New ADODB.Recordset
		Dim Archivo As String
		Dim li_aRC As Short
		Dim ruta As String
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto NombreArchivoTxt(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Archivo = NombreArchivoTxt(dato)
		li_aRC = FreeFile
		ruta = "C:\libroselectronicos\" & VGParametros.empresacodigo & "\"
		ruta = ruta & VGParamSistem.Anoproceso & "\" & RTrim(DesMes(VGParamSistem.Mesproceso)) & "\"
		FileOpen(li_aRC, ruta & Archivo, OpenMode.Output)
		If Mid(Archivo, 30, 1) = "2" Then
			FileClose(li_aRC)
			Exit Sub
		End If
		RSparCompras = New ADODB.Recordset
		SQL = "select * from ct_paramlibaux where paramlibauxtipo='CO'"
		RSparCompras = VGCNx.Execute(SQL)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparCompras.RecordCount. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If RSparCompras.RecordCount = 0 Then
			MsgBox("No existen parametros para el registros de compras")
			Exit Sub
		End If
		SQL = "##regcomp" & VGParametros.empresacodigo & VGParamSistem.Mesproceso
		If ExisteElem(0, VGCNx, SQL) Then VGCNx.Execute(" drop table " & SQL)
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_LibroRegistroCompras_rpt"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@anno").Value = VGParamSistem.Anoproceso
			.Parameters("@mes").Value = VGParamSistem.Mesproceso
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparCompras!paramlibauxasiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@ASIENTOSPLAN").Value = RSparCompras!paramlibauxasiento
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparCompras!paramlibauxcuenta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@CTASPLANCOMP").Value = RSparCompras!paramlibauxcuenta
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparCompras!paramlibauxigv. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@CTASIGV").Value = RSparCompras!paramlibauxigv
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparCompras!paramlibauxies. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@CTASIES").Value = RSparCompras!paramlibauxies
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparCompras!paramlibauxirenta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@CTASRENTA").Value = RSparCompras!paramlibauxirenta
			.Parameters("@OPCION").Value = 1
			'  Set rsql = .Execute
			.Execute()
		End With
		
		SQL = " SELECT * FROM " & SQL
		RSQL = VGCNx.Execute(SQL)
		If RSQL.RecordCount > 0 Then Call GeneraArchivoCompras(RSQL, Archivo, li_aRC)
	End Sub
	
	Public Sub GeneraArchivoCompras(ByRef rs As ADODB.Recordset, ByRef Archivo As String, ByRef li_arc1 As Short)
		Dim registro As Object
		Dim reg As String
		Dim dato1 As String
		Dim dato2 As String
		Dim dato3 As String
		Dim NroReg As Double
		NroReg = 1
		rs.MoveFirst()
		Do While Not rs.EOF
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto registro. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			registro = ""
			With rs
				dato3 = rs.Fields("detcomprobfechaemision").Value
				reg = Mid(Archivo, 14, 8) & "|" + rs.Fields("cabcomprobnumero").Value + "|" + dato3 + "|"
				
				dato1 = rs.Fields("detcomprobfechavencimiento").Value
                dato3 = IIf(rs.Fields("documentocodigo").Value = "50", Right(rs.Fields("serie").Value, 3), rs.Fields("serie").Value)
				reg = reg & dato1 & "|" + rs.Fields("documentocodigo").Value + "|" + dato3 + "|"
				
				'campos 7 para adelante
				dato1 = IIf(rs.Fields("documentocodigo").Value = "50", VGParamSistem.Anoproceso, "0")
				dato3 = "0"
				reg = reg & dato1 & "|" + rs.Fields("detcomprobnumdocumento").Value + "|" + dato3 + "|"
				
				dato1 = rs.Fields("identidadcodigo").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				dato2 = ESNULO(rs.Fields("entidadruc"), "-")
				If dato2 = "" Then dato2 = "-"
				dato3 = RTrim(rs.Fields("entidadrazonsocial").Value)
				If dato3 = "" Then dato3 = "-"
				reg = reg & dato1 & "|" & dato2 & "|" & dato3 & "|"
				
				'campos 13 para adelante
				dato1 = CStr(System.Math.Round(.Fields("baseimpgrab").Value, 2))
				dato2 = CStr(System.Math.Round(.Fields("igvimpgrab").Value, 2))
				reg = reg & dato1 & "|" & dato2 & "|" & "0.00" & "|"
				
				reg = reg & "0.00" & "|" & "0.00" & "|" & "0.00" & "|"
				
				'campos 19 para adelante
				dato1 = IIf(System.Math.Round(.Fields("montoinafecto").Value, 2) = 0, "0.00", System.Math.Round(.Fields("montoinafecto").Value, 2))
				reg = reg & dato1 & "|" & "0.00" & "|" & "0.00" & "|"
				
				dato1 = CStr(System.Math.Round(.Fields("baseimpgrab").Value, 2) + System.Math.Round(.Fields("igvimpgrab").Value, 2) + System.Math.Round(.Fields("montoinafecto").Value, 2))
				dato2 = VB6.Format(.Fields("detcomprobtipocambio").Value, "0.000")
				If .Fields("documentonotacredito").Value = False Then
					dato3 = "01/01/0001"
				Else
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					dato3 = ESNULO(.Fields("detcomprobfecharef"), "01/01/0001")
				End If
				reg = reg & dato1 & "|" & dato2 & "|" & dato3 & "|"
				If NroReg = 13 Then
					'    MsgBox ("xx")
				End If
				'campos 25 para adelante
				If .Fields("documentonotacredito").Value = False Then
					dato1 = "00"
					dato2 = "-"
					dato3 = "-"
				Else
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					dato1 = ESNULO(.Fields("tipdocref"), "00")
                    dato2 = IIf(dato1 = "00", "-", Left(.Fields("detcomprobnumref").Value, 4))
                    dato3 = IIf(dato1 = "00", "-", Right(.Fields("detcomprobnumref").Value, 10))
				End If
				reg = reg & dato1 & "|" & dato2 & "|" & dato3 & "|"
				
				dato1 = "-"
				dato2 = "01/01/0001"
				dato3 = "0"
				reg = reg & dato1 & "|" & dato2 & "|" & dato3 & "|"
				
				'campos 31 para adelante
				dato1 = "0"
				dato2 = VB6.Format(Year(rs.Fields("detcomprobfechaemision").Value), "0000") & VB6.Format(Month(rs.Fields("detcomprobfechaemision").Value), "00")
				dato2 = IIf(dato2 < VGParamSistem.Anoproceso & VGParamSistem.Mesproceso, "6", "1")
				reg = reg & dato1 & "|" & dato2 & "|"
				NroReg = NroReg + 1
			End With
			PrintLine(li_arc1, reg)
			rs.MoveNext()
		Loop 
		rs.Close()
		FileClose(li_arc1)
		'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		Exit Sub
Error_PDT: 
	End Sub
	Public Sub GeneraVentas(ByRef dato As String)
		Dim RSparVentas As Object
		Dim Rrsql As New ADODB.Recordset
		Dim Archivo As String
		Dim li_aRC As Short
		Dim ruta As String
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto NombreArchivoTxt(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Archivo = NombreArchivoTxt(dato)
		li_aRC = FreeFile
		ruta = "C:\libroselectronicos\" & VGParametros.empresacodigo & "\"
		ruta = ruta & VGParamSistem.Anoproceso & "\" & RTrim(DesMes(VGParamSistem.Mesproceso)) & "\"
		FileOpen(li_aRC, ruta & Archivo, OpenMode.Output)
		
		If Mid(Archivo, 30, 1) = "2" Then
			FileClose(li_aRC)
			Exit Sub
		End If
		RSparVentas = New ADODB.Recordset
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparVentas.Open. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RSparVentas.Open("select * from ct_paramlibaux where paramlibauxtipo='VT'", VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparVentas.RecordCount. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If RSparVentas.RecordCount = 0 Then
			MsgBox("No existen parametros para el registros de Ventas")
			Exit Sub
		End If
		'UPGRADE_NOTE: El objeto Rrsql no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Rrsql = Nothing
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_Libroregistroventas_rpt"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@anno").Value = VGParamSistem.Anoproceso
			.Parameters("@MES").Value = VGParamSistem.Mesproceso
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparVentas!paramlibauxasiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@ASIENTOSPLAN").Value = RSparVentas!paramlibauxasiento
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparVentas!paramlibauxcuenta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@CTASPLANCOMP").Value = RSparVentas!paramlibauxcuenta
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparVentas!paramlibauxigv. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@CTASIGV").Value = RSparVentas!paramlibauxigv
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparVentas!paramlibauxies. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@CTASFLETE").Value = RSparVentas!paramlibauxies
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparVentas!paramlibauxirenta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@CTASOTROS").Value = RSparVentas!paramlibauxirenta
			.Parameters("@CTASDEVOL").Value = "74%"
			Rrsql = .Execute
		End With
		If Rrsql.RecordCount > 0 Then Call GeneraArchivoVentas(Rrsql, Archivo, li_aRC)
	End Sub
	
	Public Sub GeneraArchivoVentas(ByRef rs As ADODB.Recordset, ByRef Archivo As String, ByRef li_arc1 As Short)
        Dim detcomprobnumref As String = ""
		Dim registro As Object
		Dim reg As String
		Dim dato1 As String
		Dim dato2 As String
		Dim dato3 As String
		Dim contador As Double
		On Error GoTo err1
		rs.MoveFirst()
		contador = 1
		Do While Not rs.EOF
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto registro. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			registro = ""
			With rs
				dato1 = rs.Fields("detcomprobfechaemision").Value
				reg = Mid(Archivo, 14, 8) & "|" + rs.Fields("cabcomprobnumero").Value + "|" + dato1 + "|"
				
				dato1 = rs.Fields("detcomprobfechavencimiento").Value
				reg = reg & dato1 & "|" + rs.Fields("documentocodigo").Value + "|" + rs.Fields("tdserie").Value + "|"
				
				'campos 7 para adelante
                dato1 = Right(rs.Fields("detcomprobnumdocumento").Value, 10)
				dato2 = "0"
				dato3 = rs.Fields("identidadcodigo").Value
				reg = reg & dato1 & "|" & dato2 & "|" & dato3 & "|"
				
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				dato1 = ESNULO(rs.Fields("entidadruc"), "-")
				dato1 = IIf(Left(dato1, 3) = "000", "-", dato1)
				dato2 = RTrim(rs.Fields("entidadrazonsocial").Value)
				If dato2 = "" Then dato2 = "-"
				dato3 = "0.00"
				reg = reg & dato1 & "|" & dato2 & "|" & dato3 & "|"
				
				'campos 13 para adelante
				dato1 = IIf(System.Math.Round(.Fields("baseimponible").Value, 2) = 0, "0.00", System.Math.Round(.Fields("baseimponible").Value, 2))
				dato2 = "0.00"
				dato3 = IIf(System.Math.Round(.Fields("montoinafecto").Value, 2) = 0, "0.00", System.Math.Round(.Fields("montoinafecto").Value, 2))
				reg = reg & dato1 & "|" & dato2 & "|" & dato3 & "|"
				
				dato1 = "0.00"
				dato2 = IIf(System.Math.Round(.Fields("igvimpgrab").Value, 2) = 0, "0.00", System.Math.Round(.Fields("igvimpgrab").Value, 2))
				dato3 = "0.00"
				reg = reg & dato1 & "|" & dato2 & "|" & dato3 & "|"
				
				'campos 19 para adelante
				dato1 = "0.00"
				dato2 = "0.00"
				dato3 = CStr(System.Math.Round(.Fields("baseimponible").Value, 2) + System.Math.Round(.Fields("igvimpgrab").Value, 2) + System.Math.Round(.Fields("montoinafecto").Value, 2))
				dato3 = IIf(CDbl(dato3) = 0, "0.00", dato3)
				reg = reg & dato1 & "|" & dato2 & "|" & dato3 & "|"
				
				dato1 = VB6.Format(.Fields("detcomprobtipocambio").Value, "0.000")
				If .Fields("documentonotacredito").Value = 0 Then
					dato2 = "01/01/0001"
					dato3 = "00"
				Else
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					dato2 = ESNULO(.Fields("detcomprobfecharef"), "01/01/0001")
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					dato3 = ESNULO(Left(.Fields("documentoreferencia").Value, 2), "00")
					dato3 = IIf(dato3 = "", "00", dato3)
				End If
				reg = reg & dato1 & "|" & dato2 & "|" & dato3 & "|"
				
				'campos 25 para adelante
				
				If .Fields("documentonotacredito").Value = 0 Then
					dato1 = "-"
					dato2 = "-"
				Else
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto detcomprobnumref. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    dato1 = IIf(dato1 = "00", "-", Left(detcomprobnumref, 4))
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto detcomprobnumref. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    dato2 = IIf(dato1 = "00", "-", Right(detcomprobnumref, 10))
				End If
				dato3 = IIf(.Fields("operaciondocumentoanulado").Value = True, "2", "1")
				reg = reg & dato1 & "|" & dato2 & "|" & dato3 & "|"
				
			End With
			contador = contador + 1
			If contador = 16 Then
				'    MsgBox ("error")
			End If
			PrintLine(li_arc1, reg)
			rs.MoveNext()
			
		Loop 
		rs.Close()
		FileClose(li_arc1)
		'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		Exit Sub
err1: 
		MsgBox("error")
		Resume Next
	End Sub
	
	Public Function NombreArchivoTxt(ByRef dato1 As String) As Object
		Dim rsql2 As New ADODB.Recordset
		Dim nombre As String
		Dim dia As String
		Dim codoportun As String
        rsql2 = Nothing
		rsql2 = VGCNx.Execute("select * from ct_librossunatcorrelativos where librocodigosunat='" & dato1 & "'")
		If rsql2.Fields("diaproceso").Value = "DD" Then
            dia = Left(CStr(Fecha(1, CDate("01/" & VGParamSistem.Mesproceso & "/" & VGParamSistem.Anoproceso & ""))), 2)
		Else
			dia = rsql2.Fields("diaproceso").Value
		End If
		If rsql2.Fields("codigoOportunidad").Value = "CC" Then
            codoportun = Left(CStr(Fecha(1, CDate("01/" & VGParamSistem.Mesproceso & "/" & VGParamSistem.Anoproceso & ""))), 2)
		Else
			codoportun = rsql2.Fields("codigoOportunidad").Value
		End If
		nombre = rsql2.Fields("identificadorGenerico").Value & VGParametros.RucEmpresa & VGParamSistem.Anoproceso
		nombre = nombre & VGParamSistem.Mesproceso & dia & dato1 & codoportun
		'UPGRADE_NOTE: El objeto rsql2 no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsql2 = Nothing
		SQL = "select * from ct_librosSunatxempresa where empresacodigo='" & VGParametros.empresacodigo & "'"
		SQL = SQL & " and librocodigosunat='" & dato1 & "'"
		rsql2 = VGCNx.Execute(SQL)
		If rsql2.RecordCount = 0 Then
			nombre = nombre & "2011.txt"
		Else
			nombre = nombre & "1111.txt"
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto NombreArchivoTxt. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NombreArchivoTxt = nombre
	End Function
	Public Sub GeneraMayor(ByRef dato As String)
		Dim RSQL As New ADODB.Recordset
		Dim Archivo As String
		Dim li_aRC As Short
		Dim MesAnt As String
		Dim ruta As String
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto NombreArchivoTxt(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Archivo = NombreArchivoTxt(dato)
		li_aRC = FreeFile
		ruta = "C:\libroselectronicos\" & VGParametros.empresacodigo & "\"
		ruta = ruta & VGParamSistem.Anoproceso & "\" & RTrim(DesMes(VGParamSistem.Mesproceso)) & "\"
		FileOpen(li_aRC, ruta & Archivo, OpenMode.Output)
		If Mid(Archivo, 30, 1) = "2" Then
			FileClose(li_aRC)
			Exit Sub
		End If
		MesAnt = VB6.Format(Val(VGParamSistem.Mesproceso) - 1, "00")
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_libroMayor_rpt"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@anno").Value = VGParamSistem.Anoproceso
			.Parameters("@mesant").Value = MesAnt
			.Parameters("@mesini").Value = VGParamSistem.Mesproceso
			.Parameters("@mesfin").Value = VGParamSistem.Mesproceso
			RSQL = .Execute
		End With
		If RSQL.RecordCount > 0 Then Call GeneraArchivoMayor(RSQL, Archivo, li_aRC)
	End Sub
	
	Public Sub GeneraArchivoMayor(ByRef rs As ADODB.Recordset, ByRef Archivo As String, ByRef li_arc1 As Short)
		Dim registro As Object
		Dim reg As String
		Dim fecha As String
		Dim n As Double
		Dim cuenta As String
		rs.MoveFirst()
		cuenta = ""
		n = 0
		Do While Not rs.EOF
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto registro. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			registro = ""
			fecha = "01/" & VGParamSistem.Mesproceso & "/" & VGParamSistem.Anoproceso
			If RTrim(rs.Fields("cabcomprobnumero").Value) <> "" And (rs.Fields("detcomprobdebe").Value + rs.Fields("detcomprobhaber").Value) > 0 Then
				With rs
					If cuenta <> rs.Fields("cuentacodigo").Value Then
						reg = Mid(Archivo, 14, 8) & "|" & Mid(Archivo, 14, 8) & "|" & RTrim(rs.Fields("cuentacodigo").Value) & "|"
						'   campo 4
						reg = reg & fecha & "|" & "SALDOS INICIAL" & "|"
						reg = CStr(CDbl(reg) + IIf(rs.Fields("saldoini").Value > 0, VB6.Format(rs.Fields("saldoini").Value, "00000000.00"), "0.00") + CDbl("|"))
						'Campo 7
						reg = CStr(CDbl(reg) + IIf(rs.Fields("saldoini").Value < 0, VB6.Format(rs.Fields("saldoini").Value * -1, "00000000.00"), "0.00") + CDbl("|") + CDbl("1") + CDbl("|"))
						If rs.Fields("saldoini").Value <> 0 Then PrintLine(li_arc1, reg)
						n = n + 1
					End If
					'campo 1
					fecha = rs.Fields("cabcomprobfeccontable").Value
					reg = Mid(Archivo, 14, 8) & "|" + rs.Fields("cabcomprobnumero").Value + "." + rs.Fields("detcomprobitem").Value + "|"
					reg = reg & RTrim(rs.Fields("cuentacodigo").Value) & "|"
					'   campo 4
					reg = reg & fecha & "|" + rs.Fields("detcomprobglosa").Value + "|" + VB6.Format(rs.Fields("detcomprobdebe").Value, "00000000.00") + "|"
					'Campo 7
					reg = reg & VB6.Format(rs.Fields("detcomprobhaber").Value, "00000000.00") & "|" & "1" & "|"
					cuenta = rs.Fields("cuentacodigo").Value
				End With
				PrintLine(li_arc1, reg)
				n = n + 1
				
			End If
			rs.MoveNext()
		Loop 
		rs.Close()
		FileClose(li_arc1)
		'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		Exit Sub
Error_PDT: 
	End Sub
End Module