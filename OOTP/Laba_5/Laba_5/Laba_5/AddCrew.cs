using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_5
{
    public partial class AddCrew : Form
    {
        public List<CrewMember> ListCrew;
        public AddCrew()
        {
            InitializeComponent();
            Position.Items.Add("Пилот");
            Position.Items.Add("Помощник пилота");
            Position.Items.Add("Стюардесса");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Age.Minimum = 18;
            Age.Maximum = 50;
            label1.Text = Convert.ToString(Age.Value);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_New_Crew_Click(object sender, EventArgs e)
        {

            if (ListCrew.Count == 0 && Convert.ToString(Position.SelectedItem) != "Пилот")
            {
                MessageBox.Show("Добавьте пилота");
            }
            else if (ListCrew.Count == 1 && Convert.ToString(Position.SelectedItem) != "Помощник пилота")
            {
                MessageBox.Show("Добавьте помощника пилота");
            }
            else if (ListCrew.Count == 2 && Convert.ToString(Position.SelectedItem) != "Стюардесса")
            {
                MessageBox.Show("Добавьте стюардессу");
            }
            else if (ListCrew.Count >= 3)
            {
                MessageBox.Show("Максимум 3 члена экипажа");
            }
            else if (Name.Text == "")
            {
                MessageBox.Show("Введите имя");
            }
            else if (SecondName.Text == "")
            {
                MessageBox.Show("Введите фамилию");
            }
            else if (Age.Value == 0)
            {
                MessageBox.Show("Выберите возраст");
            }
            else if (Convert.ToString(Position.SelectedItem) == "")
            {
                MessageBox.Show("Выберите должность");
            }
            else if (Expirience.Value > 37)
            {
                MessageBox.Show("Стаж не может превышать 37 лет");
            }
            else
            {
                ListCrew.Add(new CrewMember(Name.Text, SecondName.Text, Age.Value, Convert.ToString(Position.SelectedItem), (int)Expirience.Value));
                MessageBox.Show("Член экипажа добавлен");
            }
        }

        private void End_Add_Crew_Click(object sender, EventArgs e)
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
    }
}
