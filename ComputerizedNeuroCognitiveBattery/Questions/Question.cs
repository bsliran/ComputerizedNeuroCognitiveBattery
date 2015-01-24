using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerizedNeuroCognitiveBattery
{
    public abstract class Question
    {
        protected Stopwatch _stopwatch;
        protected QuestionResult _result;

        public void StartStopwatch()
        {
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
        }

        public QuestionResult Result { get; set; }

        public string Instructions { get; set; }
    }
}
