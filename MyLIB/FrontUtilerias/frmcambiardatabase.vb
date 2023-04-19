Imports MyLIB
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class frmcambiardatabase
    Private outil As Utilerias = New MyLIB.Utilerias
    Private bacepto As Boolean = False          'Bandera que determina si acepto 
    Private sdatabase As String = ""            'Nombre de la base de datos

    ''' <summary>
    ''' PROPIEDAD: Bandera que determina si acepto
    ''' </summary>
    ''' <value></value>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Property acepto() As Boolean
        Get
            Return bacepto
        End Get
        Set(ByVal pbval As Boolean)
            bacepto = pbval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre de la base de datos
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property database() As String
        Get
            Return sdatabase
        End Get
        Set(ByVal psval As String)
            sdatabase = psval.Trim
        End Set
    End Property

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub frmcambiardatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'omdipa = Me.ParentForm
        Catch ex As HANYException
            ex.add("MyGENARO.frmcambiardatabase.Load()", "Ocurrio un error al cargar la pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de ACCESS (*.accdb)|*.accdb"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtdatabase.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim sconnectString As String = ""
        Try
            database = Me.txtdatabase.Text
            bacepto = True
            Me.Close()
        Catch ex As HANYException
            ex.add("MyGENARO.frmcambiardatabase.btnAceptar_Click()", "Ocurrio un error al conectar a la base de datos")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmcambiardatabase.btnAceptar_Click()", "Ocurrio un error al conectar a la base de datos [" & ex1.ToString & "]"))
        End Try
    End Sub
End Class