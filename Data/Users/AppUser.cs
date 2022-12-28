using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System.Linq;

namespace Ex2022Timurshin320.Data.Users
{
    [BsonIgnoreExtraElements]
    public class AppUser
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        [BsonIgnoreIfNull]
        public string FirstName { get; set; } = "Иван";
        [BsonIgnoreIfNull]
        public string LastName { get; set; } = "Иванович";

        [BsonIgnoreIfNull]
        public string PhotoId { get; set; }

        public virtual string IsValid()
        {
            if (Email == "" || !Email.Contains('@')) return "Неверный email!";
            if (Password == "") return "Неверный пароль!";
            return "";
        }
    }
}
