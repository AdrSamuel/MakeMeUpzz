using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repositories {
    public class DatabaseSingleton {
        /*private DatabaseSingleton() { }*/
        private static MakeMeUpzzDatabaseEntities _instance = null;

        public static MakeMeUpzzDatabaseEntities GetInstance() {
            if (_instance == null) {
                _instance = new MakeMeUpzzDatabaseEntities();
            }

            return _instance;
        }
    }
}