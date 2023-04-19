<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrontWizSyncProyCGI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFrontWizSyncProyCGI))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btnterminar = New System.Windows.Forms.Button()
        Me.grbpaso3 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.chksubdirectorios = New System.Windows.Forms.CheckBox()
        Me.cboestilo = New System.Windows.Forms.ComboBox()
        Me.btnexaminar = New System.Windows.Forms.Button()
        Me.txtdirectory = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grbpaso4 = New System.Windows.Forms.GroupBox()
        Me.lblextension = New System.Windows.Forms.Label()
        Me.btnleerdir = New System.Windows.Forms.Button()
        Me.chkselectall = New System.Windows.Forms.CheckBox()
        Me.clbArchivos = New System.Windows.Forms.CheckedListBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.grbpaso2 = New System.Windows.Forms.GroupBox()
        Me.lblnvoestilo = New System.Windows.Forms.Label()
        Me.cboFrontEnd = New System.Windows.Forms.ComboBox()
        Me.txtsincronia = New System.Windows.Forms.TextBox()
        Me.radNueva = New System.Windows.Forms.RadioButton()
        Me.radExiste = New System.Windows.Forms.RadioButton()
        Me.cbosincronia = New System.Windows.Forms.ComboBox()
        Me.grbpaso6 = New System.Windows.Forms.GroupBox()
        Me.btnstaffload = New System.Windows.Forms.Button()
        Me.txtpantallas = New System.Windows.Forms.TextBox()
        Me.gridpantalla = New System.Windows.Forms.DataGridView()
        Me.btnsync = New System.Windows.Forms.Button()
        Me.grbpaso5 = New System.Windows.Forms.GroupBox()
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.prbarmado = New System.Windows.Forms.ProgressBar()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.grbpaso1 = New System.Windows.Forms.GroupBox()
        Me.cboproyecto = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grbpaso3.SuspendLayout()
        Me.grbpaso4.SuspendLayout()
        Me.grbpaso2.SuspendLayout()
        Me.grbpaso6.SuspendLayout()
        CType(Me.gridpantalla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso5.SuspendLayout()
        Me.grbpaso1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 8)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(194, 121)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 28
        Me.LogoPictureBox.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.19231!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.80769!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnsiguiente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnanterior, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnterminar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(374, 267)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(393, 35)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsiguiente.Location = New System.Drawing.Point(104, 6)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(81, 23)
        Me.btnsiguiente.TabIndex = 2
        Me.btnsiguiente.Text = "Siguiente >"
        '
        'btnanterior
        '
        Me.btnanterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnanterior.Location = New System.Drawing.Point(11, 6)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(67, 23)
        Me.btnanterior.TabIndex = 0
        Me.btnanterior.Text = "< Regresar"
        '
        'btnterminar
        '
        Me.btnterminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnterminar.Location = New System.Drawing.Point(255, 6)
        Me.btnterminar.Name = "btnterminar"
        Me.btnterminar.Size = New System.Drawing.Size(81, 23)
        Me.btnterminar.TabIndex = 1
        Me.btnterminar.Text = "Terminar"
        '
        'grbpaso3
        '
        Me.grbpaso3.Controls.Add(Me.TextBox5)
        Me.grbpaso3.Controls.Add(Me.chksubdirectorios)
        Me.grbpaso3.Controls.Add(Me.cboestilo)
        Me.grbpaso3.Controls.Add(Me.btnexaminar)
        Me.grbpaso3.Controls.Add(Me.txtdirectory)
        Me.grbpaso3.Controls.Add(Me.TextBox1)
        Me.grbpaso3.Location = New System.Drawing.Point(212, 12)
        Me.grbpaso3.Name = "grbpaso3"
        Me.grbpaso3.Size = New System.Drawing.Size(555, 244)
        Me.grbpaso3.TabIndex = 37
        Me.grbpaso3.TabStop = False
        Me.grbpaso3.Text = " PASO 3:  Busqueda de programas fuente "
        Me.grbpaso3.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(7, 151)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(363, 25)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.Text = "¿ Que estilo de documentación tiene los programas fuente del directorio ? "
        '
        'chksubdirectorios
        '
        Me.chksubdirectorios.AutoSize = True
        Me.chksubdirectorios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chksubdirectorios.Location = New System.Drawing.Point(418, 89)
        Me.chksubdirectorios.Name = "chksubdirectorios"
        Me.chksubdirectorios.Size = New System.Drawing.Size(120, 17)
        Me.chksubdirectorios.TabIndex = 7
        Me.chksubdirectorios.Text = "Incluir subdirectorios"
        Me.chksubdirectorios.UseVisualStyleBackColor = True
        '
        'cboestilo
        '
        Me.cboestilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboestilo.FormattingEnabled = True
        Me.cboestilo.Location = New System.Drawing.Point(6, 182)
        Me.cboestilo.Name = "cboestilo"
        Me.cboestilo.Size = New System.Drawing.Size(531, 21)
        Me.cboestilo.TabIndex = 6
        '
        'btnexaminar
        '
        Me.btnexaminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexaminar.Location = New System.Drawing.Point(6, 98)
        Me.btnexaminar.Name = "btnexaminar"
        Me.btnexaminar.Size = New System.Drawing.Size(113, 23)
        Me.btnexaminar.TabIndex = 4
        Me.btnexaminar.Text = "Examinar..."
        Me.btnexaminar.UseVisualStyleBackColor = True
        '
        'txtdirectory
        '
        Me.txtdirectory.Location = New System.Drawing.Point(6, 63)
        Me.txtdirectory.Name = "txtdirectory"
        Me.txtdirectory.ReadOnly = True
        Me.txtdirectory.Size = New System.Drawing.Size(531, 20)
        Me.txtdirectory.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(363, 33)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Seleccione el directorio desde donde serán tomados los programas fuente."
        '
        'grbpaso4
        '
        Me.grbpaso4.Controls.Add(Me.lblextension)
        Me.grbpaso4.Controls.Add(Me.btnleerdir)
        Me.grbpaso4.Controls.Add(Me.chkselectall)
        Me.grbpaso4.Controls.Add(Me.clbArchivos)
        Me.grbpaso4.Controls.Add(Me.TextBox3)
        Me.grbpaso4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grbpaso4.Location = New System.Drawing.Point(212, 9)
        Me.grbpaso4.Name = "grbpaso4"
        Me.grbpaso4.Size = New System.Drawing.Size(555, 247)
        Me.grbpaso4.TabIndex = 42
        Me.grbpaso4.TabStop = False
        Me.grbpaso4.Text = " PASO 4:  Selección de Código Fuente "
        Me.grbpaso4.Visible = False
        '
        'lblextension
        '
        Me.lblextension.AutoSize = True
        Me.lblextension.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblextension.Location = New System.Drawing.Point(17, 45)
        Me.lblextension.Name = "lblextension"
        Me.lblextension.Size = New System.Drawing.Size(56, 13)
        Me.lblextension.TabIndex = 7
        Me.lblextension.Text = "Extensión "
        '
        'btnleerdir
        '
        Me.btnleerdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnleerdir.Location = New System.Drawing.Point(446, 41)
        Me.btnleerdir.Name = "btnleerdir"
        Me.btnleerdir.Size = New System.Drawing.Size(91, 23)
        Me.btnleerdir.TabIndex = 3
        Me.btnleerdir.Text = "Leer Directorio"
        Me.btnleerdir.UseVisualStyleBackColor = True
        '
        'chkselectall
        '
        Me.chkselectall.AutoSize = True
        Me.chkselectall.Location = New System.Drawing.Point(18, 220)
        Me.chkselectall.Name = "chkselectall"
        Me.chkselectall.Size = New System.Drawing.Size(106, 17)
        Me.chkselectall.TabIndex = 2
        Me.chkselectall.Text = "Seleccionar todo"
        Me.chkselectall.UseVisualStyleBackColor = True
        '
        'clbArchivos
        '
        Me.clbArchivos.FormattingEnabled = True
        Me.clbArchivos.Location = New System.Drawing.Point(18, 63)
        Me.clbArchivos.Name = "clbArchivos"
        Me.clbArchivos.Size = New System.Drawing.Size(519, 154)
        Me.clbArchivos.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(18, 18)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(519, 24)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = "De esta lista de programas fuente, seleccione aquellos archivos que participaran " & _
            "en la incorporación."
        '
        'grbpaso2
        '
        Me.grbpaso2.Controls.Add(Me.lblnvoestilo)
        Me.grbpaso2.Controls.Add(Me.cboFrontEnd)
        Me.grbpaso2.Controls.Add(Me.txtsincronia)
        Me.grbpaso2.Controls.Add(Me.radNueva)
        Me.grbpaso2.Controls.Add(Me.radExiste)
        Me.grbpaso2.Controls.Add(Me.cbosincronia)
        Me.grbpaso2.Location = New System.Drawing.Point(212, 12)
        Me.grbpaso2.Name = "grbpaso2"
        Me.grbpaso2.Size = New System.Drawing.Size(555, 244)
        Me.grbpaso2.TabIndex = 43
        Me.grbpaso2.TabStop = False
        Me.grbpaso2.Text = " PASO 2: Seleccione la sincronización"
        Me.grbpaso2.Visible = False
        '
        'lblnvoestilo
        '
        Me.lblnvoestilo.AutoSize = True
        Me.lblnvoestilo.Enabled = False
        Me.lblnvoestilo.Location = New System.Drawing.Point(9, 163)
        Me.lblnvoestilo.Name = "lblnvoestilo"
        Me.lblnvoestilo.Size = New System.Drawing.Size(281, 13)
        Me.lblnvoestilo.TabIndex = 20
        Me.lblnvoestilo.Text = "¿ En que estilo se generan los programas del front - end ? "
        '
        'cboFrontEnd
        '
        Me.cboFrontEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFrontEnd.Enabled = False
        Me.cboFrontEnd.FormattingEnabled = True
        Me.cboFrontEnd.Location = New System.Drawing.Point(12, 182)
        Me.cboFrontEnd.Name = "cboFrontEnd"
        Me.cboFrontEnd.Size = New System.Drawing.Size(357, 21)
        Me.cboFrontEnd.TabIndex = 18
        '
        'txtsincronia
        '
        Me.txtsincronia.Enabled = False
        Me.txtsincronia.Location = New System.Drawing.Point(86, 124)
        Me.txtsincronia.MaxLength = 60
        Me.txtsincronia.Name = "txtsincronia"
        Me.txtsincronia.Size = New System.Drawing.Size(451, 20)
        Me.txtsincronia.TabIndex = 17
        '
        'radNueva
        '
        Me.radNueva.AutoSize = True
        Me.radNueva.Location = New System.Drawing.Point(12, 127)
        Me.radNueva.Name = "radNueva"
        Me.radNueva.Size = New System.Drawing.Size(57, 17)
        Me.radNueva.TabIndex = 13
        Me.radNueva.Text = "Nueva"
        Me.radNueva.UseVisualStyleBackColor = True
        '
        'radExiste
        '
        Me.radExiste.AutoSize = True
        Me.radExiste.Checked = True
        Me.radExiste.Location = New System.Drawing.Point(12, 40)
        Me.radExiste.Name = "radExiste"
        Me.radExiste.Size = New System.Drawing.Size(68, 17)
        Me.radExiste.TabIndex = 12
        Me.radExiste.TabStop = True
        Me.radExiste.Text = "Existente"
        Me.radExiste.UseVisualStyleBackColor = True
        '
        'cbosincronia
        '
        Me.cbosincronia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosincronia.FormattingEnabled = True
        Me.cbosincronia.Location = New System.Drawing.Point(86, 39)
        Me.cbosincronia.Name = "cbosincronia"
        Me.cbosincronia.Size = New System.Drawing.Size(451, 21)
        Me.cbosincronia.TabIndex = 10
        '
        'grbpaso6
        '
        Me.grbpaso6.Controls.Add(Me.btnstaffload)
        Me.grbpaso6.Controls.Add(Me.txtpantallas)
        Me.grbpaso6.Controls.Add(Me.gridpantalla)
        Me.grbpaso6.Controls.Add(Me.btnsync)
        Me.grbpaso6.Location = New System.Drawing.Point(212, 8)
        Me.grbpaso6.Name = "grbpaso6"
        Me.grbpaso6.Size = New System.Drawing.Size(555, 253)
        Me.grbpaso6.TabIndex = 44
        Me.grbpaso6.TabStop = False
        Me.grbpaso6.Text = " PASO 6: Sincronización por Pantalla"
        Me.grbpaso6.Visible = False
        '
        'btnstaffload
        '
        Me.btnstaffload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstaffload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstaffload.Location = New System.Drawing.Point(7, 222)
        Me.btnstaffload.Name = "btnstaffload"
        Me.btnstaffload.Size = New System.Drawing.Size(47, 20)
        Me.btnstaffload.TabIndex = 32
        Me.btnstaffload.Text = "load"
        Me.btnstaffload.UseVisualStyleBackColor = True
        '
        'txtpantallas
        '
        Me.txtpantallas.Location = New System.Drawing.Point(133, 223)
        Me.txtpantallas.Name = "txtpantallas"
        Me.txtpantallas.ReadOnly = True
        Me.txtpantallas.Size = New System.Drawing.Size(416, 20)
        Me.txtpantallas.TabIndex = 31
        Me.txtpantallas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gridpantalla
        '
        Me.gridpantalla.AllowUserToAddRows = False
        Me.gridpantalla.AllowUserToDeleteRows = False
        Me.gridpantalla.AllowUserToResizeRows = False
        Me.gridpantalla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridpantalla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridpantalla.Location = New System.Drawing.Point(7, 21)
        Me.gridpantalla.MultiSelect = False
        Me.gridpantalla.Name = "gridpantalla"
        Me.gridpantalla.ReadOnly = True
        Me.gridpantalla.RowHeadersVisible = False
        Me.gridpantalla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridpantalla.Size = New System.Drawing.Size(542, 200)
        Me.gridpantalla.TabIndex = 4
        '
        'btnsync
        '
        Me.btnsync.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsync.Location = New System.Drawing.Point(55, 222)
        Me.btnsync.Name = "btnsync"
        Me.btnsync.Size = New System.Drawing.Size(75, 20)
        Me.btnsync.TabIndex = 3
        Me.btnsync.Text = "Sincronizar"
        Me.btnsync.UseVisualStyleBackColor = True
        '
        'grbpaso5
        '
        Me.grbpaso5.Controls.Add(Me.lstdebug)
        Me.grbpaso5.Controls.Add(Me.btniniciar)
        Me.grbpaso5.Controls.Add(Me.prbarmado)
        Me.grbpaso5.Controls.Add(Me.TextBox2)
        Me.grbpaso5.Location = New System.Drawing.Point(212, 8)
        Me.grbpaso5.Name = "grbpaso5"
        Me.grbpaso5.Size = New System.Drawing.Size(555, 253)
        Me.grbpaso5.TabIndex = 46
        Me.grbpaso5.TabStop = False
        Me.grbpaso5.Text = " PASO 5: Extracción de interfaces por objeto"
        Me.grbpaso5.Visible = False
        '
        'lstdebug
        '
        Me.lstdebug.FormattingEnabled = True
        Me.lstdebug.Location = New System.Drawing.Point(6, 104)
        Me.lstdebug.Name = "lstdebug"
        Me.lstdebug.Size = New System.Drawing.Size(531, 134)
        Me.lstdebug.TabIndex = 4
        '
        'btniniciar
        '
        Me.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btniniciar.Location = New System.Drawing.Point(406, 45)
        Me.btniniciar.Name = "btniniciar"
        Me.btniniciar.Size = New System.Drawing.Size(131, 20)
        Me.btniniciar.TabIndex = 3
        Me.btniniciar.Text = "Iniciar extracción"
        Me.btniniciar.UseVisualStyleBackColor = True
        '
        'prbarmado
        '
        Me.prbarmado.Location = New System.Drawing.Point(6, 75)
        Me.prbarmado.Name = "prbarmado"
        Me.prbarmado.Size = New System.Drawing.Size(531, 23)
        Me.prbarmado.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(6, 19)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(531, 33)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "A continuación se va a leer cada programa y se van a extraer las interfaces publi" & _
            "cas que pueden utilizarse en el Front-End"
        '
        'grbpaso1
        '
        Me.grbpaso1.Controls.Add(Me.cboproyecto)
        Me.grbpaso1.Controls.Add(Me.TextBox4)
        Me.grbpaso1.Location = New System.Drawing.Point(212, 11)
        Me.grbpaso1.Name = "grbpaso1"
        Me.grbpaso1.Size = New System.Drawing.Size(555, 244)
        Me.grbpaso1.TabIndex = 47
        Me.grbpaso1.TabStop = False
        Me.grbpaso1.Text = " PASO 1: Seleccione el nombre del proyecto"
        '
        'cboproyecto
        '
        Me.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboproyecto.FormattingEnabled = True
        Me.cboproyecto.Location = New System.Drawing.Point(79, 39)
        Me.cboproyecto.Name = "cboproyecto"
        Me.cboproyecto.Size = New System.Drawing.Size(459, 21)
        Me.cboproyecto.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(17, 42)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(56, 16)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "Proyecto : "
        '
        'frmFrontWizSyncProyCGI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.grbpaso6)
        Me.Controls.Add(Me.grbpaso2)
        Me.Controls.Add(Me.grbpaso4)
        Me.Controls.Add(Me.grbpaso5)
        Me.Controls.Add(Me.grbpaso3)
        Me.Controls.Add(Me.grbpaso1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFrontWizSyncProyCGI"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "WIZARD ! Para sincronizar un proyecto"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grbpaso3.ResumeLayout(False)
        Me.grbpaso3.PerformLayout()
        Me.grbpaso4.ResumeLayout(False)
        Me.grbpaso4.PerformLayout()
        Me.grbpaso2.ResumeLayout(False)
        Me.grbpaso2.PerformLayout()
        Me.grbpaso6.ResumeLayout(False)
        Me.grbpaso6.PerformLayout()
        CType(Me.gridpantalla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso5.ResumeLayout(False)
        Me.grbpaso5.PerformLayout()
        Me.grbpaso1.ResumeLayout(False)
        Me.grbpaso1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents btnterminar As System.Windows.Forms.Button
    Friend WithEvents grbpaso3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents chksubdirectorios As System.Windows.Forms.CheckBox
    Friend WithEvents cboestilo As System.Windows.Forms.ComboBox
    Friend WithEvents btnexaminar As System.Windows.Forms.Button
    Friend WithEvents txtdirectory As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblextension As System.Windows.Forms.Label
    Friend WithEvents btnleerdir As System.Windows.Forms.Button
    Friend WithEvents chkselectall As System.Windows.Forms.CheckBox
    Friend WithEvents clbArchivos As System.Windows.Forms.CheckedListBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents grbpaso2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbosincronia As System.Windows.Forms.ComboBox
    Friend WithEvents radExiste As System.Windows.Forms.RadioButton
    Friend WithEvents radNueva As System.Windows.Forms.RadioButton
    Friend WithEvents txtsincronia As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnstaffload As System.Windows.Forms.Button
    Friend WithEvents txtpantallas As System.Windows.Forms.TextBox
    Friend WithEvents gridpantalla As System.Windows.Forms.DataGridView
    Friend WithEvents btnsync As System.Windows.Forms.Button
    Friend WithEvents grbpaso5 As System.Windows.Forms.GroupBox
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents btniniciar As System.Windows.Forms.Button
    Friend WithEvents prbarmado As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboproyecto As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lblnvoestilo As System.Windows.Forms.Label
    Friend WithEvents cboFrontEnd As System.Windows.Forms.ComboBox
End Class
