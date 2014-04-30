Option Strict Off
Option Explicit On
Friend Class FrmLibroDiario
	Inherits System.Windows.Forms.Form
	Dim NombreTabla As String
	
	Private Sub FrmLibroDiario_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call ConfiguraForm()
		Call Llenacbomes()
		NombreTabla = "CT_CABCOMPROB" & VGParamSistem.Anoproceso
		If IsNumeric(VGParamSistem.Anoproceso) Then
			Call SeleccionarMes(CShort(VGParamSistem.Mesproceso), CShort(VGParamSistem.Anoproceso))
		End If
	End Sub
	
	Sub ConfiguraForm()
	
        Ctr_AyuAsiento.Conexion(VGCNx)
        Ctr_AyuSubAsiento.Conexion(VGCNx)
        Ctr_AyuSubAsiento.Filtro = "asientocodigo='" & Ctr_AyuAsiento.xclave & "'"

    End Sub


    Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Sub Llenacbomes()
        Dim I As Short
        '  VGvardllgen = New dllgeneral.dll_general
        cboMes.Items.Clear()
        For I = 1 To 12
            cboMes.Items.Add(DesMes(Str(I)))
        Next
    End Sub

    Sub SeleccionarMes(ByRef nMes As Short, ByRef nAnno As Short)
        cboMes.Text = VB6.GetItemString(cboMes, nMes - 1)
        DTPickerFecInicio.Value = VB6.Format("01/" & nMes & "/" & nAnno, "dd/mm/yyyy")
        DTPickerFecFinal.Value = DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, DTPickerFecInicio.Value))
    End Sub
    Private Sub cboMes_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMes.SelectedIndexChanged
        Call SeleccionarMes(cboMes.SelectedIndex + 1, CShort(VGParamSistem.Anoproceso))
    End Sub

    Function ValidaData() As Boolean
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
            If optOpcion0.Checked = True Then
                SQL = SQL & "WHERE  asientocodigo='" & Ctr_Ayuda2(0).xclave & "' "
            Else
                SQL = SQL & "WHERE asientocodigo='" & ctr_ayuAsiento.xclave & "' "
            End If
            SQL = SQL & " AND cabcomprobmes=" & CShort(VGParamSistem.Mesproceso)
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

    Private Sub Ctr_Ayuda1_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent)
        Dim Index As Short = Ctr_Ayuda1.GetIndex(eventSender)
        If Index = 0 Then
            ctr_ayuSubasiento.Filtro = "asientocodigo='" & Trim(ctr_ayuAsiento.xclave) & "'"
        End If

    End Sub

    Private Sub ctr_ayuAsiento_AlDevolverDato(sender As Object, e As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles ctr_ayuAsiento.AlDevolverDato
        Ctr_Ayuda21.Filtro = "asientocodigo='" & Trim(Ctr_Ayuda20.xclave) & "'"

    End Sub



    Private Sub ctr_ayuAsiento_ClickEvent(sender As Object, e As EventArgs) Handles ctr_ayuAsiento.ClickEvent

        ctr_ayuAsiento.Filtro = "asientocodigo='" & Trim(Ctr_Ayuda20.xclave) & "'"

    End Sub


    Private Sub optOpcion0_CheckedChanged(sender As Object, e As EventArgs) Handles optOpcion0.CheckedChanged
        fraDetallado.Visible = True
        fraResumido.Visible = False
    End Sub

    Private Sub optOpcion1_CheckedChanged(sender As Object, e As EventArgs) Handles optOpcion1.CheckedChanged
        fraDetallado.Visible = False
        fraResumido.Visible = True
    End Sub

    Private Sub optOpcion2_CheckedChanged(sender As Object, e As EventArgs) Handles optOpcion2.CheckedChanged
        fraDetallado.Visible = False
        fraResumido.Visible = True
    End Sub

    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
        Me.Close()
    End Sub

    Private Sub cmdBotones0_Click(sender As Object, e As EventArgs) Handles cmdBotones0.Click
        Dim cMes As String
        Dim arrform(2) As Object
        Dim arrparm() As Object 'Detallado
        'If ValidaData() = True Then
        '   MsgBox "Imprimiendo", vbInformation, Caption
        'End If
        If optOpcion0.Checked = True Then
            ReDim arrparm(8) 'Store Procedure:CT_DIARIO2_REP
            arrparm(0) = VGParamSistem.BDEmpresa
            arrparm(1) = VGParametros.empresacodigo
            arrparm(2) = VGParamSistem.Anoproceso
            If cboMes.SelectedIndex >= 0 Then
                cMes = VB6.Format(cboMes.SelectedIndex + 1, "0#")
            Else
                cMes = VB6.Format(VGParamSistem.Mesproceso, "0#")
            End If
            arrparm(3) = cMes
            arrparm(4) = "%%"
            arrparm(5) = IIf(IsNothing(Ctr_Ayuda2(0).xclave), "%%", Ctr_Ayuda2(0).xclave)
            arrparm(6) = IIf(IsNothing(ctr_ayuAsiento.xclave), "%%", ctr_ayuAsiento.xclave)
            arrparm(7) = "FORMATO 05.01"
            arrform(0) = "@TituloReporte='" & "Libro Diario Detallado - Asiento: " & ctr_ayuAsiento.xclave & " " & ctr_ayuAsiento.xnombre & "'"
            arrform(1) = "@Mes='" & DesMes(cMes) & "'" 'DESMES(VGParamSistem.Mesproceso)
            Call ImpresionRptProc("ct_LibroDiario.rpt", arrform, arrparm)
        Else 'Resumido Store Procedure:CT_DIARIO1_REP
            ReDim arrparm(6)
            arrparm(0) = VGParamSistem.BDEmpresa
            arrparm(1) = VGParametros.empresacodigo
            arrparm(2) = VGParamSistem.Anoproceso
            If cboMes.SelectedIndex >= 0 Then
                cMes = VB6.Format(cboMes.SelectedIndex + 1, "0#")
            Else
                cMes = VB6.Format(VGParamSistem.Mesproceso, "0#")
            End If
            arrparm(3) = cMes
            arrparm(4) = IIf(IsNothing(ctr_ayuAsiento.xclave), "%%", ctr_ayuAsiento.xclave)
            arrparm(5) = IIf(IsNothing(Ctr_Ayuda1(1).xclave), "%%", ctr_ayuSubasiento.xclave)
            arrform(0) = "@TituloReporte='" & "Libro Diario Resumido - Asiento: " & ctr_ayuAsiento.xclave & " " & ctr_ayuAsiento.xnombre & "'"
            arrform(1) = "@Mes='" & DesMes(cMes) & "'" 'DESMES(VGParamSistem.Mesproceso)
            If optOpcion1.Checked = True Then
                Call ImpresionRptProc("ct_LibroDiarioResumido1.rpt", arrform, arrparm)
            Else
                Call ImpresionRptProc("ct_LibroDiarioResumido2.rpt", arrform, arrparm)
            End If
        End If
    End Sub
End Class