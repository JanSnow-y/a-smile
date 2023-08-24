using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Heart {
    }

    public partial class EntityFactory {
        public static Heart Heart() {
            return new Heart();
        }
    }
}
