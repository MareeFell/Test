using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Треугольника
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32 (textBox3.Text);
            if (a==0 || b==0 || c==0)
            {
                label1.Text = "Треугольник не существует";
            }
            if (a==b && a==c && b==c)
            {
                label1.Text = "Треугольник равносторонний";
            }
            if ((a == b && a != c) || (a == c && a != b) || (c == b && c != a))
            {
                label1.Text = "Треугольник равнобедренный";
            }
            if (a !=b && a!= c && b!= c)
            {
                label1.Text = "Треугольник разносторонний";
            } 
            if ((a + b <= c) || (c + b <= a) || (a + c <= b))
            {
                label1.Text = "Треугольник не существует";
            }
            button2.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button1.Visible = false;

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }

            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}