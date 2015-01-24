
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
            Question currentDayQuestion = new NumericComboBoxedQuestion(possibleDays, currentDay, TextResources.CurrentDayQuestion);

            var possibleMonths = new List<int>();
            for (int i = 1; i <= 12; i++)
            {
                possibleMonths.Add(i);
            }

            var currentMonth = DateTime.Now.Month;
            Question currentMonthQuestion = new NumericComboBoxedQuestion(possibleMonths, currentMonth, TextResources.CurrentMonthQuestion);


            var possibleYears = new List<int>();
            for (int i = 2000; i <= 2050; i++)
            {
                possibleYears.Add(i);
            }

            var currentYear = DateTime.Now.Year;
            Question currentYearQuestion = new NumericComboBoxedQuestion(possibleYears, currentMonth, TextResources.CurrentYearQuestion);




        }


    }


    private 
}
