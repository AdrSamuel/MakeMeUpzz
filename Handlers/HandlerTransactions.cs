using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handlers {
    public class HandlerTransactions {

        public static List<TransactionHeader> GetAllTransaction() {
            return TranHeaderRepository.GetAllTransaction();
        }

        public static void CreateTransaction(int userID) {

            int tranID = TranHeaderRepository.CreateTran(userID);

            TranDetailRepository.CreateTranDetail(userID, tranID);

            CartRepository.ClearCart(userID);

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