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
        static public async void AddUser(User user)
        {
            int UserCount = await GetData.GetCollectionCount("users");

            DocumentReference docRef = DB.db.Collection("users").Document((UserCount + 1).ToString());

            Dictionary<string, object?> userInfo = new()
            {
                {"Firstname", user.firstname },
                {"Lastname", user.lastname },
                {"E-Mail", user.email },
            };

            await docRef.SetAsync(userInfo);
        }


        public void SetUserData()
        {
           
        }

    }

    
}