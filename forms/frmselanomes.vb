Option Strict Off
Option Explicit On
Friend Class frmselanomes
	Inherits System.Windows.Forms.Form
	'FIXIT: Utilice Option Explicit para evitar la creación implícita de variables de tipo Variant.     FixIT90210ae-R383-H1984
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		Dim tccambio As Double
        '  VGvardllgen = New dllgeneral.dll_general
		VGParamSistem.Anoproceso = VB6.Format(Year(DTPperiodo._Value), "0000")
		VGParamSistem.Mesproceso = VB6.Format(Month(DTPperiodo._Value), "00")
		VGParamSistem.TablaCabcomprob = "ct_cabcomprob" & Year(DTPperiodo._Value)
		VGParamSistem.TablaDetcomprob = "ct_detcomprob" & Year(DTPperiodo._Value)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DTPperiodo._Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		VGParamSistem.FechaTrabajo = DTPperiodo._Value
		'UPGRADE_WARNING: El límite inferior de la colección MDIPrincipal.StatusBar1.Panels cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		MDIPrincipal.StatusBar1.Items.Item(1).Text = "Mes Proceso : " & DesMes(CStr(Month(DTPperiodo._Value)))
		'UPGRADE_WARNING: El límite inferior de la colección MDIPrincipal.StatusBar1.Panels cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		MDIPrincipal.StatusBar1.Items.Item(2).Text = "Año Proceso :" & Year(DTPperiodo._Value)
		
        tccambio = XRecuperaTipoCambio(CDate(VB6.Format(DTPperiodo._Value, "dd/mm/yyyy")), tipocambio.Venta, VGCNx)
		If tccambio = 0 Then
			MsgBox("No existe tipo de cambio para esta fecha", MsgBoxStyle.Information)
		End If
		'UPGRADE_WARNING: El límite inferior de la colección MDIPrincipal.StatusBar1.Panels cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		MDIPrincipal.StatusBar1.Items.Item(4).Text = "Tipo Cambio  (" & VB6.Format(tccambio, "#.000") & ")"
		'UPGRADE_WARNING: El límite inferior de la colección MDIPrincipal.StatusBar1.Panels cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		MDIPrincipal.StatusBar1.Items.Item(3).Text = "Fecha de Trabajo (" & VGParamSistem.FechaTrabajo & ")"
		
		Me.Close()
		
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		Me.Close()
	End Sub
	
	Private Sub frmselanomes_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		DTPperiodo.Value = VGParamSistem.FechaTrabajo
	End Sub
End Class