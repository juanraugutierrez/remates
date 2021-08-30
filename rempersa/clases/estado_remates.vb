Public Class estado_remates
    Public contex As New persaEntities11

    Private Property var As System.Linq.IQueryable(Of persaEntities11)
    Private Property quer As System.Linq.IQueryable


    Public Function lista_estadoremates() As IQueryable

        quer = From c In contex.estado_remates Select c
        Return quer

    End Function

    Sub carga(mm As estado_remates)
        contex.AddToestado_remates(mm)
        contex.SaveChanges()
        contex.AcceptAllChanges()

    End Sub

    Function EstadoRematesForestado(estado As String) As Integer
        Dim eve As Integer
        eve = (From c In contex.estado_remates Where c.estado_remate = estado Select c.id_estadoremate).Single()
        Return eve
    End Function


    Public Sub UpdateTipoRemate(id As Integer, mm As tipo_remates)
        Dim tiporem As Object
        tiporem = (From c In contex.tipo_remates Where c.id_tiporemate = id).Single()

        tiporem.descripcion = mm.descripcion
        contex.SaveChanges()
        contex.AcceptAllChanges()


    End Sub

    Public Function borramandante(id As Integer) As Boolean

        Dim borr As Object
        borr = (From c In contex.mandantes Where c.id_mandante = id).Single()
        Try
            contex.DeleteObject(borr)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

End Class
