Public Class Form1
    Dim Client As New UNOLibs.Net.ClientClass
    Dim WithEvents Server As UNOLibs.Net.ServerClass

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles ServerPort.ValueChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub KnopkaOtpravkiMsg_Click(sender As Object, e As EventArgs) Handles KnopkaOtpravkiMsg.Click
        Dim IP As String = IPDest.Text
        Dim PORT As Integer = PortDest.Value
        Dim DATA As String = IshodMessage.Text
        Try
            Client.SendMessage(IP, PORT, DATA)
        Catch ex As Exception
            MsgBox("Error sending message")
        End Try

    End Sub
End Class
