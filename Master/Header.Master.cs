using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Master {
    public partial class Header: System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null) {

                Response.Redirect("~/Views/LoginPage.aspx");

            } else {

                User user;

                if (Session["user"] == null) {

                    var username = Request.Cookies["user_cookie"].Value;
                    user = HandlerUser.GetUser(username);
                    Session["user"] = user;

                } else {

                    user = (User) Session["user"];

                }

                if (user.UserRole.Equals("Admin")) {

                    CustomerNavbar.Visible = false;
                    AdminNavbar.Visible = true;

                } else {

                    CustomerNavbar.Visible = true;
                    AdminNavbar.Visible = false;

                }

            }

        }

        protected void OrderMakeupLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/CustomerViews/OrderMakeupPage.aspx");
        }

        protected void HistoryLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/TransactionPage.aspx");
        }

        protected void HomeLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void ManageMakeupLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/ManageMakeupPage.aspx");
        }

        protected void OrderQueueLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/OrderQueuePage.aspx");
        }

        protected void TransactionReportLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/MakeupTransactionReportPage.aspx");
        }

        protected void ProfileLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/ProfilePage.aspx");
        }

        protected void LogoutLabel_Click(object sender, EventArgs e) {
            string[] cookies = Request.Cookies.AllKeys;
            foreach (string cookie in cookies) {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }

            Session.Remove("user");
            Response.Redirect("~/Views/LoginPage.aspx");
        }
    }
}