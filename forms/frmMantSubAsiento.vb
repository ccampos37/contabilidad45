Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMantSubAsiento
	Inherits System.Windows.Forms.Form
	
	Dim modoinsert As Boolean
	Dim modoedit As Boolean
	Dim rs As New ADODB.Recordset
	Dim rsAsiento As ADODB.Recordset
	
	Private Sub frmMantSubAsiento_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call ConfiguraForm()
        Call MuestraDatosAsiento()
        SSTab1.TabPages.Item(0).Enabled = True

	End Sub
	
	Private Sub frmMantSubAsiento_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        rs = Nothing
        rsAsiento = Nothing
        VGvardllgen = Nothing
	End Sub
	
	Sub ConfiguraForm()
		SSTab1.SelectedIndex = 0
		SSTab1.TabPages.Item(1).Enabled = False
		SSTab1.TabPages.Item(2).Enabled = False
		Ctr_Ayuda1.conexion(VGCNx)
		Ctr_Ayuda2.conexion(VGCNx)
        Ctr_Ayuda1.Filtro = "where asientocodigo<>'00'"
        cAcepta.Enabled = False
		lblNumReg.Text = CStr(Nothing)
        'Me.Width = VB6.TwipsToPixelsX(6825)
        'Me.Height = VB6.TwipsToPixelsY(7815)
	End Sub
	
	Sub MuestraDatosAsiento()
		Dim SQL As String
		rsAsiento = New ADODB.Recordset
		SQL = "SELECT asientocodigo as Codigo,asientodescripcion as Descripción FROM ct_asiento WHERE asientocodigo<>'00' ORDER BY 1"
		rsAsiento = VGCNx.Execute(SQL)
		TDBGrid1.DataSource = rsAsiento
        TDBGrid1.Columns(0).Width = 60
        TDBGrid1.Columns(1).Width = 220
		lblNumReg.Text = CStr(rsAsiento.RecordCount)
	End Sub
	
	Private Sub Ctr_Ayuda1_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_Ayuda1.AlDevolverDato
		Call MuestraDatosSubAsiento()
	End Sub
	
	'FIXIT: Declare 'MuestraDatosSubAsiento' con un tipo de datos de enlace en tiempo de compilación     FixIT90210ae-R1672-R1B8ZE
    Public Sub MuestraDatosSubAsiento()
        Dim SQL As String
        SQL = "SELECT ct_subasiento.subasientocodigo, ct_subasiento.subasientodescripcion,"
        SQL = SQL & "ct_subasiento.subasientoglosa,ct_subasiento.subasientorepitedoc,gr_moneda.monedadescripcion,"
        SQL = SQL & "ct_subasiento.subasientonumcorr01, ct_subasiento.subasientonumcorr02, ct_subasiento.subasientonumcorr03, ct_subasiento.subasientonumcorr04,"
        SQL = SQL & "ct_subasiento.subasientonumcorr05, ct_subasiento.subasientonumcorr06, ct_subasiento.subasientonumcorr07, ct_subasiento.subasientonumcorr08,"
        SQL = SQL & "ct_subasiento.subasientonumcorr09, ct_subasiento.subasientonumcorr10, ct_subasiento.subasientonumcorr11, ct_subasiento.subasientonumcorr12,ct_subasiento.monedacodigo "
        SQL = SQL & "FROM ct_subasiento INNER JOIN gr_moneda ON ct_subasiento.monedacodigo = gr_moneda.monedacodigo "
        SQL = SQL & "INNER JOIN ct_asiento ON ct_subasiento.asientocodigo = ct_asiento.asientocodigo "
        SQL = SQL & "WHERE ct_subasiento.subasientocodigo<>'00' AND "
        SQL = SQL & "ct_subasiento.asientocodigo='" & Trim(Ctr_Ayuda1.xclave) & "' "
        SQL = SQL & "ORDER BY 1,2"
        rs = VGCNx.Execute(SQL)
        TDBGrid3.DataSource = rs
        Call ConfiguraGridSubAsientos()
        If rs.RecordCount <= 0 Then Call LimpiarForm(Me, "ctr_ayuda1")

    End Sub

    Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBotones.Click
        Dim Index As Short = cmdBotones.GetIndex(eventSender)
        Dim J As Short
        Dim spos As Short
        Dim SQL As String

        On Error GoTo X

        Select Case Index
            Case 0 'nuevo
                SSTab1.TabPages.Item(2).Enabled = True
                SSTab1.SelectedIndex = 1
                'Call LimpiarValores

                Call LimpiarForm(Me, "Ctr_Ayuda1")

                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt(0).CtlText = GeneraCodigo(VGCNx, "Select max(subasientocodigo) from ct_subasiento where asientocodigo='" & Ctr_Ayuda1.xclave & "'", "0000")
                txt(0).Focus()
                Call ModoEditable(True, gbDatos, "Ctr_Ayuda1")
                frmbotones.Visible = False
                modoinsert = True
                lblMensaje.Text = "Nuevo"

            Case 1 'modificar
                If TDBGrid1.Row < 0 Then
                    Exit Sub
                End If
                SSTab1.TabPages.Item(2).Enabled = True
                SSTab1.SelectedIndex = 1
                modoedit = True
                frmbotones.Visible = False
                Call ModoEditable(True, gbDatos, "Ctr_Ayuda1")
                lblMensaje.Text = "Editar"

            Case 2 'eliminar
                If MsgBox("Desea eliminar el registro de SubAsiento Nº " & TDBGrid3.Columns(0).Value & "?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "AVISO") = MsgBoxResult.Yes Then
                    SQL = "DELETE FROM CT_SUBASIENTO WHERE subasientocodigo='" & Trim(TDBGrid3.Columns(0).Value) & "' AND "
                    SQL = SQL & "asientocodigo='" & Trim(Ctr_Ayuda1.xclave) & "'"
                    VGCNx.Execute(SQL)
                    Call MuestraDatosSubAsiento()
                End If

            Case 3 'imprimir
                Call Impresion("rptSubAsiento.rpt")

            Case 4 ' salir
                Me.Close()
        End Select

        Exit Sub

X:
        If Index = 2 And Err.Number = -2147217873 Then
            MsgBox("Registro no podrá Eliminarse mientras exista Información en la Tablas Relacionadas", MsgBoxStyle.Information, Text)
        Else
            MsgBox("Error inesperado: " & Err.Description & "  " & Err.Number, MsgBoxStyle.Information, Text)
        End If

    End Sub

    Private Sub cAcepta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cAcepta.Click
        Dim SQL As String
        On Error GoTo X

        VGvardllgen = New dllgeneral.dll_general
        VGCNx.BeginTrans()

        If modoinsert = True Then
            SQL = "INSERT INTO CT_SUBASIENTO (subasientocodigo,asientocodigo,monedacodigo,subasientodescripcion,"
            SQL = SQL & "subasientonumcorr01,subasientonumcorr02,subasientonumcorr03,subasientonumcorr04,subasientonumcorr05,subasientonumcorr06,subasientonumcorr07,subasientonumcorr08,subasientonumcorr09,subasientonumcorr10,subasientonumcorr11,subasientonumcorr12,subasientoglosa,subasientorepitedoc,usuariocodigo,fechaact) "
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            SQL = SQL & "VALUES ('" & txt(0).CtlText & "','" & Ctr_Ayuda1.xclave & "','" & Ctr_Ayuda2.xclave & "','" & Trim(UCase(txt(1).CtlText)) & "',"
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(4).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(3).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & VGvardllgen.ESNULO(txt(2).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(3).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(4).CtlText, 0) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(7).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(6).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & VGvardllgen.ESNULO(txt(5).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(6).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(7).CtlText, 0) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(13).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(12).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(11).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(10).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(9).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & VGvardllgen.ESNULO(txt(8).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(9).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(10).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(11).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(12).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(13).CtlText, 0) & ",'" & txt(14).CtlText & "'," & chk.CheckState & ",'"
            SQL = SQL & VGusuario & "','" & VB6.Format(Today, "dd/mm/yyyy") & "')"

        ElseIf modoedit = True Then
            SQL = "UPDATE CT_SUBASIENTO SET monedacodigo='" & Ctr_Ayuda2.xclave & "',"
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            SQL = SQL & "subasientodescripcion='" & Trim(UCase(txt(1).CtlText)) & "',"
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(4).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(3).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & "subasientonumcorr01=" & VGvardllgen.ESNULO(txt(2).CtlText, 0) & ",subasientonumcorr02=" & VGvardllgen.ESNULO(txt(3).CtlText, 0) & ",subasientonumcorr03=" & VGvardllgen.ESNULO(txt(4).CtlText, 0) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(7).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(6).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & "subasientonumcorr04=" & VGvardllgen.ESNULO(txt(5).CtlText, 0) & ",subasientonumcorr05=" & VGvardllgen.ESNULO(txt(6).CtlText, 0) & ",subasientonumcorr06=" & VGvardllgen.ESNULO(txt(7).CtlText, 0) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(10).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(9).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & "subasientonumcorr07=" & VGvardllgen.ESNULO(txt(8).CtlText, 0) & ",subasientonumcorr08=" & VGvardllgen.ESNULO(txt(9).CtlText, 0) & ",subasientonumcorr09=" & VGvardllgen.ESNULO(txt(10).CtlText, 0) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(13).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(12).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & "subasientonumcorr10=" & VGvardllgen.ESNULO(txt(11).CtlText, 0) & ",subasientonumcorr11=" & VGvardllgen.ESNULO(txt(12).CtlText, 0) & ",subasientonumcorr12=" & VGvardllgen.ESNULO(txt(13).CtlText, 0) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            SQL = SQL & "subasientoglosa='" & txt(14).CtlText & "',subasientorepitedoc=" & chk.CheckState & ","
            SQL = SQL & "usuariocodigo='" & VGusuario & "',fechaact='" & VB6.Format(Today, "dd/mm/yyyy") & "' "
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            SQL = SQL & "WHERE subasientocodigo='" & txt(0).CtlText & "' AND asientocodigo='" & Ctr_Ayuda1.xclave & "'"
        End If

        VGCNx.Execute(SQL)
        VGCNx.CommitTrans()

        'UPGRADE_NOTE: El objeto VGvardllgen no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        VGvardllgen = Nothing
        frmbotones.Visible = True
        modoinsert = False : modoedit = False : lblMensaje.Text = CStr(Nothing)
        Call MuestraDatosSubAsiento()
        cAcepta.Enabled = False
        'UPGRADE_NOTE: El objeto VGvardllgen no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        VGvardllgen = Nothing
        Call ModoEditable(False, Me, "")
        Exit Sub

X:
        If Err.Number = -2147217873 Then
            MsgBox("Esta intentando registrar Código de SubAsiento Existente ", MsgBoxStyle.Information, Text)
            txt(0).Focus()
        Else
            MsgBox("Error inesperado: " & Err.Number & " " & Err.Description, MsgBoxStyle.Information, Text)
        End If
        VGCNx.RollbackTrans()

    End Sub

    Private Sub cCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cCancela.Click
        frmbotones.Visible = True
        modoinsert = False : modoedit = False : lblMensaje.Text = CStr(Nothing)
        cAcepta.Enabled = False
        SSTab1.SelectedIndex = 0
        SSTab1.TabPages.Item(0).Enabled = True
        SSTab1.TabPages.Item(1).Enabled = False
        SSTab1.TabPages.Item(2).Enabled = False
    End Sub

    Private Sub SSTab1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SSTab1.SelectedIndexChanged
        Static PreviousTab As Short = SSTab1.SelectedIndex()
        If PreviousTab = 0 Then SSTab1.TabPages.Item(PreviousTab).Enabled = False
        PreviousTab = SSTab1.SelectedIndex()
    End Sub

    Private Sub TDBGrid1_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_HeadClickEvent) Handles TDBGrid1.HeadClick
        On Error Resume Next
        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If IsNothing(rs.Sort) Then
            rs.Sort = TDBGrid1.Columns.Item(eventArgs.ColIndex).DataField & " asc"
        ElseIf VB.Right(rs.Sort, 3) = "asc" Then
            rs.Sort = TDBGrid1.Columns.Item(eventArgs.ColIndex).DataField & " desc"
        ElseIf VB.Right(rs.Sort, 4) = "desc" Then
            rs.Sort = TDBGrid1.Columns.Item(eventArgs.ColIndex).DataField & " asc"
        End If
        'UPGRADE_NOTE: Refresh se actualizó a CtlRefresh. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        TDBGrid1.Refresh()
    End Sub

    Private Sub TDBGrid1_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBGrid1.DblClick
        If rsAsiento.RecordCount > 0 Then
            SSTab1.TabPages.Item(1).Enabled = True
            SSTab1.TabPages.Item(2).Enabled = False
            SSTab1.SelectedIndex = 1
            Ctr_Ayuda1.xclave = TDBGrid1.Columns(0).Text : Ctr_Ayuda1.Ejecutar()
            Ctr_Ayuda1.CtlEnabled = False
            Call ModoEditable(False, gbDatos, "Ctr_Ayuda1")
            cAcepta.Enabled = False
        End If
    End Sub

    'FIXIT: Declare 'LastRow' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
    Private Sub TDBGrid2_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_RowColChangeEvent) Handles TDBGrid3.RowColChange
        Call EditarSubAsiento()
    End Sub

    Private Sub txt_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Change
        Dim Index As Short = txt.GetIndex(eventSender)
        If modoinsert = True Or modoedit = True Then
            cAcepta.Enabled = ValidaDataIngreso()
        End If
    End Sub

    'UPGRADE_WARNING: El evento chk.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chk_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chk.CheckStateChanged
        If modoinsert = True Or modoedit = True Then cAcepta.Enabled = ValidaDataIngreso()
    End Sub

    Private Sub txt_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyPressEvent) Handles txt.KeyPressEvent
        Dim Index As Short = txt.GetIndex(eventSender)
        If eventArgs.KeyAscii = 13 And Index = 15 Then
            cAcepta.Focus()
            Call cAcepta_Click(cAcepta, New System.EventArgs())
        End If
    End Sub

    Private Sub txt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Leave
        Dim Index As Short = txt.GetIndex(eventSender)
        If Index = 0 Then
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            If Not IsDbNull(txt(0).CtlText) Then txt(0).CtlText = VB6.Format(txt(0).CtlText, "0000")
        Else
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            txt(Index).CtlText = UCase(txt(Index).CtlText)
        End If
    End Sub

    Sub EditarSubAsiento()
        Dim i As Short

        If rs.RecordCount > 0 Then
            With TDBGrid3
                For i = 2 To 13
                    txt(i).CtlText = TDBGrid3.Columns(i + 3).Value
                Next
                txt(0).CtlText = .Columns(0).Value
                txt(1).CtlText = .Columns(1).Value
                txt(14).CtlText = .Columns(2).Value
                chk.CheckState = IIf(.Columns(3).Value = 0, 0, 1)
                Ctr_Ayuda2.xclave = .Columns(17).Value : Ctr_Ayuda2.Ejecutar()
            End With

        End If
    End Sub

    Sub ConfiguraGridSubAsientos()
        Dim i As Short
        With TDBGrid3
            .Columns(0).Width = 60
            .Columns(1).Width = 220
            .Columns(2).Width = 80
            .Columns(3).Width = 100
            .Columns(4).Width = 90
            For i = 5 To 16
                .Columns(i).Width = 90
            Next
        End With

    End Sub
	
	Function ValidaDataIngreso() As Boolean
		Dim i As Short
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If IsNothing(Ctr_Ayuda1.xclave) Then
			ValidaDataIngreso = False
			Exit Function
		End If
		
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If IsNothing(Ctr_Ayuda2.xclave) Then
			ValidaDataIngreso = False
			Exit Function
		End If
		
		For i = 0 To 1
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If IsNothing(txt(i).CtlText) Then
				ValidaDataIngreso = False
				Exit Function
			End If
			
		Next 
		
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If IsNothing(txt(14).CtlText) Then
			ValidaDataIngreso = False
			Exit Function
		End If
		
		ValidaDataIngreso = True
	End Function
	
	
	'Private Function LimpiarValores()
	'Dim I As Integer
	' Ctr_Ayuda2.xclave = Empty: Ctr_Ayuda2.Ejecutar
	' For I = 0 To 14
	'  txt(I).Text = Empty
	' Next
	' chk.Value = 0
	'
	'End Function

    Private Sub TDBGrid1_AfterColUpdate(ByVal sender As System.Object, ByVal e As AxTrueOleDBGrid70.TrueDBGridEvents_AfterColUpdateEvent) Handles TDBGrid1.AfterColUpdate

    End Sub
End Class