Option Strict Off
Option Explicit On
Public Class FrmMntMoneda
    Inherits System.Windows.Forms.Form
    Dim a_Array(12, 12) As Object

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)


        'Nombre Campos:
        a_Array(0, 0) = "monedacodigo"
        a_Array(0, 1) = "monedadescripcion"
        a_Array(0, 2) = "monedasimbolo"
        a_Array(0, 3) = "usuariocodigo"
        a_Array(0, 4) = "fechaact"

        'Etiquetas:
        a_Array(1, 0) = "Código"
        a_Array(1, 1) = "Descripción"
        a_Array(1, 2) = "Simbolo"
        a_Array(1, 3) = Nothing
        a_Array(1, 4) = Nothing
        'Tipo de Dato:
        a_Array(2, 0) = "C"
        a_Array(2, 1) = "C"
        a_Array(2, 2) = "C"
        a_Array(2, 3) = "C"
        a_Array(2, 4) = "D"

        'Ancho de campo:
        a_Array(3, 0) = 2
        a_Array(3, 1) = 30
        a_Array(3, 2) = 4
        a_Array(3, 3) = 8
        a_Array(3, 4) = Nothing

        'Campo Clave:
        a_Array(4, 0) = True
        a_Array(4, 1) = False
        a_Array(4, 2) = False
        a_Array(4, 3) = False
        a_Array(4, 4) = False

        'Valores Ingresados por el Sistema:
        a_Array(5, 0) = Nothing
        a_Array(5, 1) = Nothing
        a_Array(5, 2) = Nothing
        a_Array(5, 3) = VGUsuario
        a_Array(5, 4) = Today.ToString("dd/MM/yyyy")

        'Permite Nulos:
        a_Array(6, 0) = False
        a_Array(6, 1) = False
        a_Array(6, 2) = False
        a_Array(6, 3) = False
        a_Array(6, 4) = False

        TablasBasicas1.CadenaCone = VGCNxSql
        TablasBasicas1.NombreTabla = "gr_moneda"
        TablasBasicas1.TitForm = "Tipo de Monedas"
        TablasBasicas1.Arreglo = a_Array
        TablasBasicas1.Setear_Controles()
        TablasBasicas1.Obtener_Campos()
        TablasBasicas1.cargar_datos()


    End Sub

End Class
