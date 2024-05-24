using MakeMeUpzz.Factories;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories {
    public class MakeupTypeRepository {
        private static MakeMeUpzzDatabaseEntities _instance = DatabaseSingleton.GetInstance();

        public static void CreateMakeupType(string name) {

            int id = _instance.MakeupTypes.Any() ? GetHighestID() + 1 : 1;
            MakeupType makeupType = MakeupTypeFactory.Create(id, name);
            _instance.MakeupTypes.Add(makeupType);
            _instance.SaveChanges();

        }

        private static int GetHighestID() {
            return _instance.MakeupTypes.Max(x => x.MakeUpTypeID);
        }

        internal static List<MakeupType> GetAllMakeupType() {
            return (from x in _instance.MakeupTypes select x).ToList();
        }
    }
}