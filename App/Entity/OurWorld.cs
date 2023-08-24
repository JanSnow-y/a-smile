using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class OurWorld {
        public OurWorld(Souls owner) { }

        public void untamed() { }
    }

    public partial class EntityFactory {
        public static OurWorld Worlds(Souls owner) {
            return new OurWorld(owner);
        }
    }
}
