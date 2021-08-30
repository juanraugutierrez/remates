
Public Class acciones

    Public contex As New persaEntities11


    Private Property var As System.Linq.IQueryable(Of persaEntities11)

    Public Function listausuarios() As IEnumerable

        var = From c In contex.usuarios Select c

        Return var


    End Function

    Sub carga(mm As usuarios)
        contex.AddTousuarios(mm)
        contex.SaveChanges()
        contex.AcceptAllChanges()

    End Sub

    Function userForID(id As Integer)
        Dim eve As Object
        eve = (From c In contex.usuarios Where c.id_usuario = id).Single()
        Return eve
    End Function
    Function userValida(use As String, pass As String) As Boolean
        Dim eve As Object
        Try
            eve = (From c In contex.usuarios Where c.use_user = use).Single()
        Catch ex As Exception
            Return False
        End Try

        If eve.use_password = pass Then
            remates.tlabel_usuario.Text = use.ToUpper
            remates.Tlabel_estado.Text = "Validado " & Now.ToShortDateString() & " " & Now.ToShortTimeString
            remates.Refresh()

            Return True
        Else
            Return False
        End If

    End Function


    Public Sub UpdateUsuario(id As Integer, mm As usuarios)
        Dim use As Object
        use = (From c In contex.usuarios Where c.id_usuario = id).Single()

        use.use_nombre = mm.use_nombre.ToString()
        use.use_apelledo = mm.use_apellido
        use.use_cargo = mm.use_cargo

        contex.SaveChanges()
        contex.AcceptAllChanges()


    End Sub

    Public Function borrusuario(id As Integer) As Boolean

        Dim eve As Object
        eve = (From c In contex.usuarios Where c.id_usuario = id).Single()
        Try
            contex.DeleteObject(eve)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function



End Class


