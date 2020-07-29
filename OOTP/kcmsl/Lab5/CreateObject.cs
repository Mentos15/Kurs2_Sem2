using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class CreateObject : Form
    {
        public Airport air;
        public CreateObject()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\Dmitry\Desktop\labs\ООП\Лабораторные\Lab5\json.txt"))
            {
                File.Delete(@"C:\Users\Dmitry\Desktop\labs\ООП\Лабораторные\Lab5\json.txt");
            }

            this.Hide();
            SwitchForms.Plain.Show();

            SwitchForms.Crew.ListCrew = new List<CrewMember>(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (SwitchForms.CreateObject.air == null)
            {
                MessageBox.Show("Объект не создан");
            }
            else if (!File.Exists(@"C:\Users\Dmitry\Desktop\labs\ООП\Лабораторные\Lab5\json.txt"))
            {
                MessageBox.Show("Объект не сохранен");
            }
            else
            {
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Airport));
                using (FileStream stream = new FileStream(@"C:\Users\Dmitry\Desktop\labs\ООП\Лабораторные\Lab5\json.txt", FileMode.Open))
                {
                    Airport newAir = (Airport)json.ReadObject(stream);
                    richTextBox1.Text = newAir.PlaneInfo();
                    richTextBox2.Text = newAir.CrewInfo();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (SwitchForms.CreateObject.air == null)
            {
                MessageBox.Show("Объект не создан");
            }
            else
            {
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Airport));
                using (FileStream stream = new FileStream(@"C:\Users\Dmitry\Desktop\labs\ООП\Лабораторные\Lab5\json.txt", FileMode.OpenOrCreate))
                {
                    json.WriteObject(stream, SwitchForms.CreateObject.air);
                }
                MessageBox.Show("Объект сохранен в файл json.txt");
            }
        }
    }
}
