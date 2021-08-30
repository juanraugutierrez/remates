Public Class Frm_adjudcatario
    Dim rema As New Remate
    Dim factu As New factura
    Dim llote As New loteo
    Dim lotess As lotes
    Dim remaelegido As remates_mercaderia

    Dim activo As List(Of lotes)
    Dim indice As Integer = 0

    Private Shared frmInstance As Frm_adjudcatario = Nothing


    Public Shared Function Instance() As Form
        If frmInstance Is Nothing OrElse frmInstance.IsDisposed = True Then
            frmInstance = New Frm_adjudcatario
        End If
        frmInstance.BringToFront()
        Return frmInstance
    End Function

    Private Sub Frm_adjudcatario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.GroupBox2.Visible = False
        chKVerTotales.Checked = False
        Dtgadjudicatarios.Visible = False
        carga()
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width / 2 - 500
        y = Screen.PrimaryScreen.WorkingArea.Height / 2 - 300
        Me.Location = New Point(x, y)

    End Sub
    Sub carga()
        Me.Cmb_remates.DataSource = rema.listaremates
        Me.Cmb_remates.DisplayMember = "codigo_remate"
        Me.Cmb_remates.ValueMember = "fecha_remate"
    End Sub


    Private Sub Cmb_remates_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_remates.SelectedIndexChanged
        Try
            remaelegido = Nothing
            remaelegido = New remates_mercaderia
            remaelegido = Cmb_remates.SelectedItem
            Try
                activo = llote.loteForID(remaelegido.id_remate)
                Me.Lbl_fecharema.Text = "Fecha de Remate :" & factu.fremates(remaelegido.codigo_remate)
                Me.Lbl_tiporema.Text = factu.tremates(remaelegido.id_remate)
                Me.Lbl_nrolotes.Text = remaelegido.numero_lotes
                Me.GroupBox2.Visible = True

                If activo.Count() <= 0 Then
                    MsgBox("No hay lotes para este Remate", MsgBoxStyle.Critical, "Adjudicatario")
                    Exit Sub
                End If
            Catch ex As Exception

            End Try
            Try
                paso()



                indice = 0
            Catch ex As Exception

            End Try
            Try
                If indice < 0 Then
                    indice += 1
                End If
                mostrar(indice)


            Catch ex As Exception

            End Try
            'Button2_Click(Me, e)

        Catch ex As Exception

        End Try

    End Sub
    Sub paso()
        Try
            Dtgadjudicatarios.DataSource = Nothing
            Dim lista As IList = (From l In contex.lotes Where l.id_remate = remaelegido.id_remate And l.adjudicatario <> Nothing And l.adjudicatario <> "Sin Postor" And l.precio_final > 0 Order By l.nro_lote Descending Select l).ToList()

            Dim lista2 As Object =
                (From l In lista Group By l.adjudicatario Into g = Group
                 Order By g.Sum(Function(i) i.precio_final) Descending
                 Select New With {.Adjudicatario = adjudicatario, .Cuenta = g.Count(), .Total = g.Sum(Function(i) i.precio_final)}).Distinct.ToList


            Dtgadjudicatarios.DataSource = lista2
            Dtgadjudicatarios.Refresh()
            Dtgadjudicatarios.RowHeadersVisible = False


            Dtgadjudicatarios.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dtgadjudicatarios.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dtgadjudicatarios.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Dtgadjudicatarios.DefaultCellStyle.Font = New Font("arial narrow", 8)

            Dim ancho As Integer
            ancho = Me.Dtgadjudicatarios.Width

            With Me.Dtgadjudicatarios
                .Columns(0).Width = ancho * 0.5
                .Columns(1).Width = ancho * 0.22
                .Columns(2).Width = ancho * 0.22

                .Columns(1).DefaultCellStyle.Format = "#,##0"
                .Columns(2).DefaultCellStyle.Format = "$ #,##0"
            End With

        Catch ex As Exception
            MsgBox(String.Concat(ex.InnerException, vbCrLf, ex.Message), MsgBoxStyle.Critical, "  ")
        End Try
    End Sub
    Sub mostrar(indice As Integer)
        Try
            Lbl_lotem.Text = String.Empty
            Lbl_descripcion.Text = String.Empty
            Txt_unidades.Text = String.Empty
            Txt_punitario.Text = String.Empty
            Txt_total.Text = String.Empty
            Txt_adjudicatario.Text = String.Empty

            Lbl_lotem.Text = activo(indice).nro_lote & " " & activo(indice).sub_lote
            Lbl_descripcion.Text = activo(indice).descripcion
            Txt_unidades.Text = activo(indice).nro_unidades
            Txt_unidadesfinales.Text = activo(indice).nro_unidades_final
            Txt_punitario.Text = activo(indice).precio_unitario_final
            Txt_total.Text = activo(indice).precio_final
            Txt_adjudicatario.Text = activo(indice).adjudicatario.ToString()
            Me.Refresh()


            Me.Lst_adjudicatarios.DataSource = Nothing
            Me.Lst_adjudicatarios.Refresh()

        Catch ex As Exception
            For Each c As Control In Me.GroupBox1.Controls
                If TypeOf (c) Is TextBox Then
                    c.Text = String.Empty
                End If
            Next



        End Try

    End Sub

    Private Sub Btn_grabar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_grabar.Click

        Try
            If String.IsNullOrEmpty(Txt_adjudicatario.Text) Then
                MsgBox("Debe ingresar un adjudicatario", MsgBoxStyle.Critical, "Adjudicatario")
                Exit Sub
            End If
            If String.IsNullOrEmpty(Txt_unidades.Text) Then
                MsgBox("Debe ingresar al menos una unidad", MsgBoxStyle.Critical, "Adjudicatario")
                Exit Sub
            End If
            If String.IsNullOrEmpty(Txt_punitario.Text) Then
                MsgBox("Debe ingresar al un precio", MsgBoxStyle.Critical, "Adjudicatario")
                Exit Sub
            End If
            lotess = activo(indice)

            lotess.precio_final = CLng(Txt_total.Text)
            lotess.precio_unitario_final = CLng(Txt_punitario.Text)
            lotess.nro_unidades = CInt(Txt_unidades.Text)
            lotess.nro_unidades_final = CInt(Txt_unidadesfinales.Text)
            lotess.adjudicatario = Txt_adjudicatario.Text.ToUpper

            llote.UpdateloteID(lotess.id_lote, remaelegido.id_remate, lotess)

            Me.Cursor = Cursors.WaitCursor
            For Each c As Control In Me.GroupBox3.Controls
                If TypeOf (c) Is TextBox Then
                    c.Text = String.Empty
                End If
            Next
            Me.Refresh()

            mostrar(indice)
            paso()
            Me.Refresh()

            Me.Cursor = Cursors.Default
            'MsgBox("Cambio Ejecutado", MsgBoxStyle.Critical, "Adjudicatario")

            indice += 1
            If indice > activo.Count - 1 Then indice = 0

            mostrar(indice)

        Catch ex As Exception

        End Try

        Me.Lst_adjudicatarios.DataSource = Nothing
        Me.Lst_adjudicatarios.Refresh()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Btn_buscar.Click

        Dim results As List(Of lotes)
        Try
            results = activo.FindAll(Function(column) CInt(column.nro_lote) = CInt(Txt_buscar.Text))
            indice = 0
            For Each t In activo
                If CInt(t.nro_lote) = CInt(Txt_buscar.Text) Then
                    Exit For
                End If
                indice += 1
            Next
            Lbl_lotem.Text = activo(indice).nro_lote
            Lbl_descripcion.Text = activo(indice).descripcion
            Txt_unidades.Text = activo(indice).nro_unidades
            Txt_punitario.Text = activo(indice).precio_unitario_final
            Txt_total.Text = activo(indice).precio_final
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Txt_punitario_GotFocus(sender As Object, e As System.EventArgs) Handles Txt_punitario.GotFocus
        Me.Txt_punitario.Text = String.Empty
    End Sub

    Private Sub Txt_punitario_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_punitario.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Try
                activo(indice).precio_unitario_final = CInt(Txt_punitario.Text)
                If IsNothing(Txt_unidadesfinales.Text) Or CLng(Txt_unidadesfinales.Text) = 0 Then
                    Txt_unidadesfinales.Text = Txt_unidades.Text
                    activo(indice).nro_unidades_final = CInt(Txt_unidades.Text)
                    Txt_total.Text = CLng(Txt_unidades.Text) * CLng(Txt_punitario.Text)

                Else
                    Txt_total.Text = CLng(Txt_unidadesfinales.Text) * CLng(Txt_punitario.Text)
                End If
                activo(indice).nro_unidades_final = CLng(Txt_unidadesfinales.Text)
                activo(indice).nro_unidades = CLng(Txt_unidades.Text)
                activo(indice).precio_final = CLng(Txt_total.Text)
                activo(indice).precio_unitario_final = CLng(Txt_punitario.Text)


                activo(indice).precio_final = CLng(activo(indice).precio_unitario_final) * CLng(activo(indice).nro_unidades_final)

                'Txt_unidades.Text = activo(indice).nro_unidades_final
                'Txt_punitario.Text = activo(indice).precio_unitario_final
                'Txt_total.Text = activo(indice).precio_final
                Me.Cursor = Cursors.WaitCursor
                For Each c As Control In Me.GroupBox3.Controls
                    If TypeOf (c) Is TextBox Then
                        c.Text = String.Empty
                    End If
                Next


                mostrar(indice)

                Me.Cursor = Cursors.Default


            Catch ex As Exception
                MsgBox("Hubo en error al cargar los datos del adjudicatario, revise  y corrija", MsgBoxStyle.Critical, "Adjudicatarios")

                activo(indice).precio_unitario_final = 0
                activo(indice).precio_final = 0
                activo(indice).nro_unidades = 0

                Txt_unidades.Text = activo(indice).nro_unidades_final
                Txt_punitario.Text = activo(indice).precio_unitario_final
                Txt_total.Text = activo(indice).precio_final


            End Try




        End If

    End Sub

    Private Sub Txt_unidades_GotFocus(sender As Object, e As System.EventArgs) Handles Txt_unidades.GotFocus
        Me.Txt_unidades.Text = String.Empty
    End Sub

    Private Sub Txt_unidades_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_unidades.KeyPress

        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) Then
            e.Handled = True
        End If


        If e.KeyChar = ChrW(Keys.Return) Then
            Try
                lotess.nro_unidades_final = CInt(Txt_unidades.Text)
                lotess.precio_final = lotess.precio_unitario_final * lotess.nro_unidades_final

                Txt_unidades.Text = lotess.nro_unidades
                Txt_unidadesfinales.Text = lotess.nro_unidades_final
                Txt_punitario.Text = lotess.precio_unitario_final
                Txt_total.Text = lotess.precio_final

            Catch ex As Exception
                MsgBox("Hubo en error al cargar los datos del adjudicatario, revise  y corrija", MsgBoxStyle.Critical, "Adjudicatarios")

                lotess.precio_unitario_final = 0
                lotess.precio_final = 0
                lotess.nro_unidades = 0

                Txt_unidades.Text = lotess.nro_unidades
                Txt_unidadesfinales.Text = lotess.nro_unidades_final
                Txt_punitario.Text = lotess.precio_unitario_final
                Txt_total.Text = lotess.precio_final


            End Try




        End If

    End Sub

    Private Sub Txt_total_GotFocus(sender As Object, e As System.EventArgs) Handles Txt_total.GotFocus
        Me.Txt_total.Text = String.Empty
    End Sub

    Private Sub Txt_total_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_total.KeyPress

        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Try
                lotess.precio_final = CInt(Txt_total.Text)
                lotess.nro_unidades_final = CInt(Txt_unidades.Text)
                lotess.precio_unitario_final = lotess.precio_final / lotess.nro_unidades_final
                Txt_unidades.Text = lotess.nro_unidades
                Txt_punitario.Text = lotess.precio_unitario_final
                Txt_total.Text = lotess.precio_final

            Catch ex As Exception
                MsgBox("Hubo en error al cargar los datos del adjudicatario, revise  y corrija" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Adjudicatarios")

                lotess.precio_unitario_final = 0
                lotess.precio_final = 0
                lotess.nro_unidades = 0

                Txt_unidades.Text = lotess.nro_unidades
                Txt_punitario.Text = lotess.precio_unitario_final
                Txt_total.Text = lotess.precio_final


            End Try




        End If

    End Sub

    Private Sub Txt_adjudicatario_GotFocus(sender As Object, e As System.EventArgs) Handles Txt_adjudicatario.GotFocus
        Me.Txt_adjudicatario.Text = String.Empty
    End Sub

    Private Sub Txt_unidadesfinales_GotFocus(sender As Object, e As System.EventArgs) Handles Txt_unidadesfinales.GotFocus
        Me.Txt_unidadesfinales.Text = String.Empty
    End Sub

    Private Sub Txt_adjudicatario_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_adjudicatario.KeyPress

        'buscar

        Me.Lst_adjudicatarios.DataSource = Nothing
        Me.Lst_adjudicatarios.DataSource = llote.listaloteAdju(remaelegido.id_remate, Txt_adjudicatario.Text)
        Me.Lst_adjudicatarios.DisplayMember = "adjudicatario"
        Me.Lst_adjudicatarios.Refresh()



    End Sub








    Private Sub Lst_adjudicatarios_Click(sender As Object, e As System.EventArgs) Handles Lst_adjudicatarios.Click
        Txt_adjudicatario.Text = Lst_adjudicatarios.SelectedItem
        Btn_grabar.Focus()
    End Sub

    Private Sub Txt_unidades_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_unidades.TextChanged

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Btn_sinpostor.Click
        Me.Txt_adjudicatario.Text = "Sin Postor"

        activo(indice).precio_final = 0
        activo(indice).precio_unitario_final = 0
        activo(indice).nro_unidades_final = 0
        activo(indice).adjudicatario = "Sin Postor"

        lotess = activo(indice)

        llote.UpdateloteID(lotess.id_lote, remaelegido.id_remate, lotess)

        indice += 1
        If indice > activo.Count - 1 Then indice = 0

        mostrar(indice)


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        indice += 1
        If indice > activo.Count - 1 Then indice = 0
        mostrar(indice)

        Me.Lst_adjudicatarios.DataSource = Nothing
        Me.Lst_adjudicatarios.Refresh()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        indice -= 1
        If indice < 0 Then indice = activo.Count - 1
        mostrar(indice)



        Me.Lst_adjudicatarios.DataSource = Nothing
        Me.Lst_adjudicatarios.Refresh()
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dtgadjudicatarios.DataSource = Nothing
        Dtgadjudicatarios.DataSource = (From l In contex.lotes Where l.id_remate = remaelegido.id_remate Group By l.adjudicatario
                  Into g = Group
                                        Order By g.Count Descending
                                        Select New With {.adjudicatario = adjudicatario, .cuenta = g.Count(Function(i) i.adjudicatario), .total = g.Sum(Function(i) i.precio_final)}).Distinct.ToList()
        Dtgadjudicatarios.RowHeadersVisible = False

        Dtgadjudicatarios.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Dtgadjudicatarios.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Dtgadjudicatarios.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Dtgadjudicatarios.DefaultCellStyle.Font = New Font("arial narrow", 8)

    End Sub



    Private Sub Txt_unidadesfinales_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_unidadesfinales.KeyPress

        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Try
                activo(indice).precio_unitario_final = CInt(Txt_unidadesfinales.Text)
                If IsNothing(Txt_punitario.Text) Or CLng(Txt_punitario.Text) = 0 Then
                    Txt_punitario.Focus()
                Else
                    Txt_total.Text = CLng(Txt_unidadesfinales.Text) * CLng(Txt_punitario.Text)
                End If
                activo(indice).nro_unidades_final = CLng(Txt_unidadesfinales.Text)
                activo(indice).nro_unidades = CLng(Txt_unidades.Text)
                activo(indice).precio_final = CLng(Txt_total.Text)
                activo(indice).precio_unitario_final = CLng(Txt_punitario.Text)


                activo(indice).precio_final = CLng(activo(indice).precio_unitario_final) * CLng(activo(indice).nro_unidades_final)

                'Txt_unidades.Text = activo(indice).nro_unidades_final
                'Txt_punitario.Text = activo(indice).precio_unitario_final
                'Txt_total.Text = activo(indice).precio_final
                Me.Cursor = Cursors.WaitCursor
                For Each c As Control In Me.GroupBox3.Controls
                    If TypeOf (c) Is TextBox Then
                        c.Text = String.Empty
                    End If
                Next


                mostrar(indice)

                Me.Cursor = Cursors.Default


            Catch ex As Exception
                MsgBox("Hubo en error al cargar los datos del adjudicatario, revise  y corrija", MsgBoxStyle.Critical, "Adjudicatarios")

                activo(indice).precio_unitario_final = 0
                activo(indice).precio_final = 0
                activo(indice).nro_unidades = 0

                Txt_unidades.Text = activo(indice).nro_unidades_final
                Txt_punitario.Text = activo(indice).precio_unitario_final
                Txt_total.Text = activo(indice).precio_final


            End Try




        End If

    End Sub

    Private Sub chKVerTotales_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chKVerTotales.CheckedChanged
        Dtgadjudicatarios.Visible = chKVerTotales.Checked
    End Sub
End Class