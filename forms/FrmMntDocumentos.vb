Public Class FrmMntDocumentos
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
        aparam(0) = VGParamSistem.BDEmpresa
        aform(0) = "emp ='" & VGParametros.RucEmpresa & "'"
        Call ImpresionRptProc(cNomRepor, aform, aparam, , "Centro de costos")
    End Sub

    Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmdcancelar.Click
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
        DbGrid1.Visible = False
        Frame2.Visible = False
        frame5.Visible = False
        txtcodigo.Enabled = True
        Frame3.Text = "Ingreso de Centro de costosS"

        Frame1.Visible = True
        Frame3.Visible = True
        txtcodigo.Focus()
        resp = "S"
        Limpiar()


    End Sub
    Private Sub CmdModificar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdModificar.Click
        If rs.RecordCount > 0 Then
            Limpiar()
            resp = "N"
            Frame3.Text = "Modificación de tipo de Documento"
            DbGrid1.Visible = False
            Frame2.Visible = False
            frame5.Visible = False
            Frame1.Visible = True
            Frame3.Visible = True
            txtcodigo.Text = rs.Fields("documentocodigo").Value
            txtcodigo.Enabled = False
            txtdescripcion.Text = rs.Fields("documentodescripcion").Value
            TxtRefSunat.Text = ESNULO(rs.Fields("formadepagocodigo"), "")
            CheckcOMPRAS.CheckState = ESNULO(IIf(rs.Fields("documentoregcompras").Value = True, 1, 0), 0)
            CheckVTAS.CheckState = ESNULO(IIf(rs.Fields("documentoregventas").Value = True, 1, 0), 0)
            CheckNota.CheckState = ESNULO(IIf(rs.Fields("documentonotacredito").Value = True, 1, 0), 0)
            Checkref.CheckState = ESNULO(IIf(rs.Fields("documentoref").Value = True, 1, 0), 0)

            txtdescripcion.Focus()
        End If
    End Sub

    Private Sub CmdEliminar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmdeliminar.Click
        On Error GoTo EliErr
        Dim cSql1 As String
        Dim CSQL2, cSql3 As String
        Dim cCodigo1 As String
        Dim cSel1 As ADODB.Recordset
        Dim cCodigo As String
        Dim cSqlA As String
        Dim cSelA As ADODB.Recordset
        If rs.RecordCount > 0 Then
            cSqlA = "Select * FROM ct_detComprob" & VGParamSistem.Anoproceso & " WHERE documentocodigo = '" & Trim(DbGrid1.Columns(0).Text) & "'"
            cSelA = New ADODB.Recordset
            cSelA = VGCNx.Execute(cSqlA)
            If Not cSelA.EOF Then
                MsgBox("Existen documentos de referencia en asientos contables, no puede eliminarlo")
                cSelA.Close()
                Exit Sub
            End If
            cSelA.Close()
            cSql1 = "delete gr_documento where documentocodigo='" & Trim(DbGrid1.Columns(0).Text) & "'"
            If MsgBox("Seguro de Eliminar", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, mensaje1) = MsgBoxResult.Ok Then
                nTra = 2
                'cCodigo1 = Pos_Dato1(RS, "UM_ABREV")
                nTra = 1
                VGCNx.BeginTrans()
                VGCNx.Execute(cSql1)
                VGCNx.CommitTrans()
                nTra = 0
                Call Listado("")
            End If
            DbGrid1.Refresh()
            If DbGrid1.Visible Then DbGrid1.Focus()
        Else
            MsgBox("No existe ningún registro para Eliminar", MsgBoxStyle.Information, mensaje1)
        End If
        Exit Sub
EliErr:
        MsgBox(Err.Description)
        If nTra = 1 Then VGCNx.RollbackTrans()
    End Sub
    Private Sub cmdgrabar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdGrabar.Click
        If resp = "S" Then
            If txtcodigo.Text = "" Then
                MsgBox("Ingrese Código de Documento", MsgBoxStyle.Information, "Mensaje")
                txtcodigo.Focus()
                Exit Sub
            Else
                If Existe(1, Trim(txtcodigo.Text), "gr_documento", "documentocodigo", False) Then
                    MsgBox("El código del docuemnto ya existe", MsgBoxStyle.Information, "Mensaje")
                    txtcodigo.Focus()
                    Exit Sub
                End If
            End If
        End If
        If txtdescripcion.Text = "" Then
            MsgBox("Ingrese Nombre del documento", MsgBoxStyle.Exclamation, "Aviso")
            txtdescripcion.Focus()
            Exit Sub
        End If
        If resp = "S" Then
            SQL = "INSERT INTO gr_documento (documentocodigo, documentodescripcion, documentoregcompras, "
            SQL = SQL & "documentoregventas,documentonotacredito, documentoregletrasxcobrar, documentoregletrasxpagar,"
            SQL = SQL & "documentoref,formadepagocodigo)"
            SQL = SQL & " VALUES ('" & txtcodigo.Text & "','" & txtdescripcion.Text & "',"
            SQL = SQL & CheckcOMPRAS.CheckState & "," & CheckVTAS.CheckState & ","
            SQL = SQL & CheckNota.CheckState & ",0,0," & Checkref.CheckState & ",'" & TxtRefSunat.Text & "')"
        Else
            SQL = "UPDATE gr_documento "
            SQL = SQL & " SET documentodescripcion='" & RTrim(txtdescripcion.Text) & "',"
            SQL = SQL & "documentoregcompras=" & CheckcOMPRAS.CheckState & ",documentoregventas=" & CheckVTAS.CheckState & ","
            SQL = SQL & "documentonotacredito=" & CheckNota.CheckState & ", documentoref=" & Checkref.CheckState & ","
            SQL = SQL & "formadepagocodigo ='" & TxtRefSunat.Text & "'"
            SQL = SQL & " WHERE documentocodigo ='" & txtcodigo.Text & "'"
        End If
        VGCNx.Execute(SQL)
        Limpiar()
        Call cmdCancelar_Click(Cmdcancelar, New System.EventArgs())
        Listado((""))
        DbGrid1.Visible = True
    End Sub
    Sub Limpiar()
        txtcodigo.Text = ""
        CheckcOMPRAS.CheckState = 0
        CheckVTAS.CheckState = 0
        CheckNota.CheckState = 0
        Checkref.CheckState = 0
        CheckAnulado.CheckState = 0
    End Sub
    Private Sub FrmMntEstructuraBalance_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        datos = "SELECT documentocodigo, documentodescripcion, documentoregcompras, documentoregventas, documentoregletrasxcobrar, "
        datos = datos & " documentoregletrasxpagar, documentonotacredito, documentoref, formadepagocodigo FROM Gr_Documento"

        If DbGrid1.Visible Then DbGrid1.Focus()
        Call cmdCancelar_Click(Cmdcancelar, New System.EventArgs())
        Call Listado("")

    End Sub
    Sub Listado(ByRef wcad As Object)
        'UPGRADE_NOTE: El objeto DbGrid1.DataSource no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        DbGrid1.DataSource = Nothing
        rs = VGCNx.Execute(datos)
        DbGrid1.DataSource = rs
        With DbGrid1
            .Columns(0).Caption = "Doc"
            .Columns(1).Caption = "descripcion"
            .Columns(2).Caption = "Compras"
            .Columns(3).Caption = "Ventas"
            .Columns(4).Caption = "Nptas"
            .Columns(5).Caption = "Doc.ef."
            .MarqueeStyle = MSDataGridLib.MarqueeStyleConstants.dbgHighlightRow
            .Refresh()
        End With
    End Sub
End Class