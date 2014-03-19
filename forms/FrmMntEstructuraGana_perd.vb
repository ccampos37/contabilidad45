Option Strict Off
Option Explicit On
Public Class FrmMntEstructuraGana_perd

    Inherits System.Windows.Forms.Form
    Dim a_Array(12, 12) As Object

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        'Nombre Campos:
        a_Array(0, 0) = "EGP_LINEA"
        a_Array(0, 1) = "EGP_NIVEL"
        a_Array(0, 2) = "EGP_ACUMES"
        a_Array(0, 3) = "EGP_SIGNO1"
        a_Array(0, 4) = "EGP_DESCRI"
        a_Array(0, 5) = "EGP_ACUANO"
        a_Array(0, 6) = "EGP_SIGNO2"
        a_Array(0, 7) = "EGP_SALDO"
        a_Array(0, 8) = "EGP_GRUPO"

        'Etiquetas:
        a_Array(1, 0) = "Línea"
        a_Array(1, 1) = "Nivel"
        a_Array(1, 2) = "Acum Mes"
        a_Array(1, 3) = "Signo 1"
        a_Array(1, 4) = "Descripcion"
        a_Array(1, 5) = "Acum Año"
        a_Array(1, 6) = "Signo 2"
        a_Array(1, 7) = "Saldo"
        a_Array(1, 8) = "Grupo"

        'Tipo de Dato:
        a_Array(2, 0) = "C"
        a_Array(2, 1) = "C"
        a_Array(2, 2) = "N" 'Float
        a_Array(2, 3) = "C"
        a_Array(2, 4) = "C"
        a_Array(2, 5) = "N" 'Float
        a_Array(2, 6) = "C"
        a_Array(2, 7) = "B" 'Bit
        a_Array(2, 8) = "C"

        'Ancho de campo:
        a_Array(3, 0) = 6
        a_Array(3, 1) = 2
        a_Array(3, 2) = Nothing
        a_Array(3, 3) = 2
        a_Array(3, 4) = 60
        a_Array(3, 5) = Nothing
        a_Array(3, 6) = 2
        a_Array(3, 7) = 1
        a_Array(3, 8) = 2

        'Campo Clave:
        a_Array(4, 0) = True
        a_Array(4, 1) = False
        a_Array(4, 2) = False
        a_Array(4, 3) = False
        a_Array(4, 4) = False
        a_Array(4, 5) = False
        a_Array(4, 6) = False
        a_Array(4, 7) = False
        a_Array(4, 8) = False

        'Valores Ingresados por el Sistema:
        a_Array(5, 0) = Nothing
        a_Array(5, 1) = Nothing
        a_Array(5, 2) = Nothing
        a_Array(5, 3) = Nothing
        a_Array(5, 4) = Nothing
        a_Array(5, 5) = Nothing
        a_Array(5, 6) = Nothing
        a_Array(5, 7) = Nothing
        a_Array(5, 8) = Nothing

        'a_Array(5, 4) = Format(Now, "aaaa-mm-dd hh:mm:ss.000")
        'Permite Nulos:
        a_Array(6, 0) = False
        a_Array(6, 1) = False
        a_Array(6, 2) = True
        a_Array(6, 3) = True
        a_Array(6, 4) = True
        a_Array(6, 5) = False
        a_Array(6, 6) = True
        a_Array(6, 7) = False
        a_Array(6, 8) = True


        TablasBasicas1.CadenaCone = VGCNxSql
        TablasBasicas1.NombreTabla = "ct_strucganper"
        TablasBasicas1.TitForm = "Estructura del Estado de Gan. y Perd."
        TablasBasicas1.Arreglo = a_Array
        TablasBasicas1.Setear_Controles()
        TablasBasicas1.Obtener_Campos()
        TablasBasicas1.cargar_datos()

    End Sub

    'FIXIT: Declare 'indice' con un tipo de datos de enlace en tiempo de compilación           FixIT90210ae-R1672-R1B8ZE
    Private Sub TablasBasicas1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMantTablaBasica.__mTablaBasica_ClickEvent)
        ' If indice = 3 Then
        '   MDIPrincipal.cryRpt.Destination = crptToWindow
        '   MDIPrincipal.cryRpt.WindowState = crptMaximized
        '   MDIPrincipal.cryRpt.ReportFileName = App.Path & "\Reportes\rptEstruMantGanPer.rpt"
        '   MDIPrincipal.cryRpt.Connect = vgCADENAREPORT
        '   MDIPrincipal.cryRpt.DiscardSavedData = True
        '   MDIPrincipal.cryRpt.Action = 1
        ' End If

        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto indice. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If eventArgs.indice = 3 Then Call Impresion("rptEstruMantGanPer.rpt")

    End Sub

End Class