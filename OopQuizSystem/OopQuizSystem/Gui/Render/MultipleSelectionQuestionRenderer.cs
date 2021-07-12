using OopQuizSystem.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopQuizSystem.Gui.Render
{
    public class MultipleSelectionQuestionRenderer : QuestionConsoleRenderer
    {
        public MultipleSelectionQuestionRenderer(MultipleSelectionQuestion question):base(question)
        {

        }
        public override int[] GetResponse()
        {
            while (true)
            {
                Console.Write($"Please type the index of the correct answers (numeric value between [{0}, {Question.Options.Length - 1}], use comma as a separator!");

                string answer = Console.ReadLine();

                bool allIndicesAreValid = true;

                //convert answer in string array
                string[] answerParts = answer.Split(",", StringSplitOptions.RemoveEmptyEntries);


                foreach (string anserPart in answerParts)
                {
                    if (int.TryParse(anserPart, out int index))
                    {
                        if (index >= 0 && index < Question.Options.Length)
                        {
                            //index e valid
                        }
                        else
                        {
                            Console.WriteLine($"Index was outside of the bounds of the options, you must type a numeric value between [{0}, {Question.Options.Length - 1}]");

                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Value '{answer}' is not a number, you must type a numeric value between [{0}, {Question.Options.Length - 1}]");
                        allIndicesAreValid = false;
                        break;
                    }


                    if (allIndicesAreValid)
                    {
                        int[] indices = new int[answerParts.Length];
                        for (int i = 0; i < answerParts.Length; i++)
                        {
                            indices[i] = int.Parse(answerParts[i]);
                        }

                    }
                }




            }
        }
    }
}
