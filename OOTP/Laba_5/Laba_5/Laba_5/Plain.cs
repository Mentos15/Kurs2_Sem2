﻿using System;
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
    public partial class Plain : Form
    {
        public int TackBar1Plain()
        {
            return trackBar1.Value;
        }
        public string RadioPlain()
        {
            if (radioButton1.Checked) { return radioButton1.Text; }
            else if (radioButton2.Checked) { return radioButton2.Text; }
            else if (radioButton3.Checked) { return radioButton3.Text; }
            else { return ""; }
        }
        public string ComboBox1Plain()
        {
            return Convert.ToString(Model.SelectedItem);
        }
        public int NumericUpDown1Plain()
        {
            return (int)ID.Value;
        }
        public DateTime DateTimePicker1Plain()
        {
            return dateTimePicker1.Value;
        }
        public Plain()
        {
            InitializeComponent();
            Model.Items.Add("Большой");
            Model.Items.Add("Скоростной");
            Model.Items.Add("Комфортабельный");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 10;
            trackBar1.Maximum = 100;
            label1.Text = Convert.ToString(trackBar1.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewCrew_Click(object sender, EventArgs e)
        {
            if (NumericUpDown1Plain() == 0 || NumericUpDown1Plain() > 100000)
            {
                MessageBox.Show("Введите корректный ID");
            }
            else if (RadioPlain() == "")
            {
                MessageBox.Show("Выберите тип самолета");
            }
            else if (ComboBox1Plain() == "")
            {
                MessageBox.Show("Выберите модель самолета");
            }
            else if (trackBar1.Value == 0)
            {
                MessageBox.Show("Выберите кол-во мест");
            }
            else if (DateTimePicker1Plain().Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Выберите корректный год выпуска");
            }
            else
            {
                this.Hide();
                SwitchForms.Crew.Show();
                SwitchForms.CreateObject.air = new Airaport(NumericUpDown1Plain(), RadioPlain(), ComboBox1Plain(), TackBar1Plain(), DateTimePicker1Plain());
            }
        }

        private void ID_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}