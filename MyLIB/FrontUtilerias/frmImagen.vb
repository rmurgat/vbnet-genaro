Public Class frmImagen

    Private Sub frmImagen_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.picimagen.Top = 0
        Me.picimagen.Left = 0
        Me.picimagen.Width = Me.Width
        Me.picimagen.Height = Me.Height
    End Sub

    Private Sub frmImagen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Paint_FileImagen(ByVal sfile As String)
        Me.picimagen.Load(sfile)
    End Sub
End Class