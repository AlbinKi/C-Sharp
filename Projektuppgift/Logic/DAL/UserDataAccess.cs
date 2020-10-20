using Logic.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Logic.DAL
{
    public class UserDataAccess
    {
        private const string path = @"DAL\User.json";

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            StreamReader sr = new StreamReader(path);

            string jsonString = sr.ReadToEnd();
            List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString);
            sr.Close();

            return users;
        }

        public void AddUser(List<User> users)
        {
            StreamWriter sw = new StreamWriter(path);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,

            };

            var jsonObject = JsonSerializer.Serialize(users, options);

            sw.Write(jsonObject);
            sw.Close();
        }

    }
}
