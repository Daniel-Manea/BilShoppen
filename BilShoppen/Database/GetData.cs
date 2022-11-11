using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public static async Task<QuerySnapshot> GetDocuments(string collectionName)
        {
            Query collectionQuery = DB.db.Collection(collectionName);
            QuerySnapshot collectionQuerySnapshot = await collectionQuery.GetSnapshotAsync();

            return collectionQuerySnapshot;
        }


        public static async Task<Dictionary<string, object>?> GetDocument(string collectionName, string documentName)
        {
            DocumentReference docRef = DB.db.Collection(collectionName).Document(documentName);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                Console.WriteLine("Document data for {0} document:", snapshot.Id);
                Dictionary<string, object> response = snapshot.ToDictionary();
                return response;
            }
            else
            {
                Console.WriteLine("Document {0} does not exist!", snapshot.Id);

                return null;
            }
        }



    }
}
