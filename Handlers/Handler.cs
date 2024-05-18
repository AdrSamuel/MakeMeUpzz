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

        public static User GetUser(string username) {
            return UserRepository.GetUser(username);
        }

        public static List<User> GetAllUser() {
            return UserRepository.GetAllUser();
        }


    }
}