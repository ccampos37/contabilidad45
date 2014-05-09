<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMntAsiento
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
        Contabilidad.MDIPrincipal.Show()
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
    Public WithEvents cmdBotones3 As System.Windows.Forms.Button
    Public WithEvents cmdBotones4 As System.Windows.Forms.Button
    Public WithEvents cmdBotones2 As System.Windows.Forms.Button
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents frmbotones As System.Windows.Forms.GroupBox
    Public WithEvents TDBGridAsientos As AxTrueOleDBGrid70.AxTDBGrid
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblNumReg As System.Windows.Forms.Label
    Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents ChkCargo As System.Windows.Forms.CheckBox
    Public WithEvents chk0 As System.Windows.Forms.CheckBox
    Public WithEvents chk1 As System.Windows.Forms.CheckBox
    Public WithEvents Ctr_Ayuda1 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents _lbl_1 As System.Windows.Forms.Label
    Public WithEvents _lbl_0 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cAcepta As System.Windows.Forms.Button
    Public WithEvents cCancela As System.Windows.Forms.Button
    Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents txt8 As AxTextFer.AxTxFer
    Public WithEvents txt9 As AxTextFer.AxTxFer
    Public WithEvents txt10 As AxTextFer.AxTxFer
    Public WithEvents txt4 As AxTextFer.AxTxFer
    Public WithEvents txt5 As AxTextFer.AxTxFer
    Public WithEvents txt6 As AxTextFer.AxTxFer
    Public WithEvents txt7 As AxTextFer.AxTxFer
    Public WithEvents txt11 As AxTextFer.AxTxFer
    Public WithEvents txt12 As AxTextFer.AxTxFer
    Public WithEvents txt13 As AxTextFer.AxTxFer
    Public WithEvents txt3 As AxTextFer.AxTxFer
    Public WithEvents txt14 As AxTextFer.AxTxFer
    Public WithEvents _lbl_5 As System.Windows.Forms.Label
    Public WithEvents _lbl_6 As System.Windows.Forms.Label
    Public WithEvents _lbl_7 As System.Windows.Forms.Label
    Public WithEvents _lbl_8 As System.Windows.Forms.Label
    Public WithEvents _lbl_9 As System.Windows.Forms.Label
    Public WithEvents _lbl_10 As System.Windows.Forms.Label
    Public WithEvents _lbl_11 As System.Windows.Forms.Label
    Public WithEvents _lbl_12 As System.Windows.Forms.Label
    Public WithEvents _lbl_13 As System.Windows.Forms.Label
    Public WithEvents _lbl_14 As System.Windows.Forms.Label
    Public WithEvents _lbl_15 As System.Windows.Forms.Label
    Public WithEvents _lbl_4 As System.Windows.Forms.Label
    Public WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents SSTab1 As System.Windows.Forms.TabControl
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMntAsiento))
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.frmbotones = New System.Windows.Forms.GroupBox()
        Me.cmdBotones3 = New System.Windows.Forms.Button()
        Me.cmdBotones4 = New System.Windows.Forms.Button()
        Me.cmdBotones2 = New System.Windows.Forms.Button()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.TDBGridAsientos = New AxTrueOleDBGrid70.AxTDBGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumReg = New System.Windows.Forms.Label()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txt2 = New Jck_txt.Jck_Txt()
        Me.txt1 = New Jck_txt.Jck_Txt()
        Me.txt0 = New Jck_txt.Jck_Txt()
        Me.ChkCargo = New System.Windows.Forms.CheckBox()
        Me.chk0 = New System.Windows.Forms.CheckBox()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.Ctr_Ayuda1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._lbl_1 = New System.Windows.Forms.Label()
        Me._lbl_0 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cAcepta = New System.Windows.Forms.Button()
        Me.cCancela = New System.Windows.Forms.Button()
        Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt8 = New AxTextFer.AxTxFer()
        Me.txt9 = New AxTextFer.AxTxFer()
        Me.txt10 = New AxTextFer.AxTxFer()
        Me.txt4 = New AxTextFer.AxTxFer()
        Me.txt5 = New AxTextFer.AxTxFer()
        Me.txt6 = New AxTextFer.AxTxFer()
        Me.txt7 = New AxTextFer.AxTxFer()
        Me.txt11 = New AxTextFer.AxTxFer()
        Me.txt12 = New AxTextFer.AxTxFer()
        Me.txt13 = New AxTextFer.AxTxFer()
        Me.txt3 = New AxTextFer.AxTxFer()
        Me.txt14 = New AxTextFer.AxTxFer()
        Me._lbl_5 = New System.Windows.Forms.Label()
        Me._lbl_6 = New System.Windows.Forms.Label()
        Me._lbl_7 = New System.Windows.Forms.Label()
        Me._lbl_8 = New System.Windows.Forms.Label()
        Me._lbl_9 = New System.Windows.Forms.Label()
        Me._lbl_10 = New System.Windows.Forms.Label()
        Me._lbl_11 = New System.Windows.Forms.Label()
        Me._lbl_12 = New System.Windows.Forms.Label()
        Me._lbl_13 = New System.Windows.Forms.Label()
        Me._lbl_14 = New System.Windows.Forms.Label()
        Me._lbl_15 = New System.Windows.Forms.Label()
        Me._lbl_4 = New System.Windows.Forms.Label()
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        Me.frmbotones.SuspendLayout()
        CType(Me.TDBGridAsientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage1.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage2.SuspendLayout()
        CType(Me.txt8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SSTab1
        '
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage2)
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(7, 6)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 1
        Me.SSTab1.Size = New System.Drawing.Size(476, 406)
        Me.SSTab1.TabIndex = 6
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.frmbotones)
        Me._SSTab1_TabPage0.Controls.Add(Me.TDBGridAsientos)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label1)
        Me._SSTab1_TabPage0.Controls.Add(Me.lblNumReg)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(468, 380)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Consulta"
        '
        'frmbotones
        '
        Me.frmbotones.BackColor = System.Drawing.SystemColors.Control
        Me.frmbotones.Controls.Add(Me.cmdBotones3)
        Me.frmbotones.Controls.Add(Me.cmdBotones4)
        Me.frmbotones.Controls.Add(Me.cmdBotones2)
        Me.frmbotones.Controls.Add(Me.cmdBotones1)
        Me.frmbotones.Controls.Add(Me.cmdBotones0)
        Me.frmbotones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmbotones.Location = New System.Drawing.Point(32, 309)
        Me.frmbotones.Name = "frmbotones"
        Me.frmbotones.Padding = New System.Windows.Forms.Padding(0)
        Me.frmbotones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmbotones.Size = New System.Drawing.Size(382, 37)
        Me.frmbotones.TabIndex = 7
        Me.frmbotones.TabStop = False
        '
        'cmdBotones3
        '
        Me.cmdBotones3.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones3.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones3.Location = New System.Drawing.Point(229, 11)
        Me.cmdBotones3.Name = "cmdBotones3"
        Me.cmdBotones3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones3.Size = New System.Drawing.Size(72, 22)
        Me.cmdBotones3.TabIndex = 12
        Me.cmdBotones3.Text = "&Imprimir"
        Me.cmdBotones3.UseVisualStyleBackColor = False
        '
        'cmdBotones4
        '
        Me.cmdBotones4.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones4.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones4.Location = New System.Drawing.Point(304, 11)
        Me.cmdBotones4.Name = "cmdBotones4"
        Me.cmdBotones4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones4.Size = New System.Drawing.Size(72, 22)
        Me.cmdBotones4.TabIndex = 11
        Me.cmdBotones4.Text = "&Salir"
        Me.cmdBotones4.UseVisualStyleBackColor = False
        '
        'cmdBotones2
        '
        Me.cmdBotones2.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones2.Location = New System.Drawing.Point(154, 11)
        Me.cmdBotones2.Name = "cmdBotones2"
        Me.cmdBotones2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones2.Size = New System.Drawing.Size(72, 22)
        Me.cmdBotones2.TabIndex = 10
        Me.cmdBotones2.Text = "&Eliminar"
        Me.cmdBotones2.UseVisualStyleBackColor = False
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(79, 11)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(72, 22)
        Me.cmdBotones1.TabIndex = 9
        Me.cmdBotones1.Text = "E&ditar"
        Me.cmdBotones1.UseVisualStyleBackColor = False
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(4, 11)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(72, 22)
        Me.cmdBotones0.TabIndex = 8
        Me.cmdBotones0.Text = "&Nuevo"
        Me.cmdBotones0.UseVisualStyleBackColor = False
        '
        'TDBGridAsientos
        '
        Me.TDBGridAsientos.DataSource = Nothing
        Me.TDBGridAsientos.Location = New System.Drawing.Point(5, 61)
        Me.TDBGridAsientos.Name = "TDBGridAsientos"
        Me.TDBGridAsientos.OcxState = CType(resources.GetObject("TDBGridAsientos.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBGridAsientos.Size = New System.Drawing.Size(434, 218)
        Me.TDBGridAsientos.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(316, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Nº Registros"
        '
        'lblNumReg
        '
        Me.lblNumReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNumReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumReg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNumReg.ForeColor = System.Drawing.Color.Yellow
        Me.lblNumReg.Location = New System.Drawing.Point(379, 287)
        Me.lblNumReg.Name = "lblNumReg"
        Me.lblNumReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumReg.Size = New System.Drawing.Size(61, 19)
        Me.lblNumReg.TabIndex = 47
        Me.lblNumReg.Text = "lblNumReg"
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.Frame1)
        Me._SSTab1_TabPage1.Controls.Add(Me.cAcepta)
        Me._SSTab1_TabPage1.Controls.Add(Me.cCancela)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(468, 380)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Mantenimiento"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txt2)
        Me.Frame1.Controls.Add(Me.txt1)
        Me.Frame1.Controls.Add(Me.txt0)
        Me.Frame1.Controls.Add(Me.ChkCargo)
        Me.Frame1.Controls.Add(Me.chk0)
        Me.Frame1.Controls.Add(Me.chk1)
        Me.Frame1.Controls.Add(Me.Ctr_Ayuda1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me._lbl_1)
        Me.Frame1.Controls.Add(Me._lbl_0)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(6, 28)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(438, 209)
        Me.Frame1.TabIndex = 13
        Me.Frame1.TabStop = False
        '
        'txt2
        '
        Me.txt2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt2.BackColor = System.Drawing.Color.White
        Me.txt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txt2.decimales = 0
        Me.txt2.formato = "999"
        Me.txt2.Location = New System.Drawing.Point(121, 93)
        Me.txt2.longitud = 50
        Me.txt2.Name = "txt2"
        Me.txt2.negativos = False
        Me.txt2.Requerido = True
        Me.txt2.Size = New System.Drawing.Size(305, 21)
        Me.txt2.TabIndex = 52
        Me.txt2.tipoCaracter = 3
        Me.txt2.tipoletra = 1
        '
        'txt1
        '
        Me.txt1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt1.BackColor = System.Drawing.Color.White
        Me.txt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txt1.decimales = 0
        Me.txt1.formato = "999"
        Me.txt1.Location = New System.Drawing.Point(122, 34)
        Me.txt1.longitud = 30
        Me.txt1.Name = "txt1"
        Me.txt1.negativos = False
        Me.txt1.Requerido = True
        Me.txt1.Size = New System.Drawing.Size(304, 21)
        Me.txt1.TabIndex = 51
        Me.txt1.tipoCaracter = 3
        Me.txt1.tipoletra = 1
        '
        'txt0
        '
        Me.txt0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt0.BackColor = System.Drawing.Color.White
        Me.txt0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txt0.decimales = 0
        Me.txt0.formato = "999"
        Me.txt0.Location = New System.Drawing.Point(122, 7)
        Me.txt0.longitud = 3
        Me.txt0.Name = "txt0"
        Me.txt0.negativos = False
        Me.txt0.Requerido = True
        Me.txt0.Size = New System.Drawing.Size(137, 21)
        Me.txt0.TabIndex = 50
        Me.txt0.tipoCaracter = 1
        Me.txt0.tipoletra = 3
        '
        'ChkCargo
        '
        Me.ChkCargo.BackColor = System.Drawing.SystemColors.Control
        Me.ChkCargo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkCargo.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkCargo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkCargo.Location = New System.Drawing.Point(8, 146)
        Me.ChkCargo.Name = "ChkCargo"
        Me.ChkCargo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkCargo.Size = New System.Drawing.Size(126, 15)
        Me.ChkCargo.TabIndex = 49
        Me.ChkCargo.Text = "Adiciona Cargo"
        Me.ChkCargo.UseVisualStyleBackColor = False
        '
        'chk0
        '
        Me.chk0.BackColor = System.Drawing.SystemColors.Control
        Me.chk0.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk0.Location = New System.Drawing.Point(122, 57)
        Me.chk0.Name = "chk0"
        Me.chk0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk0.Size = New System.Drawing.Size(30, 20)
        Me.chk0.TabIndex = 2
        Me.chk0.UseVisualStyleBackColor = False
        '
        'chk1
        '
        Me.chk1.BackColor = System.Drawing.SystemColors.Control
        Me.chk1.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk1.Location = New System.Drawing.Point(122, 75)
        Me.chk1.Name = "chk1"
        Me.chk1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk1.Size = New System.Drawing.Size(21, 20)
        Me.chk1.TabIndex = 3
        Me.chk1.UseVisualStyleBackColor = False
        '
        'Ctr_Ayuda1
        '
        Me.Ctr_Ayuda1.Enabled = True
        Me.Ctr_Ayuda1.Location = New System.Drawing.Point(121, 120)
        Me.Ctr_Ayuda1.Name = "Ctr_Ayuda1"
        Me.Ctr_Ayuda1.OcxState = CType(resources.GetObject("Ctr_Ayuda1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda1.Size = New System.Drawing.Size(313, 21)
        Me.Ctr_Ayuda1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Op. Grabadas"
        '
        '_lbl_1
        '
        Me._lbl_1.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_1.Location = New System.Drawing.Point(8, 34)
        Me._lbl_1.Name = "_lbl_1"
        Me._lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_1.Size = New System.Drawing.Size(105, 19)
        Me._lbl_1.TabIndex = 18
        Me._lbl_1.Text = "Descripción"
        '
        '_lbl_0
        '
        Me._lbl_0.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_0.Location = New System.Drawing.Point(8, 14)
        Me._lbl_0.Name = "_lbl_0"
        Me._lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_0.Size = New System.Drawing.Size(154, 19)
        Me._lbl_0.TabIndex = 17
        Me._lbl_0.Text = "Código"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(113, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Controla Referencia"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(111, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Referencia"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(9, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Libro"
        '
        'cAcepta
        '
        Me.cAcepta.BackColor = System.Drawing.SystemColors.Control
        Me.cAcepta.Cursor = System.Windows.Forms.Cursors.Default
        Me.cAcepta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cAcepta.Location = New System.Drawing.Point(135, 249)
        Me.cAcepta.Name = "cAcepta"
        Me.cAcepta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cAcepta.Size = New System.Drawing.Size(76, 23)
        Me.cAcepta.TabIndex = 20
        Me.cAcepta.Text = "&Aceptar"
        Me.cAcepta.UseVisualStyleBackColor = False
        '
        'cCancela
        '
        Me.cCancela.BackColor = System.Drawing.SystemColors.Control
        Me.cCancela.Cursor = System.Windows.Forms.Cursors.Default
        Me.cCancela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cCancela.Location = New System.Drawing.Point(231, 249)
        Me.cCancela.Name = "cCancela"
        Me.cCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cCancela.Size = New System.Drawing.Size(76, 23)
        Me.cCancela.TabIndex = 21
        Me.cCancela.Text = "&Cancelar"
        Me.cCancela.UseVisualStyleBackColor = False
        '
        '_SSTab1_TabPage2
        '
        Me._SSTab1_TabPage2.Controls.Add(Me.txt8)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt9)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt10)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt4)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt5)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt6)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt7)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt11)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt12)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt13)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt3)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt14)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_5)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_6)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_7)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_8)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_9)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_10)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_11)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_12)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_13)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_14)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_15)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_4)
        Me._SSTab1_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage2.Name = "_SSTab1_TabPage2"
        Me._SSTab1_TabPage2.Size = New System.Drawing.Size(468, 380)
        Me._SSTab1_TabPage2.TabIndex = 2
        Me._SSTab1_TabPage2.Text = "Correlativos"
        '
        'txt8
        '
        Me.txt8.Enabled = True
        Me.txt8.Location = New System.Drawing.Point(127, 164)
        Me.txt8.Name = "txt8"
        Me.txt8.OcxState = CType(resources.GetObject("txt8.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt8.Size = New System.Drawing.Size(77, 20)
        Me.txt8.TabIndex = 28
        '
        'txt9
        '
        Me.txt9.Enabled = True
        Me.txt9.Location = New System.Drawing.Point(336, 49)
        Me.txt9.Name = "txt9"
        Me.txt9.OcxState = CType(resources.GetObject("txt9.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt9.Size = New System.Drawing.Size(79, 20)
        Me.txt9.TabIndex = 29
        '
        'txt10
        '
        Me.txt10.Enabled = True
        Me.txt10.Location = New System.Drawing.Point(336, 70)
        Me.txt10.Name = "txt10"
        Me.txt10.OcxState = CType(resources.GetObject("txt10.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt10.Size = New System.Drawing.Size(79, 20)
        Me.txt10.TabIndex = 30
        '
        'txt4
        '
        Me.txt4.Enabled = True
        Me.txt4.Location = New System.Drawing.Point(127, 72)
        Me.txt4.Name = "txt4"
        Me.txt4.OcxState = CType(resources.GetObject("txt4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt4.Size = New System.Drawing.Size(77, 20)
        Me.txt4.TabIndex = 24
        '
        'txt5
        '
        Me.txt5.Enabled = True
        Me.txt5.Location = New System.Drawing.Point(127, 95)
        Me.txt5.Name = "txt5"
        Me.txt5.OcxState = CType(resources.GetObject("txt5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt5.Size = New System.Drawing.Size(77, 20)
        Me.txt5.TabIndex = 25
        '
        'txt6
        '
        Me.txt6.Enabled = True
        Me.txt6.Location = New System.Drawing.Point(127, 118)
        Me.txt6.Name = "txt6"
        Me.txt6.OcxState = CType(resources.GetObject("txt6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt6.Size = New System.Drawing.Size(77, 20)
        Me.txt6.TabIndex = 26
        '
        'txt7
        '
        Me.txt7.Enabled = True
        Me.txt7.Location = New System.Drawing.Point(127, 141)
        Me.txt7.Name = "txt7"
        Me.txt7.OcxState = CType(resources.GetObject("txt7.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt7.Size = New System.Drawing.Size(77, 20)
        Me.txt7.TabIndex = 27
        '
        'txt11
        '
        Me.txt11.Enabled = True
        Me.txt11.Location = New System.Drawing.Point(336, 93)
        Me.txt11.Name = "txt11"
        Me.txt11.OcxState = CType(resources.GetObject("txt11.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt11.Size = New System.Drawing.Size(79, 20)
        Me.txt11.TabIndex = 31
        '
        'txt12
        '
        Me.txt12.Enabled = True
        Me.txt12.Location = New System.Drawing.Point(336, 116)
        Me.txt12.Name = "txt12"
        Me.txt12.OcxState = CType(resources.GetObject("txt12.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt12.Size = New System.Drawing.Size(79, 20)
        Me.txt12.TabIndex = 32
        '
        'txt13
        '
        Me.txt13.Enabled = True
        Me.txt13.Location = New System.Drawing.Point(336, 139)
        Me.txt13.Name = "txt13"
        Me.txt13.OcxState = CType(resources.GetObject("txt13.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt13.Size = New System.Drawing.Size(79, 20)
        Me.txt13.TabIndex = 33
        '
        'txt3
        '
        Me.txt3.Enabled = True
        Me.txt3.Location = New System.Drawing.Point(127, 48)
        Me.txt3.Name = "txt3"
        Me.txt3.OcxState = CType(resources.GetObject("txt3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt3.Size = New System.Drawing.Size(77, 20)
        Me.txt3.TabIndex = 23
        '
        'txt14
        '
        Me.txt14.Enabled = True
        Me.txt14.Location = New System.Drawing.Point(336, 161)
        Me.txt14.Name = "txt14"
        Me.txt14.OcxState = CType(resources.GetObject("txt14.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt14.Size = New System.Drawing.Size(80, 20)
        Me.txt14.TabIndex = 34
        '
        '_lbl_5
        '
        Me._lbl_5.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_5.Location = New System.Drawing.Point(13, 78)
        Me._lbl_5.Name = "_lbl_5"
        Me._lbl_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_5.Size = New System.Drawing.Size(52, 19)
        Me._lbl_5.TabIndex = 46
        Me._lbl_5.Text = "Febrero"
        '
        '_lbl_6
        '
        Me._lbl_6.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_6.Location = New System.Drawing.Point(13, 101)
        Me._lbl_6.Name = "_lbl_6"
        Me._lbl_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_6.Size = New System.Drawing.Size(52, 19)
        Me._lbl_6.TabIndex = 45
        Me._lbl_6.Text = "Marzo"
        '
        '_lbl_7
        '
        Me._lbl_7.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_7.Location = New System.Drawing.Point(13, 124)
        Me._lbl_7.Name = "_lbl_7"
        Me._lbl_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_7.Size = New System.Drawing.Size(52, 19)
        Me._lbl_7.TabIndex = 44
        Me._lbl_7.Text = "Abril"
        '
        '_lbl_8
        '
        Me._lbl_8.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_8.Location = New System.Drawing.Point(13, 145)
        Me._lbl_8.Name = "_lbl_8"
        Me._lbl_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_8.Size = New System.Drawing.Size(52, 19)
        Me._lbl_8.TabIndex = 43
        Me._lbl_8.Text = "Mayo"
        '
        '_lbl_9
        '
        Me._lbl_9.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_9.Location = New System.Drawing.Point(13, 169)
        Me._lbl_9.Name = "_lbl_9"
        Me._lbl_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_9.Size = New System.Drawing.Size(52, 19)
        Me._lbl_9.TabIndex = 42
        Me._lbl_9.Text = "Junio"
        '
        '_lbl_10
        '
        Me._lbl_10.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_10.Location = New System.Drawing.Point(238, 51)
        Me._lbl_10.Name = "_lbl_10"
        Me._lbl_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_10.Size = New System.Drawing.Size(44, 19)
        Me._lbl_10.TabIndex = 41
        Me._lbl_10.Text = "Julio"
        '
        '_lbl_11
        '
        Me._lbl_11.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_11.Location = New System.Drawing.Point(237, 72)
        Me._lbl_11.Name = "_lbl_11"
        Me._lbl_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_11.Size = New System.Drawing.Size(75, 19)
        Me._lbl_11.TabIndex = 40
        Me._lbl_11.Text = "Agosto"
        '
        '_lbl_12
        '
        Me._lbl_12.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_12.Location = New System.Drawing.Point(237, 97)
        Me._lbl_12.Name = "_lbl_12"
        Me._lbl_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_12.Size = New System.Drawing.Size(75, 19)
        Me._lbl_12.TabIndex = 39
        Me._lbl_12.Text = "Setiembre"
        '
        '_lbl_13
        '
        Me._lbl_13.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_13.Location = New System.Drawing.Point(237, 119)
        Me._lbl_13.Name = "_lbl_13"
        Me._lbl_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_13.Size = New System.Drawing.Size(75, 19)
        Me._lbl_13.TabIndex = 38
        Me._lbl_13.Text = "Octubre"
        '
        '_lbl_14
        '
        Me._lbl_14.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_14.Location = New System.Drawing.Point(237, 143)
        Me._lbl_14.Name = "_lbl_14"
        Me._lbl_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_14.Size = New System.Drawing.Size(75, 19)
        Me._lbl_14.TabIndex = 37
        Me._lbl_14.Text = "Noviembre"
        '
        '_lbl_15
        '
        Me._lbl_15.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_15.Location = New System.Drawing.Point(237, 167)
        Me._lbl_15.Name = "_lbl_15"
        Me._lbl_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_15.Size = New System.Drawing.Size(75, 19)
        Me._lbl_15.TabIndex = 36
        Me._lbl_15.Text = "Diciembre"
        '
        '_lbl_4
        '
        Me._lbl_4.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_4.Location = New System.Drawing.Point(13, 54)
        Me._lbl_4.Name = "_lbl_4"
        Me._lbl_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_4.Size = New System.Drawing.Size(47, 19)
        Me._lbl_4.TabIndex = 35
        Me._lbl_4.Text = "Enero"
        '
        'frmMntAsiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(486, 416)
        Me.Controls.Add(Me.SSTab1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmMntAsiento"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asientos"
        Me.SSTab1.ResumeLayout(false)
        Me._SSTab1_TabPage0.ResumeLayout(false)
        Me.frmbotones.ResumeLayout(false)
        CType(Me.TDBGridAsientos,System.ComponentModel.ISupportInitialize).EndInit
        Me._SSTab1_TabPage1.ResumeLayout(false)
        Me.Frame1.ResumeLayout(false)
        CType(Me.Ctr_Ayuda1,System.ComponentModel.ISupportInitialize).EndInit
        Me._SSTab1_TabPage2.ResumeLayout(false)
        CType(Me.txt8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt10,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt11,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt12,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt13,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt14,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents txt0 As Jck_txt.Jck_Txt
    Friend WithEvents txt2 As Jck_txt.Jck_Txt
    Friend WithEvents txt1 As Jck_txt.Jck_Txt
#End Region
End Class