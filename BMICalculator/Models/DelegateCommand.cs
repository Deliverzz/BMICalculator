using System.Windows.Input;

namespace BMICalculator
{
    internal class DelegateCommand : ICommand
    {
        public Action<object> CommandHandler { get; set; }
    }
}