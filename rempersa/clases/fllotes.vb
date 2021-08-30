Public Class fllotes

    Public contex As New persaEntities11

    Private Property var As System.Linq.IQueryable(Of persaEntities11)
    Private Property quer As System.Linq.IQueryable
    Public lista As List(Of flotes)
    Dim para As New parametro

    Public neto As Long
    Public iva As Long
    Public ila As Long

    Public comision As Long
    Public cargo As Long
    Public total As Long
    Public otros As Long
    Public unidades As Integer
    Public nfacturas As Integer
    Public nlotes As Integer
    Public garantias As Long

    Sub toma(d As String, remate As Integer, afecto As Boolean, ila As Boolean)
        lista = New List(Of flotes)
        neto = 0
        iva = 0
        comision = 0
        cargo = 0
        total = 0
        otros = 0
        unidades = 0
        nfacturas = 0
        nlotes = 0
        garantias = 0

        If String.IsNullOrEmpty(d) Then
            Exit Sub
        End If
        lista = New List(Of flotes)
        Dim t = listaloteo(d, remate, afecto, ila)

        Dim p As Integer = 0
        Dim nr_lotef As Integer = 1

        For Each l As lotes In t
            If p >= 10 Then
                p = 0
                nr_lotef += 1
            Else
                p += 1
            End If

            Dim ll As New flotes
            ll.id_lote = l.id_lote
            ll.id_remate = l.id_remate
            ll.nro_lote = l.nro_lote
            ll.sub_lote = l.sub_lote
            ll.descripcion = l.descripcion
            ll.nro_unidades = l.nro_unidades
            ll.adjudicatario = l.adjudicatario
            ll.observaciones = l.observaciones
            ll.papel = l.papel
            ll.precio_minimo = l.precio_minimo
            ll.facturado = l.facturado
            ll.desistido = l.desistido
            ll.liquidado = l.liquidado
            ll.id_ejecutivo = l.id_ejecutivo
            ll.nro_unidades_final = l.nro_unidades_final
            ll.precio_unitario_final = l.precio_unitario_final
            ll.precio_final = l.precio_final
            ll.afecto = l.afecto
            ll.ila = l.ila
            ll.valor_comercial = l.valor_comercial
            ll.mandante = l.mandante
            ll.garantia = l.garantia
            ll.sucursal = l.sucursal
            ll.nlote_factura = nr_lotef
            lista.Add(ll)
        Next

        lista.OrderBy(Function(x) x.nlote_factura)
        calcula(afecto)
    End Sub




    Public Sub calcula(afecto As Boolean)
        neto = 0
        iva = 0
        ila = 0
        comision = 0
        cargo = 0
        total = 0
        otros = 0
        unidades = 0
        nfacturas = 0
        nlotes = 0
        garantias = 0


        For Each t In lista

            If Not (t.desistido) Then
                neto += t.precio_final
                unidades += t.nro_unidades_final
                nlotes += 1
                If t.ila Then
                    ila += Math.Ceiling((t.precio_final) * (20.5 / 100))
                End If
            Else
                Me.cargo += Math.Ceiling(t.precio_final * 0.3)
            End If
            garantias += t.garantia
        Next
        comision = Math.Ceiling(neto * (CDbl(para.parametroForname("comision") / 1000)))

        Me.nlotes = nlotes

        Me.nfacturas = Math.Ceiling(nlotes / 20)
        cargo += (nfacturas * CInt(para.parametroForname("cargo")))



        If afecto Then
            iva = Math.Ceiling((neto + comision + cargo) * (19 / 100))
        Else
            iva = Math.Ceiling((comision + cargo) * (19 / 100))

        End If
        total = neto + iva + cargo + comision + ila

        If (Me.nlotes Mod 20) = 0 Then
            Me.nfacturas = Int(Me.nlotes / 20)
        Else
            Me.nfacturas = Int(Me.nlotes / 20) + 1

        End If

    End Sub



    Public Sub calcula(afecto As Boolean, nro As Integer)
        Me.neto = 0
        Me.iva = 0
        Me.comision = 0
        Me.cargo = 0
        Me.total = 0
        Me.otros = 0
        Me.unidades = 0
        Me.nfacturas = 0
        Me.nlotes = 0
        Me.garantias = 0

        For Each t In lista

            If t.nlote_factura = nro And Not (t.desistido) Then
                Me.neto += t.precio_final
                Me.unidades += t.nro_unidades_final
                nlotes += 1
                garantias += t.garantia
            ElseIf t.nlote_factura = nro And t.desistido Then
                Me.cargo += Math.Ceiling(t.precio_final * 0.3)
                garantias += t.garantia
            End If

        Next
        Me.comision = Math.Ceiling(Me.neto * (CDbl(para.parametroForname("comision") / 1000)))
        Me.cargo += CInt(para.parametroForname("cargo"))
        'nfacturas = Math.Ceiling(nlotes / 8)
        If afecto Then
            Me.iva = Math.Ceiling((Me.neto + Me.comision + Me.cargo) * (19 / 100))
        Else
            Me.iva = Math.Ceiling((Me.comision + Me.cargo) * (19 / 100))
        End If
        Me.total = Me.neto + Me.iva + Me.cargo + Me.comision
        If Me.nlotes \ 20 = Math.Ceiling(Me.nlotes / 20) Then
            Me.nfacturas = Me.nlotes \ 20
        Else
            Me.nfacturas = (Me.nlotes \ 20) + 1

        End If



    End Sub

    Sub desiste(idl As Integer)

        Dim lot As Object
        lot = (From c In contex.lotes Where c.id_lote = idl).Single()
        lot.desistido = Not (lot.desistido)
        contex.SaveChanges()
        contex.AcceptAllChanges()

    End Sub



    Public Function listaloteo(adjudicatario As String, remate As Integer, afecto As Boolean, ila As Boolean) As IQueryable
        quer = From c In contex.lotes Where c.adjudicatario = adjudicatario And c.id_remate = remate And c.afecto = afecto And c.facturado = False And c.ila = ila Select c
        Return quer
    End Function


    Public Function sublista(nro As Integer) As List(Of flotes)
        Dim ff As New List(Of flotes)
        For Each l In Me.lista
            If Not (l.desistido) Then
                If l.nlote_factura = nro Then
                    Dim ll As New flotes
                    ll.id_lote = l.id_lote
                    ll.id_remate = l.id_remate
                    ll.nro_lote = l.nro_lote
                    ll.sub_lote = l.sub_lote
                    ll.descripcion = l.descripcion
                    ll.nro_unidades = l.nro_unidades
                    ll.adjudicatario = l.adjudicatario
                    ll.observaciones = l.observaciones
                    ll.papel = l.papel
                    ll.precio_minimo = l.precio_minimo
                    ll.facturado = l.facturado
                    ll.desistido = l.desistido
                    ll.liquidado = l.liquidado
                    ll.id_ejecutivo = l.id_ejecutivo
                    ll.nro_unidades_final = l.nro_unidades_final
                    ll.precio_unitario_final = l.precio_unitario_final
                    ll.precio_final = l.precio_final
                    ll.afecto = l.afecto
                    ll.ila = l.ila
                    ll.valor_comercial = l.valor_comercial
                    ll.mandante = l.mandante
                    ll.garantia = l.garantia
                    ll.sucursal = l.sucursal
                    ll.nlote_factura = nro
                    ff.Add(ll)
                End If
            End If
        Next
        Return ff
    End Function

    Function llevalotes(d As String, remate As Integer, afecto As Boolean, ila As Boolean) As List(Of lotes)
        Dim L As New List(Of lotes)
        L = (From lo In contex.lotes Where lo.id_remate = remate And lo.adjudicatario = d And lo.afecto = afecto And lo.facturado = 0 And lo.ila = ila Select lo).ToList()
        Return L
    End Function


End Class
