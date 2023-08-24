using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Comb {
    public partial class CompApply {
        public static inTheWrapper inThe<T>() {
            return new();
        }
    }

    public class inTheWrapper {
        public void ofThis<T1, T2>(Action<object> a) { 
        }
    }
}
