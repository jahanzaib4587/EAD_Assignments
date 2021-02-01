using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Assignment2_EAD.Commands
{
    class DelegateCmnd : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public DelegateCmnd(Action<object> e, Func<object, bool> ca)
        {
            this.execute = e;
            this.canExecute = ca;
        }
        public bool CanExecute(object parameter)
        {
            return this.canExecute(parameter as string);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter as string);
        }
    }
}
