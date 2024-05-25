using MakeMeUpzz.Controllers;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views {
    public partial class ProfilePage: System.Web.UI.Page {

        User user;
        protected void Page_Load(object sender, EventArgs e) {

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null) {

                Response.Redirect("LoginPage.aspx");

            } else {
               
                if (Session["user"] == null) {

                    var username = Request.Cookies["user_cookie"].Value;
                    user = HandlerUser.GetUser(username);
                    Session["user"] = user;

                } else {

                    user = (User) Session["user"];

                }

                if (!IsPostBack) {

                    var username = user.UserName;
                    List<User> userList = HandlerUser.GetUserTypeList(username);

                    if (userList != null) {

                        ProfileGV.DataSource = userList;
                        ProfileGV.DataBind();

                    }

                }
            }
        }

        protected void UpdatePasswordButton_Click(object sender, EventArgs e) {

            var oldPass = OldPasswordBox.Text;
            var newPass = NewPasswordBox.Text;
            var usernameParam = user.UserName;

            ErrorLabel.Text = ProfileController.UpdatePass(oldPass, newPass);

            if (ErrorLabel.Text.Equals("")) {
                ErrorLabel.Text = HandlerUser.CheckPassword(oldPass);
            }

            if (ErrorLabel.Text.Equals("")) {
                HandlerUser.UpdatePassword(newPass, usernameParam);
            }
        }

        protected void ProfileGV_RowEditing(object sender, GridViewEditEventArgs e) {

            var row = ProfileGV.Rows[e.NewEditIndex];
            var username = row.Cells[0].Text;
            var id = HandlerUser.GetUserID(username).ToString();

            Response.Redirect("~/Views/UpdateProfilePage.aspx?id="+id);
        }
    }
}