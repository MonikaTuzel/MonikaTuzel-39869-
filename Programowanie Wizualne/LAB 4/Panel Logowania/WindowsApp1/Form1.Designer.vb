<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ZalogujButton1 = New System.Windows.Forms.Button()
        Me.RejestracjaButton2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.25!)
        Me.Label1.Location = New System.Drawing.Point(108, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Witam w panelu logowania!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.25!)
        Me.Label2.Location = New System.Drawing.Point(107, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Login:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.25!)
        Me.Label3.Location = New System.Drawing.Point(107, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasło:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Cambria", 9.25!)
        Me.TextBox1.Location = New System.Drawing.Point(180, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 22)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Cambria", 9.25!)
        Me.TextBox2.Location = New System.Drawing.Point(180, 136)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(191, 22)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ZalogujButton1
        '
        Me.ZalogujButton1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ZalogujButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ZalogujButton1.Font = New System.Drawing.Font("Cambria", 9.25!)
        Me.ZalogujButton1.Location = New System.Drawing.Point(294, 210)
        Me.ZalogujButton1.Name = "ZalogujButton1"
        Me.ZalogujButton1.Size = New System.Drawing.Size(87, 33)
        Me.ZalogujButton1.TabIndex = 5
        Me.ZalogujButton1.Text = "Zaloguj"
        Me.ZalogujButton1.UseVisualStyleBackColor = False
        '
        'RejestracjaButton2
        '
        Me.RejestracjaButton2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.RejestracjaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RejestracjaButton2.Font = New System.Drawing.Font("Cambria", 9.25!)
        Me.RejestracjaButton2.Location = New System.Drawing.Point(98, 210)
        Me.RejestracjaButton2.Name = "RejestracjaButton2"
        Me.RejestracjaButton2.Size = New System.Drawing.Size(87, 33)
        Me.RejestracjaButton2.TabIndex = 6
        Me.RejestracjaButton2.Text = "Rejestracja"
        Me.RejestracjaButton2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(478, 311)
        Me.Controls.Add(Me.RejestracjaButton2)
        Me.Controls.Add(Me.ZalogujButton1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 9.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel Logowania"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ZalogujButton1 As Button
    Friend WithEvents RejestracjaButton2 As Button
End Class
