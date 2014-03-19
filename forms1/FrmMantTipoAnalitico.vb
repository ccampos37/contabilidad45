Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FrmMantTipoAnalitico
	Inherits System.Windows.Forms.Form
	
	Dim resp As String
    Dim nTra As Integer
	Dim rs As New ADODB.Recordset

	
	Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command9.Click
		DbGrid1.Visible = True
		Frame5.Visible = True
		Frame2.Visible = True
		Frame4.Visible = False
		Frame3.Visible = False
		
		DbGrid1.Focus()
	End Sub
	
    Private Sub TxFiltro_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxFiltro.TextChanged
        Dim ncondi As String
        'If RS.RecordCount > 0 Then
        If Trim(TxFiltro.Text) <> "" Then
            If CmbOrden.SelectedIndex = 0 Then
                ncondi = Trim(UCase(TxFiltro.Text)) & "%"
            ElseIf CmbOrden.SelectedIndex = 1 Then
                ncondi = Trim(UCase(TxFiltro.Text)) & "%"
            End If
        Else
            ncondi = "SELECT * FROM ct_tipoanalitico"
        End If
        Call Listado(ncondi)
        'End If
    End Sub
	
    Private Sub CmbOrden_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmbOrden.SelectedIndexChanged ' Ordenar por
        Dim nCom As Short
        Dim nsql As String

        nCom = CmbOrden.SelectedIndex

        Select Case nCom
            Case 0
                'Data1.RecordSource = "Select * from TABUNIMED  order by UM_ABREV"
                nsql = "Select * from ct_tipoanalitico  order by tipoanaliticocodigo"
                Call Listado(nsql)
            Case 1
                'Data1.RecordSource = "Select * from TABUNIMED  order by UM_NOMBRE"
                nsql = "Select * from ct_tipoanalitico  order by tipoanaliticodescripcion"
                Call Listado(nsql)
        End Select
        TxFiltro.Text = ""
    End Sub
	
	Private Sub DataGrid1_KeyPress(ByRef KeyAscii As Short)
		If KeyAscii = System.Windows.Forms.Keys.Back Then
			If Len(TxFiltro.Text) - 1 > 0 Then
				TxFiltro.Text = VB.Left(TxFiltro.Text, Len(TxFiltro.Text) - 1)
			Else
				TxFiltro.Text = ""
			End If
			KeyAscii = 0
		ElseIf KeyAscii <> 13 Then 
			TxFiltro.Text = TxFiltro.Text & Chr(KeyAscii)
		End If
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		resp = "S"
		Limpiar()
		Text1.Enabled = True
		DbGrid1.Visible = False
		Frame2.Visible = False
		Frame5.Visible = False
		Frame3.Text = "Ingreso de Tipo de AnaliticoS"
		
		Frame4.Visible = True
		Frame3.Visible = True
		Text1.Focus()
	End Sub
	
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		If rs.RecordCount > 0 Then
			Limpiar()
			resp = "N"
			Frame3.Text = "Modificación de Tipo de AnaliticoS"
			DbGrid1.Visible = False
			Frame2.Visible = False
			Frame5.Visible = False
			Frame4.Visible = True
			Frame3.Visible = True
			
			Text1.Text = rs.Fields("tipoanaliticocodigo").Value
			Text1.Enabled = False
            If Not IsDBNull(rs.Fields("tipoanaliticodescripcion").Value) Then
                Text2.Text = rs.Fields("tipoanaliticodescripcion").Value
            Else
                Text2.Text = ""
            End If
			Text2.Focus()
		End If
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		On Error GoTo EliErr
		Dim cSql1 As String
		Dim CSQL2, cSql3 As String
		Dim cCodigo1 As String
		Dim cSel1 As ADODB.Recordset
		Dim cCodigo As String
		Dim cSqlA As String
		Dim cSelA As ADODB.Recordset
		If rs.RecordCount > 0 Then
            cSqlA = "Select * FROM ct_Analitico WHERE tipoanaliticocodigo = '" & Trim(DbGrid1.Columns(0).Text) & "'"
			cSelA = New ADODB.Recordset
			cSelA.Open(cSqlA, VGCNx, ADODB.CursorTypeEnum.adOpenStatic)
			If Not cSelA.EOF Then
				MsgBox("Este Archivo Tiene enlace con Documentos no puede eliminarlo")
				cSelA.Close()
				Exit Sub
			End If
			cSelA.Close()
			
			cSql1 = "delete ct_tipoanalitico where tipoanaliticocodigo='" & Trim(DbGrid1.Columns(0).Text) & "'"
			If MsgBox("Seguro de Eliminar", MsgBoxStyle.Question + MsgBoxStyle.OKCancel, mensaje1) = MsgBoxResult.OK Then
                nTra = 1
				VGCNx.BeginTrans()
				VGCNx.Execute(cSql1)
				VGCNx.CommitTrans()
				nTra = 0
				rs = VGCNx.Execute("Select * from ct_tipoanalitico  order by tipoanaliticocodigo")
				Call Listado("")
			End If
            DbGrid1.Refresh()
            If DbGrid1.Visible Then DbGrid1.Focus()
        Else
            MsgBox("No existe ningún registro para Eilminar", MsgBoxStyle.Information, mensaje1)
        End If
        Exit Sub
EliErr:
        MsgBox(Err.Description)
        If nTra = 1 Then VGCNx.RollbackTrans()
    End Sub

    Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
        Me.Close()
    End Sub

    Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
        If resp = "S" Then
            If Text1.Text = "" Then
                MsgBox("Ingrese Código de Tipo de Analitico", MsgBoxStyle.Information, "Mensaje")
                Text1.Focus()
                Exit Sub
            Else
                If Existe(1, Trim(Text1.Text), "ct_tipoanalitico", "tipoanaliticocodigo", False) Then
                    MsgBox("El código de Tipo de Analitico ya existe", MsgBoxStyle.Information, "Mensaje")
                    Text1.Focus()
                    Exit Sub
                End If
            End If
        End If

        If Text2.Text = "" Then
            MsgBox("Ingrese Nombre de Tipo de Analitico", MsgBoxStyle.Exclamation, "Aviso")
            Text2.Focus()
            Exit Sub
        End If

        If resp = "S" Then
            SQL = "INSERT INTO ct_tipoanalitico (tipoanaliticocodigo,tipoanaliticodescripcion)"
            SQL = SQL & "VALUES ('" & Text1.Text & "','" & Text2.Text & "')"

            VGCNx.Execute(SQL)
            Call Listado("SELECT * FROM ct_tipoanalitico")

            Limpiar()
            Call Command9_Click(Command9, New System.EventArgs())

        Else
            VGCNx.Execute("UPDATE ct_tipoanalitico " & " SET tipoanaliticodescripcion ='" & Text2.Text & "'" & " WHERE tipoanaliticocodigo ='" & Text1.Text & "'")
            Call Listado("SELECT * FROM ct_tipoanalitico")
            Call Command9_Click(Command9, New System.EventArgs())
        End If
        DbGrid1.Visible = True
    End Sub
    Sub Limpiar()
        Text1.Text = ""
        Text2.Text = ""
    End Sub
    Private Sub FrmMantTipoAnalitico_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        TxFiltro.Text = ""
        CmbOrden.SelectedIndex = 0
        If DbGrid1.Visible Then DbGrid1.Focus()
    End Sub

    Private Sub FrmMantTipoAnalitico_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        rs = VGCNx.Execute("Select * from ct_tipoanalitico  order by tipoanaliticodescripcion")
        Call Listado("")
    End Sub
    Sub Listado(ByRef wcad As Object)
        DbGrid1.DataSource = Nothing
        If Trim(TxFiltro.Text) <> "" And TxFiltro.Visible Then
            Select Case CmbOrden.SelectedIndex
                Case 0
                    rs = VGCNx.Execute("SELECT * FROM ct_tipoanalitico WHERE tipoanaliticocodigo LIKE '%" & wcad & "' ORDER BY 1")
                Case 1
                    rs = VGCNx.Execute("SELECT * FROM ct_tipoanalitico WHERE tipoanaliticodescripcion LIKE '%" & wcad & "' ORDER BY 2 ")
            End Select
            If rs.EOF Then rs = VGCNx.Execute("SELECT * FROM ct_tipoanalitico ")
        Else
            Select Case CmbOrden.SelectedIndex
                Case 0
                    rs = VGCNx.Execute("SELECT * FROM ct_tipoanalitico ORDER BY tipoanaliticocodigo")
                Case 1
                    rs = VGCNx.Execute("SELECT * FROM ct_tipoanalitico ORDER BY tipoanaliticodescripcion ")
            End Select
        End If
        DbGrid1.DataSource = rs
        With DbGrid1
            .Columns(0).Caption = "Codigo"
            .Columns(0).Width = VB6.TwipsToPixelsX(1000)
            .Columns(1).Caption = "Descripcion"
            .Columns(1).Width = VB6.TwipsToPixelsX(3800)
            .MarqueeStyle = MSDataGridLib.MarqueeStyleConstants.dbgHighlightRow
            .Refresh()
        End With
    End Sub
    Private Sub Text1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text1.Enter
        Enfoque(Text1)
    End Sub
	
	Private Sub Text1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            If Trim(Text1.Text) <> "" Then
                If Existe(1, Trim(Text1.Text), "ct_tipoanalitico", "tipoanaliticocodigo", False) Then
                    MsgBox("El código de Tipo de Analitico ya existe", MsgBoxStyle.Information, "Mensaje")
                    Text1.Text = "" : Text1.Focus()
                    GoTo EventExitSub
                End If
            Else
                MsgBox("Ingrese código de Tipo de Analitico ", MsgBoxStyle.Information, "Mensaje")
                Text1.Text = "" : Text1.Focus()
            End If
            Text2.Focus()
        Else
            KeyAscii = Asc(UCase(Chr(KeyAscii)))
        End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub Text2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text2.Enter
		Enfoque(Text2)
	End Sub
	
	Private Sub Text2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			If Trim(Text2.Text) = "" Then
				MsgBox("Ingrese descripcion del Tipo de Analitico", MsgBoxStyle.Information, "Mensaje")
				Text2.Text = "" : Text2.Focus()
			End If
			Command8.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class