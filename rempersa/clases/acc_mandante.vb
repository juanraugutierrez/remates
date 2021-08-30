Public Class acc_mandante
    Public contex As New persaEntities11

    Private Property var As System.Linq.IQueryable(Of persaEntities11)
    Private Property quer As System.Linq.IQueryable

    Public Function listamandantes() As IQueryable
        quer = From c In contex.mandantes Select c
        Return quer
    End Function

    Sub carga(mm As mandantes)
        contex.AddTomandantes(mm)
        contex.SaveChanges()
        contex.AcceptAllChanges()

    End Sub

    Function mandanteForID(id As Integer)
        Dim eve As Object
        eve = (From c In contex.mandantes Where c.id_mandante = id).Single()
        Return eve
    End Function


    Public Sub UpdateMandante(id As Integer, mm As mandantes)
        Dim manda As Object
        manda = (From c In contex.mandantes Where c.id_mandante = id).Single()

        manda.nombre_mandante = mm.razonsocial_mandante.ToString().ToUpper()
        manda.Replegal_mandante = mm.Replegal_mandante.ToString().ToUpper()
        manda.nrocontratos_mandante = mm.nrocontratos_mandante
        manda.rut_mandante = mm.rut_mandante.ToString()
        manda.telefono_mandante = mm.telefono_mandante.ToString()
        manda.repDireccion_mandante = mm.repDireccion_mandante.ToString().ToUpper()

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
