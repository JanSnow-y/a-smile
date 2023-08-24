using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Obsidian {
    }

    public partial class EntityFactory {
        public static Obsidian Obsidian() {
            return new Obsidian();
        }
    }
}
