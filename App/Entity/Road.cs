using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Road {
        public void uncharted() { }
    }

    public partial class EntityFactory { 
        public static Road Road() {
            return new();
        }
    }
}
