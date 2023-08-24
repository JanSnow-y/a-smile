using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Rain {
        public Touch Touch { get; set; } = new();
    }

    public partial class EntityFactory {
        public static Rain Rain() {
            return new Rain();
        }
        public static Rain Rains() {
            return new Rain();
        }
    }
}
