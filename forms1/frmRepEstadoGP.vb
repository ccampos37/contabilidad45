Option Strict Off
Option Explicit On
Friend Class xxxfrmRepEstadoGP
	Inherits System.Windows.Forms.Form
	
	Private Sub xxxfrmRepEstadoGP_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call LlenarcboTipoReporte()
		
	End Sub
	
	'UPGRADE_WARNING: El evento cboTipoReporte.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboTipoReporte_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTipoReporte.SelectedIndexChanged
		cmdBotones(0).Focus()
		Select Case cboTipoReporte.SelectedIndex
			Case 0
				
			Case 1
				
			Case 2
				
		End Select
	End Sub
	
	Sub LlenarcboTipoReporte()
		cboTipoReporte.Items.Clear()
		cboTipoReporte.Items.Add("Estado de Ganancias y Pérdidas")
		cboTipoReporte.Items.Add("Sustento de Estado de Ganancias y Pérdidas")
		cboTipoReporte.Items.Add("Resumen de Estado de Ganacias y Pérdidas")
	End Sub
	
	Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBotones.Click
		Dim Index As Short = cmdBotones.GetIndex(eventSender)
		Select Case Index
			Case 0
				
			Case 1 : Me.Close()
				
		End Select
		
	End Sub
End Class