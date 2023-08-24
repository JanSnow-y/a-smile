using ASmile.App.Adj.Apply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Invitation : Apply {
        public List<string> OrderedModifiers { get; set; } = new();
    }

    public partial class EntityFactory {
        public static Invitation Invitation() {
            return new Invitation();
        }
    }
}
