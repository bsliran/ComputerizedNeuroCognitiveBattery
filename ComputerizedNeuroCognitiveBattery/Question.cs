using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerizedNeuroCognitiveBattery
{
    abstract class Question
    {
        private Stopwatch _stopwatch;
        private QuestionResult _result;
        //private Dictionary<T, double> _correctAnswers;

       /* public void Answer(T answer)
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
        */

        public void StartStopwatch()
        {
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
        }

        public QuestionResult Result { get; set; }
        
        
    }
}
