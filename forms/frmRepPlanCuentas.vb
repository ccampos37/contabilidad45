Option Strict Off
Option Explicit On
Friend Class frmRepPlanCuentas
	Inherits System.Windows.Forms.Form
	
	Private Sub frmRepPlanCuentas_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Option10.Checked = True
        Option20.Checked = True
		Call Llenarcboniveles()
		Call ConfiguraForm()
	End Sub
	
	Sub Llenarcboniveles()
		Dim i As Short
		For i = 1 To VGnumnivelescuenta
            cboNiveles.Items.Add("NIVEL " & Format(i, "0#"))
		Next 
	End Sub

	
	Sub ConfiguraForm()
		
		Ctr_Ayuda1.Conexion(VGCNx)
	End Sub

    Private Sub Option20_CheckedChanged(sender As Object, e As EventArgs) Handles Option20.CheckedChanged
        If Option20.Checked = True Then cboNiveles.Enabled = True
    End Sub

    Private Sub Option21_CheckedChanged(sender As Object, e As EventArgs) Handles Option21.CheckedChanged
        If Option21.Checked = True Then cboNiveles.Enabled = False
    End Sub

    Private Sub cmdBotones0_Click(sender As Object, e As EventArgs) Handles cmdBotones0.Click
        '     Call imprimir()
    End Sub

    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
        Me.Close()
    End Sub
End Class