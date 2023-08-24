using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Earth {
    }

    public class Earths { 
    }

    public partial class EntityFactory {
        public static Earth Earth() {
            return new Earth();
        }

        public static Earths Earths() {
            return new Earths();
        }
    }
}
