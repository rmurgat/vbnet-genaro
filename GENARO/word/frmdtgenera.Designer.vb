<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdtgenera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdtgenera))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btnterminar = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.grbpaso2 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.chkopenfile = New System.Windows.Forms.CheckBox()
        Me.btndocfile = New System.Windows.Forms.Button()
        Me.txtdocfile = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
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
        Me.grbpaso1 = New System.Windows.Forms.GroupBox()
        Me.cboproyecto = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.grbpaso5 = New System.Windows.Forms.GroupBox()
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.prbarmado = New System.Windows.Forms.ProgressBar()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso2.SuspendLayout()
        Me.grbpaso3.SuspendLayout()
        Me.grbpaso4.SuspendLayout()
        Me.grbpaso1.SuspendLayout()
        Me.grbpaso5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.19231!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.80769!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnsiguiente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnanterior, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnterminar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(205, 271)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(390, 35)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsiguiente.Location = New System.Drawing.Point(123, 6)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(81, 23)
        Me.btnsiguiente.TabIndex = 2
        Me.btnsiguiente.Text = "Siguiente >"
        '
        'btnanterior
        '
        Me.btnanterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnanterior.Location = New System.Drawing.Point(17, 6)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(67, 23)
        Me.btnanterior.TabIndex = 0
        Me.btnanterior.Text = "< Regresar"
        '
        'btnterminar
        '
        Me.btnterminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnterminar.Location = New System.Drawing.Point(267, 6)
        Me.btnterminar.Name = "btnterminar"
        Me.btnterminar.Size = New System.Drawing.Size(81, 23)
        Me.btnterminar.TabIndex = 1
        Me.btnterminar.Text = "Terminar"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(5, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(190, 121)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 6
        Me.LogoPictureBox.TabStop = False
        '
        'grbpaso2
        '
        Me.grbpaso2.Controls.Add(Me.TextBox6)
        Me.grbpaso2.Controls.Add(Me.cbotipo)
        Me.grbpaso2.Controls.Add(Me.chkopenfile)
        Me.grbpaso2.Controls.Add(Me.btndocfile)
        Me.grbpaso2.Controls.Add(Me.txtdocfile)
        Me.grbpaso2.Controls.Add(Me.TextBox7)
        Me.grbpaso2.Location = New System.Drawing.Point(201, 9)
        Me.grbpaso2.Name = "grbpaso2"
        Me.grbpaso2.Size = New System.Drawing.Size(381, 244)
        Me.grbpaso2.TabIndex = 11
        Me.grbpaso2.TabStop = False
        Me.grbpaso2.Text = " PASO 2: Seleccione el archivo de documentación"
        Me.grbpaso2.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Location = New System.Drawing.Point(6, 119)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(39, 14)
        Me.TextBox6.TabIndex = 18
        Me.TextBox6.Text = "Estilo : "
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Location = New System.Drawing.Point(51, 116)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(318, 21)
        Me.cbotipo.TabIndex = 16
        '
        'chkopenfile
        '
        Me.chkopenfile.AutoSize = True
        Me.chkopenfile.Checked = True
        Me.chkopenfile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkopenfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkopenfile.Location = New System.Drawing.Point(273, 75)
        Me.chkopenfile.Name = "chkopenfile"
        Me.chkopenfile.Size = New System.Drawing.Size(96, 17)
        Me.chkopenfile.TabIndex = 6
        Me.chkopenfile.Text = "Abrir al terminar"
        Me.chkopenfile.UseVisualStyleBackColor = True
        '
        'btndocfile
        '
        Me.btndocfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndocfile.Location = New System.Drawing.Point(6, 67)
        Me.btndocfile.Name = "btndocfile"
        Me.btndocfile.Size = New System.Drawing.Size(113, 23)
        Me.btndocfile.TabIndex = 4
        Me.btndocfile.Text = "Examinar..."
        Me.btndocfile.UseVisualStyleBackColor = True
        '
        'txtdocfile
        '
        Me.txtdocfile.Location = New System.Drawing.Point(6, 41)
        Me.txtdocfile.Name = "txtdocfile"
        Me.txtdocfile.ReadOnly = True
        Me.txtdocfile.Size = New System.Drawing.Size(363, 20)
        Me.txtdocfile.TabIndex = 3
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Location = New System.Drawing.Point(6, 19)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(322, 16)
        Me.TextBox7.TabIndex = 0
        Me.TextBox7.Text = "Seleccione el archivo donde se graba la documentación."
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'grbpaso3
        '
        Me.grbpaso3.Controls.Add(Me.TextBox5)
        Me.grbpaso3.Controls.Add(Me.chksubdirectorios)
        Me.grbpaso3.Controls.Add(Me.cboestilo)
        Me.grbpaso3.Controls.Add(Me.btnexaminar)
        Me.grbpaso3.Controls.Add(Me.txtdirectory)
        Me.grbpaso3.Controls.Add(Me.TextBox1)
        Me.grbpaso3.Location = New System.Drawing.Point(195, 9)
        Me.grbpaso3.Name = "grbpaso3"
        Me.grbpaso3.Size = New System.Drawing.Size(387, 244)
        Me.grbpaso3.TabIndex = 23
        Me.grbpaso3.TabStop = False
        Me.grbpaso3.Text = " PASO 3:  Busqueda de programas fuente "
        Me.grbpaso3.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(6, 143)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(322, 33)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.Text = "¿ Que estilo de documentación tiene los programas fuente del directorio ? "
        '
        'chksubdirectorios
        '
        Me.chksubdirectorios.AutoSize = True
        Me.chksubdirectorios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chksubdirectorios.Location = New System.Drawing.Point(249, 104)
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
        Me.cboestilo.Size = New System.Drawing.Size(363, 21)
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
        Me.txtdirectory.Size = New System.Drawing.Size(363, 20)
        Me.txtdirectory.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(394, 33)
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
        Me.grbpaso4.Location = New System.Drawing.Point(195, 9)
        Me.grbpaso4.Name = "grbpaso4"
        Me.grbpaso4.Size = New System.Drawing.Size(387, 256)
        Me.grbpaso4.TabIndex = 25
        Me.grbpaso4.TabStop = False
        Me.grbpaso4.Text = " PASO 4:  Selección de Código Fuente "
        Me.grbpaso4.Visible = False
        '
        'lblextension
        '
        Me.lblextension.AutoSize = True
        Me.lblextension.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblextension.Location = New System.Drawing.Point(21, 58)
        Me.lblextension.Name = "lblextension"
        Me.lblextension.Size = New System.Drawing.Size(56, 13)
        Me.lblextension.TabIndex = 7
        Me.lblextension.Text = "Extensión "
        '
        'btnleerdir
        '
        Me.btnleerdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnleerdir.Location = New System.Drawing.Point(278, 49)
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
        Me.clbArchivos.Location = New System.Drawing.Point(18, 78)
        Me.clbArchivos.Name = "clbArchivos"
        Me.clbArchivos.Size = New System.Drawing.Size(352, 139)
        Me.clbArchivos.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(18, 18)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(352, 33)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = "De esta lista de programas fuente, seleccione aquellos archivos que participaran " & _
            "en la incorporación."
        '
        'grbpaso1
        '
        Me.grbpaso1.Controls.Add(Me.cboproyecto)
        Me.grbpaso1.Controls.Add(Me.TextBox4)
        Me.grbpaso1.Location = New System.Drawing.Point(201, 15)
        Me.grbpaso1.Name = "grbpaso1"
        Me.grbpaso1.Size = New System.Drawing.Size(381, 244)
        Me.grbpaso1.TabIndex = 26
        Me.grbpaso1.TabStop = False
        Me.grbpaso1.Text = " PASO 1: Seleccione el nombre del proyecto"
        '
        'cboproyecto
        '
        Me.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboproyecto.FormattingEnabled = True
        Me.cboproyecto.Location = New System.Drawing.Point(79, 39)
        Me.cboproyecto.Name = "cboproyecto"
        Me.cboproyecto.Size = New System.Drawing.Size(290, 21)
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
        'grbpaso5
        '
        Me.grbpaso5.Controls.Add(Me.lstdebug)
        Me.grbpaso5.Controls.Add(Me.btniniciar)
        Me.grbpaso5.Controls.Add(Me.prbarmado)
        Me.grbpaso5.Controls.Add(Me.TextBox2)
        Me.grbpaso5.Location = New System.Drawing.Point(201, 9)
        Me.grbpaso5.Name = "grbpaso5"
        Me.grbpaso5.Size = New System.Drawing.Size(393, 253)
        Me.grbpaso5.TabIndex = 27
        Me.grbpaso5.TabStop = False
        Me.grbpaso5.Text = " PASO 5: Generación de documento"
        Me.grbpaso5.Visible = False
        '
        'lstdebug
        '
        Me.lstdebug.FormattingEnabled = True
        Me.lstdebug.Location = New System.Drawing.Point(6, 104)
        Me.lstdebug.Name = "lstdebug"
        Me.lstdebug.Size = New System.Drawing.Size(369, 134)
        Me.lstdebug.TabIndex = 4
        '
        'btniniciar
        '
        Me.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btniniciar.Location = New System.Drawing.Point(244, 49)
        Me.btniniciar.Name = "btniniciar"
        Me.btniniciar.Size = New System.Drawing.Size(131, 20)
        Me.btniniciar.TabIndex = 3
        Me.btniniciar.Text = "Iniciar incorporación"
        Me.btniniciar.UseVisualStyleBackColor = True
        '
        'prbarmado
        '
        Me.prbarmado.Location = New System.Drawing.Point(6, 75)
        Me.prbarmado.Name = "prbarmado"
        Me.prbarmado.Size = New System.Drawing.Size(369, 23)
        Me.prbarmado.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(6, 19)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(369, 33)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "A continuación se muestra el resultado de la incorporación de cada una de las cla" & _
            "ses."
        '
        'frmdtgenera
        '
        Me.AcceptButton = Me.btnanterior
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnterminar
        Me.ClientSize = New System.Drawing.Size(601, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.grbpaso1)
        Me.Controls.Add(Me.grbpaso5)
        Me.Controls.Add(Me.grbpaso4)
        Me.Controls.Add(Me.grbpaso3)
        Me.Controls.Add(Me.grbpaso2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmdtgenera"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "WIZARD para la generación del diseño técnico"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso2.ResumeLayout(False)
        Me.grbpaso2.PerformLayout()
        Me.grbpaso3.ResumeLayout(False)
        Me.grbpaso3.PerformLayout()
        Me.grbpaso4.ResumeLayout(False)
        Me.grbpaso4.PerformLayout()
        Me.grbpaso1.ResumeLayout(False)
        Me.grbpaso1.PerformLayout()
        Me.grbpaso5.ResumeLayout(False)
        Me.grbpaso5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents btnterminar As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents grbpaso2 As System.Windows.Forms.GroupBox
    Friend WithEvents btndocfile As System.Windows.Forms.Button
    Friend WithEvents txtdocfile As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkopenfile As System.Windows.Forms.CheckBox
    Friend WithEvents grbpaso3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents chksubdirectorios As System.Windows.Forms.CheckBox
    Friend WithEvents cboestilo As System.Windows.Forms.ComboBox
    Friend WithEvents btnexaminar As System.Windows.Forms.Button
    Friend WithEvents txtdirectory As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnleerdir As System.Windows.Forms.Button
    Friend WithEvents chkselectall As System.Windows.Forms.CheckBox
    Friend WithEvents clbArchivos As System.Windows.Forms.CheckedListBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboproyecto As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso5 As System.Windows.Forms.GroupBox
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents btniniciar As System.Windows.Forms.Button
    Friend WithEvents prbarmado As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblextension As System.Windows.Forms.Label

End Class
