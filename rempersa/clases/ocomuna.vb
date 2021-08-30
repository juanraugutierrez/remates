Public Class ocomuna
    Public contex As New persaEntities11

    Private Property var As System.Linq.IQueryable(Of lotes)
    Private Property quer As System.Linq.IQueryable

    Public Function listacomunas() As IEnumerable
        var = From c In contex.lotes Select c
        Return var
    End Function

    Public Function listaregiontext(idregion As Integer) As String
        Dim var As String
        var = (From c In contex.comunas Join r In contex.regiones On c.id_region Equals r.id_region Where c.id_comuna = idregion Select r.region).FirstOrDefault().ToString()
        Return var
    End Function


    Public Function listacomuna(idcomuna As Integer) As IQueryable
        quer = (From c In contex.comunas Where c.id_comuna = idcomuna Select c)
        Return quer
    End Function
    Public Function listacomunatext(idcomuna As Integer) As String
        Dim var As String
        var = (From c In contex.comunas Where c.id_comuna = idcomuna Select c.comuna).First().ToString()
        Return var
    End Function

End Class