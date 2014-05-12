Option Strict Off
Option Explicit On
Imports Contabilidad.ModFuncionesGen
Module FuncionesContab
    Dim ndiaMes(12) As Short
    Dim cdesMes(12) As String
    Private Declare Function GetComputerName Lib "kernel32" Alias "GetComputerNameA" (ByVal lpBuffer As String, ByRef nSize As Integer) As Integer

    Sub Impresion(ByRef cNombreReporte As String)
        On Error GoTo x
        With MDIPrincipal.cryRpt
            .Reset()
            .Destination = Crystal.DestinationConstants.crptToWindow
            .WindowState = Crystal.WindowStateConstants.crptMaximized
            .ReportFileName = VGParamSistem.RutaReport & VGParamSistem.CarpetaReportes & cNombreReporte
            '    .LogOnServer "pdssql.dll", VGParamSistem.Servidor, VGParamSistem.BDEmpresa, VGParamSistem.UsuarioReporte, VGParamSistem.Pwd
            If CDbl(VGsql) = 1 Then
                .Connect = "Provider=SQLOLEDB;Password=" & VGParamSistem.PwdGEN & ";Persist Security Info=True;User ID=" & VGParamSistem.UsuarioGEN & ";Initial Catalog=" & VGParamSistem.BDEmpresaGEN & ";SERVER=" & VGParamSistem.ServidorGEN
            Else
                .Connect = VGCadenaReport2
            End If
            .DiscardSavedData = True

            If cNombreReporte = "rptTipoCambio.rpt" Then
                .set_Formulas(0, "@Mes=" & CShort(VGParamSistem.Mesproceso))
                .set_Formulas(1, "@Mesanno='" & DesMes(VGParamSistem.Mesproceso) & "-" & VGParamSistem.Anoproceso & "'")
                .set_Formulas(2, "@Anual='" & VGParamSistem.Anoproceso & "'")
            End If
            .Action = 1
        End With
        Exit Sub
x:
        MsgBox("Error inesperado: " & Err.Number & "  " & Err.Description, MsgBoxStyle.Exclamation)
    End Sub

    Private Sub CrystOrden(ByRef cry As AxCrystal.AxCrystalReport, ByRef cad As String)
        Dim pos, I As Short

        Dim valor As String
        Do While True
            pos = InStr(1, cad, ",", CompareMethod.Text)
            I = 0
            If pos = 0 Then Exit Do
            valor = Left(cad, pos - 1)
            cry.set_SortFields(I, valor)
            I = I + 1
            cad = Right(cad, Len(cad) - pos)
        Loop
    End Sub

    Public Sub ParametroCuenta(ByRef Index As Short)
        Dim rs As ADODB.Recordset
        Dim cuenta As String = ""
        Dim costos As String = ""
        Dim I As Short
        Dim J As Short
        Dim configuracion As String
        Dim num1 As Short
        Dim num2 As Short

        Select Case Index
            Case 0
                rs = New ADODB.Recordset
                rs = VGCNx.Execute("SELECT sistemaconfiguracuenta,sistemaconfiguracentrocostos FROM ct_sistema")

                If Not (rs.BOF Or rs.EOF) Then
                    'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    cuenta = IIf(IsDBNull(rs.Fields(0).Value), "", Trim(rs.Fields(0).Value))
                    'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    costos = IIf(IsDBNull(rs.Fields(1).Value), "", Trim(rs.Fields(1).Value))
                    'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
                    rs = Nothing
                Else
                    configuracion = Trim(rs.Fields(1).Value)
                End If
            Case 1
                cuenta = strvalor
                costos = strvalor1
        End Select
        For I = 1 To Len(costos)
            If Mid(costos, I, 1) = "*" Then num2 = num2 + 1
        Next
        ReDim VG_cNIVELES(Len(costos) - num2)
        J = 0
        For I = 1 To Len(costos) Step 2
            VG_cNIVELES(J) = CShort(Mid(costos, I, 1))
            J = J + 1
        Next
        VGnumnivelescentrocosto = Len(costos) - num2

        ' ****

        For I = 1 To Len(cuenta)
            If Mid(cuenta, I, 1) = "*" Then num1 = num1 + 1
        Next
        ReDim VG_aNIVELES(Len(cuenta) - num1)
        J = 0
        For I = 1 To Len(cuenta) Step 2
            VG_aNIVELES(J) = CShort(Mid(cuenta, I, 1))
            J = J + 1
        Next
        VGnumnivelescuenta = Len(cuenta) - num1

    End Sub

    Public Sub CargarParametrosContabilidad()
        Dim rsaux As ADODB.Recordset
        rsaux = New ADODB.Recordset
        rsaux = VGCNx.Execute(" Select top 1 * from ct_sistema")
        If rsaux.RecordCount = 0 Then Exit Sub
        VGParametros.monedabase = rsaux.Fields("monedacodigo").Value
        VGParametros.IGV = CDbl(Trim(rsaux.Fields("sistemavalorigv").Value))
        VGParametros.CuadreAsiento = rsaux.Fields("sistemaestcuadreasiento").Value
        VGParametros.impresionalta = rsaux.Fields("sistematipoimpresion").Value
        VGParametros.sistemamonista = rsaux.Fields("sistemamonista").Value
        VGParametros.sistemactaajustedeb = RTrim(rsaux.Fields("sistemactaajustedeb").Value)
        VGParametros.sistemactaajustehab = RTrim(rsaux.Fields("sistemactaajustehab").Value)
        VGParametros.AsientoAutoxCCostos = ESNULO(RTrim(rsaux.Fields("asientoAutoCCostos").Value), 0)
        VGParametros.cuentadeCostos = RTrim(ESNULO(rsaux.Fields("cuentacodigoCostos"), 0))
        VGParametros.ingresoformatorapido = ESNULO(rsaux.Fields("ingresoformatorapido"), 0)


        VGParametros.asientocodigo = rsaux.Fields("sistemaasientocodigo").Value
        VGParametros.subasientocodigo = rsaux.Fields("sistemasubasientocodigo").Value

        If IsNumeric(VGParamSistem.Anoproceso) And IsNumeric(VGParamSistem.Mesproceso) Then
            SQL = "select * from ct_cierremensual where empresacodigo='" & VGParametros.empresacodigo & "' and " & " anio='" & VGParamSistem.Anoproceso & "' and mes=" & Trim(VGParamSistem.Mesproceso) & " "
            rsaux = VGCNx.Execute(SQL)
            If rsaux.RecordCount > 0 Then VGParametros.cierremes = IIf(rsaux.Fields("Contabilidad").Value = True, True, False)
            If VGtipolicencia = "" Then
                VGParametros.cierremes = True
                MsgBox("Licencia no AUTORIZADA, comucarse a ccampos37@yahoo.com ( PROPIETARIO, NO PIRATA ")
                Exit Sub
            Else
                If Not VGtipolicencia = "P" Then
                    If VGtipolicencia = "T" Then
                        If VGfechalicencia < VGParamSistem.FechaTrabajo Then
                            VGParametros.cierremes = True
                            MsgBox("Licencia caduco su fecha de evaluacion , comunicarse con sistemas( ccampos37@yahoo.com - PROPIETARIO )  ")
                            Exit Sub
                        End If
                    Else
                        VGParametros.cierremes = True
                        MsgBox("Licencia no AUTORIZADA, comucarse a ccampos37@yahoo.com ( PROPIETARIO) , NO PIRATA ")
                        Exit Sub
                    End If
                End If
            End If
        End If

        Call ParametroCuenta(0)

        MDIPrincipal.StatusBar1.Items.Item(5).Text = "Servidor (" & VGParamSistem.Servidor & ")"
        '        MDIPrincipal.StatusBar1.Items.Item(6).Text = "Base de Datos (" & VGParamSistem.BDEmpresa & ")"

    End Sub
    Public Function Coversion(ByRef MonOrigi As String, ByRef VCambio As Double, ByRef monto As Double) As Object
        'FCP
        Dim valor As Double
        On Error GoTo errtext
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Coversion. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Coversion = 0
        If MonOrigi = VGParametros.monedabase Then
            valor = monto / VCambio ' Soles ==> a Dolares
        Else
            valor = monto * VCambio ' Dolares ==> a Soles
        End If
        Coversion = System.Math.Round(valor, 2)
        Exit Function
errtext:
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Coversion. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Coversion = 0
    End Function


    Public Sub EjecutarLote(ByRef RichTextBox1 As System.Windows.Forms.RichTextBox, ByRef cnx As ADODB.Connection)
        'Funcion Creada por fernando cossio
        'Ejecuta scrip de lotes generadas en la secuencia de comandos del SQL
        Dim pos, ini As Integer
        Dim I As Short
        Dim cad As String
        Dim Cont, longi As Integer
        Dim conpos As Integer
        Dim sqlcad As String
        pos = 1
        ini = 1
        On Error GoTo error_Renamed
        longi = Len(RichTextBox1.Text)
        Do While pos <> 0
            pos = InStr(pos + 2, RichTextBox1.Text, "GO", CompareMethod.Text)
            sqlcad = ""
            If pos + 2 > longi Then Exit Do
            If pos = 0 Then Exit Do
            If Asc(Mid(RichTextBox1.Text, pos - 1, 1)) = 10 And Asc(Mid(RichTextBox1.Text, pos + 2, 1)) = 13 Then
                Cont = Cont + 1
                sqlcad = Mid(RichTextBox1.Text, ini, pos - (ini + 2))
                RichTextBox1.SelectionStart = pos : RichTextBox1.SelectionLength = 2
                ini = pos + 2
                cnx.Execute(sqlcad)
            End If
        Loop
error_Renamed:
        MsgBox("Error inesperado: " & Err.Number & "  " & Err.Description, MsgBoxStyle.Exclamation)

        Exit Sub
        Resume
    End Sub

    Public Sub ModoEditable(ByRef flagModo As Boolean, ByRef Obj As Object, ByRef cNameCtrX As String, Optional ByRef Ind As Integer = -1)

        Dim Control As Object
        Dim objtab, objintab As Control

        Select Case Obj.GetType.ToString

            Case "System.Windows.Forms.Form"

                For Each Control In Obj.Controls

                    If UCase(Control.Name) <> UCase(cNameCtrX) Then
                        If TypeOf Control Is System.Windows.Forms.TextBox Then Control.Enabled = flagModo
                        If TypeOf Control Is AxTextFer.AxTxFer Then Control.Enabled = flagModo
                        If TypeOf Control Is System.Windows.Forms.CheckBox Then Control.Enabled = flagModo
                        If TypeOf Control Is Axctrlayuda_f.AxCtr_Ayuda Then Control.Enabled = flagModo

                    End If
                Next

            Case "System.Windows.Forms.TabControl"



                For Each Control In Obj.tabpages
                    For Each objtab In Control.Controls
                        For Each objintab In objtab.Controls
                            objintab.Enabled = flagModo
                        Next
                    Next
                Next

            Case "System.Windows.Forms.GroupBox"

                Obj.enabled = flagModo



        End Select

    End Sub
    Public Sub LimpiarForm(ByRef Formu As System.Windows.Forms.Form, ByRef cNameCtrX As String)

        Dim Control As System.Windows.Forms.Control
        For Each Control In Formu.Controls
            If UCase(Control.Name) <> UCase(cNameCtrX) Then
                If TypeOf Control Is System.Windows.Forms.TextBox Then Control.Text = CStr(Nothing)
                If TypeOf Control Is AxTextFer.AxTxFer Then Control.Text = CStr(Nothing)

            End If
        Next Control
    End Sub

    Public Function GeneraCodigo(ByRef Conex As ADODB.Connection, ByRef csql As String, ByRef cNumCeros As String) As String
        Dim rsX As ADODB.Recordset
        rsX = New ADODB.Recordset
        rsX = Conex.Execute(csql)
        'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        GeneraCodigo = Format(Val(IIf(IsDBNull(rsX.Fields(0).Value), 0, rsX.Fields(0).Value)) + 1, cNumCeros)
        'UPGRADE_NOTE: El objeto rsX no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsX = Nothing
    End Function

    Public Sub PropCrystal(ByRef CrystalRpt As AxCrystal.AxCrystalReport)
        CrystalRpt.WindowShowCancelBtn = True
        CrystalRpt.WindowShowCloseBtn = True
        CrystalRpt.WindowShowExportBtn = True
        CrystalRpt.WindowShowGroupTree = True
        CrystalRpt.WindowShowNavigationCtls = True
        CrystalRpt.WindowShowPrintBtn = True
        CrystalRpt.WindowShowPrintSetupBtn = True
        CrystalRpt.WindowShowProgressCtls = True
        CrystalRpt.WindowShowSearchBtn = True
        CrystalRpt.WindowShowZoomCtl = True
    End Sub

    Public Function ValidaAsientos() As Boolean
        Dim SQL As String
        SQL = "SELECT ct_asiento.asientocodigo as Código, ct_asiento.asientodescripcion as Descripción "
        SQL = SQL & "FROM ct_asiento "
        SQL = SQL & "WHERE ct_asiento.asientocodigo<>'00'"
        If VerificaDatoExistente(VGCNx, SQL) <= 0 Then
            ValidaAsientos = False
            MsgBox("Faltan Registrar los Asientos por la Opción correspondiente", MsgBoxStyle.Information, "Sistema Contable")
        Else
            ValidaAsientos = True
        End If
    End Function

    Public Function ValidaSubAsientos(ByRef xCodAsiento As String) As Boolean
        Dim SQL As String
        SQL = "SELECT subasientocodigo FROM ct_subasiento WHERE subasientocodigo<>'00' "
        SQL = SQL & "AND asientocodigo like '" & xCodAsiento & "%'"

        '  VGvardllgen = New dllgeneral.dll_general
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VerificaDatoExistente(VGCNx, SQL). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If VerificaDatoExistente(VGCNx, SQL) <= 0 Then
            ValidaSubAsientos = False
            MsgBox("Faltan registrar los SubAsientos que corresponden al Asiento Nº " & xCodAsiento, MsgBoxStyle.Information, "Sistema Contable")
        Else
            ValidaSubAsientos = True
        End If
        'UPGRADE_NOTE: El objeto VGvardllgen no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        '  VGvardllgen = Nothing
    End Function

    Public Sub CancelaDocumentos()
        On Error GoTo Mayor
        Dim x As Integer
        Dim NombrePC As String
        Randomize() 'Inicializa el generador de números aleatorios.
        'FIXIT: Reemplazar la función 'Str' con la función 'Str$'.                                 FixIT90210ae-R9757-R1B8ZE
        NombrePC = Trim(Str(CInt(Rnd() * 10000000)))
        'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        VGCNx.BeginTrans()
        VGCommandoSP = New ADODB.Command
        VGCommandoSP.let_ActiveConnection(VGGeneral)
        VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        VGCommandoSP.CommandText = "ct_ProcCanc_pro"
        VGCommandoSP.Parameters.Refresh()
        With VGCommandoSP
            .Parameters("@BaseConta").Value = VGParamSistem.BDEmpresa
            .Parameters("@empresa").Value = VGParametros.empresacodigo
            .Parameters("@Anno").Value = VGParamSistem.Anoproceso
            .Parameters("@Mes").Value = VGParamSistem.Mesproceso
            .Parameters("@NombrePC").Value = NombrePC
            .Execute(x)
        End With
        VGCNx.CommitTrans()
        'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
        MsgBox("Se Cancelo los Documentos Satisfactoriamente  " & Chr(13) & "Items Afectados ", MsgBoxStyle.Information)
        Exit Sub
Mayor:
        'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
        VGCNx.RollbackTrans()
        MsgBox("No se pudo Cancelar los Documentos " & Chr(13) & Err.Description, MsgBoxStyle.Exclamation)
    End Sub
End Module