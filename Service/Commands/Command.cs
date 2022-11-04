using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EntityFramework_Exam.Service.Commands
{
    public class Command : ICommand
    {
        readonly Action<object?> methodCommand;
        readonly Predicate<object?>? canExecute;

        event EventHandler? ICommand.CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
        public Command(Action<object?> methodCommand, Predicate<object?>? canExecute = null)
        {
            this.methodCommand = methodCommand;
            this.canExecute = canExecute;
        }
        bool ICommand.CanExecute(object? parameter)
        {
            if (canExecute is null)
            {
                return true;
            }
            else
            {
                return canExecute(parameter);
            }
        }

        void ICommand.Execute(object? parameter)
        {
            methodCommand?.Invoke(parameter);
        }
    }
}
