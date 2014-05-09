Option Strict Off
Option Explicit On
Imports Func = Contabilidad.ModFuncionesGen
Friend Class frmConsultaComprobantes
    Inherits System.Windows.Forms.Form
    Dim rscabecera As New ADODB.Recordset
    Dim rsdetalle As New ADODB.Recordset


    Private Sub frmConsultaComprobantes_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        CtrAyu_Asiento.conexion(VGCNx)
        CtrAyu_SubAsiento.conexion(VGCNx)
        CtrAyu_Libro.conexion(VGCNx)
        TDBG_ConsultaDetalle.FetchRowStyle = True
        DTPicker1.Value = ""
    End Sub

    Private Sub EjecutarConsulta()

        Dim xasiento, sqlcad, xsubasiento As String
        rscabecera = New ADODB.Recordset
        xasiento = Trim(CtrAyu_Asiento.xclave) : xsubasiento = Trim(CtrAyu_SubAsiento.xclave)
        sqlcad = "SELECT * FROM " & VGParamSistem.TablaCabcomprob & " "
        sqlcad = sqlcad & "WHERE cabcomprobmes='" & CShort(VGParamSistem.Mesproceso) & "' "

        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        If Not IsNothing(txt0.Text) Then sqlcad = sqlcad & "AND cast(Right(rtrim$(cabcomprobnumero),5) as int)=" & CInt(Func.Right(Trim(txt0.Text), 5)) & " "
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        If Not IsNothing(txt1.Text) Then sqlcad = sqlcad & "AND cast(Right(rtrim$(cabcomprobnlibro),5) as int)=" & CInt(Func.Right(Trim(txt1.Text), 5)) & " "
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        If Not IsNothing(txt2.Text) Then sqlcad = sqlcad & "AND cabcomprobglosa like '%" & txt2.Text & "%' "
        'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If Not IsDBNull(DTPicker1.Value) Then sqlcad = sqlcad & "AND cabcomprobfeccontable='" & CDate(DTPicker1.Value) & "'"

        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If Not IsNothing(xasiento) Then sqlcad = sqlcad & "AND asientocodigo='" & xasiento & "' "
        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If Not IsNothing(xsubasiento) Then sqlcad = sqlcad & "AND subasientocodigo='" & Trim(xsubasiento) & "' "
        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If Not IsNothing(Trim(CtrAyu_Libro.xclave)) Then sqlcad = sqlcad & "AND detcomprobnlibro='" & Trim(CtrAyu_Libro.xclave) & "' "

        rscabecera = VGCNx.Execute(sqlcad)

        If rscabecera.RecordCount > 0 Then
            lblNro_Reg.Text = Format(rscabecera.RecordCount, "0 ")
            TDBG_ConsultaCabecera.Focus()
        Else
            lblNro_Reg.Text = Format(0, "0 ")
        End If
        TDBG_ConsultaCabecera.DataSource = rscabecera
    End Sub

    Private Sub EjecutarConsultaDetalle(ByRef xParam As String)
        Dim sqlcad As String
        sqlcad = "SELECT plantillaasientoinafecto,detcomprobitem,operacioncodigo,analiticocodigo,cuentacodigo,"
        sqlcad = sqlcad & "documentocodigo,detcomprobnumdocumento,indicador= case when detcomprobdebe>0 then 'D' else 'H' end,"
        sqlcad = sqlcad & "montosol=case when detcomprobdebe>0 then detcomprobdebe else detcomprobhaber end,"
        sqlcad = sqlcad & "montouss=case when detcomprobussdebe>0 then detcomprobussdebe else detcomprobusshaber end,detcomprobauto,monedacodigo "
        sqlcad = sqlcad & "FROM " & VGParamSistem.TablaDetcomprob & " WHERE cabcomprobnumero='" & xParam & " '"

        rsdetalle = New ADODB.Recordset
        rsdetalle = VGCNx.Execute(sqlcad)
        TDBG_ConsultaDetalle.DataSource = rsdetalle
        lblNroReg_Det.Text = CStr(rsdetalle.RecordCount)

    End Sub

    Private Sub cmdConsultar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConsultar.Click
        Call EjecutarConsulta()
    End Sub

    Private Sub TDBG_ConsultaCabecera_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBG_ConsultaCabecera.DblClick
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto TDBG_ConsultaCabecera.Columns().Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmantcomprobantes.CodComprob = TDBG_ConsultaCabecera.Columns(0).Value
        frmantcomprobantes.Show()
    End Sub

    Private Sub TDBG_ConsultaCabecera_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_KeyDownEvent) Handles TDBG_ConsultaCabecera.KeyDownEvent
        If eventArgs.keyCode = 13 Then
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto TDBG_ConsultaCabecera.Columns().Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            frmantcomprobantes.CodComprob = TDBG_ConsultaCabecera.Columns(0).Value
            frmantcomprobantes.Show()
        End If
    End Sub

    Private Sub TDBG_ConsultaCabecera_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_HeadClickEvent) Handles TDBG_ConsultaCabecera.HeadClick
        With rscabecera
            'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If IsNothing(.Sort) Then
                .Sort = TDBG_ConsultaCabecera.Columns.Item(eventArgs.colIndex).DataField & " asc"
            ElseIf Func.Right(.Sort, 3) = "asc" Then
                .Sort = TDBG_ConsultaCabecera.Columns.Item(eventArgs.colIndex).DataField & " desc"
            ElseIf Func.Right(.Sort, 4) = "desc" Then
                .Sort = TDBG_ConsultaCabecera.Columns.Item(eventArgs.colIndex).DataField & " asc"
            End If
            'UPGRADE_NOTE: Refresh se actualizó a CtlRefresh. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            TDBG_ConsultaCabecera.Refresh()
        End With
    End Sub

    'FIXIT: Declare 'LastRow' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
    Private Sub TDBG_ConsultaCabecera_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_RowColChangeEvent) Handles TDBG_ConsultaCabecera.RowColChange
        'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If IsDBNull(TDBG_ConsultaCabecera.Columns(0).Value) Then Exit Sub
        Call EjecutarConsultaDetalle((TDBG_ConsultaCabecera.Columns(0).Value))
    End Sub

    'FIXIT: Declare 'Bookmark' con un tipo de datos de enlace en tiempo de compilación         FixIT90210ae-R1672-R1B8ZE
    'UPGRADE_NOTE: Split se actualizó a Split_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub TDBG_ConsultaDetalle_FetchRowStyle(ByVal Split_Renamed As Short, ByRef Bookmark As Object, ByVal RowStyle As TrueOleDBGrid70.StyleDisp)
        Dim rsX As ADODB.Recordset
        rsX = rsdetalle.Clone(ADODB.LockTypeEnum.adLockReadOnly)
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Bookmark. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        rsX.Bookmark = Bookmark
        If rsX.Fields("detcomprobauto").Value Then
            RowStyle.BackColor = System.Convert.ToUInt32(RGB(185, 251, 236))
        End If
    End Sub

    Private Sub txt_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyDownEvent) Handles txt.KeyDownEvent
        Dim Index As Short = txt.GetIndex(eventSender)
        If Index = 1 Then
            If eventArgs.keyCode = 13 Then Call EjecutarConsulta()
        End If
    End Sub
End Class