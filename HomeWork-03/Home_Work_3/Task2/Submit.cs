using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Task2
{
    class Submit : ICommand
    {
        protected viewModel vM;
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
            /*if(parameter!=null)
            {
                return vM.doExecute(parameter as object[]);
            }
            else
            {
               return false;
            }*/
            return true;
        }

        public void Execute(object parameter)
        {
            vM.displayResult(parameter as object[]);
        }
    }
}
