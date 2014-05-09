Option Strict Off
Option Explicit On
Friend Class frmRepPlanCuentasSaldosIniciales
	Inherits System.Windows.Forms.Form
	
	Private Sub frmRepPlanCuentasSaldosIniciales_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
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
        Ctr_Ayuda1.conexion(VGCNx)
    End Sub
	Sub imprimir()
        Dim arrparam(3) As Object
        Dim arrform(1) As Object
        arrparam(0) = VGCNx.DefaultDatabase
        arrparam(1) = VGParametros.empresacodigo
        arrparam(2) = VGParamSistem.Anoproceso
        arrform(0) = "ano='" & VGParamSistem.Anoproceso & "'"
		
		Call ImpresionRptProc("ct_saldosiniciales.rpt", arrform, arrparam,  , "Saldos iniciales")
	End Sub
End Class