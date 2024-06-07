using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controllers {
    public class TransactionController {

        public static List<TransactionHeader> GetAllTransaction() {
            return HandlerTransactions.GetAllTransaction();
        }

        public static void CreateTransaction(int userID) {
            HandlerTransactions.CreateTransaction(userID);
        }

        public static void HandleTransaction(int transactionID) {
            HandlerTransactions.HandleTransaction(transactionID);
        }

        public static List<TransactionHeader> GetUserTransactions(int userID) {
            return HandlerTransactions.GetUserTransactions(userID);
        }
        public static TransactionHeader GetUserTransactionsByID(int tranID) {
            return HandlerTransactions.GetUserTransactionsByID(tranID);
        }

        public static List<TransactionDetail> GetTransactionDetail(int id) {
            return HandlerTransactions.GetTransactionDetail(id);
        }

        public static List<TransactionHeader> GetUnhandledTransaction() {
            return HandlerTransactions.GetUnhandledTransaction();
        }

        public static List<TransactionHeader> GetHandledTransaction() {
            return HandlerTransactions.GetHandledTransaction();
        }

    }
}