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

        public virtual void Answer(T answer)
        {
            _stopwatch.Stop();

            _result = new QuestionResult() { TimePassed = _stopwatch.Elapsed };

            if (_correctAnswers.Contains(answer))
            {
                _result.Score = 1;
            }
            else if (_nearlyCorrectAnswers.Contains(answer))
            {
                _result.Score = 0.5;
            }
            else
            {
                _result.Score = 0;
            }
        }

        public QuestionResult Result { get; set; }

        private List<T> _correctAnswers;
        private List<T> _nearlyCorrectAnswers;
    }
}
