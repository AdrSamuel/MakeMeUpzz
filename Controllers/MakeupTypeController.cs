using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controllers {
    public class MakeupTypeController {

        public static MakeupType GetMakeupTypeByID(int id) {
            return HandlerMakeupType.GetMakeupTypeByID(id);
        }

        public static List<MakeupType> GetAllMakeupType() {
            return HandlerMakeupType.GetAllMakeupType();
        }

        public static void InsertMakeupType(string name) {
            HandlerMakeupType.InsertMakeupType(name);
        }

        public static void UpdateMakeupType(int id, string name) {
            HandlerMakeupType.UpdateMakeupType(id, name);
        }

        public static void DeleteMakeupType(int id) {
            HandlerMakeupType.DeleteMakeupType(id);
        }
    }
}