Option Strict Off
Option Explicit On
Friend Class frmRepEstructuras
	Inherits System.Windows.Forms.Form
	
	'UPGRADE_WARNING: El evento cboTipoReporte.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboTipoReporte_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTipoReporte.SelectedIndexChanged
        cmdBotones0.Focus()
	End Sub
	
	Private Sub frmRepEstructuras_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call LlenarcboTipoReporte()
		ProgressBar1.Visible = False

	End Sub
	
	Sub LlenarcboTipoReporte()
		cboTipoReporte.Items.Clear()
		cboTipoReporte.Items.Add("Balance General")
		cboTipoReporte.Items.Add("Estado de Ganáncias y Pérdidas")
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

    Private Sub cmdBotones0_Click(sender As Object, e As EventArgs) Handles cmdBotones0.Click
        Call prueba()

    End Sub

    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
        Me.Close()

    End Sub
End Class