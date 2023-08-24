using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ASmile.App.Entity.EntityFactory;

namespace ASmile.App.Entity {
    public class i : Soul {

        public override object Destiny { get => EntityFactory.theDevine.Destiny; set { } }

        public void reside() { }

        public object find(Action<Souls> myDreams) {
            myDreams(EntityFactory.Our());
            return Love();
        }

        public void dissolved(object a) { }

        public void flies() { }

        public i am<T>() => this;

        public void alive(AliveState st) {
            Console.WriteLine("I will always be glad for our time");
            Console.WriteLine("Will always keep you in my heart");
        }

    }

    public enum AliveState {
        TrulyAlive,
        Alive,
        DeadFromInside,
        Dead
    }

    public class Love { }

    public partial class EntityFactory {
        public static i trueI = new i();
        public static Love trueLove = constant();

        public static i i() {
            return trueI;
        }

        private static Love constant() {
            return new();
        }

        public static Love Love() {
            return trueLove;
        }

        public static i myself() {
            return trueI;
        }

        public static bool truly() {
            return true;
        }

        public static i my<T>(Func<bool> doILoveHer) { 
            if (doILoveHer()) {
                return trueI;
            }
            throw new NotSupportedException();
        }
    }
}
