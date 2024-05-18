using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Master {
    public partial class Header: System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            AdminNavbar.Visible = false;
        }

        protected void OrderMakeupLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/CustomerViews/OrderMakeupPage.aspx");
        }

        protected void HistoryLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/CustomerViews/TranHistoryPage.aspx");
        }

        protected void HomeLabel_Click(object sender, EventArgs e) {
            Response.Redirect("HomePage.aspx");
        }

        protected void ManageMakeupLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/ManageMakeupPage.aspx");
        }

        protected void OrderQueueLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/.aspx");
        }

        protected void TransactionReportLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/AdminViews/TranReportPage.aspx");
        }

        protected void ProfileLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/ProfilePage.aspx");
        }

        protected void LogoutLabel_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/LogoutPage.aspx");
        }
    }
}