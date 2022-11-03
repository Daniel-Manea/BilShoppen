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

        public static async Task<int> GetCollectionCount(string collectionName)
        {
            Query collectionQuery = DB.db.Collection(collectionName);
            QuerySnapshot collectionQuerySnapshot = await collectionQuery.GetSnapshotAsync();
            return collectionQuerySnapshot != null ? collectionQuerySnapshot.Count : 0;
        }

    }
}
