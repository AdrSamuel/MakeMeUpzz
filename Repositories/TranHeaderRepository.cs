using MakeMeUpzz.Factories;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories {
    public class TranHeaderRepository {
        private static MakeMeUpzzDatabaseEntities _instance = DatabaseSingleton.GetInstance();

        public static int CreateTran(int userID) {

            int id = _instance.TransactionHeaders.Any() ? GetHighestID() + 1 : 1;

            TransactionHeader transactionHeader = TranHeaderFactory.Create(id, userID);

            _instance.TransactionHeaders.Add(transactionHeader);
            _instance.SaveChanges();

            return id;
        }

        private static int GetHighestID() {
            return _instance.TransactionHeaders.Max(x => x.TransactionID);
        }

        public static List<TransactionHeader> GetAllTransaction() {
            return (from x in _instance.TransactionHeaders select x).ToList();
        }

        private static TransactionHeader GetTransactionByID(int id) {
            return (from x in _instance.TransactionHeaders where 
                    x.TransactionID == id select x).FirstOrDefault();
        }

        public static void HandleTransaction(int transactionID) {

            TransactionHeader transactionHeader = GetTransactionByID(transactionID);

            transactionHeader.Status = "Handled";

            _instance.SaveChanges();
        }

        public static List<TransactionHeader> GetUserTransactions(int userID) {
            return (from x in _instance.TransactionHeaders where x.UserID == userID select x).ToList();
        }

        public static TransactionHeader GetUserTransactionsByID(int tranID) {
            return (from x in _instance.TransactionHeaders where x.TransactionID == tranID select x).FirstOrDefault();
        }

        internal static List<TransactionHeader> GetUnhandledTransaction() {
            return (from x in _instance.TransactionHeaders where x.Status.Equals("Unhandled") select x).ToList();
        }

        internal static List<TransactionHeader> GetHandledTransaction() {
            return (from x in _instance.TransactionHeaders where x.Status.Equals("Handled") select x).ToList();
        }
    }
}