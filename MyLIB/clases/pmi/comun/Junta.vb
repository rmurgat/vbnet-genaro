Imports Microsoft.VisualBasic

''' <summary>
'''     Clase que tiene el registro de las juntas realizadas para este proyecto en particular
''' </summary>
''' <empresa>
'''     01 - ATL Solutions S.A. de C.V. 
''' </empresa>
''' <autor>
'''     Rubén Murga Tapia (10 de Mayo del 2009)
''' </autor>
''' <remarks></remarks>

Public Class Junta

    Private scdproyecto As String = ""              ' Clave del proyecto
    Private scdjunta As String = ""              ' Clave de la junta
    Private snblugar As String = ""              ' Nombre del Lugar donde se realiza la junta
    Private stxcomment As String = ""              ' Comentario
    Private sfhjunta As String = ""              ' Fecha y Hora de la Junta
    Private stpjunta As String = ""              ' Tipo de Junta
    Private stxobjetivo As String = ""              ' Objetivo de la Junta
    Private snbjunta As String = ""              ' Nombre de la Junta (para identificarla)
    Private sstjunta As String = ""              ' Estatus de la junta

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
    ''' PROPIEDAD: Nombre del Lugar donde se realiza la junta
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nblugar() As String
        Get
            Return snblugar
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then
                snblugar = ""
                Exit Property
            End If
            snblugar = psnb.Trim
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
    
    ''' <summary>
    ''' PROPIEDAD: Fecha y Hora de la Junta
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property fhjunta() As String
        Get
            Return sfhjunta
        End Get
        Set(ByVal psfh As String)
            If psfh Is Nothing Then
                sfhjunta = ""
                Exit Property
            End If
            sfhjunta = psfh.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Tipo de Junta
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property tpjunta() As String
        Get
            Return stpjunta
        End Get
        Set(ByVal pstp As String)
            If pstp Is Nothing Then
                stpjunta = ""
                Exit Property
            End If
            stpjunta = pstp.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Objetivo de la Junta
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property txobjetivo() As String
        Get
            Return stxobjetivo
        End Get
        Set(ByVal pstx As String)
            If pstx Is Nothing Then
                stxobjetivo = ""
                Exit Property
            End If
            stxobjetivo = pstx.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Nombre de la Junta (para identificarla)
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbjunta() As String
        Get
            Return snbjunta
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then
                snbjunta = ""
                Exit Property
            End If
            snbjunta = psnb.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Estatus de la junta
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property stjunta() As String
        Get
            Return sstjunta
        End Get
        Set(ByVal psst As String)
            If psst Is Nothing Then
                sstjunta = ""
                Exit Property
            End If
            sstjunta = psst.Trim
        End Set
    End Property
    

End Class   ' fin clase [Junta]

