using BilShoppen.Database;
using Google.Cloud.Firestore;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace BilShoppen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_New_User(object sender, RoutedEventArgs e)
        {

            NewUserWindow newUserWindow = new NewUserWindow();
            newUserWindow.Show();

        }

        private void Button_Click_Add_Car(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Users_List(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Cars_List(object sender, RoutedEventArgs e)
        {

        }
    }
}
