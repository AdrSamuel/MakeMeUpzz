using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MakeMeUpzz.Dataset;
using MakeMeUpzz.Models;
using MakeMeUpzz.Report;
using MakeMeUpzz.Handlers;

namespace MakeMeUpzz.Views.AdminViews {
    public partial class ReportPage: System.Web.UI.Page {
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

                TranCrystalReport report = new TranCrystalReport();
                CrystalReportViewer.ReportSource = report;

                TranDataSet data = GetData(HandlerTransactions.GetAllTransaction());
                report.SetDataSource(data);

            }

        }

        private TranDataSet GetData(List<TransactionHeader> transactions) {

            TranDataSet data = new TranDataSet();

            var headerTable = data.TransactionHeaders;
            var detailTable = data.TransactionDetails;

            foreach (TransactionHeader t in transactions) {

                var headerRow = headerTable.NewRow();
                headerRow["TransactionID"] = t.TransactionID;
                headerRow["UserID"] = t.UserID;
                headerRow["TransactionDate"] = t.TransactionDate;
                headerRow["Status"] = t.Status;

                headerTable.Rows.Add(headerRow);

                foreach (TransactionDetail d in t.TransactionDetails) {

                    var dRow = detailTable.NewRow();

                    dRow["TransactionID"] = d.TransactionID;
                    dRow["MakeupID"] = d.MakeupID;
                    dRow["Quantity"] = d.Quantity;

                    detailTable.Rows.Add(dRow);

                }

            }

            return data;
        }

        protected void HomeButton_Click(object sender, EventArgs e) {
            Response.Redirect("~/Views/HomePage.aspx");
        }
    }
}