using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Night {
    }

    public class Nights { 
    }

    public partial class EntityFactory {
        public static Night Night() {
            return new Night();
        }
    }
}
