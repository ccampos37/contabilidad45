Option Strict Off
Option Explicit On
Friend Class FrmLibroDiarioSimplificado
	Inherits System.Windows.Forms.Form
	Private Sub cmdImprimir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImprimir.Click
		Dim cMes As String
		Dim arrparm(6) As Object 'Store Procedure:CT_DIARIO2_REP
		Dim arrform(3) As Object
		arrparm(0) = VGParamSistem.BDEmpresa
		arrparm(1) = VGParametros.empresacodigo
		arrparm(2) = VGParamSistem.Anoproceso
		If cboMes.SelectedIndex >= 0 Then
            cMes = Format(cboMes.SelectedIndex + 1, "0#")
		Else
            cMes = Format(VGParamSistem.Mesproceso, "0#")
		End If
		arrparm(3) = cMes
        arrparm(4) = IIf(IsNothing(Ctr_Ayuda20.xclave), "%%", Ctr_Ayuda20.xclave)
        arrparm(5) = IIf(IsNothing(Ctr_Ayuda21.xclave), "%%", Ctr_Ayuda21.xclave)
        '  VGvardllgen = New dllgeneral.dll_general
		arrform(0) = "TituloReporte='" & "FORMATO 05.02 - Libro Diario Simplificado '"
        arrform(1) = "periodo='" & VGParamSistem.Anoproceso & "'" 'DESMES(VGParamSistem.Mesproceso)
        arrform(2) = "Mes='" & DesMes(cMes) & "'" 'DESMES(VGParamSistem.Mesproceso)
		
		Call ImpresionRptProc("ct_LibroDiarioSimplificado.rpt", arrform, arrparm)
		
	End Sub
	
	Private Sub cmdSalir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSalir.Click
		Me.Close()
	End Sub
	
	Private Sub FrmLibroDiarioSimplificado_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim NombreTabla As Object
		Call ConfiguraForm()
		Call Llenacbomes()
		NombreTabla = "CT_CABCOMPROB" & VGParamSistem.Anoproceso
		If IsNumeric(VGParamSistem.Anoproceso) Then
			Call SeleccionarMes(CShort(VGParamSistem.Mesproceso), CShort(VGParamSistem.Anoproceso))
		End If
	End Sub
	
	Sub ConfiguraForm()
        optOpcion0.Checked = True
		
        Ctr_Ayuda20.conexion(VGCNx)
        Ctr_Ayuda21.conexion(VGCNx)
		
	End Sub
	
    Sub Llenacbomes()
        Dim I As Short
        cboMes.Items.Clear()
        For I = 1 To 12
            cboMes.Items.Add(DesMes(Str(I)))
        Next


    End Sub
	
	Sub SeleccionarMes(ByRef nMes As Short, ByRef nAnno As Short)
        cboMes.Text = VB6.GetItemString(cboMes, nMes - 1)
        DTPickerFecInicio.Value = Format("01/" & nMes & "/" & nAnno, "dd/mm/yyyy")
		DTPickerFecFinal.Value = DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, DTPickerFecInicio.Value))
	End Sub
	
	'UPGRADE_WARNING: El evento cboMes.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboMes_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMes.SelectedIndexChanged
		Call SeleccionarMes(cboMes.SelectedIndex + 1, CShort(VGParamSistem.Anoproceso))
	End Sub
	
	Function ValidaData() As Boolean
        Dim NombreTabla As String = ""
		Dim SQL As String
		If DTPickerFecInicio.Value > DTPickerFecFinal.Value Then
			MsgBox("La Fecha de Término es menor a la Fecha de Inicio", MsgBoxStyle.Information, Text)
			DTPickerFecInicio.Focus()
			ValidaData = False
			Exit Function
		End If
		SQL = "select name from sysobjects where name='" & NombreTabla & "'"
		If VerificaDatoExistente(VGCNx, SQL) > 0 Then
			SQL = "select asientocodigo from " & NombreTabla & " "
            SQL = SQL & "WHERE  asientocodigo='" & Ctr_Ayuda20.xclave & "' "
			If VerificaDatoExistente(VGCNx, SQL) = 0 Then
				MsgBox("No existe Información para Mostrar", MsgBoxStyle.Information, Text)
				ValidaData = False
				Exit Function
			End If
		Else
			MsgBox("No existen las Tablas para el Año de Proceso Actual: " & VGParamSistem.Anoproceso & vbCrLf & "Consulte con el Administrador del Sistema Contable", MsgBoxStyle.Exclamation, Text)
			ValidaData = False
			Exit Function
		End If
		
		ValidaData = True
	End Function
	
	Private Sub DTPickerFecInicio_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DTPickerFecInicio.Enter
		DTPickerFecInicio.CalendarBackColor = System.Drawing.ColorTranslator.FromOle(&HE2FDFE)
	End Sub
	
	Private Sub DTPickerFecFinal_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DTPickerFecFinal.Enter
		DTPickerFecFinal.CalendarBackColor = System.Drawing.ColorTranslator.FromOle(&HE2FDFE)
	End Sub
	
    Private Sub optOpcion0_CheckedChanged(sender As Object, e As EventArgs) Handles optOpcion0.CheckedChanged
        fraDetallado.Visible = True

    End Sub
End Class