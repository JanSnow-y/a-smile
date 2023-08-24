using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Universe {
        public void sighs() { }
    }

    public partial class EntityFactory {
        public static Universe theUniverse() {
            return new Universe();
        }
    }
}
