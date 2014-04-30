Option Strict Off
Option Explicit On
Friend Class frmRepCajaBancos
    Inherits System.Windows.Forms.Form
    Dim RSparVentas As ADODB.Recordset


    Private Sub frmRepCajaBancos_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        RSparVentas = New ADODB.Recordset
        Ctr_Ayuda1.conexion(VGCNx)
        Ctr_Ayuda1.Filtro = "cuentacodigo like '10%' AND empresacodigo ='" & VGParametros.empresacodigo & "' "
    End Sub

    Public Sub imprimir()
        'FIXIT: Declare 'arrform' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
        Dim arrform(3) As Object
        Dim arrparm(7) As Object

        '  VGvardllgen = New dllgeneral.dll_general
        arrparm(0) = VGParamSistem.BDEmpresa
        arrparm(1) = VGParametros.empresacodigo
        arrparm(2) = VGParamSistem.Anoproceso
        arrparm(3) = VB6.Format(CDbl(VGParamSistem.Mesproceso) - 1, "0#")
        arrparm(4) = VB6.Format(VGParamSistem.Mesproceso, "0#")
        arrparm(5) = IIf(IsNothing(Ctr_Ayuda1.xclave), "10%", Trim(Ctr_Ayuda1.xclave) & "%%")
        arrparm(6) = "%%"

        '  VGvardllgen = New dllgeneral.dll_general
        arrform(0) = "@TituloReporte='" & "Libro Caja Bancos " & "'" 'Ctr_Ayuda1.xclave
        arrform(1) = "@Mes='" & DesMes(VGParamSistem.Mesproceso) & "'"
        arrform(2) = "@anno='" & VGParamSistem.Anoproceso & "'"

        Call ImpresionRptProc("ct_LibroCajaBancos.rpt", arrform, arrparm)

    End Sub

    Private Function ArmaCriterio(ByRef cad As String, ByRef car As String, Optional ByRef campocrit As String = "") As String
        Dim pos As Short
        Dim criterio As String
        Dim valor As String
        criterio = ""
        Do While True
            pos = InStr(1, cad, car, CompareMethod.Text)
            If pos = 0 Then Exit Do
            If campocrit = "" Or Trim(car) = "," Then
                valor = "''" & cad.Substring(0, pos - 1) & "''"
            Else
                valor = "''" & cad.Substring(0, pos) & "''"
            End If
            cad = cad.Substring(pos, Len(cad) - pos)
            If campocrit <> "" Then
                criterio = criterio & campocrit & " like " & valor & " or "
            Else
                criterio = criterio & valor & car
            End If
        Loop
        If campocrit <> "" Then
            ArmaCriterio = criterio.Substring(0, Len(criterio) - 3)
        Else
            ArmaCriterio = criterio.Substring(0, Len(criterio) - 1)
        End If
    End Function


    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Call imprimir()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class