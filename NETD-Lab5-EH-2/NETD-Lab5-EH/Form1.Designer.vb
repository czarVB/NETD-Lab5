<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.tsmFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsMenu
        '
        Me.mnsMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFile, Me.tsmEdit, Me.tsmHelp})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(582, 28)
        Me.mnsMenu.TabIndex = 2
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'tsmFile
        '
        Me.tsmFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiNew, Me.tmiOpen, Me.tmiSave, Me.tmiSaveAs, Me.tmiClose, Me.tmiExit})
        Me.tsmFile.Name = "tsmFile"
        Me.tsmFile.Size = New System.Drawing.Size(44, 24)
        Me.tsmFile.Text = "File"
        '
        'tmiNew
        '
        Me.tmiNew.Name = "tmiNew"
        Me.tmiNew.Size = New System.Drawing.Size(181, 26)
        Me.tmiNew.Text = "New"
        '
        'tmiOpen
        '
        Me.tmiOpen.Name = "tmiOpen"
        Me.tmiOpen.Size = New System.Drawing.Size(181, 26)
        Me.tmiOpen.Text = "Open"
        '
        'tmiSave
        '
        Me.tmiSave.Name = "tmiSave"
        Me.tmiSave.Size = New System.Drawing.Size(181, 26)
        Me.tmiSave.Text = "Save"
        '
        'tmiSaveAs
        '
        Me.tmiSaveAs.Name = "tmiSaveAs"
        Me.tmiSaveAs.Size = New System.Drawing.Size(181, 26)
        Me.tmiSaveAs.Text = "Save As"
        '
        'tmiClose
        '
        Me.tmiClose.Name = "tmiClose"
        Me.tmiClose.Size = New System.Drawing.Size(181, 26)
        Me.tmiClose.Text = "Close"
        '
        'tmiExit
        '
        Me.tmiExit.Name = "tmiExit"
        Me.tmiExit.Size = New System.Drawing.Size(181, 26)
        Me.tmiExit.Text = "Exit"
        '
        'tsmEdit
        '
        Me.tsmEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiCut, Me.tmiCopy, Me.tmiPaste})
        Me.tsmEdit.Name = "tsmEdit"
        Me.tsmEdit.Size = New System.Drawing.Size(47, 24)
        Me.tsmEdit.Text = "Edit"
        '
        'tmiCut
        '
        Me.tmiCut.Name = "tmiCut"
        Me.tmiCut.Size = New System.Drawing.Size(118, 26)
        Me.tmiCut.Text = "Cut"
        '
        'tmiCopy
        '
        Me.tmiCopy.Name = "tmiCopy"
        Me.tmiCopy.Size = New System.Drawing.Size(118, 26)
        Me.tmiCopy.Text = "Copy"
        '
        'tmiPaste
        '
        Me.tmiPaste.Name = "tmiPaste"
        Me.tmiPaste.Size = New System.Drawing.Size(118, 26)
        Me.tmiPaste.Text = "Paste"
        '
        'tsmHelp
        '
        Me.tsmHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiAbout})
        Me.tsmHelp.Name = "tsmHelp"
        Me.tsmHelp.Size = New System.Drawing.Size(53, 24)
        Me.tsmHelp.Text = "Help"
        '
        'tmiAbout
        '
        Me.tmiAbout.Name = "tmiAbout"
        Me.tmiAbout.Size = New System.Drawing.Size(181, 26)
        Me.tmiAbout.Text = "About"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtContent
        '
        Me.txtContent.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.Location = New System.Drawing.Point(0, 31)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(582, 322)
        Me.txtContent.TabIndex = 3
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 353)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.MaximizeBox = False
        Me.Name = "frmTextEditor"
        Me.Text = "Text Editor"
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents tsmFile As ToolStripMenuItem
    Friend WithEvents tmiOpen As ToolStripMenuItem
    Friend WithEvents tsmEdit As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents txtContent As TextBox
    Friend WithEvents tmiSaveAs As ToolStripMenuItem
    Friend WithEvents tsmHelp As ToolStripMenuItem
    Friend WithEvents tmiAbout As ToolStripMenuItem
    Friend WithEvents tmiNew As ToolStripMenuItem
    Friend WithEvents tmiSave As ToolStripMenuItem
    Friend WithEvents tmiClose As ToolStripMenuItem
    Friend WithEvents tmiExit As ToolStripMenuItem
    Friend WithEvents tmiCut As ToolStripMenuItem
    Friend WithEvents tmiCopy As ToolStripMenuItem
    Friend WithEvents tmiPaste As ToolStripMenuItem
End Class
