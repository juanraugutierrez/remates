Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.IO


Public Class frm_recepV
    Dim reso As New resolucion
    Public dt As New DataSet
    Public dts As New DataSet
    Dim oNodoImage As Xml.XmlNode
    Dim fotos As DataSet
    Dim imagetextb As Object
    Dim oDom As New Xml.XmlDocument
    Dim norm As Integer


    Dim codig, optre As String
    Dim copias As Integer = 0
    Dim cargas, lista As DataSet
    Dim dr, dr1 As DataRow
    Dim precio As Double
    Dim descripcion As String
    Dim uni As Integer
    Dim ft As New System.Drawing.Text.PrivateFontCollection
    Dim tfon As Font
    Dim prff As FontFamily
    Dim prtSettings = New PrinterSettings

    Public elegio As New DataTable

    Public conn As New OleDbConnection()
    Public commad As New OleDbCommand
    Public datada As New OleDbDataAdapter
    Public resu As OleDbDataReader

    Dim destino As String
    Dim mandante As String
    Dim cartula As String
    Dim rol As String
    Dim cuaderno As String
    Dim tomo As String
    Dim recepctor As String
    Dim tipo_vehi As String
    Dim marca As String
    Dim patente As String
    Dim modelo As String
    Dim año As String
    Dim nromoto As String
    Dim nrochasis As String
    Dim color As String
    Dim combustible As String
    Dim pbv As String
    Dim percirc As Integer
    Dim vencpercirc As Date
    Dim revtec As Integer
    Dim vencrevtec As Date
    Dim seg As Integer
    Dim venseg As Date
    Dim compseg As String
    Dim cerdom As Integer
    Dim estado As String
    Dim dueño_ante As String
    Dim rutdueant As String
    Dim fecadqu As Date
    Dim repertorio As String
    Dim numrep As String
    Dim kilometraje As String
    Dim valor_comercial As String
    Dim preciominimo As String
    Dim valoradjc As String
    Dim adjudicado As String
    Dim idremates As Integer
    Dim idfact As Integer
    Dim idliqui As Integer

    Dim numremate As Integer
    Dim fecremate As Date
    Dim cod_kozak_lote As String
    Dim usuario As String
    Dim tipo As String
    Dim llaves As Integer
    Dim bateria As Integer
    Dim radio As Integer
    Dim tag As Integer
    Dim extintor As Integer
    Dim farolesdelantero As Integer
    Dim farolestraseros As Integer
    Dim llavederuedas As Integer
    Dim neumatico As Integer
    Dim cinturondeseg As Integer
    Dim ruedarepuesto As Integer
    Dim placapatente As Integer
    Dim mascara As Integer
    Dim capot As Integer
    Dim asientos As Integer
    Dim tapaben As Integer
    Dim tapaderueda As Integer
    Dim gata As Integer
    Dim computador As Integer
    Dim tapmaleta As Integer
    Dim parachoquetrasero As Integer
    Dim parachoquedelantero As Integer
    Dim tipoimagen As String
    Dim idingresos As Integer
    Dim index As Integer



    Private Sub conFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).Enabled = True
        DirectCast(sender, TextBox).BackColor = Drawing.Color.Yellow
        If DirectCast(sender, TextBox).Enabled = vbFalse Then
            DirectCast(sender, TextBox).Enabled = True
        End If
    End Sub
    Private Sub sinFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Drawing.Color.White
    End Sub


    Private Sub frm_recepV_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        reso.ajustarResolucion(Me)
        Me.WindowState = FormWindowState.Maximized
        For Each c As Object In Me.GroupBox3.Controls
            If c.GetType Is GetType(TextBox) Then
                AddHandler DirectCast(c, TextBox).GotFocus, AddressOf conFoco
                AddHandler DirectCast(c, TextBox).LostFocus, AddressOf sinFoco
            End If
        Next

        For Each c As Object In Me.GroupBox6.Controls
            If c.GetType Is GetType(TextBox) Then
                AddHandler DirectCast(c, TextBox).GotFocus, AddressOf conFoco
                AddHandler DirectCast(c, TextBox).LostFocus, AddressOf sinFoco
            End If
        Next

        For Each c As Object In Me.Grp_judicial.Controls
            If c.GetType Is GetType(TextBox) Then
                AddHandler DirectCast(c, TextBox).GotFocus, AddressOf conFoco
                AddHandler DirectCast(c, TextBox).LostFocus, AddressOf sinFoco
            End If
        Next

        For Each c As Object In Me.Grp_seguro.Controls
            If c.GetType Is GetType(TextBox) Then
                AddHandler DirectCast(c, TextBox).GotFocus, AddressOf conFoco
                AddHandler DirectCast(c, TextBox).LostFocus, AddressOf sinFoco
            End If
        Next


        Me.CmB_tipo.ValueMember = dts.Tables(0).Columns(0).ToString()
        Me.CmB_tipo.DisplayMember = dts.Tables(0).Columns(0).ToString()



        Me.CmB_mandante.DataSource = dts.Tables("mandante")
        Me.CmB_mandante.ValueMember = dts.Tables("mandante").Columns(3).ToString
        Me.CmB_mandante.DisplayMember = dts.Tables("mandante").Columns(3).ToString

        norm = 1

        Timeve.Start()
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Btn_cargar.Click

        If Rdb_imapp.Checked = True Then
            tipoimagen = "patente"
            Rdb_imapp.ForeColor = Drawing.Color.CadetBlue
        ElseIf Me.Rdb_imaliz.Checked = True Then
            tipoimagen = "lizquierda"
            Rdb_imaliz.ForeColor = Drawing.Color.CadetBlue
        ElseIf Me.Rdb_imald.Checked = True Then
            tipoimagen = "lderecha"
            Rdb_imald.ForeColor = Drawing.Color.CadetBlue
        ElseIf Me.Rdb_imavi.Checked = True Then
            tipoimagen = "vinterior"
            Rdb_imavi.ForeColor = Drawing.Color.CadetBlue
        ElseIf Me.Rdb_imavm.Checked = True Then
            tipoimagen = "vmotor"
            Rdb_imavm.ForeColor = Drawing.Color.CadetBlue
        ElseIf Me.Rdb_imavp.Checked = True Then
            tipoimagen = "vposterior"
            Rdb_imavp.ForeColor = Drawing.Color.CadetBlue
        ElseIf Me.Rdb_imavf.Checked = True Then
            tipoimagen = "vfrontal"
            Rdb_imavf.ForeColor = Drawing.Color.CadetBlue
        Else
            MsgBox("Debe eligir una opcion de vista para cargar una imagen")
            Rdb_imapp.Focus()
            Exit Sub
        End If

        Dim filename As String
        Dim openfiler As New OpenFileDialog
        'Definiendo propiedades al openfiledialog
        Me.Chck_ltras.Checked = False
        With openfiler
            'directorio inicial
            .InitialDirectory = "C:\"
            'archivos que se pueden abrir
            .Filter = "Archivos de imágen(*.jpg)|*.jpg|All Files (*.*)|*.*"
            'indice del archivo de lectura por defecto
            .FilterIndex = 1
            'restaurar el directorio al cerrar el dialogo
            .RestoreDirectory = True
        End With
        'Evalua si el usuario hace click en el boton abrir
        If openfiler.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Obteniendo la ruta completa del archivo xml
            filename = openfiler.FileName
            Me.PictureBox1.Image = Image.FromFile(filename)
            Me.PictureBox1.Image = redimensiona(Me.PictureBox1.Image, Me.Txt_patente.Text)
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        MsgBox("La imagen aun no esta en la BBDD debe ejecutar el procedimiento", MsgBoxStyle.Information, "Imagenes")
        Btn_subir.Font = New Font(Btn_subir.Font, FontStyle.Bold)
        Btn_subir.Focus()

    End Sub






    Private Sub Dtgr_Vingresados_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        'index = e.RowIndex
        'idingresos = CInt(Dtgr_Vingresados.Item(0, e.RowIndex).Value())
        'Me.txt_marca.Text = Dtgr_Vingresados.Item(1, e.RowIndex).Value()
        'Me.txt_modelo.Text = Dtgr_Vingresados.Item(2, e.RowIndex).Value()
        'Me.txt_tipo.Text = Dtgr_Vingresados.Item(3, e.RowIndex).Value()
        'Me.txt_fecha.Text = Dtgr_Vingresados.Item(14, e.RowIndex).Value().ToString.Substring(1, 10)
        'Dtgr_Vingresados.Rows(e.RowIndex).Selected = True
        'Me.txt_imarca.Focus()
    End Sub



    Private Sub txt_imarca_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_imarca.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Select Case sender.name
                Case Is = "txt_imarca"
                    marca = Me.txt_imarca.Text
                Case Is = "txt_imodelo"
                    modelo = txt_imodelo.Text
                Case Is = "txt_tipo"
                    'tipo = Me.txt_tipo.Text
            End Select
            SendKeys.Send("{TAB}")
        End If
    End Sub



    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs)
        'imprime(Me.Lbl_codigo.Text, 1)
    End Sub
    Sub imprime(ByVal codigo As String, ByVal copias As Integer)
        Dim pgt As New System.Drawing.Printing.PageSettings
        Dim prDoc As New PrintDocument
        Dim prtPrev As New PrintPreviewDialog
        Dim ps As New System.Drawing.Printing.PaperSize("etiqueta", 196, 118)
        pgt.PaperSize = ps
        pgt.Margins.Top = 0
        pgt.Margins.Bottom = 0
        pgt.Margins.Left = 0
        pgt.Margins.Right = 0
        prDoc.DefaultPageSettings.PaperSize = pgt.PaperSize
        prDoc.DefaultPageSettings.Margins = pgt.Margins
        prDoc.PrinterSettings.PrinterName = optre
        AddHandler prDoc.PrintPage, AddressOf print_PrintPage
        codig = barcodec(codigo)

        For u As Integer = 1 To copias
            prDoc.Print()
        Next
        'prtPrev.Document = prDoc
        'prtPrev.ShowDialog()
    End Sub
    Function barcodec(ByVal texto As String) As String
        barcodec = String.Format("*{0}*", texto)
    End Function

    Public Sub print_PrintPage(ByVal sender As Object, _
                               ByVal e As PrintPageEventArgs)
        ' Este evento se producirá cada vez que se imprima una nueva página


        ' imprimimos la cadena en el margen izquierdo
        Dim i As Integer = 1
        ' La fuente a usar

        'ft.AddFontFile("C:\desarrollo\vtaoutletvb\ventadirecta\ventadirecta\fuentes\c39hrp48dhtt.TTF")
        'prff = ft.Families(0)
        'tfon = New Font(prff, 45)
        tfon = New System.Drawing.Font("C39HrP48DhTt", 45)

        'Dim prFont As New Font(tfon, 45, FontStyle.Regular)
        Dim prFont1 As New Font("Calabri", 8, FontStyle.Regular)
        Dim prFont2 As New Font("Calabri", 8, FontStyle.Bold)
        'Dim desc As String
        'Dim largo As Integer

        'If descripcion.Length > 20 Then
        'desc = descripcion.Substring(0, 20)
        'Else
        'largo = descripcion.Length
        'desc = descripcion
        'End If





        ' imprimimos la cadena
        e.Graphics.DrawString(codig, tfon, Brushes.Black, 12, 16)


        e.Graphics.DrawString(DateTime.Now.ToShortDateString(), New Font("Arial", 5, FontStyle.Bold), Brushes.Black, 23, 2)
        'e.Graphics.DrawString("REMATES KOZAK", New Font("Arial", 7, FontStyle.Bold), Brushes.Black, 60, 2)
        'e.Graphics.DrawString(usuario, New Font("Arial", 6, FontStyle.Regular), Brushes.Black, 2, 5)
        e.Graphics.DrawString(Mid(Me.txt_imarca.Text & "-" & Me.txt_imodelo.Text, 1, 21), New Font("Arial", 6, FontStyle.Bold), Brushes.Black, 65, 3)
        'e.Graphics.DrawString("Valor", New Font("Arial", 6, FontStyle.Bold), Brushes.Black, 60, 64)
        'e.Graphics.DrawString(precio.ToString("$ #,##0"), New Font("Arial", 22, FontStyle.Bold), Brushes.Black, 10, 74)
        e.Graphics.DrawString("Patente : " & Me.Txt_patente.Text, New Font("Arial", 7, FontStyle.Bold), Brushes.Black, 24, 82)
        e.HasMorePages = False


    End Sub




    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_combustible.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_color.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_vim.TextChanged

    End Sub
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Btn_subir.Click
        Dim codigo As String
        Dim Timagen As String

        'If Not (String.IsNullOrEmpty(Me.PictureBox1.Image.Size.ToString)) Then
        '    Me.PictureBox1.Refresh()
        '    oNodoImage = Serialization.ImageToXMLNode(PictureBox1.Image)
        '    Timagen = oNodoImage.OuterXml
        '    codigo = Me.Lbl_codigo.Text
        '    bd.cargaimagen(Me.Lbl_codigo.Text, Timagen, tipoimagen)
        '    Me.PictureBox1.Refresh()
        'End If
        MsgBox("Imagen Cargada", MsgBoxStyle.DefaultButton1, "Carga de Imagenes")
        Me.Btn_subir.Font = New Font(Me.Font, FontStyle.Regular)

    End Sub

    Private Sub Timeve_Tick(sender As System.Object, e As System.EventArgs) Handles Timeve.Tick
        For Each c As Object In Me.GroupBox3.Controls
            If c.GetType Is GetType(TextBox) Then
                If String.IsNullOrEmpty(c.text) Then GoTo salida
            End If
        Next
        If String.IsNullOrEmpty(Txt_rman.Text) Then GoTo salida
        If String.IsNullOrEmpty(Txt_pminimo.Text) Then GoTo salida
        If String.IsNullOrEmpty(Txt_Vcomercial.Text) Then GoTo salida
        'If String.IsNullOrEmpty(txt_marca.Text) Then GoTo salida

        If Rdb_judicial.Checked Then
            If String.IsNullOrEmpty(Txt_causa.Text) Then GoTo salida
            If String.IsNullOrEmpty(Txt_caratula.Text) Then GoTo salida
            If String.IsNullOrEmpty(Txt_rol.Text) Then GoTo salida
        End If
        If RdB_seguro.Checked Then
            If String.IsNullOrEmpty(Txt_siniestro.Text) Then GoTo salida
            If String.IsNullOrEmpty(Txt_Poliza.Text) Then GoTo salida
        End If

        'If Me.Lbl_codigo.Text.Length > 5 Then
        '    Me.Btn_modificar.Enabled = True
        '    Me.Btn_eliminar.Enabled = True
        '    Me.Timeve.Stop()
        '    Exit Sub
        'End If

        If Not (Me.Chk_segatec.Checked) Then
            Me.Txt_Aseg.Text = "Sin informacion"
            Me.Txt_Poliza.Text = "Sin informacion"
            Me.Dtp_venpoliza.Enabled = False
            Me.Dtp_venpoliza.Visible = False
        Else
            Me.Dtp_venpoliza.Enabled = True
            Me.Dtp_venpoliza.Visible = True
        End If




        Btn_grabar.Enabled = True
        Exit Sub

salida:
        Btn_grabar.Enabled = False

    End Sub

    Private Sub Btn_grabar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_grabar.Click
        'Me.Panel1.Enabled = True
        'Me.Lbl_codigo.Text = regveh(Me)
        'Me.Btn_cargar.Enabled = True
        'Me.Rdb_imapp.Checked = True

        'If index <> 0 Or Not (String.IsNullOrEmpty(index)) Then
        '    bd.ingreveR(index)
        '    Me.Dtgr_Vingresados.Rows.Remove(Me.Dtgr_Vingresados.Rows(index))
        'End If


        'For Each c As Object In Me.GroupBox3.Controls
        '    If c.GetType Is GetType(TextBox) Then
        '        c.enabled = False
        '    End If
        'Next
        'Txt_rman.Enabled = False
        'Txt_pminimo.Enabled = False
        'Txt_Vcomercial.Enabled = False
        'txt_marca.Enabled = False

        Rdb_judicial.Enabled = False
        Txt_causa.Enabled = False
        Txt_caratula.Enabled = False
        Txt_rol.Enabled = False

        RdB_seguro.Enabled = False
        Txt_siniestro.Enabled = False
        Txt_Poliza.Enabled = False



        Me.Btn_modificar.Enabled = True
        Me.Btn_eliminar.Enabled = True
        Me.Timeve.Stop()


        Me.Chk_segatec.Enabled = False
        Me.Txt_Aseg.Enabled = False
        Me.Txt_Poliza.Enabled = False
        Me.Dtp_venpoliza.Enabled = False
        Me.Dtp_venpoliza.Visible = False

        Me.Dtp_venpoliza.Enabled = False
        Me.Dtp_venpoliza.Visible = False






    End Sub



    Private Sub CmB_mandante_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmB_mandante.SelectedIndexChanged
        'If norm <> 0 Then
        '    Me.Txt_rman.Text = bd.mandantes(Me.CmB_mandante.SelectedValue.ToString)
        'End If
    End Sub

    Private Sub Txt_pminimo_GotFocus(sender As Object, e As System.EventArgs) Handles Txt_pminimo.GotFocus
        Txt_pminimo.Text = String.Empty
    End Sub

    Private Sub Txt_Vcomercial_GotFocus(sender As Object, e As System.EventArgs) Handles Txt_Vcomercial.GotFocus
        Txt_Vcomercial.Text = String.Empty
    End Sub

    Private Sub Txt_pminimo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_pminimo.KeyPress, Txt_Vcomercial.KeyPress, Txt_kilo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If String.IsNullOrEmpty(Txt_pminimo.Text) Then Txt_pminimo.Text = 0
            Txt_pminimo.Text = Format(CLng(Txt_pminimo.Text.Replace("$", "")), "$ #,##0")
            If String.IsNullOrEmpty(Txt_Vcomercial.Text) Then Exit Sub
            Txt_Vcomercial.Text = Format(CLng(Txt_Vcomercial.Text.Replace("$", "")), "$ #,##0")
            If String.IsNullOrEmpty(Txt_kilo.Text) Then Exit Sub
            Txt_kilo.Text = Format(CLng(Txt_kilo.Text.Replace("$", "")), " #,##0")
        End If

    End Sub


    Private Sub Rdb_judicial_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rdb_judicial.CheckedChanged
        If Rdb_judicial.Checked Then
            Me.Grp_judicial.Visible = True
            Me.Grp_seguro.Visible = False
            Me.Txt_rol.Focus()
        ElseIf Rdb_judicial.Checked Then
            Me.Grp_judicial.Visible = False
            Me.RdB_seguro.Focus()
        End If
    End Sub

    Private Sub RdB_seguro_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdB_seguro.CheckedChanged
        If RdB_seguro.Checked Then
            Me.Grp_seguro.Visible = True
            Me.Grp_judicial.Visible = False
            Me.Txt_siniestro.Focus()
        ElseIf RdB_seguro.Checked Then
            Me.Grp_seguro.Visible = False
            Me.RdB_voluntario.Focus()
        End If


    End Sub

    Private Sub RdB_voluntario_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdB_voluntario.CheckedChanged, RdB_otro.CheckedChanged
        If RdB_voluntario.Checked Or RdB_otro.Checked Then
            Me.Grp_seguro.Visible = False
            Me.Grp_judicial.Visible = False
        End If


    End Sub

    Private Sub Chk_segatec_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Chk_segatec.CheckedChanged
        If Not (Chk_segatec.Checked) Then
            Me.Txt_Aseg.Text = "Sin informacion"
            Me.Txt_Poliza.Text = "Sin informacion"
            Me.Dtp_venpoliza.Visible = False
            Me.Dtp_venpoliza.Enabled = False
        Else
            Me.Dtp_venpoliza.Visible = True
            Me.Dtp_venpoliza.Enabled = True
            Me.Txt_Aseg.Text = String.Empty
            Me.Txt_Poliza.Text = String.Empty
        End If
    End Sub


    Private Sub Chk_revtec_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Chk_revtec.CheckedChanged

    End Sub

    Private Sub Grp_judicial_Enter(sender As System.Object, e As System.EventArgs) Handles Grp_judicial.Enter

    End Sub


    Function regveh(ByVal f As Object) As String

        Dim vfecha As Date
        Dim vdestino As String
        Dim vmandante As String
        Dim vcaratula As String
        Dim vrolcausa As String
        Dim vcuaderno As String
        Dim vtomo As String
        Dim vreceptor As String
        Dim vtipove As String
        Dim vmarca As String
        Dim vpatente As String
        Dim vmodelo As String
        Dim vaño As String
        Dim vnromotor As String
        Dim vnrochasis As String
        Dim vcolor As String
        Dim vcombustible As String
        Dim vpbv As String
        Dim vpercir As String
        Dim vvepercir As Date
        Dim vrevtec As String
        Dim vvrevtec As Date
        Dim vseguro As String
        Dim vvseguro As Date
        Dim vpoliza As String
        Dim vsegcompa As String
        Dim vcerdom As String
        Dim vestado As String
        Dim vdueant As String
        Dim vrutduean As String
        Dim vfeadqduean As String
        Dim vreper As String
        Dim vnumrep As String
        Dim vlimdom As String
        Dim vkilometraje As String
        Dim vvalorcomer As String
        Dim vprecio_minimo As String
        Dim vvaloradj As String
        Dim vAdjudicado As String
        Dim vid_adju As String
        Dim vidfact As String
        Dim vidliqui As String
        Dim vnumremate As String
        Dim vfecremate As Date
        Dim vcod_kozak_lote As String
        Dim vusuario As String
        Dim vllavescon As Integer
        Dim vbateria As Integer
        Dim vradio As Integer
        Dim vtag As Integer
        Dim vextintor As Integer
        Dim vfdeltan As Integer
        Dim vftraser As Integer
        Dim vllrueda As Integer
        Dim vneumatico As Integer
        Dim vcinseg As Integer
        Dim vrueresp As Integer
        Dim vplapat As Integer
        Dim vmasca As Integer
        Dim vcapot As Integer
        Dim vasientos As Integer
        Dim vtapben As Integer
        Dim vtaprue As Integer
        Dim vgata As Integer
        Dim vcompu As Integer
        Dim vtapmal As Integer
        Dim vparachquetra As Integer
        Dim vparachoqd As Integer


        Dim discr As String



        commad.CommandType = CommandType.StoredProcedure
        commad.CommandText = "cargavebo"
        commad.Parameters.Clear()
        vfecha = Now

        commad.Parameters.AddWithValue("fecha", vfecha)
        'VE_DESTINO
        If Rdb_judicial.Checked Then
            vdestino = "Judicial"
            discr = "Judicial".Substring(0, 2)
        ElseIf RdB_seguro.Checked Then
            vdestino = "Seguro"
            discr = "Seguro".Substring(0, 2)
        ElseIf RdB_voluntario.Checked Then
            vdestino = "Voluntario"
            discr = "Voluntario".Substring(0, 2)
        Else
            vdestino = "Otro"
            discr = "Otro".Substring(0, 2)
        End If

        commad.Parameters.AddWithValue("destino", vdestino)
        'VE_MANDANTE
        vmandante = CmB_mandante.SelectedValue.ToString
        commad.Parameters.AddWithValue("mandante", vmandante)

        'VE_CARATULA
        If Me.Rdb_judicial.Checked Then

            vcaratula = Txt_caratula.Text
            vrolcausa = Txt_rol.Text & "-" & Txt_causa.Text
            vcuaderno = Txt_cuaderno.Text
            vtomo = Txt_tomo.Text
            vreceptor = String.Empty
        Else
            vcaratula = String.Empty
            vrolcausa = String.Empty
            vcuaderno = String.Empty
            vtomo = String.Empty
            vreceptor = String.Empty
        End If

        commad.Parameters.AddWithValue("caratula", vcaratula)
        commad.Parameters.AddWithValue("rolcausa", vrolcausa)
        commad.Parameters.AddWithValue("cuaderno", vcuaderno)
        commad.Parameters.AddWithValue("tomo", vtomo)
        commad.Parameters.AddWithValue("receptor", vreceptor)

        'VE_TIPOVE
        vtipove = CmB_tipo.SelectedValue.ToString
        vmarca = txt_imarca.Text
        vpatente = Me.Txt_patente.Text
        vmodelo = txt_imodelo.Text
        vaño = años.Value
        vnromotor = Txt_nmotor.Text

        commad.Parameters.AddWithValue("tipove", vtipove)
        commad.Parameters.AddWithValue("marca", vmarca)
        commad.Parameters.AddWithValue("patente", vpatente)
        commad.Parameters.AddWithValue("modelo", vmodelo)
        commad.Parameters.AddWithValue("año", vaño)
        commad.Parameters.AddWithValue("nromotor", vnromotor)

        'VE_NROCHASIS
        If String.IsNullOrEmpty(Txt_nchasis.Text) Then
            vnrochasis = Txt_vim.Text
        Else
            vnrochasis = Txt_nchasis.Text
        End If
        commad.Parameters.AddWithValue("nrochasis", vnrochasis)


        'VE_COLOR VE_COMBUSTIBLE VE_PBV
        vcolor = Me.Txt_color.Text
        vcombustible = Txt_combustible.Text
        vpbv = Txt_PBV.Text & " Kilos "
        commad.Parameters.AddWithValue("color", vcolor)
        commad.Parameters.AddWithValue("combustible", vcombustible)
        commad.Parameters.AddWithValue("pbv", vpbv)

        'VE_PERCIR VE_VEPERCIR
        If RdB_percir.Checked Then
            vpercir = "1"
            vvepercir = Dtm_percir.Value
        Else
            vpercir = "0"
            vvepercir = "01-01-1900"
        End If

        commad.Parameters.AddWithValue("percir", vpercir)
        commad.Parameters.AddWithValue("vepercir", vvepercir)


        'VE_RECTEC VE_VREVTEC 
        If Chk_revtec.Checked Then
            vrevtec = "1"
            vvrevtec = Dtm_tecn.Value
        Else
            vrevtec = "0"
            vvrevtec = "01-01-1900"
        End If
        commad.Parameters.AddWithValue("revtec", vrevtec)
        commad.Parameters.AddWithValue("vrevtec", vvrevtec)

        'VE_SEGURO VE_VSEGURO VE_POLIZA VE_SEGCOMPA
        If Chk_segatec.Checked Then
            vseguro = "1"
            vvseguro = Dtm_tecn.Value
            vpoliza = Txt_Poliza.Text
            vsegcompa = Txt_Aseg.Text
        Else
            vseguro = "0"
            vvseguro = "01-01-1900"
            vpoliza = Txt_Poliza.Text
            vsegcompa = Txt_Aseg.Text


        End If

        commad.Parameters.AddWithValue("seguro", vseguro)
        commad.Parameters.AddWithValue("vseguro", vvseguro)
        commad.Parameters.AddWithValue("poliza", vpoliza)
        commad.Parameters.AddWithValue("segcompa", vsegcompa)

        'VE_CERDOM
        If Me.Chck_certificado.Checked Then
            vcerdom = "1"
        Else
            vcerdom = "0"
        End If
        commad.Parameters.AddWithValue("cerdom", vcerdom)

        'VE_ESTADO
        If Rdb_bueno.Checked Then
            vestado = "Bueno"
        ElseIf Rdb_regular.Checked Then
            vestado = "Regular"
        ElseIf Rdb_malo.Checked Then
            vestado = "Malo"
        Else
            vestado = "SIN REVISAR"
        End If

        commad.Parameters.AddWithValue("estado", vestado)


        'VE_DUEANT VE_FEADQDUAN  [ve_feadqduean] [ve_reper]  [ve_numrep]  [ve_limdom]

        If String.IsNullOrEmpty(Me.Txt_duant.Text) Then
            vdueant = "S/N"
            vrutduean = "S/N"
            vfeadqduean = String.Empty
            vreper = "S/N"
            vnumrep = "S/N"
            vlimdom = "S/N"
        Else
            vdueant = Txt_duant.Text
            vrutduean = Txt_rutduan.Text
            vfeadqduean = DTP_adq.Value
            vreper = Txt_repertorio.Text
            vnumrep = Txt_repnum.Text
            vlimdom = txt_limdom.Text
        End If

        commad.Parameters.AddWithValue("dueant", vdueant)
        commad.Parameters.AddWithValue("rutduean", vrutduean)
        commad.Parameters.AddWithValue("feadqduean", vfeadqduean)
        commad.Parameters.AddWithValue("reper", vreper)
        commad.Parameters.AddWithValue("numrep", vnumrep)
        commad.Parameters.AddWithValue("limdom", vlimdom)



        '[ve_kilometraje]  [ve_valorcomer]  [ve_precio_minimo]                  [ve_valoradj]     [ve_Adjudicado]       [ve_idliqui]     [ve_numremate]   [ve_fecremate]  [ve_cod_kozak_lote],[ve_usuario]
        vkilometraje = CLng(Txt_kilo.Text)
        vvalorcomer = CLng(Txt_Vcomercial.Text)
        vprecio_minimo = CLng(Txt_pminimo.Text)
        vvaloradj = 0
        vAdjudicado = 0
        vid_adju = 0
        vidfact = 0
        vidliqui = 0
        vnumremate = 0
        vfecremate = CDate("01-01-1900")
        vcod_kozak_lote = "99AU000000000000"
        vusuario = String.Empty





        commad.Parameters.AddWithValue("kilometraje", vkilometraje)
        commad.Parameters.AddWithValue("valorcomer", vvalorcomer)
        commad.Parameters.AddWithValue("precio_minimo", vprecio_minimo)
        commad.Parameters.AddWithValue("valoradj", vvaloradj)
        commad.Parameters.AddWithValue("Adjudicado", vAdjudicado)
        commad.Parameters.AddWithValue("id_adju", vid_adju)
        commad.Parameters.AddWithValue("idfact", vidfact)
        commad.Parameters.AddWithValue("idliqui", vidliqui)
        commad.Parameters.AddWithValue("numremate", vnumremate)
        commad.Parameters.AddWithValue("fecremate", vfecremate)
        commad.Parameters.AddWithValue("cod_kozak_lote", vcod_kozak_lote)
        commad.Parameters.AddWithValue("usuario", vusuario)


        'vllavescon = Bv(Me.Chck_llav.Checked)
        'commad.Parameters.AddWithValue("llavescon", vllavescon)

        'vbateria = Bv(Me.Chck_bate.Checked)
        'commad.Parameters.AddWithValue("bateria", vbateria)

        'vradio = Bv(Me.Chck_radi.Checked)
        'commad.Parameters.AddWithValue("radio", vradio)

        'vtag = Bv(Me.Chck_tag.Checked)
        'commad.Parameters.AddWithValue("tag", vtag)

        'vextintor = Bv(Me.Chck_extin.Checked)
        'commad.Parameters.AddWithValue("extintor", vextintor)

        'vfdeltan = Bv(Me.Chck_fdela.Checked)
        'commad.Parameters.AddWithValue("fdeltan", vfdeltan)

        'vftraser = Bv(Me.Chck_ftrase.Checked)
        'commad.Parameters.AddWithValue("ftraser", vftraser)

        'vllrueda = Bv(Me.Chck_llarue.Checked)
        'commad.Parameters.AddWithValue("llrueda", vllrueda)

        'vneumatico = Bv(Me.Chck_neuma.Checked)
        'commad.Parameters.AddWithValue("neumatico", vneumatico)


        'vcinseg = Bv(Me.Chck_cinseg.Checked)
        'commad.Parameters.AddWithValue("cinseg", vcinseg)

        'vrueresp = Bv(Me.Chck_repu.Checked)
        'commad.Parameters.AddWithValue("rueresp", vrueresp)


        'vplapat = Bv(Me.Chck_ppate.Checked)
        'commad.Parameters.AddWithValue("plapat", vplapat)


        'vmasca = Bv(Me.Chck_masca.Checked)
        'commad.Parameters.AddWithValue("masca", vmasca)

        'vcapot = Bv(Me.Chck_capot.Checked)
        'commad.Parameters.AddWithValue("capot", vcapot)


        'vasientos = Bv(Me.Chck_asien.Checked)
        'commad.Parameters.AddWithValue("asientos", vasientos)

        'vtapben = Bv(Me.Chck_tapben.Checked)
        'commad.Parameters.AddWithValue("tapben", vtapben)

        'vtaprue = Bv(Me.Chck_taprue.Checked)
        'commad.Parameters.AddWithValue("taprue", vtaprue)

        'vgata = Bv(Me.Chck_gata.Checked)
        'commad.Parameters.AddWithValue("gata", vgata)

        'vcompu = Bv(Me.Chck_compu.Checked)
        'commad.Parameters.AddWithValue("compu", vcompu)

        'vtapmal = Bv(Me.Chck_tmale.Checked)
        'commad.Parameters.AddWithValue("tapmal", vtapmal)

        'vparachquetra = Bv(Me.Chck_paradela.Checked)
        'commad.Parameters.AddWithValue("parachquetra", vparachquetra)


        'vparachoqd = Bv(Me.Chck_paratra.Checked)
        'commad.Parameters.AddWithValue("parachoqd", vparachoqd)
        'cone()
        'commad.Connection = conn
        'commad.ExecuteNonQuery()


        commad.CommandType = CommandType.Text
        commad.CommandText = String.Empty


        commad.CommandText = "insert  into folio_ingreso(fecha_ingreso,hora_ingreso,operador,auto_marca,auto_modelo,auto_tipo,auto_inscripcion,observacion,auto_motor,auto_chasis,auto_color,auto_combustible,auto_leyenda,auto_pbv,auto_vim,auto_año,auto_km,auto_permiso,auto_seguro,auto_revision,auto_minimo)  values (" & _
                             "getdate(),getdate(),'" & usuario & "','" & txt_imarca.Text & "','" & txt_imodelo.Text & "',' ','" & Txt_patente.Text & "','"


        If Rdb_bueno.Checked Then
            commad.CommandText = commad.CommandText & String.Concat("Bueno','")
        ElseIf Rdb_regular.Checked Then
            commad.CommandText = commad.CommandText & String.Concat("Regular','")
        ElseIf Rdb_malo.Checked Then
            commad.CommandText = commad.CommandText & String.Concat("Malo','")
        End If


        'commad.CommandText = commad.CommandText & String.Concat(Me.Txt_nmotor.Text, "','", Me.Txt_nchasis.Text, "','", Me.Txt_color.Text, "','", Me.Txt_combustible.Text, "','", "ninguna", "','", Me.Txt_PBV.Text, "','", Me.Txt_vim.Text, "','", Me.años.Value, "','", Me.Txt_kilo.Text, "','", Bv(Me.RdB_percir.Checked), "','", Txt_Poliza.Text, "','", Bv(Me.Chk_revtec.Checked), "',", CLng(Me.Txt_pminimo.Text.Replace("$", "")), ")")
        'cone()
        'commad.Connection = conn
        'commad.ExecuteNonQuery()


        'commad.CommandText = String.Empty

        commad.CommandText = "update folio_ingreso set cod_kozak_lote= 10000000 + id_ingreso  where auto_inscripcion= '" & Txt_patente.Text & "' and cod_kozak_lote is null"
        cone()
        commad.Connection = conn
        commad.ExecuteNonQuery()



        commad.CommandText = String.Empty
        commad.CommandText = "update folio_ingreso set cod_kozak_lote='" & CStr(Now.Year).Substring(2, 2) & discr.ToUpper & "' + cod_kozak_lote  where auto_inscripcion= '" & Txt_patente.Text & "'"
        cone()
        commad.Connection = conn
        commad.ExecuteNonQuery()

        commad.CommandText = String.Empty
        commad.CommandText = "select top 1 cod_kozak_lote from folio_ingreso where auto_inscripcion='" & Txt_patente.Text & "'"

        cone()
        commad.Connection = conn

        resu = commad.ExecuteReader
        resu.Read()
        Dim ppaso As String

        ppaso = resu.Item(0)

        Dim commad1 As New OleDbCommand

        commad1.CommandType = CommandType.Text
        commad1.CommandText = String.Empty
        commad1.CommandText = "update vebo set ve_cod_kozak_lote='" & ppaso & "' where ve_patente='" & Txt_patente.Text & "'"
        cone()
        commad1.Connection = conn
        commad1.ExecuteNonQuery()


        regveh = ppaso
    End Function

    Sub cone()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        'conn.ConnectionString = "Provider=SQLOLEDB;Data Source=PC\SQLEXPRESS;initial catalog=remates_15-04-2013;Integrated Security=SSPI"
        'conn.ConnectionString = "Provider=SQLOLEDB;Data Source=" & My.Settings.servidor & ";initial catalog=" & My.Settings.base & ";Integrated Security=SSPI"
        conn.ConnectionString = "Provider=SQLOLEDB;Data Source=SERVIDOR\SQLKOZAK;Initial Catalog=remates;Persist Security Info=True;User ID=sa;Password=Plazos.01"

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Fallo la conexion")
        End Try
    End Sub

    Private Sub Txt_pminimo_AcceptsTabChanged(sender As System.Object, e As System.EventArgs) Handles Txt_pminimo.AcceptsTabChanged

    End Sub

    Private Sub Txt_Vcomercial_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_Vcomercial.TextChanged

    End Sub

    Private Sub Rdb_imapp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rdb_imapp.CheckedChanged

    End Sub


    Private Sub Chck_ltras_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Chck_ltras.CheckedChanged
        If Chck_ltras.Checked Then
            Dim imagenOriginal As Bitmap
            Dim imagenRedimensionada As Bitmap
            Dim ff As New Font("Calabri", 12, FontStyle.Bold)
            Dim pp As New Point
            imagenOriginal = New Bitmap(Me.PictureBox1.Image)
            imagenRedimensionada = New Bitmap(352, 264)

            Using gr As Graphics = Graphics.FromImage(imagenRedimensionada)
                gr.DrawImage(imagenOriginal, 0, 0, imagenRedimensionada.Width, imagenRedimensionada.Height)
                pp.X = Math.Truncate((imagenRedimensionada.Width \ 20) * 2)
                pp.Y = Math.Truncate((imagenRedimensionada.Height \ 20) * 19)
                gr.DrawString("® REMATES KOZAK -" & Now.Year & " " & Me.Txt_patente.Text, ff, Brushes.Black, pp)

            End Using
            Me.PictureBox1.Image = imagenRedimensionada
        Else
            Dim imagenOriginal As Bitmap
            Dim imagenRedimensionada As Bitmap
            Dim ff As New Font("Calabri", 12, FontStyle.Bold)
            Dim pp As New Point
            imagenOriginal = New Bitmap(Me.PictureBox1.Image)
            imagenRedimensionada = New Bitmap(352, 264)

            Using gr As Graphics = Graphics.FromImage(imagenRedimensionada)
                gr.DrawImage(imagenOriginal, 0, 0, imagenRedimensionada.Width, imagenRedimensionada.Height)
                pp.X = Math.Truncate((imagenRedimensionada.Width \ 20) * 2)
                pp.Y = Math.Truncate((imagenRedimensionada.Height \ 20) * 19)
                gr.DrawString("® REMATES KOZAK -" & Now.Year & " " & Me.Txt_patente.Text, ff, Brushes.WhiteSmoke, pp)

            End Using
            Me.PictureBox1.Image = imagenRedimensionada
        End If

    End Sub

    Private Sub Btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_modificar.Click

    End Sub

    Private Sub Btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_eliminar.Click

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub GroupBox8_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox8.Enter

    End Sub

    Private Sub Txt_pminimo_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_pminimo.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs)

    End Sub
End Class