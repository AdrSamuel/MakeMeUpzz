﻿using MakeMeUpzz.Controllers;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views {
    public partial class TransactionDetailPage: System.Web.UI.Page {

        public TransactionHeader transaction;
        public List<TransactionDetail> transactionDetail;
        protected void Page_Load(object sender, EventArgs e) {


            if (Session["user"] == null && Request.Cookies["user_cookie"] == null) {

                Response.Redirect("LoginPage.aspx");

            } else {

                User user;

                if (Session["user"] == null) {

                    var username = Request.Cookies["user_cookie"].Value;
                    user = UserController.GetUser(username);
                    Session["user"] = user;

                } else {

                    user = (User) Session["user"];

                }

                int tranID = Convert.ToInt32(Request.QueryString["id"]);

                transaction = TransactionController.GetUserTransactionsByID(tranID);
                transactionDetail = TransactionController.GetTransactionDetail(tranID);

                if (user.UserRole.Equals("Customer") && !(transaction.User.UserName.Equals(user.UserName))) {

                    Response.Redirect("~/Views/LoginPage.aspx");

                }
            }

        }
    }
}