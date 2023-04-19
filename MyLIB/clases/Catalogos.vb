Option Explicit On
Imports System.Data.SQLite

Public Class Catalogos
    Private odb As DBCatalogos
    Private olog As HANYLog
    Private smensaje As String = ""     'ultimo mensaje de error

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByRef cnn As SQLiteConnection)
        Try
            odb = New DBCatalogos(cnn)
            olog = New HANYLog
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.New(cnn)", "Ocurrio un error al conectarse a la base de datos")
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' PROPIEDAD: ultimo mensaje de error
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property mensaje() As String
        Get
            Return smensaje
        End Get
        Set(ByVal psval As String)
            smensaje = psval
        End Set
    End Property


    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                SELECT CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////

    ''' <summary>
    ''' Procedimiento para la consulta del catálogo de empresas
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getEmpresas() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getEmpresas()
            orows = oset.Tables("empresas").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Empresa = New Empresa
                obj.cdempresa = orows.Item(i).Item("cd_empresa")
                obj.nbempresa = orows.Item(i).Item("nb_empresa")
                obj.cdrfc = orows.Item(i).Item("cd_rfc")
                obj.nbdireccion = orows.Item(i).Item("nb_direccion")
                obj.nutelefono = orows.Item(i).Item("nu_telefono")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getEmpresas()", "Ocurrio un error al consultar las empresas")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getEmpresas()", "Ocurrio un error al consultar las empresas [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function


    ''' <summary>
    ''' Procedimiento para la consulta de un registro de la tabla gen001_empresa
    ''' </summary>
    ''' <returns>Empresa</returns>
    ''' <remarks></remarks>
    Public Function getEmpresa(ByVal scd As String) As Empresa
        Dim oset As DataSet
        Dim obj As Empresa
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getEmpresa(scd)
            orows = oset.Tables("empresas").Rows
            If orows.Count = 1 Then
                obj = New Empresa
                obj.cdempresa = orows.Item(0).Item("cd_empresa")
                obj.nbempresa = orows.Item(0).Item("nb_empresa")
                obj.cdrfc = orows.Item(0).Item("cd_rfc")
                obj.nbdireccion = orows.Item(0).Item("nb_direccion")
                obj.nutelefono = orows.Item(0).Item("nu_telefono")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getEmpresa(cd)", "Ocurrio un error al consultar la empresa")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getEmpresa(cd)", "Ocurrio un error al consultar la empresa [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function


    ''' <summary>
    ''' Procedimiento para la consulta de un registro de la tabla gen002_cliente
    ''' </summary>
    ''' <returns>Cliente</returns>
    ''' <remarks></remarks>
    Public Function getCliente(ByVal scd As String) As Cliente
        Dim oset As DataSet
        Dim obj As Cliente
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getCliente(scd)
            orows = oset.Tables("clientes").Rows
            If orows.Count = 1 Then
                obj = New Cliente
                obj.cdcliente = orows.Item(0).Item("cd_cliente")
                obj.cdrfc = orows.Item(0).Item("cd_rfc")
                obj.nutelefono = orows.Item(0).Item("nu_telefono")
                obj.nbdireccion = orows.Item(0).Item("nb_direccion")
                obj.nbcliente = orows.Item(0).Item("nb_cliente")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getCliente(cd)", "Ocurrio un error al consultar el cliente")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getCliente(cd)", "Ocurrio un error al consultar el cliente [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta de un registro de la tabla gen002_cliente
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getClientes() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getClientes()
            orows = oset.Tables("clientes").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Cliente = New Cliente
                obj.cdcliente = orows.Item(i).Item("cd_cliente")
                obj.cdrfc = orows.Item(i).Item("cd_rfc")
                obj.nutelefono = orows.Item(i).Item("nu_telefono")
                obj.nbdireccion = orows.Item(i).Item("nb_direccion")
                obj.nbcliente = orows.Item(i).Item("nb_cliente")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getClientes()", "Ocurrio un error al consultar los clientes")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getClientes()", "Ocurrio un error al consultar los clientes [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de estatus de un proyecto
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getStProyectos() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getStProyectos()
            orows = oset.Tables("estatus").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Estatus = New Estatus
                obj.clave = orows.Item(i).Item("cd_stproyecto")
                obj.nombre = orows.Item(i).Item("nb_stproyecto")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getStProyectos()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getStProyectos()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un renglón de estatus de un proyecto
    ''' </summary>
    ''' <returns>Estatus</returns>
    ''' <remarks></remarks>
    Public Function getStProyecto(ByVal scd As String) As Estatus
        Dim oset As DataSet
        Dim obj As Estatus
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getStProyecto(scd)
            orows = oset.Tables("estatus").Rows
            If orows.Count = 1 Then
                obj = New Estatus
                obj.clave = orows.Item(0).Item("cd_stproyecto")
                obj.nombre = orows.Item(0).Item("nb_stproyecto")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getStProyecto()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getStProyecto()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de proyectos
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getProyectos(ByRef ocrit As Criterio) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        'PASO 1: consulta los proyectos
        oc = New Collection
        Try
            oset = odb.getProyectos(ocrit)
            orows = oset.Tables("proyectos").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Proyecto = New Proyecto
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdstproyecto = orows.Item(i).Item("cd_stproyecto")
                obj.nbproyecto = orows.Item(i).Item("nb_proyecto")
                obj.cdcliente = orows.Item(i).Item("cd_cliente")
                obj.cdpmp = orows.Item(i).Item("cd_pmp")
                obj.comment = orows.Item(i).Item("tx_comment")
                obj.cdempresa = orows.Item(i).Item("cd_empresa")
                obj.imprecio = orows.Item(i).Item("im_precio")
                obj.imiva = orows.Item(i).Item("im_iva")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getProyectos(crit,1)", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getProyectos(crit,1)", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing

        'PASO 2: recorre cada renglón para colocarle las descripciones
        Try
            For Each op As Proyecto In oc
                Dim ocliente As Cliente = Me.getCliente(op.cdcliente)
                Dim oempresa As Empresa = Me.getEmpresa(op.cdempresa)
                Dim opmp As Persona = Me.getPersona(op.cdpmp)
                Dim oestatus As Estatus = Me.getStProyecto(op.cdstproyecto)
                If Not ocliente Is Nothing Then op.nbcliente = ocliente.nbcliente
                If Not oempresa Is Nothing Then op.nbempresa = oempresa.nbempresa
                If Not opmp Is Nothing Then op.nbpmp = opmp.nbpersona
                If Not oestatus Is Nothing Then op.nbstproyecto = oestatus.nombre
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getProyectos(crit,2)", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getProyectos(crit,2)", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un proyecto en particular
    ''' </summary>
    ''' <returns>Proyecto</returns>
    ''' <remarks></remarks>
    Public Function getProyecto(ByVal scd As String) As Proyecto
        Dim oset As DataSet
        Dim obj As Proyecto
        Dim orows As DataRowCollection
        Dim oemp As Empresa
        Dim octe As Cliente

        obj = Nothing
        Try
            'PASO 1: Consulta los datos del proyecto
            oset = odb.getProyecto(scd)
            orows = oset.Tables("proyectos").Rows
            If orows.Count = 1 Then
                obj = New Proyecto
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdstproyecto = orows.Item(0).Item("cd_stproyecto")
                obj.nbproyecto = orows.Item(0).Item("nb_proyecto")
                obj.cdcliente = orows.Item(0).Item("cd_cliente")
                obj.cdpmp = orows.Item(0).Item("cd_pmp")
                obj.comment = orows.Item(0).Item("tx_comment")
                obj.cdempresa = orows.Item(0).Item("cd_empresa")
                obj.imprecio = orows.Item(0).Item("im_precio")
                obj.imiva = orows.Item(0).Item("im_iva")
            End If

            'PASO 2: Consulta la información de cliente
            octe = Me.getCliente(obj.cdcliente)
            If Not octe Is Nothing Then obj.nbcliente = octe.nbcliente

            'PASO 3: Consulta la información de la empresa
            oemp = Me.getEmpresa(obj.cdempresa)
            If Not oemp Is Nothing Then obj.nbempresa = oemp.nbempresa

        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getProyecto()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getProyecto()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de personas
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getPersonas() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getPersonas()
            orows = oset.Tables("personas").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Persona = New Persona
                obj.cdpersona = orows.Item(i).Item("cd_persona")
                obj.cdusuario = orows.Item(i).Item("cd_usuario")
                obj.cdtipo = orows.Item(i).Item("cd_tipo")
                obj.cdrfc = orows.Item(i).Item("cd_rfc")
                obj.nutelcasa = orows.Item(i).Item("nu_telcasa")
                obj.nuteloficina = orows.Item(i).Item("nu_teloficina")
                obj.nbpersona = orows.Item(i).Item("nb_persona")
                obj.nbempresa = orows.Item(i).Item("nb_empresa")
                obj.nbemail = orows.Item(i).Item("nb_email")
                obj.comment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPersonas()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPersonas()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc

    End Function

    ''' <summary>
    ''' Procedimiento para la consulta de un registro de la tabla gen002_cliente
    ''' </summary>
    ''' <returns>Persona</returns>
    ''' <remarks></remarks>
    Public Function getPersona(ByVal scd As String) As Persona
        Dim oset As DataSet
        Dim obj As Persona
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getPersona(scd)
            orows = oset.Tables("personas").Rows
            If orows.Count = 1 Then
                obj = New Persona
                obj.cdpersona = orows.Item(0).Item("cd_persona")
                obj.cdusuario = orows.Item(0).Item("cd_usuario")
                obj.cdtipo = orows.Item(0).Item("cd_tipo")
                obj.cdrfc = orows.Item(0).Item("cd_rfc")
                obj.nutelcasa = orows.Item(0).Item("nu_telcasa")
                obj.nuteloficina = orows.Item(0).Item("nu_teloficina")
                obj.nbpersona = orows.Item(0).Item("nb_persona")
                obj.nbempresa = orows.Item(0).Item("nb_empresa")
                obj.nbemail = orows.Item(0).Item("nb_email")
                obj.comment = orows.Item(0).Item("tx_comment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPersona()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPersona()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de roles del stafff
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getRolStaffs() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getRolStaffs()
            orows = oset.Tables("roles").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Rol = New Rol
                obj.clave = orows.Item(i).Item("cd_rolstaff")
                obj.nombre = orows.Item(i).Item("nb_rolstaff")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getRolStaffs()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getRolStaffs()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un rol del staff en particular
    ''' </summary>
    ''' <param name="scd">clave del rol</param>
    ''' <returns>Rol</returns>
    ''' <remarks></remarks>
    Public Function getRolStaff(ByVal scd As String) As Rol
        Dim oset As DataSet
        Dim obj As Rol
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getRolStaff(scd)
            orows = oset.Tables("roles").Rows
            If orows.Count = 1 Then
                obj = New Rol
                obj.clave = orows.Item(0).Item("cd_rolstaff")
                obj.nombre = orows.Item(0).Item("nb_rolstaff")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getRolStaff()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getRolStaff()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function


    ''' <summary>
    ''' Procedimiento para consultar toda la información del catálogo de Staffs
    ''' </summary>
    ''' <param name="ocrit">criterios de consulta del staff</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getStaffs(ByRef ocrit As Criterio) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getStaffs(ocrit)
            orows = oset.Tables("staff").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Staff = New Staff
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdstaff = orows.Item(i).Item("cd_staff")
                obj.cdpersona = orows.Item(i).Item("cd_persona")
                obj.cdrolstaff = orows.Item(i).Item("cd_rolstaff")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
            oset = Nothing

            'PASO 2: recorre cada renglón para colocarle las descripciones

            For Each ostaff As Staff In oc
                Dim opersona As Persona = Me.getPersona(ostaff.cdpersona)
                Dim orol As Rol = Me.getRolStaff(ostaff.cdrolstaff)
                If Not opersona Is Nothing Then ostaff.nbpersona = opersona.nbpersona
                If Not orol Is Nothing Then ostaff.nbrolstaff = orol.nombre
            Next

        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getStaffs()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getStaffs()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un staff en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdstaff">clave del staff</param>
    ''' <returns>Staff</returns>
    ''' <remarks></remarks>
    Public Function getStaff(ByVal scdproyecto As String, ByVal scdstaff As String) As Staff
        Dim oset As DataSet
        Dim obj As Staff
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getStaff(scdproyecto, scdstaff)
            orows = oset.Tables("staff").Rows
            If orows.Count = 1 Then
                obj = New Staff
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdstaff = orows.Item(0).Item("cd_staff")
                obj.cdpersona = orows.Item(0).Item("cd_persona")
                obj.cdrolstaff = orows.Item(0).Item("cd_rolstaff")
                obj.txcomment = orows.Item(0).Item("tx_comment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getStaff()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getStaff()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
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
    ''' Procedimiento para consultar toda la información de los steackholders
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getSteackholders(ByVal scdproyecto As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getSteackholders(scdproyecto)
            orows = oset.Tables("steackholder").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Steackholder = New Steackholder
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdsteackholder = orows.Item(i).Item("cd_steackholder")
                obj.cdpersona = orows.Item(i).Item("cd_persona")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getSteackholders(1)", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getSteackholders(1)", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing

        'PASO 2: recorre cada renglón para colocarle las descripciones
        Try
            For Each osteack As Steackholder In oc
                Dim opersona As Persona = Me.getPersona(osteack.cdpersona)
                If Not opersona Is Nothing Then osteack.nbpersona = opersona.nbpersona
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getSteackholders(2)", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getSteackholders(2)", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar la información del Steackholder
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyect</param>
    ''' <param name="scdsteackholder">Clave del steackholder</param>
    ''' <returns>Steackholder</returns>
    ''' <remarks></remarks>
    Public Function getSteackholder(ByVal scdproyecto As String, ByVal scdsteackholder As String) As Steackholder
        Dim oset As DataSet
        Dim obj As Steackholder
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getSteackholder(scdproyecto, scdsteackholder)
            orows = oset.Tables("steackholder").Rows
            If orows.Count = 1 Then
                obj = New Steackholder
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdsteackholder = orows.Item(0).Item("cd_steackholder")
                obj.cdpersona = orows.Item(0).Item("cd_persona")
                obj.txcomment = orows.Item(0).Item("tx_comment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getSteackholder()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getSteackholder()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar las pantallas que se utilizan en el sistema
    ''' </summary>
    ''' <param name="scdproyecto">clave delproyecto</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getPantallas(ByVal scdproyecto As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getPantallas(scdproyecto)
            orows = oset.Tables("pantallas").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Pantalla = New Pantalla
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdpantalla = orows.Item(i).Item("cd_pantalla")
                obj.cdstanalisis = orows.Item(i).Item("cd_stanalisis")
                obj.cdstconstruccion = orows.Item(i).Item("cd_stconstruccion")
                obj.cdanalista = orows.Item(i).Item("cd_analista")
                obj.cdprogramador = orows.Item(i).Item("cd_programador")
                obj.nbpantalla = orows.Item(i).Item("nb_pantalla")
                If Not IsDBNull(orows.Item(i).Item("nb_imagefile")) Then obj.nbimagefile = orows.Item(i).Item("nb_imagefile")
                obj.cdcodigo = orows.Item(i).Item("cd_codigo")
                obj.txobjetivo = orows.Item(i).Item("tx_objetivo")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallas(1)", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallas(1)", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing

        'PASO 2: recorre cada renglón para colocarle las descripciones
        Try
            For Each opant As Pantalla In oc
                Dim oanalista As Persona = Me.getPersona(opant.cdanalista)
                Dim oprogramer As Persona = Me.getPersona(opant.cdprogramador)
                Dim ostanalisis As Estatus = Me.getStAnalisis(opant.cdstanalisis)
                Dim ostconstruc As Estatus = Me.getStConstruccion(opant.cdstconstruccion)
                If Not oanalista Is Nothing Then opant.nbanalista = oanalista.nbpersona
                If Not oprogramer Is Nothing Then opant.nbprogramador = oprogramer.nbpersona
                If Not ostanalisis Is Nothing Then opant.nbstanalisis = ostanalisis.nombre
                If Not ostconstruc Is Nothing Then opant.nbstconstruccion = ostconstruc.nombre
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallas(2)", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallas(2)", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar los reportes que se utilizan en el sistema
    ''' </summary>
    ''' <param name="scdproyecto">clave delproyecto</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getReportes(ByVal scdproyecto As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getReportes(scdproyecto)
            orows = oset.Tables("reportes").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Reporte = New Reporte
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdreporte = orows.Item(i).Item("cd_reporte")
                obj.cdstanalisis = orows.Item(i).Item("cd_stanalisis")
                obj.cdstconstruccion = orows.Item(i).Item("cd_stconstruccion")
                obj.cdanalista = orows.Item(i).Item("cd_analista")
                obj.cdprogramador = orows.Item(i).Item("cd_programador")
                obj.nbreporte = orows.Item(i).Item("nb_reporte")
                obj.nbimagefile = orows.Item(i).Item("nb_imagefile")
                obj.cdcodigo = orows.Item(i).Item("cd_codigo")
                obj.txobjetivo = orows.Item(i).Item("tx_objetivo")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getReportes(1)", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getReportes(1)", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing

        'PASO 2: recorre cada renglón para colocarle las descripciones
        Try
            For Each orep As Reporte In oc
                Dim oanalista As Persona = Me.getPersona(orep.cdanalista)
                Dim oprogramer As Persona = Me.getPersona(orep.cdprogramador)
                Dim ostanalisis As Estatus = Me.getStAnalisis(orep.cdstanalisis)
                Dim ostconstruc As Estatus = Me.getStConstruccion(orep.cdstconstruccion)
                If Not oanalista Is Nothing Then orep.nbanalista = oanalista.nbpersona
                If Not oprogramer Is Nothing Then orep.nbprogramador = oprogramer.nbpersona
                If Not ostanalisis Is Nothing Then orep.nbstanalisis = ostanalisis.nombre
                If Not ostconstruc Is Nothing Then orep.nbstconstruccion = ostconstruc.nombre
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getReportes(2)", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getReportes(2)", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try

        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar una pantalla que sea utilizada en el sistema
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <returns>Pantalla</returns>
    ''' <remarks></remarks>
    Public Function getPantalla(ByVal scdproyecto As String, ByVal scdpantalla As String) As Pantalla
        Dim oset As DataSet
        Dim obj As Pantalla
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getPantalla(scdproyecto, scdpantalla)
            orows = oset.Tables("pantallas").Rows
            If orows.Count = 1 Then
                obj = New Pantalla
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdpantalla = orows.Item(0).Item("cd_pantalla")
                obj.cdstanalisis = orows.Item(0).Item("cd_stanalisis")
                obj.cdstconstruccion = orows.Item(0).Item("cd_stconstruccion")
                obj.cdanalista = orows.Item(0).Item("cd_analista")
                obj.cdprogramador = orows.Item(0).Item("cd_programador")
                obj.nbpantalla = orows.Item(0).Item("nb_pantalla")
                If Not IsDBNull(orows.Item(0).Item("nb_imagefile")) Then obj.nbimagefile = orows.Item(0).Item("nb_imagefile")
                obj.cdcodigo = orows.Item(0).Item("cd_codigo")
                obj.txobjetivo = orows.Item(0).Item("tx_objetivo")
                obj.txcomment = orows.Item(0).Item("tx_comment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantalla()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantalla()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar una pantalla que sea utilizada en el sistema
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <returns>Pantalla</returns>
    ''' <remarks></remarks>
    Public Function getPantallaSinc(ByVal scdsincronia As String, ByVal scdproyecto As String, ByVal scdpantalla As String) As Pantalla
        Dim opant As Pantalla
        Dim oper As Persona
        Try
            opant = Me.getPantalla(scdproyecto, scdpantalla)
            oper = Me.getPersona(opant.cdprogramador)
            If Not oper Is Nothing Then opant.nbprogramador = oper.nbpersona
            opant.sincronia = Me.getSincroniaPantalla(scdsincronia, scdproyecto, scdpantalla)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallaSinc()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallaSinc()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        Return opant
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un reporte que sea utilizado en el sistema
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdreporte">clave del reporte</param>
    ''' <returns>Reporte</returns>
    ''' <remarks></remarks>
    Public Function getReporte(ByVal scdproyecto As String, ByVal scdreporte As String) As Reporte
        Dim oset As DataSet
        Dim obj As Reporte
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getReporte(scdproyecto, scdreporte)
            orows = oset.Tables("reportes").Rows
            If orows.Count = 1 Then
                obj = New Reporte
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdreporte = orows.Item(0).Item("cd_reporte")
                obj.cdstanalisis = orows.Item(0).Item("cd_stanalisis")
                obj.cdstconstruccion = orows.Item(0).Item("cd_stconstruccion")
                obj.cdanalista = orows.Item(0).Item("cd_analista")
                obj.cdprogramador = orows.Item(0).Item("cd_programador")
                obj.nbreporte = orows.Item(0).Item("nb_reporte")
                obj.nbimagefile = orows.Item(0).Item("nb_imagefile")
                obj.cdcodigo = orows.Item(0).Item("cd_codigo")
                obj.txobjetivo = orows.Item(0).Item("tx_objetivo")
                obj.txcomment = orows.Item(0).Item("tx_comment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getReporte()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getReporte()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar todo el catálogo de estatus del analisis
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getStAnalisis() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getStAnalisis()
            orows = oset.Tables("estatus").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Estatus = New Estatus
                obj.clave = orows.Item(i).Item("cd_stanalisis")
                obj.nombre = orows.Item(i).Item("nb_stanalisis")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getStAnalisis()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getStAnalisis()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el estatus del analisis
    ''' </summary>
    ''' <param name="scd"></param>
    ''' <returns>Estatus</returns>
    ''' <remarks></remarks>
    Public Function getStAnalisis(ByVal scd As String) As Estatus
        Dim oset As DataSet
        Dim obj As Estatus
        Dim orows As DataRowCollection
        obj = Nothing
        Try
            oset = odb.getStAnalisis(scd)
            orows = oset.Tables("estatus").Rows
            If orows.Count = 1 Then
                obj = New Estatus
                obj.clave = orows.Item(0).Item("cd_stanalisis")
                obj.nombre = orows.Item(0).Item("nb_stanalisis")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getStAnalisis(2)", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getStAnalisis(2)", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el estatus de construcción
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getStConstruccion() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getStConstruccion()
            orows = oset.Tables("estatus").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Estatus = New Estatus
                obj.clave = orows.Item(i).Item("cd_stconstruccion")
                obj.nombre = orows.Item(i).Item("nb_stconstruccion")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getStConstruccion()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getStConstruccion()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el estatus de la construcción
    ''' </summary>
    ''' <param name="scd"></param>
    ''' <returns>Estatus</returns>
    ''' <remarks></remarks>
    Public Function getStConstruccion(ByVal scd As String) As Estatus
        Dim oset As DataSet
        Dim obj As Estatus
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getStConstruccion(scd)
            orows = oset.Tables("estatus").Rows
            If orows.Count = 1 Then
                obj = New Estatus
                obj.clave = orows.Item(0).Item("cd_stconstruccion")
                obj.nombre = orows.Item(0).Item("nb_stconstruccion")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getStConstruccion(2)", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getStConstruccion(2)", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar los botones
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdpantalla">Clave de la pantalla</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getPantallaBotones(ByVal scdproyecto As String, ByVal scdpantalla As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getPantallaBotones(scdproyecto, scdpantalla)
            orows = oset.Tables("botones").Rows
            For i = 0 To orows.Count - 1
                Dim obj As PantallaBoton = New PantallaBoton
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdpantalla = orows.Item(i).Item("cd_pantalla")
                obj.cdboton = orows.Item(i).Item("cd_boton")
                obj.nbboton = orows.Item(i).Item("nb_boton")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallaBotones()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallaBotones()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consulta la información de un botón en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdpantalla">Clave de la pantalla</param>
    ''' <param name="scdboton">Clave del boton</param>
    ''' <returns>PantallaBoton</returns>
    ''' <remarks></remarks>
    Public Function getPantallaBoton(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdboton As String) As PantallaBoton
        Dim oset As DataSet
        Dim obj As PantallaBoton
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getPantallaBoton(scdproyecto, scdpantalla, scdboton)
            orows = oset.Tables("botones").Rows
            If orows.Count = 1 Then
                obj = New PantallaBoton
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdpantalla = orows.Item(0).Item("cd_pantalla")
                obj.cdboton = orows.Item(0).Item("cd_boton")
                obj.nbboton = orows.Item(0).Item("nb_boton")
                obj.txcomment = orows.Item(0).Item("tx_comment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallaBoton()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallaBoton()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimeinto para consultar los campos que son utilizados en una pantalla
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getPantallaCampos(ByVal scdproyecto As String, ByVal scdpantalla As String) As Collection
        Return Me.getPantallaCampos(scdproyecto, scdpantalla, "")
    End Function

    ''' <summary>
    ''' Procedimeinto para consultar los campos que son utilizados en una pantalla
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getPantallaCampoSinArreglo(ByVal scdproyecto As String, ByVal scdpantalla As String) As Collection
        Dim csinarreglo As Collection
        Dim ctmp As Collection

        csinarreglo = New Collection
        Try
            ctmp = Me.getPantallaCampos(scdproyecto, scdpantalla, "")
            For Each ocampo As PantallaCampo In ctmp
                If ocampo.cdarreglo.Equals("") Then csinarreglo.Add(ocampo)
            Next

        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallaCampos()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallaCampos()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        Return csinarreglo
    End Function

    ''' <summary>
    ''' Procedimeinto para consultar los campos que son utilizados en una pantalla
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <param name="stpiocampo">tipo de campo input ó output</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getPantallaCampos(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal stpiocampo As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getPantallaCampos(scdproyecto, scdpantalla, stpiocampo)
            orows = oset.Tables("campos").Rows
            For i = 0 To orows.Count - 1
                Dim obj As PantallaCampo = New PantallaCampo()
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdpantalla = orows.Item(i).Item("cd_pantalla")
                obj.cdcampo = orows.Item(i).Item("cd_campo")
                obj.nulongitud = orows.Item(i).Item("nu_longitud")
                obj.nudecimales = orows.Item(i).Item("nu_decimales")
                obj.cdtpcampo = orows.Item(i).Item("cd_tpcampo")
                obj.tpinoutput = orows.Item(i).Item("tp_inoutput")
                If Not IsDBNull(orows.Item(i).Item("cd_arreglo")) Then obj.cdarreglo = orows.Item(i).Item("cd_arreglo")
                obj.nbcampo = orows.Item(i).Item("nb_campo")
                If Not IsDBNull(orows.Item(i).Item("tx_comment")) Then obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallaCampos()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallaCampos()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimeinto para consultar los campos que son utilizados en una pantalla
    ''' </summary>
    ''' <param name="scdsincronia">Clave de la sincronia</param>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getPantallaCamposSinc(ByVal scdsincronia As String, ByVal scdproyecto As String, ByVal scdpantalla As String) As Collection
        Dim ccampos As Collection

        ccampos = Nothing
        Try
            ccampos = Me.getPantallaCampos(scdproyecto, scdpantalla)
            For Each ocampo As PantallaCampo In ccampos
                ocampo.sincronia = Me.getSincroniaCampo(scdsincronia, scdproyecto, scdpantalla, ocampo.cdcampo)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallaCamposSinc()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallaCamposSinc()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        Return ccampos
    End Function

    ''' <summary>
    ''' Procedimeinto para consultar los arreglos que son utilizados en una pantalla
    ''' </summary>
    ''' <param name="scdsincronia">Clave de la sincronia</param>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getPantallarreglosSinc(ByVal scdsincronia As String, ByVal scdproyecto As String, ByVal scdpantalla As String) As Collection
        Dim carreglos As Collection

        carreglos = Nothing
        Try
            carreglos = Me.getPantallarreglos(scdproyecto, scdpantalla)
            For Each oarreglo As Pantallarreglo In carreglos
                oarreglo.sincronia = Me.getSincroniArreglo(scdsincronia, scdproyecto, scdpantalla, oarreglo.cdarreglo)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallarreglosSinc()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallarreglosSinc()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        Return carreglos
    End Function

    ''' <summary>
    ''' Procedimiento para consultar los campos que son utilizados en un reporte
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdreporte">clave del reporte</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getReporteCampos(ByVal scdproyecto As String, ByVal scdreporte As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getReporteCampos(scdproyecto, scdreporte)
            orows = oset.Tables("campos").Rows
            For i = 0 To orows.Count - 1
                Dim obj As ReporteCampo = New ReporteCampo
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdreporte = orows.Item(i).Item("cd_reporte")
                obj.nbcampo = orows.Item(i).Item("nb_campo")
                obj.cdcampo = orows.Item(i).Item("cd_campo")
                If Not IsDBNull(orows.Item(i).Item("cd_arreglo")) Then obj.cdarreglo = orows.Item(i).Item("cd_arreglo")
                obj.cdtpcampo = orows.Item(i).Item("cd_tpcampo")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                obj.nudecimales = orows.Item(i).Item("nu_decimales")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getReporteCampos()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getReporteCampos()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un campo en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <param name="scdcampo">clave del campo</param>
    ''' <returns>Campo</returns>
    ''' <remarks></remarks>
    Public Function getPantallaCampo(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdcampo As String) As PantallaCampo
        Dim oset As DataSet
        Dim obj As PantallaCampo
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getPantallaCampo(scdproyecto, scdpantalla, scdcampo)
            orows = oset.Tables("campos").Rows
            If orows.Count = 1 Then
                obj = New PantallaCampo
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdpantalla = orows.Item(0).Item("cd_pantalla")
                obj.cdcampo = orows.Item(0).Item("cd_campo")
                obj.nulongitud = orows.Item(0).Item("nu_longitud")
                obj.nudecimales = orows.Item(0).Item("nu_decimales")
                obj.cdtpcampo = orows.Item(0).Item("cd_tpcampo")
                obj.tpinoutput = orows.Item(0).Item("tp_inoutput")
                If Not IsDBNull(orows.Item(0).Item("cd_arreglo")) Then obj.cdarreglo = orows.Item(0).Item("cd_arreglo")
                obj.nbcampo = orows.Item(0).Item("nb_campo")
                If Not IsDBNull(orows.Item(0).Item("tx_comment")) Then obj.txcomment = orows.Item(0).Item("tx_comment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallaCampo()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallaCampo()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un campo del reporte en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdreporte">clave del reporte</param>
    ''' <param name="scdcampo">clave del campo</param>
    ''' <returns>Campo</returns>
    ''' <remarks></remarks>
    Public Function getReporteCampo(ByVal scdproyecto As String, ByVal scdreporte As String, ByVal scdcampo As String) As ReporteCampo
        Dim oset As DataSet
        Dim obj As ReporteCampo
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getReporteCampo(scdproyecto, scdreporte, scdcampo)
            orows = oset.Tables("campos").Rows
            If orows.Count = 1 Then
                obj = New ReporteCampo
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdreporte = orows.Item(0).Item("cd_reporte")
                obj.nbcampo = orows.Item(0).Item("nb_campo")
                obj.cdcampo = orows.Item(0).Item("cd_campo")
                If Not IsDBNull(orows.Item(0).Item("cd_arreglo")) Then obj.cdarreglo = orows.Item(0).Item("cd_arreglo")
                obj.cdtpcampo = orows.Item(0).Item("cd_tpcampo")
                obj.txcomment = orows.Item(0).Item("tx_comment")
                obj.nudecimales = orows.Item(0).Item("nu_decimales")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getReporteCampo()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getReporteCampo()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catalogo de tipos de campos
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getTpCampos() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getTpCampos()
            orows = oset.Tables("tipos").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Estatus = New Estatus
                obj.clave = orows.Item(i).Item("cd_tpcampo")
                obj.nombre = orows.Item(i).Item("nb_tpcampo")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getTpCampos()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getTpCampos()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Función para consultar las fuentes de datos basandose en un criterio 
    ''' de consulta
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getFuenteDatos(ByRef ocrit As Criterio) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getFuenteDatos(ocrit)
            orows = oset.Tables("fuentedatos").Rows
            For i = 0 To orows.Count - 1
                Dim obj As FuenteDato = New FuenteDato
                obj.cdfuentedato = orows.Item(i).Item("cd_fuentedato")
                obj.stfuentedato = orows.Item(i).Item("st_fuentedato")
                obj.tpfuentedato = orows.Item(i).Item("tp_fuentedato")
                obj.cdcliente = orows.Item(i).Item("cd_cliente")
                obj.nbfuentedato = orows.Item(i).Item("nb_fuentedato")
                obj.cdconexion = orows.Item(i).Item("cd_conexion")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getFuenteDatos()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getFuenteDatos()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un registro tipo DataSource
    ''' </summary>
    ''' <param name="scdfuentedato">clave de la fuente de datos a investigar</param>
    ''' <returns>FuenteDato</returns>
    ''' <remarks></remarks>
    Public Function getFuenteDato(ByVal scdfuentedato As String) As FuenteDato
        Dim oset As DataSet
        Dim obj As FuenteDato = Nothing
        Dim orows As DataRowCollection

        Try
            oset = odb.getFuenteDato(scdfuentedato)
            orows = oset.Tables("fuentedatos").Rows
            If orows.Count = 1 Then
                obj = New FuenteDato
                obj.cdfuentedato = scdfuentedato
                obj.stfuentedato = orows.Item(0).Item("st_fuentedato")
                obj.tpfuentedato = orows.Item(0).Item("tp_fuentedato")
                obj.cdcliente = orows.Item(0).Item("cd_cliente")
                obj.nbfuentedato = orows.Item(0).Item("nb_fuentedato")
                obj.cdconexion = orows.Item(0).Item("cd_conexion")
                obj.txcomment = orows.Item(0).Item("tx_comment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getFuenteDato(sfte)", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getFuenteDato(sfte)", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar registros desde la tabla gen023_entidadato
    ''' </summary>
    ''' <param name="scdfuentedato">clave de la fuente de datos</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getEntidaDatos(ByVal scdfuentedato As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getEntidaDatos(scdfuentedato)
            orows = oset.Tables("entidades").Rows
            For i = 0 To orows.Count - 1
                Dim obj As EntidaDato = New EntidaDato
                obj.cdfuentedato = scdfuentedato
                obj.nbentidadato = orows.Item(i).Item("nb_entidadato")
                obj.tpentidadato = orows.Item(i).Item("cd_tpentidadato")
                obj.nbclase = orows.Item(i).Item("nb_clase")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                obj.txclasecomment = orows.Item(i).Item("tx_clasecomment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getEntidaDatos()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getEntidaDatos()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un registro desde la tabla gen023_entidadato
    ''' </summary>
    ''' <param name="scdfuentedato">clave del datasource</param>
    ''' <param name="snbentidadato">clave de la entidad de base de datos</param>
    ''' <returns>EntidaDato</returns>
    ''' <remarks></remarks>
    Public Function getEntidaDato(ByVal scdfuentedato As String, ByVal snbentidadato As String) As EntidaDato
        Dim oset As DataSet
        Dim obj As EntidaDato = Nothing
        Dim orows As DataRowCollection

        Try
            oset = odb.getEntidaDato(scdfuentedato, snbentidadato)
            orows = oset.Tables("entidades").Rows
            If orows.Count = 1 Then
                obj = New EntidaDato
                obj.cdfuentedato = scdfuentedato
                obj.nbentidadato = snbentidadato
                obj.tpentidadato = orows.Item(0).Item("cd_tpentidadato")
                obj.nbclase = orows.Item(0).Item("nb_clase")
                obj.txcomment = orows.Item(0).Item("tx_comment")
                obj.txclasecomment = orows.Item(0).Item("tx_clasecomment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getEntidaDato(fte, ent)", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getEntidaDato(fte, ent)", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Function para consultar los campos de una entidad
    ''' </summary>
    ''' <param name="scdfuentedato">clave de la fuente de datos</param>
    ''' <param name="snbentidadato">nombre de la entidad</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getEntidaDatoCampos(ByVal scdfuentedato As String, ByVal snbentidadato As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection = New Collection
        Try
            oset = odb.getEntidaDatoCampos(scdfuentedato, snbentidadato)
            orows = oset.Tables("dbcampos").Rows
            For i = 0 To orows.Count - 1
                Dim obj As EntidaDatoCampo = New EntidaDatoCampo
                obj.cdfuentedato = scdfuentedato
                obj.nbentidadato = snbentidadato
                obj.nbcampo = orows.Item(i).Item("nb_campo")
                obj.cdorden = orows.Item(i).Item("cd_orden")
                obj.nulongitud = orows.Item(i).Item("nu_longitud")
                obj.nudecimales = orows.Item(i).Item("nu_decimales")
                obj.stpermitenulos = orows.Item(i).Item("st_permite_nulos")
                obj.stesllave = orows.Item(i).Item("st_esllave")
                obj.stesalterna = orows.Item(i).Item("st_esllave_alterna")
                obj.stesautoincremento = orows.Item(0).Item("st_esautoincremento")
                obj.stessecuencia = orows.Item(0).Item("st_essecuencia")
                obj.nbsecuencia = orows.Item(0).Item("nb_secuencia")
                obj.cdtpdatofisico = orows.Item(i).Item("cd_tpdatofisico")
                obj.nbvariable = orows.Item(i).Item("nb_variable")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getEntidaDatoCampos()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getEntidaDatoCampos()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Function para consultar un solo registro desde la tabla gen024_dbentidad_campo
    ''' </summary>
    ''' <param name="scdfuentedato">clave del datasource</param>
    ''' <param name="snbentidad">nombre de la entidad</param>
    ''' <param name="snbcampo">nombre del campo</param>
    ''' <returns>EntidaDatoCampo</returns>
    ''' <remarks></remarks>
    Public Function getEntidaDatoCampo(ByVal scdfuentedato As String, ByVal snbentidad As String, ByVal snbcampo As String) As EntidaDatoCampo
        Dim oset As DataSet
        Dim obj As EntidaDatoCampo = Nothing
        Dim orows As DataRowCollection

        Try
            oset = odb.getEntidaDatoCampo(scdfuentedato, snbentidad, snbcampo)
            orows = oset.Tables("dbcampos").Rows
            If orows.Count = 1 Then
                obj = New EntidaDatoCampo
                obj.cdfuentedato = scdfuentedato
                obj.nbentidadato = snbentidad
                obj.nbcampo = snbcampo
                obj.cdorden = orows.Item(0).Item("cd_orden")
                obj.nulongitud = orows.Item(0).Item("nu_longitud")
                obj.nudecimales = orows.Item(0).Item("nu_decimales")
                obj.stpermitenulos = orows.Item(0).Item("st_permite_nulos")
                obj.stesllave = orows.Item(0).Item("st_esllave")
                obj.stesalterna = orows.Item(0).Item("st_esllave_alterna")
                obj.stesautoincremento = orows.Item(0).Item("st_esautoincremento")
                obj.stessecuencia = orows.Item(0).Item("st_essecuencia")
                obj.nbsecuencia = orows.Item(0).Item("nb_secuencia")
                obj.cdtpdatofisico = orows.Item(0).Item("cd_tpdatofisico")
                obj.nbvariable = orows.Item(0).Item("nb_variable")
                obj.txcomment = orows.Item(0).Item("tx_comment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getEntidaDatoCampo()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getEntidaDatoCampo()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de tipos de entidad
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getTpEntidaDatos() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getTpEntidaDato("")
            orows = oset.Tables("tipos").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Tipo = New Tipo
                obj.clave = orows.Item(i).Item("cd_tpentidadato")
                obj.nombre = orows.Item(i).Item("nb_tpentidadato")
                obj.estatus = orows.Item(i).Item("st_tpentidadato")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getTpEntidaDatos()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getTpEntidaDatos()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar solo un tipo de entidad
    ''' </summary>
    ''' <param name="sclave">clave del tipo de entidad</param>
    ''' <returns>Tipo</returns>
    ''' <remarks></remarks>
    Public Function getTpEntidaDato(ByVal sclave As String) As Tipo
        Dim oset As DataSet
        Dim obj As Tipo = Nothing
        Dim orows As DataRowCollection

        Try
            oset = odb.getTpEntidaDato(sclave)
            orows = oset.Tables("tipos").Rows
            If orows.Count = 1 Then
                obj = New Tipo
                obj.clave = sclave
                obj.clave = orows.Item(0).Item("cd_tpentidadato")
                obj.nombre = orows.Item(0).Item("nb_tpentidadato")
                obj.estatus = orows.Item(0).Item("st_tpentidadato")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getTpEntidaDato()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getTpEntidaDato()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar las fuentes de datos de un proyecto en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getProyectoFuenteDatos(ByVal scdproyecto As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getProyectoFuenteDatos(scdproyecto)
            orows = oset.Tables("fuentes").Rows
            For i = 0 To orows.Count - 1
                Dim obj As ProyectoFuenteDato = New ProyectoFuenteDato
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdfuentedato = orows.Item(i).Item("cd_fuentedato")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getProyectoFuenteDatos()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getProyectoFuenteDatos()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar una de las fuentes de datos de un proyecto en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdfuentedato">clave de la fuente de datos</param>
    ''' <returns>ProyectoFuenteDato</returns>
    ''' <remarks></remarks>
    Public Function getProyectoFuenteDato(ByVal scdproyecto As String, ByVal scdfuentedato As String) As ProyectoFuenteDato
        Dim oset As DataSet
        Dim obj As ProyectoFuenteDato = Nothing
        Dim orows As DataRowCollection

        Try
            oset = odb.getProyectoFuenteDato(scdproyecto, scdfuentedato)
            orows = oset.Tables("fuentes").Rows
            If orows.Count = 1 Then
                obj = New ProyectoFuenteDato
                obj.cdproyecto = scdproyecto
                obj.cdfuentedato = scdfuentedato
                obj.txcomment = orows.Item(0).Item("tx_comment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getProyectoFuenteDato()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getProyectoFuenteDato()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar las entidades de datos de la relación proyecto - fuente de datos
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdfuentedato">clave de la fuente de datos</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getProyectoFuenteDatoEntidades(ByVal scdproyecto As String, ByVal scdfuentedato As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getProyectoFuenteDatoEntidades(scdproyecto, scdfuentedato)
            orows = oset.Tables("entidades").Rows
            For i = 0 To orows.Count - 1
                Dim obj As ProyectoFuenteDatoEntidad = New ProyectoFuenteDatoEntidad
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdfuentedato = orows.Item(i).Item("cd_fuentedato")
                obj.nbentidadato = orows.Item(i).Item("nb_entidadato")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getProyectoFuenteDatoEntidades()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getProyectoFuenteDatoEntidades()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar aquellos proyectos que usan a una entidad en particular
    ''' </summary>
    ''' <param name="scdfuentedato">Clave de la fuente de datos</param>
    ''' <param name="scdentidad">Nombre de la enteidad</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getProyectosUsanEntidad(ByVal scdfuentedato As String, ByVal scdentidad As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getProyectosUsanEntidad(scdfuentedato, scdentidad)
            orows = oset.Tables("entidades").Rows
            For i = 0 To orows.Count - 1
                Dim obj As ProyectoFuenteDatoEntidad = New ProyectoFuenteDatoEntidad
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdfuentedato = orows.Item(i).Item("cd_fuentedato")
                obj.nbentidadato = orows.Item(i).Item("nb_entidadato")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getProyectosUsanEntidad()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getProyectosUsanEntidad()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar las entidades de datos de la relación proyecto - fuente de datos
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getProyectoFuenteDatoEntidades(ByVal scdproyecto As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getProyectoFuenteDatoEntidades(scdproyecto)
            orows = oset.Tables("entidades").Rows
            For i = 0 To orows.Count - 1
                Dim obj As ProyectoFuenteDatoEntidad = New ProyectoFuenteDatoEntidad
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdfuentedato = orows.Item(i).Item("cd_fuentedato")
                obj.nbentidadato = orows.Item(i).Item("nb_entidadato")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getProyectoFuenteDatoEntidades()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getProyectoFuenteDatoEntidades()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un registro desde la tabla [gen034_PANTALLA_EVENTO] 
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdpantalla">Clave de la pantalla</param>
    ''' <param name="scdevento">Clave del evento</param>
    ''' <returns>PantallaEvento</returns>
    ''' <remarks></remarks>
    Public Function getPantallaEvento(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdevento As String) As PantallaEvento
        Dim oset As DataSet
        Dim obj As PantallaEvento = Nothing
        Dim orows As DataRowCollection
        Dim otipo As TpEvento

        'PASO 1: consulta los datos de un evento en particular
        Try
            oset = odb.getPantallaEvento(scdproyecto, scdpantalla, scdevento)
            orows = oset.Tables("eventos").Rows
            If orows.Count = 1 Then
                obj = New PantallaEvento()
                obj.cdproyecto = scdproyecto
                obj.cdpantalla = scdpantalla
                obj.cdevento = scdevento
                obj.cdtpevento = orows.Item(0).Item("cd_tpevento")
                obj.nbevento = orows.Item(0).Item("nb_evento")
                If Not IsDBNull(orows.Item(0).Item("tx_comment")) Then obj.txcomment = orows.Item(0).Item("tx_comment")
            End If
            oset = Nothing

            'PASO 2: consulta su tipo 
            otipo = Me.getTpEvento(obj.cdtpevento)
            If Not otipo Is Nothing Then obj.cdmetacodigo = otipo.cdmetacod
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallaEvento()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallaEvento()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try

        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un registro desde la tabla [gen034_PANTALLA_EVENTO] 
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdpantalla">Clave de la pantalla</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getPantallaEventos(ByVal scdproyecto As String, ByVal scdpantalla As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        Try
            'PASO 1: Consulta la coleccion de eventos relacionados con una pantalla
            oc = New Collection

            oset = odb.getPantallaEventos(scdproyecto, scdpantalla)
            orows = oset.Tables("eventos").Rows
            For i = 0 To orows.Count - 1
                Dim obj As PantallaEvento = New PantallaEvento
                obj.cdproyecto = scdproyecto
                obj.cdpantalla = scdpantalla
                obj.cdevento = orows.Item(i).Item("cd_evento")
                obj.cdtpevento = orows.Item(i).Item("cd_tpevento")
                obj.nbevento = orows.Item(i).Item("nb_evento")
                If Not IsDBNull(orows.Item(i).Item("tx_comment")) Then obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
            oset = Nothing

            'PASO 2: Consulta la información de cada tipo de evento
            For Each obj As PantallaEvento In oc
                Dim otipo As TpEvento
                otipo = Me.getTpEvento(obj.cdtpevento)
                If Not otipo Is Nothing Then obj.cdmetacodigo = otipo.cdmetacod
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallaEventos()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallaEventos()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un registro desde la tabla [gen034_PANTALLA_EVENTO] 
    ''' </summary>
    ''' <param name="scdsincronia">Clave de la sincronia</param>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdpantalla">Clave de la pantalla</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getPantallaEventosSinc(ByVal scdsincronia As String, ByVal scdproyecto As String, ByVal scdpantalla As String) As Collection
        Dim ceventos As Collection

        ceventos = Nothing
        Try
            'PASO 1: Lee los eventos implicados en pantlla
            ceventos = Me.getPantallaEventos(scdproyecto, scdpantalla)

            'PASO 2: Se le asigna a cada evento su respectiva sincronia
            For Each oevento As PantallaEvento In ceventos
                oevento.sincronia = Me.getSincroniaEvento(scdsincronia, scdproyecto, scdpantalla, oevento.cdevento)
                If Not oevento.sincronia Is Nothing Then
                    Dim onodo As Nodo

                    'PASO 2.1: Se lee la sincronia del evento
                    onodo = New Nodo(oevento.sincronia.xmlevento)

                    'PASO 2.2: Si se trata de una navegación, busgo el nombre del target real
                    If onodo.getValue("evehtml.navegara").Equals("Si") Then
                        Dim otargetsinc As SincroniaPantalla
                        Dim snbcomponent As String

                        otargetsinc = Me.getSincroniaPantalla(scdsincronia, scdproyecto, onodo.getValue("evehtml.navegar.navtarget"))
                        If Not otargetsinc Is Nothing Then
                            snbcomponent = otargetsinc.nbcomponente
                        Else
                            snbcomponent = "_TARGET_SIN_SINCRONIA_"
                        End If
                        onodo.addNodoEn("navegar", New Nodo("<navnbtarget>" & snbcomponent & "</navnbtarget>"))
                        oevento.sincronia.xmlevento = onodo.GetXML()
                    End If
                End If
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallaEventosSinc()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallaEventosSinc()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        Return ceventos
    End Function


    ''' <summary>
    ''' Procedimiento para consultar el catálogo de tipos de evento
    ''' </summary>
    ''' <returns>TpEvento</returns>
    ''' <remarks></remarks>
    Public Function getTpEvento(ByVal sclave As String) As TpEvento
        Dim oset As DataSet
        Dim obj As TpEvento = Nothing
        Dim orows As DataRowCollection

        Try
            oset = odb.getTpEvento(sclave)
            orows = oset.Tables("tipos").Rows
            If orows.Count = 1 Then
                obj = New TpEvento
                obj.clave = sclave
                obj.nombre = orows.Item(0).Item("nb_tpevento")
                obj.cdmetacod = orows.Item(0).Item("cd_metacodigo")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getTpEvento()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getTpEvento()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar el catálogo de tipos de evento
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getTpEventos() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getTpEventos()
            orows = oset.Tables("tipos").Rows
            For i = 0 To orows.Count - 1
                Dim obj As TpEvento = New TpEvento
                obj.clave = orows.Item(i).Item("cd_tpevento")
                obj.nombre = orows.Item(i).Item("nb_tpevento")
                obj.cdmetacod = orows.Item(i).Item("cd_metacodigo")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getTpEventos()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getTpEventos()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar todas las navegaciones de un proyecto
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getNavegaciones(ByVal scdproyecto As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getNavegaciones(scdproyecto)
            orows = oset.Tables("nav").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Navegacion = New Navegacion
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdesde = orows.Item(i).Item("cd_desde")
                obj.cdhasta = orows.Item(i).Item("cd_hasta")
                obj.tpnavegacion = orows.Item(i).Item("tp_navegacion")
                obj.stopenwindow = IIf(orows.Item(i).Item("st_openwindow").Equals("AC"), True, False)
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getNavegaciones()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getNavegaciones()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar las navegaciones de una pantalla en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdesde">Clave de la pantalla</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getNavegaciones(ByVal scdproyecto As String, ByVal scdesde As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getNavegaciones(scdproyecto, scdesde)
            orows = oset.Tables("nav").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Navegacion = New Navegacion
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdesde = orows.Item(i).Item("cd_desde")
                obj.cdhasta = orows.Item(i).Item("cd_hasta")
                obj.tpnavegacion = orows.Item(i).Item("tp_navegacion")
                obj.stopenwindow = IIf(orows.Item(i).Item("st_openwindow").Equals("AC"), True, False)
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getNavegaciones(2)", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getNavegaciones(2)", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar las navegaciones de una pantalla en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdhasta">Clave de la pantalla final</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getNavegaDesdeDestino(ByVal scdproyecto As String, ByVal scdhasta As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getNavegaDesdeDestino(scdproyecto, scdhasta)
            orows = oset.Tables("nav").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Navegacion = New Navegacion
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdesde = orows.Item(i).Item("cd_desde")
                obj.cdhasta = orows.Item(i).Item("cd_hasta")
                obj.tpnavegacion = orows.Item(i).Item("tp_navegacion")
                obj.stopenwindow = IIf(orows.Item(i).Item("st_openwindow").Equals("AC"), True, False)
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getNavegaDesdeDestino()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getNavegaDesdeDestino()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar una navegación en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdesde">Clave de la pantalla desde donde se hace el llamado</param>
    ''' <param name="scdhasta">Clave de la pantalla hasta donde se navega</param>
    ''' <returns>Navegacion</returns>
    ''' <remarks></remarks>
    Public Function getNavegacion(ByVal scdproyecto As String, ByVal scdesde As String, ByVal scdhasta As String) As Navegacion
        Dim oset As DataSet
        Dim orows As DataRowCollection
        Dim obj As Navegacion

        obj = Nothing
        Try
            oset = odb.getNavegacion(scdproyecto, scdesde, scdhasta)
            orows = oset.Tables("nav").Rows
            If orows.Count = 1 Then
                obj = New Navegacion
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdesde = orows.Item(0).Item("cd_desde")
                obj.cdhasta = orows.Item(0).Item("cd_hasta")
                obj.tpnavegacion = orows.Item(0).Item("tp_navegacion")
                obj.stopenwindow = IIf(orows.Item(0).Item("st_openwindow").Equals("AC"), True, False)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getNavegacion()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getNavegacion()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar los parámetros de una navegación en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdesde">Clave de la pantalla desde donde se viaja</param>
    ''' <param name="scdhasta">Clave de la pantalla hasta donde se viaja</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getNavegacionParams(ByVal scdproyecto As String, ByVal scdesde As String, ByVal scdhasta As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getNavegacionParams(scdproyecto, scdesde, scdhasta)
            orows = oset.Tables("navpar").Rows
            For i = 0 To orows.Count - 1
                Dim obj As NavegacionParam = New NavegacionParam
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdesde = orows.Item(i).Item("cd_desde")
                obj.cdhasta = orows.Item(i).Item("cd_hasta")
                obj.nbparam = orows.Item(i).Item("nb_param")
                obj.stconstante = IIf(orows.Item(i).Item("st_constante").Equals("AC"), True, False)
                obj.txconstante = orows.Item(i).Item("tx_constante")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getNavegacionParams()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getNavegacionParams()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para consultar los parámetros de una navegación en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdesde">Clave de la pantalla desde donde se viaja</param>
    ''' <param name="scdhasta">Clave de la pantalla hasta donde se viaja</param>
    ''' <param name="scdparam">Clave del parametro</param>
    ''' <returns>NavegacionParam</returns>
    ''' <remarks></remarks>
    Public Function getNavegacionParam(ByVal scdproyecto As String, ByVal scdesde As String, ByVal scdhasta As String, ByVal scdparam As String) As NavegacionParam
        Dim oset As DataSet
        Dim orows As DataRowCollection
        Dim obj As NavegacionParam

        obj = Nothing
        Try
            oset = odb.getNavegacionParam(scdproyecto, scdesde, scdhasta, scdparam)
            orows = oset.Tables("navpar").Rows
            If orows.Count = 1 Then
                obj = New NavegacionParam
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdesde = orows.Item(0).Item("cd_desde")
                obj.cdhasta = orows.Item(0).Item("cd_hasta")
                obj.nbparam = orows.Item(0).Item("nb_param")
                obj.stconstante = IIf(orows.Item(0).Item("st_constante").Equals("AC"), True, False)
                obj.txconstante = orows.Item(0).Item("tx_constante")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getNavegacionParam()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getNavegacionParam()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen027_sincronia
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de la sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <returns>Sincronia</returns>
    ''' <remarks></remarks>
    Public Function getSincronia(ByVal pscdsincronia As String, ByVal pscdproyecto As String) As Sincronia
        Dim oset As DataSet
        Dim obj As Sincronia
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getSincronia(pscdsincronia, pscdproyecto)
            orows = oset.Tables("sincronia").Rows
            If orows.Count = 1 Then
                obj = New Sincronia
                obj.cdsincronia = orows.Item(0).Item("cd_sincronia")
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.nbsincronia = orows.Item(0).Item("nb_sincronia")
                obj.estatus = orows.Item(0).Item("st_sincronia")
                obj.cdestilogenera = orows.Item(0).Item("cd_estilo_genera")
                obj.xmsincronia = orows.Item(0).Item("xm_sincronia")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getSincronia()", "Ocurrio un error al consultar la sincronia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getSincronia(cd)", "Ocurrio un error al consultar la sincronia [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen027_sincronia
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getSincronias(ByVal pscdproyecto As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getSincronias(pscdproyecto)
            orows = oset.Tables("sincronia").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Sincronia = New Sincronia
                obj.cdsincronia = orows.Item(i).Item("cd_sincronia")
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.nbsincronia = orows.Item(i).Item("nb_sincronia")
                obj.estatus = orows.Item(i).Item("st_sincronia")
                obj.cdestilogenera = orows.Item(i).Item("cd_estilo_genera")
                obj.xmsincronia = orows.Item(i).Item("xm_sincronia")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getSincronias()", "Ocurrio un error al consultar")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getSincronias()", "Ocurrio un error al consultar [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para la consulta todos los registros de la tabla gen027_sincronia
    ''' </summary>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getallSincronias() As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getallSincronias()
            orows = oset.Tables("sincronia").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Sincronia = New Sincronia
                obj.cdsincronia = orows.Item(i).Item("cd_sincronia")
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.nbsincronia = orows.Item(i).Item("nb_sincronia")
                obj.estatus = orows.Item(i).Item("st_sincronia")
                obj.cdestilogenera = orows.Item(i).Item("cd_estilo_genera")
                obj.xmsincronia = orows.Item(i).Item("xm_sincronia")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getallSincronias()", "Ocurrio un error al consultar")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getallSincronias()", "Ocurrio un error al consultar [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen038_sincronia_pantalla
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <returns>SincroniaPantalla</returns>
    ''' <remarks></remarks>
    Public Function getSincroniaPantalla(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String) As SincroniaPantalla
        Dim oset As DataSet
        Dim obj As SincroniaPantalla
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getSincroniaPantalla(pscdsincronia, pscdproyecto, pscdpantalla)
            orows = oset.Tables("sincronia").Rows
            If orows.Count = 1 Then
                obj = New SincroniaPantalla()
                obj.cdsincronia = orows.Item(0).Item("cd_sincronia")
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdpantalla = orows.Item(0).Item("cd_pantalla")
                obj.nbhtmlfile = orows.Item(0).Item("nb_htmlfile")
                obj.nbhtmlforma = orows.Item(0).Item("nb_htmlforma")
                obj.nbcomponente = orows.Item(0).Item("nb_componente")
                obj.nbextension = orows.Item(0).Item("nb_extension")
                obj.xmlpantalla = orows.Item(0).Item("xm_pantalla")
                obj.estatus = orows.Item(0).Item("st_pantalla")
                obj.cdestilofuncion = orows.Item(0).Item("cd_estilo_funcion")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getSincroniaPantalla()", "Ocurrio un error al consultar")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getSincroniaPantalla()", "Ocurrio un error al consultar [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen039_sincronia_evento
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <param name="pscdevento">Clave del evento</param>
    ''' <returns>SincroniaEvento</returns>
    ''' <remarks></remarks>
    Public Function getSincroniaEvento(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String, ByVal pscdevento As String) As SincroniaEvento
        Dim oset As DataSet
        Dim obj As SincroniaEvento
        Dim orows As DataRowCollection

        obj = Nothing
        Try
            oset = odb.getSincroniaEvento(pscdsincronia, pscdproyecto, pscdpantalla, pscdevento)
            orows = oset.Tables("sincronia").Rows
            If orows.Count = 1 Then
                obj = New SincroniaEvento
                obj.cdsincronia = orows.Item(0).Item("cd_sincronia")
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdpantalla = orows.Item(0).Item("cd_pantalla")
                obj.cdevento = orows.Item(0).Item("cd_evento")
                If Not IsDBNull(orows.Item(0).Item("xm_evento")) Then obj.xmlevento = orows.Item(0).Item("xm_evento")
                If Not IsDBNull(orows.Item(0).Item("st_evento")) Then obj.estatus = orows.Item(0).Item("st_evento")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getSincroniaEvento()", "Ocurrio un error al consultar")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getSincroniaEvento()", "Ocurrio un error al consultar [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para seleccionar un registro de la tabla gen040_sincronia_campo
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de la sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <param name="pscdcampo">Clave del campo</param>
    ''' <returns>SincroniaCampo</returns>
    ''' <remarks></remarks>
    Public Function getSincroniaCampo(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String, ByVal pscdcampo As String) As SincroniaCampo
        Dim oset As DataSet
        Dim obj As SincroniaCampo
        Dim orows As DataRowCollection
        obj = Nothing
        Try
            oset = odb.getSincroniaCampo(pscdsincronia, pscdproyecto, pscdpantalla, pscdcampo)
            orows = oset.Tables("sincronia").Rows
            If orows.Count = 1 Then
                obj = New SincroniaCampo
                obj.cdsincronia = orows.Item(0).Item("cd_sincronia")
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdpantalla = orows.Item(0).Item("cd_pantalla")
                obj.cdcampo = orows.Item(0).Item("cd_campo")
                obj.xmlcampo = orows.Item(0).Item("xm_campo")
                obj.nbidhtml = orows.Item(0).Item("nb_idhtml")
                obj.estatus = orows.Item(0).Item("st_campo")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getSincroniaCampo()", "Ocurrio un error al consultar")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getSincroniaCampo()", "Ocurrio un error al consultar [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un objeto SincroniArreglo
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de la sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <param name="pscdarreglo">Clave del arreglo</param>
    ''' <returns>Objeto tipo SincroniArreglo</returns>
    ''' <remarks></remarks>
    Public Function getSincroniArreglo(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String, ByVal pscdarreglo As String) As SincroniArreglo
        Dim oset As DataSet
        Dim obj As SincroniArreglo
        Dim orows As DataRowCollection
        obj = Nothing
        Try
            oset = odb.getSincroniArreglo(pscdsincronia, pscdproyecto, pscdpantalla, pscdarreglo)
            orows = oset.Tables("sincronia").Rows
            If orows.Count = 1 Then
                obj = New SincroniArreglo
                obj.cdsincronia = orows.Item(0).Item("cd_sincronia")
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto").ToString
                obj.cdpantalla = orows.Item(0).Item("cd_pantalla").ToString
                obj.cdarreglo = orows.Item(0).Item("cd_arreglo").ToString
                obj.starreglo = orows.Item(0).Item("st_arreglo").ToString
                obj.nbidhtml = orows.Item(0).Item("nb_idhtml").ToString
                obj.tpelement = orows.Item(0).Item("tp_element").ToString
                obj.nbelement = orows.Item(0).Item("nb_element").ToString
                obj.nbobject = orows.Item(0).Item("nb_object").ToString
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getSincroniArreglo()", "Ocurrio un error al consultar un objeto SincroniArreglo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getSincroniArreglo()", "Ocurrio un error al consultar un objeto SincroniArreglo [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un campo en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <param name="snbidhtml">Id del html</param>
    ''' <returns>PantallaCampo</returns>
    ''' <remarks></remarks>
    Public Function getPantallaCampobyId(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdsincronia As String, ByVal snbidhtml As String) As PantallaCampo
        Dim oset As DataSet
        Dim obj As PantallaCampo
        Dim orows As DataRowCollection

        If scdsincronia.Equals("") Then Return Nothing
        If snbidhtml.Equals("") Then Return Nothing

        obj = Nothing
        Try
            oset = odb.getPantallaCampobyId(scdproyecto, scdpantalla, scdsincronia, snbidhtml)
            orows = oset.Tables("campos").Rows
            If orows.Count > 0 Then
                obj = New PantallaCampo
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdpantalla = orows.Item(0).Item("cd_pantalla")
                obj.cdcampo = orows.Item(0).Item("cd_campo")
                obj.nulongitud = orows.Item(0).Item("nu_longitud")
                obj.nudecimales = orows.Item(0).Item("nu_decimales")
                obj.cdtpcampo = orows.Item(0).Item("cd_tpcampo")
                obj.tpinoutput = orows.Item(0).Item("tp_inoutput")
                obj.nbcampo = orows.Item(0).Item("nb_campo")
                If Not IsDBNull(orows.Item(0).Item("tx_comment")) Then obj.txcomment = orows.Item(0).Item("tx_comment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallaCampobyId()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallaCampobyId()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar unos campos en particular por medio del arreglo
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <param name="scdarreglo">clave del arreglo</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getPantallaCamposbyArreglo(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdarreglo As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection

        oc = New Collection
        Try
            oset = odb.getPantallaCamposbyArreglo(scdproyecto, scdpantalla, scdarreglo)
            orows = oset.Tables("campos").Rows
            For i = 0 To orows.Count - 1
                Dim obj As PantallaCampo = New PantallaCampo()
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdpantalla = orows.Item(i).Item("cd_pantalla")
                obj.cdcampo = orows.Item(i).Item("cd_campo")
                obj.nulongitud = orows.Item(i).Item("nu_longitud")
                obj.nudecimales = orows.Item(i).Item("nu_decimales")
                obj.cdtpcampo = orows.Item(i).Item("cd_tpcampo")
                obj.tpinoutput = orows.Item(i).Item("tp_inoutput")
                If Not IsDBNull(orows.Item(i).Item("cd_arreglo")) Then obj.cdarreglo = orows.Item(i).Item("cd_arreglo")
                obj.nbcampo = orows.Item(i).Item("nb_campo")
                If Not IsDBNull(orows.Item(i).Item("tx_comment")) Then obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallaCamposbyArreglo()", "Ocurrio un error al consultar registros")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallaCamposbyArreglo()", "Ocurrio un error al consultar registros [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function


    ''' <summary>
    ''' Procedimiento para consultar un objeto Pantallarreglo
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <param name="pscdarreglo">Clave del arreglo</param>
    ''' <returns>Objeto tipo Pantallarreglo</returns>
    ''' <remarks></remarks>
    Public Function getPantallarreglo(ByVal pscdproyecto As String, ByVal pscdpantalla As String, ByVal pscdarreglo As String) As Pantallarreglo
        Dim oset As DataSet
        Dim orows As DataRowCollection
        Dim obj As Pantallarreglo = Nothing

        Try
            oset = odb.getPantallarreglo(pscdproyecto, pscdpantalla, pscdarreglo)
            orows = oset.Tables("arreglos").Rows
            If orows.Count > 0 Then
                obj = New Pantallarreglo
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdpantalla = orows.Item(0).Item("cd_pantalla")
                obj.cdarreglo = orows.Item(0).Item("cd_arreglo")
                obj.tpinoutput = orows.Item(0).Item("tp_inoutput")
                obj.nurensxpagina = orows.Item(0).Item("nu_rensxpagina")
                obj.nbarreglo = orows.Item(0).Item("nb_arreglo")
                obj.stpaginacion = orows.Item(0).Item("st_paginacion")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallarreglo()", "Ocurrio un error al consultar un objeto Pantallarreglo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallarreglo()", "Ocurrio un error al consultar un objeto Pantallarreglo [" & ex1.ToString & "]")
        End Try
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar algunos objetos tipo Pantallarreglo
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getPantallarreglos(ByVal pscdproyecto As String, ByVal pscdpantalla As String) As Collection
        Dim oset As DataSet
        Dim orows As DataRowCollection
        Dim ocol As Collection
        Dim i As Integer

        ocol = New Collection()
        Try
            oset = odb.getPantallarreglos(pscdproyecto, pscdpantalla)
            orows = oset.Tables("arreglos").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Pantallarreglo = New Pantallarreglo
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdpantalla = orows.Item(i).Item("cd_pantalla")
                obj.cdarreglo = orows.Item(i).Item("cd_arreglo")
                obj.tpinoutput = orows.Item(i).Item("tp_inoutput")
                obj.nurensxpagina = orows.Item(i).Item("nu_rensxpagina")
                obj.nbarreglo = orows.Item(i).Item("nb_arreglo")
                obj.stpaginacion = orows.Item(i).Item("st_paginacion")
                ocol.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getPantallarreglos()", "Ocurrio un error al consultar los objetos tipo Pantallarreglo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getPantallarreglos()", "Ocurrio un error al consultar los objetos tipo Pantallarreglo [" & ex1.ToString & "]")
        End Try
        Return ocol
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un objeto ReporteArreglo
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdreporte">Clave del reporte</param>
    ''' <param name="pscdarreglo">Clave del arreglo</param>
    ''' <returns>Objeto tipo ReporteArreglo</returns>
    ''' <remarks></remarks>
    Public Function getReporteArreglo(ByVal pscdproyecto As String, ByVal pscdreporte As String, ByVal pscdarreglo As String) As ReporteArreglo
        Dim oset As DataSet
        Dim orows As DataRowCollection
        Dim obj As ReporteArreglo = Nothing
        Try
            oset = odb.getReporteArreglo(pscdproyecto, pscdreporte, pscdarreglo)
            orows = oset.Tables("arreglos").Rows
            If orows.Count > 0 Then
                obj = New ReporteArreglo
                obj.cdproyecto = orows.Item(0).Item("cd_proyecto")
                obj.cdreporte = orows.Item(0).Item("cd_reporte")
                obj.nbarreglo = orows.Item(0).Item("nb_arreglo")
                obj.cdarreglo = orows.Item(0).Item("cd_arreglo")
                obj.nurensxpagina = orows.Item(0).Item("nu_rensxpagina")
                obj.stpaginacion = orows.Item(0).Item("st_paginacion")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getReporteArreglo()", "Ocurrio un error al consultar un objeto ReporteArreglo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getReporteArreglo()", "Ocurrio un error al consultar un objeto ReporteArreglo [" & ex1.ToString & "]")
        End Try
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar algunos objetos tipo ReporteArreglo
    ''' </summary>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdreporte">Clave del reporte</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getReporteArreglos(ByVal pscdproyecto As String, ByVal pscdreporte As String) As Collection
        Dim oset As DataSet
        Dim orows As DataRowCollection
        Dim ocol As Collection
        Dim i As Integer

        ocol = New Collection()
        Try
            oset = odb.getReporteArreglos(pscdproyecto, pscdreporte)
            orows = oset.Tables("arreglos").Rows
            For i = 0 To orows.Count - 1
                Dim obj As ReporteArreglo = New ReporteArreglo
                obj.cdproyecto = orows.Item(i).Item("cd_proyecto")
                obj.cdreporte = orows.Item(i).Item("cd_reporte")
                obj.nbarreglo = orows.Item(i).Item("nb_arreglo")
                obj.cdarreglo = orows.Item(i).Item("cd_arreglo")
                obj.nurensxpagina = orows.Item(i).Item("nu_rensxpagina")
                obj.stpaginacion = orows.Item(i).Item("st_paginacion")
                ocol.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getReporteArreglos()", "Ocurrio un error al consultar los objetos tipo ReporteArreglo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getReporteArreglos()", "Ocurrio un error al consultar los objetos tipo ReporteArreglo [" & ex1.ToString & "]")
        End Try
        Return ocol
    End Function

    ''' <summary>
    ''' Procedimiento para consultar 
    ''' </summary>
    ''' <param name="scdfuente"></param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function getallTipoAConvertir(ByVal scdfuente As String) As Collection
        Dim ocol As Collection
        Dim centidades As Collection
        Dim stipos As String = ""

        ocol = New Collection()
        Try
            'PASO 1: Consulta las entidades de datos
            centidades = Me.getEntidaDatos(scdfuente)

            'PASO 2: Recorre las entidades para buscar los tipos de datos
            For Each oent As EntidaDato In centidades
                Dim ccampos As Collection
                ccampos = Me.getEntidaDatoCampos(scdfuente, oent.nbentidadato)
                For Each ocampo As EntidaDatoCampo In ccampos
                    If stipos.IndexOf(ocampo.cdtpdatofisico & ",") < 0 Then
                        ocol.Add(ocampo.cdtpdatofisico)
                        stipos = stipos & ocampo.cdtpdatofisico & ","
                    End If
                Next
            Next

        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getallTipoAConvertir()", "Ocurrio un error al consultar")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getallTipoAConvertir()", "Ocurrio un error al consultar [" & ex1.ToString & "]")
        End Try
        Return ocol
    End Function

    ''' <summary>
    ''' Procedimiento para consultar un objeto Referencia
    ''' </summary>
    ''' <param name="pscdfuentedato">Clave de la fuente de datos</param>
    ''' <param name="psnbentidadato">Nombre de la entidad de datos</param>
    ''' <param name="pscdreferencia">Clave de la referencia</param>
    ''' <returns>Objeto tipo Referencia</returns>
    ''' <remarks></remarks>
    Public Function getReferencia(ByVal pscdfuentedato As String, ByVal psnbentidadato As String, ByVal pscdreferencia As String) As Referencia
        Dim oset As DataSet
        Dim obj As Referencia = Nothing
        Dim orows As DataRowCollection

        Try
            oset = odb.getReferencia(pscdfuentedato, psnbentidadato, pscdreferencia)
            orows = oset.Tables("referencia").Rows
            If orows.Count = 1 Then
                obj = New Referencia()
                obj.cdfuentedato = orows.Item(0).Item("cd_fuentedato")
                obj.nbentidadato = orows.Item(0).Item("nb_entidadato")
                obj.cdreferencia = orows.Item(0).Item("cd_referencia")
                obj.nbreferencia = orows.Item(0).Item("nb_referencia")
                obj.txcomment = orows.Item(0).Item("tx_comment")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getReferencia()", "Ocurrio un error al consultar un objeto Referencia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getReferencia()", "Ocurrio un error al consultar un objeto Referencia [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar algunos objetos tipo Referencia
    ''' </summary>
    ''' <param name="pscdfuentedato">Clave de la fuente de datos</param>
    ''' <param name="psnbentidadato">Nombre de la entidad de datos</param>
    ''' <returns>Objeto tipo Referencia</returns>
    ''' <remarks></remarks>
    Public Function getReferencias(ByVal pscdfuentedato As String, ByVal psnbentidadato As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection
        oc = New Collection

        Try
            oset = odb.getReferencias(pscdfuentedato, psnbentidadato)
            orows = oset.Tables("referencia").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Referencia
                obj = New Referencia()
                obj.cdfuentedato = orows.Item(i).Item("cd_fuentedato")
                obj.nbentidadato = orows.Item(i).Item("nb_entidadato")
                obj.cdreferencia = orows.Item(i).Item("cd_referencia")
                obj.nbreferencia = orows.Item(i).Item("nb_referencia")
                obj.txcomment = orows.Item(i).Item("tx_comment")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getReferencias()", "Ocurrio un error al consultar los objetos tipo Referencia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getReferencias()", "Ocurrio un error al consultar los objetos tipo Referencia [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function

    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                INSERT CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////
    ''' <summary>
    ''' Procedimiento para insertar un registro en la tabla gen027_sincronia
    ''' </summary>
    ''' <param name="oadd">objeto tipo Sincronia</param>
    ''' <remarks></remarks>
    Public Sub addSincronia(ByRef oadd As Sincronia)
        Try
            oadd.cdsincronia = Me.getNext("gen027_sincronia", "cd_sincronia", "cd_proyecto='" & oadd.cdproyecto & "'")
            odb.addSincronia(oadd)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.addSincronia()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.addSincronia()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para consultar un objeto Referenciacampo
    ''' </summary>
    ''' <param name="pscdreferencia">Clave de la referencia</param>
    ''' <param name="pscdfuentedato">Clave de la fuente de datos</param>
    ''' <param name="psnbentidadato">Nombre de la entidad de datos</param>
    ''' <param name="psnullavecampo">Numero o posicion del campo dentro de la referencia</param>
    ''' <returns>Objeto tipo Referenciacampo</returns>
    ''' <remarks></remarks>
    Public Function getReferenciacampo(ByVal pscdreferencia As String, ByVal pscdfuentedato As String, ByVal psnbentidadato As String, ByVal psnullavecampo As String) As Referenciacampo
        Dim oset As DataSet
        Dim obj As Referenciacampo = Nothing
        Dim orows As DataRowCollection

        Try
            oset = odb.getReferenciacampo(pscdreferencia, pscdfuentedato, psnbentidadato, psnullavecampo)
            orows = oset.Tables("referenciacampo").Rows
            If orows.Count = 1 Then
                obj = New Referenciacampo()
                obj.cdreferencia = orows.Item(0).Item("cd_referencia")
                obj.cdfuentedato = orows.Item(0).Item("cd_fuentedato")
                obj.nbentidadato = orows.Item(0).Item("nb_entidadato")
                obj.nullavecampo = orows.Item(0).Item("nu_llavecampo")
                obj.nbcampo = orows.Item(0).Item("nb_campo")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getReferenciacampo()", "Ocurrio un error al consultar un objeto Referenciacampo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getReferenciacampo()", "Ocurrio un error al consultar un objeto Referenciacampo [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return obj
    End Function

    ''' <summary>
    ''' Procedimiento para consultar algunos objetos tipo Referenciacampo
    ''' </summary>
    ''' <param name="pscdreferencia">Clave de la referencia</param>
    ''' <param name="pscdfuentedato">Clave de la fuente de datos</param>
    ''' <param name="psnbentidadato">Nombre de la entidad de datos</param>
    ''' <returns>Objeto tipo Referenciacampo</returns>
    ''' <remarks></remarks>
    Public Function getReferenciacampos(ByVal pscdreferencia As String, ByVal pscdfuentedato As String, ByVal psnbentidadato As String) As Collection
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Dim oc As Collection
        oc = New Collection

        Try
            oset = odb.getReferenciacampos(pscdreferencia, pscdfuentedato, psnbentidadato)
            orows = oset.Tables("referenciacampo").Rows
            For i = 0 To orows.Count - 1
                Dim obj As Referenciacampo
                obj = New Referenciacampo()
                obj.cdreferencia = orows.Item(i).Item("cd_referencia")
                obj.cdfuentedato = orows.Item(i).Item("cd_fuentedato")
                obj.nbentidadato = orows.Item(i).Item("nb_entidadato")
                obj.nullavecampo = orows.Item(i).Item("nu_llavecampo")
                obj.nbcampo = orows.Item(i).Item("nb_campo")
                oc.Add(obj)
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.getReferenciacampos()", "Ocurrio un error al consultar los objetos tipo Referenciacampo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.getReferenciacampos()", "Ocurrio un error al consultar los objetos tipo Referenciacampo [" & ex1.ToString & "]")
        End Try
        oset = Nothing
        Return oc
    End Function


    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                UPDATE CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////

    ''' <summary>
    ''' Procedimiento para salvar la información de un proyecto
    ''' </summary>
    ''' <param name="oupd">objeto para actualizar</param>
    ''' <remarks></remarks>
    Public Sub saveProyecto(ByRef oupd As Proyecto)
        Try
            If oupd.cdproyecto.Equals("") Then
                oupd.cdproyecto = Me.getNext("gen003_proyecto", "cd_proyecto", "")
                odb.addProyecto(oupd)
            Else
                odb.updProyecto(oupd)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveProyecto()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveProyecto()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para salvar la información de un Staff
    ''' </summary>
    ''' <param name="oupd">objeto para actualizar</param>
    ''' <remarks></remarks>
    Public Sub saveStaff(ByRef oupd As Staff)
        Try
            If oupd.cdstaff.Equals("") Then
                oupd.cdstaff = Me.getNext("gen006_staff", "cd_staff", "cd_proyecto='" & oupd.cdproyecto & "'")
                odb.addStaff(oupd)
            Else
                odb.updStaff(oupd)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveStaff()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveStaff()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para salvar la información de las personas
    ''' </summary>
    ''' <param name="osave">objeto con los datos a salvar</param>
    ''' <remarks></remarks>
    Public Sub savePersona(ByRef osave As Persona)
        Try
            If osave.cdpersona.Equals("") Then
                osave.cdpersona = Me.getNext("gen004_persona", "cd_persona", "")
                odb.addPersona(osave)
            Else
                odb.updPersona(osave)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.savePersona()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.savePersona()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para salvar la información de los Steackholders
    ''' </summary>
    ''' <param name="osave">objeto con los datos a salvar</param>
    ''' <remarks></remarks>
    Public Sub saveSteackholder(ByRef osave As Steackholder)
        Try
            If osave.cdsteackholder.Equals("") Then
                osave.cdsteackholder = Me.getNext("gen005_steackholder", "cd_steackholder", "cd_proyecto='" & osave.cdproyecto & "'")
                odb.addSteackholder(osave)
            Else
                odb.updSteackholder(osave)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveSteackholder()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveSteackholder()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para salvar la información de una pantalla
    ''' </summary>
    ''' <param name="osave">objeto con los datos a salvar</param>
    ''' <remarks></remarks>
    Public Sub savePantalla(ByRef osave As Pantalla)
        Try
            If osave.cdpantalla.Equals("") Then
                osave.cdpantalla = Me.getNext("gen011_pantalla", "cd_pantalla", "cd_proyecto='" & osave.cdproyecto & "'")
                odb.addPantalla(osave)
            Else
                odb.updPantalla(osave)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.savePantalla()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.savePantalla()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para salvar la información de un reporte
    ''' </summary>
    ''' <param name="osave">objeto con los datos a salvar</param>
    ''' <remarks></remarks>
    Public Sub saveReporte(ByRef osave As Reporte)
        Try
            If osave.cdreporte.Equals("") Then
                osave.cdreporte = Me.getNext("gen030_reporte", "cd_reporte", "cd_proyecto='" & osave.cdproyecto & "'")
                odb.addReporte(osave)
            Else
                odb.updReporte(osave)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveReporte()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveReporte()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para salvar la información de un boton
    ''' </summary>
    ''' <param name="osave">objeto que tiene los datos del boton</param>
    ''' <remarks></remarks>
    Public Sub saveBoton(ByRef osave As PantallaBoton)
        Try
            If osave.cdboton.Equals("") Then
                osave.cdboton = Me.getNext("gen015_pantalla_boton", "cd_boton", "cd_proyecto='" & osave.cdproyecto & "' AND cd_pantalla='" & osave.cdpantalla & "'")
                odb.addBoton(osave)
            Else
                odb.updBoton(osave)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveBoton()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveBoton()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para salvar la información del campo de una pantalla
    ''' </summary>
    ''' <param name="osave">objeto con los datos a salvar</param>
    ''' <remarks></remarks>
    Public Sub savePantallaCampo(ByRef osave As PantallaCampo)
        Try
            If osave.cdcampo.Equals("") Then
                osave.cdcampo = Me.getNext("gen013_pantalla_campo", "cd_campo", "cd_proyecto='" & osave.cdproyecto & "' AND cd_pantalla='" & osave.cdpantalla & "'")
                odb.addPantallaCampo(osave)
            Else
                odb.updPantallaCampo(osave)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.savePantallaCampo()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.savePantallaCampo()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para salvar la información del metodo para una pantalla
    ''' </summary>
    ''' <param name="osave">objeto con los datos a salvar</param>
    ''' <remarks></remarks>
    Public Sub savePantallaEvento(ByRef osave As PantallaEvento)
        Try
            If osave.cdevento.Equals("") Then
                osave.cdevento = Me.getNext("gen034_pantalla_evento", "cd_evento", "cd_proyecto='" & osave.cdproyecto & "' AND cd_pantalla='" & osave.cdpantalla & "'")
                odb.addPantallaEvento(osave)
            Else
                odb.updPantallaEvento(osave)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.savePantallaEvento()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.savePantallaEvento()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para salvar la información del campo de un reporte
    ''' </summary>
    ''' <param name="osave">objeto con los datos a salvar</param>
    ''' <remarks></remarks>
    Public Sub saveReporteCampo(ByRef osave As ReporteCampo)
        Try
            If osave.cdcampo.Equals("") Then
                osave.cdcampo = Me.getNext("gen031_reporte_campo", "cd_campo", "cd_proyecto='" & osave.cdproyecto & "' AND cd_reporte='" & osave.cdreporte & "'")
                odb.addReporteCampo(osave)
            Else
                odb.updReporteCampo(osave)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveReporteCampo()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveReporteCampo()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para salvar la información desde un datasource
    ''' </summary>
    ''' <param name="oupd">objeto que tiene la información del Datasource</param>
    ''' <remarks></remarks>
    Public Sub saveFuenteDato(ByRef oupd As FuenteDato)
        Try
            If oupd.cdfuentedato.Equals("") Then
                oupd.cdfuentedato = Me.getNext("gen022_fuentedato", "cd_fuentedato", "")
                odb.addFuenteDato(oupd)
            Else
                odb.updFuenteDato(oupd)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveFuenteDato()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveFuenteDato()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para grabar la información de una Entidad de datos en la tabla gen023_entidadato
    ''' </summary>
    ''' <param name="oupd">objeto con la información a grabar</param>
    ''' <remarks></remarks>
    Public Sub saveEntidaDato(ByRef oupd As EntidaDato)
        Dim otmp As EntidaDato = Nothing
        Try
            otmp = Me.getEntidaDato(oupd.cdfuentedato, oupd.nbentidadato)
            If otmp Is Nothing Then
                odb.addEntidaDato(oupd)
            Else
                odb.updEntidaDato(oupd)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveEntidaDato()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveEntidaDato()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para grabar la información de un campo en la tabla gen024_dbentidad_campo
    ''' </summary>
    ''' <param name="oupd">objeto con la información a grabar</param>
    ''' <remarks></remarks>
    Public Sub saveEntidaDatoCampo(ByRef oupd As EntidaDatoCampo)
        Dim otmp As EntidaDatoCampo = Nothing
        Try
            otmp = Me.getEntidaDatoCampo(oupd.cdfuentedato, oupd.nbentidadato, oupd.nbcampo)
            If otmp Is Nothing Then
                odb.addEntidaDatoCampo(oupd)
            Else
                odb.updEntidaDatoCampo(oupd)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveEntidaDatoCampo()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveEntidaDatoCampo()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar la información de una fuente de datos que pertenece a un proyecto
    ''' </summary>
    ''' <param name="oupd"></param>
    ''' <remarks></remarks>
    Public Sub saveProyectoFuenteDato(ByRef oupd As ProyectoFuenteDato)
        Dim otmp As ProyectoFuenteDato = Nothing
        Try
            otmp = Me.getProyectoFuenteDato(oupd.cdproyecto, oupd.cdfuentedato)
            If otmp Is Nothing Then
                odb.addProyectoFuenteDato(oupd)
            Else
                odb.updProyectoFuenteDato(oupd)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveProyectoFuenteDato()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveProyectoFuenteDato()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar una entidad - fuente de datos a un proyecto en particular
    ''' </summary>
    ''' <param name="oadd">objeto para darlo de alta</param>
    ''' <remarks></remarks>
    Public Sub addProyectoFuenteDatoEntidad(ByRef oadd As ProyectoFuenteDatoEntidad)
        Try
            odb.addProyectoFuenteDatoEntidad(oadd)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.addProyectoFuenteDatoEntidad()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.addProyectoFuenteDatoEntidad()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Function para actualizar la informacion de una entidad en la tabla gen023_entidadato
    ''' </summary>
    ''' <param name="oupd">objeto con los datos para actualizar</param>
    ''' <remarks></remarks>
    Public Sub updEntidadDatoComment(ByRef oupd As EntidaDato)
        Try
            odb.updEntidadDatoComment(oupd)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.updEntidadDatoComment()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.updEntidadDatoComment()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Function para actualizar la informacion de un campo de datos en la tabla gen024_entidadato_campo
    ''' </summary>
    ''' <param name="oupd">objeto con los datos para actualizar</param>
    ''' <remarks></remarks>
    Public Sub updEntidadDatoCampoComment(ByRef oupd As EntidaDatoCampo)
        Try
            odb.updEntidadDatoCampoComment(oupd)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.updEntidadDatoCampoComment()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.updEntidadDatoCampoComment()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar la información de la navegación de un proyecto
    ''' </summary>
    ''' <param name="oupd">Objeto con la navegación</param>
    ''' <remarks></remarks>
    Public Sub saveNavegacion(ByRef oupd As Navegacion)
        Dim otmp As Navegacion = Nothing
        Try
            otmp = Me.getNavegacion(oupd.cdproyecto, oupd.cdesde, oupd.cdhasta)
            If otmp Is Nothing Then
                odb.addNavegacion(oupd)
            Else
                odb.updNavegacion(oupd)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveNavegacion()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveNavegacion()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar una colección de parámetros en la base de datos
    ''' </summary>
    ''' <param name="cparams">colección</param>
    ''' <remarks></remarks>
    Public Sub addNavegacionParams(ByRef cparams As Collection)
        Dim icounter As Integer
        Try
            icounter = 1
            For Each opar As NavegacionParam In cparams
                Dim sparam As String = "000000" & icounter
                opar.cdparam = sparam.Substring(sparam.Length - 6)
                odb.addNavegacionParam(opar)
                icounter = icounter + 1
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.addNavegacionParams()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.addNavegacionParams()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen027_sincronia
    ''' </summary>
    ''' <param name="oupd">objeto tipo Sincronia</param>
    ''' <remarks></remarks>
    Public Sub updSincronia(ByVal oupd As Sincronia)
        Try
            odb.updSincronia(oupd)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.updSincronia()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.updSincronia()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para propagar los compentarios
    ''' </summary>
    ''' <param name="sftedatos">clave de la fuente de datos</param>
    ''' <param name="snbcampo">nombre del campo</param>
    ''' <param name="scomment">comentario</param>
    ''' <remarks></remarks>
    Public Sub updPropagarCommentEntidadCampo(ByVal sftedatos As String, ByVal snbcampo As String, ByVal scomment As String)
        Dim centidades As Collection
        Try
            centidades = Me.getEntidaDatos(sftedatos)
            For Each oent As EntidaDato In centidades
                Dim ccampos As Collection
                ccampos = Me.getEntidaDatoCampos(sftedatos, oent.nbentidadato)
                For Each ocam As EntidaDatoCampo In ccampos
                    If ocam.nbcampo.Equals(snbcampo) And ocam.txcomment.Equals("") Then
                        ocam.txcomment = scomment
                        odb.updEntidaDatoCampo(ocam)
                    End If
                Next
            Next
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.updPropagarCommentEntidadCampo()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.updPropagarCommentEntidadCampo()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen038_sincronia_pantalla
    ''' </summary>
    ''' <param name="oupd">objeto tipo SincroniaPantalla</param>
    ''' <remarks></remarks>
    Public Sub saveSincroniaPantalla(ByVal oupd As SincroniaPantalla)
        Dim otmp As SincroniaPantalla
        Try
            otmp = Me.getSincroniaPantalla(oupd.cdsincronia, oupd.cdproyecto, oupd.cdpantalla)
            If otmp Is Nothing Then
                odb.addSincroniaPantalla(oupd)
            Else
                odb.updSincroniaPantalla(oupd)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveSincroniaPantalla()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveSincroniaPantalla()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen039_sincronia_evento
    ''' </summary>
    ''' <param name="oupd">objeto tipo SincroniaEvento</param>
    ''' <remarks></remarks>
    Public Sub saveSincroniaEvento(ByVal oupd As SincroniaEvento)
        Dim otmp As SincroniaEvento
        Try
            otmp = Me.getSincroniaEvento(oupd.cdsincronia, oupd.cdproyecto, oupd.cdpantalla, oupd.cdevento)
            If otmp Is Nothing Then
                odb.addSincroniaEvento(oupd)
            Else
                odb.updSincroniaEvento(oupd)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveSincroniaEvento()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveSincroniaEvento()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen040_sincronia_campo
    ''' </summary>
    ''' <param name="oupd">objeto tipo SincroniaCampo</param>
    ''' <remarks></remarks>
    Public Sub saveSincroniaCampo(ByVal oupd As SincroniaCampo)
        Dim otmp As SincroniaCampo
        Try
            otmp = Me.getSincroniaCampo(oupd.cdsincronia, oupd.cdproyecto, oupd.cdpantalla, oupd.cdcampo)
            If Not otmp Is Nothing Then odb.delSincroniaCampo(oupd.cdsincronia, oupd.cdproyecto, oupd.cdpantalla, oupd.cdcampo)
            odb.addSincroniaCampo(oupd)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveSincroniaCampo()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveSincroniaCampo()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar un registro de la tabla gen044_sincronia_arreglo
    ''' </summary>
    ''' <param name="oupd">objeto tipo SincroniArreglo</param>
    ''' <remarks></remarks>
    Public Sub saveSincroniArreglo(ByRef oupd As SincroniArreglo)
        Dim otmp As SincroniArreglo
        Try
            otmp = Me.getSincroniArreglo(oupd.cdsincronia, oupd.cdproyecto, oupd.cdpantalla, oupd.cdarreglo)
            If Not otmp Is Nothing Then odb.delSincroniArreglo(oupd.cdsincronia, oupd.cdproyecto, oupd.cdpantalla, oupd.cdarreglo)
            odb.addSincroniArreglo(oupd)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveSincroniArreglo()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveSincroniArreglo()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para salvar la información relativa a el arreglo de una pantalla
    ''' </summary>
    ''' <param name="osave">objeto con los datos a salvar</param>
    ''' <remarks></remarks>
    Public Sub savePantallarreglo(ByRef osave As Pantallarreglo)
        Try
            If osave.cdarreglo.Equals("") Then
                osave.cdarreglo = Me.getNext("gen042_pantalla_arreglo", "cd_arreglo", "cd_proyecto='" & osave.cdproyecto & "' AND cd_pantalla='" & osave.cdpantalla & "'")
                odb.addPantallarreglo(osave)
            Else
                odb.updPantallarreglo(osave)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.savePantallarreglo()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.savePantallarreglo()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para salvar la información relativa a el arreglo de un reporte
    ''' </summary>
    ''' <param name="osave">objeto con los datos a salvar</param>
    ''' <remarks></remarks>
    Public Sub saveReporteArreglo(ByRef osave As ReporteArreglo)
        Try
            If osave.cdarreglo.Equals("") Then
                osave.cdarreglo = Me.getNext("gen043_reporte_arreglo", "cd_arreglo", "cd_proyecto='" & osave.cdproyecto & "' AND cd_reporte='" & osave.cdreporte & "'")
                odb.addReporteArreglo(osave)
            Else
                odb.updReporteArreglo(osave)
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.saveReporteArreglo()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.saveReporteArreglo()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Function para actualizar los registros de una clase
    ''' </summary>
    ''' <param name="stabla">Nombre de la tabla</param>
    ''' <param name="scampo">Nombre del campo</param>
    ''' <param name="svalor">Valor</param>
    ''' <returns>numero de registros actualizados</returns>
    ''' <remarks></remarks>
    Public Function updNuevoCampo(ByVal stabla As String, ByVal scampo As String, ByVal svalor As String) As Integer
        Dim objCommand As SQLiteCommand
        Dim objDataAdapter As SQLiteDataAdapter
        Dim orows As DataRowCollection
        Dim oset As DataSet
        Dim i As Integer
        Try
            oset = New DataSet()
            objCommand = New SQLiteCommand("SELECT * FROM " & stabla, odb.cnn)
            objDataAdapter = New SQLiteDataAdapter(objCommand)
            objDataAdapter.FillSchema(oset, SchemaType.Source, stabla)
            objDataAdapter.Fill(oset, stabla)
            orows = oset.Tables(stabla).Rows
            For i = 0 To orows.Count - 1
                If IsDBNull(orows.Item(i).Item(scampo)) Then
                    orows.Item(i).BeginEdit()
                    orows.Item(i).Item(scampo) = svalor
                    orows.Item(i).EndEdit()
                End If
            Next
            Dim objCommandBuilder As New SQLiteCommandBuilder(objDataAdapter)
            objDataAdapter.Update(oset, stabla)

            objDataAdapter = Nothing
            objCommand = Nothing

        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.updNuevoCampo()", "Ocurrio un error al actualizar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.updNuevoCampo()", "Ocurrio un error al actualizar informacion [" & ex1.ToString & "]")
        End Try
        Return (i + 1)
    End Function

    ''' <summary>
    ''' Procedimiento para agregar un nuevo objeto tipo Referencia
    ''' </summary>
    ''' <param name="oadd">objeto tipo Referencia</param>
    ''' <remarks></remarks>
    Public Sub addReferencia(ByRef oadd As Referencia)
        Try
            oadd.cdreferencia = Me.getNext("gen032_referencia", "cd_referencia", "cd_fuentedato='" & oadd.cdfuentedato & "' AND nb_entidadato='" & oadd.nbentidadato & "'")
            odb.addReferencia(oadd)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.addReferencia()", "Ocurrio un error al agregar un objeto tipo Referencia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.addReferencia()", "Ocurrio un error al agregar un objeto tipo Referencia [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar un nuevo objeto tipo Referenciacampo
    ''' </summary>
    ''' <param name="oadd">objeto tipo Referenciacampo</param>
    ''' <remarks></remarks>
    Public Sub addReferenciacampo(ByRef oadd As Referenciacampo)
        Try
            oadd.nullavecampo = Me.getNext("gen051_referenciacampo", "nu_llavecampo", "cd_fuentedato='" & oadd.cdfuentedato & "' AND nb_entidadato='" & oadd.nbentidadato & "' AND cd_referencia='" & oadd.cdreferencia & "'").Substring(4)
            odb.addReferenciacampo(oadd)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.addReferenciacampo()", "Ocurrio un error al agregar un objeto tipo Referenciacampo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.addReferenciacampo()", "Ocurrio un error al agregar un objeto tipo Referenciacampo [" & ex1.ToString & "]")
        End Try
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////
    '//                                DELETE CODE                                         //
    '////////////////////////////////////////////////////////////////////////////////////////

    ''' <summary>
    ''' Procedimiento para eliminar el registro de un proyecto
    ''' </summary>
    ''' <param name="sproject"></param>
    ''' <returns>true/false</returns>
    ''' <remarks></remarks>
    Public Function delProyecto(ByVal sproject As String) As Boolean

        Try
            If odb.getExist("gen006_staff", "cd_proyecto='" & sproject & "'") Then
                Me.mensaje = "No es posible eliminar un proyecto que tiene STAFF"
                Return False
            End If

            If odb.getExist("gen005_steackholder", "cd_proyecto='" & sproject & "'") Then
                Me.mensaje = "No es posible eliminar un proyecto que tiene Steackholders"
                Return False
            End If

            If odb.getExist("gen010_costo", "cd_proyecto='" & sproject & "'") Then
                Me.mensaje = "No es posible eliminar un proyecto que tiene Costos"
                Return False
            End If

            If odb.getExist("gen011_pantalla", "cd_proyecto='" & sproject & "'") Then
                Me.mensaje = "No es posible eliminar un proyecto que tiene Pantallas"
                Return False
            End If

            If odb.getExist("gen030_reporte", "cd_proyecto='" & sproject & "'") Then
                Me.mensaje = "No es posible eliminar un proyecto que tiene Reportes"
                Return False
            End If

            odb.delProyecto(sproject)

        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delProyecto()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delProyecto()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try

        Return True
    End Function

    ''' <summary>
    ''' Procedimiento para eliminar un registro de Staff
    ''' </summary>
    ''' <param name="sproject"></param>
    ''' <param name="sstaff"></param>
    ''' <remarks></remarks>
    Public Sub delStaff(ByVal sproject As String, ByVal sstaff As String)
        Try
            odb.delStaff(sproject, sstaff)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delStaff()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delStaff()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de Persona
    ''' </summary>
    ''' <param name="scdpersona">clave de la persona</param>
    ''' <returns>true/false</returns>
    ''' <remarks></remarks>
    Public Function delPersona(ByVal scdpersona As String) As Boolean

        Try
            If odb.getExist("gen006_staff", "cd_persona='" & scdpersona & "'") Then
                Me.mensaje = "Los datos de la personas no se pueden eliminar porque está registrada dentro del staff de uno o mas proyectos"
                Return False
            End If

            odb.delPersona(scdpersona)

        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delPersona()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delPersona()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try

        Return True
    End Function

    ''' <summary>
    ''' Procedimiento para eliminar un registro de Steackholder
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdsteackholder">clave de la persona</param>
    ''' <remarks></remarks>
    Public Sub delSteackholder(ByVal scdproyecto As String, ByVal scdsteackholder As String)
        Try
            odb.delSteackholder(scdproyecto, scdsteackholder)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delSteackholder()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delSteackholder()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar la información relativa a una pantalla en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyect</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <returns>true/false</returns>
    ''' <remarks></remarks>
    Public Function delPantalla(ByVal scdproyecto As String, ByVal scdpantalla As String) As Boolean
        Try
            If odb.getExist("gen013_pantalla_campo", "cd_proyecto='" & scdproyecto & "' AND cd_pantalla='" & scdpantalla & "'") Then
                Me.mensaje = "Los datos del proyecto no se pueden eliminar porque tiene Campos registrados"
                Return False
            End If

            If odb.getExist("gen015_pantalla_boton", "cd_proyecto='" & scdproyecto & "' AND cd_pantalla='" & scdpantalla & "'") Then
                Me.mensaje = "Los datos del proyecto no se pueden eliminar porque tiene Botones registrados"
                Return False
            End If

            If odb.getExist("gen034_pantalla_evento", "cd_proyecto='" & scdproyecto & "' AND cd_pantalla='" & scdpantalla & "'") Then
                Me.mensaje = "Los datos del proyecto no se pueden eliminar porque tiene Métodos de construcción registrados"
                Return False
            End If

            If odb.getExist("gen036_navegacion", "cd_proyecto='" & scdproyecto & "' AND (cd_desde='" & scdpantalla & "' OR cd_hasta='" & scdpantalla & "')") Then
                Me.mensaje = "Los datos del proyecto no se pueden eliminar porque estan registrados en la navegación"
                Return False
            End If

            odb.delPantalla(scdproyecto, scdpantalla)

        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delPantalla()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delPantalla()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try

        Return True
    End Function

    ''' <summary>
    ''' Procedimiento para eliminar la información relativa a un reporte en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdreporte">clave del reporte</param>
    ''' <remarks></remarks>
    Public Sub delReporte(ByVal scdproyecto As String, ByVal scdreporte As String)
        Try
            odb.delReporte(scdproyecto, scdreporte)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delReporte()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delReporte()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar la información relativa a un botón en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyect</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <param name="scdboton">clave del boton</param>
    ''' <remarks></remarks>
    Public Sub delPantallaBoton(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdboton As String)
        Try
            odb.delPantallaBoton(scdproyecto, scdpantalla, scdboton)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delPantallaBoton()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delPantallaBoton()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un campo de la base de datos
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <param name="scdcampo">clave del campo</param>
    ''' <remarks></remarks>
    Public Sub delPantallaCampo(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdcampo As String)
        Try
            odb.delPantallaCampo(scdproyecto, scdpantalla, scdcampo)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delPantallaCampo()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delPantallaCampo()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un campo de la base de datos
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdpantalla">clave de la pantalla</param>
    ''' <param name="scdevento">clave del metodo para el objecto</param>
    ''' <remarks></remarks>
    Public Sub delPantallaEvento(ByVal scdproyecto As String, ByVal scdpantalla As String, ByVal scdevento As String)
        Try
            odb.delPantallaEvento(scdproyecto, scdpantalla, scdevento)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delPantallaEvento()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delPantallaEvento()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un campo de un reporte en particular
    ''' </summary>
    ''' <param name="scdproyecto">clave del proyecto</param>
    ''' <param name="scdreporte">clave del reporte</param>
    ''' <param name="scdcampo">clave del campo</param>
    ''' <remarks></remarks>
    Public Sub delReporteCampo(ByVal scdproyecto As String, ByVal scdreporte As String, ByVal scdcampo As String)
        Try
            odb.delReporteCampo(scdproyecto, scdreporte, scdcampo)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delReporteCampo()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delReporteCampo()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen022_datasource
    ''' </summary>
    ''' <param name="scdfuentedato">Clave del la fuente de datos</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function delFuenteDato(ByVal scdfuentedato As String) As Boolean
        Try
            If odb.getExist("gen023_entidadato", "cd_fuentedato='" & scdfuentedato & "'") Then
                Me.mensaje = "No es posible eliminar una fuente de datos que tenga entidad de datos"
                Return False
            End If

            If odb.getExist("gen021_proyecto_fuentedato", "cd_fuentedato='" & scdfuentedato & "'") Then
                Me.mensaje = "No es posible eliminar una fuente de datos que este relacionada a un proyecto"
                Return False
            End If

            odb.delFuenteDato(scdfuentedato)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delFuenteDato()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delFuenteDato()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try

        Return True
    End Function

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen023_entidadato
    ''' </summary>
    ''' <param name="scdfuentedato">Clave del datasource</param>
    ''' <param name="snbentidadato">Nombre de la entidad</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function delEntidaDato(ByVal scdfuentedato As String, ByVal snbentidadato As String) As Boolean
        Try
            If odb.getExist("gen024_entidadato_campo", "cd_fuentedato='" & scdfuentedato & "' AND nb_entidadato='" & snbentidadato & "'") Then
                MsgBox("No es posible eliminar una entidad que tiene campos", MsgBoxStyle.Exclamation, "MyLIB")
                Return False
            End If

            If odb.getExist("gen025_proyecto_entidadato", "cd_fuentedato='" & scdfuentedato & "' AND nb_entidadato='" & snbentidadato & "'") Then
                MsgBox("No es posible eliminar una entidad relacionada a un proyecto", MsgBoxStyle.Exclamation, "MyLIB")
                Return False
            End If

            If odb.getExist("gen026_entidadato_parametro", "cd_fuentedato='" & scdfuentedato & "' AND nb_entidadato='" & snbentidadato & "'") Then
                MsgBox("No es posible eliminar una entidad que tiene parametros", MsgBoxStyle.Exclamation, "MyLIB")
                Return False
            End If

            odb.delEntidaDato(scdfuentedato, snbentidadato)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delEntidaDato()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delEntidaDato()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try

        Return True
    End Function

    ''' <summary>
    ''' Procedimiento para eliminar toda la información de una entidad de datos en particular
    ''' </summary>
    ''' <param name="scdfuentedato">clave de la fuente de datos</param>
    ''' <param name="snbentidadato">nombre de la entidad</param>
    ''' <remarks></remarks>
    Public Sub delallEntidadDato(ByVal scdfuentedato As String, ByVal snbentidadato As String)
        Dim ccampos As Collection
        Dim cproys As Collection
        Try
            'PASO 1: Consulta las entidades utilizadas en los proyectos
            cproys = Me.getProyectosUsanEntidad(scdfuentedato, snbentidadato)
            For Each opry As ProyectoFuenteDatoEntidad In cproys
                odb.delProyectoFuenteDatoEntidad(opry.cdproyecto, scdfuentedato, snbentidadato)
            Next

            'PASO 2: Elimina cada campo de la entidad
            ccampos = Me.getEntidaDatoCampos(scdfuentedato, snbentidadato)
            For Each ocam As EntidaDatoCampo In ccampos
                odb.delEntidaDatoCampo(scdfuentedato, snbentidadato, ocam.nbcampo)
            Next

            'PASO 3: Elimina el registro de la entidad de datos
            odb.delEntidaDato(scdfuentedato, snbentidadato)

        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delallEntidadDato()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delallEntidadDato()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar todas las referencias
    ''' </summary>
    ''' <param name="scdfuentedato">Clave de la fuente de datos</param>
    ''' <param name="snbentidadato">Nombre de la entidad de datos</param>
    ''' <remarks></remarks>
    Public Sub delallReferences(ByVal scdfuentedato As String, ByVal snbentidadato As String)
        Dim creferences As Collection
        Dim ccampos As Collection

        Try
            'PASO 1: Consulta las entidades utilizadas en los proyectos
            creferences = Me.getReferencias(scdfuentedato, snbentidadato)
            For Each obj As Referencia In creferences
                'PASO 1.1: Consulta los campos de una referencia y los elimina
                ccampos = Me.getReferenciacampos(obj.cdreferencia, scdfuentedato, snbentidadato)
                For Each ocampo As Referenciacampo In ccampos
                    Me.delReferenciacampo(obj.cdreferencia, scdfuentedato, snbentidadato, ocampo.nullavecampo)
                Next
                'PASO 1.1: Elimina la referencia
                odb.delReferencia(scdfuentedato, snbentidadato, obj.cdreferencia)
            Next

        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delallReferences()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delallReferences()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen024_dbentidad_campo
    ''' </summary>
    ''' <param name="scdfuentedato">Clave del datasource</param>
    ''' <param name="snbentidad">Nombre de la entidad</param>
    ''' <remarks></remarks>
    Public Sub delEntidaDatoCampos(ByVal scdfuentedato As String, ByVal snbentidad As String)
        Try
            odb.delEntidaDatoCampos(scdfuentedato, snbentidad)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delEntidaDatoCampos()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delEntidaDatoCampos()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un registro de la tabla gen024_entidadato_campo
    ''' </summary>
    ''' <param name="scdfuentedato">Clave del datasource</param>
    ''' <param name="snbentidad">Nombre de la entidad</param>
    ''' <param name="snbcampo">Nombre del campo</param>
    ''' <remarks></remarks>
    Public Sub delEntidaDatoCampo(ByVal scdfuentedato As String, ByVal snbentidad As String, ByVal snbcampo As String)
        Try
            odb.delEntidaDatoCampo(scdfuentedato, snbentidad, snbcampo)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delEntidaDatoCampo()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delEntidaDatoCampo()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar la relación entre una fuente de datos y un proyecto
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdfuentedato">Clave de la fuente de datos</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function delProyectoFuenteDato(ByVal scdproyecto As String, ByVal scdfuentedato As String) As Boolean
        Try
            If odb.getExist("gen025_proyecto_entidadato", "cd_proyecto='" & scdproyecto & "' AND cd_fuentedato='" & scdfuentedato & "'") Then
                MsgBox("No es posible eliminar la fuente de datos porque tiene entidades seleccionadas", MsgBoxStyle.Exclamation, "MyLIB")
                Return False
            End If

            odb.delProyectoFuenteDato(scdproyecto, scdfuentedato)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delProyectoFuenteDato()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delProyectoFuenteDato()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try

        Return True
    End Function

    ''' <summary>
    ''' Procedimiento para eliminar las entidades que pertenecen a la relación de un proyecto y una fuente de datos
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyect</param>
    ''' <param name="scdfuentedato">Clave de la fuente de datos</param>
    ''' <remarks></remarks>
    Public Sub delProyectoFuenteDatoEntidades(ByVal scdproyecto As String, ByVal scdfuentedato As String)
        Try
            odb.delProyectoFuenteDatoEntidades(scdproyecto, scdfuentedato)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delProyectoFuenteDatoEntidades()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delProyectoFuenteDatoEntidades()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar una navegación en particular
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdesde">Clave del proyecto desde</param>
    ''' <param name="scdhasta">Clave del proyecto hasta</param>
    ''' <remarks></remarks>
    Public Sub delNavegacion(ByVal scdproyecto As String, ByVal scdesde As String, ByVal scdhasta As String)
        Try
            odb.delNavegacion(scdproyecto, scdesde, scdhasta)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delNavegacion()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delNavegacion()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar el parámetro de navegación
    ''' </summary>
    ''' <param name="scdproyecto">Clave del proyecto</param>
    ''' <param name="scdesde">Clave del proyecto desde</param>
    ''' <param name="scdhasta">Clave del proyecto hasta</param>
    ''' <remarks></remarks>
    Public Sub delNavegacionParams(ByVal scdproyecto As String, ByVal scdesde As String, ByVal scdhasta As String)
        Try
            odb.delNavegacionParams(scdproyecto, scdesde, scdhasta)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delNavegacionParams()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delNavegacionParams()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar las sincronizaciones de una pantalla en particular
    ''' </summary>
    ''' <param name="pscdsincronia">Clave de la sincronia</param>
    ''' <param name="pscdproyecto">Clave del proyecto</param>
    ''' <param name="pscdpantalla">Clave de la pantalla</param>
    ''' <remarks></remarks>
    Public Sub delSincroniaPantalla(ByVal pscdsincronia As String, ByVal pscdproyecto As String, ByVal pscdpantalla As String)
        Try
            odb.delSincroniArreglos(pscdsincronia, pscdproyecto, pscdpantalla)
            odb.delSincroniaEventos(pscdsincronia, pscdproyecto, pscdpantalla)
            odb.delSincroniaCampos(pscdsincronia, pscdproyecto, pscdpantalla)
            odb.delSincroniaPantalla(pscdsincronia, pscdproyecto, pscdpantalla)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delSincroniaPantalla()", "Ocurrio un error al grabar informacion")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delSincroniaPantalla()", "Ocurrio un error al grabar informacion [" & ex1.ToString & "]")
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
        Try
            odb.delPantallarreglo(pscdproyecto, pscdpantalla, pscdarreglo)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delPantallarreglo(key)", "Ocurrio un error al eliminar un objeto tipo Pantallarreglo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delPantallarreglo(key)", "Ocurrio un error al eliminar un objeto tipo Pantallarreglo [" & ex1.ToString & "]")
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
        Try
            odb.delReporteArreglo(pscdproyecto, pscdreporte, pscdarreglo)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delReporteArreglo(key)", "Ocurrio un error al eliminar un objeto tipo ReporteArreglo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delReporteArreglo(key)", "Ocurrio un error al eliminar un objeto tipo ReporteArreglo [" & ex1.ToString & "]")
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
        Try
            odb.delReferencia(pscdfuentedato, psnbentidadato, pscdreferencia)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delReferencia(key)", "Ocurrio un error al eliminar un objeto tipo Referencia")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delReferencia(key)", "Ocurrio un error al eliminar un objeto tipo Referencia [" & ex1.ToString & "]")
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
        Try
            odb.delReferenciacampo(pscdreferencia, pscdfuentedato, psnbentidadato, psnullavecampo)
        Catch ex As HANYException
            ex.add("MyLIB.Catalogos.delReferenciacampo(key)", "Ocurrio un error al eliminar un objeto tipo Referenciacampo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Catalogos.delReferenciacampo(key)", "Ocurrio un error al eliminar un objeto tipo Referenciacampo [" & ex1.ToString & "]")
        End Try
    End Sub

End Class   'fin clase [Catalogos]
