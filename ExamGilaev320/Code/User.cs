using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ExamGilaev320.Code
{
    public class User
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public string email;
        public string password;
        public string name;
        public string surname;

        public User(string name, string surname, string email, string password)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
        }
    }
}
