<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBwizComments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDBwizComments))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.grbpaso1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnfuente = New System.Windows.Forms.Button()
        Me.cboftedatos = New System.Windows.Forms.ComboBox()
        Me.grbpaso2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radcampo = New System.Windows.Forms.RadioButton()
        Me.radentidad = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcarseparador = New System.Windows.Forms.TextBox()
        Me.radtipoTXT = New System.Windows.Forms.RadioButton()
        Me.radtipoXML = New System.Windows.Forms.RadioButton()
        Me.btncommentfile = New System.Windows.Forms.Button()
        Me.txtfile = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.grbpaso3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnexportar = New System.Windows.Forms.Button()
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.btnimportar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpaso1.SuspendLayout()
        Me.grbpaso2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grbpaso3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.20126!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.79874!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnsiguiente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnanterior, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btncerrar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(185, 232)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(372, 34)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsiguiente.Location = New System.Drawing.Point(104, 5)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(81, 23)
        Me.btnsiguiente.TabIndex = 2
        Me.btnsiguiente.Text = "Siguiente >"
        '
        'btnanterior
        '
        Me.btnanterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnanterior.Location = New System.Drawing.Point(11, 5)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(76, 23)
        Me.btnanterior.TabIndex = 0
        Me.btnanterior.Text = "< Regresar"
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncerrar.Location = New System.Drawing.Point(240, 5)
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
        Me.LogoPictureBox.Size = New System.Drawing.Size(176, 110)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 19
        Me.LogoPictureBox.TabStop = False
        '
        'grbpaso1
        '
        Me.grbpaso1.Controls.Add(Me.Label1)
        Me.grbpaso1.Controls.Add(Me.btnfuente)
        Me.grbpaso1.Controls.Add(Me.cboftedatos)
        Me.grbpaso1.Location = New System.Drawing.Point(185, 12)
        Me.grbpaso1.Name = "grbpaso1"
        Me.grbpaso1.Size = New System.Drawing.Size(372, 214)
        Me.grbpaso1.TabIndex = 21
        Me.grbpaso1.TabStop = False
        Me.grbpaso1.Text = " PASO 1: Seleccione el nombre de la fuente de datos "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Fuente de Datos :"
        '
        'btnfuente
        '
        Me.btnfuente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfuente.Location = New System.Drawing.Point(260, 90)
        Me.btnfuente.Name = "btnfuente"
        Me.btnfuente.Size = New System.Drawing.Size(103, 20)
        Me.btnfuente.TabIndex = 13
        Me.btnfuente.Text = "Ver Fuente..."
        Me.btnfuente.UseVisualStyleBackColor = True
        '
        'cboftedatos
        '
        Me.cboftedatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboftedatos.FormattingEnabled = True
        Me.cboftedatos.Location = New System.Drawing.Point(7, 64)
        Me.cboftedatos.Name = "cboftedatos"
        Me.cboftedatos.Size = New System.Drawing.Size(357, 21)
        Me.cboftedatos.TabIndex = 9
        '
        'grbpaso2
        '
        Me.grbpaso2.Controls.Add(Me.Label3)
        Me.grbpaso2.Controls.Add(Me.GroupBox2)
        Me.grbpaso2.Controls.Add(Me.GroupBox1)
        Me.grbpaso2.Controls.Add(Me.btncommentfile)
        Me.grbpaso2.Controls.Add(Me.txtfile)
        Me.grbpaso2.Location = New System.Drawing.Point(185, 12)
        Me.grbpaso2.Name = "grbpaso2"
        Me.grbpaso2.Size = New System.Drawing.Size(371, 214)
        Me.grbpaso2.TabIndex = 22
        Me.grbpaso2.TabStop = False
        Me.grbpaso2.Text = "PASO 2: Seleccione Archivo, Tipo de Archivo y Comentarios de quien son "
        Me.grbpaso2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(338, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Seleccione el archivo desde donde se tomará ó dejará  la información "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radcampo)
        Me.GroupBox2.Controls.Add(Me.radentidad)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Location = New System.Drawing.Point(187, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 68)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comentarios para :"
        '
        'radcampo
        '
        Me.radcampo.AutoSize = True
        Me.radcampo.Checked = True
        Me.radcampo.Location = New System.Drawing.Point(73, 44)
        Me.radcampo.Name = "radcampo"
        Me.radcampo.Size = New System.Drawing.Size(58, 17)
        Me.radcampo.TabIndex = 12
        Me.radcampo.TabStop = True
        Me.radcampo.Text = "Campo"
        Me.radcampo.UseVisualStyleBackColor = True
        '
        'radentidad
        '
        Me.radentidad.AutoSize = True
        Me.radentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radentidad.Location = New System.Drawing.Point(73, 21)
        Me.radentidad.Name = "radentidad"
        Me.radentidad.Size = New System.Drawing.Size(54, 16)
        Me.radentidad.TabIndex = 11
        Me.radentidad.Text = "Entidad"
        Me.radentidad.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcarseparador)
        Me.GroupBox1.Controls.Add(Me.radtipoTXT)
        Me.GroupBox1.Controls.Add(Me.radtipoXML)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(7, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 68)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Archivo"
        '
        'txtcarseparador
        '
        Me.txtcarseparador.Location = New System.Drawing.Point(113, 44)
        Me.txtcarseparador.MaxLength = 1
        Me.txtcarseparador.Name = "txtcarseparador"
        Me.txtcarseparador.Size = New System.Drawing.Size(21, 20)
        Me.txtcarseparador.TabIndex = 5
        Me.txtcarseparador.Text = "|"
        '
        'radtipoTXT
        '
        Me.radtipoTXT.AutoSize = True
        Me.radtipoTXT.Checked = True
        Me.radtipoTXT.Location = New System.Drawing.Point(6, 45)
        Me.radtipoTXT.Name = "radtipoTXT"
        Me.radtipoTXT.Size = New System.Drawing.Size(107, 17)
        Me.radtipoTXT.TabIndex = 4
        Me.radtipoTXT.TabStop = True
        Me.radtipoTXT.Text = "txt separado por :"
        Me.radtipoTXT.UseVisualStyleBackColor = True
        '
        'radtipoXML
        '
        Me.radtipoXML.AutoSize = True
        Me.radtipoXML.Enabled = False
        Me.radtipoXML.Location = New System.Drawing.Point(6, 22)
        Me.radtipoXML.Name = "radtipoXML"
        Me.radtipoXML.Size = New System.Drawing.Size(43, 17)
        Me.radtipoXML.TabIndex = 3
        Me.radtipoXML.Text = ".xml"
        Me.radtipoXML.UseVisualStyleBackColor = True
        '
        'btncommentfile
        '
        Me.btncommentfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncommentfile.Location = New System.Drawing.Point(6, 164)
        Me.btncommentfile.Name = "btncommentfile"
        Me.btncommentfile.Size = New System.Drawing.Size(83, 23)
        Me.btncommentfile.TabIndex = 7
        Me.btncommentfile.Text = "Examinar..."
        Me.btncommentfile.UseVisualStyleBackColor = True
        '
        'txtfile
        '
        Me.txtfile.Location = New System.Drawing.Point(6, 138)
        Me.txtfile.Name = "txtfile"
        Me.txtfile.ReadOnly = True
        Me.txtfile.Size = New System.Drawing.Size(357, 20)
        Me.txtfile.TabIndex = 6
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'grbpaso3
        '
        Me.grbpaso3.Controls.Add(Me.Label2)
        Me.grbpaso3.Controls.Add(Me.btnexportar)
        Me.grbpaso3.Controls.Add(Me.lstdebug)
        Me.grbpaso3.Controls.Add(Me.btnimportar)
        Me.grbpaso3.Location = New System.Drawing.Point(185, 12)
        Me.grbpaso3.Name = "grbpaso3"
        Me.grbpaso3.Size = New System.Drawing.Size(371, 214)
        Me.grbpaso3.TabIndex = 23
        Me.grbpaso3.TabStop = False
        Me.grbpaso3.Text = "PASO 3: Importación/Exportación de comentarios"
        Me.grbpaso3.Visible = False
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(7, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 34)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "En este paso en el que importan/exportan todos los comentarios desde/hasta un arc" & _
            "hivo de texto ya sea como .xml ó .txt."
        '
        'btnexportar
        '
        Me.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexportar.Location = New System.Drawing.Point(250, 62)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(113, 23)
        Me.btnexportar.TabIndex = 10
        Me.btnexportar.Text = "Exportar"
        Me.btnexportar.UseVisualStyleBackColor = True
        '
        'lstdebug
        '
        Me.lstdebug.FormattingEnabled = True
        Me.lstdebug.Location = New System.Drawing.Point(7, 95)
        Me.lstdebug.Name = "lstdebug"
        Me.lstdebug.Size = New System.Drawing.Size(356, 108)
        Me.lstdebug.TabIndex = 9
        '
        'btnimportar
        '
        Me.btnimportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnimportar.Location = New System.Drawing.Point(7, 64)
        Me.btnimportar.Name = "btnimportar"
        Me.btnimportar.Size = New System.Drawing.Size(113, 23)
        Me.btnimportar.TabIndex = 8
        Me.btnimportar.Text = "Importar"
        Me.btnimportar.UseVisualStyleBackColor = True
        '
        'frmDBwizComments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 274)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.grbpaso3)
        Me.Controls.Add(Me.grbpaso2)
        Me.Controls.Add(Me.grbpaso1)
        Me.Name = "frmDBwizComments"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "WIZARD ! Para la importación de comentarios de las entidades..."
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpaso1.ResumeLayout(False)
        Me.grbpaso1.PerformLayout()
        Me.grbpaso2.ResumeLayout(False)
        Me.grbpaso2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbpaso3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents grbpaso1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboftedatos As System.Windows.Forms.ComboBox
    Friend WithEvents grbpaso2 As System.Windows.Forms.GroupBox
    Friend WithEvents btncommentfile As System.Windows.Forms.Button
    Friend WithEvents txtfile As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grbpaso3 As System.Windows.Forms.GroupBox
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents btnimportar As System.Windows.Forms.Button
    Friend WithEvents btnfuente As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcarseparador As System.Windows.Forms.TextBox
    Friend WithEvents radtipoTXT As System.Windows.Forms.RadioButton
    Friend WithEvents radtipoXML As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radcampo As System.Windows.Forms.RadioButton
    Friend WithEvents radentidad As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnexportar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
