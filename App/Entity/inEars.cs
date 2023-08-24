using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class inEars {
        public void it(Action<Ears> enjoy) {
            enjoy(new());
        }    
    }

    public class Ears {
        public void sways() { }
    }

    public partial class EntityFactory {
        public static inEars inEars() {
            return new inEars();
        }
    }
}
