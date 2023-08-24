using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Comb {
    public partial class CompApply {
        public static void within<T1, T2>(Action consume) {
            consume();
        }
    }
}
