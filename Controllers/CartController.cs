using MakeMeUpzz.Handlers;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controllers {
    public class CartController {
        public static void AddToCart(int userID, int makeupID, int quantity) {
            HandlerCart.AddToCart(userID, makeupID, quantity);
        }

        public static List<CartDTO> GetCart(int userID) {
            return HandlerCart.GetCart(userID);
        }

        public static void ClearCart(int userID) {
            HandlerCart.ClearCart(userID);
        }

    }
}