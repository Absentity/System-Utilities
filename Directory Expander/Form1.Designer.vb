<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectorForm))
        Me.expandButton = New System.Windows.Forms.Button()
        Me.folderSelector = New System.Windows.Forms.FolderBrowserDialog()
        Me.directoryField = New System.Windows.Forms.TextBox()
        Me.browseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.maxRangeField = New System.Windows.Forms.TextBox()
        Me.minRangeField = New System.Windows.Forms.TextBox()
        Me.bthread = New System.ComponentModel.BackgroundWorker()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'expandButton
        '
        Me.expandButton.Location = New System.Drawing.Point(150, 132)
        Me.expandButton.Name = "expandButton"
        Me.expandButton.Size = New System.Drawing.Size(75, 23)
        Me.expandButton.TabIndex = 7
        Me.expandButton.Text = "Expand!"
        Me.expandButton.UseVisualStyleBackColor = True
        '
        'folderSelector
        '
        Me.folderSelector.Description = "Select the folder to duplicate."
        Me.folderSelector.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'directoryField
        '
        Me.directoryField.Location = New System.Drawing.Point(12, 82)
        Me.directoryField.Name = "directoryField"
        Me.directoryField.Size = New System.Drawing.Size(213, 20)
        Me.directoryField.TabIndex = 1
        '
        'browseButton
        '
        Me.browseButton.Location = New System.Drawing.Point(231, 80)
        Me.browseButton.Name = "browseButton"
        Me.browseButton.Size = New System.Drawing.Size(75, 23)
        Me.browseButton.TabIndex = 2
        Me.browseButton.Text = "Browse..."
        Me.browseButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(12, 172)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(294, 23)
        Me.progressBar.Step = 1
        Me.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressBar.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Min:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Max:"
        '
        'maxRangeField
        '
        Me.maxRangeField.Location = New System.Drawing.Point(73, 134)
        Me.maxRangeField.Name = "maxRangeField"
        Me.maxRangeField.Size = New System.Drawing.Size(32, 20)
        Me.maxRangeField.TabIndex = 6
        Me.maxRangeField.Text = "15"
        '
        'minRangeField
        '
        Me.minRangeField.Location = New System.Drawing.Point(73, 108)
        Me.minRangeField.Name = "minRangeField"
        Me.minRangeField.Size = New System.Drawing.Size(32, 20)
        Me.minRangeField.TabIndex = 4
        Me.minRangeField.Text = "1"
        '
        'bthread
        '
        Me.bthread.WorkerReportsProgress = True
        Me.bthread.WorkerSupportsCancellation = True
        '
        'cancelButton
        '
        Me.cancelButton.Enabled = False
        Me.cancelButton.Location = New System.Drawing.Point(231, 132)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 9
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'SelectorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 207)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.minRangeField)
        Me.Controls.Add(Me.maxRangeField)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.browseButton)
        Me.Controls.Add(Me.directoryField)
        Me.Controls.Add(Me.expandButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SelectorForm"
        Me.ShowIcon = False
        Me.Text = "Directory Expander"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents expandButton As System.Windows.Forms.Button
    Friend WithEvents folderSelector As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents directoryField As System.Windows.Forms.TextBox
    Friend WithEvents browseButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents progressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents maxRangeField As System.Windows.Forms.TextBox
    Friend WithEvents minRangeField As System.Windows.Forms.TextBox
    Friend WithEvents bthread As System.ComponentModel.BackgroundWorker
    Friend WithEvents cancelButton As System.Windows.Forms.Button

End Class
