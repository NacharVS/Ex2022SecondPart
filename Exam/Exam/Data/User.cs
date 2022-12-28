using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Exam.Data;

public class User
{
    [BsonId] public ObjectId Id { get; set; }
    [BsonIgnoreIfDefault] public string FName { get; set; }
    [BsonIgnoreIfDefault] public string LName { get; set; }
    [BsonIgnoreIfDefault] public string Mail { get; set; }
    [BsonIgnoreIfDefault] public string Password { get; set; }
    
    public User() {}
    
    public User(string fName, string lName, string mail, string password)
    {
        FName = fName;
        LName = lName;
        Mail = mail;
        Password = password;
    }
}