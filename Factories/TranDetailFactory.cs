using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factories {
    public class TranDetailFactory {
        public static TransactionDetail Create(int tranID, int makeupID, int quan) {

            TransactionDetail transactionDetail = new TransactionDetail() {
                TransactionID = tranID,
                MakeupID = makeupID,
                Quantity = quan
            };

            return transactionDetail;
        }
    }
}