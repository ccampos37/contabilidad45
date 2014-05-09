<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMntSaldosInicialPlan
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
    Public WithEvents txtBuscar As AxTextFer.AxTxFer
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents txt0 As AxTextFer.AxTxFer
    Public WithEvents txt1 As AxTextFer.AxTxFer
    Public WithEvents txt2 As AxTextFer.AxTxFer
    Public WithEvents txt3 As AxTextFer.AxTxFer
    Public WithEvents lbl2 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents _lbl_1 As System.Windows.Forms.Label
    Public WithEvents _lbl_0 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents TDBGrid1 As AxTrueOleDBGrid70.AxTDBGrid
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txt As AxTxFerArray
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMntSaldosInicialPlan))
        Me.txtBuscar = New AxTextFer.AxTxFer()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txt0 = New AxTextFer.AxTxFer()
        Me.txt1 = New AxTextFer.AxTxFer()
        Me.txt2 = New AxTextFer.AxTxFer()
        Me.txt3 = New AxTextFer.AxTxFer()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._lbl_1 = New System.Windows.Forms.Label()
        Me._lbl_0 = New System.Windows.Forms.Label()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.TDBGrid1 = New AxTrueOleDBGrid70.AxTDBGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.txtBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.txt0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Enabled = True
        Me.txtBuscar.Location = New System.Drawing.Point(0, 28)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.OcxState = CType(resources.GetObject("txtBuscar.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txtBuscar.Size = New System.Drawing.Size(369, 20)
        Me.txtBuscar.TabIndex = 12
        Me.txtBuscar.UseWaitCursor = True
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(238, 373)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(121, 51)
        Me.cmdBotones1.TabIndex = 7
        Me.cmdBotones1.Text = "&Cancelar"
        Me.cmdBotones1.UseVisualStyleBackColor = False
        Me.cmdBotones1.UseWaitCursor = True
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txt0)
        Me.Frame1.Controls.Add(Me.txt1)
        Me.Frame1.Controls.Add(Me.txt2)
        Me.Frame1.Controls.Add(Me.txt3)
        Me.Frame1.Controls.Add(Me.lbl2)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me._lbl_1)
        Me.Frame1.Controls.Add(Me._lbl_0)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(1, 228)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(368, 139)
        Me.Frame1.TabIndex = 6
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Editar Saldo Iniciales"
        Me.Frame1.UseWaitCursor = True
        '
        'txt0
        '
        Me.txt0.Enabled = True
        Me.txt0.Location = New System.Drawing.Point(144, 32)
        Me.txt0.Name = "txt0"
        Me.txt0.OcxState = CType(resources.GetObject("txt0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt0.Size = New System.Drawing.Size(221, 27)
        Me.txt0.TabIndex = 1
        Me.txt0.UseWaitCursor = True
        '
        'txt1
        '
        Me.txt1.Enabled = True
        Me.txt1.Location = New System.Drawing.Point(142, 59)
        Me.txt1.Name = "txt1"
        Me.txt1.OcxState = CType(resources.GetObject("txt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt1.Size = New System.Drawing.Size(222, 27)
        Me.txt1.TabIndex = 2
        Me.txt1.UseWaitCursor = True
        '
        'txt2
        '
        Me.txt2.Enabled = True
        Me.txt2.Location = New System.Drawing.Point(143, 85)
        Me.txt2.Name = "txt2"
        Me.txt2.OcxState = CType(resources.GetObject("txt2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt2.Size = New System.Drawing.Size(222, 27)
        Me.txt2.TabIndex = 3
        Me.txt2.UseWaitCursor = True
        '
        'txt3
        '
        Me.txt3.Enabled = True
        Me.txt3.Location = New System.Drawing.Point(143, 111)
        Me.txt3.Name = "txt3"
        Me.txt3.OcxState = CType(resources.GetObject("txt3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt3.Size = New System.Drawing.Size(222, 27)
        Me.txt3.TabIndex = 4
        Me.txt3.UseWaitCursor = True
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.SystemColors.Window
        Me.lbl2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(5, 13)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl2.Size = New System.Drawing.Size(360, 17)
        Me.lbl2.TabIndex = 14
        Me.lbl2.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Location = New System.Drawing.Point(5, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(134, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Haber (Dolares)"
        Me.Label2.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Location = New System.Drawing.Point(5, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(134, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Debe (Dolares)"
        Me.Label1.UseWaitCursor = True
        '
        '_lbl_1
        '
        Me._lbl_1.BackColor = System.Drawing.Color.White
        Me._lbl_1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me._lbl_1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me._lbl_1.Location = New System.Drawing.Point(6, 60)
        Me._lbl_1.Name = "_lbl_1"
        Me._lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_1.Size = New System.Drawing.Size(132, 21)
        Me._lbl_1.TabIndex = 9
        Me._lbl_1.Text = "Haber (Soles)"
        Me._lbl_1.UseWaitCursor = True
        '
        '_lbl_0
        '
        Me._lbl_0.BackColor = System.Drawing.Color.White
        Me._lbl_0.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me._lbl_0.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me._lbl_0.Location = New System.Drawing.Point(6, 34)
        Me._lbl_0.Name = "_lbl_0"
        Me._lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_0.Size = New System.Drawing.Size(132, 22)
        Me._lbl_0.TabIndex = 8
        Me._lbl_0.Text = "Debe (Soles)"
        Me._lbl_0.UseWaitCursor = True
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(111, 373)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(121, 51)
        Me.cmdBotones0.TabIndex = 5
        Me.cmdBotones0.Text = "&Aceptar"
        Me.cmdBotones0.UseVisualStyleBackColor = False
        Me.cmdBotones0.UseWaitCursor = True
        '
        'TDBGrid1
        '
        Me.TDBGrid1.DataSource = Nothing
        Me.TDBGrid1.Location = New System.Drawing.Point(1, 49)
        Me.TDBGrid1.Name = "TDBGrid1"
        Me.TDBGrid1.OcxState = CType(resources.GetObject("TDBGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBGrid1.Size = New System.Drawing.Size(368, 173)
        Me.TDBGrid1.TabIndex = 0
        Me.TDBGrid1.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(201, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Buscar por Código / Descripción"
        Me.Label3.UseWaitCursor = True
        '
        'frmMntSaldosInicialPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(388, 450)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.cmdBotones1)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdBotones0)
        Me.Controls.Add(Me.TDBGrid1)
        Me.Controls.Add(Me.Label3)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.Name = "frmMntSaldosInicialPlan"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldos Iniciales"
        Me.UseWaitCursor = True
        CType(Me.txtBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        CType(Me.txt0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
End Class