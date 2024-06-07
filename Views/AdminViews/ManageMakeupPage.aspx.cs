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
    public partial class ManageMakeupPage: System.Web.UI.Page {
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

                if (!IsPostBack) {

                    MakeupGV.DataSource = MakeupController.GetAllMakeup();
                    MakeupGV.DataBind();

                    MakeupTypeGV.DataSource = MakeupTypeController.GetAllMakeupType();
                    MakeupTypeGV.DataBind();

                    MakeupBrandGV.DataSource = MakeupBrandController.GetAllMakeupBrand();
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

        protected void MakeupGV_RowEditing(object sender, GridViewEditEventArgs e) {

            var row = MakeupGV.Rows[e.NewEditIndex];
            var makeupID = row.Cells[0].Text;

            Response.Redirect("~/Views/AdminViews/UpdateMakeupPage.aspx?id=" + makeupID);
        }

        protected void MakeupGV_RowDeleting(object sender, GridViewDeleteEventArgs e) {

            var row = MakeupGV.Rows[e.RowIndex];
            var makeupID = Convert.ToInt32(row.Cells[0].Text);

            MakeupController.DeleteMakeup(makeupID);
            Response.Redirect("~/Views/AdminViews/ManageMakeupPage.aspx");
        }

        protected void MakeupTypeGV_RowEditing(object sender, GridViewEditEventArgs e) {

            var row = MakeupTypeGV.Rows[e.NewEditIndex];
            var makeupTypeID = row.Cells[0].Text;

            Response.Redirect("~/Views/AdminViews/UpdateMakeupTypePage.aspx?id=" + makeupTypeID);
        }

        protected void MakeupTypeGV_RowDeleting(object sender, GridViewDeleteEventArgs e) {

            var row = MakeupTypeGV.Rows[e.RowIndex];
            var makeupTypeID = Convert.ToInt32(row.Cells[0].Text);

            MakeupTypeController.DeleteMakeupType(makeupTypeID);
            Response.Redirect("~/Views/AdminViews/ManageMakeupPage.aspx");

        }

        protected void MakeupBrandGV_RowEditing(object sender, GridViewEditEventArgs e) {

            var row = MakeupBrandGV.Rows[e.NewEditIndex];
            var makeupBrandID = row.Cells[0].Text;

            Response.Redirect("~/Views/AdminViews/UpdateMakeupBrandPage.aspx?id=" + makeupBrandID);

        }

        protected void MakeupBrandGV_RowDeleting(object sender, GridViewDeleteEventArgs e) {

            var row = MakeupBrandGV.Rows[e.RowIndex];
            var makeupBrandID = Convert.ToInt32(row.Cells[0].Text);

            MakeupBrandController.DeleteMakeupBrand(makeupBrandID);
            Response.Redirect("~/Views/AdminViews/ManageMakeupPage.aspx");

        }
    }
}