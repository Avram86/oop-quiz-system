using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopQuizSystem.Library
{
    public abstract class GraphicalInterfaceQuestionRenderer
    {
        public abstract void Render();
        public abstract int[] GetResponse();

    }
}
