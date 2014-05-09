Option Strict Off
Option Explicit On
Friend Class FrmCreacionEmpresa
	Inherits System.Windows.Forms.Form
	Dim RSAUX As New ADODB.Recordset
	Dim Rsql1 As New ADODB.Recordset
	Dim modificar As Short
	Dim codigo As String
	
	
	Private Sub CmdModificar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdModificar.Click
		Text1.Text = RSAUX.Fields("empresacodigo").Value
		Text2.Text = RSAUX.Fields("empresadescripcion").Value
		Text3.Text = RSAUX.Fields("empresadireccion").Value
		Text4.Text = RSAUX.Fields("empresaruc").Value
		Text1.Enabled = False
		SSTab1.SelectedIndex = 1
		modificar = 1
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Text1.Text = codigo
		SSTab1.SelectedIndex = 1
		modificar = 0
	End Sub
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
	End Sub
	
	Private Sub cmdgrabar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdgrabar.Click
		If modificar = 0 Then
			SQL = " insert co_multiempresas ( empresacodigo, empresadescripcion,empresadireccion, empresaruc )"
			SQL = SQL & " values ( '" & Text1.Text & "','" & Text2.Text & "','" & Text3.Text & "','" & Text4.Text & "')"
			Rsql1 = VGCNx.Execute(SQL)
			Call adicionaregistros()
		Else
			SQL = " update co_multiempresas set empresadescripcion='" & Text2.Text & "',empresadireccion='" & Text3.Text & "',"
			SQL = SQL & "empresaruc='" & Text4.Text & "' where empresacodigo='" & Text1.Text & "'"
			Rsql1 = VGCNx.Execute(SQL)
		End If
		Call cargar()
		SSTab1.SelectedIndex = 0
	End Sub
	Private Sub adicionaregistros()
		'  -------  plan de cuentas
		If ExisteElem(0, VGCNx, "" & VGcomputer & "") Then VGCNx.Execute("drop table " & VGcomputer & "")
		SQL = "select * into " & VGcomputer & " from ct_cuenta "
		SQL = SQL & " where empresacodigo='" & Ctr_Ayuempresa.xclave & "'"
		Rsql1 = VGCNx.Execute(SQL)
		'
		SQL = "update " & VGcomputer & " set empresacodigo='" & Text1.Text & "'"
		Rsql1 = VGCNx.Execute(SQL)
		'
		SQL = "insert ct_cuenta select * from  " & VGcomputer & ""
		Rsql1 = VGCNx.Execute(SQL)
		' --------------  asiento
		SQL = " insert ct_asientocorre ( empresacodigo,asientocodigo,asientoanno )"
		SQL = SQL & " select '" & Text1.Text & "',asientocodigo,'" & VGParamSistem.Anoproceso & "'"
		SQL = SQL & " from ct_asientocorre where empresacodigo='" & Ctr_Ayuempresa.xclave & "'"
		SQL = SQL & " and asientoanno='" & VGParamSistem.Anoproceso & "'"
		Rsql1 = VGCNx.Execute(SQL)
		'
		' --------------  libro
		SQL = " insert ct_librocorre ( empresacodigo,librocodigo,libroanno )"
		SQL = SQL & " select '" & Text1.Text & "',librocodigo,'" & VGParamSistem.Anoproceso & "'"
		SQL = SQL & " from ct_librocorre where empresacodigo='" & Ctr_Ayuempresa.xclave & "'"
		SQL = SQL & " and libroanno='" & VGParamSistem.Anoproceso & "'"
		Rsql1 = VGCNx.Execute(SQL)
		' --------------  centro de costos
		If ExisteElem(0, VGCNx, "" & VGcomputer & "") Then VGCNx.Execute("drop table " & VGcomputer & "")
		SQL = "select * into " & VGcomputer & " from ct_centrocosto "
		SQL = SQL & " where empresacodigo='" & Ctr_Ayuempresa.xclave & "'"
		Rsql1 = VGCNx.Execute(SQL)
		'
		SQL = "update " & VGcomputer & " set empresacodigo='" & Text1.Text & "'"
		Rsql1 = VGCNx.Execute(SQL)
		'
		SQL = "insert ct_centrocosto select * from  " & VGcomputer & ""
		Rsql1 = VGCNx.Execute(SQL)
		
		Call cargar()
		SSTab1.SelectedIndex = 0
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		SSTab1.SelectedIndex = 0
	End Sub
	
	
	Private Sub FrmCreacionEmpresa_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Ctr_Ayuempresa.Conexion(VGCNx)
		If VGParametros.MultiEmpresas = False Then
			MsgBox(" Sistema no esta habilitado para varias empresas ")
			Command1.Enabled = False
			'   Exit Sub
		End If
		SSTab1.SelectedIndex = 0
		Call cargar()
	End Sub
	Private Sub cargar()
		'UPGRADE_NOTE: El objeto RSAUX no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		RSAUX = Nothing
		SQL = "select * from co_multiempresas"
		RSAUX = VGCNx.Execute(SQL)
		DataGrid1.DataSource = RSAUX
		'UPGRADE_NOTE: Refresh se actualizó a CtlRefresh. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        DataGrid1.Refresh()
		Rsql1 = VGCNx.Execute("select codigo=max(empresacodigo)+1 from co_multiempresas where empresacodigo<'90'")
        codigo = Format(Rsql1.Fields("codigo").Value, "00")
	End Sub
End Class