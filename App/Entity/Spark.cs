using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Spark {
    }

    public partial class EntityFactory {
        public static Spark Spark() {
            return new Spark();
        }
    }
}
