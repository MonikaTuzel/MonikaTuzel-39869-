using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PESEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string P = textBox1.Text;
            int dlugosc = P.Length;

            if ((textBox1.Text != "") && (dlugosc == 11))
            {
                long pesel = Convert.ToInt64(textBox1.Text);
                
                int i = 10;
                int[] tab = new int[11];
                int suma, g;

                do
                {
                    tab[i] = Convert.ToInt32( pesel % 10);
                    pesel /= 10;
                    i--;
                } while (pesel > 0);

                suma = tab[0] + 3 * tab[1] + 7 * tab[2] + 9 * tab[3] + tab[4] + 3 * tab[5] + 7 * tab[6] + 9 * tab[7] + tab[8] + 3 * tab[9];

                suma %= 10;
                g = 10 - suma;

                if (g == tab[10])
                {
                    wynik.ForeColor = Color.Green;
                    wynik.Text = "NUMER PESEL POPRAWNY!";
                }
                else
                {
                    wynik.ForeColor = Color.Red;
                    wynik.Text = "NUMER PESEL NIEPOPRAWNY!";
                }


                
            }
            else if ((dlugosc >0 ) && (dlugosc != 11))
             {
                wynik.ForeColor = Color.Gray;
                 wynik.Text = "numer PESEL musi mieć 11 cyfr!";
              }

            else
            {
                wynik.ForeColor = Color.Gray;
                wynik.Text = "Wprowadź numer PESEL!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
