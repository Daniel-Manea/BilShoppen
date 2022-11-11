using BilShoppen.Database;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilShoppen.Cars
{
    internal class CarsList
    {

        public static async Task<Dictionary<string, Car>> GetCarsList()
        {

            QuerySnapshot documentsQuery = await GetData.GetDocuments("cars");
            Dictionary<string, Car> carDictionary = new Dictionary<string, Car>();
            List<object> carsList = new List<object>();


            foreach (DocumentSnapshot documentSnapshot in documentsQuery.Documents)
            {
                Dictionary<string, object> carDictionary2 = documentSnapshot.ToDictionary();

                Car car = new Car();

                foreach (KeyValuePair<string, object> info in carDictionary2)
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
                    carsList.Add(car);
                }
                carDictionary.Add(documentSnapshot.Id, car);
            }

            return carDictionary;
            
        }
        }
}
