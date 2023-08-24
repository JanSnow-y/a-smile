using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Adj.Apply {

    public partial class AdjApply {

        private static int StepCounter = 0;
    
        public static object gentle<T>() where T : Apply {
            switch (++StepCounter) {
                case 1: Console.WriteLine("Daylight as breaks between the nights"); break;
                case 2: Console.WriteLine("Another step another cycle through meaningless days"); break;
                default: break;
            }
            
            Type baseType = typeof(T);
            List<string> mods = new() { nameof(gentle), baseType.Name };
            while (baseType.IsGenericType) {
                baseType = baseType.GenericTypeArguments[0];
                mods.Add(baseType.Name);
            }
            var inst = (Activator.CreateInstance(baseType) as Apply)!;
            inst.OrderedModifiers = mods;
            return inst;
        }

    }

}
