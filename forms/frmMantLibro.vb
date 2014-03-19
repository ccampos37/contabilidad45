Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMantLibro
	Inherits System.Windows.Forms.Form
	
	Dim modoinsert As Boolean
	Dim modoedit As Boolean
	Dim rs As New ADODB.Recordset
	Dim rsLibro As ADODB.Recordset
	
	Private Sub frmMantLibro_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call ConfiguraForm()
        Call MuestraDatosLibro()
    End Sub
	
	Private Sub frmMantLibro_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		'UPGRADE_NOTE: El objeto rsLibro no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsLibro = Nothing
		'UPGRADE_NOTE: El objeto VGvardllgen no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		VGvardllgen = Nothing
	End Sub
	
	Sub ConfiguraForm()
		SSTab1.SelectedIndex = 0
		SSTab1.TabPages.Item(1).Enabled = False
		SSTab1.TabPages.Item(2).Enabled = False
		cAcepta.Enabled = False
		lblNumReg.Text = CStr(Nothing)
		Me.Width = VB6.TwipsToPixelsX(7050)
		Me.Height = VB6.TwipsToPixelsY(6255)
	End Sub
	
	'FIXIT: Declare 'MuestraDatosLibro' con un tipo de datos de enlace en tiempo de compilación     FixIT90210ae-R1672-R1B8ZE
    Public Sub MuestraDatosLibro()
        Dim SQL As String


        SQL = "SELECT A.librocodigo, A.librodescripcion,A.flagcontrol,B.libronumcorr01,"
        SQL = SQL & "B.libronumcorr02, B.libronumcorr03, B.libronumcorr04,B.libronumcorr05,"
        SQL = SQL & "B.libronumcorr06, B.libronumcorr07, B.libronumcorr08,B.libronumcorr09,"
        SQL = SQL & "B.libronumcorr10 , B.libronumcorr11, B.libronumcorr12 "
        SQL = SQL & "FROM  ct_libro A left join ct_librocorre B on b.empresacodigo='" & VGParametros.empresacodigo & "' and a.librocodigo<>'00' "
        SQL = SQL & "and A.librocodigo=B.librocodigo and B.libroanno='" & VGParamSistem.Anoproceso & "'"

        rs = VGCNx.Execute(SQL)
        TDBGridAsientos2.DataSource = rs
        Call ConfiguraGridLibros()
        lblNumReg.Text = CStr(rs.RecordCount)

        SSTab1.TabPages.Item(0).Enabled = True

    End Sub

    Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBotones.Click
        Dim Index As Short = cmdBotones.GetIndex(eventSender)
        Dim J As Short
        Dim spos As Short
        Dim SQL As String
        Dim SQL1 As String

        On Error GoTo x

        Select Case Index
            Case 0 'nuevo
                SSTab1.SelectedIndex = 1
                SSTab1.TabPages.Item(1).Enabled = True
                SSTab1.TabPages.Item(2).Enabled = True
                modoinsert = True
                Call LimpiarForm(Me, "")
                txt(0).Focus()
                Call ModoEditable(True, Me, "")
                frmbotones.Visible = False

            Case 1 'modificar
                If TDBGridAsientos2.Row < 0 Then
                    Exit Sub
                End If
                SSTab1.SelectedIndex = 1
                SSTab1.TabPages.Item(1).Enabled = True
                SSTab1.TabPages.Item(2).Enabled = True
                modoedit = True
                frmbotones.Visible = False
                Call Editarlibro()
                Call ModoEditable(True, Me, "")

            Case 2 'eliminar
                If MsgBox("Desea eliminar el registro de Libro Nº " & TDBGridAsientos2.Columns(0).Value & "?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "AVISO") = MsgBoxResult.Yes Then
                    'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    SQL = "DELETE FROM CT_LIBRO WHERE librocodigo='" & txt(0).CtlText & "'"
                    SQL1 = "DELETE FROM CT_LIBROCORRE WHERE "
                    'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    SQL1 = SQL1 & " empresacodigo='" & VGParametros.empresacodigo & "' and librocodigo='" & txt(0).CtlText & "' AND libroanno='" & VGParamSistem.Anoproceso & "'"
                    VGCNx.Execute(SQL)
                    VGCNx.Execute(SQL1)
                    Call MuestraDatosLibro()
                End If

            Case 3 'imprimir
                Call Impresion("rptlibro.rpt")

            Case 4 ' salir
                Me.Close()
        End Select

        Exit Sub

x:
        If Index = 2 And Err.Number = -2147217873 Then
            MsgBox("Registro no podrá Eliminarse mientras exista Información en la Tablas Relacionadas", MsgBoxStyle.Information, Text)
        Else
            MsgBox("Error inesperado: " & Err.Description & "  " & Err.Number, MsgBoxStyle.Information, Text)
        End If

    End Sub

    Private Sub cAcepta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cAcepta.Click
        Dim SQL As String
        Dim SQL1 As String
        Dim xx As New ADODB.Recordset
        On Error GoTo x
        Dim Cont As Short
        VGvardllgen = New dllgeneral.dll_general
        VGCNx.BeginTrans()
        Cont = 0
        If modoinsert = True Then
            SQL = "INSERT INTO CT_libro (librocodigo,librodescripcion,flagcontrol,"
            SQL = SQL & "libronumcorr01,libronumcorr02,libronumcorr03,libronumcorr04,libronumcorr05,libronumcorr06,libronumcorr07,libronumcorr08,libronumcorr09,libronumcorr10,libronumcorr11,libronumcorr12,usuariocodigo,fechaact) "
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            SQL = SQL & "VALUES ('" & txt(0).CtlText & "','" & txt(1).CtlText & "'," & chk(0).CheckState & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(5).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(4).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & VGvardllgen.ESNULO(txt(3).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(4).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(5).CtlText, 0) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(8).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(7).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & VGvardllgen.ESNULO(txt(6).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(7).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(8).CtlText, 0) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(14).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(13).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(12).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(11).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(10).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & VGvardllgen.ESNULO(txt(9).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(10).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(11).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(12).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(13).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(14).CtlText, 0) & ",'"
            SQL = SQL & VGusuario & "','" & VB6.Format(Today, "dd/mm/yyyy") & "')"

            SQL1 = " select  * from CT_libroCorre where empresacodigo='" & VGParametros.empresacodigo & "'"
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            SQL1 = SQL1 & " and librocodigo='" & txt(0).CtlText & "' and libroanno='" & VGParamSistem.Anoproceso & "'"
            'UPGRADE_NOTE: El objeto xx no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            xx = Nothing
            xx = VGCNx.Execute(SQL1)
            If xx.RecordCount = 0 Then
                Cont = 1
            End If
            SQL1 = "INSERT INTO CT_libroCorre (empresacodigo,librocodigo,libroanno,"
            SQL1 = SQL1 & "libronumcorr01,libronumcorr02,libronumcorr03,libronumcorr04,libronumcorr05,libronumcorr06,libronumcorr07,libronumcorr08,libronumcorr09,libronumcorr10,libronumcorr11,libronumcorr12,usuariocodigo,fechaact) "
            SQL1 = SQL1 & "VALUES ('" & VGParametros.empresacodigo & "',"
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            SQL1 = SQL1 & "'" & txt(0).CtlText & " ','" & VGParamSistem.Anoproceso & "',"
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(5).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(4).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL1 = SQL1 & VGvardllgen.ESNULO(txt(3).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(4).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(5).CtlText, 0) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(8).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(7).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL1 = SQL1 & VGvardllgen.ESNULO(txt(6).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(7).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(8).CtlText, 0) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(14).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(13).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(12).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(11).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(10).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL1 = SQL1 & VGvardllgen.ESNULO(txt(9).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(10).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(11).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(12).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(13).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(14).CtlText, 0) & ",'"
            SQL1 = SQL1 & VGusuario & "','" & VB6.Format(Today, "dd/mm/yyyy") & "')"

        ElseIf modoedit = True Then
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            SQL = "UPDATE CT_LIBRO SET librodescripcion='" & Trim(UCase(txt(1).CtlText)) & "',"
            SQL = SQL & "flagcontrol=" & chk(0).CheckState & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(5).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(4).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & "libronumcorr01=" & VGvardllgen.ESNULO(txt(3).CtlText, 0) & ",libronumcorr02=" & VGvardllgen.ESNULO(txt(4).CtlText, 0) & ",libronumcorr03=" & VGvardllgen.ESNULO(txt(5).CtlText, 0) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(8).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(7).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & "libronumcorr04=" & VGvardllgen.ESNULO(txt(6).CtlText, 0) & ",libronumcorr05=" & VGvardllgen.ESNULO(txt(7).CtlText, 0) & ",libronumcorr06=" & VGvardllgen.ESNULO(txt(8).CtlText, 0) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(11).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(10).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & "libronumcorr07=" & VGvardllgen.ESNULO(txt(9).CtlText, 0) & ",libronumcorr08=" & VGvardllgen.ESNULO(txt(10).CtlText, 0) & ",libronumcorr09=" & VGvardllgen.ESNULO(txt(11).CtlText, 0) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(14).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(13).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & "libronumcorr10=" & VGvardllgen.ESNULO(txt(12).CtlText, 0) & ",libronumcorr11=" & VGvardllgen.ESNULO(txt(13).CtlText, 0) & ",libronumcorr12=" & VGvardllgen.ESNULO(txt(14).CtlText, 0) & ","
            SQL = SQL & "usuariocodigo='" & VGusuario & "',fechaact='" & VB6.Format(Today, "dd/mm/yyyy") & "' "
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            SQL = SQL & "WHERE librocodigo='" & txt(0).CtlText & "'"

            SQL1 = " select  * from CT_libroCorre where empresacodigo='" & VGParametros.empresacodigo & "'"
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            SQL1 = SQL1 & " and librocodigo='" & txt(0).CtlText & "' and libroanno='" & VGParamSistem.Anoproceso & "'"
            'UPGRADE_NOTE: El objeto xx no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            xx = Nothing
            xx = VGCNx.Execute(SQL1)
            If xx.RecordCount = 0 Then
                SQL1 = "INSERT INTO CT_libroCorre (empresacodigo,librocodigo,libroanno,"
                SQL1 = SQL1 & "libronumcorr01,libronumcorr02,libronumcorr03,libronumcorr04,libronumcorr05,libronumcorr06,libronumcorr07,libronumcorr08,libronumcorr09,libronumcorr10,libronumcorr11,libronumcorr12,usuariocodigo,fechaact) "
                SQL1 = SQL1 & "VALUES ('" & VGParametros.empresacodigo & "',"
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                SQL1 = SQL1 & "'" & txt(0).CtlText & " ','" & VGParamSistem.Anoproceso & "',"
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(5).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(4).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SQL1 = SQL1 & VGvardllgen.ESNULO(txt(3).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(4).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(5).CtlText, 0) & ","
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(8).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(7).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SQL1 = SQL1 & VGvardllgen.ESNULO(txt(6).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(7).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(8).CtlText, 0) & ","
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(14).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(13).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(12).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(11).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(10).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SQL1 = SQL1 & VGvardllgen.ESNULO(txt(9).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(10).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(11).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(12).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(13).CtlText, 0) & "," & VGvardllgen.ESNULO(txt(14).CtlText, 0) & ",'"
                SQL1 = SQL1 & VGusuario & "','" & VB6.Format(Today, "dd/mm/yyyy") & "')"
            Else
                SQL1 = "UPDATE CT_LIBROCorre SET "
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(5).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(4).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SQL1 = SQL1 & "libronumcorr01=" & VGvardllgen.ESNULO(txt(3).CtlText, 0) & ",libronumcorr02=" & VGvardllgen.ESNULO(txt(4).CtlText, 0) & ",libronumcorr03=" & VGvardllgen.ESNULO(txt(5).CtlText, 0) & ","
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(8).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(7).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SQL1 = SQL1 & "libronumcorr04=" & VGvardllgen.ESNULO(txt(6).CtlText, 0) & ",libronumcorr05=" & VGvardllgen.ESNULO(txt(7).CtlText, 0) & ",libronumcorr06=" & VGvardllgen.ESNULO(txt(8).CtlText, 0) & ","
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(11).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(10).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SQL1 = SQL1 & "libronumcorr07=" & VGvardllgen.ESNULO(txt(9).CtlText, 0) & ",libronumcorr08=" & VGvardllgen.ESNULO(txt(10).CtlText, 0) & ",libronumcorr09=" & VGvardllgen.ESNULO(txt(11).CtlText, 0) & ","
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(14).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(txt(13).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SQL1 = SQL1 & "libronumcorr10=" & VGvardllgen.ESNULO(txt(12).CtlText, 0) & ",libronumcorr11=" & VGvardllgen.ESNULO(txt(13).CtlText, 0) & ",libronumcorr12=" & VGvardllgen.ESNULO(txt(14).CtlText, 0) & ","
                SQL1 = SQL1 & "usuariocodigo='" & VGusuario & "',fechaact='" & VB6.Format(Today, "dd/mm/yyyy") & "' "
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                SQL1 = SQL1 & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and librocodigo='" & txt(0).CtlText & "' AND "
                SQL1 = SQL1 & "libroanno='" & VGParamSistem.Anoproceso & "'"
            End If
        End If
        VGCNx.Execute(SQL)
        If Cont = 0 Then
            VGCNx.Execute(SQL1)
        End If
        VGCNx.CommitTrans()

        'UPGRADE_NOTE: El objeto VGvardllgen no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        VGvardllgen = Nothing
        frmbotones.Visible = True
        modoinsert = False : modoedit = False
        Call MuestraDatosLibro()
        cAcepta.Enabled = False
        'UPGRADE_NOTE: El objeto VGvardllgen no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        VGvardllgen = Nothing
        Call ModoEditable(False, Me, "")
        SSTab1.SelectedIndex = 0
        SSTab1.TabPages.Item(1).Enabled = False
        SSTab1.TabPages.Item(2).Enabled = False
        Exit Sub

x:
        If Err.Number = -2147217873 Then
            MsgBox("Esta intentando registrar Código de Sublibro Existente ", MsgBoxStyle.Information, Text)
            txt(0).Focus()
        Else
            MsgBox("Error inesperado: " & Err.Number & " " & Err.Description, MsgBoxStyle.Information, Text)
        End If
        VGCNx.RollbackTrans()

    End Sub

    Private Sub cCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cCancela.Click
        frmbotones.Visible = True
        modoinsert = False : modoedit = False
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

    Private Sub TDBGridAsientos_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_HeadClickEvent) Handles TDBGridAsientos2.HeadClick
        On Error Resume Next
        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If IsNothing(rs.Sort) Then
            rs.Sort = TDBGridAsientos2.Columns.Item(eventArgs.ColIndex).DataField & " asc"
        ElseIf VB.Right(rs.Sort, 3) = "asc" Then
            rs.Sort = TDBGridAsientos2.Columns.Item(eventArgs.ColIndex).DataField & " desc"
        ElseIf VB.Right(rs.Sort, 4) = "desc" Then
            rs.Sort = TDBGridAsientos2.Columns.Item(eventArgs.ColIndex).DataField & " asc"
        End If
        TDBGridAsientos2.Refresh()
    End Sub

    Private Sub TDBGridAsientos_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBGridAsientos2.DblClick
        If rs.RecordCount > 0 Then Call cmdBotones_Click(cmdBotones.Item(1), New System.EventArgs())
    End Sub

    Private Sub TDBGridAsientos_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_RowColChangeEvent) Handles TDBGridAsientos2.RowColChange
        Call Editarlibro()
    End Sub

    Private Sub txt_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Change
        Dim Index As Short = txt.GetIndex(eventSender)
        If modoinsert = True Or modoedit = True Then
            cAcepta.Enabled = ValidaDataIngreso()
        End If
    End Sub

    'UPGRADE_WARNING: El evento chk.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chk_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chk.CheckStateChanged
        Dim Index As Short = chk.GetIndex(eventSender)
        If modoinsert = True Or modoedit = True Then cAcepta.Enabled = ValidaDataIngreso()
    End Sub

    Private Sub txt_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyDownEvent) Handles txt.KeyDownEvent
        Dim Index As Short = txt.GetIndex(eventSender)
        If Index = 2 And eventArgs.KeyCode = 13 Then
            cAcepta.Focus()
        End If

    End Sub

    Private Sub txt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Leave
        Dim Index As Short = txt.GetIndex(eventSender)
        If Index = 0 Then
            If Not IsDBNull(txt(0).CtlText) Then txt(0).CtlText = VB6.Format(txt(0).CtlText, "00")
        Else
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            txt(Index).CtlText = UCase(txt(Index).CtlText)
        End If
    End Sub

    Sub Editarlibro()
        Dim i As Short

        If rs.RecordCount > 0 Then
            With TDBGridAsientos2
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt(0).CtlText = .Columns(0).Value
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt(1).CtlText = .Columns(1).Value
                chk(0).CheckState = IIf(.Columns(2).Value = 0, 0, 1)
                For i = 1 To 12
                    'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    txt(i + 2).CtlText = .Columns(i + 2).Value
                Next
            End With
        End If
    End Sub

    Sub ConfiguraGridLibros()
        Dim i As Short
        With TDBGridAsientos2
            .Columns(0).Width = 80
            .Columns(1).Width = 220
            .Columns(2).Width = 80
            For i = 1 To 12
                .Columns(i + 2).Visible = False
            Next
        End With

    End Sub
	
	Function ValidaDataIngreso() As Boolean
		Dim i As Short
		For i = 0 To 1
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If IsNothing(txt(i).CtlText) Then
				ValidaDataIngreso = False
				Exit Function
			End If
		Next 
		ValidaDataIngreso = True
	End Function
End Class