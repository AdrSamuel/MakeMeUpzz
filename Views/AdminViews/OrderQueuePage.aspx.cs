using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views.AdminViews {
    public partial class OrderQueuePage: System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

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

                if (!IsPostBack) {

                    UnhandledGV.DataSource = Handler.GetUnhandledTransaction();
                    UnhandledGV.DataBind();

                    HandledGV.DataSource = Handler.GetHandledTransaction();
                    HandledGV.DataBind();
                }

            }
        }

        protected void HandleButton_Click(object sender, EventArgs e) {

            Button btn = (Button) sender;
            GridViewRow row = (GridViewRow) btn.NamingContainer;
            int transactionID = Convert.ToInt32(row.Cells[0].Text);

            Handler.HandleTransaction(transactionID);

            Response.Redirect("OrderQueuePage.aspx");
        }

        protected void HistoryButton_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/TransactionPage.aspx");
        }
    }
}