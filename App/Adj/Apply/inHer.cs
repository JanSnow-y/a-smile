using ASmile.App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Adj.Apply {


    public partial class AdjApply {
        public static in_HerWrapper _inHer<T>() {
            return new();
        }
    }

    public class in_HerWrapper {

        public Soul divine() {
            return EntityFactory.Divine();
        }

    }
}
