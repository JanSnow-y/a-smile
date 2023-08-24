using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Emotions {
        public void take<T>() { }
    }

    public partial class EntityFactory { 
        public static Emotions Emotions() {
            return new Emotions();
        }
    }
}
