using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondWpf.Models
{
    public class Purchase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public string Id { get; set; }
        [BsonIgnoreIfDefault]
        public string UserName { get; set; }
        [BsonIgnoreIfDefault]
        public List<Item> Products { get; set; }
        [BsonIgnoreIfDefault]
        public int Price { get; set; }
        [BsonIgnoreIfDefault]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date { get; set; }

    }
}
