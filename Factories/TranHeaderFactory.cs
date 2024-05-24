using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factories {
    public class TranHeaderFactory {

        public static TransactionHeader Create(int id, int userID) {

            TransactionHeader transactionHeader = new TransactionHeader() {
                TransactionID = id,
                UserID = userID,
                TransactionDate = DateTime.Now,
                Status = "Unhandled"
            };

            return transactionHeader;
        }
    }
}