using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handlers {
    public class HandlerMakeupType {

        public static MakeupType GetMakeupTypeByID(int id) {
            return MakeupTypeRepository.GetMakeupTypeByID(id);
        }

        public static List<MakeupType> GetAllMakeupType() {
            return MakeupTypeRepository.GetAllMakeupType();
        }

        public static void InsertMakeupType(string name) {
            MakeupTypeRepository.CreateMakeupType(name);
        }

        public static void UpdateMakeupType(int id, string name) {
            MakeupTypeRepository.UpdateMakeupType(id, name);
        }

        public static void DeleteMakeupType(int id) {
            MakeupTypeRepository.DeleteMakeupType(id);
        }


    }
}