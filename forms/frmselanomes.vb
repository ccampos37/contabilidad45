Option Strict Off
Option Explicit On
Friend Class frmselanomes
	Inherits System.Windows.Forms.Form
	'FIXIT: Utilice Option Explicit para evitar la creaci�n impl�cita de variables de tipo Variant.     FixIT90210ae-R383-H1984
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		Dim tccambio As Double
        '  VGvardllgen = New dllgeneral.dll_general
        VGParamSistem.Anoproceso = Format(Year(DTPperiodo.Value), "0000")
        VGParamSistem.Mesproceso = Format(Month(DTPperiodo.Value), "00")
        VGParamSistem.TablaCabcomprob = "ct_cabcomprob" & Year(DTPperiodo.Value)
        VGParamSistem.TablaDetcomprob = "ct_detcomprob" & Year(DTPperiodo.Value)
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DTPperiodo._Value. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        VGParamSistem.FechaTrabajo = DTPperiodo.Value
        'UPGRADE_WARNING: El l�mite inferior de la colecci�n MDIPrincipal.StatusBar1.Panels cambi� de 1 a 0. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        MDIPrincipal.StatusBar1.Items.Item(1).Text = "Mes Proceso : " & DesMes(CStr(Month(DTPperiodo.Value)))
        MDIPrincipal.StatusBar1.Items.Item(2).Text = "A�o Proceso :" & Year(DTPperiodo.Value)
        tccambio = XRecuperaTipoCambio(CDate(Format(DTPperiodo.Value, "dd/mm/yyyy")), tipocambio.Venta, VGCNx)
        If tccambio = 0 Then
            MsgBox("No existe tipo de cambio para esta fecha", MsgBoxStyle.Information)
        End If
        MDIPrincipal.StatusBar1.Items.Item(4).Text = "Tipo Cambio  (" & Format(tccambio, "#.000") & ")"
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