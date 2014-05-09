Option Strict Off
Option Explicit On
Imports Contabilidad.ModFuncionesGen
Friend Class ClsMantMov1
	Public Enum Campos
		operacioncodigo = 1
		cuentacodigo = 2
		centrocostocodigo = 3
		tipoanaliticocodigo = 4
		analiticocodigo = 5
		detcomprobruc = 6
		documentocodigo = 7
		detcomprobnumdocumento = 8
		detcomprobfechavencimiento = 9
		detcomprobglosa = 10
		indicador = 11
		monedacodigo = 12
		Montos = 13
		detcomprobfecharef = 14
		detcomprobfechaemision = 15
		plantillaasientoinafecto = 16
	End Enum
	
	Public Sub CargarAyudas()
		With frmantcomprobantes
			Call .CtrAyu_Analitico.Conexion(VGCNx) : .CtrAyu_Analitico.Filtro = "analiticocodigo<>'00'"
			Call .CtrAyu_Asiento.Conexion(VGCNx) : .CtrAyu_Asiento.Filtro = "asientocodigo <>'00'"
			Call .CtrAyu_CCosto.Conexion(VGCNx) : .CtrAyu_CCosto.Filtro = "empresacodigo='" & VGParametros.empresacodigo & "' and centrocostocodigo<>'00' and  centrocostonivel=" & VGnumnivelescentrocosto & ""
			Call .CtrAyu_Cuenta.Conexion(VGCNx) : .CtrAyu_Cuenta.Filtro = "empresacodigo='" & VGParametros.empresacodigo & "' and cuentanivel=" & VGnumnivelescuenta & " and cuentacodigo <>'00'"
			Call .CtrAyu_Opera.Conexion(VGCNx)
			Call .CtrAyu_SubAsiento.Conexion(VGCNx) : .CtrAyu_SubAsiento.Filtro = "subasientocodigo <>'00'"
			Call .CtrAyu_TipAnal.Conexion(VGCNx) : .CtrAyu_TipAnal.Filtro = "tipoanaliticocodigo<>'00'"
			Call .CtrAyu_TipDoc.Conexion(VGCNx) : .CtrAyu_TipDoc.Filtro = "documentocodigo<>'00'"
			Call .CtrAyu_TipRef.Conexion(VGCNx) : .CtrAyu_TipRef.Filtro = "documentocodigo<>'00' and isnull(documentoref,0)<>0 "
			Call .CtrAyu_Moneda.Conexion(VGCNx) : .CtrAyu_Moneda.Filtro = "monedacodigo<>'00'"
			
			Call .CtrAyu_Analitico1.Conexion(VGCNx) : .CtrAyu_Analitico1.Filtro = "analiticocodigo<>'00'"
			Call .CtrAyu_TipDoc1.Conexion(VGCNx) : .CtrAyu_TipDoc1.Filtro = "documentocodigo<>'00'"
			Call .CtrAyu_Cuenta1.Conexion(VGCNx) : .CtrAyu_Cuenta1.Filtro = "empresacodigo='" & VGParametros.empresacodigo & "' and cuentanivel=" & VGnumnivelescuenta & " and cuentacodigo <>'00'"
			Call .CtrAyu_Cuenta2.Conexion(VGCNx)
			Call .CtrAyu_Moneda1.Conexion(VGCNx) : .CtrAyu_Moneda1.Filtro = "monedacodigo<>'00'"
			
		End With
	End Sub
	Public Sub CreaRsTempDetalle(ByRef rs As ADODB.Recordset)
		With rs.Fields
			Call .Append("detcomprobitem", ADODB.DataTypeEnum.adVarChar, 5)
			Call .Append("operacioncodigo", ADODB.DataTypeEnum.adVarChar, 2)
			Call .Append("cuentacodigo", ADODB.DataTypeEnum.adVarChar, 20)
			Call .Append("centrocostocodigo", ADODB.DataTypeEnum.adVarChar, 6)
			Call .Append("tipoanaliticocodigo", ADODB.DataTypeEnum.adVarChar, 3)
			Call .Append("analiticocodigo", ADODB.DataTypeEnum.adVarChar, 15)
			Call .Append("detcomprobruc", ADODB.DataTypeEnum.adVarChar, 13, ADODB.FieldAttributeEnum.adFldIsNullable)
			Call .Append("documentocodigo", ADODB.DataTypeEnum.adVarChar, 2)
			Call .Append("detcomprobnumdocumento", ADODB.DataTypeEnum.adVarChar, 20, ADODB.FieldAttributeEnum.adFldIsNullable)
			Call .Append("detcomprobfechaemision", ADODB.DataTypeEnum.adDate)
			Call .Append("detcomprobfechavencimiento", ADODB.DataTypeEnum.adDate,  , ADODB.FieldAttributeEnum.adFldIsNullable)
			Call .Append("detcomprobglosa", ADODB.DataTypeEnum.adVarChar, 50)
			Call .Append("indicador", ADODB.DataTypeEnum.adVarChar, 1)
			Call .Append("monedacodigo", ADODB.DataTypeEnum.adVarChar, 2)
			Call .Append("tcambio", ADODB.DataTypeEnum.adVarChar, 3)
			Call .Append("valcambio", ADODB.DataTypeEnum.adDouble)
			Call .Append("montosol", ADODB.DataTypeEnum.adDouble)
			Call .Append("montouss", ADODB.DataTypeEnum.adDouble)
			Call .Append("detcomprobauto", ADODB.DataTypeEnum.adBoolean)
			Call .Append("detcomprobajusteuser", ADODB.DataTypeEnum.adBoolean)
			Call .Append("plantillaasientoinafecto", ADODB.DataTypeEnum.adBoolean)
			Call .Append("tipdocref", ADODB.DataTypeEnum.adVarChar, 2, ADODB.FieldAttributeEnum.adFldIsNullable)
			Call .Append("detcomprobnumref", ADODB.DataTypeEnum.adVarChar, 20, ADODB.FieldAttributeEnum.adFldIsNullable)
			Call .Append("comodin", ADODB.DataTypeEnum.adVarChar, 350, ADODB.FieldAttributeEnum.adFldIsNullable)
			Call .Append("tdaux", ADODB.DataTypeEnum.adVarChar, 2, ADODB.FieldAttributeEnum.adFldIsNullable)
			Call .Append("ndaux", ADODB.DataTypeEnum.adVarChar, 50, ADODB.FieldAttributeEnum.adFldIsNullable)
			Call .Append("index", ADODB.DataTypeEnum.adInteger)
			Call .Append("detcomprobitemaux", ADODB.DataTypeEnum.adVarChar, 5)
			Call .Append("NumPlantilla", ADODB.DataTypeEnum.adInteger)
			Call .Append("detcomprobitemres", ADODB.DataTypeEnum.adVarChar, 5)
			Call .Append("detcomprobnlibro", ADODB.DataTypeEnum.adVarChar, 10, ADODB.FieldAttributeEnum.adFldIsNullable)
			Call .Append("detcomprobfecharef", ADODB.DataTypeEnum.adDate,  , ADODB.FieldAttributeEnum.adFldIsNullable)
			Call .Append("detcomprobtipo", ADODB.DataTypeEnum.adVarChar, 5, ADODB.FieldAttributeEnum.adFldIsNullable)
		End With
		
	End Sub
	Public Sub AñadiralDetalle(ByRef rs As ADODB.Recordset)
     	Dim fila As Object
		Dim CamposAux As ADODB.Fields
		Dim I As Short
		'FIXIT: Declare 'Posant' con un tipo de datos de enlace en tiempo de compilación           FixIT90210ae-R1672-R1B8ZE
		Dim rsaux As ADODB.Recordset
        rsaux = rs.Clone(ADODB.LockTypeEnum.adLockReadOnly)
		rsaux.Filter = 0
		Call Limpia()
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fila. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fila = 1
		If rs.RecordCount > 1 Then
			'fila = CDbl(left(rs!Index, Len(rs!Index) - 1)) & CaracterProx(rs!Index)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fila. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fila = CShort(rs.Fields("detcomprobitem").Value) + 1
			rsaux.Filter = "detcomprobitem='" & rs.Fields("detcomprobitem").Value & "'"
			CamposAux = rsaux.Fields
		End If
		With rs
			.AddNew()
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fila. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If fila = 1 Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Fields("detcomprobitem").Value = Format(Val(ESNULO(MaxItem(rs, "detcomprobitem"), 0) + 1), "00000")
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto frmantcomprobantes.DTPFechaComprobCab._Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Fields("detcomprobfechaemision").Value = frmantcomprobantes.DTPFechaComprobCab._Value
                .Fields("indicador").Value = "D"
                .Fields("monedacodigo").Value = VGMonSubAsiento
                .Fields("tcambio").Value = "02"
                .Fields("valcambio").Value = VGValorCambio
                .Fields("Index").Value = 2
                .Fields("detcomprobauto").Value = 0
            Else
                For I = 0 To CamposAux.Count - 1
                    rs.Fields(I).Value = CamposAux(I).Value
                Next
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fila. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Fields("detcomprobitem").Value = Format(fila, "00000")
                .Fields("Index").Value = 1
                .Fields("NumPlantilla").Value = 0
            End If
            .Update()
        End With
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fila. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If fila <> 1 Then
            Call ActualizaNumItems(rs, fila)
            Call VerfiSiEsPlantilla(rs)
            Call CalculoIGV(rs)
            Call CalculodeAjuste(rs)
            Call frmantcomprobantes.CalcularTotales(rs)
        End If
    End Sub
    Private Function CaracterProx(ByVal cad As String) As String
        Dim pos As Short
        Dim cadeval, cadaux As String
        pos = InStr(1, cad, "A", CompareMethod.Text)
        cadeval = Mid(cad, pos, (Len(cad) - pos) + 1)
        cadaux = Right(cadeval, 1)
        If Asc(cadaux) = 90 Then
            cadeval = cadeval & "A"
        Else
            cadeval = Left(cadeval, Len(cadeval) - 1) & Chr(Asc(cadaux) + 1)
        End If
        CaracterProx = cadeval
    End Function
    Public Sub VerfiSiEsPlantilla(ByRef rs As ADODB.Recordset)
        Dim rsaux As ADODB.Recordset
        rsaux = New ADODB.Recordset
        rsaux.Open("select * from ct_subasiento where asientocodigo='" & Trim(frmantcomprobantes.VPAsiento) & "' and subasientocodigo='" & Trim(frmantcomprobantes.VPSubAsiento) & "' and  isnull(subasientorepitedoc,0) =1 ", VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        If rsaux.RecordCount = 0 Then Exit Sub
        If Not rsaux.RecordCount.equals(rs.RecordCount) Then
            VGRepiteDoc = False
        Else
            VGRepiteDoc = True
        End If
    End Sub
    'FIXIT: Declare 'criterio' con un tipo de datos de enlace en tiempo de compilación         FixIT90210ae-R1672-R1B8ZE
    Public Sub ActualizaNumItems(ByRef rs As ADODB.Recordset, ByVal criterio As Object)

        Dim I As Integer
        VGactulizodoc = True
        rs.MoveFirst()
        I = 1
        Do While Not rs.EOF
            rs.Fields("detcomprobitemres").Value = Format(I, "00000")
            rs.Update()
            I = I + 1
            rs.MoveNext()
        Loop
        rs.Sort = ""
        rs.MoveFirst()
        Do While Not rs.EOF
            rs.Fields("detcomprobitem").Value = rs.Fields("detcomprobitemres").Value
            rs.Fields("Index").Value = 2
            rs.Update()
            rs.MoveNext()
        Loop
        rs.Sort = "detcomprobitem asc,index asc "
        rs.MoveFirst()
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto criterio. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        rs.Find("detcomprobitem='" & Format(criterio, "00000") & "'")
        VGactulizodoc = False
    End Sub

    Public Sub Limpia()
        VGflaglimpia = False
        With frmantcomprobantes
            .CtrAyu_Opera.xclave = "" : .CtrAyu_Opera.xnombre = ""
            .CtrAyu_Cuenta.xclave = "" : .CtrAyu_Cuenta.xnombre = ""
            .CtrAyu_CCosto.xclave = "" : .CtrAyu_CCosto.xnombre = ""
            .CtrAyu_TipAnal.xclave = "" : .CtrAyu_TipAnal.xnombre = ""
            .CtrAyu_Analitico.xclave = "" : .CtrAyu_Analitico.xnombre = ""
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .txRuc.Text = ""
            .CtrAyu_TipDoc.xclave = "" : .CtrAyu_TipDoc.xnombre = ""
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .TxSerie.Text = ""
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .TxNdoc.Text = ""
            '     .Dtp_FechaDoc = frmantcomprobantes.DTPFechaComprobCab
            'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            .DtpFech_Ven._Value = System.DBNull.Value
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .TxGlosa.Text = ""
            .CmbID.SelectedIndex = 0
            .CtrAyu_Moneda.xclave = VGMonSubAsiento : .CtrAyu_Moneda.Ejecutar()
            .CmbTcambio.SelectedIndex = 1
            VGValorCambio = RecuperaTipoCambio(Format(frmantcomprobantes.DTPFechaComprobCab._Value, "dd/mm/yyyy"), tipocambio.Venta)
            .lb_vcambio.Text = Format(VGValorCambio, "#.000 ")
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .TxMonto.Text = Format(0, "#.00")
            .CtrAyu_TipRef.xclave = "" : .CtrAyu_TipRef.xnombre = ""
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .TxNref.Text = ""
            'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            .DtpFech_Ven.Value = System.DBNull.Value
            'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            .Dtp_FechaDocRef.Value = System.DBNull.Value

            .CtrAyu_Cuenta1.xclave = "" : .CtrAyu_Cuenta1.xnombre = ""
            .CtrAyu_Cuenta2.xclave = "" : .CtrAyu_Cuenta2.xnombre = ""
            .CtrAyu_Analitico1.xclave = "" : .CtrAyu_Analitico1.xnombre = ""
            .CtrAyu_TipDoc1.xclave = "" : .CtrAyu_TipDoc1.xnombre = ""
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .TxSerie1.Text = ""
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .TxNdoc1.Text = ""

        End With
        VGflaglimpia = True
    End Sub
    'FIXIT: Declare 'FechaAux' con un tipo de datos de enlace en tiempo de compilación         FixIT90210ae-R1672-R1B8ZE
    'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    Public Sub ActualizarDetalle(ByRef rs As ADODB.Recordset, ByRef op As Campos, Optional ByRef flag As Boolean = False, Optional ByRef FechaAux As Object = "01/01/2014")
        'Procedimiento Realizado por Fernando Cossio......
        Dim POSANTERIOR As Object

        Dim swth As Short
        If rs Is Nothing Then Exit Sub
        If rs.RecordCount = 0 Then Exit Sub
        VGactulizodoc = False
        If VGMoverRegistro Then Exit Sub
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim fecha As Date
        Dim mon As String
        Dim camb As Double
        With rs
            '!detcomprobitem = Format(Val(ESNULO(MaxItem(rs, "detcomprobitem"), 0) + 1), "00000")
            Select Case op
                Case 0
                    VGactulizodoc = True
                    POSANTERIOR = .AbsolutePosition
                    .MoveFirst()
                    While Not .EOF
                        .Fields("detcomprobglosa").Value = frmantcomprobantes.TxGlosaComprobCab.Text
                        .Update()
                        .MoveNext()
                    End While
                    VGactulizodoc = False
                    .AbsolutePosition = POSANTERIOR
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
                    Exit Sub
                Case 1 : .Fields("operacioncodigo").Value = frmantcomprobantes.CtrAyu_Opera.xclave
                Case 2 : .Fields("cuentacodigo").Value = frmantcomprobantes.CtrAyu_Cuenta.xclave
                Case 3 : .Fields("centrocostocodigo").Value = Trim(frmantcomprobantes.CtrAyu_CCosto.xclave)
                Case 4 : .Fields("tipoanaliticocodigo").Value = frmantcomprobantes.CtrAyu_TipAnal.xclave
                Case 5
                    .Fields("analiticocodigo").Value = frmantcomprobantes.CtrAyu_Analitico.xclave
                    '!detcomprobruc = Trim$(frmantcomprobantes.txRuc.Text)
                Case 6
                    .Fields("detcomprobruc").Value = Trim(frmantcomprobantes.txRuc.Text)
                Case 7, 8
                    If VGRepiteDoc Then
                        VGactulizodoc = True
                        POSANTERIOR = .AbsolutePosition
                        .MoveFirst()
                        While Not .EOF
                            .Fields("documentocodigo").Value = frmantcomprobantes.CtrAyu_TipDoc.xclave
                            .Fields("detcomprobnumdocumento").Value = Left(frmantcomprobantes.TxSerie.Text, frmantcomprobantes.TxSerie.MaxLength) & frmantcomprobantes.TxNdoc.Text

                            .Fields("tipdocref").Value = frmantcomprobantes.CtrAyu_TipRef.xclave
                            .Fields("detcomprobnumref").Value = frmantcomprobantes.TxNref.Text
                            .Fields("detcomprobfecharef").Value = frmantcomprobantes.Dtp_FechaDocRef._Value
                            .Update()
                            .MoveNext()
                        End While
                        VGactulizodoc = False
                        .AbsolutePosition = POSANTERIOR
                        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
                        Exit Sub
                    Else
                        .Fields("tipdocref").Value = frmantcomprobantes.CtrAyu_TipRef.xclave
                        .Fields("detcomprobnumref").Value = frmantcomprobantes.TxNref.Text
                        .Fields("documentocodigo").Value = frmantcomprobantes.CtrAyu_TipDoc.xclave
                        .Fields("detcomprobnumdocumento").Value = Trim(frmantcomprobantes.TxSerie.Text) & Trim(frmantcomprobantes.TxNdoc.Text)
                    End If
                Case 9
                    .Fields("detcomprobfechavencimiento").Value = frmantcomprobantes.DtpFech_Ven._Value
                Case 14
                    .Fields("detcomprobfecharef").Value = frmantcomprobantes.Dtp_FechaDocRef._Value
                Case 10
                    .Fields("detcomprobglosa").Value = frmantcomprobantes.TxGlosa.Text
                Case 11 : .Fields("indicador").Value = Trim(frmantcomprobantes.CmbID.Text)
                Case 12

                    If (CDbl(.Fields("detcomprobitem").Value) = 1 Or flag) And vgcont <> 2 Then
                        VGactulizodoc = False

                        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto frmantcomprobantes.Dtp_FechaDoc._Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        fecha = frmantcomprobantes.Dtp_FechaDoc._Value
                        mon = frmantcomprobantes.CtrAyu_Moneda.xclave
                        camb = CDbl(ESNULO((frmantcomprobantes.lb_vcambio), 0))
                        POSANTERIOR = .AbsolutePosition
                        '.AbsolutePosition = 1
                        .MoveFirst()
                        Call frmantcomprobantes.AlMoverRegistro()
                        While Not .EOF
                            swth = 1
                            .Fields("detcomprobfechaemision").Value = fecha
                            .Fields("valcambio").Value = camb
                            .Fields("monedacodigo").Value = mon
                            .Update()
                            vgcont = 2
                            If Not flag Then
                                frmantcomprobantes.CtrAyu_Moneda.xclave = mon : frmantcomprobantes.CtrAyu_Moneda.Ejecutar()
                            Else
                                '                       frmantcomprobantes.Dtp_FechaDoc = frmantcomprobantes.DTPFechaComprobCab
                                If IsDBNull(FechaAux) Then FechaAux = frmantcomprobantes.Dtp_FechaDoc._Value
                                VGValorCambio = RecuperaTipoCambio(Format(FechaAux, "dd/mm/yyyy"), frmantcomprobantes.CmbTcambio.SelectedIndex + 1)
                                frmantcomprobantes.lb_vcambio.Text = Format(VGValorCambio, "#.000 ")
                                'If .AbsolutePosition = 1 Then .AbsolutePosition = 1
                                frmantcomprobantes.CtrAyu_Moneda.xclave = mon : frmantcomprobantes.CtrAyu_Moneda.Ejecutar()
                                'Se ejecuta y Actuliza todo el monto de ese registro en ese momento
                            End If


MonedaTodos:
                            .MoveNext()
                        End While
                        VGactulizodoc = False
                        vgcont = 0
                        .AbsolutePosition = POSANTERIOR

                        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
                        Exit Sub
                    Else
                        swth = 2
                        GoTo ActualizaMontos
Monedasola:
                    End If

                Case 13
                    swth = 3
                    GoTo ActualizaMontos

Montos:

                    '                If cuentaigv(CInt(!detcomprobitem)) <> "" Then
                    '                    Call CalculoIGV(rs)
                    '                End If
                Case 15
                    .Fields("detcomprobfechaemision").Value = frmantcomprobantes.Dtp_FechaDoc._Value
                Case 16 : .Fields("plantillaasientoinafecto").Value = frmantcomprobantes.ChkInafecto.CheckState

            End Select
            .Fields("detcomprobauto").Value = 0
            .Update()
        End With
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
        Exit Sub
ActualizaMontos:
        With rs
            .Fields("monedacodigo").Value = frmantcomprobantes.CtrAyu_Moneda.xclave
            .Fields("tcambio").Value = Trim(frmantcomprobantes.CmbTcambio.Text)
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto frmantcomprobantes.Dtp_FechaDoc._Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .Fields("detcomprobfechaemision").Value = frmantcomprobantes.Dtp_FechaDoc._Value
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .Fields("valcambio").Value = CDbl(ESNULO((frmantcomprobantes.lb_vcambio), 0))
            .Fields("detcomprobajusteuser").Value = frmantcomprobantes.ChkAjusta.CheckState
            If frmantcomprobantes.ChkAjusta.CheckState = 0 Then
                If .Fields("monedacodigo").Value <> VGParametros.monedabase Then
                    .Fields("montosol").Value = Coversion(.Fields("monedacodigo").Value, .Fields("valcambio").Value, CDbl(ESNULO(Espunto((frmantcomprobantes.TxMonto.valor)), 0)))
                    .Fields("montouss").Value = System.Math.Round(CDbl(ESNULO(Espunto((frmantcomprobantes.TxMonto.valor)), 0)), 2)
                Else
                    .Fields("montouss").Value = Coversion(.Fields("monedacodigo").Value, .Fields("valcambio").Value, CDbl(ESNULO(Espunto((frmantcomprobantes.TxMonto.valor)), 0)))
                    .Fields("montosol").Value = System.Math.Round(CDbl(ESNULO(Espunto((frmantcomprobantes.TxMonto.valor)), 0)), 2)
                End If
            Else
                If .Fields("monedacodigo").Value = VGParametros.monedabase Then
                    .Fields("montosol").Value = System.Math.Round(CDbl(ESNULO(Espunto((frmantcomprobantes.TxMonto.valor)), 0)), 2)
                    .Fields("montouss").Value = System.Math.Round(CDbl(ESNULO(Espunto((frmantcomprobantes.TxValor.valor)), 0)), 2)
                Else
                    .Fields("montouss").Value = System.Math.Round(CDbl(ESNULO(Espunto((frmantcomprobantes.TxMonto.valor)), 0)), 2)
                    .Fields("montosol").Value = System.Math.Round(CDbl(ESNULO(Espunto((frmantcomprobantes.TxValor.valor)), 0)), 2)
                End If
            End If
        End With
        'Select Case swth
        '	Case 1 : GoTo MonedaTodos
        '	Case 2 : GoTo Monedasola
        '	Case 3 : GoTo Montos
        'End Select
    End Sub
    Public Sub CalculoIGV(ByRef rs As ADODB.Recordset)
        Dim POSANTERIOR As Object
        Dim rsaux As ADODB.Recordset
        Dim ctaigv As String
        Dim inaf As Boolean
        Dim porc As Double
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If cuentaigv(CShort(ESNULO(rs.Fields("detcomprobitemaux"), "0"))) = "" Then Exit Sub
        'If rs!montosol = 0 Then Exit Sub
        VGactulizodoc = True
        rsaux = New ADODB.Recordset
        rsaux.Fields.Append("cuenta", ADODB.DataTypeEnum.adVarChar, 20)
        rsaux.Fields.Append("valorsol", ADODB.DataTypeEnum.adDouble)
        rsaux.Fields.Append("valordol", ADODB.DataTypeEnum.adDouble)
        rsaux.Open()
        With rs
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto POSANTERIOR. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            POSANTERIOR = .AbsolutePosition
            .MoveFirst()
            While Not .EOF
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ctaigv = cuentaigv(CShort(ESNULO(.Fields("detcomprobitemaux"), "0")), inaf, porc)
                If Trim(ctaigv) <> "" And Not inaf Then
                    rsaux.Filter = "cuenta='" & ctaigv & "'"
                    If rsaux.RecordCount = 0 Then
                        rsaux.AddNew()
                        rsaux.Fields("cuenta").Value = ctaigv
                    End If
                    rsaux.Fields("valorsol").Value = rsaux.Fields("valorsol").Value + (.Fields("montosol").Value * (porc / 100))
                    rsaux.Fields("valordol").Value = rsaux.Fields("valordol").Value + (.Fields("montouss").Value * (porc / 100))
                    rsaux.Update()
                End If
                .MoveNext()
            End While
            'Actualizo recordset
            rsaux.MoveFirst()
            While Not rsaux.EOF
                .Filter = "cuentacodigo='" & rsaux.Fields("cuenta").Value & "'"
                If .RecordCount > 0 Then
                    .Fields("montosol").Value = rsaux.Fields("valorsol").Value
                    .Fields("montouss").Value = rsaux.Fields("valordol").Value
                    .Update()
                End If
                rsaux.MoveNext()
            End While
            .Filter = 0
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto POSANTERIOR. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .AbsolutePosition = POSANTERIOR
            VGactulizodoc = False
        End With
    End Sub
    Private Function cuentaigv(ByRef Item As Short, Optional ByRef inaf As Boolean = False, Optional ByRef porc As Double = 0) As String
        Dim rsaux As ADODB.Recordset
        Dim SQL As String
        cuentaigv = ""
        inaf = False
        rsaux = New ADODB.Recordset
        SQL = "select isnull(plantillaasientocuentaigv,'') as A,plantillaasientoinafecto as B,isnull(plantillaasientovalorigv,1) as C from ct_plantillaasiento where " & "asientocodigo='" & frmantcomprobantes.VPAsiento & "' and subasientocodigo='" & frmantcomprobantes.VPSubAsiento & "' and " & "plantillaasientocorrela=" & Item
        rsaux.Open(SQL, VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If rsaux.RecordCount = 0 Then Exit Function
        cuentaigv = rsaux.Fields("a").Value
        inaf = IIf(rsaux.Fields("b").Value = 0, False, True)
        porc = rsaux.Fields("c").Value
    End Function
    Private Function cuentaajuste(ByRef cuenta As String, Optional ByRef ind As String = "") As Short
        Dim rsaux As ADODB.Recordset
        cuentaajuste = 0
        ind = ""
        rsaux = New ADODB.Recordset
        rsaux.Open("select isnull(plantillaasientoctaajuste,0) as A, isnull(iddebeohaber,'') as B from ct_plantillaasiento where " & "asientocodigo='" & frmantcomprobantes.VPAsiento & "' and subasientocodigo='" & frmantcomprobantes.VPSubAsiento & "' and " & "cuentacodigo='" & Trim(cuenta) & "' and isnull(plantillaasientoctaajuste,0) <> 0 ", VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If rsaux.RecordCount = 0 Then Exit Function
        cuentaajuste = 1
        ind = Trim(rsaux.Fields("b").Value)
    End Function
    'FIXIT: Declare 'MaxItem' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
    Private Function MaxItem(ByVal rs As ADODB.Recordset, ByVal Campo As String) As Object
        Dim rsauxiliar As New ADODB.Recordset
        rsauxiliar = rs.Clone(ADODB.LockTypeEnum.adLockReadOnly)
        On Error GoTo errormaxitem
        rsauxiliar.Sort = Campo & " desc"
        rsauxiliar.MoveFirst()
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto MaxItem. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        MaxItem = rsauxiliar.Fields(Campo).Value
        Exit Function
errormaxitem:
        'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto MaxItem. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        MaxItem = System.DBNull.Value
    End Function

    Public Sub GrabarCabecera(ByVal op As Short, ByRef NumComprob As String, Optional ByVal Numlibro As String = "")
        On Error GoTo ErrorGrabaCabecera
        VGCommandoSP = New ADODB.Command
        VGCommandoSP.let_ActiveConnection(VGGeneral)
        VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        VGCommandoSP.CommandText = "ct_grabarcabcomprob_pro"
        VGCommandoSP.Parameters.Refresh()
        With VGCommandoSP
            .Parameters("@base").Value = VGParamSistem.BDEmpresa
            .Parameters("@tabla").Value = VGParamSistem.TablaCabcomprob
            .Parameters("@empresa").Value = VGParametros.empresacodigo
            .Parameters("@op").Value = op
            .Parameters("@cabcomprobmes").Value = CShort(VGParamSistem.Mesproceso)
            .Parameters("@cabcomprobnumero").Value = Trim(NumComprob)
            .Parameters("@asientocodigo").Value = frmantcomprobantes.VPAsiento
            .Parameters("@subasientocodigo").Value = frmantcomprobantes.VPSubAsiento
            If op <= 2 Then
                .Parameters("@cabcomprobfeccontable").Value = frmantcomprobantes.DTPFechaComprobCab._Value
                .Parameters("@cabcomprobobservaciones").Value = UCase(Trim(frmantcomprobantes.TxObsComprobCab.Text))
                .Parameters("@cabcomprobglosa").Value = UCase(Trim(frmantcomprobantes.TxGlosaComprobCab.Text))
                .Parameters("@cabcomprobtotdebe").Value = System.Math.Round(CDbl(ESNULO(frmantcomprobantes.LbTotales0.Text, 0)), 2)
                .Parameters("@cabcomprobtothaber").Value = System.Math.Round(CDbl(ESNULO(frmantcomprobantes.LbTotales1.Text, 0)), 2)
                .Parameters("@cabcomprobtotussdebe").Value = System.Math.Round(CDbl(ESNULO(frmantcomprobantes.LbTotales3.Text, 0)), 2)
                .Parameters("@cabcomprobtotusshaber").Value = System.Math.Round(CDbl(ESNULO(frmantcomprobantes.LbTotales4.Text, 0)), 2)
                If frmantcomprobantes.VlGrabada Then
                    .Parameters("@cabcomprobgrabada").Value = frmantcomprobantes.ChkGrabado.CheckState
                Else
                    .Parameters("@cabcomprobgrabada").Value = 0
                End If
                If frmantcomprobantes.VlNref Then
                    .Parameters("@cabcomprobnref").Value = Trim(frmantcomprobantes.TxCtrNref.Text)
                Else
                    .Parameters("@cabcomprobnref").Value = ""
                End If
                .Parameters("@usuariocodigo").Value = VGUsuario
                .Parameters("@fechaact").Value = Now
                .Parameters("@estcomprobcodigo").Value = "01"
                .Parameters("@cabcomprobnlibro").Value = Numlibro
            End If
        End With
        VGCommandoSP.Execute()
        Exit Sub
ErrorGrabaCabecera:
        VGvarVerifica = False
        VGErrorString = "Error en Grabar Cabecera " & Chr(13) & Err.Description
        MsgBox(VGErrorString)
    End Sub

    Public Function NumeroComprob(ByRef mes As Short, Optional ByRef numero As Double = 0) As String
        On Error GoTo Errnum
        Dim rsaux As ADODB.Recordset
        rsaux = New ADODB.Recordset

        SQL = "select isnull(asientonumcorr" & Trim(Format(mes, "00")) & ",0)+1 as numcorrelativo "
        SQL = SQL & " from ct_asientocorre where empresacodigo='" & VGParametros.empresacodigo & "'"
        SQL = SQL & " and asientocodigo='" & Trim(frmantcomprobantes.VPAsiento) & "'"
        SQL = SQL & " AND asientoanno='" & VGParamSistem.Anoproceso & "'"

        rsaux.Open(SQL, VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        If rsaux.RecordCount > 0 Then
            NumeroComprob = Trim(Format(mes, "00")) & Trim(frmantcomprobantes.VPAsiento) & Trim(Format(rsaux.Fields("numcorrelativo").Value, "00000"))
            numero = rsaux.Fields("numcorrelativo").Value
        Else
            NumeroComprob = "00"
            numero = 0
        End If
        Exit Function
Errnum:
        VGvarVerifica = False
        VGErrorString = "Error en Numero de Comprobante " & Chr(13) & Err.Description
    End Function

    Public Function NumeroComprobLibro(ByRef mes As Short, ByVal libro As String, Optional ByRef numero As Integer = 0) As String
        On Error GoTo Errnum
        Dim rsaux As ADODB.Recordset
        rsaux = New ADODB.Recordset
        SQL = "select isnull(libronumcorr" & Trim(Format(mes, "00")) & ",0)+1 as numcorrelativo from ct_librocorre "
        SQL = SQL & " where empresacodigo='" & VGParametros.empresacodigo & "' and librocodigo='" & Trim(libro) & "'"
        SQL = SQL & " AND libroanno='" & VGParamSistem.Anoproceso & "'"
        rsaux.Open(SQL, VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If rsaux.RecordCount > 0 Then
            NumeroComprobLibro = Trim(Format(mes, "00")) & Trim(libro) & Trim(Format(rsaux.Fields("numcorrelativo").Value, "000000"))
            numero = rsaux.Fields("numcorrelativo").Value
        Else
            NumeroComprobLibro = "00"
            numero = 0
        End If
        Exit Function
Errnum:
        VGvarVerifica = False
        VGErrorString = "Error en Numero de Comprobante Libro " & Chr(13) & Err.Description
    End Function


    Public Sub CalculaComprob(ByVal NumComprob As String)
        On Error GoTo ErrCalc
        VGCommandoSP = New ADODB.Command
        VGCommandoSP.let_ActiveConnection(VGGeneral)
        VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        VGCommandoSP.CommandText = "ct_CalcComprob_pro"
        VGCommandoSP.Parameters.Refresh()
        With VGCommandoSP
            .Parameters("@Servidor").Value = VGParamSistem.Servidor
            .Parameters("@base").Value = VGParamSistem.BDEmpresa
            .Parameters("@empresa").Value = VGParametros.empresacodigo
            .Parameters("@Ano").Value = VGParamSistem.Anoproceso
            .Parameters("@mes").Value = Format(CShort(VGParamSistem.Mesproceso), "0")
            .Parameters("@Asiento").Value = Trim(frmantcomprobantes.VPAsiento)
            .Parameters("@SubAsiento").Value = Trim(frmantcomprobantes.VPSubAsiento)
            .Parameters("@Comprob").Value = NumComprob
            .Execute()
        End With
        Exit Sub
ErrCalc:
        VGvarVerifica = False
        VGErrorString = "Error en Calcular Comprobante " & Chr(13) & Err.Description
    End Sub

    Public Sub ActualizaCorrelComprob(ByVal numero As Double)
        On Error GoTo Actualizacorre
        VGCommandoSP = New ADODB.Command
        VGCommandoSP.let_ActiveConnection(VGGeneral)
        VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        VGCommandoSP.CommandText = "ct_actcorrcomprob_pro"
        VGCommandoSP.Parameters.Refresh()
        With VGCommandoSP
            .Parameters("@base").Value = VGParamSistem.BDEmpresa
            .Parameters("@empresa").Value = VGParametros.empresacodigo
            .Parameters("@anno").Value = VGParamSistem.Anoproceso
            .Parameters("@mes").Value = Format(CShort(VGParamSistem.Mesproceso), "00")
            .Parameters("@asiento").Value = Trim(frmantcomprobantes.VPAsiento)
            .Parameters("@numero").Value = numero
            .Execute()
        End With
        Exit Sub
Actualizacorre:
        VGvarVerifica = False
        VGErrorString = "Error en Actualizar Comprobante " & Chr(13) & Err.Description
    End Sub
    Public Sub ActualizaCorrelComprobLibro(ByVal numero As Double, ByRef libro As String)
        On Error GoTo Actualizacorre
        VGCommandoSP = New ADODB.Command
        VGCommandoSP.let_ActiveConnection(VGGeneral)
        VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        VGCommandoSP.CommandText = "ct_actcorrcomproblibro_pro"
        VGCommandoSP.Parameters.Refresh()
        With VGCommandoSP
            .Parameters("@base").Value = VGParamSistem.BDEmpresa
            .Parameters("@anno").Value = VGParamSistem.Anoproceso
            .Parameters("@empresa").Value = VGParametros.empresacodigo
            .Parameters("@mes").Value = Format(CShort(VGParamSistem.Mesproceso), "00")
            .Parameters("@libro").Value = Trim(libro)
            .Parameters("@numero").Value = numero
            .Execute()
        End With
        Exit Sub
Actualizacorre:
        VGvarVerifica = False
        VGErrorString = "Error en Actualizar Comprobante Libro " & Chr(13) & Err.Description
        MsgBox(VGErrorString)
    End Sub
    Public Sub GrabarDetalle(ByVal rs As ADODB.Recordset, ByRef NumComprob As String, Optional ByVal Numlibro As String = "")
        On Error GoTo ErrorGrabaDetalle
        Dim rsaux As ADODB.Recordset
        Dim NumeroComprobante As String
        Dim numerodocumento As String
        rsaux = rs.Clone(ADODB.LockTypeEnum.adLockReadOnly)
        If Vgdocumentoanulado = "" Then
            rsaux.Filter = "(montosol<>0 or montouss <> 0)"
        Else
            rsaux.Filter = "operacioncodigo='" & Vgdocumentoanulado & "'"
        End If
        VGCommandoSP = New ADODB.Command
        'Elimar los Detalle antes de grabar
        VGCommandoSP.let_ActiveConnection(VGGeneral)
        VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        VGCommandoSP.CommandText = "ct_grabardetallecomprob_pro"
        VGCommandoSP.Parameters.Refresh()
        With VGCommandoSP
            .Parameters("@base").Value = VGParamSistem.BDEmpresa
            .Parameters("@tabla").Value = VGParamSistem.TablaDetcomprob
            .Parameters("@empresa").Value = VGParametros.empresacodigo
            .Parameters("@cabcomprobnumero").Value = NumComprob
            .Parameters("@detcomprobnlibro").Value = Numlibro
            .Parameters("@cabcomprobmes").Value = CShort(VGParamSistem.Mesproceso)
            .Parameters("@asientocodigo").Value = frmantcomprobantes.VPAsiento
            .Parameters("@subasientocodigo").Value = frmantcomprobantes.VPSubAsiento
            .Parameters("@op").Value = 2
            .Execute()
        End With
        rsaux.MoveFirst()
        While Not rsaux.EOF
            If rsaux.Fields("detcomprobauto").Value = 0 Then
                With VGCommandoSP
                    .Parameters("@op").Value = 1
                    .Parameters("@detcomprobitem").Value = rsaux.Fields("detcomprobitem").Value
                    .Parameters("@operacioncodigo").Value = rsaux.Fields("operacioncodigo").Value
                    .Parameters("@cuentacodigo").Value = rsaux.Fields("cuentacodigo").Value
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    .Parameters("@centrocostocodigo").Value = ESNULO(rsaux.Fields("centrocostocodigo"), "00")
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    .Parameters("@analiticocodigo").Value = Trim(ESNULO(rsaux.Fields("analiticocodigo"), "00"))
                    .Parameters("@detcomprobruc").Value = rsaux.Fields("detcomprobruc").Value
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    .Parameters("@documentocodigo").Value = ESNULO(rsaux.Fields("documentocodigo"), "00")
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    numerodocumento = ESNULO(rsaux.Fields("detcomprobnumdocumento"), "")
                    If Len(numerodocumento) > 4 And IsNumeric(numerodocumento) Then
                        numerodocumento = Left(numerodocumento, 4) & Right("0000000000" & Right(numerodocumento, Len(numerodocumento) - 4), 10)
                    End If
                    .Parameters("@detcomprobnumdocumento").Value = numerodocumento
                    .Parameters("@detcomprobfechaemision").Value = Format(rsaux.Fields("detcomprobfechaemision").Value, "dd/mm/yyyy")
                    'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    If IsDbNull(rsaux.Fields("detcomprobfechavencimiento").Value) Then
                        .Parameters("@detcomprobfechavencimiento").Value = Format(rsaux.Fields("detcomprobfechaemision").Value, "dd/mm/yyyy")
                    Else
                        .Parameters("@detcomprobfechavencimiento").Value = Format(rsaux.Fields("detcomprobfechavencimiento").Value, "dd/mm/yyyy")
                    End If
                    .Parameters("@detcomprobfecharef").Value = rsaux.Fields("detcomprobfecharef").Value
                    .Parameters("@detcomprobglosa").Value = UCase(rsaux.Fields("detcomprobglosa").Value)
                    .Parameters("@monedacodigo").Value = rsaux.Fields("monedacodigo").Value
                    .Parameters("@detcomprobtipocambio").Value = rsaux.Fields("valcambio").Value
                    .Parameters("@detcomprobformacambio").Value = rsaux.Fields("tcambio").Value
                    Select Case rsaux.Fields("indicador").Value
                        Case "D"
                            .Parameters("@detcomprobdebe").Value = System.Math.Round(rsaux.Fields("montosol").Value, 2)
                            .Parameters("@detcomprobussdebe").Value = System.Math.Round(rsaux.Fields("montouss").Value, 2)
                            .Parameters("@detcomprobhaber").Value = 0
                            .Parameters("@detcomprobusshaber").Value = 0
                        Case "H"
                            .Parameters("@detcomprobhaber").Value = System.Math.Round(rsaux.Fields("montosol").Value, 2)
                            .Parameters("@detcomprobusshaber").Value = System.Math.Round(rsaux.Fields("montouss").Value, 2)
                            .Parameters("@detcomprobdebe").Value = 0
                            .Parameters("@detcomprobussdebe").Value = 0
                    End Select
                    .Parameters("@detcomprobauto").Value = 0
                    .Parameters("@detcomprobajusteuser").Value = rsaux.Fields("detcomprobajusteuser").Value
                    .Parameters("@plantillaasientoinafecto").Value = rsaux.Fields("plantillaasientoinafecto").Value
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    .Parameters("@tipdocref").Value = ESNULO(rsaux.Fields("tipdocref"), "00")
                    .Parameters("@detcomprobnumref").Value = rsaux.Fields("detcomprobnumref").Value
                    .Execute()
                End With
            End If
            rsaux.MoveNext()
        End While
        Exit Sub
ErrorGrabaDetalle:
        VGvarVerifica = False
        VGErrorString = "Error en Grabar Detalle " & Chr(13) & Err.Description
        MsgBox(VGErrorString)
        Exit Sub
        Resume
    End Sub
    Public Sub GrabaAsientoAuto(ByRef Comp As String)
        On Error GoTo GrabaAuto
        VGCommandoSP = New ADODB.Command
        VGCommandoSP.let_ActiveConnection(VGGeneral)
        VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        VGCommandoSP.CommandText = "ct_grabaautomatico_pro"
        VGCommandoSP.Parameters.Refresh()
        With VGCommandoSP
            .Parameters("@base").Value = VGParamSistem.BDEmpresa
            .Parameters("@tabla").Value = VGParamSistem.TablaDetcomprob
            .Parameters("@empresa").Value = VGParametros.empresacodigo
            .Parameters("@comp").Value = Comp
            .Parameters("@mes").Value = CShort(VGParamSistem.Mesproceso)
            .Parameters("@asiento").Value = frmantcomprobantes.VPAsiento
            .Parameters("@subasiento").Value = frmantcomprobantes.VPSubAsiento
            .Parameters("@tipo").Value = "0"
            .Execute()
        End With
        If VGParametros.AsientoAutoxCCostos = "1" Then
            VGCommandoSP = New ADODB.Command
            VGCommandoSP.let_ActiveConnection(VGGeneral)
            VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            VGCommandoSP.CommandText = "ct_grabaautomatico_pro"
            VGCommandoSP.Parameters.Refresh()
            With VGCommandoSP
                .Parameters("@base").Value = VGParamSistem.BDEmpresa
                .Parameters("@tabla").Value = VGParamSistem.TablaDetcomprob
                .Parameters("@empresa").Value = VGParametros.empresacodigo
                .Parameters("@comp").Value = Comp
                .Parameters("@mes").Value = CShort(VGParamSistem.Mesproceso)
                .Parameters("@asiento").Value = frmantcomprobantes.VPAsiento
                .Parameters("@subasiento").Value = frmantcomprobantes.VPSubAsiento
                .Parameters("@tipo").Value = "1"
                .Execute()
            End With
        End If
        Exit Sub
GrabaAuto:
        VGvarVerifica = False
        VGErrorString = "Error en Grabar Asientos Automaticos " & Chr(13) & Err.Description
        MsgBox(VGErrorString)
    End Sub
    Public Sub MostrarCabecera(ByVal rs As ADODB.Fields)
        Dim rsaux As ADODB.Fields
        rsaux = rs
        With frmantcomprobantes
            .lbNumComprobCab.Text = rsaux("cabcomprobnumero").Value
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .lbNumComprobCablibro.Text = ESNULO((rsaux("cabcomprobnlibro").Value), "")
            .DTPFechaComprobCab._Value = rsaux("cabcomprobfeccontable").Value
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .TxObsComprobCab.Text = rsaux("cabcomprobobservaciones").Value
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .TxGlosaComprobCab.Text = rsaux("cabcomprobglosa").Value
            .LbTotales0.Text = Format(rsaux("cabcomprobtotdebe").Value, "###,###,###.00 ")
            .LbTotales1.Text = Format(rsaux("cabcomprobtothaber").Value, "###,###,###.00 ")
            .LbTotales2.Text = Format(rsaux("cabcomprobtotdebe").Value - rsaux("cabcomprobtothaber").Value, "###,###,###.00 ")
            .LbTotales3.Text = Format(rsaux("cabcomprobtotussdebe").Value, "###,###,###.00 ")
            .LbTotales4.Text = Format(rsaux("cabcomprobtotusshaber").Value, "###,###,###.00 ")
            .LbTotales5.Text = Format(rsaux("cabcomprobtotussdebe").Value - rsaux("cabcomprobtotusshaber").Value, "###,###,###.00 ")
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .ChkGrabado.CheckState = IIf(ESNULO((rsaux("cabcomprobgrabada").Value), False), 1, 0)
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .TxCtrNref.Text = ESNULO((rsaux("cabcomprobnref").Value), "")
            .VPAsiento = rsaux("asientocodigo").Value
            .VPSubAsiento = rsaux("subasientocodigo").Value
        End With
    End Sub
    Public Sub MostrarDetalle(ByRef rs As ADODB.Recordset)
        Dim rsaux As ADODB.Recordset
        Dim I As Short
        On Error GoTo err_Renamed
        rsaux = New ADODB.Recordset
        VGCommandoSP = New ADODB.Command
        'Elimar los Detalle antes de grabar
        VGCommandoSP.let_ActiveConnection(VGGeneral)
        VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        VGCommandoSP.CommandText = "ct_grabardetallecomprob_pro"
        VGCommandoSP.Parameters.Refresh()
        With VGCommandoSP
            .Parameters("@base").Value = VGParamSistem.BDEmpresa
            .Parameters("@tabla").Value = VGParamSistem.TablaDetcomprob
            .Parameters("@empresa").Value = VGParametros.empresacodigo
            .Parameters("@cabcomprobnumero").Value = frmantcomprobantes.lbNumComprobCab.Text
            .Parameters("@cabcomprobmes").Value = CShort(VGParamSistem.Mesproceso)
            .Parameters("@asientocodigo").Value = frmantcomprobantes.VPAsiento
            .Parameters("@subasientocodigo").Value = frmantcomprobantes.VPSubAsiento
            .Parameters("@op").Value = 3
            rsaux = .Execute
        End With
        If rsaux.RecordCount > 0 Then
            rsaux.MoveFirst()
            While Not rsaux.EOF
                rs.AddNew()
                For I = 0 To rsaux.Fields.Count - 1
                    rs.Fields(rsaux.Fields(I).Name).Value = rsaux.Fields(I).Value
                Next
                rs.Fields("tdaux").Value = rsaux.Fields("documentocodigo").Value
                rs.Fields("ndaux").Value = rsaux.Fields("detcomprobnumdocumento").Value
                rs.Fields("Index").Value = 2
                rs.Update()
                rsaux.MoveNext()
            End While
        End If
        If rs.RecordCount > 0 Then
            rs.AbsolutePosition = 1
            frmantcomprobantes.TDBG_Det.Focus()
            frmantcomprobantes.lbnregdetalle.Text = Format(rs.RecordCount, "0 ")
        Else
            frmantcomprobantes.lbnregdetalle.Text = Format(0, "0 ")
        End If
err_Renamed:
        Resume Next
    End Sub
    Public Function ValidarGrabarCabecera(ByRef NR As Integer) As Boolean
        ValidarGrabarCabecera = False
        With frmantcomprobantes
            'Validando Que exista por lo menos un registro en el detalle
            If NR = 0 Then
                MsgBox("Por lo menos debe haber ingresado un registro de detalle", MsgBoxStyle.Information)
                frmantcomprobantes.DTPFechaComprobCab.Focus()
                Exit Function
            End If
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            If Trim(.TxGlosaComprobCab.Text) = "" Then
                MsgBox("Tiene que ingresar la glosa de la cabecera de comprobante")
                .TxGlosaComprobCab.Focus()
                Exit Function
            End If
            ValidarGrabarCabecera = True
        End With
    End Function
    Public Function ValidarGrabarDetalle() As Boolean
        ValidarGrabarDetalle = False
        With frmantcomprobantes
            'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            If (.CtrAyu_Opera.CtlEnabled And .CtrAyu_Opera.Visible) And Trim(.CtrAyu_Opera.xclave) = "" Then
                MsgBox("Debe ingresar el Codigo de Operacion", MsgBoxStyle.Information)
                .CtrAyu_Opera.Focus()
                Exit Function
            End If
            'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            If (.CtrAyu_Cuenta.CtlEnabled And .CtrAyu_Cuenta.Visible) And (Trim(.CtrAyu_Cuenta.xclave) = "" Or Trim(.CtrAyu_Cuenta.xclave) = "00") Then
                MsgBox("Debe ingresar la Cuenta", MsgBoxStyle.Information)
                .CtrAyu_Cuenta.Focus()
                Exit Function
            End If
            'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            If (.CtrAyu_CCosto.CtlEnabled And .CtrAyu_CCosto.Visible) And Trim(.CtrAyu_CCosto.xclave) = "" Then
                MsgBox("Debe ingresar el Centro de Costo", MsgBoxStyle.Information)
                .CtrAyu_CCosto.Focus()
                Exit Function
            End If
            'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            If (.CtrAyu_TipAnal.CtlEnabled And .CtrAyu_TipAnal.Visible) And Trim(.CtrAyu_TipAnal.xclave) = "" Then
                MsgBox("Debe ingresar el Tipo de Analitico", MsgBoxStyle.Information)
                .CtrAyu_TipAnal.Focus()
                Exit Function
            End If
            'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            If (.CtrAyu_Analitico.CtlEnabled And .CtrAyu_Analitico.Visible) And Trim(.CtrAyu_Analitico.xclave) = "" Then
                MsgBox("Debe ingresar el Codigo de Analitico", MsgBoxStyle.Information)
                .CtrAyu_Analitico.Focus()
                Exit Function
            End If
            'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            If (.CtrAyu_TipDoc.CtlEnabled And .CtrAyu_TipDoc.Visible) And Trim(.CtrAyu_TipDoc.xclave) = "" Then
                MsgBox("Debe ingresar el Tipo de Documento", MsgBoxStyle.Information)
                .CtrAyu_TipDoc.Focus()
                Exit Function
            End If

            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            If (.TxSerie.CtlEnabled And .TxSerie.Visible) And Trim(.TxSerie.Text & .TxNdoc.Text) = "" Then
                MsgBox("Debe Ingrear el Numero del Documento", MsgBoxStyle.Information)
                .TxSerie.Focus()
                Exit Function
            End If

            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            If (.TxGlosa.CtlEnabled And .TxGlosa.Visible) And Trim(.TxGlosa.Text) = "" Then
                '     MsgBox "Debe Ingrear la Glosa del Detalle", vbInformation
                '     .TxGlosa.SetFocus
                '      Exit Function
            End If

            'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            If (.CtrAyu_Moneda.CtlEnabled And .CtrAyu_Moneda.Visible) And Trim(.CtrAyu_Moneda.xclave) = "" Then
                MsgBox("Debe ingresar el Codigo de Moneda", MsgBoxStyle.Information)
                .CtrAyu_Moneda.Focus()
                Exit Function
            End If
            If CDbl(.lb_vcambio.Text) = 0 Then
                MsgBox("No existe tipo cambio para esta fecha", MsgBoxStyle.Information)
                .Dtp_FechaDoc.Focus()
                Exit Function
            End If

            '    If CDbl(.TxMonto.valor) = 0 Then
            '        MsgBox "El monto ha ingresar debe ser mayor a 0", vbInformation
            '        Exit Function
            '    End If
            ValidarGrabarDetalle = True

        End With
    End Function
    Public Function ValidarRsDetalle(ByRef rs As ADODB.Recordset) As Boolean
        Dim doc, docaux As String
        ValidarRsDetalle = False
        rs.AbsolutePosition = 1
        While Not rs.EOF
            If Not ValidarGrabarDetalle Then Exit Function
            If rs.Fields("operacioncodigo").Value = "01" Then
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                doc = Trim(ESNULO(rs.Fields("documentocodigo"), "")) & Trim(ESNULO(rs.Fields("detcomprobnumdocumento"), ""))
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                docaux = Trim(ESNULO(rs.Fields("tdaux"), "")) & Trim(ESNULO(rs.Fields("ndaux"), ""))
                If doc <> docaux And Trim(rs.Fields("analiticocodigo").Value) <> "00" Then
                    If ValidaDoc(rs.Fields("cuentacodigo").Value) = True Then
                        If Not Validadocum(rs.Fields("analiticocodigo").Value, rs.Fields("documentocodigo").Value, rs.Fields("detcomprobnumdocumento").Value) Then
                            MsgBox("Este documento ya ha sido registrado", MsgBoxStyle.Exclamation)
                            frmantcomprobantes.TxNdoc.Focus()
                            Exit Function
                        End If
                    End If
                End If
            End If
            rs.MoveNext()
        End While
        frmantcomprobantes.LbTotales2.Text = IIf(frmantcomprobantes.LbTotales2.Text = "", 0, frmantcomprobantes.LbTotales2.Text)
        If CDbl(frmantcomprobantes.LbTotales2.Text) <> 0 Then
            MsgBox("El Asiento se encuentra descuadrado en Soles ", MsgBoxStyle.Exclamation)
            If VGParametros.CuadreAsiento And Not (frmantcomprobantes.CtrAyu_Asiento.xclave = VGParametros.asientocodigo And frmantcomprobantes.CtrAyu_SubAsiento.xclave = VGParametros.subasientocodigo) Then Exit Function
        End If
        ValidarRsDetalle = True
    End Function
    Public Function CargarPlantillaAsiento(ByRef rs As ADODB.Recordset, ByVal Asiento As String, ByVal SubAsiento As String) As Boolean
        Dim rsaux As ADODB.Recordset
        Dim criterio As String = ""

        CargarPlantillaAsiento = False
        rsaux = New ADODB.Recordset
        SQL = "select * from ct_plantillaasiento where asientocodigo='" & Trim(Asiento) & "'"
        SQL = SQL & " AND subasientocodigo='" & Trim(SubAsiento) & "' order by plantillaasientocorrela"
        rsaux = VGCNx.Execute(SQL)
        If rsaux.RecordCount = 0 Then Exit Function
        rsaux.MoveFirst()
        While Not rsaux.EOF
            With rs
                .AddNew()
                If rsaux.Fields("cuentacodigo").Value = "00" Then
                    If rsaux.Fields("plantillaasientocomodin").Value <> "" Then
                        criterio = ArmaCriterioComodin(rsaux.Fields("plantillaasientocomodin").Value)
                    End If
                    .Fields("comodin").Value = criterio
                End If
                .Fields("detcomprobitem").Value = Format(rsaux.Fields("plantillaasientocorrela").Value, "00000")
                .Fields("detcomprobitemaux").Value = Format(rsaux.Fields("plantillaasientocorrela").Value, "00000")
                .Fields("operacioncodigo").Value = rsaux.Fields("operacioncodigo").Value
                .Fields("cuentacodigo").Value = rsaux.Fields("cuentacodigo").Value
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto frmantcomprobantes.DTPFechaComprobCab._Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Fields("detcomprobfechaemision").Value = frmantcomprobantes.DTPFechaComprobCab._Value
                .Fields("indicador").Value = rsaux.Fields("iddebeohaber").Value
                '      !monedacodigo = VGParametros.monedabase
                .Fields("tcambio").Value = "02"
                .Fields("valcambio").Value = VGValorCambio
                .Fields("detcomprobauto").Value = 0
                .Fields("plantillaasientoinafecto").Value = rsaux.Fields("plantillaasientoinafecto").Value
                .Fields("detcomprobglosa").Value = VGGlosa
                .Fields("monedacodigo").Value = VGMonSubAsiento
                .Fields("Index").Value = 2
                .Fields("NumPlantilla").Value = rsaux.Fields("plantillaasientocorrela").Value
                .Fields("detcomprobTipo").Value = rsaux.Fields("plantillaasientoTipo").Value
                .Update()
            End With
            rsaux.MoveNext()
        End While

        rs.AbsolutePosition = 1
        CargarPlantillaAsiento = True
    End Function
    Private Function ArmaCriterioComodin(ByRef cad As String) As String
        Dim pos As Short
        Dim criterio As String
        Dim valor As String
        criterio = ""
        Do While True
            pos = InStr(1, cad, "%", CompareMethod.Text)
            If pos = 0 Then Exit Do
            valor = "'" & Left(cad, pos) & "'"
            cad = Right(cad, Len(cad) - pos)
            criterio = criterio & "cuentacodigo like " & valor & " or "
        Loop
        ArmaCriterioComodin = Left(criterio, Len(criterio) - 3)
    End Function
    Public Function RecuperaTipoCambio(ByRef fecha As String, ByRef tipo As tipocambio) As Double
        Dim rsaux As ADODB.Recordset
        rsaux = New ADODB.Recordset
        'FIXIT: Declare 'fechaIni' con un tipo de datos de enlace en tiempo de compilación         FixIT90210ae-R1672-R1B8ZE
        Dim fechaIni As Object
        Dim fechaDato As Date
        Dim Campo As String
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fechaIni. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        fechaIni = "01/01/" & VGParamSistem.Anoproceso
        fechaDato = CDate(fecha)
        'FIXIT: Reemplazar la función 'Str' con la función 'Str$'.                                 FixIT90210ae-R9757-R1B8ZE
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fechaIni. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If fechaIni > fechaDato Then fecha = "31/12/" & Str(CDbl(VGParamSistem.Anoproceso) - 1)
        RecuperaTipoCambio = 0
        Select Case tipo
            Case tipocambio.Compra
                Campo = "tipocambiocompra"
            Case tipocambio.Venta
                Campo = "tipocambioventa"
            Case tipocambio.Promedio
                Campo = "tipocambiopromedio"
            Case Else
                Campo = "tipocambioventa"
        End Select
        rsaux.Open("Select Valor=isnull(" & Campo & ",0)  from ct_tipocambio where tipocambiofecha ='" & fecha & "'", VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If rsaux.RecordCount > 0 Then
            RecuperaTipoCambio = rsaux.Fields("valor").Value
            frmantcomprobantes.lbnregdetalle.Text = Format(rsaux.RecordCount, "0 ")
        End If
    End Function
	Public Function Validadocum(ByRef analitico As String, ByRef tipdoc As String, ByRef ndoc As String) As Boolean
		Dim sqlcad As String
		Dim rsaux As ADODB.Recordset
		Validadocum = True
		rsaux = New ADODB.Recordset
		sqlcad = "select * from dbo.ct_detcomprob" & VGParamSistem.Anoproceso & " where analiticocodigo='" & Trim(analitico) & "' and " & " operacioncodigo='01' and documentocodigo='" & Trim(tipdoc) & "' and " & " detcomprobnumdocumento='" & Trim(ndoc) & "' "
		rsaux.Open(sqlcad, VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		If rsaux.RecordCount = 0 Then Exit Function
		Validadocum = False
	End Function
	Public Function Verifidocumacancelar(Optional ByRef moneda As String = "", Optional ByRef fecha As Date = #12:00:00 AM#, Optional ByRef montototal As Double = 0, Optional ByRef montoacumamort As Double = 0) As Boolean
		Dim sqlcad As String
		Dim rsaux As ADODB.Recordset
		Dim Ncomprob As String
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Ncomprob = Trim(frmantcomprobantes.TxSerie.Text) & IIf(Trim(frmantcomprobantes.TxSerie.Text) = "", "", "-") & Trim(frmantcomprobantes.TxNdoc.Text)
		Verifidocumacancelar = False
		rsaux = New ADODB.Recordset
		sqlcad = "select * from dbo.ct_detcomprob" & VGParamSistem.Anoproceso & " where analiticocodigo='" & Trim(frmantcomprobantes.CtrAyu_Analitico.xclave) & "' and " & " isnull(operacioncodigo,'')='01' and documentocodigo='" & Trim(frmantcomprobantes.CtrAyu_TipDoc.xclave) & "' and " & " detcomprobnumdocumento='" & Ncomprob & "" & "' "
		rsaux.Open(sqlcad, VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		If rsaux.RecordCount = 0 Then Exit Function
		Verifidocumacancelar = True
	End Function
	
	Public Sub CalculodeAjuste(ByRef rs As ADODB.Recordset, Optional ByRef flagnotipocambio As Boolean = False)
		On Error GoTo ERRX
        Dim POSANTERIOR As Object
		Dim rsaux As ADODB.Recordset
		Dim monto As Double
        Dim ctaajuste As String
        Dim ind As String = ""
		Dim sicuentaajuste As Short
		Dim difsoles, difdolares As Double
        difsoles = CDbl(ESNULO(frmantcomprobantes.LbTotales2.Text, 0)) 'diferencia en soles
        difdolares = CDbl(ESNULO(frmantcomprobantes.LbTotales5.Text, 0)) 'diferencia en dolares
		VGactulizodoc = True
		rsaux = New ADODB.Recordset
		rsaux.Fields.Append("CtaAjustevar", ADODB.DataTypeEnum.adVarChar, 20)
		rsaux.Fields.Append("Indi", ADODB.DataTypeEnum.adVarChar, 1)
		rsaux.Open()
        Dim campoajustar As String = ""
		With rs
            POSANTERIOR = .AbsolutePosition
			.MoveFirst()
			While Not .EOF
				sicuentaajuste = cuentaajuste(.Fields("cuentacodigo").Value, ind)
				If sicuentaajuste = 1 And ind = "D" Then
					rsaux.AddNew()
					rsaux.Fields("CtaAjustevar").Value = .Fields("cuentacodigo").Value
					rsaux.Fields("indi").Value = "D"
					rsaux.Update()
				End If
				If sicuentaajuste = 1 And ind = "H" Then
					rsaux.AddNew()
					rsaux.Fields("CtaAjustevar").Value = .Fields("cuentacodigo").Value
					rsaux.Fields("indi").Value = "H"
					rsaux.Update()
				End If
				.MoveNext()
			End While
			If rsaux.RecordCount = 0 Then
				.Filter = 0
				'Modificado:03/02/2003 ICS
                If POSANTERIOR < 0 Then Exit Sub
                .AbsolutePosition = POSANTERIOR
				VGactulizodoc = False
				Exit Sub
			End If
			Call CalcularTotalessinajuste(rs, rsaux, difsoles, difdolares)
			'En el caso que no cuadre en la moneda base que seria el sol
			'Y cuadre en la moneda en dolares
			
			If Not flagnotipocambio Then
				If difsoles <> 0 And difdolares = 0 Then
					If difsoles < 0 Then campoajustar = "D"
					If difsoles > 0 Then campoajustar = "H"
				Else
					campoajustar = "N"
				End If
			Else
				campoajustar = "N"
			End If
			'Solamente dos cuentas de ajuste deben existir
			rsaux.MoveFirst()
			.Filter = 0
			While Not rsaux.EOF
				.Filter = 0
				.Filter = "cuentacodigo='" & Trim(rsaux.Fields("CtaAjustevar").Value) & "'"
				If .RecordCount > 0 Then
					If rsaux.Fields("indi").Value = campoajustar Then
						.Fields("montosol").Value = System.Math.Abs(difsoles)
					Else
						.Fields("montosol").Value = 0
					End If
					.Fields("montouss").Value = 0
					.Update()
				End If
				rsaux.MoveNext()
			End While
			
			.Filter = 0
            .AbsolutePosition = POSANTERIOR
			VGactulizodoc = False
		End With
		
ERRX: 
		
	End Sub
	
	Private Sub CalcularTotalessinajuste(ByVal rs As ADODB.Recordset, ByVal rsajust As ADODB.Recordset, ByRef difersoles As Double, ByRef diferdolares As Double)
		Dim rsaux, rs2 As ADODB.Recordset
        rsaux = rs.Clone(ADODB.LockTypeEnum.adLockReadOnly)
		rs2 = rsajust.Clone(ADODB.LockTypeEnum.adLockReadOnly)
        Dim difsoles, difdolares As Double
		Dim montosolesDebe, montodolaresDebe As Double
		Dim montosolesHaber, montodolaresHaber As Double
		Dim cad As String
		cad = ""
		If rs2.RecordCount = 0 Then Exit Sub
		rs2.MoveFirst()
		Do While Not rs2.EOF
			cad = cad & "cuentacodigo<>'" & rs2.Fields("CtaAjustevar").Value & "' and "
			rs2.MoveNext()
		Loop 
		cad = Trim(Left(cad, Len(cad) - 4))
		
		montosolesDebe = 0 : montodolaresDebe = 0
		montosolesHaber = 0 : montodolaresHaber = 0
		difsoles = 0 : difdolares = 0
		rsaux.Filter = cad
		rsaux.MoveFirst()
		While Not rsaux.EOF
			If rsaux.Fields("indicador").Value = "D" Then
                montosolesDebe = montosolesDebe + ESNULO(rsaux.Fields("montosol"), 0)
                montodolaresDebe = montodolaresDebe + ESNULO(rsaux.Fields("montouss"), 0)
			Else
                montosolesHaber = montosolesHaber + ESNULO(rsaux.Fields("montosol"), 0)
                montodolaresHaber = montodolaresHaber + ESNULO(rsaux.Fields("montouss"), 0)
			End If
			rsaux.MoveNext()
		End While
		difsoles = montosolesDebe - montosolesHaber
		difdolares = montodolaresDebe - montodolaresHaber
		difersoles = difsoles
		diferdolares = difdolares
		rsaux.Filter = 0
	End Sub
	
    Private Function ValidaDoc(ByVal cuenta As String) As Boolean
        Dim sqldoc As String
        Dim rsdoc As ADODB.Recordset
        rsdoc = New ADODB.Recordset
        ValidaDoc = False
        sqldoc = "Select cuentadocumento From ct_cuenta Where empresacodigo='" & VGParametros.empresacodigo & "' And cuentacodigo='" & cuenta & "' And cuentadocumento='1' "
        rsdoc.Open(sqldoc, VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If rsdoc.RecordCount > 0 Then ValidaDoc = True
    End Function
	
	Public Sub ActivaIngresorapido(ByVal rs1 As ADODB.Recordset, ByRef form1 As System.Windows.Forms.Form)
        With frmantcomprobantes
            .Txtimpo.Visible = False
            .TxtIgv.Visible = False
            .TxtPerc.Visible = False
            .TxtInaf.Visible = False
            If rs1.RecordCount = 0 Then
                .FrameIngreso.Visible = False
                Exit Sub
            End If
            rs1.MoveFirst()
            While Not rs1.EOF
                If rs1.Fields("detcomprobTipo").Value = "IMPO" Then
                    .Txtimpo.Visible = True
                    If rs1.Fields("cuentacodigo").Value = "00" Then
                        If ESNULO(rs1.Fields("comodin"), "") <> "" Then
                            .CtrAyu_Cuenta1.Filtro = "(empresacodigo='" & VGParametros.empresacodigo & "' and (cuentanivel=" & VGnumnivelescuenta & ") and (cuentacodigo<>'00') and (" & rs1.Fields("comodin").Value & "))"
                        Else
                            .CtrAyu_Cuenta1.Filtro = "(empresacodigo='" & VGParametros.empresacodigo & "' and (cuentacodigo<>'00')" & " and (cuentanivel=" & VGnumnivelescuenta & "))"
                        End If
                    Else
                        If rs1.Fields("cuentacodigo").Value <> "" Then
                            .CtrAyu_Cuenta1.xclave = rs1.Fields("cuentacodigo").Value
                            .CtrAyu_Cuenta1.Ejecutar()
                        Else
                            .CtrAyu_Cuenta1.Filtro = "(empresacodigo='" & VGParametros.empresacodigo & "' and (cuentacodigo<>'00')" & " and (cuentanivel=" & VGnumnivelescuenta & "))"
                        End If
                    End If
                ElseIf rs1.Fields("detcomprobTipo").Value = "IGV" Then
                    .TxtIgv.Visible = True
                ElseIf rs1.Fields("detcomprobTipo").Value = "INAF" Then
                    .TxtInaf.Visible = True
                ElseIf rs1.Fields("detcomprobTipo").Value = "PERC" Then
                    .TxtPerc.Visible = True
                ElseIf rs1.Fields("detcomprobTipo").Value = "TOT" Then
                    If rs1.Fields("cuentacodigo").Value = "00" Then
                        If ESNULO(rs1.Fields("comodin"), "") <> "" Then
                            .CtrAyu_Cuenta2.Filtro = "(empresacodigo='" & VGParametros.empresacodigo & "' and (cuentanivel=" & VGnumnivelescuenta & ") and (cuentacodigo<>'00') and (" & rs1.Fields("comodin").Value & "))"
                        Else
                            .CtrAyu_Cuenta2.Filtro = "(empresacodigo='" & VGParametros.empresacodigo & "' and (cuentacodigo<>'00')" & " and (cuentanivel=" & VGnumnivelescuenta & "))"
                        End If
                    Else
                        If rs1.Fields("cuentacodigo").Value <> "" Then
                            .CtrAyu_Cuenta2.xclave = rs1.Fields("cuentacodigo").Value
                            .CtrAyu_Cuenta2.Ejecutar()
                        Else
                            .CtrAyu_Cuenta2.Filtro = "(empresacodigo='" & VGParametros.empresacodigo & "' and (cuentacodigo<>'00')" & " and (cuentanivel=" & VGnumnivelescuenta & "))"
                        End If
                    End If
                End If
                rs1.MoveNext()
            End While
        End With
	End Sub
	Public Sub ActualizaIngresorapido(ByRef rs1 As ADODB.Recordset, ByRef form1 As System.Windows.Forms.Form)
        With frmantcomprobantes
            rs1.MoveFirst()
            While Not rs1.EOF
                If rs1.Fields("detcomprobTipo").Value = "IMPO" Then
                    rs1.Fields("cuentacodigo").Value = .CtrAyu_Cuenta1.xclave
                    rs1.Fields("montosol").Value = Val(.Txtimpo.Text)
                    .TxMonto.Text = Val(.Txtimpo.Text)
                ElseIf rs1.Fields("detcomprobTipo").Value = "IGV" Then
                    rs1.Fields("montosol").Value = Val(.TxtIgv.Text)
                    .TxMonto.Text = Val(.TxtIgv.Text)
                ElseIf rs1.Fields("detcomprobTipo").Value = "INAF" Then
                    rs1.Fields("montosol").Value = Val(.TxtInaf.Text)
                    .TxMonto.Text = Val(.TxtInaf.Text)
                ElseIf rs1.Fields("detcomprobTipo").Value = "PERC" Then
                    rs1.Fields("montosol").Value = Val(.TxtPerc.Text)
                    .TxMonto.Text = Val(.TxtPerc.Text)
                ElseIf rs1.Fields("detcomprobTipo").Value = "TOT" Then
                    rs1.Fields("montosol").Value = Val(.TxtTot.Text)
                    .TxMonto.Text = Val(.TxtTot.Text)
                    rs1.Fields("analiticocodigo").Value = .CtrAyu_Analitico1.xclave
                    rs1.Fields("documentocodigo").Value = .CtrAyu_TipDoc1.xclave
                    rs1.Fields("detcomprobnumdocumento").Value = .TxSerie1.Text + .TxNdoc1.Text
                    rs1.Fields("detcomprobfechaemision").Value = .DTP_fecha1
                    rs1.Fields("detcomprobfechavencimiento").Value = .DTP_fecha1

                End If

                rs1.MoveNext()
            End While
            If VGRepiteDoc Then
                rs1.MoveFirst()
                While Not rs1.EOF
                    rs1.Fields("documentocodigo").Value = .CtrAyu_TipDoc1.xclave
                    rs1.Fields("detcomprobnumdocumento").Value = Left(.TxSerie1.Text, .TxSerie1.MaxLength) & .TxNdoc1.Text
                    rs1.Update()
                    rs1.MoveNext()
                End While
            Else
                rs1.Fields("documentocodigo").Value = .CtrAyu_TipDoc1.xclave
                rs1.Fields("detcomprobnumdocumento").Value = Trim(.TxSerie1.Text) & Trim(.TxNdoc1.Text)
            End If
        End With
	End Sub
End Class