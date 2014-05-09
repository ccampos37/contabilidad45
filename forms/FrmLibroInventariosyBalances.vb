Option Strict Off
Option Explicit On
Friend Class FrmLibroInventariosyBalances
	Inherits System.Windows.Forms.Form
	Dim rs As New ADODB.Recordset
	Dim rs1 As ADODB.Recordset
    Private Sub Check1_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check1.CheckStateChanged


    End Sub
	Private Sub LlenarLista(ByRef rss As ADODB.Recordset, ByRef Tip As Short)

		Dim itmX As System.Windows.Forms.ListViewItem
		
		ListView1.Columns.Clear()
		ListView1.Items.Clear()
        ListView1.Columns.Add("", "Tipo de Reporte", CInt((ListView1.Width) / 1))
		ListView1.View = System.Windows.Forms.View.Details
		Do While Not rss.EOF
			itmX = ListView1.Items.Add(Str(rss.Fields("correlativo").Value + 0) & "  " + rss.Fields("formatocodigo").Value + "  " + rss.Fields("formatodescripcion2").Value)
			'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			ListView1.Items.Item(rss.Fields("correlativo").Value + 0).Checked = Tip
			rss.MoveNext()
		Loop 
		
	End Sub
	
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

        If ExisteElem(0, VGCNx, VGcomputer) Then VGCNx.Execute(" drop table " & VGcomputer)
        VGCNx.Execute(" create table " & VGcomputer & "( formato varchar(20) , reportegrupo int )")
        rs.MoveFirst()
        Do While Not rs.EOF
            'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If ListView1.Items.Item(rs.Fields("correlativo").Value + 0).Checked = True Then
                SQL = " insert " & VGcomputer & "( formato, reportegrupo ) values ('" & rs.Fields("formatocodigo").Value & "'," & rs.Fields("reportegrupo").Value & ")"
                VGCNx.Execute(SQL)
            End If
            rs.MoveNext()
        Loop
        rs = VGCNx.Execute(" select * from " & VGcomputer & "")
        If rs.RecordCount > 0 Then
            Call imprimir()
        End If
    End Sub
	
    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Me.Close()
    End Sub
	
	Private Sub FrmLibroInventariosyBalances_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		FrameCuentas.Visible = True
		Check1.CheckState = System.Windows.Forms.CheckState.Checked
	End Sub
	
	Private Sub imprimir()
		Dim aparam(6) As Object
		Dim aform(1) As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aform(0) = "empresa='" & VGParametros.NomEmpresa & "'"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(0) = VGCNx.DefaultDatabase
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(3) = VGParamSistem.Mesproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(4) = "2"
		rs.MoveFirst()
		Do While Not rs.EOF
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			aparam(5) = rs.Fields("Formato").Value
			If rs.Fields("reportegrupo").Value = 1 Then
				Call ImpresionRptProc("ct_Libro03_03_06_12_13.rpt", aform, aparam,  , "LIbro de Inventarios y Balances")
			ElseIf rs.Fields("reportegrupo").Value = 2 Then 
				Call ImpresionRptProc("ct_Libro03_11_14.rpt", aform, aparam,  , "LIbro de Inventarios y Balances")
			ElseIf rs.Fields("reportegrupo").Value = 3 Then 
				Call ImpresionRptProc("ct_Libro03_11_14.rpt", aform, aparam,  , "LIbro de Inventarios y Balances")
			End If
			
			rs.MoveNext()
		Loop 
		
		
	End Sub

    Private Sub Check1_CheckedChanged(sender As Object, e As EventArgs) Handles Check1.CheckedChanged
        Dim tipo As Short
        tipo = Check1.CheckState

        FrameCuentas.Visible = True
        SQL = " select formatocodigo,correlativo ,formatodescripcion2, reportegrupo  from ct_formatos where LibroSUNATCodigo =3 "
        SQL = SQL & " AND reporteGrupo>=1 order by correlativo "
        rs = VGCNx.Execute(SQL)
        Call LlenarLista(rs, tipo)
    End Sub
End Class