Public Class showdownConverter
    Public Shared Sub parse()
        ' Create a new array with the data from sd_Team_rchTxtBox
        Dim tempData As Array = Form1.sd_Team_rchTxtBox.Text.Split()
        Dim tempString As String = ""


        Try
            Dim dataOffset As Integer = 0


            If tempData(1).ToString.Trim("""") = "@" Then

            ElseIf tempData(2).ToString.Trim("""") = "@" Then

            ElseIf tempData(3).ToString.Trim("""") = "@" Then

            Else
                If tempData(2).ToString.Trim("(", ")") = "M" Or tempData(2).ToString.Trim("(", ")") = "F" Then

                ElseIf tempData(3).ToString.Trim("(", ")", """") = "Ability" Then

                End If
            End If

            MessageBox.Show("Check Debug Log", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Something went wrong. Maybe your team is not correctly formatted?", "Cannot Convert Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine(ex.Message)
        End Try

        '        Try
        '            ' Check Part Position
        '            If Form1.sd_PokePos_cmb.SelectedIndex = 0 Then

        '#Region "Pokemon 1"
        '                ' Name & Nickname

        '                ' Check to see if "@" is on array index 1
        '                If tempData(1).ToString.Trim("""") = "@" Then
        '                    Form1.pokemonOneName_txtBox.Text = tempData(0).ToString
        '                ElseIf Not tempData(1).ToString.Trim("""") = "@" Or Not tempData(2).ToString.Trim("""") = "@" Then ' Used only if there is no held item
        '                    'Check for nickname
        '                    If tempData(1).ToString.Trim("""") = "" Then
        '                        Form1.pokemonOneName_txtBox.Text = tempData(0).ToString
        '                    Else ' Use this if the nickname is set.
        '                        Form1.pokemonOneNickName_txtBox.Text = tempData(0).ToString
        '                        tempString = tempData(1).ToString.Trim("(", ")")
        '                        Form1.pokemonOneName_txtBox.Text = tempString
        '                    End If
        '                Else ' Use this if the nickname is set.
        '                    Form1.pokemonOneNickName_txtBox.Text = tempData(0).ToString
        '                    tempString = tempData(1).ToString.Trim("(", ")")
        '                    Form1.pokemonOneName_txtBox.Text = tempString
        '                End If

        '                ' Held Items

        '                ' Check to see if "@" is on array index 1
        '                If tempData(1).ToString.Trim("""") = "@" Then
        '                    If tempData(3).ToString.Trim("""") = "" Then
        '                        Form1.pokemonOneItem_txtBox.Text = tempData(2).ToString.Trim("""")
        '                    Else
        '                        Form1.pokemonOneItem_txtBox.Text = tempData(2).ToString.Trim("""") & tempData(3).ToString.Trim("""")
        '                    End If
        '                ElseIf Not tempData(1).ToString.Trim("""") = "@" Or Not tempData(2).ToString.Trim("""") = "@" Then ' Used only if there is no held item

        '                Else

        '                End If
        '#End Region


        '            End If

        '            MessageBox.Show("Your team has been converted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Catch ex As Exception
        '            MessageBox.Show("Something went wrong. Maybe your team is not correctly formatted?", "Cannot Convert Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End Try
    End Sub
End Class
