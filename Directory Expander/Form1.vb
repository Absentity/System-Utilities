Imports System.IO.Directory
Imports System.IO.File
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class SelectorForm

    Private Sub browseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browseButton.Click
        If folderSelector.ShowDialog() = Windows.Forms.DialogResult.OK Then
            directoryField.Text = folderSelector.SelectedPath
        End If
    End Sub

    Private Function getZeroString(ByVal value As Integer) As String
        Dim zstr As String = ""
        For z As Integer = value To maxRangeField.Text.Length - 1
            zstr &= "0"
        Next z
        Return zstr
    End Function

    ' Expands the dirs (done in seperate thread!)
    Private Sub expandDirs(ByVal worker As System.ComponentModel.BackgroundWorker, _
                ByVal e As System.ComponentModel.DoWorkEventArgs, _
                ByVal sourceDir As String, _
                ByVal minRange As Integer, _
                ByVal maxRange As Integer)
        ' Create a Regular Expression looking for occurances of '_template_'
        Dim regExp As Regex
        regExp = New Regex("_template_*")

        ' Get passed in input
        'Dim minRange As Integer = CInt(e.Argument(0))
        'Dim maxrange As Integer = CInt(e.Argument(1))

        Dim zeroString As String = ""

        ' Find all subdirectories and files
        Dim dirs As String() = GetDirectories(sourceDir)
        Dim files(dirs.Length) As Array
        Dim counter As Integer = 0
        For Each d As String In dirs
            files(counter) = GetFiles(d)
            counter += 1
        Next

        ' ONLY make new directories and files
        For i As Integer = minRange To maxRange
            worker.ReportProgress((i / maxRange) * 100)

            If worker.CancellationPending Then
                Return
            End If

            ' Find the amount of zeroes to prepend to the folder
            ' TODO: DRY, there's a recursive method for this
            Select Case i
                ' Am I an idiot? Why not zeroString = "0" ?
                ' This would be best done recursively
                Case Is < 10
                    zeroString = getZeroString(1)
                Case Is < 100
                    zeroString = getZeroString(2)
                Case Is < 1000
                    zeroString = getZeroString(3)
                Case Is < 10000
                    zeroString = getZeroString(4)
            End Select

            ' Skip overwriting existing directories
            If FileIO.FileSystem.DirectoryExists(regExp.Replace(sourceDir, zeroString & i.ToString)) Then
                Continue For
            End If

            ' Simulating wait
            Thread.Sleep(1000)

            ' Only creates new directories
            ' TODO: This NEEDS to be recursive
            For j As Integer = 0 To dirs.Length - 1
                CreateDirectory(regExp.Replace(dirs(j), zeroString & i.ToString))
                For Each d As String In files(j)
                    Copy(d, regExp.Replace(d, zeroString & i.ToString))
                Next
            Next j
        Next i

    End Sub

    Private Sub expandButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles expandButton.Click
        Dim args As Array = Array.CreateInstance(GetType(String), 3)
        Dim min, max As Integer

        ' Convert range fields to numbers
        If (Int32.TryParse(minRangeField.Text, min) AndAlso _
                Int32.TryParse(maxRangeField.Text, max)) Then
            args(0) = min
            args(1) = max
            args(2) = directoryField.Text

            toggleControls()

            bthread.RunWorkerAsync(args)
        Else
            MessageBox.Show("Invalid range specified.", "Error!", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub bthread_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bthread.DoWork
        Dim worker As System.ComponentModel.BackgroundWorker = CType(sender, System.ComponentModel.BackgroundWorker)
        Dim min = e.Argument(0)
        Dim max = e.Argument(1)
        Dim dir = e.Argument(2)

        ''expandDirs(sender, e, "Z:\Jobs\2009 Jobs\290_template_", 3, 99)
        expandDirs(sender, e, dir, min, max)
    End Sub

    Private Sub bthread_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bthread.ProgressChanged
        'Update progressbar
        progressBar.Value = e.ProgressPercentage
    End Sub

    Private Sub cancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelButton.Click
        bthread.CancelAsync()
    End Sub

    Private Sub bthread_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bthread.RunWorkerCompleted
        MessageBox.Show("Job finished!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        toggleControls()
    End Sub

    Private Sub toggleControls()
        ' Toggle controls
        expandButton.Enabled = Not expandButton.Enabled
        browseButton.Enabled = Not browseButton.Enabled
        cancelButton.Enabled = Not cancelButton.Enabled
    End Sub

End Class
