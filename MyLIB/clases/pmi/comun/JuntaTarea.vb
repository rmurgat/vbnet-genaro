Imports Microsoft.VisualBasic

''' <summary>
'''     Clase que tiene el registro de las tareas que se comprometieron en una junta
''' </summary>
''' <empresa>
'''     01 - ATL Solutions S.A. de C.V. 
''' </empresa>
''' <autor>
'''     Rubén Murga Tapia (10 de Mayo del 2009)
''' </autor>
''' <remarks></remarks>

Public Class JuntaTarea

    Private scdproyecto As String = ""              ' Clave del proyecto
    Private scdjunta As String = ""              ' Clave de la junta
    Private scdtarea As String = ""              ' Clave de la tarea
    Private stxtarea As String = ""              ' Descripción de la tarea
    Private sfhtarea As String = ""              ' Fecha en que está comprometida la tarea
    Private snbquien As String = ""              ' Nombre de la persona(s) responsable de la tarea
    Private ssttarea As String = ""              ' Estatus de la tarea

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
    ''' PROPIEDAD: Clave de la tarea
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdtarea() As String
        Get
            Return scdtarea
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then
                scdtarea = ""
                Exit Property
            End If
            scdtarea = pscd.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Descripción de la tarea
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property txtarea() As String
        Get
            Return stxtarea
        End Get
        Set(ByVal pstx As String)
            If pstx Is Nothing Then
                stxtarea = ""
                Exit Property
            End If
            stxtarea = pstx.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Fecha en que está comprometida la tarea
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property fhtarea() As String
        Get
            Return sfhtarea
        End Get
        Set(ByVal psfh As String)
            If psfh Is Nothing Then
                sfhtarea = ""
                Exit Property
            End If
            sfhtarea = psfh.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Nombre de la persona(s) responsable de la tarea
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbquien() As String
        Get
            Return snbquien
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then
                snbquien = ""
                Exit Property
            End If
            snbquien = psnb.Trim
        End Set
    End Property
    
    ''' <summary>
    ''' PROPIEDAD: Estatus de la tarea
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property sttarea() As String
        Get
            Return ssttarea
        End Get
        Set(ByVal psst As String)
            If psst Is Nothing Then
                ssttarea = ""
                Exit Property
            End If
            ssttarea = psst.Trim
        End Set
    End Property
    

End Class   ' fin clase [JuntaTarea]

