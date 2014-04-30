Option Strict Off
Option Explicit On
Friend Class frmRepPlantillaSubAsientos
	Inherits System.Windows.Forms.Form
	
	Private Sub frmRepPlantillaSubAsientos_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Ctr_Ayuda1.Conexion(VGCNx)
		Ctr_Ayuda2.Conexion(VGCNx)
		
	End Sub
	
    Private Sub Ctr_Ayuda1_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_Ayuda1.AlDevolverDato
        Ctr_Ayuda2.Filtro = "asientocodigo='" & Ctr_Ayuda1.xclave & "'"
    End Sub

    Private Sub cmdBotones0_Click(sender As Object, e As EventArgs) Handles cmdBotones0.Click
        Dim arrform(2) As Object
        Dim arrparm(5) As Object
        arrparm(0) = VGParamSistem.BDEmpresa
        arrparm(1) = VGParametros.empresacodigo
        arrparm(2) = VGParamSistem.Anoproceso
        arrparm(3) = IIf(IsNothing(Ctr_Ayuda1.xclave), "%%", Ctr_Ayuda1.xclave)
        arrparm(4) = IIf(IsNothing(Ctr_Ayuda2.xclave), "%%", Ctr_Ayuda2.xclave)
        '  VGvardllgen = New dllgeneral.dll_general
        If IsNothing(Ctr_Ayuda1.xclave) Then
            arrform(0) = "@TituloReporte='Reporte de Plantillas - Todos los Asientos'"
        Else
            arrform(0) = "@TituloReporte='" & "Reporte de Plantillas - Asiento: " & Ctr_Ayuda1.xclave & " " & Ctr_Ayuda1.xnombre & "'"
        End If
        arrform(1) = "@Mes='" & DesMes(VGParamSistem.Mesproceso) & "'"
        Call ImpresionRptProc("rptPlantillaSubAsiento.rpt", arrform, arrparm)

    End Sub

    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
        Me.Close()
    End Sub
End Class