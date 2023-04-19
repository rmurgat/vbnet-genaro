<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSteackholder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSteackholder))
        Me.txtcomentario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsteackholder = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.picproyecto = New System.Windows.Forms.PictureBox()
        Me.picpersona = New System.Windows.Forms.PictureBox()
        Me.cboPersona = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnbproyecto = New System.Windows.Forms.TextBox()
        Me.lblcdproyecto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picproyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcomentario
        '
        Me.txtcomentario.Location = New System.Drawing.Point(83, 113)
        Me.txtcomentario.Multiline = True
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcomentario.Size = New System.Drawing.Size(531, 83)
        Me.txtcomentario.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Comentario :"
        '
        'txtsteackholder
        '
        Me.txtsteackholder.Location = New System.Drawing.Point(83, 43)
        Me.txtsteackholder.Name = "txtsteackholder"
        Me.txtsteackholder.ReadOnly = True
        Me.txtsteackholder.Size = New System.Drawing.Size(100, 20)
        Me.txtsteackholder.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Steckholder :"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(520, 202)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 23)
        Me.btnSalir.TabIndex = 29
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Location = New System.Drawing.Point(428, 202)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 28
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'picproyecto
        '
        Me.picproyecto.Image = CType(resources.GetObject("picproyecto.Image"), System.Drawing.Image)
        Me.picproyecto.Location = New System.Drawing.Point(595, 11)
        Me.picproyecto.Name = "picproyecto"
        Me.picproyecto.Size = New System.Drawing.Size(19, 21)
        Me.picproyecto.TabIndex = 27
        Me.picproyecto.TabStop = False
        '
        'picpersona
        '
        Me.picpersona.Image = CType(resources.GetObject("picpersona.Image"), System.Drawing.Image)
        Me.picpersona.Location = New System.Drawing.Point(489, 75)
        Me.picpersona.Name = "picpersona"
        Me.picpersona.Size = New System.Drawing.Size(27, 21)
        Me.picpersona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpersona.TabIndex = 26
        Me.picpersona.TabStop = False
        '
        'cboPersona
        '
        Me.cboPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPersona.FormattingEnabled = True
        Me.cboPersona.Location = New System.Drawing.Point(83, 75)
        Me.cboPersona.Name = "cboPersona"
        Me.cboPersona.Size = New System.Drawing.Size(400, 21)
        Me.cboPersona.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Persona :"
        '
        'txtnbproyecto
        '
        Me.txtnbproyecto.Location = New System.Drawing.Point(189, 12)
        Me.txtnbproyecto.Name = "txtnbproyecto"
        Me.txtnbproyecto.ReadOnly = True
        Me.txtnbproyecto.Size = New System.Drawing.Size(400, 20)
        Me.txtnbproyecto.TabIndex = 21
        '
        'lblcdproyecto
        '
        Me.lblcdproyecto.Location = New System.Drawing.Point(83, 12)
        Me.lblcdproyecto.Name = "lblcdproyecto"
        Me.lblcdproyecto.ReadOnly = True
        Me.lblcdproyecto.Size = New System.Drawing.Size(100, 20)
        Me.lblcdproyecto.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Proyecto :"
        '
        'frmSteackholder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtcomentario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsteackholder)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.picproyecto)
        Me.Controls.Add(Me.picpersona)
        Me.Controls.Add(Me.cboPersona)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnbproyecto)
        Me.Controls.Add(Me.lblcdproyecto)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSteackholder"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Datos de Steackholder"
        CType(Me.picproyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcomentario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsteackholder As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents picproyecto As System.Windows.Forms.PictureBox
    Friend WithEvents picpersona As System.Windows.Forms.PictureBox
    Friend WithEvents cboPersona As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnbproyecto As System.Windows.Forms.TextBox
    Friend WithEvents lblcdproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
