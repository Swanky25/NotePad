
Imports System.IO
Public Class Form1
    'GLOBAL VARIABLES
    Private saveFile As New Windows.Forms.SaveFileDialog
    'Private openFile As New Windows.Forms.OpenFileDialog
    Private PrintFile As New Windows.Forms.PrintDialog

    'FORMS ACTIONS
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = True
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Me.StartPosition = FormStartPosition.CenterScreen
        RichTextBox1.BackColor = Color.Aqua
        RichTextBox1.ForeColor = Color.Black
    End Sub

    'OPEN FILE 
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            'MAKE A DEFAULT DIRECTORY
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop

            'FILTER files as type .txt, .doc,.xls,.ppt
            OpenFileDialog1.Filter = "Text Documents|*.txt|Web Documents|*.html|CSS|*.css|All Files|*.*"

            OpenFileDialog1.Title = "WISDOM NOTEPAD IS OPENING..."
            If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                'READ FILE
                RichTextBox1.Text = File.ReadAllText(OpenFileDialog1.FileName)

            End If
            ' OpenFileDialog1.ShowDialog()
           
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    'SAVE DIALOG
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            'IF RichTextBox1 CONTAINS ITEMS 
            If RichTextBox1.Text.Length > 0 And RichTextBox1.Text <> "" Then


                'FILTER files as type .txt, .doc,.xls,.py
                saveFile.Filter = "Text Documents|*.txt|Web Documents|*.html|CSS|*.css| Python| *.py|All Files|*.*"

                saveFile.Title = "WISDOM-NOTEPAD SAVE TO..."
                saveFile.ShowDialog()



                'CREATE A SAVE FILE
                File.WriteAllText(saveFile.FileName, RichTextBox1.Text)
                Me.Text = saveFile.FileName.ToString & " - " & "WISDOM NOTEPAD"
            Else
                MsgBox("Content of wisdom-notepad is empty" & Environment.NewLine & "Therefore can't activate save dialog")
            End If
        Catch ex As Exception
            MsgBox("WISDOM NOTEPAD " & Environment.NewLine & ex.Message())
        End Try
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

    'CUT OFF SELECTED TEXT IN RICH_TEXT_BOX
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        If RichTextBox1.Text.Length > 0 Then
            RichTextBox1.Cut()
        Else
            MsgBox("Nothing is there to cut")
        End If

    End Sub

    'PASTE TEXT THAT HAS BEEN SAVE IN MEMORY
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click

        Try
            RichTextBox1.Paste()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private fontStyle As New Windows.Forms.FontDialog
    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        fontStyle.ShowDialog()
        RichTextBox1.Font = fontStyle.Font
    End Sub

    Private addColor As New Windows.Forms.ColorDialog
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        addColor.ShowDialog()
        RichTextBox1.ForeColor = addColor.Color
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Try
            RichTextBox1.Copy()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    'SELECT TEXT IN RICH_TEXT_BOX
    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectToolStripMenuItem.Click
        'IF SOMETHING IS REALLY TYPED INTO THE TEXT FILE
        If RichTextBox1.Text.Length > 0 Then
            RichTextBox1.SelectAll()
        Else
            MsgBox("Nothing is there to select!")
        End If
    End Sub

    Private Sub DateTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateTimeToolStripMenuItem.Click
        Dim sysTimeDate As Date
        sysTimeDate = Now
        RichTextBox1.AppendText(sysTimeDate)
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If RichTextBox1.Text.Length > 0 Then
            Try
                PrintFile.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        Else
            MsgBox("Content of wisdom-notepad is empty" & Environment.NewLine & "Therefore can't activate print dialog")
        End If

    End Sub

    'ABOUT WISDOM_NOTEPAD
    Private Sub AboutNotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutNotepadToolStripMenuItem.Click
        'USE THE DECLARED VARIABLE AS AN INSTANCE TO CALL THE FORM 
        Dim callAbout As New frmAbout
        callAbout.ShowDialog()
    End Sub

    'UNDO PREVIOUS ACTIONS MADE 
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        Try
            RichTextBox1.Undo()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    'REPEAT ACTIONS MADE EARLIER
    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        Dim HelpForm As New frmHelp

        If ViewHelpToolStripMenuItem.Checked Then
            ViewHelpToolStripMenuItem.Checked = False
        Else
            ViewHelpToolStripMenuItem.Checked = True
            HelpForm.ShowDialog()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim newFile As New Form1
        newFile.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        If (OpenFileDialog1.FileName <> Nothing Or OpenFileDialog1.FileName <> "") Then
            Me.Text = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1, (OpenFileDialog1.FileName.IndexOf(".", 0) - (OpenFileDialog1.FileName.LastIndexOf("\") + 1))) & " - " & "WISDOM NOTEPAD"
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
