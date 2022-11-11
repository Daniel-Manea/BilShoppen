using BilShoppen.Cars;
using BilShoppen.Database;
using BilShoppen.Users;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


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

            NewCarWindow newCarWindow = new();
            newCarWindow.Show();

        }

        private async void Button_Click_Users_List(object sender, RoutedEventArgs e)
        {
            UsersListWindow usersListWindow = new();
            var usersList = await UsersList.GetUsersList();
            if (usersList.Count > 0)
            {

                foreach (KeyValuePair<string, User> user in usersList)
                {
                    //string? TextBlock = $"ID: {user.Key} - Name: {user.Value.firstname} {user.Value.lastname}";

                    Button button = new()
                    {
                        Name = $"User_{user.Key}",
                        Uid = user.Key.ToString(),
                        Margin = new Thickness(10, 0, 10, 0),
                        Padding = new Thickness(15)
                    };
                    Label label = new()
                    {
                        Margin = new Thickness(10, 0, 10, 0),
                        VerticalAlignment = VerticalAlignment.Center,
                        Padding = new Thickness(15)
                    };
                    var newStackPanel = new StackPanel()
                    {
                        Orientation = Orientation.Horizontal
                    };

                    button.Click += UsersListWindow.Button_Click_EditUserInfo;
                    button.Content = "Edit user info";
                    label.Content = $"ID: {user.Key} - Name: {user.Value.firstname} {user.Value.lastname}";
                    newStackPanel.Children.Add(button);
                    newStackPanel.Children.Add(label);

                    usersListWindow.UsersListBox.Items.Add(newStackPanel);
                }
                usersListWindow.Show();
                    
            }
            else
            {
                MessageBox.Show("No users in the Database");
            }

        }
       

        private async void Button_Click_Cars_List(object sender, RoutedEventArgs e)
        {
            CarsListWindow carsListWindow = new();
            var carsList = await CarsList.GetCarsList();
            if (carsList.Count > 0)
            {

                foreach (KeyValuePair<string, Car> car in carsList)
                {
                    //string? TextBlock = $"ID: {user.Key} - Name: {user.Value.firstname} {user.Value.lastname}";

                    Button button = new()
                    {
                        Name = $"Car_{car.Key}",
                        Uid = car.Key.ToString(),
                        Margin = new Thickness(10, 0, 10, 0),
                        Padding = new Thickness(15)
                    };
                    Label label = new()
                    {
                        Margin = new Thickness(10, 0, 10, 0),
                        VerticalAlignment = VerticalAlignment.Center,
                        Padding = new Thickness(15)
                    };
                    var newStackPanel = new StackPanel()
                    {
                        Orientation = Orientation.Horizontal
                    };


                    button.Click += CarsListWindow.Button_Click_EditCarInfo;
                    button.Content = "Edit car info";
                    label.Content = $"ID: {car.Key} - Brand: {car.Value.carBrand} - Model: {car.Value.carModel} - Color: {car.Value.carColor} - Doors: {car.Value.carDoors}";
                    newStackPanel.Children.Add(button);
                    newStackPanel.Children.Add(label);

                    carsListWindow.CarsListBox.Items.Add(newStackPanel);
                }
                carsListWindow.Show();

            }
            else
            {
                MessageBox.Show("No cars in the Database");
            }
        }
    }
}
