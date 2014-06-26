<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDiarioGeneral
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
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents optOpcion2 As System.Windows.Forms.RadioButton
    Public WithEvents optOpcion0 As System.Windows.Forms.RadioButton
    Public WithEvents optOpcion1 As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Ctr_Ayuda21 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents fraDetallado As System.Windows.Forms.GroupBox
    Public WithEvents Ctr_Ayuda1 As AxCtr_AyudaArray
    Public WithEvents Ctr_Ayuda2 As AxCtr_AyudaArray
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiarioGeneral))
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optOpcion2 = New System.Windows.Forms.RadioButton()
        Me.optOpcion0 = New System.Windows.Forms.RadioButton()
        Me.optOpcion1 = New System.Windows.Forms.RadioButton()
        Me.fraDetallado = New System.Windows.Forms.GroupBox()
        Me.Ctr_Ayuda21 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ctr_Ayuda20 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_Ayuda3 = New Ctr_Ayuda.Ctr_Ayuda()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.fraDetallado.SuspendLayout()
        CType(Me.Ctr_Ayuda21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayuda20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.cboMes)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(12, 102)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(342, 47)
        Me.Frame2.TabIndex = 18
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Seleccionar Mes"
        '
        'cboMes
        '
        Me.cboMes.BackColor = System.Drawing.SystemColors.Window
        Me.cboMes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMes.Location = New System.Drawing.Point(3, 13)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMes.Size = New System.Drawing.Size(331, 21)
        Me.cboMes.TabIndex = 2
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(85, 269)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(82, 23)
        Me.cmdBotones0.TabIndex = 16
        Me.cmdBotones0.Text = "&Aceptar"
        Me.cmdBotones0.UseVisualStyleBackColor = False
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(192, 269)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(82, 23)
        Me.cmdBotones1.TabIndex = 15
        Me.cmdBotones1.Text = "&Cancelar"
        Me.cmdBotones1.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.optOpcion2)
        Me.Frame1.Controls.Add(Me.optOpcion0)
        Me.Frame1.Controls.Add(Me.optOpcion1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(342, 84)
        Me.Frame1.TabIndex = 9
        Me.Frame1.TabStop = False
        '
        'optOpcion2
        '
        Me.optOpcion2.BackColor = System.Drawing.SystemColors.Control
        Me.optOpcion2.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion2.Location = New System.Drawing.Point(17, 56)
        Me.optOpcion2.Name = "optOpcion2"
        Me.optOpcion2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion2.Size = New System.Drawing.Size(191, 25)
        Me.optOpcion2.TabIndex = 21
        Me.optOpcion2.TabStop = True
        Me.optOpcion2.Text = "Diario General Resumido Tipo 2"
        Me.optOpcion2.UseVisualStyleBackColor = False
        '
        'optOpcion0
        '
        Me.optOpcion0.BackColor = System.Drawing.SystemColors.Control
        Me.optOpcion0.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion0.Location = New System.Drawing.Point(17, 16)
        Me.optOpcion0.Name = "optOpcion0"
        Me.optOpcion0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion0.Size = New System.Drawing.Size(172, 25)
        Me.optOpcion0.TabIndex = 0
        Me.optOpcion0.TabStop = True
        Me.optOpcion0.Text = "Diario General Detallado"
        Me.optOpcion0.UseVisualStyleBackColor = False
        '
        'optOpcion1
        '
        Me.optOpcion1.BackColor = System.Drawing.SystemColors.Control
        Me.optOpcion1.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion1.Location = New System.Drawing.Point(16, 40)
        Me.optOpcion1.Name = "optOpcion1"
        Me.optOpcion1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion1.Size = New System.Drawing.Size(197, 17)
        Me.optOpcion1.TabIndex = 1
        Me.optOpcion1.TabStop = True
        Me.optOpcion1.Text = "Diario General Resumido Tipo 1"
        Me.optOpcion1.UseVisualStyleBackColor = False
        '
        'fraDetallado
        '
        Me.fraDetallado.BackColor = System.Drawing.SystemColors.Control
        Me.fraDetallado.Controls.Add(Me.Ctr_Ayuda3)
        Me.fraDetallado.Controls.Add(Me.Ctr_Ayuda21)
        Me.fraDetallado.Controls.Add(Me.Label6)
        Me.fraDetallado.Controls.Add(Me.Label5)
        Me.fraDetallado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraDetallado.Location = New System.Drawing.Point(7, 155)
        Me.fraDetallado.Name = "fraDetallado"
        Me.fraDetallado.Padding = New System.Windows.Forms.Padding(0)
        Me.fraDetallado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDetallado.Size = New System.Drawing.Size(343, 80)
        Me.fraDetallado.TabIndex = 8
        Me.fraDetallado.TabStop = False
        Me.fraDetallado.Text = "Diario General Detallado"
        '
        'Ctr_Ayuda21
        '
        Me.Ctr_Ayuda21.Enabled = True
        Me.Ctr_Ayuda21.Location = New System.Drawing.Point(85, 44)
        Me.Ctr_Ayuda21.Name = "Ctr_Ayuda21"
        Me.Ctr_Ayuda21.OcxState = CType(resources.GetObject("Ctr_Ayuda21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda21.Size = New System.Drawing.Size(254, 22)
        Me.Ctr_Ayuda21.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(12, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "SubAsiento"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(13, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Asiento"
        '
        'Ctr_Ayuda20
        '
        Me.Ctr_Ayuda20.Enabled = True
        Me.Ctr_Ayuda20.Location = New System.Drawing.Point(29, 303)
        Me.Ctr_Ayuda20.Name = "Ctr_Ayuda20"
        Me.Ctr_Ayuda20.OcxState = CType(resources.GetObject("Ctr_Ayuda20.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda20.Size = New System.Drawing.Size(254, 22)
        Me.Ctr_Ayuda20.TabIndex = 19
        '
        'Ctr_Ayuda3
        '
        Me.Ctr_Ayuda3.CampoDevCod = "asientocodigo"
        Me.Ctr_Ayuda3.CampoDevDesc = "asientodescripcion"
        Me.Ctr_Ayuda3.Codigo = ""
        Me.Ctr_Ayuda3.Descripcion = ""
        Me.Ctr_Ayuda3.ListaAlias = "asientocodigo,asientodescripcion"
        Me.Ctr_Ayuda3.ListaCampos = "codigo,descripcion"
        Me.Ctr_Ayuda3.Location = New System.Drawing.Point(85, 17)
        Me.Ctr_Ayuda3.LongCod = "3"
        Me.Ctr_Ayuda3.LongDesc = "30"
        Me.Ctr_Ayuda3.Name = "Ctr_Ayuda3"
        Me.Ctr_Ayuda3.NombreTabla = "ct_asiento"
        Me.Ctr_Ayuda3.Requerido = False
        Me.Ctr_Ayuda3.Size = New System.Drawing.Size(244, 20)
        Me.Ctr_Ayuda3.TabIndex = 21
        Me.Ctr_Ayuda3.Titulo = "Tabla de asientos"
        '
        'frmDiarioGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(397, 337)
        Me.Controls.Add(Me.Ctr_Ayuda20)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.cmdBotones0)
        Me.Controls.Add(Me.cmdBotones1)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.fraDetallado)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.Name = "frmDiarioGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diario General"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.fraDetallado.ResumeLayout(False)
        CType(Me.Ctr_Ayuda21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayuda20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents Ctr_Ayuda3 As Ctr_Ayuda.Ctr_Ayuda
    Public WithEvents Ctr_Ayuda20 As Axctrlayuda_f.AxCtr_Ayuda
#End Region
End Class