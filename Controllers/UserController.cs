using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controllers {
    public class UserController {

        public static string Login(string username, string password) {
            return HandlerUser.Login(username, password);
        }

        public static void Register(string username, string email, string gender,
            string password, DateTime dob) {
            HandlerUser.Register(username, email, gender, password, dob);
        }

        public static void UpdateProfile(int id, string username, string email, string gender, DateTime dob) {
            HandlerUser.UpdateProfile(id, username, email, gender, dob);
        }

        public static void DeleteUser(int userID) {
            HandlerUser.DeleteUser(userID);
        }

        public static string CheckPassword(string password) {
            return HandlerUser.CheckPassword(password);
        }

        public static void UpdatePassword(string password, string username) {
            HandlerUser.UpdatePassword(password, username);
        }

        public static User GetUser(string username) {
            return HandlerUser.GetUser(username);
        }

        public static List<User> GetAllUser() {
            return HandlerUser.GetAllUser();
        }

        public static List<User> GetUserTypeList(string username) {
            return HandlerUser.GetUserTypeList(username);
        }

        public static List<string> GetGenderList() {
            return HandlerUser.GetGenderList();
        }

        public static string GetGender(string username) {
            return HandlerUser.GetGender(username);
        }

        public static int GetUserID(string username) {
            return HandlerUser.GetUserID(username);
        }

        public static User GetUserByID(int id) {
            return HandlerUser.GetUserByID(id);
        }

        public static string GetUserNameByID(int id) {
            return HandlerUser.GetUserNameByID(id);
        }

    }
}