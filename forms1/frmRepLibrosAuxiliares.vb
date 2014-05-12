Option Strict Off
Option Explicit On
Friend Class frmRepLibrosAuxiliares
	Inherits System.Windows.Forms.Form
	Const N_OPCIONES_CAJABANCOS As Short = 2
	Const N_OPCIONES_LIBROSAUX As Short = 5
	Dim aOpcionLibroaux(N_OPCIONES_LIBROSAUX) As Short
	
	Private Sub frmRepLibrosAuxiliares_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call LlenarcboLibroAuxiliar()
		Call ConfiguraForm()
	End Sub
	
	Sub LlenarcboLibroAuxiliar()
		Dim i As Short
		cboLibroAuxiliar.Items.Add("Caja y Bancos")
		cboLibroAuxiliar.Items.Add("Registro de Compras")
		cboLibroAuxiliar.Items.Add("Registro de Ventas")
		cboLibroAuxiliar.Items.Add("Letras x Pagar")
		cboLibroAuxiliar.Items.Add("Letras x Cobrar")
		For i = 0 To N_OPCIONES_LIBROSAUX
			aOpcionLibroaux(i) = i + 1
		Next 
	End Sub
	
	'UPGRADE_WARNING: El evento optOpcion.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optOpcion_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optOpcion.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optOpcion.GetIndex(eventSender)
			ConfiguraSeleccion((Index))
		End If
	End Sub
	
	'UPGRADE_WARNING: El evento cboLibroAuxiliar.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboLibroAuxiliar_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLibroAuxiliar.SelectedIndexChanged
		Select Case cboLibroAuxiliar.SelectedIndex
			Case 0
				fraCajaBancos.Enabled = True
				Call ConfiguraOpcionCajaBancos(True)
				
			Case 1, 2, 3, 4
				fraCajaBancos.Enabled = False
				Call ConfiguraOpcionCajaBancos(False)
		End Select
		
	End Sub
	
	Sub ConfiguraForm()
		fraCajaBancos.Enabled = False
		Call ConfiguraOpcionCajaBancos(False)
	End Sub
	
	Sub ConfiguraOpcionCajaBancos(ByRef valor As Boolean)
		'Valor ==> T: Habilita  .F.=Deshabilita
		Dim i As Short
		For i = 0 To N_OPCIONES_CAJABANCOS - 1
			optOpcionCajaBancos(i).Enabled = valor
		Next 
	End Sub
	
	Sub ConfiguraSeleccion(ByRef valor As Short)
		Select Case valor
			Case 0
				fraCajaBancos.Enabled = True
				Call ConfiguraOpcionCajaBancos(True)
				
			Case 1, 2, 3, 4
				fraCajaBancos.Enabled = False
				Call ConfiguraOpcionCajaBancos(False)
		End Select
	End Sub
	
    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
        Me.Close()
    End Sub

End Class