Option Strict Off
Option Explicit On
Friend Class frmEstructuraMantParametrosGastos
	Inherits System.Windows.Forms.Form
    Friend WithEvents TablasBasicas1 As TablasBasicas.TablasBasicas
    'FIXIT: Declare 'a_Array' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
	Dim a_Array(12, 12) As Object
	
	Private Sub frmEstructuraMantParametrosGastos_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
        CentrarForm(MDIPrincipal, Me)
		
		'Nombre Campos:
        a_Array(0, 0) = "paramgastoslinutil"
        a_Array(0, 1) = "paramgastosctautil"
        a_Array(0, 2) = "paramgastoslinventa"
        a_Array(0, 3) = "paramgastoslinadmin"
		'a_Array(0, 4) = "paramgastoslindiv"
        a_Array(0, 4) = "paramgastosactivo"
        a_Array(0, 5) = "paramgastosgastoadmin"
        a_Array(0, 6) = "paramgastosgastoventa"
        a_Array(0, 7) = "paramgastosgastoprod"
        a_Array(0, 8) = "paramgastosgastofinan"
        a_Array(0, 9) = "paramgastosgastodiv"
        a_Array(0, 10) = "usuariocodigo"
        a_Array(0, 11) = "fechaact"
		'Etiquetas:
        a_Array(1, 0) = "Línea de Utilidad"
        a_Array(1, 1) = "Cuenta de Utilidad"
        a_Array(1, 2) = "Linea de Ventas"
        a_Array(1, 3) = "Linea de Administración"
        a_Array(1, 4) = "Activo"
        a_Array(1, 5) = "Gastos de Adm."
        a_Array(1, 6) = "Gastos de Ventas"
        a_Array(1, 7) = "Gastos de Producción"
        a_Array(1, 8) = "Gastos Financieros"
        a_Array(1, 9) = "Gastos Diversos"
        a_Array(1, 10) = Nothing
        a_Array(1, 11) = Nothing

        'Tipo de Dato:
        a_Array(2, 0) = "N"
        a_Array(2, 1) = "N"
        a_Array(2, 2) = "N"
        a_Array(2, 3) = "N"
        a_Array(2, 4) = "N"
        a_Array(2, 5) = "N"
        a_Array(2, 6) = "N"
        a_Array(2, 7) = "N"
        a_Array(2, 8) = "N"
        a_Array(2, 9) = "N"
        a_Array(2, 10) = "C"
        a_Array(2, 11) = "D"

        'Ancho de campo:
        a_Array(3, 0) = 6
        a_Array(3, 1) = 2
        a_Array(3, 2) = 2
        a_Array(3, 3) = 2
        a_Array(3, 4) = 2
        a_Array(3, 5) = 2
        a_Array(3, 6) = 2
        a_Array(3, 7) = 2
        a_Array(3, 8) = 2
        a_Array(3, 9) = 2
        a_Array(3, 10) = 8
        a_Array(3, 11) = Nothing

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
        a_Array(4, 10) = False
        a_Array(4, 11) = False
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
        a_Array(5, 9) = Nothing
        a_Array(5, 10) = VGusuario
        a_Array(5, 11) = Today.ToString("dd/MM/yyyy")
		'a_Array(5, 4) = Format(Now, "aaaa-mm-dd hh:mm:ss.000")
		'Permite Nulos:
        a_Array(6, 0) = False
        a_Array(6, 1) = False
        a_Array(6, 2) = False
        a_Array(6, 3) = False
        a_Array(6, 4) = False
        a_Array(6, 5) = False
        a_Array(6, 6) = False
        a_Array(6, 7) = False
        a_Array(6, 8) = False
        a_Array(6, 9) = False
        a_Array(6, 10) = False
        a_Array(6, 11) = False
		
        TablasBasicas1.CadenaCone = VGCNxSql
        TablasBasicas1.NombreTabla = "ct_paramgastos"
        TablasBasicas1.TitForm = "Parámetros de Gastos"
        TablasBasicas1.Arreglo = a_Array
        TablasBasicas1.Setear_Controles()
        TablasBasicas1.Obtener_Campos()
        TablasBasicas1.cargar_datos()
		
	End Sub
	
	'FIXIT: Declare 'indice' con un tipo de datos de enlace en tiempo de compilación           FixIT90210ae-R1672-R1B8ZE
    Private Sub mTablaBasica1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMantTablaBasica.__mTablaBasica_ClickEvent)
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto indice. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If eventArgs.indice = 3 Then Call Impresion("rptEstruMantParGastos.rpt")
    End Sub

    Private Sub InitializeComponent()
        Me.TablasBasicas1 = New TablasBasicas.TablasBasicas()
        Me.SuspendLayout()
        '
        'TablasBasicas1
        '
        Me.TablasBasicas1.Location = New System.Drawing.Point(12, 12)
        Me.TablasBasicas1.Name = "TablasBasicas1"
        Me.TablasBasicas1.Size = New System.Drawing.Size(473, 425)
        Me.TablasBasicas1.TabIndex = 2
        '
        'frmEstructuraMantParametrosGastos
        '
        Me.ClientSize = New System.Drawing.Size(498, 447)
        Me.Controls.Add(Me.TablasBasicas1)
        Me.Name = "frmEstructuraMantParametrosGastos"
        Me.ResumeLayout(False)

    End Sub
End Class