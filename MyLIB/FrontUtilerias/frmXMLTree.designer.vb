<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXMLTree
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXMLTree))
        Me.treXML = New System.Windows.Forms.TreeView
        Me.btnload = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'treXML
        '
        Me.treXML.Location = New System.Drawing.Point(12, 12)
        Me.treXML.Name = "treXML"
        Me.treXML.Size = New System.Drawing.Size(336, 426)
        Me.treXML.TabIndex = 0
        '
        'btnload
        '
        Me.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnload.Location = New System.Drawing.Point(12, 436)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(47, 20)
        Me.btnload.TabIndex = 19
        Me.btnload.Text = "load"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(354, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmXMLTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 464)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.treXML)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmXMLTree"
        Me.Text = "frmXML"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents treXML As System.Windows.Forms.TreeView
    Friend WithEvents btnload As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
