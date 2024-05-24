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

        public static MakeupBrand GetMakeupBrandByID(int id) {
            return _instance.MakeupBrands.Find(id);
        }

        public static void UpdateMakeupBrand(int id, string name, int rating) {

            MakeupBrand makeupBrand = GetMakeupBrandByID(id);

            makeupBrand.MakeupBrandName = name;
            makeupBrand.MakeupBrandRating = rating;

            _instance.SaveChanges();
        }

        public static void DeleteMakeupBrand(int id) {

            MakeupBrand makeupBrand = GetMakeupBrandByID(id);

            _instance.MakeupBrands.Remove(makeupBrand);
            _instance.SaveChanges();
        }
    }
}