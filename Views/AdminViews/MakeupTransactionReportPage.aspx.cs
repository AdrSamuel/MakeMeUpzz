using MakeMeUpzz.Controllers;
using MakeMeUpzz.Dataset;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views.AdminViews {
    public partial class MakeupTransactionReportPage: System.Web.UI.Page {
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

                TransactionReport report = new TransactionReport();
                ReportViewer.ReportSource = report;

                TransactionDataset data = GetData(TransactionController.GetAllTransaction());
                report.SetDataSource(data);

            }
        }

        private TransactionDataset GetData(List<TransactionHeader> transactions) {

            TransactionDataset data = new TransactionDataset();

            var headerTable = data.TransactionHeaders;
            var detailTable = data.TransactionDetails;

            foreach (TransactionHeader t in transactions) {

                var grandTotal = t.TransactionDetails.Sum(td => td.Quantity * td.Makeup.MakeupPrice);
                var headerRow = headerTable.NewRow();
                headerRow["TransactionID"] = t.TransactionID;
                headerRow["UserID"] = t.UserID;
                headerRow["TransactionDate"] = t.TransactionDate;
                headerRow["Status"] = t.Status;
                headerRow["GrandTotal"] = grandTotal;

                headerTable.Rows.Add(headerRow);

                foreach (TransactionDetail d in t.TransactionDetails) {

                    var subTotal = d.Quantity * d.Makeup.MakeupPrice;
                    var dRow = detailTable.NewRow();

                    dRow["TransactionID"] = d.TransactionID;
                    dRow["MakeupID"] = d.MakeupID;
                    dRow["Quantity"] = d.Quantity;
                    dRow["MakeupPrice"] = d.Makeup.MakeupPrice;
                    dRow["SubTotal"] = subTotal;

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