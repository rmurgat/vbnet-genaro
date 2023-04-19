Option Explicit On
Imports System.Data.SQLite

''' <summary>
''' Clase de acceso a la base de datos para el proyecto
''' </summary>
''' <company>01 - ATL Solutions S.A. de C.V.</company>
''' <project>MyCATALOGOS</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>10 de Mayo del 2009</created>
''' <remarks></remarks>
Public Class DBPmi
    Private ocnn As SQLiteConnection
    Private olog As HANYLog
    Private sdbfile As String
    Private sql As String      'Cadena que tiene todas los querys de acceso a base de datos
    Private outil As Utilerias

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByRef cnn As SQLiteConnection)
        Try
            ocnn = cnn
            olog = New HANYLog
            outil = New Utilerias
        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.New(cnn)", "Ocurrio un error al crear la clase de base de datos")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.New(cnn)", "Ocurrio un error al crear la clase de base de datos [" & ex1.ToString & "]")
        End Try
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                SELECT CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen047_junta
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getJunta(ByVal pscdproyecto As String, ByVal pscdjunta As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_junta, nb_lugar, tx_comment, fh_junta, tp_junta, tx_objetivo, nb_junta, st_junta"
            sql = sql & " FROM  gen047_junta"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_junta='" & pscdjunta & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "junta")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.getJunta()", "Ocurrio un error al consultar la tabla gen047_junta")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.getJunta()", "Ocurrio un error al consultar la tabla gen047_junta [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen047_junta
    ''' </summary>
    ''' <param name="pocrit">Criterios de criterio</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getJuntas(ByRef pocrit As Criterio) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter
        Dim swhere As String

        Try
            swhere = ""
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_junta, nb_lugar, tx_comment, fh_junta, tp_junta, tx_objetivo, nb_junta, st_junta"
            sql = sql & " FROM  gen047_junta"
            If Not pocrit.cdproyecto.Equals("") Then swhere = outil.Anade_Token(swhere, "cd_proyecto='" & pocrit.cdproyecto & "'", " AND ")
            If Not pocrit.cdjunta.Equals("") Then swhere = outil.Anade_Token(swhere, "cd_junta='" & pocrit.cdjunta & "'", " AND ")
            If Not pocrit.estatus.Equals("") Then swhere = outil.Anade_Token(swhere, "st_junta='" & pocrit.estatus & "'", " AND ")
            If Not swhere.Equals("") Then sql = sql & " WHERE " & swhere
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "junta")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.getJuntas(crit)", "Ocurrio un error al consultar la tabla gen047_junta")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.getJuntas(crit)", "Ocurrio un error al consultar la tabla gen047_junta sql=[" & sql & "] exception[" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen047_junta
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getallJuntas() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_junta, nb_lugar, tx_comment, fh_junta, tp_junta, tx_objetivo, nb_junta, st_junta"
            sql = sql & " FROM  gen047_junta"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "junta")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.getallJuntas()", "Ocurrio un error al consultar la tabla gen047_junta")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.getallJuntas()", "Ocurrio un error al consultar la tabla gen047_junta [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen048_junta_participa
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <param name="pscdsteackholder">Clave de la persona relacionada con el proyecto</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getJuntaParticipa(ByVal pscdproyecto As String, ByVal pscdjunta As String, ByVal pscdsteackholder As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_junta, cd_steackholder, st_ausente, st_sustituto, tx_comment"
            sql = sql & " FROM  gen048_junta_participa"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_junta='" & pscdjunta & "'"
            sql = sql & " AND   cd_steackholder='" & pscdsteackholder & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "juntaparticipa")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.getJuntaParticipa()", "Ocurrio un error al consultar la tabla gen048_junta_participa")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.getJuntaParticipa()", "Ocurrio un error al consultar la tabla gen048_junta_participa [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen048_junta_participa
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getJuntaParticipas(ByVal pscdproyecto As String, ByVal pscdjunta As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_junta, cd_steackholder, st_ausente, st_sustituto, tx_comment"
            sql = sql & " FROM  gen048_junta_participa"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_junta='" & pscdjunta & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "juntaparticipa")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.getJuntaParticipas()", "Ocurrio un error al consultar la tabla gen048_junta_participa")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.getJuntaParticipas()", "Ocurrio un error al consultar la tabla gen048_junta_participa [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen048_junta_participa
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getallJuntaParticipas() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_junta, cd_steackholder, st_ausente, st_sustituto, tx_comment"
            sql = sql & " FROM  gen048_junta_participa"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "juntaparticipa")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.getallJuntaParticipas()", "Ocurrio un error al consultar la tabla gen048_junta_participa")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.getallJuntaParticipas()", "Ocurrio un error al consultar la tabla gen048_junta_participa [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen049_junta_tarea
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <param name="pscdtarea">Clave de la tarea</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getJuntaTarea(ByVal pscdproyecto As String, ByVal pscdjunta As String, ByVal pscdtarea As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_junta, cd_tarea, tx_tarea, fh_tarea, nb_quien, st_tarea"
            sql = sql & " FROM  gen049_junta_tarea"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_junta='" & pscdjunta & "'"
            sql = sql & " AND   cd_tarea='" & pscdtarea & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "juntatarea")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.getJuntaTarea()", "Ocurrio un error al consultar la tabla gen049_junta_tarea")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.getJuntaTarea()", "Ocurrio un error al consultar la tabla gen049_junta_tarea [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen049_junta_tarea
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <param name="pscdtarea">Clave de la tarea</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getJuntaTareas(ByVal pscdproyecto As String, ByVal pscdjunta As String, ByVal pscdtarea As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_junta, cd_tarea, tx_tarea, fh_tarea, nb_quien, st_tarea"
            sql = sql & " FROM  gen049_junta_tarea"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_junta='" & pscdjunta & "'"
            sql = sql & " AND   cd_tarea='" & pscdtarea & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "juntatarea")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.getJuntaTareas()", "Ocurrio un error al consultar la tabla gen049_junta_tarea")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.getJuntaTareas()", "Ocurrio un error al consultar la tabla gen049_junta_tarea [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen049_junta_tarea
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getallJuntaTareas() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_junta, cd_tarea, tx_tarea, fh_tarea, nb_quien, st_tarea"
            sql = sql & " FROM  gen049_junta_tarea"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "juntatarea")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.getallJuntaTareas()", "Ocurrio un error al consultar la tabla gen049_junta_tarea")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.getallJuntaTareas()", "Ocurrio un error al consultar la tabla gen049_junta_tarea [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen050_junta_acuerdo
    ''' </summary>
    ''' <param name="pscdacuerdo">Clave del proyecto</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getJuntaAcuerdo(ByVal pscdacuerdo As String, ByVal pscdproyecto As String, ByVal pscdjunta As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT tx_acuerdo, st_acuerdo, cd_acuerdo, cd_proyecto, cd_junta"
            sql = sql & " FROM  gen050_junta_acuerdo"
            sql = sql & " WHERE cd_acuerdo='" & pscdacuerdo & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_junta='" & pscdjunta & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "juntaacuerdo")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.getJuntaAcuerdo()", "Ocurrio un error al consultar la tabla gen050_junta_acuerdo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.getJuntaAcuerdo()", "Ocurrio un error al consultar la tabla gen050_junta_acuerdo [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen050_junta_acuerdo
    ''' </summary>
    ''' <param name="pscdacuerdo">Clave del proyecto</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdjunta">Clave de la junta</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getJuntaAcuerdos(ByVal pscdacuerdo As String, ByVal pscdproyecto As String, ByVal pscdjunta As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT tx_acuerdo, st_acuerdo, cd_acuerdo, cd_proyecto, cd_junta"
            sql = sql & " FROM  gen050_junta_acuerdo"
            sql = sql & " WHERE cd_acuerdo='" & pscdacuerdo & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_junta='" & pscdjunta & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "juntaacuerdo")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.getJuntaAcuerdos()", "Ocurrio un error al consultar la tabla gen050_junta_acuerdo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.getJuntaAcuerdos()", "Ocurrio un error al consultar la tabla gen050_junta_acuerdo [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen050_junta_acuerdo
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getallJuntaAcuerdos() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT tx_acuerdo, st_acuerdo, cd_acuerdo, cd_proyecto, cd_junta"
            sql = sql & " FROM  gen050_junta_acuerdo"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "juntaacuerdo")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.getallJuntaAcuerdos()", "Ocurrio un error al consultar la tabla gen050_junta_acuerdo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.getallJuntaAcuerdos()", "Ocurrio un error al consultar la tabla gen050_junta_acuerdo [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimientopara consultar el siguiente valor consecutivo de una tabla
    ''' </summary>
    ''' <param name="stabla">nombre de la tabla</param>
    ''' <param name="scampo">nombre del campo</param>
    ''' <param name="swhere">condición where</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getLast(ByVal stabla As String, ByVal sCampo As String, ByVal swhere As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT MAX(" & sCampo & ") AS cd_last"
            sql = sql & " FROM  " & stabla
            If Not swhere.Equals("") Then sql = sql & " WHERE  " & swhere
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "last")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.getLast()", "Ocurrio un error al consultar la tabla " & stabla & " [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                INSERT CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////
    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen047_junta
    ''' </summary>
    ''' <param name="oadd">objeto tipo Junta</param>
    ''' <remarks></remarks>
    Public Sub addJunta(ByRef oadd As Junta)
        Dim objCommand As SQLiteCommand

        Try
            sql = "INSERT INTO gen047_junta"
            sql = sql & "(cd_proyecto, cd_junta, nb_lugar, tx_comment, fh_junta, tp_junta, tx_objetivo, nb_junta, st_junta)"
            sql = sql & " VALUES ('" & oadd.cdproyecto & "','" & oadd.cdjunta & "','" & oadd.nblugar & "','" & oadd.txcomment & "','" & oadd.fhjunta & "','" & oadd.tpjunta & "','" & oadd.txobjetivo & "','" & oadd.nbjunta & "','" & oadd.stjunta & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.addJunta()", "Ocurrio un error al agragar en gen047_junta")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.addJunta()", "Ocurrio un error al agragar en gen047_junta [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen048_junta_participa
    ''' </summary>
    ''' <param name="oadd">objeto tipo JuntaParticipa</param>
    ''' <remarks></remarks>
    Public Sub addJuntaParticipa(ByRef oadd As JuntaParticipa)
        Dim objCommand As SQLiteCommand

        Try
            sql = "INSERT INTO gen048_junta_participa"
            sql = sql & "(cd_proyecto, cd_junta, cd_steackholder, st_ausente, st_sustituto, tx_comment)"
            sql = sql & " VALUES ('" & oadd.cdproyecto & "','" & oadd.cdjunta & "','" & oadd.cdsteackholder & "','" & oadd.stausente & "','" & oadd.stsustituto & "','" & oadd.txcomment & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.addJuntaParticipa()", "Ocurrio un error al agragar en gen048_junta_participa")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.addJuntaParticipa()", "Ocurrio un error al agragar en gen048_junta_participa [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen049_junta_tarea
    ''' </summary>
    ''' <param name="oadd">objeto tipo JuntaTarea</param>
    ''' <remarks></remarks>
    Public Sub addJuntaTarea(ByRef oadd As JuntaTarea)
        Dim objCommand As SQLiteCommand

        Try
            sql = "INSERT INTO gen049_junta_tarea"
            sql = sql & "(cd_proyecto, cd_junta, cd_tarea, tx_tarea, fh_tarea, nb_quien, st_tarea)"
            sql = sql & " VALUES ('" & oadd.cdproyecto & "','" & oadd.cdjunta & "','" & oadd.cdtarea & "','" & oadd.txtarea & "','" & oadd.fhtarea & "','" & oadd.nbquien & "','" & oadd.sttarea & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.addJuntaTarea()", "Ocurrio un error al agragar en gen049_junta_tarea")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.addJuntaTarea()", "Ocurrio un error al agragar en gen049_junta_tarea [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen050_junta_acuerdo
    ''' </summary>
    ''' <param name="oadd">objeto tipo JuntaAcuerdo</param>
    ''' <remarks></remarks>
    Public Sub addJuntaAcuerdo(ByRef oadd As JuntaAcuerdo)
        Dim objCommand As SQLiteCommand

        Try
            sql = "INSERT INTO gen050_junta_acuerdo"
            sql = sql & "(tx_acuerdo, st_acuerdo, cd_acuerdo, cd_proyecto, cd_junta)"
            sql = sql & " VALUES ('" & oadd.txacuerdo & "','" & oadd.stacuerdo & "','" & oadd.cdacuerdo & "','" & oadd.cdproyecto & "','" & oadd.cdjunta & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.addJuntaAcuerdo()", "Ocurrio un error al agragar en gen050_junta_acuerdo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.addJuntaAcuerdo()", "Ocurrio un error al agragar en gen050_junta_acuerdo [" & ex1.ToString & "]")
        End Try
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                UPDATE CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////
    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen047_junta
    ''' </summary>
    ''' <param name="oupd">objeto tipo Junta</param>
    ''' <remarks></remarks>
    Public Sub updJunta(ByVal oupd As Junta)
        Dim objCommand As SQLiteCommand

        Try
            sql = "UPDATE gen047_junta"
            sql = sql & " SET nb_lugar= '" & oupd.nblugar & "'"
            sql = sql & ",tx_comment= '" & oupd.txcomment & "'"
            sql = sql & ",fh_junta= '" & oupd.fhjunta & "'"
            sql = sql & ",tp_junta= '" & oupd.tpjunta & "'"
            sql = sql & ",tx_objetivo= '" & oupd.txobjetivo & "'"
            sql = sql & ",nb_junta= '" & oupd.nbjunta & "'"
            sql = sql & ",st_junta= '" & oupd.stjunta & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_junta='" & oupd.cdjunta & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.updJunta()", "Ocurrio un error al actualizar en gen047_junta")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.updJunta()", "Ocurrio un error al actualizar en gen047_junta [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen048_junta_participa
    ''' </summary>
    ''' <param name="oupd">objeto tipo JuntaParticipa</param>
    ''' <remarks></remarks>
    Public Sub updJuntaParticipa(ByVal oupd As JuntaParticipa)
        Dim objCommand As SQLiteCommand

        Try
            sql = "UPDATE gen048_junta_participa"
            sql = sql & " SET st_ausente= '" & oupd.stausente & "'"
            sql = sql & ",st_sustituto= '" & oupd.stsustituto & "'"
            sql = sql & ",tx_comment= '" & oupd.txcomment & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_junta='" & oupd.cdjunta & "'"
            sql = sql & " AND   cd_steackholder='" & oupd.cdsteackholder & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.updJuntaParticipa()", "Ocurrio un error al actualizar en gen048_junta_participa")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.updJuntaParticipa()", "Ocurrio un error al actualizar en gen048_junta_participa [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen049_junta_tarea
    ''' </summary>
    ''' <param name="oupd">objeto tipo JuntaTarea</param>
    ''' <remarks></remarks>
    Public Sub updJuntaTarea(ByVal oupd As JuntaTarea)
        Dim objCommand As SQLiteCommand

        Try
            sql = "UPDATE gen049_junta_tarea"
            sql = sql & " SET tx_tarea= '" & oupd.txtarea & "'"
            sql = sql & ",fh_tarea= '" & oupd.fhtarea & "'"
            sql = sql & ",nb_quien= '" & oupd.nbquien & "'"
            sql = sql & ",st_tarea= '" & oupd.sttarea & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_junta='" & oupd.cdjunta & "'"
            sql = sql & " AND   cd_tarea='" & oupd.cdtarea & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.updJuntaTarea()", "Ocurrio un error al actualizar en gen049_junta_tarea")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.updJuntaTarea()", "Ocurrio un error al actualizar en gen049_junta_tarea [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen050_junta_acuerdo
    ''' </summary>
    ''' <param name="oupd">objeto tipo JuntaAcuerdo</param>
    ''' <remarks></remarks>
    Public Sub updJuntaAcuerdo(ByVal oupd As JuntaAcuerdo)
        Dim objCommand As SQLiteCommand

        Try
            sql = "UPDATE gen050_junta_acuerdo"
            sql = sql & " SET tx_acuerdo= '" & oupd.txacuerdo & "'"
            sql = sql & ",st_acuerdo= '" & oupd.stacuerdo & "'"
            sql = sql & " WHERE cd_acuerdo='" & oupd.cdacuerdo & "'"
            sql = sql & " AND   cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_junta='" & oupd.cdjunta & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.updJuntaAcuerdo()", "Ocurrio un error al actualizar en gen050_junta_acuerdo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.updJuntaAcuerdo()", "Ocurrio un error al actualizar en gen050_junta_acuerdo [" & ex1.ToString & "]")
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
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen047_junta"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_junta='" & pscdjunta & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.delJunta(key)", "Ocurrio un error al eliminar de gen047_junta")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.delJunta(key)", "Ocurrio un error al eliminar de gen047_junta [" & ex1.ToString & "]")
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
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen048_junta_participa"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_junta='" & pscdjunta & "'"
            sql = sql & " AND   cd_steackholder='" & pscdsteackholder & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.delJuntaParticipa(key)", "Ocurrio un error al eliminar de gen048_junta_participa")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.delJuntaParticipa(key)", "Ocurrio un error al eliminar de gen048_junta_participa [" & ex1.ToString & "]")
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
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen049_junta_tarea"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_junta='" & pscdjunta & "'"
            sql = sql & " AND   cd_tarea='" & pscdtarea & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.delJuntaTarea(key)", "Ocurrio un error al eliminar de gen049_junta_tarea")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.delJuntaTarea(key)", "Ocurrio un error al eliminar de gen049_junta_tarea [" & ex1.ToString & "]")
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
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen050_junta_acuerdo"
            sql = sql & " WHERE cd_acuerdo='" & pscdacuerdo & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_junta='" & pscdjunta & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBPmi.delJuntaAcuerdo(key)", "Ocurrio un error al eliminar de gen050_junta_acuerdo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBPmi.delJuntaAcuerdo(key)", "Ocurrio un error al eliminar de gen050_junta_acuerdo [" & ex1.ToString & "]")
        End Try
    End Sub

End Class   ' fin clase [DBPmi]

