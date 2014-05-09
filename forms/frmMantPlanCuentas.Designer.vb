<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMantPlanCuentas
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
		'Éste es un formulario MDI secundario.
		'Este código simula la funcionalidad de VB6 
		' de cargar automáticamente
		' y mostrar el formulario primario de
		' un MDI secundario.
		Me.MDIParent = Contabilidad.MDIPrincipal
		Contabilidad.MDIPrincipal.Show
	End Sub
	'Form invalida a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
    Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblNumReg As System.Windows.Forms.Label
    Public WithEvents TDBGrid1 As AxTrueOleDBGrid70.AxTDBGrid
    Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents cAcepta As System.Windows.Forms.Button
    Public WithEvents chk5 As System.Windows.Forms.CheckBox
    Public WithEvents cboTipoAjuste As System.Windows.Forms.ComboBox
    Public WithEvents cmdDistribucion As System.Windows.Forms.Button
    Public WithEvents chk4 As System.Windows.Forms.CheckBox
    Public WithEvents chk3 As System.Windows.Forms.CheckBox
    Public WithEvents chk1 As System.Windows.Forms.CheckBox
    Public WithEvents chk0 As System.Windows.Forms.CheckBox
    Public WithEvents chk2 As System.Windows.Forms.CheckBox
    Public WithEvents _lbl_16 As System.Windows.Forms.Label
    Public WithEvents _lbl_15 As System.Windows.Forms.Label
    Public WithEvents _lbl_14 As System.Windows.Forms.Label
    Public WithEvents _lbl_11 As System.Windows.Forms.Label
    Public WithEvents _lbl_10 As System.Windows.Forms.Label
    Public WithEvents lblNivel As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents _lbl_9 As System.Windows.Forms.Label
    Public WithEvents _lbl_8 As System.Windows.Forms.Label
    Public WithEvents _lbl_7 As System.Windows.Forms.Label
    Public WithEvents _lbl_6 As System.Windows.Forms.Label
    Public WithEvents _lbl_5 As System.Windows.Forms.Label
    Public WithEvents _lbl_4 As System.Windows.Forms.Label
    Public WithEvents _lbl_3 As System.Windows.Forms.Label
    Public WithEvents _lbl_2 As System.Windows.Forms.Label
    Public WithEvents _lbl_1 As System.Windows.Forms.Label
    Public WithEvents _lbl_0 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cCancela As System.Windows.Forms.Button
    Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents _lbl_12 As System.Windows.Forms.Label
    Public WithEvents _lbl_13 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents lblPorcen As System.Windows.Forms.Label
    Public WithEvents TDBGrid2 As AxTrueOleDBGrid70.AxTDBGrid
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdSigue As System.Windows.Forms.Button
    Public WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents SSTab1 As System.Windows.Forms.TabControl
    Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripButton
    Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
    Public WithEvents txtBuscar As AxTextFer.AxTxFer
    Public WithEvents cmdBuscar As System.Windows.Forms.Button
    Public WithEvents TreeView1 As System.Windows.Forms.TreeView
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantPlanCuentas))
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumReg = New System.Windows.Forms.Label()
        Me.TDBGrid1 = New AxTrueOleDBGrid70.AxTDBGrid()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.cAcepta = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Text6 = New Ctr_TxtPersonalizado.Ctr_Text()
        Me.Text5 = New Ctr_TxtPersonalizado.Ctr_Text()
        Me.Text4 = New Ctr_TxtPersonalizado.Ctr_Text()
        Me.Text3 = New Ctr_TxtPersonalizado.Ctr_Text()
        Me.Text2 = New Ctr_TxtPersonalizado.Ctr_Text()
        Me.Text1 = New Ctr_TxtPersonalizado.Ctr_Text()
        Me.Text0 = New Ctr_TxtPersonalizado.Ctr_Text()
        Me.Ctr_Ayuda1 = New Ctr_Ayuda.Ctr_Ayuda()
        Me.Ctr_Ayuda4 = New Ctr_Ayuda.Ctr_Ayuda()
        Me.chk5 = New System.Windows.Forms.CheckBox()
        Me.cboTipoAjuste = New System.Windows.Forms.ComboBox()
        Me.cmdDistribucion = New System.Windows.Forms.Button()
        Me.chk4 = New System.Windows.Forms.CheckBox()
        Me.chk3 = New System.Windows.Forms.CheckBox()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.chk0 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me._lbl_16 = New System.Windows.Forms.Label()
        Me._lbl_15 = New System.Windows.Forms.Label()
        Me._lbl_14 = New System.Windows.Forms.Label()
        Me._lbl_11 = New System.Windows.Forms.Label()
        Me._lbl_10 = New System.Windows.Forms.Label()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._lbl_9 = New System.Windows.Forms.Label()
        Me._lbl_8 = New System.Windows.Forms.Label()
        Me._lbl_7 = New System.Windows.Forms.Label()
        Me._lbl_6 = New System.Windows.Forms.Label()
        Me._lbl_5 = New System.Windows.Forms.Label()
        Me._lbl_4 = New System.Windows.Forms.Label()
        Me._lbl_3 = New System.Windows.Forms.Label()
        Me._lbl_2 = New System.Windows.Forms.Label()
        Me._lbl_1 = New System.Windows.Forms.Label()
        Me._lbl_0 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cCancela = New System.Windows.Forms.Button()
        Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtPorcen = New Ctr_TxtPersonalizado.Ctr_Text()
        Me.Ctr_Ayuda3 = New Ctr_Ayuda.Ctr_Ayuda()
        Me.Ctr_Ayuda2 = New Ctr_Ayuda.Ctr_Ayuda()
        Me.Label4 = New System.Windows.Forms.Label()
        Me._lbl_12 = New System.Windows.Forms.Label()
        Me._lbl_13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPorcen = New System.Windows.Forms.Label()
        Me.TDBGrid2 = New AxTrueOleDBGrid70.AxTDBGrid()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdSigue = New System.Windows.Forms.Button()
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button4 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripButton()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtBuscar = New AxTextFer.AxTxFer()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me._SSTab1_TabPage2.SuspendLayout()
        CType(Me.TDBGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Toolbar1.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.txtBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SSTab1
        '
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage2)
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(306, 42)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 1
        Me.SSTab1.Size = New System.Drawing.Size(438, 439)
        Me.SSTab1.TabIndex = 19
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.Label1)
        Me._SSTab1_TabPage0.Controls.Add(Me.lblNumReg)
        Me._SSTab1_TabPage0.Controls.Add(Me.TDBGrid1)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(430, 413)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Consulta"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(310, 416)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Nº Registros"
        '
        'lblNumReg
        '
        Me.lblNumReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNumReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumReg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNumReg.ForeColor = System.Drawing.Color.Yellow
        Me.lblNumReg.Location = New System.Drawing.Point(373, 415)
        Me.lblNumReg.Name = "lblNumReg"
        Me.lblNumReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumReg.Size = New System.Drawing.Size(61, 19)
        Me.lblNumReg.TabIndex = 40
        Me.lblNumReg.Text = "lblNumReg"
        '
        'TDBGrid1
        '
        Me.TDBGrid1.DataSource = Nothing
        Me.TDBGrid1.Location = New System.Drawing.Point(2, 45)
        Me.TDBGrid1.Name = "TDBGrid1"
        Me.TDBGrid1.OcxState = CType(resources.GetObject("TDBGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBGrid1.Size = New System.Drawing.Size(432, 366)
        Me.TDBGrid1.TabIndex = 38
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.cAcepta)
        Me._SSTab1_TabPage1.Controls.Add(Me.Frame2)
        Me._SSTab1_TabPage1.Controls.Add(Me.cCancela)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(430, 413)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Mantenimiento"
        '
        'cAcepta
        '
        Me.cAcepta.BackColor = System.Drawing.SystemColors.Control
        Me.cAcepta.Cursor = System.Windows.Forms.Cursors.Default
        Me.cAcepta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cAcepta.Location = New System.Drawing.Point(134, 382)
        Me.cAcepta.Name = "cAcepta"
        Me.cAcepta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cAcepta.Size = New System.Drawing.Size(75, 24)
        Me.cAcepta.TabIndex = 37
        Me.cAcepta.Text = "&Aceptar"
        Me.cAcepta.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Text6)
        Me.Frame2.Controls.Add(Me.Text5)
        Me.Frame2.Controls.Add(Me.Text4)
        Me.Frame2.Controls.Add(Me.Text3)
        Me.Frame2.Controls.Add(Me.Text2)
        Me.Frame2.Controls.Add(Me.Text1)
        Me.Frame2.Controls.Add(Me.Text0)
        Me.Frame2.Controls.Add(Me.Ctr_Ayuda1)
        Me.Frame2.Controls.Add(Me.Ctr_Ayuda4)
        Me.Frame2.Controls.Add(Me.chk5)
        Me.Frame2.Controls.Add(Me.cboTipoAjuste)
        Me.Frame2.Controls.Add(Me.cmdDistribucion)
        Me.Frame2.Controls.Add(Me.chk4)
        Me.Frame2.Controls.Add(Me.chk3)
        Me.Frame2.Controls.Add(Me.chk1)
        Me.Frame2.Controls.Add(Me.chk0)
        Me.Frame2.Controls.Add(Me.chk2)
        Me.Frame2.Controls.Add(Me._lbl_16)
        Me.Frame2.Controls.Add(Me._lbl_15)
        Me.Frame2.Controls.Add(Me._lbl_14)
        Me.Frame2.Controls.Add(Me._lbl_11)
        Me.Frame2.Controls.Add(Me._lbl_10)
        Me.Frame2.Controls.Add(Me.lblNivel)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me._lbl_9)
        Me.Frame2.Controls.Add(Me._lbl_8)
        Me.Frame2.Controls.Add(Me._lbl_7)
        Me.Frame2.Controls.Add(Me._lbl_6)
        Me.Frame2.Controls.Add(Me._lbl_5)
        Me.Frame2.Controls.Add(Me._lbl_4)
        Me.Frame2.Controls.Add(Me._lbl_3)
        Me.Frame2.Controls.Add(Me._lbl_2)
        Me.Frame2.Controls.Add(Me._lbl_1)
        Me.Frame2.Controls.Add(Me._lbl_0)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(2, 20)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(432, 354)
        Me.Frame2.TabIndex = 21
        Me.Frame2.TabStop = False
        '
        'Text6
        '
        Me.Text6.Alineacion = "0"
        Me.Text6.CadRestriccion = ""
        Me.Text6.ColorbgEnfoque = System.Drawing.Color.Cornsilk
        Me.Text6.ColorFondo = System.Drawing.Color.White
        Me.Text6.ColorTxt = System.Drawing.Color.Black
        Me.Text6.ColorTxtEnfoque = System.Drawing.Color.Brown
        Me.Text6.Enfoque = True
        Me.Text6.FormatoLostfocus = ""
        Me.Text6.Location = New System.Drawing.Point(180, 138)
        Me.Text6.MaxLen = "20"
        Me.Text6.Name = "Text6"
        Me.Text6.NegarRestriccion = False
        Me.Text6.NroDecimales = "2"
        Me.Text6.PermiteNegativo = False
        Me.Text6.PermiteSignoMiles = False
        Me.Text6.SaltoEnter = True
        Me.Text6.Size = New System.Drawing.Size(58, 20)
        Me.Text6.TabIndex = 64
        Me.Text6.TipoDato = "0 - Cadena"
        Me.Text6.ValorTxt = ""
        '
        'Text5
        '
        Me.Text5.Alineacion = "0"
        Me.Text5.CadRestriccion = ""
        Me.Text5.ColorbgEnfoque = System.Drawing.Color.Cornsilk
        Me.Text5.ColorFondo = System.Drawing.Color.White
        Me.Text5.ColorTxt = System.Drawing.Color.Black
        Me.Text5.ColorTxtEnfoque = System.Drawing.Color.Brown
        Me.Text5.Enfoque = True
        Me.Text5.FormatoLostfocus = ""
        Me.Text5.Location = New System.Drawing.Point(180, 118)
        Me.Text5.MaxLen = "20"
        Me.Text5.Name = "Text5"
        Me.Text5.NegarRestriccion = False
        Me.Text5.NroDecimales = "0"
        Me.Text5.PermiteNegativo = False
        Me.Text5.PermiteSignoMiles = False
        Me.Text5.SaltoEnter = True
        Me.Text5.Size = New System.Drawing.Size(240, 20)
        Me.Text5.TabIndex = 63
        Me.Text5.TipoDato = "1 - Numero"
        Me.Text5.ValorTxt = ""
        '
        'Text4
        '
        Me.Text4.Alineacion = "0"
        Me.Text4.CadRestriccion = ""
        Me.Text4.ColorbgEnfoque = System.Drawing.Color.Cornsilk
        Me.Text4.ColorFondo = System.Drawing.Color.White
        Me.Text4.ColorTxt = System.Drawing.Color.Black
        Me.Text4.ColorTxtEnfoque = System.Drawing.Color.Brown
        Me.Text4.Enfoque = True
        Me.Text4.FormatoLostfocus = ""
        Me.Text4.Location = New System.Drawing.Point(180, 98)
        Me.Text4.MaxLen = "20"
        Me.Text4.Name = "Text4"
        Me.Text4.NegarRestriccion = False
        Me.Text4.NroDecimales = "2"
        Me.Text4.PermiteNegativo = False
        Me.Text4.PermiteSignoMiles = False
        Me.Text4.SaltoEnter = True
        Me.Text4.Size = New System.Drawing.Size(58, 20)
        Me.Text4.TabIndex = 62
        Me.Text4.TipoDato = "0 - Cadena"
        Me.Text4.ValorTxt = ""
        '
        'Text3
        '
        Me.Text3.Alineacion = "0"
        Me.Text3.CadRestriccion = ""
        Me.Text3.ColorbgEnfoque = System.Drawing.Color.Cornsilk
        Me.Text3.ColorFondo = System.Drawing.Color.White
        Me.Text3.ColorTxt = System.Drawing.Color.Black
        Me.Text3.ColorTxtEnfoque = System.Drawing.Color.Brown
        Me.Text3.Enfoque = True
        Me.Text3.FormatoLostfocus = ""
        Me.Text3.Location = New System.Drawing.Point(180, 78)
        Me.Text3.MaxLen = "20"
        Me.Text3.Name = "Text3"
        Me.Text3.NegarRestriccion = False
        Me.Text3.NroDecimales = "0"
        Me.Text3.PermiteNegativo = False
        Me.Text3.PermiteSignoMiles = False
        Me.Text3.SaltoEnter = True
        Me.Text3.Size = New System.Drawing.Size(240, 20)
        Me.Text3.TabIndex = 61
        Me.Text3.TipoDato = "1 - Numero"
        Me.Text3.ValorTxt = ""
        '
        'Text2
        '
        Me.Text2.Alineacion = "0"
        Me.Text2.CadRestriccion = ""
        Me.Text2.ColorbgEnfoque = System.Drawing.Color.Cornsilk
        Me.Text2.ColorFondo = System.Drawing.Color.White
        Me.Text2.ColorTxt = System.Drawing.Color.Black
        Me.Text2.ColorTxtEnfoque = System.Drawing.Color.Brown
        Me.Text2.Enfoque = True
        Me.Text2.FormatoLostfocus = ""
        Me.Text2.Location = New System.Drawing.Point(180, 58)
        Me.Text2.MaxLen = "20"
        Me.Text2.Name = "Text2"
        Me.Text2.NegarRestriccion = False
        Me.Text2.NroDecimales = "0"
        Me.Text2.PermiteNegativo = False
        Me.Text2.PermiteSignoMiles = False
        Me.Text2.SaltoEnter = True
        Me.Text2.Size = New System.Drawing.Size(240, 20)
        Me.Text2.TabIndex = 60
        Me.Text2.TipoDato = "1 - Numero"
        Me.Text2.ValorTxt = ""
        '
        'Text1
        '
        Me.Text1.Alineacion = "0"
        Me.Text1.CadRestriccion = ""
        Me.Text1.ColorbgEnfoque = System.Drawing.Color.Cornsilk
        Me.Text1.ColorFondo = System.Drawing.Color.White
        Me.Text1.ColorTxt = System.Drawing.Color.Black
        Me.Text1.ColorTxtEnfoque = System.Drawing.Color.Brown
        Me.Text1.Enfoque = True
        Me.Text1.FormatoLostfocus = ""
        Me.Text1.Location = New System.Drawing.Point(180, 37)
        Me.Text1.MaxLen = "20"
        Me.Text1.Name = "Text1"
        Me.Text1.NegarRestriccion = False
        Me.Text1.NroDecimales = "2"
        Me.Text1.PermiteNegativo = False
        Me.Text1.PermiteSignoMiles = False
        Me.Text1.SaltoEnter = True
        Me.Text1.Size = New System.Drawing.Size(240, 20)
        Me.Text1.TabIndex = 59
        Me.Text1.TipoDato = "0 - Cadena"
        Me.Text1.ValorTxt = ""
        '
        'Text0
        '
        Me.Text0.Alineacion = "0"
        Me.Text0.CadRestriccion = ""
        Me.Text0.ColorbgEnfoque = System.Drawing.Color.Cornsilk
        Me.Text0.ColorFondo = System.Drawing.Color.White
        Me.Text0.ColorTxt = System.Drawing.Color.Black
        Me.Text0.ColorTxtEnfoque = System.Drawing.Color.Brown
        Me.Text0.Enfoque = True
        Me.Text0.FormatoLostfocus = ""
        Me.Text0.Location = New System.Drawing.Point(180, 14)
        Me.Text0.MaxLen = "20"
        Me.Text0.Name = "Text0"
        Me.Text0.NegarRestriccion = False
        Me.Text0.NroDecimales = "0"
        Me.Text0.PermiteNegativo = False
        Me.Text0.PermiteSignoMiles = False
        Me.Text0.SaltoEnter = True
        Me.Text0.Size = New System.Drawing.Size(118, 20)
        Me.Text0.TabIndex = 58
        Me.Text0.TipoDato = "1 - Numero"
        Me.Text0.ValorTxt = ""
        '
        'Ctr_Ayuda1
        '
        Me.Ctr_Ayuda1.CampoDevCod = "tipoanaliticocodigo"
        Me.Ctr_Ayuda1.CampoDevDesc = "tipoanaliticodescripcion"
        Me.Ctr_Ayuda1.Codigo = ""
        Me.Ctr_Ayuda1.Descripcion = ""
        Me.Ctr_Ayuda1.ListaAlias = "Codigo, Descripcion,"
        Me.Ctr_Ayuda1.ListaCampos = "tipoanaliticocodigo ,tipoanaliticodescripcion "
        Me.Ctr_Ayuda1.Location = New System.Drawing.Point(180, 222)
        Me.Ctr_Ayuda1.LongCod = "25"
        Me.Ctr_Ayuda1.LongDesc = "184"
        Me.Ctr_Ayuda1.Name = "Ctr_Ayuda1"
        Me.Ctr_Ayuda1.NombreTabla = "ct_tipoanalitico"
        Me.Ctr_Ayuda1.Requerido = True
        Me.Ctr_Ayuda1.Size = New System.Drawing.Size(244, 20)
        Me.Ctr_Ayuda1.TabIndex = 10
        Me.Ctr_Ayuda1.Titulo = "Tipo Analitico"
        '
        'Ctr_Ayuda4
        '
        Me.Ctr_Ayuda4.CampoDevCod = "tipocuentacodigo"
        Me.Ctr_Ayuda4.CampoDevDesc = "tipocuentadescripcion"
        Me.Ctr_Ayuda4.Codigo = ""
        Me.Ctr_Ayuda4.Descripcion = ""
        Me.Ctr_Ayuda4.ListaAlias = "Codigo, Descripcion,"
        Me.Ctr_Ayuda4.ListaCampos = "tipocuentacodigo ,tipocuentadescripcion"
        Me.Ctr_Ayuda4.Location = New System.Drawing.Point(180, 160)
        Me.Ctr_Ayuda4.LongCod = "25"
        Me.Ctr_Ayuda4.LongDesc = "184"
        Me.Ctr_Ayuda4.Name = "Ctr_Ayuda4"
        Me.Ctr_Ayuda4.NombreTabla = "ct_tipocuenta"
        Me.Ctr_Ayuda4.Requerido = False
        Me.Ctr_Ayuda4.Size = New System.Drawing.Size(241, 22)
        Me.Ctr_Ayuda4.TabIndex = 7
        Me.Ctr_Ayuda4.Titulo = "Tipo Cuenta"
        '
        'chk5
        '
        Me.chk5.BackColor = System.Drawing.SystemColors.Control
        Me.chk5.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk5.Location = New System.Drawing.Point(180, 319)
        Me.chk5.Name = "chk5"
        Me.chk5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk5.Size = New System.Drawing.Size(14, 13)
        Me.chk5.TabIndex = 56
        Me.chk5.UseVisualStyleBackColor = False
        '
        'cboTipoAjuste
        '
        Me.cboTipoAjuste.BackColor = System.Drawing.SystemColors.Window
        Me.cboTipoAjuste.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTipoAjuste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoAjuste.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTipoAjuste.Items.AddRange(New Object() {"00 - Ninguno", "01 - Ajuste Diferencia Cambio", "02 - Ajuste ACM"})
        Me.cboTipoAjuste.Location = New System.Drawing.Point(180, 182)
        Me.cboTipoAjuste.Name = "cboTipoAjuste"
        Me.cboTipoAjuste.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTipoAjuste.Size = New System.Drawing.Size(241, 21)
        Me.cboTipoAjuste.TabIndex = 8
        '
        'cmdDistribucion
        '
        Me.cmdDistribucion.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDistribucion.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDistribucion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDistribucion.Location = New System.Drawing.Point(199, 281)
        Me.cmdDistribucion.Name = "cmdDistribucion"
        Me.cmdDistribucion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDistribucion.Size = New System.Drawing.Size(17, 14)
        Me.cmdDistribucion.TabIndex = 15
        Me.cmdDistribucion.Text = "..."
        Me.cmdDistribucion.UseVisualStyleBackColor = False
        '
        'chk4
        '
        Me.chk4.BackColor = System.Drawing.SystemColors.Control
        Me.chk4.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk4.Location = New System.Drawing.Point(180, 300)
        Me.chk4.Name = "chk4"
        Me.chk4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk4.Size = New System.Drawing.Size(14, 13)
        Me.chk4.TabIndex = 14
        Me.chk4.UseVisualStyleBackColor = False
        '
        'chk3
        '
        Me.chk3.BackColor = System.Drawing.SystemColors.Control
        Me.chk3.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk3.Location = New System.Drawing.Point(180, 281)
        Me.chk3.Name = "chk3"
        Me.chk3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk3.Size = New System.Drawing.Size(13, 13)
        Me.chk3.TabIndex = 13
        Me.chk3.UseVisualStyleBackColor = False
        '
        'chk1
        '
        Me.chk1.BackColor = System.Drawing.SystemColors.Control
        Me.chk1.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk1.Location = New System.Drawing.Point(180, 245)
        Me.chk1.Name = "chk1"
        Me.chk1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk1.Size = New System.Drawing.Size(19, 13)
        Me.chk1.TabIndex = 11
        Me.chk1.UseVisualStyleBackColor = False
        '
        'chk0
        '
        Me.chk0.BackColor = System.Drawing.SystemColors.Control
        Me.chk0.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk0.Location = New System.Drawing.Point(180, 206)
        Me.chk0.Name = "chk0"
        Me.chk0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk0.Size = New System.Drawing.Size(15, 14)
        Me.chk0.TabIndex = 9
        Me.chk0.UseVisualStyleBackColor = False
        '
        'chk2
        '
        Me.chk2.BackColor = System.Drawing.SystemColors.Control
        Me.chk2.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk2.Location = New System.Drawing.Point(180, 263)
        Me.chk2.Name = "chk2"
        Me.chk2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk2.Size = New System.Drawing.Size(16, 13)
        Me.chk2.TabIndex = 12
        Me.chk2.UseVisualStyleBackColor = False
        '
        '_lbl_16
        '
        Me._lbl_16.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_16.Location = New System.Drawing.Point(10, 314)
        Me._lbl_16.Name = "_lbl_16"
        Me._lbl_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_16.Size = New System.Drawing.Size(155, 16)
        Me._lbl_16.TabIndex = 57
        Me._lbl_16.Text = "Adiciona Cargo"
        '
        '_lbl_15
        '
        Me._lbl_15.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_15.Location = New System.Drawing.Point(9, 184)
        Me._lbl_15.Name = "_lbl_15"
        Me._lbl_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_15.Size = New System.Drawing.Size(155, 16)
        Me._lbl_15.TabIndex = 55
        Me._lbl_15.Text = "Tipo de Ajuste"
        '
        '_lbl_14
        '
        Me._lbl_14.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_14.Location = New System.Drawing.Point(9, 162)
        Me._lbl_14.Name = "_lbl_14"
        Me._lbl_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_14.Size = New System.Drawing.Size(155, 16)
        Me._lbl_14.TabIndex = 53
        Me._lbl_14.Text = "Tipo Cuenta"
        '
        '_lbl_11
        '
        Me._lbl_11.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_11.Location = New System.Drawing.Point(10, 298)
        Me._lbl_11.Name = "_lbl_11"
        Me._lbl_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_11.Size = New System.Drawing.Size(155, 16)
        Me._lbl_11.TabIndex = 45
        Me._lbl_11.Text = "Cuenta Activa"
        '
        '_lbl_10
        '
        Me._lbl_10.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_10.Location = New System.Drawing.Point(10, 280)
        Me._lbl_10.Name = "_lbl_10"
        Me._lbl_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_10.Size = New System.Drawing.Size(155, 16)
        Me._lbl_10.TabIndex = 44
        Me._lbl_10.Text = "Asiento Automático"
        '
        'lblNivel
        '
        Me.lblNivel.BackColor = System.Drawing.SystemColors.Control
        Me.lblNivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNivel.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNivel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNivel.Location = New System.Drawing.Point(383, 12)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNivel.Size = New System.Drawing.Size(40, 18)
        Me.lblNivel.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(314, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Nivel Cuenta"
        '
        '_lbl_9
        '
        Me._lbl_9.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_9.Location = New System.Drawing.Point(10, 261)
        Me._lbl_9.Name = "_lbl_9"
        Me._lbl_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_9.Size = New System.Drawing.Size(155, 16)
        Me._lbl_9.TabIndex = 41
        Me._lbl_9.Text = "Controla Documento"
        '
        '_lbl_8
        '
        Me._lbl_8.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_8.Location = New System.Drawing.Point(10, 242)
        Me._lbl_8.Name = "_lbl_8"
        Me._lbl_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_8.Size = New System.Drawing.Size(171, 16)
        Me._lbl_8.TabIndex = 35
        Me._lbl_8.Text = "Controla Centro Costo"
        '
        '_lbl_7
        '
        Me._lbl_7.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_7.Location = New System.Drawing.Point(9, 223)
        Me._lbl_7.Name = "_lbl_7"
        Me._lbl_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_7.Size = New System.Drawing.Size(170, 13)
        Me._lbl_7.TabIndex = 34
        Me._lbl_7.Text = "Tipo Analítico"
        '
        '_lbl_6
        '
        Me._lbl_6.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_6.Location = New System.Drawing.Point(9, 204)
        Me._lbl_6.Name = "_lbl_6"
        Me._lbl_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_6.Size = New System.Drawing.Size(170, 22)
        Me._lbl_6.TabIndex = 33
        Me._lbl_6.Text = "Controla Código Análisis"
        '
        '_lbl_5
        '
        Me._lbl_5.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_5.Location = New System.Drawing.Point(9, 141)
        Me._lbl_5.Name = "_lbl_5"
        Me._lbl_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_5.Size = New System.Drawing.Size(170, 22)
        Me._lbl_5.TabIndex = 32
        Me._lbl_5.Text = "Naturaleza de Estado Gan. y Pérd."
        '
        '_lbl_4
        '
        Me._lbl_4.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_4.Location = New System.Drawing.Point(9, 121)
        Me._lbl_4.Name = "_lbl_4"
        Me._lbl_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_4.Size = New System.Drawing.Size(170, 22)
        Me._lbl_4.TabIndex = 31
        Me._lbl_4.Text = "Línea de Estado de Gan. y Pérd."
        '
        '_lbl_3
        '
        Me._lbl_3.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_3.Location = New System.Drawing.Point(9, 100)
        Me._lbl_3.Name = "_lbl_3"
        Me._lbl_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_3.Size = New System.Drawing.Size(170, 22)
        Me._lbl_3.TabIndex = 30
        Me._lbl_3.Text = "Naturaleza de Balance"
        '
        '_lbl_2
        '
        Me._lbl_2.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_2.Location = New System.Drawing.Point(9, 80)
        Me._lbl_2.Name = "_lbl_2"
        Me._lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_2.Size = New System.Drawing.Size(170, 22)
        Me._lbl_2.TabIndex = 29
        Me._lbl_2.Text = "Línea de Balance de Pasivo"
        '
        '_lbl_1
        '
        Me._lbl_1.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_1.Location = New System.Drawing.Point(9, 60)
        Me._lbl_1.Name = "_lbl_1"
        Me._lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_1.Size = New System.Drawing.Size(170, 22)
        Me._lbl_1.TabIndex = 28
        Me._lbl_1.Text = "Línea de Balance de Activo"
        '
        '_lbl_0
        '
        Me._lbl_0.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_0.Location = New System.Drawing.Point(9, 38)
        Me._lbl_0.Name = "_lbl_0"
        Me._lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_0.Size = New System.Drawing.Size(170, 15)
        Me._lbl_0.TabIndex = 27
        Me._lbl_0.Text = "Descripción Cuenta"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(11, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(170, 21)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Código Cuenta"
        '
        'cCancela
        '
        Me.cCancela.BackColor = System.Drawing.SystemColors.Control
        Me.cCancela.Cursor = System.Windows.Forms.Cursors.Default
        Me.cCancela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cCancela.Location = New System.Drawing.Point(253, 382)
        Me.cCancela.Name = "cCancela"
        Me.cCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cCancela.Size = New System.Drawing.Size(75, 24)
        Me.cCancela.TabIndex = 36
        Me.cCancela.Text = "&Cancelar"
        Me.cCancela.UseVisualStyleBackColor = False
        '
        '_SSTab1_TabPage2
        '
        Me._SSTab1_TabPage2.Controls.Add(Me.txtPorcen)
        Me._SSTab1_TabPage2.Controls.Add(Me.Ctr_Ayuda3)
        Me._SSTab1_TabPage2.Controls.Add(Me.Ctr_Ayuda2)
        Me._SSTab1_TabPage2.Controls.Add(Me.Label4)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_12)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_13)
        Me._SSTab1_TabPage2.Controls.Add(Me.Label5)
        Me._SSTab1_TabPage2.Controls.Add(Me.lblPorcen)
        Me._SSTab1_TabPage2.Controls.Add(Me.TDBGrid2)
        Me._SSTab1_TabPage2.Controls.Add(Me.cmdAceptar)
        Me._SSTab1_TabPage2.Controls.Add(Me.cmdSigue)
        Me._SSTab1_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage2.Name = "_SSTab1_TabPage2"
        Me._SSTab1_TabPage2.Size = New System.Drawing.Size(430, 413)
        Me._SSTab1_TabPage2.TabIndex = 2
        Me._SSTab1_TabPage2.Text = "Cuentas Distribución"
        '
        'txtPorcen
        '
        Me.txtPorcen.Alineacion = "0"
        Me.txtPorcen.CadRestriccion = ""
        Me.txtPorcen.ColorbgEnfoque = System.Drawing.Color.Cornsilk
        Me.txtPorcen.ColorFondo = System.Drawing.Color.White
        Me.txtPorcen.ColorTxt = System.Drawing.Color.Black
        Me.txtPorcen.ColorTxtEnfoque = System.Drawing.Color.Brown
        Me.txtPorcen.Enfoque = True
        Me.txtPorcen.FormatoLostfocus = ""
        Me.txtPorcen.Location = New System.Drawing.Point(195, 174)
        Me.txtPorcen.MaxLen = "20"
        Me.txtPorcen.Name = "txtPorcen"
        Me.txtPorcen.NegarRestriccion = False
        Me.txtPorcen.NroDecimales = "2"
        Me.txtPorcen.PermiteNegativo = False
        Me.txtPorcen.PermiteSignoMiles = False
        Me.txtPorcen.SaltoEnter = True
        Me.txtPorcen.Size = New System.Drawing.Size(84, 20)
        Me.txtPorcen.TabIndex = 60
        Me.txtPorcen.TipoDato = "1 - Numero"
        Me.txtPorcen.ValorTxt = ""
        '
        'Ctr_Ayuda3
        '
        Me.Ctr_Ayuda3.CampoDevCod = "cuentacodigo"
        Me.Ctr_Ayuda3.CampoDevDesc = "cuentadescripcion"
        Me.Ctr_Ayuda3.Codigo = ""
        Me.Ctr_Ayuda3.Descripcion = ""
        Me.Ctr_Ayuda3.ListaAlias = "Codigo,Descripcion,"
        Me.Ctr_Ayuda3.ListaCampos = "cuentacodigo,cuentadescripcion"
        Me.Ctr_Ayuda3.Location = New System.Drawing.Point(12, 129)
        Me.Ctr_Ayuda3.LongCod = "40"
        Me.Ctr_Ayuda3.LongDesc = "180"
        Me.Ctr_Ayuda3.Name = "Ctr_Ayuda3"
        Me.Ctr_Ayuda3.NombreTabla = "ct_cuenta"
        Me.Ctr_Ayuda3.Requerido = True
        Me.Ctr_Ayuda3.Size = New System.Drawing.Size(290, 20)
        Me.Ctr_Ayuda3.TabIndex = 58
        Me.Ctr_Ayuda3.Titulo = "Cuenta de Abono"
        '
        'Ctr_Ayuda2
        '
        Me.Ctr_Ayuda2.CampoDevCod = "cuentacodigo"
        Me.Ctr_Ayuda2.CampoDevDesc = "cuentadescripcion"
        Me.Ctr_Ayuda2.Codigo = ""
        Me.Ctr_Ayuda2.Descripcion = ""
        Me.Ctr_Ayuda2.ListaAlias = "Codigo, Descripcion,"
        Me.Ctr_Ayuda2.ListaCampos = "cuentacodigo ,cuentadescripcion"
        Me.Ctr_Ayuda2.Location = New System.Drawing.Point(12, 80)
        Me.Ctr_Ayuda2.LongCod = "40"
        Me.Ctr_Ayuda2.LongDesc = "100"
        Me.Ctr_Ayuda2.Name = "Ctr_Ayuda2"
        Me.Ctr_Ayuda2.NombreTabla = "ct_cuenta"
        Me.Ctr_Ayuda2.Requerido = False
        Me.Ctr_Ayuda2.Size = New System.Drawing.Size(290, 20)
        Me.Ctr_Ayuda2.TabIndex = 57
        Me.Ctr_Ayuda2.Titulo = "Cuenta de Cargo"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Blue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(193, 20)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Porcentaje de Distribución (%)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lbl_12
        '
        Me._lbl_12.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_12.Location = New System.Drawing.Point(11, 109)
        Me._lbl_12.Name = "_lbl_12"
        Me._lbl_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_12.Size = New System.Drawing.Size(273, 17)
        Me._lbl_12.TabIndex = 48
        Me._lbl_12.Text = "Seleccionar Cuenta al Abono"
        Me._lbl_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lbl_13
        '
        Me._lbl_13.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_13.Location = New System.Drawing.Point(14, 60)
        Me._lbl_13.Name = "_lbl_13"
        Me._lbl_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_13.Size = New System.Drawing.Size(269, 17)
        Me._lbl_13.TabIndex = 49
        Me._lbl_13.Text = "Seleccionar Cuenta al Cargo"
        Me._lbl_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(304, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Total (%)"
        '
        'lblPorcen
        '
        Me.lblPorcen.BackColor = System.Drawing.SystemColors.Control
        Me.lblPorcen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPorcen.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPorcen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPorcen.Location = New System.Drawing.Point(353, 313)
        Me.lblPorcen.Name = "lblPorcen"
        Me.lblPorcen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPorcen.Size = New System.Drawing.Size(81, 20)
        Me.lblPorcen.TabIndex = 51
        Me.lblPorcen.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TDBGrid2
        '
        Me.TDBGrid2.DataSource = Nothing
        Me.TDBGrid2.Location = New System.Drawing.Point(2, 201)
        Me.TDBGrid2.Name = "TDBGrid2"
        Me.TDBGrid2.OcxState = CType(resources.GetObject("TDBGrid2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBGrid2.Size = New System.Drawing.Size(432, 109)
        Me.TDBGrid2.TabIndex = 46
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(285, 174)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(18, 20)
        Me.cmdAceptar.TabIndex = 25
        Me.cmdAceptar.Text = "..."
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'cmdSigue
        '
        Me.cmdSigue.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSigue.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSigue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSigue.Location = New System.Drawing.Point(168, 345)
        Me.cmdSigue.Name = "cmdSigue"
        Me.cmdSigue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSigue.Size = New System.Drawing.Size(75, 24)
        Me.cmdSigue.TabIndex = 52
        Me.cmdSigue.Text = "&Aceptar"
        Me.cmdSigue.UseVisualStyleBackColor = False
        '
        'Toolbar1
        '
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me._Toolbar1_Button2, Me._Toolbar1_Button3, Me._Toolbar1_Button4, Me._Toolbar1_Button5})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(765, 40)
        Me.Toolbar1.TabIndex = 18
        '
        '_Toolbar1_Button1
        '
        Me._Toolbar1_Button1.AutoSize = False
        Me._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button1.Name = "_Toolbar1_Button1"
        Me._Toolbar1_Button1.Size = New System.Drawing.Size(53, 37)
        Me._Toolbar1_Button1.Text = "&Nuevo"
        Me._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Toolbar1_Button1.ToolTipText = "Añadir registro al Plan Cuentas"
        '
        '_Toolbar1_Button2
        '
        Me._Toolbar1_Button2.AutoSize = False
        Me._Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button2.Name = "_Toolbar1_Button2"
        Me._Toolbar1_Button2.Size = New System.Drawing.Size(53, 37)
        Me._Toolbar1_Button2.Text = "E&ditar"
        Me._Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Toolbar1_Button2.ToolTipText = "Modificar Plan de Cuentas"
        '
        '_Toolbar1_Button3
        '
        Me._Toolbar1_Button3.AutoSize = False
        Me._Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button3.Name = "_Toolbar1_Button3"
        Me._Toolbar1_Button3.Size = New System.Drawing.Size(53, 37)
        Me._Toolbar1_Button3.Text = "&Eliminar"
        Me._Toolbar1_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Toolbar1_Button3.ToolTipText = "Eliminar Plan de Cuentas"
        '
        '_Toolbar1_Button4
        '
        Me._Toolbar1_Button4.AutoSize = False
        Me._Toolbar1_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button4.Name = "_Toolbar1_Button4"
        Me._Toolbar1_Button4.Size = New System.Drawing.Size(53, 37)
        Me._Toolbar1_Button4.Text = "&Imprimir"
        Me._Toolbar1_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Toolbar1_Button4.ToolTipText = "Listar Plan de Cuentas"
        '
        '_Toolbar1_Button5
        '
        Me._Toolbar1_Button5.AutoSize = False
        Me._Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button5.Name = "_Toolbar1_Button5"
        Me._Toolbar1_Button5.Size = New System.Drawing.Size(53, 37)
        Me._Toolbar1_Button5.Text = "&Salir"
        Me._Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Toolbar1_Button5.ToolTipText = "Cerrar la Ventana "
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtBuscar)
        Me.Frame1.Controls.Add(Me.cmdBuscar)
        Me.Frame1.Controls.Add(Me.TreeView1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(-1, -7)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(305, 487)
        Me.Frame1.TabIndex = 16
        Me.Frame1.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Enabled = True
        Me.txtBuscar.Location = New System.Drawing.Point(3, 51)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.OcxState = CType(resources.GetObject("txtBuscar.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txtBuscar.Size = New System.Drawing.Size(280, 20)
        Me.txtBuscar.TabIndex = 54
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBuscar.Enabled = False
        Me.cmdBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBuscar.Location = New System.Drawing.Point(284, 52)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBuscar.Size = New System.Drawing.Size(19, 20)
        Me.cmdBuscar.TabIndex = 20
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.HideSelection = False
        Me.TreeView1.Indent = 24
        Me.TreeView1.Location = New System.Drawing.Point(3, 72)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(299, 414)
        Me.TreeView1.TabIndex = 17
        '
        'frmMantPlanCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(765, 502)
        Me.Controls.Add(Me.SSTab1)
        Me.Controls.Add(Me.Toolbar1)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMantPlanCuentas"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Plan de Cuentas"
        Me.SSTab1.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me._SSTab1_TabPage2.ResumeLayout(False)
        CType(Me.TDBGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        CType(Me.txtBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ctr_Ayuda4 As Ctr_Ayuda.Ctr_Ayuda
    Friend WithEvents Ctr_Ayuda1 As Ctr_Ayuda.Ctr_Ayuda
    Friend WithEvents Ctr_Ayuda3 As Ctr_Ayuda.Ctr_Ayuda
    Friend WithEvents Ctr_Ayuda2 As Ctr_Ayuda.Ctr_Ayuda
    Friend WithEvents Text6 As Ctr_TxtPersonalizado.Ctr_Text
    Friend WithEvents Text5 As Ctr_TxtPersonalizado.Ctr_Text
    Friend WithEvents Text4 As Ctr_TxtPersonalizado.Ctr_Text
    Friend WithEvents Text3 As Ctr_TxtPersonalizado.Ctr_Text
    Friend WithEvents Text2 As Ctr_TxtPersonalizado.Ctr_Text
    Friend WithEvents Text1 As Ctr_TxtPersonalizado.Ctr_Text
    Friend WithEvents Text0 As Ctr_TxtPersonalizado.Ctr_Text
    Friend WithEvents txtPorcen As Ctr_TxtPersonalizado.Ctr_Text

#End Region
End Class