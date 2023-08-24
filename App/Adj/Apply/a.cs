using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Adj.Apply {
    public partial class AdjApply {

        public static aWrapper a<T>() {
            Type baseType = typeof(T);
            List<string> mods = new() { nameof(gentle), baseType.Name };
            while (baseType.IsGenericType) {
                baseType = baseType.GenericTypeArguments[0];
                mods.Add(baseType.Name);
            }
            var inst = (Activator.CreateInstance(baseType) as Apply)!;
            inst.OrderedModifiers = mods;
            return new aWrapper(inst);
        }

        public static object a<T>(Apply inst) {
            Type baseType = typeof(T);
            List<string> mods = new() { nameof(gentle), baseType.Name };
            while (baseType.IsGenericType) {
                baseType = baseType.GenericTypeArguments[0];
                mods.Add(baseType.Name);
            }
            inst.OrderedModifiers = mods;
            return inst;
        }

        public static object a<T, TApp>() where TApp : Apply,new() {
            Type baseType = typeof(T);
            List<string> mods = new() { nameof(gentle), baseType.Name };
            while (baseType.IsGenericType) {
                baseType = baseType.GenericTypeArguments[0];
                mods.Add(baseType.Name);
            }
            var inst = new TApp();
            inst.OrderedModifiers = mods;
            return inst;
        }

    }

    public class aWrapper {

        public object inst;

        public aWrapper(object inst) {
            this.inst = inst;
        }

        public aWrapper of(object a) { 
            return this;
        }

        public aWrapper Where(object a) {
            return this;
        }

        public aWrapper fleeting<T>() {
            return this;
        }

        public void blooms() {
            Console.WriteLine("One so beautiful that I felt like inside an art museum");
        }

        public void to(object a) { }

    }
}
