Imports System.Web.UI.WebControls

Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Guna2PictureBox3.Visible = True Then
            Guna2PictureBox3.Visible = False
            Guna2PictureBox4.Visible = True
        ElseIf Guna2PictureBox4.Visible = True Then
            Guna2PictureBox4.Visible = False
            Guna2PictureBox5.Visible = True
        ElseIf Guna2PictureBox5.Visible = True Then
            Guna2PictureBox5.Visible = False
            Guna2PictureBox6.Visible = True
        ElseIf Guna2PictureBox6.Visible = True Then
            Guna2PictureBox6.Visible = False
            Guna2PictureBox7.Visible = True
        ElseIf Guna2PictureBox7.Visible = True Then
            Guna2PictureBox7.Visible = False
            Guna2PictureBox8.Visible = True
        ElseIf Guna2PictureBox8.Visible = True Then
            Guna2PictureBox8.Visible = False
            Guna2PictureBox3.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Timer1.Enabled Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub Guna2Button3_Click_1(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub

End Class
