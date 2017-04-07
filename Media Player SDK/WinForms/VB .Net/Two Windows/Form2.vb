' ReSharper disable InconsistentNaming

Public Class Form2

    Public Sub LogLicensing(message As String)

        If cbLicensing.Checked Then
            mmError.Text = mmError.Text + "LICENSING:" + Environment.NewLine + message + Environment.NewLine
        End If

    End Sub

    Public Sub Log(message As String)

        If cbLicensing.Checked Then
            mmError.Text = mmError.Text + message + Environment.NewLine
        End If

    End Sub

    Public ReadOnly Property Screen() As Control
	Get
	    Return pnScreen
	End Get
    End Property

End Class

' ReSharper restore InconsistentNaming