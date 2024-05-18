using MakeMeUpzz.Controllers;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views {
    public partial class LoginPage: System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void login_btn_Click(object sender, EventArgs e) {

            var username = UserNameBox.Text;
            var password = PasswordBox.Text;
            bool remember = RememberBox.Checked;

            ErrorLabel.Text = LoginController.Login(username, password);

            if (ErrorLabel.Text.Equals("")) {

                ErrorLabel.Text = Handler.Login(username, password);

                if (ErrorLabel.Text.Equals("")) {

                    Session["user"] = Handler.GetUser(username);

                    if (remember) {

                        HttpCookie cookie = new HttpCookie("user_cookie");
                        cookie.Value = username;
                        cookie.Expires = DateTime.Now.AddHours(1);
                        Response.Cookies.Add(cookie);

                    }

                    Response.Redirect("HomePage.aspx");
                }
            }
        }
    }
}