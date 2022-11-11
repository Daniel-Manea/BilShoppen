using BilShoppen.Database;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilShoppen.Users
{
    internal class UsersList
    {
        public static async Task<Dictionary<string, User>> GetUsersList()
        {

            QuerySnapshot documentsQuery = await GetData.GetDocuments("users");
            Dictionary<string, User> userDictionary = new();
            List<object> usersList = new();


            foreach (DocumentSnapshot documentSnapshot in documentsQuery.Documents)
            {
                Dictionary<string, object> user = documentSnapshot.ToDictionary();

                User user1 = new();

                foreach (KeyValuePair<string, object> info in user)
                {
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
            }

            return userDictionary;

        }
    }
}
