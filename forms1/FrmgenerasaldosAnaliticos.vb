Option Strict Off
Option Explicit On
Friend Class FrmgenerasaldosAnaliticos
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim SQL As String
		On Error GoTo xx
		If MsgBox("Desea continuar ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
			Exit Sub
		End If
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		VGCNx.BeginTrans()
		
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_GeneraCtaCteApertura_pro"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@annoact").Value = VGParamSistem.Anoproceso
			.Parameters("@annopas").Value = Trim(CStr(CDbl(VGParamSistem.Anoproceso) - 1))
			.Parameters("@NombrePC").Value = VGcomputer
			.Execute()
		End With
		VGCNx.CommitTrans()
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox("Se Genero la Cuenta Corriente de Apertura del Año " & VGParamSistem.Anoproceso, MsgBoxStyle.Information)
		Command1.Enabled = False
		Exit Sub
xx: 
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		VGCNx.RollbackTrans()
		MsgBox("No se pudo Aperturar la Cuenta Corriente " & Chr(13) & Err.Description, MsgBoxStyle.Exclamation)
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
	End Sub
	
	Private Sub FrmgenerasaldosAnaliticos_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Text1.Text = CStr(CDbl(VGParamSistem.Anoproceso) - 1)
		Text2.Text = VGParamSistem.Anoproceso
	End Sub
End Class