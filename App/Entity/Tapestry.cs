using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Tapestry {
    }

    public partial class EntityFactory {
        public static Tapestry Tapestry() {
            return new Tapestry();
        }
    }
}
