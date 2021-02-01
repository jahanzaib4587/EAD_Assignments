using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Task1
{
    class Submit : ICommand
    {
        viewModel vM;
        public event EventHandler CanExecuteChanged
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
        public Submit(viewModel vM2)
        {
            this.vM = vM2;
        }
        public bool CanExecute(object parameter)
        {
            return vM.doexecute(parameter as object[]);
        }

        public void Execute(object parameter)
        {
            vM.displayResult(parameter as object[]);
        }
    }
}
