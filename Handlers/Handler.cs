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

        public static Makeup GetMakeupByID(int id) {
            return MakeupRepository.GetMakeupByID(id);
        }
        public static MakeupBrand GetMakeupBrandByID(int id) {
            return MakeupBrandRepository.GetMakeupBrandByID(id);
        }
        public static MakeupType GetMakeupTypeByID(int id) {
            return MakeupTypeRepository.GetMakeupTypeByID(id);
        }

        public static void UpdateMakeup(int id, string name, int price,
            int weight, int typeID, int brandID) {
            MakeupRepository.UpdateMakeup(id, name, price, weight, typeID, brandID);
        }

        public static void UpdateMakeupBrand(int id, string name, int rating) {
            MakeupBrandRepository.UpdateMakeupBrand(id, name, rating);
        }

        public static void UpdateMakeupType(int id, string name) {
            MakeupTypeRepository.UpdateMakeupType(id, name);
        }

        public static void DeleteMakeup(int id) {
            MakeupRepository.DeleteMakeup(id);        
        }
        public static void DeleteMakeupType(int id) {
            MakeupTypeRepository.DeleteMakeupType(id);
        }
        public static void DeleteMakeupBrand(int id) {
            MakeupBrandRepository.DeleteMakeupBrand(id);
        }

        public static void CreateTransaction(int userID) {

            int tranID = TranHeaderRepository.CreateTran(userID);

            TranDetailRepository.CreateTranDetail(userID, tranID);

            CartRepository.ClearCart(userID);

        }

        public static List<TransactionHeader> GetAllTransaction() {
            return TranHeaderRepository.GetAllTransaction();
        }

        internal static void HandleTransaction(int transactionID) {
            TranHeaderRepository.HandleTransaction(transactionID);
        }

        public static List<TransactionHeader> GetUserTransactions(int userID) {
            return TranHeaderRepository.GetUserTransactions(userID);
        }
        public static TransactionHeader GetUserTransactionsByID(int tranID) {
            return TranHeaderRepository.GetUserTransactionsByID(tranID);
        }

        public static List<TransactionDetail> GetTransactionDetail(int id) {
            return TranDetailRepository.GetTransactionDetail(id);
        }

        internal static List<TransactionHeader> GetUnhandledTransaction() {
            return TranHeaderRepository.GetUnhandledTransaction();
        }

        internal static List<TransactionHeader> GetHandledTransaction() {
            return TranHeaderRepository.GetHandledTransaction();
        }
    }
}