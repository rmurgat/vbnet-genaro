Option Explicit On

Imports System

''' <summary>
''' Clase utilizada para la escribir los errores generados en un Archivo LOG de las 
''' aplicaciones construidas para ATL Solutions
''' </summary>
''' <remarks>
''' Autor : Rubén Murga Tapia
''' </remarks>
Public Class HANYLog

    Private sarchivo As String    'archivo utilizado para el log

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub

    ''' <summary>
    ''' PROPIEDAD: nombre del archivo utilizado para el log
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property archivo() As String
        Get
            Return sarchivo
        End Get
        Set(ByVal snb As String)
            sarchivo = snb
        End Set
    End Property

    ''' <summary>
    ''' METODO: para escribir en el archivo del LOG de errores generados por los componentes
    ''' </summary>
    ''' <param name="sorigen">origen del mensaje</param>
    ''' <param name="smensaje">texto del mensaje</param>
    ''' <remarks></remarks>
    Public Sub LException(ByVal sorigen As String, ByVal smensaje As String)
        Try
            Call Escribe(Comun.STR_LOGDIRECTORY_NAME & "LogException.txt", sorigen, smensaje)
        Catch ex As HANYException
            ex.add("MyLIB.HANYLog.LException()", "Ocurrio un error escribir archivo")
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' METODO: para escribir en el archivo del LOG de debug escritor por el programador
    ''' </summary>
    ''' <param name="sorigen">origen del mensaje</param>
    ''' <param name="smensaje">texto del mensaje</param>
    ''' <remarks></remarks>
    Public Sub LDebug(ByVal sorigen As String, ByVal smensaje As String)
        Try
            Call Escribe(Comun.STR_LOGDIRECTORY_NAME & "LogDebug.txt", sorigen, smensaje)
        Catch ex As HANYException
            ex.add("MyLIB.HANYLog.LDebug()", "Ocurrio un error escribir archivo")
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' METODO: para escribir en el archivo del LOG de debug escritor por el programador
    ''' </summary>
    ''' <param name="sorigen">origen del mensaje</param>
    ''' <param name="smensaje">txto del mensaje</param>
    ''' <remarks></remarks>
    Public Sub LMail(ByVal sorigen As String, ByVal smensaje As String)
        Try
            Call Escribe(Comun.STR_LOGDIRECTORY_NAME & "LogMail.txt", sorigen, smensaje)
        Catch ex As HANYException
            ex.add("MyLIB.HANYLog.LMail()", "Ocurrio un error escribir archivo")
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' METODO: escribe en el archivo el mensaje que se ha enviado
    ''' </summary>
    ''' <param name="sfile">archivo donde se escribira</param>
    ''' <param name="sorigen">origen del mensaje</param>
    ''' <param name="smensaje">texto del mensaje</param>
    ''' <remarks></remarks>
    Private Sub Escribe(ByVal sfile As String, ByVal sorigen As String, ByVal smensaje As String)
        Dim odate As Date
        Try
            odate = Date.Now
            FileOpen(1, sfile, OpenMode.Append) ' Open file for output.
            WriteLine(1, odate.ToString + " : " + sorigen + "-" + smensaje)  ' Print text to file.
            FileClose(1)   ' Close file.
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.HANYLog.Escribe()", "Ocurrio un error al escribir el archivo [" & ex1.ToString & "]")
        End Try

    End Sub

End Class   'fin clase [HANYLog]
