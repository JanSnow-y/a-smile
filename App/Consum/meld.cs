using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.consume {
    public partial class consumeApply { 
        public static void meld(Action consume) {
            consume();
        } 
    }
}
