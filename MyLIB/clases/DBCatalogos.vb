Option Explicit On
Imports System.Data.SQLite

Public Class DBCatalogos
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
            ex.add("MyLIB.DBCatalogos.New(cnn)", "Ocurrio un error al crear la clase de base de datos")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.New(cnn)", "Ocurrio un error al crear la clase de base de datos [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' PROPIEDAD: 
    ''' </summary>
    ''' <value></value>
    ''' <returns>OleDbConnection</returns>
    ''' <remarks></remarks>
    Public Property cnn() As SQLiteConnection
        Get
            Return ocnn
        End Get
        Set(ByVal poval As SQLiteConnection)
            ocnn = poval
        End Set
    End Property

    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                SELECT CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////

    ''' <summary>
    ''' Procedimiento para la consulta del catálogo de empresas
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getEmpresas() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT  cd_empresa, nb_empresa, cd_rfc, nb_direccion, nu_telefono"
            sql = sql & " FROM  gen001_empresa"
            sql = sql & " ORDER BY cd_empresa"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "empresas")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getEmpresas()", "Ocurrio un error al consultar la tabla gen001_empresa [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta de un registro de la tabla gen001_empresa
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getEmpresa(ByVal scd As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT  cd_empresa, nb_empresa, cd_rfc, nb_direccion, nu_telefono"
            sql = sql & " FROM  gen001_empresa"
            sql = sql & " WHERE cd_empresa='" & scd & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "empresas")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getEmpresa()", "Ocurrio un error al consultar la tabla gen001_empresa [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function


    ''' <summary>
    ''' Procedimiento para la consulta de varios registros de la tabla gen002_cliente
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getClientes() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT  cd_cliente, cd_rfc, nu_telefono, nb_direccion, nb_cliente"
            sql = sql & " FROM  gen002_cliente"
            sql = sql & " ORDER BY cd_cliente"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "clientes")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getClientes()", "Ocurrio un error al consultar la tabla gen002_cliente [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta de un registro de la tabla gen002_cliente
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getCliente(ByVal scd As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT  cd_cliente, cd_rfc, nu_telefono, nb_direccion, nb_cliente"
            sql = sql & " FROM  gen002_cliente"
            sql = sql & " WHERE cd_cliente='" & scd & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "clientes")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getCliente()", "Ocurrio un error al consultar la tabla gen002_cliente [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de estatus de un proyecto
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getStProyectos() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT  cd_stproyecto, nb_stproyecto"
            sql = sql & " FROM  gen028_stproyecto"
            sql = sql & " ORDER BY cd_stproyecto"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "estatus")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getStProyectos()", "Ocurrio un error al consultar la tabla gen028_stproyecto [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un renglón de estatus de un proyecto
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getStProyecto(ByVal scd As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT  cd_stproyecto, nb_stproyecto"
            sql = sql & " FROM  gen028_stproyecto"
            sql = sql & " WHERE cd_stproyecto = '" & scd & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "estatus")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getStProyecto()", "Ocurrio un error al consultar la tabla gen028_stproyecto [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de proyectos
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getProyectos(ByRef ocrit As Criterio) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter
        Dim swhere As String

        Try
            swhere = ""
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_stproyecto, nb_proyecto, cd_cliente, cd_pmp, "
            sql = sql & "tx_comment, cd_empresa, im_precio, im_iva"
            sql = sql & " FROM  gen003_proyecto"
            If Not ocrit.cdcliente.Equals("") Then swhere = outil.Anade_Token(swhere, "cd_cliente='" & ocrit.cdcliente & "'", " AND ")
            If Not ocrit.cdstproyecto.Equals("") Then swhere = outil.Anade_Token(swhere, "cd_stproyecto='" & ocrit.cdstproyecto & "'", " AND ")
            If Not swhere.Equals("") Then sql = sql & " WHERE " & swhere
            sql = sql & " ORDER BY cd_proyecto"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "proyectos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getProyectos()", "Ocurrio un error al consultar la tabla gen003_proyecto [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un proyecto en particular
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getProyecto(ByVal scd As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter
        Dim swhere As String

        Try
            swhere = ""
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_stproyecto, nb_proyecto, cd_cliente, cd_pmp, "
            sql = sql & "tx_comment, cd_empresa, im_precio, im_iva"
            sql = sql & " FROM  gen003_proyecto"
            sql = sql & " WHERE cd_proyecto = '" & scd & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "proyectos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getProyecto()", "Ocurrio un error al consultar la tabla gen003_proyecto [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de personas
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getPersonas() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_persona, cd_usuario, cd_tipo, cd_rfc, nu_telcasa, nu_teloficina, nb_persona, nb_empresa, nb_email, tx_comment"
            sql = sql & " FROM  gen004_persona"
            sql = sql & " ORDER BY cd_persona"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "personas")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPersonas()", "Ocurrio un error al consultar la tabla gen004_persona [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de personas
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getPersona(ByVal scd As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_persona, cd_usuario, cd_tipo, cd_rfc, nu_telcasa, nu_teloficina, nb_persona, nb_empresa, nb_email, tx_comment"
            sql = sql & " FROM  gen004_persona"
            sql = sql & " WHERE cd_persona ='" & scd & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "personas")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPersona()", "Ocurrio un error al consultar la tabla gen004_persona [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de roles del stafff
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getRolStaffs() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_rolstaff, nb_rolstaff"
            sql = sql & " FROM  gen007_rolstaff"
            sql = sql & " ORDER BY cd_rolstaff"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "roles")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getRolStaffs()", "Ocurrio un error al consultar la tabla gen007_rolstaff [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un rol del staff en particular
    ''' </summary>
    ''' <param name="scd">clave del rol</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getRolStaff(ByVal scd As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_rolstaff, nb_rolstaff"
            sql = sql & " FROM  gen007_rolstaff"
            sql = sql & " WHERE cd_rolstaff = '" & scd & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "roles")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getRolStaff()", "Ocurrio un error al consultar la tabla gen007_rolstaff [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar toda la información del catálogo de Staffs
    ''' </summary>
    ''' <param name="ocrit">criterios de consulta del staff</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getStaffs(ByRef ocrit As Criterio) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter
        Dim swhere As String = ""

        Try
            If Not ocrit.cdproyecto.Equals("") Then swhere = outil.Anade_Token(swhere, " cd_proyecto='" & ocrit.cdproyecto & "'", " AND ")
            If Not ocrit.cdrolstaff.Equals("") Then swhere = outil.Anade_Token(swhere, " cd_rolstaff IN(" & ocrit.cdrolstaff & ")", " AND ")

            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_staff, cd_persona, cd_rolstaff, tx_comment"
            sql = sql & " FROM  gen006_staff"
            If Not swhere.Equals("") Then sql = sql & " WHERE " & swhere
            sql = sql & " ORDER BY cd_staff"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "staff")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getStaffs()", "Ocurrio un error al consultar la tabla gen006_staff [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un staff en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdstaff">clave del staff</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getStaff(ByVal scdproyecto As String, ByVal scdstaff As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_staff, cd_persona, cd_rolstaff, tx_comment"
            sql = sql & " FROM  gen006_staff"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_staff='" & scdstaff & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "staff")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getStaff(cdproy, cdstaff)", "Ocurrio un error al consultar la tabla gen006_staff [" & ex1.ToString & "] sql=[" & sql & "]")
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
            Throw New HANYException("MyLIB.DBCatalogos.getLast()", "Ocurrio un error al consultar la tabla " & stabla & " [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function


    ''' <summary>
    ''' Procedimiento para saber si existen renglones en una tabla con las condiciones 
    ''' </summary>
    ''' <param name="stabla"></param>
    ''' <param name="swhere"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function getExist(ByVal stabla As String, ByVal swhere As String) As Boolean
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT * FROM  " & stabla
            If Not swhere.Equals("") Then sql = sql & " WHERE  " & swhere
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "oexist")
            objDataAdapter = Nothing
            objCommand = Nothing
            If oset.Tables("oexist").Rows.Count > 0 Then Return True
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getExist()", "Ocurrio un error al consultar la tabla " & stabla & " [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return False
    End Function


    ''' <summary>
    ''' Procedimiento para consultar toda la información de los steackholders
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getSteackholders(ByVal scdproyecto As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_steackholder, cd_persona, tx_comment"
            sql = sql & " FROM  gen005_steackholder"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " ORDER BY cd_steackholder"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "steackholder")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getSteackholders()", "Ocurrio un error al consultar la tabla gen005_steackholder [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar la información del Steackholder
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyect</param>
    ''' <param name="scdsteackholder">Clave del steackholder</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function getSteackholder(ByVal scdproyecto As String, ByVal scdsteackholder As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_steackholder, cd_persona, tx_comment"
            sql = sql & " FROM  gen005_steackholder"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_steackholder='" & scdsteackholder & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "steackholder")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getSteackholder()", "Ocurrio un error al consultar la tabla gen005_steackholder [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar las pantallas que se utilizan en el sistema
    ''' </summary>
    ''' <param name="scdproyecto">clave delproyecto</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getPantallas(ByVal scdproyecto As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_pantalla, cd_stanalisis, cd_stconstruccion, cd_analista, cd_programador, nb_pantalla, nb_imagefile, cd_codigo, tx_objetivo, tx_comment"
            sql = sql & " FROM  gen011_pantalla"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " ORDER BY cd_codigo, cd_pantalla"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "pantallas")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPantallas()", "Ocurrio un error al consultar la tabla gen011_pantalla [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar una pantalla que sea utilizada en el sistema
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getPantalla(ByVal scdproyecto As String, ByVal scdpantalla As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_pantalla, cd_stanalisis, cd_stconstruccion, cd_analista, cd_programador, nb_pantalla, nb_imagefile, cd_codigo, tx_objetivo, tx_comment"
            sql = sql & " FROM  gen011_pantalla"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & scdpantalla & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "pantallas")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPantalla()", "Ocurrio un error al consultar la tabla gen011_pantalla [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar los reportes que se utilizan en el sistema
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getReportes(ByVal scdproyecto As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, tx_objetivo, tx_comment, nb_reporte, cd_reporte, cd_analista, cd_programador, cd_codigo, cd_stanalisis, cd_stconstruccion, nb_imagefile "
            sql = sql & " FROM  gen030_reporte"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " ORDER BY cd_reporte"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "reportes")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getReportes()", "Ocurrio un error al consultar la tabla gen030_reporte [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un solo reporte que sea utilizada en el sistema
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdreporte">clave del reporte</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getReporte(ByVal scdproyecto As String, ByVal scdreporte As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, tx_objetivo, tx_comment, nb_reporte, cd_reporte, cd_analista, cd_programador, cd_codigo, cd_stanalisis, cd_stconstruccion, nb_imagefile "
            sql = sql & " FROM  gen030_reporte"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_reporte='" & scdreporte & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "reportes")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getReporte()", "Ocurrio un error al consultar la tabla gen030_reporte [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar todo el catálogo de estatus del analisis
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getStAnalisis() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_stanalisis, nb_stanalisis"
            sql = sql & " FROM  gen017_stanalisis"
            sql = sql & " ORDER BY cd_stanalisis "

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "estatus")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getStAnalisis()", "Ocurrio un error al consultar la tabla gen017_stanalisis [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function


    ''' <summary>
    ''' Procedimiento para consultar el estatus del analisis
    ''' </summary>
    ''' <param name="scd"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function getStAnalisis(ByVal scd As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_stanalisis, nb_stanalisis"
            sql = sql & " FROM  gen017_stanalisis"
            sql = sql & " WHERE cd_stanalisis = '" & scd & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "estatus")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getStAnalisis(cd)", "Ocurrio un error al consultar la tabla gen017_stanalisis [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function


    ''' <summary>
    ''' Procedimiento para consultar el estatus de construcción
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getStConstruccion() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_stconstruccion, nb_stconstruccion"
            sql = sql & " FROM  gen016_stconstruccion"
            sql = sql & " ORDER BY cd_stconstruccion"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "estatus")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getStConstruccion()", "Ocurrio un error al consultar la tabla gen016_stconstruccion [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el estatus de construcción
    ''' </summary>
    ''' <param name="scd">clave del estatus</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function getStConstruccion(ByVal scd As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_stconstruccion, nb_stconstruccion"
            sql = sql & " FROM  gen016_stconstruccion"
            sql = sql & " WHERE cd_stconstruccion = '" & scd & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "estatus")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getStConstruccion()", "Ocurrio un error al consultar la tabla gen016_stconstruccion [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar los botones
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdpantalla">Clave de la pantalla</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getPantallaBotones(ByVal scdproyecto As String, ByVal scdpantalla As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_pantalla, cd_boton, nb_boton, tx_comment"
            sql = sql & " FROM  gen015_pantalla_boton"
            sql = sql & " WHERE cd_proyecto = '" & scdproyecto & "'"
            sql = sql & "  AND  cd_pantalla = '" & scdpantalla & "'"
            sql = sql & " ORDER BY cd_boton"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "botones")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPantallaBotones()", "Ocurrio un error al consultar la tabla gen015_pantalla_boton [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consulta la información de un botón en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdpantalla">Clave de la pantalla</param>
    ''' <param name="scdboton">Clave del boton</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getPantallaBoton(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdboton As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_pantalla, cd_boton, nb_boton, tx_comment"
            sql = sql & " FROM  gen015_pantalla_boton"
            sql = sql & " WHERE cd_proyecto = '" & scdproyecto & "'"
            sql = sql & "  AND  cd_pantalla = '" & scdpantalla & "'"
            sql = sql & "  AND  cd_boton = '" & scdboton & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "botones")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPantallaBoton()", "Ocurrio un error al consultar la tabla gen015_pantalla_boton [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimeinto para consultar los campos que son utilizados en una pantalla
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <param name="stpiocampo">tipo input/ouput campo</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getPantallaCampos(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal stpiocampo As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_pantalla, cd_campo, nu_longitud, nu_decimales, cd_tpcampo, tp_inoutput, cd_arreglo, nb_campo, tx_comment"
            sql = sql & " FROM  gen013_pantalla_campo"
            sql = sql & " WHERE cd_proyecto = '" & scdproyecto & "'"
            sql = sql & "  AND  cd_pantalla = '" & scdpantalla & "'"
            If Not stpiocampo.Equals("") Then sql = sql & "  AND  tp_inoutput = '" & stpiocampo & "'"
            sql = sql & " ORDER BY cd_campo"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "campos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPantallaCampos()", "Ocurrio un error al consultar la tabla gen013_pantalla_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimeinto para consultar los campos que son utilizados en un reporte
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdreporte">clave del reporte</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getReporteCampos(ByVal scdproyecto As String, ByVal scdreporte As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_reporte, nb_campo, cd_campo, cd_arreglo, cd_tpcampo, tx_comment, nu_decimales"
            sql = sql & " FROM  gen031_reporte_campo"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & "  AND  cd_reporte='" & scdreporte & "'"
            sql = sql & " ORDER BY cd_campo"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "campos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getReporteCampos()", "Ocurrio un error al consultar la tabla gen031_reporte_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un campo en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <param name="scdcampo">clave del campo</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getPantallaCampo(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdcampo As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_pantalla, cd_campo, nu_longitud, nu_decimales, cd_tpcampo, tp_inoutput, cd_arreglo, nb_campo, tx_comment"
            sql = sql & " FROM  gen013_pantalla_campo"
            sql = sql & " WHERE cd_proyecto = '" & scdproyecto & "'"
            sql = sql & "  AND  cd_pantalla = '" & scdpantalla & "'"
            sql = sql & "  AND  cd_campo = '" & scdcampo & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "campos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPantallaCampo()", "Ocurrio un error al consultar la tabla gen013_pantalla_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un campo en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdreporte">clave del reporte</param>
    ''' <param name="scdcampo">clave del campo</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getReporteCampo(ByVal scdproyecto As String, ByVal scdreporte As String, ByVal scdcampo As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_reporte, nb_campo, cd_campo, cd_arreglo, cd_tpcampo, tx_comment, nu_decimales"
            sql = sql & " FROM  gen031_reporte_campo"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & "  AND  cd_reporte='" & scdreporte & "'"
            sql = sql & "  AND  cd_campo = '" & scdcampo & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "campos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getReporteCampo()", "Ocurrio un error al consultar la tabla gen031_reporte_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catalogo de tipos de campos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function getTpCampos() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_tpcampo, nb_tpcampo"
            sql = sql & " FROM  gen014_tpcampo"
            sql = sql & " ORDER BY cd_tpcampo"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "tipos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getTpCampos()", "Ocurrio un error al consultar la tabla gen014_tpcampo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Función para consultar las fuentes de datos basandose en un criterio 
    ''' de consulta
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getFuenteDatos(ByRef ocrit As Criterio) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_fuentedato, tp_fuentedato, st_fuentedato, cd_cliente, nb_fuentedato, cd_conexion, tx_comment"
            sql = sql & " FROM  gen022_fuentedato"
            If Not ocrit.cdcliente.Equals("") Then sql = sql & " WHERE cd_cliente='" & ocrit.cdcliente & "'"
            sql = sql & " ORDER BY cd_fuentedato"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "fuentedatos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getFuenteDatos()", "Ocurrio un error al consultar la tabla gen022_fuentedato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Función para consultar un registro de fuente de datos
    ''' de consulta
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getFuenteDato(ByVal scdfuentedato As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT st_fuentedato, tp_fuentedato, cd_cliente, nb_fuentedato, cd_conexion, tx_comment"
            sql = sql & " FROM  gen022_fuentedato"
            sql = sql & " WHERE cd_fuentedato='" & scdfuentedato & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "fuentedatos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getFuenteDato()", "Ocurrio un error al consultar la tabla gen022_fuentedato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Function para consultar las entidades de datos
    ''' </summary>
    ''' <param name="scdfuentedato">clave del datasource</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getEntidaDatos(ByVal scdfuentedato As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_fuentedato, nb_entidadato, cd_tpentidadato, nb_clase, tx_comment, tx_clasecomment"
            sql = sql & " FROM  gen023_entidadato"
            sql = sql & " WHERE cd_fuentedato='" & scdfuentedato & "'"
            sql = sql & " ORDER BY nb_entidadato"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "entidades")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getEntidaDatos()", "Ocurrio un error al consultar la tabla gen023_entidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Function para consultar las entidades de datos
    ''' </summary>
    ''' <param name="scdfuentedato">clave del datasource</param>
    ''' <param name="snbentidadato">clave de la entidad</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getEntidaDato(ByVal scdfuentedato As String, ByVal snbentidadato As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_fuentedato, nb_entidadato, cd_tpentidadato, nb_clase, tx_comment, tx_clasecomment"
            sql = sql & " FROM  gen023_entidadato"
            sql = sql & " WHERE cd_fuentedato='" & scdfuentedato & "'"
            sql = sql & "  AND  nb_entidadato ='" & snbentidadato & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "entidades")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getEntidaDato()", "Ocurrio un error al consultar la tabla gen023_entidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Function para consultar los campos desde la tabla gen024_entidadato_campo
    ''' </summary>
    ''' <param name="scdfuentedato">clave del datasource</param>
    ''' <param name="snbentidad">nombre de la entidad</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getEntidaDatoCampos(ByVal scdfuentedato As String, ByVal snbentidad As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT nb_campo, cd_orden, nu_longitud, nu_decimales, st_permite_nulos, st_esllave, st_esllave_alterna, st_esautoincremento, st_essecuencia, nb_secuencia, cd_tpdatofisico, nb_variable, tx_comment"
            sql = sql & " FROM  gen024_entidadato_campo"
            sql = sql & " WHERE cd_fuentedato='" & scdfuentedato & "'"
            sql = sql & "  AND  nb_entidadato='" & snbentidad & "'"
            sql = sql & " ORDER BY st_esllave, cd_orden"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "dbcampos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getEntidaDatoCampos()", "Ocurrio un error al consultar la tabla gen024_entidadato_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Function para consultar un solo registro desde la tabla gen024_dbentidad_campo
    ''' </summary>
    ''' <param name="scdfuentedato">clave de la fuente de datos</param>
    ''' <param name="snbentidad">nombre de la entidad</param>
    ''' <param name="snbcampo">nombre del campo</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getEntidaDatoCampo(ByVal scdfuentedato As String, ByVal snbentidad As String, ByVal snbcampo As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_orden, nu_longitud, nu_decimales, st_permite_nulos, st_esllave, st_esllave_alterna, st_esautoincremento, st_essecuencia, nb_secuencia, cd_tpdatofisico, nb_variable, tx_comment"
            sql = sql & " FROM  gen024_entidadato_campo"
            sql = sql & " WHERE cd_fuentedato='" & scdfuentedato & "'"
            sql = sql & "  AND  nb_entidadato='" & snbentidad & "'"
            sql = sql & "  AND  nb_campo='" & snbcampo & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "dbcampos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getEntidaDatoCampo()", "Ocurrio un error al consultar la tabla gen024_entidadato_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de tipo de entidad de datos
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getTpEntidaDato(ByVal sclave As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT  cd_tpentidadato, nb_tpentidadato, st_tpentidadato"
            sql = sql & " FROM  gen033_tpentidadato"
            If Not sclave.Equals("") Then sql = sql & " WHERE cd_tpentidadato='" & sclave & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "tipos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getTpEntidaDato(cd)", "Ocurrio un error al consultar la tabla gen033_tpentidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de tipos de entidad
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getTpEntidaDato() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_tpentidadato, nb_tpentidadato, st_tpentidadato"
            sql = sql & " FROM  gen033_tpentidadato"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "tipos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getTpEntidaDato()", "Ocurrio un error al consultar la tabla gen033_tpentidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar las fuentes de datos de un proyecto en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function getProyectoFuenteDatos(ByVal scdproyecto As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_fuentedato, tx_comment"
            sql = sql & " FROM  gen021_proyecto_fuentedato"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "fuentes")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getProyectoFuenteDatos()", "Ocurrio un error al consultar la tabla gen021_proyecto_fuentedato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar una de las fuentes de datos de un proyecto en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdfuentedato">clave de la fuente de datos</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function getProyectoFuenteDato(ByVal scdproyecto As String, ByVal scdfuentedato As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_fuentedato, tx_comment"
            sql = sql & " FROM  gen021_proyecto_fuentedato"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & "  AND  cd_fuentedato='" & scdfuentedato & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "fuentes")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getProyectoFuenteDato(pry, fte)", "Ocurrio un error al consultar la tabla gen021_proyecto_fuentedato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar las entidades de datos de la relación proyecto - fuente de datos
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdfuentedato">clave de la fuente de datos</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getProyectoFuenteDatoEntidades(ByVal scdproyecto As String, ByVal scdfuentedato As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_fuentedato, nb_entidadato"
            sql = sql & " FROM  gen025_proyecto_entidadato"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & "  AND  cd_fuentedato='" & scdfuentedato & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "entidades")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getProyectoFuenteDatoEntidades(cdprym, cdfte)", "Ocurrio un error al consultar la tabla gen025_proyecto_entidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar las entidades de datos de la relación proyecto - fuente de datos
    ''' </summary>
    ''' <param name="scdfuentedato">clave de la fuente de datos</param>
    ''' <param name="snbentidad">nombre de la entidad</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getProyectosUsanEntidad(ByVal scdfuentedato As String, ByVal snbentidad As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_fuentedato, nb_entidadato"
            sql = sql & " FROM  gen025_proyecto_entidadato"
            sql = sql & " WHERE cd_fuentedato='" & scdfuentedato & "'"
            sql = sql & "  AND  nb_entidadato='" & snbentidad & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "entidades")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getProyectosUsanEntidad(cdfte, nbentidad)", "Ocurrio un error al consultar la tabla gen025_proyecto_entidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar las entidades de datos de la relación proyecto - fuente de datos
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getProyectoFuenteDatoEntidades(ByVal scdproyecto As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_fuentedato, nb_entidadato"
            sql = sql & " FROM  gen025_proyecto_entidadato"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " ORDER BY cd_fuentedato"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "entidades")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getProyectoFuenteDatoEntidades()", "Ocurrio un error al consultar la tabla gen025_proyecto_entidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un registro desde la tabla [gen034_PANTALLA_METOBJECT] 
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdpantalla">Clave de la pantalla</param>
    ''' <param name="scdevento">Clave del evento</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getPantallaEvento(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdevento As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_pantalla, cd_evento, cd_tpevento, nb_evento, tx_comment"
            sql = sql & " FROM  gen034_pantalla_evento"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & scdpantalla & "'"
            sql = sql & " AND   cd_evento='" & scdevento & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "eventos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPantallaEvento()", "Ocurrio un error al consultar la tabla gen034_pantalla_evento [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un registro desde la tabla [gen034_PANTALLA_METOBJECT] 
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdpantalla">Clave de la pantalla</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getPantallaEventos(ByVal scdproyecto As String, ByVal scdpantalla As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_pantalla, cd_evento, cd_tpevento, nb_evento, tx_comment"
            sql = sql & " FROM  gen034_pantalla_evento"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & scdpantalla & "'"
            sql = sql & " ORDER BY cd_evento"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "eventos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPantallaEventos()", "Ocurrio un error al consultar la tabla gen034_pantalla_evento [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Función para consultar un tipo de evento en particular
    ''' </summary>
    ''' <param name="sclave">Clave del evento</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function getTpEvento(ByVal sclave As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet()
            sql = "SELECT cd_tpevento, nb_tpevento, cd_metacodigo"
            sql = sql & " FROM  gen035_tpevento"
            sql = sql & " WHERE cd_tpevento='" & sclave & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "tipos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getTpEvento()", "Ocurrio un error al consultar la tabla gen035_tpevento [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de tipos de evento
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getTpEventos() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_tpevento, nb_tpevento, cd_metacodigo"
            sql = sql & " FROM  gen035_tpevento"
            sql = sql & " ORDER BY cd_tpevento"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "tipos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getTpEventos()", "Ocurrio un error al consultar la tabla gen035_tpevento [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar todas las navegaciones de un proyecto
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getNavegaciones(ByVal scdproyecto As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_desde, cd_hasta, tp_navegacion, st_openwindow"
            sql = sql & " FROM  gen036_navegacion"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " ORDER BY cd_desde, cd_hasta"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "nav")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getNavegaciones()", "Ocurrio un error al consultar la tabla gen036_navegacion [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar las navegaciones de una pantalla en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdesde">Clave de la pantalla</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function getNavegaciones(ByVal scdproyecto As String, ByVal scdesde As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_desde, cd_hasta, tp_navegacion, st_openwindow"
            sql = sql & " FROM  gen036_navegacion"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_desde='" & scdesde & "'"
            sql = sql & " ORDER BY cd_hasta"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "nav")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getNavegaciones(cdpry, cddesde)", "Ocurrio un error al consultar la tabla gen036_navegacion [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function 'getNavegaDesdeDestino

    ''' <summary>
    ''' Procedimiento para consultar las navegaciones de una pantalla en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdhasta">Clave de la pantalla destino</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function getNavegaDesdeDestino(ByVal scdproyecto As String, ByVal scdhasta As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_desde, cd_hasta, tp_navegacion, st_openwindow"
            sql = sql & " FROM  gen036_navegacion"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_hasta='" & scdhasta & "'"
            sql = sql & " ORDER BY cd_desde"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "nav")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getNavegaDesdeDestino()", "Ocurrio un error al consultar la tabla gen036_navegacion [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar una navegación en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdesde">Clave de la pantalla desde donde se hace el llamado</param>
    ''' <param name="scdhasta">Clave de la pantalla hasta donde se navega</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getNavegacion(ByVal scdproyecto As String, ByVal scdesde As String, ByVal scdhasta As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_desde, cd_hasta, tp_navegacion, st_openwindow"
            sql = sql & " FROM  gen036_navegacion"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_desde='" & scdesde & "'"
            sql = sql & " AND   cd_hasta='" & scdhasta & "'"
            sql = sql & " ORDER BY cd_hasta"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "nav")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getNavegacion()", "Ocurrio un error al consultar la tabla gen036_navegacion [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar los parámetros de una navegación en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdesde">Clave de la pantalla desde donde se viaja</param>
    ''' <param name="scdhasta">Clave de la pantalla hasta donde se viaja</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getNavegacionParams(ByVal scdproyecto As String, ByVal scdesde As String, ByVal scdhasta As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_desde, cd_hasta, cd_param, nb_param, st_constante, tx_constante"
            sql = sql & " FROM  gen037_navegacion_param"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_desde='" & scdesde & "'"
            sql = sql & " AND   cd_hasta='" & scdhasta & "'"
            sql = sql & " ORDER BY cd_param"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "navpar")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getNavegacionParams()", "Ocurrio un error al consultar la tabla gen037_navegacion_param [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar los parámetros de una navegación en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdesde">Clave de la pantalla desde donde se viaja</param>
    ''' <param name="scdhasta">Clave de la pantalla hasta donde se viaja</param>
    ''' <param name="scdparam">Clave del parametro</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getNavegacionParam(ByVal scdproyecto As String, ByVal scdesde As String, ByVal scdhasta As String, ByVal scdparam As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_desde, cd_hasta, cd_param, nb_param, st_constante, tx_constante"
            sql = sql & " FROM  gen037_navegacion_param"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_desde='" & scdesde & "'"
            sql = sql & " AND   cd_hasta='" & scdhasta & "'"
            sql = sql & " AND   cd_param='" & scdparam & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "navpar")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getNavegacionParam()", "Ocurrio un error al consultar la tabla gen037_navegacion_param [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen027_sincronia
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de la sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getSincronia(ByVal pscdsincronia As String, ByVal pscdproyecto As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_sincronia, cd_proyecto, nb_sincronia, st_sincronia, cd_estilo_genera, xm_sincronia"
            sql = sql & " FROM  gen027_sincronia"
            sql = sql & " WHERE cd_sincronia='" & pscdsincronia & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "sincronia")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.getSincronia()", "Ocurrio un error al consultar la tabla gen027_sincronia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getSincronia()", "Ocurrio un error al consultar la tabla gen027_sincronia [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen027_sincronia
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getSincronias(ByVal pscdproyecto As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_sincronia, cd_proyecto, nb_sincronia, st_sincronia, cd_estilo_genera, xm_sincronia"
            sql = sql & " FROM  gen027_sincronia"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "sincronia")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.getSincronias()", "Ocurrio un error al consultar la tabla gen027_sincronia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getSincronias()", "Ocurrio un error al consultar la tabla gen027_sincronia [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen027_sincronia
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getallSincronias() As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_sincronia, cd_proyecto, nb_sincronia, st_sincronia, cd_estilo_genera, xm_sincronia"
            sql = sql & " FROM  gen027_sincronia"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "sincronia")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.getallSincronias()", "Ocurrio un error al consultar la tabla gen027_sincronia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getallSincronias()", "Ocurrio un error al consultar la tabla gen027_sincronia [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen038_sincronia_pantalla
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getSincroniaPantalla(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_sincronia, cd_proyecto, cd_pantalla, nb_htmlfile, nb_htmlforma, nb_componente, nb_extension, xm_pantalla, st_pantalla, cd_estilo_genera, cd_estilo_funcion"
            sql = sql & " FROM  gen038_sincronia_pantalla"
            sql = sql & " WHERE cd_sincronia='" & pscdsincronia & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "sincronia")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.getSincroniaPantalla()", "Ocurrio un error al consultar la tabla gen038_sincronia_pantalla")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getSincroniaPantalla()", "Ocurrio un error al consultar la tabla gen038_sincronia_pantalla [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen039_sincronia_evento
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <param name="pscdevento">Clave del evento</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getSincroniaEvento(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String, ByVal pscdevento As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_sincronia, cd_proyecto, cd_pantalla, cd_evento, xm_evento, st_evento"
            sql = sql & " FROM  gen039_sincronia_evento"
            sql = sql & " WHERE cd_sincronia='" & pscdsincronia & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"
            sql = sql & " AND   cd_evento='" & pscdevento & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "sincronia")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.getSincroniaEvento()", "Ocurrio un error al consultar la tabla gen039_sincronia_evento")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getSincroniaEvento()", "Ocurrio un error al consultar la tabla gen039_sincronia_evento [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen040_sincronia_campo
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de la sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <param name="pscdcampo">Clave del campo</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getSincroniaCampo(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String, ByVal pscdcampo As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_sincronia, cd_proyecto, cd_pantalla, cd_campo, xm_campo, nb_idhtml, st_campo"
            sql = sql & " FROM  gen040_sincronia_campo"
            sql = sql & " WHERE cd_sincronia='" & pscdsincronia & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"
            sql = sql & " AND   cd_campo='" & pscdcampo & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "sincronia")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.getSincroniaCampo()", "Ocurrio un error al consultar la tabla gen040_sincronia_campo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getSincroniaCampo()", "Ocurrio un error al consultar la tabla gen040_sincronia_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen044_sincronia_parreglo
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de la sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <param name="pscdarreglo">Clave del arreglo</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getSincroniArreglo(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String, ByVal pscdarreglo As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_sincronia, cd_proyecto, cd_pantalla, cd_arreglo, st_arreglo, nb_idhtml, tp_element, nb_element, nb_object "
            sql = sql & " FROM  gen044_sincronia_parreglo"
            sql = sql & " WHERE cd_sincronia='" & pscdsincronia & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"
            sql = sql & " AND   cd_arreglo='" & pscdarreglo & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "sincronia")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.getSincroniArreglo()", "Ocurrio un error al consultar la tabla gen044_sincronia_parreglo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getSincroniArreglo()", "Ocurrio un error al consultar la tabla gen044_sincronia_parreglo [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un campo en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <param name="snbidhtml">Id del HTML</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getPantallaCampobyId(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdsincronia As String, ByVal snbidhtml As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter
        Try
            oset = New DataSet
            sql = "SELECT c.cd_proyecto as cd_proyecto, c.cd_pantalla as cd_pantalla, c.cd_campo as cd_campo, nu_longitud, nu_decimales, cd_tpcampo, tp_inoutput, nb_campo, tx_comment"
            sql = sql & " FROM  gen013_pantalla_campo c, gen040_sincronia_campo s"
            sql = sql & " WHERE c.cd_proyecto = s.cd_proyecto"
            sql = sql & "  AND  c.cd_pantalla = s.cd_pantalla"
            sql = sql & "  AND  c.cd_campo = s.cd_campo"
            sql = sql & "  AND  s.cd_sincronia = '" & scdsincronia & "'"
            sql = sql & "  AND  s.cd_proyecto = '" & scdproyecto & "'"
            sql = sql & "  AND  s.cd_pantalla = '" & scdpantalla & "'"
            sql = sql & "  AND  s.nb_idhtml = '" & snbidhtml & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "campos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPantallaCampobyId()", "Ocurrio un error al consultar la tabla gen013_pantalla_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para consultar unos campos en particular por medio del arreglo
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <param name="scdarreglo">clave del arreglo</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function getPantallaCamposbyArreglo(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdarreglo As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter
        Try
            oset = New DataSet
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_pantalla, cd_campo, nu_longitud, nu_decimales, cd_tpcampo, tp_inoutput, cd_arreglo, nb_campo, tx_comment"
            sql = sql & " FROM  gen013_pantalla_campo"
            sql = sql & " WHERE cd_proyecto = '" & scdproyecto & "'"
            sql = sql & "  AND  cd_pantalla = '" & scdpantalla & "'"
            sql = sql & "  AND  cd_arreglo = '" & scdarreglo & "'"
            sql = sql & " ORDER BY cd_campo"

            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "campos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPantallaCamposbyArreglo()", "Ocurrio un error al consultar la tabla gen013_pantalla_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen042_pantalla_arreglo
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <param name="pscdarreglo">Clave del arreglo</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getPantallarreglo(ByVal pscdproyecto As String, ByVal pscdpantalla As String, ByVal pscdarreglo As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter
        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_pantalla, cd_arreglo, tp_inoutput, nu_rensxpagina, nb_arreglo, st_paginacion"
            sql = sql & " FROM  gen042_pantalla_arreglo"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"
            sql = sql & " AND   cd_arreglo='" & pscdarreglo & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "arreglos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPantallarreglo()", "Ocurrio un error al consultar la tabla gen042_pantalla_arreglo [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen042_pantalla_arreglo
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getPantallarreglos(ByVal pscdproyecto As String, ByVal pscdpantalla As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter
        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_pantalla, cd_arreglo, tp_inoutput, nu_rensxpagina, nb_arreglo, st_paginacion"
            sql = sql & " FROM  gen042_pantalla_arreglo"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "arreglos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getPantallarreglos()", "Ocurrio un error al consultar la tabla gen042_pantalla_arreglo [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen043_reporte_arreglo
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdreporte">Clave del reporte</param>
    ''' <param name="pscdarreglo">Clave del arreglo</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getReporteArreglo(ByVal pscdproyecto As String, ByVal pscdreporte As String, ByVal pscdarreglo As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter
        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_reporte, nb_arreglo, cd_arreglo, nu_rensxpagina, st_paginacion"
            sql = sql & " FROM  gen043_reporte_arreglo"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_reporte='" & pscdreporte & "'"
            sql = sql & " AND   cd_arreglo='" & pscdarreglo & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "arreglos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getReporteArreglo()", "Ocurrio un error al consultar la tabla gen043_reporte_arreglo [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen043_reporte_arreglo
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdreporte">Clave del reporte</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getReporteArreglos(ByVal pscdproyecto As String, ByVal pscdreporte As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter
        Try
            oset = New DataSet
            sql = "SELECT cd_proyecto, cd_reporte, nb_arreglo, cd_arreglo, nu_rensxpagina, st_paginacion"
            sql = sql & " FROM  gen043_reporte_arreglo"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_reporte='" & pscdreporte & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "arreglos")
            objDataAdapter = Nothing
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getReporteArreglos()", "Ocurrio un error al consultar la tabla gen043_reporte_arreglo [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen032_referencia
    ''' </summary>
    ''' <param name="pscdfuentedato">Clave de la fuente de datos</param>
    ''' <param name="psnbentidadato">Nombre de la entidad de datos</param>
    ''' <param name="pscdreferencia">Clave de la referencia</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getReferencia(ByVal pscdfuentedato As String, ByVal psnbentidadato As String, ByVal pscdreferencia As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_fuentedato, nb_entidadato, cd_referencia, nb_referencia, tx_comment"
            sql = sql & " FROM  gen032_referencia"
            sql = sql & " WHERE cd_fuentedato='" & pscdfuentedato & "'"
            sql = sql & " AND   nb_entidadato='" & psnbentidadato & "'"
            sql = sql & " AND   cd_referencia='" & pscdreferencia & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "referencia")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.getReferencia()", "Ocurrio un error al consultar la tabla gen032_referencia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getReferencia()", "Ocurrio un error al consultar la tabla gen032_referencia [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen032_referencia
    ''' </summary>
    ''' <param name="pscdfuentedato">Clave de la fuente de datos</param>
    ''' <param name="psnbentidadato">Nombre de la entidad de datos</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getReferencias(ByVal pscdfuentedato As String, ByVal psnbentidadato As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_fuentedato, nb_entidadato, cd_referencia, nb_referencia, tx_comment"
            sql = sql & " FROM  gen032_referencia"
            sql = sql & " WHERE cd_fuentedato='" & pscdfuentedato & "'"
            sql = sql & " AND   nb_entidadato='" & psnbentidadato & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "referencia")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.getReferencias()", "Ocurrio un error al consultar la tabla gen032_referencia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getReferencias()", "Ocurrio un error al consultar la tabla gen032_referencia [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen051_referenciacampo
    ''' </summary>
    ''' <param name="pscdreferencia">Clave de la referencia</param>
    ''' <param name="pscdfuentedato">Clave de la fuente de datos</param>
    ''' <param name="psnbentidadato">Nombre de la entidad de datos</param>
    ''' <param name="psnullavecampo">Numero o posicion del campo dentro de la referencia</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getReferenciacampo(ByVal pscdreferencia As String, ByVal pscdfuentedato As String, ByVal psnbentidadato As String, ByVal psnullavecampo As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_referencia, cd_fuentedato, nb_entidadato, nu_llavecampo, nb_campo"
            sql = sql & " FROM  gen051_referenciacampo"
            sql = sql & " WHERE cd_referencia='" & pscdreferencia & "'"
            sql = sql & " AND   cd_fuentedato='" & pscdfuentedato & "'"
            sql = sql & " AND   nb_entidadato='" & psnbentidadato & "'"
            sql = sql & " AND   nu_llavecampo='" & psnullavecampo & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "referenciacampo")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.getReferenciacampo()", "Ocurrio un error al consultar la tabla gen051_referenciacampo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getReferenciacampo()", "Ocurrio un error al consultar la tabla gen051_referenciacampo [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen051_referenciacampo
    ''' </summary>
    ''' <param name="pscdreferencia">Clave de la referencia</param>
    ''' <param name="pscdfuentedato">Clave de la fuente de datos</param>
    ''' <param name="psnbentidadato">Nombre de la entidad de datos</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function getReferenciacampos(ByVal pscdreferencia As String, ByVal pscdfuentedato As String, ByVal psnbentidadato As String) As DataSet
        Dim oset As DataSet
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter

        Try
            oset = New DataSet
            sql = "SELECT cd_referencia, cd_fuentedato, nb_entidadato, nu_llavecampo, nb_campo"
            sql = sql & " FROM  gen051_referenciacampo"
            sql = sql & " WHERE cd_referencia='" & pscdreferencia & "'"
            sql = sql & " AND   cd_fuentedato='" & pscdfuentedato & "'"
            sql = sql & " AND   nb_entidadato='" & psnbentidadato & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.Fill(oset, "referenciacampo")
            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.getReferenciacampos()", "Ocurrio un error al consultar la tabla gen051_referenciacampo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.getReferenciacampos()", "Ocurrio un error al consultar la tabla gen051_referenciacampo [" & ex1.ToString & "]")
        End Try
        Return oset
    End Function

    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                INSERT CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////

    ''' <summary>
    ''' Procedimiento para agregar un nuevo proyecto
    ''' </summary>
    ''' <param name="oadd">objeto para agregar</param>
    ''' <remarks></remarks>
    Friend Sub addProyecto(ByRef oadd As Proyecto)
        Dim objCommand As SQLiteCommand

        Try
            sql = "INSERT INTO gen003_proyecto(cd_proyecto, cd_stproyecto, cd_cliente, cd_pmp, cd_empresa, im_precio, im_iva, nb_proyecto, tx_comment)"
            sql = sql & " VALUES('" & oadd.cdproyecto & "','" & oadd.cdstproyecto & "','" & oadd.cdcliente & "','" & oadd.cdpmp & "','" & oadd.cdempresa & "'," & oadd.imprecio & "," & oadd.imiva & ",'" & oadd.nbproyecto & "','" & oadd.comment & "')"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addProyecto()", "Ocurrio un error al agregar un registro a la tabla gen003_proyecto [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedicimiento para agregar información del Staff
    ''' </summary>
    ''' <param name="oadd">objeto del Staff con valores</param>
    ''' <remarks></remarks>
    Friend Sub addStaff(ByRef oadd As Staff)
        Dim objCommand As SQLiteCommand

        Try
            sql = "INSERT INTO gen006_staff(cd_proyecto, cd_staff, cd_persona, cd_rolstaff, tx_comment)"
            sql = sql & " VALUES('" & oadd.cdproyecto & "','" & oadd.cdstaff & "','" & oadd.cdpersona & "','" & oadd.cdrolstaff & "','" & oadd.txcomment & "')"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addStaff()", "Ocurrio un error al agregar un registro a la tabla gen006_staff [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar la información de una persona
    ''' </summary>
    ''' <param name="oadd">datos para agregar</param>
    ''' <remarks></remarks>
    Friend Sub addPersona(ByRef oadd As Persona)
        Dim objCommand As SQLiteCommand

        Try
            sql = "INSERT INTO gen004_persona(cd_persona, cd_usuario, cd_tipo, cd_rfc, nu_telcasa, nu_teloficina, nb_persona, nb_empresa, nb_email, tx_comment)"
            sql = sql & " VALUES('" & oadd.cdpersona & "','" & oadd.cdusuario & "','" & oadd.cdtipo & "','" & oadd.cdrfc & "','" & oadd.nutelcasa & "','" & oadd.nuteloficina & "','" & oadd.nbpersona & "','" & oadd.nbempresa & "','" & oadd.nbemail & "','" & oadd.comment & "')"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addPersona()", "Ocurrio un error al agregar un registro a la tabla gen004_persona [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar la información de un steackholder
    ''' </summary>
    ''' <param name="oadd">datos para agregar</param>
    ''' <remarks></remarks>
    Friend Sub addSteackholder(ByRef oadd As Steackholder)
        Dim objCommand As SQLiteCommand

        Try
            sql = "INSERT INTO gen005_steackholder(cd_proyecto, cd_steackholder, cd_persona, tx_comment)"
            sql = sql & " VALUES('" & oadd.cdproyecto & "','" & oadd.cdsteackholder & "','" & oadd.cdpersona & "','" & oadd.txcomment & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addSteackholder()", "Ocurrio un error al agregar un registro a la tabla gen005_steackholder [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar un nuevo registro a la tabla pantalla
    ''' </summary>
    ''' <param name="oadd">objeto para agregar</param>
    ''' <remarks></remarks>
    Friend Sub addPantalla(ByRef oadd As Pantalla)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen011_pantalla(cd_proyecto, cd_pantalla, cd_stanalisis, cd_stconstruccion, cd_analista, cd_programador, cd_codigo, nb_pantalla, nb_imagefile, tx_objetivo, tx_comment)"
            sql = sql & " VALUES('" & oadd.cdproyecto & "','" & oadd.cdpantalla & "','" & oadd.cdstanalisis & "','" & oadd.cdstconstruccion & "','" & oadd.cdanalista & "','" & oadd.cdprogramador & "','" & oadd.cdcodigo & "','" & oadd.nbpantalla & "','" & oadd.nbimagefile & "','" & oadd.txobjetivo & "','" & oadd.txcomment & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addPantalla()", "Ocurrio un error al agregar un registro a la tabla gen011_pantalla [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar un nuevo registro a la tabla de reportes
    ''' </summary>
    ''' <param name="oadd"></param>
    ''' <remarks></remarks>
    Friend Sub addReporte(ByRef oadd As Reporte)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO  gen030_reporte"
            sql = sql & "(cd_proyecto, tx_objetivo, tx_comment, nb_reporte, cd_reporte, cd_analista, cd_programador, cd_codigo, cd_stanalisis, cd_stconstruccion, nb_imagefile)"
            sql = sql & " VALUES ('" & oadd.cdproyecto() & "','" & oadd.txobjetivo & "','" & oadd.txcomment() & "', '" & oadd.nbreporte() & "', '" & oadd.cdreporte() & "', '" & oadd.cdanalista() & "', '" & oadd.cdprogramador() & "', '" & oadd.cdcodigo() & "', '" & oadd.cdstanalisis() & "', '" & oadd.cdstconstruccion() & "', '" & oadd.nbimagefile() & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addReporte()", "Ocurrio un error al agregar un registro a la tabla gen030_reporte [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar un nuevo registro en la tabla gen015_pantalla_boton
    ''' </summary>
    ''' <param name="oadd">objeto con datos del boton</param>
    ''' <remarks></remarks>
    Friend Sub addBoton(ByRef oadd As PantallaBoton)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen015_pantalla_boton(cd_proyecto, cd_pantalla, cd_boton, nb_boton, tx_comment)"
            sql = sql & " VALUES('" & oadd.cdproyecto & "','" & oadd.cdpantalla & "','" & oadd.cdboton & "','" & oadd.nbboton & "','" & oadd.txcomment & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addBoton()", "Ocurrio un error al agregar un registro a la tabla gen015_pantalla_boton [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar un nuevo campo a la base de datos
    ''' </summary>
    ''' <param name="oadd">Objeto con los datos a agregar</param>
    ''' <remarks></remarks>
    Friend Sub addPantallaCampo(ByRef oadd As PantallaCampo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen013_pantalla_campo(cd_pantalla, cd_proyecto, cd_campo, nu_longitud, nu_decimales, cd_tpcampo, tp_inoutput, cd_arreglo, nb_campo, tx_comment)"
            sql = sql & " VALUES('" & oadd.cdpantalla & "','" & oadd.cdproyecto & "','" & oadd.cdcampo & "'," & oadd.nulongitud & "," & oadd.nudecimales & ",'" & oadd.cdtpcampo & "','" & oadd.tpinoutput & "','" & oadd.cdarreglo & "','" & oadd.nbcampo & "','" & oadd.txcomment & "')"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addPantallaCampo()", "Ocurrio un error al agregar un registro a la tabla gen013_pantalla_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar un nuevo campo al reporte
    ''' </summary>
    ''' <param name="oadd">Objeto con los datos a agregar</param>
    ''' <remarks></remarks>
    Friend Sub addReporteCampo(ByRef oadd As ReporteCampo)
        Dim objCommand As SQLiteCommand

        Try
            sql = "INSERT INTO gen031_reporte_campo"
            sql = sql & "(cd_proyecto, cd_reporte, nb_campo, cd_campo, cd_arreglo, cd_tpcampo, tx_comment, nu_decimales)"
            sql = sql & " VALUES ('" & oadd.cdproyecto() & "', '" & oadd.cdreporte() & "', '" & oadd.nbcampo() & "', '" & oadd.cdcampo() & "','" & oadd.cdarreglo & "', '" & oadd.cdtpcampo() & "', '" & oadd.txcomment() & "', " & oadd.nudecimales() & ")"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addReporteCampo()", "Ocurrio un error al agregar un registro a la tabla gen031_reporte_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar una fuente de datos
    ''' </summary>
    ''' <param name="oadd">objeto con la información a agregar</param>
    ''' <remarks></remarks>
    Friend Sub addFuenteDato(ByRef oadd As FuenteDato)
        Dim objCommand As SQLiteCommand

        Try
            sql = "INSERT INTO gen022_fuentedato(cd_fuentedato, st_fuentedato, tp_fuentedato, cd_cliente, nb_fuentedato, cd_conexion, tx_comment)"
            sql = sql & " VALUES('" & oadd.cdfuentedato & "','" & oadd.stfuentedato & "','" & oadd.tpfuentedato & "','" & oadd.cdcliente & "','" & oadd.nbfuentedato & "','" & oadd.cdconexion & "','" & oadd.txcomment & "')"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addFuenteDato()", "Ocurrio un error al agregar un registro a la tabla gen022_fuentedato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar un nuevo registro en la tabla gen023_entidadato
    ''' </summary>
    ''' <param name="oadd">objeto con los datos que se desean agregar</param>
    ''' <remarks></remarks>
    Friend Sub addEntidaDato(ByRef oadd As EntidaDato)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen023_entidadato(cd_fuentedato, nb_entidadato, cd_tpentidadato, nb_clase, tx_comment, tx_clasecomment)"
            sql = sql & " VALUES('" & oadd.cdfuentedato & "','" & oadd.nbentidadato & "','" & oadd.tpentidadato & "','" & oadd.nbclase & "','" & oadd.txcomment & "','" & oadd.txclasecomment & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addEntidaDato()", "Ocurrio un error al agregar un registro a la tabla gen023_entidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agragar un nuevo registro a la tabla gen024_entidadato_campo
    ''' </summary>
    ''' <param name="oadd">objeto con la información a agregar</param>
    ''' <remarks></remarks>
    Friend Sub addEntidaDatoCampo(ByRef oadd As EntidaDatoCampo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen024_entidadato_campo(cd_fuentedato, nb_entidadato, nb_campo, cd_orden, nu_longitud, nu_decimales, st_permite_nulos, st_esllave, st_esllave_alterna, st_esautoincremento, st_essecuencia, nb_secuencia, cd_tpdatofisico, nb_variable, tx_comment)"
            sql = sql & " VALUES('" & oadd.cdfuentedato & "','" & oadd.nbentidadato & "','" & oadd.nbcampo & "'," & oadd.cdorden & "," & oadd.nulongitud & "," & oadd.nudecimales & ",'" & oadd.stpermitenulos & "','" & oadd.stesllave & "','" & oadd.stesalterna & "','" & oadd.stesautoincremento & "','" & oadd.stessecuencia & "','" & oadd.nbsecuencia & "','" & oadd.cdtpdatofisico & "','" & oadd.nbvariable & "','" & oadd.txcomment & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addEntidaDatoCampo()", "Ocurrio un error al agregar un registro a la tabla gen024_entidadato_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar una nueva relación de proyecto y fuente de datos
    ''' </summary>
    ''' <param name="oadd">objeto que se debe agregar</param>
    ''' <remarks></remarks>
    Friend Sub addProyectoFuenteDato(ByRef oadd As ProyectoFuenteDato)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen021_proyecto_fuentedato(cd_proyecto, cd_fuentedato, tx_comment)"
            sql = sql & " VALUES('" & oadd.cdproyecto & "','" & oadd.cdfuentedato & "','" & oadd.txcomment & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addProyectoFuenteDato()", "Ocurrio un error al agregar un registro a la tabla gen021_proyecto_fuentedato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar una entidad - fuente de datos a un proyecto en particular
    ''' </summary>
    ''' <param name="oadd">objeto para darlo de altoa</param>
    ''' <remarks></remarks>
    Friend Sub addProyectoFuenteDatoEntidad(ByRef oadd As ProyectoFuenteDatoEntidad)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen025_proyecto_entidadato(cd_proyecto, cd_fuentedato, nb_entidadato)"
            sql = sql & " VALUES('" & oadd.cdproyecto & "','" & oadd.cdfuentedato & "','" & oadd.nbentidadato & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addProyectoFuenteDatoEntidad()", "Ocurrio un error al agregar un registro a la tabla gen025_proyecto_entidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar un nuevo metodo en la tabla [gen034_PANTALLA_EVENTO]
    ''' </summary>
    ''' <param name="oadd">Objeto con la información para agregar</param>
    ''' <remarks></remarks>
    Friend Sub addPantallaEvento(ByRef oadd As PantallaEvento)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen034_pantalla_evento(cd_proyecto, cd_pantalla, cd_evento, cd_tpevento, nb_evento, tx_comment)"
            sql = sql & " VALUES('" & oadd.cdproyecto & "','" & oadd.cdpantalla & "','" & oadd.cdevento & "','" & oadd.cdtpevento & "','" & oadd.nbevento & "','" & oadd.txcomment & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addPantallaEvento()", "Ocurrio un error al agregar un registro a la tabla gen034_pantalla_evento [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar una navegación en particular
    ''' </summary>
    ''' <param name="oadd">Objeto con la navegación para agregar</param>
    ''' <remarks></remarks>
    Friend Sub addNavegacion(ByRef oadd As Navegacion)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen036_navegacion(cd_proyecto, cd_desde, cd_hasta, tp_navegacion, st_openwindow)"
            sql = sql & " VALUES('" & oadd.cdproyecto & "','" & oadd.cdesde & "','" & oadd.cdhasta & "','" & oadd.tpnavegacion & "','" & IIf(oadd.stopenwindow, "AC", "IN") & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addNavegacion()", "Ocurrio un error al agregar un registro a la tabla gen036_navegacion [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar el parámetro de una navegación
    ''' </summary>
    ''' <param name="oadd">objeto para agregar</param>
    ''' <remarks></remarks>
    Friend Sub addNavegacionParam(ByRef oadd As NavegacionParam)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen037_navegacion_param(cd_proyecto, cd_desde, cd_hasta, cd_param, nb_param, st_constante, tx_constante)"
            sql = sql & " VALUES('" & oadd.cdproyecto & "','" & oadd.cdesde & "','" & oadd.cdhasta & "','" & oadd.cdparam & "','" & oadd.nbparam & "','" & IIf(oadd.stconstante, "AC", "IN") & "','" & oadd.txconstante & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addNavegacionParam()", "Ocurrio un error al agregar un registro a la tabla gen037_navegacion_param [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen027_sincronia
    ''' </summary>
    ''' <param name="oadd">objeto tipo Sincronia</param>
    ''' <remarks></remarks>
    Public Sub addSincronia(ByRef oadd As Sincronia)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen027_sincronia"
            sql = sql & "(cd_proyecto, cd_sincronia, cd_estilo_genera, nb_sincronia, st_sincronia, xm_sincronia)"
            sql = sql & " VALUES ('" & oadd.cdproyecto & "','" & oadd.cdsincronia & "','" & oadd.cdestilogenera & "','" & oadd.nbsincronia & "','" & oadd.estatus & "','" & oadd.xmsincronia & "')"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addSincronia()", "Ocurrio un error al agragar en gen027_sincronia [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen038_sincronia_pantalla
    ''' </summary>
    ''' <param name="oadd">objeto tipo SincroniaPantalla</param>
    ''' <remarks></remarks>
    Public Sub addSincroniaPantalla(ByRef oadd As SincroniaPantalla)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen038_sincronia_pantalla"
            sql = sql & "(nb_htmlfile, cd_proyecto, cd_pantalla, nb_extension, xm_pantalla, cd_sincronia, st_pantalla, nb_htmlforma, nb_componente, cd_estilo_funcion)"
            sql = sql & " VALUES ('" & oadd.nbhtmlfile & "','" & oadd.cdproyecto & "','" & oadd.cdpantalla & "','" & oadd.nbextension & "','" & oadd.xmlpantalla & "','" & oadd.cdsincronia & "','" & oadd.estatus & "','" & oadd.nbhtmlforma & "','" & oadd.nbcomponente & "','" & oadd.cdestilofuncion & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addSincroniaPantalla()", "Ocurrio un error al agragar en gen038_sincronia_pantalla [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen039_sincronia_evento
    ''' </summary>
    ''' <param name="oadd">objeto tipo SincroniaEvento</param>
    ''' <remarks></remarks>
    Public Sub addSincroniaEvento(ByRef oadd As SincroniaEvento)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen039_sincronia_evento"
            sql = sql & "(cd_proyecto, cd_pantalla, cd_evento, xm_evento, cd_sincronia, st_evento)"
            sql = sql & " VALUES ('" & oadd.cdproyecto & "','" & oadd.cdpantalla & "','" & oadd.cdevento & "','" & oadd.xmlevento & "','" & oadd.cdsincronia & "','" & oadd.estatus & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addSincroniaEvento()", "Ocurrio un error al agragar en gen039_sincronia_evento [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen040_sincronia_campo
    ''' </summary>
    ''' <param name="oadd">objeto tipo SincroniaCampo</param>
    ''' <remarks></remarks>
    Public Sub addSincroniaCampo(ByRef oadd As SincroniaCampo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen040_sincronia_campo"
            sql = sql & "(cd_pantalla, cd_proyecto, cd_campo, xm_campo, nb_idhtml, cd_sincronia, st_campo)"
            sql = sql & " VALUES ('" & oadd.cdpantalla & "','" & oadd.cdproyecto & "','" & oadd.cdcampo & "','" & oadd.xmlcampo & "','" & oadd.nbidhtml & "','" & oadd.cdsincronia & "','" & oadd.estatus & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addSincroniaCampo()", "Ocurrio un error al agragar en gen040_sincronia_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen044_sincronia_parreglo
    ''' </summary>
    ''' <param name="oadd">objeto tipo SincroniArreglo</param>
    ''' <remarks></remarks>
    Public Sub addSincroniArreglo(ByRef oadd As SincroniArreglo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen044_sincronia_parreglo"
            sql = sql & "(cd_sincronia, cd_proyecto, cd_pantalla, cd_arreglo, st_arreglo, nb_idhtml, tp_element, nb_element, nb_object)"
            sql = sql & " VALUES ('" & oadd.cdsincronia & "','" & oadd.cdproyecto & "','" & oadd.cdpantalla & "','" & oadd.cdarreglo & "','" & oadd.starreglo & "','" & oadd.nbidhtml & "','" & oadd.tpelement & "','" & oadd.nbelement & "','" & oadd.nbobject & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addSincroniArreglo()", "Ocurrio un error al agragar en gen044_sincronia_parreglo [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen042_pantalla_arreglo
    ''' </summary>
    ''' <param name="oadd">objeto tipo Pantallarreglo</param>
    ''' <remarks></remarks>
    Public Sub addPantallarreglo(ByRef oadd As Pantallarreglo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen042_pantalla_arreglo"
            sql = sql & "(cd_proyecto, cd_pantalla, cd_arreglo, tp_inoutput, nu_rensxpagina, nb_arreglo, st_paginacion)"
            sql = sql & " VALUES ('" & oadd.cdproyecto & "','" & oadd.cdpantalla & "','" & oadd.cdarreglo & "','" & oadd.tpinoutput & "'," & oadd.nurensxpagina & ",'" & oadd.nbarreglo & "','" & oadd.stpaginacion & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addPantallarreglo()", "Ocurrio un error al agragar en gen042_pantalla_arreglo [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen043_reporte_arreglo
    ''' </summary>
    ''' <param name="oadd">objeto tipo ReporteArreglo</param>
    ''' <remarks></remarks>
    Public Sub addReporteArreglo(ByRef oadd As ReporteArreglo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "INSERT INTO gen043_reporte_arreglo"
            sql = sql & "(cd_proyecto, cd_reporte, nb_arreglo, cd_arreglo, nu_rensxpagina, st_paginacion)"
            sql = sql & " VALUES ('" & oadd.cdproyecto & "','" & oadd.cdreporte & "','" & oadd.nbarreglo & "','" & oadd.cdarreglo & "'," & oadd.nurensxpagina & ",'" & oadd.stpaginacion & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addReporteArreglo()", "Ocurrio un error al agragar en gen043_reporte_arreglo [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen032_referencia
    ''' </summary>
    ''' <param name="oadd">objeto tipo Referencia</param>
    ''' <remarks></remarks>
    Public Sub addReferencia(ByRef oadd As Referencia)
        Dim objCommand As SQLiteCommand

        Try
            sql = "INSERT INTO gen032_referencia"
            sql = sql & "(cd_fuentedato, nb_entidadato, cd_referencia, nb_referencia, tx_comment)"
            sql = sql & " VALUES ('" & oadd.cdfuentedato & "','" & oadd.nbentidadato & "','" & oadd.cdreferencia & "','" & oadd.nbreferencia & "','" & oadd.txcomment & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.addReferencia()", "Ocurrio un error al agragar en gen032_referencia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addReferencia()", "Ocurrio un error al agragar en gen032_referencia [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen051_referenciacampo
    ''' </summary>
    ''' <param name="oadd">objeto tipo Referenciacampo</param>
    ''' <remarks></remarks>
    Public Sub addReferenciacampo(ByRef oadd As Referenciacampo)
        Dim objCommand As SQLiteCommand

        Try
            sql = "INSERT INTO gen051_referenciacampo"
            sql = sql & "(cd_referencia, cd_fuentedato, nb_entidadato, nu_llavecampo, nb_campo)"
            sql = sql & " VALUES ('" & oadd.cdreferencia & "','" & oadd.cdfuentedato & "','" & oadd.nbentidadato & "','" & oadd.nullavecampo & "','" & oadd.nbcampo & "')"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.addReferenciacampo()", "Ocurrio un error al agragar en gen051_referenciacampo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.addReferenciacampo()", "Ocurrio un error al agragar en gen051_referenciacampo [" & ex1.ToString & "]")
        End Try
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                UPDATE CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////

    ''' <summary>
    ''' Procedimiento para actualizar la información de un proyecto
    ''' </summary>
    ''' <param name="oupd">objeto para actualizar</param>
    ''' <remarks></remarks>
    Friend Sub updProyecto(ByRef oupd As Proyecto)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen003_proyecto SET "
            sql = sql & "cd_cliente='" & oupd.cdcliente & "'"
            sql = sql & ",cd_stproyecto='" & oupd.cdstproyecto & "'"
            sql = sql & ",cd_pmp='" & oupd.cdpmp & "'"
            sql = sql & ",cd_empresa='" & oupd.cdempresa & "'"
            sql = sql & ",im_precio=" & oupd.imprecio
            sql = sql & ",im_iva=" & oupd.imiva
            sql = sql & ",nb_proyecto='" & oupd.nbproyecto & "'"
            sql = sql & ",tx_comment='" & oupd.comment & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updProyecto()", "Ocurrio un error al actualizar un registro a la tabla gen003_proyecto [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub


    ''' <summary>
    ''' Procedimiento para actualizar la información de un Staff
    ''' </summary>
    ''' <param name="oupd">objeto para actualizar</param>
    ''' <remarks></remarks>
    Friend Sub updStaff(ByRef oupd As Staff)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen006_staff SET "
            sql = sql & "cd_persona='" & oupd.cdpersona & "'"
            sql = sql & ",cd_rolstaff='" & oupd.cdrolstaff & "'"
            sql = sql & ",tx_comment='" & oupd.txcomment & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_staff='" & oupd.cdstaff & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updStaff()", "Ocurrio un error al actualizar un registro a la tabla gen006_staff [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar la información de una persona
    ''' </summary>
    ''' <param name="oupd">objeto con los datos a actualizar</param>
    ''' <remarks></remarks>
    Friend Sub updPersona(ByRef oupd As Persona)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen004_persona SET "
            sql = sql & "cd_usuario='" & oupd.cdusuario & "'"
            sql = sql & ",cd_tipo='" & oupd.cdtipo & "'"
            sql = sql & ",cd_rfc='" & oupd.cdrfc & "'"
            sql = sql & ",nu_telcasa='" & oupd.nutelcasa & "'"
            sql = sql & ",nu_teloficina='" & oupd.nuteloficina & "'"
            sql = sql & ",nb_persona='" & oupd.nbpersona & "'"
            sql = sql & ",nb_empresa='" & oupd.nbempresa & "'"
            sql = sql & ",nb_email='" & oupd.nbemail & "'"
            sql = sql & ",tx_comment='" & oupd.comment & "'"
            sql = sql & " WHERE cd_persona='" & oupd.cdpersona & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updPersona()", "Ocurrio un error al actualizar un registro a la tabla gen004_persona [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar los datos del Steackholder
    ''' </summary>
    ''' <param name="oupd">objeto con la información del Steackholder</param>
    ''' <remarks></remarks>
    Friend Sub updSteackholder(ByRef oupd As Steackholder)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen005_steackholder SET "
            sql = sql & "cd_persona='" & oupd.cdpersona & "'"
            sql = sql & ",tx_comment='" & oupd.txcomment & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_steackholder='" & oupd.cdsteackholder & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updSteackholder()", "Ocurrio un error al actualizar un registro a la tabla gen005_steackholder [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar la información de una pantalla en particular
    ''' </summary>
    ''' <param name="oupd">objeto con los datos a actualizar</param>
    ''' <remarks></remarks>
    Friend Sub updPantalla(ByRef oupd As Pantalla)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen011_pantalla SET "
            sql = sql & "cd_stanalisis='" & oupd.cdstanalisis & "'"
            sql = sql & ",cd_stconstruccion='" & oupd.cdstconstruccion & "'"
            sql = sql & ",cd_analista='" & oupd.cdanalista & "'"
            sql = sql & ",cd_programador='" & oupd.cdprogramador & "'"
            sql = sql & ",cd_codigo='" & oupd.cdcodigo & "'"
            sql = sql & ",nb_pantalla='" & oupd.nbpantalla & "'"
            sql = sql & ",nb_imagefile='" & oupd.nbimagefile & "'"
            sql = sql & ",tx_objetivo='" & oupd.txobjetivo & "'"
            sql = sql & ",tx_comment='" & oupd.txcomment & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & oupd.cdpantalla & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updPantalla()", "Ocurrio un error al actualizar un registro a la tabla gen011_pantalla [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar la información de un reporte en particular
    ''' </summary>
    ''' <param name="oupd">objeto con los datos a actualizar</param>
    ''' <remarks></remarks>
    Friend Sub updReporte(ByRef oupd As Reporte)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen030_reporte"
            sql = sql & " SET  tx_objetivo='" & oupd.txobjetivo & "'"
            sql = sql & ",tx_comment='" & oupd.txcomment() & "'"
            sql = sql & ",nb_reporte='" & oupd.nbreporte() & "'"
            sql = sql & ",cd_analista='" & oupd.cdanalista() & "'"
            sql = sql & ",cd_programador='" & oupd.cdprogramador() & "'"
            sql = sql & ",cd_codigo='" & oupd.cdcodigo() & "'"
            sql = sql & ",cd_stanalisis='" & oupd.cdstanalisis() & "'"
            sql = sql & ",cd_stconstruccion='" & oupd.cdstconstruccion() & "'"
            sql = sql & ",nb_imagefile='" & oupd.nbimagefile() & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto() & "'"
            sql = sql & "  AND  cd_reporte='" & oupd.cdreporte() & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updReporte()", "Ocurrio un error al actualizar un registro a la tabla gen030_reporte [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar la información relativa a un boton
    ''' </summary>
    ''' <param name="oupd">objeto con los datos de un boton</param>
    ''' <remarks></remarks>
    Friend Sub updBoton(ByRef oupd As PantallaBoton)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen015_pantalla_boton SET "
            sql = sql & "nb_boton='" & oupd.nbboton & "'"
            sql = sql & ",tx_comment='" & oupd.txcomment & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & oupd.cdpantalla & "'"
            sql = sql & " AND   cd_boton='" & oupd.cdboton & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updBoton()", "Ocurrio un error al actualizar un registro a la tabla gen015_pantalla_boton [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar el campo
    ''' </summary>
    ''' <param name="oupd">objeto con los datos</param>
    ''' <remarks></remarks>
    Friend Sub updPantallaCampo(ByRef oupd As PantallaCampo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen013_pantalla_campo SET "
            sql = sql & "nu_longitud=" & oupd.nulongitud
            sql = sql & ",nu_decimales=" & oupd.nudecimales
            sql = sql & ",cd_tpcampo='" & oupd.cdtpcampo & "'"
            sql = sql & ",tp_inoutput='" & oupd.tpinoutput & "'"
            sql = sql & ",cd_arreglo='" & oupd.cdarreglo & "'"
            sql = sql & ",nb_campo='" & oupd.nbcampo & "'"
            sql = sql & ",tx_comment='" & oupd.txcomment & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & oupd.cdpantalla & "'"
            sql = sql & " AND   cd_campo='" & oupd.cdcampo & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updPantallaCampo()", "Ocurrio un error al actualizar un registro a la tabla gen013_pantalla_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar el campo de un reporte
    ''' </summary>
    ''' <param name="oupd">objeto con los datos</param>
    ''' <remarks></remarks>
    Friend Sub updReporteCampo(ByRef oupd As ReporteCampo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen031_reporte_campo"
            sql = sql & " SET  nb_campo='" & oupd.nbcampo() & "'"
            sql = sql & ",cd_arreglo='" & oupd.cdarreglo & "'"
            sql = sql & ",cd_tpcampo='" & oupd.cdtpcampo() & "'"
            sql = sql & ",tx_comment='" & oupd.txcomment() & "'"
            sql = sql & ",nu_decimales=" & oupd.nudecimales()
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto() & "'"
            sql = sql & "  AND  cd_reporte='" & oupd.cdreporte() & "'"
            sql = sql & "  AND  cd_campo='" & oupd.cdcampo() & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updReporteCampo()", "Ocurrio un error al actualizar un registro a la tabla gen031_reporte_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar la información de un datasource
    ''' </summary>
    ''' <param name="oupd">objeto para actualizar</param>
    ''' <remarks></remarks>
    Friend Sub updFuenteDato(ByRef oupd As FuenteDato)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen022_fuentedato SET "
            sql = sql & "cd_cliente='" & oupd.cdcliente & "'"
            sql = sql & ",st_fuentedato='" & oupd.stfuentedato & "'"
            sql = sql & ",tp_fuentedato='" & oupd.tpfuentedato & "'"
            sql = sql & ",nb_fuentedato='" & oupd.nbfuentedato & "'"
            sql = sql & ",cd_conexion='" & oupd.cdconexion & "'"
            sql = sql & ",tx_comment='" & oupd.txcomment & "'"
            sql = sql & " WHERE cd_fuentedato='" & oupd.cdfuentedato & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updFuenteDato()", "Ocurrio un error al actualizar un registro a la tabla gen022_fuentedato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Función para actualizar la información de las entidades de base de datos en tabla gen023_entidadato
    ''' </summary>
    ''' <param name="oupd">objeto que tiene la información de la entidad</param>
    ''' <remarks></remarks>
    Friend Sub updEntidaDato(ByRef oupd As EntidaDato)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen023_entidadato SET "
            sql = sql & "cd_tpentidadato='" & oupd.tpentidadato & "'"
            sql = sql & ",nb_clase='" & oupd.nbclase & "'"
            sql = sql & ",tx_comment='" & oupd.txcomment & "'"
            sql = sql & ",tx_clasecomment='" & oupd.txclasecomment & "'"
            sql = sql & " WHERE cd_fuentedato='" & oupd.cdfuentedato & "'"
            sql = sql & "  AND  nb_entidadato='" & oupd.nbentidadato & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updEntidaDato()", "Ocurrio un error al actualizar un registro a la tabla gen023_entidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Function para actualizar la informacion de un campo de datos en la tabla gen024_entidadato_campo
    ''' </summary>
    ''' <param name="oupd">Objeto con la información a actualizar</param>
    ''' <remarks></remarks>
    Friend Sub updEntidaDatoCampo(ByRef oupd As EntidaDatoCampo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen024_entidadato_campo SET "
            sql = sql & "cd_orden=" & oupd.cdorden
            sql = sql & ",nu_longitud=" & oupd.nulongitud
            sql = sql & ",nu_decimales=" & oupd.nudecimales
            sql = sql & ",st_permite_nulos='" & oupd.stpermitenulos & "'"
            sql = sql & ",st_esllave='" & oupd.stesllave & "'"
            sql = sql & ",st_esllave_alterna='" & oupd.stesalterna & "'"
            sql = sql & ",st_esautoincremento='" & oupd.stesautoincremento & "'"
            sql = sql & ",st_essecuencia='" & oupd.stessecuencia & "'"
            sql = sql & ",nb_secuencia='" & oupd.nbsecuencia & "'"
            sql = sql & ",cd_tpdatofisico='" & oupd.cdtpdatofisico & "'"
            sql = sql & ",nb_variable='" & oupd.nbvariable & "'"
            sql = sql & ",tx_comment='" & oupd.txcomment & "'"
            sql = sql & " WHERE cd_fuentedato='" & oupd.cdfuentedato & "'"
            sql = sql & "  AND  nb_entidadato='" & oupd.nbentidadato & "'"
            sql = sql & "  AND  nb_campo='" & oupd.nbcampo & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updEntidaDatoCampo()", "Ocurrio un error al actualizar un registro a la tabla gen024_entidadato_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Function para actualizar la informacion de un campo de datos en la tabla gen023_entidadato
    ''' </summary>
    ''' <param name="oupd">objeto con los datos para actualizar</param>
    ''' <remarks></remarks>
    Friend Sub updEntidadDatoComment(ByRef oupd As EntidaDato)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen023_entidadato SET "
            sql = sql & " tx_comment='" & oupd.txcomment & "'"
            sql = sql & " WHERE cd_fuentedato='" & oupd.cdfuentedato & "'"
            sql = sql & "  AND  nb_entidadato='" & oupd.nbentidadato & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updEntidadDatoComment()", "Ocurrio un error al actualizar un registro a la tabla gen023_entidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Function para actualizar la informacion de un campo de datos en la tabla gen024_entidadato_campo
    ''' </summary>
    ''' <param name="oupd">objeto con los datos para actualizar</param>
    ''' <remarks></remarks>
    Friend Sub updEntidadDatoCampoComment(ByRef oupd As EntidaDatoCampo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen024_entidadato_campo SET "
            sql = sql & " tx_comment='" & oupd.txcomment & "'"
            sql = sql & " WHERE cd_fuentedato='" & oupd.cdfuentedato & "'"
            sql = sql & "  AND  nb_entidadato='" & oupd.nbentidadato & "'"
            sql = sql & "  AND  nb_campo='" & oupd.nbcampo & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updEntidadDatoCampoComment()", "Ocurrio un error al actualizar un registro a la tabla gen024_entidadato_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar la información de la relación entre un proyecto y fuente de datos
    ''' </summary>
    ''' <param name="oupd">objeto con la inf. para actualizar</param>
    ''' <remarks></remarks>
    Friend Sub updProyectoFuenteDato(ByRef oupd As ProyectoFuenteDato)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen021_proyecto_fuentedato SET "
            sql = sql & "tx_comment='" & oupd.txcomment & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & "  AND  cd_fuentedato='" & oupd.cdfuentedato & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updProyectoFuenteDato()", "Ocurrio un error al actualizar un registro a la tabla gen021_proyecto_fuentedato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar la información de un metodo para un objecto
    ''' </summary>
    ''' <param name="oupd">Información para actualizar</param>
    ''' <remarks></remarks>
    Friend Sub updPantallaEvento(ByRef oupd As PantallaEvento)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen034_pantalla_evento SET "
            sql = sql & "cd_tpevento='" & oupd.cdtpevento & "'"
            sql = sql & ",nb_evento='" & oupd.nbevento & "'"
            sql = sql & ",tx_comment='" & oupd.txcomment & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & "  AND  cd_pantalla='" & oupd.cdpantalla & "'"
            sql = sql & "  AND  cd_evento='" & oupd.cdevento & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updPantallaEvento()", "Ocurrio un error al actualizar un registro a la tabla gen034_pantalla_evento [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar la navegación 
    ''' </summary>
    ''' <param name="oupd">objeto para actualizar</param>
    ''' <remarks></remarks>
    Friend Sub updNavegacion(ByRef oupd As Navegacion)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen036_navegacion SET "
            sql = sql & "tp_navegacion='" & oupd.tpnavegacion & "'"
            sql = sql & ",st_openwindow='" & IIf(oupd.stopenwindow, "AC", "IN") & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & "  AND  cd_desde='" & oupd.cdesde & "'"
            sql = sql & "  AND  cd_hasta='" & oupd.cdhasta & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updNavegacion()", "Ocurrio un error al actualizar un registro a la tabla gen036_navegacion [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen027_sincronia
    ''' </summary>
    ''' <param name="oupd">objeto tipo Sincronia</param>
    ''' <remarks></remarks>
    Public Sub updSincronia(ByVal oupd As Sincronia)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen027_sincronia"
            sql = sql & " SET nb_sincronia= '" & oupd.nbsincronia & "'"
            sql = sql & ",st_sincronia= '" & oupd.estatus & "'"
            sql = sql & ",cd_estilo_genera= '" & oupd.cdestilogenera & "'"
            sql = sql & ",xm_sincronia= '" & oupd.xmsincronia & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_sincronia='" & oupd.cdsincronia & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.updSincronia()", "Ocurrio un error al actualizar en gen027_sincronia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updSincronia()", "Ocurrio un error al actualizar en gen027_sincronia [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen038_sincronia_pantalla
    ''' </summary>
    ''' <param name="oupd">objeto tipo SincroniaPantalla</param>
    ''' <remarks></remarks>
    Public Sub updSincroniaPantalla(ByVal oupd As SincroniaPantalla)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen038_sincronia_pantalla"
            sql = sql & " SET nb_htmlfile= '" & oupd.nbhtmlfile & "'"
            sql = sql & ",nb_htmlforma= '" & oupd.nbhtmlforma & "'"
            sql = sql & ",nb_extension= '" & oupd.nbextension & "'"
            sql = sql & ",xm_pantalla= '" & oupd.xmlpantalla & "'"
            sql = sql & ",st_pantalla= '" & oupd.estatus & "'"
            sql = sql & ",nb_componente= '" & oupd.nbcomponente & "'"
            sql = sql & ",cd_estilo_funcion= '" & oupd.cdestilofuncion & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & oupd.cdpantalla & "'"
            sql = sql & " AND   cd_sincronia='" & oupd.cdsincronia & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updSincroniaPantalla()", "Ocurrio un error al actualizar en gen038_sincronia_pantalla [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen039_sincronia_evento
    ''' </summary>
    ''' <param name="oupd">objeto tipo SincroniaEvento</param>
    ''' <remarks></remarks>
    Public Sub updSincroniaEvento(ByVal oupd As SincroniaEvento)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen039_sincronia_evento"
            sql = sql & " SET xm_evento= '" & oupd.xmlevento & "'"
            sql = sql & ",st_evento= '" & oupd.estatus & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & oupd.cdpantalla & "'"
            sql = sql & " AND   cd_evento='" & oupd.cdevento & "'"
            sql = sql & " AND   cd_sincronia='" & oupd.cdsincronia & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updSincroniaEvento()", "Ocurrio un error al actualizar en gen039_sincronia_evento [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen044_sincronia_parreglo
    ''' </summary>
    ''' <param name="oupd">objeto tipo SincroniArreglo</param>
    ''' <remarks></remarks>
    Public Sub updSincroniArreglo(ByVal oupd As SincroniArreglo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen044_sincronia_parreglo"
            sql = sql & " SET nb_idhtml= '" & oupd.nbidhtml & "'"
            sql = sql & ",tp_element= '" & oupd.tpelement & "'"
            sql = sql & ",nb_element= '" & oupd.nbelement & "'"
            sql = sql & ",nb_object= '" & oupd.nbobject & "'"
            sql = sql & ",st_arreglo= '" & oupd.starreglo & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & oupd.cdpantalla & "'"
            sql = sql & " AND   cd_arreglo='" & oupd.cdarreglo & "'"
            sql = sql & " AND   cd_sincronia='" & oupd.cdsincronia & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updSincroniArreglo()", "Ocurrio un error al actualizar en gen044_sincronia_parreglo [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen040_sincronia_campo
    ''' </summary>
    ''' <param name="oupd">objeto tipo SincroniaCampo</param>
    ''' <remarks></remarks>
    Public Sub updSincroniaCampo(ByVal oupd As SincroniaCampo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen040_sincronia_campo"
            sql = sql & " SET xm_campo= '" & oupd.xmlcampo & "'"
            sql = sql & ",nb_idhtml= '" & oupd.nbidhtml & "'"
            sql = sql & ",st_campo= '" & oupd.estatus & "'"
            sql = sql & " WHERE cd_pantalla='" & oupd.cdpantalla & "'"
            sql = sql & " AND   cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_campo='" & oupd.cdcampo & "'"
            sql = sql & " AND   cd_sincronia='" & oupd.cdsincronia & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updSincroniaCampo()", "Ocurrio un error al actualizar en gen040_sincronia_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen042_pantalla_arreglo
    ''' </summary>
    ''' <param name="oupd">objeto tipo Pantallarreglo</param>
    ''' <remarks></remarks>
    Public Sub updPantallarreglo(ByVal oupd As Pantallarreglo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen042_pantalla_arreglo"
            sql = sql & " SET nu_rensxpagina= " & oupd.nurensxpagina
            sql = sql & ",tp_inoutput= '" & oupd.tpinoutput & "'"
            sql = sql & ",nb_arreglo= '" & oupd.nbarreglo & "'"
            sql = sql & ",st_paginacion= '" & oupd.stpaginacion & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & oupd.cdpantalla & "'"
            sql = sql & " AND   cd_arreglo='" & oupd.cdarreglo & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updPantallarreglo()", "Ocurrio un error al actualizar en gen042_pantalla_arreglo [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen043_reporte_arreglo
    ''' </summary>
    ''' <param name="oupd">objeto tipo ReporteArreglo</param>
    ''' <remarks></remarks>
    Public Sub updReporteArreglo(ByVal oupd As ReporteArreglo)
        Dim objCommand As SQLiteCommand
        Try
            sql = "UPDATE gen043_reporte_arreglo"
            sql = sql & " SET nb_arreglo= '" & oupd.nbarreglo & "'"
            sql = sql & ",nu_rensxpagina= " & oupd.nurensxpagina
            sql = sql & ",st_paginacion= '" & oupd.stpaginacion & "'"
            sql = sql & " WHERE cd_proyecto='" & oupd.cdproyecto & "'"
            sql = sql & " AND   cd_reporte='" & oupd.cdreporte & "'"
            sql = sql & " AND   cd_arreglo='" & oupd.cdarreglo & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updReporteArreglo()", "Ocurrio un error al actualizar en gen043_reporte_arreglo [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen032_referencia
    ''' </summary>
    ''' <param name="oupd">objeto tipo Referencia</param>
    ''' <remarks></remarks>
    Public Sub updReferencia(ByVal oupd As Referencia)
        Dim objCommand As SQLiteCommand

        Try
            sql = "UPDATE gen032_referencia"
            sql = sql & " SET nb_referencia= '" & oupd.nbreferencia & "'"
            sql = sql & ",tx_comment= '" & oupd.txcomment & "'"
            sql = sql & " WHERE cd_fuentedato='" & oupd.cdfuentedato & "'"
            sql = sql & " AND   nb_entidadato='" & oupd.nbentidadato & "'"
            sql = sql & " AND   cd_referencia='" & oupd.cdreferencia & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.updReferencia()", "Ocurrio un error al actualizar en gen032_referencia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updReferencia()", "Ocurrio un error al actualizar en gen032_referencia [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen051_referenciacampo
    ''' </summary>
    ''' <param name="oupd">objeto tipo Referenciacampo</param>
    ''' <remarks></remarks>
    Public Sub updReferenciacampo(ByVal oupd As Referenciacampo)
        Dim objCommand As SQLiteCommand

        Try
            sql = "UPDATE gen051_referenciacampo"
            sql = sql & " SET nb_campo= '" & oupd.nbcampo & "'"
            sql = sql & " WHERE cd_referencia='" & oupd.cdreferencia & "'"
            sql = sql & " AND   cd_fuentedato='" & oupd.cdfuentedato & "'"
            sql = sql & " AND   nb_entidadato='" & oupd.nbentidadato & "'"
            sql = sql & " AND   nu_llavecampo='" & oupd.nullavecampo & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.updReferenciacampo()", "Ocurrio un error al actualizar en gen051_referenciacampo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.updReferenciacampo()", "Ocurrio un error al actualizar en gen051_referenciacampo [" & ex1.ToString & "]")
        End Try
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                DELETE CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////

    ''' <summary>
    ''' Procedimiento para eliminar un registro de Proyecto
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <remarks></remarks>
    Friend Sub delProyecto(ByVal scdproyecto As String)
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen003_proyecto "
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delProyecto()", "Ocurrio un error al eliminar de la tabla gen003_proyecto [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de Staff
    ''' </summary>
    ''' <param name="sproject"></param>
    ''' <param name="sstaff"></param>
    ''' <remarks></remarks>
    Friend Sub delStaff(ByVal sproject As String, ByVal sstaff As String)
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen006_staff "
            sql = sql & " WHERE cd_proyecto='" & sproject & "'"
            sql = sql & " AND   cd_staff='" & sstaff & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delStaff()", "Ocurrio un error al eliminar de la tabla gen006_staff [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de Persona
    ''' </summary>
    ''' <param name="scdpersona">clave de la persona</param>
    ''' <remarks></remarks>
    Friend Sub delPersona(ByVal scdpersona As String)
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen004_persona "
            sql = sql & " WHERE cd_persona='" & scdpersona & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delPersona()", "Ocurrio un error al eliminar de la tabla gen004_persona [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de Pantalla
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <remarks></remarks>
    Friend Sub delPantalla(ByVal scdproyecto As String, ByVal scdpantalla As String)
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen011_pantalla "
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & "  AND  cd_pantalla='" & scdpantalla & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delPantalla()", "Ocurrio un error al eliminar de la tabla gen011_pantalla [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de Reporte
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdreporte">clave del reporte</param>
    ''' <remarks></remarks>
    Friend Sub delReporte(ByVal scdproyecto As String, ByVal scdreporte As String)
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen030_reporte "
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & "  AND  cd_reporte='" & scdreporte & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delReporte()", "Ocurrio un error al eliminar de la tabla gen030_reporte [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de Steackholder
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdsteackholder">clave de la persona</param>
    ''' <remarks></remarks>
    Friend Sub delSteackholder(ByVal scdproyecto As String, ByVal scdsteackholder As String)
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen005_steackholder "
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_steackholder='" & scdsteackholder & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delSteackholder()", "Ocurrio un error al eliminar de la tabla gen005_steackholder [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar la información relativa a un botón en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyect</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <param name="scdboton">clave del boton</param>
    ''' <remarks></remarks>
    Friend Sub delPantallaBoton(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdboton As String)
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen015_pantalla_boton "
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & scdpantalla & "'"
            sql = sql & " AND   cd_boton='" & scdboton & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delPantallaBoton()", "Ocurrio un error al eliminar de la tabla gen015_pantalla_boton [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un campo de la base de datos
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <param name="scdcampo">clave del campo</param>
    ''' <remarks></remarks>
    Friend Sub delPantallaCampo(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdcampo As String)
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen013_pantalla_campo "
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & scdpantalla & "'"
            sql = sql & " AND   cd_campo='" & scdcampo & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delPantallaCampo()", "Ocurrio un error al eliminar de la tabla gen013_pantalla_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un campo del reporte
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdreporte">clave del reporte</param>
    ''' <param name="scdcampo">clave del campo</param>
    ''' <remarks></remarks>
    Friend Function delReporteCampo(ByVal scdproyecto As String, ByVal scdreporte As String, ByVal scdcampo As String) As Boolean
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen031_reporte_campo"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & "  AND  cd_reporte='" & scdreporte & "'"
            sql = sql & "  AND  cd_campo='" & scdcampo & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delReporteCampo()", "Ocurrio un error al eliminar de la tabla gen031_reporte_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Function

    ''' <summary>
    ''' Function para eliminar un registro de la tabla gen022_datasource
    ''' </summary>
    ''' <param name="scdfuentedato">clave del datasource a eliminar</param>
    ''' <remarks></remarks>
    Friend Sub delFuenteDato(ByVal scdfuentedato As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen022_fuentedato"
            sql = sql & " WHERE cd_fuentedato='" & scdfuentedato & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delFuenteDato()", "Ocurrio un error al eliminar de la tabla gen022_fuentedato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Function para eliminar un registro de la tabla gen023_entidadato
    ''' </summary>
    ''' <param name="scdfuentedato">clave de la fuente de datos</param>
    ''' <param name="snbentidadato">nombre de la entidad de datos</param>
    ''' <remarks></remarks>
    Friend Sub delEntidaDato(ByVal scdfuentedato As String, ByVal snbentidadato As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen023_entidadato"
            sql = sql & " WHERE cd_fuentedato='" & scdfuentedato & "'"
            sql = sql & "  AND  nb_entidadato='" & snbentidadato & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delEntidaDato()", "Ocurrio un error al eliminar de la tabla gen023_entidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de gen024_dbentidad_campo
    ''' </summary>
    ''' <param name="scdfuentedato">clave de la fuente de datos</param>
    ''' <param name="snbentidadato">nombre de la entidad de datos</param>
    ''' <remarks></remarks>
    Friend Sub delEntidaDatoCampos(ByVal scdfuentedato As String, ByVal snbentidadato As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen024_entidadato_campo"
            sql = sql & " WHERE cd_fuentedato='" & scdfuentedato & "'"
            sql = sql & "  AND  nb_entidadato='" & snbentidadato & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delEntidaDatoCampos()", "Ocurrio un error al eliminar de la tabla gen024_entidadato_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de gen024_entidadato_campo
    ''' </summary>
    ''' <param name="scdfuentedato">clave de la fuente de datos</param>
    ''' <param name="snbentidad">nombre de la entidad de datos</param>
    ''' <param name="snbcampo">nombre del campo</param>
    ''' <remarks></remarks>
    Friend Sub delEntidaDatoCampo(ByVal scdfuentedato As String, ByVal snbentidad As String, ByVal snbcampo As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen024_entidadato_campo"
            sql = sql & " WHERE cd_fuentedato='" & scdfuentedato & "'"
            sql = sql & "  AND  nb_entidadato='" & snbentidad & "'"
            sql = sql & "  AND  nb_campo='" & snbcampo & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delEntidaDatoCampo()", "Ocurrio un error al eliminar de la tabla gen024_entidadato_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar una fuente de datos desde un proyecto
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyect</param>
    ''' <param name="scdfuentedato">Clave de la fuente de datos</param>
    ''' <remarks></remarks>
    Friend Sub delProyectoFuenteDato(ByVal scdproyecto As String, ByVal scdfuentedato As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen021_proyecto_fuentedato"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & "  AND  cd_fuentedato='" & scdfuentedato & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delProyectoFuenteDato()", "Ocurrio un error al eliminar de la tabla gen021_proyecto_fuentedato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar las entidades que pertenecen a la relación de un proyecto y una fuente de datos
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyect</param>
    ''' <param name="scdfuentedato">Clave de la fuente de datos</param>
    ''' <param name="snbentidad">Nombre de la entidad de datos</param>
    ''' <remarks></remarks>
    Friend Sub delProyectoFuenteDatoEntidad(ByVal scdproyecto As String, ByVal scdfuentedato As String, ByVal snbentidad As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen025_proyecto_entidadato"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & "  AND  cd_fuentedato='" & scdfuentedato & "'"
            sql = sql & "  AND  nb_entidadato='" & snbentidad & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delProyectoFuenteDatoEntidad()", "Ocurrio un error al eliminar de la tabla gen025_proyecto_entidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar las entidades que pertenecen a la relación de un proyecto y una fuente de datos
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyect</param>
    ''' <param name="scdfuentedato">Clave de la fuente de datos</param>
    ''' <remarks></remarks>
    Friend Sub delProyectoFuenteDatoEntidades(ByVal scdproyecto As String, ByVal scdfuentedato As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen025_proyecto_entidadato"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & "  AND  cd_fuentedato='" & scdfuentedato & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delProyectoFuenteDatoEntidades()", "Ocurrio un error al eliminar de la tabla gen025_proyecto_entidadato [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un metodo relacionado a un objeto
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdpantalla">Clave de la pantalla</param>
    ''' <param name="scdevento">Clave del evento para el objeto</param>
    ''' <remarks></remarks>
    Friend Sub delPantallaEvento(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdevento As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen034_pantalla_evento"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & "  AND  cd_pantalla='" & scdpantalla & "'"
            sql = sql & "  AND  cd_evento='" & scdevento & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delPantallaEvento()", "Ocurrio un error al eliminar de la tabla gen034_pantalla_evento [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar una navegación en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdesde">Clave del proyecto desde</param>
    ''' <param name="scdhasta">Clave del proyecto hasta</param>
    ''' <remarks></remarks>
    Friend Sub delNavegacion(ByVal scdproyecto As String, ByVal scdesde As String, ByVal scdhasta As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen036_navegacion"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & "  AND  cd_desde='" & scdesde & "'"
            sql = sql & "  AND  cd_hasta='" & scdhasta & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delNavegacion()", "Ocurrio un error al eliminar de la tabla gen036_navegacion [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar los parámetros de la navegación
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdesde">Clave de la pantalla desde donde se llama</param>
    ''' <param name="scdhasta">Clave de la pantalla hasta donde se llama</param>
    ''' <remarks></remarks>
    Friend Sub delNavegacionParams(ByVal scdproyecto As String, ByVal scdesde As String, ByVal scdhasta As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen037_navegacion_param"
            sql = sql & " WHERE cd_proyecto='" & scdproyecto & "'"
            sql = sql & "  AND  cd_desde='" & scdesde & "'"
            sql = sql & "  AND  cd_hasta='" & scdhasta & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delNavegacionParams()", "Ocurrio un error al eliminar de la tabla gen037_navegacion_param [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen027_sincronia
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de la sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <remarks></remarks>
    Public Sub delSincronia(ByVal pscdsincronia As String, ByVal pscdproyecto As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen027_sincronia"
            sql = sql & " WHERE cd_sincronia='" & pscdsincronia & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delSincronia(key)", "Ocurrio un error al eliminar de gen027_sincronia [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen038_sincronia_pantalla
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <remarks></remarks>
    Public Sub delSincroniaPantalla(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen038_sincronia_pantalla"
            sql = sql & " WHERE cd_sincronia='" & pscdsincronia & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"

            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delSincroniaPantalla(key)", "Ocurrio un error al eliminar de gen038_sincronia_pantalla [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen039_sincronia_evento
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <param name="pscdevento">Clave del evento</param>
    ''' <remarks></remarks>
    Public Sub delSincroniaEvento(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String, ByVal pscdevento As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen039_sincronia_evento"
            sql = sql & " WHERE cd_sincronia='" & pscdsincronia & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"
            sql = sql & " AND   cd_evento='" & pscdevento & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delSincroniaEvento(key)", "Ocurrio un error al eliminar de gen039_sincronia_evento [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen039_sincronia_evento
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <remarks></remarks>
    Public Sub delSincroniaEventos(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen039_sincronia_evento"
            sql = sql & " WHERE cd_sincronia='" & pscdsincronia & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delSincroniaEventos(key)", "Ocurrio un error al eliminar de gen039_sincronia_evento [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen040_sincronia_campo
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de la sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <param name="pscdcampo">Clave del campo</param>
    ''' <remarks></remarks>
    Public Sub delSincroniaCampo(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String, ByVal pscdcampo As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen040_sincronia_campo"
            sql = sql & " WHERE cd_sincronia='" & pscdsincronia & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"
            sql = sql & " AND   cd_campo='" & pscdcampo & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delSincroniaCampo(key)", "Ocurrio un error al eliminar de gen040_sincronia_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen040_sincronia_campo
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de la sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <remarks></remarks>
    Public Sub delSincroniaCampos(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen040_sincronia_campo"
            sql = sql & " WHERE cd_sincronia='" & pscdsincronia & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delSincroniaCampos(key)", "Ocurrio un error al eliminar de gen040_sincronia_campo [" & ex1.ToString & "] sql=[" & sql & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen044_sincronia_parreglo
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de la sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <param name="pscdarreglo">Clave del arreglo</param>
    ''' <remarks></remarks>
    Public Sub delSincroniArreglo(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String, ByVal pscdarreglo As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen044_sincronia_parreglo"
            sql = sql & " WHERE cd_sincronia='" & pscdsincronia & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"
            sql = sql & " AND   cd_arreglo='" & pscdarreglo & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delSincroniArreglo(key)", "Ocurrio un error al eliminar de gen044_sincronia_parreglo [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen044_sincronia_parreglo
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de la sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <remarks></remarks>
    Public Sub delSincroniArreglos(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen044_sincronia_parreglo"
            sql = sql & " WHERE cd_sincronia='" & pscdsincronia & "'"
            sql = sql & " AND   cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delSincroniArreglos(key)", "Ocurrio un error al eliminar de gen044_sincronia_parreglo [" & ex1.ToString & "]")
        End Try
    End Sub


    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen042_pantalla_arreglo
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <param name="pscdarreglo">Clave del arreglo</param>
    ''' <remarks></remarks>
    Public Sub delPantallarreglo(ByVal pscdproyecto As String, ByVal pscdpantalla As String, ByVal pscdarreglo As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen042_pantalla_arreglo"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_pantalla='" & pscdpantalla & "'"
            sql = sql & " AND   cd_arreglo='" & pscdarreglo & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delPantallarreglo(key)", "Ocurrio un error al eliminar de gen042_pantalla_arreglo [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen043_reporte_arreglo
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdreporte">Clave del reporte</param>
    ''' <param name="pscdarreglo">Clave del arreglo</param>
    ''' <remarks></remarks>
    Public Sub delReporteArreglo(ByVal pscdproyecto As String, ByVal pscdreporte As String, ByVal pscdarreglo As String)
        Dim objCommand As SQLiteCommand
        Try
            sql = "DELETE FROM gen043_reporte_arreglo"
            sql = sql & " WHERE cd_proyecto='" & pscdproyecto & "'"
            sql = sql & " AND   cd_reporte='" & pscdreporte & "'"
            sql = sql & " AND   cd_arreglo='" & pscdarreglo & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delReporteArreglo(key)", "Ocurrio un error al eliminar de gen043_reporte_arreglo [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen032_referencia
    ''' </summary>
    ''' <param name="pscdfuentedato">Clave de la fuente de datos</param>
    ''' <param name="psnbentidadato">Nombre de la entidad de datos</param>
    ''' <param name="pscdreferencia">Clave de la referencia</param>
    ''' <remarks></remarks>
    Public Sub delReferencia(ByVal pscdfuentedato As String, ByVal psnbentidadato As String, ByVal pscdreferencia As String)
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen032_referencia"
            sql = sql & " WHERE cd_fuentedato='" & pscdfuentedato & "'"
            sql = sql & " AND   nb_entidadato='" & psnbentidadato & "'"
            sql = sql & " AND   cd_referencia='" & pscdreferencia & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.delReferencia(key)", "Ocurrio un error al eliminar de gen032_referencia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delReferencia(key)", "Ocurrio un error al eliminar de gen032_referencia [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen051_referenciacampo
    ''' </summary>
    ''' <param name="pscdreferencia">Clave de la referencia</param>
    ''' <param name="pscdfuentedato">Clave de la fuente de datos</param>
    ''' <param name="psnbentidadato">Nombre de la entidad de datos</param>
    ''' <param name="psnullavecampo">Numero o posicion del campo dentro de la referencia</param>
    ''' <remarks></remarks>
    Public Sub delReferenciacampo(ByVal pscdreferencia As String, ByVal pscdfuentedato As String, ByVal psnbentidadato As String, ByVal psnullavecampo As String)
        Dim objCommand As SQLiteCommand

        Try
            sql = "DELETE FROM gen051_referenciacampo"
            sql = sql & " WHERE cd_referencia='" & pscdreferencia & "'"
            sql = sql & " AND   cd_fuentedato='" & pscdfuentedato & "'"
            sql = sql & " AND   nb_entidadato='" & psnbentidadato & "'"
            sql = sql & " AND   nu_llavecampo='" & psnullavecampo & "'"
            objCommand = New SQLiteCommand(sql, ocnn)
            objCommand.ExecuteNonQuery()
            objCommand.Dispose()
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.DBCatalogos.delReferenciacampo(key)", "Ocurrio un error al eliminar de gen051_referenciacampo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DBCatalogos.delReferenciacampo(key)", "Ocurrio un error al eliminar de gen051_referenciacampo [" & ex1.ToString & "]")
        End Try
    End Sub

End Class  'fin clase [DBCatalogos]
