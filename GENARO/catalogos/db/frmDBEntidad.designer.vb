<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBEntidad
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabgeneral = New System.Windows.Forms.TabPage()
        Me.btnentgrabar = New System.Windows.Forms.Button()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabcampo = New System.Windows.Forms.TabPage()
        Me.gridcampos = New System.Windows.Forms.DataGridView()
        Me.txttotcampos = New System.Windows.Forms.TextBox()
        Me.btncamdetalle = New System.Windows.Forms.Button()
        Me.btncamposload = New System.Windows.Forms.Button()
        Me.btncamdel = New System.Windows.Forms.Button()
        Me.btncamadd = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtmainame = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabgeneral.SuspendLayout()
        Me.tabcampo.SuspendLayout()
        CType(Me.gridcampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabgeneral)
        Me.TabControl1.Controls.Add(Me.tabcampo)
        Me.TabControl1.Location = New System.Drawing.Point(15, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(641, 279)
        Me.TabControl1.TabIndex = 13
        '
        'tabgeneral
        '
        Me.tabgeneral.Controls.Add(Me.btnentgrabar)
        Me.tabgeneral.Controls.Add(Me.txtComment)
        Me.tabgeneral.Controls.Add(Me.Label10)
        Me.tabgeneral.Controls.Add(Me.cboTipo)
        Me.tabgeneral.Controls.Add(Me.Label5)
        Me.tabgeneral.Controls.Add(Me.txtnombre)
        Me.tabgeneral.Controls.Add(Me.Label3)
        Me.tabgeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabgeneral.Name = "tabgeneral"
        Me.tabgeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabgeneral.Size = New System.Drawing.Size(633, 253)
        Me.tabgeneral.TabIndex = 0
        Me.tabgeneral.Text = "General"
        Me.tabgeneral.UseVisualStyleBackColor = True
        '
        'btnentgrabar
        '
        Me.btnentgrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnentgrabar.Location = New System.Drawing.Point(545, 214)
        Me.btnentgrabar.Name = "btnentgrabar"
        Me.btnentgrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnentgrabar.TabIndex = 34
        Me.btnentgrabar.Text = "Grabar"
        Me.btnentgrabar.UseVisualStyleBackColor = True
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(25, 96)
        Me.txtComment.MaxLength = 255
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComment.Size = New System.Drawing.Size(595, 52)
        Me.txtComment.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Comentarios :"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(89, 45)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(433, 21)
        Me.cboTipo.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Tipo :"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(89, 16)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(219, 20)
        Me.txtnombre.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nombre :"
        '
        'tabcampo
        '
        Me.tabcampo.Controls.Add(Me.gridcampos)
        Me.tabcampo.Controls.Add(Me.txttotcampos)
        Me.tabcampo.Controls.Add(Me.btncamdetalle)
        Me.tabcampo.Controls.Add(Me.btncamposload)
        Me.tabcampo.Controls.Add(Me.btncamdel)
        Me.tabcampo.Controls.Add(Me.btncamadd)
        Me.tabcampo.Controls.Add(Me.Label16)
        Me.tabcampo.Location = New System.Drawing.Point(4, 22)
        Me.tabcampo.Name = "tabcampo"
        Me.tabcampo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabcampo.Size = New System.Drawing.Size(633, 253)
        Me.tabcampo.TabIndex = 1
        Me.tabcampo.Text = "Campos"
        Me.tabcampo.UseVisualStyleBackColor = True
        '
        'gridcampos
        '
        Me.gridcampos.AllowUserToAddRows = False
        Me.gridcampos.AllowUserToDeleteRows = False
        Me.gridcampos.AllowUserToResizeRows = False
        Me.gridcampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridcampos.Location = New System.Drawing.Point(32, 40)
        Me.gridcampos.MultiSelect = False
        Me.gridcampos.Name = "gridcampos"
        Me.gridcampos.ReadOnly = True
        Me.gridcampos.RowHeadersVisible = False
        Me.gridcampos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridcampos.Size = New System.Drawing.Size(568, 167)
        Me.gridcampos.TabIndex = 43
        '
        'txttotcampos
        '
        Me.txttotcampos.Location = New System.Drawing.Point(180, 213)
        Me.txttotcampos.Name = "txttotcampos"
        Me.txttotcampos.ReadOnly = True
        Me.txttotcampos.Size = New System.Drawing.Size(356, 20)
        Me.txttotcampos.TabIndex = 42
        Me.txttotcampos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btncamdetalle
        '
        Me.btncamdetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncamdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncamdetalle.Location = New System.Drawing.Point(85, 212)
        Me.btncamdetalle.Name = "btncamdetalle"
        Me.btncamdetalle.Size = New System.Drawing.Size(89, 20)
        Me.btncamdetalle.TabIndex = 41
        Me.btncamdetalle.Text = "ver detalle"
        Me.btncamdetalle.UseVisualStyleBackColor = True
        '
        'btncamposload
        '
        Me.btncamposload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncamposload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncamposload.Location = New System.Drawing.Point(32, 212)
        Me.btncamposload.Name = "btncamposload"
        Me.btncamposload.Size = New System.Drawing.Size(47, 20)
        Me.btncamposload.TabIndex = 40
        Me.btncamposload.Text = "load"
        Me.btncamposload.UseVisualStyleBackColor = True
        '
        'btncamdel
        '
        Me.btncamdel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncamdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncamdel.Location = New System.Drawing.Point(543, 213)
        Me.btncamdel.Name = "btncamdel"
        Me.btncamdel.Size = New System.Drawing.Size(25, 20)
        Me.btncamdel.TabIndex = 39
        Me.btncamdel.Text = "-"
        Me.btncamdel.UseVisualStyleBackColor = True
        '
        'btncamadd
        '
        Me.btncamadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncamadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncamadd.Location = New System.Drawing.Point(574, 213)
        Me.btncamadd.Name = "btncamadd"
        Me.btncamadd.Size = New System.Drawing.Size(25, 20)
        Me.btncamadd.TabIndex = 38
        Me.btncamadd.Text = "+"
        Me.btncamadd.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(33, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(567, 23)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "CAMPOS"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(565, 14)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtmainame
        '
        Me.txtmainame.Location = New System.Drawing.Point(63, 17)
        Me.txtmainame.Name = "txtmainame"
        Me.txtmainame.ReadOnly = True
        Me.txtmainame.Size = New System.Drawing.Size(377, 20)
        Me.txtmainame.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre :"
        '
        'frmDBEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 346)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtmainame)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDBEntidad"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Detalle de una entidad de datos"
        Me.TabControl1.ResumeLayout(False)
        Me.tabgeneral.ResumeLayout(False)
        Me.tabgeneral.PerformLayout()
        Me.tabcampo.ResumeLayout(False)
        Me.tabcampo.PerformLayout()
        CType(Me.gridcampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabgeneral As System.Windows.Forms.TabPage
    Friend WithEvents btnentgrabar As System.Windows.Forms.Button
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tabcampo As System.Windows.Forms.TabPage
    Private WithEvents gridcampos As System.Windows.Forms.DataGridView
    Friend WithEvents txttotcampos As System.Windows.Forms.TextBox
    Friend WithEvents btncamdetalle As System.Windows.Forms.Button
    Friend WithEvents btncamposload As System.Windows.Forms.Button
    Friend WithEvents btncamdel As System.Windows.Forms.Button
    Friend WithEvents btncamadd As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtmainame As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
