<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rzut
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rzut))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(313, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.kostka
        Me.PictureBox1.Location = New System.Drawing.Point(491, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 243)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(156, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(407, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jeśli chcesz rzucić kostką wciśnij ""r"" na swojej klawiaturze"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 40.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Salmon
        Me.Label3.Location = New System.Drawing.Point(226, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 63)
        Me.Label3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(92, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Twój wynik:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(429, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Naciśnij dwa razy LPM na wynik, aby zapisać go do wchowka"
        '
        'Rzut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(719, 388)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Rzut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rzut kostką"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
