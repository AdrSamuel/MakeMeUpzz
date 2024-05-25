using MakeMeUpzz.Controllers;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views.AdminViews {
    public partial class UpdateMakeupBrandPage: System.Web.UI.Page {
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
                    MakeupBrand makeupBrand = HandlerMakeupBrand.GetMakeupBrandByID(makeupID);

                    BrandNameBox.Text = makeupBrand.MakeupBrandName;
                    BrandRatingBox.Text = Convert.ToString(makeupBrand.MakeupBrandRating);
                }

            }
        }

        protected void BackButton_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/ManageMakeupPage.aspx");
        }

        protected void UpdateButton_Click(object sender, EventArgs e) {

            var id = Convert.ToInt32(Request["id"]);
            var name = BrandNameBox.Text;
            var rating = BrandRatingBox.Text;

            ErrorLabel.Text = MakeupController.CheckMakeupBrand(name, rating);

            if (ErrorLabel.Text.Equals("")) {

                HandlerMakeupBrand.UpdateMakeupBrand(id, name, Convert.ToInt32(rating));

                ErrorLabel.Text = "Update Success";

            }
        }
    }
}