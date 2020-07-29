using Lab_7.Models;
using Lab_7.ReadAndWrite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
 


namespace Lab_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string Path = $"{Environment.CurrentDirectory}\\todoData.json";
        private IOServise _fileIOservice;
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            DateGrid.Visibility = Visibility.Collapsed;
            DateGrid.ItemsSource = TaskList.taskList;
          

        }

        private void _todoData_ListChanged(object sender, ListChangedEventArgs e)
        {

            if(e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _fileIOservice.SaveData(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Close();
                }

            }
        }
        public void ADD(ToDoModels mod)
        {
            todoData.Add(mod);
            DateGrid.ItemsSource = todoData;
            todoData.ListChanged += _todoData_ListChanged;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        public void Add_Task(object sender, RoutedEventArgs e)
        {
            Add_Task add_task = new Add_Task();
            add_task.ShowDialog();

        }

        private void OutPut_Click(object sender, RoutedEventArgs e)
        {
            DateGrid.Visibility = Visibility.Visible;
        }
    }
}
