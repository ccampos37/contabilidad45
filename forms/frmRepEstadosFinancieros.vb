Option Strict Off
Option Explicit On
Friend Class frmRepEstadosFinancieros
	Inherits System.Windows.Forms.Form
	
	Private Sub frmRepEstadosFinancieros_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        DTPicker_Fecha.Value = DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, CDate(Format("01/" & VGParamSistem.Mesproceso & "/" & CShort(VGParamSistem.Anoproceso), "dd/mm/yyyy"))))
        DTPicker_Fecha.MinDate = CDate(Format("01/01/" & VGParamSistem.Anoproceso, "dd/mm/yyyy"))
        DTPicker_Fecha.MaxDate = CDate(Format("31/12/" & VGParamSistem.Anoproceso, "dd/mm/yyyy"))
        Check1.CheckState = System.Windows.Forms.CheckState.Unchecked
        Frame3.Visible = False
    End Sub

    Sub ImpresionEFE()
        'FIXIT: Declare 'arrform' and 'arrparm' con un tipo de datos de enlace en tiempo de compilación     FixIT90210ae-R1672-R1B8ZE
        Dim arrform(0) As Object
        Dim arrparm() As Object
        ReDim arrparm(5)
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(0) = VGParamSistem.BDEmpresa
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(1) = VGParametros.empresacodigo
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(2) = VGParamSistem.Anoproceso
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(3) = Format(Month(DTPicker_Fecha.Value), "0#")
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(4) = VGComputer
        Call ImpresionRptProc("ct_EstadoFlujoEfectivo.rpt", arrform, arrparm)
    End Sub

    Sub ImpresionBalanceGeneral()
        'FIXIT: Declare 'arrform' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
        Dim arrform(0) As Object
        Dim arrparm(7) As Object
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(0) = VGParamSistem.BDEmpresa
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(1) = VGParametros.empresacodigo
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(2) = VGParamSistem.Anoproceso
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(3) = Format(Month(DTPicker_Fecha.Value), "0#")
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(4) = "2"
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(5) = VGComputer
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(6). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(6) = Check1.CheckState
        Call ImpresionRptProc("ct_BalanceGeneral.rpt", arrform, arrparm)
        Call ImpresionRptProc("ct_balancegeneral_anexo.rpt", arrform, arrparm)
    End Sub

    Sub ImpresionEGPFuncion()
        Dim arrform(1) As Object
        Dim arrparm(6) As Object
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(0) = VGParamSistem.BDEmpresa
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(1) = VGParametros.empresacodigo
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(2) = VGParamSistem.Anoproceso
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(3) = Format(Month(CDate(Format(DTPicker_Fecha.Value, "dd/mm/yyyy"))), "0#")
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(4) = VGComputer
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(5) = "0"
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrform(0) = "@TituloReporte='" & "Estado de Ganáncias y Pérdidas por FUNCION" & "'"
        Call ImpresionRptProc("ct_EstadoGanPedFun.rpt", arrform, arrparm)
    End Sub

    Sub ImpresionEGPNaturaleza()
        Dim arrform(1) As Object
        Dim arrparm(5) As Object
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(0) = VGCNx.DefaultDatabase
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(1) = VGParametros.empresacodigo
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(2) = VGParamSistem.Anoproceso
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(3) = Format(Month(CDate(Format(DTPicker_Fecha.Value, "dd/mm/yyyy"))), "0#")
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(4) = VGComputer
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrform(0) = "@TituloReporte='" & "Estado de Ganáncias y Pérdidas por NATURALEZA" & "'"
        Call ImpresionRptProc("ct_EstadoGanPedNat.rpt", arrform, arrparm)
    End Sub
	

    Private Sub cmdBotones0_Click(sender As Object, e As EventArgs) Handles cmdBotones0.Click
        If optTipo0.Checked = True Then
            Call ImpresionEGPFuncion()
        ElseIf optTipo1.Checked = True Then
            Call ImpresionEGPNaturaleza()

        ElseIf optTipo2.Checked = True Then
            Call ImpresionBalanceGeneral()

        ElseIf optTipo3.Checked = True Then
            Call ImpresionEFE()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub optTipo2_CheckedChanged(sender As Object, e As EventArgs) Handles optTipo2.CheckedChanged
        If optTipo2.Checked = True Then
            Frame3.Visible = True
        Else
            Frame3.Visible = False
        End If

    End Sub

    Private Sub optTipo0_CheckedChanged(sender As Object, e As EventArgs) Handles optTipo0.CheckedChanged
        Frame3.Visible = False

    End Sub

    Private Sub optTipo1_CheckedChanged(sender As Object, e As EventArgs) Handles optTipo1.CheckedChanged
        Frame3.Visible = False

    End Sub

    Private Sub optTipo3_CheckedChanged(sender As Object, e As EventArgs) Handles optTipo3.CheckedChanged
        Frame3.Visible = False

    End Sub
End Class