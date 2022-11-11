using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace BilShoppen.Database
{
    internal class AddData
    {
        static public async void AddUser(User user, int? id = null)
        {

            Dictionary<string, object?> userInfo = new()
            {
                {"Firstname", user.firstname },
                {"Lastname", user.lastname },
                {"E-Mail", user.email },
            };

            if (id == null)
            {
                int UserCount = await GetData.GetCollectionCount("users");

               DocumentReference docRef = DB.db.Collection("users").Document((UserCount + 1).ToString());
                await docRef.SetAsync(userInfo);
            } else
            {
                DocumentReference docRef = DB.db.Collection("users").Document((id).ToString());
                await docRef.SetAsync(userInfo);
            }
        }

        static public async void AddCar(Cars.Car car, int? id = null)
        {

            Dictionary<string, object?> carInfo = new()
            {
                {"Brand", car.carBrand },
                {"Model", car.carModel },
                {"Color", car.carColor },
                { "Doors", car.carDoors }
            };

            if (id == null)
            {
                int CarCount = await GetData.GetCollectionCount("cars");

                DocumentReference docRef = DB.db.Collection("cars").Document((CarCount + 1).ToString());
                await docRef.SetAsync(carInfo);
            }
            else
            {
                DocumentReference docRef = DB.db.Collection("cars").Document((id).ToString());
                await docRef.SetAsync(carInfo);
            }
        }

    }

    
}