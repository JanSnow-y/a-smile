using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Heaven {
    }

    public partial class EntityFactory {
        public static Heaven OurHeaven() {
            return new Heaven();
        }
    }
}