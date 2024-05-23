using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories {
    public class CartDTO {
        public int UserID { get; set; }
        public int MakeupID { get; set; }
        public string MakeupName { get; set; }
        public int Quantity { get; set; }

    }
}