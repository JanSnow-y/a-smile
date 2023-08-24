using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class It {
    }

    public partial class EntityFactory {
        public static It It() {
            return new It();
        }
    }
}
