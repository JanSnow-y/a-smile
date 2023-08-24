using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Shade {
        public void entwine() { 
        }
    }

    public partial class EntityFactory {
        public static Shade Shade() {
            return new Shade();
        }
        public static Shade Shades() {
            return new Shade();
        }
    }
}
