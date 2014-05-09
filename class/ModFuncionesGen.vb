Option Strict Off
Option Explicit On
Module ModFuncionesGen


    Public Function Existe(ByRef tipo As Short, ByRef Cod As String, ByRef Tabla As String, ByRef Campo As String, ByRef Fecha As Boolean, Optional ByRef Cod2 As String = "", Optional ByRef cCampo2 As String = "", Optional ByRef Cod3 As String = "", Optional ByRef cCampo3 As String = "", Optional ByRef Cod4 As Boolean = False, Optional ByRef cCampo4 As String = "", Optional ByRef Cod5 As String = "", Optional ByRef cCampo5 As String = "") As Boolean
        Dim cSel1 As ADODB.Recordset
        Dim cSL As String
        cSel1 = New ADODB.Recordset

        If Fecha Then
            cSL = "Select * from " & Tabla & "  Where " & Campo & " =  '" & Cod & "'"
        Else
            If UCase(Tabla) = "PUNTO_VENTA" Then
                cSL = "Select * from " & Tabla & "  Where " & Campo & " =  '" & Cod & "'"
            Else
                cSL = "Select * from " & Tabla & "  Where " & Campo & " =  '" & Cod & "'"
            End If
            If Trim(Cod2) <> "" Then
                cSL = cSL & " And  " & cCampo2 & " =  '" & SupCadSQL(Cod2) & "'"
            End If
            If Trim(Cod3) <> "" Then
                cSL = cSL & " And  " & cCampo3 & " =  '" & SupCadSQL(Cod3) & "'"
            End If
            If Trim(cCampo4) <> "" Then
                If Cod4 = True Then
                    cSL = cSL & " And  " & cCampo4
                Else
                    cSL = cSL & " And  " & Not cCampo4
                End If
            End If
            If Trim(Cod5) <> "" Then
                cSL = cSL & " And  " & cCampo5 & " =  '" & Cod5 & "'"
            End If
        End If

        Select Case tipo
            Case 1 'Bd. Comun
                cSel1.Open(cSL, VGCNx, ADODB.CursorTypeEnum.adOpenStatic)
            Case 2 'Bd. Config
                cSel1.Open(cSL, VGConfig, ADODB.CursorTypeEnum.adOpenStatic)
            Case 3 'Bd. Contab
                cSel1.Open(cSL, VGCnxCT, ADODB.CursorTypeEnum.adOpenStatic)
        End Select

        If cSel1.RecordCount > 0 Then
            Existe = True
        Else
            Existe = False
        End If
        'csel1.Close
    End Function
    Public Function Validar_RUC(ByRef xRuc As String) As Boolean
        Dim flag As Boolean
        'UPGRADE_WARNING: El límite inferior de la matriz TAB_VAL ha cambiado de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
        Dim TAB_VAL(10) As Short

        ' TAB_VAL(1) = 2
        ' TAB_VAL(2) = 7
        ' TAB_VAL(3) = 6
        ' TAB_VAL(4) = 5
        ' TAB_VAL(5) = 4
        ' TAB_VAL(6) = 3
        ' TAB_VAL(7) = 2
        flag = True
        xRuc = Trim(xRuc)

        ' If xRuc <> " " Then
        'If xRuc <> "00000002" Then
        If Len(RTrim(xRuc)) < 11 Then
            MsgBox("Número de R.U.C. no tiene 11 dígitos", MsgBoxStyle.Exclamation, "Ingreso de Datos")
            flag = False
        Else
            '         nX = 0
            '         NR = 0
            '         NY = 0
            '         CadNR = ""
            '         For i = 1 To 7
            '             nX = nX + Val(mid$(xRuc, i, 1)) * TAB_VAL(i)
            '         Next i
            '         NY = nX \ 11
            '         NR = 11 - (nX - (NY * 11))
            '         CadNR = TRIM$(String(10 - Len(Str(NR)) + 1, "0")) & TRIM$(Str(NR))
            '         If mid$(CadNR, 10, 1) = mid$(xRuc, 8, 1) Then
            '            flag = True
            ''         Else
            '            MsgBox "Número de R.U.C. invalido", vbExclamation, "Ingreso de Datos"
            '            flag = False
            '         End If
        End If
        '   Else
        '      MsgBox "Anexo emite Liquidaciones de compra", vbExclamation, "Ingreso de Datos"
        '  End If
        'End If
        Validar_RUC = flag
    End Function
    '*************************************************
    'Elimina de ( ' ) de una Cadena
    'para Grabarla en una instrucción SQL
    '*************************************************
    Public Function SupCadSQL(ByRef S As String) As String
        Dim Aux As String = ""
        If Not IsDBNull(S) Then
            Aux = Replace(S, "'", "''")
        End If
        SupCadSQL = Aux

    End Function
    Public Function XRecuperaTipoCambio(ByRef Fecha As Date, ByRef tipo As tipocambio, ByRef cnx As ADODB.Connection) As Double
        Dim RSAUX As ADODB.Recordset
        RSAUX = New ADODB.Recordset
        Dim Campo As String
        XRecuperaTipoCambio = 0
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
        SQL = "Select Valor=isnull(" & Campo & ",0)  from ct_tipocambio where tipocambiofecha ='" & Fecha & "'"
        RSAUX = VGCNx.Execute(SQL)
        If RSAUX.RecordCount > 0 Then
            XRecuperaTipoCambio = RSAUX.Fields("valor").Value
        End If
    End Function
    Public Function ExisteSQL(ByVal cnx As ADODB.Connection, ByVal SentenciaSQL As String) As Boolean
        On Error GoTo SaliError
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        ExisteSQL = False
        Dim RSAUX As ADODB.Recordset
        RSAUX = New ADODB.Recordset
        RSAUX.Open(SentenciaSQL, cnx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If RSAUX.RecordCount > 0 Then
            ExisteSQL = True
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
        Exit Function
SaliError:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
        ExisteSQL = False
        MsgBox(Err.Description)
        Exit Function
        Resume
    End Function
    Public Function Fecha(ByVal tipo As Short, ByRef dato As Date) As Date
        Dim fecha1 As Date
        fecha1 = CDate(Format("01/" & Format(Month(dato), "00") & "/" & Year(dato), "dd/mm/yyyy"))
        Select Case tipo
            Case 1
                Fecha = fecha1
            Case 2
                fecha1 = System.Date.FromOADate(fecha1.ToOADate + 31)
                fecha1 = CDate(Format("01/" & Format(Month(fecha1), "00") & "/" & Year(fecha1), "dd/mm/yyyy"))
                Fecha = System.Date.FromOADate(fecha1.ToOADate - 1)
            Case 3
                fecha1 = System.Date.FromOADate(fecha1.ToOADate - 27)
                Fecha = CDate(Format("01/" & Format(Month(fecha1), "00") & "/" & Year(fecha1), "dd/mm/yyyy"))
        End Select
    End Function

    Public Function ESNULO(ByRef EXPRESION As Object, ByRef valor As Object) As Object
        On Error GoTo errfun
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto EXPRESION. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If IsDbNull(EXPRESION) Or IsNothing(Trim(EXPRESION)) Then
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto valor. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ESNULO = valor
        Else
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto EXPRESION. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ESNULO = EXPRESION
        End If
        Exit Function
errfun:
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto valor. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ESNULO = valor
    End Function
    Public Function ExisteElem(ByRef Tip As Short, ByRef VGCN As ADODB.Connection, ByRef Tabla As String, Optional ByRef Campo As String = "") As Boolean
        'Funcion que devuelve un valor verdadero si es que encuentra el elemento
        'Creado por Fernando Cossio
        Dim SQL As String
        Dim RSAUX As New ADODB.Recordset
        '*------------------------------*
        '0 Si Existe la tabla
        '1 Si Existe el Campo
        ExisteElem = False
        Tabla = UCase(Tabla) : Campo = UCase(Campo)
        On Error GoTo ErrExiste
        SQL = ""
        Select Case Tip
            Case 0
                SQL = "Select Top 1 * From " & Tabla
            Case 1
                SQL = "Select Top 1 " & Campo & " From " & Tabla
        End Select
        RSAUX = VGCN.Execute(SQL)
        ExisteElem = True
        Exit Function
ErrExiste:
        ExisteElem = False
    End Function
    Public Function DateSQL(ByVal Fecha As String) As String
        On Error GoTo ERR
        Select Case VGformatofecha
            Case "DMY"
                DateSQL = "" & Format(Fecha, "dd/mm/yyyy") & ""
            Case "MDY"
                DateSQL = "" & Format(Fecha, "mm/dd/yyyy") & ""
        End Select
ERR:
        DateSQL = "" & Format(Fecha, "dd/mm/yyyy") & ""
    End Function

    Function DesMes(ByRef nMes As String) As String
        Dim DescriMes As String = ""

        Select Case nMes
            Case "01"
                DescriMes = "ENERO "
            Case "02"
                DescriMes = "FEBRERO  "
            Case "03"
                DescriMes = "MARZO "
            Case "04"
                DescriMes = "ABRIL "
            Case "05"
                DescriMes = "MAYO "
            Case "06"
                DescriMes = "JUNIO "
            Case "07"
                DescriMes = "JULIO "
            Case "08"
                DescriMes = "AGOSTO "
            Case "09"
                DescriMes = "SETIEMBRE "
            Case "10"
                DescriMes = "OCTUBRE "
            Case "11"
                DescriMes = "NOVIEMBRE "
            Case "12"
                DescriMes = "DICIEMBRE "
        End Select

        DesMes = DescriMes
    End Function

    Public Function Devolver_Dato(ByRef tipo As Short, ByRef Cod As String, ByRef Tabla As String, ByRef Campo As String, ByRef Fecha As Boolean, ByRef CampDev As String, Optional ByRef Cod2 As String = "", Optional ByRef Campo2 As String = "", Optional ByRef Cod3 As String = "", Optional ByRef Campo3 As String = "", Optional ByRef Cod4 As Double = 0, Optional ByRef Campo4 As String = "") As String
        Dim cSel1 As ADODB.Recordset
        Dim cF As String = ""
        cSel1 = New ADODB.Recordset

        If Trim(Campo) <> "" Then
            If Fecha = False Then
                cF = "Select " & CampDev & " from " & Tabla & "  Where " & Campo & " =  '" & Cod & "' "
            Else
                cF = "Select " & CampDev & " from " & Tabla & "  Where " & Campo & " =  #" & Format(Cod, "mm/dd/yyyy") & "#"
            End If
        End If
        If Trim(Campo2) <> "" Then
            cF = cF & " and " & Campo2 & " = '" & Cod2 & "' "
        End If
        If Trim(Campo3) <> "" Then
            cF = cF & " and " & Campo3 & " = '" & Cod3 & "' "
        End If
        If Trim(Campo4) <> "" Then
            cF = cF & " and " & Campo4 & " = '" & Cod4 & "' "
        End If
        Select Case tipo
            Case 1 'Bd. Comun
                cSel1.Open(cF, VGCNx, ADODB.CursorTypeEnum.adOpenStatic)
            Case 2 'Bd. Config
                cSel1.Open(cF, VGConfig, ADODB.CursorTypeEnum.adOpenStatic)
            Case 3 'Bd. Contabilidad
                cSel1.Open(cF, VGCnxCT, ADODB.CursorTypeEnum.adOpenStatic)
        End Select

        If cSel1.RecordCount > 0 Then
            'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            Devolver_Dato = IIf(Not IsDbNull(cSel1.Fields(0).Value), cSel1.Fields(0).Value, "")
        Else
            Devolver_Dato = ""
        End If
    End Function

    Public Function NUMLET(ByRef num As String) As String
        Dim cLET As String
        Dim cWork As String
        Dim cUNIDAD As String
        Dim cDECENA As String
        Dim cCENTENA As String
        Dim nMODULUS As Short
        Dim nI As Short
        Dim nK As Short
        Dim Lit1 As String
        Dim Lit2 As String
        Dim Lit3 As String
        Dim Lit4 As String
        Dim Lit5 As String
        Lit1 = "Uno    Dosc   Trec   Cuatroc  Quin   Seisc  Setec  Ochoc  Novec  "
        Lit2 = "Diez     Veinte   Treinta  Cuarenta CincuentaSesenta  Setenta  Ochenta  Noventa  "
        Lit3 = "Once      Doce      Trece     Catorce   Quince    Dieciseis DiecisieteDieciocho Diecinueve"
        Lit4 = "Uno   Dos   Tres  CuatroCinco Seis  Siete Ocho  Nueve "
        Lit5 = "Millon    Billon    Trillon   CuatrillonQuintillon"
        'Proceso Input = Num , Output = Let

        cLET = ""

        'Dim NUM As Double
        'NUM = Val(NUMx)

        If num > CStr(0.99) Then
            'Separa los Enteros en una Cadena de Caracteres
            If InStr(1, Trim(Str(CDbl(num))), ".", 0) > 0 Then
                cWork = Mid(Trim(Str(CDbl(num))), 1, InStr(1, Trim(Str(CDbl(num))), ".", 0) - 1)
            Else
                cWork = Str(CDbl(num))
            End If
            nMODULUS = Int(Len(Trim(cWork)) / 3)
            nMODULUS = Len(Trim(cWork)) - (nMODULUS * 3)

            If nMODULUS > 0 Then
                cWork = New String("0", 3 - nMODULUS) & Trim(cWork)
            End If

            nK = (Len(Trim(cWork)) / 3) - 1
            'Procesa de Mil en Mil
            nI = 1
            Do While nI < Len(Trim(cWork)) - 1
                cCENTENA = Mid(Trim(cWork), nI, 1)
                cDECENA = Mid(Trim(cWork), nI + 1, 1)
                cUNIDAD = Mid(Trim(cWork), nI + 2, 1)
                'Centenas
                If cCENTENA <> "0" Then
                    If cCENTENA = "1" Then
                        cLET = cLET & "Cien "
                        If cDECENA <> "0" Or cUNIDAD <> "0" Then
                            cLET = Mid(cLET, 1, Len(cLET) - 1) & "to "
                        End If
                    Else
                        cLET = cLET & Trim(Mid(Lit1, ((Val(cCENTENA) - 1) * 7) + 1, 7)) & "ientos "
                    End If
                End If
                'Decenas
                If cDECENA <> "0" Then
                    If cDECENA = "1" And cUNIDAD <> "0" Then
                        If ((Val(cUNIDAD) - 1) * 10) + 1 > 0 Then cLET = cLET & Trim(Mid(Lit3, ((Val(cUNIDAD) - 1) * 10) + 1, 10))
                    Else
                        If ((Val(cDECENA) - 1) * 9) + 1 > 0 Then cLET = cLET & Trim(Mid(Lit2, ((Val(cDECENA) - 1) * 9) + 1, 9))
                    End If
                End If
                'Unidades
                If cUNIDAD <> "0" Then
                    If cDECENA > "1" Then
                        cLET = Mid(cLET, 1, Len(cLET) - 1) & "i"
                        If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET & LCase(Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6)))
                    Else
                        If cDECENA < "1" Then
                            If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET & Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6))
                        End If
                    End If
                End If
                cLET = cLET & " "
                'Pone Miles o Millones
                If nK > 0 Then
                    If cCENTENA & cDECENA & cUNIDAD = "001" Then
                        cLET = Mid(cLET, 1, Len(cLET) - 2) & " "
                    End If
                    nMODULUS = Int(nK / 2)
                    nMODULUS = nK - (nMODULUS * 2)
                    If nMODULUS = 0 Then
                        cLET = cLET & Trim(Mid(Lit5, (((nK / 2) - 1) * 10) + 1, 10))
                        If cCENTENA & cDECENA & cUNIDAD = "001" Or CDbl(num) > 1999999 Then
                            cLET = cLET & "es "
                        Else
                            cLET = cLET & " "
                        End If
                    Else
                        If cCENTENA & cDECENA & cUNIDAD > "000" Then
                            cLET = cLET & "Mil "
                        End If
                    End If
                    nK = nK - 1
                End If
                nI = nI + 3
            Loop
            cLET = cLET & "con "
        End If
        If InStr(1, Trim(Str(CDbl(num))), ".", 0) > 0 Then
            cLET = cLET & Mid(Trim(Str(CDbl(num))), InStr(1, Trim(Str(CDbl(num))), ".", 0) + 1, 2) & "/100" & " "
        Else
            cLET = cLET & "00/100" & " "
        End If
        NUMLET = cLET
    End Function

    Public Function CODIFICA(ByRef cadena As String, ByRef valor As Short) As String
        Dim ciclo, posic As Short
        Dim utl_sal As Short
        Dim cadena_cod, carac, cad As String
        posic = 0 : utl_sal = 0
        carac = "" : cadena_cod = "" : cad = ""
        cadena = UCase(Trim(cadena))
        For ciclo = 1 To Len(cadena)
            carac = Mid(cadena, ciclo, 1)
            If (ciclo Mod 2) = 0 Then
                carac = UCase(carac)
            Else
                carac = LCase(carac)
            End If
            cadena_cod = cadena_cod & carac
        Next ciclo

        For ciclo = 1 To Len(cadena_cod)
            posic = ciclo Mod 7
            carac = Mid(cadena_cod, ciclo, 1)
            Select Case posic
                Case 0
                    carac = Chr(Asc(carac) * 2)
                Case 1
                    carac = Chr(Asc(carac) - valor)
                Case 2
                    carac = Chr(Asc(carac) - (ciclo * 2))
                    utl_sal = Asc(carac)
                Case 3
                    If utl_sal > 10 Then utl_sal = utl_sal - (Int(utl_sal / 10) * 10)
                    carac = Chr(Asc(carac) - valor + utl_sal)
                Case 4
                    carac = Chr(Asc(carac) - ciclo)
                    utl_sal = Asc(carac)
                Case 5
                    If utl_sal > 10 Then utl_sal = utl_sal - (Int(utl_sal / 10) * 10)
                    carac = Chr(Asc(carac) - valor + utl_sal)
            End Select
            cad = cad & carac
        Next ciclo
        CODIFICA = cad
    End Function
    'función que desencripta una cadena
    Public Function DECODIFICA(ByRef cadena As String, ByRef valor As Short) As String
        Dim val_n, ciclo, posic, val_an As Short
        Dim carac, cad As String
        cadena = Trim(cadena)
        cad = ""
        val_n = 0 : val_an = 0
        For ciclo = 1 To Len(cadena)
            carac = Mid(cadena, ciclo, 1)
            posic = ciclo Mod 7
            Select Case posic
                Case 0
                    val_n = Asc(carac) / 2
                Case 1
                    val_n = Asc(carac) + valor
                Case 2
                    val_n = Asc(carac) + (ciclo * 2)
                    val_an = Asc(carac)
                Case 3
                    If val_an > 10 Then val_an = val_an - (Int(val_an / 10) * 10)
                    val_n = Asc(carac) + valor - val_an
                Case 4
                    val_n = Asc(carac) + ciclo
                Case 5
                    If val_an > 10 Then val_an = val_an - (Int(val_an / 10) * 10)
                    val_n = Asc(carac) + valor - val_an
                Case 6
                    val_n = Asc(carac)
            End Select
            cad = cad & Chr(val_n)
        Next ciclo
        DECODIFICA = (cad)
    End Function
    Public Function numero(ByRef Number As Object) As String
        Dim aValor As Double
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Number. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If IsDbNull(Number) Or Len(Trim(Number)) = 0 Then
            aValor = 0
        Else
            If IsNumeric(Number) Then
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Number. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                aValor = Number
            Else
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Number. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                aValor = Val(Number)
            End If
        End If
        numero = Format(aValor, "####,###.00")
    End Function


    Public Function TraeDataSerie(ByRef nsql As String, ByRef vcon As ADODB.Connection) As String
        Dim rsbuscn As New ADODB.Recordset

        rsbuscn = vcon.Execute(nsql)
        If rsbuscn.RecordCount > 0 Then
            TraeDataSerie = rsbuscn.Fields("puntovtadoccorr").Value
        Else
            TraeDataSerie = "1"
        End If
        'UPGRADE_NOTE: El objeto rsbuscn no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsbuscn = Nothing

    End Function

    Public Function VerificaCombo(ByRef xcombo As System.Windows.Forms.ComboBox, ByRef ncadena As String) As Integer
        Dim J As Object
        Dim k As Integer
        On Error GoTo nerror
        VerificaCombo = -1
        If xcombo.Items.Count > 0 Then
            VerificaCombo = 0
            For J = 0 To xcombo.Items.Count - 1
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto J. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                xcombo.SelectedIndex = J
                k = InStr(xcombo.Text, "-")
                If k > 1 Then
                    If Left(xcombo.Text, k - 1) = ncadena Then
                        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto J. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        VerificaCombo = J
                        Exit For
                    End If
                Else
                    If xcombo.Text = ncadena Then
                        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto J. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        VerificaCombo = J
                        Exit For
                    End If
                End If
            Next J

        End If

nerror:
        If Err.Number Then
            MsgBox(Err.Number & "-" & Err.Description)
            Err.Clear()
            Resume Next
        End If
    End Function

    Public Function Escadena(ByRef pdato As Object) As String
        'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If IsDbNull(pdato) Then
            Escadena = ""
        ElseIf Len(Trim(pdato)) = 0 Then
            Escadena = ""
        Else
            Escadena = Trim(pdato)
        End If
    End Function


    Public Function DatoTipoCambio(ByRef xCn As ADODB.Connection, ByRef xfecha As String) As Double
        Dim rs As New ADODB.Recordset
        Dim SQL As String
        SQL = "select tipocambiocompra,tipocambioventa from ct_tipocambio "
        SQL = SQL & "Where tipocambiofecha='" & DateSQL(xfecha) & "'"
        rs = xCn.Execute(SQL)
        If Not (rs.EOF Or rs.BOF) Then
            DatoTipoCambio = CDbl(Format(rs.Fields(1).Value, "#####0.###0"))
        Else
            DatoTipoCambio = CDbl(Format(1, "#####0.###0"))
        End If
        rs = Nothing
    End Function

    Public Function DatoMoneda(ByRef xValor As String) As String
        Dim rmone As New ADODB.Recordset
        DatoMoneda = " "
        rmone = VGCNx.Execute("select * from gr_moneda where monedacodigo='" & xValor & "'")
        If rmone.RecordCount > 0 Then
            DatoMoneda = Escadena(rmone.Fields("monedasimbolo")) & " ."

        End If
        rmone.Close()

    End Function

    Public Function CODIFICASQL(ByRef cadena As String) As String
        Dim ciclo, posic As Short
        Dim utl_sal As Short
        Dim cadena_cod, carac, cad As String
        posic = 0 : utl_sal = 0
        carac = "" : cadena_cod = "" : cad = ""
        cadena = UCase(Trim(cadena))
        For ciclo = 1 To Len(cadena)
            carac = Mid(cadena, ciclo, 1)
            If (ciclo Mod 2) = 0 Then
                carac = UCase(carac)
            Else
                carac = LCase(carac)
            End If
            cadena_cod = cadena_cod & carac
        Next ciclo

        For ciclo = 1 To Len(cadena_cod)
            posic = ciclo Mod 2
            carac = Mid(cadena_cod, ciclo, 1)
            Select Case posic
                Case 0
                    carac = Chr(Asc(carac) * 2)
                Case 1
                    carac = Chr(Asc(carac) - 2)
            End Select
            cad = cad & carac
        Next ciclo
        CODIFICASQL = cad
    End Function

    Public Function DECODIFICASQL(ByRef cadena As String) As String
        Dim val_n, ciclo, posic, val_an As Short
        Dim carac, cad As String
        cadena = Trim(cadena)
        cad = ""
        val_n = 0 : val_an = 0
        For ciclo = 1 To Len(cadena)
            carac = Mid(cadena, ciclo, 1)
            posic = ciclo Mod 2
            Select Case posic
                Case 0
                    val_n = Asc(carac) / 2
                    cad = cad & LCase(Chr(val_n))
                Case 1
                    val_n = Asc(carac) + 2
                    cad = cad & Chr(val_n)
            End Select
        Next ciclo
        DECODIFICASQL = cad
    End Function


    Public Function numeroEntero(ByRef Number As Object) As Double
        If IsDbNull(Number) Or Len(Trim(Number)) = 0 Then
            numeroEntero = 0
        Else
            numeroEntero = Number
        End If
    End Function

    Public Function VerificaDatoExistente(ByRef cn1 As ADODB.Connection, ByRef dato1 As String) As Object
        Dim Rsql1 As ADODB.Recordset
        On Error GoTo errverifica
        Rsql1 = cn1.Execute(dato1)
        If Rsql1.RecordCount > 0 Then
            VerificaDatoExistente = Rsql1.RecordCount
        Else
            VerificaDatoExistente = 0
        End If
        Exit Function
errverifica:
        VerificaDatoExistente = -1
    End Function


    Public Function UltNumeroAuto(ByRef Tabla As String, ByRef op As String, ByRef cnx As ADODB.Connection) As Integer
        Dim RSAUX As ADODB.Recordset
        On Error GoTo errornum
        RSAUX = New ADODB.Recordset
        Select Case op
            Case CStr(1)
                '            rsaux.Open "SELECT Numx=isnull(IDENT_CURRENT('" & TABLA & "'),0)", cnx, adOpenKeyset, adLockReadOnly
                RSAUX.Open("SELECT top 1 Numx=isnull(cabprovinumero,1) from co_sistema ", cnx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        End Select
        If RSAUX.EOF Or RSAUX.BOF Then
            UltNumeroAuto = 1
            Exit Function
        Else
            UltNumeroAuto = RSAUX.Fields("Numx").Value
        End If
        Exit Function
errornum:
        UltNumeroAuto = -1
    End Function


    Public Function Espunto(ByRef texto As Object) As Object
        If Trim(texto) = "." Or Trim(texto) = "-" Then
            Espunto = "0"
        Else
            Espunto = texto
        End If
    End Function
    Public Sub PlanillaTotales(ByRef xrb As ADODB.Recordset, ByRef xcampo As Object, ByRef xdepo As System.Windows.Forms.Label)
        Dim asumar As Double
        asumar = 0
        If xrb.RecordCount > 0 Then
            xrb.MoveFirst()
            Do Until xrb.EOF
                asumar = asumar + CDbl(xrb.Fields(xcampo).Value)
                xrb.MoveNext()
            Loop
        End If
        xdepo.Text = numero(asumar)
    End Sub
    Public Function LeerIni(app As String, lpSectName As String, lpKeyName As String, FileName As String) As String
        Dim lpDefault As String
        Dim temp As New String(Chr(0), 255)
        Dim X As Integer
        lpDefault = FileName
        X = GetPrivateProfileString(lpSectName, lpKeyName, lpDefault, temp, Len(temp), app)
        LeerIni = Left(temp, X)
    End Function
    Public Function Left([Dato] As String, caracteres As Integer) As String
        If caracteres > Len([Dato]) Then caracteres = Len([Dato])
        Left = [Dato].Substring(0, caracteres)
    End Function
    Public Function Right([Dato] As String, caracteres As Integer) As String
        If caracteres > Len([Dato]) Then caracteres = Len([Dato])
        Right = [Dato].Substring(Len([Dato]) - caracteres, caracteres)
    End Function
End Module