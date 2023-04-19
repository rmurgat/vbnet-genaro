
''' <summary>
''' Clase con las funciones necesarias para leer la configuración XML de la aplicación
''' </summary>
''' <remarks></remarks>
Public Class ConfigXML
    Private outil As Utilerias
    Private ozip As ZipArchivo
    Dim oxmlmain As Nodo

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByRef pozip As ZipArchivo)
        outil = New Utilerias
        ozip = pozip
    End Sub

    ''' <summary>
    ''' Funcion para consultar todos aquellos estilos de programación
    ''' </summary>
    ''' <param name="sestilo">tipo de estilo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getEstiloProgramacion(ByVal sestilo As String) As Collection
        Dim oxmlestilos As Nodo
        Try
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            Return oxmlestilos.Buscar("estilo", "tipo", sestilo)
        Catch ex As HANYException
            ex.add("MyLIB.ConfigXML.getEstiloProgramacion()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.ConfigXML.getEstiloProgramacion()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
        Return Nothing
    End Function

    ''' <summary>
    ''' Función para cargar un solo estilo de programación en particular
    ''' </summary>
    ''' <param name="sclave">Clave</param>
    ''' <returns>Nodo</returns>
    ''' <remarks></remarks>
    Public Function getUnEstiloProgramacion(ByVal sclave As String) As Nodo
        Dim oxmlestilos As Nodo
        Dim oxmlestinmain As Nodo
        Try
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmlestinmain = oxmlestilos.BuscarPrimero("estilo", "clave", sclave)
            Return New Nodo(oxmlestinmain.GetXML() & ozip.getFileInflated(oxmlestinmain.getValue("estilo.directorio") & oxmlestinmain.getValue("estilo.configuracion")))
        Catch ex As HANYException
            ex.add("MyLIB.ConfigXML.getUnEstiloProgramacion()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.ConfigXML.getUnEstiloProgramacion()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
        Return Nothing
    End Function

    ''' <summary>
    ''' Función para consultar los tipos de funciones programadas para un estilo en particular
    ''' </summary>
    ''' <param name="sclave">Clave del Estilo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getFunciones(ByVal sclave As String) As Collection
        Dim oxmlestilo As Nodo
        Dim oxmlfuncionales As Nodo
        Try
            oxmlestilo = Me.getUnEstiloProgramacion(sclave)
            oxmlfuncionales = oxmlestilo.getPrimerNodo("code.funcionales")
            Return oxmlfuncionales.getNodo("funcion")
        Catch ex As HANYException
            ex.add("MyLIB.ConfigXML.getUnEstiloFunciones()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.ConfigXML.getUnEstiloFunciones()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
    End Function

    ''' <summary>
    ''' Función para recuperar los pormenores de codificación de una funcion en particular
    ''' </summary>
    ''' <param name="scdestilo">Clave del estilo de programación</param>
    ''' <param name="scdfunc">Clave de la función</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getUnaFuncion(ByVal scdestilo As String, ByVal scdfunc As String) As Nodo
        Dim oxmlestilos, oxmlestinmain, oxmlestilo, oxmlfuncs, oxmlfunc As Nodo

        Try
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmlestinmain = oxmlestilos.BuscarPrimero("estilo", "clave", scdestilo)
            oxmlestilo = New Nodo(ozip.getFileInflated(oxmlestinmain.getValue("estilo.directorio") & oxmlestinmain.getValue("estilo.configuracion")))
            oxmlfuncs = oxmlestilo.getPrimerNodo("funcionales")
            oxmlfunc = oxmlfuncs.BuscarPrimero("funcion", "clave", scdfunc)
            Return New Nodo(ozip.getFileInflated(oxmlestinmain.getValue("estilo.directorio") & oxmlfunc.getValue("funcion.configuracion")))

        Catch ex As HANYException
            ex.add("MyLIB.ConfigXML.getUnaFuncion()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.ConfigXML.getUnaFuncion()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
    End Function


End Class  'fin clase [ConfigXML]
