<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQAValidaFuente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQAValidaFuente))
        Me.prbvalidacion = New System.Windows.Forms.ProgressBar()
        Me.btnleer = New System.Windows.Forms.Button()
        Me.chkselectall = New System.Windows.Forms.CheckBox()
        Me.clbEntidades = New System.Windows.Forms.CheckedListBox()
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btnterminar = New System.Windows.Forms.Button()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.grbpaso2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grbpaso3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClipboard = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.cbofuente = New System.Windows.Forms.ComboBox()
        Me.grbpaso1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grbpaso2.SuspendLayout()
        Me.grbpaso3.SuspendLayout()
        Me.grbpaso1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prbvalidacion
        '
        Me.prbvalidacion.Location = New System.Drawing.Point(6, 75)
        Me.prbvalidacion.Name = "prbvalidacion"
        Me.prbvalidacion.Size = New System.Drawing.Size(340, 23)
        Me.prbvalidacion.TabIndex = 1
        '
        'btnleer
        '
        Me.btnleer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnleer.Location = New System.Drawing.Point(255, 50)
        Me.btnleer.Name = "btnleer"
        Me.btnleer.Size = New System.Drawing.Size(91, 23)
        Me.btnleer.TabIndex = 3
        Me.btnleer.Text = "Leer Entidades"
        Me.btnleer.UseVisualStyleBackColor = True
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
        'clbEntidades
        '
        Me.clbEntidades.FormattingEnabled = True
        Me.clbEntidades.Location = New System.Drawing.Point(6, 79)
        Me.clbEntidades.Name = "clbEntidades"
        Me.clbEntidades.Size = New System.Drawing.Size(340, 139)
        Me.clbEntidades.TabIndex = 1
        '
        'lstdebug
        '
        Me.lstdebug.FormattingEnabled = True
        Me.lstdebug.Location = New System.Drawing.Point(6, 104)
        Me.lstdebug.Name = "lstdebug"
        Me.lstdebug.Size = New System.Drawing.Size(340, 134)
        Me.lstdebug.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.19231!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.80769!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnsiguiente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnanterior, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnterminar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(179, 256)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(352, 35)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsiguiente.Location = New System.Drawing.Point(96, 6)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(81, 23)
        Me.btnsiguiente.TabIndex = 2
        Me.btnsiguiente.Text = "Siguiente >"
        '
        'btnanterior
        '
        Me.btnanterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnanterior.Location = New System.Drawing.Point(9, 6)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(67, 23)
        Me.btnanterior.TabIndex = 0
        Me.btnanterior.Text = "< Regresar"
        '
        'btnterminar
        '
        Me.btnterminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnterminar.Location = New System.Drawing.Point(230, 6)
        Me.btnterminar.Name = "btnterminar"
        Me.btnterminar.Size = New System.Drawing.Size(81, 23)
        Me.btnterminar.TabIndex = 1
        Me.btnterminar.Text = "Terminar"
        '
        'btniniciar
        '
        Me.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btniniciar.Location = New System.Drawing.Point(238, 49)
        Me.btniniciar.Name = "btniniciar"
        Me.btniniciar.Size = New System.Drawing.Size(108, 20)
        Me.btniniciar.TabIndex = 3
        Me.btniniciar.Text = "Iniciar validación"
        Me.btniniciar.UseVisualStyleBackColor = True
        '
        'grbpaso2
        '
        Me.grbpaso2.Controls.Add(Me.btnleer)
        Me.grbpaso2.Controls.Add(Me.Label2)
        Me.grbpaso2.Controls.Add(Me.chkselectall)
        Me.grbpaso2.Controls.Add(Me.clbEntidades)
        Me.grbpaso2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grbpaso2.Location = New System.Drawing.Point(179, 2)
        Me.grbpaso2.Name = "grbpaso2"
        Me.grbpaso2.Size = New System.Drawing.Size(352, 244)
        Me.grbpaso2.TabIndex = 14
        Me.grbpaso2.TabStop = False
        Me.grbpaso2.Text = " PASO 2: Selección de clases que se validaran"
        Me.grbpaso2.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(339, 41)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "De la lista de entidades de datos, seleccione aquellas que particcipan en la vali" & _
            "dación."
        '
        'grbpaso3
        '
        Me.grbpaso3.Controls.Add(Me.Label3)
        Me.grbpaso3.Controls.Add(Me.btnClipboard)
        Me.grbpaso3.Controls.Add(Me.lstdebug)
        Me.grbpaso3.Controls.Add(Me.btniniciar)
        Me.grbpaso3.Controls.Add(Me.prbvalidacion)
        Me.grbpaso3.Location = New System.Drawing.Point(179, 2)
        Me.grbpaso3.Name = "grbpaso3"
        Me.grbpaso3.Size = New System.Drawing.Size(352, 244)
        Me.grbpaso3.TabIndex = 15
        Me.grbpaso3.TabStop = False
        Me.grbpaso3.Text = " PASO 3: Validación de código comentado"
        Me.grbpaso3.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(339, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "A continuación se muestra el resultado del analisis realizado a cada una de las e" & _
            "ntidades de la fuente de datos."
        '
        'btnClipboard
        '
        Me.btnClipboard.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClipboard.FlatAppearance.BorderSize = 0
        Me.btnClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClipboard.Image = CType(resources.GetObject("btnClipboard.Image"), System.Drawing.Image)
        Me.btnClipboard.Location = New System.Drawing.Point(208, 43)
        Me.btnClipboard.Name = "btnClipboard"
        Me.btnClipboard.Size = New System.Drawing.Size(24, 30)
        Me.btnClipboard.TabIndex = 6
        Me.btnClipboard.UseVisualStyleBackColor = True
        Me.btnClipboard.Visible = False
        '
        'cbofuente
        '
        Me.cbofuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofuente.FormattingEnabled = True
        Me.cbofuente.Location = New System.Drawing.Point(9, 50)
        Me.cbofuente.Name = "cbofuente"
        Me.cbofuente.Size = New System.Drawing.Size(337, 21)
        Me.cbofuente.TabIndex = 6
        '
        'grbpaso1
        '
        Me.grbpaso1.Controls.Add(Me.Label1)
        Me.grbpaso1.Controls.Add(Me.cbofuente)
        Me.grbpaso1.Location = New System.Drawing.Point(179, 2)
        Me.grbpaso1.Name = "grbpaso1"
        Me.grbpaso1.Size = New System.Drawing.Size(352, 244)
        Me.grbpaso1.TabIndex = 13
        Me.grbpaso1.TabStop = False
        Me.grbpaso1.Text = " PASO 1: Selección Fuente de Datos a validar "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "¿ Cual es la fuente de datos que se desea validar ?"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 2)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(170, 110)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 12
        Me.LogoPictureBox.TabStop = False
        '
        'frmQAValidaFuente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.grbpaso2)
        Me.Controls.Add(Me.grbpaso3)
        Me.Controls.Add(Me.grbpaso1)
        Me.Name = "frmQAValidaFuente"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Validación de la fuente de datos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grbpaso2.ResumeLayout(False)
        Me.grbpaso2.PerformLayout()
        Me.grbpaso3.ResumeLayout(False)
        Me.grbpaso1.ResumeLayout(False)
        Me.grbpaso1.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents prbvalidacion As System.Windows.Forms.ProgressBar
    Friend WithEvents btnleer As System.Windows.Forms.Button
    Friend WithEvents chkselectall As System.Windows.Forms.CheckBox
    Friend WithEvents clbEntidades As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnClipboard As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents btnterminar As System.Windows.Forms.Button
    Friend WithEvents btniniciar As System.Windows.Forms.Button
    Friend WithEvents grbpaso2 As System.Windows.Forms.GroupBox
    Friend WithEvents grbpaso3 As System.Windows.Forms.GroupBox
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cbofuente As System.Windows.Forms.ComboBox
    Friend WithEvents grbpaso1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
