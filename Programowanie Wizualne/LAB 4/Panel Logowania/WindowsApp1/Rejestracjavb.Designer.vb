<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rejestracja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rejestracja))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LoginTextBox1 = New System.Windows.Forms.TextBox()
        Me.HasloTextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.25!)
        Me.Label1.Location = New System.Drawing.Point(128, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Zarejestruj się!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.25!)
        Me.Label3.Location = New System.Drawing.Point(49, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hasło:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.25!)
        Me.Label4.Location = New System.Drawing.Point(49, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Login:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Cambria", 9.25!)
        Me.Button3.Location = New System.Drawing.Point(158, 308)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 33)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Zarejestruj"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'LoginTextBox1
        '
        Me.LoginTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.LoginTextBox1.Location = New System.Drawing.Point(133, 112)
        Me.LoginTextBox1.Name = "LoginTextBox1"
        Me.LoginTextBox1.Size = New System.Drawing.Size(178, 22)
        Me.LoginTextBox1.TabIndex = 10
        Me.LoginTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HasloTextBox2
        '
        Me.HasloTextBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.HasloTextBox2.Location = New System.Drawing.Point(133, 156)
        Me.HasloTextBox2.Name = "HasloTextBox2"
        Me.HasloTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.HasloTextBox2.Size = New System.Drawing.Size(178, 22)
        Me.HasloTextBox2.TabIndex = 11
        Me.HasloTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Rejestracja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(403, 388)
        Me.Controls.Add(Me.HasloTextBox2)
        Me.Controls.Add(Me.LoginTextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 9.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Rejestracja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rejestracja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents LoginTextBox1 As TextBox
    Friend WithEvents HasloTextBox2 As TextBox
End Class
