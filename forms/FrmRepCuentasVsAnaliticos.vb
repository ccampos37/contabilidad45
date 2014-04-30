Option Strict Off
Option Explicit On
Friend Class FrmRepCuentasVsAnaliticos
	Inherits System.Windows.Forms.Form
	'FIXIT: Utilice Option Explicit para evitar la creación implícita de variables de tipo Variant.     FixIT90210ae-R383-H1984
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		Call imprimir()
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		Me.Close()
	End Sub
	
	Private Sub FrmRepCuentasVsAnaliticos_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call CargaNivel()
		cmbNivel.Text = "1"
	End Sub
	Private Sub CargaNivel()
		Dim i As Short
		For i = 1 To VGnumnivelescuenta
			cmbNivel.Items.Add(VB6.Format(i, "0"))
		Next 
		cmbNivel.SelectedIndex = 0
	End Sub
	
	Public Sub imprimir()
		'FIXIT: Declare 'arrform' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
		Dim arrform(2) As Object
		Dim arrparm(7) As Object

		
		'@Base,@empresa, @Anno, @computer, @Nivel, @tipo
        arrparm(0) = VGParamSistem.BDEmpresa
        arrparm(1) = VGParametros.empresacodigo
        arrparm(2) = VGParamSistem.Anoproceso
        arrparm(3) = VGParamSistem.Mesproceso
        arrparm(4) = VGcomputer
        arrparm(5) = LongitudNivel(CShort(cmbNivel.Text))
        arrparm(6) = "1"
		
		Call ImpresionRptProc("ct_CuentasVsAnaliticos.rpt", arrform, arrparm)
	End Sub
	Private Function LongitudNivel(ByVal nivel As Short) As Short
		Dim rs As ADODB.Recordset
		LongitudNivel = 2
		rs = New ADODB.Recordset
		rs = VGCNx.Execute("SELECT sistemaconfiguracuenta FROM ct_sistema")
		If Not rs.EOF Then
			LongitudNivel = CShort(Mid(rs.Fields("sistemaconfiguracuenta").Value, nivel * 2 - 1, 1))
			'2*4*8
		End If
	End Function

    Private Sub cmbNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNivel.SelectedIndexChanged

    End Sub
End Class