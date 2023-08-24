using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Sea {
    }

    public partial class EntityFactory {
        public static Sea Sea() {
            return new Sea();
        }
    }
}
