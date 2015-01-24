using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerizedNeuroCognitiveBattery
{
    public class TextComboBoxedQuestion : Question
    {
        public TextComboBoxedQuestion(List<string> possibleAnswers, string correctAnswer)
        {
            PossibleAnswers = possibleAnswers;
            _correctAnswer = correctAnswer;
        }

        public List<string> PossibleAnswers { get; set; }

        private string _correctAnswer;

        public void Answer(string answer)
        {
            _stopwatch.Stop();

            _result = new QuestionResult() { TimePassed = _stopwatch.Elapsed };

            if (_correctAnswer == answer)
            {
                _result.Score = 1;
            }
            else
            {
                _result.Score = 0;
            }
        }

    }
}
