using ASmile.App.Adj.Apply;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Swamp {
    }

    public class Swamps : Apply {

        public List<string> OrderedModifiers { get; set; } = new();

        public Embrace Embrace { get; set; } = new();
    }

    public partial class EntityFactory {
        public static Swamp Swamp() {
            return new Swamp();
        }
    }
}
