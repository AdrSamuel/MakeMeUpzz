using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controllers {
    public class ProfileController {
        public static string UpdatePass(string oldPass, string newPass) {

            string response = RegisterController.CheckPassword(oldPass);

            if (response.Equals("")) {
                response = RegisterController.CheckPassword(newPass);
            }

            return response;
        }


        public static string UpdateProfile(string email, string gender, DateTime dob) {

            string response = RegisterController.CheckUserEmail(email);


            if (response.Equals("")) {
                response = RegisterController.CheckGender(email);
            }

            if (response.Equals("")) {
                response = RegisterController.CheckDob(dob);
            }

            return response;
        }
        public static string UpdateProfile(string username, string email, string gender, DateTime dob) {

            string response = RegisterController.CheckUserName(username);

            if (response.Equals("")) {
                response = RegisterController.CheckUserEmail(email);
            }

            if (response.Equals("")) {
                response = RegisterController.CheckGender(email);
            }

            if (response.Equals("")) {
                response = RegisterController.CheckDob(dob);
            }

            return response;
        }

    }
}