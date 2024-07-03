Imports System.IO

Public Class Preview
    Private Sub Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub saveToTrainers_btn_Click(sender As Object, e As EventArgs) Handles saveToTrainers_btn.Click

        If saveToTrainerText.ShowDialog = DialogResult.OK Then

            Try
                File.AppendAllText(saveToTrainerText.FileName, output_rchTxt.Text)
            Catch ex As Exception
                MessageBox.Show("Oh no! An error! Let's have a look at what happened..." & vbCrLf & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try

        End If
    End Sub
End Class