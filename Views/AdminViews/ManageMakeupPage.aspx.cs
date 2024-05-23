using MakeMeUpzz.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views.AdminViews {
    public partial class ManageMakeupPage: System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            if(!IsPostBack) {

                MakeupGV.DataSource = Handler.GetAllMakeup();
                MakeupGV.DataBind();

                MakeupTypeGV.DataSource = Handler.GetAllMakeupType();
                MakeupTypeGV.DataBind();

                MakeupBrandGV.DataSource = Handler.GetAllMakeupBrand();
                MakeupBrandGV.DataBind();
            }

        }
    }
}