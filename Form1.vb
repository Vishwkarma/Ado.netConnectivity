
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.SqlClient

Public Class Form1
    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=CHETANPC1998\SQLEXPRESS;Initial Catalog=ADONET;Integrated Security=True")
        cn.Open()
        MsgBox(" database connected successfully ...")
        cn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New SqlCommand(" INSERT INTO Student(PRN,Sname,contact,City)  VALUES(" & TextBox1.Text & " ,' " & TextBox2.Text & " '," & TextBox3.Text & ",' " & TextBox4.Text & " ')", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Inserted successfully....")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = New SqlCommand(" UPDATE STUDENT SET Sname='" & TextBox2.Text & "',contact= " & TextBox3.Text & ", City= '" & TextBox4.Text & " ' WHERE PRN=" & TextBox1.Text & "", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Updated successfully....")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cmd = New SqlCommand("DELETE FROM Student WHERE PRN = " & TextBox1.Text & "", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Deleted successfully....")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cmd = New SqlCommand(" SELECT * FROM Student where PRN = " & TextBox1.Text & " ", cn)
        cn.Open()
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            TextBox1.Text = dr(1)
            TextBox2.Text = dr(2)
            TextBox3.Text = dr(3)

        Else
            MsgBox("No record Found....")
        End If

        cn.Close()

    End Sub
    Sub fillList()
        cmd = New SqlCommand(" SELECT * FROM Student where PRN = " & TextBox1.Text & " ", cn)
        cn.Open()
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            TextBox1.Text = dr(1)
            TextBox2.Text = dr(2)
            TextBox3.Text = dr(3)

        Else
            MsgBox("No record Found....")
        End If

        cn.Close()
    End Sub


End Class
