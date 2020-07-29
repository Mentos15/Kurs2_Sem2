using Lab7_8.Json;
using Lab7_8.Task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;

            //Заполняем меню смены языка:
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLanguage.Items.Add(menuLang);
            }
        }

        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Serialization.Load();
            dataGrid.ItemsSource = TaskList.taskList;
            foreach (var x in TaskList.taskList)
            {
                TaskList.list.Add(x);
            }
            Date.SelectedDate = DateTime.Now;
        }
        private void About_click(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Версия: 2.0\nВладелец: Дмитрий");
        }
        private void Make_click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.ShowDialog();
        }
        private void Save_click(object sender, RoutedEventArgs e)
        {
            Serialization.Save(TaskList.taskList);
        }
        private void SType_click(object sender, RoutedEventArgs e)
        {
            string FilterText = Type.Text.ToLower();
            TaskList.taskList.Clear();
            foreach (var x in TaskList.list)
            {
                if (x.Type.ToLower().Contains(FilterText))
                {
                    TaskList.taskList.Add(x);
                }
            }
        }
        private void SDescription_click(object sender, RoutedEventArgs e)
        {
            string FilterText = Description.Text.ToLower();
            TaskList.taskList.Clear();
            foreach (var x in TaskList.list)
            {
                if (x.Information.ToLower().Contains(FilterText))
                {
                    TaskList.taskList.Add(x);
                }
            }
        }
        private void SCal_click(object sender, RoutedEventArgs e)
        {
            DateTime FilterDate = (DateTime)Date.SelectedDate;
            TaskList.taskList.Clear();
            foreach (var x in TaskList.list)
            {
                if (FilterDate == x.EndDate)
                {
                    TaskList.taskList.Add(x);
                }
            }
        }
        private void SClear_click(object sender, RoutedEventArgs e)
        {
            TaskList.taskList.Clear();
            foreach(var x in TaskList.list)
            {
                TaskList.taskList.Add(x);
            }
        }
        private void Local_click(object sender, EventArgs e)
        {
            
        }
        private void Close_click(object sender, EventArgs e)
        {
            
        }
    }
}
