Option Strict Off
Option Explicit On
Friend Class FrmMntTipocambio
    Inherits System.Windows.Forms.Form
    Dim a_Array(12, 12) As Object
    Private Sub FrmMntTipoCambio_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim filtro As String = ""
        CentrarForm(MDIPrincipal, Me)

        'Nombre Campos:
        a_Array(0, 0) = "Tipocambiofecha"
        a_Array(0, 1) = "tipocambiocompra"
        a_Array(0, 2) = "tipocambioventa"
        a_Array(0, 3) = "tipocambiopromedio"
        a_Array(0, 4) = "usuariocodigo"
        a_Array(0, 5) = "fechaact"

        'Etiquetas:
        a_Array(1, 0) = "Fecha"
        a_Array(1, 1) = "Compra"
        a_Array(1, 2) = "Venta"
        a_Array(1, 3) = Nothing
        a_Array(1, 4) = Nothing
        a_Array(1, 5) = Nothing

        'Tipo de Dato:

        a_Array(2, 0) = "D"
        a_Array(2, 1) = "N"
        a_Array(2, 2) = "N"
        a_Array(2, 3) = "N"
        a_Array(2, 4) = "C"
        a_Array(2, 5) = "D"

        'Ancho de campo:
        a_Array(3, 0) = 10
        a_Array(3, 1) = 10
        a_Array(3, 2) = 10
        a_Array(3, 3) = Nothing
        a_Array(3, 4) = Nothing
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
        a_Array(5, 3) = "0.0"
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

        mTablaBasica1.CadenaCone = VGCNxSql
        mTablaBasica1.NombreTabla = "ct_Tipocambio"
        mTablaBasica1.TitForm = "Tipo de Cambio"
        filtro = "WHERE Month(tipocambiofecha)=" & VGParamSistem.Mesproceso & " AND YEAR(tipoocambiofecha)=" & VGParamSistem.Anoproceso & ""
        mTablaBasica1.Filtro = filtro
        mTablaBasica1.Arreglo = a_Array
        mTablaBasica1.Setear_Controles()
        mTablaBasica1.Obtener_Campos()
        mTablaBasica1.cargar_datos()
    End Sub

    Private Sub mTablaBasica1_Load(sender As Object, e As EventArgs) Handles mTablaBasica1.Load

    End Sub
End Class