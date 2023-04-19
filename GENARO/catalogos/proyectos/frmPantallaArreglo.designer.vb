<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPantallaArreglo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPantallaArreglo))
        Me.tabarreglo = New System.Windows.Forms.TabControl()
        Me.tabgeneral = New System.Windows.Forms.TabPage()
        Me.radoutput = New System.Windows.Forms.RadioButton()
        Me.radinput = New System.Windows.Forms.RadioButton()
        Me.chkpaginacion = New System.Windows.Forms.CheckBox()
        Me.txtregistros = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabhtml = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grdinout = New System.Windows.Forms.DataGridView()
        Me.cboidhtml = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tabobject = New System.Windows.Forms.TabPage()
        Me.txtnbElement = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.picobjobjdel = New System.Windows.Forms.PictureBox()
        Me.picobjobj = New System.Windows.Forms.PictureBox()
        Me.txtobjobj = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.picdelclase = New System.Windows.Forms.PictureBox()
        Me.picobjclase = New System.Windows.Forms.PictureBox()
        Me.txtclase = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboarreglo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnbpantalla = New System.Windows.Forms.TextBox()
        Me.txtcdpantalla = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnbproyecto = New System.Windows.Forms.TextBox()
        Me.txtcdproyecto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdgrabar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.tabarreglo.SuspendLayout()
        Me.tabgeneral.SuspendLayout()
        Me.tabhtml.SuspendLayout()
        CType(Me.grdinout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabobject.SuspendLayout()
        CType(Me.picobjobjdel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picobjobj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picdelclase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picobjclase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabarreglo
        '
        Me.tabarreglo.Controls.Add(Me.tabgeneral)
        Me.tabarreglo.Controls.Add(Me.tabhtml)
        Me.tabarreglo.Controls.Add(Me.tabobject)
        Me.tabarreglo.Location = New System.Drawing.Point(13, 98)
        Me.tabarreglo.Name = "tabarreglo"
        Me.tabarreglo.SelectedIndex = 0
        Me.tabarreglo.Size = New System.Drawing.Size(525, 163)
        Me.tabarreglo.TabIndex = 0
        '
        'tabgeneral
        '
        Me.tabgeneral.Controls.Add(Me.radoutput)
        Me.tabgeneral.Controls.Add(Me.radinput)
        Me.tabgeneral.Controls.Add(Me.chkpaginacion)
        Me.tabgeneral.Controls.Add(Me.txtregistros)
        Me.tabgeneral.Controls.Add(Me.Label7)
        Me.tabgeneral.Controls.Add(Me.txtNombre)
        Me.tabgeneral.Controls.Add(Me.Label1)
        Me.tabgeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabgeneral.Name = "tabgeneral"
        Me.tabgeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabgeneral.Size = New System.Drawing.Size(517, 137)
        Me.tabgeneral.TabIndex = 0
        Me.tabgeneral.Text = "General"
        Me.tabgeneral.UseVisualStyleBackColor = True
        '
        'radoutput
        '
        Me.radoutput.AutoSize = True
        Me.radoutput.Location = New System.Drawing.Point(434, 18)
        Me.radoutput.Name = "radoutput"
        Me.radoutput.Size = New System.Drawing.Size(63, 17)
        Me.radoutput.TabIndex = 70
        Me.radoutput.Text = "SALIDA"
        Me.radoutput.UseVisualStyleBackColor = True
        '
        'radinput
        '
        Me.radinput.AutoSize = True
        Me.radinput.Checked = True
        Me.radinput.Location = New System.Drawing.Point(351, 18)
        Me.radinput.Name = "radinput"
        Me.radinput.Size = New System.Drawing.Size(77, 17)
        Me.radinput.TabIndex = 69
        Me.radinput.TabStop = True
        Me.radinput.Text = "ENTRADA"
        Me.radinput.UseVisualStyleBackColor = True
        '
        'chkpaginacion
        '
        Me.chkpaginacion.AutoSize = True
        Me.chkpaginacion.Location = New System.Drawing.Point(18, 83)
        Me.chkpaginacion.Name = "chkpaginacion"
        Me.chkpaginacion.Size = New System.Drawing.Size(129, 17)
        Me.chkpaginacion.TabIndex = 59
        Me.chkpaginacion.Text = "¿ Tiene paginación ? "
        Me.chkpaginacion.UseVisualStyleBackColor = True
        '
        'txtregistros
        '
        Me.txtregistros.Location = New System.Drawing.Point(141, 52)
        Me.txtregistros.MaxLength = 60
        Me.txtregistros.Name = "txtregistros"
        Me.txtregistros.Size = New System.Drawing.Size(50, 20)
        Me.txtregistros.TabIndex = 58
        Me.txtregistros.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Elementos por pantalla : "
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(74, 17)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(232, 20)
        Me.txtNombre.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre : "
        '
        'tabhtml
        '
        Me.tabhtml.Controls.Add(Me.Label8)
        Me.tabhtml.Controls.Add(Me.grdinout)
        Me.tabhtml.Controls.Add(Me.cboidhtml)
        Me.tabhtml.Controls.Add(Me.Label5)
        Me.tabhtml.Location = New System.Drawing.Point(4, 22)
        Me.tabhtml.Name = "tabhtml"
        Me.tabhtml.Padding = New System.Windows.Forms.Padding(3)
        Me.tabhtml.Size = New System.Drawing.Size(517, 137)
        Me.tabhtml.TabIndex = 1
        Me.tabhtml.Text = "Sync HTML"
        Me.tabhtml.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Compuesto por :"
        '
        'grdinout
        '
        Me.grdinout.AllowUserToAddRows = False
        Me.grdinout.AllowUserToDeleteRows = False
        Me.grdinout.AllowUserToResizeRows = False
        Me.grdinout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdinout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdinout.Location = New System.Drawing.Point(99, 62)
        Me.grdinout.MultiSelect = False
        Me.grdinout.Name = "grdinout"
        Me.grdinout.ReadOnly = True
        Me.grdinout.RowHeadersVisible = False
        Me.grdinout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdinout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdinout.Size = New System.Drawing.Size(412, 69)
        Me.grdinout.TabIndex = 72
        '
        'cboidhtml
        '
        Me.cboidhtml.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboidhtml.FormattingEnabled = True
        Me.cboidhtml.Location = New System.Drawing.Point(307, 23)
        Me.cboidhtml.Name = "cboidhtml"
        Me.cboidhtml.Size = New System.Drawing.Size(121, 21)
        Me.cboidhtml.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Renglón de la tabla sobre el que se hace la variación: "
        '
        'tabobject
        '
        Me.tabobject.Controls.Add(Me.txtnbElement)
        Me.tabobject.Controls.Add(Me.Label6)
        Me.tabobject.Controls.Add(Me.picobjobjdel)
        Me.tabobject.Controls.Add(Me.picobjobj)
        Me.tabobject.Controls.Add(Me.txtobjobj)
        Me.tabobject.Controls.Add(Me.Label18)
        Me.tabobject.Controls.Add(Me.picdelclase)
        Me.tabobject.Controls.Add(Me.picobjclase)
        Me.tabobject.Controls.Add(Me.txtclase)
        Me.tabobject.Controls.Add(Me.Label15)
        Me.tabobject.Location = New System.Drawing.Point(4, 22)
        Me.tabobject.Name = "tabobject"
        Me.tabobject.Size = New System.Drawing.Size(517, 137)
        Me.tabobject.TabIndex = 2
        Me.tabobject.Text = "Sync Class-Object"
        Me.tabobject.UseVisualStyleBackColor = True
        '
        'txtnbElement
        '
        Me.txtnbElement.Location = New System.Drawing.Point(203, 45)
        Me.txtnbElement.MaxLength = 40
        Me.txtnbElement.Name = "txtnbElement"
        Me.txtnbElement.Size = New System.Drawing.Size(107, 20)
        Me.txtnbElement.TabIndex = 27
        Me.txtnbElement.Text = "orow"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(21, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Nombre de Objeto para Elemento:"
        '
        'picobjobjdel
        '
        Me.picobjobjdel.Image = CType(resources.GetObject("picobjobjdel.Image"), System.Drawing.Image)
        Me.picobjobjdel.Location = New System.Drawing.Point(345, 77)
        Me.picobjobjdel.Name = "picobjobjdel"
        Me.picobjobjdel.Size = New System.Drawing.Size(19, 20)
        Me.picobjobjdel.TabIndex = 25
        Me.picobjobjdel.TabStop = False
        '
        'picobjobj
        '
        Me.picobjobj.Image = CType(resources.GetObject("picobjobj.Image"), System.Drawing.Image)
        Me.picobjobj.Location = New System.Drawing.Point(316, 77)
        Me.picobjobj.Name = "picobjobj"
        Me.picobjobj.Size = New System.Drawing.Size(21, 20)
        Me.picobjobj.TabIndex = 24
        Me.picobjobj.TabStop = False
        '
        'txtobjobj
        '
        Me.txtobjobj.Location = New System.Drawing.Point(203, 77)
        Me.txtobjobj.Name = "txtobjobj"
        Me.txtobjobj.Size = New System.Drawing.Size(107, 20)
        Me.txtobjobj.TabIndex = 23
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(21, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(155, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Nombre del Objeto con Arreglo:"
        '
        'picdelclase
        '
        Me.picdelclase.Image = CType(resources.GetObject("picdelclase.Image"), System.Drawing.Image)
        Me.picdelclase.Location = New System.Drawing.Point(343, 17)
        Me.picdelclase.Name = "picdelclase"
        Me.picdelclase.Size = New System.Drawing.Size(19, 20)
        Me.picdelclase.TabIndex = 21
        Me.picdelclase.TabStop = False
        '
        'picobjclase
        '
        Me.picobjclase.Image = CType(resources.GetObject("picobjclase.Image"), System.Drawing.Image)
        Me.picobjclase.Location = New System.Drawing.Point(316, 17)
        Me.picobjclase.Name = "picobjclase"
        Me.picobjclase.Size = New System.Drawing.Size(21, 20)
        Me.picobjclase.TabIndex = 20
        Me.picobjclase.TabStop = False
        '
        'txtclase
        '
        Me.txtclase.Location = New System.Drawing.Point(203, 17)
        Me.txtclase.Name = "txtclase"
        Me.txtclase.ReadOnly = True
        Me.txtclase.Size = New System.Drawing.Size(107, 20)
        Me.txtclase.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(21, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(176, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Clase de cada Elemento en Arreglo:"
        '
        'cboarreglo
        '
        Me.cboarreglo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboarreglo.FormattingEnabled = True
        Me.cboarreglo.Location = New System.Drawing.Point(83, 63)
        Me.cboarreglo.Name = "cboarreglo"
        Me.cboarreglo.Size = New System.Drawing.Size(362, 21)
        Me.cboarreglo.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Arreglo :"
        '
        'txtnbpantalla
        '
        Me.txtnbpantalla.Location = New System.Drawing.Point(147, 36)
        Me.txtnbpantalla.Name = "txtnbpantalla"
        Me.txtnbpantalla.ReadOnly = True
        Me.txtnbpantalla.Size = New System.Drawing.Size(298, 20)
        Me.txtnbpantalla.TabIndex = 58
        '
        'txtcdpantalla
        '
        Me.txtcdpantalla.Location = New System.Drawing.Point(83, 36)
        Me.txtcdpantalla.Name = "txtcdpantalla"
        Me.txtcdpantalla.ReadOnly = True
        Me.txtcdpantalla.Size = New System.Drawing.Size(58, 20)
        Me.txtcdpantalla.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Pantalla :"
        '
        'txtnbproyecto
        '
        Me.txtnbproyecto.Location = New System.Drawing.Point(147, 6)
        Me.txtnbproyecto.Name = "txtnbproyecto"
        Me.txtnbproyecto.ReadOnly = True
        Me.txtnbproyecto.Size = New System.Drawing.Size(298, 20)
        Me.txtnbproyecto.TabIndex = 55
        '
        'txtcdproyecto
        '
        Me.txtcdproyecto.Location = New System.Drawing.Point(83, 6)
        Me.txtcdproyecto.Name = "txtcdproyecto"
        Me.txtcdproyecto.ReadOnly = True
        Me.txtcdproyecto.Size = New System.Drawing.Size(58, 20)
        Me.txtcdproyecto.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Proyecto :"
        '
        'cmdgrabar
        '
        Me.cmdgrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdgrabar.Location = New System.Drawing.Point(451, 34)
        Me.cmdgrabar.Name = "cmdgrabar"
        Me.cmdgrabar.Size = New System.Drawing.Size(87, 23)
        Me.cmdgrabar.TabIndex = 69
        Me.cmdgrabar.Text = "Grabar"
        Me.cmdgrabar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(451, 6)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(87, 23)
        Me.btnsalir.TabIndex = 68
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'frmPantallaArreglo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 273)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdgrabar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.cboarreglo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnbpantalla)
        Me.Controls.Add(Me.txtcdpantalla)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnbproyecto)
        Me.Controls.Add(Me.txtcdproyecto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tabarreglo)
        Me.Name = "frmPantallaArreglo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Detalle de un arreglo"
        Me.tabarreglo.ResumeLayout(False)
        Me.tabgeneral.ResumeLayout(False)
        Me.tabgeneral.PerformLayout()
        Me.tabhtml.ResumeLayout(False)
        Me.tabhtml.PerformLayout()
        CType(Me.grdinout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabobject.ResumeLayout(False)
        Me.tabobject.PerformLayout()
        CType(Me.picobjobjdel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picobjobj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picdelclase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picobjclase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabarreglo As System.Windows.Forms.TabControl
    Friend WithEvents tabgeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabhtml As System.Windows.Forms.TabPage
    Friend WithEvents tabobject As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboarreglo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnbpantalla As System.Windows.Forms.TextBox
    Friend WithEvents txtcdpantalla As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnbproyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtcdproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdgrabar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cboidhtml As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents picobjobjdel As System.Windows.Forms.PictureBox
    Friend WithEvents picobjobj As System.Windows.Forms.PictureBox
    Friend WithEvents txtobjobj As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents picdelclase As System.Windows.Forms.PictureBox
    Friend WithEvents picobjclase As System.Windows.Forms.PictureBox
    Friend WithEvents txtclase As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkpaginacion As System.Windows.Forms.CheckBox
    Friend WithEvents txtregistros As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents radoutput As System.Windows.Forms.RadioButton
    Friend WithEvents radinput As System.Windows.Forms.RadioButton
    Friend WithEvents txtnbElement As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grdinout As System.Windows.Forms.DataGridView
End Class
