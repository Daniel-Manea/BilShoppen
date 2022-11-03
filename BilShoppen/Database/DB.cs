using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilShoppen.Database
{
    class DB
    {
        public static void Initialize()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Database/db-config.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
        }
        private static readonly string project = "car-dealership-366710";
        public static readonly FirestoreDb db = FirestoreDb.Create(project);

    }
}
