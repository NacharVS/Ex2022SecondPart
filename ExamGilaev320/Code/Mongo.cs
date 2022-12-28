using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Text.Json;

namespace ExamGilaev320.Code
{
    public static class Mongo
    {
        public static IMongoDatabase db = new MongoClient("mongodb://localhost").GetDatabase("ExamWorkData");

        public static void AddToDataBase(User user)
        {
            var collection = db.GetCollection<User>("ExamWorkData");
            collection.InsertOne(user);
        }

        public static User FindByName(string email)
        {
            var collection = db.GetCollection<User>("ExamWorkData");
            var unit = collection.Find(x => x.email == email).FirstOrDefault();
            return unit;
        }

        public static IMongoCollection<User> GetCollection()
        {
            var filter = new BsonDocument();
            var collection = db.GetCollection<User>("ExamWorkData");

            return collection;
        }
        public static void ReplaceByName(string email, User user)
        {
            var filter = new BsonDocument("email", email);
            var collection = db.GetCollection<User>("ExamWorkData");
            collection.ReplaceOne(filter, user);
        }

        internal static User TakeUnit(string? name)
        {
            var simpleProjection = Builders<User>.Projection.
            Exclude("none");
            BsonClassMap.RegisterClassMap<User>();
            var filter = Builders<User>.Filter.Eq("name", name);
            var collection = db.GetCollection<User>("ExamWorkData");
            return collection.Find(filter).Project<User>(simpleProjection).FirstOrDefault();
        }
    }
}
