using MakeMeUpzz.Models;
using MakeMeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handlers {
    public class HandlerMakeupBrand {

        public static List<MakeupBrand> GetAllMakeupBrand() {
            return MakeupBrandRepository.GetAllMakeupBrand();
        }

        public static void InsertMakeupBrand(string name, int rating) {
            MakeupBrandRepository.CreateMakeupBrand(name, rating);
        }

        public static MakeupBrand GetMakeupBrandByID(int id) {
            return MakeupBrandRepository.GetMakeupBrandByID(id);
        }

        public static void UpdateMakeupBrand(int id, string name, int rating) {
            MakeupBrandRepository.UpdateMakeupBrand(id, name, rating);
        }

        public static void DeleteMakeupBrand(int id) {
            MakeupBrandRepository.DeleteMakeupBrand(id);
        }
    }
}