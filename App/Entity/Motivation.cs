using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Motivation {
        public void surges() { }
    }

    public partial class EntityFactory {
        public static Motivation Motivation() {
            return new();
        }
    }
}
