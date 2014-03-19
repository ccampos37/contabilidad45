Option Strict Off
Option Explicit On
Friend Class frmRepPlanCuentas
	Inherits System.Windows.Forms.Form
	
	Private Sub frmRepPlanCuentas_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Option1(0).Checked = True
		Option2(0).Checked = True
		Call Llenarcboniveles()
		Call ConfiguraForm()
	End Sub
	
	Sub Llenarcboniveles()
		Dim i As Short
		For i = 1 To VGnumnivelescuenta
			cboNiveles.Items.Add("NIVEL " & VB6.Format(i, "0#"))
		Next 
	End Sub
	
	'UPGRADE_WARNING: El evento Option2.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Option2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option2.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = Option2.GetIndex(eventSender)
			Select Case Index
				Case 0 : cboNiveles.Enabled = True
				Case 1 : cboNiveles.Enabled = False
			End Select
		End If
	End Sub
	
	Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBotones.Click
		Dim Index As Short = cmdBotones.GetIndex(eventSender)
		Select Case Index
			Case 0
				
			Case 1 : Me.Close()
				
		End Select
		
	End Sub
	
	Sub ConfiguraForm()
		
		Ctr_Ayuda1.Conexion(VGCNx)
	End Sub
End Class