<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProyecto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmainclave = New System.Windows.Forms.TextBox()
        Me.txtmainame = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.cboEstatus = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btngengrabar = New System.Windows.Forms.Button()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboPMP = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabPantallas = New System.Windows.Forms.TabPage()
        Me.txttotpantallas = New System.Windows.Forms.TextBox()
        Me.btnpantdetalle = New System.Windows.Forms.Button()
        Me.btnpantload = New System.Windows.Forms.Button()
        Me.btnpantdel = New System.Windows.Forms.Button()
        Me.btnpantadd = New System.Windows.Forms.Button()
        Me.gridpantallas = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tabReportes = New System.Windows.Forms.TabPage()
        Me.gridreportes = New System.Windows.Forms.DataGridView()
        Me.txttotreportes = New System.Windows.Forms.TextBox()
        Me.btnrepdetalle = New System.Windows.Forms.Button()
        Me.btnrepsload = New System.Windows.Forms.Button()
        Me.btnrepdel = New System.Windows.Forms.Button()
        Me.btnrepadd = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tabdatos = New System.Windows.Forms.TabPage()
        Me.txttotfuentes = New System.Windows.Forms.TextBox()
        Me.btnftedetalle = New System.Windows.Forms.Button()
        Me.btnfteload = New System.Windows.Forms.Button()
        Me.btndelfuente = New System.Windows.Forms.Button()
        Me.btnaddfuente = New System.Windows.Forms.Button()
        Me.dgvfuentedatos = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tabNavegacion = New System.Windows.Forms.TabPage()
        Me.txtnavegacion = New System.Windows.Forms.TextBox()
        Me.btnavdetalle = New System.Windows.Forms.Button()
        Me.btnavload = New System.Windows.Forms.Button()
        Me.btnavdel = New System.Windows.Forms.Button()
        Me.btnavadd = New System.Windows.Forms.Button()
        Me.gridNavegacion = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.tabPantallas.SuspendLayout()
        CType(Me.gridpantallas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReportes.SuspendLayout()
        CType(Me.gridreportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabdatos.SuspendLayout()
        CType(Me.dgvfuentedatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNavegacion.SuspendLayout()
        CType(Me.gridNavegacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave :"
        '
        'txtmainclave
        '
        Me.txtmainclave.Location = New System.Drawing.Point(60, 13)
        Me.txtmainclave.Name = "txtmainclave"
        Me.txtmainclave.ReadOnly = True
        Me.txtmainclave.Size = New System.Drawing.Size(100, 20)
        Me.txtmainclave.TabIndex = 1
        '
        'txtmainame
        '
        Me.txtmainame.Location = New System.Drawing.Point(166, 13)
        Me.txtmainame.Name = "txtmainame"
        Me.txtmainame.ReadOnly = True
        Me.txtmainame.Size = New System.Drawing.Size(400, 20)
        Me.txtmainame.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabGeneral)
        Me.TabControl1.Controls.Add(Me.tabPantallas)
        Me.TabControl1.Controls.Add(Me.tabReportes)
        Me.TabControl1.Controls.Add(Me.tabdatos)
        Me.TabControl1.Controls.Add(Me.tabNavegacion)
        Me.TabControl1.Location = New System.Drawing.Point(17, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(648, 341)
        Me.TabControl1.TabIndex = 4
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabGeneral.Controls.Add(Me.cboEstatus)
        Me.tabGeneral.Controls.Add(Me.Label15)
        Me.tabGeneral.Controls.Add(Me.btngengrabar)
        Me.tabGeneral.Controls.Add(Me.txtComentario)
        Me.tabGeneral.Controls.Add(Me.Label10)
        Me.tabGeneral.Controls.Add(Me.txtIva)
        Me.tabGeneral.Controls.Add(Me.Label9)
        Me.tabGeneral.Controls.Add(Me.txtPrecio)
        Me.tabGeneral.Controls.Add(Me.Label8)
        Me.tabGeneral.Controls.Add(Me.cboEmpresa)
        Me.tabGeneral.Controls.Add(Me.Label7)
        Me.tabGeneral.Controls.Add(Me.cboPMP)
        Me.tabGeneral.Controls.Add(Me.Label6)
        Me.tabGeneral.Controls.Add(Me.cboCliente)
        Me.tabGeneral.Controls.Add(Me.Label5)
        Me.tabGeneral.Controls.Add(Me.txtclave)
        Me.tabGeneral.Controls.Add(Me.Label4)
        Me.tabGeneral.Controls.Add(Me.txtnombre)
        Me.tabGeneral.Controls.Add(Me.Label3)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(640, 315)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'cboEstatus
        '
        Me.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstatus.FormattingEnabled = True
        Me.cboEstatus.Location = New System.Drawing.Point(411, 17)
        Me.cboEstatus.Name = "cboEstatus"
        Me.cboEstatus.Size = New System.Drawing.Size(199, 21)
        Me.cboEstatus.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(340, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Estatus :"
        '
        'btngengrabar
        '
        Me.btngengrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngengrabar.Location = New System.Drawing.Point(535, 272)
        Me.btngengrabar.Name = "btngengrabar"
        Me.btngengrabar.Size = New System.Drawing.Size(75, 23)
        Me.btngengrabar.TabIndex = 19
        Me.btngengrabar.Text = "Grabar"
        Me.btngengrabar.UseVisualStyleBackColor = True
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(343, 115)
        Me.txtComentario.MaxLength = 1000
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentario.Size = New System.Drawing.Size(267, 134)
        Me.txtComentario.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(340, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Comentarios :"
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(79, 221)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(127, 20)
        Me.txtIva.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(12, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "IVA :"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(79, 185)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(127, 20)
        Me.txtPrecio.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(12, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Precio :"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(79, 148)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(175, 21)
        Me.cboEmpresa.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Empresa :"
        '
        'cboPMP
        '
        Me.cboPMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPMP.FormattingEnabled = True
        Me.cboPMP.Location = New System.Drawing.Point(79, 115)
        Me.cboPMP.Name = "cboPMP"
        Me.cboPMP.Size = New System.Drawing.Size(224, 21)
        Me.cboPMP.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "PMP :"
        '
        'cboCliente
        '
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(79, 80)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(224, 21)
        Me.cboCliente.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Cliente :"
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(79, 20)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.ReadOnly = True
        Me.txtclave.Size = New System.Drawing.Size(100, 20)
        Me.txtclave.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Clave :"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(79, 46)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(433, 20)
        Me.txtnombre.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre :"
        '
        'tabPantallas
        '
        Me.tabPantallas.Controls.Add(Me.txttotpantallas)
        Me.tabPantallas.Controls.Add(Me.btnpantdetalle)
        Me.tabPantallas.Controls.Add(Me.btnpantload)
        Me.tabPantallas.Controls.Add(Me.btnpantdel)
        Me.tabPantallas.Controls.Add(Me.btnpantadd)
        Me.tabPantallas.Controls.Add(Me.gridpantallas)
        Me.tabPantallas.Controls.Add(Me.Label11)
        Me.tabPantallas.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.tabPantallas.Location = New System.Drawing.Point(4, 22)
        Me.tabPantallas.Name = "tabPantallas"
        Me.tabPantallas.Size = New System.Drawing.Size(640, 315)
        Me.tabPantallas.TabIndex = 3
        Me.tabPantallas.Text = "Pantallas"
        Me.tabPantallas.UseVisualStyleBackColor = True
        '
        'txttotpantallas
        '
        Me.txttotpantallas.Location = New System.Drawing.Point(184, 240)
        Me.txttotpantallas.Name = "txttotpantallas"
        Me.txttotpantallas.ReadOnly = True
        Me.txttotpantallas.Size = New System.Drawing.Size(356, 20)
        Me.txttotpantallas.TabIndex = 28
        Me.txttotpantallas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnpantdetalle
        '
        Me.btnpantdetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpantdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpantdetalle.Location = New System.Drawing.Point(89, 239)
        Me.btnpantdetalle.Name = "btnpantdetalle"
        Me.btnpantdetalle.Size = New System.Drawing.Size(89, 20)
        Me.btnpantdetalle.TabIndex = 27
        Me.btnpantdetalle.Text = "ver detalle"
        Me.btnpantdetalle.UseVisualStyleBackColor = True
        '
        'btnpantload
        '
        Me.btnpantload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpantload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpantload.Location = New System.Drawing.Point(36, 239)
        Me.btnpantload.Name = "btnpantload"
        Me.btnpantload.Size = New System.Drawing.Size(47, 20)
        Me.btnpantload.TabIndex = 26
        Me.btnpantload.Text = "load"
        Me.btnpantload.UseVisualStyleBackColor = True
        '
        'btnpantdel
        '
        Me.btnpantdel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpantdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpantdel.Location = New System.Drawing.Point(547, 240)
        Me.btnpantdel.Name = "btnpantdel"
        Me.btnpantdel.Size = New System.Drawing.Size(25, 20)
        Me.btnpantdel.TabIndex = 25
        Me.btnpantdel.Text = "-"
        Me.btnpantdel.UseVisualStyleBackColor = True
        '
        'btnpantadd
        '
        Me.btnpantadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpantadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpantadd.Location = New System.Drawing.Point(578, 240)
        Me.btnpantadd.Name = "btnpantadd"
        Me.btnpantadd.Size = New System.Drawing.Size(25, 20)
        Me.btnpantadd.TabIndex = 24
        Me.btnpantadd.Text = "+"
        Me.btnpantadd.UseVisualStyleBackColor = True
        '
        'gridpantallas
        '
        Me.gridpantallas.AllowUserToAddRows = False
        Me.gridpantallas.AllowUserToDeleteRows = False
        Me.gridpantallas.AllowUserToOrderColumns = True
        Me.gridpantallas.AllowUserToResizeRows = False
        Me.gridpantallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridpantallas.Location = New System.Drawing.Point(36, 65)
        Me.gridpantallas.Name = "gridpantallas"
        Me.gridpantallas.ReadOnly = True
        Me.gridpantallas.RowHeadersVisible = False
        Me.gridpantallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridpantallas.Size = New System.Drawing.Size(568, 168)
        Me.gridpantallas.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(37, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(567, 23)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "PANTALLAS"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabReportes
        '
        Me.tabReportes.Controls.Add(Me.gridreportes)
        Me.tabReportes.Controls.Add(Me.txttotreportes)
        Me.tabReportes.Controls.Add(Me.btnrepdetalle)
        Me.tabReportes.Controls.Add(Me.btnrepsload)
        Me.tabReportes.Controls.Add(Me.btnrepdel)
        Me.tabReportes.Controls.Add(Me.btnrepadd)
        Me.tabReportes.Controls.Add(Me.Label16)
        Me.tabReportes.Location = New System.Drawing.Point(4, 22)
        Me.tabReportes.Name = "tabReportes"
        Me.tabReportes.Size = New System.Drawing.Size(640, 315)
        Me.tabReportes.TabIndex = 7
        Me.tabReportes.Text = "Reportes"
        Me.tabReportes.UseVisualStyleBackColor = True
        '
        'gridreportes
        '
        Me.gridreportes.AllowUserToAddRows = False
        Me.gridreportes.AllowUserToDeleteRows = False
        Me.gridreportes.AllowUserToResizeRows = False
        Me.gridreportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridreportes.Location = New System.Drawing.Point(36, 74)
        Me.gridreportes.MultiSelect = False
        Me.gridreportes.Name = "gridreportes"
        Me.gridreportes.ReadOnly = True
        Me.gridreportes.RowHeadersVisible = False
        Me.gridreportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridreportes.Size = New System.Drawing.Size(568, 167)
        Me.gridreportes.TabIndex = 36
        '
        'txttotreportes
        '
        Me.txttotreportes.Location = New System.Drawing.Point(184, 248)
        Me.txttotreportes.Name = "txttotreportes"
        Me.txttotreportes.ReadOnly = True
        Me.txttotreportes.Size = New System.Drawing.Size(356, 20)
        Me.txttotreportes.TabIndex = 35
        Me.txttotreportes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnrepdetalle
        '
        Me.btnrepdetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrepdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrepdetalle.Location = New System.Drawing.Point(89, 247)
        Me.btnrepdetalle.Name = "btnrepdetalle"
        Me.btnrepdetalle.Size = New System.Drawing.Size(89, 20)
        Me.btnrepdetalle.TabIndex = 34
        Me.btnrepdetalle.Text = "ver detalle"
        Me.btnrepdetalle.UseVisualStyleBackColor = True
        '
        'btnrepsload
        '
        Me.btnrepsload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrepsload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrepsload.Location = New System.Drawing.Point(36, 247)
        Me.btnrepsload.Name = "btnrepsload"
        Me.btnrepsload.Size = New System.Drawing.Size(47, 20)
        Me.btnrepsload.TabIndex = 33
        Me.btnrepsload.Text = "load"
        Me.btnrepsload.UseVisualStyleBackColor = True
        '
        'btnrepdel
        '
        Me.btnrepdel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrepdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrepdel.Location = New System.Drawing.Point(547, 248)
        Me.btnrepdel.Name = "btnrepdel"
        Me.btnrepdel.Size = New System.Drawing.Size(25, 20)
        Me.btnrepdel.TabIndex = 32
        Me.btnrepdel.Text = "-"
        Me.btnrepdel.UseVisualStyleBackColor = True
        '
        'btnrepadd
        '
        Me.btnrepadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrepadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrepadd.Location = New System.Drawing.Point(578, 248)
        Me.btnrepadd.Name = "btnrepadd"
        Me.btnrepadd.Size = New System.Drawing.Size(25, 20)
        Me.btnrepadd.TabIndex = 31
        Me.btnrepadd.Text = "+"
        Me.btnrepadd.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(37, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(567, 23)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "REPORTES"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabdatos
        '
        Me.tabdatos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabdatos.Controls.Add(Me.txttotfuentes)
        Me.tabdatos.Controls.Add(Me.btnftedetalle)
        Me.tabdatos.Controls.Add(Me.btnfteload)
        Me.tabdatos.Controls.Add(Me.btndelfuente)
        Me.tabdatos.Controls.Add(Me.btnaddfuente)
        Me.tabdatos.Controls.Add(Me.dgvfuentedatos)
        Me.tabdatos.Controls.Add(Me.Label12)
        Me.tabdatos.Location = New System.Drawing.Point(4, 22)
        Me.tabdatos.Name = "tabdatos"
        Me.tabdatos.Size = New System.Drawing.Size(640, 315)
        Me.tabdatos.TabIndex = 4
        Me.tabdatos.Text = "Fuente de Datos"
        Me.tabdatos.UseVisualStyleBackColor = True
        '
        'txttotfuentes
        '
        Me.txttotfuentes.Location = New System.Drawing.Point(183, 240)
        Me.txttotfuentes.Name = "txttotfuentes"
        Me.txttotfuentes.ReadOnly = True
        Me.txttotfuentes.Size = New System.Drawing.Size(356, 20)
        Me.txttotfuentes.TabIndex = 38
        Me.txttotfuentes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnftedetalle
        '
        Me.btnftedetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnftedetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnftedetalle.Location = New System.Drawing.Point(88, 239)
        Me.btnftedetalle.Name = "btnftedetalle"
        Me.btnftedetalle.Size = New System.Drawing.Size(89, 20)
        Me.btnftedetalle.TabIndex = 37
        Me.btnftedetalle.Text = "ver detalle"
        Me.btnftedetalle.UseVisualStyleBackColor = True
        '
        'btnfteload
        '
        Me.btnfteload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfteload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfteload.Location = New System.Drawing.Point(35, 239)
        Me.btnfteload.Name = "btnfteload"
        Me.btnfteload.Size = New System.Drawing.Size(47, 20)
        Me.btnfteload.TabIndex = 36
        Me.btnfteload.Text = "load"
        Me.btnfteload.UseVisualStyleBackColor = True
        '
        'btndelfuente
        '
        Me.btndelfuente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelfuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelfuente.Location = New System.Drawing.Point(548, 239)
        Me.btndelfuente.Name = "btndelfuente"
        Me.btndelfuente.Size = New System.Drawing.Size(25, 20)
        Me.btndelfuente.TabIndex = 29
        Me.btndelfuente.Text = "-"
        Me.btndelfuente.UseVisualStyleBackColor = True
        '
        'btnaddfuente
        '
        Me.btnaddfuente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnaddfuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddfuente.Location = New System.Drawing.Point(579, 239)
        Me.btnaddfuente.Name = "btnaddfuente"
        Me.btnaddfuente.Size = New System.Drawing.Size(25, 20)
        Me.btnaddfuente.TabIndex = 28
        Me.btnaddfuente.Text = "+"
        Me.btnaddfuente.UseVisualStyleBackColor = True
        '
        'dgvfuentedatos
        '
        Me.dgvfuentedatos.AllowUserToAddRows = False
        Me.dgvfuentedatos.AllowUserToDeleteRows = False
        Me.dgvfuentedatos.AllowUserToResizeRows = False
        Me.dgvfuentedatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvfuentedatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfuentedatos.Location = New System.Drawing.Point(37, 83)
        Me.dgvfuentedatos.MultiSelect = False
        Me.dgvfuentedatos.Name = "dgvfuentedatos"
        Me.dgvfuentedatos.ReadOnly = True
        Me.dgvfuentedatos.RowHeadersVisible = False
        Me.dgvfuentedatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvfuentedatos.Size = New System.Drawing.Size(567, 150)
        Me.dgvfuentedatos.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(37, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(567, 23)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "FUENTE DE DATOS"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabNavegacion
        '
        Me.tabNavegacion.Controls.Add(Me.txtnavegacion)
        Me.tabNavegacion.Controls.Add(Me.btnavdetalle)
        Me.tabNavegacion.Controls.Add(Me.btnavload)
        Me.tabNavegacion.Controls.Add(Me.btnavdel)
        Me.tabNavegacion.Controls.Add(Me.btnavadd)
        Me.tabNavegacion.Controls.Add(Me.gridNavegacion)
        Me.tabNavegacion.Controls.Add(Me.Label17)
        Me.tabNavegacion.Location = New System.Drawing.Point(4, 22)
        Me.tabNavegacion.Name = "tabNavegacion"
        Me.tabNavegacion.Size = New System.Drawing.Size(640, 315)
        Me.tabNavegacion.TabIndex = 8
        Me.tabNavegacion.Text = "Navegación"
        Me.tabNavegacion.UseVisualStyleBackColor = True
        '
        'txtnavegacion
        '
        Me.txtnavegacion.Location = New System.Drawing.Point(189, 278)
        Me.txtnavegacion.Name = "txtnavegacion"
        Me.txtnavegacion.ReadOnly = True
        Me.txtnavegacion.Size = New System.Drawing.Size(356, 20)
        Me.txtnavegacion.TabIndex = 42
        Me.txtnavegacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnavdetalle
        '
        Me.btnavdetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnavdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnavdetalle.Location = New System.Drawing.Point(94, 277)
        Me.btnavdetalle.Name = "btnavdetalle"
        Me.btnavdetalle.Size = New System.Drawing.Size(89, 20)
        Me.btnavdetalle.TabIndex = 41
        Me.btnavdetalle.Text = "ver detalle"
        Me.btnavdetalle.UseVisualStyleBackColor = True
        '
        'btnavload
        '
        Me.btnavload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnavload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnavload.Location = New System.Drawing.Point(41, 277)
        Me.btnavload.Name = "btnavload"
        Me.btnavload.Size = New System.Drawing.Size(47, 20)
        Me.btnavload.TabIndex = 40
        Me.btnavload.Text = "load"
        Me.btnavload.UseVisualStyleBackColor = True
        '
        'btnavdel
        '
        Me.btnavdel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnavdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnavdel.Location = New System.Drawing.Point(552, 277)
        Me.btnavdel.Name = "btnavdel"
        Me.btnavdel.Size = New System.Drawing.Size(25, 20)
        Me.btnavdel.TabIndex = 39
        Me.btnavdel.Text = "-"
        Me.btnavdel.UseVisualStyleBackColor = True
        '
        'btnavadd
        '
        Me.btnavadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnavadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnavadd.Location = New System.Drawing.Point(583, 277)
        Me.btnavadd.Name = "btnavadd"
        Me.btnavadd.Size = New System.Drawing.Size(25, 20)
        Me.btnavadd.TabIndex = 38
        Me.btnavadd.Text = "+"
        Me.btnavadd.UseVisualStyleBackColor = True
        '
        'gridNavegacion
        '
        Me.gridNavegacion.AllowUserToAddRows = False
        Me.gridNavegacion.AllowUserToDeleteRows = False
        Me.gridNavegacion.AllowUserToOrderColumns = True
        Me.gridNavegacion.AllowUserToResizeRows = False
        Me.gridNavegacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridNavegacion.Location = New System.Drawing.Point(39, 40)
        Me.gridNavegacion.MultiSelect = False
        Me.gridNavegacion.Name = "gridNavegacion"
        Me.gridNavegacion.ReadOnly = True
        Me.gridNavegacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridNavegacion.Size = New System.Drawing.Size(567, 231)
        Me.gridNavegacion.TabIndex = 37
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(39, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(567, 23)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "NAVEGACIÓN"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(578, 11)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 410)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtmainame)
        Me.Controls.Add(Me.txtmainclave)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProyecto"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GENARO - Información de un Proyecto"
        Me.TabControl1.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.tabPantallas.ResumeLayout(False)
        Me.tabPantallas.PerformLayout()
        CType(Me.gridpantallas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReportes.ResumeLayout(False)
        Me.tabReportes.PerformLayout()
        CType(Me.gridreportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabdatos.ResumeLayout(False)
        Me.tabdatos.PerformLayout()
        CType(Me.dgvfuentedatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNavegacion.ResumeLayout(False)
        Me.tabNavegacion.PerformLayout()
        CType(Me.gridNavegacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmainclave As System.Windows.Forms.TextBox
    Friend WithEvents txtmainame As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabPantallas As System.Windows.Forms.TabPage
    Friend WithEvents tabdatos As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboPMP As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btngengrabar As System.Windows.Forms.Button
    Friend WithEvents gridpantallas As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btndelfuente As System.Windows.Forms.Button
    Friend WithEvents btnaddfuente As System.Windows.Forms.Button
    Friend WithEvents dgvfuentedatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnpantdetalle As System.Windows.Forms.Button
    Friend WithEvents btnpantload As System.Windows.Forms.Button
    Friend WithEvents btnpantdel As System.Windows.Forms.Button
    Friend WithEvents btnpantadd As System.Windows.Forms.Button
    Friend WithEvents txttotpantallas As System.Windows.Forms.TextBox
    Friend WithEvents tabReportes As System.Windows.Forms.TabPage
    Friend WithEvents txttotreportes As System.Windows.Forms.TextBox
    Friend WithEvents btnrepdetalle As System.Windows.Forms.Button
    Friend WithEvents btnrepsload As System.Windows.Forms.Button
    Friend WithEvents btnrepdel As System.Windows.Forms.Button
    Friend WithEvents btnrepadd As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents gridreportes As System.Windows.Forms.DataGridView
    Friend WithEvents cboEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txttotfuentes As System.Windows.Forms.TextBox
    Friend WithEvents btnftedetalle As System.Windows.Forms.Button
    Friend WithEvents btnfteload As System.Windows.Forms.Button
    Friend WithEvents tabNavegacion As System.Windows.Forms.TabPage
    Friend WithEvents gridNavegacion As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnavdel As System.Windows.Forms.Button
    Friend WithEvents btnavadd As System.Windows.Forms.Button
    Friend WithEvents txtnavegacion As System.Windows.Forms.TextBox
    Friend WithEvents btnavdetalle As System.Windows.Forms.Button
    Friend WithEvents btnavload As System.Windows.Forms.Button

End Class
