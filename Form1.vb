Public Class Form1

    Private decSong As Decimal = 2.99D
    Private decHourlyRate As Decimal = 8.99D
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnValue.Text = ""


        cboSelectAction.SelectedIndex = 0
        lblTotalCost.Visible = False
        lblDisplay.Visible = False
        btnValue.Visible = False
        btnCost.Visible = False
        btnCost.Visible = False
        btnClear.Visible = False
        lblTotalCost.Visible = False
        btnValue.Clear()
        'ClearForm()
    End Sub


    Dim intValue As Integer
    Dim decTotal As Decimal
    Dim blnAmountIsValid As Boolean = False
    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim blnAmountIsValid As Boolean = False
        Dim intValue As Integer
        Dim decTotal As Decimal

        blnAmountIsValid = ValidateInput()
        If blnAmountIsValid = True Then
            intValue = Convert.ToInt32(btnValue.Text)
            If cboSelectAction.SelectedIndex = 0 Then
                decTotal = ComputeSongCost(intValue)
            Else
                decTotal = ComputeRoomCost(intValue)
            End If

            lblTotalCost.Visible = True
            lblTotalCost.Text = "Total Cost of Karaoke Night - " & decTotal.ToString("C")

        End If



    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)




    End Sub

    Private Function ValidateInput() As Boolean

        Dim intValue As Integer
        Dim blnValid As Boolean = False
        Try
            intValue = Convert.ToInt32(btnValue.Text)
            If intValue > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a number greater than 0", , "Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid amount", , "Error")
        Catch Exception As OverflowException
            MsgBox("Please enter a reasonable amount", , "Error")
        Catch Exception As SystemException
            MsgBox("Entry invalid. Enter a valid number representing the number in your party.", , "Error")
        End Try
        btnValue.Focus()
        btnValue.Clear()
        Return blnValid



    End Function
    Private Function ComputeSongCost(ByVal intPass As Integer) As Decimal
        Dim decPassCost As Decimal
        decPassCost = intPass * decSong

        Return decPassCost
    End Function

    Private Function ComputeRoomCost(ByVal intPass As Integer) As Decimal
        Dim decTicketCost As Decimal
        decTicketCost = intPass * decHourlyRate

        Return decTicketCost
    End Function



    Private Sub cboSelectAction_SelectIndexChanged(sender As Object, e As EventArgs) Handles cboSelectAction.SelectedIndexChanged
        If cboSelectAction.SelectedIndex = 0 Then
            lblDisplay.Text = "Number of Karaoke Songs"
            lblDisplay.Visible = True
            btnValue.Visible = True
            btnCost.Visible = True
            btnClear.Visible = True
            btnValue.Focus()
        End If
        If cboSelectAction.SelectedIndex = 1 Then
            lblDisplay.Text = "Hourly Rental of Karaoke Room:"
            lblDisplay.Visible = True
            btnValue.Visible = True
            btnCost.Visible = True
            btnClear.Visible = True
            btnValue.Focus()
        End If
    End Sub


End Class
