Option Strict Off
Option Explicit On
Module MainContab
	'Sistema de Contabilidad Version 1.0
	'Visual Basic 6.0 y SQL - 2000
	'Desarrolladores :
	'Fernando Cossio Peralta
	'Ivan Crispin Sanchez
	
	'Declaraciones de Variables
	'Variables Globales
	Public Const ColorHabilitado As Integer = &H80000004
	Public Const ColorDesHabilitado As Integer = &H80000005
	
	Public VgActivalogin As Integer 'Activa login una sola vez
    Public VGCNxSql As String
	
	Public VGflaglimpia As Boolean 'Flag que Limpia
	Public VGMoverRegistro As Boolean 'Flag al mover el registro
	Public VGCommandoSP As ADODB.Command 'De Comando
	Public VGvardllgen As dllgeneral.dll_general 'Dll de Algunas funciones
	Public VGdllApi As dll_apisgen.dll_apis
	Public VGvarVerifica As Boolean 'Flag Verifica que transaccion es OK (Grabar ,Etc)
	Public VGErrorString As String 'Almacena el Error el que hubo en alguna transaccion
	Public VGValorCambio As Double 'Almacena el valor del Cambio
	Public VGRepiteDoc As Boolean 'Flag de Repite de documento en subasiento
	Public VGactulizodoc As Boolean 'Flag de Actualizacion del detalle de comprobante
	Public VGstrConexion As String 'Cadena de Conexion
	Public VgMostrar As Boolean
	Public vgcont As Short
	Public Vgdocumentoanulado As String
	Public VGformatofecha As String
	
	
	
	Public VGnumnivelescuenta As Short 'Número de Niveles del Plan de Cuentas
	Public VG_aNIVELES() As Short 'Dígitos por Nivel de cuenta
	Public VGnumnivelescentrocosto As Short 'Número de Niveles de los centros de costos
	Public VG_cNIVELES() As Short 'Dígitos por Nivel de costos
	Public VGGlosa As String 'Glosa del Sub Asiento
	Public VGMonSubAsiento As String 'Moneda por defecto del Sub Asiento
	Public vGCadenaReport As String 'Cadena de Reportes Base Empresa
	
	Public strvalor As String
	Public strvalor1 As String
	
	Public VGParametros As ParametrosdeContabilidad
	Public VGParamSistem As ParametrosdeSistema
	Public VGtipo As ModificarCampos.TIPOSISTEMA
	
	Public Structure ParametrosdeContabilidad
		Dim monedabase As String
		Dim IGV As Double
		Dim empresacodigo As String
		Dim NomEmpresa As String
		Dim RucEmpresa As String
		Dim CuadreAsiento As Boolean
		Dim ImpresionAsiento As Boolean
		Dim impresionalta As Boolean
		Dim asientocodigo As String
		Dim subasientocodigo As String
		Dim documentoanulado As String
		Dim sistemamonista As Boolean
		Dim sistemactaajustedeb As String
		Dim sistemactaajustehab As String
		Dim AsientoAutoxCCostos As String
		Dim cuentadeCostos As String
		Dim puntovta As String
		Dim cierremes As Boolean
		Dim MultiEmpresas As Boolean
		Dim ingresoformatorapido As Boolean
	End Structure
	Public Structure ParametrosdeSistema
		Dim TablaCabcomprob As String
		Dim TablaDetcomprob As String
		Dim BDEmpresa As String
		Dim Mesproceso As String
		Dim Anoproceso As String
		Dim FechaTrabajo As Date
		Dim Usuario As String
		Dim Servidor As String
		Dim BDempresaCONF As String
		Dim ServidorGEN As String
		Dim UsuarioGEN As String
		Dim PwdGEN As String
		Dim BDEmpresaGEN As String
		Dim ServidorCT As String
		Dim UsuarioCT As String
		Dim PwdCT As String
		Dim BDEmpresaCT As String
		Dim RutaReport As String
		Dim Pwd As String
		Dim UsuarioReporte As String
		Dim CarpetaReportes As String
	End Structure
	
	
	
	Public Sub AdjuntarServ(ByRef cnx As ADODB.Connection, ByRef Servidor As String)
		On Error GoTo ErrAdjunt
		cnx.Execute("Exec sp_addlinkedserver '" & Servidor & "'")
		Exit Sub
ErrAdjunt: 
		Exit Sub
	End Sub
End Module