using MakeMeUpzz.Factories;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories {
    public class TranDetailRepository {
        private static MakeMeUpzzDatabaseEntities _instance = DatabaseSingleton.GetInstance();

        public static void CreateTranDetail(int userID, int tranID) {
            List<CartDTO> cart = CartRepository.GetCart(userID);

            foreach (CartDTO item in cart) {
                TransactionDetail transactionDetail = new TransactionDetail {
                    TransactionID = tranID,
                    MakeupID = item.MakeupID,
                    Quantity = item.Quantity
                };

                _instance.TransactionDetails.Add(transactionDetail);

                _instance.SaveChanges();
            }
        }

        public static List<TransactionDetail> GetTransactionDetail(int tranID) {
            return _instance.TransactionDetails.Where(td => td.TransactionID == tranID).ToList();
        }
    }
}