using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MakeMeUpzz.Repositories;
using MakeMeUpzz.Factories;

namespace MakeMeUpzz.Repositories {
    public class MakeupRepository {

        private static MakeMeUpzzDatabaseEntities _instance = DatabaseSingleton.GetInstance();

        public static void CreateMakeup(string name, int price, int weight, int typeID, int brandID) {

            int id = _instance.Makeups.Any() ? GetHighestID() + 1 : 1;
            Makeup makeup = MakeupFactory.Create(id, name, price, weight, typeID, brandID);
            _instance.Makeups.Add(makeup);
            _instance.SaveChanges();

        }
        private static int GetHighestID() {
            return _instance.Makeups.Max(x => x.MakeupID);
        }

        public static List<Makeup> GetAllMakeup() {
            return _instance.Makeups.Include("MakeupType").Include("MakeupBrand").ToList();
        }
    }
}