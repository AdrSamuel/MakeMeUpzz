using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factories {
    public class MakeupTypeFactory {
        public static MakeupType Create(int id, string name) {

            MakeupType type = new MakeupType() {
                MakeUpTypeID = id,
                MakeupTypeName = name
            };

            return type;
        }
    }
}