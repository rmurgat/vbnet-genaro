<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPantallaTools
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
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radeliminar = New System.Windows.Forms.RadioButton()
        Me.radcopiar = New System.Windows.Forms.RadioButton()
        Me.txtnbpantalla = New System.Windows.Forms.TextBox()
        Me.txtcdpantalla = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnbproyecto = New System.Windows.Forms.TextBox()
        Me.txtcdproyecto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panCopiar = New System.Windows.Forms.Panel()
        Me.picpreview = New System.Windows.Forms.PictureBox()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.chkevento = New System.Windows.Forms.CheckBox()
        Me.chkio = New System.Windows.Forms.CheckBox()
        Me.chkboton = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbopantalla = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboproyecto = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.panCopiar.SuspendLayout()
        CType(Me.picpreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(449, 12)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(87, 23)
        Me.btnsalir.TabIndex = 52
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radeliminar)
        Me.GroupBox1.Controls.Add(Me.radcopiar)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 49)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Operaciones "
        '
        'radeliminar
        '
        Me.radeliminar.AutoSize = True
        Me.radeliminar.Location = New System.Drawing.Point(157, 19)
        Me.radeliminar.Name = "radeliminar"
        Me.radeliminar.Size = New System.Drawing.Size(61, 17)
        Me.radeliminar.TabIndex = 1
        Me.radeliminar.Text = "Eliminar"
        Me.radeliminar.UseVisualStyleBackColor = True
        '
        'radcopiar
        '
        Me.radcopiar.AutoSize = True
        Me.radcopiar.Checked = True
        Me.radcopiar.Location = New System.Drawing.Point(67, 19)
        Me.radcopiar.Name = "radcopiar"
        Me.radcopiar.Size = New System.Drawing.Size(58, 17)
        Me.radcopiar.TabIndex = 0
        Me.radcopiar.TabStop = True
        Me.radcopiar.Text = "Copiar "
        Me.radcopiar.UseVisualStyleBackColor = True
        '
        'txtnbpantalla
        '
        Me.txtnbpantalla.Location = New System.Drawing.Point(145, 44)
        Me.txtnbpantalla.Name = "txtnbpantalla"
        Me.txtnbpantalla.ReadOnly = True
        Me.txtnbpantalla.Size = New System.Drawing.Size(298, 20)
        Me.txtnbpantalla.TabIndex = 64
        '
        'txtcdpantalla
        '
        Me.txtcdpantalla.Location = New System.Drawing.Point(81, 44)
        Me.txtcdpantalla.Name = "txtcdpantalla"
        Me.txtcdpantalla.ReadOnly = True
        Me.txtcdpantalla.Size = New System.Drawing.Size(58, 20)
        Me.txtcdpantalla.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Pantalla :"
        '
        'txtnbproyecto
        '
        Me.txtnbproyecto.Location = New System.Drawing.Point(145, 14)
        Me.txtnbproyecto.Name = "txtnbproyecto"
        Me.txtnbproyecto.ReadOnly = True
        Me.txtnbproyecto.Size = New System.Drawing.Size(298, 20)
        Me.txtnbproyecto.TabIndex = 61
        '
        'txtcdproyecto
        '
        Me.txtcdproyecto.Location = New System.Drawing.Point(81, 14)
        Me.txtcdproyecto.Name = "txtcdproyecto"
        Me.txtcdproyecto.ReadOnly = True
        Me.txtcdproyecto.Size = New System.Drawing.Size(58, 20)
        Me.txtcdproyecto.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Proyecto :"
        '
        'panCopiar
        '
        Me.panCopiar.Controls.Add(Me.picpreview)
        Me.panCopiar.Controls.Add(Me.btniniciar)
        Me.panCopiar.Controls.Add(Me.chkevento)
        Me.panCopiar.Controls.Add(Me.chkio)
        Me.panCopiar.Controls.Add(Me.chkboton)
        Me.panCopiar.Controls.Add(Me.Label6)
        Me.panCopiar.Controls.Add(Me.cbopantalla)
        Me.panCopiar.Controls.Add(Me.Label5)
        Me.panCopiar.Controls.Add(Me.cboproyecto)
        Me.panCopiar.Controls.Add(Me.Label4)
        Me.panCopiar.Controls.Add(Me.Label1)
        Me.panCopiar.Location = New System.Drawing.Point(15, 139)
        Me.panCopiar.Name = "panCopiar"
        Me.panCopiar.Size = New System.Drawing.Size(521, 272)
        Me.panCopiar.TabIndex = 65
        '
        'picpreview
        '
        Me.picpreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picpreview.Location = New System.Drawing.Point(246, 110)
        Me.picpreview.Name = "picpreview"
        Me.picpreview.Size = New System.Drawing.Size(267, 151)
        Me.picpreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpreview.TabIndex = 70
        Me.picpreview.TabStop = False
        '
        'btniniciar
        '
        Me.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btniniciar.Location = New System.Drawing.Point(426, 20)
        Me.btniniciar.Name = "btniniciar"
        Me.btniniciar.Size = New System.Drawing.Size(87, 23)
        Me.btniniciar.TabIndex = 69
        Me.btniniciar.Text = "COPIAR"
        Me.btniniciar.UseVisualStyleBackColor = True
        '
        'chkevento
        '
        Me.chkevento.AutoSize = True
        Me.chkevento.Checked = True
        Me.chkevento.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkevento.Location = New System.Drawing.Point(18, 184)
        Me.chkevento.Name = "chkevento"
        Me.chkevento.Size = New System.Drawing.Size(65, 17)
        Me.chkevento.TabIndex = 68
        Me.chkevento.Text = "Eventos"
        Me.chkevento.UseVisualStyleBackColor = True
        '
        'chkio
        '
        Me.chkio.AutoSize = True
        Me.chkio.Checked = True
        Me.chkio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkio.Location = New System.Drawing.Point(18, 161)
        Me.chkio.Name = "chkio"
        Me.chkio.Size = New System.Drawing.Size(98, 17)
        Me.chkio.TabIndex = 67
        Me.chkio.Text = "Input / Outputs"
        Me.chkio.UseVisualStyleBackColor = True
        '
        'chkboton
        '
        Me.chkboton.AutoSize = True
        Me.chkboton.Checked = True
        Me.chkboton.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkboton.Location = New System.Drawing.Point(18, 138)
        Me.chkboton.Name = "chkboton"
        Me.chkboton.Size = New System.Drawing.Size(65, 17)
        Me.chkboton.TabIndex = 66
        Me.chkboton.Text = "Botones"
        Me.chkboton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Elementos de la pantalla que desea copiar :"
        '
        'cbopantalla
        '
        Me.cbopantalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopantalla.FormattingEnabled = True
        Me.cbopantalla.Location = New System.Drawing.Point(86, 73)
        Me.cbopantalla.Name = "cbopantalla"
        Me.cbopantalla.Size = New System.Drawing.Size(427, 21)
        Me.cbopantalla.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Pantalla :"
        '
        'cboproyecto
        '
        Me.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboproyecto.FormattingEnabled = True
        Me.cboproyecto.Location = New System.Drawing.Point(86, 45)
        Me.cboproyecto.Name = "cboproyecto"
        Me.cboproyecto.Size = New System.Drawing.Size(328, 21)
        Me.cboproyecto.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Proyecto :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pantalla Origen desde la cual se desea copiar :"
        '
        'frmPantallaTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.panCopiar)
        Me.Controls.Add(Me.txtnbpantalla)
        Me.Controls.Add(Me.txtcdpantalla)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnbproyecto)
        Me.Controls.Add(Me.txtcdproyecto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsalir)
        Me.Name = "frmPantallaTools"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Utileria de pantalla"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panCopiar.ResumeLayout(False)
        Me.panCopiar.PerformLayout()
        CType(Me.picpreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radeliminar As System.Windows.Forms.RadioButton
    Friend WithEvents radcopiar As System.Windows.Forms.RadioButton
    Friend WithEvents txtnbpantalla As System.Windows.Forms.TextBox
    Friend WithEvents txtcdpantalla As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnbproyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtcdproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panCopiar As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbopantalla As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboproyecto As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkevento As System.Windows.Forms.CheckBox
    Friend WithEvents chkio As System.Windows.Forms.CheckBox
    Friend WithEvents chkboton As System.Windows.Forms.CheckBox
    Friend WithEvents btniniciar As System.Windows.Forms.Button
    Friend WithEvents picpreview As System.Windows.Forms.PictureBox
End Class
