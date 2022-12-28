using MongoDB.Bson;
using MongoDB.Driver;

namespace Exam.Data;

public class MongoConnection
{
    public IMongoCollection<User> GetCollection()
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("Exam");
        var collection = database.GetCollection<User>("Users");
        return collection;
    }

    public User Login(string mail, string password)
    {
        var collection = GetCollection();
        var user = collection.Find(x => x.Mail == mail && x.Password == password).FirstOrDefault();

        return user;
    }

    public void AddUser(User user)
    {
        var collection = GetCollection();
        collection.InsertOne(user);
    }

    public User FindByMail(string mail)
    {
        var collection = GetCollection();
        var filter = new BsonDocument("Mail", mail);
        return collection.Find(filter).FirstOrDefault();
    }
}