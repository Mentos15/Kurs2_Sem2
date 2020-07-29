using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;


namespace Laba_5
{
    public partial class CreateObject : Form
    {
        public Airaport air;
        public CreateObject()
        {
            InitializeComponent();
        }

        private void Create_object_Click(object sender, EventArgs e)
        {


            this.Hide();
            SwitchForms.Plain.Show();

            SwitchForms.Crew.ListCrew = new List<CrewMember>(3);
        }

        private void Save_object_Click(object sender, EventArgs e)
        {
            if (SwitchForms.CreateObject.air == null)
            {
                MessageBox.Show("Объект не создан");
            }
            else
            {
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Airaport));
                using (FileStream stream = new FileStream(@"C:\Users\Виталий\2_KURS_2_SEM\OOTP\Laba_5\json.txt", FileMode.OpenOrCreate))
                {
                    json.WriteObject(stream, SwitchForms.CreateObject.air);
                }
                MessageBox.Show("Объект сохранен в файл json.txt");
            }
        }

        private void Output_object_Click(object sender, EventArgs e)
        {
            if (SwitchForms.CreateObject.air == null)
            {
                MessageBox.Show("Объект не создан");
            }
            else if (!File.Exists(@"C:\Users\Виталий\2_KURS_2_SEM\OOTP\Laba_5\json.txt"))
            {
                MessageBox.Show("Объект не сохранен");
            }
            else
            {
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Airaport));
                using (FileStream stream = new FileStream(@"C:\Users\Виталий\2_KURS_2_SEM\OOTP\Laba_5\json.txt", FileMode.Open))
                {
                    Airaport newAir = (Airaport)json.ReadObject(stream);
                    richTextBox1.Text = newAir.PlaneInfo();
                    richTextBox2.Text = newAir.CrewInfo();
                }
            }
        }
    }

    
}
