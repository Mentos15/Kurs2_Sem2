using Lab7_8.Task;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab7_8
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        static int i = 1;
        private string _categ;
        public Window1()
        {
            InitializeComponent();
        }
        void Add_do(object sender, RoutedEventArgs e)
        {
            if (Date.SelectedDate == null || (DateTime)Date.SelectedDate <= DateTime.Now)
            {
                MessageBox.Show("Выберите корректную дату завершения");
            }
            else
            {
                TaskList.list.Add(new Tasks(_categ, TextMore.Text, (DateTime)Date.SelectedDate));
                TaskList.worklist.Add(new Tasks(_categ, TextMore.Text, (DateTime)Date.SelectedDate));
                i++;
                Close();
            } 
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                _categ = item.Content.ToString();
            }
        }
    }
}
