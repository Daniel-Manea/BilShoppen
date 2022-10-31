﻿using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DocumentReference = Google.Cloud.Firestore.DocumentReference;

namespace BilShoppen.Database
{
    internal class DB
    {

        public static void InitializeDB()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"db-config.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
        }

        private static readonly string project = "car-dealership-366710";

        private static readonly FirestoreDb db = FirestoreDb.Create(project);

        static public async void AddUser(object userInfo)
        {
            DocumentReference docRef = db.Collection("users").Document("test");
            Dictionary<string, object> user = new()
            {
                {
                    "Name", userInfo
                },
            };
            await docRef.SetAsync(user);
        }
    }
}