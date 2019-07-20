' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
Option Explicit On

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Dim FirstNo As Decimal
    Dim SecondNo As Decimal
    Dim Result As Decimal

    Private Sub BtnClear_Click(sender As Object, e As RoutedEventArgs) Handles BtnClear.Click
        TxtFirstNo.Text = ""
        TxtSecondNo.Text = ""
        TxtResult.Text = ""
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As RoutedEventArgs) Handles BtnAdd.Click
        If Decimal.TryParse(TxtFirstNo.Text, FirstNo) And Decimal.TryParse(TxtSecondNo.Text, SecondNo) Then
            Result = FirstNo + SecondNo
            TxtResult.Text = Result.ToString()
        Else
            TxtResult.Text = "Error: Invalid Input."
        End If

    End Sub

    Private Sub BtnSub_Click(sender As Object, e As RoutedEventArgs) Handles BtnSub.Click
        If Decimal.TryParse(TxtFirstNo.Text, FirstNo) And Decimal.TryParse(TxtSecondNo.Text, SecondNo) Then
            Result = FirstNo - SecondNo
            TxtResult.Text = Result.ToString()
        Else
            TxtResult.Text = "Error: Invalid Input."
        End If
    End Sub

    Private Sub BtnMul_Click(sender As Object, e As RoutedEventArgs) Handles BtnMul.Click
        If Decimal.TryParse(TxtFirstNo.Text, FirstNo) And Decimal.TryParse(TxtSecondNo.Text, SecondNo) Then
            Result = FirstNo * SecondNo
            TxtResult.Text = Result.ToString()
        Else
            TxtResult.Text = "Error: Invalid Input."
        End If
    End Sub

    Private Sub BtnDiv_Click(sender As Object, e As RoutedEventArgs) Handles BtnDiv.Click
        If Decimal.TryParse(TxtFirstNo.Text, FirstNo) And Decimal.TryParse(TxtSecondNo.Text, SecondNo) Then
            If SecondNo = 0 Then
                TxtResult.Text = "Error: Divide By Zero."
            Else
                Result = FirstNo / SecondNo
                TxtResult.Text = Result.ToString()
            End If
        Else
            TxtResult.Text = "Error: Invalid Input."
        End If
    End Sub
End Class
