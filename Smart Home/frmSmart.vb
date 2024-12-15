' Program Name: Smart Home Monthly Electric Savings
' Date: December 15, 2024
' Author: K Bola
' Purpose: This window application opens a text file that lists the monthly savings of a smart home's electric bill 
Option Strict On
Public Class frmSmart
    ' Class Level Private Variables
    Private _intSizeOfArray As Integer = 12
    Private _strMonths(_intSizeOfArray) As String
    Private _decSavings(_intSizeOfArray) As Decimal
    Private Sub frmSmart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strFileLocation As String = "C:\Users\HELLO\Source\Repos\Smart Home\savings.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "File doesn't exist."
        ' Verifying if a file exists
        If (IO.File.Exists(strFileLocation)) Then
            objReader = IO.File.OpenText(strFileLocation)
            ' Reading the file line by line 
            Do While objReader.Peek <> -1
                _strMonths(intCount) = objReader.ReadLine()
                _decSavings(intCount) = Convert.ToDecimal(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()

            ' The combo box object is filled with months
            For intFill = 0 To (_strMonths.Length - 1)
                If (_strMonths(intFill) IsNot Nothing) Then
                    cboMonths.Items.Add(_strMonths(intFill))
                End If
            Next
        Else
            MsgBox(strFileError, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error")
            Close()
        End If
    End Sub

    Private Sub cboMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonths.SelectedIndexChanged
        ' Declaring Variables
        Dim intMonthSelection As Integer = cboMonths.SelectedIndex
        Dim strMonthSelection As String = CStr(cboMonths.SelectedItem)
        If (intMonthSelection >= 0) Then
            lblDisplaySavings.Visible = True
            lblDisplaySavings.Text = "The electric savings for " & strMonthSelection & " is " & _decSavings(intMonthSelection).ToString("C")
            btnDisplay.Visible = True
        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Calling Procedures
        Sum()
        ' Outputting the highest electric savings
        lblOverall.Visible = True
        lblOverall.Text = "December had the most significant monthly savings"
    End Sub

    Private Sub Sum()
        Dim dectotal As Decimal
        For Each saving In _decSavings
            dectotal += saving
        Next
        Dim decAverage As Decimal = dectotal / 12
        lblDisplayAverage.Visible = True
        lblDisplayAverage.Text = "The average monthly savings: " & decAverage.ToString("C")
    End Sub
End Class
