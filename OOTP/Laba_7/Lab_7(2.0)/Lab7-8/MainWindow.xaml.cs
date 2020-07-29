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
        private string _categ;
        public MainWindow()
        {
            InitializeComponent();
            List<string> styles = new List<string> { "Pink", "Dark" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "Dark";
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

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            // определяем путь к файлу ресурсов
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
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
            dataGrid.ItemsSource = TaskList.worklist;
            foreach (var x in TaskList.worklist)
            {
                TaskList.list.Add(x);
            }
            
        }
        private void About_click(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Версия: 2.0\nВладелец: Виталий");
        }
        private void Make_click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.ShowDialog();
        }
        private void Save_click(object sender, RoutedEventArgs e)
        {
            Serialization.Save(TaskList.worklist);
        }
        private void Search_click(object sender, RoutedEventArgs e)
        {
            string FilterText = Type.Text.ToLower();
            TaskList.worklist.Clear();
            foreach (var x in TaskList.list)
            {
                if (x.Type.ToLower().Contains(FilterText))
                {
                    TaskList.worklist.Add(x);
                }
            }
        }

        private void SClear_click(object sender, RoutedEventArgs e)
        {
            TaskList.worklist.Clear();
            foreach(var x in TaskList.list)
            {
                TaskList.worklist.Add(x);
            }
        }
        private void SortByDate_click(object sender, ExecutedRoutedEventArgs e)
        {
            var sortedlist = TaskList.list.OrderBy(x => x.EndDate).ToList();
            TaskList.worklist.Clear();
            foreach (var x in sortedlist)
            {
                TaskList.worklist.Add(x);
            }

        }
        private void Local_click(object sender, EventArgs e)
        {
            
        }
        private void Close_click(object sender, EventArgs e)
        {
            
        }

        private void Filter_click(object sender, ExecutedRoutedEventArgs e)
        {
            if (EndDate.SelectedDate == null || (DateTime)EndDate.SelectedDate <= DateTime.Now)
            {
                MessageBox.Show("Выберите корректную дату завершения");
            }
            else
            {
                string FilterText = Type.Text.ToLower();
                TaskList.worklist.Clear();
                foreach (var x in TaskList.list)
                {
                    if (x.Type == _categ && x.EndDate == (DateTime)EndDate.SelectedDate)
                    {
                        TaskList.worklist.Add(x);
                    }
                }
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
