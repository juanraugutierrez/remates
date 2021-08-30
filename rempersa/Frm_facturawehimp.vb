Imports Microsoft.Reporting.WinForms

Public Class Frm_facturawehimp
    Dim reso As New resolucion
    Dim rema As New Remate
    Dim factu As New factura
    Dim para As New parametro
    Public contex As New persaEntities11
    Dim usecli As New cliente
    Dim remate As Integer
    Public cli As New clientes
    Dim comuna As New ocomuna

    Dim neto As Long
    Dim iva As Long
    Dim comision As Long
    Dim vcomision As Double
    Dim cargo As Long
    Dim total As Long
    Dim garantia As Long
    Dim liquido As Long
    Public id_clien As Integer
    Public id_comuna As Integer
    Dim valor As Integer
    Dim colCheck As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
    Dim cliente As String

    Dim llot As List(Of lotes)

    Private Sub Frm_facturaimp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        reso.ajustarResolucion(Me)
        Try
            Me.WindowState = FormWindowState.Maximized
            carga()
            cliente = String.Empty
            valor = CInt(para.parametroForname("cargo"))
            vcomision = CDbl(para.parametroForname("comision")) / 1000
        Catch ex As Exception

        End Try
    End Sub

    Sub carga()

        Me.Cmb_leyenda.Items.Add("Rematado a la vista para circular")
        Me.Cmb_leyenda.Items.Add("Rematado a la vista para Desarme")

        Cmb_leyenda.SelectedIndex = 0
        Cmb_leyenda.Refresh()

        Me.Cmb_remates.DataSource = rema.listaremates("V")
        Me.Cmb_remates.DisplayMember = "codigo_remate"
        Me.Cmb_remates.ValueMember = "id_remate"

        Me.Lst_clientes.DataSource = factu.listaclientes(remate, Chk_afecto.Checked, False)
        Me.Lst_clientes.DisplayMember = "adjudicatario"
        'Me.Cmb_cliente.ValueMember = "Cliente"


        Me.Chk_afecto.Checked = False


        Me.Cmb_pago.DataSource = factu.tipospagos()
        Me.Cmb_pago.DisplayMember = "descripcion_pago"
        Me.Cmb_pago.ValueMember = "id_tipopago"
    End Sub




    Private Sub Cmb_remates_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_remates.SelectedIndexChanged
        Dim remaelegido As New remates_mercaderia
        remaelegido = Cmb_remates.SelectedItem
        Me.Lbl_fecharema.Text = "F. Rmte.:" & factu.fremates(remaelegido.codigo_remate)
        Me.Lbl_tiporema.Text = factu.tremates(remaelegido.id_remate)
        remate = remaelegido.id_remate



        Me.Lst_clientes.ClearSelected()
        Me.Lst_clientes.DataSource = Nothing
        Me.Lst_clientes.Refresh()


        Me.Lst_clientes.DataSource = factu.listaclientes(remate, Chk_afecto.Checked, False)
        Me.Lst_clientes.DisplayMember = "adjudicatario"


    End Sub

    Private Sub Lst_clientes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Lst_clientes.SelectedIndexChanged
        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next

        Try
            Dim lista As New Object
            cliente = Lst_clientes.SelectedValue

            Me.Dtg_lotes.DataSource = Nothing
            Try
                Me.Dtg_lotes.Columns.Remove("Desitido")
            Catch ex As Exception

            End Try


            llot = factu.lotfacturables1(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)
            Me.Dtg_lotes.DataSource = factu.lotfacturables(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)
            Me.Dtg_lotes.RowHeadersVisible = False

            For Each t In Me.Dtg_lotes.Columns
                t.visible = False
            Next

            neto = 0
            For Each t In llot
                neto += t.precio_final
                garantia += t.garantia
            Next


            neto = 0

            If Chk_comision.Checked Then
                comision = Math.Ceiling(neto * (CDbl(para.parametroForname("comision") / 1000)))
            Else
                comision = 0
            End If

            If Chk_cargos.Checked Then
                valor = para.parametroForname("cargo")
            Else
                valor = 0
            End If



            If factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) Mod 10 > 0 Then
                cargo = valor * ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10) + 1)
                Txt_nrodefacturas.Text = ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10) + 1)
            Else
                cargo = valor * ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10))
                Txt_nrodefacturas.Text = ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10))
            End If

            If Chk_afecto.Checked Then
                iva = Math.Ceiling((neto + comision + cargo) * 0.19)
            Else
                iva = Math.Ceiling((comision + cargo) * 0.19)
            End If


            total = (neto + comision + cargo) + iva
            garantia = factu.lotfacturgarantiad(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)
            liquido = total - garantia

            Dim ancho As Integer
            ancho = Me.Dtg_lotes.Width
            Me.Dtg_lotes.Columns(2).Visible = True
            Me.Dtg_lotes.Columns(3).Visible = True
            Me.Dtg_lotes.Columns(4).Visible = True
            Me.Dtg_lotes.Columns(14).Visible = True
            Me.Dtg_lotes.Columns(15).Visible = True
            Me.Dtg_lotes.Columns(16).Visible = True
            Me.Dtg_lotes.Columns(21).Visible = True


            Try
                colCheck.Name = "Desitido"
                Me.Dtg_lotes.Columns.Add(colCheck)
            Catch ex As Exception

            End Try





            With Me.Dtg_lotes
                .Columns(2).DisplayIndex = 0
                .Columns(3).DisplayIndex = 1
                .Columns(4).DisplayIndex = 2
                .Columns(14).DisplayIndex = 3
                .Columns(15).DisplayIndex = 4
                .Columns(16).DisplayIndex = 5
                .Columns(21).DisplayIndex = 6


                .Columns(15).DefaultCellStyle.Format = "$ #,##0"
                .Columns(16).DefaultCellStyle.Format = "$ #,##0"
                .Columns(21).DefaultCellStyle.Format = "$ #,##0"

                .Columns(14).DefaultCellStyle.Format = "#,##0"

                .Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



                .Columns(2).Width = ancho * 0.08
                .Columns(3).Width = ancho * 0.08
                .Columns(4).Width = ancho * 0.38
                .Columns(14).Width = ancho * 0.089
                .Columns(15).Width = ancho * 0.089
                .Columns(16).Width = ancho * 0.1
                .Columns(21).Width = ancho * 0.1



                .Columns(2).HeaderText = "N° Lote"
                .Columns(3).HeaderText = "Sub Lote"
                .Columns(4).HeaderText = "Especie"
                .Columns(14).HeaderText = "Unidades"
                .Columns(15).HeaderText = "V. Unitario"
                .Columns(16).HeaderText = "V. Total"
                .Columns(21).HeaderText = "Garantia"



            End With

            'Dim chk As New DataGridViewCheckBoxColumn()

            'chk.HeaderText = "Desite"
            'chk.Name = "chk"
            'chk.TrueValue = True
            'Me.Dtg_lotes.Columns.Add(chk)


            Me.Txt_neto.TextAlign = HorizontalAlignment.Right

            Me.Txt_neto.Text = Format(neto, "$ #,##0")
            Me.Txt_iva.Text = Format(iva, "$ #,##0")
            Me.Txt_cargo.Text = Format(cargo, "$ #,##0")
            Me.Txt_comision.Text = Format(comision, "$ #,##0")
            Me.Txt_total.Text = Format(total, "$ #,##0")
            Me.Txt_garantia.Text = Format(garantia, "$ #,##0")
            Me.Txt_liquido.Text = Format(liquido, "$ #,##0")

            Me.Txt_lotes.Text = Format(factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked), "#,##0")



        Catch ex As Exception

        End Try


    End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dtg_lotes.CellValueChanged
        If e.ColumnIndex = 25 Then
            'MsgBox("Estado: " & Dtg_lotes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & vbCrLf & e.ColumnIndex)
            If Dtg_lotes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Then
                Dim idl As Integer
                idl = Dtg_lotes.Rows(e.RowIndex).Cells(0).Value
                contex.ExecuteStoreCommand("update lotes set desistido=1 where  id_lote={0}", idl)
                contex.SaveChanges()
                neto = factu.lotfacturTotald(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)


                If Chk_comision.Checked Then
                    comision = Math.Ceiling(neto * (CDbl(para.parametroForname("comision") / 1000)))
                Else
                    comision = 0
                End If

                If Chk_cargos.Checked Then
                    valor = para.parametroForname("cargo")
                Else
                    valor = 0
                End If



                If factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) Mod 10 > 0 Then
                    cargo = valor * ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10) + 1)
                    Txt_nrodefacturas.Text = ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10) + 1)
                Else
                    cargo = valor * ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10))
                    Txt_nrodefacturas.Text = ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10))
                End If

                If Chk_afecto.Checked Then
                    iva = Math.Ceiling((neto + comision + cargo) * 0.19)
                Else
                    iva = Math.Ceiling((comision + cargo) * 0.19)
                End If


                total = (neto + comision + cargo) + iva
                garantia = factu.lotfacturgarantiad(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)
                liquido = total - garantia


                Me.Txt_neto.Text = Format(neto, "$ #,##0")
                Me.Txt_iva.Text = Format(iva, "$ #,##0")
                Me.Txt_cargo.Text = Format(cargo, "$ #,##0")
                Me.Txt_comision.Text = Format(comision, "$ #,##0")
                Me.Txt_total.Text = Format(total, "$ #,##0")
                Me.Txt_garantia.Text = Format(garantia, "$ #,##0")
                Me.Txt_liquido.Text = Format(liquido, "$ #,##0")
                Me.Txt_lotes.Text = Format(factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked), "#,##0")
                Me.Refresh()

            Else
                Dim idl As Integer
                idl = Dtg_lotes.Rows(e.RowIndex).Cells(0).Value
                contex.ExecuteStoreCommand("update lotes set desistido=0 where  id_lote={0}", idl)
                contex.SaveChanges()

                neto = factu.lotfacturTotald(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)


                If Chk_comision.Checked Then
                    comision = Math.Ceiling(neto * (CDbl(para.parametroForname("comision") / 1000)))
                Else
                    comision = 0
                End If

                If Chk_cargos.Checked Then
                    valor = para.parametroForname("cargo")
                Else
                    valor = 0
                End If



                If factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) Mod 10 > 0 Then
                    cargo = valor * ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10) + 1)
                    Txt_nrodefacturas.Text = ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10) + 1)
                Else
                    cargo = valor * ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10))
                    Txt_nrodefacturas.Text = ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10))
                End If

                If Chk_afecto.Checked Then
                    iva = Math.Ceiling((neto + comision + cargo) * 0.19)
                Else
                    iva = Math.Ceiling((comision + cargo) * 0.19)
                End If


                total = (neto + comision + cargo) + iva
                garantia = factu.lotfacturgarantiad(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)
                liquido = total - garantia

                Me.Txt_neto.Text = Format(neto, "$ #,##0")
                Me.Txt_iva.Text = Format(iva, "$ #,##0")
                Me.Txt_cargo.Text = Format(cargo, "$ #,##0")
                Me.Txt_comision.Text = Format(comision, "$ #,##0")
                Me.Txt_total.Text = Format(total, "$ #,##0")
                Me.Txt_garantia.Text = Format(garantia, "$ #,##0")
                Me.Txt_liquido.Text = Format(liquido, "$ #,##0")
                Me.Txt_lotes.Text = Format(factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked), "#,##0")
                Me.Refresh()

            End If
        End If


    End Sub


    Private Sub Data_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_lotes.CurrentCellDirtyStateChanged
        If Dtg_lotes.IsCurrentCellDirty Then
            Dtg_lotes.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Btn_imprimir.Click
        If String.IsNullOrWhiteSpace(Txt_danterior.Text) And IsNothing(Cmb_leyenda.SelectedIndex) Then
            MsgBox("Debe ingresar datos del dueño anterior", MsgBoxStyle.Critical, "Error en Dueño Anterior")
            Exit Sub
        End If
        Dim estado As Boolean = False
        Dim Invoice As New List(Of EFactura)()
        Dim Detail As New List(Of EArticulo)()
        Dim idfact As Integer = 0

        Dim factur As New EFactura
        factur.Razonsocial = Txt_razonsocial.Text.ToUpper
        factur.Rut = Txt_rut.Text.ToUpper
        factur.Direccion = Txt_direccion.Text.ToUpper
        factur.Comuna = Txt_Comuna.Text.ToUpper
        factur.Giro = Txt_giro.Text

        If CInt(Txt_nrodefacturas.Text) = 1 Then
            factur.totaltexto = "SON :" & Num2Text(total).ToUpper & " PESOS"
            Try
                factur.NumeroFactura = Txt_nrofactura.Text.ToUpper
            Catch ex As Exception
                MsgBox("Debe ingresar Numero de Factura", MsgBoxStyle.Critical, "Facturacion")
                Exit Sub

            End Try

            If Not (IsNumeric(Txt_nrofactura.Text)) Then
                MsgBox("Debe ingresar Numero de Factura", MsgBoxStyle.Critical, "Facturacion")
                Exit Sub
            End If

            factur.FechaFacturacion = Now.Day & "               " & mesliteral(Now.Month) & "                                             " & Now.Year.ToString().Substring(2, 2)




            factur.Neto = CDec(Txt_neto.Text.Replace("$", "").Replace(".", ""))
            factur.Comision = CDec(Txt_comision.Text.Replace("$", "").Replace(".", ""))
            factur.Cargos = CDec(Txt_cargo.Text.Replace("$", "").Replace(".", ""))

            factur.Iva = CDec(Txt_iva.Text.Replace("$", "").Replace(".", ""))
            factur.Total = CDec(Txt_total.Text.Replace("$", "").Replace(".", ""))
            factur.Garantia = CDec(Txt_garantia.Text.Replace("$", "").Replace(".", ""))
            factur.Liquido = liquido



            Invoice.Add(factur)

            If Rdb_factura.Checked Then
                estado = True
                Dim dbfactura As New facturadb
                dbfactura.cargo = factur.Cargos
                dbfactura.Comision = 0
                dbfactura.id_comuna = id_comuna
                dbfactura.id_cliente = id_clien
                dbfactura.id_condicionespago = Cmb_pago.SelectedValue
                dbfactura.NumeroFactura = factur.NumeroFactura
                dbfactura.nlotes = CInt(Txt_lotes.Text)
                dbfactura.id_remate = remate

                dbfactura.Iva = factur.Iva
                dbfactura.Neto = factur.Neto
                dbfactura.Total = factur.Total
                dbfactura.Garantia = factur.Garantia
                dbfactura.ingreso_liquido = liquido

                dbfactura.fecha = Now

                idfact = dbfactura.cargafa()
                Dim leye As String
                leye = Txt_danterior.Text.ToUpper & vbCrLf & Cmb_leyenda.SelectedItem
                Detail = CargaArticulosv(remate, cliente, estado, Chk_afecto.Checked, idfact, leye)
            Else
                estado = False
                Detail = CargaArticulosv(remate, cliente, estado, Chk_afecto.Checked, idfact, Cmb_leyenda.SelectedValue)
            End If



            Dim nlotes As Integer
            nlotes = Detail.Count


            Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.Factura.rdlc"
            Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()


            Dim parameters(1) As ReportParameter
            parameters(0) = New ReportParameter("nlotes", nlotes)
            parameters(1) = New ReportParameter("tcomision", comision)

            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dfactura", Invoice))
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dfacturadet", Detail))
            Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters)
            Frm_muestrareportes.ReportViewer1.RefreshReport()
            Frm_muestrareportes.WindowState = FormWindowState.Maximized

            Frm_muestrareportes.Show()

            Me.Lst_clientes.DataSource = Nothing
            Me.Lst_clientes.DataSource = factu.listaclientes(remate, Chk_afecto.Checked, False)
            Me.Lst_clientes.DisplayMember = "adjudicatario"

            Me.Dtg_lotes.DataSource = Nothing
            Try
                Me.Dtg_lotes.Columns.Remove("Desitido")
            Catch ex As Exception

            End Try

            Try



                Me.Dtg_lotes.DataSource = factu.lotfacturables(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)
                Me.Dtg_lotes.RowHeadersVisible = False

                For Each t In Me.Dtg_lotes.Columns
                    t.visible = False
                Next

                neto = factu.lotfacturTotald(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)


                If Chk_comision.Checked Then
                    comision = Math.Ceiling(neto * (CDbl(para.parametroForname("comision") / 1000)))
                Else
                    comision = 0
                End If

                If Chk_cargos.Checked Then
                    valor = para.parametroForname("cargo")
                Else
                    valor = 0
                End If



                If factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) Mod 10 > 0 Then
                    cargo = valor * ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10) + 1)
                    Txt_nrodefacturas.Text = ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10) + 1)
                Else
                    cargo = valor * ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10))
                    Txt_nrodefacturas.Text = ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10))
                End If

                If Chk_afecto.Checked Then
                    iva = Math.Ceiling((neto + comision + cargo) * 0.19)
                Else
                    iva = Math.Ceiling((comision + cargo) * 0.19)
                End If


                total = (neto + comision + cargo) + iva
                garantia = factu.lotfacturgarantiad(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)
                liquido = total - garantia

                Dim ancho As Integer
                ancho = Me.Dtg_lotes.Width
                Me.Dtg_lotes.Columns(2).Visible = True
                Me.Dtg_lotes.Columns(3).Visible = True
                Me.Dtg_lotes.Columns(4).Visible = True
                Me.Dtg_lotes.Columns(14).Visible = True
                Me.Dtg_lotes.Columns(15).Visible = True
                Me.Dtg_lotes.Columns(16).Visible = True
                Me.Dtg_lotes.Columns(21).Visible = True


                Try
                    colCheck.Name = "Desitido"
                    Me.Dtg_lotes.Columns.Add(colCheck)
                Catch ex As Exception

                End Try





                With Me.Dtg_lotes
                    .Columns(2).DisplayIndex = 0
                    .Columns(3).DisplayIndex = 1
                    .Columns(4).DisplayIndex = 2
                    .Columns(14).DisplayIndex = 3
                    .Columns(15).DisplayIndex = 4
                    .Columns(16).DisplayIndex = 5
                    .Columns(21).DisplayIndex = 6


                    .Columns(15).DefaultCellStyle.Format = "$ #,##0"
                    .Columns(16).DefaultCellStyle.Format = "$ #,##0"
                    .Columns(21).DefaultCellStyle.Format = "$ #,##0"

                    .Columns(14).DefaultCellStyle.Format = "#,##0"

                    .Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



                    .Columns(2).Width = ancho * 0.08
                    .Columns(3).Width = ancho * 0.08
                    .Columns(4).Width = ancho * 0.38
                    .Columns(14).Width = ancho * 0.089
                    .Columns(15).Width = ancho * 0.089
                    .Columns(16).Width = ancho * 0.1
                    .Columns(21).Width = ancho * 0.1



                    .Columns(2).HeaderText = "N° Lote"
                    .Columns(3).HeaderText = "Sub Lote"
                    .Columns(4).HeaderText = "Especie"
                    .Columns(14).HeaderText = "Unidades"
                    .Columns(15).HeaderText = "V. Unitario"
                    .Columns(16).HeaderText = "V. Total"
                    .Columns(21).HeaderText = "Garantia"



                End With

                'Dim chk As New DataGridViewCheckBoxColumn()

                'chk.HeaderText = "Desite"
                'chk.Name = "chk"
                'chk.TrueValue = True
                'Me.Dtg_lotes.Columns.Add(chk)


                Me.Txt_neto.TextAlign = HorizontalAlignment.Right

                Me.Txt_neto.Text = Format(neto, "$ #,##0")
                Me.Txt_iva.Text = Format(iva, "$ #,##0")
                Me.Txt_cargo.Text = Format(cargo, "$ #,##0")
                Me.Txt_comision.Text = Format(comision, "$ #,##0")
                Me.Txt_total.Text = Format(total, "$ #,##0")
                Me.Txt_garantia.Text = Format(garantia, "$ #,##0")
                Me.Txt_liquido.Text = Format(liquido, "$ #,##0")

                Me.Txt_lotes.Text = Format(factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked), "#,##0")



            Catch ex As Exception

            End Try




            For Each c As Control In Me.GroupBox1.Controls
                If TypeOf (c) Is TextBox Then
                    c.Text = String.Empty
                End If
            Next
        Else

            Dim dt As New DataView


            'generadetalle()

            'calculatotalparcial()

            'imprime()

        End If


    End Sub


    Private Sub Btn_actualizar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_actualizar.Click
        Me.Lst_clientes.DataSource = Nothing
        Me.Lst_clientes.DataSource = factu.listaclientes(remate, Chk_afecto.Checked, False)
        Me.Lst_clientes.DisplayMember = "adjudicatario"


        Me.Dtg_lotes.DataSource = factu.lotfacturables(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)
        Me.Dtg_lotes.RowHeadersVisible = False

        For Each t In Me.Dtg_lotes.Columns
            t.visible = False
        Next

        neto = factu.lotfacturTotal(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)


        If Chk_comision.Checked Then
            comision = Math.Ceiling(neto * CDbl(para.parametroForname("comision") / 100))
        Else
            comision = 0
        End If

        If Chk_cargos.Checked Then
            valor = para.parametroForname("cargo")
        Else
            valor = 0
        End If

        If factu.lotfactlotes(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) Mod 10 > 0 Then
            cargo = valor * ((factu.lotfactlotes(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10) + 1)
            Txt_nrodefacturas.Text = ((factu.lotfactlotes(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10) + 1)
        Else
            cargo = valor * ((factu.lotfactlotes(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10))
            Txt_nrodefacturas.Text = ((factu.lotfactlotes(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10))
        End If
        'cargo = 500
        iva = Math.Ceiling((neto + comision + cargo) * 0.19)
        total = (neto + comision + cargo) + iva
        garantia = factu.lotfacturgarantia(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)
        liquido = total - garantia




        Dim ancho As Integer
        ancho = Me.Dtg_lotes.Width
        Me.Dtg_lotes.Columns(2).Visible = True
        Me.Dtg_lotes.Columns(3).Visible = True
        Me.Dtg_lotes.Columns(4).Visible = True
        Me.Dtg_lotes.Columns(14).Visible = True
        Me.Dtg_lotes.Columns(15).Visible = True
        Me.Dtg_lotes.Columns(16).Visible = True
        Me.Dtg_lotes.Columns(21).Visible = True





        With Me.Dtg_lotes
            .Columns(2).DisplayIndex = 0
            .Columns(3).DisplayIndex = 1
            .Columns(4).DisplayIndex = 2
            .Columns(14).DisplayIndex = 3
            .Columns(15).DisplayIndex = 4
            .Columns(16).DisplayIndex = 5
            .Columns(21).DisplayIndex = 6


            .Columns(15).DefaultCellStyle.Format = "$ #,##0"
            .Columns(16).DefaultCellStyle.Format = "$ #,##0"
            .Columns(21).DefaultCellStyle.Format = "$ #,##0"

            .Columns(14).DefaultCellStyle.Format = "#,##0"

            .Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



            .Columns(2).Width = ancho * 0.08
            .Columns(3).Width = ancho * 0.08
            .Columns(4).Width = ancho * 0.4
            .Columns(14).Width = ancho * 0.089
            .Columns(15).Width = ancho * 0.089
            .Columns(16).Width = ancho * 0.1
            .Columns(21).Width = ancho * 0.1



            .Columns(2).HeaderText = "N° Lote"
            .Columns(3).HeaderText = "Sub Lote"
            .Columns(4).HeaderText = "Especie"
            .Columns(14).HeaderText = "Unidades"
            .Columns(15).HeaderText = "V. Unitario"
            .Columns(16).HeaderText = "V. Total"
            .Columns(21).HeaderText = "Garantia"
        End With
    End Sub

    Private Sub Btn_buscaclientes_Click(sender As System.Object, e As System.EventArgs) Handles Btn_buscaclientes.Click
        Frm_clientes.Btn_asignar.Enabled = True
        Frm_clientes.Btn_asignar.Visible = True
        Frm_clientes.Btn_eliminar.Visible = False

        Frm_clientes.ShowDialog()
    End Sub

    Private Sub Btn_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_limpiar.Click
        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Frm_clientes.Btn_asignar.Enabled = True
        Frm_clientes.Btn_asignar.Visible = True
        Frm_clientes.formulario = Me

        Frm_clientes.ShowDialog()
    End Sub

    Private Sub Txt_nrofactura_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_nrofactura.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_rut__KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_rut.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) And Not (AscW(e.KeyChar) = 45) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Try
                Dim ccc As New Object

                cli = usecli.buscarclienterut(Txt_rut.Text)


                Me.Txt_razonsocial.Text = cli.razon_social.ToUpper
                Me.Txt_Comuna.Text = comuna.listacomunatext(cli.id_comuna)
                id_clien = cli.id_cliente
                Me.Txt_giro.Text = cli.giro.ToUpper
                Me.Txt_direccion.Text = cli.direccion.ToUpper
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Cliente")
                Frm_clientes.Btn_asignar.Enabled = True
                Frm_clientes.Btn_asignar.Visible = True
                Frm_clientes.formulario = Me

                Frm_clientes.ShowDialog()

            End Try
        End If




    End Sub







    Private Sub Chk_cargos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Chk_cargos.CheckedChanged, Chk_afecto.CheckedChanged, Chk_comision.CheckedChanged
        Me.Lst_clientes.DataSource = Nothing
        Me.Lst_clientes.DataSource = factu.listaclientes(remate, Chk_afecto.Checked, False)
        Me.Lst_clientes.DisplayMember = "adjudicatario"

        Me.Dtg_lotes.DataSource = Nothing
        Try
            Me.Dtg_lotes.Columns.Remove("Desitido")
        Catch ex As Exception

        End Try

        Me.Refresh()
        Me.Dtg_lotes.DataSource = factu.lotfacturables(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)


        Me.Dtg_lotes.RowHeadersVisible = False

        For Each t In Me.Dtg_lotes.Columns
            t.visible = False
        Next

        neto = factu.lotfacturTotald(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)

        If Chk_comision.Checked Then
            comision = Math.Ceiling(neto * CDbl(para.parametroForname("comision") / 1000))
        Else
            comision = 0
        End If

        If Chk_cargos.Checked Then
            valor = para.parametroForname("cargo")
        Else
            valor = 0
        End If

        If factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) Mod 10 > 0 Then
            cargo = valor * ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10) + 1)
            Txt_nrodefacturas.Text = ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10) + 1)
        Else
            cargo = valor * ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10))
            Txt_nrodefacturas.Text = ((factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked) \ 10))
        End If

        iva = Math.Ceiling((neto + comision + cargo) * 0.19)
        total = (neto + comision + cargo) + iva
        garantia = factu.lotfacturgarantiad(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)
        liquido = total - garantia


        Try
            If Dtg_lotes.RowCount > 0 Then
                Dim ancho As Integer

                colCheck.Name = "Desitido"
                Me.Dtg_lotes.Columns.Add(colCheck)




                With Me.Dtg_lotes
                    .Columns(2).DisplayIndex = 0
                    .Columns(3).DisplayIndex = 1
                    .Columns(4).DisplayIndex = 2
                    .Columns(14).DisplayIndex = 3
                    .Columns(15).DisplayIndex = 4
                    .Columns(16).DisplayIndex = 5
                    .Columns(21).DisplayIndex = 6


                    .Columns(15).DefaultCellStyle.Format = "$ #,##0"
                    .Columns(16).DefaultCellStyle.Format = "$ #,##0"
                    .Columns(21).DefaultCellStyle.Format = "$ #,##0"

                    .Columns(14).DefaultCellStyle.Format = "#,##0"

                    .Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



                    .Columns(2).Width = ancho * 0.08
                    .Columns(3).Width = ancho * 0.08
                    .Columns(4).Width = ancho * 0.38
                    .Columns(14).Width = ancho * 0.089
                    .Columns(15).Width = ancho * 0.089
                    .Columns(16).Width = ancho * 0.1
                    .Columns(21).Width = ancho * 0.1



                    .Columns(2).HeaderText = "N° Lote"
                    .Columns(3).HeaderText = "Sub Lote"
                    .Columns(4).HeaderText = "Especie"
                    .Columns(14).HeaderText = "Unidades"
                    .Columns(15).HeaderText = "V. Unitario"
                    .Columns(16).HeaderText = "V. Total"
                    .Columns(21).HeaderText = "Garantia"



                End With

                'Dim chk As New DataGridViewCheckBoxColumn()

                'chk.HeaderText = "Desite"
                'chk.Name = "chk"
                'chk.TrueValue = True
                'Me.Dtg_lotes.Columns.Add(chk)


                Me.Txt_neto.TextAlign = HorizontalAlignment.Right

                Me.Txt_neto.Text = Format(neto, "$ #,##0")
                Me.Txt_iva.Text = Format(iva, "$ #,##0")
                Me.Txt_cargo.Text = Format(cargo, "$ #,##0")
                Me.Txt_comision.Text = Format(comision, "$ #,##0")
                Me.Txt_total.Text = Format(total, "$ #,##0")
                Me.Txt_garantia.Text = Format(garantia, "$ #,##0")
                Me.Txt_liquido.Text = Format(liquido, "$ #,##0")

                Me.Txt_lotes.Text = Format(factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked), "#,##0")

            End If

        Catch ex As Exception

        End Try


        Me.Txt_lotes.Text = Format(factu.lotfactlotesd(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked), "#,##0")

    End Sub




    Private Sub Cmb_pago_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_pago.SelectedIndexChanged

    End Sub

End Class