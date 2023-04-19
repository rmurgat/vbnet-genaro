Imports Microsoft.VisualBasic

''' <summary>
''' Clase que hereda a las excepciones conel objetivo de guardar 
''' un arreglo (track) de excepciones
''' </summary>
''' <remarks></remarks>
Public Class HANYException
    Inherits Exception

    Private olog As HANYLog
    Private ctrack As Collection = Nothing

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        ctrack = New Collection
        olog = New HANYLog
    End Sub

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <param name="sorigen">Origen de la excepción</param>
    ''' <param name="sexcepcion">cadena de la excepción</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal sorigen As String, ByVal sexcepcion As String)
        ctrack = New Collection
        olog = New HANYLog
        Me.add(sorigen, sexcepcion)
    End Sub

    ''' <summary>
    ''' Procdimiento para agragar una nueva excepción al stack de excepciones
    ''' </summary>
    ''' <param name="sorigen">Origen de la excepción</param>
    ''' <param name="sexcepcion">texto de la excepción</param>
    ''' <remarks></remarks>
    Public Sub add(ByVal sorigen As String, ByVal sexcepcion As String)
        ctrack.Add("[] " & sorigen & " - " & sexcepcion)
        olog.LException(sorigen, sexcepcion)
    End Sub

    ''' <summary>
    ''' Función para regresar el stack de excepciones en un String
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function getstackString() As String
        Dim str As String = ""
        For Each oex As String In ctrack
            str = str & oex & vbCrLf
        Next
        Return str
    End Function

    ''' <summary>
    ''' Función para traerse el track de excepciones
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function gettrack() As Collection
        Return ctrack
    End Function


End Class  ' fin clase [HANYException]
