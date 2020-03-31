using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BMR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((BoxWaga.Text != "") && (textBox3.Text != "") && (textBox5.Text != ""))
           {

                if ((checkBox1.Checked == true) && (checkBox2.Checked == false))
                 {
                    double wagam = Convert.ToDouble(BoxWaga.Text);
                    double wzrostm = Convert.ToDouble(textBox3.Text);
                    double wiekm = Convert.ToDouble(textBox5.Text);
                    double bmrm = (9.99 * wagam) + (6.25 * wzrostm) - (4.92 * wiekm) + 5;
                    label9.Text = bmrm.ToString();
                 }
                else if ((checkBox2.Checked == true) && (checkBox1.Checked == false))
                {
                    double wagak = Convert.ToDouble(BoxWaga.Text);
                    double wzrostk = Convert.ToDouble(textBox3.Text);
                    double wiekk = Convert.ToDouble(textBox5.Text);
                    double bmrk = (9.99 * wagak) + (6.25 * wzrostk) - (4.92 * wiekk) - 161;
                    label9.Text = bmrk.ToString();
                }
                else
                {
                    label9.Text = "WYBIERZ PŁEĆ!";
                }
            }
            else
            {
                label9.Text = "BRAK DANYCH!";
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoxWaga.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            label9.Text = "";
        }

        private void labelWaga_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
