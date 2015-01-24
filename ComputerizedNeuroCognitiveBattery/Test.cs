using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerizedNeuroCognitiveBattery
{
    public class Test
    {
        private int _userId;
        private DateTime _testTime;
        
        public IDictionary<Question, QuestionResult> Questions { get; set; }

        public Test(int userId)
        {
            _userId = userId;
            _testTime = DateTime.Now;

            InitializeQuestions();
        }

        private void InitializeQuestions()
        {
            Questions = new Dictionary<Question, QuestionResult>();
        }

        private TestResultModel GetTestResult()
        {
            throw new NotImplementedException();
        }
    }
}
