using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class TheOnlyGalaxyForMeIsYou {
        public TheOnlyGalaxyForMeIsYou(Souls heavenWithYou) { }

        public void entwined() { }
    }

    public partial class EntityFactory { 
        public static TheOnlyGalaxyForMeIsYou Galaxies(Souls we) {
            return new(we);
        }
    }
}
