using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace lb_16_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<User> users;
        public MainWindow()
        {
            InitializeComponent();
            users = new ObservableCollection<User>() { new User("Пользователь 1", 1000.123),
            new User("Пользователь 2", 15321.138), new User("Пользователь 3", 0), new User("Пользователь 4", -31231.41)};
            usersDataTable.ItemsSource = users;
        }
    }
}
