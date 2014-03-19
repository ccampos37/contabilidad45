Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.Data

Friend Class frmMantEntidad
    Inherits System.Windows.Forms.Form

    Dim modoinsert As Boolean
    Dim modoedit As Boolean
    Dim i_filaorigen As Short
    Dim rs As New ADODB.Recordset
    Dim FLAG_CHECK As Boolean
    Dim rsNet As New DataSet




    Private Sub frmMantEntidad_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call ConfiguraForm()
        Call MuestraDatos("%")
        Call CargaLista()


    End Sub

    Sub ConfiguraForm()
        SSTab1.SelectedIndex = 0
        cAcepta.Enabled = False
        lblNumReg.Text = CStr(Nothing)
        FLAG_CHECK = False


        'Me.Width = VB6.TwipsToPixelsX(650)
        'Me.Height = VB6.TwipsToPixelsY(5925)
    End Sub

    Private Sub MuestraDatos(ByRef xCod As String)
        Dim SQL As String
        SQL = "SELECT entidadcodigo,entidadrazonsocial,entidaddireccion,entidadtelefono,entidadruc,entidadtipocontri From ct_entidad "
        '  SQL = SQL & "  AND WHERE entidadcodigo<>'00' "

        If IsNumeric(xCod) = True Then
            SQL = SQL & " WHERE entidadcodigo LIKE '" & xCod & "%'"
        Else
            SQL = SQL & " WHERE  entidadrazonsocial LIKE '" & xCod & "%'"
        End If
        rs = VGCNx.Execute(SQL)



        CambioRs_Dataset(rs, TDBGrid1)

        Call ConfiguraTdbgrid()
        lblNumReg.Text = CStr(rs.RecordCount)
        SSTab1.SelectedIndex = 0
    End Sub

    Sub CargaLista()
        ' Declara una variable para agregar objetos ListItem.
        Dim rsX As ADODB.Recordset
        Dim itmX As System.Windows.Forms.ListViewItem
        Dim SQL As String
        rsX = New ADODB.Recordset

        ListView1.Columns.Clear()
        ListView1.Items.Clear()
        ListView1.Columns.Add("", "Codigo Tipo Analítico", CInt(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(ListView1.Width) / 3)))
        ListView1.Columns.Add("Descripción Tipo Analítico", CInt(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(ListView1.Width) * 2 / 3)), System.Windows.Forms.HorizontalAlignment.Center)
        ListView1.View = System.Windows.Forms.View.Details

        SQL = "select tipoanaliticocodigo,tipoanaliticodescripcion FROM ct_tipoanalitico WHERE tipoanaliticocodigo<>'00'"
        rsX = VGCNx.Execute(SQL)
        While Not rsX.EOF
            itmX = ListView1.Items.Add(rsX.Fields(0).Value)
            If itmX.SubItems.Count > 0 Then
                itmX.SubItems(0).Text = rsX.Fields(0).Value
            Else
                itmX.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, rsX.Fields(1).Value))
            End If
            rsX.MoveNext()
        End While
        rsX = Nothing

    End Sub

    Private Sub cCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cCancela.Click
        SSTab1.TabPages.Item(0).Enabled = True
        SSTab1.SelectedIndex = 0
        SSTab1.Focus()
        frmbotones.Visible = True
        modoinsert = False
        modoedit = False
        i_filaorigen = -1
        txtbuscar.Visible = True

    End Sub

    Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBotones.Click
        Dim Index As Short = cmdBotones.GetIndex(eventSender)
        Dim J As Short
        Dim spos As Short
        Dim SQL As String

        On Error GoTo X
        SSTab1.TabPages.Item(1).Enabled = True

        Select Case Index
            Case 0 'nuevo
                modoinsert = True
                frmbotones.Visible = False
                SSTab1.SelectedIndex = 1
                Call LimpiarValores()
                Call CargaLista()
                txt(0).CtlEnabled = True
                txt(0).Focus()

            Case 1 'editar
                If TDBGrid1.Rows.Count < 0 Then
                    Exit Sub
                End If
                modoedit = True
                'frmbotones.Visible = False
                SSTab1.SelectedIndex = 1
                Call EditarValores()
                Call MuestraCheckTipoAnalitico()
                cAcepta.Enabled = False
                txt(0).CtlEnabled = False

                txtbuscar.Visible = False




            Case 2 'eliminar
                Dim n As Integer
                n = TDBGrid1.CurrentRow.Index

                If MsgBox("Desea eliminar el registro de Código Entidad " & Trim(TDBGrid1.Item(0, n).Value), MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "AVISO") = MsgBoxResult.Yes Then
                    VGCNx.BeginTrans()
                    SQL = "DELETE FROM ct_analitico WHERE entidadcodigo='" & Trim(TDBGrid1.Item(0, n).Value) & "'"
                    VGCNx.Execute(SQL)
                    SQL = "DELETE FROM ct_entidad WHERE entidadcodigo='" & Trim(TDBGrid1.Item(0, n).Value) & "'"
                    VGCNx.Execute(SQL)
                    VGCNx.CommitTrans()
                    Call MuestraDatos((txtbuscar.CtlText))
                End If

            Case 3 'imprimir
                Call Impresion("rptEntidad.rpt")

            Case 4 ' salir
                Me.Close()
        End Select

        Exit Sub

X:
        If Index = 2 And Err.Number = -2147217873 Then
            MsgBox("Registro no podrá Eliminarse mientras exista Información en la Tablas Relacionadas", MsgBoxStyle.Information, Text)
            VGCNx.RollbackTrans()
        Else
            MsgBox("Error inesperado: " & Err.Description & "  " & Err.Number, MsgBoxStyle.Information, Text)
        End If

    End Sub

    Sub EditarValores()
        Dim i, n As Short

        n = TDBGrid1.CurrentRow.Index
        With TDBGrid1
            For i = 0 To 4
                txt(i).CtlText = Trim(.Item(i, n).Value)
            Next

            If (Not IsNothing(Trim(.Item(5, n).Value))) And Trim(.Item(5, n).Value) <> "" Then
                cboTipoCont.Text = VB6.GetItemString(cboTipoCont, Convert.ToInt32(.Item(5, n).Value) - 1)
            Else
                cboTipoCont.Text = CStr(Nothing)
            End If
        End With
    End Sub

    'FIXIT: Declare 'LimpiarValores' con un tipo de datos de enlace en tiempo de compilación     FixIT90210ae-R1672-R1B8ZE
    Public Sub LimpiarValores()
        Dim i As Short
        For i = 0 To 4
            txt(i).CtlText = Nothing
        Next
        cboTipoCont.Text = CStr(Nothing)
    End Sub

    Private Sub cAcepta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cAcepta.Click
        If ValidaData() = True Then
            Call GrabaData()
        End If

    End Sub

    Function ValidaData() As Boolean
        Dim rsX As ADODB.Recordset
        Dim SQL As String
        Dim i As Short


        If IsNothing(txt(0).CtlText) Then
            MsgBox("Debe Registrar el Código de Analítico", MsgBoxStyle.Information, Text)
            ValidaData = False
            txt(4).Focus()
            Exit Function
        End If

        '    If Len(Trim$(txt(0).Text)) <> 11 And Trim$(txt(0).Text) <> "00" Then
        '        MsgBox "El Código de Analítico debe tener 11 caracteres", vbInformation, Caption
        '        ValidaData = False
        '        txt(4).SetFocus
        '        Exit Function
        '    End If

        '    If txt(4).Text = Empty Then
        '        MsgBox "Debe Registrar el Nº de RUC", vbInformation, Caption
        '        ValidaData = False
        '        txt(4).SetFocus
        '        Exit Function
        '    End If

        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items.Item(i).Checked = True Then
                ValidaData = True
                Exit For
            Else
                ValidaData = False
                If i = ListView1.Items.Count Then
                    MsgBox("Falta Completar el Tipo de Analítico", MsgBoxStyle.Information, Text)
                    Exit Function
                End If
            End If
        Next

        '  If txt(4).Text <> Empty And Len(Trim$(txt(4).Text)) <> 11 Then
        '    MsgBox "El número de RUC tiene 11 dígitos", vbInformation, Caption
        '    ValidaData = False
        '    txt(4).SetFocus
        '    Exit Function
        '  End If

        If Not IsNothing(txt(4).CtlText) Then
            SQL = "SELECT count(entidadruc) FROM ct_entidad WHERE entidadruc='" & txt(4).CtlText & "'"
            rsX = New ADODB.Recordset
            rsX = VGCNx.Execute(SQL)
            VGvardllgen = New dllgeneral.dll_general

            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(rsX(0), 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If modoedit = True And VGvardllgen.ESNULO(rsX.Fields(0), 0) = 1 Then
                ValidaData = True
                SQL = "SELECT count(entidadruc) FROM ct_entidad WHERE entidadruc='" & txt(4).CtlText & "'"
                SQL = SQL & " AND entidadcodigo<>'" & txt(0).CtlText & "'"
                rsX = VGCNx.Execute(SQL)
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(rsX(0), 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If VGvardllgen.ESNULO(rsX.Fields(0), 0) > 0 Then
                    MsgBox("Esta intentando registrar un numero de RUC existente", MsgBoxStyle.Information, Text)
                    ValidaData = False
                    txt(4).Focus()
                    Exit Function
                End If
            Else
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(rsX(0), 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If VGvardllgen.ESNULO(rsX.Fields(0), 0) > 0 Then
                    MsgBox("Esta intentando registrar un número de RUC existente", MsgBoxStyle.Information, Text)
                    ValidaData = False
                    txt(4).Focus()
                    Exit Function
                Else
                    ValidaData = True
                End If
            End If
        End If

        ValidaData = True
    End Function

    Sub GrabaData()
        Dim xVarCbo As String
        Dim SQL As String
        On Error GoTo X

        SSTab1.TabPages.Item(0).Enabled = True

        xVarCbo = Trim(VB.Left(VB6.GetItemString(cboTipoCont, cboTipoCont.SelectedIndex), 2))

        If modoinsert = True Then
            SQL = "INSERT CT_ENTIDAD(entidadcodigo,entidadrazonsocial,entidaddireccion,entidadtelefono,entidadruc,entidadtipocontri,usuariocodigo,fechaact) "
            SQL = SQL & "VALUES ('" & UCase(txt(0).CtlText) & "','" & UCase(txt(1).CtlText) & "','" & UCase(txt(2).CtlText) & "','" & txt(3).CtlText & "','" & txt(4).CtlText & "','" & xVarCbo & "','" & VGusuario & "','" & Today & "')"
            VGCNx.BeginTrans()
            VGCNx.Execute(SQL)
            Call GrabaCheckTipoAnalitico()
            VGCNx.CommitTrans()

        ElseIf modoedit = True Then
            SQL = "UPDATE CT_ENTIDAD SET entidadrazonsocial='" & Trim(UCase(txt(1).CtlText)) & "',"
            SQL = SQL & "entidaddireccion='" & Trim(UCase(txt(2).CtlText)) & "',"
            SQL = SQL & "entidadtelefono='" & txt(3).CtlText & "',"
            SQL = SQL & "entidadruc='" & txt(4).CtlText & "',"
            SQL = SQL & "entidadtipocontri='" & xVarCbo & "',"
            SQL = SQL & "usuariocodigo='" & VGusuario & "',fechaact='" & VB6.Format(Today, "dd/mm/yyyy") & "' "
            SQL = SQL & "WHERE entidadcodigo='" & txt(0).CtlText & "'"
            VGCNx.BeginTrans()
            VGCNx.Execute(SQL)

            If FLAG_CHECK = True Then
                'Call DeleteCheckTipoAnalitico
                Call GrabaCheckTipoAnalitico()
            End If

            VGCNx.CommitTrans()

        End If

        Call MuestraDatos((txtbuscar.CtlText))
        frmbotones.Visible = True
        modoinsert = False : modoedit = False : FLAG_CHECK = False
        i_filaorigen = -1
        Exit Sub
        txtbuscar.Visible = True

X:
        If Err.Number = -2147217873 Then
            MsgBox("Esta intentando registrar Código Analítico Existente " & Err.Description, MsgBoxStyle.Information, Text)
        Else
            MsgBox("Error inesperado: " & Err.Number & " " & Err.Description)
        End If
        VGCNx.RollbackTrans()

    End Sub

    Sub MuestraCheckTipoAnalitico()
        Dim rsX As ADODB.Recordset
        Dim i As Integer
        Dim SQL As String
        SQL = "select tipoanaliticocodigo,analiticocodigo FROM ct_analitico WHERE entidadcodigo='" & txt(4).CtlText & "'"
        rsX = VGCNx.Execute(SQL)

        While Not rsX.EOF
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items.Item(i).Text = rsX.Fields(0).Value Then
                    ListView1.Items.Item(i).Checked = True
                Else
                    ListView1.Items.Item(i).Checked = False
                End If
            Next
            rsX.MoveNext()
        End While
        rsX = Nothing

    End Sub

    Sub DeleteCheckTipoAnalitico()
        Dim SQL As String
        SQL = "DELETE FROM ct_analitico WHERE entidadcodigo='" & txt(0).CtlText & "'"
        VGCNx.Execute(SQL)
    End Sub

    Sub GrabaCheckTipoAnalitico()
        Dim SQL As String
        Dim i As Integer
        Dim xCodAnalitico As String
        Dim rsX As New ADODB.Recordset
        rsX = New ADODB.Recordset
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items.Item(i).Checked = True Then
                xCodAnalitico = Trim(txt(0).CtlText) & Trim(ListView1.Items.Item(i).Text)
                SQL = "select count(*) from ct_analitico where analiticocodigo='" & xCodAnalitico & "'"
                rsX = VGCNx.Execute(SQL)
                If rsX.Fields(0).Value = 0 Then
                    SQL = "INSERT ct_analitico (analiticocodigo,entidadcodigo,tipoanaliticocodigo,usuariocodigo,fechaact) "
                    SQL = SQL & "VALUES ('" & xCodAnalitico & "','" & Trim(txt(0).CtlText) & "','" & Trim(ListView1.Items.Item(i).Text) & "','" & VGusuario & "','" & Today & "')"
                    VGCNx.Execute(SQL)
                End If
            End If
        Next
    End Sub

    Private Sub frmMantEntidad_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        rs = Nothing
    End Sub

    Private Sub ListView1_ColumnClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
        Dim ColumnHeader As System.Windows.Forms.ColumnHeader = ListView1.Columns(eventArgs.Column)
        'UPGRADE_ISSUE: MSComctlLib.ListView propiedad ListView1.SortKey no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        ListView1.Sorting = ColumnHeader.Index
        ListView1.Sort()
    End Sub

    Private Sub ListView1_ItemCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ItemCheckEventArgs) Handles ListView1.ItemCheck
        Dim Item As System.Windows.Forms.ListViewItem = ListView1.Items(eventArgs.Index)
        FLAG_CHECK = True
        cAcepta.Enabled = ValidaDataIngreso()
    End Sub

    Private Sub SSTab1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SSTab1.SelectedIndexChanged

    End Sub

    'Private Sub TDBGrid1_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_HeadClickEvent) Handles TDBGrid1.HeadClick

    'ya no sirve , esto es caractyeristica de datagridview

    'On Error Resume Next
    ''UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
    'If IsNothing(rs.Sort) Then
    '    rs.Sort = TDBGrid1.Columns.Item(eventArgs.colIndex).DataField & " asc"
    'ElseIf VB.Right(rs.Sort, 3) = "asc" Then
    '    rs.Sort = TDBGrid1.Columns.Item(eventArgs.colIndex).DataField & " desc"
    'ElseIf VB.Right(rs.Sort, 4) = "desc" Then
    '    rs.Sort = TDBGrid1.Columns.Item(eventArgs.colIndex).DataField & " asc"
    'End If
    'Call ConfiguraTdbgrid()
    ''UPGRADE_NOTE: Refresh se actualizó a CtlRefresh. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    'TDBGrid1.Refresh()
    'End Sub



    Private Sub ConfiguraTdbgrid()
        TDBGrid1.Columns(0).Width = 100
        TDBGrid1.Columns(1).Width = 300
        TDBGrid1.Columns(2).Width = 200
        TDBGrid1.Columns(3).Width = 100
        TDBGrid1.Columns(4).Width = 100

    End Sub

    Function ValidaDataIngreso() As Boolean
        Dim i As Short
        For i = 0 To 1
            If IsNothing(txt(i).CtlText) Then
                ValidaDataIngreso = False
                Exit Function
            End If
        Next

        ValidaDataIngreso = True
    End Function

    Private Sub txt_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Change
        Dim Index As Short = txt.GetIndex(eventSender)
        cAcepta.Enabled = ValidaDataIngreso()
    End Sub

    Private Sub txt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Leave
        Dim Index As Short = txt.GetIndex(eventSender)
        txt(Index).CtlText = UCase(txt(Index).CtlText)
        If Index = 0 And modoedit = False Then txt(4).CtlText = txt(0).CtlText
    End Sub

    'UPGRADE_WARNING: El evento cboTipoCont.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cboTipoCont_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTipoCont.SelectedIndexChanged
        cAcepta.Enabled = ValidaDataIngreso()
    End Sub

    Private Sub txt_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyPressEvent) Handles txt.KeyPressEvent
        Dim Index As Short = txt.GetIndex(eventSender)
        If eventArgs.keyAscii = 13 And Index = 15 Then
            cAcepta.Focus()
            Call cAcepta_Click(cAcepta, New System.EventArgs())
        End If
    End Sub

    Private Sub txtBuscar_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtbuscar.Change
        Call MuestraDatos((txtbuscar.CtlText))
    End Sub




    Private Sub SSTab1_Selecting(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles SSTab1.Selecting
        If e.TabPageIndex = 1 Then
            Call cmdBotones_Click(cmdBotones.Item(1), New System.EventArgs())
        Else
            Call cCancela_Click(cCancela, New System.EventArgs())
        End If

    End Sub




    Private Sub TDBGrid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TDBGrid1.CellContentClick

    End Sub

    Private Sub TDBGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TDBGrid1.DoubleClick
        If rs.RecordCount > 0 And (modoedit = False And modoinsert = False) Then
            Call cmdBotones_Click(cmdBotones.Item(1), New System.EventArgs())
        End If
    End Sub
End Class