using MakeMeUpzz.Controllers;
using MakeMeUpzz.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views {
    public partial class RegisterPage: System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void SubmitButton_Click(object sender, EventArgs e) {

            var username = UserNameBox.Text;
            var email = EmailBox.Text;
            var gender = GenderDropDownList.SelectedValue;
            var password = PasswordBox.Text;
            var confPassword = ConfPasswordBox.Text;
            var dob = Calendar.SelectedDate;

            ErrorLabel.Text = RegisterController.Register(username, email, gender, password,
                confPassword, dob);

            if (ErrorLabel.Text.Equals("")) {

                HandlerUser.Register(username, email, gender, password, dob);

                Session["user"] = HandlerUser.GetUser(username);

                Response.Redirect("HomePage.aspx");
            }
        }
    }
}