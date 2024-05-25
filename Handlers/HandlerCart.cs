using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handlers {
    public class HandlerCart {

        public static void AddToCart(int userID, int makeupID, int quantity) {
            CartRepository.CreateCart(userID, makeupID, quantity);
        }

        public static List<CartDTO> GetCart(int userID) {
            return CartRepository.GetCart(userID);
        }

        public static void ClearCart(int userID) {
            CartRepository.ClearCart(userID);
        }

    }
}