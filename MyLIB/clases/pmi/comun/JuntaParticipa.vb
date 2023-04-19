Imports Microsoft.VisualBasic

''' <summary>
'''     Clase que tiene el registro de aquellas personas que participan en la junta
''' </summary>
''' <empresa>
'''     01 - ATL Solutions S.A. de C.V. 
''' </empresa>
''' <autor>
'''     Rubén Murga Tapia (10 de Mayo del 2009)
''' </autor>
''' <remarks></remarks>

Public Class JuntaParticipa

    Private scdproyecto As String = ""              ' Clave del proyecto
    Private scdjunta As String = ""              ' Clave de la junta
    Private scdsteackholder As String = ""              ' Clave de la persona relacionada con el proyecto
    Private sstausente As String = ""              ' Estatus de ausente
    Private sstsustituto As String = ""              ' Estatus que determina que esta persona es un sustituto
    Private stxcomment As String = ""              ' Comentario

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
    
    ''' <summary>
    ''' PROPIEDAD: Clave de la persona relacionada con el proyecto
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdsteackholder() As String
        Get
            Return scdsteackholder
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then
                scdsteackholder = ""
                Exit Property
            End If
            scdsteackholder = pscd.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Estatus de ausente
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property stausente() As String
        Get
            Return sstausente
        End Get
        Set(ByVal psst As String)
            If psst Is Nothing Then
                sstausente = ""
                Exit Property
            End If
            sstausente = psst.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Estatus que determina que esta persona es un sustituto
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property stsustituto() As String
        Get
            Return sstsustituto
        End Get
        Set(ByVal psst As String)
            If psst Is Nothing Then
                sstsustituto = ""
                Exit Property
            End If
            sstsustituto = psst.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Comentario
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property txcomment() As String
        Get
            Return stxcomment
        End Get
        Set(ByVal pstx As String)
            If pstx Is Nothing Then
                stxcomment = ""
                Exit Property
            End If
            stxcomment = pstx.Trim
        End Set
    End Property
    

End Class   ' fin clase [JuntaParticipa]

