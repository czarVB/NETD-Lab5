'****************************************************************
'* Name: Evan Heath
'* Date: Mar 29th, 2019
'* Program Name: NETD Lab 5 - Text Editor
'* Purpose: A generic text editor which can create, load, and save files. It can also cut, copy, and paste text for you
'****************************************************************

Option Strict On

Imports System.IO

Public Class frmTextEditor

    Dim saved As Boolean = True
    Dim openedFile As String = Nothing

    Private Sub tmiNew_Click(sender As Object, e As EventArgs) Handles tmiNew.Click
        If SaveProcedure() Then
            txtContent.Text = ""
            saved = True
            openedFile = Nothing
        End If
    End Sub

    Private Sub tmiOpen_Click(sender As Object, e As EventArgs) Handles tmiOpen.Click
        If SaveProcedure() Then
            SelectAndDisplayFile()
            saved = True
        End If
    End Sub

    Private Sub tmiSave_Click(sender As Object, e As EventArgs) Handles tmiSave.Click
        If openedFile = Nothing Then
            SelectAndSaveFile()
        Else
            SaveFile(openedFile)
        End If
    End Sub

    Private Sub tmiSaveAs_Click(sender As Object, e As EventArgs) Handles tmiSaveAs.Click
        SelectAndSaveFile()
    End Sub

    Private Sub tmiClose_Click(sender As Object, e As EventArgs) Handles tmiClose.Click
        If SaveProcedure() Then
            txtContent.Text = ""
            saved = True
            openedFile = Nothing
        End If
    End Sub

    Private Sub tmiExit_Click(sender As Object, e As EventArgs) Handles tmiExit.Click
        If SaveProcedure() Then
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

    Public Sub SelectAndDisplayFile()
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                ' Open reader
                Dim reader As New StreamReader(OpenFileDialog1.FileName)
                ' Read all data / text
                txtContent.Text = reader.ReadToEnd()
                ' Close the file
                reader.Close()
                ' Set the opened file
                openedFile = OpenFileDialog1.FileName
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End If
    End Sub

    Public Function PromptSave() As Integer
        If Not saved Then
            Dim msg As MsgBoxResult = MsgBox("Would you like to save this file?", MsgBoxStyle.YesNoCancel, "Save File?")

            If msg = MsgBoxResult.Yes Then
                Return 2
            ElseIf msg = MsgBoxResult.No Then
                Return 1
            Else
                Return 0
            End If
        Else
            Return 1
        End If
    End Function

    Public Sub SelectAndSaveFile()
        ' Set a filter to find a file that is a txt file
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            SaveFile(SaveFileDialog1.FileName)
            openedFile = SaveFileDialog1.FileName
        End If
    End Sub

    Public Sub SaveFile(ByVal file As String)
        Try
            ' Write the text to the file
            My.Computer.FileSystem.WriteAllText(file, txtContent.Text(), False)
            saved = True
        Catch exc As Exception
            Console.WriteLine(exc.ToString())
        End Try
    End Sub

    Public Function SaveProcedure() As Boolean
        Dim save As Integer = PromptSave()
        If Not save = 0 Then
            If save = 2 Then
                If openedFile = Nothing Then
                    SelectAndSaveFile()
                Else
                    SaveFile(openedFile)
                End If
            End If
            ' Return True because the user didn't select Cancel
            Return True
        End If
        ' Return False because the user cancelled the action
        Return False
    End Function

    Private Sub frmTextEditor_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        txtContent.Size = New Size(Me.Size.Width - 18, Me.Size.Width - 78)
    End Sub

    Private Sub frmTextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContent.Size = New Size(582, 322)
    End Sub

End Class
