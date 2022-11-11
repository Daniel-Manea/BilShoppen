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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class NewCarWindow : Window
    {
        public NewCarWindow()
        {
            InitializeComponent();
        }

        private void Save_Add_Car_Button_Click(object sender, RoutedEventArgs e)
        {
            Car car = new();
            {
                car.carBrand = Car_Brand_Input.Text;
                car.carModel = Car_Model_Input.Text;
                car.carColor = Car_Colour_Input.Text;
                car.carDoors = Car_Doors_Input.Text;
            };
            AddData.AddCar(car);

            this.Close();
        }

        private void Cansel_Add_Car_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}