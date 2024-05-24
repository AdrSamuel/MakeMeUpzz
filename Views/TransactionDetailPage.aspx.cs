using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views {
    public partial class TransactionDetailPage: System.Web.UI.Page {

        public TransactionHeader transaction;
        public List<TransactionDetail> transactionDetail;
        protected void Page_Load(object sender, EventArgs e) {
            int tranID = Convert.ToInt32(Request.QueryString["id"]);

            transaction = Handler.GetUserTransactionsByID(tranID);
            transactionDetail = Handler.GetTransactionDetail(tranID);
        }
    }
}