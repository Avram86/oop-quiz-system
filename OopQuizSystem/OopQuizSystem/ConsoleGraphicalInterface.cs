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
        public override int[] RenderQuestionAndGetResponse(Question question)
        {
            Console.WriteLine("");
            Console.WriteLine(new string('=', Console.WindowWidth - 1));
            Console.WriteLine($"{question.Text}");
            Console.WriteLine(new string('-', Console.WindowWidth - 1));
            for (int i = 0; i < question.Options.Length; i++)
            {
                Console.WriteLine($"{i}) {question.Options[i].Text}");
            }
            Console.WriteLine(new string('=', Console.WindowWidth - 1));

            switch (question.Type)
            {
                case QuestionType.SingleSelection:
                    {
                        bool isQuestionAnswered = false;
                        while (!isQuestionAnswered)
                        {
                            Console.Write($"Please type the index of the correct answer (numeric value between [{0}, {question.Options.Length - 1}], only 1 value):");
                            string answer = Console.ReadLine();
                            if (int.TryParse(answer, out int index))
                            {
                                if (index >= 0 && index < question.Options.Length)
                                {
                                    return new[] { index };
                                }
                                else
                                {
                                    Console.WriteLine($"Index was outside of the bounds of the options, you must type a numeric value between [{0}, {question.Options.Length - 1}]");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Value '{answer}' is not a number, you must type a numeric value between [{0}, {question.Options.Length - 1}]");
                            }
                        }
                    }
                    break;


                case QuestionType.MultipleSelection:
                    {
                        bool isQuestionAnswered = false;

                        while (!isQuestionAnswered)
                        {
                            Console.Write($"Please type the index of the correct answer (numeric value between [{0}, {question.Options.Length - 1}]");
                            
                            string answer = Console.ReadLine();

                            //convert answer in string array
                            string[] answerArray = answer.Split(",", StringSplitOptions.TrimEntries);
                            int[] answerArrayInt = new int[answerArray.Length];
                            int i = 0;

                            foreach(string optionAnser in answerArray)
                            {
                                if (int.TryParse(optionAnser, out int index))
                                {
                                    if (index >= 0 && index < question.Options.Length)
                                    {
                                        answerArrayInt[i] = index;
                                        i++;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Index was outside of the bounds of the options, you must type a numeric value between [{0}, {question.Options.Length - 1}]");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Value '{answer}' is not a number, you must type a numeric value between [{0}, {question.Options.Length - 1}]");
                                }
                            }
                            return answerArrayInt;
                        }
                    }
                    break;
            }

            // should never reach here, but compiler expects a return value
            return null;
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

