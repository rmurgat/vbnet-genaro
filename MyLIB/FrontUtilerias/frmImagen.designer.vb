<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImagen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImagen))
        Me.picimagen = New System.Windows.Forms.PictureBox()
        CType(Me.picimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picimagen
        '
        Me.picimagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picimagen.Location = New System.Drawing.Point(12, 12)
        Me.picimagen.Name = "picimagen"
        Me.picimagen.Size = New System.Drawing.Size(619, 443)
        Me.picimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picimagen.TabIndex = 0
        Me.picimagen.TabStop = False
        '
        'frmImagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 467)
        Me.Controls.Add(Me.picimagen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImagen"
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Visualizador de Imagen"
        CType(Me.picimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picimagen As System.Windows.Forms.PictureBox
End Class
