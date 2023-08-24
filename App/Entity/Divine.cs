using ASmile.App.Adj.Apply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ASmile.App.Entity.EntityFactory;

namespace ASmile.App.Entity {
    public class Divine : Soul, Apply {
        public List<string> OrderedModifiers { get; set; } = new();

        public void a<T>(Action<Souls> combine) {
            combine(Souls());
        }
    }

    public interface Beauties {
    }

    public interface DearLove {
    }

    public interface Name { }

    public class Te : Divine, Beauties, Name, DearLove {
        public Hope bestows() {
            return new();
        }

        public Divine Presence { get => this; }
    }

    public class Hope { }

    public class You : Te { }

    public partial class EntityFactory {
        public static Te theDevine = new Te();

        public static Divine Divine() {
            return theDevine;
        }

        public static Te She() {
            return theDevine;
        }

        public static Hope Hope() {
            return new();
        }

        public static Te Your() {
            return theDevine;
        }
    }
}
