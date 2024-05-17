using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factories {
    public class UserFactory {

        public static User Create(int id, string name, string email,
            DateTime dob, string gender, string role, string password) {

            User user = new User() {
                UserID = id,
                UserName = name,
                UserEmail = email,
                UserDOB = dob,
                UserGender = gender,
                UserRole = role,
                UserPassword = password
            };

            return user;
        }
    }
}