using BilShoppen.Cars;
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
    /// Interaction logic for CarsListWindow.xaml
    /// </summary>
    public partial class CarsListWindow : Window
    {
        public CarsListWindow() => InitializeComponent();
        public static async void Button_Click_EditCarInfo(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;

            CarEditInfoWindow carEditInfoWindow = new();

            Dictionary<string, object>? carDocument = await GetData.GetDocument("cars", $"{button.Uid}");
            Car car = new();

            if (carDocument != null)
                foreach (KeyValuePair<string, object> info in carDocument)
                {


                    if (info.Key == "Brand")
                    {
                        car.carBrand = info.Value.ToString();
                    }

                    if (info.Key == "Model")
                    {
                        car.carModel = info.Value.ToString();
                    }

                    if (info.Key == "Color")
                    {
                        car.carColor = info.Value.ToString();
                    }
                    if (info.Key == "Doors")
                    {
                        car.carDoors = info.Value.ToString();
                    }
                }

            carEditInfoWindow.Brand_Edit_Input.Text = car.carBrand;
            carEditInfoWindow.Model_Edit_Input.Text = car.carModel;
            carEditInfoWindow.Color_Edit_Input.Text = car.carColor;
            carEditInfoWindow.Doors_Edit_Input.Text = car.carDoors;



            carEditInfoWindow.Save_Button.Uid = button.Uid;

            carEditInfoWindow.Show();



        }
    }
}
