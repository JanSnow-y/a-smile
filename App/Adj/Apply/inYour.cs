using ASmile.App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Adj.Apply {
    public partial class AdjApply {

        public static object inYour<T>() {
            return EntityFactory.Angel();
        }
        public static void inYour<T>(Action goal) {
            goal();
        }
    }
}
