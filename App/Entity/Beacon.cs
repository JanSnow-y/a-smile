using ASmile.App.Adj.Apply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Beacon {
    }

    public class Beacons : Apply {
        public List<string> OrderedModifiers { get; set; }
    }

    public partial class EntityFactory {
        public static Beacon Beacon() {
            return new Beacon();
        }
    }
}
