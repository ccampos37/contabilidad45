Option Strict Off
Option Explicit On
Friend Class frmannos
	Inherits System.Windows.Forms.Form
	Dim rsannos As ADODB.Recordset
	Dim SQL As String
	
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		On Error GoTo Actmes
		If rsannos.RecordCount = 0 Then Exit Sub
		VGCNx.BeginTrans()
		SQL = "UPDATE dbo.CT_General set " & ActualizaMeses & " Where " & "generalanno='" & rsannos.Fields("generalanno").Value & "'"
		VGCNx.Execute(SQL)
		VGCNx.CommitTrans()
		Me.Close()
		Exit Sub
Actmes: 
		VGCNx.RollbackTrans()
		MsgBox("Hubo Errores al Actualizar los meses " & Chr(13) & Err.Description)
		
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		Me.Close()
	End Sub
	Private Function ActualizaMeses() As String
		Dim I As Short
		SQL = ""
		For I = 1 To 12
			'UPGRADE_WARNING: El límite inferior de la colección LV_Meses.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			SQL = SQL & "generalmes" & VB6.Format(I, "00") & "=" & IIf(LV_Meses.Items.Item(I).Checked, 1, 0)
			If I <= 11 Then SQL = SQL & ","
		Next 
		ActualizaMeses = SQL
	End Function
	Public Sub cmdGenerar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGenerar.Click
		'Cargando la plantilla de las tablasç
		On Error GoTo xtrans
		If Not VeriExisteAño Then Exit Sub
		
		RichCom.LoadFile(My.Application.Info.DirectoryPath & "\plantillatablasano.sql")
        'If Trim(RichCom.FileName) = "" Then
        '    MsgBox("No se ha encontrado el archivo " & My.Application.Info.DirectoryPath & "\" & " plantillatablasano.sql " & Chr(13) & "en la Ruta especificada", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		RichCom.Text = Replace(RichCom.Text, "xxxx", VB6.Format(Year(DTPanno.Value), "0000"))
		VGCNx.BeginTrans()
		Call EjecutarLote(RichCom, VGCNx)
		'Grabando el Año
		SQL = "Insert Into ct_general(generalanno) values('" & Year(DTPanno.Value) & "')"
		VGCNx.Execute(SQL)
		VGCNx.CommitTrans()
		'Cargando los Meses por primera vez
		If rsannos.RecordCount = 0 Then
			Call CargarMeses()
		End If
		rsannos.Requery()
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		MsgBox("El año se genero Satisfactoriamente ", MsgBoxStyle.Information)
		Exit Sub
xtrans: 
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		MsgBox("Hubo Errores al generar el nuevo año " & Chr(13) & Err.Description)
		VGCNx.RollbackTrans()
		Exit Sub
		Resume 
	End Sub
	Private Function VeriExisteAño() As Boolean
		Dim rsaux As ADODB.Recordset
		rsaux = New ADODB.Recordset
		VeriExisteAño = False
		rsaux.Open("select * from ct_general where generalanno='" & Year(DTPanno.Value) & "'", VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		If rsaux.RecordCount > 0 Then
			MsgBox("El año de ejercicio " & Year(DTPanno.Value) & " ya se genero ", MsgBoxStyle.Information)
			Exit Function
		End If
		VeriExisteAño = True
	End Function
	
	Private Sub frmannos_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Height = VB6.TwipsToPixelsY(6060)
		Me.Width = VB6.TwipsToPixelsX(4980)
		rsannos = New ADODB.Recordset
		rsannos.Open("ct_general", VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
		If rsannos.RecordCount > 0 Then
			Call CargarMeses()
		End If
		TDB_Anno.DataSource = rsannos
	End Sub
	Private Sub CargarMeses()
		Dim items As System.Windows.Forms.ListView.ListViewItemCollection
		Dim I As Short
		VGvardllgen = New dllgeneral.dll_general
		items = LV_Meses.Items
		For I = 1 To 12
			'UPGRADE_WARNING: El límite inferior de la colección items.ImageList cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			'UPGRADE_WARNING: El límite inferior de la colección items cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			'UPGRADE_WARNING: La propiedad Image no se actualizó Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="D94970AE-02E7-43BF-93EF-DCFCD10D27B5"'
			items.Insert(I, VB6.Format(I, "C0"), DesMes(VB6.Format(I, "00")), 1)
		Next 
	End Sub
	Private Sub ActivarMeses()
		Dim I As Short
		For I = 1 To rsannos.Fields.Count - 1
			'UPGRADE_WARNING: El límite inferior de la colección LV_Meses.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			LV_Meses.Items.Item(I).Checked = rsannos.Fields(I).Value
		Next 
	End Sub
	
	Private Sub LV_Meses_ItemCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ItemCheckEventArgs) Handles LV_Meses.ItemCheck
		Dim Item As System.Windows.Forms.ListViewItem = LV_Meses.Items(eventArgs.Index)
		'Item.Checked = Not Item.Checked
	End Sub
	
	'FIXIT: Declare 'LastRow' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
	Private Sub TDB_Anno_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_RowColChangeEvent) Handles TDB_Anno.RowColChange
		If rsannos.RecordCount = 0 Then Exit Sub
		Call ActivarMeses()
	End Sub
End Class