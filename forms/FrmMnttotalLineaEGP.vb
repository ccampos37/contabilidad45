Option Strict Off
Option Explicit On
Public Class FrmMnttotalLineaEGP

    Inherits System.Windows.Forms.Form
    Dim a_Array(12, 12) As Object

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        'Nombre Campos:
        a_Array(0, 0) = "totalizadorgplinea"
        a_Array(0, 1) = "totalizadorgpformulames"
        a_Array(0, 2) = "totalizadorgpformulaacum"
        a_Array(0, 3) = "totalizadorgpantig"
        a_Array(0, 4) = "usuariocodigo"
        a_Array(0, 5) = "fechaact"
        'Etiquetas:
        a_Array(1, 0) = "Línea"
        a_Array(1, 1) = "Formula Mensual"
        a_Array(1, 2) = "Formula Acumulado"
        a_Array(1, 3) = "Antiguedad"
        a_Array(1, 4) = Nothing
        a_Array(1, 5) = Nothing
        'Tipo de Dato:
        a_Array(2, 0) = "C"
        a_Array(2, 1) = "C"
        a_Array(2, 2) = "C"
        a_Array(2, 3) = "C"
        a_Array(2, 4) = "C"
        a_Array(2, 5) = "D"
        'Ancho de campo:
        a_Array(3, 0) = 6
        a_Array(3, 1) = 90
        a_Array(3, 2) = 90
        a_Array(3, 3) = 6
        a_Array(3, 4) = 8
        a_Array(3, 5) = Nothing
        'Campo Clave:
        a_Array(4, 0) = True
        a_Array(4, 1) = False
        a_Array(4, 2) = False
        a_Array(4, 3) = False
        a_Array(4, 4) = False
        a_Array(4, 5) = False
        'Valores Ingresados por el Sistema:
        a_Array(5, 0) = Nothing
        a_Array(5, 1) = Nothing
        a_Array(5, 2) = Nothing
        a_Array(5, 3) = Nothing
        a_Array(5, 4) = VGUsuario
        a_Array(5, 5) = Today.ToString("dd/MM/yyyy")
        'a_Array(5, 4) = Format(Now, "aaaa-mm-dd hh:mm:ss.000")
        'Permite Nulos:
        a_Array(6, 0) = False
        a_Array(6, 1) = False
        a_Array(6, 2) = False
        a_Array(6, 3) = False
        a_Array(6, 4) = False
        a_Array(6, 5) = False

        TablasBasicas1.CadenaCone = VGCNxSql
        TablasBasicas1.NombreTabla = "ct_totalizadorgp"
        TablasBasicas1.TitForm = "Totalizador de Ganancias y Pérdidas"
        TablasBasicas1.Arreglo = a_Array
        TablasBasicas1.Setear_Controles()
        TablasBasicas1.Obtener_Campos()
        TablasBasicas1.cargar_datos()

    End Sub

    'FIXIT: Declare 'indice' con un tipo de datos de enlace en tiempo de compilación           FixIT90210ae-R1672-R1B8ZE
    Private Sub TablasBasicas1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMantTablaBasica.__mTablaBasica_ClickEvent)
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto indice. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If eventArgs.indice = 3 Then Call Impresion("rptEstruMantTotalLinEGP.rpt")
    End Sub


End Class