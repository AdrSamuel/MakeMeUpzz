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
    public partial class UpdateProfilePage: System.Web.UI.Page {
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

                if (!IsPostBack) {

                    int ID = Convert.ToInt32(Request["id"]);
                    User userDisplay = Handler.GetUserByID(ID);

                    UserNameBox.Text = userDisplay.UserName.ToString();
                    UserEmailBox.Text = userDisplay.UserEmail.ToString();
                    UserGenderDropDownList.DataSource = Handler.GetGenderList();
                    UserGenderDropDownList.DataBind();
                    UserGenderDropDownList.DataSource = userDisplay.UserGender;

                }
            }


        }

        protected void UpdateButton_Click(object sender, EventArgs e) {

            int id = Convert.ToInt32(Request["id"]);
            string oldUsername = Handler.GetUserNameByID(id);

            string username = UserNameBox.Text;
            string email = UserEmailBox.Text;
            string gender = UserGenderDropDownList.Text;
            DateTime dob = Calendar.SelectedDate;

            if (oldUsername.Equals(username)) {

                ErrorLabel.Text = ProfileController.UpdateProfile(email, gender, dob);

            } else {

                ErrorLabel.Text = ProfileController.UpdateProfile(username, email, gender, dob);

            }


            if (ErrorLabel.Text.Equals("")) {

                Handler.UpdateProfile(id, username, email, gender, dob);

                ErrorLabel.Text = "Update Success";

            }


        }

    }
}