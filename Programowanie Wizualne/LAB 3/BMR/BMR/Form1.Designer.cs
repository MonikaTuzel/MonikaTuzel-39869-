namespace BMR
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
			this.labelWaga = new System.Windows.Forms.Label();
			this.BoxWaga = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelWaga
			// 
			this.labelWaga.AutoSize = true;
			this.labelWaga.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelWaga.Location = new System.Drawing.Point(151, 126);
			this.labelWaga.Name = "labelWaga";
			this.labelWaga.Size = new System.Drawing.Size(60, 15);
			this.labelWaga.TabIndex = 2;
			this.labelWaga.Text = "Waga [kg]";
			this.labelWaga.Click += new System.EventHandler(this.labelWaga_Click);
			// 
			// BoxWaga
			// 
			this.BoxWaga.Location = new System.Drawing.Point(154, 142);
			this.BoxWaga.Name = "BoxWaga";
			this.BoxWaga.Size = new System.Drawing.Size(100, 20);
			this.BoxWaga.TabIndex = 3;
			this.BoxWaga.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
			this.label5.Location = new System.Drawing.Point(151, 185);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "Wzrost [cm]";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(154, 201);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightCoral;
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(544, 371);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(141, 58);
			this.button1.TabIndex = 10;
			this.button1.Text = "OBLICZ!";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Location = new System.Drawing.Point(436, 255);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 32);
			this.button2.TabIndex = 11;
			this.button2.Text = "WYCZYŚĆ";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
			this.label7.Location = new System.Drawing.Point(151, 237);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 15);
			this.label7.TabIndex = 12;
			this.label7.Text = "Wiek [lat]";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(154, 255);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label9.Location = new System.Drawing.Point(172, 346);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(0, 27);
			this.label9.TabIndex = 16;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
			this.checkBox1.Location = new System.Drawing.Point(382, 163);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(84, 19);
			this.checkBox1.TabIndex = 17;
			this.checkBox1.Text = "Mężczyzna";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
			this.checkBox2.Location = new System.Drawing.Point(382, 201);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(65, 19);
			this.checkBox2.TabIndex = 18;
			this.checkBox2.Text = "Kobieta";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Gold;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(55, 346);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 19);
			this.label1.TabIndex = 19;
			this.label1.Text = "TWÓJ WYNIK:";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(253, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(192, 35);
			this.label2.TabIndex = 20;
			this.label2.Text = "Kalkulator BMR";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(171, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(373, 26);
			this.label3.TabIndex = 21;
			this.label3.Text = "wzkaźnik podstawowej przemiany materii";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(706, 453);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.BoxWaga);
			this.Controls.Add(this.labelWaga);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "BMR";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWaga;
        private System.Windows.Forms.TextBox BoxWaga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

