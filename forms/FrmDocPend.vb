Option Strict Off
Option Explicit On
Friend Class FrmDocPend
	Inherits System.Windows.Forms.Form
	'FIXIT: Utilice Option Explicit para evitar la creación implícita de variables de tipo Variant.     FixIT90210ae-R383-H1984
	Dim RsPend As ADODB.Recordset
	Dim CamposAux As ADODB.Fields
	Dim FlagAceptar As Boolean
	
	Public Sub RecibeRs(ByRef rs As ADODB.Recordset, ByRef Campos As ADODB.Fields)
		RsPend = rs.Clone(ADODB.LockTypeEnum.adLockReadOnly)
		TDBG_DocPend.DataSource = RsPend
        lbnregdetalle.Text = Format(RsPend.RecordCount, "0 ")
        Me.ShowDialog()
        Campos = CamposAux
    End Sub

    Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
        CamposAux = RsPend.Fields
        FlagAceptar = True
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
        'UPGRADE_NOTE: El objeto CamposAux no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        CamposAux = Nothing
        FlagAceptar = False
        Me.Close()
    End Sub


	Private Sub FrmDocPend_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_NOTE: El objeto CamposAux no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		If Not FlagAceptar Then CamposAux = Nothing
		FlagAceptar = False
	End Sub
	
	Private Sub TDBG_DocPend_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBG_DocPend.DblClick
		Call cmdAceptar_Click(cmdAceptar, New System.EventArgs())
	End Sub
	
	Private Sub TDBG_DocPend_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_KeyPressEvent) Handles TDBG_DocPend.KeyPressEvent
		If eventArgs.KeyAscii = 13 Then Call cmdAceptar_Click(cmdAceptar, New System.EventArgs())
	End Sub
End Class