Public Class cliente
    Public contex As New persaEntities11

    Private Property var As System.Linq.IQueryable(Of persaEntities11)
    Private Property quer As System.Linq.IQueryable

    Public Function listaclientes() As IQueryable
        quer = From c In contex.clientes Select c
        Return quer

    End Function

    Public Function listacomunas(id As Integer) As IQueryable
        quer = From c In contex.comunas Where c.id_region = id Select c
        Return quer
    End Function



    Public Function listaregiones() As IQueryable
        quer = From c In contex.regiones Select c
        Return quer
    End Function

    Public Function buscarcliente(id As Integer) As clientes
        Dim cll As New clientes
        cll = (From c In contex.clientes Where c.id_cliente = id Select c).First()
        Return cll
    End Function

    Public Function buscarcliente(nom As String) As IQueryable
        quer = From c In contex.clientes Where c.razon_social = nom Select c
        Return quer
    End Function
    Public Function buscarclienterutr(rut As String) As IQueryable
        rut = Replace(rut, ".", "")
        rut = RTrim(LTrim(rut))
        quer = From c In contex.clientes Where c.rut.Contains(rut) Select c
        Return quer
    End Function
    Public Function buscarclienterut(rut As String) As Object
        rut = Replace(rut, ".", "")
        rut = RTrim(LTrim(rut))
        Dim var As Object
        var = (From c In contex.clientes Where c.rut = rut Select c).First()
        Return var
    End Function

    Public Function buscarclienten(nom As String) As IQueryable
        quer = From c In contex.clientes Where c.razon_social.Contains(nom) Select c
        Return quer
    End Function

    Sub carga(mm As clientes)
        contex.AddToclientes(mm)
        contex.SaveChanges()
        contex.AcceptAllChanges()
    End Sub




    Public Sub Updatelote(mm As clientes)
        Dim clie As Object
        clie = (From c In contex.clientes Where c.id_cliente = mm.id_cliente).Single()
        clie = mm
        contex.SaveChanges()
        contex.AcceptAllChanges()

    End Sub

    Public Function borralote(id As Integer) As Boolean

        Dim clie As Object
        clie = (From c In contex.clientes Where c.id_cliente = id).Single()
        Try
            contex.DeleteObject(clie)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function



End Class






