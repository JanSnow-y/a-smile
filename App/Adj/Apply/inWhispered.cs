using ASmile.App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Adj.Apply {


    public partial class AdjApply {
        public static void inWhispered<T>(Action<object> gettingWhisperedIn) {
            gettingWhisperedIn(new Love());
        }
    }
}
