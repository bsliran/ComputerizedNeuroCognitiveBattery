using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerizedNeuroCognitiveBattery
{
    public class ImageQuestions : Question
    {

        public ImageQuestions(string imageSource, string correctAnswer)
        {
            ImageSource = imageSource;
            _correctAnswer = correctAnswer;
        }

        public string ImageSource { get; set; }

        private string _correctAnswer;

        public void Answer(string answer)
        {
            _stopwatch.Stop();

            _result = new QuestionResult() { TimePassed = _stopwatch.Elapsed };

            if (TyposHelper.EqualsIgnoringTypos(_correctAnswer, answer))
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
