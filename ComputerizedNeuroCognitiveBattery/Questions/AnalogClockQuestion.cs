using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerizedNeuroCognitiveBattery
{
    public class AnalogClockQuestion : Question
    {
        public AnalogClockQuestion(string imageSource, Dictionary<TimeSpan, double> correctAnswers)
        {
            ImageSource = imageSource;
            _correctAnswers = correctAnswers;
        }

        public string ImageSource { get; private set; }

        Dictionary<TimeSpan, double> _correctAnswers;

        public void Answer(TimeSpan answer)
        {
            _stopwatch.Stop();

            _result = new QuestionResult() { TimePassed = _stopwatch.Elapsed };

            if (_correctAnswers.ContainsKey(answer))
            {
                _result.Score = _correctAnswers[answer];
            }
            else
            {
                _result.Score = 0;
            }
        }
    
    }
}
