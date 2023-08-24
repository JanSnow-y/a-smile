using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Angel {
        public Angel(Soul origin) { }
    }

    public partial class EntityFactory {
        public static Angel Angel() {
            return new Angel(Divine());
        }
    }
}
