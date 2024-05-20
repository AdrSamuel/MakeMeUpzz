using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handlers {
    public class Handler {
        public static string Login(string username, string password) {
            return UserRepository.CheckUser(username, password) != null ? "" : "Invalid credential";
        }

        public static void Register(string username, string email, string gender,
            string password, DateTime dob) {
            UserRepository.CreateCustomer(username, email, gender, password, dob);
        }

        public static void UpdateProfile(int id, string username, string email, string gender, DateTime dob) {
            UserRepository.UpdateProfile(id, username, email, gender, dob);
        }

        public static void UpdateProfile(int id, string email, string gender, DateTime dob) {
            UserRepository.UpdateProfile(id, email, gender, dob);
        }

        public static string CheckPassword(string password) {
            return UserRepository.CheckPassword(password) != null ? "" : "Wrong Password";
        }

        public static void UpdatePassword(string password,string username) {
            UserRepository.UpdatePassword(password, username);
        }

        public static User GetUser(string username) {
            return UserRepository.GetUser(username);
        }

        public static List<User> GetAllUser() {
            return UserRepository.GetAllUser();
        }

        public static List<User> GetUserTypeList(string username) {
            return UserRepository.GetUserTypeList(username);
        }

        public static List<string> GetGenderList() {
            return UserRepository.GetGenderList();
        }

        public static string GetGender(string username) {
            return UserRepository.GetGender(username);
        }

        public static int GetUserID(string username) {
            return UserRepository.GetUserID(username);
        }

        public static User GetUserByID(int id) {
            return UserRepository.GetUserByID(id);
        }

        public static string GetUserNameByID(int id) {
            return UserRepository.GetUserNameByID(id);
        }

    }
}