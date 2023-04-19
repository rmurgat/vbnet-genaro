Public Class frmXMLTree
    Private sxml As String   'propiedad xml a visualizar

    ''' <summary>
    ''' PROPIEDAD: propiedad xml a visualizar
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property xml() As String
        Get
            Return sxml
        End Get
        Set(ByVal psval As String)
            sxml = psval.Trim
        End Set
    End Property

    Private Sub frmXML_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click
        Dim onodo As Nodo
        Dim sraiz As String = ""

        'PASO 1: Inicializa las variables
        onodo = New Nodo(Me.xml)
        sraiz = onodo.getNombreRaiz()

        'PASO 2: Recorre las propieades de primer nivel
        treXML.BeginUpdate()
        treXML.Nodes.Clear()

        treXML.Nodes.Add(sraiz, sraiz)




        'treXML.Nodes.Add("SEGUNDO", "SEGUNDO")
        'treXML.Nodes.Add("TERCERO", "TERCERO")
        'treXML.Nodes.Add("CUARTO", "CUARTO")

        'treXML.Nodes("PRIMERO").Nodes.Add("PRIMERO.1", "PRIMERO.1")
        'treXML.Nodes("PRIMERO").Nodes.Add("PRIMERO.2", "PRIMERO.2")
        'treXML.Nodes("PRIMERO").Nodes.Add("PRIMERO.3", "PRIMERO.3")

        'treXML.Nodes("PRIMERO").Nodes("PRIMERO.1").Nodes.Add("PRIMERO.1.1", "PRIMERO.1.1")

        'treXML.Nodes("SEGUNDO").Nodes.Add(New TreeNode("SEGUNDO.1"))
        'treXML.Nodes("SEGUNDO").Nodes.Add(New TreeNode("SEGUNDO.2"))
        'treXML.Nodes("SEGUNDO").Nodes.Add(New TreeNode("SEGUNDO.3"))
        'treXML.Nodes("SEGUNDO").Nodes.Add(New TreeNode("SEGUNDO.4"))

        'treXML.Nodes("TERCERO").Nodes.Add(New TreeNode("TERCERO.1"))
        'treXML.Nodes("TERCERO").Nodes.Add(New TreeNode("TERCERO.2"))
        'treXML.Nodes("TERCERO").Nodes.Add(New TreeNode("TERCERO.3"))

        'treXML.Nodes("CUARTO").Nodes("TERCERO.1").Nodes.Add(New TreeNode("TERCERO.1.1"))
        'treXML.Nodes("CUARTO").Nodes("TERCERO.1").Nodes.Add(New TreeNode("TERCERO.1.2"))
        'treXML.Nodes("CUARTO").Nodes("TERCERO.1").Nodes.Add(New TreeNode("TERCERO.1.3"))

        'PASO N: Actualiza el arbol 
        treXML.EndUpdate()
    End Sub
End Class