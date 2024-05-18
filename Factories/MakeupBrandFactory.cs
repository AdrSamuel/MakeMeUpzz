using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factories {
    public class MakeupBrandFactory {
        public static MakeupBrand Create(int id, string name, int rating) {

            MakeupBrand makeupBrand = new MakeupBrand() {
                MakeupBrandID = id,
                MakeupBrandName = name,
                MakeupBrandRating = rating
            };

            return makeupBrand;
        }
    }
}