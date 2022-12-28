﻿using Ex2022Timurshin320.Data.Users;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Ex2022Timurshin320.Data.DB
{
    public class UsersContext
    {
        private IMongoCollection<AppUser> users = DBConnection.users;

        public AppUser GetUser(string id)
        {
            return users.Find(user => user.Id == id).FirstOrDefault();
        }

        public List<AppUser> GetUsersByRole(string role)
        {
            return users.Find(new BsonDocument("_t", role)).ToList();
        }

        public AppUser GetUserByEmail(string email)
        {
            return users.Find(user => user.Email == email).FirstOrDefault();
        }

        public void AddUser(AppUser user)
        {
            users.InsertOne(user);
        }

        public void UpdateUser(AppUser user)
        {
            users.ReplaceOne(u => u.Id == user.Id, user);
        }

        public void DeleteUser(string id)
        {
            users.DeleteOne(user => user.Id == id);
        }

        public void DeleteUserByEmail(string email)
        {
            users.DeleteOne(user => user.Email == email);
        }

        public List<AppUser> GetAllUsers()
        {
            return users.Find(user => true).ToList();
        }
        
        public AppUser Authenticate(string email, string password)
        {
            return users.Find(user => user.Email == email && user.Password == password).FirstOrDefault();
        }
    }
}
