Option Strict Off
Option Explicit On
Friend Class frmRepComprob
	Inherits System.Windows.Forms.Form
	'FIXIT: Utilice Option Explicit para evitar la creación implícita de variables de tipo Variant.     FixIT90210ae-R383-H1984
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Call imprimir()
	End Sub
	
	Private Sub imprimir()
        Dim SubAsiento As String = ""
        Dim arrform(0) As Object
		Dim arrparm(7) As Object
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        arrparm(0) = Trim(VGParamSistem.BDEmpresa)
        arrparm(1) = VGParametros.empresacodigo
        arrparm(2) = Trim(VGParamSistem.Anoproceso)
        arrparm(3) = Trim(VGParamSistem.Mesproceso)
        arrparm(4) = Trim(TxCompIni.Text)
        arrparm(5) = Trim(Txcomprfin.Text)
        arrparm(6) = Trim(SubAsiento)
		Call ImpresionRptProc("rptVoucherComprobRang.rpt", arrform, arrparm)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
	End Sub
End Class