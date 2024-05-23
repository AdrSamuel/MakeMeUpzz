using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories {
    public class MakeupBrandRepository {
        private static MakeMeUpzzDatabaseEntities _instance = DatabaseSingleton.GetInstance();

        internal static List<MakeupBrand> GetAllMakeupBrand() {
            return (from x in _instance.MakeupBrands select x).ToList();
        }
    }
}