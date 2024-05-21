using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MakeMeUpzz.Repositories;

namespace MakeMeUpzz.Repositories {
    public class MakeupRepository {

        private static MakeMeUpzzDatabaseEntities _instance = DatabaseSingleton.GetInstance();

       /* public static List<Makeup> GetAllMakeup() {
            return (from x in _instance.Makeups select x).ToList();
        }*/

        public static List<Makeup> GetAllMakeup() {
            return _instance.Makeups.Include("MakeupType").Include("MakeupBrand").ToList();
        }
    }
}