Option Strict Off
Option Explicit On
Friend Class frmValidacionSeries
	Inherits System.Windows.Forms.Form
	
	Private Sub frmValidacionSeries_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim rs As ADODB.Recordset
		Dim rsM As ADODB.Recordset
		Dim SQL As String
		Dim serie As String
		Dim numeroini As Integer
		Dim contador As Integer
		
		'Ejecutar el Store del Registro de Ventas: Generar un Temporal
		
		rs = New ADODB.Recordset
		SQL = "select cabcomprobnumero,serie=left(detcomprobnumdocumento,3),"
		SQL = SQL & "numero=substring(detcomprobnumdocumento,5,8) from regventas "
		SQL = SQL & "order by 2,3"
		
		rs = VGCNx.Execute(SQL)
		
		DataGrid1.DataSource = rs
		rs.MoveFirst()
		If Not rs.EOF And Not rs.BOF Then
			
			Do Until rs.EOF
				serie = rs.Fields(1).Value
				'Print serie
				numeroini = CInt(rs.Fields(2).Value)
				Do Until rs.EOF And serie = rs.Fields(1).Value
					If numeroini <> rs.Fields(2).Value Then
						Text1.Text = Text1.Text & rs.Fields(2).Value & " / "
						rs.MoveNext()
						numeroini = CInt(rs.Fields(2).Value)
					End If
					
				Loop 
			Loop 
			
		End If
		
	End Sub
End Class