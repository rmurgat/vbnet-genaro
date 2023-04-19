<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Me.txtnbproyecto = New System.Windows.Forms.TextBox()
        Me.lblcdproyecto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPersona = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cborolstaff = New System.Windows.Forms.ComboBox()
        Me.picpersona = New System.Windows.Forms.PictureBox()
        Me.picproyecto = New System.Windows.Forms.PictureBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtstaff = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcomentario = New System.Windows.Forms.TextBox()
        CType(Me.picpersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picproyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnbproyecto
        '
        Me.txtnbproyecto.Location = New System.Drawing.Point(197, 12)
        Me.txtnbproyecto.Name = "txtnbproyecto"
        Me.txtnbproyecto.ReadOnly = True
        Me.txtnbproyecto.Size = New System.Drawing.Size(400, 20)
        Me.txtnbproyecto.TabIndex = 6
        '
        'lblcdproyecto
        '
        Me.lblcdproyecto.Location = New System.Drawing.Point(91, 12)
        Me.lblcdproyecto.Name = "lblcdproyecto"
        Me.lblcdproyecto.ReadOnly = True
        Me.lblcdproyecto.Size = New System.Drawing.Size(100, 20)
        Me.lblcdproyecto.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Proyecto :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Persona :"
        '
        'cboPersona
        '
        Me.cboPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPersona.FormattingEnabled = True
        Me.cboPersona.Location = New System.Drawing.Point(91, 75)
        Me.cboPersona.Name = "cboPersona"
        Me.cboPersona.Size = New System.Drawing.Size(400, 21)
        Me.cboPersona.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Rol :"
        '
        'cborolstaff
        '
        Me.cborolstaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cborolstaff.FormattingEnabled = True
        Me.cborolstaff.Location = New System.Drawing.Point(91, 107)
        Me.cborolstaff.Name = "cborolstaff"
        Me.cborolstaff.Size = New System.Drawing.Size(273, 21)
        Me.cborolstaff.TabIndex = 10
        '
        'picpersona
        '
        Me.picpersona.Image = CType(resources.GetObject("picpersona.Image"), System.Drawing.Image)
        Me.picpersona.Location = New System.Drawing.Point(497, 75)
        Me.picpersona.Name = "picpersona"
        Me.picpersona.Size = New System.Drawing.Size(27, 21)
        Me.picpersona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpersona.TabIndex = 11
        Me.picpersona.TabStop = False
        '
        'picproyecto
        '
        Me.picproyecto.Image = CType(resources.GetObject("picproyecto.Image"), System.Drawing.Image)
        Me.picproyecto.Location = New System.Drawing.Point(603, 11)
        Me.picproyecto.Name = "picproyecto"
        Me.picproyecto.Size = New System.Drawing.Size(19, 21)
        Me.picproyecto.TabIndex = 12
        Me.picproyecto.TabStop = False
        '
        'btnGrabar
        '
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Location = New System.Drawing.Point(436, 231)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 13
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(528, 231)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 23)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Staff :"
        '
        'txtstaff
        '
        Me.txtstaff.Location = New System.Drawing.Point(91, 43)
        Me.txtstaff.Name = "txtstaff"
        Me.txtstaff.ReadOnly = True
        Me.txtstaff.Size = New System.Drawing.Size(100, 20)
        Me.txtstaff.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Comentario :"
        '
        'txtcomentario
        '
        Me.txtcomentario.Location = New System.Drawing.Point(91, 148)
        Me.txtcomentario.Multiline = True
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcomentario.Size = New System.Drawing.Size(531, 72)
        Me.txtcomentario.TabIndex = 18
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtcomentario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtstaff)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.picproyecto)
        Me.Controls.Add(Me.picpersona)
        Me.Controls.Add(Me.cborolstaff)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboPersona)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnbproyecto)
        Me.Controls.Add(Me.lblcdproyecto)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStaff"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GENARO - Staff"
        CType(Me.picpersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picproyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnbproyecto As System.Windows.Forms.TextBox
    Friend WithEvents lblcdproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboPersona As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cborolstaff As System.Windows.Forms.ComboBox
    Friend WithEvents picpersona As System.Windows.Forms.PictureBox
    Friend WithEvents picproyecto As System.Windows.Forms.PictureBox
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtstaff As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcomentario As System.Windows.Forms.TextBox

End Class
