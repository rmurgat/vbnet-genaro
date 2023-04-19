<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmeditor
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
        Me.rtbeditor = New System.Windows.Forms.RichTextBox
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.FontDialog = New System.Windows.Forms.FontDialog
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrabarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrabarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopiarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.FuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtbeditor
        '
        Me.rtbeditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbeditor.Location = New System.Drawing.Point(15, 31)
        Me.rtbeditor.Name = "rtbeditor"
        Me.rtbeditor.Size = New System.Drawing.Size(520, 293)
        Me.rtbeditor.TabIndex = 1
        Me.rtbeditor.Text = ""
        '
        'FontDialog
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(549, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(549, 24)
        Me.MenuStrip2.TabIndex = 3
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrabarToolStripMenuItem, Me.GrabarComoToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'GrabarToolStripMenuItem
        '
        Me.GrabarToolStripMenuItem.Name = "GrabarToolStripMenuItem"
        Me.GrabarToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.GrabarToolStripMenuItem.Text = "Grabar..."
        '
        'GrabarComoToolStripMenuItem
        '
        Me.GrabarComoToolStripMenuItem.Name = "GrabarComoToolStripMenuItem"
        Me.GrabarComoToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.GrabarComoToolStripMenuItem.Text = "Grabar como..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(155, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarTodoToolStripMenuItem, Me.ToolStripSeparator2, Me.FuenteToolStripMenuItem})
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.FontToolStripMenuItem.Text = "Edición"
        '
        'CopiarTodoToolStripMenuItem
        '
        Me.CopiarTodoToolStripMenuItem.Name = "CopiarTodoToolStripMenuItem"
        Me.CopiarTodoToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CopiarTodoToolStripMenuItem.Text = "Copiar todo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(138, 6)
        '
        'FuenteToolStripMenuItem
        '
        Me.FuenteToolStripMenuItem.Name = "FuenteToolStripMenuItem"
        Me.FuenteToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.FuenteToolStripMenuItem.Text = "Fuente..."
        '
        'frmeditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(549, 336)
        Me.Controls.Add(Me.rtbeditor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmeditor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbeditor As System.Windows.Forms.RichTextBox
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrabarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrabarComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FuenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
