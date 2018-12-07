''' <summary>Class with some helpful methods</summary>
Module Functions
    ''' <summary>Function that controls that user types only numbers</summary>
    ''' <param name="e"></param>
    Public Sub justNumbers(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
End Module