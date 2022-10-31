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
            DB.InitializeDB();
            InitializeComponent();
        }

        private void Button_Click_Save_User(object sender, RoutedEventArgs e)
        {

                User user = new User();
                user.firstname = First_Name_Input.Text;
                user.lastname = Last_Name_Input.Text;
                user.email = Email_Input.Text;
                DB.AddUser(user.GetName(), user.lastname);
         

        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {

        }
    }
}
