Imports MySql.Data.MySqlClient
Public Class FLogin
    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT * FROM USER_2421106 " &
            "WHERE username='" & txtusername.Text & "' " &
            "AND userpass=MD5('" & txtpassword.Text & "')"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            Dim level As String
            level = cek.Item("userlevelid")
            useraktif = txtusername.Text

            If level = "1" Then
                Fmenu.SettingToolStripMenuItem.Enabled = True
            Else
                Fmenu.SettingToolStripMenuItem.Enabled = False
            End If
            Fmenu.ToolStripStatusLabel1.Text = txtusername.Text
            Fmenu.Show()
            Me.Hide()
        Else
            MsgBox("Username/Password Salah...", MsgBoxStyle.Information, "Informasi")
        End If
        kon.Close()
    End Sub
    Private Sub cmdexit_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        End
    End Sub
    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtpassword.Focus()
        End Select
    End Sub
    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmdlogin.Focus()
        End Select
    End Sub

    Private Sub FLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class