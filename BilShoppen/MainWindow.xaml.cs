using BilShoppen.Database;
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
            DB.InitializeDB();
            InitializeComponent();

        }

       public class User
        {
            private string firstname = "unknown";

            private string lastname = "unknown";

            private object Name = "unknown";


            protected void SetName()
            {
               Name = new { FirstName = "Daniel", LastName = "Manea" };
            }

            public static object GetName()
            {

                return new { FirstName = "Daniel", LastName = "Manea" }; ;
            }
        }

        private void Button_Click_Ny(object sender, RoutedEventArgs e)
        {
    
            DB.AddUser(User.GetName());
        }
        private void Button_Click_Åben(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_Email(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_Gem(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_Afslut(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
