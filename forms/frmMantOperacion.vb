Option Strict Off
Option Explicit On
Friend Class frmMantOperacion
    Inherits System.Windows.Forms.Form
    Friend WithEvents TablasBasicas1 As TablasBasicas.TablasBasicas
    Dim a_Array(12, 12) As Object
    Private Sub frmMantOperacion_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'CentrarForm MDIPrincipal, Me


        'Nombre Campos:
        a_Array(0, 0) = "operacioncodigo"
        a_Array(0, 1) = "operaciondescripcion"
        a_Array(0, 2) = "operaciondocumentoanulado"
        a_Array(0, 3) = "facturacionanticipada"
        a_Array(0, 4) = "usuariocodigo"
        a_Array(0, 5) = "fechaact"

        'Etiquetas:
        a_Array(1, 0) = "Código"
        a_Array(1, 1) = "Descripcion"
        a_Array(1, 2) = "Permite Doc.Anulado"
        a_Array(1, 3) = "Compensa fact.anticipada"
        a_Array(1, 4) = Nothing
        a_Array(1, 5) = Nothing

        'Tipo de Dato:
        a_Array(2, 0) = "C"
        a_Array(2, 1) = "C"
        a_Array(2, 2) = "B"
        a_Array(2, 3) = "B"
        a_Array(2, 4) = "C"
        a_Array(2, 5) = "D"

        'Ancho de campo:
        a_Array(3, 0) = 2
        a_Array(3, 1) = 25
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
        a_Array(5, 3) = Nothing
        a_Array(5, 4) = VGusuario
        a_Array(5, 5) = Today.ToString("dd/MM/yyyy")

        'Permite Nulos:

        a_Array(6, 0) = False
        a_Array(6, 1) = False
        a_Array(6, 2) = False
        a_Array(6, 3) = False
        a_Array(6, 4) = False
        a_Array(6, 5) = False

        'CadCone = "Data Source=Contabilidad;Initial Catalog=COSITUC;User ID=SA;Password=12345"
        Try
            TablasBasicas1.CadenaCone = VGCNxSql
            TablasBasicas1.NombreTabla = "ct_operacion"
            TablasBasicas1.TitForm = "Operación"
            TablasBasicas1.Filtro = "operacioncodigo<>'00'"
            TablasBasicas1.Arreglo = a_Array

            TablasBasicas1.Setear_Controles()
            TablasBasicas1.Obtener_Campos()
            TablasBasicas1.cargar_datos()

        Catch ex As Exception
            MsgBox("Error --> " + ex.Message)
        End Try
    End Sub
    'Private Sub TablasBasicas1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMantTablaBasica.__mTablaBasica_ClickEvent) Handles TablasBasicas1.ClickEvent
    '    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto indice. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '    If eventArgs.indice = 3 Then Call Impresion("rptOperacion.rpt")
    'End Sub

    Private Sub InitializeComponent()
        Me.TablasBasicas1 = New TablasBasicas.TablasBasicas()
        Me.SuspendLayout()
        '
        'TablasBasicas1
        '
        Me.TablasBasicas1.Location = New System.Drawing.Point(12, 12)
        Me.TablasBasicas1.Name = "TablasBasicas1"
        Me.TablasBasicas1.Size = New System.Drawing.Size(473, 425)
        Me.TablasBasicas1.TabIndex = 4
        '
        'frmMantOperacion
        '
        Me.ClientSize = New System.Drawing.Size(499, 445)
        Me.Controls.Add(Me.TablasBasicas1)
        Me.Name = "frmMantOperacion"
        Me.ResumeLayout(False)

    End Sub
End Class