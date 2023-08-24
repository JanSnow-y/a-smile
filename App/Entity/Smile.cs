using ASmile.App.Adj.Apply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class MostBeautifulSmile {
        public MostBeautifulSmile(Soul whose) { }
        public thatWrapper that<T>() {
            return new();
        }
    }

    public class __Smile : MostBeautifulSmile, Apply {
        public __Smile() : base(EntityFactory.Divine()) { }

        public List<string> OrderedModifiers { get; set; } = new();
    }

    public class thatWrapper {
        public void to(Action<Heaven> hope) {
            hope(EntityFactory.OurHeaven());
        }
    }

    public partial class EntityFactory {
        public static MostBeautifulSmile _Smile() {
            return new MostBeautifulSmile(Divine());
        }
    }
}