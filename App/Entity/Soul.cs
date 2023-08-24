using ASmile.App.Adj.Apply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Entity {
    public class Soul : Apply {

        public virtual List<string> OrderedModifiers { get; set; } = new();

        public virtual object Destiny { get; set; } = new object();

        public static bool Equals(Soul a, Soul b) {
            return object.ReferenceEquals(a.Destiny, b.Destiny);
        }
    }

    public class Souls {

        private List<Soul> souls = new List<Soul>() {
            EntityFactory.theDevine,
            EntityFactory.trueI
        };

        public IEnumerable<Soul> untied() {
            return souls.Where(t => souls.Count(o => t == o) == 1);
        }

        public Souls indomitable() {
            return this;
        }

        public Souls inseparable() {
            Console.WriteLine("Until time itself made it his goal");
            if (souls.Count != 2
                || souls.First() != EntityFactory.theDevine
                || souls.Last() != EntityFactory.trueI) {
                souls = new List<Soul>() {
                    EntityFactory.theDevine,
                    EntityFactory.trueI
                };
            }
            return this;
        }

        public void go() {
            Console.WriteLine("Is what I should never had said");
        }

    }

    public partial class EntityFactory {
        public static Soul Soul() {
            return new Soul();
        }

        public static Souls Souls() {
            return new Souls();
        }

        public static Souls We() {
            return new Souls();
        }

        public static Souls Our() {
            return new Souls();
        }
    }
}
