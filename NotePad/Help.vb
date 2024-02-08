Public Class frmHelp

    Private callWhatIsNotepad As New frmWhatNotepad
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Help and Support"
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ShowIcon = False
        LinkClick.Hide()
        Label6.Hide()
    End Sub

    Private Sub linkWhatIsTheNotepad_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkWhatIsTheNotepad.LinkClicked

        callWhatIsNotepad.ShowDialog()
    End Sub

    Private Sub LinkHowToOpenTheNotepad_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkHowToOpenTheNotepad.LinkClicked
        LinkClick.Show()
        Label6.Show()
    End Sub

    Private Sub LinkClick_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkClick.LinkClicked
        Dim callForm1 As New Form1
        callForm1.ShowDialog()
    End Sub

    Private Sub LinkHowToFont_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkHowToFont.LinkClicked
        'CALL THE FORM FRMTHEFONT
        Dim callFont As New frmTheFont
        callFont.ShowDialog()
    End Sub

    Private Sub LinkHowToCutCopyPaste_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkHowToCutCopyPaste.LinkClicked
        Dim callCutCopyPaste As New frmCutCopyPaste
        callCutCopyPaste.ShowDialog()
    End Sub

    Private Sub LinkTimeDate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkTimeDate.LinkClicked
        Dim callDateTime As New frmdateTime
        callDateTime.ShowDialog()
    End Sub
End Class