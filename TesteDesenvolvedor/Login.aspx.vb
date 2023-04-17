
Imports System.Data.SqlClient
Public Class Login
    Inherits System.Web.UI.Page

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Dim var

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=DESKTOP-487L9VC; Initial Catalog=TesteDesenvolvedorBD; Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("SELECT Senha FROM Administrador WHERE Nome = '" + TextBox1.Text + "'", con)
        dr = cmd.ExecuteReader
        If (dr.Read) Then
            If (dr(0).ToString = TextBox2.Text) Then

                Response.Redirect("~/Administradors/Details/1")

            Else
                Response.Write("Senha incorreta")


            End If



        Else
            Response.Write("Administrador não existe!")
        End If



    End Sub
End Class
