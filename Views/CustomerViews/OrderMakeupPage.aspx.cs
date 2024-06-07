using MakeMeUpzz.Controllers;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views.CustomerViews {
    public partial class OrderMakeupPage: System.Web.UI.Page {

        private static User user;
        protected void Page_Load(object sender, EventArgs e) {
           
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null) {

                Response.Redirect("~/Views/LoginPage.aspx");

            } else {

                if (Session["user"] == null) {

                    var username = Request.Cookies["user_cookie"].Value;
                    user = UserController.GetUser(username);
                    Session["user"] = user;

                } else {

                    user = (User) Session["user"];

                }

                if (user.UserRole.Equals("Admin")) {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }

                if (!IsPostBack) {


                    MakeupGV.DataSource = MakeupController.GetAllMakeup();
                    MakeupGV.DataBind();

                    CartGV.DataSource = CartController.GetCart(user.UserID);
                    CartGV.DataBind();

                    if (CartGV.Rows.Count == 0) {
                        CartStatus.Text = "Cart is empty";
                        CartButton.Visible = false;
                    }
                }

            }

        }

        protected void OrderButton_Click(object sender, EventArgs e) {

            Button btn = (Button) sender;
            GridViewRow row = (GridViewRow) btn.NamingContainer;
            TextBox QuantityBox = (TextBox) row.FindControl("QuantityBox");

            ErrorLabel.Text = OrderController.CheckQuantity(QuantityBox);

            if (ErrorLabel.Text.Equals("")) {

                int quantity = Convert.ToInt32(QuantityBox.Text);
                int userID = user.UserID;
                int makeupID = Convert.ToInt32(MakeupGV.DataKeys[row.RowIndex].Value);

                CartController.AddToCart(userID, makeupID, quantity);

                Response.Redirect("OrderMakeupPage.aspx");
            }
            
        }

        protected void CheckoutButton_Click(object sender, EventArgs e) {

            int userID = user.UserID;

            TransactionController.CreateTransaction(userID);

            Response.Redirect("OrderMakeupPage.aspx");
        }

        protected void ClearCartButton_Click(object sender, EventArgs e) {

            int userID = user.UserID;

            CartController.ClearCart(userID);

            Response.Redirect("OrderMakeupPage.aspx");
        }
    }
}