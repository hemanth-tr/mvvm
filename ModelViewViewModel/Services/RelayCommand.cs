using System.Windows.Input;

namespace ModelViewViewModel.Services
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<object> ExecuteMethod;
        private Predicate<object> CanExecutePredicate;

        public RelayCommand(Action<object> executeMethod, Predicate<object> canExecuteMethod)
        {
            this.ExecuteMethod = executeMethod;
            this.CanExecutePredicate = canExecuteMethod;
        }

        public bool CanExecute(object? parameter)
        {
            return CanExecutePredicate(parameter);
        }

        public void Execute(object? parameter)
        {
            ExecuteMethod(parameter);
        }
    }
}
