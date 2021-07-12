using OopQuizSystem.Gui.Render;
using OopQuizSystem.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopQuizSystem.Gui.Factories
{
    public class MultipleSelectionQuestionRendererFactory : GraphicalInterfaceQuestionRendererFactory
    {
        public override GraphicalInterfaceQuestionRenderer Create(Question question)
        {
            if (question is MultipleSelectionQuestion multipleSelectionQuestion)
            {
                return new MultipleSelectionQuestionRenderer(multipleSelectionQuestion);
            }

            return null;
        }
    }
}
