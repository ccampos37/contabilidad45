<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMntEntidad
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
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents cmdBotones2 As System.Windows.Forms.Button
    Public WithEvents cmdBotones4 As System.Windows.Forms.Button
    Public WithEvents cmdBotones3 As System.Windows.Forms.Button
    Public WithEvents frmbotones As System.Windows.Forms.GroupBox
    Public WithEvents cAcepta As System.Windows.Forms.Button
    Public WithEvents cCancela As System.Windows.Forms.Button
    Public WithEvents cboTipoCont As System.Windows.Forms.ComboBox
    Public WithEvents ListView1 As System.Windows.Forms.ListView
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents _lbl_1 As System.Windows.Forms.Label
    Public WithEvents _lbl_2 As System.Windows.Forms.Label
    Public WithEvents _lbl_3 As System.Windows.Forms.Label
    Public WithEvents _lbl_16 As System.Windows.Forms.Label
    Public WithEvents _lbl_0 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txt As AxTxFerArray
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMntEntidad))
        Me.frmbotones = New System.Windows.Forms.GroupBox()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.cmdBotones2 = New System.Windows.Forms.Button()
        Me.cmdBotones4 = New System.Windows.Forms.Button()
        Me.cmdBotones3 = New System.Windows.Forms.Button()
        Me.cAcepta = New System.Windows.Forms.Button()
        Me.cCancela = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt0 = New System.Windows.Forms.TextBox()
        Me.cboTipoCont = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._lbl_1 = New System.Windows.Forms.Label()
        Me._lbl_2 = New System.Windows.Forms.Label()
        Me._lbl_3 = New System.Windows.Forms.Label()
        Me._lbl_16 = New System.Windows.Forms.Label()
        Me._lbl_0 = New System.Windows.Forms.Label()
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TDBGrid1 = New System.Windows.Forms.DataGridView()
        Me.lblNumReg = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtbuscar = New AxTextFer.AxTxFer()
        Me.frmbotones.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SSTab1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.txtbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmbotones
        '
        Me.frmbotones.BackColor = System.Drawing.SystemColors.Control
        Me.frmbotones.Controls.Add(Me.cmdBotones0)
        Me.frmbotones.Controls.Add(Me.cmdBotones1)
        Me.frmbotones.Controls.Add(Me.cmdBotones2)
        Me.frmbotones.Controls.Add(Me.cmdBotones4)
        Me.frmbotones.Controls.Add(Me.cmdBotones3)
        Me.frmbotones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmbotones.Location = New System.Drawing.Point(94, 302)
        Me.frmbotones.Name = "frmbotones"
        Me.frmbotones.Padding = New System.Windows.Forms.Padding(0)
        Me.frmbotones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmbotones.Size = New System.Drawing.Size(381, 37)
        Me.frmbotones.TabIndex = 8
        Me.frmbotones.TabStop = False
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
        Me.cmdBotones0.TabIndex = 13
        Me.cmdBotones0.Text = "&Nuevo"
        Me.cmdBotones0.UseVisualStyleBackColor = False
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
        Me.cmdBotones1.TabIndex = 12
        Me.cmdBotones1.Text = "E&ditar"
        Me.cmdBotones1.UseVisualStyleBackColor = False
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
        Me.cmdBotones2.TabIndex = 11
        Me.cmdBotones2.Text = "&Eliminar"
        Me.cmdBotones2.UseVisualStyleBackColor = False
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
        Me.cmdBotones4.TabIndex = 10
        Me.cmdBotones4.Text = "&Salir"
        Me.cmdBotones4.UseVisualStyleBackColor = False
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
        Me.cmdBotones3.TabIndex = 9
        Me.cmdBotones3.Text = "&Imprimir"
        Me.cmdBotones3.UseVisualStyleBackColor = False
        '
        'cAcepta
        '
        Me.cAcepta.BackColor = System.Drawing.SystemColors.Control
        Me.cAcepta.Cursor = System.Windows.Forms.Cursors.Default
        Me.cAcepta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cAcepta.Location = New System.Drawing.Point(168, 330)
        Me.cAcepta.Name = "cAcepta"
        Me.cAcepta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cAcepta.Size = New System.Drawing.Size(76, 23)
        Me.cAcepta.TabIndex = 6
        Me.cAcepta.Text = "&Aceptar"
        Me.cAcepta.UseVisualStyleBackColor = False
        '
        'cCancela
        '
        Me.cCancela.BackColor = System.Drawing.SystemColors.Control
        Me.cCancela.Cursor = System.Windows.Forms.Cursors.Default
        Me.cCancela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cCancela.Location = New System.Drawing.Point(264, 330)
        Me.cCancela.Name = "cCancela"
        Me.cCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cCancela.Size = New System.Drawing.Size(76, 23)
        Me.cCancela.TabIndex = 7
        Me.cCancela.Text = "&Cancelar"
        Me.cCancela.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txt3)
        Me.Frame1.Controls.Add(Me.txt2)
        Me.Frame1.Controls.Add(Me.txt1)
        Me.Frame1.Controls.Add(Me.txt4)
        Me.Frame1.Controls.Add(Me.txt0)
        Me.Frame1.Controls.Add(Me.cboTipoCont)
        Me.Frame1.Controls.Add(Me.ListView1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me._lbl_1)
        Me.Frame1.Controls.Add(Me._lbl_2)
        Me.Frame1.Controls.Add(Me._lbl_3)
        Me.Frame1.Controls.Add(Me._lbl_16)
        Me.Frame1.Controls.Add(Me._lbl_0)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(32, 32)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(437, 283)
        Me.Frame1.TabIndex = 15
        Me.Frame1.TabStop = False
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(181, 119)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(251, 20)
        Me.txt3.TabIndex = 31
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(181, 91)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(251, 20)
        Me.txt2.TabIndex = 30
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(181, 65)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(251, 20)
        Me.txt1.TabIndex = 29
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(182, 39)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(251, 20)
        Me.txt4.TabIndex = 28
        '
        'txt0
        '
        Me.txt0.Location = New System.Drawing.Point(182, 12)
        Me.txt0.Name = "txt0"
        Me.txt0.Size = New System.Drawing.Size(251, 20)
        Me.txt0.TabIndex = 27
        '
        'cboTipoCont
        '
        Me.cboTipoCont.BackColor = System.Drawing.SystemColors.Window
        Me.cboTipoCont.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTipoCont.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTipoCont.Items.AddRange(New Object() {"01 - Principal Contribuyente", "02 - Buen Contribuyente", "03 - Normal Contribuyente"})
        Me.cboTipoCont.Location = New System.Drawing.Point(182, 145)
        Me.cboTipoCont.Name = "cboTipoCont"
        Me.cboTipoCont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTipoCont.Size = New System.Drawing.Size(253, 21)
        Me.cboTipoCont.TabIndex = 5
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Window
        Me.ListView1.CheckBoxes = True
        Me.ListView1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListView1.GridLines = True
        Me.ListView1.LabelEdit = True
        Me.ListView1.Location = New System.Drawing.Point(2, 172)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(433, 103)
        Me.ListView1.TabIndex = 24
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(154, 18)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Tipo Contribuyente"
        '
        '_lbl_1
        '
        Me._lbl_1.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_1.Location = New System.Drawing.Point(8, 65)
        Me._lbl_1.Name = "_lbl_1"
        Me._lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_1.Size = New System.Drawing.Size(154, 19)
        Me._lbl_1.TabIndex = 19
        Me._lbl_1.Text = "Razón Social"
        '
        '_lbl_2
        '
        Me._lbl_2.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_2.Location = New System.Drawing.Point(8, 92)
        Me._lbl_2.Name = "_lbl_2"
        Me._lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_2.Size = New System.Drawing.Size(154, 19)
        Me._lbl_2.TabIndex = 18
        Me._lbl_2.Text = "Dirección"
        '
        '_lbl_3
        '
        Me._lbl_3.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_3.Location = New System.Drawing.Point(8, 118)
        Me._lbl_3.Name = "_lbl_3"
        Me._lbl_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_3.Size = New System.Drawing.Size(154, 19)
        Me._lbl_3.TabIndex = 17
        Me._lbl_3.Text = "Telefono"
        '
        '_lbl_16
        '
        Me._lbl_16.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_16.Location = New System.Drawing.Point(9, 42)
        Me._lbl_16.Name = "_lbl_16"
        Me._lbl_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_16.Size = New System.Drawing.Size(159, 19)
        Me._lbl_16.TabIndex = 16
        Me._lbl_16.Text = "RUC"
        '
        '_lbl_0
        '
        Me._lbl_0.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_0.Location = New System.Drawing.Point(8, 21)
        Me._lbl_0.Name = "_lbl_0"
        Me._lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_0.Size = New System.Drawing.Size(56, 19)
        Me._lbl_0.TabIndex = 20
        Me._lbl_0.Text = "Código"
        '
        'SSTab1
        '
        Me.SSTab1.Controls.Add(Me.TabPage1)
        Me.SSTab1.Controls.Add(Me.TabPage2)
        Me.SSTab1.Location = New System.Drawing.Point(12, 12)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 0
        Me.SSTab1.Size = New System.Drawing.Size(576, 385)
        Me.SSTab1.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TDBGrid1)
        Me.TabPage1.Controls.Add(Me.lblNumReg)
        Me.TabPage1.Controls.Add(Me.frmbotones)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(568, 359)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consulta"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TDBGrid1
        '
        Me.TDBGrid1.AllowUserToAddRows = False
        Me.TDBGrid1.AllowUserToDeleteRows = False
        Me.TDBGrid1.AllowUserToOrderColumns = True
        Me.TDBGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TDBGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TDBGrid1.Location = New System.Drawing.Point(26, 25)
        Me.TDBGrid1.Name = "TDBGrid1"
        Me.TDBGrid1.Size = New System.Drawing.Size(508, 274)
        Me.TDBGrid1.TabIndex = 29
        '
        'lblNumReg
        '
        Me.lblNumReg.AutoSize = True
        Me.lblNumReg.Location = New System.Drawing.Point(495, 368)
        Me.lblNumReg.Name = "lblNumReg"
        Me.lblNumReg.Size = New System.Drawing.Size(39, 13)
        Me.lblNumReg.TabIndex = 28
        Me.lblNumReg.Text = "Label1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cAcepta)
        Me.TabPage2.Controls.Add(Me.Frame1)
        Me.TabPage2.Controls.Add(Me.cCancela)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(568, 359)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Enabled = True
        Me.txtbuscar.Location = New System.Drawing.Point(206, 11)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.OcxState = CType(resources.GetObject("txtbuscar.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txtbuscar.Size = New System.Drawing.Size(279, 20)
        Me.txtbuscar.TabIndex = 26
        '
        'frmMantEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(600, 404)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.SSTab1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMantEntidad"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Entidad (Analìtico)"
        Me.frmbotones.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.SSTab1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.txtbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SSTab1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblNumReg As System.Windows.Forms.Label
    Public WithEvents txtbuscar As AxTextFer.AxTxFer
    Friend WithEvents TDBGrid1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt0 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
#End Region
End Class