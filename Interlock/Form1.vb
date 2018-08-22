Public Class Form1
    Private Sub closeAllWindows(_frm As Form)
        For Each frm As Form In Me.MdiChildren
            If (_frm.Name <> frm.Name) Then
                frm.Dispose()
                frm.Close()
            End If
        Next

    End Sub
    Private Sub activateForm(_frm As Form)
        _frm.MdiParent = Me
        _frm.Dock = DockStyle.Fill
        _frm.Show()
    End Sub
    Private Sub EngineTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EngineTypeToolStripMenuItem.Click
        Dim abc As New Form2()
        Me.activateForm(abc)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolStripStatusLabel1.Text = "Hello : Admin"
        Me.ToolStripStatusLabel2.Text = DateTime.Now.ToLongDateString()
    End Sub
End Class
