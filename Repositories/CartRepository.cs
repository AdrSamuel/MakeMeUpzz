using MakeMeUpzz.Factories;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories {
    public class CartRepository {

        private static MakeMeUpzzDatabaseEntities _instance = DatabaseSingleton.GetInstance();

        public static void CreateCart(int userID, int makeupID, int quantity) {

            int id = _instance.Carts.Any() ? GetHighestCartID() + 1 : 1;

            Cart cart = CartFactory.Create(id, userID, makeupID, quantity);
            _instance.Carts.Add(cart);
            _instance.SaveChanges();

        }

        public static void ClearCart(int userID) {

            var userCarts = _instance.Carts.Where(c => c.UserID == userID);

            _instance.Carts.RemoveRange(userCarts);

            _instance.SaveChanges();

        }

        public static List<CartDTO> GetCart(int userID) {
            return (from cart in _instance.Carts
                    join makeup in _instance.Makeups on cart.MakeupID equals makeup.MakeupID
                    where cart.UserID == userID
                    group cart by new { makeup.MakeupName, cart.MakeupID } into g
                    select new CartDTO {
                        MakeupID = g.Key.MakeupID,
                        MakeupName = g.Key.MakeupName,
                        Quantity = g.Sum(x => x.Quantity)
                    }).ToList();
        }

        private static int GetHighestCartID() {
            return _instance.Carts.Max(x => x.CartID);
        }

    }
}