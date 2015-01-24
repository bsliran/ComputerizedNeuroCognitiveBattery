using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerizedNeuroCognitiveBattery
{
    public class NumericComboBoxedQuestion : Question
    {

        public NumericComboBoxedQuestion( List<int> possibleAnswers , int correctAnswer, string instructions)
        {
            PossibleAnswers = possibleAnswers;
            Instructions = instructions;
            _correctAnswer = correctAnswer;
        }

        public List<int> PossibleAnswers { get; private set; }

        private int _correctAnswer;

        public void Answer(int answer)
        {
            _stopwatch.Stop();

            _result = new QuestionResult() { TimePassed = _stopwatch.Elapsed };

            if (_correctAnswer == answer)
            {
                _result.Score = 1;
            }
            else if (_correctAnswer + 1 == answer || _correctAnswer - 1 == answer)
            {
                _result.Score = 0.5;
            }
            else
            {
                _result.Score = 0;
            }
        }
    }
}
