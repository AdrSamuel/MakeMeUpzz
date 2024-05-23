using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories {
    public class MakeupTypeRepository {
        private static MakeMeUpzzDatabaseEntities _instance = DatabaseSingleton.GetInstance();

        internal static List<MakeupType> GetAllMakeupType() {
            return (from x in _instance.MakeupTypes select x).ToList();
        }
    }
}