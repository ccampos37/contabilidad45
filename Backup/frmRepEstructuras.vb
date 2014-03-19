Option Strict Off
Option Explicit On
Friend Class frmRepEstructuras
	Inherits System.Windows.Forms.Form
	
	'UPGRADE_WARNING: El evento cboTipoReporte.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboTipoReporte_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTipoReporte.SelectedIndexChanged
		cmdBotones(0).Focus()
	End Sub
	
	Private Sub frmRepEstructuras_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call LlenarcboTipoReporte()
		ProgressBar1.Visible = False
		Call ConfiguraForm()
	End Sub
	
	Sub LlenarcboTipoReporte()
		cboTipoReporte.Items.Clear()
		cboTipoReporte.Items.Add("Balance General")
		cboTipoReporte.Items.Add("Estado de Ganáncias y Pérdidas")
	End Sub
	
	Sub ConfiguraForm()
		Width = VB6.TwipsToPixelsX(5190)
		Height = VB6.TwipsToPixelsY(2655)
		'Left = (MDIPrincipal.Width - Me.Width) / 2
		'Top = ((MDIPrincipal.Height - Me.Height) / 2) - 600
	End Sub
	
	Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBotones.Click
		Dim Index As Short = cmdBotones.GetIndex(eventSender)
		Select Case Index
			Case 0
				Call prueba()
				
			Case 1 : Me.Close()
				
		End Select
		
	End Sub
	
	Sub prueba()
		ProgressBar1.Minimum = 1
		ProgressBar1.Maximum = 100
		ProgressBar1.Visible = True
		
		ProgressBar1.Value = 10
		
		ProgressBar1.Value = 30
		
		ProgressBar1.Value = 50
		
		ProgressBar1.Value = 60
		
		'ProgressBar1.Value = 100
		
		'ProgressBar1.Visible = False
		
	End Sub
End Class