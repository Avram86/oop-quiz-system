using OopQuizSystem.Gui.Factories;
using OopQuizSystem.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopQuizSystem
{
    public class ConsoleGraphicalInterface : GraphicalInterface
    {
        public override GraphicalInterfaceQuestionRendererFactory[] QuestionRendererFactories
        {
            get 
            {
                return new GraphicalInterfaceQuestionRendererFactory[]
                {
                    new SingleSelectionQuestionRendererFactory(),
                    new MultipleSelectionQuestionRendererFactory()
                };
            }
        }

        public override void RenderQuizScore(Quiz quiz)
        {
            Console.WriteLine($"Your score is: '{quiz.Score}'");
        }

        public override void RenderQuizStart(QuizRespondent respondent)
        {
            Console.WriteLine($"Hello '{respondent.Name}', please answer the following questions: ");
        }
    }
}

