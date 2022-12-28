using MongoDB.Bson;

namespace Sabirzyanov320ExamRegistration.Data.Entities;

public class User
{
    public ObjectId Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public User(ObjectId id, string firstName, string lastName, string email, string password, string photoRoute)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    public User()
    {
        
    }
}