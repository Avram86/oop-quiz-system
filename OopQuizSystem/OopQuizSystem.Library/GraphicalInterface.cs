using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopQuizSystem.Library
{
    public abstract class GraphicalInterface
    {
        public abstract void RenderQuizStart(QuizRespondent respondent);

        public abstract int[] RenderQuestionAndGetResponse(Question question);

        public abstract void RenderQuizScore(Quiz quiz);
    }
}
