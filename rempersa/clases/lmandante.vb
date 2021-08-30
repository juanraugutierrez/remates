Public Class lmandante
    Public contex As New persaEntities11

    Private Property var As System.Linq.IQueryable(Of persaEntities11)
    Private Property quer As System.Linq.IQueryable

    Public Function listamandantes() As IQueryable
        quer = From c In contex.mandantes Select c
        Return quer
    End Function


    Public Function listamandantes(ByVal manda As String) As IQueryable
        quer = From c In contex.mandantes Where c.razonsocial_mandante.Contains(manda) Select c
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

    Public Function buscarmandante(id As Integer) As mandantes
        Dim cll As New mandantes
        cll = (From c In contex.mandantes Where c.id_mandante = id Select c).First()
        Return cll
    End Function

    Public Function buscarmandate(nom As String) As IQueryable
        quer = From c In contex.mandantes Where c.razonsocial_mandante = nom Select c
        Return quer
    End Function
    Public Function buscarmandanterutr(rut As String) As IQueryable
        rut = Replace(rut, ".", "")
        rut = RTrim(LTrim(rut))
        quer = From c In contex.mandantes Where c.rut_mandante.Contains(rut) Select c
        Return quer
    End Function
    Public Function buscarmandanterut(rut As String) As Object
        rut = Replace(rut, ".", "")
        rut = RTrim(LTrim(rut))
        Dim var As Object
        var = (From c In contex.mandantes Where c.rut_mandante = rut Select c).First()
        Return var
    End Function


    Public Function buscarcomuna(valor As Integer) As String
        Dim var As String
        var = (From c In contex.comunas Where c.id_comuna = valor Select c.comuna).First
        Return var
    End Function
    Public Function buscarmandanten(nom As String) As IQueryable
        quer = From c In contex.mandantes Where c.razonsocial_mandante.Contains(nom) Select c
        Return quer
    End Function

    Sub carga(mm As mandantes)
        contex.AddTomandantes(mm)
        contex.SaveChanges()
        contex.AcceptAllChanges()
    End Sub




    Public Sub Updatemandante(mm As mandantes)
        Dim clie As Object
        clie = (From c In contex.mandantes Where c.id_mandante = mm.id_mandante).Single()

        clie.id_mandante = mm.id_mandante
        clie.id_comuna = mm.id_comuna
        clie.mandato = mm.mandato
        clie.mandato = mm.monto_liquidado
        clie.razonsocial_mandante = mm.razonsocial_mandante
        clie.rut_mandante = mm.rut_mandante
        clie.direccion_mandante = mm.direccion_mandante
        clie.giro = mm.giro
        clie.repDireccion_mandante = mm.repDireccion_mandante
        clie.vigente = mm.vigente
        clie.mandato = mm.mandato
        clie.telefono_mandante = mm.telefono_mandante
        clie.id_comuna = mm.id_comuna
        clie.email = mm.email

        contex.SaveChanges()
        contex.AcceptAllChanges()

    End Sub

    Public Function borramandante(id As Integer) As Boolean

        Dim manda As Object
        manda = (From c In contex.mandantes Where c.id_mandante = id).Single()
        Try
            contex.DeleteObject(manda)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function



End Class






