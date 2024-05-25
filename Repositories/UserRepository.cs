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

        public static void UpdateProfile(int id, string username, string email, string gender, DateTime DoB) {

            User user = GetUserByID(id);

            user.UserName = username;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserDOB = DoB;

            _instance.SaveChanges();
        }

        public static void UpdateProfile(int id, string email, string gender, DateTime DoB) {

            User user = GetUserByID(id);

            user.UserEmail = email;
            user.UserGender = gender;
            user.UserDOB = DoB;

            _instance.SaveChanges();
        }

        public static void DeleteUser(int userID) {

            User user = GetUserByID(userID);

            _instance.Users.Remove(user);
            _instance.SaveChanges();
        }

        public static User CheckUser(string username, string password) {
            return (from x in _instance.Users where x.UserName.Equals(username)
                    && x.UserPassword.Equals(password) select x).FirstOrDefault();
        }

        public static User CheckPassword(string password) {
            return (from x in _instance.Users where x.UserPassword.Equals(password) select x).FirstOrDefault();
        }

        public static void UpdatePassword(string password, string username) {
            User user = GetUser(username);

            user.UserPassword = password;

            _instance.SaveChanges();
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

        public static List<User> GetUserTypeList(string username) {
            return (from x in _instance.Users
                    where x.UserName.Equals(username)
                    select x).ToList();
        }

        private static int GetHighestID() {
            return _instance.Users.Max(x => x.UserID);
        }

        public static List<string> GetGenderList() {
            return _instance.Users.Select(x => x.UserGender).Distinct().ToList();
        }

        public static string GetGender(string username) {
            return (from x in _instance.Users where x.UserName.Equals(username) select x.UserGender)
                .ToString();
        }

        public static int GetUserID(string username) {
            return (from x in _instance.Users where x.UserName.Equals(username) select x.UserID).FirstOrDefault();
        }

        public static User GetUserByID(int id) {
            return _instance.Users.FirstOrDefault(x => x.UserID == id);
        }

        public static string GetUserNameByID(int id) {
            return _instance.Users.Single(x => x.UserID == id).UserName;
        }

    }
}