<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuenteDatos
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
        Me.txtmainame = New System.Windows.Forms.TextBox()
        Me.txtmainclave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabgeneral = New System.Windows.Forms.TabPage()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btngengrabar = New System.Windows.Forms.Button()
        Me.txtconexion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabentidades = New System.Windows.Forms.TabPage()
        Me.gridentidades = New System.Windows.Forms.DataGridView()
        Me.txttotentidades = New System.Windows.Forms.TextBox()
        Me.btnrepdetalle = New System.Windows.Forms.Button()
        Me.btnentyload = New System.Windows.Forms.Button()
        Me.btnrepdel = New System.Windows.Forms.Button()
        Me.btnrepadd = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabgeneral.SuspendLayout()
        Me.tabentidades.SuspendLayout()
        CType(Me.gridentidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmainame
        '
        Me.txtmainame.Location = New System.Drawing.Point(164, 18)
        Me.txtmainame.Name = "txtmainame"
        Me.txtmainame.ReadOnly = True
        Me.txtmainame.Size = New System.Drawing.Size(377, 20)
        Me.txtmainame.TabIndex = 6
        '
        'txtmainclave
        '
        Me.txtmainclave.Location = New System.Drawing.Point(58, 18)
        Me.txtmainclave.Name = "txtmainclave"
        Me.txtmainclave.ReadOnly = True
        Me.txtmainclave.Size = New System.Drawing.Size(100, 20)
        Me.txtmainclave.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Clave :"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(565, 15)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabgeneral)
        Me.TabControl1.Controls.Add(Me.tabentidades)
        Me.TabControl1.Location = New System.Drawing.Point(15, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(641, 336)
        Me.TabControl1.TabIndex = 8
        '
        'tabgeneral
        '
        Me.tabgeneral.Controls.Add(Me.cbotipo)
        Me.tabgeneral.Controls.Add(Me.Label6)
        Me.tabgeneral.Controls.Add(Me.btngengrabar)
        Me.tabgeneral.Controls.Add(Me.txtconexion)
        Me.tabgeneral.Controls.Add(Me.Label2)
        Me.tabgeneral.Controls.Add(Me.txtComentario)
        Me.tabgeneral.Controls.Add(Me.Label10)
        Me.tabgeneral.Controls.Add(Me.cboCliente)
        Me.tabgeneral.Controls.Add(Me.Label5)
        Me.tabgeneral.Controls.Add(Me.txtclave)
        Me.tabgeneral.Controls.Add(Me.Label4)
        Me.tabgeneral.Controls.Add(Me.txtnombre)
        Me.tabgeneral.Controls.Add(Me.Label3)
        Me.tabgeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabgeneral.Name = "tabgeneral"
        Me.tabgeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabgeneral.Size = New System.Drawing.Size(633, 310)
        Me.tabgeneral.TabIndex = 0
        Me.tabgeneral.Text = "General"
        Me.tabgeneral.UseVisualStyleBackColor = True
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Items.AddRange(New Object() {"BD - Manejadro de base de dato", "HT - HOST"})
        Me.cbotipo.Location = New System.Drawing.Point(89, 109)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(231, 21)
        Me.cbotipo.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Tipo :"
        '
        'btngengrabar
        '
        Me.btngengrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngengrabar.Location = New System.Drawing.Point(545, 38)
        Me.btngengrabar.Name = "btngengrabar"
        Me.btngengrabar.Size = New System.Drawing.Size(75, 23)
        Me.btngengrabar.TabIndex = 34
        Me.btngengrabar.Text = "Grabar"
        Me.btngengrabar.UseVisualStyleBackColor = True
        '
        'txtconexion
        '
        Me.txtconexion.Location = New System.Drawing.Point(25, 179)
        Me.txtconexion.MaxLength = 100
        Me.txtconexion.Multiline = True
        Me.txtconexion.Name = "txtconexion"
        Me.txtconexion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtconexion.Size = New System.Drawing.Size(267, 115)
        Me.txtconexion.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Parámetros de conexión :"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(353, 135)
        Me.txtComentario.MaxLength = 255
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentario.Size = New System.Drawing.Size(267, 159)
        Me.txtComentario.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(350, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Comentarios :"
        '
        'cboCliente
        '
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(89, 74)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(433, 21)
        Me.cboCliente.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Cliente :"
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(89, 14)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.ReadOnly = True
        Me.txtclave.Size = New System.Drawing.Size(100, 20)
        Me.txtclave.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Clave :"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(89, 40)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(433, 20)
        Me.txtnombre.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nombre :"
        '
        'tabentidades
        '
        Me.tabentidades.Controls.Add(Me.gridentidades)
        Me.tabentidades.Controls.Add(Me.txttotentidades)
        Me.tabentidades.Controls.Add(Me.btnrepdetalle)
        Me.tabentidades.Controls.Add(Me.btnentyload)
        Me.tabentidades.Controls.Add(Me.btnrepdel)
        Me.tabentidades.Controls.Add(Me.btnrepadd)
        Me.tabentidades.Controls.Add(Me.Label16)
        Me.tabentidades.Location = New System.Drawing.Point(4, 22)
        Me.tabentidades.Name = "tabentidades"
        Me.tabentidades.Padding = New System.Windows.Forms.Padding(3)
        Me.tabentidades.Size = New System.Drawing.Size(633, 310)
        Me.tabentidades.TabIndex = 1
        Me.tabentidades.Text = "Entidades"
        Me.tabentidades.UseVisualStyleBackColor = True
        '
        'gridentidades
        '
        Me.gridentidades.AllowUserToAddRows = False
        Me.gridentidades.AllowUserToDeleteRows = False
        Me.gridentidades.AllowUserToResizeRows = False
        Me.gridentidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridentidades.Location = New System.Drawing.Point(32, 72)
        Me.gridentidades.MultiSelect = False
        Me.gridentidades.Name = "gridentidades"
        Me.gridentidades.ReadOnly = True
        Me.gridentidades.RowHeadersVisible = False
        Me.gridentidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridentidades.Size = New System.Drawing.Size(568, 167)
        Me.gridentidades.TabIndex = 43
        '
        'txttotentidades
        '
        Me.txttotentidades.Location = New System.Drawing.Point(180, 246)
        Me.txttotentidades.Name = "txttotentidades"
        Me.txttotentidades.ReadOnly = True
        Me.txttotentidades.Size = New System.Drawing.Size(356, 20)
        Me.txttotentidades.TabIndex = 42
        Me.txttotentidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnrepdetalle
        '
        Me.btnrepdetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrepdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrepdetalle.Location = New System.Drawing.Point(85, 245)
        Me.btnrepdetalle.Name = "btnrepdetalle"
        Me.btnrepdetalle.Size = New System.Drawing.Size(89, 20)
        Me.btnrepdetalle.TabIndex = 41
        Me.btnrepdetalle.Text = "ver detalle"
        Me.btnrepdetalle.UseVisualStyleBackColor = True
        '
        'btnentyload
        '
        Me.btnentyload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnentyload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentyload.Location = New System.Drawing.Point(32, 245)
        Me.btnentyload.Name = "btnentyload"
        Me.btnentyload.Size = New System.Drawing.Size(47, 20)
        Me.btnentyload.TabIndex = 40
        Me.btnentyload.Text = "load"
        Me.btnentyload.UseVisualStyleBackColor = True
        '
        'btnrepdel
        '
        Me.btnrepdel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrepdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrepdel.Location = New System.Drawing.Point(543, 246)
        Me.btnrepdel.Name = "btnrepdel"
        Me.btnrepdel.Size = New System.Drawing.Size(25, 20)
        Me.btnrepdel.TabIndex = 39
        Me.btnrepdel.Text = "-"
        Me.btnrepdel.UseVisualStyleBackColor = True
        '
        'btnrepadd
        '
        Me.btnrepadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrepadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrepadd.Location = New System.Drawing.Point(574, 246)
        Me.btnrepadd.Name = "btnrepadd"
        Me.btnrepadd.Size = New System.Drawing.Size(25, 20)
        Me.btnrepadd.TabIndex = 38
        Me.btnrepadd.Text = "+"
        Me.btnrepadd.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(33, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(567, 23)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "ENTIDADES"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFuenteDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 407)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtmainame)
        Me.Controls.Add(Me.txtmainclave)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFuenteDatos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Detalle de una Fuente de Datos"
        Me.TabControl1.ResumeLayout(False)
        Me.tabgeneral.ResumeLayout(False)
        Me.tabgeneral.PerformLayout()
        Me.tabentidades.ResumeLayout(False)
        Me.tabentidades.PerformLayout()
        CType(Me.gridentidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmainame As System.Windows.Forms.TextBox
    Friend WithEvents txtmainclave As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabgeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabentidades As System.Windows.Forms.TabPage
    Friend WithEvents txtconexion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents gridentidades As System.Windows.Forms.DataGridView
    Friend WithEvents txttotentidades As System.Windows.Forms.TextBox
    Friend WithEvents btnrepdetalle As System.Windows.Forms.Button
    Friend WithEvents btnentyload As System.Windows.Forms.Button
    Friend WithEvents btnrepdel As System.Windows.Forms.Button
    Friend WithEvents btnrepadd As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btngengrabar As System.Windows.Forms.Button
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
