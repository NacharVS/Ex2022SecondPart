using ExamSecondWpf.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondWpf
{
    public class MongoConnection
    {
        public IMongoDatabase Connection;

        public MongoConnection()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            Connection = client.GetDatabase("ShopSafiullin320");
        }

        public void AddPurchaseInfo(Purchase pur)
        {
            var collection = Connection.GetCollection<Purchase>("Purchases");

            collection.InsertOne(pur);
        }
    }
}
