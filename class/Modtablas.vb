Option Strict Off
Option Explicit On
Imports System.Data
Module ModificarCampos
	
	Public VGCNx As New ADODB.Connection 'Conexion de la BD empresa
	Public VGCnxCT As New ADODB.Connection 'Conexion de Contabilidad
	Public VGGeneral As New ADODB.Connection 'Conexion de la BD Generales
	Public VGConfig As New ADODB.Connection 'Conexion de la BD de configuracion
	Public VGTipoCod As String ' Tipo de codificacion 1:encriptado 0: libre
	Public VGdllApi As New dll_apisgen.dll_apis
	Public UsuarioReporte As String
	Public VGnumniveles As Short 'Número de Niveles del Plan de Cuentas
	Public VGnumnivgas As Short 'Número de Niveles del Plan de gastos
	Public VGnumnivcos As Short 'Número de Niveles de centro de costos
	Public VGSalir As Boolean
	
	Public VGfechalicencia As Date 'fecha limute de licencias
	Public VGtipolicencia As String 'tipo de licencia
	'
	Public VGUsuario As String
	Public VGPass As String
	Public VGcomputer As String 'Nombre de la computadora
	Public VGCodEmpresa As String
	Public SQL As String
	Public RSQL As New ADODB.Recordset
	
	Public VGCadenaReport2 As String
	Public Declare Function GetComputerName Lib "kernel32"  Alias "GetComputerNameA"(ByVal lpBuffer As String, ByRef nSize As Integer) As Integer
	Public Enum TIPOSISTEMA
		inventarios = 1
		compras = 2
		pagar = 3
		caja = 4
		contab = 5
		facturacion = 6
		cobrar = 7
		activos = 8
		costos = 9
		planillas = 10
		PyM = 11
	End Enum
	Public VGsql As String
	
	Public Const NUMMAGICO As Short = 5
	
	'Constantes de mensajes para visualizar
	Public mensaje1 As String
	Public Const g_tiposol As String = "01"
	Public Const g_tipodolar As String = "02"
	Public Const MsgEdit As String = "No Existen Datos para Editar.. "
	Public Const MsgGraba As String = "Datos Grabados satisfactoriamente...."
	Public Const MsgElim As String = "No Existen Datos a Eliminar.."
	Public Const MsgAdd As String = "Los datos ya existen...Verifique!!!"
	Public Const MsgTitle As String = "AVISO"
	Public Const Msg29 As String = "Debe Ingresar Numeros"
	
	Public Enum TIPFECHA
		Sqlf = 1
		Adof = 2
	End Enum
	Public Enum tipocambio
        Compra = 1
        Venta = 2
        Promedio = 3
	End Enum
	Public Sub adicionarcamposinmuebles()
		
		If Not ExisteElem(1, VGCNx, "maeart", "longitudderecha") Then
			VGCNx.Execute("ALTER TABLE maeart ADD longitudderecha float NULL")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "longitudizquierda") Then
			VGCNx.Execute("ALTER TABLE maeart ADD longitudizquierda float NULL")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "longitudfrontal") Then
			VGCNx.Execute("ALTER TABLE maeart ADD longitudfrontal float NULL")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "longitudposterior") Then
			VGCNx.Execute("ALTER TABLE maeart ADD longitudposterior float NULL")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "areaterreno") Then
			VGCNx.Execute("ALTER TABLE maeart ADD areaterreno float NULL")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "areaconstruida") Then
			VGCNx.Execute("ALTER TABLE maeart ADD areaconstruida float NULL")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "numerodepisos") Then
			VGCNx.Execute("ALTER TABLE maeart ADD numerodepisos integer NULL")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "numerodehabitaciones") Then
			VGCNx.Execute("ALTER TABLE maeart ADD numerodehabitaciones integer NULL")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "numerodeservicios") Then
			VGCNx.Execute("ALTER TABLE maeart ADD numerodeservicios integer NULL")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "linderofrontera") Then
			VGCNx.Execute("ALTER TABLE maeart ADD linderofrontera nvarchar(30) NULL")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "linderoposterior") Then
			VGCNx.Execute("ALTER TABLE maeart ADD linderoposterior nvarchar(30) NULL")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "linderoizquierdo") Then
			VGCNx.Execute("ALTER TABLE maeart ADD linderoizquierdo nvarchar(30) NULL")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "linderoderecho") Then
			VGCNx.Execute("ALTER TABLE maeart ADD linderoderecho nvarchar(30) NULL")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "proyectocodigo") Then
			VGCNx.Execute("ALTER TABLE maeart ADD proyectocodigo nvarchar(3) NULL")
		End If
		
	End Sub
	Public Sub adicionarcamposCT()
		
		If Not ExisteElem(1, VGCNx, "co_multiempresas", "empresaruc") Then
			VGCNx.Execute("ALTER TABLE co_multiempresas ADD empresaruc nvarchar(11) NULL")
		End If
		If Not ExisteElem(1, VGCNx, "co_multiempresas", "empresadireccion") Then
			VGCNx.Execute("ALTER TABLE co_multiempresas ADD empresadireccion nvarchar(50) NULL")
		End If
		If Not ExisteElem(1, VGCNx, "co_multiempresas", "cajacodigo") Then
			VGCNx.Execute("ALTER TABLE co_multiempresas ADD cajacodigo varchar(50) default('01')")
		End If
		If Not ExisteElem(1, VGCNx, "ct_operacion", "facturacionanticipada") Then
			VGCNx.Execute("ALTER TABLE ct_operacion ADD facturacionanticipada bit default('0')")
		End If
		If Not ExisteElem(1, VGCNx, "ct_centrocosto", "estructuranumerolinea") Then
			VGCNx.Execute("ALTER TABLE ct_centrocosto ADD estructuranumerolinea varchar(10) ")
		End If
		If Not ExisteElem(1, VGCNx, "ct_saldos" & VGParamSistem.AnoProceso & "", "saldoacumdebe00") Then
			VGCNx.Execute("ALTER TABLE ct_saldos" & VGParamSistem.AnoProceso & " ADD saldoacumdebe00 float default (0) ")
		End If
		If Not ExisteElem(1, VGCNx, "ct_saldos" & VGParamSistem.AnoProceso & "", "saldoacumhaber00") Then
			VGCNx.Execute("ALTER TABLE ct_saldos" & VGParamSistem.AnoProceso & " ADD saldoacumhaber00 float default (0) ")
		End If
		If Not ExisteElem(1, VGCNx, "ct_saldos" & VGParamSistem.AnoProceso & "", "saldoacumussdebe00") Then
			VGCNx.Execute("ALTER TABLE ct_saldos" & VGParamSistem.AnoProceso & " ADD saldoacumussdebe00 float default (0) ")
		End If
		If Not ExisteElem(1, VGCNx, "ct_saldos" & VGParamSistem.AnoProceso & "", "saldoacumussHaber00") Then
			VGCNx.Execute("ALTER TABLE ct_saldos" & VGParamSistem.AnoProceso & " ADD saldoacumussHaber00 float default (0) ")
		End If
		If Not ExisteElem(1, VGCNx, "ct_cuenta", "cuentaadicionacargo") Then
			VGCNx.Execute("ALTER TABLE ct_cuenta ADD cuentaadicionacargo char(1) default ('0') ")
		End If 'JCGI
		If Not ExisteElem(1, VGCNx, "ct_asiento", "asientoadicionacargo") Then
			VGCNx.Execute("ALTER TABLE ct_asiento ADD asientoadicionacargo char(1) default ('0') ")
		End If
		If Not ExisteElem(1, VGCNx, "ct_importarventas", "procedimientoasiento") Then
			VGCNx.Execute("ALTER TABLE ct_importarventas ADD procedimientoasiento varchar(40) default ('') ")
			VGCNx.Execute(" update ct_importarventas set procedimientoasiento='' ")
		End If 'JCGI
		If Not ExisteElem(1, VGConfig, "si_usuario", "usuariocodigo") Then
			VGConfig.Execute("ALTER TABLE si_usuario ADD usuariocodigo varchar(8) default('') ")
			If ExisteElem(1, VGConfig, "si_usuario", "UsuarioCodigo") Then
				VGConfig.Execute("UPDATE si_usuario SET usuariocodigo=UsuarioCodigo")
			End If
		End If
		If Not ExisteElem(1, VGConfig, "si_usuario", "usuariopassword") Then
			VGConfig.Execute("ALTER TABLE si_usuario ADD usuariopassword varchar(8) default('') ")
			If ExisteElem(1, VGConfig, "si_usuario", "usu_password") Then
				VGConfig.Execute("UPDATE si_usuario SET usuariopassword=usu_password")
			End If
		End If
		If Not ExisteElem(1, VGConfig, "si_usuario", "usuarionombre") Then
			VGConfig.Execute("ALTER TABLE si_usuario ADD usuarionombre varchar(30) default('') ")
			If ExisteElem(1, VGConfig, "si_usuario", "usu_nombre") Then
				VGConfig.Execute("UPDATE si_usuario SET usuarionombre=usu_nombre")
			End If
		End If
		If Not ExisteElem(1, VGConfig, "si_menuusuarios", "usuariocodigo") Then
			VGConfig.Execute("ALTER TABLE si_menuusuarios ADD usuariocodigo varchar(8) default('') ")
			If ExisteElem(1, VGConfig, "si_menuusuarios", "UsuarioCodigo") Then
				VGConfig.Execute("UPDATE si_menuusuarios SET usuariocodigo=UsuarioCodigo")
			End If
		End If
		If Not ExisteElem(1, VGCNx, "ct_detcomprob" & VGParamSistem.AnoProceso & "", "detcomprobfechadetraccion") Then
			VGCNx.Execute("ALTER TABLE ct_detcomprob" & VGParamSistem.AnoProceso & " ADD detcomprobfechadetraccion datetime ")
		End If
		If Not ExisteElem(1, VGCNx, "ct_detcomprob" & VGParamSistem.AnoProceso & "", "detcomprobnumerodetraccion") Then
			VGCNx.Execute("ALTER TABLE ct_detcomprob" & VGParamSistem.AnoProceso & " ADD detcomprobnumerodetraccion varchar(20) default('')  ")
		End If
		If Not ExisteElem(1, VGConfig, "empresa", "tipodelicencias") Then
			VGConfig.Execute("ALTER TABLE empresa ADD tipodelicencias varchar(1) default('')  ")
			VGConfig.Execute("update empresa set tipodelicencias ='T'")
		End If
		If Not ExisteElem(1, VGConfig, "empresa", "fechalimitelicencias") Then
			VGConfig.Execute("ALTER TABLE empresa ADD fechalimitelicencias datetime ")
			VGConfig.Execute("update empresa set fechalimitelicencias ='31/12/2014'")
		End If
		If ExisteElem(1, VGCNx, "CO_multiempresas", "empresadescripcion") Then
			VGCNx.Execute("ALTER TABLE CO_multiempresas ALTER COLUMN empresadescripcion varchar(50)")
		End If
		If Not ExisteElem(1, VGCNx, "ct_librosSunatcorrelativos", "LibrosunatEstadoAnulado") Then
			VGCNx.Execute("ALTER TABLE ct_librosSunatcorrelativos ADD LibrosunatEstadoAnulado bit default(1) ")
			VGCNx.Execute("update ct_librosSunatcorrelativos set LibrosunatEstadoAnulado =1")
		End If
		If Not ExisteElem(1, VGCNx, "ct_plantillaasiento", "plantillaasientoTipo") Then
			VGCNx.Execute("ALTER TABLE ct_plantillaasiento ADD plantillaasientoTipo varchar(5) default('') ")
			VGCNx.Execute("update ct_plantillaasiento set plantillaasientoTipo =''")
		End If
		If Not ExisteElem(1, VGCNx, "ct_sistema", "ingresoformatorapido") Then
			VGCNx.Execute("ALTER TABLE ct_sistema ADD ingresoformatorapido bit default(0) ")
			VGCNx.Execute("update ct_sistema set ingresoformatorapido =0")
		End If
	End Sub
	Public Sub adicionarcamposcostos()
		If Not ExisteElem(1, VGCNx, "cs_sistema", "baseorigen") Then
			VGCNx.Execute("ALTER TABLE cs_sistema ADD baseorigen varchar(30) default(' ')")
		End If
		If Not ExisteElem(1, VGCNx, "cs_resumenxmesplantillas", "importedolares") Then
			VGCNx.Execute("ALTER TABLE cs_resumenxmesplantillas ADD importedolares float default('0')")
		End If
		If Not ExisteElem(1, VGCNx, "cs_sistema", "codigopersonalplantilla") Then
			VGCNx.Execute("ALTER TABLE cs_sistema ADD codigopersonalplantilla varchar(2) default('00')")
		End If
		If Not ExisteElem(1, VGCNx, "cs_sistema", "mesesreferencia") Then
			VGCNx.Execute("ALTER TABLE cs_sistema ADD mesesreferencia integer default('12')")
		End If
		If Not ExisteElem(1, VGCNx, "cs_estructurapresentacion", "tipodegastosfijos") Then
			VGCNx.Execute("ALTER TABLE cs_estructurapresentacion ADD tipodegastosfijos bit default('0') ")
		End If
		If Not ExisteElem(1, VGCNx, "cs_sistema", "mesdecierre") Then
			VGCNx.Execute("ALTER TABLE cs_sistema ADD mesdecierre nvarchar(6) default('') ")
		End If
	End Sub
	Public Sub adicionarcampos()
		On Error GoTo err2
		If Not ExisteElem(1, VGCNx, "co_multiempresas", "empresaruc") Then
			VGCNx.Execute("ALTER TABLE co_multiempresas ADD empresaruc nvarchar(11) NULL")
		End If
		If Not ExisteElem(1, VGCNx, "co_multiempresas", "empresadireccion") Then
			VGCNx.Execute("ALTER TABLE co_multiempresas ADD empresadireccion nvarchar(50) NULL")
		End If
		If Not ExisteElem(1, VGCNx, "co_multiempresas", "codigocuenta") Then
			VGCNx.Execute("ALTER TABLE co_multiempresas ADD codigocuenta nvarchar(14) NULL")
		End If
		If ExisteElem(1, VGCNx, "cc_tipodocumento", "tdocumentonumerador") Then
			VGCNx.Execute("ALTER TABLE cc_tipodocumento ALTER COLUMN tdocumentonumerador nvarchar(15) NULL")
		End If
		If Not ExisteElem(1, VGCNx, "te_codigocaja", "empresacodigo") Then
			VGCNx.Execute("ALTER TABLE te_codigocaja ADD empresacodigo varchar(2) default('01')")
		End If
		If Not ExisteElem(1, VGCNx, "vt_cargo", "empresacodigo") Then
			VGCNx.Execute("ALTER TABLE vt_cargo ADD empresacodigo varchar(2) default('01')")
		End If
		If Not ExisteElem(1, VGCNx, "vt_abono", "empresacodigo") Then
			VGCNx.Execute("ALTER TABLE vt_abono ADD empresacodigo varchar(2) default('01')")
		End If
		If Not ExisteElem(1, VGCNx, "vt_puntovtadocumento", "empresacodigo") Then
			VGCNx.Execute("ALTER TABLE vt_puntovtadocumento ADD empresacodigo varchar(2) default('01')")
		End If
		If Not ExisteElem(1, VGCNx, "vt_seriedocumento", "empresacodigo") Then
			VGCNx.Execute("ALTER TABLE vt_seriedocumento ADD empresacodigo varchar(2) default('01')")
		End If
		If Not ExisteElem(1, VGCNx, "te_saldosmensuales", "empresacodigo") Then
			VGCNx.Execute("ALTER TABLE te_saldosmensuales ADD empresacodigo varchar(2) default('01')")
		End If
		If Not ExisteElem(1, VGCNx, "co_multiempresas", "cajacodigo") Then
			VGCNx.Execute("ALTER TABLE co_multiempresas ADD cajacodigo varchar(50) default('01')")
		End If
		If Not ExisteElem(1, VGCNx, "ct_operacion", "facturacionanticipada") Then
			VGCNx.Execute("ALTER TABLE ct_operacion ADD facturacionanticipada bit default('0')")
		End If
		If Not ExisteElem(1, VGCNx, "ct_centrocosto", "estructuranumerolinea") Then
			VGCNx.Execute("ALTER TABLE ct_centrocosto ADD estructuranumerolinea varchar(10) ")
		End If
		If Not ExisteElem(1, VGCNx, "co_tipocompra", "modosprovisionescodigo") Then
			VGCNx.Execute("ALTER TABLE co_tipocompra ADD modosprovisionescodigo varchar(30) default('01,05')")
		End If
		If Not ExisteElem(1, VGCNx, "al_sistema", "flagconversioncodigo") Then
			VGCNx.Execute("ALTER TABLE al_sistema ADD flagconversioncodigo bit default('0')")
		End If
		If Not ExisteElem(0, VGCNx, "al_tipoalmacen") Then
			SQL = " Create Table al_tipoalmacen "
			SQL = SQL & "( tipoalmacencodigo VarChar(1),"
			SQL = SQL & "tipoalmacendescripcion VarChar(30),"
			SQL = SQL & "usuariocodigo varchar(8),fechaact datetime "
			SQL = SQL & " CONSTRAINT PK_al_tipoalmacen "
			SQL = SQL & " PRIMARY KEY (tipoalmacencodigo))  "
			VGCNx.Execute(SQL)
		End If
		If Not ExisteElem(1, VGCNx, "al_sistema", "flagtipoalmacen") Then
			VGCNx.Execute("ALTER TABLE al_sistema ADD flagtipoalmacen bit default('0')")
		End If
		If Not ExisteElem(1, VGCNx, "tabalm", "tipoalmacencodigo") Then
			VGCNx.Execute("ALTER TABLE tabalm ADD tipoalmacencodigo varchar(1) default('0')")
		End If
		If Not ExisteElem(1, VGCNx, "co_gastos", "gastosgeneractacte") Then
			VGCNx.Execute("ALTER TABLE co_gastos ADD gastosgeneractacte bit default('0')")
		End If
		If Not ExisteElem(1, VGCNx, "co_gastos", "tipodocumentocodigo") Then
			VGCNx.Execute("ALTER TABLE co_gastos ADD tipodocumentocodigo varchar(2) default('00')")
		End If
		If Not ExisteElem(1, VGCNx, "co_multiempresas", "empresadescrcorta") Then
			VGCNx.Execute("ALTER TABLE co_multiempresas ADD empresadescrcorta varchar(15) ")
		End If
		If Not ExisteElem(1, VGCNx, "co_multiempresas", "empresatelefonos") Then
			VGCNx.Execute("ALTER TABLE co_multiempresas ADD empresatelefonos varchar(20) ")
		End If
		If Not ExisteElem(1, VGConfig, "empresa", "multiguiasremision") Then
			VGConfig.Execute("ALTER TABLE empresa ADD multiguiasremision bit default('0')")
		End If
		If Not ExisteElem(1, VGConfig, "empresa", "multifacturas") Then
			VGConfig.Execute("ALTER TABLE empresa ADD multifacturas bit default('0') ")
		End If
		If Not ExisteElem(1, VGConfig, "empresa", "multiboletas") Then
			VGConfig.Execute("ALTER TABLE empresa ADD multiboletas bit default('0') ")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "estadodetraccion") Then
			VGCNx.Execute("ALTER TABLE maeart ADD estadodetraccion bit default('0') ")
		End If
		If Not ExisteElem(1, VGCNx, "vt_parametroventa", "kitvirtual") Then
			VGCNx.Execute("ALTER TABLE vt_parametroventa ADD kitvirtual bit default('0') ")
		End If
		If Not ExisteElem(1, VGCNx, "vt_pedido", "pedidoobserva") Then
			VGCNx.Execute("ALTER TABLE vt_pedido ADD pedidoobserva varchar(200) default('0') ")
		End If
		If Not ExisteElem(1, VGCNx, "tabtransa", "ingresosfuturos") Then
			VGCNx.Execute("ALTER TABLE tabtransa ADD ingresosfuturos bit default('0') ")
		End If
		If Not ExisteElem(1, VGCNx, "vt_parametroventa", "minimodetraccion") Then
			VGCNx.Execute("ALTER TABLE vt_parametroventa ADD minimodetraccion float default('999999') ")
		End If
		If Not ExisteElem(1, VGCNx, "co_sistema", "codigopercepcion") Then
			VGCNx.Execute("ALTER TABLE co_sistema ADD codigopercepcion nvarchar(20) ")
		End If
		If Not ExisteElem(1, VGCNx, "cp_tipodocumento", "tdocumentointerempresa") Then
			VGCNx.Execute("ALTER TABLE cp_tipodocumento ADD tdocumentointerempresa bit default('0')")
		End If
		If Not ExisteElem(1, VGCNx, "te_cuentabancos", "empresacodigo") Then
			VGCNx.Execute("ALTER TABLE te_cuentabancos ADD empresacodigo char(2) default('01')")
		End If
		If Not ExisteElem(1, VGCNx, "co_modoprovi", "modoprovianalitico") Then
			VGCNx.Execute("ALTER TABLE co_modoprovi ADD modoprovianalitico bit default('0')")
		End If
		If Not ExisteElem(1, VGCNx, "co_cabeceraprovisiones", "cabprovianalitico") Then
			VGCNx.Execute("ALTER TABLE co_cabeceraprovisiones ADD cabprovianalitico varchar(11)")
		End If
		If Not ExisteElem(1, VGCNx, "co_sistema", "TipoDocAcuenta") Then
			VGCNx.Execute("ALTER TABLE co_sistema ADD TipoDocAcuenta char(2)")
		End If
		If Not ExisteElem(1, VGCNx, "co_sistema", "TipoDocRetencion") Then
			VGCNx.Execute("ALTER TABLE co_sistema ADD TipoDocRetencion char(2)")
		End If
		If Not ExisteElem(1, VGCNx, "co_modoprovi", "librocodigo") Then
			VGCNx.Execute("ALTER TABLE co_modoprovi ADD librocodigo char(2) default('00')")
		End If
		If Not ExisteElem(1, VGCNx, "co_modoprovi", "mesproceso") Then
			VGCNx.Execute("ALTER TABLE co_modoprovi ADD mesproceso char(6) default('000000')")
		End If
		If Not ExisteElem(1, VGCNx, "te_cabecerarecibos", "cabprovinumaux") Then
			VGCNx.Execute("ALTER TABLE te_cabecerarecibos ADD cabprovinumaux varchar(10) default('')")
		End If
		If Not ExisteElem(1, VGCNx, "co_cabeceraprovisiones", "cabprovinumlibro") Then
			VGCNx.Execute("ALTER TABLE co_cabeceraprovisiones ADD cabprovinumlibro varchar(20) default('')")
		End If
		If Not ExisteElem(0, VGConfig, "si_usuario") Then
			VGConfig.Execute("select * into si_usuario  from usuario")
		End If
		If Not ExisteElem(1, VGCNx, "vt_parametroventa", "PedidosSinfacturar") Then
			VGCNx.Execute("ALTER TABLE vt_parametroventa ADD PedidosSinfacturar bit default(0)")
			VGCNx.Execute("update vt_parametroventa SET PedidosSinfacturar=0")
		End If
		If Not ExisteElem(1, VGCNx, "co_cabordcompra", "puntovtacodigo") Then
			VGCNx.Execute("ALTER TABLE co_cabordcompra ADD puntovtacodigo char(2) default('00')")
			VGCNx.Execute("update co_cabordcompra SET puntovtacodigo='00'")
		End If
		If Not ExisteElem(1, VGCNx, "co_cabordcompra", "trasladofisico") Then
			VGCNx.Execute("ALTER TABLE co_cabordcompra ADD trasladofisico bit default(0)")
			VGCNx.Execute("update co_cabordcompra SET trasladofisico=0")
		End If
		If Not ExisteElem(1, VGCNx, "co_estadorequerimiento", "NivelRequerimiento") Then
			VGCNx.Execute("ALTER TABLE co_estadorequerimiento ADD NivelRequerimiento char(1) default('0')")
			VGCNx.Execute("update co_estadorequerimiento SET NivelRequerimiento='0'")
		End If
		If Not ExisteElem(1, VGCNx, "co_tipodeorden", "flagrequerimientosPedidos") Then
			VGCNx.Execute("ALTER TABLE co_tipodeorden ADD flagrequerimientosPedidos char(1) default('0')")
			VGCNx.Execute("update co_tipodeorden SET flagrequerimientosPedidos='0'")
		End If
		If Not ExisteElem(1, VGCNx, "co_cabordcompra", "estadoordencodigo") Then
			VGCNx.Execute("ALTER TABLE co_cabordcompra ADD estadoordencodigo integer default(0)")
			VGCNx.Execute("update co_cabordcompra SET estadoordencodigo=0")
		End If
		If ExisteElem(1, VGCNx, "VT_detallepedido", "unidadcodigo") Then
			VGCNx.Execute("ALTER TABLE VT_detallepedido ALTER COLUMN unidadcodigo varchar(5) ")
		End If
		If Not ExisteElem(1, VGCNx, "al_sistema", "SaldoConsolidadoxPedidos") Then
			VGCNx.Execute("ALTER TABLE al_sistema ADD SaldoConsolidadoxPedidos integer default(0) ")
		End If
		If Not ExisteElem(1, VGCNx, "al_sistema", "SaldoConsolidadoxPedidos") Then
			VGCNx.Execute("ALTER TABLE al_sistema ADD SaldoConsolidadoxPedidos integer default(0) ")
		End If
		If Not ExisteElem(1, VGCNx, "movalmcab", "usuariomodifica") Then
			VGCNx.Execute("ALTER TABLE movalmcab ADD usuariomodifica varchar(8) default('') ")
		End If
		If Not ExisteElem(1, VGCNx, "movalmcab", "fechamodifica") Then
			VGCNx.Execute("ALTER TABLE movalmcab ADD fechamodifica datetime ")
		End If
		If Not ExisteElem(1, VGCNx, "movalmcab", "hostname") Then
			VGCNx.Execute("ALTER TABLE movalmcab ADD hostname varchar(50) default(host_name()) ")
		End If
		If ExisteElem(1, VGCNx, "tabalm", "puntovtacodigo") Then
			VGCNx.Execute("ALTER TABLE tabalm ALTER COLUMN puntovtacodigo varchar(50) ")
		End If
		If Not ExisteElem(1, VGCNx, "al_sistema", "multiplespuntovta") Then
			VGCNx.Execute("ALTER TABLE al_sistema ADD multiplespuntovta integer default(0) ")
		End If
		If Not ExisteElem(1, VGCNx, "vt_sistema", "empresaasientosautomaticos") Then
			VGCNx.Execute("ALTER TABLE vt_sistema ADD empresaasientosautomaticos integer default(0) ")
		End If
		If ExisteElem(1, VGCNx, "te_parametroempresa", "empresaasientosautomaticos") Then
			VGCNx.Execute("ALTER TABLE te_parametroempresa ALTER COLUMN empresaasientosautomaticos integer ")
		End If
		If ExisteElem(1, VGCNx, "movalmcab", "cacotiza") Then
			VGCNx.Execute("ALTER TABLE movalmcab ALTER COLUMN cacotiza varchar(60) ")
		End If
		If Not ExisteElem(1, VGCNx, "vt_sistema", "generapedidotemporal") Then
			VGCNx.Execute("ALTER TABLE vt_sistema ADD generapedidotemporal integer default(0) ")
		End If
		If Not ExisteElem(1, VGCNx, "vt_asientodet", "cuentaventadiferida") Then
			VGCNx.Execute("ALTER TABLE vt_asientodet ADD cuentaventadiferida varchar(20) default ('00') ")
			VGCNx.Execute(" update vt_asientodet set cuentaventadiferida=cuenta ")
		End If
		If Not ExisteElem(1, VGCNx, "vt_pedido", "pedidoventadiferida") Then
			VGCNx.Execute("ALTER TABLE vt_pedido ADD pedidoventadiferida integer  default (0) ")
			VGCNx.Execute(" update vt_pedido set pedidoventadiferida=0 ")
		End If 'JCGI
		If Not ExisteElem(1, VGCNx, "vt_sistema", "pedidotipovena") Then
			VGCNx.Execute("ALTER TABLE vt_sistema ADD pedidotipovena varchar(20) default ('') ")
			VGCNx.Execute(" update vt_sistema set pedidotipovena='' ")
		End If 'JCGI
		If Not ExisteElem(1, VGCNx, "vt_modoventa", "modovtacopiasBO") Then
			VGCNx.Execute("ALTER TABLE vt_modoventa ADD modovtacopiasBO integer default (0) ")
			VGCNx.Execute(" update vt_modoventa set modovtacopiasBO=0 ")
		End If
		If Not ExisteElem(1, VGCNx, "vt_sistema", "impresionvisual") Then
			VGCNx.Execute("ALTER TABLE vt_sistema ADD impresionvisual integer")
		End If
		If Not ExisteElem(1, VGCNx, "te_parametroempresa", "multicajas") Then
			VGCNx.Execute("ALTER TABLE te_parametroempresa ADD multicajas integer default(1)")
			VGCNx.Execute(" update te_parametroempresa set multicajas=1 ")
			
		End If
		If Not ExisteElem(1, VGCNx, "vt_sistema", "temporalpedidos") Then
			VGCNx.Execute("ALTER TABLE vt_sistema ADD temporalpedidos integer default(0)")
		End If
		If Not ExisteElem(1, VGCNx, "vt_cargo", "pedidonumero") Then
			VGCNx.Execute("ALTER TABLE vt_cargo ADD pedidonumero varchar(15) default('')")
		End If
		If Not ExisteElem(1, VGCNx, "movalmcab", "cabcomprobnumero") Then
			VGCNx.Execute("ALTER TABLE movalmcab ADD cabcomprobnumero varchar(10) default('')")
		End If
		If Not ExisteElem(1, VGCNx, "tabtransa", "asientocodigo") Then
			VGCNx.Execute("ALTER TABLE tabtransa ADD asientocodigo varchar(3) default('00')")
		End If
		If Not ExisteElem(1, VGCNx, "al_sistema", "asientoautoAContab") Then
			VGCNx.Execute("ALTER TABLE al_sistema ADD asientoautoAContab integer default(0)")
		End If
		If Not ExisteElem(1, VGCNx, "movalmcab", "fechadocumento") Then
			VGCNx.Execute("ALTER TABLE movalmcab ADD fechadocumento date ")
		End If
		If Not ExisteElem(1, VGCNx, "movalmcab", "tipodocumento") Then
			VGCNx.Execute("ALTER TABLE movalmcab ADD tipodocumento varchar(2) default('')")
			VGCNx.Execute("update movalmcab set tipodocumento ='' where isnull(tipodocumento,'')=''")
		End If
		
		If Not ExisteElem(1, VGCNx, "movalmcab", "numerodocumento") Then
			VGCNx.Execute("ALTER TABLE movalmcab ADD numerodocumento varchar(15) default('')")
			VGCNx.Execute("update movalmcab set numerodocumento ='' where isnull(numerodocumento,'')=''")
		End If
		If Not ExisteElem(1, VGCNx, "co_sistema", "sistemactaPERCEPCION") Then
			VGCNx.Execute("ALTER TABLE co_sistema ADD sistemactaPERCEPCION varchar(20) default('')")
			VGCNx.Execute("update co_sistema set sistemactaPERCEPCION ='' where isnull(sistemactaIES,'')=''")
		End If
		If Not ExisteElem(1, VGCNx, "movalmcab", "ImporteBruto") Then
			VGCNx.Execute("ALTER TABLE movalmcab ADD ImporteBruto float")
			VGCNx.Execute("update movalmcab set ImporteBruto =0 ")
		End If
		If Not ExisteElem(1, VGCNx, "movalmcab", "ImporteIgv") Then
			VGCNx.Execute("ALTER TABLE movalmcab ADD ImporteIgv float")
			VGCNx.Execute("update movalmcab set ImporteIgv =0 ")
		End If
		If Not ExisteElem(1, VGCNx, "movalmcab", "ImportePercepcion") Then
			VGCNx.Execute("ALTER TABLE movalmcab ADD ImportePercepcion float")
			VGCNx.Execute("update movalmcab set ImportePercepcion =0 ")
		End If
		If Not ExisteElem(1, VGCNx, "vt_parametroventa", "ventasBM") Then
			VGCNx.Execute("ALTER TABLE vt_parametroventa ADD ventasBM integer ")
			VGCNx.Execute("update vt_parametroventa set ventasBM =0 ")
		End If
		If Not ExisteElem(1, VGCNx, "vt_sistema", "codigosduplicados") Then
			VGCNx.Execute("ALTER TABLE vt_sistema ADD codigosduplicados integer ")
			VGCNx.Execute("update vt_sistema set codigosduplicados =1 ")
		End If
		If Not ExisteElem(1, VGCNx, "vt_cargo", "puntovtacodigo") Then
			VGCNx.Execute("ALTER TABLE vt_cargo ADD puntovtacodigo varchar(20) default('01')  ")
			VGCNx.Execute("update vt_cargo set puntovtacodigo ='' ")
		End If
		If Not ExisteElem(1, VGCNx, "vt_puntoventa", "codigocajavtasDol") Then
			VGCNx.Execute("ALTER TABLE vt_puntoventa ADD codigocajavtasDol varchar(2) ")
			VGCNx.Execute("update vt_puntoventa set codigocajavtasDol =''")
		End If
		If Not ExisteElem(1, VGCNx, "maeart", "tipodecambio") Then
			VGCNx.Execute("ALTER TABLE maeart ADD tipodecambio float default(0) ")
			VGCNx.Execute("update maeart set tipodecambio =0")
		End If
		If Not ExisteElem(1, VGCNx, "al_sistema", "Controlatipodecambio") Then
			VGCNx.Execute("ALTER TABLE al_sistema ADD Controlatipodecambio integer default(0) ")
			VGCNx.Execute("update al_sistema set Controlatipodecambio =0")
		End If
		If Not ExisteElem(1, VGCNx, "TABUNIMED", "sunatcodigo") Then
			VGCNx.Execute("ALTER TABLE TABUNIMED ADD sunatcodigo varchar(5) default('') ")
			VGCNx.Execute("update TABUNIMED set sunatcodigo =''")
		End If
		If Not ExisteElem(1, VGCNx, "tipo_docu", "sunatcodigo") Then
			VGCNx.Execute("ALTER TABLE tipo_docu ADD sunatcodigo varchar(5) default('') ")
			VGCNx.Execute("update tipo_docu set sunatcodigo =''")
		End If
		If Not ExisteElem(1, VGCNx, "CT_centrocosto", "EstadoAnulado") Then
			VGCNx.Execute("ALTER TABLE CT_centrocosto ADD EstadoAnulado bit default(0) ")
			VGCNx.Execute("update CT_centrocosto set EstadoAnulado =0")
		End If
		Exit Sub
err2: 
		' MsgBox "Error inesperado: " & Err.Number & "  " & Err.Description, vbExclamation
		Resume Next
	End Sub
	Public ReadOnly Property ComputerName(Optional ByVal tipo As Short = 0) As Object
		Get
			Dim sName As String
			Dim iRetVal As Integer
			Dim ipos As Short
			Dim NombrePC As String
			sName = Space(255)
			iRetVal = GetComputerName(sName, 255)
			If iRetVal = 0 Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ComputerName. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ComputerName = ""
				Exit Property
			End If
			ipos = InStr(sName, Chr(0))
			If tipo = 0 Then
				Randomize()
				NombrePC = Trim(Str(CInt(Rnd() * 10000000)))
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ComputerName. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ComputerName = "##" & Left(sName, ipos - 1) & NombrePC
			ElseIf tipo = 1 Then 
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ComputerName. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ComputerName = "##" & Left(sName, ipos - 1)
			Else
				ComputerName = Left(sName, ipos - 1)
			End If
		End Get
	End Property
	Public Sub central(ByRef f As System.Windows.Forms.Form)
		f.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(f.Width)) / 2)
		f.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) / 1.19 - VB6.PixelsToTwipsY(f.Height)))
	End Sub
	
	Public Sub Enfoque(ByRef OBJ As Object)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto OBJ.SelStart. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OBJ.SelStart = 0
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto OBJ.SelLength. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OBJ.SelLength = Len(OBJ)
	End Sub
	
	Public Function Existe(ByRef tipo As Short, ByRef Cod As String, ByRef Tabla As String, ByRef Campo As String, ByRef Fecha As Boolean, Optional ByRef Cod2 As String = "", Optional ByRef cCampo2 As String = "", Optional ByRef Cod3 As String = "", Optional ByRef cCampo3 As String = "", Optional ByRef Cod4 As Boolean = False, Optional ByRef cCampo4 As String = "", Optional ByRef Cod5 As String = "", Optional ByRef cCampo5 As String = "") As Boolean
		Dim cSel1 As ADODB.Recordset
		Dim cSL As String
		cSel1 = New ADODB.Recordset
		
		If Fecha Then
			cSL = "Select * from " & Tabla & "  Where " & Campo & " =  '" & Cod & "'"
		Else
			If UCase(Tabla) = "PUNTO_VENTA" Then
				cSL = "Select * from " & Tabla & "  Where " & Campo & " =  '" & Cod & "'"
			Else
				cSL = "Select * from " & Tabla & "  Where " & Campo & " =  '" & Cod & "'"
			End If
			If Trim(Cod2) <> "" Then
				cSL = cSL & " And  " & cCampo2 & " =  '" & SupCadSQL(Cod2) & "'"
			End If
			If Trim(Cod3) <> "" Then
				cSL = cSL & " And  " & cCampo3 & " =  '" & SupCadSQL(Cod3) & "'"
			End If
			If Trim(cCampo4) <> "" Then
				If Cod4 = True Then
					cSL = cSL & " And  " & cCampo4
				Else
					cSL = cSL & " And  " & Not cCampo4
				End If
			End If
			If Trim(Cod5) <> "" Then
				cSL = cSL & " And  " & cCampo5 & " =  '" & Cod5 & "'"
			End If
		End If
		
		Select Case tipo
			Case 1 'Bd. Comun
				cSel1.Open(cSL, VGCNx, ADODB.CursorTypeEnum.adOpenStatic)
			Case 2 'Bd. Config
				cSel1.Open(cSL, VGConfig, ADODB.CursorTypeEnum.adOpenStatic)
			Case 3 'Bd. Contab
				cSel1.Open(cSL, VGCnxCT, ADODB.CursorTypeEnum.adOpenStatic)
		End Select
		
		If cSel1.RecordCount > 0 Then
			Existe = True
		Else
			Existe = False
		End If
		'csel1.Close
	End Function
	Public Function Validar_RUC(ByRef xRuc As String) As Boolean
		Dim flag As Boolean
		'UPGRADE_WARNING: El límite inferior de la matriz TAB_VAL ha cambiado de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		Dim TAB_VAL(10) As Short
		Dim NR, nX, NY, i As Short
		Dim CadNR As String
		
		' TAB_VAL(1) = 2
		' TAB_VAL(2) = 7
		' TAB_VAL(3) = 6
		' TAB_VAL(4) = 5
		' TAB_VAL(5) = 4
		' TAB_VAL(6) = 3
		' TAB_VAL(7) = 2
		flag = True
		xRuc = Trim(xRuc)
		
		' If xRuc <> " " Then
		'If xRuc <> "00000002" Then
		If Len(RTrim(xRuc)) < 11 Then
			MsgBox("Número de R.U.C. no tiene 11 dígitos", MsgBoxStyle.Exclamation, "Ingreso de Datos")
			flag = False
		Else
			'         nX = 0
			'         NR = 0
			'         NY = 0
			'         CadNR = ""
			'         For i = 1 To 7
			'             nX = nX + Val(mid$(xRuc, i, 1)) * TAB_VAL(i)
			'         Next i
			'         NY = nX \ 11
			'         NR = 11 - (nX - (NY * 11))
			'         CadNR = TRIM$(String(10 - Len(Str(NR)) + 1, "0")) & TRIM$(Str(NR))
			'         If mid$(CadNR, 10, 1) = mid$(xRuc, 8, 1) Then
			'            flag = True
			''         Else
			'            MsgBox "Número de R.U.C. invalido", vbExclamation, "Ingreso de Datos"
			'            flag = False
			'         End If
		End If
		'   Else
		'      MsgBox "Anexo emite Liquidaciones de compra", vbExclamation, "Ingreso de Datos"
		'  End If
		'End If
		Validar_RUC = flag
	End Function
	'*************************************************
	'Elimina de ( ' ) de una Cadena
	'para Grabarla en una instrucción SQL
	'*************************************************
	Public Function SupCadSQL(ByRef S As String) As String
        Dim Aux As String = ""
        If Not IsDBNull(S) Then
            Aux = Replace(S, "'", "''")
        End If
		SupCadSQL = Aux
		
	End Function
	
	Public Sub ImpresionRptProc(ByRef cNombreReporte As String, ByRef PFormulas() As Object, ByRef Param() As Object, Optional ByRef ORDEN As String = "", Optional ByRef titulo As String = "")
		Dim i As Short
		On Error GoTo x
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		With MDIPrincipal.CryRptProc
			.Reset()
			.WindowTitle = titulo
			Call PropCrystal((MDIPrincipal.CryRptProc))
			.ReportFileName = VGParamSistem.RutaReport
			If Right(VGParamSistem.RutaReport, 1) <> "\" Then
				.ReportFileName = VGParamSistem.RutaReport & "\"
			End If
			.ReportFileName = .ReportFileName & VGParamSistem.carpetareportes
			
			If Right(.ReportFileName, 1) <> "\" Then
				.ReportFileName = .ReportFileName & "\"
			End If
			'.ReportFileName &
			.ReportFileName = .ReportFileName & cNombreReporte
			If CDbl(VGsql) = 1 Then
				.Connect = "Provider=SQLOLEDB;Password=" & VGParamSistem.PwdGEN & ";Persist Security Info=True;User ID=" & VGParamSistem.UsuarioGEN & ";Initial Catalog=" & VGParamSistem.BDEmpresaGEN & ";SERVER=" & VGParamSistem.ServidorGEN
			Else
				.Connect = VGCadenaReport2
			End If
			
			.set_formulas(0, "@Empresa='" & VGParametros.NomEmpresa & "'")
			.set_formulas(1, "@Ruc='" & VGParametros.RucEmpresa & "'") 'aki va el ruc
			If UBound(PFormulas) > 0 Then
				For i = 0 To UBound(PFormulas) - 1
					.set_formulas(2 + i, PFormulas(i))
				Next 
			End If
			.DiscardSavedData = True
			If UBound(Param) > 0 Then
				For i = 0 To UBound(Param) - 1
					.set_StoredProcParam(i, Param(i))
				Next 
			End If
			If ORDEN <> "" Then Call CrystOrden((MDIPrincipal.CryRptProc), ORDEN)
			If .Status <> 2 Then .Action = 1
		End With
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		Exit Sub
x: 
		If Err.Number = 9 Then Resume Next
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox("Error inesperado: " & Err.Number & "  " & Err.Description, MsgBoxStyle.Exclamation)
	End Sub
	Private Sub CrystOrden(ByRef cry As AxCrystal.AxCrystalReport, ByRef cad As String)
		Dim pos, i As Short
		Dim cadaux As String
		Dim valor As String
		i = 0
		Do While True
			pos = InStr(1, cad, ",", CompareMethod.Text)
			'I = 0
			If pos = 0 Then Exit Do
			valor = Left(cad, pos - 1)
			cry.set_SortFields(i, valor)
			i = i + 1
			cad = Right(cad, Len(cad) - pos)
		Loop 
	End Sub
	
	Sub ImpresionRptbase(ByRef cNombreReporte As String, ByRef PFormulas() As Object, ByRef Param() As Object, Optional ByRef ORDEN As String = "", Optional ByRef titulo As String = "")
		Dim i As Short
		On Error GoTo x
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		With MDIPrincipal.CryRptProc
			.Reset()
			.Destination = Crystal.DestinationConstants.crptToWindow
			.WindowState = Crystal.WindowStateConstants.crptMaximized
			.WindowTitle = titulo
			Call PropCrystal((MDIPrincipal.CryRptProc))
			.ReportFileName = VGParamSistem.RutaReport & "\" & cNombreReporte
			If CDbl(VGsql) = 1 Then
				.Connect = "Provider=SQLOLEDB;Password=" & VGParamSistem.PwdGEN & ";Persist Security Info=True;User ID=" & VGParamSistem.UsuarioGEN & ";Initial Catalog=" & VGParamSistem.BDEmpresaGEN & ";SERVER=" & VGParamSistem.ServidorGEN
			Else
				.Connect = VGCadenaReport2
				
			End If
			
			.set_formulas(0, "@Emp='" & VGParametros.NomEmpresa & "'")
			.set_formulas(1, "@Ruc='" & VGParametros.RucEmpresa & "'")
			If UBound(PFormulas) > 0 Then
				For i = 0 To UBound(PFormulas) - 1
					.set_formulas(2 + i, PFormulas(i))
				Next 
			End If
			.DiscardSavedData = True
			If UBound(Param) > 0 Then
				For i = 0 To UBound(Param) - 1
					.set_StoredProcParam(i, Param(i))
				Next 
			End If
			If ORDEN <> "" Then Call CrystOrden((MDIPrincipal.CryRptProc), ORDEN)
			If .Status <> 2 Then .Action = 1
		End With
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		Exit Sub
x: 
		If Err.Number = 9 Then Resume Next
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox("Error inesperado: " & Err.Number & "  " & Err.Description, MsgBoxStyle.Exclamation)
	End Sub
	Public Sub PropCrystal(ByRef CrystalRpt As AxCrystal.AxCrystalReport)
		CrystalRpt.WindowShowCancelBtn = True
		CrystalRpt.WindowShowCloseBtn = True
		CrystalRpt.WindowShowExportBtn = True
		CrystalRpt.WindowShowGroupTree = True
		CrystalRpt.WindowShowNavigationCtls = True
		CrystalRpt.WindowShowPrintBtn = True
		CrystalRpt.WindowShowPrintSetupBtn = True
		CrystalRpt.WindowShowProgressCtls = True
		CrystalRpt.WindowShowSearchBtn = True
		CrystalRpt.WindowShowZoomCtl = True
		CrystalRpt.Destination = Crystal.DestinationConstants.crptToWindow
		CrystalRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
		
		
	End Sub
	
	Sub ImpresionRpt_SubRpt_Proc(ByRef cNombreReporte As String, ByRef PFormulas() As Object, ByRef Param() As Object, ByRef cNombreSubRpt As String, Optional ByRef ORDEN As String = "", Optional ByRef titulo As String = "")
		Dim strBuscar As New dll_apisgen.dll_apis
		Dim i As Short
		On Error GoTo x
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		With MDIPrincipal.CryRptProc
			.Reset()
			.WindowTitle = titulo
			Call PropCrystal((MDIPrincipal.CryRptProc))
			If Right(VGParamSistem.RutaReport, 1) <> "\" Then VGParamSistem.RutaReport = VGParamSistem.RutaReport & "\"
			.ReportFileName = VGParamSistem.RutaReport & cNombreReporte
			
			If CDbl(VGsql) = 1 Then
				.Connect = "Provider=SQLOLEDB;Password=" & VGParamSistem.PwdGEN & ";Persist Security Info=True;User ID=" & VGParamSistem.UsuarioGEN & ";Initial Catalog=" & VGParamSistem.BDEmpresaGEN & ";SERVER=" & VGParamSistem.ServidorGEN
			Else
				.Connect = VGCadenaReport2
				
			End If
			
			.set_formulas(0, "@Empresa='" & VGParametros.NomEmpresa & "'")
			.set_formulas(1, "@Ruc='" & VGParametros.RucEmpresa & "'")
			If UBound(PFormulas) > 0 Then
				For i = 0 To UBound(PFormulas) - 1
					.set_formulas(2 + i, PFormulas(i))
				Next 
			End If
			.DiscardSavedData = True
			If UBound(Param) > 0 Then
				For i = 0 To UBound(Param) - 1
					.set_StoredProcParam(i, Param(i))
				Next 
			End If
			.DiscardSavedData = True
			'***Para el SubReporte
			.SubreportToChange = cNombreSubRpt
			If CDbl(VGsql) = 1 Then
				.Connect = "Provider=SQLOLEDB;Password=" & VGParamSistem.PwdGEN & ";Persist Security Info=True;User ID=" & VGParamSistem.UsuarioGEN & ";Initial Catalog=" & VGParamSistem.BDEmpresaGEN & ";SERVER=" & VGParamSistem.ServidorGEN
			Else
				.Connect = VGCadenaReport2
				
			End If
			
			If UBound(Param) > 0 Then
				For i = 0 To UBound(Param) - 1
					.set_StoredProcParam(i, Param(i))
				Next 
			End If
			If ORDEN <> "" Then Call CrystOrden((MDIPrincipal.CryRptProc), ORDEN)
			If .Status <> 2 Then .Action = 1
		End With
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		Exit Sub
x: 
		If Err.Number = 9 Then Resume Next
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox("Error inesperado: " & Err.Number & "  " & Err.Description, MsgBoxStyle.Exclamation)
	End Sub
	Public Function XRecuperaTipoCambio(ByRef Fecha As Date, ByRef tipo As tipocambio, ByRef cnx As ADODB.Connection) As Double
		Dim RSAUX As ADODB.Recordset
		RSAUX = New ADODB.Recordset
		Dim Campo As String
		XRecuperaTipoCambio = 0
		Select Case tipo
			Case tipocambio.Compra
				Campo = "tipocambiocompra"
			Case tipocambio.Venta
				Campo = "tipocambioventa"
			Case tipocambio.Promedio
				Campo = "tipocambiopromedio"
			Case Else
				Campo = "tipocambioventa"
		End Select
		SQL = "Select Valor=isnull(" & Campo & ",0)  from ct_tipocambio where tipocambiofecha ='" & Fecha & "'"
		RSAUX = VGCNx.Execute(SQL)
		If RSAUX.RecordCount > 0 Then
			XRecuperaTipoCambio = RSAUX.Fields("valor").Value
		End If
	End Function
	Public Function ExisteSQL(ByVal cnx As ADODB.Connection, ByVal SentenciaSQL As String) As Boolean
		On Error GoTo SaliError
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		ExisteSQL = False
		Dim RSAUX As ADODB.Recordset
		RSAUX = New ADODB.Recordset
		RSAUX.Open(SentenciaSQL, cnx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		If RSAUX.RecordCount > 0 Then
			ExisteSQL = True
		End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		Exit Function
SaliError: 
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		ExisteSQL = False
		MsgBox(Err.Description)
		Exit Function
		Resume 
	End Function
	
	Public Sub ADOConectar()
		
		VGdllApi = New dll_apisgen.dll_apis
		VGcomputer = UCase(ComputerName)
		VGsql = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "CONEXION", "SQL", "?")
		VGsql = IIf(VGsql = "?", 0, VGsql)
		
		VGTipoCod = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\Marfice.ini", "conexion", "tipocod", "")
		VGTipoCod = IIf(VGTipoCod = "", "0", VGTipoCod)
		
		VGParametros.empresacodigo = "01"
		
		VGformatofecha = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "CONEXION", "FECHASQL", "?")
		VGformatofecha = IIf(VGformatofecha = "?", "DMY", VGformatofecha)
		
		
		VGParamSistem.BDEmpresaGEN = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "BDGENERAL", "BDDATOS", "?")
		VGParamSistem.ServidorGEN = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "BDGENERAL", "SERVIDOR", "?")
		VGParamSistem.UsuarioGEN = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "BDGENERAL", "USUARIO", "?")
		'   VGParamSistem.PwdGEN = CODIFICASQL("administrador2010*")
		If VGTipoCod = "1" Then
			VGParamSistem.PwdGEN = DECODIFICASQL(VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "BDGENERAL", "PASSW", "?"))
		Else
			VGParamSistem.PwdGEN = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "BDGENERAL", "PASSW", "?")
		End If
		VGParamSistem.BDEmpresa = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "CONEXION", "BDDATOS", "?")
		VGParamSistem.Servidor = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "CONEXION", "SERVIDOR", "?")
		VGParamSistem.Usuario = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "CONEXION", "USUARIO", "?")
		VGParamSistem.UsuarioReporte = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "CONEXION", "USUARIO", "?")
		
		If VGTipoCod = "1" Then
			VGParamSistem.Pwd = DECODIFICASQL(VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "conexion", "PASSW", "?"))
		Else
			VGParamSistem.Pwd = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "conexion", "PASSW", "?")
		End If
		
		VGParamSistem.BDempresaCONF = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "CONEXION", "BDDATOSCONF", "?")
		If VGParamSistem.BDempresaCONF = "?" Then VGParamSistem.BDempresaCONF = "bdwenco"
		
		VGParamSistem.BDEmpresaCT = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "CONTABILIDAD", "BDDATOS", "?")
		VGParamSistem.ServidorCT = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "CONTABILIDAD", "SERVIDOR", "?")
		VGParamSistem.UsuarioCT = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "CONTABILIDAD", "USUARIO", "?")
		
		If VGTipoCod = "1" Then
			VGParamSistem.PwdCT = DECODIFICASQL(VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "CONTABILIDAD", "PASSW", "?"))
		Else
			VGParamSistem.PwdCT = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "CONTABILIDAD", "PASSW", "?")
		End If
		
		If VGParamSistem.BDEmpresa = "?" Or VGParamSistem.Servidor = "?" Then
			MsgBox("No se ha Configurado bien los parametros BDDATOS y SERVIDOR en el archivo " & Chr(13) & My.Application.Info.DirectoryPath & "\MARFICE.INI")
		End If
		
		
		
		'Establecer Cadena de Conexión de Reportes
		VGCadenaReport2 = "DSN=jckconsultores;DSQ=" & VGParamSistem.BDEmpresaGEN & ";UID=" & VGParamSistem.UsuarioGEN & ";PWD=" & VGParamSistem.PwdGEN & ""
		
		On Error GoTo error_Renamed
		VGGeneral = New ADODB.Connection
		VGGeneral.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		VGGeneral.CommandTimeout = 0
		VGGeneral.ConnectionTimeout = 0
		VGGeneral.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=" & VGParamSistem.UsuarioGEN & ";Password=" & VGParamSistem.PwdGEN & ";Initial Catalog=" & VGParamSistem.BDEmpresaGEN & ";Data Source=" & VGParamSistem.ServidorGEN
		VGGeneral.Open()
		
		
		'Conexion de Cofiguracion
		
		VGConfig = New ADODB.Connection
		VGConfig.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		VGConfig.CommandTimeout = 0
		VGConfig.ConnectionTimeout = 0
		VGConfig.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=" & VGParamSistem.Usuario & ";Password=" & VGParamSistem.Pwd & ";Initial Catalog=" & VGParamSistem.BDempresaCONF & ";Data Source=" & VGParamSistem.Servidor
		VGConfig.Open()
		
		'Conexion de inventarios
		
		If VGParamSistem.BDEmpresa = "" Or VGParamSistem.BDEmpresa = "?" Then
			RSQL = VGConfig.Execute("select empresabaseinventarios from empresa where empresaflaginventarios=1")
			VGParamSistem.BDEmpresa = RSQL.Fields("empresabaseinventarios").Value
		End If
		VGCNx = New ADODB.Connection
		VGCNx.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		VGCNx.CommandTimeout = 0
		VGCNx.ConnectionTimeout = 0
		VGCNx.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=" & VGParamSistem.Usuario & ";Password=" & VGParamSistem.Pwd & ";Initial Catalog=" & VGParamSistem.BDEmpresa & ";Data Source=" & VGParamSistem.Servidor
		VGCNx.Open()
		
		'Conexion de Contabilidad
		
		VGCnxCT = New ADODB.Connection
		VGCnxCT.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		VGCnxCT.CommandTimeout = 0
		VGCnxCT.ConnectionTimeout = 0
		VGCnxCT.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=" & VGParamSistem.UsuarioCT & ";Password=" & VGParamSistem.PwdCT & ";Initial Catalog=" & VGParamSistem.BDEmpresaCT & ";Data Source=" & VGParamSistem.ServidorCT
		VGCnxCT.Open()
		
		'Call adicionacamposct
		Exit Sub
		
error_Renamed: 
		
		MsgBox(Err.Description, MsgBoxStyle.Exclamation)
		Exit Sub
		Resume 
	End Sub
	
	Public Function Fecha(ByVal tipo As Short, ByRef dato As Date) As Date
		Dim fecha1 As Date
		fecha1 = CDate(VB6.Format("01/" & VB6.Format(Month(dato), "00") & "/" & Year(dato), "dd/mm/yyyy"))
		Select Case tipo
			Case 1
				Fecha = fecha1
			Case 2
				fecha1 = System.Date.FromOADate(fecha1.ToOADate + 31)
				fecha1 = CDate(VB6.Format("01/" & VB6.Format(Month(fecha1), "00") & "/" & Year(fecha1), "dd/mm/yyyy"))
				Fecha = System.Date.FromOADate(fecha1.ToOADate - 1)
			Case 3
				fecha1 = System.Date.FromOADate(fecha1.ToOADate - 27)
				Fecha = CDate(VB6.Format("01/" & VB6.Format(Month(fecha1), "00") & "/" & Year(fecha1), "dd/mm/yyyy"))
		End Select
	End Function
	
	Public Function ESNULO(ByRef EXPRESION As Object, ByRef valor As Object) As Object
		On Error GoTo errfun
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto EXPRESION. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If IsDbNull(EXPRESION) Or IsNothing(Trim(EXPRESION)) Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto valor. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ESNULO = valor
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto EXPRESION. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ESNULO = EXPRESION
		End If
		Exit Function
errfun: 
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto valor. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ESNULO = valor
	End Function
	Public Function ExisteElem(ByRef Tip As Short, ByRef VGCN As ADODB.Connection, ByRef Tabla As String, Optional ByRef Campo As String = "") As Boolean
		'Funcion que devuelve un valor verdadero si es que encuentra el elemento
		'Creado por Fernando Cossio
		Dim SQL As String
		Dim RSAUX As New ADODB.Recordset
		'*------------------------------*
		'0 Si Existe la tabla
		'1 Si Existe el Campo
		ExisteElem = False
		Tabla = UCase(Tabla) : Campo = UCase(Campo)
		On Error GoTo ErrExiste
		SQL = ""
		Select Case Tip
			Case 0
				SQL = "Select Top 1 * From " & Tabla
			Case 1
				SQL = "Select Top 1 " & Campo & " From " & Tabla
		End Select
		RSAUX = VGCN.Execute(SQL)
		ExisteElem = True
		Exit Function
ErrExiste: 
		ExisteElem = False
	End Function
    Public Function DateSQL(ByVal Fecha As String) As String
        'On Error GoTo ERR
        'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If IsDBNull(Fecha) Then Exit Function
        Select Case VGformatofecha
            Case "DMY"
                DateSQL = "" & VB6.Format(Fecha, "dd/mm/yyyy") & ""
            Case "MDY"
                DateSQL = "" & VB6.Format(Fecha, "mm/dd/yyyy") & ""
        End Select
        'ERR:
        '    DateSQL = "'" & Day(FECHA) & "/" & Month(FECHA) & "/" & Year(FECHA) & "'"
    End Function
	
	Function DesMes(ByRef nMes As String) As String
		Dim DescriMes As String
		
		Select Case nMes
			Case "01"
				DescriMes = "ENERO "
			Case "02"
				DescriMes = "FEBRERO  "
			Case "03"
				DescriMes = "MARZO "
			Case "04"
				DescriMes = "ABRIL "
			Case "05"
				DescriMes = "MAYO "
			Case "06"
				DescriMes = "JUNIO "
			Case "07"
				DescriMes = "JULIO "
			Case "08"
				DescriMes = "AGOSTO "
			Case "09"
				DescriMes = "SETIEMBRE "
			Case "10"
				DescriMes = "OCTUBRE "
			Case "11"
				DescriMes = "NOVIEMBRE "
			Case "12"
				DescriMes = "DICIEMBRE "
		End Select
		
		DesMes = DescriMes
	End Function
	
	'Public Sub Init_ControlDataGrid(EsteGrid As DataGrid)
	' With EsteGrid
	'  .AllowAddNew = False
	'  .AllowDelete = False
	'  .AllowUpdate = False
	'  .AllowRowSizing = False
	'  .TabAction = dbgControlNavigation
	'  .MarqueeStyle = dbgHighlightRow
	' .Font =
	' End With
	'End Sub
	
	Public Function Devolver_Dato(ByRef tipo As Short, ByRef Cod As String, ByRef Tabla As String, ByRef Campo As String, ByRef Fecha As Boolean, ByRef CampDev As String, Optional ByRef Cod2 As String = "", Optional ByRef Campo2 As String = "", Optional ByRef Cod3 As String = "", Optional ByRef Campo3 As String = "", Optional ByRef Cod4 As Double = 0, Optional ByRef Campo4 As String = "") As String
		Dim cSel1 As ADODB.Recordset
		Dim cF As String
		cSel1 = New ADODB.Recordset
		
		If Trim(Campo) <> "" Then
			If Fecha = False Then
				cF = "Select " & CampDev & " from " & Tabla & "  Where " & Campo & " =  '" & Cod & "' "
			Else
				cF = "Select " & CampDev & " from " & Tabla & "  Where " & Campo & " =  #" & VB6.Format(Cod, "mm/dd/yyyy") & "#"
			End If
		End If
		If Trim(Campo2) <> "" Then
			cF = cF & " and " & Campo2 & " = '" & Cod2 & "' "
		End If
		If Trim(Campo3) <> "" Then
			cF = cF & " and " & Campo3 & " = '" & Cod3 & "' "
		End If
		If Trim(Campo4) <> "" Then
			cF = cF & " and " & Campo4 & " = '" & Cod4 & "' "
		End If
		Select Case tipo
			Case 1 'Bd. Comun
				cSel1.Open(cF, VGCNx, ADODB.CursorTypeEnum.adOpenStatic)
			Case 2 'Bd. Config
				cSel1.Open(cF, VGConfig, ADODB.CursorTypeEnum.adOpenStatic)
			Case 3 'Bd. Contabilidad
				cSel1.Open(cF, VGCnxCT, ADODB.CursorTypeEnum.adOpenStatic)
		End Select
		
		If cSel1.RecordCount > 0 Then
			'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			Devolver_Dato = IIf(Not IsDbNull(cSel1.Fields(0).Value), cSel1.Fields(0).Value, "")
		Else
			Devolver_Dato = ""
		End If
	End Function
	
	Public Function NUMLET(ByRef num As String) As String
		Dim cLET As String
		Dim cWork As String
		Dim cUNIDAD As String
		Dim cDECENA As String
		Dim cCENTENA As String
		Dim nMODULUS As Short
		Dim nI As Short
		Dim nK As Short
		Dim Lit1 As String
		Dim Lit2 As String
		Dim Lit3 As String
		Dim Lit4 As String
		Dim Lit5 As String
		Lit1 = "Uno    Dosc   Trec   Cuatroc  Quin   Seisc  Setec  Ochoc  Novec  "
		Lit2 = "Diez     Veinte   Treinta  Cuarenta CincuentaSesenta  Setenta  Ochenta  Noventa  "
		Lit3 = "Once      Doce      Trece     Catorce   Quince    Dieciseis DiecisieteDieciocho Diecinueve"
		Lit4 = "Uno   Dos   Tres  CuatroCinco Seis  Siete Ocho  Nueve "
		Lit5 = "Millon    Billon    Trillon   CuatrillonQuintillon"
		'Proceso Input = Num , Output = Let
		
		cLET = ""
		
		'Dim NUM As Double
		'NUM = Val(NUMx)
		
		If num > CStr(0.99) Then
			'Separa los Enteros en una Cadena de Caracteres
			If InStr(1, Trim(Str(CDbl(num))), ".", 0) > 0 Then
				cWork = Mid(Trim(Str(CDbl(num))), 1, InStr(1, Trim(Str(CDbl(num))), ".", 0) - 1)
			Else
				cWork = Str(CDbl(num))
			End If
			nMODULUS = Int(Len(Trim(cWork)) / 3)
			nMODULUS = Len(Trim(cWork)) - (nMODULUS * 3)
			
			If nMODULUS > 0 Then
				cWork = New String("0", 3 - nMODULUS) & Trim(cWork)
			End If
			
			nK = (Len(Trim(cWork)) / 3) - 1
			'Procesa de Mil en Mil
			nI = 1
			Do While nI < Len(Trim(cWork)) - 1
				cCENTENA = Mid(Trim(cWork), nI, 1)
				cDECENA = Mid(Trim(cWork), nI + 1, 1)
				cUNIDAD = Mid(Trim(cWork), nI + 2, 1)
				'Centenas
				If cCENTENA <> "0" Then
					If cCENTENA = "1" Then
						cLET = cLET & "Cien "
						If cDECENA <> "0" Or cUNIDAD <> "0" Then
							cLET = Mid(cLET, 1, Len(cLET) - 1) & "to "
						End If
					Else
						cLET = cLET & Trim(Mid(Lit1, ((Val(cCENTENA) - 1) * 7) + 1, 7)) & "ientos "
					End If
				End If
				'Decenas
				If cDECENA <> "0" Then
					If cDECENA = "1" And cUNIDAD <> "0" Then
						If ((Val(cUNIDAD) - 1) * 10) + 1 > 0 Then cLET = cLET & Trim(Mid(Lit3, ((Val(cUNIDAD) - 1) * 10) + 1, 10))
					Else
						If ((Val(cDECENA) - 1) * 9) + 1 > 0 Then cLET = cLET & Trim(Mid(Lit2, ((Val(cDECENA) - 1) * 9) + 1, 9))
					End If
				End If
				'Unidades
				If cUNIDAD <> "0" Then
					If cDECENA > "1" Then
						cLET = Mid(cLET, 1, Len(cLET) - 1) & "i"
						If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET & LCase(Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6)))
					Else
						If cDECENA < "1" Then
							If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET & Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6))
						End If
					End If
				End If
				cLET = cLET & " "
				'Pone Miles o Millones
				If nK > 0 Then
					If cCENTENA & cDECENA & cUNIDAD = "001" Then
						cLET = Mid(cLET, 1, Len(cLET) - 2) & " "
					End If
					nMODULUS = Int(nK / 2)
					nMODULUS = nK - (nMODULUS * 2)
					If nMODULUS = 0 Then
						cLET = cLET & Trim(Mid(Lit5, (((nK / 2) - 1) * 10) + 1, 10))
						If cCENTENA & cDECENA & cUNIDAD = "001" Or CDbl(num) > 1999999 Then
							cLET = cLET & "es "
						Else
							cLET = cLET & " "
						End If
					Else
						If cCENTENA & cDECENA & cUNIDAD > "000" Then
							cLET = cLET & "Mil "
						End If
					End If
					nK = nK - 1
				End If
				nI = nI + 3
			Loop 
			cLET = cLET & "con "
		End If
		If InStr(1, Trim(Str(CDbl(num))), ".", 0) > 0 Then
			cLET = cLET & Mid(Trim(Str(CDbl(num))), InStr(1, Trim(Str(CDbl(num))), ".", 0) + 1, 2) & "/100" & " "
		Else
			cLET = cLET & "00/100" & " "
		End If
		NUMLET = cLET
	End Function
	
	Public Function CODIFICA(ByRef cadena As String, ByRef valor As Short) As String
		Dim ciclo, posic As Short
		Dim utl_sal As Short
		Dim cadena_cod, carac, cad As String
		posic = 0 : utl_sal = 0
		carac = "" : cadena_cod = "" : cad = ""
		cadena = UCase(Trim(cadena))
		For ciclo = 1 To Len(cadena)
			carac = Mid(cadena, ciclo, 1)
			If (ciclo Mod 2) = 0 Then
				carac = UCase(carac)
			Else
				carac = LCase(carac)
			End If
			cadena_cod = cadena_cod & carac
		Next ciclo
		
		For ciclo = 1 To Len(cadena_cod)
			posic = ciclo Mod 7
			carac = Mid(cadena_cod, ciclo, 1)
			Select Case posic
				Case 0
					carac = Chr(Asc(carac) * 2)
				Case 1
					carac = Chr(Asc(carac) - valor)
				Case 2
					carac = Chr(Asc(carac) - (ciclo * 2))
					utl_sal = Asc(carac)
				Case 3
					If utl_sal > 10 Then utl_sal = utl_sal - (Int(utl_sal / 10) * 10)
					carac = Chr(Asc(carac) - valor + utl_sal)
				Case 4
					carac = Chr(Asc(carac) - ciclo)
					utl_sal = Asc(carac)
				Case 5
					If utl_sal > 10 Then utl_sal = utl_sal - (Int(utl_sal / 10) * 10)
					carac = Chr(Asc(carac) - valor + utl_sal)
			End Select
			cad = cad & carac
		Next ciclo
		CODIFICA = cad
	End Function
	'función que desencripta una cadena
	Public Function DECODIFICA(ByRef cadena As String, ByRef valor As Short) As String
		Dim val_n, ciclo, posic, val_an As Short
		Dim carac, cad As String
		cadena = Trim(cadena)
		cad = ""
		val_n = 0 : val_an = 0
		For ciclo = 1 To Len(cadena)
			carac = Mid(cadena, ciclo, 1)
			posic = ciclo Mod 7
			Select Case posic
				Case 0
					val_n = Asc(carac) / 2
				Case 1
					val_n = Asc(carac) + valor
				Case 2
					val_n = Asc(carac) + (ciclo * 2)
					val_an = Asc(carac)
				Case 3
					If val_an > 10 Then val_an = val_an - (Int(val_an / 10) * 10)
					val_n = Asc(carac) + valor - val_an
				Case 4
					val_n = Asc(carac) + ciclo
				Case 5
					If val_an > 10 Then val_an = val_an - (Int(val_an / 10) * 10)
					val_n = Asc(carac) + valor - val_an
				Case 6
					val_n = Asc(carac)
			End Select
			cad = cad & Chr(val_n)
		Next ciclo
		DECODIFICA = (cad)
	End Function
	Public Function numero(ByRef Number As Object) As String
		Dim aValor As Double
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Number. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If IsDbNull(Number) Or Len(Trim(Number)) = 0 Then
			aValor = 0
		Else
			If IsNumeric(Number) Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Number. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				aValor = Number
			Else
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Number. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				aValor = Val(Number)
			End If
		End If
		numero = VB6.Format(aValor, "####,###.00")
	End Function
	
    Public Sub MostrarForm(ByRef pVentana As System.Windows.Forms.Form, ByRef pPos As String)

        'pVentana.Icon = LoadPicture(App.Path & "\Cuenta.ico")

        If pPos = "C" Then
            pVentana.Left = VB6.TwipsToPixelsX(((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(pVentana.Width)) / 2) - 350)
            pVentana.Top = VB6.TwipsToPixelsY(((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(pVentana.Height)) / 2) - 350)
        ElseIf pPos = "I" Then
            pVentana.Left = VB6.TwipsToPixelsX(300)
            pVentana.Top = VB6.TwipsToPixelsY(300)
        ElseIf pPos = "M" And pVentana.Visible = False Then
            pVentana.Text = pVentana.Text & "  " & VGParametros.NomEmpresa
            pVentana.Width = VB6.TwipsToPixelsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width)
        ElseIf pPos = "C1" Then
            pVentana.Left = VB6.TwipsToPixelsX(((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(pVentana.Width)) / 2) - 350)
            pVentana.Top = VB6.TwipsToPixelsY(((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(pVentana.Height)) / 2) - 350)
            Exit Sub
        ElseIf pPos = "C2" Then
            pVentana.Left = VB6.TwipsToPixelsX(((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(pVentana.Width)) / 2) - 350)
            pVentana.Top = VB6.TwipsToPixelsY(((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(pVentana.Height)) / 2) - 350)
            Exit Sub
        End If
        '		pVentana.Panel.Panels(1).Width = (VB6.PixelsToTwipsX(pVentana.Width) / 4)
        'If pPos = "M" Then
        '	'UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        '	pVentana.Panel.Panels(1).Width = ((VB6.PixelsToTwipsX(pVentana.Width) - 2600) / 4)
        '	'UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        '	pVentana.Panel.Panels(1).text = "EMPRESA: " & VGParametros.NomEmpresa
        '	'UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        '	pVentana.Panel.Panels(2).Alignment = System.Windows.Forms.ToolStripItemAlignment.Left
        '	'UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        '	pVentana.Panel.Panels(2).Width = (VB6.PixelsToTwipsX(pVentana.Width) / 4)
        'Else
        '	'UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        '	pVentana.Panel.Panels(1).text = "FORMATO : " & Escadena((pVentana.Text))
        '	'UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        '	pVentana.Panel.Panels(2).text = "USUARIO: " & VGUsuario
        '	'UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        '	pVentana.Panel.Panels(2).Alignment = System.Windows.Forms.ToolStripItemAlignment.Left
        '	'UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        '	pVentana.Panel.Panels(2).Width = (VB6.PixelsToTwipsX(pVentana.Width) / 4)
        'End If
        ''UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        'pVentana.Panel.Panels(1).Alignment = System.Windows.Forms.ToolStripItemAlignment.Left
        ''UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        'pVentana.Panel.Panels(3).text = "FECHA :" & VB6.Format(Today, "dd/mm/yyyy")
        ''UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        'pVentana.Panel.Panels(3).Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        ''UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        'pVentana.Panel.Panels(3).Width = (VB6.PixelsToTwipsX(pVentana.Width) / 4)
        ''UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        'pVentana.Panel.Panels(4).text = "HORA :" & VB6.Format(TimeOfDay, "hh:mm:ss")
        ''UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        'pVentana.Panel.Panels(4).Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        ''UPGRADE_ISSUE: Control Panel no se pudo resolver porque está dentro del espacio de nombres genérico Form. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        'pVentana.Panel.Panels(4).Width = (VB6.PixelsToTwipsX(pVentana.Width) / 4)

    End Sub
	
    Public Sub MostrarFormVentas(ByRef pVentana As System.Windows.Forms.Form, ByRef pPos As String)

        'pVentana.Icon = LoadPicture(App.Path & "\Cuenta.ico")

        If pPos = "C" Then
            pVentana.Left = VB6.TwipsToPixelsX(((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(pVentana.Width)) / 2) - 350)
            pVentana.Top = VB6.TwipsToPixelsY(((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(pVentana.Height)) / 2) - 350)
        ElseIf pPos = "I" Then
            pVentana.Left = VB6.TwipsToPixelsX(300)
            pVentana.Top = VB6.TwipsToPixelsY(300)
        ElseIf pPos = "M" And pVentana.Visible = False Then
            pVentana.Text = pVentana.Text & "  " & VGParametros.NomEmpresa
            pVentana.Width = VB6.TwipsToPixelsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width)
        ElseIf pPos = "C1" Then
            pVentana.Left = VB6.TwipsToPixelsX(((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(pVentana.Width)) / 2) - 350)
            pVentana.Top = VB6.TwipsToPixelsY(((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(pVentana.Height)) / 2) - 350)
            Exit Sub
        ElseIf pPos = "C2" Then
            pVentana.Left = VB6.TwipsToPixelsX(((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(pVentana.Width)) / 2) - 350)
            pVentana.Top = VB6.TwipsToPixelsY(((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(pVentana.Height)) / 2) - 350)
            Exit Sub
        End If


    End Sub
	
    Public Sub Seguir(ByRef MBox As Object, ByRef ntecla As Short)
        If ntecla = 13 Then
            System.Windows.Forms.SendKeys.Send("{tab}")
        End If
    End Sub
	
	
	
	
    Public Sub Limpiartexto(ByRef MBox As Object, ByRef ninicio As Short, ByRef nfin As Short, Optional ByRef Noincluir1 As Object = Nothing, Optional ByRef Noincluir2 As Short = 0)
        Dim J As Short
        If IsNothing(Noincluir1) Then
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Noincluir1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Noincluir1 = -1
        End If
        If IsNothing(Noincluir2) Then
            Noincluir2 = -1
        End If

        For J = ninicio To nfin
            If J = Noincluir1 Or J = Noincluir2 Then
            Else
                MBox(J) = Nothing
            End If
        Next J
    End Sub
	Public Function TraeDataSerie(ByRef nsql As String, ByRef vcon As ADODB.Connection) As String
		Dim rsbuscn As New ADODB.Recordset
		
		rsbuscn = vcon.Execute(nsql)
		If rsbuscn.RecordCount > 0 Then
			TraeDataSerie = rsbuscn.Fields("puntovtadoccorr").Value
		Else
			TraeDataSerie = "1"
		End If
		'UPGRADE_NOTE: El objeto rsbuscn no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsbuscn = Nothing
		
	End Function
	
	Public Function VerificaCombo(ByRef xcombo As System.Windows.Forms.ComboBox, ByRef ncadena As String) As Integer
		Dim J As Object
		Dim k As Integer
		On Error GoTo nerror
		VerificaCombo = -1
		If xcombo.Items.Count > 0 Then
			VerificaCombo = 0
			For J = 0 To xcombo.Items.Count - 1
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto J. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xcombo.SelectedIndex = J
				k = InStr(xcombo.Text, "-")
				If k > 1 Then
					If Left(xcombo.Text, k - 1) = ncadena Then
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto J. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						VerificaCombo = J
						Exit For
					End If
				Else
					If xcombo.Text = ncadena Then
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto J. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						VerificaCombo = J
						Exit For
					End If
				End If
			Next J
			
		End If
		
nerror: 
		If Err.Number Then
			MsgBox(Err.Number & "-" & Err.Description)
			Err.Clear()
			Resume Next
		End If
	End Function
	
	Public Sub CargarTipo(ByRef xcombo As System.Windows.Forms.ComboBox, ByRef xtipo As Object)
		Dim adll2 As New dllgeneral.dll_general
		
		Select Case xtipo
			Case 1 '--condicion documento--
				xcombo.Items.Clear()
				xcombo.Items.Add("0-Activo")
				xcombo.Items.Add("1-Anulado")
				xcombo.SelectedIndex = 0
			Case 2 '--tipodocumento --
				xcombo.Items.Clear()
				Call adll2.llenacombo(xcombo, "select documentocodigo,documentodescripcion from vt_documento", VGCNx)
				'     xcombo.AddItem g_tipobol & "-Boleta"
				'     xcombo.AddItem g_tipofac & "-Factura"
				'     xcombo.AddItem g_tipoguia & "-B.O."
				xcombo.SelectedIndex = 0
			Case 3 '---estado
				xcombo.Items.Clear()
				xcombo.Items.Add("S-SI")
				xcombo.Items.Add("N-NO")
				xcombo.SelectedIndex = 0
			Case 4 '-- Tipo persona
				xcombo.Items.Clear()
				xcombo.Items.Add("1-NATURAL")
				xcombo.Items.Add("2-JURIDICA")
				xcombo.SelectedIndex = 0
			Case 5 '-tipo pais
				xcombo.Items.Clear()
				xcombo.Items.Add("1-PERUANA")
				xcombo.Items.Add("2-EXTRANJERA")
				xcombo.SelectedIndex = 0
			Case 6 '--todos los tipos documentos --
				xcombo.Items.Clear()
				Call adll2.llenacombo(xcombo, "select documentocodigo,documentodescripcion from vt_documento ", VGCNx)
				'xcombo.AddItem g_tipobol & "-Boleta"
				'xcombo.AddItem g_tipofac & "-Factura"
				'xcombo.AddItem g_tipoguia & "-B.O."
				'xcombo.AddItem g_tipoped & "-Pedido"
				xcombo.SelectedIndex = 0
				
		End Select
	End Sub
	Public Function Escadena(ByRef pdato As Object) As String
		'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If IsDbNull(pdato) Then
			Escadena = ""
		ElseIf Len(Trim(pdato)) = 0 Then 
			Escadena = ""
		Else
			Escadena = Trim(pdato)
		End If
	End Function
	
	
	Public Function DatoTipoCambio(ByRef xCn As ADODB.Connection, ByRef xfecha As String) As Double
		Dim rs As New ADODB.Recordset
		Dim SQL As String
		SQL = "select tipocambiocompra,tipocambioventa from ct_tipocambio "
		SQL = SQL & "Where tipocambiofecha='" & DateSQL(xfecha) & "'"
		rs = xCn.Execute(SQL)
		If Not (rs.EOF Or rs.BOF) Then
			DatoTipoCambio = CDbl(VB6.Format(rs.Fields(1).Value, "#####0.###0"))
		Else
			DatoTipoCambio = CDbl(VB6.Format(1, "#####0.###0"))
		End If
		rs = Nothing
	End Function
	
	
	Public Sub imprimir(ByRef cNombreReporte As String)
		Dim VGdllApi As New dll_apisgen.dll_apis
		On Error GoTo errores
		
		With MDIPrincipal.CryRptProc
			Call PropCrystal((MDIPrincipal.CryRptProc))
			.ReportFileName = VGParamSistem.RutaReport
			If Right(VGParamSistem.RutaReport, 1) <> "\" Then
				.ReportFileName = VGParamSistem.RutaReport & "\"
			End If
			.ReportFileName = .ReportFileName & VGParamSistem.carpetareportes
			If Right(.ReportFileName, 1) <> "\" Then
				.ReportFileName = .ReportFileName & "\"
			End If
			.ReportFileName = .ReportFileName & cNombreReporte
			.Connect = "Provider=SQLOLEDB;PWD=" & VGParamSistem.Pwd & ";UID=" & VGParamSistem.Usuario & ";DSQ=" & VGParamSistem.BDEmpresa & ";DSN=" & VGParamSistem.Servidor
			.set_formulas(0, "Empresa='" & VGParametros.NomEmpresa & "'")
			.Action = 1
		End With
		Exit Sub
		
errores: 
		MsgBox("Error inesperado: " & Err.Number & "  " & Err.Description, MsgBoxStyle.Exclamation)
		Err.Clear()
		Exit Sub
		
	End Sub
	Public Sub GeneraAsientoEnlineaTesorTransfer(ByRef empresa As String, ByRef Fecha As Date, ByRef Nrecibo As String)
		Dim rsparimpo As ADODB.Recordset
		Dim Comando As ADODB.Command
		On Error GoTo Procesotransf
		rsparimpo = New ADODB.Recordset
		rsparimpo.Open("Select * From  ct_importartesoreria Where Left(Upper(tipooperacion),1) ='T'", VGCnxCT, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		Comando = New ADODB.Command
		With Comando
			.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			.CommandText = "te_GeneraAsientosTesoreriaTransflinea_pro"
			.let_ActiveConnection(VGGeneral)
			.Parameters.Refresh()
			.Parameters("@BaseConta").Value = VGCnxCT.DefaultDatabase
			.Parameters("@BaseVenta").Value = VGCNx.DefaultDatabase
			.Parameters("@empresa").Value = empresa
			.Parameters("@Asiento").Value = rsparimpo.Fields("asiento").Value
			.Parameters("@SubAsiento").Value = rsparimpo.Fields("SubAsiento").Value
			.Parameters("@Libro").Value = rsparimpo.Fields("libro").Value
			
			.Parameters("@Mes").Value = VB6.Format(Month(Fecha), "00")
			.Parameters("@Ano").Value = Year(Fecha)
			.Parameters("@Compu").Value = VGcomputer
			.Parameters("@Usuario").Value = VGParamSistem.Usuario
			.Parameters("@Ntransfer").Value = Nrecibo
			.Parameters("@ajustehaber").Value = VGParametros.sistemactaajustehab
			.Parameters("@ajustedebe").Value = VGParametros.sistemactaajustedeb
			.Execute()
		End With
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox("La Contabilizacion se Realizo Satisfactoriamente", MsgBoxStyle.Information, "Sistema de Tesoreria")
		Exit Sub
Procesotransf: 
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox(Err.Description)
		Exit Sub
		Resume 
	End Sub
	Public Sub GeneraAsientoEnlineaTesor(ByRef Fecha As Date, ByRef empresa As String, ByRef m_opcion As String, ByRef Nrecibo As String, ByRef op As Short, ByRef comprobconta As String, ByRef monedacodigo As String, ByRef cajabanco As String, ByRef m_tipovoucher As String)
		Dim rsparimpo As ADODB.Recordset
		Dim numerror As Short
		Dim Comando As ADODB.Command
		numerror = 0
		On Error GoTo Proceso
		
		VGCNx.BeginTrans()
		
		rsparimpo = New ADODB.Recordset
		
		rsparimpo = VGCnxCT.Execute("Select * From  ct_importartesoreria Where tipooperacion ='X' ")
		If rsparimpo.RecordCount() > 0 Then
			
			Comando = New ADODB.Command
			With Comando
				.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
				.CommandText = "te_GeneraAsientosTesorerialINEA_pro"
				.CommandTimeout = 0
				.let_ActiveConnection(VGGeneral)
				.Parameters.Refresh()
				.Parameters("@BaseConta").Value = VGCnxCT.DefaultDatabase
				.Parameters("@BaseVenta").Value = VGCNx.DefaultDatabase
				.Parameters("@empresa").Value = empresa
				.Parameters("@Asiento").Value = rsparimpo.Fields("asiento").Value
				.Parameters("@SubAsiento").Value = rsparimpo.Fields("SubAsiento").Value
				.Parameters("@Libro").Value = rsparimpo.Fields("libro").Value
				
				.Parameters("@Mes").Value = VB6.Format(Month(Fecha), "00")
				.Parameters("@Ano").Value = Year(Fecha)
				
				.Parameters("@tipanal").Value = "002"
				.Parameters("@Compu").Value = VGcomputer
				.Parameters("@Usuario").Value = VGParamSistem.Usuario
				.Parameters("@TipoMov").Value = Trim(UCase(m_tipovoucher))
				.Parameters("@Nrecibo").Value = Nrecibo
				.Parameters("@op").Value = op
				.Parameters("@comprobconta").Value = comprobconta
				.Parameters("@ajustehaber").Value = VGParametros.sistemactaajustehab
				.Parameters("@ajustedebe").Value = VGParametros.sistemactaajustedeb
				.Execute()
			End With
			If numerror = 0 Then
				VGCNx.CommitTrans()
				'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
				MsgBox("La Contabilizacion se Realizo Satisfactoriamente", MsgBoxStyle.Information, "Sistema de Tesoreria")
			End If
		End If
		Exit Sub
Proceso: 
		numerror = 1
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox(Err.Description)
		VGCNx.RollbackTrans()
		Exit Sub
		Resume 
	End Sub
	
	Public Function DatoMoneda(ByRef xValor As String) As String
		Dim rmone As New ADODB.Recordset
		
		rmone = VGCNx.Execute("select * from gr_moneda where monedacodigo='" & xValor & "'")
		If rmone.RecordCount > 0 Then
			DatoMoneda = Escadena(rmone.Fields("monedasimbolo")) & " ."
		Else
			DatoMoneda = " "
		End If
		rmone.Close()
		
	End Function
	
	Public Sub ADOConectarReport(ByRef report As String)
		
		VGParamSistem.RutaReport = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "REPORTES", "" & report & "", "?")
		VGParamSistem.carpetareportes = VGdllApi.LeerIni(My.Application.Info.DirectoryPath & "\MARFICE.INI", "conexion", "CARPETAREPORTES", "?")
		
	End Sub
	
	Public Function CODIFICASQL(ByRef cadena As String) As String
		Dim ciclo, posic As Short
		Dim utl_sal As Short
		Dim cadena_cod, carac, cad As String
		posic = 0 : utl_sal = 0
		carac = "" : cadena_cod = "" : cad = ""
		cadena = UCase(Trim(cadena))
		For ciclo = 1 To Len(cadena)
			carac = Mid(cadena, ciclo, 1)
			If (ciclo Mod 2) = 0 Then
				carac = UCase(carac)
			Else
				carac = LCase(carac)
			End If
			cadena_cod = cadena_cod & carac
		Next ciclo
		
		For ciclo = 1 To Len(cadena_cod)
			posic = ciclo Mod 2
			carac = Mid(cadena_cod, ciclo, 1)
			Select Case posic
				Case 0
					carac = Chr(Asc(carac) * 2)
				Case 1
					carac = Chr(Asc(carac) - 2)
			End Select
			cad = cad & carac
		Next ciclo
		CODIFICASQL = cad
	End Function
	
	Public Function DECODIFICASQL(ByRef cadena As String) As String
		Dim val_n, ciclo, posic, val_an As Short
		Dim carac, cad As String
		cadena = Trim(cadena)
		cad = ""
		val_n = 0 : val_an = 0
		For ciclo = 1 To Len(cadena)
			carac = Mid(cadena, ciclo, 1)
			posic = ciclo Mod 2
			Select Case posic
				Case 0
					val_n = Asc(carac) / 2
					cad = cad & LCase(Chr(val_n))
				Case 1
					val_n = Asc(carac) + 2
					cad = cad & Chr(val_n)
			End Select
		Next ciclo
		DECODIFICASQL = cad
	End Function
	
	
	Public Function numeroEntero(ByRef Number As Object) As Double
		If IsDbNull(Number) Or Len(Trim(Number)) = 0 Then
			numeroEntero = 0
		Else
			numeroEntero = Number
		End If
	End Function
	
	Public Sub llenagrupoempresa(ByRef rs As ADODB.Recordset, ByRef Campo As String, ByRef usuar As String)
		Dim xusuario As String
		xusuario = ""
		VGcomputer = UCase(ComputerName(1))
		If ExisteElem(0, VGConfig, "si_empresaxusuario") Then
			If ExisteElem(0, VGConfig, VGcomputer) Then
				rs = VGConfig.Execute(" select * from " & VGcomputer & " where tipodesistema=" & MainContab.vgtipo & "")
				If rs.RecordCount > 0 Then
					xusuario = rs.Fields("usuariocodigo").Value
					usuar = xusuario
					SQL = "Select a.* from EMPRESA a inner join si_empresaxusuario b "
					SQL = SQL & " on a.emp_codigo  collate Modern_Spanish_CI_AS =b.empresacodigo  collate Modern_Spanish_CI_AS"
					SQL = SQL & " where " & Campo & "= 1 and b.usuariocodigo='" & xusuario & "'  order by EMP_CODIGO "
				End If
			End If
		End If
		VGcomputer = UCase(ComputerName())
		If SQL = "" Then SQL = "Select * from EMPRESA where " & Campo & "= 1 order by EMP_CODIGO "
		rs = Nothing
		rs = VGConfig.Execute(SQL)
	End Sub
	
	Public Sub multiplesPuntoVta()
		
	End Sub
	Public Function VerificaDatoExistente(ByRef cn1 As ADODB.Connection, ByRef dato1 As String) As Object
		Dim Rsql1 As ADODB.Recordset
		On Error GoTo errverifica
		Rsql1 = cn1.Execute(dato1)
		If Rsql1.RecordCount > 0 Then
			VerificaDatoExistente = Rsql1.RecordCount
		Else
			VerificaDatoExistente = 0
		End If
		Exit Function
errverifica: 
		VerificaDatoExistente = -1
	End Function
	
	Public Sub HabilitarDetalleContab(ByRef flag As Boolean, ByRef framex As System.Windows.Forms.GroupBox, ByRef FORMX As System.Windows.Forms.Form)
		On Error Resume Next
		framex.Enabled = flag
		Dim Control As System.Windows.Forms.Control
		For	Each Control In FORMX.Controls
			If UCase(Control.Parent.Name) = UCase(framex.Name) Then
				Control.Enabled = flag
			End If
		Next Control

	End Sub
	
	Public Sub HabilitarDetalle(ByRef flag As Boolean, ByRef framex As System.Windows.Forms.GroupBox, ByRef FORMX As System.Windows.Forms.Form)
		'FCP
		On Error Resume Next
		framex.Enabled = flag
		Dim Control As System.Windows.Forms.Control
		For	Each Control In FORMX.Controls
			If UCase(Control.Parent.Name) = UCase(framex.Name) Then
				Control.Enabled = flag
			End If
		Next Control
	End Sub
	
	Public Sub ClearControlsInframe(ByRef framex As System.Windows.Forms.GroupBox, ByRef FORMX As System.Windows.Forms.Form)
		'FCP
		On Error Resume Next
		Dim Control As System.Windows.Forms.Control
		For	Each Control In FORMX.Controls
			If UCase(Control.Parent.Name) = UCase(framex.Name) Then
				If UCase(Left(Control.Name, 2)) <> "LE" Then
					If TypeOf Control Is System.Windows.Forms.TextBox Then Control.Text = ""
					If TypeOf Control Is AxTextFer.AxTxFer Then Control.Text = ""
					If TypeOf Control Is System.Windows.Forms.Label Then Control.Text = ""
					'If TypeOf Control Is DTPicker Then Control.Value = Date
				End If
			End If
		Next Control
	End Sub
	
	
	
	Public Function UltNumeroAuto(ByRef Tabla As String, ByRef op As String, ByRef cnx As ADODB.Connection) As Integer
		Dim RSAUX As ADODB.Recordset
		On Error GoTo errornum
		RSAUX = New ADODB.Recordset
		Select Case op
			Case CStr(1)
				'            rsaux.Open "SELECT Numx=isnull(IDENT_CURRENT('" & TABLA & "'),0)", cnx, adOpenKeyset, adLockReadOnly
				RSAUX.Open("SELECT top 1 Numx=isnull(cabprovinumero,1) from co_sistema ", cnx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		End Select
		If RSAUX.EOF Or RSAUX.BOF Then
			UltNumeroAuto = 1
			Exit Function
		Else
			UltNumeroAuto = RSAUX.Fields("Numx").Value
		End If
		Exit Function
errornum: 
		UltNumeroAuto = -1
	End Function
	
	
	Public Function Espunto(ByRef texto As Object) As Object
		If Trim(texto) = "." Or Trim(texto) = "-" Then
			Espunto = "0"
		Else
			Espunto = texto
		End If
	End Function
	Public Sub PlanillaTotales(ByRef xrb As ADODB.Recordset, ByRef xcampo As Object, ByRef xdepo As System.Windows.Forms.Label)
		Dim asumar As Double
		asumar = 0
		If xrb.RecordCount > 0 Then
			xrb.MoveFirst()
			Do Until xrb.EOF
				asumar = asumar + CDbl(xrb.Fields(xcampo).Value)
				xrb.MoveNext()
			Loop 
		End If
		xdepo.Text = numero(asumar)
    End Sub
    Public Sub CambioRs_Dataset(ByVal adorecorset As ADODB.Recordset, ByVal Datagrid As DataGridView)
        Dim i, J, k As Integer
        Dim data As New DataSet
        i = 0
        J = 0
        k = 0
        data.Tables.Add("tbldata")
        If adorecorset.Fields.Count > 0 Then
            For J = 0 To adorecorset.Fields.Count - 1
                data.Tables(0).Columns.Add()
            Next
            If adorecorset.EOF = False Then
                adorecorset.MoveFirst()
                While adorecorset.EOF = False
                    data.Tables("tbldata").Rows.Add()
                    For J = 0 To adorecorset.Fields.Count - 1
                        data.Tables(0).Rows(i).Item(J) = adorecorset.Fields(J).Value
                    Next
                    adorecorset.MoveNext()
                    i = i + 1
                End While
            End If
            Datagrid.DataSource = data
            Datagrid.DataMember = "tbldata"
            For k = 0 To adorecorset.Fields.Count - 1
                Datagrid.Columns(k).HeaderText = adorecorset.Fields(k).Name
            Next
        End If

    End Sub

End Module