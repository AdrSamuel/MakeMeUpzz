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
    public partial class InsertMakeupType: System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null) {

                Response.Redirect("~/Views/LoginPage.aspx");

            } else {

                User user;

                if (Session["user"] == null) {

                    var username = Request.Cookies["user_cookie"].Value;
                    user = UserController.GetUser(username);
                    Session["user"] = user;

                } else {

                    user = (User) Session["user"];

                }

                if (user.UserRole.Equals("Customer")) {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }
            }
        }

        protected void InsertButton_Click(object sender, EventArgs e) {

            var name = TypeNameBox.Text;

            ErrorLabel.Text = MakeupController.CheckMakeupType(name);

            if (ErrorLabel.Text.Equals("")) {
                MakeupTypeController.InsertMakeupType(name);
                ErrorLabel.Text = "Success";
            }
        }

        protected void BackButton_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/ManageMakeupPage.aspx");
            ErrorLabel.Text = "Success";
        }
    }
}