using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trigonom_Calcul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool flag = true;
        double a = 0, b = 0;
        public Stack<string> stack = new Stack<string>();

        private void Numbers_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void Point_Click(object sender, EventArgs e)
        {
            if (flag && textBox1.Text != "")
            {
                textBox1.Text += (sender as Button).Text;
                flag = false;
            }
        }
        

        private void OneClear_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            flag = true;
        }
       
        private void Sin_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(textBox1.Text);
            a = Math.Sin(sin);
            textBox1.Text = a.ToString();
        }
        private void Sqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(textBox1.Text);
            a = Math.Sqrt(sqrt);
            textBox1.Text = a.ToString();
        }

        private void Pow_Click(object sender, EventArgs e)
        {
            double pow = Double.Parse(textBox1.Text);
            a = Math.Pow(pow, 2);
            textBox1.Text = a.ToString();
        }
        private void Cos_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(textBox1.Text);
            a = Math.Cos(cos);
            textBox1.Text = a.ToString();

        }
        private void Tang_Click(object sender, EventArgs e)
        {
            double tg = Double.Parse(textBox1.Text);
            a = Math.Tan(tg);
            textBox1.Text = a.ToString();
        }
        private void Ctang_Click(object sender, EventArgs e)
        {
            double ctg = Double.Parse(textBox1.Text);
            a = Math.Cos(ctg) / Math.Sin(ctg);
            textBox1.Text = a.ToString();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            stack.Push(textBox1.Text);
        }
        private void Pop_Click(object sender, EventArgs e)
        {
            if(stack.Count == 0)
            {
                MessageBox.Show("Больше нет сохраненных жначений");
            }
            else
            {
                textBox1.Text = stack.Pop();
                
            }
            
        }

        private void Pow3_Click(object sender, EventArgs e)
        {
            double pow = Double.Parse(textBox1.Text);
            a = Math.Pow(pow, 3);
            textBox1.Text = a.ToString();
        }
        private void Pow4_Click(object sender, EventArgs e)
        {
            double pow = Double.Parse(textBox1.Text);
            a = Math.Pow(pow, 4);
            textBox1.Text = a.ToString();
        }

        private void pi2_Click(object sender, EventArgs e)
        {
            
            a = (Math.PI / 2);
            textBox1.Text = a.ToString();
        }

        private void pi3_Click(object sender, EventArgs e)
        {
            
            a = (Math.PI / 3);
            textBox1.Text = a.ToString();
        }

        private void pi4_Click(object sender, EventArgs e)
        {
            
            a = (Math.PI / 4);
            textBox1.Text = a.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
