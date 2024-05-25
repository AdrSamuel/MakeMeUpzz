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
    public partial class UpdateMakeupPage: System.Web.UI.Page {
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

                if (!IsPostBack) {

                    int makeupID = Convert.ToInt32(Request["id"]);
                    Makeup makeup = HandlerMakeup.GetMakeupByID(makeupID);

                    MakeupNameBox.Text = makeup.MakeupName;
                    MakeupPriceBox.Text = Convert.ToString(makeup.MakeupPrice);
                    MakeupWeightBox.Text = Convert.ToString(makeup.MakeupWeight);
                    MakeupTypeIDBox.Text = Convert.ToString(makeup.MakeupTypeID);
                    MakeupBrandIDBox.Text = Convert.ToString(makeup.MakeupBrandID);

                }

            }
        }
        protected void BackButton_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/ManageMakeupPage.aspx");
        }

        protected void UpdateButton_Click(object sender, EventArgs e) {

            var id = Convert.ToInt32(Request["id"]);
            var name = MakeupNameBox.Text;
            var price = MakeupPriceBox.Text;
            var weight = MakeupWeightBox.Text;
            var typeID = MakeupTypeIDBox.Text;
            var brandID = MakeupBrandIDBox.Text;

            ErrorLabel.Text = MakeupController.CheckMakeup(name, price, weight, typeID, brandID);

            if (ErrorLabel.Text.Equals("")) {

                HandlerMakeup.UpdateMakeup(id, name, Convert.ToInt32(price), Convert.ToInt32(weight),
                    Convert.ToInt32(typeID), Convert.ToInt32(brandID));

                ErrorLabel.Text = "Update Success";

            }
        }
    }
}