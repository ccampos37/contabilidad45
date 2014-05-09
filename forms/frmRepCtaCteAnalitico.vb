Option Strict Off
Option Explicit On
Friend Class frmRepCtaCteAnalitico
	Inherits System.Windows.Forms.Form
	
	Private Sub frmRepCtaCteAnalitico_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call LlenarcboTipoAnalitico()
		Ctr_Ayuda1.Conexion(VGCNx)
		Ctr_Ayuda2.Conexion(VGCNx)
		Ctr_AyudaEnt.Conexion(VGCNx)
		Ctr_Ayuda1.Filtro = " empresacodigo='" & VGParametros.empresacodigo & "'"
        optFiltro0.Checked = True
	End Sub
	
	'UPGRADE_WARNING: El evento cboTipoAnalitico.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboTipoAnalitico_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTipoAnalitico.SelectedIndexChanged
        Ctr_Ayuda2.Filtro = "Right(tipoanaliticocodigo,3)='" & VB6.GetItemString(lstTipoAnaliticoCodigo, cboTipoAnalitico.SelectedIndex) & "'"
        Ctr_Ayuda2.Ejecutar()

        Ctr_AyudaEnt.Filtro = "entidadcodigo in (Select case when lTrim(rtrim(entidadcodigo))='' then '0' else entidadcodigo end as entidadcodigo From ct_analitico Where tipoanaliticocodigo = '" & VB6.GetItemString(lstTipoAnaliticoCodigo, cboTipoAnalitico.SelectedIndex) & "')"
        Ctr_AyudaEnt.Ejecutar()
    End Sub



    Function ValidaImpresion() As Boolean
        If cboTipoAnalitico.SelectedIndex < 0 Then
            If Not MsgBox("No ha seleccionado el tipo de anallitico, desea continuar ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "AVISO") = MsgBoxResult.Yes Then
                ValidaImpresion = False
                Exit Function
            End If
        End If
        ValidaImpresion = True
    End Function

    Sub LlenarcboTipoAnalitico()
        Dim rs As ADODB.Recordset

        rs = VGCNx.Execute("Select tipoanaliticocodigo,tipoanaliticodescripcion from ct_tipoanalitico where tipoanaliticocodigo<>'00'")
        cboTipoAnalitico.Items.Clear()
        lstTipoAnaliticoCodigo.Items.Clear()
        While Not rs.EOF
            cboTipoAnalitico.Items.Add(rs.Fields(1).Value)
            lstTipoAnaliticoCodigo.Items.Add(rs.Fields(0).Value)
            rs.MoveNext()
        End While

    End Sub

    Sub ImpresionCtacteMovimiento()
        Dim cMensaje As String
        'FIXIT: Declare 'arrform' and 'arrparm' con un tipo de datos de enlace en tiempo de compilación     FixIT90210ae-R1672-R1B8ZE
        Dim arrform(2) As Object
        Dim arrparm() As Object
        ReDim arrparm(14)

        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(0) = VGParamSistem.BDEmpresa
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(1) = VGParametros.empresacodigo
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(2) = VGParamSistem.Anoproceso
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(3) = "00"
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(4) = Format(VGParamSistem.Mesproceso, "0#")
        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(5) = IIf(IsNothing(Ctr_Ayuda1.xclave), "%%", Trim(Ctr_Ayuda1.xclave) & "%")
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(6). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(6) = "%%"
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(7). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(7) = "%%"

        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(8). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(8) = IIf(IsNothing(Ctr_AyudaEnt.xclave), "%%", Trim(Ctr_AyudaEnt.xclave) & "%")

        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(9). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(9) = IIf(IsNothing(VB6.GetItemString(lstTipoAnaliticoCodigo, cboTipoAnalitico.SelectedIndex)), "%%", VB6.GetItemString(lstTipoAnaliticoCodigo, cboTipoAnalitico.SelectedIndex))
        If optFiltro0.Checked = True Then
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(10). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            arrparm(10) = "1"
            cMensaje = "Cancelados"
        ElseIf optFiltro1.Checked = True Then
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(10). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            arrparm(10) = "2"
            cMensaje = "Pendientes"
        Else
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(10). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            arrparm(10) = "3"
            cMensaje = "Todos"
        End If

        If OptDetalle0.Checked = True Then
            If Ctr_AyudaEnt.Visible = True And Not IsNothing(Ctr_AyudaEnt.xclave) And IsNothing(Ctr_Ayuda1.xclave) Then
                optOpcion2.Checked = True
                arrparm(11) = 1
                'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            ElseIf Not IsNothing(Ctr_Ayuda1.xclave) Then
                optOpcion3.Checked = True
                arrparm(11) = 2
            Else
                arrparm(11) = 0
            End If
        Else
            arrparm(11) = 0
        End If
        arrparm(12) = 0
        arrparm(13) = IIf(chkAjuste.CheckState = 1, "%", "0") ' param=0 -> No incluye asientos de ajuste x dif. cambio
        '  VGvardllgen = New dllgeneral.dll_general
        arrform(0) = "@TituloReporte='" & "Reporte de Movimientos de Cuenta Corriente de " & cboTipoAnalitico.Text & " '"
        arrform(1) = "@Mes='" & DesMes(VGParamSistem.Mesproceso) & " - " & VGParamSistem.Anoproceso & " - Situación: " & cMensaje & "'"
        arrform(2) = "@MonedaBase='" & VGParametros.monedabase & "'"
        If optOpcion2.Checked = True Then
            Call ImpresionRptProc("ct_CtacteAnalitico1.rpt", arrform, arrparm)
        Else
            If OptDetalle0.Checked = True Then
                Call ImpresionRptProc("ct_CtacteAnaliticoSaldos.rpt", arrform, arrparm)
            Else
                Call ImpresionRptProc("ct_CtacteAnalitico2.rpt", arrform, arrparm)
            End If
        End If
    End Sub

    Sub ImpresionCtaCteSaldo()
        Dim arrform(2) As Object
        Dim arrparm() As Object
        ReDim arrparm(9)
        arrparm(0) = VGParamSistem.BDEmpresa
        arrparm(1) = VGParametros.empresacodigo
        arrparm(2) = VGParamSistem.Anoproceso
        arrparm(3) = "00"
        arrparm(4) = Format(VGParamSistem.Mesproceso, "0#")
        arrparm(5) = IIf(IsNothing(Ctr_Ayuda1.xclave), "%%", Trim(Ctr_Ayuda1.xclave) & "%")
        arrparm(6) = IIf(IsNothing(Ctr_AyudaEnt.xclave), "%%", Trim(Ctr_AyudaEnt.xclave) & "%")
        arrparm(7) = IIf(IsNothing(VB6.GetItemString(lstTipoAnaliticoCodigo, cboTipoAnalitico.SelectedIndex)), "%%", VB6.GetItemString(lstTipoAnaliticoCodigo, cboTipoAnalitico.SelectedIndex))
        arrparm(8) = IIf(chkAjuste.CheckState = 1, "1", "0") ' param=0 -> No toma en cuenta dif. cambio
        '  VGvardllgen = New dllgeneral.dll_general
        arrform(0) = "@TituloReporte='" & "Saldos de Cuenta Corriente " & cboTipoAnalitico.Text & " al Mes de " & "'"
        arrform(1) = "@Mes='" & DesMes(VGParamSistem.Mesproceso) & "'"
        If optOpcion2.Checked = True Then
            Call ImpresionRptProc("rptSaldoAnalitico1.rpt", arrform, arrparm)
        Else
            Call ImpresionRptProc("rptSaldoAnalitico2.rpt", arrform, arrparm)
        End If
    End Sub
    Sub ImpresionCtaCteSaldoinicial()
        Dim cMensaje As String
        Dim arrform(2) As Object
        Dim arrparm() As Object
        If optFiltro1.Checked = True Then
            ReDim arrparm(9)
            arrparm(0) = VGParamSistem.BDEmpresa
            arrparm(1) = VGParametros.empresacodigo
            arrparm(2) = VGParamSistem.Anoproceso
            arrparm(3) = "00"
            arrparm(4) = "00"
            arrparm(5) = IIf(IsNothing(Ctr_Ayuda1.xclave), "%%", Trim(Ctr_Ayuda1.xclave) & "%")
            arrparm(6) = IIf(IsNothing(Ctr_AyudaEnt.xclave), "%%", Trim(Ctr_AyudaEnt.xclave) & "%")
            arrparm(7) = IIf(IsNothing(VB6.GetItemString(lstTipoAnaliticoCodigo, cboTipoAnalitico.SelectedIndex)), "%%", VB6.GetItemString(lstTipoAnaliticoCodigo, cboTipoAnalitico.SelectedIndex))
            arrparm(8) = IIf(chkAjuste.CheckState = 1, "1", "0") ' param=0 -> No toma en cuenta dif. cambio
            Call ImpresionRptProc("rptSaldoAnalitico2.rpt", arrform, arrparm)
        Else
            ReDim arrparm(14)
            arrparm(0) = VGParamSistem.BDEmpresa
            arrparm(1) = VGParametros.empresacodigo
            arrparm(2) = VGParamSistem.Anoproceso
            arrparm(3) = "00"
            arrparm(4) = "00"
            arrparm(5) = IIf(IsNothing(Ctr_Ayuda1.xclave), "%%", Trim(Ctr_Ayuda1.xclave) & "%")
            arrparm(6) = "%%"
            arrparm(7) = "%%"
            arrparm(8) = IIf(IsNothing(Ctr_AyudaEnt.xclave), "%%", Trim(Ctr_AyudaEnt.xclave) & "%")
            arrparm(9) = IIf(IsNothing(VB6.GetItemString(lstTipoAnaliticoCodigo, cboTipoAnalitico.SelectedIndex)), "%%", VB6.GetItemString(lstTipoAnaliticoCodigo, cboTipoAnalitico.SelectedIndex))
            arrparm(10) = "3"
            cMensaje = "Saldos Iniciales"
            '  VGvardllgen = New dllgeneral.dll_general
            arrform(0) = "@TituloReporte='" & "Reporte de Saldos Iniciales de Cuenta Corriente de " & cboTipoAnalitico.Text & " '"
            arrform(1) = "@Mes='Ano  - " & VGParamSistem.Anoproceso & " - Situación: " & cMensaje & "'"
            arrform(2) = "@MonedaBase='" & VGParametros.monedabase & "'"
            arrparm(11) = 0
            arrparm(12) = 0
            arrparm(13) = 0 ' param=0 -> No incluye asientos de ajuste x dif. cambio
            Call ImpresionRptProc("ct_CtacteAnalitico2.rpt", arrform, arrparm)
        End If

    End Sub
	
    Private Sub cmdBotones0_Click(sender As Object, e As EventArgs) Handles cmdBotones0.Click
        If ValidaImpresion() = True Then
            If optOpcion0.Checked = True Then
                Call ImpresionCtacteMovimiento()
            ElseIf optOpcion1.Checked = True Then
                Call ImpresionCtaCteSaldo()
            ElseIf optOpcion4.Checked = True Then
                Call ImpresionCtaCteSaldoinicial()

            End If
        End If
    End Sub

    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
        Me.Close()
    End Sub

    Private Sub optOpcion0_CheckedChanged(sender As Object, e As EventArgs) Handles optOpcion0.CheckedChanged
        Dim i As Integer = 0
        If i = 0 Then
            OptDetalle0.Enabled = True
            OptDetalle1.Enabled = True
        Else
            OptDetalle0.Enabled = False
            OptDetalle1.Enabled = False
        End If

    End Sub
End Class