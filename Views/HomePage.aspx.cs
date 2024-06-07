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

namespace MakeMeUpzz.Views {
    public partial class HomePage: System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            ListUserContainer.Visible = false;

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null) {

                Response.Redirect("LoginPage.aspx");

            } else {

                User user;

                if (Session["user"] == null) {

                    var username = Request.Cookies["user_cookie"].Value;
                    user = UserController.GetUser(username);
                    Session["user"] = user;

                } else {

                    user = (User) Session["user"];

                }

                UserNameShow.Text = user.UserName;
                UserRoleShow.Text = user.UserRole;

                if (user.UserRole.Equals("Admin")) {
                    ListUserContainer.Visible = true;

                    if (!IsPostBack) {

                        List<User> userList = UserController.GetAllUser();

                        if (user != null) {

                            ListUserGV.DataSource = userList;
                            ListUserGV.DataBind();

                        } 
                    }
                }
            }
        }

        protected void ListUserGV_RowDeleting(object sender, GridViewDeleteEventArgs e) {

            var row = ListUserGV.Rows[e.RowIndex];
            var userID = Convert.ToInt32(row.Cells[0].Text);

            UserController.DeleteUser(userID);
            Response.Redirect("~/Views/HomePage.aspx");

        }
    }
}