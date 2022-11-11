using BilShoppen.Cars;
using BilShoppen.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BilShoppen
{
    /// <summary>
    /// Interaction logic for CarEditInfoWindow.xaml
    /// </summary>
    public partial class CarEditInfoWindow : Window
    {
        public CarEditInfoWindow()
        {
            InitializeComponent();
        }


        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;

            Car car = new()
            {
                carModel = Model_Edit_Input.Text,
                carBrand = Brand_Edit_Input.Text,
                carColor = Color_Edit_Input.Text,
                carDoors = Doors_Edit_Input.Text
            };
            AddData.AddCar(car, Int32.Parse(button.Uid));
            this.Close();

        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
