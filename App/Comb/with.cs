using ASmile.App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Comb {
    public partial class CompApply { 
        public static Action with(object a, object b) {
            return () => { };
        }

        public static bool with<T>() {
            return typeof(T) == typeof(You);
        }
    }
}
