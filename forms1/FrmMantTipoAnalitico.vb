Option Strict Off
Option Explicit On
Public Class FrmMantTipoAnalitico
    Inherits System.Windows.Forms.Form
    Dim a_Array(12, 12) As Object
    Private Sub FrmMantTipoAnalitico_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

 
        a_Array(0, 0) = "tipoanaliticocodigo"
        a_Array(0, 1) = "tipoanaliticodescripcion"
        a_Array(0, 2) = "tipoanaliticodigitos"
        a_Array(0, 3) = "usuariocodigo"
        a_Array(0, 4) = "fechaact"


        'Etiquetas:
        a_Array(1, 0) = "Código"
        a_Array(1, 1) = "Descripción"
        a_Array(1, 2) = "digitos codigo"
        a_Array(1, 3) = Nothing
        a_Array(1, 4) = Nothing


        'Tipo de Dato:
        a_Array(2, 0) = "C"
        a_Array(2, 1) = "C"
        a_Array(2, 2) = "N"
        a_Array(2, 3) = "C"
        a_Array(2, 4) = "D"

        'Ancho de campo:
        a_Array(3, 0) = 3
        a_Array(3, 1) = 40
        a_Array(3, 2) = 10
        a_Array(3, 3) = 8
        a_Array(3, 4) = 10

        'Campo Clave:

        a_Array(4, 0) = True
        a_Array(4, 1) = False
        a_Array(4, 2) = False
        a_Array(4, 3) = False
        a_Array(4, 4) = False


        'Valores Ingresados por el Sistema:
        a_Array(5, 0) = Nothing
        a_Array(5, 1) = Nothing
        a_Array(5, 2) = "11"
        a_Array(5, 3) = VGUsuario
        a_Array(5, 4) = Today.ToString("dd/MM/yyyy")

        'a_Array(5, 4) = Format(Now, "aaaa-mm-dd hh:mm:ss.000")

        'Permite Nulos:
        a_Array(6, 0) = False
        a_Array(6, 1) = False
        a_Array(6, 2) = False
        a_Array(6, 3) = False
        a_Array(6, 4) = False
 

        TablasBasicas1.CadenaCone = VGCNxSql
        TablasBasicas1.NombreTabla = "ct_TipoAnalitico"
        TablasBasicas1.TitForm = "Tipo de Analitico"
        TablasBasicas1.Arreglo = a_Array
        TablasBasicas1.Setear_Controles()
        TablasBasicas1.Obtener_Campos()
        TablasBasicas1.cargar_datos()
    End Sub
End Class