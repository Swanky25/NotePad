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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class