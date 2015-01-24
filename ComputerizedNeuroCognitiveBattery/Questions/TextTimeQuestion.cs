using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerizedNeuroCognitiveBattery
{
    public class TextTimeQuestion : Question
    {

        public TextTimeQuestion(int correctHours, int correctMinutes, string questionText)
        {
            QuestionText = questionText;
            _correctHours = _correctHours;
            _correctMinutes = correctMinutes;
        }

        public string QuestionText { get; set; }

        private int _correctHours;

        private int _correctMinutes;

        public void Answer(int hours, int minutes)
        {
            _stopwatch.Stop();

            _result = new QuestionResult() { TimePassed = _stopwatch.Elapsed };
            if (hours == _correctHours && minutes == _correctMinutes)
            {
                _result.Score = 3;
            }
            else if (hours == _correctMinutes && minutes == _correctHours)
            {
                _result.Score = 2.5;
            }
            else if(hours > 12 && hours - 12 == _correctHours && minutes == _correctMinutes)
            {
                _result.Score = 2;
            }
            else 
            {
                _result.Score = 0;
            }
        }
    
    }
}
