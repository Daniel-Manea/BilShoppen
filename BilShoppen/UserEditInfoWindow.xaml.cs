using BilShoppen.Database;
using System;
using System.Windows;
using System.Windows.Controls;

namespace BilShoppen
{
    /// <summary>
    /// Interaction logic for UserEditInfoWindow.xaml
    /// </summary>
    public partial class UserEditInfoWindow : Window
    {
        public UserEditInfoWindow()
        {
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;

            User user = new()
            {
                firstname = First_Name_Edit_Input.Text,
                lastname = Last_Name_Edit_Input.Text,
                email = Email_Edit_Input.Text
            };
            AddData.AddUser(user, Int32.Parse(button.Uid));

            this.Close();
            
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
