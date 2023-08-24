using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Adj.Apply {
    public partial class AdjApply {

        public static T myVery<T>() where T : Apply, new() {
            var inst = new T();
            inst.OrderedModifiers = new() { nameof(shadowed) };
            return inst;
        }

    }
}
