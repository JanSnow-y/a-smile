using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Expanse {
    }

    public partial class EntityFactory {
        public static Expanse Expanse() {
            return new Expanse();
        }
    }
}
