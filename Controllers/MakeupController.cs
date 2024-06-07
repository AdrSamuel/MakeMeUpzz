using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MakeMeUpzz.Controllers {
    public class MakeupController {
        private static string CheckMakeupName(string name) {
            string response = "";

            if (name.Equals("")) {
                return "Name must not empty";
            } else if (!(name.Length > 0 && name.Length < 100)) {
                response = "Name must have 1 – 99 characters";
            }

            return response;
        }

        private static string CheckMakeupPrice(string price) {
            string response = "";
            int priceNumber = isNumber(price);

            if (price.Equals("")) {
                response = "Price must not empty";
            } else if (priceNumber.Equals(-1)) {
                response = "Price must be a number";
            } else if (!(priceNumber >= 1)) {
                response = "Price must bigger then 0";
            }

            return response;
        }

        private static string CheckMakeupWeight(string weight) {
            string response = "";

            int weightNumber = isNumber(weight);

            if (weight.Equals("")) {
                response = "Weight must not empty";
            } else if (weightNumber.Equals(-1)) {
                response = "Weight must be a number";
            } else if (!(weightNumber > 0 && weightNumber < 1500)) {
                response = "Weight must not exceed 1500 grams";
            }

            return response;
        }

        private static string CheckMakeupTypeID(string typeID) {
            string response = "";

            int typeNumber = isNumber(typeID);

            if (typeID.Equals("")) {
                response = "Type ID must not empty";
            } else if (typeNumber.Equals(-1)) {
                response = "Type ID must be a number";
            }

            return response;
        }

        private static string CheckMakeupBrandID(string brandID) {
            string response = "";

            int brandNumber = isNumber(brandID);

            if (brandID.Equals("")) {
                response = "Brand ID must not empty";
            } else if (brandNumber.Equals(-1)) {
                response = "Brand ID must be a number";
            }

            return response;
        }


        public static string CheckMakeup(string name, string price, string weight, string typeID, string brandID) {

            string response = CheckMakeupName(name);

            if (response.Equals("")) {
                response = CheckMakeupPrice(price);
            }

            if (response.Equals("")) {
                response = CheckMakeupWeight(weight);
            }

            if (response.Equals("")) {
                response = CheckMakeupTypeID(typeID);
            }

            if (response.Equals("")) {
                response = CheckMakeupBrandID(brandID);
            }

            return response;
        }

        private static string CheckBrandRating(string rating) {
            string response = "";

            int ratingNumber = isNumber(rating);

            if (rating.Equals("")) {
                return "Rating must not empty";
            } else if (rating.Equals(-1)) {
                return "Rating must be a number";
            } else if (!(ratingNumber >= 0 && ratingNumber <= 100)) {
                response = "Rating must between 0 - 100";
            }

            return response;
        }

        public static string CheckMakeupBrand(string name, string rating) {
            string response = CheckMakeupName(name);

            if (response.Equals("")) {
                response = CheckBrandRating(rating);
            }

            return response;
        }

        public static string CheckMakeupType(string name) {
            string response = CheckMakeupName(name);

            return response;
        }

        private static int isNumber(string value) {
            int number;
            bool result = int.TryParse(value, out number);

            if (result) {
                return number;
            } else {
                return -1;
            }

        }

        public static List<Makeup> GetAllMakeup() {
            return HandlerMakeup.GetAllMakeup();
        }

        public static void InsertMakeup(string name, int price, int weight, int typeID, int brandID) {
            HandlerMakeup.InsertMakeup(name, price, weight, typeID, brandID);
        }

        public static Makeup GetMakeupByID(int id) {
            return HandlerMakeup.GetMakeupByID(id);
        }

        public static void UpdateMakeup(int id, string name, int price,
            int weight, int typeID, int brandID) {
            HandlerMakeup.UpdateMakeup(id, name, price, weight, typeID, brandID);
        }

        public static void DeleteMakeup(int id) {
            HandlerMakeup.DeleteMakeup(id);
        }
    }
}