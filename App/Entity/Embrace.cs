using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Embrace {
    }

    public partial class EntityFactory {
        public static Embrace Embrace() {
            return new Embrace();
        }
    }
}
