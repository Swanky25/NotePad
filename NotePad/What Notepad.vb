Public Class frmWhatNotepad

    Private Sub btnGotIt_Click(sender As Object, e As EventArgs) Handles btnGotIt.Click
        Me.Close()
    End Sub

    Private Sub frmWhatNotepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.ShowIcon = False
    End Sub
End Class