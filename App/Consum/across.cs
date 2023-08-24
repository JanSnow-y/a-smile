using ASmile.App.Adj.Apply;
using ASmile.App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.consume {
    public partial class consumeApply {

        public static outerAcrossWrapper across<T>(Func<acrossWrapper, outerAcrossWrapper> consume) {
            return consume(new());
        }

    }

    public class acrossWrapper {
        public innerAcrossWrapper it = new();
    }

    public class innerAcrossWrapper {

        public outerAcrossWrapper dances() {
            return new();
        }

    }

    public class outerAcrossWrapper {

        public void revealing(object a) { }

    }
}
