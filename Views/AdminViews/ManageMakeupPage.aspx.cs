using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views.AdminViews {
    public partial class ManageMakeupPage: System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null) {

                Response.Redirect("LoginPage.aspx");

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

                if (!IsPostBack) {

                    MakeupGV.DataSource = Handler.GetAllMakeup();
                    MakeupGV.DataBind();

                    MakeupTypeGV.DataSource = Handler.GetAllMakeupType();
                    MakeupTypeGV.DataBind();

                    MakeupBrandGV.DataSource = Handler.GetAllMakeupBrand();
                    MakeupBrandGV.DataBind();
                }

            }
        }

        protected void InsertMakeupButton_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/InsertMakeup.aspx");
        }

        protected void InsertMakeupTypeButton_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/InsertMakeupType.aspx");
        }

        protected void InsertMakeupBrandButton_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/InsertMakeupBrand.aspx");
        }
    }
}