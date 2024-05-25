using MakeMeUpzz.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controllers {
    public class RegisterController {

        public static string CheckUserName(string username) {
            string response = "";
            bool nameExist = HandlerUser.GetUser(username) != null ? true : false; 

            if (username.Equals("")) {
                response = "Username cannot be empty";
            } else if (username.Length < 5 || username.Length > 15) {
                response = "Username must be between 5 and 15 characters";
            } else if (nameExist) {
                response = "Username taken";
            }

            return response;
        }

        public static string CheckUserEmail(string email) {
            string response = "";

            if (email.Equals("")) {
                response = "Email cannot be empty";
            } else if (!email.EndsWith(".com", StringComparison.OrdinalIgnoreCase)) {
                response = "Email must end with .com";
            }

            return response;
        }

        public static string CheckGender(string gender) {
            string response = "";

            if (gender.Equals("")) {
                response = "Gender must be chosen";
            }

            return response;
        }

        public static string CheckPassword(string password) {
            string response = "";

            if (password.Equals("")) {
                response = "Password cannot be empty";
            } else if (password.Length < 5 || password.Length > 15) {
                response = "Password must be between 5 and 15 characters";
            }

            return response;
        }

        private static string CheckConfPassword(string confPassword, string password) {
            string response = "";

            if (confPassword.Equals("")) {
                response = "Confirm Password cannot be empty";
            } else if (!confPassword.Equals(password)) {
                response = "Password must match";
            }

            return response;
        }

        public static string CheckDob(DateTime dob) {
            string response = "";

            if (dob == DateTime.MinValue) {
                response = "Date must be chosen";
            }

            return response;
        }

        public static string Register(string username, string email,
            string gender, string password, string confPassword, DateTime dob) {

            string response = CheckUserName(username);

            if (response.Equals("")) {
                response = CheckUserEmail(email);
            }

            if (response.Equals("")) {
                response = CheckGender(gender);
            }

            if (response.Equals("")) {
                response = CheckPassword(password);
            }

            if (response.Equals("")) {
                response = CheckConfPassword(confPassword, password);
            }

            if (response.Equals("")) {
                response = CheckDob(dob);
            }

            return response;
        }
    }
}