<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmgeneradoc
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmgeneradoc))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.grbpaso2 = New System.Windows.Forms.GroupBox()
        Me.dgvVariables = New System.Windows.Forms.DataGridView()
        Me.colEtiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.grbpaso3 = New System.Windows.Forms.GroupBox()
        Me.btnexamacro = New System.Windows.Forms.Button()
        Me.dgvmacros = New System.Windows.Forms.DataGridView()
        Me.colMacro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArchivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.grbpaso4 = New System.Windows.Forms.GroupBox()
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grbpaso1 = New System.Windows.Forms.GroupBox()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso2.SuspendLayout()
        CType(Me.dgvVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso3.SuspendLayout()
        CType(Me.dgvmacros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso4.SuspendLayout()
        Me.grbpaso1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.19231!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.80769!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnsiguiente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnanterior, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btncerrar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(193, 267)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(491, 35)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsiguiente.Location = New System.Drawing.Point(150, 6)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(81, 23)
        Me.btnsiguiente.TabIndex = 2
        Me.btnsiguiente.Text = "Siguiente >"
        '
        'btnanterior
        '
        Me.btnanterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnanterior.Location = New System.Drawing.Point(26, 6)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(67, 23)
        Me.btnanterior.TabIndex = 0
        Me.btnanterior.Text = "< Regresar"
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncerrar.Location = New System.Drawing.Point(336, 6)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(81, 23)
        Me.btncerrar.TabIndex = 1
        Me.btncerrar.Text = "Cerrar"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(178, 116)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 6
        Me.LogoPictureBox.TabStop = False
        '
        'grbpaso2
        '
        Me.grbpaso2.Controls.Add(Me.dgvVariables)
        Me.grbpaso2.Controls.Add(Me.TextBox3)
        Me.grbpaso2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grbpaso2.Location = New System.Drawing.Point(187, 12)
        Me.grbpaso2.Name = "grbpaso2"
        Me.grbpaso2.Size = New System.Drawing.Size(500, 244)
        Me.grbpaso2.TabIndex = 8
        Me.grbpaso2.TabStop = False
        Me.grbpaso2.Text = " PASO 2: Sustitucion de variables "
        Me.grbpaso2.Visible = False
        '
        'dgvVariables
        '
        Me.dgvVariables.AllowUserToResizeRows = False
        Me.dgvVariables.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVariables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVariables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEtiqueta, Me.colValor, Me.colNombre})
        Me.dgvVariables.Location = New System.Drawing.Point(6, 38)
        Me.dgvVariables.MultiSelect = False
        Me.dgvVariables.Name = "dgvVariables"
        Me.dgvVariables.RowHeadersVisible = False
        Me.dgvVariables.Size = New System.Drawing.Size(485, 189)
        Me.dgvVariables.TabIndex = 1
        '
        'colEtiqueta
        '
        Me.colEtiqueta.HeaderText = "Etiqueta"
        Me.colEtiqueta.Name = "colEtiqueta"
        Me.colEtiqueta.ReadOnly = True
        Me.colEtiqueta.Width = 150
        '
        'colValor
        '
        Me.colValor.HeaderText = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.Width = 350
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(6, 19)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(340, 13)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = "Ingrese los valores de las siguientes variables a sustituir."
        '
        'grbpaso3
        '
        Me.grbpaso3.Controls.Add(Me.btnexamacro)
        Me.grbpaso3.Controls.Add(Me.dgvmacros)
        Me.grbpaso3.Controls.Add(Me.TextBox2)
        Me.grbpaso3.Location = New System.Drawing.Point(187, 12)
        Me.grbpaso3.Name = "grbpaso3"
        Me.grbpaso3.Size = New System.Drawing.Size(497, 244)
        Me.grbpaso3.TabIndex = 10
        Me.grbpaso3.TabStop = False
        Me.grbpaso3.Text = " PASO 3: Incorporación de archivos "
        Me.grbpaso3.Visible = False
        '
        'btnexamacro
        '
        Me.btnexamacro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexamacro.Location = New System.Drawing.Point(6, 215)
        Me.btnexamacro.Name = "btnexamacro"
        Me.btnexamacro.Size = New System.Drawing.Size(113, 23)
        Me.btnexamacro.TabIndex = 5
        Me.btnexamacro.Text = "Examinar..."
        Me.btnexamacro.UseVisualStyleBackColor = True
        '
        'dgvmacros
        '
        Me.dgvmacros.AllowUserToResizeRows = False
        Me.dgvmacros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvmacros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvmacros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmacros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMacro, Me.colArchivo})
        Me.dgvmacros.Location = New System.Drawing.Point(6, 49)
        Me.dgvmacros.MultiSelect = False
        Me.dgvmacros.Name = "dgvmacros"
        Me.dgvmacros.RowHeadersVisible = False
        Me.dgvmacros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmacros.Size = New System.Drawing.Size(485, 157)
        Me.dgvmacros.TabIndex = 2
        '
        'colMacro
        '
        Me.colMacro.HeaderText = "Macro"
        Me.colMacro.Name = "colMacro"
        Me.colMacro.ReadOnly = True
        Me.colMacro.Width = 200
        '
        'colArchivo
        '
        Me.colArchivo.HeaderText = "Archivo"
        Me.colArchivo.Name = "colArchivo"
        Me.colArchivo.Width = 350
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(6, 19)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(351, 33)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "A continuación es necesario ingresar los archivos para su incorporación."
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'grbpaso4
        '
        Me.grbpaso4.Controls.Add(Me.lstdebug)
        Me.grbpaso4.Controls.Add(Me.btngenerar)
        Me.grbpaso4.Controls.Add(Me.TextBox4)
        Me.grbpaso4.Location = New System.Drawing.Point(187, 12)
        Me.grbpaso4.Name = "grbpaso4"
        Me.grbpaso4.Size = New System.Drawing.Size(497, 244)
        Me.grbpaso4.TabIndex = 11
        Me.grbpaso4.TabStop = False
        Me.grbpaso4.Text = " PASO 4: Generación del documento .doc "
        Me.grbpaso4.Visible = False
        '
        'lstdebug
        '
        Me.lstdebug.FormattingEnabled = True
        Me.lstdebug.Location = New System.Drawing.Point(6, 89)
        Me.lstdebug.Name = "lstdebug"
        Me.lstdebug.Size = New System.Drawing.Size(485, 147)
        Me.lstdebug.TabIndex = 6
        '
        'btngenerar
        '
        Me.btngenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btngenerar.Location = New System.Drawing.Point(6, 58)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(113, 23)
        Me.btngenerar.TabIndex = 5
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(6, 19)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(485, 33)
        Me.TextBox4.TabIndex = 0
        Me.TextBox4.Text = "En este paso se valida que se haya ingresado toda la información necesaria para l" & _
            "a generación del documento."
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(322, 33)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "De la siguiente lista, seleccione la documentación que puede ser generada utiliza" & _
            "ndo este WIZART"
        '
        'grbpaso1
        '
        Me.grbpaso1.Controls.Add(Me.cbotipo)
        Me.grbpaso1.Controls.Add(Me.TextBox1)
        Me.grbpaso1.Location = New System.Drawing.Point(187, 12)
        Me.grbpaso1.Name = "grbpaso1"
        Me.grbpaso1.Size = New System.Drawing.Size(497, 244)
        Me.grbpaso1.TabIndex = 7
        Me.grbpaso1.TabStop = False
        Me.grbpaso1.Text = " PASO 1: Elegir el tipo de documentación a generar "
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Location = New System.Drawing.Point(6, 58)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(485, 21)
        Me.cbotipo.TabIndex = 1
        '
        'frmgeneradoc
        '
        Me.AcceptButton = Me.btnanterior
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btncerrar
        Me.ClientSize = New System.Drawing.Size(695, 314)
        Me.ControlBox = False
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.grbpaso4)
        Me.Controls.Add(Me.grbpaso3)
        Me.Controls.Add(Me.grbpaso2)
        Me.Controls.Add(Me.grbpaso1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmgeneradoc"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GENARO - Generación de archivo .doc"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso2.ResumeLayout(False)
        Me.grbpaso2.PerformLayout()
        CType(Me.dgvVariables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso3.ResumeLayout(False)
        Me.grbpaso3.PerformLayout()
        CType(Me.dgvmacros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso4.ResumeLayout(False)
        Me.grbpaso4.PerformLayout()
        Me.grbpaso1.ResumeLayout(False)
        Me.grbpaso1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents grbpaso2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dgvVariables As System.Windows.Forms.DataGridView
    Friend WithEvents dgvmacros As System.Windows.Forms.DataGridView
    Friend WithEvents btnexamacro As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grbpaso4 As System.Windows.Forms.GroupBox
    Friend WithEvents btngenerar As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents colMacro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colArchivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEtiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
