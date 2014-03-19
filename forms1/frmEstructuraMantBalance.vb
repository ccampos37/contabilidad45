Option Strict Off
Option Explicit On
Friend Class frmEstructuraMantBalance
	Inherits System.Windows.Forms.Form
	'FIXIT: Declare 'a_Array' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
	Dim a_Array(12, 12) As Object
	
	Private Sub frmEstructuraMantBalance_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
        CentrarForm(MDIPrincipal, Me)
		
		'Nombre Campos:
        a_Array(0, 0) = "strucbalancelinea"
        a_Array(0, 1) = "strucbalancedato1"
        a_Array(0, 2) = "strucbalancenivel1"
        a_Array(0, 3) = "strucbalancedescrip1"
        a_Array(0, 4) = "strucbalancesigno1"
        a_Array(0, 5) = "strucbalancedato2"
        a_Array(0, 6) = "strucbalancenivel2"
        a_Array(0, 7) = "strucbalancedescrip2"
        a_Array(0, 8) = "strucbalancesigno2"
        a_Array(0, 9) = "usuariocodigo"
        a_Array(0, 10) = "fechaact"
		
		'Etiquetas:
        a_Array(1, 0) = "Línea"
        a_Array(1, 1) = "(M=Mov,L=Lin,E=Esp,T=Tot)"
        a_Array(1, 2) = "Nivel 1"
        a_Array(1, 3) = "Descripción 1"
        a_Array(1, 4) = "Signo 1"
        a_Array(1, 5) = "(M=Mov,L=Lin,E=Esp,T=Tot)"
        a_Array(1, 6) = "Nivel 2"
        a_Array(1, 7) = "Descripción 2"
        a_Array(1, 8) = "Signo 2"
        a_Array(1, 9) = Nothing
        a_Array(1, 10) = Nothing
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
        a_Array(2, 9) = "C"
        a_Array(2, 10) = "D"
		'Ancho de campo:
        a_Array(3, 0) = 6
        a_Array(3, 1) = 1
        a_Array(3, 2) = 20
        a_Array(3, 3) = 60
        a_Array(3, 4) = 2
        a_Array(3, 5) = 1
        a_Array(3, 6) = 20
        a_Array(3, 7) = 60
        a_Array(3, 8) = 2
        a_Array(3, 9) = 8
        a_Array(3, 10) = Nothing
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
        a_Array(5, 9) = VGusuario
        a_Array(5, 10) = Today.ToString("dd/MM/yyyy")
		'a_Array(5, 4) = Format(Now, "aaaa-mm-dd hh:mm:ss.000")
		'Permite Nulos:
        a_Array(6, 0) = False
        a_Array(6, 1) = False
        a_Array(6, 2) = True
        a_Array(6, 3) = False
        a_Array(6, 4) = False
        a_Array(6, 5) = False
        a_Array(6, 6) = False
        a_Array(6, 7) = False
        a_Array(6, 8) = False
        a_Array(6, 9) = False
        a_Array(6, 10) = False
		
        mTablaBasica1.CadenaCone = VGCNxSql
		mTablaBasica1.NombreTabla = "ct_strucbalance"
        mTablaBasica1.TitForm = "Estructura del Balance"
        mTablaBasica1.Arreglo = a_Array
        mTablaBasica1.Setear_Controles()
		mTablaBasica1.Obtener_Campos()
		mTablaBasica1.cargar_datos()
		
	End Sub
	
	'FIXIT: Declare 'indice' con un tipo de datos de enlace en tiempo de compilación           FixIT90210ae-R1672-R1B8ZE
    Private Sub mTablaBasica1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMantTablaBasica.__mTablaBasica_ClickEvent)
        ' If indice = 3 Then
        '   MDIPrincipal.cryRpt.Destination = crptToWindow
        '   MDIPrincipal.cryRpt.WindowState = crptMaximized
        '   MDIPrincipal.cryRpt.ReportFileName = App.Path & "\Reportes\rptEstruMantBalance.rpt"
        '   MDIPrincipal.cryRpt.Connect = vgCADENAREPORT
        '   MDIPrincipal.cryRpt.DiscardSavedData = True
        '   MDIPrincipal.cryRpt.Action = 1
        ' End If
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto indice. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If eventArgs.indice = 3 Then Call Impresion("rptEstruMantBalance.rpt")


    End Sub
End Class