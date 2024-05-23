using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Controllers {
    public class OrderController {

        public static string CheckQuantity(TextBox quantity) {
            string response = "";

            if (quantity == null || string.IsNullOrEmpty(quantity.Text) || Convert.ToInt32(quantity.Text) <= 0) {
                response = "Quantity must be bigger then 0";
            }

            return response;
        }


    }
}