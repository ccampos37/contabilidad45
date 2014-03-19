Option Strict Off
Option Explicit On
Friend Class frmEstructuraMantParamLibAux
	Inherits System.Windows.Forms.Form
	'FIXIT: Declare 'a_Array' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
	Dim a_Array(12, 12) As Object
	
	Private Sub frmEstructuraMantParamLibAux_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
	
        CentrarForm(MDIPrincipal, Me)
		
		'Nombre Campos:
        a_Array(0, 0) = "paramlibauxtipo"
        a_Array(0, 1) = "paramlibauxdescripcion"
        a_Array(0, 2) = "paramlibauxasiento"
        a_Array(0, 3) = "paramlibauxcuenta"
        a_Array(0, 4) = "paramlibauxigv"
        a_Array(0, 5) = "paramlibauxirenta"
        a_Array(0, 6) = "paramlibauxies"
        a_Array(0, 7) = "paramlibauxtiporeg"
        a_Array(0, 8) = "usuariocodigo"
        a_Array(0, 9) = "fechaact"
		'Etiquetas:
        a_Array(1, 0) = "Tipo de Reporte"
        a_Array(1, 1) = "Descripción"
        a_Array(1, 2) = "Asientos"
        a_Array(1, 3) = "Cuentas"
        a_Array(1, 4) = "IGV"
        a_Array(1, 5) = "I.RENTA / OTROS INGRESOS"
        a_Array(1, 6) = "IES / FLETE"
        a_Array(1, 7) = "Tipo de Registro"
        a_Array(1, 8) = Nothing
        a_Array(1, 9) = Nothing
		'Tipo de Dato:
        a_Array(2, 0) = "C"
        a_Array(2, 1) = "C"
        a_Array(2, 2) = "C"
        a_Array(2, 3) = "C"
        a_Array(2, 4) = "C"
        a_Array(2, 5) = "C"
        a_Array(2, 6) = "C"
        a_Array(2, 7) = "C"
        a_Array(2, 8) = "C"
        a_Array(2, 9) = "D"
		'Ancho de campo:
        a_Array(3, 0) = 6
        a_Array(3, 1) = 20
        a_Array(3, 2) = 40
        a_Array(3, 3) = 70
        a_Array(3, 4) = 40
        a_Array(3, 5) = 40
        a_Array(3, 6) = 40
        a_Array(3, 7) = 4
        a_Array(3, 8) = 8
        a_Array(3, 9) = Nothing
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
        a_Array(4, 9) = False
		'Valores Ingresados por el Sistema:
        a_Array(5, 0) = Nothing
        a_Array(5, 1) = Nothing
        a_Array(5, 2) = Nothing
        a_Array(5, 3) = Nothing
        a_Array(5, 4) = Nothing
        a_Array(5, 5) = Nothing
        a_Array(5, 6) = Nothing
        a_Array(5, 7) = Nothing
        a_Array(5, 8) = VGusuario
        a_Array(5, 9) = Today.ToString("dd/MM/yyyy")
		'a_Array(5, 4) = Format(Now, "aaaa-mm-dd hh:mm:ss.000")
		'Permite Nulos:
        a_Array(6, 0) = False
        a_Array(6, 1) = False
        a_Array(6, 2) = False
        a_Array(6, 3) = False
        a_Array(6, 4) = True
        a_Array(6, 5) = True
        a_Array(6, 6) = True
        a_Array(6, 7) = True
        a_Array(6, 8) = False
        a_Array(6, 9) = False
		
        mTablaBasica1.CadenaCone = VGCNxSql
		mTablaBasica1.NombreTabla = "ct_paramlibaux"
        mTablaBasica1.TitForm = "Parámetros Libros Auxiliares"
        mTablaBasica1.Arreglo = a_Array
        mTablaBasica1.Setear_Controles()
		mTablaBasica1.Obtener_Campos()
		mTablaBasica1.cargar_datos()
		
	End Sub
	
    'Private Sub mTablaBasica1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMantTablaBasica.__mTablaBasica_ClickEvent)
    '    If eventArgs.indice = 3 Then Call Impresion("rptEstruMantParLibAux.rpt")
    'End Sub
End Class