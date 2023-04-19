Option Explicit On
Imports System.Data.SQLite

''' <summary>
''' Clase de negocio y principal acceso para el proyecto
''' </summary>
''' <company>01 - ATL Solutions S.A. de C.V.</company>
''' <project>MyCATALOGOS</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>10 de Mayo del 2009</created>
''' <remarks></remarks>
Public Class BPmi
    Private odb As DBPmi             'objeto de acceso a base de datos
    Private olog As HANYLog             'objeto para la escritura del log
    Private smensaje As String = ""     'ultimo mensaje de error

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByRef cnn As SQLiteConnection)
        Try
            odb = New DBPmi(cnn)
            olog = New HANYLog
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.New(cnn)", "Ocurrio un error al conectarse a la base de datos")
            Throw ex
        End Try
    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                SELECT CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////
    ''' <summary>
    ''' Procedimiento para consultar un objeto Junta
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <returns>Objeto tipo Junta</returns>
    ''' <remarks></remarks>
    Public Function getJunta(ByVal pscdproyecto As String, ByVal pscdjunta As String) As Junta
        Dim oset As DataSet
        Dim obj As Junta = Nothing
        Dim orows As DataRowCollection

        Try
            oset = odb.getJunta(pscdproyecto, pscdjunta)
            orows = oset.Tables("junta").Rows
            If orows.Count = 1 Then
                obj = New Junta()
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdjunta = orows.Item(0).Item("cd_junta")
                obj.nblugar = orows.Item(0).Item("nb_lugar")
                obj.txcomment = orows.Item(0).Item("tx_comment")
                obj.fhjunta = orows.Item(0).Item("fh_junta")
                obj.tpjunta = orows.Item(0).Item("tp_junta")
                obj.txobjetivo = orows.Item(0).Item("tx_objetivo")
                obj.nbjunta = orows.Item(0).Item("nb_junta")
                obj.stjunta = orows.Item(0).Item("st_junta")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.getJunta()", "Ocurrio un error al consultar un objeto Junta")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.getJunta()", "Ocurrio un error al consultar un objeto Junta [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar algunos objetos tipo Junta
    ''' </summary>
    ''' <param name="pocrit">Criterios de consulta</param>
    ''' <returns>Objeto tipo Junta</returns>
    ''' <remarks></remarks>
    Public Function getJuntas(ByRef pocrit As Criterio) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection
        oc = New Collection

        Try
            oset = odb.getJuntas(pocrit)
            orows = oset.Tables("junta").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Junta
                obj = New Junta()
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdjunta = orows.Item(i).Item("cd_junta")
                obj.nblugar = orows.Item(i).Item("nb_lugar")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                obj.fhjunta = orows.Item(i).Item("fh_junta")
                obj.tpjunta = orows.Item(i).Item("tp_junta")
                obj.txobjetivo = orows.Item(i).Item("tx_objetivo")
                obj.nbjunta = orows.Item(i).Item("nb_junta")
                obj.stjunta = orows.Item(i).Item("st_junta")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.getJuntas(crit)", "Ocurrio un error al consultar los objetos tipo Junta")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.getJuntas(crit)", "Ocurrio un error al consultar los objetos tipo Junta [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar todos los objetos del tipo Junta
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getallJuntas() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getallJuntas()
            orows = oset.Tables("junta").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Junta
                obj = New Junta()
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdjunta = orows.Item(i).Item("cd_junta")
                obj.nblugar = orows.Item(i).Item("nb_lugar")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                obj.fhjunta = orows.Item(i).Item("fh_junta")
                obj.tpjunta = orows.Item(i).Item("tp_junta")
                obj.txobjetivo = orows.Item(i).Item("tx_objetivo")
                obj.nbjunta = orows.Item(i).Item("nb_junta")
                obj.stjunta = orows.Item(i).Item("st_junta")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.getallJuntas()", "Ocurrio un error al consultar los objetos tipo Junta")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.getallJuntas()", "Ocurrio un error al consultar los objetos tipo Junta [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un objeto JuntaParticipa
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <param name="pscdsteackholder">Clave de la persona relacionada con el proyecto</param>
    ''' <returns>Objeto tipo JuntaParticipa</returns>
    ''' <remarks></remarks>
    Public Function getJuntaParticipa(ByVal pscdproyecto As String, ByVal pscdjunta As String, ByVal pscdsteackholder As String) As JuntaParticipa
        Dim oset As DataSet
        Dim obj As JuntaParticipa = Nothing
        Dim orows As DataRowCollection

        Try
            oset = odb.getJuntaParticipa(pscdproyecto, pscdjunta, pscdsteackholder)
            orows = oset.Tables("juntaparticipa").Rows
            If orows.Count = 1 Then
                obj = New JuntaParticipa()
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdjunta = orows.Item(0).Item("cd_junta")
                obj.cdsteackholder = orows.Item(0).Item("cd_steackholder")
                obj.stausente = orows.Item(0).Item("st_ausente")
                obj.stsustituto = orows.Item(0).Item("st_sustituto")
                obj.txcomment = orows.Item(0).Item("tx_comment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.getJuntaParticipa()", "Ocurrio un error al consultar un objeto JuntaParticipa")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.getJuntaParticipa()", "Ocurrio un error al consultar un objeto JuntaParticipa [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar algunos objetos tipo JuntaParticipa
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <returns>Objeto tipo JuntaParticipa</returns>
    ''' <remarks></remarks>
    Public Function getJuntaParticipas(ByVal pscdproyecto As String, ByVal pscdjunta As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection
        oc = New Collection

        Try
            oset = odb.getJuntaParticipas(pscdproyecto, pscdjunta)
            orows = oset.Tables("juntaparticipa").Rows
            For i = 0 To orows.Count - 1
                Dim obj As JuntaParticipa
                obj = New JuntaParticipa()
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdjunta = orows.Item(i).Item("cd_junta")
                obj.cdsteackholder = orows.Item(i).Item("cd_steackholder")
                obj.stausente = orows.Item(i).Item("st_ausente")
                obj.stsustituto = orows.Item(i).Item("st_sustituto")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.getJuntaParticipas()", "Ocurrio un error al consultar los objetos tipo JuntaParticipa")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.getJuntaParticipas()", "Ocurrio un error al consultar los objetos tipo JuntaParticipa [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar todos los objetos del tipo JuntaParticipa
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getallJuntaParticipas() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getallJuntaParticipas()
            orows = oset.Tables("juntaparticipa").Rows
            For i = 0 To orows.Count - 1
                Dim obj As JuntaParticipa
                obj = New JuntaParticipa()
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdjunta = orows.Item(i).Item("cd_junta")
                obj.cdsteackholder = orows.Item(i).Item("cd_steackholder")
                obj.stausente = orows.Item(i).Item("st_ausente")
                obj.stsustituto = orows.Item(i).Item("st_sustituto")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.getallJuntaParticipas()", "Ocurrio un error al consultar los objetos tipo JuntaParticipa")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.getallJuntaParticipas()", "Ocurrio un error al consultar los objetos tipo JuntaParticipa [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un objeto JuntaTarea
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <param name="pscdtarea">Clave de la tarea</param>
    ''' <returns>Objeto tipo JuntaTarea</returns>
    ''' <remarks></remarks>
    Public Function getJuntaTarea(ByVal pscdproyecto As String, ByVal pscdjunta As String, ByVal pscdtarea As String) As JuntaTarea
        Dim oset As DataSet
        Dim obj As JuntaTarea = Nothing
        Dim orows As DataRowCollection

        Try
            oset = odb.getJuntaTarea(pscdproyecto, pscdjunta, pscdtarea)
            orows = oset.Tables("juntatarea").Rows
            If orows.Count = 1 Then
                obj = New JuntaTarea()
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdjunta = orows.Item(0).Item("cd_junta")
                obj.cdtarea = orows.Item(0).Item("cd_tarea")
                obj.txtarea = orows.Item(0).Item("tx_tarea")
                obj.fhtarea = orows.Item(0).Item("fh_tarea")
                obj.nbquien = orows.Item(0).Item("nb_quien")
                obj.sttarea = orows.Item(0).Item("st_tarea")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.getJuntaTarea()", "Ocurrio un error al consultar un objeto JuntaTarea")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.getJuntaTarea()", "Ocurrio un error al consultar un objeto JuntaTarea [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar algunos objetos tipo JuntaTarea
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <param name="pscdtarea">Clave de la tarea</param>
    ''' <returns>Objeto tipo JuntaTarea</returns>
    ''' <remarks></remarks>
    Public Function getJuntaTareas(ByVal pscdproyecto As String, ByVal pscdjunta As String, ByVal pscdtarea As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection
        oc = New Collection

        Try
            oset = odb.getJuntaTareas(pscdproyecto, pscdjunta, pscdtarea)
            orows = oset.Tables("juntatarea").Rows
            For i = 0 To orows.Count - 1
                Dim obj As JuntaTarea
                obj = New JuntaTarea()
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdjunta = orows.Item(i).Item("cd_junta")
                obj.cdtarea = orows.Item(i).Item("cd_tarea")
                obj.txtarea = orows.Item(i).Item("tx_tarea")
                obj.fhtarea = orows.Item(i).Item("fh_tarea")
                obj.nbquien = orows.Item(i).Item("nb_quien")
                obj.sttarea = orows.Item(i).Item("st_tarea")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.getJuntaTareas()", "Ocurrio un error al consultar los objetos tipo JuntaTarea")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.getJuntaTareas()", "Ocurrio un error al consultar los objetos tipo JuntaTarea [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar todos los objetos del tipo JuntaTarea
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getallJuntaTareas() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getallJuntaTareas()
            orows = oset.Tables("juntatarea").Rows
            For i = 0 To orows.Count - 1
                Dim obj As JuntaTarea
                obj = New JuntaTarea()
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdjunta = orows.Item(i).Item("cd_junta")
                obj.cdtarea = orows.Item(i).Item("cd_tarea")
                obj.txtarea = orows.Item(i).Item("tx_tarea")
                obj.fhtarea = orows.Item(i).Item("fh_tarea")
                obj.nbquien = orows.Item(i).Item("nb_quien")
                obj.sttarea = orows.Item(i).Item("st_tarea")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.getallJuntaTareas()", "Ocurrio un error al consultar los objetos tipo JuntaTarea")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.getallJuntaTareas()", "Ocurrio un error al consultar los objetos tipo JuntaTarea [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un objeto JuntaAcuerdo
    ''' </summary>
    ''' <param name="pscdacuerdo">Clave del proyecto</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <returns>Objeto tipo JuntaAcuerdo</returns>
    ''' <remarks></remarks>
    Public Function getJuntaAcuerdo(ByVal pscdacuerdo As String, ByVal pscdproyecto As String, ByVal pscdjunta As String) As JuntaAcuerdo
        Dim oset As DataSet
        Dim obj As JuntaAcuerdo = Nothing
        Dim orows As DataRowCollection

        Try
            oset = odb.getJuntaAcuerdo(pscdacuerdo, pscdproyecto, pscdjunta)
            orows = oset.Tables("juntaacuerdo").Rows
            If orows.Count = 1 Then
                obj = New JuntaAcuerdo()
                obj.txacuerdo = orows.Item(0).Item("tx_acuerdo")
                obj.stacuerdo = orows.Item(0).Item("st_acuerdo")
                obj.cdacuerdo = orows.Item(0).Item("cd_acuerdo")
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdjunta = orows.Item(0).Item("cd_junta")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.getJuntaAcuerdo()", "Ocurrio un error al consultar un objeto JuntaAcuerdo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.getJuntaAcuerdo()", "Ocurrio un error al consultar un objeto JuntaAcuerdo [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar algunos objetos tipo JuntaAcuerdo
    ''' </summary>
    ''' <param name="pscdacuerdo">Clave del proyecto</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <returns>Objeto tipo JuntaAcuerdo</returns>
    ''' <remarks></remarks>
    Public Function getJuntaAcuerdos(ByVal pscdacuerdo As String, ByVal pscdproyecto As String, ByVal pscdjunta As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection
        oc = New Collection

        Try
            oset = odb.getJuntaAcuerdos(pscdacuerdo, pscdproyecto, pscdjunta)
            orows = oset.Tables("juntaacuerdo").Rows
            For i = 0 To orows.Count - 1
                Dim obj As JuntaAcuerdo
                obj = New JuntaAcuerdo()
                obj.txacuerdo = orows.Item(i).Item("tx_acuerdo")
                obj.stacuerdo = orows.Item(i).Item("st_acuerdo")
                obj.cdacuerdo = orows.Item(i).Item("cd_acuerdo")
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdjunta = orows.Item(i).Item("cd_junta")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.getJuntaAcuerdos()", "Ocurrio un error al consultar los objetos tipo JuntaAcuerdo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.getJuntaAcuerdos()", "Ocurrio un error al consultar los objetos tipo JuntaAcuerdo [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar todos los objetos del tipo JuntaAcuerdo
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getallJuntaAcuerdos() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getallJuntaAcuerdos()
            orows = oset.Tables("juntaacuerdo").Rows
            For i = 0 To orows.Count - 1
                Dim obj As JuntaAcuerdo
                obj = New JuntaAcuerdo()
                obj.txacuerdo = orows.Item(i).Item("tx_acuerdo")
                obj.stacuerdo = orows.Item(i).Item("st_acuerdo")
                obj.cdacuerdo = orows.Item(i).Item("cd_acuerdo")
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdjunta = orows.Item(i).Item("cd_junta")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.getallJuntaAcuerdos()", "Ocurrio un error al consultar los objetos tipo JuntaAcuerdo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.getallJuntaAcuerdos()", "Ocurrio un error al consultar los objetos tipo JuntaAcuerdo [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimientopara consultar el siguiente valor consecutivo de una tabla
    ''' </summary>
    ''' <param name="stabla">nombre de la tabla</param>
    ''' <param name="sCampo">nombre del campo</param>
    ''' <param name="swhere">condición where</param>
    ''' <returns>valor</returns>
    ''' <remarks></remarks>
    Private Function getNext(ByVal stabla As String, ByVal sCampo As String, ByVal swhere As String) As String
        Dim oset As DataSet
        Dim orows As DataRowCollection
        Dim ilast As Integer
        Dim snext As String
        snext = "000001"
        Try
            oset = odb.getLast(stabla, sCampo, swhere)
            orows = oset.Tables("last").Rows
            If orows.Count = 0 Then
                Return "000001"
            End If
            If orows.Count = 1 Then
                ilast = Convert.ToInt32(orows.Item(0).Item("cd_last")) + 1
                snext = "000000" & ilast.ToString
                snext = snext.Substring(snext.Length - 6)
            End If

        Catch ex As Exception
            Return "000001"
        End Try
        oset = Nothing
        Return snext
    End Function


    ''' <summary>
    ''' Procedimiento para agregar un nuevo objeto tipo JuntaParticipa
    ''' </summary>
    ''' <param name="oadd">objeto tipo JuntaParticipa</param>
    ''' <remarks></remarks>
    Public Sub addJuntaParticipa(ByRef oadd As JuntaParticipa)
        Try
            odb.addJuntaParticipa(oadd)
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.addJuntaParticipa()", "Ocurrio un error al agregar un objeto tipo JuntaParticipa")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.addJuntaParticipa()", "Ocurrio un error al agregar un objeto tipo JuntaParticipa [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar un nuevo objeto tipo JuntaTarea
    ''' </summary>
    ''' <param name="oadd">objeto tipo JuntaTarea</param>
    ''' <remarks></remarks>
    Public Sub addJuntaTarea(ByRef oadd As JuntaTarea)
        Try
            odb.addJuntaTarea(oadd)
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.addJuntaTarea()", "Ocurrio un error al agregar un objeto tipo JuntaTarea")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.addJuntaTarea()", "Ocurrio un error al agregar un objeto tipo JuntaTarea [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar un nuevo objeto tipo JuntaAcuerdo
    ''' </summary>
    ''' <param name="oadd">objeto tipo JuntaAcuerdo</param>
    ''' <remarks></remarks>
    Public Sub addJuntaAcuerdo(ByRef oadd As JuntaAcuerdo)
        Try
            odb.addJuntaAcuerdo(oadd)
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.addJuntaAcuerdo()", "Ocurrio un error al agregar un objeto tipo JuntaAcuerdo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.addJuntaAcuerdo()", "Ocurrio un error al agregar un objeto tipo JuntaAcuerdo [" & ex1.ToString & "]")
        End Try
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                UPDATE CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////
    ''' <summary>
    ''' Procedimiento para actualizar un nuevo objeto tipo Junta
    ''' </summary>
    ''' <param name="osave">objeto tipo Junta</param>
    ''' <remarks></remarks>
    Public Sub saveJunta(ByRef osave As Junta)
        Try
            If osave.cdjunta.Equals("") Then
                osave.cdjunta = Me.getNext("gen047_junta", "cd_junta", "cd_proyecto='" & osave.cdproyecto & "'")
                odb.addJunta(osave)
            Else
                odb.updJunta(osave)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.updJunta()", "Ocurrio un error al actualizar un objeto tipo Junta")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.updJunta()", "Ocurrio un error al actualizar un objeto tipo Junta [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un nuevo objeto tipo JuntaParticipa
    ''' </summary>
    ''' <param name="oupd">objeto tipo JuntaParticipa</param>
    ''' <remarks></remarks>
    Public Sub updJuntaParticipa(ByRef oupd As JuntaParticipa)
        Try
            odb.updJuntaParticipa(oupd)
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.updJuntaParticipa()", "Ocurrio un error al actualizar un objeto tipo JuntaParticipa")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.updJuntaParticipa()", "Ocurrio un error al actualizar un objeto tipo JuntaParticipa [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un nuevo objeto tipo JuntaTarea
    ''' </summary>
    ''' <param name="oupd">objeto tipo JuntaTarea</param>
    ''' <remarks></remarks>
    Public Sub updJuntaTarea(ByRef oupd As JuntaTarea)
        Try
            odb.updJuntaTarea(oupd)
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.updJuntaTarea()", "Ocurrio un error al actualizar un objeto tipo JuntaTarea")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.updJuntaTarea()", "Ocurrio un error al actualizar un objeto tipo JuntaTarea [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un nuevo objeto tipo JuntaAcuerdo
    ''' </summary>
    ''' <param name="oupd">objeto tipo JuntaAcuerdo</param>
    ''' <remarks></remarks>
    Public Sub updJuntaAcuerdo(ByRef oupd As JuntaAcuerdo)
        Try
            odb.updJuntaAcuerdo(oupd)
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.updJuntaAcuerdo()", "Ocurrio un error al actualizar un objeto tipo JuntaAcuerdo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.updJuntaAcuerdo()", "Ocurrio un error al actualizar un objeto tipo JuntaAcuerdo [" & ex1.ToString & "]")
        End Try
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                DELETE CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////
    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen047_junta
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <remarks></remarks>
    Public Sub delJunta(ByVal pscdproyecto As String, ByVal pscdjunta As String)
        Try
            odb.delJunta(pscdproyecto, pscdjunta)
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.delJunta(key)", "Ocurrio un error al eliminar un objeto tipo Junta")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.delJunta(key)", "Ocurrio un error al eliminar un objeto tipo Junta [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen048_junta_participa
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <param name="pscdsteackholder">Clave de la persona relacionada con el proyecto</param>
    ''' <remarks></remarks>
    Public Sub delJuntaParticipa(ByVal pscdproyecto As String, ByVal pscdjunta As String, ByVal pscdsteackholder As String)
        Try
            odb.delJuntaParticipa(pscdproyecto, pscdjunta, pscdsteackholder)
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.delJuntaParticipa(key)", "Ocurrio un error al eliminar un objeto tipo JuntaParticipa")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.delJuntaParticipa(key)", "Ocurrio un error al eliminar un objeto tipo JuntaParticipa [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen049_junta_tarea
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <param name="pscdtarea">Clave de la tarea</param>
    ''' <remarks></remarks>
    Public Sub delJuntaTarea(ByVal pscdproyecto As String, ByVal pscdjunta As String, ByVal pscdtarea As String)
        Try
            odb.delJuntaTarea(pscdproyecto, pscdjunta, pscdtarea)
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.delJuntaTarea(key)", "Ocurrio un error al eliminar un objeto tipo JuntaTarea")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.delJuntaTarea(key)", "Ocurrio un error al eliminar un objeto tipo JuntaTarea [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen050_junta_acuerdo
    ''' </summary>
    ''' <param name="pscdacuerdo">Clave del proyecto</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <remarks></remarks>
    Public Sub delJuntaAcuerdo(ByVal pscdacuerdo As String, ByVal pscdproyecto As String, ByVal pscdjunta As String)
        Try
            odb.delJuntaAcuerdo(pscdacuerdo, pscdproyecto, pscdjunta)
        Catch ex As HANYException
            ex.add("MyLIB.BPmi.delJuntaAcuerdo(key)", "Ocurrio un error al eliminar un objeto tipo JuntaAcuerdo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.BPmi.delJuntaAcuerdo(key)", "Ocurrio un error al eliminar un objeto tipo JuntaAcuerdo [" & ex1.ToString & "]")
        End Try
    End Sub



End Class 'fin clase [BPmi]

