using ASmile.App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Common {
    public class LanguageWrapper {

        public static IEnumerable<object> ActiveElements { get; set; } = new List<Step>() { new Step(), new Step() };

        public static EachWrapper each<T>(Func<T, object> consumer) where T : class {
            var newSet = new List<object>();
            foreach (var element in ActiveElements) {
                newSet.Add(consumer((element as T)!)); // Pure trust
            }
            return new EachWrapper(newSet);
        }

        public static void graves(myExistence e) { 
        }

        public static bool? But() {
            return true;
        }

        public static AliveState inEvery<T>() => AliveState.TrulyAlive;

    }

    public class EachWrapper {

        public List<object> producedElements { get; set; } = new();

        public EachWrapper(List<object> producedElements) {
            this.producedElements = producedElements;
        }

        public void to(Action<object> consumer) {
            foreach (var element in producedElements) {
                consumer(element);
            }
        }

    }
}
