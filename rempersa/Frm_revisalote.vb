Public Class Frm_revisalote

    Private Sub Frm_revisalote_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        Dim root = New TreeNode("Revison de Lotes")
        Trvlotes.Nodes.Add(root)
        Trvlotes.Nodes(0).Nodes.Add("Loteo")
        Trvlotes.Nodes(0).Nodes.Add("Adjudicacion")
        Trvlotes.Nodes(0).Nodes.Add("Garantia")
        Trvlotes.Nodes(0).Nodes.Add("Facturacion")
        Trvlotes.Nodes(0).Nodes.Add("Liquidacion")


    End Sub
End Class