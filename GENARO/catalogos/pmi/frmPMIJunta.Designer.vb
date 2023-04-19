<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPMIJunta
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
        Me.txtlugar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtComent = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtObjetivo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboEstatus = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btngrabar = New System.Windows.Forms.Button()
        Me.tabacuerdos = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tabtareas = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gridtareas = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabparticipa = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cbodetalle = New System.Windows.Forms.Button()
        Me.btnjuntasload = New System.Windows.Forms.Button()
        Me.btnoneout = New System.Windows.Forms.Button()
        Me.btnonein = New System.Windows.Forms.Button()
        Me.btnallout = New System.Windows.Forms.Button()
        Me.btnallin = New System.Windows.Forms.Button()
        Me.lstparticipa = New System.Windows.Forms.ListBox()
        Me.lstholders = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnbproyecto = New System.Windows.Forms.TextBox()
        Me.txtcdproyecto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtnbjunta = New System.Windows.Forms.TextBox()
        Me.txtcdjunta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabgeneral.SuspendLayout()
        Me.tabacuerdos.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabtareas.SuspendLayout()
        CType(Me.gridtareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabparticipa.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabgeneral)
        Me.TabControl1.Controls.Add(Me.tabacuerdos)
        Me.TabControl1.Controls.Add(Me.tabtareas)
        Me.TabControl1.Controls.Add(Me.tabparticipa)
        Me.TabControl1.Location = New System.Drawing.Point(12, 78)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(607, 306)
        Me.TabControl1.TabIndex = 0
        '
        'tabgeneral
        '
        Me.tabgeneral.Controls.Add(Me.txtlugar)
        Me.tabgeneral.Controls.Add(Me.Label11)
        Me.tabgeneral.Controls.Add(Me.txtComent)
        Me.tabgeneral.Controls.Add(Me.Label8)
        Me.tabgeneral.Controls.Add(Me.txtObjetivo)
        Me.tabgeneral.Controls.Add(Me.Label7)
        Me.tabgeneral.Controls.Add(Me.txtfecha)
        Me.tabgeneral.Controls.Add(Me.Label6)
        Me.tabgeneral.Controls.Add(Me.cbotipo)
        Me.tabgeneral.Controls.Add(Me.Label5)
        Me.tabgeneral.Controls.Add(Me.cboEstatus)
        Me.tabgeneral.Controls.Add(Me.Label15)
        Me.tabgeneral.Controls.Add(Me.txtclave)
        Me.tabgeneral.Controls.Add(Me.Label4)
        Me.tabgeneral.Controls.Add(Me.txtnombre)
        Me.tabgeneral.Controls.Add(Me.Label3)
        Me.tabgeneral.Controls.Add(Me.btngrabar)
        Me.tabgeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabgeneral.Name = "tabgeneral"
        Me.tabgeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabgeneral.Size = New System.Drawing.Size(599, 280)
        Me.tabgeneral.TabIndex = 0
        Me.tabgeneral.Text = "General"
        Me.tabgeneral.UseVisualStyleBackColor = True
        '
        'txtlugar
        '
        Me.txtlugar.Location = New System.Drawing.Point(414, 44)
        Me.txtlugar.MaxLength = 60
        Me.txtlugar.Name = "txtlugar"
        Me.txtlugar.Size = New System.Drawing.Size(156, 20)
        Me.txtlugar.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(368, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Lugar :"
        '
        'txtComent
        '
        Me.txtComent.Location = New System.Drawing.Point(371, 135)
        Me.txtComent.MaxLength = 1000
        Me.txtComent.Multiline = True
        Me.txtComent.Name = "txtComent"
        Me.txtComent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComent.Size = New System.Drawing.Size(199, 134)
        Me.txtComent.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(294, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Comentarios :"
        '
        'txtObjetivo
        '
        Me.txtObjetivo.Location = New System.Drawing.Point(79, 135)
        Me.txtObjetivo.MaxLength = 1000
        Me.txtObjetivo.Multiline = True
        Me.txtObjetivo.Name = "txtObjetivo"
        Me.txtObjetivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObjetivo.Size = New System.Drawing.Size(199, 134)
        Me.txtObjetivo.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(14, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Objetivo :"
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(447, 101)
        Me.txtfecha.MaxLength = 20
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(123, 20)
        Me.txtfecha.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(368, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Fecha y Hora:"
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Items.AddRange(New Object() {"01 - PRESENTACION", "02 - ALCANCE", "03 - ANALISIS", "04 - DEFINICION", "05 - SEGUIMIENTO", "06 - CIERRE / TERMINO"})
        Me.cbotipo.Location = New System.Drawing.Point(79, 44)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(199, 21)
        Me.cbotipo.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Tipo :"
        '
        'cboEstatus
        '
        Me.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstatus.FormattingEnabled = True
        Me.cboEstatus.Items.AddRange(New Object() {"PE - PENDIENTE POR REALIZAR", "RE - REALIZADA", "CA - CANCELADA"})
        Me.cboEstatus.Location = New System.Drawing.Point(79, 101)
        Me.cboEstatus.Name = "cboEstatus"
        Me.cboEstatus.Size = New System.Drawing.Size(199, 21)
        Me.cboEstatus.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(14, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Estatus :"
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(79, 14)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.ReadOnly = True
        Me.txtclave.Size = New System.Drawing.Size(100, 20)
        Me.txtclave.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(14, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Clave :"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(79, 72)
        Me.txtnombre.MaxLength = 60
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(491, 20)
        Me.txtnombre.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(14, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nombre :"
        '
        'btngrabar
        '
        Me.btngrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngrabar.Location = New System.Drawing.Point(495, 12)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(75, 23)
        Me.btngrabar.TabIndex = 20
        Me.btngrabar.Text = "Grabar"
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'tabacuerdos
        '
        Me.tabacuerdos.Controls.Add(Me.Button7)
        Me.tabacuerdos.Controls.Add(Me.Button8)
        Me.tabacuerdos.Controls.Add(Me.DataGridView5)
        Me.tabacuerdos.Controls.Add(Me.Label13)
        Me.tabacuerdos.Location = New System.Drawing.Point(4, 22)
        Me.tabacuerdos.Name = "tabacuerdos"
        Me.tabacuerdos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabacuerdos.Size = New System.Drawing.Size(599, 280)
        Me.tabacuerdos.TabIndex = 1
        Me.tabacuerdos.Text = "Acuerdos"
        Me.tabacuerdos.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(527, 222)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(25, 20)
        Me.Button7.TabIndex = 37
        Me.Button7.Text = "-"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(558, 222)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(25, 20)
        Me.Button8.TabIndex = 36
        Me.Button8.Text = "+"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(16, 66)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(567, 150)
        Me.DataGridView5.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(16, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(567, 23)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "ACUERDOS"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabtareas
        '
        Me.tabtareas.Controls.Add(Me.Button1)
        Me.tabtareas.Controls.Add(Me.Button2)
        Me.tabtareas.Controls.Add(Me.gridtareas)
        Me.tabtareas.Controls.Add(Me.Label9)
        Me.tabtareas.Location = New System.Drawing.Point(4, 22)
        Me.tabtareas.Name = "tabtareas"
        Me.tabtareas.Size = New System.Drawing.Size(599, 280)
        Me.tabtareas.TabIndex = 2
        Me.tabtareas.Text = "Tareas"
        Me.tabtareas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(527, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 20)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(558, 222)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 20)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'gridtareas
        '
        Me.gridtareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridtareas.Location = New System.Drawing.Point(16, 66)
        Me.gridtareas.Name = "gridtareas"
        Me.gridtareas.Size = New System.Drawing.Size(567, 150)
        Me.gridtareas.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(16, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(567, 23)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "TAREAS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabparticipa
        '
        Me.tabparticipa.Controls.Add(Me.Button3)
        Me.tabparticipa.Controls.Add(Me.cbodetalle)
        Me.tabparticipa.Controls.Add(Me.btnjuntasload)
        Me.tabparticipa.Controls.Add(Me.btnoneout)
        Me.tabparticipa.Controls.Add(Me.btnonein)
        Me.tabparticipa.Controls.Add(Me.btnallout)
        Me.tabparticipa.Controls.Add(Me.btnallin)
        Me.tabparticipa.Controls.Add(Me.lstparticipa)
        Me.tabparticipa.Controls.Add(Me.lstholders)
        Me.tabparticipa.Controls.Add(Me.Label12)
        Me.tabparticipa.Controls.Add(Me.Label10)
        Me.tabparticipa.Location = New System.Drawing.Point(4, 22)
        Me.tabparticipa.Name = "tabparticipa"
        Me.tabparticipa.Size = New System.Drawing.Size(599, 280)
        Me.tabparticipa.TabIndex = 3
        Me.tabparticipa.Text = "Participantes"
        Me.tabparticipa.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(512, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "Grabar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cbodetalle
        '
        Me.cbodetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbodetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodetalle.Location = New System.Drawing.Point(277, 217)
        Me.cbodetalle.Name = "cbodetalle"
        Me.cbodetalle.Size = New System.Drawing.Size(86, 20)
        Me.cbodetalle.TabIndex = 48
        Me.cbodetalle.Text = "ver detalle"
        Me.cbodetalle.UseVisualStyleBackColor = True
        '
        'btnjuntasload
        '
        Me.btnjuntasload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnjuntasload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjuntasload.Location = New System.Drawing.Point(512, 55)
        Me.btnjuntasload.Name = "btnjuntasload"
        Me.btnjuntasload.Size = New System.Drawing.Size(75, 22)
        Me.btnjuntasload.TabIndex = 47
        Me.btnjuntasload.Text = "load"
        Me.btnjuntasload.UseVisualStyleBackColor = True
        '
        'btnoneout
        '
        Me.btnoneout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnoneout.Location = New System.Drawing.Point(227, 80)
        Me.btnoneout.Name = "btnoneout"
        Me.btnoneout.Size = New System.Drawing.Size(29, 23)
        Me.btnoneout.TabIndex = 46
        Me.btnoneout.Text = "<"
        Me.btnoneout.UseVisualStyleBackColor = True
        '
        'btnonein
        '
        Me.btnonein.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnonein.Location = New System.Drawing.Point(227, 51)
        Me.btnonein.Name = "btnonein"
        Me.btnonein.Size = New System.Drawing.Size(29, 23)
        Me.btnonein.TabIndex = 45
        Me.btnonein.Text = ">"
        Me.btnonein.UseVisualStyleBackColor = True
        '
        'btnallout
        '
        Me.btnallout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnallout.Location = New System.Drawing.Point(227, 138)
        Me.btnallout.Name = "btnallout"
        Me.btnallout.Size = New System.Drawing.Size(29, 23)
        Me.btnallout.TabIndex = 44
        Me.btnallout.Text = "<<"
        Me.btnallout.UseVisualStyleBackColor = True
        '
        'btnallin
        '
        Me.btnallin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnallin.Location = New System.Drawing.Point(227, 109)
        Me.btnallin.Name = "btnallin"
        Me.btnallin.Size = New System.Drawing.Size(29, 23)
        Me.btnallin.TabIndex = 43
        Me.btnallin.Text = ">>"
        Me.btnallin.UseVisualStyleBackColor = True
        '
        'lstparticipa
        '
        Me.lstparticipa.FormattingEnabled = True
        Me.lstparticipa.Location = New System.Drawing.Point(277, 51)
        Me.lstparticipa.Name = "lstparticipa"
        Me.lstparticipa.Size = New System.Drawing.Size(187, 160)
        Me.lstparticipa.TabIndex = 42
        '
        'lstholders
        '
        Me.lstholders.FormattingEnabled = True
        Me.lstholders.Location = New System.Drawing.Point(24, 51)
        Me.lstholders.Name = "lstholders"
        Me.lstholders.Size = New System.Drawing.Size(187, 186)
        Me.lstholders.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(24, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(187, 23)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "STEACKHOLDERS"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(277, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(187, 23)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "PARTICIPANTES"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnbproyecto
        '
        Me.txtnbproyecto.Location = New System.Drawing.Point(163, 16)
        Me.txtnbproyecto.Name = "txtnbproyecto"
        Me.txtnbproyecto.ReadOnly = True
        Me.txtnbproyecto.Size = New System.Drawing.Size(359, 20)
        Me.txtnbproyecto.TabIndex = 11
        '
        'txtcdproyecto
        '
        Me.txtcdproyecto.Location = New System.Drawing.Point(82, 16)
        Me.txtcdproyecto.Name = "txtcdproyecto"
        Me.txtcdproyecto.ReadOnly = True
        Me.txtcdproyecto.Size = New System.Drawing.Size(75, 20)
        Me.txtcdproyecto.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Proyecto :"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(528, 14)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtnbjunta
        '
        Me.txtnbjunta.Location = New System.Drawing.Point(163, 43)
        Me.txtnbjunta.Name = "txtnbjunta"
        Me.txtnbjunta.ReadOnly = True
        Me.txtnbjunta.Size = New System.Drawing.Size(359, 20)
        Me.txtnbjunta.TabIndex = 15
        '
        'txtcdjunta
        '
        Me.txtcdjunta.Location = New System.Drawing.Point(82, 43)
        Me.txtcdjunta.Name = "txtcdjunta"
        Me.txtcdjunta.ReadOnly = True
        Me.txtcdjunta.Size = New System.Drawing.Size(75, 20)
        Me.txtcdjunta.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Junta :"
        '
        'frmPMIJunta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 396)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtnbjunta)
        Me.Controls.Add(Me.txtcdjunta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtnbproyecto)
        Me.Controls.Add(Me.txtcdproyecto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPMIJunta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Junta"
        Me.TabControl1.ResumeLayout(False)
        Me.tabgeneral.ResumeLayout(False)
        Me.tabgeneral.PerformLayout()
        Me.tabacuerdos.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabtareas.ResumeLayout(False)
        CType(Me.gridtareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabparticipa.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabgeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabacuerdos As System.Windows.Forms.TabPage
    Friend WithEvents txtnbproyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtcdproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabtareas As System.Windows.Forms.TabPage
    Friend WithEvents tabparticipa As System.Windows.Forms.TabPage
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtnbjunta As System.Windows.Forms.TextBox
    Friend WithEvents txtcdjunta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtComent As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtObjetivo As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents gridtareas As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtlugar As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lstparticipa As System.Windows.Forms.ListBox
    Friend WithEvents lstholders As System.Windows.Forms.ListBox
    Friend WithEvents btnallout As System.Windows.Forms.Button
    Friend WithEvents btnallin As System.Windows.Forms.Button
    Friend WithEvents btnoneout As System.Windows.Forms.Button
    Friend WithEvents btnonein As System.Windows.Forms.Button
    Friend WithEvents btnjuntasload As System.Windows.Forms.Button
    Friend WithEvents cbodetalle As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
