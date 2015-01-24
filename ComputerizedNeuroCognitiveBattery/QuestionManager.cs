
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerizedNeuroCognitiveBattery
{
    class QuestionManager
    {
        List<Question> Questions { get; set; }

        public QuestionManager()
        {

            var possibleDays = new List<int>();
            for (int i = 1; i <= 31; i++)
            {
                possibleDays.Add(i);
            }

            var currentDay = DateTime.Now.Day;
            Question currentDayQuestion = new NumericComboBoxedQuestion(possibleDays, currentDay, TextResources.DayQuestion);
        }


    }
}
