using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Chapter {
    public interface Enraptured<T> : ChapterName where T:ChapterName {
    }

    public interface Reverie : ChapterName {

    }
}
