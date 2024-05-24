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
    public partial class InsertMakeup: System.Web.UI.Page {
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

                if (user.UserRole.Equals("Customer")) {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }
            }
        }
        protected void BackButton_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/ManageMakeupPage.aspx");
        }

        protected void InsertButton_Click(object sender, EventArgs e) {

            var name = NameBox.Text;
            var price = PriceBox.Text;
            var weight = WeightBox.Text;
            var typeID = TypeBox.Text;
            var brandID = BrandBox.Text;

            ErrorLabel.Text = MakeupController.CheckMakeup(name, price, weight, typeID, brandID);

            if (ErrorLabel.Text.Equals("")) {
                Handler.InsertMakeup(name, Convert.ToInt32(price), Convert.ToInt32(weight),
                    Convert.ToInt32(typeID), Convert.ToInt32(brandID));
                ErrorLabel.Text = "Success";
            }
        }
    }
}