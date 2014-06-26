Option Strict Off
Option Explicit On
Friend Class frmDiarioGeneral
    Inherits System.Windows.Forms.Form
    Dim NombreTabla As String

    Private Sub frmRepDiarioGeneral_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
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
        Ctr_Ayuda21.Conexion(VGCNx)

    End Sub
    Sub Llenacbomes()
        Dim i As integer
        cboMes.Items.Clear()
        For i = 1 To 12
            cboMes.Items.Add(DesMes(Format(i, "00")))
        Next
        'UPGRADE_NOTE: El objeto VGvardllgen no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        ' '  VGvardllgen = Nothing

    End Sub

    Sub SeleccionarMes(ByRef nMes As Short, ByRef nAnno As Short)
        cboMes.Text = VB6.GetItemString(cboMes, nMes - 1)
    End Sub

    'UPGRADE_WARNING: El evento cboMes.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cboMes_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Call SeleccionarMes(cboMes.SelectedIndex + 1, CShort(VGParamSistem.Anoproceso))
    End Sub

    Function ValidaData() As Boolean
        Dim SQL As String
        SQL = "select name from sysobjects where name='" & NombreTabla & "'"
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VerificaDatoExistente(VGCNx, SQL). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If VerificaDatoExistente(VGCNx, SQL) > 0 Then
            SQL = "select asientocodigo from " & NombreTabla & " "
            If optOpcion0.Checked = True Then
                SQL = SQL & "WHERE  asientocodigo='" & Ctr_Ayuda2(0).xclave & "' "
            Else
                SQL = SQL & "WHERE asientocodigo='" & Ctr_Ayuda1(0).xclave & "' "
            End If
            SQL = SQL & " AND cabcomprobmes=" & CShort(VGParamSistem.Mesproceso)
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VerificaDatoExistente(VGCNx, SQL). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
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

    Private Sub cmdBotones0_Click(sender As Object, e As EventArgs) Handles cmdBotones0.Click
        Dim cMes As String
        Dim arrform(2) As Object
        Dim arrparm(6) As Object 'Detallado
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
        If optOpcion0.Checked = True Then
            arrform(0) = "@TituloReporte='" & "Libro Diario Detallado - Asiento: " & Ctr_Ayuda20.xclave & " " & Ctr_Ayuda20.xnombre & "'"
            arrform(1) = "@Mes='" & DesMes(cMes) & "'" 'DESMES(VGParamSistem.Mesproceso)
            Call ImpresionRptProc("ct_DiarioDetallado.rpt", arrform, arrparm)
        Else 'Resumido Store Procedure:CT_DIARIO1_REP
            arrform(0) = "@TituloReporte='" & "Libro Diario Resumido - Asiento: " & Ctr_Ayuda20.xclave & " " & Ctr_Ayuda20.xnombre & "'"
            arrform(1) = "@Mes='" & DesMes(cMes) & "'" 'DESMES(VGParamSistem.Mesproceso)      
            If optOpcion1.Checked = True Then
                Call ImpresionRptProc("ct_LibroDiarioResumido1.rpt", arrform, arrparm)
            Else
                Call ImpresionRptProc("ct_LibroDiarioResumido2.rpt", arrform, arrparm)
            End If
        End If

    End Sub

    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
        Me.Close()
    End Sub

    Private Sub Ctr_Ayuda20_AlDevolverDato(sender As Object, e As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent)
        Ctr_Ayuda21.Filtro = "asientocodigo='" & Trim(Ctr_Ayuda20.xclave) & "'"
    End Sub

    Private Sub CrystalReportViewer2_Load(sender As Object, e As EventArgs)

    End Sub
End Class