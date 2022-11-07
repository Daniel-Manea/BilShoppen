using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilShoppen.Database
{
    internal class GetData
    {
        public static Dictionary<string, User> userDictionary = new Dictionary<string, User>();


        public static async Task<int> GetCollectionCount(string collectionName)
        {
            Query collectionQuery = DB.db.Collection(collectionName);
            QuerySnapshot collectionQuerySnapshot = await collectionQuery.GetSnapshotAsync();
            return collectionQuerySnapshot != null ? collectionQuerySnapshot.Count : 0;
        }

        public static async void GetDocuments(string collectionName)
        {
            List<object> usersList = new List<object>();

            Dictionary<string, User> userDictionary = new Dictionary<string, User>();   


            Query usersQuery = DB.db.Collection(collectionName);
            QuerySnapshot usersQuerySnapshot = await usersQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot documentSnapshot in usersQuerySnapshot.Documents)
            {
                Console.WriteLine("Document data for {0} document:", documentSnapshot.Id);
                Dictionary<string, object> user = documentSnapshot.ToDictionary();

                User user1 = new User();



                foreach (KeyValuePair<string, object> info in user)
                {
                    
                    //Console.WriteLine("{0}: {1}", info.Key, info.Value);


                    //user1.firstname = info.Key.Equals("Firstname").ToString();
                    //user1.lastname = info.Key.Equals("Lastname").ToString();
                    //user1.email = info.Key.Equals("E-Mail").ToString();

                    if (info.Key == "Firstname")
                    {
                        user1.firstname = info.Value.ToString();
                    }

                    if (info.Key == "Lastname")
                    {
                        user1.lastname = info.Value.ToString();
                    }

                    if (info.Key == "E-Mail")
                    {
                        user1.email = info.Value.ToString();
                    }
                    usersList.Add(user1);
                }
                userDictionary.Add(documentSnapshot.Id, user1);

                //Console.WriteLine(usersList);
            }


            //GetUsers.ShowData(userDictionary);
            


            //return userDictionary;
        }
    }
}
