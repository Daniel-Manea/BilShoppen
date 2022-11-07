using BilShoppen.Database;
using BilShoppen.Users;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Google.Rpc.Context.AttributeContext.Types;
using static System.Net.Mime.MediaTypeNames;

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
            DB.Initialize();
        }

        private void Button_Click_New_User(object sender, RoutedEventArgs e)
        {

            NewUserWindow newUserWindow = new();
            newUserWindow.Show();
        }

        private void Button_Click_Add_Car(object sender, RoutedEventArgs e)
        {

        }


        private async void Button_Click_Users_List(object sender, RoutedEventArgs e)
        {
            UsersListWindow usersListWindow = new();
            var usersList = await UsersList.GetUsersList();
            if (usersList != null)
            foreach (KeyValuePair<string, User> user in usersList)
            {
                    //string? TextBlock = $"ID: {user.Key} - Name: {user.Value.firstname} {user.Value.lastname}";

                    Button button = new()
                    {
                        Margin = new Thickness(10, 0, 10, 0),
                        Padding = new Thickness(15)
                    };
                    Label label = new()
                    {
                        Margin = new Thickness(10, 0, 10, 0),
                        VerticalAlignment = VerticalAlignment.Center,
                        Padding = new Thickness(15)
                    };
                    var newStackPanel = new StackPanel() {
                        Orientation = Orientation.Horizontal
                    };

                    button.Content = "Click";
                    label.Content = $"ID: {user.Key} - Name: {user.Value.firstname} {user.Value.lastname}";
                    newStackPanel.Children.Add(button);
                    newStackPanel.Children.Add(label);

                    usersListWindow.UsersListBox.Items.Add(newStackPanel);
            }
            usersListWindow.Show();
        }

        private void Button_Click_Cars_List(object sender, RoutedEventArgs e)
        {

        }
    }
}
