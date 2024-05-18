using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factories {
    public class UserFactory {

        public static User Create(int id, string name, string email,
            string gender, string password, DateTime dob) {

            User user = new User() {
                UserID = id,
                UserName = name,
                UserEmail = email,
                UserDOB = dob,
                UserGender = gender,
                UserRole = "Customer",
                UserPassword = password
            };

            return user;
        }
    }
}