using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerizedNeuroCognitiveBattery
{
    abstract class Question<T>
    {
        private Stopwatch _stopwatch;
        private QuestionResult _result;

        public void Answer(T answer)
        {
            _stopwatch.Stop();

            _result = new QuestionResult() { TimePassed = _stopwatch.Elapsed };

            if (_correctAnswers.Keys.Contains(answer))
            {
                _result.Score = _correctAnswers[answer];
            }
            else
            {
                _result.Score = 0;
            }
        }

        public void StartStopwatch()
        {
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
        }

        public QuestionResult Result { get; set; }

        private Dictionary<T, double> _correctAnswers;
    }
}
