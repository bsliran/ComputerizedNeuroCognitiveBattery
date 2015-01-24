using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerizedNeuroCognitiveBattery
{
    public class TestResultModel : INotifyPropertyChanged
    {
        private int _userId;
        private DateTime _testTime;
        private string _testTimeDescription;
        private int _totalScore;
        private int _totalTimeInSeconds;
        private IDictionary<int, QuestionResult> _QuestionResults;
        private string _questionResultsDescription;

        public int UserId 
        {
            get { return _userId; }
            set
            {
                _userId = value;
                OnPropertyChanged("UserId");
            }
        }

        public DateTime TestTime
        {
            get { return _testTime; }
            set
            {
                _testTime = value;
                TestTimeDescription = string.Format(TextResources.TestTimeTemplate, TestTime.Date, TestTime.TimeOfDay);
            }
        }

        public string TestTimeDescription
        {
            get { return _testTimeDescription; }
            set
            {
                _testTimeDescription = value;
                OnPropertyChanged("TestTimeDescription");
            }
        }
        
        public int TotalScore
        {
            get { return _totalScore; }
            set
            {
                _totalScore = value;
                OnPropertyChanged("TotalScore");
            }
        }

        public int TotalTimeInSeconds
        {
            get { return _totalTimeInSeconds; }
            set
            {
                _totalTimeInSeconds = value;
                OnPropertyChanged("TotalTimeInSeconds");
            }
        }

        public IDictionary<int, QuestionResult> QuestionResults
        {
            get { return _QuestionResults; }
            set
            {
                _QuestionResults = value;

                var orederedQuestionResults = QuestionResults.OrderBy(x => x.Key);
                var stringBuilder = new StringBuilder();

                foreach (var questionResult in orederedQuestionResults)
                {
                    stringBuilder.AppendLine(string.Format(TextResources.QuestionResultTemplate, questionResult.Key, questionResult.Value.TimePassed.Seconds));
                }

                QuestionResultsDescription = stringBuilder.ToString();
            }
        }

        public string QuestionResultsDescription
        {
            get { return _questionResultsDescription; }
            set
            {
                _questionResultsDescription = value;
                OnPropertyChanged("QuestionResultsDescription");
            }
        }

        public TestResultModel()
        {
            QuestionResults = new Dictionary<int, QuestionResult>();
        }

        #region INotifyPropertyChanged
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        } 

        #endregion
    }
}
