<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMntLibro
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
    Public WithEvents lblNumReg As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TDBGridAsientos2 As AxTrueOleDBGrid70.AxTDBGrid
    Public WithEvents cmdBotones3 As System.Windows.Forms.Button
    Public WithEvents cmdBotones4 As System.Windows.Forms.Button
    Public WithEvents cmdBotones2 As System.Windows.Forms.Button
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents frmbotones As System.Windows.Forms.GroupBox
    Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents chk0 As System.Windows.Forms.CheckBox
    Public WithEvents txt0 As AxTextFer.AxTxFer
    Public WithEvents txt1 As AxTextFer.AxTxFer
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents _lbl_1 As System.Windows.Forms.Label
    Public WithEvents _lbl_0 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cAcepta As System.Windows.Forms.Button
    Public WithEvents cCancela As System.Windows.Forms.Button
    Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents _lbl_4 As System.Windows.Forms.Label
    Public WithEvents _lbl_15 As System.Windows.Forms.Label
    Public WithEvents _lbl_14 As System.Windows.Forms.Label
    Public WithEvents _lbl_13 As System.Windows.Forms.Label
    Public WithEvents _lbl_12 As System.Windows.Forms.Label
    Public WithEvents _lbl_11 As System.Windows.Forms.Label
    Public WithEvents _lbl_10 As System.Windows.Forms.Label
    Public WithEvents _lbl_9 As System.Windows.Forms.Label
    Public WithEvents _lbl_8 As System.Windows.Forms.Label
    Public WithEvents _lbl_7 As System.Windows.Forms.Label
    Public WithEvents _lbl_6 As System.Windows.Forms.Label
    Public WithEvents _lbl_5 As System.Windows.Forms.Label
    Public WithEvents txt14 As AxTextFer.AxTxFer
    Public WithEvents txt3 As AxTextFer.AxTxFer
    Public WithEvents txt13 As AxTextFer.AxTxFer
    Public WithEvents txt12 As AxTextFer.AxTxFer
    Public WithEvents txt11 As AxTextFer.AxTxFer
    Public WithEvents txt7 As AxTextFer.AxTxFer
    Public WithEvents txt6 As AxTextFer.AxTxFer
    Public WithEvents txt5 As AxTextFer.AxTxFer
    Public WithEvents txt4 As AxTextFer.AxTxFer
    Public WithEvents txt10 As AxTextFer.AxTxFer
    Public WithEvents txt9 As AxTextFer.AxTxFer
    Public WithEvents txt8 As AxTextFer.AxTxFer
    Public WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents SSTab1 As System.Windows.Forms.TabControl

    Public WithEvents txt As AxTxFerArray
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMntLibro))
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.lblNumReg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TDBGridAsientos2 = New AxTrueOleDBGrid70.AxTDBGrid()
        Me.frmbotones = New System.Windows.Forms.GroupBox()
        Me.cmdBotones3 = New System.Windows.Forms.Button()
        Me.cmdBotones4 = New System.Windows.Forms.Button()
        Me.cmdBotones2 = New System.Windows.Forms.Button()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chk0 = New System.Windows.Forms.CheckBox()
        Me.txt0 = New AxTextFer.AxTxFer()
        Me.txt1 = New AxTextFer.AxTxFer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._lbl_1 = New System.Windows.Forms.Label()
        Me._lbl_0 = New System.Windows.Forms.Label()
        Me.cAcepta = New System.Windows.Forms.Button()
        Me.cCancela = New System.Windows.Forms.Button()
        Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage()
        Me._lbl_4 = New System.Windows.Forms.Label()
        Me._lbl_15 = New System.Windows.Forms.Label()
        Me._lbl_14 = New System.Windows.Forms.Label()
        Me._lbl_13 = New System.Windows.Forms.Label()
        Me._lbl_12 = New System.Windows.Forms.Label()
        Me._lbl_11 = New System.Windows.Forms.Label()
        Me._lbl_10 = New System.Windows.Forms.Label()
        Me._lbl_9 = New System.Windows.Forms.Label()
        Me._lbl_8 = New System.Windows.Forms.Label()
        Me._lbl_7 = New System.Windows.Forms.Label()
        Me._lbl_6 = New System.Windows.Forms.Label()
        Me._lbl_5 = New System.Windows.Forms.Label()
        Me.txt14 = New AxTextFer.AxTxFer()
        Me.txt3 = New AxTextFer.AxTxFer()
        Me.txt13 = New AxTextFer.AxTxFer()
        Me.txt12 = New AxTextFer.AxTxFer()
        Me.txt11 = New AxTextFer.AxTxFer()
        Me.txt7 = New AxTextFer.AxTxFer()
        Me.txt6 = New AxTextFer.AxTxFer()
        Me.txt5 = New AxTextFer.AxTxFer()
        Me.txt4 = New AxTextFer.AxTxFer()
        Me.txt10 = New AxTextFer.AxTxFer()
        Me.txt9 = New AxTextFer.AxTxFer()
        Me.txt8 = New AxTextFer.AxTxFer()
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        CType(Me.TDBGridAsientos2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmbotones.SuspendLayout()
        Me._SSTab1_TabPage1.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.txt0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage2.SuspendLayout()
        CType(Me.txt14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SSTab1
        '
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage2)
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(0, 0)
        Me.SSTab1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 1
        Me.SSTab1.Size = New System.Drawing.Size(603, 469)
        Me.SSTab1.TabIndex = 3
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.lblNumReg)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label1)
        Me._SSTab1_TabPage0.Controls.Add(Me.TDBGridAsientos2)
        Me._SSTab1_TabPage0.Controls.Add(Me.frmbotones)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(595, 443)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Consulta"
        '
        'lblNumReg
        '
        Me.lblNumReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNumReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumReg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNumReg.ForeColor = System.Drawing.Color.Yellow
        Me.lblNumReg.Location = New System.Drawing.Point(505, 353)
        Me.lblNumReg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumReg.Name = "lblNumReg"
        Me.lblNumReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumReg.Size = New System.Drawing.Size(81, 23)
        Me.lblNumReg.TabIndex = 41
        Me.lblNumReg.Text = "lblNumReg"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(421, 354)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nº Registros"
        '
        'TDBGridAsientos2
        '
        Me.TDBGridAsientos2.DataSource = Nothing
        Me.TDBGridAsientos2.Location = New System.Drawing.Point(5, 61)
        Me.TDBGridAsientos2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TDBGridAsientos2.Name = "TDBGridAsientos2"
        Me.TDBGridAsientos2.OcxState = CType(resources.GetObject("TDBGridAsientos2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBGridAsientos2.Size = New System.Drawing.Size(543, 273)
        Me.TDBGridAsientos2.TabIndex = 16
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
        Me.frmbotones.Location = New System.Drawing.Point(43, 396)
        Me.frmbotones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.frmbotones.Name = "frmbotones"
        Me.frmbotones.Padding = New System.Windows.Forms.Padding(0)
        Me.frmbotones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmbotones.Size = New System.Drawing.Size(509, 46)
        Me.frmbotones.TabIndex = 4
        Me.frmbotones.TabStop = False
        '
        'cmdBotones3
        '
        Me.cmdBotones3.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones3.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones3.Location = New System.Drawing.Point(305, 14)
        Me.cmdBotones3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBotones3.Name = "cmdBotones3"
        Me.cmdBotones3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones3.Size = New System.Drawing.Size(96, 27)
        Me.cmdBotones3.TabIndex = 9
        Me.cmdBotones3.Text = "&Imprimir"
        Me.cmdBotones3.UseVisualStyleBackColor = False
        '
        'cmdBotones4
        '
        Me.cmdBotones4.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones4.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones4.Location = New System.Drawing.Point(405, 14)
        Me.cmdBotones4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBotones4.Name = "cmdBotones4"
        Me.cmdBotones4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones4.Size = New System.Drawing.Size(96, 27)
        Me.cmdBotones4.TabIndex = 8
        Me.cmdBotones4.Text = "&Salir"
        Me.cmdBotones4.UseVisualStyleBackColor = False
        '
        'cmdBotones2
        '
        Me.cmdBotones2.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones2.Location = New System.Drawing.Point(205, 14)
        Me.cmdBotones2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBotones2.Name = "cmdBotones2"
        Me.cmdBotones2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones2.Size = New System.Drawing.Size(96, 27)
        Me.cmdBotones2.TabIndex = 7
        Me.cmdBotones2.Text = "&Eliminar"
        Me.cmdBotones2.UseVisualStyleBackColor = False
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(105, 14)
        Me.cmdBotones1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(96, 27)
        Me.cmdBotones1.TabIndex = 6
        Me.cmdBotones1.Text = "E&ditar"
        Me.cmdBotones1.UseVisualStyleBackColor = False
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(5, 14)
        Me.cmdBotones0.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(96, 27)
        Me.cmdBotones0.TabIndex = 5
        Me.cmdBotones0.Text = "&Nuevo"
        Me.cmdBotones0.UseVisualStyleBackColor = False
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.Frame1)
        Me._SSTab1_TabPage1.Controls.Add(Me.cAcepta)
        Me._SSTab1_TabPage1.Controls.Add(Me.cCancela)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(595, 443)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Mantenimiento"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chk0)
        Me.Frame1.Controls.Add(Me.txt0)
        Me.Frame1.Controls.Add(Me.txt1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me._lbl_1)
        Me.Frame1.Controls.Add(Me._lbl_0)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 34)
        Me.Frame1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(584, 257)
        Me.Frame1.TabIndex = 10
        Me.Frame1.TabStop = False
        '
        'chk0
        '
        Me.chk0.BackColor = System.Drawing.SystemColors.Control
        Me.chk0.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk0.Location = New System.Drawing.Point(163, 70)
        Me.chk0.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chk0.Name = "chk0"
        Me.chk0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk0.Size = New System.Drawing.Size(40, 25)
        Me.chk0.TabIndex = 2
        Me.chk0.UseVisualStyleBackColor = False
        '
        'txt0
        '
        Me.txt0.Enabled = True
        Me.txt0.Location = New System.Drawing.Point(121, 13)
        Me.txt0.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt0.Name = "txt0"
        Me.txt0.OcxState = CType(resources.GetObject("txt0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt0.Size = New System.Drawing.Size(149, 25)
        Me.txt0.TabIndex = 0
        '
        'txt1
        '
        Me.txt1.Enabled = True
        Me.txt1.Location = New System.Drawing.Point(121, 34)
        Me.txt1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt1.Name = "txt1"
        Me.txt1.OcxState = CType(resources.GetObject("txt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt1.Size = New System.Drawing.Size(391, 25)
        Me.txt1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(11, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(131, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Flag Control"
        '
        '_lbl_1
        '
        Me._lbl_1.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_1.Location = New System.Drawing.Point(11, 42)
        Me._lbl_1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_1.Name = "_lbl_1"
        Me._lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_1.Size = New System.Drawing.Size(140, 23)
        Me._lbl_1.TabIndex = 12
        Me._lbl_1.Text = "Descripción"
        '
        '_lbl_0
        '
        Me._lbl_0.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_0.Location = New System.Drawing.Point(11, 17)
        Me._lbl_0.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_0.Name = "_lbl_0"
        Me._lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_0.Size = New System.Drawing.Size(205, 23)
        Me._lbl_0.TabIndex = 11
        Me._lbl_0.Text = "Código"
        '
        'cAcepta
        '
        Me.cAcepta.BackColor = System.Drawing.SystemColors.Control
        Me.cAcepta.Cursor = System.Windows.Forms.Cursors.Default
        Me.cAcepta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cAcepta.Location = New System.Drawing.Point(180, 306)
        Me.cAcepta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cAcepta.Name = "cAcepta"
        Me.cAcepta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cAcepta.Size = New System.Drawing.Size(101, 28)
        Me.cAcepta.TabIndex = 14
        Me.cAcepta.Text = "&Aceptar"
        Me.cAcepta.UseVisualStyleBackColor = False
        '
        'cCancela
        '
        Me.cCancela.BackColor = System.Drawing.SystemColors.Control
        Me.cCancela.Cursor = System.Windows.Forms.Cursors.Default
        Me.cCancela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cCancela.Location = New System.Drawing.Point(308, 306)
        Me.cCancela.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cCancela.Name = "cCancela"
        Me.cCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cCancela.Size = New System.Drawing.Size(101, 28)
        Me.cCancela.TabIndex = 15
        Me.cCancela.Text = "&Cancelar"
        Me.cCancela.UseVisualStyleBackColor = False
        '
        '_SSTab1_TabPage2
        '
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_4)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_15)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_14)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_13)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_12)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_11)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_10)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_9)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_8)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_7)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_6)
        Me._SSTab1_TabPage2.Controls.Add(Me._lbl_5)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt14)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt3)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt13)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt12)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt11)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt7)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt6)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt5)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt4)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt10)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt9)
        Me._SSTab1_TabPage2.Controls.Add(Me.txt8)
        Me._SSTab1_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me._SSTab1_TabPage2.Name = "_SSTab1_TabPage2"
        Me._SSTab1_TabPage2.Size = New System.Drawing.Size(595, 443)
        Me._SSTab1_TabPage2.TabIndex = 2
        Me._SSTab1_TabPage2.Text = "Correlativos"
        '
        '_lbl_4
        '
        Me._lbl_4.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_4.Location = New System.Drawing.Point(17, 66)
        Me._lbl_4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_4.Name = "_lbl_4"
        Me._lbl_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_4.Size = New System.Drawing.Size(63, 23)
        Me._lbl_4.TabIndex = 29
        Me._lbl_4.Text = "Enero"
        '
        '_lbl_15
        '
        Me._lbl_15.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_15.Location = New System.Drawing.Point(316, 206)
        Me._lbl_15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_15.Name = "_lbl_15"
        Me._lbl_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_15.Size = New System.Drawing.Size(100, 23)
        Me._lbl_15.TabIndex = 30
        Me._lbl_15.Text = "Diciembre"
        '
        '_lbl_14
        '
        Me._lbl_14.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_14.Location = New System.Drawing.Point(316, 176)
        Me._lbl_14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_14.Name = "_lbl_14"
        Me._lbl_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_14.Size = New System.Drawing.Size(100, 23)
        Me._lbl_14.TabIndex = 31
        Me._lbl_14.Text = "Noviembre"
        '
        '_lbl_13
        '
        Me._lbl_13.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_13.Location = New System.Drawing.Point(316, 146)
        Me._lbl_13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_13.Name = "_lbl_13"
        Me._lbl_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_13.Size = New System.Drawing.Size(100, 23)
        Me._lbl_13.TabIndex = 32
        Me._lbl_13.Text = "Octubre"
        '
        '_lbl_12
        '
        Me._lbl_12.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_12.Location = New System.Drawing.Point(316, 119)
        Me._lbl_12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_12.Name = "_lbl_12"
        Me._lbl_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_12.Size = New System.Drawing.Size(100, 23)
        Me._lbl_12.TabIndex = 33
        Me._lbl_12.Text = "Setiembre"
        '
        '_lbl_11
        '
        Me._lbl_11.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_11.Location = New System.Drawing.Point(316, 89)
        Me._lbl_11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_11.Name = "_lbl_11"
        Me._lbl_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_11.Size = New System.Drawing.Size(100, 23)
        Me._lbl_11.TabIndex = 34
        Me._lbl_11.Text = "Agosto"
        '
        '_lbl_10
        '
        Me._lbl_10.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_10.Location = New System.Drawing.Point(317, 63)
        Me._lbl_10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_10.Name = "_lbl_10"
        Me._lbl_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_10.Size = New System.Drawing.Size(59, 23)
        Me._lbl_10.TabIndex = 35
        Me._lbl_10.Text = "Julio"
        '
        '_lbl_9
        '
        Me._lbl_9.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_9.Location = New System.Drawing.Point(17, 208)
        Me._lbl_9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_9.Name = "_lbl_9"
        Me._lbl_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_9.Size = New System.Drawing.Size(69, 23)
        Me._lbl_9.TabIndex = 36
        Me._lbl_9.Text = "Junio"
        '
        '_lbl_8
        '
        Me._lbl_8.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_8.Location = New System.Drawing.Point(17, 178)
        Me._lbl_8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_8.Name = "_lbl_8"
        Me._lbl_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_8.Size = New System.Drawing.Size(69, 23)
        Me._lbl_8.TabIndex = 37
        Me._lbl_8.Text = "Mayo"
        '
        '_lbl_7
        '
        Me._lbl_7.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_7.Location = New System.Drawing.Point(17, 153)
        Me._lbl_7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_7.Name = "_lbl_7"
        Me._lbl_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_7.Size = New System.Drawing.Size(69, 23)
        Me._lbl_7.TabIndex = 38
        Me._lbl_7.Text = "Abril"
        '
        '_lbl_6
        '
        Me._lbl_6.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_6.Location = New System.Drawing.Point(17, 124)
        Me._lbl_6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_6.Name = "_lbl_6"
        Me._lbl_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_6.Size = New System.Drawing.Size(69, 23)
        Me._lbl_6.TabIndex = 39
        Me._lbl_6.Text = "Marzo"
        '
        '_lbl_5
        '
        Me._lbl_5.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_5.Location = New System.Drawing.Point(17, 96)
        Me._lbl_5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lbl_5.Name = "_lbl_5"
        Me._lbl_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_5.Size = New System.Drawing.Size(69, 23)
        Me._lbl_5.TabIndex = 40
        Me._lbl_5.Text = "Febrero"
        '
        'txt14
        '
        Me.txt14.Enabled = True
        Me.txt14.Location = New System.Drawing.Point(336, 161)
        Me.txt14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt14.Name = "txt14"
        Me.txt14.OcxState = CType(resources.GetObject("txt14.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt14.Size = New System.Drawing.Size(100, 25)
        Me.txt14.TabIndex = 28
        '
        'txt3
        '
        Me.txt3.Enabled = True
        Me.txt3.Location = New System.Drawing.Point(127, 48)
        Me.txt3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt3.Name = "txt3"
        Me.txt3.OcxState = CType(resources.GetObject("txt3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt3.Size = New System.Drawing.Size(96, 25)
        Me.txt3.TabIndex = 17
        '
        'txt13
        '
        Me.txt13.Enabled = True
        Me.txt13.Location = New System.Drawing.Point(336, 139)
        Me.txt13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt13.Name = "txt13"
        Me.txt13.OcxState = CType(resources.GetObject("txt13.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt13.Size = New System.Drawing.Size(99, 25)
        Me.txt13.TabIndex = 27
        '
        'txt12
        '
        Me.txt12.Enabled = True
        Me.txt12.Location = New System.Drawing.Point(336, 116)
        Me.txt12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt12.Name = "txt12"
        Me.txt12.OcxState = CType(resources.GetObject("txt12.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt12.Size = New System.Drawing.Size(99, 25)
        Me.txt12.TabIndex = 26
        '
        'txt11
        '
        Me.txt11.Enabled = True
        Me.txt11.Location = New System.Drawing.Point(336, 93)
        Me.txt11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt11.Name = "txt11"
        Me.txt11.OcxState = CType(resources.GetObject("txt11.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt11.Size = New System.Drawing.Size(99, 25)
        Me.txt11.TabIndex = 25
        '
        'txt7
        '
        Me.txt7.Enabled = True
        Me.txt7.Location = New System.Drawing.Point(127, 141)
        Me.txt7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt7.Name = "txt7"
        Me.txt7.OcxState = CType(resources.GetObject("txt7.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt7.Size = New System.Drawing.Size(96, 25)
        Me.txt7.TabIndex = 21
        '
        'txt6
        '
        Me.txt6.Enabled = True
        Me.txt6.Location = New System.Drawing.Point(127, 118)
        Me.txt6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt6.Name = "txt6"
        Me.txt6.OcxState = CType(resources.GetObject("txt6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt6.Size = New System.Drawing.Size(96, 25)
        Me.txt6.TabIndex = 20
        '
        'txt5
        '
        Me.txt5.Enabled = True
        Me.txt5.Location = New System.Drawing.Point(127, 95)
        Me.txt5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt5.Name = "txt5"
        Me.txt5.OcxState = CType(resources.GetObject("txt5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt5.Size = New System.Drawing.Size(96, 25)
        Me.txt5.TabIndex = 19
        '
        'txt4
        '
        Me.txt4.Enabled = True
        Me.txt4.Location = New System.Drawing.Point(127, 72)
        Me.txt4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt4.Name = "txt4"
        Me.txt4.OcxState = CType(resources.GetObject("txt4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt4.Size = New System.Drawing.Size(96, 25)
        Me.txt4.TabIndex = 18
        '
        'txt10
        '
        Me.txt10.Enabled = True
        Me.txt10.Location = New System.Drawing.Point(336, 70)
        Me.txt10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt10.Name = "txt10"
        Me.txt10.OcxState = CType(resources.GetObject("txt10.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt10.Size = New System.Drawing.Size(99, 25)
        Me.txt10.TabIndex = 24
        '
        'txt9
        '
        Me.txt9.Enabled = True
        Me.txt9.Location = New System.Drawing.Point(336, 49)
        Me.txt9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt9.Name = "txt9"
        Me.txt9.OcxState = CType(resources.GetObject("txt9.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt9.Size = New System.Drawing.Size(99, 25)
        Me.txt9.TabIndex = 23
        '
        'txt8
        '
        Me.txt8.Enabled = True
        Me.txt8.Location = New System.Drawing.Point(127, 164)
        Me.txt8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt8.Name = "txt8"
        Me.txt8.OcxState = CType(resources.GetObject("txt8.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt8.Size = New System.Drawing.Size(96, 25)
        Me.txt8.TabIndex = 22
        '
        'frmMntLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(619, 481)
        Me.Controls.Add(Me.SSTab1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMntLibro"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Libros"
        Me.SSTab1.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        CType(Me.TDBGridAsientos2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmbotones.ResumeLayout(False)
        Me._SSTab1_TabPage1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.txt0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage2.ResumeLayout(False)
        CType(Me.txt14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
End Class