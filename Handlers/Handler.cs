using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
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

        public static List<Makeup> GetAllMakeup() {
            return MakeupRepository.GetAllMakeup();
        }

        public static void AddToCart(int userID, int makeupID, int quantity) {
            CartRepository.CreateCart(userID, makeupID, quantity);
        }

        public static List<CartDTO> GetCart(int userID) {
            return CartRepository.GetCart(userID);
        }

        public static void ClearCart(int userID) {
            CartRepository.ClearCart(userID);
        }

        public static List<MakeupBrand> GetAllMakeupBrand() {
            return MakeupBrandRepository.GetAllMakeupBrand();
        }

        public static List<MakeupType> GetAllMakeupType() {
            return MakeupTypeRepository.GetAllMakeupType();
        }

        public static void InsertMakeup(string name, int price, int weight, int typeID, int brandID) {
            MakeupRepository.CreateMakeup(name, price, weight, typeID, brandID);
        }

        public static void InsertMakeupBrand(string name, int rating) {
            MakeupBrandRepository.CreateMakeupBrand(name, rating);
        }

        public static void InsertMakeupType(string name) {
            MakeupTypeRepository.CreateMakeupType(name);
        }
    }
}