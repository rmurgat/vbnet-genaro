<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdiccionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdiccionario))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.grbpaso1 = New System.Windows.Forms.GroupBox()
        Me.cboftedatos = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.grbpaso2 = New System.Windows.Forms.GroupBox()
        Me.btnleerfte = New System.Windows.Forms.Button()
        Me.chkselectall = New System.Windows.Forms.CheckBox()
        Me.clbEntidad = New System.Windows.Forms.CheckedListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grbpaso4 = New System.Windows.Forms.GroupBox()
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.prbarmado = New System.Windows.Forms.ProgressBar()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.grbpaso3 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.cboestilo = New System.Windows.Forms.ComboBox()
        Me.btndocfile = New System.Windows.Forms.Button()
        Me.txtdocfile = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso1.SuspendLayout()
        Me.grbpaso2.SuspendLayout()
        Me.grbpaso4.SuspendLayout()
        Me.grbpaso3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.83019!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.16981!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnsiguiente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnanterior, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btncerrar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(190, 253)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(375, 34)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsiguiente.Location = New System.Drawing.Point(137, 5)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(70, 23)
        Me.btnsiguiente.TabIndex = 2
        Me.btnsiguiente.Text = "Siguiente >"
        '
        'btnanterior
        '
        Me.btnanterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnanterior.Location = New System.Drawing.Point(26, 5)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(66, 23)
        Me.btnanterior.TabIndex = 0
        Me.btnanterior.Text = "< Anterior"
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncerrar.Location = New System.Drawing.Point(260, 5)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(81, 23)
        Me.btncerrar.TabIndex = 1
        Me.btncerrar.Text = "Cerrar"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(6, 3)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(178, 115)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 19
        Me.LogoPictureBox.TabStop = False
        '
        'grbpaso1
        '
        Me.grbpaso1.Controls.Add(Me.cboftedatos)
        Me.grbpaso1.Controls.Add(Me.TextBox3)
        Me.grbpaso1.Location = New System.Drawing.Point(190, 3)
        Me.grbpaso1.Name = "grbpaso1"
        Me.grbpaso1.Size = New System.Drawing.Size(377, 243)
        Me.grbpaso1.TabIndex = 21
        Me.grbpaso1.TabStop = False
        Me.grbpaso1.Text = " PASO 1: Seleccione el nombre de la fuente de datos"
        '
        'cboftedatos
        '
        Me.cboftedatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboftedatos.FormattingEnabled = True
        Me.cboftedatos.Location = New System.Drawing.Point(6, 50)
        Me.cboftedatos.Name = "cboftedatos"
        Me.cboftedatos.Size = New System.Drawing.Size(365, 21)
        Me.cboftedatos.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(6, 28)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(91, 16)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "Fuente de Datos : "
        '
        'grbpaso2
        '
        Me.grbpaso2.Controls.Add(Me.btnleerfte)
        Me.grbpaso2.Controls.Add(Me.chkselectall)
        Me.grbpaso2.Controls.Add(Me.clbEntidad)
        Me.grbpaso2.Controls.Add(Me.TextBox1)
        Me.grbpaso2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grbpaso2.Location = New System.Drawing.Point(190, 3)
        Me.grbpaso2.Name = "grbpaso2"
        Me.grbpaso2.Size = New System.Drawing.Size(377, 243)
        Me.grbpaso2.TabIndex = 26
        Me.grbpaso2.TabStop = False
        Me.grbpaso2.Text = " PASO 2:  Selección de Entidades"
        Me.grbpaso2.Visible = False
        '
        'btnleerfte
        '
        Me.btnleerfte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnleerfte.Location = New System.Drawing.Point(266, 50)
        Me.btnleerfte.Name = "btnleerfte"
        Me.btnleerfte.Size = New System.Drawing.Size(91, 23)
        Me.btnleerfte.TabIndex = 3
        Me.btnleerfte.Text = "Leer Fuente"
        Me.btnleerfte.UseVisualStyleBackColor = True
        '
        'chkselectall
        '
        Me.chkselectall.AutoSize = True
        Me.chkselectall.Location = New System.Drawing.Point(6, 221)
        Me.chkselectall.Name = "chkselectall"
        Me.chkselectall.Size = New System.Drawing.Size(106, 17)
        Me.chkselectall.TabIndex = 2
        Me.chkselectall.Text = "Seleccionar todo"
        Me.chkselectall.UseVisualStyleBackColor = True
        '
        'clbEntidad
        '
        Me.clbEntidad.FormattingEnabled = True
        Me.clbEntidad.Location = New System.Drawing.Point(6, 79)
        Me.clbEntidad.Name = "clbEntidad"
        Me.clbEntidad.Size = New System.Drawing.Size(352, 139)
        Me.clbEntidad.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(352, 33)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "De esta lista de entidades, seleccione aquellas que participan en el diccionario." & _
            ""
        '
        'grbpaso4
        '
        Me.grbpaso4.Controls.Add(Me.lstdebug)
        Me.grbpaso4.Controls.Add(Me.btniniciar)
        Me.grbpaso4.Controls.Add(Me.prbarmado)
        Me.grbpaso4.Controls.Add(Me.TextBox2)
        Me.grbpaso4.Location = New System.Drawing.Point(190, 3)
        Me.grbpaso4.Name = "grbpaso4"
        Me.grbpaso4.Size = New System.Drawing.Size(377, 243)
        Me.grbpaso4.TabIndex = 28
        Me.grbpaso4.TabStop = False
        Me.grbpaso4.Text = " PASO 4: Generación de documento"
        Me.grbpaso4.Visible = False
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
        Me.btniniciar.Size = New System.Drawing.Size(131, 24)
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
        Me.TextBox2.Text = "A continuación se muestra el resultado de la incorporación de cada una de las ent" & _
            "idades"
        '
        'grbpaso3
        '
        Me.grbpaso3.Controls.Add(Me.TextBox4)
        Me.grbpaso3.Controls.Add(Me.cboestilo)
        Me.grbpaso3.Controls.Add(Me.btndocfile)
        Me.grbpaso3.Controls.Add(Me.txtdocfile)
        Me.grbpaso3.Controls.Add(Me.TextBox7)
        Me.grbpaso3.Location = New System.Drawing.Point(190, 3)
        Me.grbpaso3.Name = "grbpaso3"
        Me.grbpaso3.Size = New System.Drawing.Size(377, 243)
        Me.grbpaso3.TabIndex = 29
        Me.grbpaso3.TabStop = False
        Me.grbpaso3.Text = "PASO 3: Selección de Archivo de Salida y Estilo del documento"
        Me.grbpaso3.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(6, 137)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(56, 16)
        Me.TextBox4.TabIndex = 18
        Me.TextBox4.Text = "Estilo : "
        '
        'cboestilo
        '
        Me.cboestilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboestilo.FormattingEnabled = True
        Me.cboestilo.Location = New System.Drawing.Point(6, 159)
        Me.cboestilo.Name = "cboestilo"
        Me.cboestilo.Size = New System.Drawing.Size(359, 21)
        Me.cboestilo.TabIndex = 17
        '
        'btndocfile
        '
        Me.btndocfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndocfile.Location = New System.Drawing.Point(6, 92)
        Me.btndocfile.Name = "btndocfile"
        Me.btndocfile.Size = New System.Drawing.Size(113, 23)
        Me.btndocfile.TabIndex = 16
        Me.btndocfile.Text = "Examinar..."
        Me.btndocfile.UseVisualStyleBackColor = True
        '
        'txtdocfile
        '
        Me.txtdocfile.Location = New System.Drawing.Point(6, 66)
        Me.txtdocfile.Name = "txtdocfile"
        Me.txtdocfile.ReadOnly = True
        Me.txtdocfile.Size = New System.Drawing.Size(359, 20)
        Me.txtdocfile.TabIndex = 15
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Location = New System.Drawing.Point(6, 44)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(322, 16)
        Me.TextBox7.TabIndex = 14
        Me.TextBox7.Text = "Seleccione el archivo donde se graba la documentación."
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'frmdiccionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.grbpaso4)
        Me.Controls.Add(Me.grbpaso1)
        Me.Controls.Add(Me.grbpaso3)
        Me.Controls.Add(Me.grbpaso2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmdiccionario"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Generación del Diccionario de Datos..."
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso1.ResumeLayout(False)
        Me.grbpaso1.PerformLayout()
        Me.grbpaso2.ResumeLayout(False)
        Me.grbpaso2.PerformLayout()
        Me.grbpaso4.ResumeLayout(False)
        Me.grbpaso4.PerformLayout()
        Me.grbpaso3.ResumeLayout(False)
        Me.grbpaso3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents grbpaso1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboftedatos As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnleerfte As System.Windows.Forms.Button
    Friend WithEvents chkselectall As System.Windows.Forms.CheckBox
    Friend WithEvents clbEntidad As System.Windows.Forms.CheckedListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso4 As System.Windows.Forms.GroupBox
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents btniniciar As System.Windows.Forms.Button
    Friend WithEvents prbarmado As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents grbpaso3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents cboestilo As System.Windows.Forms.ComboBox
    Friend WithEvents btndocfile As System.Windows.Forms.Button
    Friend WithEvents txtdocfile As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
End Class
