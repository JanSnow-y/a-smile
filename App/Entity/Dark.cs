using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Dark {
    }

    public partial class EntityFactory {
        public static Dark Dark() {
            return new Dark();
        }
    }
}
