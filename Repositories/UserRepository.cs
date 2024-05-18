using MakeMeUpzz.Factories;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories {
    public class UserRepository {
        private static MakeMeUpzzDatabaseEntities _instance = DatabaseSingleton.GetInstance();

        public static void CreateCustomer(string username, string email, string gender,
            string password, DateTime dob) {

            int id = _instance.Users.Any() ? GetHighestID() + 1 : 1;

            User user = UserFactory.Create(id, username, email, gender, password, dob);
            _instance.Users.Add(user);
            _instance.SaveChanges();
        }

        public static User CheckUser(string username, string password) {
            return (from x in _instance.Users where x.UserName.Equals(username)
                    && x.UserPassword.Equals(password) select x).FirstOrDefault();
        }

        public static string GetUserRole(string username) {
            return (from x in _instance.Users where x.UserName.Equals(username)
                    select x.UserRole).FirstOrDefault();
        }

        public static User GetUser(string username) {
            return (from x in _instance.Users where x.UserName.Equals(username)
                    select x).FirstOrDefault();
        }

        public static List<User> GetAllUser() {
            return (from x in _instance.Users select x).ToList();
        }

        private static int GetHighestID() {
            return _instance.Users.Max(x => x.UserID);
        }
    }
}