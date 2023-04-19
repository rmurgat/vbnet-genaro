<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdfgenera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdfgenera))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.grbpaso3 = New System.Windows.Forms.GroupBox()
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.prbdocto = New System.Windows.Forms.ProgressBar()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.grbpaso1 = New System.Windows.Forms.GroupBox()
        Me.cboproyecto = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.grbpaso2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.chkopenfile = New System.Windows.Forms.CheckBox()
        Me.btndocfile = New System.Windows.Forms.Button()
        Me.txtdocfile = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grbpaso3.SuspendLayout()
        Me.grbpaso1.SuspendLayout()
        Me.grbpaso2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(176, 112)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 7
        Me.LogoPictureBox.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.19231!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.80769!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnsiguiente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnanterior, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btncerrar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(191, 268)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(461, 34)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsiguiente.Location = New System.Drawing.Point(138, 5)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(81, 23)
        Me.btnsiguiente.TabIndex = 2
        Me.btnsiguiente.Text = "Siguiente >"
        '
        'btnanterior
        '
        Me.btnanterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnanterior.Location = New System.Drawing.Point(22, 5)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(67, 23)
        Me.btnanterior.TabIndex = 0
        Me.btnanterior.Text = "< Regresar"
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncerrar.Location = New System.Drawing.Point(313, 5)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(81, 23)
        Me.btncerrar.TabIndex = 1
        Me.btncerrar.Text = "Cerrar"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'grbpaso3
        '
        Me.grbpaso3.Controls.Add(Me.lstdebug)
        Me.grbpaso3.Controls.Add(Me.btniniciar)
        Me.grbpaso3.Controls.Add(Me.prbdocto)
        Me.grbpaso3.Controls.Add(Me.TextBox2)
        Me.grbpaso3.Location = New System.Drawing.Point(185, 12)
        Me.grbpaso3.Name = "grbpaso3"
        Me.grbpaso3.Size = New System.Drawing.Size(467, 244)
        Me.grbpaso3.TabIndex = 14
        Me.grbpaso3.TabStop = False
        Me.grbpaso3.Text = "PASO 3: Compilación de documento  "
        Me.grbpaso3.Visible = False
        '
        'lstdebug
        '
        Me.lstdebug.FormattingEnabled = True
        Me.lstdebug.Location = New System.Drawing.Point(6, 104)
        Me.lstdebug.Name = "lstdebug"
        Me.lstdebug.Size = New System.Drawing.Size(455, 134)
        Me.lstdebug.TabIndex = 4
        '
        'btniniciar
        '
        Me.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btniniciar.Location = New System.Drawing.Point(330, 49)
        Me.btniniciar.Name = "btniniciar"
        Me.btniniciar.Size = New System.Drawing.Size(131, 20)
        Me.btniniciar.TabIndex = 3
        Me.btniniciar.Text = "Iniciar compilación"
        Me.btniniciar.UseVisualStyleBackColor = True
        '
        'prbdocto
        '
        Me.prbdocto.Location = New System.Drawing.Point(6, 75)
        Me.prbdocto.Name = "prbdocto"
        Me.prbdocto.Size = New System.Drawing.Size(455, 23)
        Me.prbdocto.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(6, 19)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(455, 33)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "A continuación se muestra el resultado de la incorporación de cada uno de los ele" & _
            "mentos."
        '
        'grbpaso1
        '
        Me.grbpaso1.Controls.Add(Me.cboproyecto)
        Me.grbpaso1.Controls.Add(Me.TextBox3)
        Me.grbpaso1.Location = New System.Drawing.Point(185, 12)
        Me.grbpaso1.Name = "grbpaso1"
        Me.grbpaso1.Size = New System.Drawing.Size(467, 244)
        Me.grbpaso1.TabIndex = 17
        Me.grbpaso1.TabStop = False
        Me.grbpaso1.Text = " PASO 1: Seleccione el nombre del proyecto"
        '
        'cboproyecto
        '
        Me.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboproyecto.FormattingEnabled = True
        Me.cboproyecto.Location = New System.Drawing.Point(102, 39)
        Me.cboproyecto.Name = "cboproyecto"
        Me.cboproyecto.Size = New System.Drawing.Size(359, 21)
        Me.cboproyecto.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(17, 42)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(56, 16)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "Proyecto : "
        '
        'grbpaso2
        '
        Me.grbpaso2.Controls.Add(Me.TextBox1)
        Me.grbpaso2.Controls.Add(Me.cbotipo)
        Me.grbpaso2.Controls.Add(Me.chkopenfile)
        Me.grbpaso2.Controls.Add(Me.btndocfile)
        Me.grbpaso2.Controls.Add(Me.txtdocfile)
        Me.grbpaso2.Controls.Add(Me.TextBox7)
        Me.grbpaso2.Location = New System.Drawing.Point(185, 12)
        Me.grbpaso2.Name = "grbpaso2"
        Me.grbpaso2.Size = New System.Drawing.Size(467, 244)
        Me.grbpaso2.TabIndex = 18
        Me.grbpaso2.TabStop = False
        Me.grbpaso2.Text = "PASO 2: Archivo con documentación y estilo que tiene"
        Me.grbpaso2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(11, 115)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(56, 16)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "Estilo : "
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Location = New System.Drawing.Point(96, 112)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(365, 21)
        Me.cbotipo.TabIndex = 12
        '
        'chkopenfile
        '
        Me.chkopenfile.AutoSize = True
        Me.chkopenfile.Checked = True
        Me.chkopenfile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkopenfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkopenfile.Location = New System.Drawing.Point(365, 75)
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
        Me.txtdocfile.Size = New System.Drawing.Size(455, 20)
        Me.txtdocfile.TabIndex = 3
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Location = New System.Drawing.Point(6, 19)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(280, 17)
        Me.TextBox7.TabIndex = 0
        Me.TextBox7.Text = "Seleccione el archivo donde se graba la documentación."
        '
        'frmdfgenera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.grbpaso2)
        Me.Controls.Add(Me.grbpaso1)
        Me.Controls.Add(Me.grbpaso3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmdfgenera"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Compilación del diseño funcional..."
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grbpaso3.ResumeLayout(False)
        Me.grbpaso3.PerformLayout()
        Me.grbpaso1.ResumeLayout(False)
        Me.grbpaso1.PerformLayout()
        Me.grbpaso2.ResumeLayout(False)
        Me.grbpaso2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grbpaso3 As System.Windows.Forms.GroupBox
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents btniniciar As System.Windows.Forms.Button
    Friend WithEvents prbdocto As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboproyecto As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkopenfile As System.Windows.Forms.CheckBox
    Friend WithEvents btndocfile As System.Windows.Forms.Button
    Friend WithEvents txtdocfile As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
End Class
