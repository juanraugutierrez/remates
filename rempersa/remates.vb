Public Class remates
    Dim reso As New resolucion
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub



    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    Sub verifica()
        If uactivo = False Then
            End
        End If
    End Sub



    Private Sub remates_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        reso.ajustarResolucion(Me)
        Me.WindowState = FormWindowState.Maximized
        horario = My.Settings.horariofacturacion
        LoginForm1.MdiParent = Me
        LoginForm1.Show()




    End Sub

    Private Sub RematesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RematesToolStripMenuItem1.Click
        verifica()
        Frm_remates.MdiParent = Me
        Frm_remates.Show()
    End Sub

    Private Sub LoteoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoteoToolStripMenuItem.Click
        verifica()
        Frm_loteo.MdiParent = Me
        Frm_loteo.Show()
    End Sub

    Private Sub FacturacionToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles FacturacionToolStripMenuItem1.Click
        verifica()
        Frm_facturaelect.MdiParent = Me
        Frm_facturaelect.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        verifica()
        Frm_clientes.MdiParent = Me
        Frm_clientes.Show()
    End Sub

    Private Sub AdjudicatarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AdjudicatarioToolStripMenuItem.Click
        verifica()

        Dim frmHijo As Frm_adjudcatario = Frm_adjudcatario.Instance
        frmHijo.MdiParent = Me
        frmHijo.Show()


    End Sub



    Private Sub LiquidacionToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles LiquidacionToolStripMenuItem1.Click
        verifica()
        Frm_liquidacionElectre.MdiParent = Me
        Frm_liquidacionElectre.Show()
    End Sub

    Private Sub GarantiasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GarantiasToolStripMenuItem.Click
        verifica()

        Dim frmHijo As Frm_garantia = Frm_garantia.Instance
        frmHijo.MdiParent = Me
        frmHijo.Show()

    End Sub

    Private Sub FacturacionVtasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FacturacionVtasToolStripMenuItem.Click
        verifica()
        Frm_facturaVtas.MdiParent = Me
        Frm_facturaVtas.Show()
    End Sub

    Private Sub NotasDeCreditoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NotasDeCreditoToolStripMenuItem.Click
        verifica()
        Frm_notacreditoVtas.MdiParent = Me
        Frm_notacreditoVtas.Show()
    End Sub

    Private Sub NominasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NominasToolStripMenuItem.Click
        verifica()
        Frm_nominas.MdiParent = Me
        Frm_nominas.Show()

    End Sub

    Private Sub AnulacionDeFacturasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnulacionDeFacturasToolStripMenuItem.Click
        verifica()
        Frm_anula.MdiParent = Me
        Frm_anula.Show()
    End Sub

    Private Sub FacturacionDeVehiculosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FacturacionDeVehiculosToolStripMenuItem.Click
        verifica()
        Frm_facturawehimp.MdiParent = Me
        Frm_facturawehimp.Show()
    End Sub

    Private Sub MandantesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MandantesToolStripMenuItem.Click
        verifica()
        Frm_mandantes.MdiParent = Me
        Frm_mandantes.Show()
    End Sub

    Private Sub VerFacturasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerFacturasToolStripMenuItem.Click
        verifica()
        Frm_verfactura.MdiParent = Me
        Frm_verfactura.Show()
    End Sub

    Private Sub RegistroDeGarantiaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistroDeGarantiaToolStripMenuItem.Click
        verifica()
        Frm_inggarantias.MdiParent = Me
        Frm_inggarantias.Show()
    End Sub

    Private Sub MonitoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        verifica()
        'Frm_monitor.MdiParent = Me
        'Frm_monitor.Show()
    End Sub

    Private Sub AnulaLiquidacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnulaLiquidacionToolStripMenuItem.Click
        verifica()
        Frm_lanula.MdiParent = Me
        Frm_lanula.Show()
    End Sub


    Private Sub ProgramacionCamionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProgramacionCamionesToolStripMenuItem.Click
        verifica()
        'Frm_programacion.MdiParent = Me
        'Frm_programacion.Show()
    End Sub


    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        verifica()
        Frm_revisalote.MdiParent = Me
        Frm_revisalote.Show()
    End Sub

    Private Sub ParametrosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ParametrosToolStripMenuItem.Click

    End Sub

    Private Sub RegistrarEgresoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarEgresoToolStripMenuItem.Click
        Dim frmHijo As Frm_egresos = Frm_egresos.Instance
        frmHijo.MdiParent = Me
        frmHijo.Show()

    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReporteToolStripMenuItem.Click

        Dim frmHijo As Frm_reportesadhoc = Frm_reportesadhoc.Instance
        frmHijo.MdiParent = Me
        frmHijo.Show()

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs)
        'Dim frmHijo As FrmFacturaElectronica = FrmFacturaElectronica.Instance
        'frmHijo.MdiParent = Me
        'frmHijo.Show()
    End Sub

    Private Sub VerLiquidacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerLiquidacionToolStripMenuItem.Click
        Dim frmHijo As Frm_verliquidacion = Frm_verliquidacion.Instance
        frmHijo.MdiParent = Me
        frmHijo.Show()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        contex.AcceptAllChanges()
        contex.Refresh(Objects.RefreshMode.StoreWins, contex.remates_mercaderia)
    End Sub

    Private Sub PArametrosToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PArametrosToolStripMenuItem1.Click

    End Sub

    Private Sub ParametrosDeLiquidacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ParametrosDeLiquidacionToolStripMenuItem.Click

    End Sub

    Private Sub GuiasDeDespachoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuiasDeDespachoToolStripMenuItem.Click
        Dim frmHijo As Frm_guias = Frm_guias.Instance
        frmHijo.MdiParent = Me
        frmHijo.Show()
    End Sub
End Class
