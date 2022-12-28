using Ex2022Timurshin320.Data.Users;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace Ex2022Timurshin320.Data.DB
{
    public static class DBConnection
    {
        private static MongoClient client = new MongoClient("mongodb://localhost");
        internal static readonly IMongoDatabase db = client.GetDatabase("Ex2022Timurshin320");
        internal static readonly IMongoCollection<AppUser> users = db.GetCollection<AppUser>("Users");
        internal static readonly GridFSBucket gridFS = new GridFSBucket(db);
    }
}