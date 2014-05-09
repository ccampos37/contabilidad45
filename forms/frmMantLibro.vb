Option Strict Off
Option Explicit On
Imports Func = Contabilidad.ModFuncionesGen
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
		rs = Nothing
        rsLibro = Nothing

	End Sub
	
	Sub ConfiguraForm()
		SSTab1.SelectedIndex = 0
		SSTab1.TabPages.Item(1).Enabled = False
		SSTab1.TabPages.Item(2).Enabled = False
		cAcepta.Enabled = False
		lblNumReg.Text = CStr(Nothing)
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
            rs.Sort = TDBGridAsientos2.Columns.Item(eventArgs.colIndex).DataField & " asc"
        ElseIf Func.Right(rs.Sort, 3) = "asc" Then
            rs.Sort = TDBGridAsientos2.Columns.Item(eventArgs.colIndex).DataField & " desc"
        ElseIf Func.Right(rs.Sort, 4) = "desc" Then
            rs.Sort = TDBGridAsientos2.Columns.Item(eventArgs.colIndex).DataField & " asc"
        End If
        TDBGridAsientos2.Refresh()
    End Sub

    Private Sub TDBGridAsientos_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBGridAsientos2.DblClick
        If rs.RecordCount > 0 Then Call cmdBotones1_Click(eventSender, eventArgs)
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

    Private Sub txt_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyDownEvent) Handles txt.KeyDownEvent
        Dim Index As Short = txt.GetIndex(eventSender)
        If Index = 2 And eventArgs.keyCode = 13 Then
            cAcepta.Focus()
        End If

    End Sub

    Private Sub txt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Leave
        Dim Index As Short = txt.GetIndex(eventSender)
        If Index = 0 Then
            If Not IsDBNull(txt0.Text) Then txt0.Text = Format(txt0.Text, "00")
        Else
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            txt(Index).Text = UCase(txt(Index).Text)
        End If
    End Sub

    Sub Editarlibro()
        Dim i As Short

        If rs.RecordCount > 0 Then
            With TDBGridAsientos2
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt0.Text = .Columns(0).Value
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt1.Text = .Columns(1).Value
                chk0.CheckState = IIf(.Columns(2).Value = 0, 0, 1)
                For i = 1 To 12
                    'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    txt(i + 2).Text = .Columns(i + 2).Value
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
            If IsNothing(txt(i).Text) Then
                ValidaDataIngreso = False
                Exit Function
            End If
        Next
        ValidaDataIngreso = True
    End Function

    Private Sub cmdBotones0_Click(sender As Object, e As EventArgs) Handles cmdBotones0.Click
        SSTab1.SelectedIndex = 1
        SSTab1.TabPages.Item(1).Enabled = True
        SSTab1.TabPages.Item(2).Enabled = True
        modoinsert = True
        Call LimpiarForm(Me, "")
        txt0.Focus()
        Call ModoEditable(True, Me, "")
        frmbotones.Visible = False
    End Sub

    Private Sub cmdBotones2_Click(sender As Object, e As EventArgs) Handles cmdBotones2.Click
        Dim sql1 As String
        If MsgBox("Desea eliminar el registro de Libro Nº " & TDBGridAsientos2.Columns(0).Value & "?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "AVISO") = MsgBoxResult.Yes Then
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            SQL = "DELETE FROM CT_LIBRO WHERE librocodigo='" & txt0.Text & "'"
            sql1 = "DELETE FROM CT_LIBROCORRE WHERE "
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            sql1 = sql1 & " empresacodigo='" & VGParametros.empresacodigo & "' and librocodigo='" & txt0.Text & "' AND libroanno='" & VGParamSistem.Anoproceso & "'"
            VGCNx.Execute(SQL)
            VGCNx.Execute(sql1)
            Call MuestraDatosLibro()
        End If
    End Sub

    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
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
    End Sub

    Private Sub cmdBotones3_Click(sender As Object, e As EventArgs) Handles cmdBotones3.Click
        Call Impresion("rptlibro.rpt")
    End Sub

    Private Sub cmdBotones4_Click(sender As Object, e As EventArgs) Handles cmdBotones4.Click
        Me.Close()
    End Sub

    Private Sub cAcepta_Click(sender As Object, e As EventArgs) Handles cAcepta.Click
        Dim SQL1 As String = ""
        Dim xx As New ADODB.Recordset
        On Error GoTo x
        Dim Cont As Short
        VGCNx.BeginTrans()
        Cont = 0
        If modoinsert = True Then
            SQL = "INSERT INTO CT_libro (librocodigo,librodescripcion,flagcontrol,"
            SQL = SQL & "libronumcorr01,libronumcorr02,libronumcorr03,libronumcorr04,libronumcorr05,libronumcorr06,libronumcorr07,libronumcorr08,libronumcorr09,libronumcorr10,libronumcorr11,libronumcorr12,usuariocodigo,fechaact) "
            SQL = SQL & "VALUES ('" & txt0.Text & "','" & txt1.Text & "'," & chk0.CheckState & ","
            SQL = SQL & ESNULO(txt3.Text, 0) & "," & ESNULO(txt4.Text, 0) & "," & ESNULO(txt5.Text, 0) & ","
            SQL = SQL & ESNULO(txt6.Text, 0) & "," & ESNULO(txt7.Text, 0) & "," & ESNULO(txt8.Text, 0) & ","
            SQL = SQL & ESNULO(txt9.Text, 0) & "," & ESNULO(txt10.Text, 0) & "," & ESNULO(txt11.Text, 0) & "," & ESNULO(txt12.Text, 0) & "," & ESNULO(txt13.Text, 0) & "," & ESNULO(txt14.Text, 0) & ",'"
            SQL = SQL & VGUsuario & "','" & Format(Today, "dd/mm/yyyy") & "')"

            SQL1 = " select  * from CT_libroCorre where empresacodigo='" & VGParametros.empresacodigo & "'"
            SQL1 = SQL1 & " and librocodigo='" & txt0.Text & "' and libroanno='" & VGParamSistem.Anoproceso & "'"
            xx = Nothing
            xx = VGCNx.Execute(SQL1)
            If xx.RecordCount = 0 Then
                Cont = 1
            End If
            SQL1 = "INSERT INTO CT_libroCorre (empresacodigo,librocodigo,libroanno,"
            SQL1 = SQL1 & "libronumcorr01,libronumcorr02,libronumcorr03,libronumcorr04,libronumcorr05,libronumcorr06,libronumcorr07,libronumcorr08,libronumcorr09,libronumcorr10,libronumcorr11,libronumcorr12,usuariocodigo,fechaact) "
            SQL1 = SQL1 & "VALUES ('" & VGParametros.empresacodigo & "',"
            SQL1 = SQL1 & "'" & txt0.Text & " ','" & VGParamSistem.Anoproceso & "',"
            SQL1 = SQL1 & ESNULO(txt3.Text, 0) & "," & ESNULO(txt4.Text, 0) & "," & ESNULO(txt5.Text, 0) & ","
            SQL1 = SQL1 & ESNULO(txt6.Text, 0) & "," & ESNULO(txt7.Text, 0) & "," & ESNULO(txt8.Text, 0) & ","
            SQL1 = SQL1 & ESNULO(txt9.Text, 0) & "," & ESNULO(txt10.Text, 0) & "," & ESNULO(txt11.Text, 0) & "," & ESNULO(txt12.Text, 0) & "," & ESNULO(txt13.Text, 0) & "," & ESNULO(txt14.Text, 0) & ",'"
            SQL1 = SQL1 & VGUsuario & "','" & Format(Today, "dd/mm/yyyy") & "')"

        ElseIf modoedit = True Then
            SQL = "UPDATE CT_LIBRO SET librodescripcion='" & Trim(UCase(txt1.Text)) & "',"
            SQL = SQL & "flagcontrol=" & chk0.CheckState & ","
            SQL = SQL & "libronumcorr01=" & ESNULO(txt3.Text, 0) & ",libronumcorr02=" & ESNULO(txt4.Text, 0) & ",libronumcorr03=" & ESNULO(txt5.Text, 0) & ","
            SQL = SQL & "libronumcorr04=" & ESNULO(txt6.Text, 0) & ",libronumcorr05=" & ESNULO(txt7.Text, 0) & ",libronumcorr06=" & ESNULO(txt8.Text, 0) & ","
            SQL = SQL & "libronumcorr07=" & ESNULO(txt9.Text, 0) & ",libronumcorr08=" & ESNULO(txt10.Text, 0) & ",libronumcorr09=" & ESNULO(txt11.Text, 0) & ","
            SQL = SQL & "libronumcorr10=" & ESNULO(txt12.Text, 0) & ",libronumcorr11=" & ESNULO(txt13.Text, 0) & ",libronumcorr12=" & ESNULO(txt14.Text, 0) & ","
            SQL = SQL & "usuariocodigo='" & VGUsuario & "',fechaact='" & Format(Today, "dd/mm/yyyy") & "' "
            SQL = SQL & "WHERE librocodigo='" & txt0.Text & "'"

            SQL1 = " select  * from CT_libroCorre where empresacodigo='" & VGParametros.empresacodigo & "'"
            SQL1 = SQL1 & " and librocodigo='" & txt0.Text & "' and libroanno='" & VGParamSistem.Anoproceso & "'"
            xx = Nothing
            xx = VGCNx.Execute(SQL1)
            If xx.RecordCount = 0 Then
                SQL1 = "INSERT INTO CT_libroCorre (empresacodigo,librocodigo,libroanno,"
                SQL1 = SQL1 & "libronumcorr01,libronumcorr02,libronumcorr03,libronumcorr04,libronumcorr05,libronumcorr06,libronumcorr07,libronumcorr08,libronumcorr09,libronumcorr10,libronumcorr11,libronumcorr12,usuariocodigo,fechaact) "
                SQL1 = SQL1 & "VALUES ('" & VGParametros.empresacodigo & "',"
                SQL1 = SQL1 & "'" & txt0.Text & " ','" & VGParamSistem.Anoproceso & "',"
                SQL1 = SQL1 & ESNULO(txt3.Text, 0) & "," & ESNULO(txt4.Text, 0) & "," & ESNULO(txt5.Text, 0) & ","
                SQL1 = SQL1 & ESNULO(txt6.Text, 0) & "," & ESNULO(txt7.Text, 0) & "," & ESNULO(txt8.Text, 0) & ","
                SQL1 = SQL1 & ESNULO(txt9.Text, 0) & "," & ESNULO(txt10.Text, 0) & "," & ESNULO(txt11.Text, 0) & "," & ESNULO(txt12.Text, 0) & "," & ESNULO(txt13.Text, 0) & "," & ESNULO(txt14.Text, 0) & ",'"
                SQL1 = SQL1 & VGUsuario & "','" & Format(Today, "dd/mm/yyyy") & "')"
            Else
                SQL1 = "UPDATE CT_LIBROCorre SET "
                SQL1 = SQL1 & "libronumcorr01=" & ESNULO(txt3.Text, 0) & ",libronumcorr02=" & ESNULO(txt4.Text, 0) & ",libronumcorr03=" & ESNULO(txt5.Text, 0) & ","
                SQL1 = SQL1 & "libronumcorr04=" & ESNULO(txt6.Text, 0) & ",libronumcorr05=" & ESNULO(txt7.Text, 0) & ",libronumcorr06=" & ESNULO(txt8.Text, 0) & ","
                SQL1 = SQL1 & "libronumcorr07=" & ESNULO(txt9.Text, 0) & ",libronumcorr08=" & ESNULO(txt10.Text, 0) & ",libronumcorr09=" & ESNULO(txt11.Text, 0) & ","
                SQL1 = SQL1 & "libronumcorr10=" & ESNULO(txt12.Text, 0) & ",libronumcorr11=" & ESNULO(txt13.Text, 0) & ",libronumcorr12=" & ESNULO(txt14.Text, 0) & ","
                SQL1 = SQL1 & "usuariocodigo='" & VGUsuario & "',fechaact='" & Format(Today, "dd/mm/yyyy") & "' "
                SQL1 = SQL1 & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and librocodigo='" & txt0.Text & "' AND "
                SQL1 = SQL1 & "libroanno='" & VGParamSistem.Anoproceso & "'"
            End If
        End If
        VGCNx.Execute(SQL)
        If Cont = 0 Then
            VGCNx.Execute(SQL1)
        End If
        VGCNx.CommitTrans()
        frmbotones.Visible = True
        modoinsert = False : modoedit = False
        Call MuestraDatosLibro()
        cAcepta.Enabled = False
        Call ModoEditable(False, Me, "")
        SSTab1.SelectedIndex = 0
        SSTab1.TabPages.Item(1).Enabled = False
        SSTab1.TabPages.Item(2).Enabled = False
        Exit Sub
x:
        If Err.Number = -2147217873 Then
            MsgBox("Esta intentando registrar Código de Sublibro Existente ", MsgBoxStyle.Information, Text)
            txt0.Focus()
        Else
            MsgBox("Error inesperado: " & Err.Number & " " & Err.Description, MsgBoxStyle.Information, Text)
        End If
        VGCNx.RollbackTrans()
    End Sub

    Private Sub chk0_CheckedChanged(sender As Object, e As EventArgs) Handles chk0.CheckedChanged
        If modoinsert = True Or modoedit = True Then cAcepta.Enabled = ValidaDataIngreso()

    End Sub
End Class