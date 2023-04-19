Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Windows.Forms

Public Class frmeditor
    Private outil As Utilerias

    Public Function Carga_Archivo(ByVal snombre As String) As Boolean
        Dim oread As System.IO.StreamReader

        If snombre.Trim.Equals("") Then
            MsgBox("Es necesario que seleccione primero un archivo", MsgBoxStyle.Exclamation, "MyLIB")
            Return False
        End If

        If Not outil.Existe_Archivo(snombre) Then
            MsgBox("El archivo que se pretende abrir no existe", MsgBoxStyle.Exclamation, "MyLIB")
            Return False
        End If

        Try
            oread = New StreamReader(snombre, System.Text.Encoding.GetEncoding(28593))      'Abre el archivo   
            Me.Text = snombre
            Me.rtbeditor.Text = oread.ReadToEnd.ToString
            oread.Close()
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyLIB.frmeditor.Carga_Archivo()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
        Return True
    End Function

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmeditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        outil = New Utilerias()
    End Sub

    Private Sub frmeditor_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.rtbeditor.Width = Me.Width - 20
        Me.rtbeditor.Height = Me.Height - 70
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub btngrabarcomo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub Paint_Text(ByVal stext As String)
        Me.rtbeditor.Text = stext
    End Sub

    Private Sub FontDialog1_Apply(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontDialog.Apply

    End Sub

    Private Sub cmdfont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FontDialog.ShowColor = False
        FontDialog.Font = rtbeditor.Font
        If FontDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            rtbeditor.Font = FontDialog.Font
        End If
    End Sub

    Private Sub GrabarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrabarToolStripMenuItem.Click
        Try
            If Me.Text.Equals("") Then
                SaveFileDialog.Title = "Grabar..."
                SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                SaveFileDialog.Filter = "Todos (*.*)|*.*"
                If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                    Me.Text = SaveFileDialog.FileName
                    Me.rtbeditor.SaveFile(Me.Text, RichTextBoxStreamType.PlainText)
                    MsgBox("El archivo creado exitosamente!", MsgBoxStyle.Information, "ATL Suit Tools")
                End If
            Else
                Me.rtbeditor.SaveFile(Me.Text, RichTextBoxStreamType.PlainText)
                MsgBox("El archivo fué actualizado exitosamente!", MsgBoxStyle.Information, "ATL Suit Tools")
            End If
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyLIB.frmeditor.btngrabar_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub GrabarComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrabarComoToolStripMenuItem.Click
        SaveFileDialog.Title = "Grabar Como..."
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Todos (*.*)|*.*"
        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.Text = SaveFileDialog.FileName
            Me.rtbeditor.SaveFile(Me.Text, RichTextBoxStreamType.PlainText)
            MsgBox("El archivo creado exitosamente!", MsgBoxStyle.Information, "ATL Suit Tools")
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteToolStripMenuItem.Click
        FontDialog.ShowColor = False
        FontDialog.Font = rtbeditor.Font
        If FontDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            rtbeditor.Font = FontDialog.Font
        End If
    End Sub

    Private Sub CopiarTodoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarTodoToolStripMenuItem.Click
        Clipboard.Clear()
        Clipboard.SetText(Me.rtbeditor.Text)
        MsgBox("Se ha copiado todo el texto en el portapapeles", MsgBoxStyle.Information, "MySUIT")
    End Sub
End Class
