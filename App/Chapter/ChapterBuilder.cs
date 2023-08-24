using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASmile.App.Chapter {
    public class ChapterBuilder {

        public static void Chapter<T>(Action chapterContent) where T:ChapterName {
            chapterContent();
        }

    }

    public interface ChapterName { }
}
