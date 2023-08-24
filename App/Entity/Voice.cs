using ASmile.App.Chapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Voice : A<Melody> {
    }

    public partial class EntityFactory {
        public static Voice Voice() {
            return new Voice();
        }
    }
}
