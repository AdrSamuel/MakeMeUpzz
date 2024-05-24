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

        public static Makeup GetMakeupByID(int id) {
            return _instance.Makeups.Find(id);
        }

        public static void UpdateMakeup(int id, string name, int price,
            int weight, int typeID, int brandID) {

            Makeup makeup = GetMakeupByID(id);

            makeup.MakeupName = name;
            makeup.MakeupPrice = price;
            makeup.MakeupWeight = weight;
            makeup.MakeupTypeID = typeID;
            makeup.MakeupBrandID = brandID;

            _instance.SaveChanges();
        }

        public static void DeleteMakeup(int id) {

            Makeup makeup = GetMakeupByID(id);
            
            _instance.Makeups.Remove(makeup);
            _instance.SaveChanges();
        }
    }
}