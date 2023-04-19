Imports Microsoft.VisualBasic

''' <summary>
'''     Clase que tiene el registro de los acuerdos tomados en la junta
''' </summary>
''' <empresa>
'''     01 - ATL Solutions S.A. de C.V. 
''' </empresa>
''' <autor>
'''     Rubén Murga Tapia (10 de Mayo del 2009)
''' </autor>
''' <remarks></remarks>

Public Class JuntaAcuerdo

    Private stxacuerdo As String = ""              ' 
    Private sstacuerdo As String = ""              ' 
    Private scdacuerdo As String = ""              ' 
    Private scdproyecto As String = ""              ' Clave del proyecto
    Private scdjunta As String = ""              ' Clave de la junta

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: 
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property txacuerdo() As String
        Get
            Return stxacuerdo
        End Get
        Set(ByVal pstx As String)
            If pstx Is Nothing Then
                stxacuerdo = ""
                Exit Property
            End If
            stxacuerdo = pstx.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: 
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property stacuerdo() As String
        Get
            Return sstacuerdo
        End Get
        Set(ByVal psst As String)
            If psst Is Nothing Then
                sstacuerdo = ""
                Exit Property
            End If
            sstacuerdo = psst.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: 
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdacuerdo() As String
        Get
            Return scdacuerdo
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then
                scdacuerdo = ""
                Exit Property
            End If
            scdacuerdo = pscd.Trim
        End Set
    End Property
    
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
    ''' PROPIEDAD: Clave de la junta
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdjunta() As String
        Get
            Return scdjunta
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then
                scdjunta = ""
                Exit Property
            End If
            scdjunta = pscd.Trim
        End Set
    End Property
    

End Class   ' fin clase [JuntaAcuerdo]

