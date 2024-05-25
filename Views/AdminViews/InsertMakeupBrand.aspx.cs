using MakeMeUpzz.Controllers;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views.AdminViews {
    public partial class InsertMakeupBrand: System.Web.UI.Page {
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

                if (user.UserRole.Equals("Customer")) {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }
            }
        }

        protected void BackButton_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/ManageMakeupPage.aspx");
        }

        protected void InsertButton_Click(object sender, EventArgs e) {
            var name = BrandNameBox.Text;
            var rating = RatingBox.Text;

            ErrorLabel.Text = MakeupController.CheckMakeupBrand(name, rating);

            if (ErrorLabel.Text.Equals("")) {
                HandlerMakeupBrand.InsertMakeupBrand(name, Convert.ToInt32(rating));
                ErrorLabel.Text = "Success";
            }
        }
    }
}