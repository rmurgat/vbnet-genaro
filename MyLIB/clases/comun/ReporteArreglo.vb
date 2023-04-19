Imports Microsoft.VisualBasic

''' <summary>
'''     Clase que tiene las propiedades de los arreglos del reporte
''' </summary>
''' <empresa>
'''     01 - ATL Solutions S.A. de C.V. 
''' </empresa>
''' <autor>
'''     Rubén Murga Tapia (10-Marzo-2009)
''' </autor>
''' <remarks></remarks>
Public Class ReporteArreglo
    Private scdproyecto As String = ""              ' Clave del proyecto
    Private scdreporte As String = ""              ' Clave del reporte
    Private snbarreglo As String = ""              ' Nombre del arreglo
    Private scdarreglo As String = ""              ' Clave del arreglo
    Private inurensxpagina As Integer = 0              ' Número de renglones por pagina
    Private sstpaginacion As String = ""              ' Estatus de paginación

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Clave del proyecto
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdproyecto() As String
        Get
            Return scdproyecto
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then
                scdproyecto = ""
                Exit Property
            End If
            scdproyecto = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del reporte
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdreporte() As String
        Get
            Return scdreporte
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then
                scdreporte = ""
                Exit Property
            End If
            scdreporte = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre del arreglo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbarreglo() As String
        Get
            Return snbarreglo
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then
                snbarreglo = ""
                Exit Property
            End If
            snbarreglo = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del arreglo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdarreglo() As String
        Get
            Return scdarreglo
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then
                scdarreglo = ""
                Exit Property
            End If
            scdarreglo = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Número de renglones por pagina
    ''' </summary>
    ''' <value></value>
    ''' <returns>Integer</returns>
    ''' <remarks></remarks>
    Public Property nurensxpagina() As Integer
        Get
            Return inurensxpagina
        End Get
        Set(ByVal pival As Integer)
            inurensxpagina = pival
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Estatus de paginación
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property stpaginacion() As String
        Get
            Return sstpaginacion
        End Get
        Set(ByVal psst As String)
            If psst Is Nothing Then
                sstpaginacion = ""
                Exit Property
            End If
            sstpaginacion = psst.Trim
        End Set
    End Property

    ''' <summary>
    ''' Función que determina si el arreglo tiene paginación
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function haspaginacion() As Boolean
        If sstpaginacion.Equals(Comun.ST_ACTIVO) Then Return True
        Return False
    End Function

End Class   ' fin clase [ReporteArreglo]

