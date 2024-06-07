using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controllers {
    public class MakeupBrandController {

        public static List<MakeupBrand> GetAllMakeupBrand() {
            return HandlerMakeupBrand.GetAllMakeupBrand();
        }

        public static void InsertMakeupBrand(string name, int rating) {
            HandlerMakeupBrand.InsertMakeupBrand(name, rating);
        }

        public static MakeupBrand GetMakeupBrandByID(int id) {
            return HandlerMakeupBrand.GetMakeupBrandByID(id);
        }

        public static void UpdateMakeupBrand(int id, string name, int rating) {
            HandlerMakeupBrand.UpdateMakeupBrand(id, name, rating);
        }

        public static void DeleteMakeupBrand(int id) {
            HandlerMakeupBrand.DeleteMakeupBrand(id);
        }

    }
}