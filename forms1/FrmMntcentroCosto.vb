Option Strict Off
Option Explicit On
Public Class frmMntCentroCosto
    Inherits System.Windows.Forms.Form
    Dim a_Array(12, 12) As Object

    Private Sub frmMantCentroCosto_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load


        a_Array(0, 0) = "empresacodigo"
        a_Array(0, 1) = "centrocostocodigo"
        a_Array(0, 2) = "centrocostodescripcion"
        a_Array(0, 3) = "centrocostodescrcorta"
        a_Array(0, 4) = "centrocostonivel"
        a_Array(0, 5) = "cuentacodigo"
        a_Array(0, 6) = "usuariocodigo"
        a_Array(0, 7) = "fechaact"


        'Etiquetas:
        a_Array(1, 0) = "Empresa"
        a_Array(1, 1) = "Código"
        a_Array(1, 2) = "Descripción"
        a_Array(1, 3) = "Desc Corta"
        a_Array(1, 4) = "Nivel"
        a_Array(1, 5) = "Cuenta Clase 9"
        a_Array(1, 6) = Nothing
        a_Array(1, 7) = Nothing


        'Tipo de Dato:
        a_Array(2, 0) = "C"
        a_Array(2, 1) = "C"
        a_Array(2, 2) = "C"
        a_Array(2, 3) = "C"
        a_Array(2, 4) = "C"
        a_Array(2, 5) = "C"
        a_Array(2, 6) = "C"
        a_Array(2, 7) = "D"

        'Ancho de campo:
        a_Array(3, 0) = 2
        a_Array(3, 1) = 6
        a_Array(3, 2) = 30
        a_Array(3, 3) = 15
        a_Array(3, 4) = 1
        a_Array(3, 5) = 10
        a_Array(3, 6) = Nothing
        a_Array(3, 7) = 10

        'Campo Clave:

        a_Array(4, 0) = True
        a_Array(4, 1) = True
        a_Array(4, 2) = False
        a_Array(4, 3) = False
        a_Array(4, 4) = False
        a_Array(4, 5) = False
        a_Array(4, 6) = False
        a_Array(4, 7) = False


        'Valores Ingresados por el Sistema:
        a_Array(5, 0) = VGParametros.empresacodigo
        a_Array(5, 1) = Nothing
        a_Array(5, 2) = Nothing
        a_Array(5, 3) = Nothing
        a_Array(5, 4) = Nothing
        a_Array(5, 5) = Nothing
        a_Array(5, 6) = VGUsuario
        a_Array(5, 7) = Today.ToString("dd/MM/yyyy")

        'a_Array(5, 4) = Format(Now, "aaaa-mm-dd hh:mm:ss.000")

        'Permite Nulos:
        a_Array(6, 0) = False
        a_Array(6, 1) = False
        a_Array(6, 2) = False
        a_Array(6, 3) = True
        a_Array(6, 4) = False
        a_Array(6, 6) = False
        a_Array(6, 7) = False


        TablasBasicas1.CadenaCone = VGCNxSql
        TablasBasicas1.NombreTabla = "ct_centrocosto"
        TablasBasicas1.TitForm = "Centro de Costo"
        TablasBasicas1.Filtro = "WHERE centrocostocodigo<>'00' And empresacodigo='" & VGParametros.empresacodigo & "'"
        TablasBasicas1.Arreglo = a_Array
        TablasBasicas1.Setear_Controles()
        TablasBasicas1.Obtener_Campos()
        TablasBasicas1.cargar_datos()

    End Sub

    'FIXIT: Declare 'indice' con un tipo de datos de enlace en tiempo de compilación           FixIT90210ae-R1672-R1B8ZE
    Private Sub TablasBasicas1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMantTablaBasica.__mTablaBasica_ClickEvent)
        Dim arrparm(3) As Object
        Dim arrform(0) As Object
        If eventArgs.indice = 3 Then
            arrparm(0) = VGCNx.DefaultDatabase
            arrparm(1) = "ct_centrocosto"
            arrparm(2) = " "
            Call ImpresionRptProc("rptCentroCosto.rpt", arrform, arrparm, , "Centro de costos")
        End If
    End Sub
End Class