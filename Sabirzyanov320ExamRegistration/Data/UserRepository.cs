using MongoDB.Driver;
using Sabirzyanov320ExamRegistration.Data.Entities;

namespace Sabirzyanov320ExamRegistration.Data;

public class UserRepository
{
    public static User GetUserByEmail(string email)
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("Exam");
        var collection = database.GetCollection<User>("User");
        User user = collection.Find(x => x.Email == email).FirstOrDefault();
        return user;
    }

    public static void InsertUser(User user)
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("Exam");
        var collection = database.GetCollection<User>("User");
        collection.InsertOne(user);
        
    }
}