using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Eyes {
        public void to(object et) { }

        public object of<T>(Func<T, object> p) where T:new() {
            return p(new T());
        }
    }

    public partial class EntityFactory {
        public static Eyes Eyes() {
            return new();
        }
    }
}