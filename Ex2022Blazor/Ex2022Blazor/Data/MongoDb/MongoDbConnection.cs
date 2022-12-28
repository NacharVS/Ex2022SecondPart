using MongoDB.Driver;

namespace Ex2022Blazor.Data.MongoDb;

public class MongoDbConnection
{
    public User? User;
    public void AddToDatabase(User user)
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("Ex2022");
        var collection = database.GetCollection<User>("Users");
        collection.InsertOne(user);
    }
    
    public User? FindByEmail(string email)
    {
        var client = new MongoClient("mongodb://localhost");
        FilterDefinition<User> filter = Builders<User>.Filter.Eq("Email", email);
        var database = client.GetDatabase("Tenders");
        var collection = database.GetCollection<User>("Users");

        return collection.Find(filter).FirstOrDefault();
    }
}