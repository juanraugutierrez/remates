Public Class lcuadraturas

    Public contex As New persaEntities11
    Private Property var As System.Linq.IQueryable(Of persaEntities11)
    Private Property quer As System.Linq.IQueryable

    Public Function listacuadraturas() As IQueryable
        quer = From c In contex.Cuadratura Select c
        Return quer
    End Function

    Public Function listacuadraturass(id As Integer) As IQueryable
        quer = From c In contex.Cuadratura Where c.id_cuadra = id Select c
        Return quer
    End Function

    Sub carga(mm As Cuadratura)
        Try
            contex.AddToCuadratura(mm)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "carga de Nominas")
        End Try

    End Sub
    Sub cargadetalle(mm As Cuadratura_detalle)
        Try
            contex.AddToCuadratura_detalle(mm)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "carga de Nominas")
        End Try

    End Sub

    Sub regfact(id_factura As Integer, id_nomina As Integer)
        Try
            contex.ExecuteStoreCommand("update facturas set id_nomina={0} where id_factura={1}", id_nomina, id_factura)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "carga de Nominas")
        End Try

    End Sub



    Public Sub Updatelote(mm As Cuadratura)
        Dim cuadra As Object
        cuadra = (From c In contex.Cuadratura Where c.id_cuadra = mm.id_cuadra).Single()
        cuadra = mm
        contex.SaveChanges()
        contex.AcceptAllChanges()

    End Sub

    Public Function borracuadratura(id As Integer) As Boolean

        Dim cuadra As Object
        cuadra = (From c In contex.Cuadratura Where c.id_cuadra = id).Single()
        Try
            contex.DeleteObject(cuadra)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Public Function buscacuadratura(id As Integer) As Cuadratura
        Dim cuadra As Object
        cuadra = (From c In contex.Cuadratura Where c.id_cuadra = id).Single()
        Return cuadra
    End Function

    Public Function buscacuadraturadetalle(id As Integer) As List(Of Cuadratura_detalle)
        Dim cuadra As List(Of Cuadratura_detalle)
        cuadra = (From c In contex.Cuadratura_detalle Where c.id_cuadra = id Select c).ToList()
        Return cuadra
    End Function

End Class
