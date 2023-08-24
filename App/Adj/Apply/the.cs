using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Adj.Apply {
    public partial class AdjApply {
        public static TCreation the<TAddj, TCreation>(Action<TCreation>? consumer = null) where TCreation:Apply,new() {
            var inst = new TCreation();
            Type baseType = typeof(TAddj);
            List<string> mods = new() { nameof(TCreation), baseType.Name };
            while (baseType.IsGenericType) { 
                baseType = baseType.GenericTypeArguments[0];
                mods.Add(baseType.Name);
            }
            inst.OrderedModifiers = mods;
            if (consumer is not null) consumer(inst);
            return inst;
        }
    }

    public interface the<T> { }
}
