
Option Strict On

Imports System.IO

Public Class frmTextEditor

    Dim saved As Boolean = True
    Dim openedFile As String = Nothing

    Private Sub tmiNew_Click(sender As Object, e As EventArgs) Handles tmiNew.Click
        Dim save = PromptSave()
        If Not save = Nothing Then
            If save Then
                If openedFile = Nothing Then
                    SaveFile()
                Else
                    WriteToFile(openedFile)
                End If
            End If
            txtContent.Text = ""
            openedFile = Nothing
        End If
    End Sub

    Private Sub tmiOpen_Click(sender As Object, e As EventArgs) Handles tmiOpen.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                ' Opens a reader (C++: ifstream)
                Dim reader As New StreamReader(OpenFileDialog1.FileName)
                ' Display the reader
                txtContent.Text() = reader.ReadToEnd()
                ' Close the stream to allow other files to access the file
                reader.Close()
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
            openedFile = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub tmiSave_Click(sender As Object, e As EventArgs) Handles tmiSave.Click
        If openedFile IsNot Nothing Then
            WriteToFile(openedFile)
        Else
            SaveFile()
            openedFile = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub tmiSaveAs_Click(sender As Object, e As EventArgs) Handles tmiSaveAs.Click
        SaveFile()
        openedFile = SaveFileDialog1.FileName
    End Sub

    Private Sub tmiClose_Click(sender As Object, e As EventArgs) Handles tmiClose.Click
        Dim save = PromptSave()
        If Not save = Nothing Then
            If save Then
                If openedFile = Nothing Then
                    SaveFile()
                Else
                    WriteToFile(openedFile)
                End If
            End If
            txtContent.Text = ""
            openedFile = Nothing
        End If
    End Sub

    Private Sub tmiExit_Click(sender As Object, e As EventArgs) Handles tmiExit.Click
        Dim save = PromptSave()
        If Not save = Nothing Then
            If save Then
                If openedFile = Nothing Then
                    SaveFile()
                Else
                    WriteToFile(openedFile)
                End If
            End If
            Close()
        End If
    End Sub

    Private Sub tmiCut_Click(sender As Object, e As EventArgs) Handles tmiCut.Click
        ' Save selected text to clipboard
        My.Computer.Clipboard.SetText(txtContent.SelectedText)

        ' Erase selected text
        txtContent.SelectedText = String.Empty
    End Sub

    Private Sub tmiCopy_Click(sender As Object, e As EventArgs) Handles tmiCopy.Click
        ' Save selected text to clipboard
        My.Computer.Clipboard.SetText(txtContent.SelectedText)
    End Sub

    Private Sub tmiPaste_Click(sender As Object, e As EventArgs) Handles tmiPaste.Click
        ' Paste clipboard text
        txtContent.SelectedText = My.Computer.Clipboard.GetText()
    End Sub

    Private Sub tmiAbout_Click(sender As Object, e As EventArgs) Handles tmiAbout.Click
        Dim popup As MsgBoxResult = MsgBox("NETD-2202 Lab 5 - Text Editor By: E. Heath", MsgBoxStyle.OkOnly, "About")
    End Sub

    Private Sub txtContent_TextChanged(sender As Object, e As EventArgs) Handles txtContent.TextChanged
        saved = False
    End Sub

    Public Function PromptSave() As Boolean
        ' Check if the file is already saved
        If saved Then
            Return False
        Else
            ' Ask the user if they want to save the file
            Dim result As MsgBoxResult = MsgBox("Would you like to save the currently open file?", MsgBoxStyle.YesNoCancel, "Save File?")
            If result = MsgBoxResult.Yes Then
                Return True
            ElseIf result = MsgBoxResult.No Then
                Return False
            Else
                Return Nothing
            End If
        End If
    End Function

    Public Sub SaveFile()
        ' Set a filter to find a file that is a txt file
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            WriteToFile(SaveFileDialog1.FileName)
        End If
    End Sub

    Public Sub WriteToFile(ByVal file As String)
        Try
            ' Write the text to the file
            My.Computer.FileSystem.WriteAllText(file, txtContent.Text(), False)
        Catch exc As Exception
            Console.WriteLine(exc.ToString())
        End Try
    End Sub
End Class
