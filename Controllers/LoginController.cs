using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controllers {
    public class LoginController {
        private static string CheckUserName(string username) {
            string response = "";

            if (username.Equals("")) {
                response = "Username cannot be empty";
            } else if (username.Length < 5 || username.Length > 15) {
                response = "Username must be between 5 and 15 characters";
            }

            return response;
        }
        public static string Login(string username, string password) {
            string response = CheckUserName(username);

            if (response.Equals("")) {
                response = RegisterController.CheckPassword(password);
            }

            return response;
        }
    }
}