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
using System.Windows.Shapes;

namespace BilShoppen
{
    /// <summary>
    /// Interaction logic for NewUserWindow.xaml
    /// </summary>
    public partial class NewUserWindow : Window
    {
        public NewUserWindow()
        {
            InitializeComponent();
        }

        public static void DoWork()
        {
            MessageBox.Show("Hello world");
        }

        private void Button_Click_Save_User(object sender, RoutedEventArgs e)
        {
            User user = new()
            {
                firstname = First_Name_Input.Text,
                lastname = Last_Name_Input.Text,
                email = Email_Input.Text
            };
            AddData.AddUser(user);

            this.Close();

        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {

        }
    }
}
