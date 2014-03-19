Option Strict Off
Option Explicit On
Friend Class FrmTipocuenta
	Inherits System.Windows.Forms.Form
    Friend WithEvents TablasBasicas1 As TablasBasicas.TablasBasicas
    'FIXIT: Declare 'a_Array as variant' con un tipo de datos de enlace en tiempo de compilación     FixIT90210ae-R1672-R1B8ZE
	Dim a_Array(12, 12) As Object
	
	Private Sub FrmTipocuenta_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		CentrarForm(MDIPrincipal, Me)
		
		'Nombre Campos:
        a_Array(0, 0) = "tipocuentacodigo"
        a_Array(0, 1) = "tipocuentadescripcion"
        a_Array(0, 2) = "tipocuentaabreviatura"
		'Etiquetas:
        a_Array(1, 0) = "Código"
        a_Array(1, 1) = "Descripción"
        a_Array(1, 2) = "Abreviatura"
		'Tipo de Dato:
        a_Array(2, 0) = "C"
        a_Array(2, 1) = "C"
        a_Array(2, 2) = "C"
		'Ancho de campo:
        a_Array(3, 0) = 2
        a_Array(3, 1) = 25
        a_Array(3, 2) = 3
		'Campo Clave:
        a_Array(4, 0) = True
        a_Array(4, 1) = False
        a_Array(4, 2) = False
		
		'Valores Ingresados por el Sistema:
        a_Array(5, 0) = Nothing
        a_Array(5, 1) = Nothing
        a_Array(5, 2) = Nothing
		'a_Array(5, 4) = Format(Now, "aaaa-mm-dd hh:mm:ss.000")
		
		'Permite Nulos:
        a_Array(6, 0) = False
        a_Array(6, 1) = False
        a_Array(6, 2) = False
		
        TablasBasicas1.CadenaCone = VGCNxSql
        TablasBasicas1.NombreTabla = "ct_tipocuenta"
        TablasBasicas1.TitForm = "Tipos de Cuentas"
        TablasBasicas1.Arreglo = a_Array
        TablasBasicas1.Setear_Controles()
        TablasBasicas1.Obtener_Campos()
        TablasBasicas1.cargar_datos()

    End Sub

    'Private Sub TablasBasicas1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMantTablaBasica.__mTablaBasica_ClickEvent)
    '    If eventArgs.indice = 3 Then
    '        Call Impresion("ct_tipocuenta.rpt")
    '    End If
    'End Sub

    Private Sub InitializeComponent()
        Me.TablasBasicas1 = New TablasBasicas.TablasBasicas()
        Me.SuspendLayout()
        '
        'TablasBasicas1
        '
        Me.TablasBasicas1.Location = New System.Drawing.Point(23, 10)
        Me.TablasBasicas1.Name = "TablasBasicas1"
        Me.TablasBasicas1.Size = New System.Drawing.Size(473, 425)
        Me.TablasBasicas1.TabIndex = 4
        '
        'FrmTipocuenta
        '
        Me.ClientSize = New System.Drawing.Size(505, 442)
        Me.Controls.Add(Me.TablasBasicas1)
        Me.Name = "FrmTipocuenta"
        Me.ResumeLayout(False)

    End Sub
End Class