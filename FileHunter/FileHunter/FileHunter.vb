Public Class FileHunter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'FileHunter 1.0
        'Provided for non-commercial use. Please refer to Github Repo for more information. 
        'Contact: Sherman_tan@outlook.com
        '(C) Tan Wei Qiang Sherman.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim SourcePath As String = txtFileName.Text
        Dim SaveDirectory As String = "C:\"

        Try
            Dim Filename As String = System.IO.Path.GetFileName(SourcePath)
            Dim SavePath As String = System.IO.Path.Combine(SaveDirectory, Filename)
            If System.IO.File.Exists(SavePath) Then
                MsgBox("The file name " + txtFileName.Text + " was located in C: drive. The file is located at " + SavePath + ".")
                lblDisplay.Text = "File is located!"
            Else
                MsgBox("The file name " + txtFileName.Text + " could not be located in C: drive.")
                lblDisplay.Text = "File is not located!"
            End If
        Catch
            lblDisplay.Text = "Illegal characters in textbox or file not found."
        End Try

    End Sub
End Class
