using Logic.DAL;
using Logic.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Text;

namespace Logic.Services
{
    public class LoginService
    {
        private UserDataAccess _db;

        public LoginService()
        {

            _db = new UserDataAccess();
        }

        public bool Login(string username, string password)
        {

            List<User> users = _db.GetUsers();

            return users.Exists(user => user.Username.Equals(username) && user.Password.Equals(password));
        }

        public void AddUser(string userName, string password)
        {
            User user = new User();
            user.Username = userName;
            user.Password = password;
            List<User> users = _db.GetUsers();
            users.Add(user);
            _db.AddUser(users);
        }
    }
}
