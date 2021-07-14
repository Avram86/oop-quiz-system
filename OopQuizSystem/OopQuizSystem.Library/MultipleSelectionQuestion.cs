using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopQuizSystem.Library
{
    public class MultipleSelectionQuestion : Question
    {
        public MultipleSelectionQuestion(
             int id,
             string text,
             Option[] options) : base(id, text, options)
        {
        }

        public override void EvaluateAnswer(int[] optionsIndices)
        {
            if (optionsIndices is null)
            {
                throw new ArgumentNullException(nameof(optionsIndices));
            }

            if (optionsIndices.Length > Options.Length)
            {
                throw new ArgumentException(
                    $"You cannot submit more responses than the number of options! The number of responses is {optionsIndices.Length}, while the number of options is {Options.Length}",
                    nameof(optionsIndices));
            }
            //1) calculate the number of correct options
            int nrOfCorrectOptions = 0;
            foreach (var option in this.Options)
            {
                if (option.IsCorrect)
                {
                    nrOfCorrectOptions++;
                }
            }
            if (nrOfCorrectOptions == 0)
            {
                if (optionsIndices.Length == 0)
                {
                    Score = 1;
                }
            }
            //we have at least one correct answer

            decimal scoreFraction = Math.Round(decimal.One / nrOfCorrectOptions,2);


            //=>optionsIndices.Length=nrOfCorrectOptions


            //2)calculate score
            if (optionsIndices.Length == nrOfCorrectOptions)
            {
                Score = 1;
            }
            else
            {
                //score/option=1/nrOfCorrectOptions

                foreach (var indexResponse in optionsIndices)
                {
                    if (indexResponse >= 0 && indexResponse < Options.Length && Options[indexResponse].IsCorrect)
                    {
                        //erro Score=0 => turn nrOfCorrectOptions from int to decimal 
                        Score += scoreFraction;
                    }
                }
            }

        }
    }

    }
