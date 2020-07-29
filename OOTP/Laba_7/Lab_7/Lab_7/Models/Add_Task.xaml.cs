using Lab_7.Models;
using Lab_7.ReadAndWrite;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Lab_7.Models
{
    /// <summary>
    /// Логика взаимодействия для Add_Task.xaml
    /// </summary>
    public partial class Add_Task : Window
    {
        
        private string _categ;
        private string _text;
        private DateTime? _date;
        public Add_Task()
        {
            InitializeComponent();
        }

        private void Add_task_Click(object sender, RoutedEventArgs e)
        {
            _text = text.Text;
            _date = calend.SelectedDate;
            ToDoModels task = new ToDoModels(_categ, _text, _date);
            MainWindow main = new MainWindow();
            main.ADD(task);
            this.Hide();
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
               _categ =  item.Content.ToString();
            }
        }
    }
}
