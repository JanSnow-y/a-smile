using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Touch {

        public object claims(object a) {
            return a;
        }

    }

    public partial class EntityFactory {
        public static Touch Touch() {
            return new Touch();
        }
    }
}
