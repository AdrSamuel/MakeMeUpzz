using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factories {
    public class CartFactory {

        public static Cart Create(int id, int userID, int makeupID, int quantity) {
            Cart cart = new Cart() {
                CartID = id,
                UserID = userID,
                MakeupID = makeupID,
                Quantity = quantity
            };

            return cart;
        }
    }
}