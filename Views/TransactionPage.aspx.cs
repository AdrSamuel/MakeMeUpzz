using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views {
    public partial class TransactionPage: System.Web.UI.Page {

        public List<TransactionHeader> allTransactions;
        public List<TransactionHeader> userTransactions;
        protected void Page_Load(object sender, EventArgs e) {

            AdminView.Visible = false;
            CustomerView.Visible = false;

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null) {

                Response.Redirect("~/Views/LoginPage.aspx");

            } else {

                User user;

                if (Session["user"] == null) {

                    var username = Request.Cookies["user_cookie"].Value;
                    user = Handler.GetUser(username);
                    Session["user"] = user;

                } else {

                    user = (User) Session["user"];

                }


                if (user.UserRole.Equals("Admin")) {

                    AdminView.Visible = true;

                } else {

                    CustomerView.Visible = true;

                }

                allTransactions = Handler.GetAllTransaction();
                userTransactions = Handler.GetUserTransactions(user.UserID);


            }

        }

    }
}
