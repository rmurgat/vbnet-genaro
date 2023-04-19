<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpmiprojects
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboEstatus = New System.Windows.Forms.ComboBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnprydel = New System.Windows.Forms.Button()
        Me.btnpryadd = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.ProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbodetalle = New System.Windows.Forms.Button()
        Me.txttotprojects = New System.Windows.Forms.TextBox()
        Me.gridprojects = New System.Windows.Forms.DataGridView()
        CType(Me.ProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridprojects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente : "
        '
        'cboCliente
        '
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(125, 16)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(224, 21)
        Me.cboCliente.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Estatus : "
        '
        'cboEstatus
        '
        Me.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstatus.FormattingEnabled = True
        Me.cboEstatus.Location = New System.Drawing.Point(125, 50)
        Me.cboEstatus.Name = "cboEstatus"
        Me.cboEstatus.Size = New System.Drawing.Size(199, 21)
        Me.cboEstatus.TabIndex = 7
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(648, 14)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(119, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnprydel
        '
        Me.btnprydel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnprydel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprydel.Location = New System.Drawing.Point(712, 352)
        Me.btnprydel.Name = "btnprydel"
        Me.btnprydel.Size = New System.Drawing.Size(25, 20)
        Me.btnprydel.TabIndex = 10
        Me.btnprydel.Text = "-"
        Me.btnprydel.UseVisualStyleBackColor = True
        '
        'btnpryadd
        '
        Me.btnpryadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpryadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpryadd.Location = New System.Drawing.Point(743, 352)
        Me.btnpryadd.Name = "btnpryadd"
        Me.btnpryadd.Size = New System.Drawing.Size(25, 20)
        Me.btnpryadd.TabIndex = 9
        Me.btnpryadd.Text = "+"
        Me.btnpryadd.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(648, 43)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(119, 23)
        Me.btnbuscar.TabIndex = 11
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(24, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(743, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "PROYECTOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbodetalle
        '
        Me.cbodetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbodetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodetalle.Location = New System.Drawing.Point(24, 352)
        Me.cbodetalle.Name = "cbodetalle"
        Me.cbodetalle.Size = New System.Drawing.Size(86, 20)
        Me.cbodetalle.TabIndex = 14
        Me.cbodetalle.Text = "ver detalle"
        Me.cbodetalle.UseVisualStyleBackColor = True
        '
        'txttotprojects
        '
        Me.txttotprojects.Location = New System.Drawing.Point(116, 352)
        Me.txttotprojects.Name = "txttotprojects"
        Me.txttotprojects.ReadOnly = True
        Me.txttotprojects.Size = New System.Drawing.Size(590, 20)
        Me.txttotprojects.TabIndex = 15
        Me.txttotprojects.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gridprojects
        '
        Me.gridprojects.AllowUserToAddRows = False
        Me.gridprojects.AllowUserToDeleteRows = False
        Me.gridprojects.AllowUserToOrderColumns = True
        Me.gridprojects.AllowUserToResizeRows = False
        Me.gridprojects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridprojects.Location = New System.Drawing.Point(25, 109)
        Me.gridprojects.Name = "gridprojects"
        Me.gridprojects.ReadOnly = True
        Me.gridprojects.RowHeadersVisible = False
        Me.gridprojects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridprojects.Size = New System.Drawing.Size(742, 237)
        Me.gridprojects.TabIndex = 30
        '
        'frmpmiprojects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 385)
        Me.ControlBox = False
        Me.Controls.Add(Me.gridprojects)
        Me.Controls.Add(Me.txttotprojects)
        Me.Controls.Add(Me.cbodetalle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnprydel)
        Me.Controls.Add(Me.btnpryadd)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cboEstatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        'Me.Name = "frmpmiprojects"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GENARO - Listado de proyectos"
        CType(Me.ProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridprojects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnprydel As System.Windows.Forms.Button
    Friend WithEvents btnpryadd As System.Windows.Forms.Button
    Friend WithEvents Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbodetalle As System.Windows.Forms.Button
    Friend WithEvents ProyectoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txttotprojects As System.Windows.Forms.TextBox
    Friend WithEvents gridprojects As System.Windows.Forms.DataGridView
End Class
