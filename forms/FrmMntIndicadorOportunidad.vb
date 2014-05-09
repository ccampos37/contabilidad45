Option Strict Off
Option Explicit On
Friend Class FrmMntIndicadorOportunidad
	Inherits System.Windows.Forms.Form
	'UPGRADE_WARNING: El evento Check1.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Check1_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check1.CheckStateChanged
		If Check1.CheckState = 1 Then Call LlenarLista()
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Call grabar()
		Command1.Visible = False
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
	End Sub
	
	Private Sub FrmMntIndicadorOportunidad_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Text1.Text = VGParametros.empresacodigo & " - " & VGParametros.NomEmpresa
		Text2.Text = VGParametros.RucEmpresa
		Call LlenarLista()
	End Sub
	Private Sub LlenarLista()
		Dim I As Short
		Dim itmX As System.Windows.Forms.ListViewItem
		Dim rs1 As New ADODB.Recordset
		Dim rs2 As New ADODB.Recordset
		ListView1.Columns.Clear()
		ListView1.Items.Clear()
        ListView1.Columns.Add("", "Presentacion de Libro", CInt((ListView1.Width) / 1))
		ListView1.View = System.Windows.Forms.View.Details
		rs1 = VGCNx.Execute("select * from ct_librossunatcorrelativos ")
		rs1.MoveFirst()
        I = 0
		Do While Not rs1.EOF
			itmX = ListView1.Items.Add(IIf(rs1.Fields("LibrosunatEstadoAnulado").Value = True, "               ", "Por Usar  ") + rs1.Fields("librocodigosunat").Value + "  " + rs1.Fields("libroCorrelativodescripcion").Value)
			If Check1.CheckState = 0 Then
				SQL = " select * from ct_librossunatxempresa where empresacodigo='" & VGParametros.empresacodigo & "'"
				SQL = SQL & " and librocodigosunat='" & rs1.Fields("librocodigosunat").Value & "'"
				rs2 = VGCNx.Execute(SQL)
                If rs2.RecordCount = 0 Then
                    'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    ListView1.Items.Item(I + 0).Checked = False
                Else
                    'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    ListView1.Items.Item(I + 0).Checked = rs2.Fields("estadoregistro").Value
                End If
			Else
				'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                ListView1.Items.Item(I + 0).Checked = True
			End If
			I = I + 1
			rs1.MoveNext()
		Loop 
	End Sub
	
	
	
	Private Sub grabar()
		Dim rs1 As New ADODB.Recordset
		SQL = "select * from ct_librossunatcorrelativos a"
		rs1 = VGCNx.Execute(SQL)
		Dim I As Short
		Dim rs2 As New ADODB.Recordset
        I = 0
		Do While Not rs1.EOF
			SQL = " select * from ct_LibrosSunatxEmpresa where empresacodigo='" & VGParametros.empresacodigo & "'"
			SQL = SQL & " and librocodigosunat='" & rs1.Fields("librocodigosunat").Value & "'"
			rs2 = VGCNx.Execute(SQL)
			If ListView1.Items.Item(I + 0).Checked = 0 Or rs1.Fields("LibrosunatEstadoAnulado").Value = 1 Then
				If rs2.RecordCount > 0 Then
					SQL = " delete ct_LibrosSunatxEmpresa where empresacodigo='" & VGParametros.empresacodigo & "'"
					SQL = SQL & " and librocodigosunat='" & rs1.Fields("librocodigosunat").Value & "'"
					rs2 = VGCNx.Execute(SQL)
				End If
			Else
				If rs2.RecordCount = 0 Then
					SQL = "Insert ct_LibrosSunatxEmpresa ( empresacodigo, librocodigosunat, estadoregistro)"
					SQL = SQL & "values('" & VGParametros.empresacodigo & "','" & rs1.Fields("librocodigosunat").Value & "',1)"
					rs2 = VGCNx.Execute(SQL)
				End If
			End If
			I = I + 1
			rs1.MoveNext()
		Loop 
		
	End Sub
End Class