Option Strict Off
Option Explicit On
Friend Class xxxfrmRepEstadoGP
	Inherits System.Windows.Forms.Form
	
	Private Sub xxxfrmRepEstadoGP_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call LlenarcboTipoReporte()
		
	End Sub
	
    Sub LlenarcboTipoReporte()
        cboTipoReporte.Items.Clear()
        cboTipoReporte.Items.Add("Estado de Ganancias y Pérdidas")
        cboTipoReporte.Items.Add("Sustento de Estado de Ganancias y Pérdidas")
        cboTipoReporte.Items.Add("Resumen de Estado de Ganacias y Pérdidas")
    End Sub
	
    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
        Me.Close()
    End Sub

    Private Sub mdBotones0_Click(sender As Object, e As EventArgs) Handles mdBotones0.Click

    End Sub
End Class