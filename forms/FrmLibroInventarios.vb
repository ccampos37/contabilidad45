Option Strict Off
Option Explicit On
Imports Func = Contabilidad.ModFuncionesGen
Friend Class FrmLibroInventarios
    Inherits System.Windows.Forms.Form

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim aparam(5) As Object
        Dim aform(1) As Object

        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aform(0) = "empresa='" & VGParametros.NomEmpresa & "'"
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aparam(0) = VGCNx.DefaultDatabase
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aparam(1) = VGParametros.empresacodigo
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aparam(2) = VGParamSistem.Anoproceso
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aparam(3) = VGParamSistem.Mesproceso
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aparam(4) = Func.Left(Combo4.Text, 2)
        If Check1.CheckState = 1 Then
            Call ImpresionRptProc("ct_LibroInventariosFisicos.rpt", aform, aparam, , Check1.Text)
        End If
        If Check2.CheckState = 1 Then
            Call ImpresionRptProc("ct_LibroInventariosValorizado.rpt", aform, aparam, , Check2.Text)
        End If

    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Me.Close()
    End Sub

    Private Sub FrmLibroInventarios_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim rs As ADODB.Recordset

        rs = VGCNx.Execute("select puntovtacodigo,puntovtadescripcion from vt_puntoventa ")
        Combo4.Items.Clear()
        Do While Not rs.EOF
            Combo4.Items.Add(rs.Fields(0).Value & " " & rs.Fields(1).Value)
            rs.MoveNext()
        Loop

        Combo4.SelectedIndex = 0

    End Sub
End Class