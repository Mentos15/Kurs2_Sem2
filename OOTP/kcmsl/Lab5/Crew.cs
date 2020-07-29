using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Crew : Form
    {
        public List<CrewMember> ListCrew;

        public Crew()
        {
            InitializeComponent();
            comboBox1.Items.Add("Пилот");
            comboBox1.Items.Add("Помощник пилота");
            comboBox1.Items.Add("Стюардесса");
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 18;
            trackBar1.Maximum = 50;
            label7.Text = Convert.ToString(trackBar1.Value);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ListCrew.Count == 0 || ListCrew.Count < 3)
            {
                MessageBox.Show("Экипаж должен состоять из 3 человек");
            }
            else
            {
                this.Hide();
                SwitchForms.CreateObject.Show();

                SwitchForms.CreateObject.air.Crew = ListCrew;
                MessageBox.Show("Объект создан");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ListCrew.Count == 0 && Convert.ToString(comboBox1.SelectedItem) != "Пилот")
            {
                MessageBox.Show("Добавьте пилота");
            }
            else if (ListCrew.Count == 1 && Convert.ToString(comboBox1.SelectedItem) != "Помощник пилота")
            {
                MessageBox.Show("Добавьте помощника пилота");
            }
            else if (ListCrew.Count == 2 && Convert.ToString(comboBox1.SelectedItem) != "Стюардесса")
            {
                MessageBox.Show("Добавьте стюардессу");
            }
            else if (ListCrew.Count >= 3)
            {
                MessageBox.Show("Максимум 3 члена экипажа");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Введите имя");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Введите фамилию");
            }
            else if (trackBar1.Value == 0)
            {
                MessageBox.Show("Выберите возраст");
            }
            else if (Convert.ToString(comboBox1.SelectedItem) == "")
            {
                MessageBox.Show("Выберите должность");
            }
            else if (numericUpDown1.Value > 37)
            {
                MessageBox.Show("Стаж не может превышать 37 лет");
            }
            else
            {
                ListCrew.Add(new CrewMember(textBox1.Text, textBox2.Text, trackBar1.Value, Convert.ToString(comboBox1.SelectedItem), (int)numericUpDown1.Value));
                MessageBox.Show("Член экипажа добавлен");
            }
        }
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            trackBar1.Minimum = 18;
            trackBar1.Maximum = 55;
            label7.Text = Convert.ToString(trackBar1.Value);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < textBox1.TextLength; i++)
            //{
            //    if (i == textBox1.TextLength - 1)
            //    {
            //        if (!char.IsLetter(textBox1.Text[i]))
            //        {
            //            string str = "";
            //            for (int j = 0; j < textBox1.TextLength - 1; j++)
            //            {
            //                str += textBox1.Text[j];
            //            }
            //            textBox1.Text = str;
            //            break;
            //        }
            //    }
            //}
        }
    }
}
