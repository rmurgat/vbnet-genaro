Option Explicit On

''' <summary>
''' Clase que contiene las propiedades y metodos del catálogo de tipos fisicos definidos para campos de una entidad de datos
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class TpDatoFisico
    Private scdtpDatoFisico As String = ""     ' Nombre del tipo de campos para la base de datos
    Private ssttpDatoFisico As String = ""     ' Estatus del tipo de dato
    Private stxcomment As String = ""          ' Comentarios

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Nombre del tipo de campos para la base de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdtpDatoFisico() As String
        Get
            Return scdtpDatoFisico
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdtpDatoFisico = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Estatus del tipo de dato
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property sttpDatoFisico() As String
        Get
            Return ssttpDatoFisico
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then Exit Property
            ssttpDatoFisico = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Comentarios
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property txcomment() As String
        Get
            Return stxcomment
        End Get
        Set(ByVal pstx As String)
            If pstx Is Nothing Then Exit Property
            stxcomment = pstx.Trim
        End Set
    End Property

End Class  'fin clase [TpDatoFisico]