using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Haven {
    }

    public partial class EntityFactory {
        public static Haven Haven() {
            return new Haven();
        }
    }
}
