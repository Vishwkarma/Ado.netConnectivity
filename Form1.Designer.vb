<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label5 = New Label()
        Button4 = New Button()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(127, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 23)
        Label1.TabIndex = 0
        Label1.Text = "PR"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(127, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 23)
        Label2.TabIndex = 1
        Label2.Text = "STUDENT NAME "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(127, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 23)
        Label3.TabIndex = 2
        Label3.Text = "CONTACT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(127, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 23)
        Label4.TabIndex = 3
        Label4.Text = "CITY"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(357, 96)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 30)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(357, 141)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 30)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(357, 193)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 30)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(357, 249)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 30)
        TextBox4.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(72, 323)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 8
        Button1.Text = "SAVE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(258, 323)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 29)
        Button2.TabIndex = 9
        Button2.Text = "UPDATE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(463, 323)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 29)
        Button3.TabIndex = 10
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(78, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 20)
        Label5.TabIndex = 11
        Label5.Text = "student registration"
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(661, 324)
        Button4.Name = "Button4"
        Button4.Size = New Size(104, 40)
        Button4.TabIndex = 12
        Button4.Text = "RETRIVE"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(572, 77)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(150, 164)
        ListBox1.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListBox1)
        Controls.Add(Button4)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox1 As ListBox
End Class
