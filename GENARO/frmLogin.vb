Option Explicit On
Imports MyLIB
Imports Microsoft.VisualBasic
Imports System.Data.SQLite

Public Class frmLogin
    Private outil As Utilerias
    Public ocnn As SQLiteConnection = Nothing
    Public bvalidousuario As Boolean = False

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim outil As Utilerias = New Utilerias
        Dim susermd5 As String = ""
        Dim spassmd5 As String = ""
        Dim sconnectString As String = System.Configuration.ConfigurationManager.AppSettings("ConnectionString")

        If Me.txtusuario.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el usuario del sistema", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If Me.txtpassword.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar la contraseña del sistema", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            'If outil.MD5Encrypt(Me.txtusuario.Text).Equals(outil.Toma_Token(1, System.Configuration.ConfigurationManager.AppSettings("usuario"), "/")) And _
            ' outil.MD5Encrypt(Me.txtpassword.Text).Equals(outil.Toma_Token(2, System.Configuration.ConfigurationManager.AppSettings("usuario"), "/")) Then

            ocnn = New SQLiteConnection(sconnectString)
            ocnn.Open()
            bvalidousuario = True
            'Me.Visible = False
            'Else
            'MsgBox("El usuario y contraseña no coinciden")
            'Exit Sub
            'End If
        Catch ex01 As Exception
            MessageBox.Show("Error al crear la conexión:" & vbCrLf & sconnectString & vbCrLf & ex01.Message)
            Exit Sub
        End Try
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Visible = False
    End Sub

    Private Sub lblrelease_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblrelease.DoubleClick
        Dim snuevo As String = ""

        snuevo = "lo nuevo con MyCATALOGOS" & vbLf
        snuevo = snuevo & " [] Se configuro que las columnas de grids no sean ordenables(rmt.16Dic2009)" & vbLf
        snuevo = snuevo & " [] Se agrego la eliminación masiva de infomación para los proyectos(rmt.03Feb2010)" & vbLf
        snuevo = snuevo & " [] Se agrego la propiedad en el campo de una fuente para autoincremento, secuencia, nombre secuencia (rmt.09Feb2010)" & vbLf
        outil.Preveer(snuevo)
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        outil = New Utilerias
    End Sub

    Private Sub lblrelease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblrelease.Click

    End Sub
End Class
