using MakeMeUpzz.Factories;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories {
    public class MakeupBrandRepository {
        private static MakeMeUpzzDatabaseEntities _instance = DatabaseSingleton.GetInstance();

        public static void CreateMakeupBrand(string name, int rating) {

            int id = _instance.MakeupBrands.Any() ? GetHighestID() + 1 : 1;
            MakeupBrand makeupBrand = MakeupBrandFactory.Create(id, name, rating);
            _instance.MakeupBrands.Add(makeupBrand);
            _instance.SaveChanges();
        }

        private static int GetHighestID() {
            return _instance.MakeupBrands.Max(x => x.MakeupBrandID);
        }

        internal static List<MakeupBrand> GetAllMakeupBrand() {
            return (from x in _instance.MakeupBrands select x).ToList();
        }
    }
}