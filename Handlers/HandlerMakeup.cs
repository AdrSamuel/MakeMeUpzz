using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handlers {
    public class HandlerMakeup {

        public static List<Makeup> GetAllMakeup() {
            return MakeupRepository.GetAllMakeup();
        }

        public static void InsertMakeup(string name, int price, int weight, int typeID, int brandID) {
            MakeupRepository.CreateMakeup(name, price, weight, typeID, brandID);
        }

        public static Makeup GetMakeupByID(int id) {
            return MakeupRepository.GetMakeupByID(id);
        }

        public static void UpdateMakeup(int id, string name, int price,
            int weight, int typeID, int brandID) {
            MakeupRepository.UpdateMakeup(id, name, price, weight, typeID, brandID);
        }

        public static void DeleteMakeup(int id) {
            MakeupRepository.DeleteMakeup(id);
        }

    }
}