
Public Class parametro

    Public contex As New persaEntities11

    Private Property var As System.Linq.IQueryable(Of persaEntities11)

    Public Function listaparametros() As IEnumerable

        var = From c In contex.parametros Select c

        Return var

    End Function

    Sub carga(mm As parametros)
        contex.AddToparametros(mm)
        contex.SaveChanges()
        contex.AcceptAllChanges()

    End Sub

    Function parametroForID(id As Integer)
        Dim eve As Object
        eve = (From c In contex.parametros Where c.id_parametro = id).Single()
        Return eve
    End Function

    Function parametroForname(name As String)
        Dim eve As Object
        eve = (From c In contex.parametros Where c.param_nombre = name Select c.param_valor).Single()
        Return eve
    End Function
    Public Sub UpdateParametro(id As Integer, mm As usuarios)
        Dim para As Object
        para = (From c In contex.parametros Where c.id_parametro = id).Single()
        para = mm
        contex.SaveChanges()
        contex.AcceptAllChanges()
    End Sub

End Class


