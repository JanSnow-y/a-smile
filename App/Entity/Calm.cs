using ASmile.App.Adj.Apply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Calm : Apply {
        public List<string> OrderedModifiers { get; set; } = new();
    }

    public partial class EntityFactory {
        public static Calm Calm() {
            return new Calm();
        }
    }
}
