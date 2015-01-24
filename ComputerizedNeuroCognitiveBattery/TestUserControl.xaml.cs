using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComputerizedNeuroCognitiveBattery
{
    /// <summary>
    /// Interaction logic for TestUserControl.xaml
    /// </summary>
    public partial class TestUserControl : UserControl
    {
        public TestUserControl()
        {
            InitializeComponent();
        }

        public QuestionBaseUserControl QuestionContent
        {
            get { return (QuestionBaseUserControl)GetValue(QuestionContentProperty); }
            set { SetValue(QuestionContentProperty, value); }
        }

        public static readonly DependencyProperty QuestionContentProperty =
            DependencyProperty.Register("QuestionContent", typeof(QuestionBaseUserControl), typeof(TestUserControl));

    }
}
