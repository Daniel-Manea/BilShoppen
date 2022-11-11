using BilShoppen.Database;
using BilShoppen.Users;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
    /// Interaction logic for UsersListWindow.xaml
    /// </summary>
    /// 

    public partial class UsersListWindow : Window
    {

        public UsersListWindow() => InitializeComponent();

        public static async void Button_Click_EditUserInfo(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;

            UserEditInfoWindow userEditInfoWindow = new();

            Dictionary<string, object>? userDocument = await GetData.GetDocument("users", $"{button.Uid}");
            User user = new User();

            if (userDocument != null)
            foreach (KeyValuePair<string, object> info in userDocument)
            {
                    

                    if (info.Key == "Firstname")
                    {
                        user.firstname = info.Value.ToString();
                    }

                    if (info.Key == "Lastname")
                    {
                        user.lastname = info.Value.ToString();
                    }

                    if (info.Key == "E-Mail")
                    {
                        user.email = info.Value.ToString();
                    }
                }

            userEditInfoWindow.First_Name_Edit_Input.Text = user.firstname;
            userEditInfoWindow.Last_Name_Edit_Input.Text = user.lastname;
            userEditInfoWindow.Email_Edit_Input.Text = user.email;

            userEditInfoWindow.Save_Button.Uid = button.Uid;

            userEditInfoWindow.Show();
            


        }
    }
}
