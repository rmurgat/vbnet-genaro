<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcargaconfiguracion
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
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExplorar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.txttemplate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.txtautor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstdebug = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncerrar.Location = New System.Drawing.Point(490, 44)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(117, 23)
        Me.btncerrar.TabIndex = 1
        Me.btncerrar.Text = "Cancelar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExplorar)
        Me.GroupBox1.Controls.Add(Me.btnCargar)
        Me.GroupBox1.Controls.Add(Me.txttemplate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtdescription)
        Me.GroupBox1.Controls.Add(Me.txtdate)
        Me.GroupBox1.Controls.Add(Me.txtautor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 225)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generales"
        '
        'btnExplorar
        '
        Me.btnExplorar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExplorar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExplorar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExplorar.Location = New System.Drawing.Point(392, 21)
        Me.btnExplorar.Name = "btnExplorar"
        Me.btnExplorar.Size = New System.Drawing.Size(41, 20)
        Me.btnExplorar.TabIndex = 12
        Me.btnExplorar.Text = "Ver..."
        Me.btnExplorar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCargar
        '
        Me.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCargar.Location = New System.Drawing.Point(316, 47)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(117, 23)
        Me.btnCargar.TabIndex = 5
        Me.btnCargar.Text = "Cargar"
        '
        'txttemplate
        '
        Me.txttemplate.Location = New System.Drawing.Point(86, 21)
        Me.txttemplate.Name = "txttemplate"
        Me.txttemplate.ReadOnly = True
        Me.txttemplate.Size = New System.Drawing.Size(300, 20)
        Me.txttemplate.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Configuración :"
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(86, 136)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.ReadOnly = True
        Me.txtdescription.Size = New System.Drawing.Size(347, 76)
        Me.txtdescription.TabIndex = 9
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(86, 106)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.ReadOnly = True
        Me.txtdate.Size = New System.Drawing.Size(207, 20)
        Me.txtdate.TabIndex = 8
        '
        'txtautor
        '
        Me.txtautor.Location = New System.Drawing.Point(86, 76)
        Me.txtautor.Name = "txtautor"
        Me.txtautor.ReadOnly = True
        Me.txtautor.Size = New System.Drawing.Size(347, 20)
        Me.txtautor.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Description  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Autor :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstdebug)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 224)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " INFO"
        '
        'lstdebug
        '
        Me.lstdebug.FormattingEnabled = True
        Me.lstdebug.Location = New System.Drawing.Point(14, 21)
        Me.lstdebug.Name = "lstdebug"
        Me.lstdebug.Size = New System.Drawing.Size(574, 199)
        Me.lstdebug.TabIndex = 0
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAceptar.Location = New System.Drawing.Point(490, 12)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 23)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmcargaconfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 479)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btncerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmcargaconfiguracion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GENARO - Carga del archivo de configuración..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstdebug As System.Windows.Forms.ListBox
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txtautor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttemplate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents btnExplorar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAceptar As System.Windows.Forms.Button

End Class
