using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Light {
        public Prism Prism = new();
    }

    public class Prism {
        public Soul aglow() {
            return EntityFactory.Divine();
        }
    }

    public partial class EntityFactory {
        public static Light Lights() {
            return new();
        }
    }
}
