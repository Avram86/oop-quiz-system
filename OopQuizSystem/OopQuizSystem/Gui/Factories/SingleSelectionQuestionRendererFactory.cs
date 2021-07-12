using OopQuizSystem.Gui.Render;
using OopQuizSystem.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopQuizSystem.Gui.Factories
{
    public class SingleSelectionQuestionRendererFactory : GraphicalInterfaceQuestionRendererFactory
    {
        public override GraphicalInterfaceQuestionRenderer Create(Question question)
        {
            if(question is SingleSelectionQuestion singleSelectionQuestion)
            {
                return new SingleSelectionQuestionRenderer(singleSelectionQuestion);
            }

            return null;
        }
    }
}
