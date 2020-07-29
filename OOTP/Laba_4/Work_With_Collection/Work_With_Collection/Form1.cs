using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_With_Collection
{
    public partial class Form1 : Form
    {
        string input;
        int size;
        List<Car> carlist;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        

        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void GenCollection_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Задайте размер коллекции");
            }
            else
            {
                richTextBox1.Clear();
                input = textBox1.Text;
                size = int.Parse(input);
                carlist = new List<Car>();
                Random rnd = new Random();
                for (int i = 1; i <= size; i++)
                {

                    int value = rnd.Next(60, 130);
                    Car car = new Car(value);
                    carlist.Add(car);
                    richTextBox1.AppendText($"Скорость  машины =  {car.speed} км/ч \n");
                }
            }
        }

        private void SortUp_Click(object sender, EventArgs e)
        {
            if(carlist == null)
            {
                MessageBox.Show("Коллекция пустая");
            }
            else
            {
                carlist.Sort();
                
                foreach(Car i in carlist)
                {
                    richTextBox2.AppendText($"Скорость машины =  {i.speed} км/ч \n");                 
                }
            }
        }

        private void Request1_Click(object sender, EventArgs e)
        {
            if (carlist == null)
            {
                MessageBox.Show("Коллекция пустая");
            }
            else
            {
                richTextBox2.Clear();
                var min = carlist.Min(a => a.speed);
                richTextBox2.AppendText($" минимальная скорость из всех машин =  {min} км/ч \n");
            }
        }

        private void Request2_Click(object sender, EventArgs e)
        {
            if (carlist == null)
            {
                MessageBox.Show("Коллекция пустая");
            }
            else{
                richTextBox2.Clear();
                var max = carlist.Max(a => a.speed);
                richTextBox2.AppendText($" Максимасльная cкорость из всех машин =  {max} км/ч \n");
            }
        }

        private void Request3_Click(object sender, EventArgs e)
        {
            if (carlist == null)
            {
                MessageBox.Show("Коллекция пустая");
            }
            else
            {
                richTextBox2.Clear();
                richTextBox2.AppendText($"Скорость  машин в диапазоне 80 - 100 \n");
                var range = carlist.Where(i => i.speed > 80 && i.speed < 100);
                foreach (Car i in range)
                {
                    richTextBox2.AppendText($"Скорость  машины =  {i.speed} км/ч \n");
                }
            }
            
        }

        private void SortDown_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            if (carlist == null)
            {
                MessageBox.Show("Коллекция пустая");
            }
            else
            {
                carlist.Sort();
                carlist.Reverse();

                foreach (Car i in carlist)
                {
                    richTextBox2.AppendText($"Скорость машины =  {i.speed} км/ч \n");
                }
            }
        }
    }
}
