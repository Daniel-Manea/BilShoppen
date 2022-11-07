using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BilShoppen.Database
{
    internal class GetUsers
    {
        public static Dictionary<string, User>? _users = null;

        public static void ShowData(Dictionary<string, User> userDictionary)
        {
            _users = userDictionary;
            foreach (KeyValuePair<string, User> pair in userDictionary)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value.firstname);
                
            }
        }


    }
}

