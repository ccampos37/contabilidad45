Option Strict Off
Option Explicit On
Imports Func = Contabilidad.ModFuncionesGen
Friend Class frmMntAsiento
    Inherits System.Windows.Forms.Form

    Dim modoinsert As Boolean
    Dim modoedit As Boolean
    Dim rs As New ADODB.Recordset
    Dim rsAsiento As ADODB.Recordset

    Private Sub frmMantAsiento_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Ctr_Ayuda1.conexion(VGCNx)
        Call ConfiguraForm()
        Call MuestraDatosAsiento()
        SSTab1.TabPages.Item(0).Enabled = True

    End Sub

    Private Sub frmMantAsiento_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        rs = Nothing
        rsAsiento = Nothing
    End Sub

    Sub ConfiguraForm()
        SSTab1.SelectedIndex = 0
        SSTab1.TabPages.Item(1).Enabled = False
        SSTab1.TabPages.Item(2).Enabled = False
        cAcepta.Enabled = False
        lblNumReg.Text = CStr(Nothing)

    End Sub

    'FIXIT: Declare 'MuestraDatosAsiento' con un tipo de datos de enlace en tiempo de compilación     FixIT90210ae-R1672-R1B8ZE
    Public Sub MuestraDatosAsiento()
        Dim SQL As String

        SQL = "SELECT A.asientocodigo, A.asientodescripcion,A.flaggrabado,A.controlnref,A.nemotecref,"
        SQL = SQL & "B.asientonumcorr01, B.asientonumcorr02, B.asientonumcorr03, B.asientonumcorr04,"
        SQL = SQL & "B.asientonumcorr05, B.asientonumcorr06, B.asientonumcorr07, B.asientonumcorr08,"
        SQL = SQL & "B.asientonumcorr09, B.asientonumcorr10, B.asientonumcorr11, B.asientonumcorr12,"
        SQL = SQL & "A.librocodigo,asientoadicionacargo=Isnull(A.asientoadicionacargo,0) "
        SQL = SQL & "FROM  ct_asiento A, ct_asientocorre B  WHERE A.asientocodigo<>'00'"
        SQL = SQL & "and b.empresacodigo='" & VGParametros.empresacodigo & "'"
        SQL = SQL & " and A.asientocodigo=B.asientocodigo and B.asientoanno='" & VGParamSistem.Anoproceso & "'"

        rs = VGCNx.Execute(SQL)
        TDBGridAsientos.DataSource = rs
        Call ConfiguraGridAsientos()
        lblNumReg.Text = CStr(rs.RecordCount)

    End Sub

    Private Sub cAcepta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cAcepta.Click

        Dim SQL1 As String = ""
        'On Error GoTo X
        VGCNx.BeginTrans()

        If modoinsert = True Then
            SQL = "INSERT INTO CT_ASIENTO (asientocodigo,asientodescripcion,flaggrabado,controlnref,nemotecref,"
            SQL = SQL & "asientonumcorr01,asientonumcorr02,asientonumcorr03,asientonumcorr04,asientonumcorr05,asientonumcorr06,asientonumcorr07,asientonumcorr08,asientonumcorr09,asientonumcorr10,asientonumcorr11,asientonumcorr12,usuariocodigo,fechaact,librocodigo,asientoadicionacargo) "
            SQL = SQL & "VALUES ('" & txt0.Text & "','" & txt1.Text & "'," & chk0.CheckState & "," & chk1.CheckState & ",'" & Trim(UCase(txt2.Text)) & "',"
            SQL = SQL & ESNULO(txt3.Text, 0) & "," & ESNULO(txt4.Text, 0) & "," & ESNULO(txt5.Text, 0) & ","
            SQL = SQL & ESNULO(txt6.Text, 0) & "," & ESNULO(txt7.Text, 0) & "," & ESNULO(txt8.Text, 0) & ","
            SQL = SQL & ESNULO(txt9.Text, 0) & "," & ESNULO(txt10.Text, 0) & "," & ESNULO(txt11.Text, 0) & "," & ESNULO(txt12.Text, 0) & "," & ESNULO(txt13.Text, 0) & "," & ESNULO(txt14.Text, 0) & ",'"
            SQL = SQL & VGUsuario & "','" & Today & "','" & IIf(Not IsNothing(Ctr_Ayuda1.xclave), Trim(Ctr_Ayuda1.xclave), "00") & "','" & ChkCargo.CheckState & "')"

            SQL1 = "INSERT INTO CT_ASIENTOCORRE (empresacodigo,asientocodigo,asientoanno,"
            SQL1 = SQL1 & "asientonumcorr01,asientonumcorr02,asientonumcorr03,asientonumcorr04,asientonumcorr05,asientonumcorr06,asientonumcorr07,asientonumcorr08,asientonumcorr09,asientonumcorr10,asientonumcorr11,asientonumcorr12,usuariocodigo,fechaact) "
            SQL1 = SQL1 & "VALUES ('" & VGParametros.empresacodigo & "',"
            SQL1 = SQL1 & "'" & txt0.Text & " ','" & VGParamSistem.Anoproceso & "',"
            SQL1 = SQL1 & ESNULO(txt3.Text, 0) & "," & ESNULO(txt4.Text, 0) & "," & ESNULO(txt5.Text, 0) & ","
            SQL1 = SQL1 & ESNULO(txt6.Text, 0) & "," & ESNULO(txt7.Text, 0) & "," & ESNULO(txt8.Text, 0) & ","
            SQL1 = SQL1 & ESNULO(txt9.Text, 0) & "," & ESNULO(txt10.Text, 0) & "," & ESNULO(txt11.Text, 0) & "," & ESNULO(txt12.Text, 0) & "," & ESNULO(txt13.Text, 0) & "," & ESNULO(txt14.Text, 0) & ",'"
            SQL1 = SQL1 & VGUsuario & "','" & Today & "')"


        ElseIf modoedit = True Then
            SQL = "UPDATE CT_ASIENTO SET asientodescripcion='" & Trim(UCase(txt1.Text)) & "',"
            SQL = SQL & "flaggrabado=" & chk0.CheckState & ","
            SQL = SQL & "controlnref=" & chk1.CheckState & ","
            SQL = SQL & "nemotecref='" & txt2.Text & "',"
            SQL = SQL & "usuariocodigo='" & VGUsuario & "',fechaact='" & Today & "',"
            SQL = SQL & "librocodigo='" & IIf(Not IsNothing(Ctr_Ayuda1.xclave), Trim(Ctr_Ayuda1.xclave), "00") & "', "
            SQL = SQL & "asientoadicionacargo='" & ChkCargo.CheckState & "' "
            SQL = SQL & "WHERE asientocodigo='" & txt0.Text & "'"

            SQL1 = "UPDATE CT_ASIENTOCORRE SET "
            SQL1 = SQL1 & "asientonumcorr01=" & ESNULO(txt3.Text, 0) & "0,asientonumcorr02=" & ESNULO(txt4.Text, 0) & ",asientonumcorr03=" & ESNULO(txt5.Text, 0) & ","
            SQL1 = SQL1 & "asientonumcorr04=" & ESNULO(txt6.Text, 0) & ",asientonumcorr05=" & ESNULO(txt7.Text, 0) & ",asientonumcorr06=" & ESNULO(txt8.Text, 0) & ","
            SQL1 = SQL1 & "asientonumcorr07=" & ESNULO(txt9.Text, 0) & ",asientonumcorr08=" & ESNULO(txt10.Text, 0) & ",asientonumcorr09=" & ESNULO(txt11.Text, 0) & ","
            SQL1 = SQL1 & "asientonumcorr10=" & ESNULO(txt12.Text, 0) & ",asientonumcorr11=" & ESNULO(txt13.Text, 0) & ",asientonumcorr12=" & ESNULO(txt14.Text, 0) & ","
            SQL1 = SQL1 & "usuariocodigo='" & VGUsuario & "',fechaact='" & Today & "' "
            SQL1 = SQL1 & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and  asientocodigo='" & txt0.Text & "' AND "
            SQL1 = SQL1 & "asientoanno='" & VGParamSistem.Anoproceso & "'"

        End If

        VGCNx.Execute(SQL)
        VGCNx.Execute(SQL1)
        VGCNx.CommitTrans()

        modoinsert = False : modoedit = False
        Call MuestraDatosAsiento()
        cAcepta.Enabled = False
        '  VGvardllgen = Nothing
        Call ModoEditable(False, Me, "")
        SSTab1.SelectedIndex = 0
        SSTab1.TabPages.Item(1).Enabled = False
        SSTab1.TabPages.Item(2).Enabled = False
        Exit Sub

X:
        If Err.Number = -2147217873 Then
            MsgBox("Esta intentando registrar Código de Asiento Existente ", MsgBoxStyle.Information, Text)
            txt0.Focus()
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

    Private Sub TDBGridAsientos_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_HeadClickEvent) Handles TDBGridAsientos.HeadClick
        On Error Resume Next
        If IsNothing(rs.Sort) Then
            rs.Sort = TDBGridAsientos.Columns.Item(eventArgs.colIndex).DataField & " asc"
        ElseIf Func.Right(rs.Sort, 3) = "asc" Then
            rs.Sort = TDBGridAsientos.Columns.Item(eventArgs.colIndex).DataField & " desc"
        ElseIf Func.Right(rs.Sort, 4) = "desc" Then
            rs.Sort = TDBGridAsientos.Columns.Item(eventArgs.colIndex).DataField & " asc"
        End If
        TDBGridAsientos.Refresh()
    End Sub

    Private Sub TDBGridAsientos_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBGridAsientos.DblClick
        If rs.RecordCount > 0 Then Call cmdBotones0_Click(eventSender, eventArgs)
    End Sub

    'FIXIT: Declare 'LastRow' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
    Private Sub TDBGridAsientos_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_RowColChangeEvent) Handles TDBGridAsientos.RowColChange
        Call EditarAsiento()
    End Sub

    Private Sub chk_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If modoinsert = True Or modoedit = True Then cAcepta.Enabled = ValidaDataIngreso()
    End Sub

    Sub EditarAsiento()
        If rs.RecordCount > 0 Then
            With TDBGridAsientos
                txt0.Text = .Columns(0).Value
                txt0.Enabled = False
                txt1.Text = .Columns(1).Value
                chk0.CheckState = IIf(.Columns(2).Value = 0, 0, 1)
                chk1.CheckState = IIf(.Columns(3).Value = 0, 0, 1)
                ChkCargo.CheckState = IIf(.Columns(18).Text = "", 0, .Columns(18).Text)

                txt3.Text = .Columns(5).Value
                txt4.Text = .Columns(6).Value
                txt5.Text = .Columns(7).Value
                txt6.Text = .Columns(8).Value
                txt7.Text = .Columns(9).Value
                txt8.Text = .Columns(10).Value
                txt9.Text = .Columns(11).Value
                txt10.Text = .Columns(12).Value
                txt11.Text = .Columns(13).Value
                txt12.Text = .Columns(14).Value
                txt13.Text = .Columns(15).Value
                txt14.Text = .Columns(16).Value
                Ctr_Ayuda1.xclave = .Columns(17).Value : Ctr_Ayuda1.Ejecutar()
            End With

        End If
    End Sub

    Sub ConfiguraGridAsientos()
        Dim i As Short
        With TDBGridAsientos
            .Columns(0).Width = 70
            .Columns(1).Width = 220
            .Columns(2).Width = 60
            .Columns(3).Width = 60
            .Columns(4).Width = 220
            .Columns(5).Width = 50
            .Columns(6).Width = 50
            For i = 5 To 16
                .Columns(i).Visible = False
            Next
        End With

    End Sub

    Function ValidaDataIngreso() As Boolean
        If IsNothing(txt0.Text) Then
            ValidaDataIngreso = False
            Exit Function
        ElseIf IsNothing(txt1.Text) Then
            ValidaDataIngreso = False
            Exit Function
        End If


        ValidaDataIngreso = True
    End Function

    Private Sub cmdBotones0_Click(sender As Object, e As EventArgs) Handles cmdBotones0.Click
        SSTab1.SelectedIndex = 1
        SSTab1.TabPages.Item(1).Enabled = True
        SSTab1.TabPages.Item(2).Enabled = True
        Call Limpiar()
        txt0.Focus()
        Call ModoEditable(True, Me, "")

        modoinsert = True
    End Sub

    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
        If TDBGridAsientos.Row < 0 Then
            Exit Sub
        End If
        SSTab1.SelectedIndex = 1
        SSTab1.TabPages.Item(1).Enabled = True
        SSTab1.TabPages.Item(2).Enabled = True

        modoedit = True
        Call EditarAsiento()
        Call ModoEditable(True, Me, "")
    End Sub

    Private Sub cmdBotones2_Click(sender As Object, e As EventArgs) Handles cmdBotones2.Click
        Dim sql1 As String
        If MsgBox("Desea eliminar el registro de SubAsiento Nº " & TDBGridAsientos.Columns(0).Value & "?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "AVISO") = MsgBoxResult.Yes Then
            SQL = "DELETE FROM CT_ASIENTO WHERE asientocodigo='" & txt0.Text & "'"
            sql1 = "DELETE FROM CT_ASIENTOCorre WHERE "
            sql1 = sql1 & " empresacodigo='" & VGParametros.empresacodigo & "' and asientocodigo='" & txt0.Text & "' AND asientoanno='" & VGParamSistem.Anoproceso & "'"
            VGCNx.Execute(SQL)
            VGCNx.Execute(sql1)
            Call MuestraDatosAsiento()
        End If

    End Sub

    Private Sub cmdBotones3_Click(sender As Object, e As EventArgs) Handles cmdBotones3.Click
        Call Impresion("rptAsiento.rpt")
    End Sub

    Private Sub cmdBotones4_Click(sender As Object, e As EventArgs) Handles cmdBotones4.Click
        Me.Close()
    End Sub

    Private Sub chk0_CheckedChanged(sender As Object, e As EventArgs) Handles chk0.CheckedChanged
        cAcepta.Enabled = True
    End Sub

    Private Sub chk1_CheckedChanged(sender As Object, e As EventArgs) Handles chk1.CheckedChanged
        cAcepta.Enabled = True
    End Sub

    Private Sub limpiar()
        txt0.Text = ""
        txt1.Text = ""
        txt2.Text = ""
        txt0.Enabled = True
    End Sub


    Private Sub txt0_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt0.KeyPress
        If modoinsert = True Or modoedit = True Then
            cAcepta.Enabled = True
        End If
    End Sub

    Private Sub txt1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1.KeyPress
        cAcepta.Enabled = True

    End Sub


    Private Sub txt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2.KeyPress
        If modoinsert = True Or modoedit = True Then
            cAcepta.Enabled = True
        End If
    End Sub

    Private Sub txt1_Load(sender As Object, e As EventArgs) Handles txt1.Load

    End Sub

    Private Sub ChkCargo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCargo.CheckedChanged
        If modoinsert = True Or modoedit = True Then
            cAcepta.Enabled = True
        End If
    End Sub
End Class